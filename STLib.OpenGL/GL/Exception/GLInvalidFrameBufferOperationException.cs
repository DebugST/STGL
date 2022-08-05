using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL
{
    public class GLInvalidFrameBufferOperationException : GLException
    {
        private const string m_str_error =
            "The command is trying to render to or read from the framebuffer while the currently bound framebuffer is not framebuffer complete " +
            "(i.e. the return value from glCheckFramebufferStatus is not GL_FRAMEBUFFER_COMPLETE). " +
            "The offending command is ignored and has no other side effect than to set the error flag.";

        public GLInvalidFrameBufferOperationException() : base(m_str_error) { }
        public GLInvalidFrameBufferOperationException(string strMessage) : base(strMessage) { }
    }
}
