using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL
{
    public class GLProgram : IDisposable
    {
        private static GLProgram m_current_program;

        public uint UID { get; private set; }

        //private Dictionary<string, uint> m_dic_loc;

        private GLProgram(uint uid) {
            this.UID = uid;
            //m_dic_loc = new Dictionary<string, uint>();
        }

        public void Use() {
            if (m_current_program == this) {
                return;
            }
            GL.UseProgram(this.UID);
        }

        public static GLProgram CreateProgram(GLShader[] shaders) {
            var uid = GL.CreateProgram();
            foreach (var v in shaders) {
                GL.AttachShader(uid, v.UID);
            }
            GLProgram.Link(uid);
            return new GLProgram(uid);
        }

        public static GLProgram CreateProgram(string strVertexShaderCode, string strFragmentShaderCode) {
            GLShader vertShader = null;
            GLShader fragShader = null;
            try {
                vertShader = GLShader.CreateShader(strVertexShaderCode, GLShaderType.Vertex);
                fragShader = GLShader.CreateShader(strFragmentShaderCode, GLShaderType.Fragment);
                return GLProgram.CreateProgram(vertShader, fragShader);
            } finally {
                if (vertShader != null) vertShader.Dispose();
                if (fragShader != null) fragShader.Dispose();
            }
        }

        public static GLProgram CreateProgram(GLShader vertexShader, GLShader fragmentShader) {
            var uid = GL.CreateProgram();
            GL.AttachShader(uid, vertexShader.UID);
            GL.AttachShader(uid, fragmentShader.UID);
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

        #region SetUniform

        #region double

        public void SetUniform(string strName, double v0, double v1, double v2, double v3) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            GL.Uniform4d(loc, v0, v1, v2, v3);
        }

        public void SetUniform(string strName, double v0, double v1, double v2) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            GL.Uniform3d(loc, v0, v1, v2);
        }

        public void SetUniform(string strName, double v0, double v1) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            GL.Uniform2d(loc, v0, v1);
        }

        public void SetUniform(string strName, double v0) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            GL.Uniform1d(loc, v0);
        }

        #endregion

        #region float

        public void SetUniform(string strName, float v0, float v1, float v2, float v3) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            GL.Uniform4f(loc, v0, v1, v2, v3);
        }

        public void SetUniform(string strName, float v0, float v1, float v2) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            GL.Uniform3f(loc, v0, v1, v2);
        }

        public void SetUniform(string strName, float v0, float v1) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            GL.Uniform2f(loc, v0, v1);
        }

        public void SetUniform(string strName, float v0) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            GL.Uniform1f(loc, v0);
        }

        #endregion

        #region uint

        public void SetUniform(string strName, uint v0, uint v1, uint v2, uint v3) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            GL.Uniform4ui(loc, v0, v1, v2, v3);
        }

        public void SetUniform(string strName, uint v0, uint v1, uint v2) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            GL.Uniform3ui(loc, v0, v1, v2);
        }

        public void SetUniform(string strName, uint v0, uint v1) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            GL.Uniform2ui(loc, v0, v1);
        }

        public void SetUniform(string strName, uint v0) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            GL.Uniform1ui(loc, v0);
        }

        #endregion

        #region int

        public void SetUniform(string strName, int v0, int v1, int v2, int v3) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            GL.Uniform4i(loc, v0, v1, v2, v3);
        }

        public void SetUniform(string strName, int v0, int v1, int v2) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            GL.Uniform3i(loc, v0, v1, v2);
        }

        public void SetUniform(string strName, int v0, int v1) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            GL.Uniform2i(loc, v0, v1);
        }

        public void SetUniform(string strName, int v0) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            if (loc == -1) {
                // TODO: ADD exception
            }
            GL.Uniform1i(loc, v0);
        }
        /// <summary>
        /// Note:<para>OpenGL uses column major matrix order,So this function will auto call mat.SwapRowCol()</para>
        /// </summary>
        /// <param name="strName">variable name</param>
        /// <param name="mat">matrix</param>
        public void SetUniform(string strName, Mathematics.Matrix4F mat) {
            mat = mat.SwapRowCol();
            var loc = GL.GetUniformLocation(this.UID, strName);
            GL.UniformMatrix4fv(loc, 1, false, ref mat.Row0.X);
        }

        #endregion

        #endregion

        #region GetUniform

        public double[] GetUniformD(string strName) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            var ps = new double[4];
            GL.GetUniformdv(this.UID, loc, ref ps[0]);
            return ps;
        }

        public float[] GetUniformF(string strName) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            var ps = new float[4];
            GL.GetUniformfv(this.UID, loc, ref ps[0]);
            return ps;
        }

        public uint[] GetUniformUI(string strName) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            var ps = new uint[4];
            GL.GetUniformuiv(this.UID, loc, ref ps[0]);
            return ps;
        }

        public int[] GetUniformI(string strName) {
            var loc = GL.GetUniformLocation(this.UID, strName);
            var ps = new int[4];
            GL.GetUniformiv(this.UID, loc, ref ps[0]);
            return ps;
        }

        #endregion

        public void Dispose() {
            GL.DeleteProgram(this.UID);
        }
    }
}
