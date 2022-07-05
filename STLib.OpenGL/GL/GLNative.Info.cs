using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace STLib.OpenGL.GL
{
    partial class GLNative  // GLNative.Info.cs
    {
        public static Information Info { get; private set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public class Information
        {
            public string Version { get; internal set; }
            public string Renderer { get; internal set; }
            public string Vendor { get; internal set; }
            public string ShadingLanguageVersion { get; internal set; }
            public int SupportedProcedures { get; internal set; }
            //public int AllProcedures { get; internal set; }
            public Extensions Extensions { get; private set; }

            private Dictionary<string, Delegate> m_dic;

            internal Information(Dictionary<string, Delegate> dic) {
                this.Extensions = new Extensions();
                m_dic = new Dictionary<string, Delegate>();
            }

            public static string[] GetSupportedProcs() {
                if (m_dic_proc == null) return null;
                string[] strs = new string[m_dic_proc.Count];
                int nIndex = 0;
                foreach (var v in m_dic_proc) {
                    strs[nIndex++] = v.Key + ": " + (v.Value != null);
                }
                return strs;
            }

            public override string ToString() {
                return
                    "Version                : " + this.Version + "\r\n" +
                    "Renderer               : " + this.Renderer + "\r\n" +
                    "Vendor                 : " + this.Vendor + "\r\n" +
                    "ShadingLanguageVersion : " + this.ShadingLanguageVersion + "\r\n" +
                    //"Procdures              : " + this.SupportedProcedures + "/" + this.AllProcedures + "\r\n" +
                    "Extendions             : " + this.Extensions.GetSupportedExtensions().Length;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public sealed class Extensions
        {
            internal Extensions() { }

            private HashSet<string> m_hs = new HashSet<string>();

            public bool this[string strName] {
                get {
                    if (m_hs.Contains(strName)) {
                        return true;
                    }
                    return false;
                }
            }

            internal void SetExtension(string strName) {
                m_hs.Add(strName);
            }

            public string[] GetSupportedExtensions() {
                return m_hs.ToArray();
            }
        }
    }
}
