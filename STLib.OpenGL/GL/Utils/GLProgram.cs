using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using STLib.OpenGL.GLM;

namespace STLib.OpenGL.GL
{
    public class GLProgram : GLObject, IDisposable
    {
        private static GLProgram m_current_program = null;

        private Dictionary<string, int> m_dic_loc;

        private GLProgram(uint uid) {
            this.UID = uid;
            m_dic_loc = new Dictionary<string, int>();
        }

        public static GLProgram Create(string strVertexShader, string strFragmentShader) {
            GLShader[] shaders = new GLShader[2];
            if (string.IsNullOrEmpty(strVertexShader)) {
                throw new ArgumentException("strVertexShader can not be empty.");
            }
            if (string.IsNullOrEmpty(strFragmentShader)) {
                throw new ArgumentException("strFragmentShader can not be empty.");
            }
            try {
                shaders[0] = GLShader.Create(strVertexShader, GLShaderType.Vertex);
                shaders[1] = GLShader.Create(strFragmentShader, GLShaderType.Fragment);
                return GLProgram.Create(shaders);
            } finally {
                foreach (var v in shaders) {
                    if (v == null) break;
                    v.Dispose();
                }
            }
        }

        public static GLProgram Create(string strVertexShader, string strGeometryShader, string strFragmentShader) {
            GLShader[] shaders = new GLShader[3];
            if (string.IsNullOrEmpty(strVertexShader)) {
                throw new ArgumentException("strVertexShader can not be empty.");
            }
            if (string.IsNullOrEmpty(strGeometryShader)) {
                throw new ArgumentException("strGeometryShader can not be empty.");
            }
            if (string.IsNullOrEmpty(strFragmentShader)) {
                throw new ArgumentException("strFragmentShader can not be empty.");
            }
            try {
                shaders[0] = GLShader.Create(strVertexShader, GLShaderType.Vertex);
                shaders[1] = GLShader.Create(strGeometryShader, GLShaderType.Geometry);
                shaders[2] = GLShader.Create(strFragmentShader, GLShaderType.Fragment);
                return GLProgram.Create(shaders);
            } finally {
                foreach (var v in shaders) {
                    if (v == null) break;
                    v.Dispose();
                }
            }
        }

        public static GLProgram Create(params GLShader[] shaders) {
            var uid = GL.CreateProgram();
            foreach (var s in shaders) {
                GL.AttachShader(uid, s.UID);
            }
            GLProgram.Link(uid);
            return new GLProgram(uid);
        }

        public static void Link(uint uid) {
            GL.LinkProgram(uid);
            int nFlag = GL.GetProgramiv(uid, GL.GL_LINK_STATUS);
            if (nFlag == 0) {
                int nLen = 0;
                byte[] byBuffer = new byte[1024];
                GL.GetProgramInfoLog(uid, byBuffer.Length, ref nLen, ref byBuffer[0]);
                GL.DeleteProgram(uid);
                string strError = Encoding.UTF8.GetString(byBuffer, 0, nLen);
                throw new GLProgramLinkException(strError);
            }
        }

        public void Use() {
            if (m_current_program == this) {
                return;
            }
            GL.UseProgram(this.UID);
        }

        #region SetUniform

        #region double

        public void SetUniform(string strName, double v0, double v1, double v2, double v3) {
            var loc = this.GetLocation(strName);
            GL.Uniform4d(loc, v0, v1, v2, v3);
        }

        public void SetUniform(string strName, double v0, double v1, double v2) {
            var loc = this.GetLocation(strName);
            GL.Uniform3d(loc, v0, v1, v2);
        }

        public void SetUniform(string strName, double v0, double v1) {
            var loc = this.GetLocation(strName);
            GL.Uniform2d(loc, v0, v1);
        }

        public void SetUniform(string strName, double v0) {
            var loc = this.GetLocation(strName);
            GL.Uniform1d(loc, v0);
        }

        #endregion

        #region float

