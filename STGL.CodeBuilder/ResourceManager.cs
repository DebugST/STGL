using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;

namespace STLib.OpenGL.GLFW
{
    internal class ResourceManager
    {
        public struct ResInfo
        {
            public string Name;
            public byte[] File;
            public string MD5;

            public override string ToString() {
                return this.Name + "(" + this.File.Length + ")";
            }
        }

        private static MD5 m_md5;

        static ResourceManager() {
            m_md5 = MD5.Create();
        }

        public static byte[] CreateLibFiles(string strPath) {
            using (MemoryStream ms = new MemoryStream()) {
                using (GZipStream gs = new GZipStream(ms, CompressionMode.Compress)) {
                    var files = Directory.GetFiles(strPath);
                    gs.Write(BitConverter.GetBytes(files.Length), 0, 4);
                    foreach (var v in files) {
                        var strName = Path.GetFileName(v);
                        var byFile = File.ReadAllBytes(v);
                        var byName = Encoding.UTF8.GetBytes(strName);
                        gs.Write(BitConverter.GetBytes(byName.Length), 0, 4);
                        gs.Write(byName, 0, byName.Length);
                        gs.Write(BitConverter.GetBytes(byFile.Length), 0, 4);
                        gs.Write(byFile, 0, byFile.Length);
                    }
                }
                return ms.ToArray();
            }
        }

        public static ResInfo[] GetResources(byte[] byData) {
            var nLen = 0;
            var byLen = new byte[4];
            byte[] byTemp = null;
            using (MemoryStream ms = new MemoryStream(byData))
            using (GZipStream gs = new GZipStream(ms, CompressionMode.Decompress)) {
                // Note: not use gs.Read(gs, byLen, 0, byLen.Length);
                // Stream.Read() has some change on Net Core
                // https://github.com/dotnet/runtime/issues/71517
                _Read(gs, byLen, 0, byLen.Length);
                nLen = BitConverter.ToInt32(byLen, 0);
                var libs = new ResInfo[nLen];
                for (int i = 0; i < libs.Length; i++) {
                    _Read(gs, byLen, 0, byLen.Length);
                    nLen = BitConverter.ToInt32(byLen, 0);
                    byTemp = new byte[nLen];
                    _Read(gs, byTemp, 0, byTemp.Length);
                    libs[i].Name = Encoding.UTF8.GetString(byTemp);

                    _Read(gs, byLen, 0, byLen.Length);
                    nLen = BitConverter.ToInt32(byLen, 0);
                    byTemp = new byte[nLen];
                    _Read(gs, byTemp, 0, byTemp.Length);
                    libs[i].File = byTemp;
                    libs[i].MD5 = ResourceManager.GetMd5(byTemp);
                }
                return libs;
            }
        }

        public static string GetMd5(byte[] byData) {
            lock (m_md5) {
                return BitConverter.ToString(m_md5.ComputeHash(byData)).Replace("-", "").ToLower();
            }
        }

        private static int _Read(Stream s, byte[] byBuffer, int nOffset, int nLen) {
            int nTempLen = 0, nIndex = nOffset;
            while ((nTempLen = s.Read(byBuffer, nIndex, nLen)) != 0) {
                nIndex += nTempLen;
                nLen -= nTempLen;
                if (nLen == 0) break;
            }
            return nIndex - nOffset;
        }
    }
}
