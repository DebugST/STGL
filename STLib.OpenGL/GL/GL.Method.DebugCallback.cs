using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace STLib.OpenGL.GL
{
    partial class GL    // GL.Method.DebugCallback
    {
        /*
         * In fact, these functions are also included in GL.Method.Unsafe, but their parameters are different. 
         * GLNative.GLDEBUGPROC is used in GL.Method.Unsafe. The signature of GLNatvie.GLDEBUGPROC is as follows:
         * (uint source, uint type, uint id, uint severity, int length, byte* message, void* userParam)
         * obviously. The author does not want developers to use pointers directly, so they are encapsulated.
         * For more information on the Debug method, please refer to the extended documentation: 
         * ARB_debug_output, AMD_debug_output, KHR_debug
         * Link: https://github.com/KhronosGroup/OpenGL-Registry/tree/main/extensions
         */
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void DEBUGPROC(uint source, uint type, uint id, uint severity, string message, object userParam);

        private static DEBUGPROC m_callback_method = null;
        private static DEBUGPROC m_callback_method_arb = null;
        private static DEBUGPROC m_callback_method_amd = null;
        private static DEBUGPROC m_callback_method_khr = null;

        private static object m_callback_userparam;
        private static object m_callback_userparam_arb;
        private static object m_callback_userparam_amd;
        private static object m_callback_userparam_khr;

        public unsafe static void DebugMessageCallback(DEBUGPROC callback, object userParam) {
            if (callback == null) {
                GLNative.glDebugMessageCallback(null, null);
                return;
            }
            m_callback_userparam = userParam;
            m_callback_method = callback;
            GLNative.glDebugMessageCallback(DebugCallback, null);
        }

        public unsafe static void DebugMessageCallbackARB(DEBUGPROC callback, object userParam) {
            if (callback == null) {
                GLNative.glDebugMessageCallbackARB(null, null);
                return;
            }
            m_callback_userparam_arb = userParam;
            m_callback_method_arb = callback;
            GLNative.glDebugMessageCallbackARB(DebugCallbackARB, null);
        }

        public unsafe static void DebugMessageCallbackAMD(DEBUGPROC callback, object userParam) {
            if (callback == null) {
                GLNative.glDebugMessageCallbackAMD(null, null);
                return;
            }
            m_callback_userparam_amd = userParam;
            m_callback_method_amd = callback;
            GLNative.glDebugMessageCallbackAMD(DebugCallbackAMD, null);
        }

        public unsafe static void DebugMessageCallbackKHR(DEBUGPROC callback, object userParam) {
            if (callback == null) {
                GLNative.glDebugMessageCallbackKHR(null, null);
                return;
            }
            m_callback_userparam_khr = userParam;
            m_callback_method_khr = callback;
            GLNative.glDebugMessageCallbackKHR(DebugCallbackKHR, null);
        }

        private unsafe static void DebugCallback(uint source, uint type, uint id, uint severity, int length, byte* message, void* userParam) {
            var str = MarshalExtend.PtrToString(message, length);
            m_callback_method(source, type, id, severity, str, m_callback_userparam);
        }

        private unsafe static void DebugCallbackARB(uint source, uint type, uint id, uint severity, int length, byte* message, void* userParam) {
            var str = MarshalExtend.PtrToString(message, length);
            m_callback_method_arb(source, type, id, severity, str, m_callback_userparam_arb);
        }

        private unsafe static void DebugCallbackAMD(uint source, uint type, uint id, uint severity, int length, byte* message, void* userParam) {
            var str = MarshalExtend.PtrToString(message, length);
            m_callback_method_amd(source, type, id, severity, str, m_callback_userparam_amd);
        }

        private unsafe static void DebugCallbackKHR(uint source, uint type, uint id, uint severity, int length, byte* message, void* userParam) {
            var str = MarshalExtend.PtrToString(message, length);
            m_callback_method_khr(source, type, id, severity, str, m_callback_userparam_khr);
        }
    }
}
