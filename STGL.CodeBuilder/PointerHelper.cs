using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STGL.CodeBuilder
{
    class PointerHelper
    {
        public static string GetCode() {
            string[] strs = new string[] { "byte", "Boolean", "Int16", "UInt16", "Int32", "UInt32", "Int64", "UInt64", "float", "double" };
            string strRet = string.Empty;
            foreach (var t in strs) {
                string strName = "Get" + t.ToUpper()[0] + t.Substring(1);
                strRet += "public " + t + " " + strName + "(){return this." + strName + "(0);}\r\n";
                //strRet += "public " + v + " " + strName + "(int nIndex){return this." + strName + "((long)nIndex);}\r\n";
                strRet += "public unsafe " + t + " " + strName + "(long nIndex){\r\n";
                strRet += "var nWidth = sizeof(" + t + ");\r\n";
                strRet += "return *((" + t + "*)((long)m_pointer+nIndex*nWidth));\r\n";
                strRet += "}\r\n";
                strRet += "public " + t + "[] " + strName + "s(long nCount){return this." + strName + "s(0,nCount);}\r\n";
                strRet += "public unsafe " + t + "[] " + strName + "s(long nIndex,long nCount){\r\n";
                strRet += "var nWidth = sizeof(" + t + ");\r\n";
                strRet += "var ret = new " + t + "[nCount];\r\n";
                strRet += "nCount *= nWidth;\r\n";
                strRet += "var src = (void*)((long)m_pointer + nIndex * nWidth);\r\n";
                strRet += "fixed(void* dst = &ret[0]){\r\n";
                strRet += "Pointer.Copy(dst,src,nCount);\r\n";
                strRet += "}\r\n";
                strRet += "return ret;\r\n";
                strRet += "}\r\n\r\n";
            }
            return strRet;
        }
    }
}
