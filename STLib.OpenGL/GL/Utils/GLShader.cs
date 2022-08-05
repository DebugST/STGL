using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL
{
    public enum GLShaderType : uint
    {
        Vertex = GL.GL_VERTEX_SHADER,
        Fragment = GL.GL_FRAGMENT_SHADER,
        Geometry = GL.GL_GEOMETRY_SHADER
    }

    public class GLShader :GLObject, IDisposable
    {
        public GLShaderType Type { get; private set; }

        private GLShader(uint uid, GLShaderType type) {
            this.UID = uid;
            this.Type = type;
        }

        public static GLShader Create(string strCode, GLShaderType type) {
            uint uid = 0;
            uid = GL.CreateShader((uint)type);
            GL.ShaderSource(uid, strCode);
            GL.CompileShader(uid);
            int nFlag = GL.GetShaderiv(uid, GL.GL_COMPILE_STATUS);
            if (nFlag == 0) {
                int nLen = 0;
                byte[] byBuffer = new byte[1024];
                GL.GetShaderInfoLog(uid, byBuffer.Length, ref nLen, ref byBuffer[0]);
                GL.DeleteShader(uid);
                string strError = Encoding.UTF8.GetString(byBuffer, 0, nLen);
                throw new GLShaderCompileException(strError);
            }
            return new GLShader(uid, type);
        }

        public void Dispose() {
            GL.DeleteShader(this.UID);
        }
    }
}
