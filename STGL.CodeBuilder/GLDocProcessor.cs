using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace STGL.CodeBuilder
{
    public class GLDocProcessor
    {
        private static Dictionary<string, string> m_dic_param_name = new Dictionary<string, string>(){
            {"ref","r"},
            {"in","i"},
            {"event","e"},
            {"base","b"},
            {"string","str"},
            {"params","ps"},
            {"object","obj"}
        };
        private static Dictionary<string, string> m_dic_type_name = new Dictionary<string, string>(){
            {"byte","GL.GL_UNSIGNED_BYTE"},
            {"short","GL.GL_SHORT"},
            {"ushort","GL.GL_UNSIGNED_SHORT"},
            {"int","GL.GL_INT"},
            {"uint","GL.GL_UNSIGNED_INT"},
            {"float","GL.GL_FLOAT"}
        };
        private static Dictionary<string, string> m_dic_overload_func = new Dictionary<string, string>();

        private struct ConstInfo
        {
            public string Name;
            public string Value;
            public List<string> Require;
            public List<string> Removed;
            public List<string> Supported;
            public string strGroup;
            public string Comment;

            public override string ToString() {
                return Name + " " + Value;
            }
        }

        private struct FuncInfo
        {
            public string Type;
            public string Name;
            public Dictionary<string, string> ArgDic;
            public List<string> ArgLst;
            public List<string> Require;
            public List<string> Removed;
            public List<string> Supported;
            public FuncComment Comment;
            public string Original;

            public override string ToString() {
                return Type + " " + Name + "("
                    + string.Join(", ", (from a in ArgDic select a.Value + " " + a.Key).ToArray())
                    + ");";
            }
        }

        private struct FuncComment
        {
            public string Description;
            public List<string> AlsoSee;
            public Dictionary<string, string> Params;
            public string Error;
            public string Note;
        }

        private static Dictionary<string, string> m_dic_type = new Dictionary<string, string>();
        private static HashSet<string> m_hs_processed_const = new HashSet<string>();
        private static HashSet<string> m_hs_processed_func = new HashSet<string>();
        //private static HashSet<string> m_hs_ext = new HashSet<string>();
        private static HashSet<string> m_hs_repeat_const = new HashSet<string>();
        private static Dictionary<string, ConstInfo> m_dic_const = new Dictionary<string, ConstInfo>();
        private static Dictionary<string, FuncInfo> m_dic_func = new Dictionary<string, FuncInfo>();

        private static StreamWriter m_writer_const;
        private static StreamWriter m_writer_delegate;
        private static StreamWriter m_writer_declare;
        private static StreamWriter m_writer_native_method;
        private static StreamWriter m_writer_safe_method;
        private static StreamWriter m_writer_unsafe_method;
        private static StreamWriter m_writer_overload_method;
        private static StreamWriter m_writer_init;
        private static StreamWriter m_writer_type;

        public static void Start(string strPathIn, string strPathOut) {
            Directory.CreateDirectory(strPathOut);
            var strs = File.ReadAllLines(strPathIn + "/gl.type.dic.txt");
            foreach (var s in strs) {
                var kv = s.Split(',');
                m_dic_type.Add(kv[0].Trim(), kv[1].Trim());
            }
            m_writer_const = new StreamWriter(strPathOut + "/GL.Const.cs", false, Encoding.UTF8);
            m_writer_delegate = new StreamWriter(strPathOut + "/GL.Native.Delegate.cs", false, Encoding.UTF8);
            m_writer_declare = new StreamWriter(strPathOut + "/GL.Native.Declare.cs", false, Encoding.UTF8);
            m_writer_native_method = new StreamWriter(strPathOut + "/GL.Native.Method.cs", false, Encoding.UTF8);
            m_writer_safe_method = new StreamWriter(strPathOut + "/GL.Method.safe.cs", false, Encoding.UTF8);
            m_writer_unsafe_method = new StreamWriter(strPathOut + "/GL.Method.Unsafe.cs", false, Encoding.UTF8);
            m_writer_overload_method = new StreamWriter(strPathOut + "/GL.Method.Overload.cs", false, Encoding.UTF8);
            m_writer_init = new StreamWriter(strPathOut + "/GL.Native.Init.cs", false, Encoding.UTF8);
            m_writer_type = new StreamWriter(strPathOut + "/type.txt", false, Encoding.UTF8);

            foreach (var v in Directory.GetFiles(strPathIn + "/overload", "*.txt")) {
                string strName = Path.GetFileNameWithoutExtension(v);
                m_dic_overload_func.Add(strName, File.ReadAllText(v));
            }

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(File.ReadAllText(strPathIn + "/gl.xml"));
            ProcessGLXML(xml);
            var dic_func_comment = ProcessXmlPath(new string[]{
                strPathIn + "/gl2.1",
                strPathIn + "/gl4"
            });
            foreach (var v in dic_func_comment.Values) {
                if (!m_dic_func.ContainsKey(v.Name)) {
                    continue;
                }
                var fi = m_dic_func[v.Name];
                fi.Comment = v.Comment;
                fi.ArgDic = v.ArgDic;
                fi.ArgLst = v.ArgLst;
                m_dic_func[v.Name] = fi;
            }

            HashSet<string> hs_all = new HashSet<string>();
            var keys = m_dic_func.Keys.ToArray();
            for (int i = 0; i < keys.Length; i++) {
                var fi = m_dic_func[keys[i]];
                fi.Original = fi.ToString();
                hs_all.Add(fi.Type);
                foreach (var a in fi.ArgDic) {
                    hs_all.Add(a.Value);
                }
                fi = ReplaceFuncString(fi);
                m_dic_func[keys[i]] = fi;
            }
            m_writer_type.Write(string.Join("\r\n", hs_all.ToArray()));
            foreach (var v in m_dic_type.Keys) {
                hs_all.Remove(v);
            }
            m_writer_type.WriteLine("\r\n\r\n----------not-in-dic----------\r\n");
            m_writer_type.Write(string.Join("\r\n", hs_all.ToArray()));

            OutPutConst(xml, m_dic_const);
            OutPutMethod(xml, m_dic_func);

            m_writer_const.Close();
            m_writer_declare.Close();
            m_writer_delegate.Close();
            m_writer_safe_method.Close();
            m_writer_unsafe_method.Close();
            m_writer_overload_method.Close();
            m_writer_native_method.Close();
            m_writer_type.Close();
        }

        private static void ProcessGLXML(XmlDocument xml) {
            ProcessGlXml_Enums(xml);
            ProcessGlXml_Commands(xml);
            ProcessGlXml_Feature(xml);
            ProcessGlXml_Extensions(xml);
        }

        private static void ProcessGlXml_Enums(XmlDocument xml) {
            foreach (XmlNode n in xml.GetElementsByTagName("enums")) {
                if (n.Attributes["namespace"].Value != "GL") continue;
                foreach (XmlNode v in n.ChildNodes) {
                    if (v.Name != "enum") continue;
                    ConstInfo ci = new ConstInfo();
                    ci.Require = new List<string>();
                    ci.Removed = new List<string>();
                    ci.Supported = new List<string>();
                    ci.Comment = _Attr(v, "comment");
                    ci.strGroup = _Attr(v, "group");
                    ci.Name = v.Attributes["name"].Value;
                    ci.Value = v.Attributes["value"].Value;
                    if (!m_dic_const.ContainsKey(ci.Name)) {
                        m_dic_const.Add(ci.Name, ci);
                    } else {
                        m_dic_const[ci.Name] = ci;
                        //m_hs_repeat_const.Add(ci.Name);
                    }
                }
            }
        }

        private static void ProcessGlXml_Commands(XmlDocument xml) {
            foreach (XmlNode n in xml.GetElementsByTagName("commands")) {
                if (n.Attributes["namespace"].Value != "GL") continue;
                foreach (XmlNode v in n.ChildNodes) {
                    if (v.Name != "command") continue;
                    FuncInfo fi = new FuncInfo();
                    fi.ArgDic = new Dictionary<string, string>();
                    fi.ArgLst = new List<string>();
                    fi.Require = new List<string>();
                    fi.Removed = new List<string>();
                    fi.Supported = new List<string>();
                    fi.ArgDic = new Dictionary<string, string>();
                    var f = v.SelectSingleNode("proto");
                    fi.Type = f.InnerText;
                    fi.Name = f.SelectSingleNode("name").InnerText.Trim();
                    fi.Type = fi.Type.Substring(0, fi.Type.Length - fi.Name.Length).Trim();
                    foreach (XmlNode p in v.SelectNodes("param")) {
                        string strName = p.SelectSingleNode("name").InnerText;
                        string strType = p.InnerText;
                        strType = strType.Substring(0, strType.Length - strName.Length).Trim();
                        if (strType == "void") continue;
                        strName = strName.Trim();
                        fi.ArgDic.Add(strName, strType);
                        fi.ArgLst.Add(strName);
                    }
                    m_dic_func.Add(fi.Name, fi);
                }
            }
        }

        private static void ProcessGlXml_Feature(XmlDocument xml) {
            foreach (XmlNode n in xml.GetElementsByTagName("feature")) {
                string strVer = n.Attributes["name"].Value;
                foreach (XmlNode r in n.SelectNodes("require")) {
                    foreach (XmlNode c in r.SelectNodes("enum")) {
                        var ci = m_dic_const[c.Attributes["name"].Value];
                        ci.Require.Add(strVer);
                        m_hs_processed_const.Add(ci.Name);
                    }
                    foreach (XmlNode f in r.SelectNodes("command")) {
                        var fi = m_dic_func[f.Attributes["name"].Value];
                        fi.Require.Add(strVer);
                        m_hs_processed_func.Add(fi.Name);
                    }
                }
                foreach (XmlNode r in n.SelectNodes("remove")) {
                    string strComment = _Attr(r, "comment");
                    foreach (XmlNode c in r.SelectNodes("enum")) {
                        var ci = m_dic_const[c.Attributes["name"].Value];
                        ci.Removed.Add(strComment);
                    }
                    foreach (XmlNode f in r.SelectNodes("command")) {
                        var fi = m_dic_func[f.Attributes["name"].Value];
                        fi.Removed.Add(strComment);
                    }
                }
            }
        }

        private static void ProcessGlXml_Extensions(XmlDocument xml) {
            foreach (XmlNode n in xml.GetElementsByTagName("extensions")) {
                foreach (XmlNode e in n.SelectNodes("extension")) {
                    string strExt = e.Attributes["name"].Value;
                    //m_hs_ext.Add(strExt);
                    string strSup = e.Attributes["supported"].Value;
                    foreach (XmlNode r in e.SelectNodes("require")) {
                        foreach (XmlNode c in r.SelectNodes("enum")) {
                            var ci = m_dic_const[c.Attributes["name"].Value];
                            ci.Require.Add(strExt);
                            ci.Supported.AddRange(strSup.ToUpper().Split('|'));
                            m_hs_processed_const.Add(ci.Name);
                        }
                        foreach (XmlNode f in r.SelectNodes("command")) {
                            var fi = m_dic_func[f.Attributes["name"].Value];
                            fi.Require.Add(strExt);
                            fi.Supported.AddRange(strSup.Split('|'));
                            m_hs_processed_func.Add(fi.Name);
                        }
                    }
                }
            }
        }

        private static Dictionary<string, FuncInfo> ProcessXmlPath(string[] strPaths) {
            Regex reg_file = new Regex(@"^gl[A-Z]");
            Dictionary<string, FuncInfo> dic = new Dictionary<string, FuncInfo>();
            foreach (var p in strPaths) {
                foreach (var v in Directory.GetFiles(p)) {
                    var strF = Path.GetFileNameWithoutExtension(v);
                    if (!reg_file.IsMatch(strF)) continue;
                    if (strF.StartsWith("glX")) continue;
                    string strText = File.ReadAllText(v, Encoding.UTF8);
                    FuncInfo[] fis = GetFunc(strText);
                    foreach (var f in fis) {
                        if (dic.ContainsKey(f.Name)) continue;
                        dic.Add(f.Name, f);
                    }
                }
            }
            return dic;
        }

        private static FuncInfo[] GetFunc(string strText) {
            List<FuncInfo> lst_ret = new List<FuncInfo>();

            Regex reg_desc = new Regex(@"<refpurpose>(.*?)</refpurpose>", RegexOptions.Singleline);
            var strDesc = _ReplaceText(reg_desc.Match(strText).Groups[1].Value);
            Regex reg_notes = new Regex(@"<refsect1 id=""notes"">.*?</title>(.*?)</refsect1>", RegexOptions.Singleline);
            var strNotes = _ReplaceText(reg_notes.Match(strText).Groups[1].Value);
            Regex reg_errors = new Regex(@"<refsect1 id=""errors"">.*?</title>(.*?)</refsect1>", RegexOptions.Singleline);
            var strErrors = _ReplaceText(reg_errors.Match(strText).Groups[1].Value);
            Regex reg_also = new Regex(@"<refsect1 id=""seealso"">.*?</title>(.*?)</refsect1>", RegexOptions.Singleline);
            var strAlso = reg_also.Match(strText).Groups[1].Value;
            var lst_also = new List<string>();
            foreach (Match m in Regex.Matches(strAlso, @">(gl\w+)<")) {
                lst_also.Add(m.Groups[1].Value);
            }

            Regex reg_group = new Regex(@"<refsynopsisdiv>(?<func>.*?)</refsynopsisdiv>(.*?<refsect1 id=""parameter(?<param>.*?)</refsect1>)?", RegexOptions.Singleline);
            foreach (Match g in reg_group.Matches(strText)) {
                List<FuncInfo> lst = new List<FuncInfo>();
                Regex reg_body = new Regex("<funcprototype>.*?</funcprototype>", RegexOptions.Singleline);
                Regex reg_func = new Regex("<funcdef>(.*?)<function>(.*?)<");
                Regex reg_args = new Regex("<paramdef>(.*?)<parameter>(.*?)<");
                foreach (Match m_body in reg_body.Matches(g.Groups["func"].Value)) {
                    FuncInfo fi = new FuncInfo();
                    var m_func = reg_func.Match(m_body.Value);
                    fi.Type = m_func.Groups[1].Value.Trim();
                    fi.Name = m_func.Groups[2].Value.Trim();
                    fi.ArgDic = new Dictionary<string, string>();
                    fi.ArgLst = new List<string>();
                    fi.Comment.Description = strDesc;
                    fi.Comment.Note = strNotes;
                    fi.Comment.Error = strErrors;
                    fi.Comment.AlsoSee = lst_also;
                    fi.Comment.Params = new Dictionary<string, string>();
                    foreach (Match m_args in reg_args.Matches(m_body.Value)) {
                        string strType = m_args.Groups[1].Value.Trim();
                        string strName = m_args.Groups[2].Value.Trim();
                        if (strType == "void") continue;
                        if (strName == "void") continue;
                        fi.ArgDic.Add(strName, strType);
                        fi.ArgLst.Add(strName);
                    }
                    lst.Add(fi);
                }
                Dictionary<string, string> dic_param = new Dictionary<string, string>();
                Regex reg_param = new Regex("<varlistentry>.*?</varlistentry>", RegexOptions.Singleline);
                foreach (Match m in reg_param.Matches(g.Groups["param"].Value)) {
                    string strParam = string.Empty;
                    foreach (Match text in Regex.Matches(m.Value, "<para>.*?</para>", RegexOptions.Singleline)) {
                        strParam += "\r\n" + _ReplaceText(text.Value);
                    }
                    strParam = strParam.Trim();
                    var ms = Regex.Matches(m.Value, "<term><parameter>(.*?)</parameter></term>");
                    foreach (Match p in ms) {
                        dic_param.Add(p.Groups[1].Value, strParam);
                    }
                }
                for (int i = 0; i < lst.Count; i++) {
                    var item = lst[i];
                    foreach (var v in item.ArgDic) {
                        if (dic_param.ContainsKey(v.Key)) {
                            item.Comment.Params.Add(v.Key, dic_param[v.Key]);
                        }
                    }
                    lst_ret.Add(item);
                }
            }
            return lst_ret.ToArray();
        }

        //===============================================================

        private static void OutPutConst(XmlDocument xml, Dictionary<string, ConstInfo> dic) {
            HashSet<string> hs = new HashSet<string>();
            OutPutConst_Feature(xml, dic, hs);
            OutPutConst_Extensions(xml, dic, hs);
        }

        private static void OutPutConst_Feature(XmlDocument xml, Dictionary<string, ConstInfo> dic, HashSet<string> hs) {
            foreach (XmlNode n in xml.GetElementsByTagName("feature")) {
                string strVer = n.Attributes["name"].Value;
                m_writer_const.Write("\r\n#region " + strVer + "\r\n\r\n");
                foreach (XmlNode r in n.SelectNodes("require")) {
                    if (r.SelectSingleNode("enum") == null) continue;
                    string strComment = _Attr(r, "comment");
                    if (!string.IsNullOrEmpty(strComment))
                        m_writer_const.Write("\r\n#region " + strComment + "\r\n\r\n");
                    foreach (XmlNode c in r.SelectNodes("enum")) {
                        var ci = dic[c.Attributes["name"].Value];
                        if (!hs.Add(ci.Name)) {
                            m_writer_const.Write("// public const uint " + ci.Name + " = " + ci.Value + ";\r\n");
                            continue;
                        }
                        m_writer_const.Write(GetConstComment(ci));
                        m_writer_const.Write("public const uint " + ci.Name + " = " + ci.Value + ";\r\n");
                    }
                    if (!string.IsNullOrEmpty(strComment))
                        m_writer_const.Write("\r\n#endregion " + strComment + "\r\n");
                }
                foreach (XmlNode r in n.SelectNodes("remove")) {
                    string strComment = _Attr(r, "comment");
                    if (!string.IsNullOrEmpty(strComment))
                        m_writer_const.Write("\r\n#region " + strComment + "\r\n\r\n");
                    foreach (XmlNode c in r.SelectNodes("enum")) {
                        var ci = dic[c.Attributes["name"].Value];
                        if (!hs.Add(ci.Name)) {
                            m_writer_const.Write("// public const uint " + ci.Name + " = " + ci.Value + ";\r\n");
                            continue;
                        }
                        m_writer_const.Write(GetConstComment(ci));
                        m_writer_const.Write("public const uint " + ci.Name + " = " + ci.Value + ";\r\n");
                    }
                    if (!string.IsNullOrEmpty(strComment))
                        m_writer_const.Write("\r\n#endregion " + strComment + "\r\n");
                }
                m_writer_const.Write("\r\n#endregion " + strVer + "\r\n");
                if (strVer.IndexOf("_4_6") != -1) break;
            }
        }

        private static void OutPutConst_Extensions(XmlDocument xml, Dictionary<string, ConstInfo> dic, HashSet<string> hs) {
            foreach (XmlNode n in xml.GetElementsByTagName("extensions")) {
                foreach (XmlNode e in n.SelectNodes("extension")) {
                    if (!_Attr(e, "supported").Split('|').Contains("gl")) {
                        continue;
                    }
                    string strExt = e.Attributes["name"].Value;
                    if (e.SelectSingleNode("require") == null) continue;
                    if (e.SelectSingleNode("require").SelectSingleNode("enum") == null) continue;
                    m_writer_const.Write("\r\n#region " + strExt + "\r\n\r\n");
                    string strSup = e.Attributes["supported"].Value;
                    foreach (XmlNode r in e.SelectNodes("require")) {
                        foreach (XmlNode c in r.SelectNodes("enum")) {
                            var ci = m_dic_const[c.Attributes["name"].Value];
                            if (!hs.Add(ci.Name)) {
                                m_writer_const.Write("// public const uint " + ci.Name + " = " + ci.Value + ";\r\n");
                                continue;
                            }
                            m_writer_const.Write(GetConstComment(ci));
                            m_writer_const.Write("public const uint " + ci.Name + " = " + ci.Value + ";\r\n");
                        }
                    }
                    m_writer_const.Write("\r\n#endregion " + strExt + "\r\n");
                }
            }
        }

        private static string GetConstComment(ConstInfo ci) {
            if (ci.Supported.Count == 0) {
                ci.Supported.Add("GL");
            }
            string strRet = string.Empty;
            strRet += "/// <summary>\r\n";
            if (!string.IsNullOrEmpty(ci.Comment)) {
                strRet += "/// " + ci.Comment + "\r\n";
            }
            if (ci.Require.Count != 0) {
                strRet += "/// Require: <para>" + string.Join(", ", ci.Require.ToArray()) + "</para>\r\n";
            }
            if (!string.IsNullOrEmpty(ci.strGroup)) {
                strRet += "/// Group: <para>" + ci.strGroup + "</para>\r\n";
            }
            strRet += "/// Supported: <para>" + string.Join(", ", ci.Supported.ToArray()) + "</para>\r\n";
            strRet += "/// </summary>";
            if (ci.Removed.Count != 0) {
                strRet += "\r\n[Obsolete(\"" + string.Join(",", ci.Removed.ToArray()) + "\")]";
            }
            return strRet + "\r\n";
        }

        //===============================================================

        private static void OutPutMethod(XmlDocument xml, Dictionary<string, FuncInfo> dic) {
            HashSet<string> hs = new HashSet<string>();

            m_writer_native_method.WriteLine("internal static Exception Exception = new NotFiniteNumberException(\"The function is not initialized, please call [GL.InitGL()] to initialize it first.\");\r\n");
            m_writer_native_method.WriteLine("private static Dictionary<string,Delegate> m_dic_proc = new Dictionary<string,Delegate>();\r\n");

            m_writer_declare.WriteLine("private struct ProcInfo{");
            m_writer_declare.WriteLine("public string Name;");
            m_writer_declare.WriteLine("public Type Type;\r\n");
            m_writer_declare.WriteLine("public ProcInfo(string strName, Type t){");
            m_writer_declare.WriteLine("this.Name = strName;");
            m_writer_declare.WriteLine("this.Type = t;");
            m_writer_declare.WriteLine("}");
            m_writer_declare.WriteLine("}\r\n");
            //m_writer_declare.WriteLine("internal static ProcInfo[] ALLProcInfo = new ProcInfo[] {");
            m_writer_declare.WriteLine("private static IEnumerable<ProcInfo> GetAllProcInfos(){");
            //m_writer_declare.WriteLine("int nIndex = 0;");
            //m_writer_declare.WriteLine("ProcInfo[] pis = new ProcInfo[XXX];");

            OutPutMethod_Feature(xml, dic, hs);
            OutPutMethod_Extensions(xml, dic, hs);

            //m_writer_declare.WriteLine("\r\nreturn pis;");
            m_writer_declare.WriteLine("}");
            //m_writer_declare.WriteLine("XXX = " + hs.Count);
            //m_writer_declare.WriteLine("};");
        }

        private static void OutPutMethod_Feature(XmlDocument xml, Dictionary<string, FuncInfo> dic, HashSet<string> hs) {
            foreach (XmlNode n in xml.GetElementsByTagName("feature")) {
                string strVer = n.Attributes["name"].Value;
                _Write("\r\n#region " + strVer + "\r\n\r\n");
                foreach (XmlNode r in n.SelectNodes("require")) {
                    if (r.SelectSingleNode("command") == null) continue;
                    string strComment = _Attr(r, "comment");
                    if (!string.IsNullOrEmpty(strComment))
                        _Write("\r\n#region " + strComment + "\r\n\r\n");
                    foreach (XmlNode c in r.SelectNodes("command")) {
                        var fi = dic[c.Attributes["name"].Value];
                        OutFuncToFile(hs, fi);
                    }
                    if (!string.IsNullOrEmpty(strComment))
                        _Write("\r\n#endregion " + strComment + "\r\n");
                }
                foreach (XmlNode r in n.SelectNodes("remove")) {
                    string strComment = _Attr(r, "comment");
                    if (!string.IsNullOrEmpty(strComment))
                        _Write("\r\n#region " + strComment + "\r\n\r\n");
                    foreach (XmlNode c in r.SelectNodes("command")) {
                        var fi = dic[c.Attributes["name"].Value];
                        OutFuncToFile(hs, fi);
                    }
                    if (!string.IsNullOrEmpty(strComment))
                        _Write("\r\n#endregion " + strComment + "\r\n");
                }
                _Write("\r\n#endregion " + strVer + "\r\n");
                if (strVer.IndexOf("_4_6") != -1) break;
            }
        }

        private static void OutPutMethod_Extensions(XmlDocument xml, Dictionary<string, FuncInfo> dic, HashSet<string> hs) {
            foreach (XmlNode n in xml.GetElementsByTagName("extensions")) {
                foreach (XmlNode e in n.SelectNodes("extension")) {
                    if (!_Attr(e, "supported").Split('|').Contains("gl")) {
                        continue;
                    }
                    string strExt = e.Attributes["name"].Value;
                    if (e.SelectSingleNode("require") == null) continue;
                    if (e.SelectSingleNode("require").SelectSingleNode("command") == null) continue;
                    _Write("\r\n#region " + strExt + "\r\n\r\n");
                    string strSup = e.Attributes["supported"].Value;
                    foreach (XmlNode r in e.SelectNodes("require")) {
                        foreach (XmlNode c in r.SelectNodes("command")) {
                            var fi = dic[c.Attributes["name"].Value];
                            OutFuncToFile(hs, fi);
                        }
                    }
                    _Write("\r\n#endregion " + strExt + "\r\n");
                }
            }
        }

        private static void OutFuncToFile(HashSet<string> hs, FuncInfo fi) {
            if (!hs.Add(fi.Name)) {
                m_writer_delegate.Write("// " + GetFuncDelegate(fi) + "\r\n");
                m_writer_declare.Write("// " + GetFuncDeclare(fi) + "\r\n");
                m_writer_native_method.Write("// " + fi.ToString() + "\r\n");
                if (fi.ToString().IndexOf('*') == -1) {
                    m_writer_safe_method.Write("// " + fi.ToString() + "\r\n");
                } else {
                    m_writer_unsafe_method.Write("// " + fi.ToString() + "\r\n");
                }
                return;
            }
            m_writer_delegate.Write("[UnmanagedFunctionPointer(CallingConvention.Cdecl)]\r\n");
            m_writer_delegate.Write(GetFuncDelegate(fi) + "\r\n");
            m_writer_declare.Write(GetFuncDeclare(fi) + "\r\n");
            m_writer_native_method.Write(GetFuncComment(fi, true));
            m_writer_native_method.Write(GetFuncNativeCall(fi) + "\r\n");
            string strSign = GetFuncSignature(fi);
            if (fi.ToString().IndexOf('*') == -1) {
                m_writer_safe_method.Write(GetFuncComment(fi, false));
                m_writer_safe_method.WriteLine(GetFuncCall(fi, strSign) + "\r\n");
            } else {
                m_writer_unsafe_method.Write(GetFuncComment(fi, false));
                m_writer_unsafe_method.WriteLine(GetUnsafeFuncCall(fi, strSign) + "\r\n");
                OutOverload(m_writer_overload_method, fi, strSign);
            }
            m_writer_init.WriteLine("_" + fi.Name + " = GetProcAddress<FN" + fi.Name + ">(ProcGetter(\"" + fi.Name + "\"));");
        }

        private static string GetFuncDelegate(FuncInfo fi) {
            string strFunc = GetType(fi.Type) + " FN" + fi.Name + "(";
            foreach (var v in fi.ArgLst) {
                strFunc += GetType(fi.ArgDic[v]) + " " + v + ",";
            }
            strFunc = strFunc.Trim(',');
            strFunc = "private " + (strFunc.IndexOf('*') != -1 ? "unsafe " : "") + "delegate " + strFunc;
            return strFunc + ");";
        }

        private static int m_nIndex = 0;
        private static string GetFuncDeclare(FuncInfo fi) {
            //return "new ProcInfo(\"" + fi.Name + "\", typeof(GLNativeDelegate.FN" + fi.Name + ")),";
            //return "pis[nIndex++] = new ProcInfo(\"" + fi.Name + "\", typeof(GLNativeDelegate.FN" + fi.Name + "));";
            return "yield return new ProcInfo(\"" + fi.Name + "\", typeof(GLNativeDelegate.FN" + fi.Name + "));";
            string strFunc = "private static FN" + fi.Name + " _" + fi.Name + " = null;";
            return strFunc;
        }

        private static string GetFuncSignature(FuncInfo fi) {
            string strSign = GetType(fi.Type) + " " + fi.Name.Substring(2) + "(";
            foreach (var v in fi.ArgLst) {
                strSign += GetType(fi.ArgDic[v]) + " " + v + ",";
            }
            return strSign.Trim(',') + ")";
        }

        private static string GetFuncCall(FuncInfo fi, string strSign) {
            //if (strSign.IndexOf('*') != -1) {
            //    return ProcessUnsafeProc(fi, strSign);
            //}
            strSign = "public static " + strSign + " {\r\n";
            strSign += "    " + (GetType(fi.Type) == "void" ? "GLNative." : "return GLNative.") + fi.Name + "(" + GetFuncCallArgString(fi) + ");\r\n";
            strSign += "}";
            return strSign;
        }

        private static string GetType(string strType) {
            if (m_dic_type.ContainsKey(strType)) {
                return m_dic_type[strType];
            }
            return strType;
        }

        private static string GetFuncNativeCall(FuncInfo fi) {
            string strFunc = GetType(fi.Type) + " " + fi.Name + "(";
            foreach (var v in fi.ArgLst) {
                strFunc += GetType(fi.ArgDic[v]) + " " + v + ",";
            }
            strFunc = strFunc.Trim(',');
            strFunc = "public " + (strFunc.IndexOf('*') != -1 ? "unsafe " : "") + "static " + strFunc + ") {\r\n";
            strFunc += "    var _F = _GetProc<GLNativeDelegate.FN" + fi.Name + ">(\"" + fi.Name + "\");\r\n";
            //strFunc += "    if (!m_dic_proc.ContainsKey(\"" + fi.Name + "\")) throw GLNative.Exception;\r\n";
            strFunc += "    " + (GetType(fi.Type) == "void" ? "" : "return ") + "_F(" + GetFuncCallArgString(fi) + ");\r\n";
            strFunc += "}";
            return strFunc;
        }

        private static string GetFuncCallArgString(FuncInfo fi) {
            //string strFunc = string.Empty;
            return string.Join(", ", fi.ArgLst.ToArray());
            //foreach (var v in fi.ArgLst) {
            //    strFunc += v + ", ";
            //}
            //return strFunc.Trim().Trim(',');
        }

        private static FuncInfo ReplaceFuncString(FuncInfo fi) {
            var keys = fi.ArgDic.Keys.ToArray();
            for (int i = 0; i < fi.ArgLst.Count; i++) {
                if (!m_dic_param_name.ContainsKey(fi.ArgLst[i])) {
                    continue;
                }
                fi.ArgDic.Add(m_dic_param_name[fi.ArgLst[i]], fi.ArgDic[fi.ArgLst[i]]);
                fi.ArgDic.Remove(fi.ArgLst[i]);
                fi.ArgLst[i] = m_dic_param_name[fi.ArgLst[i]];
            }
            return fi;
        }

        private static string GetFuncComment(FuncInfo fi, bool isNative) {
            if (fi.Supported.Count == 0) {
                fi.Supported.Add("GL");
            }
            string str = string.Empty;
            if (!string.IsNullOrEmpty(fi.Comment.Description)) {
                str += fi.Comment.Description + "\r\n";
            }
            if (fi.Require.Count != 0) {
                str += "Require: <para>" + string.Join(", ", fi.Require.ToArray()) + "</para>\r\n";
            }
            str += "Supported: <para>" + string.Join(", ", fi.Supported.ToArray()) + "</para>\r\n";
            if (!string.IsNullOrEmpty(fi.Comment.Note)) {
                str += "Notes: \r\n" + fi.Comment.Note + "\r\n";
            }
            if (!string.IsNullOrEmpty(fi.Comment.Error)) {
                str += "Errors: \r\n" + fi.Comment.Error + "\r\n";
            }
            str += "Original: <para>" + fi.Original + "</para>\r\n";
            str = "<summary>\r\n" + str + "</summary>\r\n";
            if (fi.Comment.Params != null) {
                foreach (var v in fi.Comment.Params) {
                    str += "<param name=\"" + v.Key + "\">\r\n" + v.Value + "\r\n</param>\r\n";
                }
            }
            if (fi.Comment.AlsoSee != null) {
                foreach (var v in fi.Comment.AlsoSee) {
                    str += "<seealso cref=\"" + v.Substring(isNative ? 0 : 2) + "\"/>\r\n";
                }
            }
            foreach (var v in m_dic_param_name) {
                str = str.Replace("\"" + v.Key + "\"", "\"" + v.Value + "\"");
            }
            //str = str
            //    .Replace("\"in\"", "\"innum\"")
            //    .Replace("\"ref\"", "\"r\"")
            //    .Replace("\"event\"", "\"eventptr\"")
            //    .Replace("\"base\"", "\"b\"")
            //    .Replace("\"string\"", "\"str\"")
            //    .Replace("\"params\"", "\"ps\"")
            //    .Replace("\"object\"", "\"obj\"");
            str = str.Trim();
            str = Regex.Replace(str, @"^", "/// ", RegexOptions.Multiline);
            if (fi.Removed.Count != 0) {
                str += "\r\n[Obsolete(\"" + string.Join(",", fi.Removed.ToArray()) + "\")]";
            }
            return str + "\r\n";
        }

        private static void _Write(string strText) {
            m_writer_delegate.Write(strText);
            m_writer_declare.Write(strText);
            m_writer_safe_method.Write(strText);
            m_writer_unsafe_method.Write(strText);
            m_writer_native_method.Write(strText);
            m_writer_overload_method.Write(strText);
        }

        //===============================================================
        // [unsafe to safe] =============================================

        private static void OutOverload(StreamWriter writer, FuncInfo fi, string strSign) {
            if (m_dic_overload_func.ContainsKey(fi.Name.Substring(2))) {
                writer.WriteLine(m_dic_overload_func[fi.Name.Substring(2)]);
                return;
            }
            if (strSign.IndexOf(",int* length,byte*") != -1) {
                OverLoadStringGetMethod(writer, fi);
                return;
            }
            if (strSign.IndexOf("int length,byte*") != -1) {
                OverLoadStringSetMethod(writer, fi);
                return;
            }
            if (strSign.IndexOf("IntPtr size,void* data") != -1) {
                OverLoadSizeDataMethod(writer, fi);
            }
            int nLeft = strSign.IndexOf("*");
            int nRight = strSign.LastIndexOf("*");
            if (nLeft == nRight && !fi.Type.Contains("*")) {
                if (fi.Type == "void") {
                    if (fi.Name.StartsWith("glGet")) {
                        OverLoadGetMethod(writer, fi);
                        return;
                    } else if (fi.Name.StartsWith("glGen")) {
                        OverLoadGenMethod(writer, fi);
                        return;
                    } else if (fi.Name.StartsWith("glCreate")) {
                        OverLoadCreateMethod(writer, fi);
                        return;
                    } else if (fi.Name.StartsWith("glDelete")) {
                        OverLoadDeleteMethod(writer, fi);
                        return;
                    } else if (fi.ArgDic.ContainsKey("indices")) {
                        OverLoadIndicesMethod(writer, fi);
                        return;
                    }
                }
            }
            writer.WriteLine("// [not processed] - " + GetFuncSignature(fi));
            //if (fi.Name.TrimStart("glGet")) {

            //}
        }

        private unsafe static void OverLoadGetMethod(StreamWriter writer, FuncInfo fi) {
            string strType = string.Empty;
            string strName = string.Empty;
            string strPName = string.Empty;
            string strArgs = string.Empty;
            string strArgsCall = string.Empty;
            foreach (var v in fi.ArgLst) {
                if (fi.ArgDic[v].IndexOf("*") != -1) {
                    strType = GetType(fi.ArgDic[v]);
                    if (strType == "void*" || strType == "byte*") {
                        writer.WriteLine("// [ignore] - " + GetFuncSignature(fi));
                        return;
                    }
                    strName = v;
                    strPName = "&" + strName;
                    strArgsCall += strPName + ",";
                    continue;
                }
                strArgsCall += v + ",";
                strArgs += GetType(fi.ArgDic[v]) + " " + v + ",";
            }
            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// [Overload] - " + GetFuncSignature(fi));
            writer.WriteLine("/// </summary>");
            writer.WriteLine("public unsafe static " + strType.Trim('*') + " " + fi.Name.Substring(2) + "(" + strArgs.Trim(',') + "){");
            writer.WriteLine(strType.Trim('*') + " " + strName + " = " + (strType == "bool*" ? "false" : "0") + ";");
            writer.WriteLine("GLNative." + fi.Name + "(" + strArgsCall.Trim(',') + ");");
            writer.WriteLine("return " + strName + ";");
            writer.WriteLine("}\r\n");
        }

        private unsafe static void OverLoadDeleteMethod(StreamWriter writer, FuncInfo fi) {
            string strType = string.Empty;
            string strName = string.Empty;
            string strPName = string.Empty;
            foreach (var v in fi.ArgLst) {
                if (fi.ArgDic[v].IndexOf("*") != -1) {
                    strType = GetType(fi.ArgDic[v]);
                    if (strType == "void*" || strType == "byte*") {
                        writer.WriteLine("// [ignore] - " + GetFuncSignature(fi));
                        return;
                    }
                    strName = v;
                    strPName = "p" + strName.ToUpper()[0] + strName.Substring(1);
                    continue;
                }
            }
            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// [Overload] - " + GetFuncSignature(fi));
            writer.WriteLine("/// </summary>");
            writer.WriteLine("public unsafe static void " + fi.Name.Substring(2) + "(" + strType.Trim('*') + "[] " + strName + "){");
            writer.WriteLine("fixed(" + strType + " " + strPName + " = &" + strName + "[0]){");
            writer.WriteLine("GLNative." + fi.Name + "(" + strName + ".Length," + strPName + ");");
            writer.WriteLine("}");
            writer.WriteLine("}\r\n");

            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// [Overload] - " + GetFuncSignature(fi));
            writer.WriteLine("/// </summary>");
            writer.WriteLine("public unsafe static void " + fi.Name.Substring(2) + "(" + strType.Trim('*') + "[] " + strName + ",int n){");
            writer.WriteLine("fixed(" + strType + " " + strPName + " = &" + strName + "[0]){");
            writer.WriteLine("GLNative." + fi.Name + "(n," + strPName + ");");
            writer.WriteLine("}");
            writer.WriteLine("}\r\n");
        }

        private unsafe static void OverLoadGenMethod(StreamWriter writer, FuncInfo fi) {
            string strType = string.Empty;
            string strName = string.Empty;
            string strPName = string.Empty;
            foreach (var v in fi.ArgLst) {
                if (fi.ArgDic[v].IndexOf("*") != -1) {
                    strType = GetType(fi.ArgDic[v]);
                    if (strType == "void*" || strType == "byte*") {
                        writer.WriteLine("// [ignore] - " + GetFuncSignature(fi));
                        return;
                    }
                    strName = v;
                    strPName = "p" + strName.ToUpper()[0] + strName.Substring(1);
                    continue;
                }
            }
            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// [Overload] - " + GetFuncSignature(fi));
            writer.WriteLine("/// </summary>");
            writer.WriteLine("public unsafe static " + strType.Trim('*') + " " + fi.Name.Substring(2) + "(){");
            writer.WriteLine(strType.Trim('*') + " " + strName + " = 0;");
            writer.WriteLine("GLNative." + fi.Name + "(1,&" + strName + ");");
            writer.WriteLine("return " + strName + ";");
            writer.WriteLine("}\r\n");

            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// [Overload] - " + GetFuncSignature(fi));
            writer.WriteLine("/// </summary>");
            writer.WriteLine("public unsafe static " + strType.Trim('*') + "[] " + fi.Name.Substring(2) + "(int n){");
            writer.WriteLine(strType.Trim('*') + "[] " + strName + " = new " + strType.Trim('*') + "[n];");
            writer.WriteLine("fixed(" + strType + " " + strPName + " = &" + strName + "[0]){");
            writer.WriteLine("GLNative." + fi.Name + "(n," + strPName + ");");
            writer.WriteLine("}");
            writer.WriteLine("return " + strName + ";");
            writer.WriteLine("}\r\n");
        }

        private unsafe static void OverLoadCreateMethod(StreamWriter writer, FuncInfo fi) {
            if (!fi.ArgDic.ContainsKey("n")) {
                writer.WriteLine("// [ignore] - " + GetFuncSignature(fi));
                return;
            }
            bool bHasTarget = fi.ArgDic.ContainsKey("target");
            string strType = string.Empty;
            string strName = string.Empty;
            string strPName = string.Empty;
            foreach (var v in fi.ArgLst) {
                if (fi.ArgDic[v].IndexOf("*") != -1) {
                    strType = GetType(fi.ArgDic[v]);
                    if (strType == "void*" || strType == "byte*") {
                        writer.WriteLine("// [ignore] - " + GetFuncSignature(fi));
                        return;
                    }
                    strName = v;
                    strPName = "p" + strName.ToUpper()[0] + strName.Substring(1);
                    continue;
                }
            }
            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// [Overload] - " + GetFuncSignature(fi));
            writer.WriteLine("/// </summary>");
            writer.WriteLine("public unsafe static " + strType.Trim('*') + " " + fi.Name.Substring(2) + "(" + (bHasTarget ? "uint target" : "") + "){");
            writer.WriteLine(strType.Trim('*') + " " + strName + " = 0;");
            writer.WriteLine("GLNative." + fi.Name + "(" + (bHasTarget ? "target," : "") + "1,&" + strName + ");");
            writer.WriteLine("return " + strName + ";");
            writer.WriteLine("}\r\n");

            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// [Overload] - " + GetFuncSignature(fi));
            writer.WriteLine("/// </summary>");
            writer.WriteLine("public unsafe static " + strType.Trim('*') + "[] " + fi.Name.Substring(2) + "(" + (bHasTarget ? "uint target," : "") + "int n){");
            writer.WriteLine(strType.Trim('*') + "[] " + strName + " = new " + strType.Trim('*') + "[n];");
            writer.WriteLine("fixed(" + strType + " " + strPName + " = &" + strName + "[0]){");
            writer.WriteLine("GLNative." + fi.Name + "(" + (bHasTarget ? "target," : "") + "n," + strPName + ");");
            writer.WriteLine("}");
            writer.WriteLine("return " + strName + ";");
            writer.WriteLine("}\r\n");
        }

        private unsafe static void OverLoadIndicesMethod(StreamWriter writer, FuncInfo fi) {
            bool bHasType = fi.ArgDic.ContainsKey("type");
            string[] strsType = new string[] { "byte", "short", "ushort", "int", "uint", "float" };
            string strType = string.Empty;
            string strName = string.Empty;
            string strPName = string.Empty;
            string strArgsSign_arr = string.Empty;
            string strArgsCall_arr = string.Empty;
            string strArgsSign_type_arr = string.Empty;
            string strArgsCall_type_arr = string.Empty;
            string strArgsSign_all = string.Empty;
            string strArgsCall_all = string.Empty;
            strType = GetType(fi.ArgDic["indices"]);
            if (strType != "void*") {
                strsType = new string[] { strType.Trim('*') };
                if (!m_dic_type_name.ContainsKey(strsType[0])) {
                    writer.WriteLine("// [ignore] - " + GetFuncSignature(fi));
                    return;
                }
            }
            foreach (var v in fi.ArgLst) {
                if (v == "count") {
                    strArgsSign_all += "int count,";
                    strArgsCall_arr += "(indices==null?0:indices.Length),";
                    strArgsCall_type_arr += "(indices==null?0:indices.Length),";
                    strArgsCall_all += "count,";
                } else if (v == "type") {
                    strArgsSign_type_arr += "uint type,";
                    strArgsSign_all += "uint type,";
                    strArgsCall_arr += "{TYPE},";
                    strArgsCall_type_arr += "type,";
                    strArgsCall_all += "type,";
                } else if (v == "indices") {
                    strArgsSign_arr += "{TYPE} indices,";
                    strArgsSign_type_arr += "{TYPE} indices,";
                    strArgsSign_all += "{TYPE} indices,";
                    strArgsCall_arr += "pIndices,";
                    strArgsCall_type_arr += "pIndices,";
                    strArgsCall_all += "pIndices,";
                } else {
                    strArgsSign_arr += GetType(fi.ArgDic[v]) + " " + v + ",";
                    strArgsSign_type_arr += GetType(fi.ArgDic[v]) + " " + v + ",";
                    strArgsSign_all += GetType(fi.ArgDic[v]) + " " + v + ",";
                    strArgsCall_arr += v + ",";
                    strArgsCall_type_arr += v + ",";
                    strArgsCall_all += v + ",";
                }
            }
            strArgsCall_all = strArgsCall_all.Trim(',');
            strArgsCall_arr = strArgsCall_arr.Trim(',');
            strArgsCall_type_arr = strArgsCall_type_arr.Trim(',');
            strArgsSign_all = strArgsSign_all.Trim(',');
            strArgsSign_arr = strArgsSign_arr.Trim(',');
            strArgsSign_type_arr = strArgsSign_type_arr.Trim(',');

            foreach (var v in strsType) {
                writer.WriteLine("/// <summary>");
                writer.WriteLine("/// [Overload] - " + GetFuncSignature(fi));
                writer.WriteLine("/// </summary>");
                writer.WriteLine("public unsafe static void " + fi.Name.Substring(2) + "(" + strArgsSign_arr.Replace("{TYPE}", v + "[]") + "){");
                writer.WriteLine("fixed(" + strType + " pIndices = &indices[0]){");
                writer.WriteLine("GLNative." + fi.Name + "(" + strArgsCall_arr.Replace("{TYPE}", m_dic_type_name[v]) + ");");
                writer.WriteLine("}");
                writer.WriteLine("}\r\n");
                if (fi.ArgDic.ContainsKey("type")) {
                    writer.WriteLine("/// <summary>");
                    writer.WriteLine("/// [Overload] - " + GetFuncSignature(fi));
                    writer.WriteLine("/// </summary>");
                    writer.WriteLine("public unsafe static void " + fi.Name.Substring(2) + "(" + strArgsSign_type_arr.Replace("{TYPE}", v + "[]") + "){");
                    writer.WriteLine("fixed(" + strType + " pIndices = &indices[0]){");
                    writer.WriteLine("GLNative." + fi.Name + "(" + strArgsCall_type_arr.Replace("{TYPE}", m_dic_type_name[v]) + ");");
                    writer.WriteLine("}");
                    writer.WriteLine("}\r\n");
                }
                writer.WriteLine("/// <summary>");
                writer.WriteLine("/// [Overload] - " + GetFuncSignature(fi));
                writer.WriteLine("/// </summary>");
                writer.WriteLine("public unsafe static void " + fi.Name.Substring(2) + "(" + strArgsSign_all.Replace("{TYPE}", v + "[]") + "){");
                writer.WriteLine("fixed(" + strType + " pIndices = &indices[0]){");
                writer.WriteLine("GLNative." + fi.Name + "(" + strArgsCall_all.Replace("{TYPE}", m_dic_type_name[v]) + ");");
                writer.WriteLine("}");
                writer.WriteLine("}\r\n");
            }
        }

        private static void OverLoadStringGetMethod(StreamWriter writer, FuncInfo fi) {
            bool bMaxLength = fi.ArgDic.ContainsKey("maxLength");
            string strName = string.Empty;
            string strPName = string.Empty;
            string strArgsSign_len = string.Empty;
            string strArgsCall_len = string.Empty;
            string strArgsSign_nolen = string.Empty;
            string strArgsCall_nolen = string.Empty;
            foreach (var v in fi.ArgLst) {
                if (GetType(fi.ArgDic[v]) == "byte*") {
                    strName = v;
                    strPName = "p" + strName.ToUpper()[0] + strName.Substring(1);
                    break;
                }
            }
            foreach (var v in fi.ArgLst) {
                if (v == "maxLength") {
                    strArgsSign_len += "int maxLength,";
                    strArgsCall_len += "maxLength,";
                    strArgsCall_nolen += strName + ".Length,";
                } else if (v == "bufSize") {
                    strArgsSign_len += "int bufSize,";
                    strArgsCall_len += "bufSize,";
                    strArgsCall_nolen += strName + ".Length,";
                } else if (v == "length") {
                    strArgsCall_len += "&length,";
                    strArgsCall_nolen += "&length,";
                } else if (v == strName) {
                    strArgsCall_len += strPName + ",";
                    strArgsCall_nolen += strPName + ",";
                } else {
                    string strTemp = GetType(fi.ArgDic[v]);
                    if (strTemp == "void*") strTemp = "IntPtr";
                    strArgsSign_len += strTemp + " " + v + ",";
                    strArgsSign_nolen += strTemp + " " + v + ",";
                    strArgsCall_len += (strTemp == "IntPtr" ? "(void*)" : "") + v + ",";
                    strArgsCall_nolen += (strTemp == "IntPtr" ? "(void*)" : "") + v + ",";
                }
            }
            strArgsCall_len = strArgsCall_len.Trim(',');
            strArgsCall_nolen = strArgsCall_nolen.Trim(',');
            strArgsSign_len = strArgsSign_len.Trim(',');
            strArgsSign_nolen = strArgsSign_nolen.Trim(',');

            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// [Overload] - " + GetFuncSignature(fi));
            writer.WriteLine("/// </summary>");
            writer.WriteLine("public unsafe static string " + fi.Name.Substring(2) + "(" + strArgsSign_nolen + "){");
            writer.WriteLine("int length = 0;");
            writer.WriteLine("byte[] " + strName + " = new byte[1024];");
            writer.WriteLine("fixed(byte*" + strPName + "= &" + strName + "[0]){");
            writer.WriteLine("GLNative." + fi.Name + "(" + strArgsCall_nolen + ");");
            writer.WriteLine("if(length == 0) return null;");
            writer.WriteLine("return Encoding.UTF8.GetString(" + strName + ",0,length);");
            writer.WriteLine("}");
            writer.WriteLine("}\r\n");

            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// [Overload] - " + GetFuncSignature(fi));
            writer.WriteLine("/// </summary>");
            writer.WriteLine("public unsafe static string " + fi.Name.Substring(2) + "(" + strArgsSign_len + "){");
            writer.WriteLine("int length = 0;");
            writer.WriteLine("byte[] " + strName + " = new byte[" + (bMaxLength ? "maxLength" : "bufSize") + "];");
            writer.WriteLine("fixed(byte*" + strPName + "= &" + strName + "[0]){");
            writer.WriteLine("GLNative." + fi.Name + "(" + strArgsCall_len + ");");
            writer.WriteLine("if(length == 0) return null;");
            writer.WriteLine("return Encoding.UTF8.GetString(" + strName + ",0,length);");
            writer.WriteLine("}");
            writer.WriteLine("}\r\n");

        }

        private static void OverLoadStringSetMethod(StreamWriter writer, FuncInfo fi) {
            string strName = string.Empty;
            string strPName = string.Empty;
            string strArgsSign = string.Empty;
            string strArgsCall = string.Empty;
            foreach (var v in fi.ArgLst) {
                if (GetType(fi.ArgDic[v]) == "byte*") {
                    strName = v;
                    strPName = "p" + strName.ToUpper()[0] + strName.Substring(1);
                    break;
                }
            }
            foreach (var v in fi.ArgLst) {
                if (v == "length") {
                    strArgsCall += strName + ".Length,";
                } else if (v == strName) {
                    strArgsCall += strPName + ",";
                    strArgsSign += "string " + strName + ",";
                } else {
                    string strTemp = GetType(fi.ArgDic[v]);
                    if (strTemp == "void*") strTemp = "IntPtr";
                    strArgsSign += strTemp + " " + v + ",";
                    strArgsCall += (strTemp == "IntPtr" ? "(void*)" : "") + v + ",";
                }
            }
            strArgsCall = strArgsCall.Trim(',');
            strArgsSign = strArgsSign.Trim(',');

            writer.WriteLine("/// <summary>");
            writer.WriteLine("/// [Overload] - " + GetFuncSignature(fi));
            writer.WriteLine("/// </summary>");
            writer.WriteLine("public unsafe static void " + fi.Name.Substring(2) + "(" + strArgsSign + "){");
            writer.WriteLine("byte[] byBuffer = Encoding.UTF8.GetBytes(" + strName + ");");
            writer.WriteLine("fixed(byte*" + strPName + "= &byBuffer[0]){");
            writer.WriteLine("GLNative." + fi.Name + "(" + strArgsCall + ");");
            writer.WriteLine("}");
            writer.WriteLine("}\r\n");


        }

        private static void OverLoadSizeDataMethod(StreamWriter writer, FuncInfo fi) {
            bool bHasType = fi.ArgDic.ContainsKey("type");
            string[] strsType = new string[] { "byte", "short", "ushort", "int", "uint", "float" };
            string strType = string.Empty;
            string strName = string.Empty;
            string strPName = string.Empty;
            string strArgsSign_nosize = string.Empty;
            string strArgsSign_all = string.Empty;
            string strArgsCall = string.Empty;
            foreach (var v in fi.ArgLst) {
                if (v == "size") {
                    strArgsSign_all += "long size,";
                    strArgsCall += "(IntPtr)size,";
                } else if (v == "data") {
                    strArgsSign_nosize += "{TYPE} data,";
                    strArgsSign_all += "{TYPE} data,";
                    strArgsCall += "pData,";
                } else {
                    strArgsSign_nosize += GetType(fi.ArgDic[v]) + " " + v + ",";
                    strArgsSign_all += GetType(fi.ArgDic[v]) + " " + v + ",";
                    strArgsCall += v + ",";
                }
            }
            strArgsCall = strArgsCall.Trim(',');
            strArgsSign_all = strArgsSign_all.Trim(',');
            strArgsSign_nosize = strArgsSign_nosize.Trim(',');

            foreach (var v in strsType) {
                writer.WriteLine("/// <summary>");
                writer.WriteLine("/// [Overload] - " + GetFuncSignature(fi));
                writer.WriteLine("/// </summary>");
                writer.WriteLine("public unsafe static void " + fi.Name.Substring(2) + "(" + strArgsSign_nosize.Replace("{TYPE}", v + "[]") + "){");
                writer.WriteLine("long size = data.Length * sizeof(" + v + ");");
                writer.WriteLine("if(IntPtr.Size == 4) size = (int)size;");
                writer.WriteLine("fixed(void*" + strType + " pData = &data[0]){");
                writer.WriteLine("GLNative." + fi.Name + "(" + strArgsCall.Replace("{TYPE}", m_dic_type_name[v]) + ");");
                writer.WriteLine("}");
                writer.WriteLine("}\r\n");

                writer.WriteLine("/// <summary>");
                writer.WriteLine("/// [Overload] - " + GetFuncSignature(fi));
                writer.WriteLine("/// </summary>");
                writer.WriteLine("public unsafe static void " + fi.Name.Substring(2) + "(" + strArgsSign_all.Replace("{TYPE}", v + "[]") + "){");
                //writer.WriteLine("long sz = size;");
                writer.WriteLine("if(IntPtr.Size == 4) size = (int)size;");
                writer.WriteLine("fixed(void*" + strType + " pData = &data[0]){");
                writer.WriteLine("GLNative." + fi.Name + "(" + strArgsCall.Replace("{TYPE}", m_dic_type_name[v]) + ");");
                writer.WriteLine("}");
                writer.WriteLine("}\r\n");
            }
        }

        private static string ProcessUnsafeProc(FuncInfo fi, string strSign) {
            return GetUnsafeFuncCall(fi, strSign);
            string strRet = null;

            int nStartIndex = strSign.IndexOf('*');
            int nEndIndex = strSign.LastIndexOf('*');
            if (nStartIndex != nEndIndex) { // if more than one pointer

            } else {
                strRet = UnsafeCaseCountPointer(fi, strSign);
                if (strRet != null) return strRet;
            }
            return GetUnsafeFuncCall(fi, strSign);
            strRet = "public unsafe static " + strSign + " {\r\n";
            strRet += "    " + (GetType(fi.Type) == "void" ? "GLNative." : "return GLNative.") + fi.Name + "(" + GetFuncCallArgString(fi) + ");\r\n";
            strRet += "}";
            return strRet;
        }

        private static string GetUnsafeFuncCall(FuncInfo fi, string strSign) {
            string strArgsSign = string.Empty;
            string strArgsCall = string.Empty;
            List<string> lstFixed = new List<string>();
            foreach (var name in fi.ArgLst) {
                var t = GetType(fi.ArgDic[name]);
                if (t.IndexOf("**") != -1 || t.StartsWith("void")) {
                    strArgsSign += "IntPtr " + name;
                    strArgsCall += "(" + t + ")" + name;
                } else if (t.IndexOf("*") != -1) {
                    string strName = "p" + name.ToUpper()[0] + name.Substring(1);
                    lstFixed.Add("fixed(" + (t) + " " + strName + "=&" + name + ")");
                    strArgsSign += "ref " + t.Substring(0, t.Length - 1) + " " + name;
                    strArgsCall += strName;
                } else {
                    strArgsSign += (t) + " " + name;
                    strArgsCall += name;
                }
                strArgsSign += ",";
                strArgsCall += ",";
            }
            strArgsSign = strArgsSign.Trim(',');
            strArgsCall = strArgsCall.Trim(',');
            string strRet = "public unsafe static " + GetType(fi.Type) + " " + fi.Name.Substring(2) + "(" + strArgsSign + ") {\r\n";
            foreach (var v in lstFixed) strRet += v + "\r\n";
            if (lstFixed.Count > 0) strRet += "{\r\n";
            strRet += (GetType(fi.Type) == "void" ? "GLNative." : "return GLNative.")
                + fi.Name + "(" + strArgsCall + ");\r\n";
            if (lstFixed.Count > 0) strRet += "}\r\n";
            strRet += "}";
            return strRet;
        }

        private static string UnsafeCaseCountPointer(FuncInfo fi, string strSign) {
            if (strSign.IndexOf("void*") != -1) return null;
            if (!fi.ArgDic.ContainsKey("count")) {
                return null;
            }
            string strKey = string.Empty;
            foreach (var v in fi.ArgDic) {
                if (v.Value.EndsWith("*")) {
                    strKey = v.Key;
                    break;
                }
            }
            string strRet = "public unsafe static " + strSign.Replace("*", "[]") + " {\r\n";
            strRet += "fixed(" + GetType(fi.ArgDic[strKey]) + " p = &" + strKey + "[0]){\r\n";
            strRet += (GetType(fi.Type) == "void" ? "GLNative." : "return GLNative.")
                + fi.Name + "(" + GetFuncCallArgString(fi).Replace(strKey, "p") + ");\r\n";
            strRet += "}\r\n}";
            return strRet;
        }

        private static string UnsafeCaseTargetPname(FuncInfo fi, string strSign) {
            if (strSign.IndexOf("void*") != -1) return null;
            if (!fi.ArgDic.ContainsKey("count")) {
                return null;
            }
            string strKey = string.Empty;
            foreach (var v in fi.ArgDic) {
                if (v.Value.EndsWith("*")) {
                    strKey = v.Key;
                    break;
                }
            }
            string strRet = "public unsafe static " + strSign.Replace("*", "[]") + " {\r\n";
            strRet += "fixed(" + GetType(fi.ArgDic[strKey]) + " p = &" + strKey + "[0]){\r\n";
            strRet += (GetType(fi.Type) == "void" ? "GLNative." : "return GLNative.")
                + fi.Name + "(" + GetFuncCallArgString(fi).Replace(strKey, "p") + ");\r\n";
            strRet += "}\r\n}";
            return strRet;
        }

        private static string _ReplaceText(string strText) {
            strText = strText.Replace("</code>", "[:/code:]")
                .Replace("</parameter>", "[:/pref:]")
                .Replace("</function>", "[:/func:]")
                .Replace("</refentrytitle>", "[:/func:]")
                .Replace("</constant>", "[:/code:]");
            strText = Regex.Replace(strText, "<code.*?>", "[:code:]");
            strText = Regex.Replace(strText, "<constant.*?>", "[:code:]");
            strText = Regex.Replace(strText, "<parameter.*?>", "[:pref:]");
            strText = Regex.Replace(strText, "<function.*?>", "[:func:]");
            strText = Regex.Replace(strText, "<refentrytitle.*?>", "[:func:]");
            strText = Regex.Replace(strText, "<.*?>", " ");
            strText = Regex.Replace(strText, @"^\s+", "", RegexOptions.Multiline);
            strText = strText.Trim()
                .Replace("[:code:]", "<code>")
                .Replace("[:/code:]", "</code>")
                .Replace("[:pref:]", "<paramref name=\"")
                .Replace("[:/pref:]", "\"/>")
                .Replace("[:func:]", "<see cref=\"")
                .Replace("[:/func:]", "\"/>");
            if (strText.IndexOf('\n') != -1) {
                return "<para>\r\n" + strText + "\r\n</para>";
            }
            return strText;
        }

        private static string _Attr(XmlNode node, string strName) {
            if (node.Attributes[strName] == null) {
                return string.Empty;
            }
            return node.Attributes[strName].Value;
        }
    }
}
