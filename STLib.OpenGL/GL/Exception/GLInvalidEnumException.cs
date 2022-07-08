using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL
{
    public class GLInvalidEnumException : GLException
    {
        private const string m_str_error = 
            "An unacceptable value is specified for an enumerated argument. " + 
            "The offending command is ignored and has no other side effect than to set the error flag.";

        public GLInvalidEnumException() : base(m_str_error) { }
        public GLInvalidEnumException(string message) : base(message) { }
    }
}
