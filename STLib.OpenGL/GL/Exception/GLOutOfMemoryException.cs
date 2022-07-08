using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL
{
    public class GLOutOfMemoryException : GLException
    {
        private const string m_str_error =
            "There is not enough memory left to execute the command. The state of the GL is undefined, " +
            "except for the state of the error flags, after this error is recorded.";

        public GLOutOfMemoryException() : base(m_str_error) { }
        public GLOutOfMemoryException(string message) : base(message) { }
    }
}
