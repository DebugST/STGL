using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL
{
    public class GLException : Exception
    {
        public GLException() { }
        public GLException(string message) : base(message) { }

        public void Check() {
            var nFlag = GL.GetError();
            switch (nFlag) { 
                case GL.GL_NO_ERROR:
                    return;
                case GL.GL_INVALID_ENUM:
                    throw new GLInvalidEnumException();
                case GL.GL_INVALID_VALUE:
                    throw new GLInvalidValueException();
                case GL.GL_INVALID_OPERATION:
                    throw new GLInvalidOperationException();
                case GL.GL_INVALID_FRAMEBUFFER_OPERATION:
                    throw new GLInvalidFrameBufferOperationException();
                case GL.GL_OUT_OF_MEMORY:
                    throw new GLOutOfMemoryException();
                default:
                    throw new GLException("Unknown exception.");
            }
        }
    }
}
