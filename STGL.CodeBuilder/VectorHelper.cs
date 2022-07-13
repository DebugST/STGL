using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STGL.CodeBuilder
{
    public class VectorHelper
    {
        private static string m_cname;
        private static string m_vname;
        private static string[] m_strs_field = { "X", "Y", "Z", "W" };
        private static Dictionary<char, string> m_dic_type = new Dictionary<char, string>(){
            {'I', "int"},
            {'F', "float"},
            {'D', "double"}
        };

        public static string GetCode(int n, char type) {
            if (n < 2 || n > 4) throw new ArgumentOutOfRangeException("2 <= n <= 4");
            m_cname = "Vector" + n + type;
            m_vname = "v" + n + type.ToString().ToLower();
            string strFields = string.Empty;
            string strLengthExpress = string.Empty;
            string strConstructor = string.Empty;
            string strAssign = string.Empty;
            string strToString = ")\"";

            string strAdd = string.Empty;
            string strSub = string.Empty;
            string strMul = string.Empty;
            string strDiv = string.Empty;

            string strAddC = string.Empty;
            string strSubC = string.Empty;
            string strMulC = string.Empty;
            string strDivC = string.Empty;

            string strNeg = string.Empty;

            for (int i = 0; i < n; i++) {
                strLengthExpress += "this." + m_strs_field[i] + "*" + "this." + m_strs_field[i] + "+";
                strFields += "public " + m_dic_type[type] + " " + m_strs_field[i] + ";\r\n";
                strConstructor += m_dic_type[type] + " " + m_strs_field[i].ToLower() + ",";
                strAssign += "this." + m_strs_field[i] + " = " + m_strs_field[i].ToLower() + ";\r\n";
                strToString = ", {" + (n - i - 1) + "}" + strToString + ",this." + m_strs_field[i];
                strAdd += m_vname + "a." + m_strs_field[i] + "+=" + m_vname + "b." + m_strs_field[i] + ";\r\n";
                strSub += m_vname + "a." + m_strs_field[i] + "-=" + m_vname + "b." + m_strs_field[i] + ";\r\n";
                strMul += m_vname + "a." + m_strs_field[i] + "*=" + m_vname + "b." + m_strs_field[i] + ";\r\n";
                strDiv += m_vname + "a." + m_strs_field[i] + "/=" + m_vname + "b." + m_strs_field[i] + ";\r\n";

                strAddC += m_vname + "a." + m_strs_field[i] + "+=v;\r\n";
                strSubC += m_vname + "a." + m_strs_field[i] + "-=v;\r\n";
                strMulC += m_vname + "a." + m_strs_field[i] + "*=v;\r\n";
                strDivC += m_vname + "a." + m_strs_field[i] + "/=v;\r\n";

                strNeg += m_vname + "." + m_strs_field[i] + " = -" + m_vname + "." + m_strs_field[i] + ";\r\n";
            }
            strLengthExpress = strLengthExpress.Trim('+');
            strFields = strFields.Trim();
            strConstructor = strConstructor.Trim(',');
            strToString = "return string.Format(\"(" + strToString.TrimStart(',').Trim() + ");";
            strAdd += "return " + m_vname + "a;";
            strSub += "return " + m_vname + "a;";
            strMul += "return " + m_vname + "a;";
            strDiv += "return " + m_vname + "a;";

            strAddC += "return " + m_vname + "a;";
            strSubC += "return " + m_vname + "a;";
            strMulC += "return " + m_vname + "a;";
            strDivC += "return " + m_vname + "a;";

            strNeg += "return " + m_vname + ";";

            string strRet = @"
    public struct {C}
    {
        " + strFields + @"

        public double Length {
            get {
                return Math.Sqrt(" + strLengthExpress + @");
            }
        }

        public {C}(" + strConstructor + @") {
            " + strAssign.Trim() + @"
        }

        public override string ToString() {
            " + strToString + @"
        }

        public static {C} operator +({C} {V}a, {C} {V}b) {
            " + strAdd + @"
        }

        public static {C} operator +({C} {V}a, {T} v) {
            " + strAddC + @"
        }

        public static {C} operator +({T} v, {C} {V}a) {
            " + strAddC + @"
        }


        public static {C} operator -({C} {V}a, {C} {V}b) {
            " + strSub + @"
        }

        public static {C} operator -({C} {V}a, {T} v) {
            " + strSubC + @"
        }

        public static {C} operator -({C} {V}) {
            " + strNeg + @"
        }


        /*public static {C} operator *({C} {V}a, {C} {V}b) {
            " + strMul + @"
        }

        public static {C} operator *({C} {V}a, {T} v) {
            " + strMulC + @"
        }

        public static {C} operator *(float v, {C} {V}a) {
            " + strMulC + @"
        }


        public static {C} operator /({C} {V}a, {C} {V}b) {
            " + strDiv + @"
        }

        public static {C} operator /({C} {V}a, {T} v) {
            " + strDivC + @"
        }*/
    }";
            return strRet.Replace("{C}", m_cname).Replace("{V}", m_vname).Replace("{T}", m_dic_type[type]);
        }
    }
}
