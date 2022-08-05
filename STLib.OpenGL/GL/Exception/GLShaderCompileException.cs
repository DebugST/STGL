using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL
{
    public class GLShaderCompileException : Exception
    {
        public GLShaderCompileException() { }
        public GLShaderCompileException(string strMessage) : base(strMessage) { }
    }
}
