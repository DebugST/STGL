using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL
{
    public class GLInvalidValueException : GLException
    {
        private const string m_str_error = 
            "The specified operation is not allowed in the current state. " + 
            "The offending command is ignored and has no other side effect than to set the error flag.";

        public GLInvalidValueException() : base(m_str_error) { }
        public GLInvalidValueException(string strMessage) : base(strMessage) { }
    }
}
