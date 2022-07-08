using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL
{
    public class GLInvalidOperationException : GLException
    {
        private const string m_str_error =
            "The specified operation is not allowed in the current state. " +
            "The offending command is ignored and has no other side effect than to set the error flag.";

        public GLInvalidOperationException() : base(m_str_error) { }
        public GLInvalidOperationException(string message) : base(message) { }
    }
}
