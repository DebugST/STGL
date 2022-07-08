using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL
{
    public class GLProgramLinkException : GLException
    {
        public GLProgramLinkException() { }
        public GLProgramLinkException(string message) : base(message) { }
    }
}
