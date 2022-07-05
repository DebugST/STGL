using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace STLib.OpenGL.GL
{
    public partial class GLNative   // GLNative.Init.cs
    {
        public static int InitedFunctions { get; private set; }
        public static bool IsInited { get; private set; }
        /// <summary>
        /// Procedure address getter
        /// <para>
        /// Getter is used to find all functions in OpenGL.
        /// If you are already using GLFW then you can pass glfwGetProcAddress as Getter.
        /// Otherwise, you need to obtain it by yourself through other means.
        /// </para>
        /// e.g.
        /// <para>If you are on windows you can use wglGetProcAddress from opengl32.dll.</para>
        /// </summary>
        /// <param name="strName">the procedure name</param>
        /// <returns>If no error return the procedure address, otherwise return the IntPtr.Zero</returns>
        public delegate IntPtr ProcAddressGetter(string strName);
        /// <summary>
        /// Init the OpenGL
        /// <para>Noe:</para>
        /// <para>
        /// The initialization requires an OpenGL context. If the initialization fails, please create a context and try again.
        /// This method will not init all the OpenGL procedure, It is only initialized when a method is used. 
        /// Ensure the validity of the Getter during this period.
        /// </para>
        /// </summary>
        /// <param name="ProcGetter">Procedure getter, see <see cref="ProcAddressGetter"/></param>
        public static bool Init(ProcAddressGetter procGetter) {
            if (GLNative.IsInited) return true;
            if (procGetter == null) {
                throw new ArgumentNullException("procGetter");
            }
            m_getter = procGetter;
            GLNative.Info = new Information(m_dic_proc);
            GLNative.Info.SupportedProcedures = m_dic_proc.Count;
            GLNative.Info.Version = GL.GetString(GL.GL_VERSION);
            GLNative.Info.Vendor = GL.GetString(GL.GL_VENDOR);
            GLNative.Info.Renderer = GL.GetString(GL.GL_RENDERER);
            GLNative.Info.ShadingLanguageVersion = GL.GetString(GL.GL_SHADING_LANGUAGE_VERSION);
            if (GLNative.Info.Version.Trim()[0] < '3') {
                string strExt = GL.GetString(GL.GL_EXTENSIONS);
                if (!string.IsNullOrEmpty(strExt)) {
                    foreach (var v in strExt.Split(',')) {
                        GLNative.Info.Extensions.SetExtension(v);
                    }
                }
            } else {
                int nNum = 0;
                GL.GetIntegerv(GL.GL_NUM_EXTENSIONS, ref nNum);
                for (uint i = 0; i < nNum; i++) {
                    GLNative.Info.Extensions.SetExtension(GL.GetStringi(GL.GL_EXTENSIONS, i));
                }
            }
            GLNative.IsInited = true;
            return true;
        }
        /// <summary>
        /// Init all the OpenGL procedure
        /// <para>Note:</para>
        /// <para>
        /// The initialization requires an OpenGL context. If the initialization fails, please create a context and try again.
        /// This method will init all the OpenGL procedure, It may take some time.
        /// </para>
        /// </summary>
        /// <param name="procGetter">Procedure getter, see <see cref="ProcAddressGetter"/></param>
        /// <returns>How many functions are initialized.</returns>
        public static int InitAll(ProcAddressGetter procGetter) {
            GLNative.Init(procGetter);
            foreach (var pi in GLNativeDeclare.GetAllProcInfos()) {
                if (m_dic_proc.ContainsKey(pi.Name)) {
                    continue;
                }
                IntPtr ptr = procGetter(pi.Name);
                if (ptr == IntPtr.Zero) {
                    m_dic_proc.Add(pi.Name, null);
                    continue;
                }
                var func = Marshal.GetDelegateForFunctionPointer(ptr, pi.Type);
                m_dic_proc.Add(pi.Name, func);
                GLNative.InitedFunctions++;
            }
            return GLNative.InitedFunctions;
        }
    }
}
