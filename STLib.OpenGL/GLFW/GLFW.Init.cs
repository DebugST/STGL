using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace STLib.OpenGL.GLFW
{
    partial class GLFW
    {
        static GLFW() {
            GLFW.ReleaseLib(GLFWNative.STR_LIB_PATH);
        }

        private static void ReleaseLib(string strPath) {
            var splitor = new char[] { '/', '\\', ' ', '\t', '\r', '\n' };
            if (!Path.IsPathRooted(strPath)) {
                if (strPath.StartsWith("./") || strPath.StartsWith(".\\")) {
                    strPath = strPath.TrimStart(new char[] { '.', '\\', '/' });
                }
                strPath = Path.Combine(
                    Path.GetDirectoryName(typeof(GLFW).Assembly.Location),
                    strPath.Trim(splitor)
                    );
            }
            Directory.CreateDirectory(strPath);
            ResourceManager.ReleaseFile("LICENSE.GLFW.md", strPath + "/LICENSE.GLFW.md");
            ResourceManager.ReleaseFile("LICENSE.STGL.md", strPath + "/LICENSE.STGL.md");

            switch (RuntimeInfo.System) {
                case RuntimeInfo.SystemType.Mac:
                    switch (RuntimeInfo.Platform) {
                        case RuntimeInfo.PlatformType.ARM:
                            if (RuntimeInfo.Bit == RuntimeInfo.BitType.Bit64) {
                                GLFW.ReleaseLib("glfw3.mac.arm64.dylib", strPath + "/glfw3.dylib");
                                return;
                            }
                            break;
                        case RuntimeInfo.PlatformType.X86_64:
                            if (RuntimeInfo.Bit == RuntimeInfo.BitType.Bit64) {
                                GLFW.ReleaseLib("glfw3.mac.x86_64.dylib", strPath + "/glfw3.dylib");
                                return;
                            }
                            break;
                    }
                    break;
                case RuntimeInfo.SystemType.Windows:
                    switch (RuntimeInfo.Platform) {
                        case RuntimeInfo.PlatformType.NT:
                            if (RuntimeInfo.Bit == RuntimeInfo.BitType.Bit32) {
                                GLFW.ReleaseLib("glfw3.win.x86.mingw.dll", strPath + "/glfw3.dll");
                                return;
                            }
                            if (RuntimeInfo.Bit == RuntimeInfo.BitType.Bit64) {
                                GLFW.ReleaseLib("glfw3.win.x64.mingw.dll", strPath + "/glfw3.dll");
                                return;
                            }
                            break;
                    }
                    break;
            }
            if (File.Exists(strPath + "/glfw3")) {
                return;
            }
            throw new PlatformNotSupportedException(
                "STGL relies on GLFW, and the GLFW library packaged in STGL does not support the current runtime environment. " +
                "[" + RuntimeInfo.System + "][" + RuntimeInfo.Platform + "][" + RuntimeInfo.Bit + "] - [" + RuntimeInfo.Version + "]. " +
                "If you compiled GLFW manually, you can copy the library to [" + strPath + "/glfw3](without extension) and try to run the program again. " +
                "https://www.glfw.org/docs/latest/compile_guide.html#compile_generate"
                );
        }

        private static void ReleaseLib(string strName, string strDstFile) {
            var res = ResourceManager.Get(strName);
            if (File.Exists(strDstFile)) {
                string strMD5 = ResourceManager.GetMd5(File.ReadAllBytes(strDstFile));
                if (res.MD5 == strMD5) {
                    return;
                }
                bool bDelete = false;
                foreach (var v in ResourceManager.GetAll()) {
                    if (v.MD5 == strMD5) {
                        bDelete = true;
                        break;
                    }
                }
                if (!bDelete) {
                    return;
                }
                File.Delete(strDstFile);
            }
            ResourceManager.ReleaseFile(strName, strDstFile);
        }
        /// <summary>
        /// Initializes the GLFW library.
        /// <para>
        /// This function initializes the GLFW library.  Before most GLFW functions can
        /// be used, GLFW must be initialized, and before an application terminates GLFW
        /// should be terminated in order to free any resources allocated during or
        /// after initialization.
        /// </para>
        /// <para>
        /// If this function fails, it calls <see cref="Terminate"/> before returning.  If it
        /// succeeds, you should call <see cref="Terminate"/> before the application exits.
        /// </para>
        /// <para>
        /// Additional calls to this function after successful initialization but before
        /// termination will return <c>GLFW_TRUE</c> immediately.
        /// </para>
        /// <para>errors: Possible errors include <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI int glfwInit(void);
        /// </code>
        /// </para>
        /// </summary>
        /// <returns>
        /// <c>GLFW_TRUE</c> if successful, or <c>GLFW_FALSE</c> if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        /// <remarks>
        /// [macos] This function will change the current directory of the
        /// application to the <c>Contents/Resources</c> subdirectory of the application's
        /// bundle, if present.  This can be disabled with the <see cref="COCOA_CHDIR_RESOURCES"/> init hint.
        /// </remarks>
        /// <remarks>
        /// [x11] This function will set the <c>LC_CTYPE</c> category of the
        /// application locale according to the current environment if that category is
        /// still "C".  This is because the "C" locale breaks Unicode text input.
        /// </remarks>
        /// <seealso cref="Terminate"/>
        public static bool Init() {
            return GLFWNative.glfwInit() == GLFW.TRUE;
        }
    }
}
