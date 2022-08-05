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

        public static GLException GetException() {
            var nFlag = GL.GetError();
            switch (nFlag) { 
                case GL.GL_NO_ERROR:
                    return null;
                case GL.GL_INVALID_ENUM:
                    return new GLInvalidEnumException();
                case GL.GL_INVALID_VALUE:
                    return new GLInvalidValueException();
                case GL.GL_INVALID_OPERATION:
                    return new GLInvalidOperationException();
                case GL.GL_INVALID_FRAMEBUFFER_OPERATION:
                    return new GLInvalidFrameBufferOperationException();
                case GL.GL_OUT_OF_MEMORY:
                    return new GLOutOfMemoryException();
                default:
                    throw new GLException("Unknown exception.");
            }
        }
    }
}