        public void SetUniform(string strName, float v0, float v1, float v2, float v3) {
            var loc = this.GetLocation(strName);
            GL.Uniform4f(loc, v0, v1, v2, v3);
        }

        public void SetUniform(string strName, float v0, float v1, float v2) {
            var loc = this.GetLocation(strName);
            GL.Uniform3f(loc, v0, v1, v2);
        }

        public void SetUniform(string strName, float v0, float v1) {
            var loc = this.GetLocation(strName);
            GL.Uniform2f(loc, v0, v1);
        }

        public void SetUniform(string strName, float v0) {
            var loc = this.GetLocation(strName);
            GL.Uniform1f(loc, v0);
        }

        #endregion

        #region uint

        public void SetUniform(string strName, uint v0, uint v1, uint v2, uint v3) {
            var loc = this.GetLocation(strName);
            GL.Uniform4ui(loc, v0, v1, v2, v3);
        }

        public void SetUniform(string strName, uint v0, uint v1, uint v2) {
            var loc = this.GetLocation(strName);
            GL.Uniform3ui(loc, v0, v1, v2);
        }

        public void SetUniform(string strName, uint v0, uint v1) {
            var loc = this.GetLocation(strName);
            GL.Uniform2ui(loc, v0, v1);
        }

        public void SetUniform(string strName, uint v0) {
            var loc = this.GetLocation(strName);
            GL.Uniform1ui(loc, v0);
        }

        #endregion

        #region int

        public void SetUniform(string strName, int v0, int v1, int v2, int v3) {
            var loc = this.GetLocation(strName);
            GL.Uniform4i(loc, v0, v1, v2, v3);
        }

        public void SetUniform(string strName, int v0, int v1, int v2) {
            var loc = this.GetLocation(strName);
            GL.Uniform3i(loc, v0, v1, v2);
        }

        public void SetUniform(string strName, int v0, int v1) {
            var loc = this.GetLocation(strName);
            GL.Uniform2i(loc, v0, v1);
        }

        public void SetUniform(string strName, int v0) {
            var loc = this.GetLocation(strName);
            GL.Uniform1i(loc, v0);
        }

        public void SetUniform(string strName, Matrix4F mat) {
            var loc = this.GetLocation(strName);
            GL.UniformMatrix4fv(loc, 1, false, ref mat.Col0.X);
        }

        public void SetUniform(string strName, Matrix4F mat, bool bTranspose) {
            var loc = this.GetLocation(strName);
            GL.UniformMatrix4fv(loc, 1, bTranspose, ref mat.Col0.X);
        }

        #endregion

        #endregion

        #region GetUniform

        public double[] GetUniformD(string strName) {
            var loc = this.GetLocation(strName);
            var ps = new double[4];
            GL.GetUniformdv(this.UID, loc, ref ps[0]);
            return ps;
        }

        public float[] GetUniformF(string strName) {
            var loc = this.GetLocation(strName);
            var ps = new float[4];
            GL.GetUniformfv(this.UID, loc, ref ps[0]);
            return ps;
        }

        public uint[] GetUniformUI(string strName) {
            var loc = this.GetLocation(strName);
            var ps = new uint[4];
            GL.GetUniformuiv(this.UID, loc, ref ps[0]);
            return ps;
        }

        public int[] GetUniformI(string strName) {
            var loc = this.GetLocation(strName);
            var ps = new int[4];
            GL.GetUniformiv(this.UID, loc, ref ps[0]);
            return ps;
        }

        #endregion

        private int GetLocation(string strName) {
            int loc = -1;
            if (m_dic_loc.ContainsKey(strName)) {
                loc = m_dic_loc[strName];
            } else {
                loc = GL.GetUniformLocation(this.UID, strName);
                if (loc == -1) {
                    new GLProgramUniformException("Can not found the name [" + strName + "]");
                }
                m_dic_loc.Add(strName, loc);
            }
            return loc;
        }

        public void Dispose() {
            GL.DeleteProgram(this.UID);
        }
    }
}
