using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace STLib.OpenGL.GL
{
    partial class GL    // GL.Init.cs
    {
        public static bool IsInited {
            get { return GLNative.IsInited; }
        }

        public static int InitedFunctions {
            get { return GLNative.InitedFunctions; }
        }

        public static GLNative.Information Info {
            get { return GLNative.Info; }
        }
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
        public static void Init(ProcAddressGetter ProcGetter) {
            GLNative.Init(new GLNative.ProcAddressGetter(ProcGetter));
        }
        /// <summary>
        /// Init all the OpenGL procedure
        /// <para>Note:</para>
        /// <para>
        /// The initialization requires an OpenGL context. If the initialization fails, please create a context and try again.
        /// This method will init all the OpenGL procedure, It may take some time.
        /// </para>
        /// </summary>
        /// <param name="ProcGetter">Procedure getter, see <see cref="ProcAddressGetter"/></param>
        /// <returns>How many functions are initialized.</returns>
        public static int InitAll(ProcAddressGetter ProcGetter) {
            return GLNative.InitAll(new GLNative.ProcAddressGetter(ProcGetter));
        }
    }
}