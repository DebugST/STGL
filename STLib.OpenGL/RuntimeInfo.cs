using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace STLib.OpenGL
{
    public static class RuntimeInfo
    {
        public static string Version { get; private set; }
        public static BitType Bit { get; private set; }
        public static SystemType System { get; private set; }
        public static PlatformType Platform { get; private set; }

        public enum BitType { Bit32, Bit64, Unknown }
        public enum SystemType { Windows, Mac, Linux, Unknown }
        public enum PlatformType { NT, ARM, X86_64, Unknown }

        private struct utsname
        {
            public string sysname;
            public string nodename;
            public string release;
            public string version;
            public string machine;
            public string other;

        }
        [DllImport("libc")]
        private static extern void uname(byte[] byBuffer);

        private static utsname uname() {
            /*
             * why not use uname(utsname) ??????
             * because in Mac:
             *     struct utsname{
             *         char sysname[256]
             *         ...
             *     }
             * and in Linux:
             *     struct utsname{
             *         char sysname[65]
             *         ...
             *     }
             * and even some system is [9]
             * so use byte[] and split it.
             * but some case this way have a bug, if some string is empty.
             */
            byte[] byBuffer = new byte[2048];
            RuntimeInfo.uname(byBuffer);
            int nIndex = 0; bool bFlag = false;
            List<string> lst = new List<string>();
            for (int i = 0; i < byBuffer.Length; i++) {
                if (!bFlag && byBuffer[i] != 0) {   // string start. but empty string not have start.
                    nIndex = i;
                    bFlag = true;
                }
                if (byBuffer[i] == 0 && bFlag) {    // '\0' string end.
                    lst.Add(Encoding.Default.GetString(byBuffer, nIndex, i - nIndex));
                    bFlag = false;
                }
            }
            utsname name = new utsname();
            if (lst.Count > 0) name.sysname = lst[0];
            if (lst.Count > 1) name.nodename = lst[1];
            if (lst.Count > 2) name.release = lst[2];
            if (lst.Count > 3) name.version = lst[3];
            if (lst.Count > 4) name.machine = lst[4];
            for (int i = 4; i < lst.Count; i++) {
                name.other = lst[i] + "|";
            }
            name.other = name.other.TrimEnd('|');
            return name;
        }

        static RuntimeInfo() {
            RuntimeInfo.Bit = BitType.Unknown;
            RuntimeInfo.System = SystemType.Unknown;
            RuntimeInfo.Platform = PlatformType.Unknown;
            int nWidth = IntPtr.Size;
            if (nWidth == 4) {
                RuntimeInfo.Bit = BitType.Bit32;
            } else if (nWidth == 8) {
                RuntimeInfo.Bit = BitType.Bit64;
            } else {
                RuntimeInfo.Bit = BitType.Unknown;
            }
            string strOS = Environment.OSVersion.VersionString.ToLower();
            if (strOS.IndexOf("windows") != -1) {
                RuntimeInfo.System = SystemType.Windows;
                if (strOS.IndexOf("NT") == -1) {
                    RuntimeInfo.Platform = PlatformType.NT;
                } else {
                    RuntimeInfo.Platform = PlatformType.Unknown;
                }
                RuntimeInfo.Version = strOS;
                return;
            }
            if (strOS.IndexOf("unix") != -1) {
                utsname name = RuntimeInfo.uname();
                RuntimeInfo.Version = name.version;
                switch (name.sysname.ToLower()) {
                    case "darwin":
                        RuntimeInfo.System = SystemType.Mac;
                        break;
                    case "linux":
                        RuntimeInfo.System = SystemType.Linux;
                        break;
                    default:
                        RuntimeInfo.System = SystemType.Unknown;
                        break;
                }
                switch (name.machine.ToLower()) {
                    case "x86_64":
                        RuntimeInfo.Platform = PlatformType.X86_64;
                        break;
                    case "arm64":
                        RuntimeInfo.Platform = PlatformType.ARM;
                        break;
                    default:
                        RuntimeInfo.Platform = PlatformType.Unknown;
                        break;
                }
            }
        }
    }
}
