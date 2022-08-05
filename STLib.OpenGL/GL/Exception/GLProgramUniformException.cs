using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL
{
    public class GLProgramUniformException : GLException
    {
        public GLProgramUniformException() { }
        public GLProgramUniformException(string strMessage) : base(strMessage) { }
    }
}
