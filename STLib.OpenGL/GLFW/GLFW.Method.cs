using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Runtime.InteropServices;

namespace STLib.OpenGL.GLFW
{
    /// <summary>
    /// GLFW is an Open Source, multi-platform library for OpenGL, OpenGL ES and Vulkan development on the desktop. 
    /// It provides a simple API for creating windows, contexts and surfaces, receiving input and events.
    /// <para>
    /// GLFW is written in C and supports Windows, macOS, X11 and Wayland.
    /// </para>
    /// <para>
    /// GLFW is licensed under the (zlib/libpng license)<see cref="https://www.glfw.org/license.html"/>.
    /// </para>
    /// <para>Note: These codes and comments are converted from GLFW(glfw3.h).</para>
    /// <para>Version: 3.3.7</para>
    /// <para>link: <see cref="https://www.glfw.org"/></para>
    /// <para>Date: 2022-07-11</para>
    /// <para>Author: DebugST -> <see cref="https://github.com/DebugST"/></para>
    /// </summary>
    public partial class GLFW
    {
        #region some callback process

        //private static CBError m_cb_error = null;
        private static CBWindowPos m_cb_window_pos = null;
        private static CBWindowSize m_cb_window_size = null;
        private static CBWindowClose m_cb_window_close = null;
        private static CBWindowRefresh m_cb_window_refresh = null;
        private static CBWindowFocus m_cb_window_focus = null;
        private static CBWindowIconify m_cb_window_iconify = null;
        private static CBWindowMaximize m_cb_window_maximize = null;
        private static CBFrameBufferSize m_cb_frame_buffer_size = null;
        private static CBWindowContentScale m_cb_window_content_scale = null;
        private static CBMouseButton m_cb_mouse_button = null;
        private static CBCursorPos m_cb_cursor_pos = null;
        private static CBCursorEnter m_cb_cursor_enter = null;
        private static CBScroll m_cb_scroll = null;
        private static CBKey m_cb_key = null;
        private static CBChar m_cb_char = null;
        private static CBCharMods m_cb_char_mods = null;
        //private static CBDrop m_cb_drop = null;
        private static CBMonitor m_cb_monitor = null;
        private static CBJoystick m_cb_joystick = null;

        /// <summary>
        /// This dictionary for <see cref="GLFW.SetDropCallback"/>.
        /// <para>The callback original signature in glfw3.h</para>
        /// <code>typedef void (* GLFWdropfun)(GLFWwindow* window, int path_count, const char* paths[])</code>
        /// <para>But I want to use this signature.</para>
        /// <code>public delegate void FunDrop(IntPtr, int, string[]);</code>
        /// <para>
        /// So when calling <see cref="GLFW.SetDropCallback"/> I will save the callback to this dictionary 
        /// and pass <see cref="GLFW.DropFunCallBack"/> to <see cref="GLFWNative.glfwSetDropCallback"/>. 
        /// Then I will convert the encoding in <see cref="GLFW.DropFunCallBack"/>, and then use those callback.
        /// </para>
        /// </summary>
        private static Dictionary<IntPtr, CBDrop> m_dic_callback_drop = new Dictionary<IntPtr, CBDrop>();

        /// <summary>
        /// This callback for <see cref="GLFW.SetErrorCallback"/>.
        /// <para>The callback original signature in glfw3.h</para>
        /// <code>typedef void (* GLFWerrorfun)(int error_code, const char* description);</code>
        /// <para>In C# I can't directly convert it to such a signature.</para>
        /// <code>public delegate void FunError(int, string);</code>
        /// <para>And I use <see cref="GLFW.ErrorFunCallback"/>(int, byte*)</para>
        /// <para>
        /// Because the strings used by glfw are encoded in utf-8, and in C#, the string type uses unicode encoding in memory. 
        /// So direct assignment may have unexpected problems. Such as when the string is a non-ASCII character.
        /// </para>
        /// <para>
        /// So when calling <see cref="GLFW.SetErrorCallback"/> I will save the callback to this variable 
        /// and pass <see cref="GLFW.ErrorFunCallback"/> to <see cref="GLFWNavate.glfwSetErrorCallback"/>. 
        /// Then I will convert the encoding in <see cref="GLFW.ErrorFunCallback"/>, and then use this callback.
        /// </para>
        /// </summary>
        private static CBError m_cb_error;

        /// <summary>
        /// This callback for <see cref="GLFWNative.glfwSetErrorCallback"/>.
        /// <para>The callback original signature in glfw3.h</para>
        /// <code>typedef void (* GLFWerrorfun)(int error_code, const char* description);</code>
        /// <para>In C# I can't directly convert it to such a signature.</para>
        /// <code>public delegate void FunError(int, string);</code>
        /// <para>
        /// Because the strings used by glfw are encoded in utf-8, and in C#, the string type uses unicode encoding in memory. 
        /// So direct assignment may have unexpected problems. Such as when the string is a non-ASCII character.
        /// </para>
        /// </summary>
        /// <param name="error_code">
        /// [in] An [error code](@ref errors).  Future releases may add more error codes.
        /// </param>
        /// <param name="description">[in] A UTF-8 encoded string describing the error.</param>
        /// <seealso cref="SetErrorCallback"/>
        private static unsafe void ErrorFunCallback(int error_code, byte* description) {
            string str = MarshalExtend.PtrToString(description);
            if (m_cb_error != null) {
                m_cb_error(error_code, str);
            }
        }

        /// <summary>
        /// <para>The callback original signature in glfw3.h</para>
        /// <code>typedef void (* GLFWdropfun)(GLFWwindow* window, int path_count, const char* paths[])</code>
        /// <para>But I want to use this signature.</para>
        /// <code>public delegate void FunDrop(IntPtr, string[]);</code>
        /// <para>
        /// So when calling <see cref="GLFW.SetDropCallback"/> I will pass this method to <see cref="GLFWNative.glfwSetDropCallback"/>. 
        /// Then I will convert the encoding in this method, 
        /// and then call the saved callback that pass to <see cref="GLFW.SetDropCallback"/>.
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window that received the event.</param>
        /// <param name="path_count">[in] The number of dropped paths.</param>
        /// <param name="paths">[in] The UTF-8 encoded file and/or directory path names.</param>
        /// <seealso cref="SetDropCallback"/>
        private static unsafe void DropFunCallBack(IntPtr window, int path_count, byte** paths) {
            CBDrop fun = null;
            lock (m_dic_callback_drop) {
                if (m_dic_callback_drop.ContainsKey(window)) {
                    fun = m_dic_callback_drop[window];
                }
            }
            if (fun == null) return;
            string[] strPaths = new string[path_count];
            for (int i = 0; i < path_count; i++) {
                byte* ptr = *(paths + i);
                if (ptr == null) continue;
                strPaths[i] = MarshalExtend.PtrToString(ptr);
            }
            fun(window, strPaths);
        }

        #endregion some callback process

        /// <summary>
        /// Retrieves the version of the GLFW library.
        /// <para>
        /// This function retrieves the major, minor and revision numbers of the GLFW
        /// library.  It is intended for when you are using GLFW as a shared library and
        /// want to ensure that you are using the minimum required version.
        /// </para>
        /// <para>Any or all of the version arguments may be <c>NULL</c>.</para>
        /// <para>errors: None.</para>
        /// <para>thread_safety: This function may be called from any thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwGetVersion(int* major, int* minor, int* rev);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="major">[out] Where to store the major version number, or <c>NULL</c>.</param>
        /// <param name="minor">[out] Where to store the minor version number, or <c>NULL</c>.</param>
        /// <param name="rev">[out] Where to store the revision number, or <c>NULL</c>.</param>
        /// <remarks>This function may be called before <see cref="Init"/>.</remarks>
        /// <seealso cref="GetVersionString"/>
        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwGetVersion", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetVersion(ref int major, ref int minor, ref int rev);
        /// <summary>
        /// Returns the position of the monitor's viewport on the virtual screen.
        /// <para>
        /// This function returns the position, in screen coordinates, of the upper-left
        /// corner of the specified monitor.
        /// </para>
        /// <para>
        /// Any or all of the position arguments may be <c>NULL</c>.  If an error occurs, all
        /// non-<c>NULL</c> position arguments will be set to zero.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwGetMonitorPos(GLFWmonitor* monitor, int* xpos, int* ypos);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="monitor">[in] The monitor to query.</param>
        /// <param name="xpos">[out] Where to store the monitor x-coordinate, or <c>NULL</c>.</param>
        /// <param name="ypos">[out] Where to store the monitor y-coordinate, or <c>NULL</c>.</param>
        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwGetMonitorPos", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetMonitorPos(IntPtr monitor, ref int xpos, ref int ypos);
        /// <summary>
        /// Retrieves the work area of the monitor.
        /// <para>
        /// This function returns the position, in screen coordinates, of the upper-left
        /// corner of the work area of the specified monitor along with the work area
        /// size in screen coordinates. The work area is defined as the area of the
        /// monitor not occluded by the operating system task bar where present. If no
        /// task bar exists then the work area is the monitor resolution in screen
        /// coordinates.
        /// </para>
        /// <para>
        /// Any or all of the position and size arguments may be <c>NULL</c>.  If an error
        /// occurs, all non-<c>NULL</c> position and size arguments will be set to zero.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwGetMonitorWorkarea(GLFWmonitor* monitor, int* xpos, int* ypos, int* width, int* height);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="monitor">[in] The monitor to query.</param>
        /// <param name="xpos">[out] Where to store the monitor x-coordinate, or <c>NULL</c>.</param>
        /// <param name="ypos">[out] Where to store the monitor y-coordinate, or <c>NULL</c>.</param>
        /// <param name="width">[out] Where to store the monitor width, or <c>NULL</c>.</param>
        /// <param name="height">[out] Where to store the monitor height, or <c>NULL</c>.</param>
        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwGetMonitorWorkarea", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetMonitorWorkarea(IntPtr monitor, ref int xpos, ref int ypos, ref int width, ref int height);
        /// <summary>
        /// Returns the physical size of the monitor.
        /// <para>
        /// This function returns the size, in millimetres, of the display area of the
        /// specified monitor.
        /// </para>
        /// <para>
        /// Some systems do not provide accurate monitor size information, either
        /// because the monitor
        /// [EDID](https://en.wikipedia.org/wiki/Extended_display_identification_data)
        /// data is incorrect or because the driver does not report it accurately.
        /// </para>
        /// <para>
        /// Any or all of the size arguments may be <c>NULL</c>.  If an error occurs, all
        /// non-<c>NULL</c> size arguments will be set to zero.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwGetMonitorPhysicalSize(GLFWmonitor* monitor, int* widthMM, int* heightMM);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="monitor">[in] The monitor to query.</param>
        /// <param name="widthMM">
        /// [out] Where to store the width, in millimetres, of the
        /// monitor's display area, or <c>NULL</c>.
        /// </param>
        /// <param name="heightMM">
        /// [out] Where to store the height, in millimetres, of the
        /// monitor's display area, or <c>NULL</c>.
        /// </param>
        /// <remarks>
        /// [win32] On Windows 8 and earlier the physical size is calculated from
        /// the current resolution and system DPI instead of querying the monitor EDID data.
        /// </remarks>
        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwGetMonitorPhysicalSize", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetMonitorPhysicalSize(IntPtr monitor, ref int widthMM, ref int heightMM);
        /// <summary>
        /// Retrieves the content scale for the specified monitor.
        /// <para>
        /// This function retrieves the content scale for the specified monitor.  The
        /// content scale is the ratio between the current DPI and the platform's
        /// default DPI.  This is especially important for text and any UI elements.  If
        /// the pixel dimensions of your UI scaled by this look appropriate on your
        /// machine then it should appear at a reasonable size on other machines
        /// regardless of their DPI and scaling settings.  This relies on the system DPI
        /// and scaling settings being somewhat correct.
        /// </para>
        /// <para>
        /// The content scale may depend on both the monitor resolution and pixel
        /// density and on user settings.  It may be very different from the raw DPI
        /// calculated from the physical size and current resolution.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwGetMonitorContentScale(GLFWmonitor* monitor, float* xscale, float* yscale);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="monitor">[in] The monitor to query.</param>
        /// <param name="xscale">[out] Where to store the x-axis content scale, or <c>NULL</c>.</param>
        /// <param name="yscale">[out] Where to store the y-axis content scale, or <c>NULL</c>.</param>
        /// <seealso cref="GetWindowContentScale"/>
        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwGetMonitorContentScale", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetMonitorContentScale(IntPtr monitor, ref float xscale, ref float yscale);
        /// <summary>
        /// Sets the user pointer of the specified monitor.
        /// <para>
        /// This function sets the user-defined pointer of the specified monitor.  The
        /// current value is retained until the monitor is disconnected.  The initial
        /// value is <c>NULL</c>.
        /// </para>
        /// <para>
        /// This function may be called from the monitor callback, even for a monitor
        /// that is being disconnected.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>
        /// thread_safety:
        /// This function may be called from any thread.  Access is not
        /// synchronized.
        /// </para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetMonitorUserPointer(GLFWmonitor* monitor, void* pointer);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="monitor">[in] The monitor whose pointer to set.</param>
        /// <param name="pointer">[in] The new value.</param>
        /// <seealso cref="GetMonitorUserPointer"/>
        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetMonitorUserPointer", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetMonitorUserPointer(IntPtr monitor, IntPtr pointer);
        /// <summary>
        /// Returns the user pointer of the specified monitor.
        /// <para>
        /// This function returns the current value of the user-defined pointer of the
        /// specified monitor.  The initial value is <c>NULL</c>.
        /// </para>
        /// <para>
        /// This function may be called from the monitor callback, even for a monitor
        /// that is being disconnected.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>
        /// thread_safety:
        /// This function may be called from any thread.  Access is not
        /// synchronized.
        /// </para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void* glfwGetMonitorUserPointer(GLFWmonitor* monitor);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="monitor">[in] The monitor whose pointer to return.</param>
        /// <seealso cref="SetMonitorUserPointer"/>
        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwGetMonitorUserPointer", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetMonitorUserPointer(IntPtr monitor);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetMonitorCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBMonitor glfwSetMonitorCallback(CBMonitor callback);
        /// <summary>
        /// Retrieves the position of the content area of the specified window.
        /// <para>
        /// This function retrieves the position, in screen coordinates, of the
        /// upper-left corner of the content area of the specified window.
        /// </para>
        /// <para>
        /// Any or all of the position arguments may be <c>NULL</c>.  If an error occurs, all
        /// non-<c>NULL</c> position arguments will be set to zero.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwGetWindowPos(GLFWwindow* window, int* xpos, int* ypos);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to query.</param>
        /// <param name="nX">
        /// [out] Where to store the x-coordinate of the upper-left corner of
        /// the content area, or <c>NULL</c>.
        /// </param>
        /// <param name="nY">
        /// [out] Where to store the y-coordinate of the upper-left corner of
        /// the content area, or <c>NULL</c>.
        /// </param>
        /// <remarks>
        /// [wayland] There is no way for an application to retrieve the global
        /// position of its windows, this function will always emit <see cref="PLATFORM_ERROR"/>.
        /// </remarks>
        /// <seealso cref="SetWindowPos"/>
        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwGetWindowPos", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetWindowPos(IntPtr window, ref int nX, ref int nY);
        /// <summary>
        /// Retrieves the size of the content area of the specified window.
        /// <para>
        /// This function retrieves the size, in screen coordinates, of the content area
        /// of the specified window.  If you wish to retrieve the size of the
        /// framebuffer of the window in pixels, see <see cref="GetFramebufferSize"/>.
        /// </para>
        /// <para>
        /// Any or all of the size arguments may be <c>NULL</c>.  If an error occurs, all
        /// non-<c>NULL</c> size arguments will be set to zero.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>glfw3: Added window handle parameter.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwGetWindowSize(GLFWwindow* window, int* width, int* height);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose size to retrieve.</param>
        /// <param name="nWidth">
        /// [out] Where to store the width, in screen coordinates, of the
        /// content area, or <c>NULL</c>.
        /// </param>
        /// <param name="nHeight">
        /// [out] Where to store the height, in screen coordinates, of the
        /// content area, or <c>NULL</c>.
        /// </param>
        /// <seealso cref="SetWindowSize"/>
        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwGetWindowSize", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetWindowSize(IntPtr window, ref int nWidth, ref int nHeight);
        /// <summary>
        /// Retrieves the size of the framebuffer of the specified window.
        /// <para>
        /// This function retrieves the size, in pixels, of the framebuffer of the
        /// specified window.  If you wish to retrieve the size of the window in screen
        /// coordinates, see <see cref="GetWindowSize"/>.
        /// </para>
        /// <para>
        /// Any or all of the size arguments may be <c>NULL</c>.  If an error occurs, all
        /// non-<c>NULL</c> size arguments will be set to zero.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwGetFramebufferSize(GLFWwindow* window, int* width, int* height);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose framebuffer to query.</param>
        /// <param name="width">
        /// [out] Where to store the width, in pixels, of the framebuffer,
        /// or <c>NULL</c>.
        /// </param>
        /// <param name="height">
        /// [out] Where to store the height, in pixels, of the framebuffer,
        /// or <c>NULL</c>.
        /// </param>
        /// <seealso cref="SetFramebufferSizeCallback"/>
        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwGetFramebufferSize", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetFramebufferSize(IntPtr window, ref int width, ref int height);
        /// <summary>
        /// Retrieves the size of the frame of the window.
        /// <para>
        /// This function retrieves the size, in screen coordinates, of each edge of the
        /// frame of the specified window.  This size includes the title bar, if the
        /// window has one.  The size of the frame may vary depending on the
        /// [window-related hints](@ref window_hints_wnd) used to create it.
        /// </para>
        /// <para>
        /// Because this function retrieves the size of each window frame edge and not
        /// the offset along a particular coordinate axis, the retrieved values will
        /// always be zero or positive.
        /// </para>
        /// <para>
        /// Any or all of the size arguments may be <c>NULL</c>.  If an error occurs, all
        /// non-<c>NULL</c> size arguments will be set to zero.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwGetWindowFrameSize(GLFWwindow* window, int* left, int* top, int* right, int* bottom);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose frame size to query.</param>
        /// <param name="left">
        /// [out] Where to store the size, in screen coordinates, of the left
        /// edge of the window frame, or <c>NULL</c>.
        /// </param>
        /// <param name="top">
        /// [out] Where to store the size, in screen coordinates, of the top
        /// edge of the window frame, or <c>NULL</c>.
        /// </param>
        /// <param name="right">
        /// [out] Where to store the size, in screen coordinates, of the
        /// right edge of the window frame, or <c>NULL</c>.
        /// </param>
        /// <param name="bottom">
        /// [out] Where to store the size, in screen coordinates, of the
        /// bottom edge of the window frame, or <c>NULL</c>.
        /// </param>
        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwGetWindowFrameSize", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetWindowFrameSize(IntPtr window, ref int left, ref int top, ref int right, ref int bottom);
        /// <summary>
        /// Retrieves the content scale for the specified window.
        /// <para>
        /// This function retrieves the content scale for the specified window.  The
        /// content scale is the ratio between the current DPI and the platform's
        /// default DPI.  This is especially important for text and any UI elements.  If
        /// the pixel dimensions of your UI scaled by this look appropriate on your
        /// machine then it should appear at a reasonable size on other machines
        /// regardless of their DPI and scaling settings.  This relies on the system DPI
        /// and scaling settings being somewhat correct.
        /// </para>
        /// <para>
        /// On systems where each monitors can have its own content scale, the window
        /// content scale will depend on which monitor the system considers the window
        /// to be on.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwGetWindowContentScale(GLFWwindow* window, float* xscale, float* yscale);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to query.</param>
        /// <param name="xscale">[out] Where to store the x-axis content scale, or <c>NULL</c>.</param>
        /// <param name="yscale">[out] Where to store the y-axis content scale, or <c>NULL</c>.</param>
        /// <seealso cref="SetWindowContentScaleCallback"/>
        /// <seealso cref="GetMonitorContentScale"/>
        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwGetWindowContentScale", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetWindowContentScale(IntPtr window, ref float xscale, ref float yscale);
        /// <summary>
        /// Sets the user pointer of the specified window.
        /// <para>
        /// This function sets the user-defined pointer of the specified window.  The
        /// current value is retained until the window is destroyed.  The initial value
        /// is <c>NULL</c>.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>
        /// thread_safety:
        /// This function may be called from any thread.  Access is not
        /// synchronized.
        /// </para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetWindowUserPointer(GLFWwindow* window, void* pointer);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose pointer to set.</param>
        /// <param name="pointer">[in] The new value.</param>
        /// <seealso cref="GetWindowUserPointer"/>
        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetWindowUserPointer", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetWindowUserPointer(IntPtr window, IntPtr pointer);
        /// <summary>
        /// Returns the user pointer of the specified window.
        /// <para>
        /// This function returns the current value of the user-defined pointer of the
        /// specified window.  The initial value is <c>NULL</c>.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>
        /// thread_safety:
        /// This function may be called from any thread.  Access is not
        /// synchronized.
        /// </para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void* glfwGetWindowUserPointer(GLFWwindow* window);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose pointer to return.</param>
        /// <seealso cref="SetWindowUserPointer"/>
        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwGetWindowUserPointer", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetWindowUserPointer(IntPtr window);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetWindowPosCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBWindowPos glfwSetWindowPosCallback(IntPtr window, CBWindowPos callback);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetWindowSizeCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBWindowSize glfwSetWindowSizeCallback(IntPtr window, CBWindowSize callback);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetWindowCloseCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBWindowClose glfwSetWindowCloseCallback(IntPtr window, CBWindowClose callback);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetWindowRefreshCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBWindowRefresh glfwSetWindowRefreshCallback(IntPtr window, CBWindowRefresh callback);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetWindowFocusCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBWindowFocus glfwSetWindowFocusCallback(IntPtr window, CBWindowFocus callback);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetWindowIconifyCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBWindowIconify glfwSetWindowIconifyCallback(IntPtr window, CBWindowIconify callback);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetWindowMaximizeCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBWindowMaximize glfwSetWindowMaximizeCallback(IntPtr window, CBWindowMaximize callback);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetFramebufferSizeCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBFrameBufferSize glfwSetFramebufferSizeCallback(IntPtr window, CBFrameBufferSize callback);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetWindowContentScaleCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBWindowContentScale glfwSetWindowContentScaleCallback(IntPtr window, CBWindowContentScale callback);
        /// <summary>
        /// Retrieves the position of the cursor relative to the content area of
        /// the window.
        /// <para>
        /// This function returns the position of the cursor, in screen coordinates,
        /// relative to the upper-left corner of the content area of the specified
        /// window.
        /// </para>
        /// <para>
        /// If the cursor is disabled (with <c>GLFW_CURSOR_DISABLED</c>) then the cursor
        /// position is unbounded and limited only by the minimum and maximum values of
        /// a <c>double</c>.
        /// </para>
        /// <para>
        /// The coordinate can be converted to their integer equivalents with the
        /// <c>floor</c> function.  Casting directly to an integer type works for positive
        /// coordinates, but fails for negative ones.
        /// </para>
        /// <para>
        /// Any or all of the position arguments may be <c>NULL</c>.  If an error occurs, all
        /// non-<c>NULL</c> position arguments will be set to zero.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwGetCursorPos(GLFWwindow* window, double* xpos, double* ypos);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The desired window.</param>
        /// <param name="xpos">
        /// [out] Where to store the cursor x-coordinate, relative to the
        /// left edge of the content area, or <c>NULL</c>.
        /// </param>
        /// <param name="ypos">
        /// [out] Where to store the cursor y-coordinate, relative to the to
        /// top edge of the content area, or <c>NULL</c>.
        /// </param>
        /// <seealso cref="SetCursorPos"/>
        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwGetCursorPos", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetCursorPos(IntPtr window, ref double xpos, ref double ypos);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetKeyCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBKey glfwSetKeyCallback(IntPtr window, CBKey callback);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetCharCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBChar glfwSetCharCallback(IntPtr window, CBChar callback);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetCharModsCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBCharMods glfwSetCharModsCallback(IntPtr window, CBCharMods callback);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetMouseButtonCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBMouseButton glfwSetMouseButtonCallback(IntPtr window, CBMouseButton callback);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetCursorPosCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBCursorPos glfwSetCursorPosCallback(IntPtr window, CBCursorPos callback);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetCursorEnterCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBCursorEnter glfwSetCursorEnterCallback(IntPtr window, CBCursorEnter callback);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetScrollCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBScroll glfwSetScrollCallback(IntPtr window, CBScroll callback);
        /// <summary>
        /// Sets the user pointer of the specified joystick.
        /// <para>
        /// This function sets the user-defined pointer of the specified joystick.  The
        /// current value is retained until the joystick is disconnected.  The initial
        /// value is <c>NULL</c>.
        /// </para>
        /// <para>
        /// This function may be called from the joystick callback, even for a joystick
        /// that is being disconnected.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>
        /// thread_safety:
        /// This function may be called from any thread.  Access is not
        /// synchronized.
        /// </para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetJoystickUserPointer(int jid, void* pointer);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="jid">[in] The joystick whose pointer to set.</param>
        /// <param name="pointer">[in] The new value.</param>
        /// <seealso cref="GetJoystickUserPointer"/>
        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetJoystickUserPointer", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetJoystickUserPointer(int jid, IntPtr pointer);
        /// <summary>
        /// Returns the user pointer of the specified joystick.
        /// <para>
        /// This function returns the current value of the user-defined pointer of the
        /// specified joystick.  The initial value is <c>NULL</c>.
        /// </para>
        /// <para>
        /// This function may be called from the joystick callback, even for a joystick
        /// that is being disconnected.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>
        /// thread_safety:
        /// This function may be called from any thread.  Access is not
        /// synchronized.
        /// </para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void* glfwGetJoystickUserPointer(int jid);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="jid">[in] The joystick whose pointer to return.</param>
        /// <seealso cref="SetJoystickUserPointer"/>
        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwGetJoystickUserPointer", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetJoystickUserPointer(int jid);

        [DllImport(GLFWNative.STR_LIB_FILE, EntryPoint = "glfwSetJoystickCallback", CallingConvention = CallingConvention.Cdecl)]
        private static extern CBJoystick glfwSetJoystickCallback(CBJoystick callback);

        /// <summary>
        /// Terminates the GLFW library.
        /// <para>
        /// This function destroys all remaining windows and cursors, restores any
        /// modified gamma ramps and frees any other allocated resources.  Once this
        /// function is called, you must again call <see cref="Init"/> successfully before
        /// you will be able to use most GLFW functions.
        /// </para>
        /// <para>
        /// If GLFW has been successfully initialized, this function should be called
        /// before the application exits.  If initialization fails, there is no need to
        /// call this function, as it is called by <see cref="Init"/> before it returns
        /// failure.
        /// </para>
        /// <para>This function has no effect if GLFW is not initialized.</para>
        /// <para>errors: Possible errors include <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// warning:
        /// The contexts of any remaining windows must not be current on any
        /// other thread when this function is called.
        /// </para>
        /// <para>reentrancy: This function must not be called from a callback.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwTerminate(void);
        /// </code>
        /// </para>
        /// </summary>
        /// <remarks>This function may be called before <see cref="Init"/>.</remarks>
        /// <seealso cref="Init"/>
        public static void Terminate() {
            GLFWNative.glfwTerminate();
        }
        /// <summary>
        /// Sets the specified init hint to the desired value.
        /// <para>This function sets hints for the next initialization of GLFW.</para>
        /// <para>
        /// The values you set hints to are never reset by GLFW, but they only take
        /// effect during initialization.  Once GLFW has been initialized, any values
        /// you set will be ignored until the library is terminated and initialized
        /// again.
        /// </para>
        /// <para>
        /// Some hints are platform specific.  These may be set on any platform but they
        /// will only affect their specific platform.  Other platforms will ignore them.
        /// Setting these hints requires no platform specific headers or functions.
        /// </para>
        /// <para>errors: Possible errors include <see cref="INVALID_ENUM"/> and <see cref="INVALID_VALUE"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwInitHint(int hint, int value);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="hint">[in] The [init hint](@ref init_hints) to set.</param>
        /// <param name="value">[in] The new value of the init hint.</param>
        /// <remarks>This function may be called before <see cref="Init"/>.</remarks>
        public static void InitHint(int hint, int value) {
            GLFWNative.glfwInitHint(hint, value);
        }
        /// <summary>
        /// Returns a string describing the compile-time configuration.
        /// <para>
        /// This function returns the compile-time generated
        /// [version string](@ref intro_version_string) of the GLFW library binary.  It
        /// describes the version, platform, compiler and any platform-specific
        /// compile-time options.  It should not be confused with the OpenGL or OpenGL
        /// ES version string, queried with <c>glGetString</c>.
        /// </para>
        /// <para>
        /// __Do not use the version string__ to parse the GLFW library version.  The
        /// <see cref="GetVersion"/> function provides the version of the running library
        /// binary in numerical format.
        /// </para>
        /// <para>errors: None.</para>
        /// <para>pointer_lifetime: The returned string is static and compile-time generated.</para>
        /// <para>thread_safety: This function may be called from any thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI const char* glfwGetVersionString(void);
        /// </code>
        /// </para>
        /// </summary>
        /// <returns>The ASCII encoded GLFW version string.</returns>
        /// <remarks>This function may be called before <see cref="Init"/>.</remarks>
        /// <seealso cref="GetVersion"/>
        public unsafe static string GetVersionString() {
            byte* ptr = GLFWNative.glfwGetVersionString();
            if (ptr == null) return null;
            return MarshalExtend.PtrToString(ptr, Encoding.ASCII);
        }
        /// <summary>
        /// Returns and clears the last error for the calling thread.
        /// <para>
        /// This function returns and clears the [error code](@ref errors) of the last
        /// error that occurred on the calling thread, and optionally a UTF-8 encoded
        /// human-readable description of it.  If no error has occurred since the last
        /// call, it returns <see cref="NO_ERROR"/> (zero) and the description pointer is
        /// set to <c>NULL</c>.
        /// </para>
        /// <para>errors: None.</para>
        /// <para>
        /// pointer_lifetime:
        /// The returned string is allocated and freed by GLFW.  You
        /// should not free it yourself.  It is guaranteed to be valid only until the
        /// next error occurs or the library is terminated.
        /// </para>
        /// <para>thread_safety: This function may be called from any thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI int glfwGetError(const char** description);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="description">[in] Where to store the error description pointer, or <c>NULL</c>.</param>
        /// <returns>
        /// The last error code for the calling thread, or <see cref="NO_ERROR"/>
        /// (zero).
        /// </returns>
        /// <remarks>This function may be called before <see cref="Init"/>.</remarks>
        /// <seealso cref="SetErrorCallback"/>
        public unsafe static int GetError(out string description) {
            byte* ptr;
            description = null;
            int nCode = GLFWNative.glfwGetError(&ptr);
            if (ptr != null) {
                description = MarshalExtend.PtrToString(ptr);
            }
            return nCode;
        }
        /// <summary>
        /// Sets the error callback.
        /// <para>
        /// This function sets the error callback, which is called with an error code
        /// and a human-readable description each time a GLFW error occurs.
        /// </para>
        /// <para>
        /// The error code is set before the callback is called.  Calling <see cref="GetError"/> from the error callback will return the same value as the error
        /// code argument.
        /// </para>
        /// <para>
        /// The error callback is called on the thread where the error occurred.  If you
        /// are using GLFW from multiple threads, your error callback needs to be
        /// written accordingly.
        /// </para>
        /// <para>
        /// Because the description string may have been generated specifically for that
        /// error, it is not guaranteed to be valid after the callback has returned.  If
        /// you wish to use it after the callback returns, you need to make a copy.
        /// </para>
        /// <para>
        /// Once set, the error callback remains set even after the library has been
        /// terminated.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void callback_name(int error_code, const char* description)
        /// </code>
        /// For more information about the callback parameters, see the
        /// [callback pointer type](@ref GLFWerrorfun).
        /// </para>
        /// <para>errors: None.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWerrorfun glfwSetErrorCallback(GLFWerrorfun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="callback">
        /// [in] The new callback, or <c>NULL</c> to remove the currently set
        /// callback.
        /// </param>
        /// <returns>The previously set callback, or <c>NULL</c> if no callback was set.</returns>
        /// <remarks>This function may be called before <see cref="Init"/>.</remarks>
        /// <seealso cref="GetError"/>
        public unsafe static CBError SetErrorCallback(CBError callback) {
            var old = m_cb_error;
            m_cb_error = callback;
            GLFWNative.glfwSetErrorCallback(GLFW.ErrorFunCallback);
            return old;
        }
        /// <summary>
        /// Returns the currently connected monitors.
        /// <para>
        /// This function returns an array of handles for all currently connected
        /// monitors.  The primary monitor is always first in the returned array.  If no
        /// monitors were found, this function returns <c>NULL</c>.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The returned array is allocated and freed by GLFW.  You
        /// should not free it yourself.  It is guaranteed to be valid only until the
        /// monitor configuration changes or the library is terminated.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWmonitor** glfwGetMonitors(int* count);
        /// </code>
        /// </para>
        /// </summary>
        /// <returns>
        /// An array of monitor handles, or <c>NULL</c> if no monitors were found or
        /// if an [error](@ref error_handling) occurred.
        /// </returns>
        /// <seealso cref="GetPrimaryMonitor"/>
        public static unsafe IntPtr[] GetMonitors() {
            int nCount = 0;
            IntPtr* ptr = GLFWNative.glfwGetMonitors(&nCount);
            if (ptr == null) return null;
            IntPtr[] ret = new IntPtr[nCount];
            for (int i = 0; i < nCount; i++) {
                ret[i] = *(ptr + i);
            }
            return ret;
        }
        /// <summary>
        /// Returns the primary monitor.
        /// <para>
        /// This function returns the primary monitor.  This is usually the monitor
        /// where elements like the task bar or global menu bar are located.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWmonitor* glfwGetPrimaryMonitor(void);
        /// </code>
        /// </para>
        /// </summary>
        /// <returns>
        /// The primary monitor, or <c>NULL</c> if no monitors were found or if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        /// <remarks>The primary monitor is always first in the array returned by <see cref="GetMonitors"/>.</remarks>
        /// <seealso cref="GetMonitors"/>
        public static IntPtr GetPrimaryMonitor() {
            return GLFWNative.glfwGetPrimaryMonitor();
        }
        /// <summary>
        /// Returns the name of the specified monitor.
        /// <para>
        /// This function returns a human-readable name, encoded as UTF-8, of the
        /// specified monitor.  The name typically reflects the make and model of the
        /// monitor and is not guaranteed to be unique among the connected monitors.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The returned string is allocated and freed by GLFW.  You
        /// should not free it yourself.  It is valid until the specified monitor is
        /// disconnected or the library is terminated.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI const char* glfwGetMonitorName(GLFWmonitor* monitor);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="monitor">[in] The monitor to query.</param>
        /// <returns>
        /// The UTF-8 encoded name of the monitor, or <c>NULL</c> if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        public unsafe static string GetMonitorName(IntPtr monitor) {
            byte* ptr = GLFWNative.glfwGetMonitorName(monitor);
            if (ptr == null) return null;
            return MarshalExtend.PtrToString(ptr);
        }
        /// <summary>
        /// Sets the monitor configuration callback.
        /// <para>
        /// This function sets the monitor configuration callback, or removes the
        /// currently set callback.  This is called when a monitor is connected to or
        /// disconnected from the system.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWmonitor* monitor, int event)
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWmonitorfun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWmonitorfun glfwSetMonitorCallback(GLFWmonitorfun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="callback">
        /// [in] The new callback, or <c>NULL</c> to remove the currently set
        /// callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        public static CBMonitor SetMonitorCallback(CBMonitor callback) {
            m_cb_monitor = callback;
            return GLFW.glfwSetMonitorCallback(m_cb_monitor);
        }
        /// <summary>
        /// Returns the available video modes for the specified monitor.
        /// <para>
        /// This function returns an array of all video modes supported by the specified
        /// monitor.  The returned array is sorted in ascending order, first by color
        /// bit depth (the sum of all channel depths), then by resolution area (the
        /// product of width and height), then resolution width and finally by refresh
        /// rate.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The returned array is allocated and freed by GLFW.  You
        /// should not free it yourself.  It is valid until the specified monitor is
        /// disconnected, this function is called again for that monitor or the library
        /// is terminated.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>glfw3: Changed to return an array of modes for a specific monitor.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI const GLFWvidmode* glfwGetVideoModes(GLFWmonitor* monitor, int* count);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="monitor">[in] The monitor to query.</param>
        /// <returns>
        /// An array of video modes, or <c>NULL</c> if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        /// <seealso cref="GetVideoMode"/>
        public static unsafe VidMode[] GetVideoModes(IntPtr monitor) {
            int nCount = 0;
            var ptr = GLFWNative.glfwGetVideoModes(monitor, &nCount);
            if (ptr == null || nCount < 1) {
                return null;
            }
            VidMode[] ret = new VidMode[nCount];
            for (int i = 0; i < nCount; i++) {
                var item = *(ptr + i);
                ret[i].Width = item.width;
                ret[i].Height = item.height;
                ret[i].RefreshRate = item.refreshRate;
                ret[i].RedBits = item.redBits;
                ret[i].GreenBits = item.greenBits;
                ret[i].BlueBits = item.blueBits;
            }
            return ret;
        }
        /// <summary>
        /// Returns the current mode of the specified monitor.
        /// <para>
        /// This function returns the current video mode of the specified monitor.  If
        /// you have created a full screen window for that monitor, the return value
        /// will depend on whether that window is iconified.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The returned array is allocated and freed by GLFW.  You
        /// should not free it yourself.  It is valid until the specified monitor is
        /// disconnected or the library is terminated.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI const GLFWvidmode* glfwGetVideoMode(GLFWmonitor* monitor);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="monitor">[in] The monitor to query.</param>
        /// <returns>
        /// The current mode of the monitor, or <c>NULL</c> if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        /// <seealso cref="GetVideoModes"/>
        public static unsafe VidMode GetVideoMode(IntPtr monitor) {
            VidMode mod = new VidMode();
            var ptr = GLFWNative.glfwGetVideoMode(monitor);
            mod.Width = ptr->width;
            mod.Height = ptr->height;
            mod.RefreshRate = ptr->refreshRate;
            mod.RedBits = ptr->redBits;
            mod.GreenBits = ptr->greenBits;
            mod.BlueBits = ptr->blueBits;
            return mod;
        }
        /// <summary>
        /// Generates a gamma ramp and sets it for the specified monitor.
        /// <para>
        /// This function generates an appropriately sized gamma ramp from the specified
        /// exponent and then calls <see cref="SetGammaRamp"/> with it.  The value must be
        /// a finite number greater than zero.
        /// </para>
        /// <para>
        /// The software controlled gamma ramp is applied _in addition_ to the hardware
        /// gamma correction, which today is usually an approximation of sRGB gamma.
        /// This means that setting a perfectly linear ramp, or gamma 1.0, will produce
        /// the default (usually sRGB-like) behavior.
        /// </para>
        /// <para>For gamma correct rendering with OpenGL or OpenGL ES, see the <see cref="SRGB_CAPABLE"/> hint.</para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="INVALID_VALUE"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetGamma(GLFWmonitor* monitor, float gamma);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="monitor">[in] The monitor whose gamma ramp to set.</param>
        /// <param name="gamma">[in] The desired exponent.</param>
        /// <remarks>
        /// [wayland] Gamma handling is a privileged protocol, this function
        /// will thus never be implemented and emits <see cref="PLATFORM_ERROR"/>.
        /// </remarks>
        public static void SetGamma(IntPtr monitor, float gamma) {
            GLFWNative.glfwSetGamma(monitor, gamma);
        }
        /// <summary>
        /// Returns the current gamma ramp for the specified monitor.
        /// <para>This function returns the current gamma ramp of the specified monitor.</para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The returned structure and its arrays are allocated and
        /// freed by GLFW.  You should not free them yourself.  They are valid until the
        /// specified monitor is disconnected, this function is called again for that
        /// monitor or the library is terminated.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI const GLFWgammaramp* glfwGetGammaRamp(GLFWmonitor* monitor);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="monitor">[in] The monitor to query.</param>
        /// <returns>
        /// The current gamma ramp, or <c>NULL</c> if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        /// <remarks>
        /// [wayland] Gamma handling is a privileged protocol, this function
        /// will thus never be implemented and emits <see cref="PLATFORM_ERROR"/> while
        /// returning <c>NULL</c>.
        /// </remarks>
        public static unsafe GammaRamp GetGammaRamp(IntPtr monitor) {
            var ptr = GLFWNative.glfwGetGammaRamp(monitor);
            if (ptr == null) {
                return GammaRamp.Empty;
            }
            GammaRamp ret = new GammaRamp();
            ret.Red = new ushort[ptr->size];
            ret.Green = new ushort[ptr->size];
            ret.Blue = new ushort[ptr->size];
            for (uint i = 0; i < ptr->size; i++) {
                ret.Red[i] = *(ptr->red + i);
                ret.Green[i] = *(ptr->green + i);
                ret.Blue[i] = *(ptr->blue + i);
            }
            return ret;
        }
        /// <summary>
        /// Sets the current gamma ramp for the specified monitor.
        /// <para>
        /// This function sets the current gamma ramp for the specified monitor.  The
        /// original gamma ramp for that monitor is saved by GLFW the first time this
        /// function is called and is restored by <see cref="Terminate"/>.
        /// </para>
        /// <para>
        /// The software controlled gamma ramp is applied _in addition_ to the hardware
        /// gamma correction, which today is usually an approximation of sRGB gamma.
        /// This means that setting a perfectly linear ramp, or gamma 1.0, will produce
        /// the default (usually sRGB-like) behavior.
        /// </para>
        /// <para>For gamma correct rendering with OpenGL or OpenGL ES, see the <see cref="SRGB_CAPABLE"/> hint.</para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The specified gamma ramp is copied before this function
        /// returns.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetGammaRamp(GLFWmonitor* monitor, const GLFWgammaramp* ramp);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="monitor">[in] The monitor whose gamma ramp to set.</param>
        /// <param name="ramp">[in] The gamma ramp to use.</param>
        /// <remarks>
        /// The size of the specified gamma ramp should match the size of the
        /// current ramp for that monitor.
        /// </remarks>
        /// <remarks>[win32] The gamma ramp size must be 256.</remarks>
        /// <remarks>
        /// [wayland] Gamma handling is a privileged protocol, this function
        /// will thus never be implemented and emits <see cref="PLATFORM_ERROR"/>.
        /// </remarks>
        public static unsafe void SetGammaRamp(IntPtr monitor, GammaRamp ramp) {
            GLFWNative.GLFWgammaramp ramp_in = new GLFWNative.GLFWgammaramp();
            GLFWNative.GLFWgammaramp* ptr = &ramp_in;
            fixed (ushort* p_r = &(ramp.Red[0]), p_g = &(ramp.Green[0]), p_b = &(ramp.Blue[0])) {
                ptr->red = p_r;
                ptr->green = p_g;
                ptr->blue = p_b;
                GLFWNative.glfwSetGammaRamp(monitor, ptr);
            }
        }
        /// <summary>
        /// Resets all window hints to their default values.
        /// <para>
        /// This function resets all window hints to their
        /// [default values](@ref window_hints_values).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwDefaultWindowHints(void);
        /// </code>
        /// </para>
        /// </summary>
        /// <seealso cref="WindowHint"/>
        /// <seealso cref="WindowHintString"/>
        public static void DefaultWindowHints() {
            GLFWNative.glfwDefaultWindowHints();
        }
        /// <summary>
        /// Sets the specified window hint to the desired value.
        /// <para>
        /// This function sets hints for the next call to <see cref="CreateWindow"/>.  The
        /// hints, once set, retain their values until changed by a call to this
        /// function or <see cref="DefaultWindowHints"/>, or until the library is terminated.
        /// </para>
        /// <para>
        /// Only integer value hints can be set with this function.  String value hints
        /// are set with <see cref="WindowHintString"/>.
        /// </para>
        /// <para>
        /// This function does not check whether the specified hint values are valid.
        /// If you set hints to invalid values this will instead be reported by the next
        /// call to <see cref="CreateWindow"/>.
        /// </para>
        /// <para>
        /// Some hints are platform specific.  These may be set on any platform but they
        /// will only affect their specific platform.  Other platforms will ignore them.
        /// Setting these hints requires no platform specific headers or functions.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="INVALID_ENUM"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwWindowHint(int hint, int value);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="hint">[in] The [window hint](@ref window_hints) to set.</param>
        /// <param name="value">[in] The new value of the window hint.</param>
        /// <seealso cref="WindowHintString"/>
        /// <seealso cref="DefaultWindowHints"/>
        public static void WindowHint(int hint, int value) {
            GLFWNative.glfwWindowHint(hint, value);
        }
        /// <summary>
        /// Sets the specified window hint to the desired value.
        /// <para>
        /// This function sets hints for the next call to <see cref="CreateWindow"/>.  The
        /// hints, once set, retain their values until changed by a call to this
        /// function or <see cref="DefaultWindowHints"/>, or until the library is terminated.
        /// </para>
        /// <para>
        /// Only integer value hints can be set with this function.  String value hints
        /// are set with <see cref="WindowHintString"/>.
        /// </para>
        /// <para>
        /// This function does not check whether the specified hint values are valid.
        /// If you set hints to invalid values this will instead be reported by the next
        /// call to <see cref="CreateWindow"/>.
        /// </para>
        /// <para>
        /// Some hints are platform specific.  These may be set on any platform but they
        /// will only affect their specific platform.  Other platforms will ignore them.
        /// Setting these hints requires no platform specific headers or functions.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="INVALID_ENUM"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwWindowHint(int hint, int value);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="hint">[in] The [window hint](@ref window_hints) to set.</param>
        /// <param name="value">[in] The new value of the window hint.</param>
        /// <seealso cref="WindowHintString"/>
        /// <seealso cref="DefaultWindowHints"/>
        public static void WindowHint(int hint, uint value) {
            GLFWNative.glfwWindowHint(hint, (int)value);
        }
        /// <summary>
        /// Sets the specified window hint to the desired value.
        /// <para>
        /// This function sets hints for the next call to <see cref="CreateWindow"/>.  The
        /// hints, once set, retain their values until changed by a call to this
        /// function or <see cref="DefaultWindowHints"/>, or until the library is terminated.
        /// </para>
        /// <para>
        /// Only string type hints can be set with this function.  Integer value hints
        /// are set with <see cref="WindowHint"/>.
        /// </para>
        /// <para>
        /// This function does not check whether the specified hint values are valid.
        /// If you set hints to invalid values this will instead be reported by the next
        /// call to <see cref="CreateWindow"/>.
        /// </para>
        /// <para>
        /// Some hints are platform specific.  These may be set on any platform but they
        /// will only affect their specific platform.  Other platforms will ignore them.
        /// Setting these hints requires no platform specific headers or functions.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="INVALID_ENUM"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The specified string is copied before this function
        /// returns.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwWindowHintString(int hint, const char* value);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="hint">[in] The [window hint](@ref window_hints) to set.</param>
        /// <param name="value">[in] The new value of the window hint.</param>
        /// <seealso cref="WindowHint"/>
        /// <seealso cref="DefaultWindowHints"/>
        public static unsafe void WindowHintString(int hint, string value) {
            byte[] byStr = Encoding.UTF8.GetBytes(value);
            fixed (byte* ptr = &(byStr[0])) {
                GLFWNative.glfwWindowHintString(hint, ptr);
            }
        }
        /// <summary>
        /// Creates a window and its associated context.
        /// <para>
        /// This function creates a window and its associated OpenGL or OpenGL ES
        /// context.  Most of the options controlling how the window and its context
        /// should be created are specified with [window hints](@ref window_hints).
        /// </para>
        /// <para>
        /// Successful creation does not change which context is current.  Before you
        /// can use the newly created context, you need to
        /// [make it current](@ref context_current).  For information about the <c>share</c>
        /// parameter, see @ref context_sharing.
        /// </para>
        /// <para>
        /// The created window, framebuffer and context may differ from what you
        /// requested, as not all parameters and hints are
        /// [hard constraints](@ref window_hints_hard).  This includes the size of the
        /// window, especially for full screen windows.  To query the actual attributes
        /// of the created window, framebuffer and context, see <see cref="GetWindowAttrib"/>, <see cref="GetWindowSize"/> and <see cref="GetFramebufferSize"/>.
        /// </para>
        /// <para>
        /// To create a full screen window, you need to specify the monitor the window
        /// will cover.  If no monitor is specified, the window will be windowed mode.
        /// Unless you have a way for the user to choose a specific monitor, it is
        /// recommended that you pick the primary monitor.  For more information on how
        /// to query connected monitors, see @ref monitor_monitors.
        /// </para>
        /// <para>
        /// For full screen windows, the specified size becomes the resolution of the
        /// window's _desired video mode_.  As long as a full screen window is not
        /// iconified, the supported video mode most closely matching the desired video
        /// mode is set for the specified monitor.  For more information about full
        /// screen windows, including the creation of so called _windowed full screen_
        /// or _borderless full screen_ windows, see @ref window_windowed_full_screen.
        /// </para>
        /// <para>
        /// Once you have created the window, you can switch it between windowed and
        /// full screen mode with <see cref="SetWindowMonitor"/>.  This will not affect its
        /// OpenGL or OpenGL ES context.
        /// </para>
        /// <para>
        /// By default, newly created windows use the placement recommended by the
        /// window system.  To create the window at a specific position, make it
        /// initially invisible using the [GLFW_VISIBLE](<see cref="VISIBLE_hint"/>) window
        /// hint, set its [position](@ref window_pos) and then [show](@ref window_hide)
        /// it.
        /// </para>
        /// <para>
        /// As long as at least one full screen window is not iconified, the screensaver
        /// is prohibited from starting.
        /// </para>
        /// <para>
        /// Window systems put limits on window sizes.  Very large or very small window
        /// dimensions may be overridden by the window system on creation.  Check the
        /// actual [size](@ref window_size) after creation.
        /// </para>
        /// <para>
        /// The [swap interval](@ref buffer_swap) is not set during window creation and
        /// the initial value may vary depending on driver settings and defaults.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="INVALID_ENUM"/>, <see cref="INVALID_VALUE"/>, <see cref="API_UNAVAILABLE"/>, <see cref="VERSION_UNAVAILABLE"/>, <see cref="FORMAT_UNAVAILABLE"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWwindow* glfwCreateWindow(int width, int height, const char* title, GLFWmonitor* monitor, GLFWwindow* share);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="width">
        /// [in] The desired width, in screen coordinates, of the window.
        /// This must be greater than zero.
        /// </param>
        /// <param name="height">
        /// [in] The desired height, in screen coordinates, of the window.
        /// This must be greater than zero.
        /// </param>
        /// <param name="title">[in] The initial, UTF-8 encoded window title.</param>
        /// <param name="monitor">
        /// [in] The monitor to use for full screen mode, or <c>NULL</c> for
        /// windowed mode.
        /// </param>
        /// <param name="share">
        /// [in] The window whose context to share resources with, or <c>NULL</c>
        /// to not share resources.
        /// </param>
        /// <returns>
        /// The handle of the created window, or <c>NULL</c> if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        /// <remarks>
        /// [win32] Window creation will fail if the Microsoft GDI software
        /// OpenGL implementation is the only one available.
        /// </remarks>
        /// <remarks>
        /// [win32] If the executable has an icon resource named <c>GLFW_ICON,</c> it
        /// will be set as the initial icon for the window.  If no such icon is present,
        /// the <c>IDI_APPLICATION</c> icon will be used instead.  To set a different icon,
        /// see <see cref="SetWindowIcon"/>.
        /// </remarks>
        /// <remarks>
        /// [win32] The context to share resources with must not be current on
        /// any other thread.
        /// </remarks>
        /// <remarks>
        /// [macos] The OS only supports forward-compatible core profile contexts
        /// for OpenGL versions 3.2 and later.  Before creating an OpenGL context of
        /// version 3.2 or later you must set the
        /// [GLFW_OPENGL_FORWARD_COMPAT](<see cref="OPENGL_FORWARD_COMPAT_hint"/>) and
        /// [GLFW_OPENGL_PROFILE](<see cref="OPENGL_PROFILE_hint"/>) hints accordingly.
        /// OpenGL 3.0 and 3.1 contexts are not supported at all on macOS.
        /// </remarks>
        /// <remarks>
        /// [macos] The GLFW window has no icon, as it is not a document
        /// window, but the dock icon will be the same as the application bundle's icon.
        /// For more information on bundles, see the
        /// [Bundle Programming Guide](https://developer.apple.com/library/mac/documentation/CoreFoundation/Conceptual/CFBundles/)
        /// in the Mac Developer Library.
        /// </remarks>
        /// <remarks>
        /// [macos] The first time a window is created the menu bar is created.
        /// If GLFW finds a <c>MainMenu.nib</c> it is loaded and assumed to contain a menu
        /// bar.  Otherwise a minimal menu bar is created manually with common commands
        /// like Hide, Quit and About.  The About entry opens a minimal about dialog
        /// with information from the application's bundle.  Menu bar creation can be
        /// disabled entirely with the <see cref="COCOA_MENUBAR"/> init hint.
        /// </remarks>
        /// <remarks>
        /// [macos] On OS X 10.10 and later the window frame will not be rendered
        /// at full resolution on Retina displays unless the
        /// [GLFW_COCOA_RETINA_FRAMEBUFFER](<see cref="COCOA_RETINA_FRAMEBUFFER_hint"/>)
        /// hint is <c>GLFW_TRUE</c> and the <c>NSHighResolutionCapable</c> key is enabled in the
        /// application bundle's <c>Info.plist</c>.  For more information, see
        /// [High Resolution Guidelines for OS X](https://developer.apple.com/library/mac/documentation/GraphicsAnimation/Conceptual/HighResolutionOSX/Explained/Explained.html)
        /// in the Mac Developer Library.  The GLFW test and example programs use
        /// a custom <c>Info.plist</c> template for this, which can be found as
        /// <c>CMake/MacOSXBundleInfo.plist.in</c> in the source tree.
        /// </remarks>
        /// <remarks>
        /// [macos] When activating frame autosaving with
        /// [GLFW_COCOA_FRAME_NAME](<see cref="COCOA_FRAME_NAME_hint"/>), the specified
        /// window size and position may be overridden by previously saved values.
        /// </remarks>
        /// <remarks>
        /// [x11] Some window managers will not respect the placement of
        /// initially hidden windows.
        /// </remarks>
        /// <remarks>
        /// [x11] Due to the asynchronous nature of X11, it may take a moment for
        /// a window to reach its requested state.  This means you may not be able to
        /// query the final size, position or other attributes directly after window
        /// creation.
        /// </remarks>
        /// <remarks>
        /// [x11] The class part of the <c>WM_CLASS</c> window property will by
        /// default be set to the window title passed to this function.  The instance
        /// part will use the contents of the <c>RESOURCE_NAME</c> environment variable, if
        /// present and not empty, or fall back to the window title.  Set the
        /// [GLFW_X11_CLASS_NAME](<see cref="X11_CLASS_NAME_hint"/>) and
        /// [GLFW_X11_INSTANCE_NAME](<see cref="X11_INSTANCE_NAME_hint"/>) window hints to
        /// override this.
        /// </remarks>
        /// <remarks>
        /// [wayland] Compositors should implement the xdg-decoration protocol
        /// for GLFW to decorate the window properly.  If this protocol isn't
        /// supported, or if the compositor prefers client-side decorations, a very
        /// simple fallback frame will be drawn using the wp_viewporter protocol.  A
        /// compositor can still emit close, maximize or fullscreen events, using for
        /// instance a keybind mechanism.  If neither of these protocols is supported,
        /// the window won't be decorated.
        /// </remarks>
        /// <remarks>
        /// [wayland] A full screen window will not attempt to change the mode,
        /// no matter what the requested size or refresh rate.
        /// </remarks>
        /// <remarks>
        /// [wayland] Screensaver inhibition requires the idle-inhibit protocol
        /// to be implemented in the user's compositor.
        /// </remarks>
        /// <seealso cref="DestroyWindow"/>
        public static unsafe IntPtr CreateWindow(int width, int height, string title, IntPtr monitor, IntPtr share) {
            byte[] byStr = Encoding.UTF8.GetBytes(title);
            fixed (byte* ptr = &(byStr[0])) {
                return GLFWNative.glfwCreateWindow(width, height, ptr, monitor, share);
            }
        }
        /// <summary>
        /// Destroys the specified window and its context.
        /// <para>
        /// This function destroys the specified window and its context.  On calling
        /// this function, no further callbacks will be called for that window.
        /// </para>
        /// <para>
        /// If the context of the specified window is current on the main thread, it is
        /// detached before being destroyed.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// note:
        /// The context of the specified window must not be current on any other
        /// thread when this function is called.
        /// </para>
        /// <para>reentrancy: This function must not be called from a callback.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwDestroyWindow(GLFWwindow* window);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to destroy.</param>
        /// <seealso cref="CreateWindow"/>
        public static void DestroyWindow(IntPtr window) {
            GLFWNative.glfwDestroyWindow(window);
        }
        /// <summary>
        /// Checks the close flag of the specified window.
        /// <para>This function returns the value of the close flag of the specified window.</para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>
        /// thread_safety:
        /// This function may be called from any thread.  Access is not
        /// synchronized.
        /// </para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI int glfwWindowShouldClose(GLFWwindow* window);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to query.</param>
        /// <returns>The value of the close flag.</returns>
        public static bool WindowShouldClose(IntPtr window) {
            return GLFWNative.glfwWindowShouldClose(window) != 0;
        }
        /// <summary>
        /// Sets the close flag of the specified window.
        /// <para>
        /// This function sets the value of the close flag of the specified window.
        /// This can be used to override the user's attempt to close the window, or
        /// to signal that it should be closed.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>
        /// thread_safety:
        /// This function may be called from any thread.  Access is not
        /// synchronized.
        /// </para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetWindowShouldClose(GLFWwindow* window, int value);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose flag to change.</param>
        /// <param name="value">[in] The new value.</param>
        public static void SetWindowShouldClose(IntPtr window, int value) {
            GLFWNative.glfwSetWindowShouldClose(window, value);
        }
        /// <summary>
        /// Sets the close flag of the specified window.
        /// <para>
        /// see: SetWindowShouldClose(IntPtr window, int value)
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose flag to change.</param>
        /// <param name="value">[in] The new value.</param>
        public static void SetWindowShouldClose(IntPtr window, bool value) {
            GLFWNative.glfwSetWindowShouldClose(window, value ? 1 : 0);
        }
        /// <summary>
        /// Sets the title of the specified window.
        /// <para>
        /// This function sets the window title, encoded as UTF-8, of the specified
        /// window.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>glfw3: Added window handle parameter.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetWindowTitle(GLFWwindow* window, const char* title);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose title to change.</param>
        /// <param name="title">[in] The UTF-8 encoded window title.</param>
        /// <remarks>
        /// [macos] The window title will not be updated until the next time you
        /// process events.
        /// </remarks>
        public static unsafe void SetWindowTitle(IntPtr window, string title) {
            byte[] byStr = Encoding.UTF8.GetBytes(title);
            fixed (byte* ptr = &(byStr[0])) {
                GLFWNative.glfwSetWindowTitle(window, ptr);
            }
        }
        /// <summary>
        /// Sets the icon for the specified window.
        /// <para>
        /// This function sets the icon of the specified window.  If passed an array of
        /// candidate images, those of or closest to the sizes desired by the system are
        /// selected.  If no images are specified, the window reverts to its default
        /// icon.
        /// </para>
        /// <para>
        /// The pixels are 32-bit, little-endian, non-premultiplied RGBA, i.e. eight
        /// bits per channel with the red channel first.  They are arranged canonically
        /// as packed sequential rows, starting from the top-left corner.
        /// </para>
        /// <para>
        /// The desired image sizes varies depending on platform and system settings.
        /// The selected images will be rescaled as needed.  Good sizes include 16x16,
        /// 32x32 and 48x48.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The specified image data is copied before this function
        /// returns.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetWindowIcon(GLFWwindow* window, int count, const GLFWimage* images);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose icon to set.</param>
        /// <param name="count">
        /// [in] The number of images in the specified array, or zero to
        /// revert to the default window icon.
        /// </param>
        /// <param name="images">
        /// [in] The images to create the icon from.  This is ignored if
        /// count is zero.
        /// </param>
        /// <remarks>
        /// [macos] The GLFW window has no icon, as it is not a document
        /// window, so this function does nothing.  The dock icon will be the same as
        /// the application bundle's icon.  For more information on bundles, see the
        /// [Bundle Programming Guide](https://developer.apple.com/library/mac/documentation/CoreFoundation/Conceptual/CFBundles/)
        /// in the Mac Developer Library.
        /// </remarks>
        /// <remarks>
        /// [wayland] There is no existing protocol to change an icon, the
        /// window will thus inherit the one defined in the application's desktop file.
        /// This function always emits <see cref="PLATFORM_ERROR"/>.
        /// </remarks>
        public static unsafe void SetWindowIcon(IntPtr window, int count, GLFWImage[] images) {
            if (images == null) {
                GLFWNative.glfwSetWindowIcon(window, count, null);
                return;
            }

            int nLen = 0;   // all the pixels length.
            List<int> lst_offset = new List<int>(images.Length);
            for (int i = 0; i < images.Length; i++) {
                nLen += (images[i].Width * images[i].Height * 4);   // 32-bit
                lst_offset[i] = nLen;
            }
            byte[] byBuffer = new byte[nLen];
            for (int i = 0; i < images.Length; i++) {                 // copy all the pixels to the buffer
                Array.Copy(images[i].Pixels, 0, byBuffer, lst_offset[i], images[i].Width * images[i].Height * 4);
            }

            GLFWNative.GLFWimage[] in_images = new GLFWNative.GLFWimage[images.Length];
            fixed (byte* ptr_buffer = &(byBuffer[0])) {
                fixed (GLFWNative.GLFWimage* ptr_imgs = &(in_images[0])) {
                    for (int i = 0; i < images.Length; i++) {
                        var item = *(ptr_imgs + i);
                        item.width = images[i].Width;
                        item.height = images[i].Height;
                        item.pixels = ptr_buffer + lst_offset[i];
                    }
                    GLFWNative.glfwSetWindowIcon(window, count, ptr_imgs);
                }
            }
        }
        /// <summary>
        /// Sets the position of the content area of the specified window.
        /// <para>
        /// This function sets the position, in screen coordinates, of the upper-left
        /// corner of the content area of the specified windowed mode window.  If the
        /// window is a full screen window, this function does nothing.
        /// </para>
        /// <para>
        /// __Do not use this function__ to move an already visible window unless you
        /// have very good reasons for doing so, as it will confuse and annoy the user.
        /// </para>
        /// <para>
        /// The window manager may put limits on what positions are allowed.  GLFW
        /// cannot and should not override these limits.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>glfw3: Added window handle parameter.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetWindowPos(GLFWwindow* window, int xpos, int ypos);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to query.</param>
        /// <param name="xpos">[in] The x-coordinate of the upper-left corner of the content area.</param>
        /// <param name="ypos">[in] The y-coordinate of the upper-left corner of the content area.</param>
        /// <remarks>
        /// [wayland] There is no way for an application to set the global
        /// position of its windows, this function will always emit <see cref="PLATFORM_ERROR"/>.
        /// </remarks>
        /// <seealso cref="GetWindowPos"/>
        public static void SetWindowPos(IntPtr window, int xpos, int ypos) {
            GLFWNative.glfwSetWindowPos(window, xpos, ypos);
        }
        /// <summary>
        /// Sets the size limits of the specified window.
        /// <para>
        /// This function sets the size limits of the content area of the specified
        /// window.  If the window is full screen, the size limits only take effect
        /// once it is made windowed.  If the window is not resizable, this function
        /// does nothing.
        /// </para>
        /// <para>
        /// The size limits are applied immediately to a windowed mode window and may
        /// cause it to be resized.
        /// </para>
        /// <para>
        /// The maximum dimensions must be greater than or equal to the minimum
        /// dimensions and all must be greater than or equal to zero.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="INVALID_VALUE"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetWindowSizeLimits(GLFWwindow* window, int minwidth, int minheight, int maxwidth, int maxheight);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to set limits for.</param>
        /// <param name="minwidth">
        /// [in] The minimum width, in screen coordinates, of the content
        /// area, or <c>GLFW_DONT_CARE</c>.
        /// </param>
        /// <param name="minheight">
        /// [in] The minimum height, in screen coordinates, of the
        /// content area, or <c>GLFW_DONT_CARE</c>.
        /// </param>
        /// <param name="maxwidth">
        /// [in] The maximum width, in screen coordinates, of the content
        /// area, or <c>GLFW_DONT_CARE</c>.
        /// </param>
        /// <param name="maxheight">
        /// [in] The maximum height, in screen coordinates, of the
        /// content area, or <c>GLFW_DONT_CARE</c>.
        /// </param>
        /// <remarks>
        /// If you set size limits and an aspect ratio that conflict, the
        /// results are undefined.
        /// </remarks>
        /// <remarks>
        /// [wayland] The size limits will not be applied until the window is
        /// actually resized, either by the user or by the compositor.
        /// </remarks>
        /// <seealso cref="SetWindowAspectRatio"/>
        public static void SetWindowSizeLimits(IntPtr window, int minwidth, int minheight, int maxwidth, int maxheight) {
            GLFWNative.glfwSetWindowSizeLimits(window, minwidth, minheight, maxwidth, maxheight);
        }
        /// <summary>
        /// Sets the aspect ratio of the specified window.
        /// <para>
        /// This function sets the required aspect ratio of the content area of the
        /// specified window.  If the window is full screen, the aspect ratio only takes
        /// effect once it is made windowed.  If the window is not resizable, this
        /// function does nothing.
        /// </para>
        /// <para>
        /// The aspect ratio is specified as a numerator and a denominator and both
        /// values must be greater than zero.  For example, the common 16:9 aspect ratio
        /// is specified as 16 and 9, respectively.
        /// </para>
        /// <para>
        /// If the numerator and denominator is set to <c>GLFW_DONT_CARE</c> then the aspect
        /// ratio limit is disabled.
        /// </para>
        /// <para>
        /// The aspect ratio is applied immediately to a windowed mode window and may
        /// cause it to be resized.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="INVALID_VALUE"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetWindowAspectRatio(GLFWwindow* window, int numer, int denom);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to set limits for.</param>
        /// <param name="numer">
        /// [in] The numerator of the desired aspect ratio, or
        /// <c>GLFW_DONT_CARE</c>.
        /// </param>
        /// <param name="denom">
        /// [in] The denominator of the desired aspect ratio, or
        /// <c>GLFW_DONT_CARE</c>.
        /// </param>
        /// <remarks>
        /// If you set size limits and an aspect ratio that conflict, the
        /// results are undefined.
        /// </remarks>
        /// <remarks>
        /// [wayland] The aspect ratio will not be applied until the window is
        /// actually resized, either by the user or by the compositor.
        /// </remarks>
        /// <seealso cref="SetWindowSizeLimits"/>
        public static void SetWindowAspectRatio(IntPtr window, int numer, int denom) {
            GLFWNative.glfwSetWindowAspectRatio(window, numer, denom);
        }
        /// <summary>
        /// Sets the size of the content area of the specified window.
        /// <para>
        /// This function sets the size, in screen coordinates, of the content area of
        /// the specified window.
        /// </para>
        /// <para>
        /// For full screen windows, this function updates the resolution of its desired
        /// video mode and switches to the video mode closest to it, without affecting
        /// the window's context.  As the context is unaffected, the bit depths of the
        /// framebuffer remain unchanged.
        /// </para>
        /// <para>
        /// If you wish to update the refresh rate of the desired video mode in addition
        /// to its resolution, see <see cref="SetWindowMonitor"/>.
        /// </para>
        /// <para>
        /// The window manager may put limits on what sizes are allowed.  GLFW cannot
        /// and should not override these limits.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>glfw3: Added window handle parameter.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetWindowSize(GLFWwindow* window, int width, int height);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to resize.</param>
        /// <param name="width">
        /// [in] The desired width, in screen coordinates, of the window
        /// content area.
        /// </param>
        /// <param name="height">
        /// [in] The desired height, in screen coordinates, of the window
        /// content area.
        /// </param>
        /// <remarks>
        /// [wayland] A full screen window will not attempt to change the mode,
        /// no matter what the requested size.
        /// </remarks>
        /// <seealso cref="GetWindowSize"/>
        /// <seealso cref="SetWindowMonitor"/>
        public static void SetWindowSize(IntPtr window, int width, int height) {
            GLFWNative.glfwSetWindowSize(window, width, height);
        }
        /// <summary>
        /// Returns the opacity of the whole window.
        /// <para>This function returns the opacity of the window, including any decorations.</para>
        /// <para>
        /// The opacity (or alpha) value is a positive finite number between zero and
        /// one, where zero is fully transparent and one is fully opaque.  If the system
        /// does not support whole window transparency, this function always returns one.
        /// </para>
        /// <para>The initial opacity value for newly created windows is one.</para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI float glfwGetWindowOpacity(GLFWwindow* window);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to query.</param>
        /// <returns>The opacity value of the specified window.</returns>
        /// <seealso cref="SetWindowOpacity"/>
        public static float GetWindowOpacity(IntPtr window) {
            return GLFWNative.glfwGetWindowOpacity(window);
        }
        /// <summary>
        /// Sets the opacity of the whole window.
        /// <para>This function sets the opacity of the window, including any decorations.</para>
        /// <para>
        /// The opacity (or alpha) value is a positive finite number between zero and
        /// one, where zero is fully transparent and one is fully opaque.
        /// </para>
        /// <para>The initial opacity value for newly created windows is one.</para>
        /// <para>
        /// A window created with framebuffer transparency may not use whole window
        /// transparency.  The results of doing this are undefined.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetWindowOpacity(GLFWwindow* window, float opacity);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to set the opacity for.</param>
        /// <param name="opacity">[in] The desired opacity of the specified window.</param>
        /// <seealso cref="GetWindowOpacity"/>
        public static void SetWindowOpacity(IntPtr window, float opacity) {
            GLFWNative.glfwSetWindowOpacity(window, opacity);
        }
        /// <summary>
        /// Iconifies the specified window.
        /// <para>
        /// This function iconifies (minimizes) the specified window if it was
        /// previously restored.  If the window is already iconified, this function does
        /// nothing.
        /// </para>
        /// <para>
        /// If the specified window is a full screen window, the original monitor
        /// resolution is restored until the window is restored.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>glfw3: Added window handle parameter.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwIconifyWindow(GLFWwindow* window);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to iconify.</param>
        /// <remarks>
        /// [wayland] There is no concept of iconification in wl_shell, this
        /// function will emit <see cref="PLATFORM_ERROR"/> when using this deprecated
        /// protocol.
        /// </remarks>
        /// <seealso cref="RestoreWindow"/>
        /// <seealso cref="MaximizeWindow"/>
        public static void IconifyWindow(IntPtr window) {
            GLFWNative.glfwIconifyWindow(window);
        }
        /// <summary>
        /// Restores the specified window.
        /// <para>
        /// This function restores the specified window if it was previously iconified
        /// (minimized) or maximized.  If the window is already restored, this function
        /// does nothing.
        /// </para>
        /// <para>
        /// If the specified window is a full screen window, the resolution chosen for
        /// the window is restored on the selected monitor.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>glfw3: Added window handle parameter.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwRestoreWindow(GLFWwindow* window);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to restore.</param>
        /// <seealso cref="IconifyWindow"/>
        /// <seealso cref="MaximizeWindow"/>
        public static void RestoreWindow(IntPtr window) {
            GLFWNative.glfwRestoreWindow(window);
        }
        /// <summary>
        /// Maximizes the specified window.
        /// <para>
        /// This function maximizes the specified window if it was previously not
        /// maximized.  If the window is already maximized, this function does nothing.
        /// </para>
        /// <para>If the specified window is a full screen window, this function does nothing.</para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// par:
        /// Thread Safety
        /// This function may only be called from the main thread.
        /// </para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwMaximizeWindow(GLFWwindow* window);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to maximize.</param>
        /// <seealso cref="IconifyWindow"/>
        /// <seealso cref="RestoreWindow"/>
        public static void MaximizeWindow(IntPtr window) {
            GLFWNative.glfwMaximizeWindow(window);
        }
        /// <summary>
        /// Makes the specified window visible.
        /// <para>
        /// This function makes the specified window visible if it was previously
        /// hidden.  If the window is already visible or is in full screen mode, this
        /// function does nothing.
        /// </para>
        /// <para>
        /// By default, windowed mode windows are focused when shown
        /// Set the [GLFW_FOCUS_ON_SHOW](<see cref="FOCUS_ON_SHOW_hint"/>) window hint
        /// to change this behavior for all newly created windows, or change the
        /// behavior for an existing window with <see cref="SetWindowAttrib"/>.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwShowWindow(GLFWwindow* window);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to make visible.</param>
        /// <remarks>
        /// [wayland] Because Wayland wants every frame of the desktop to be
        /// complete, this function does not immediately make the window visible.
        /// Instead it will become visible the next time the window framebuffer is
        /// updated after this call.
        /// </remarks>
        /// <seealso cref="HideWindow"/>
        public static void ShowWindow(IntPtr window) {
            GLFWNative.glfwShowWindow(window);
        }
        /// <summary>
        /// Hides the specified window.
        /// <para>
        /// This function hides the specified window if it was previously visible.  If
        /// the window is already hidden or is in full screen mode, this function does
        /// nothing.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwHideWindow(GLFWwindow* window);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to hide.</param>
        /// <seealso cref="ShowWindow"/>
        public static void HideWindow(IntPtr window) {
            GLFWNative.glfwHideWindow(window);
        }
        /// <summary>
        /// Brings the specified window to front and sets input focus.
        /// <para>
        /// This function brings the specified window to front and sets input focus.
        /// The window should already be visible and not iconified.
        /// </para>
        /// <para>
        /// By default, both windowed and full screen mode windows are focused when
        /// initially created.  Set the [GLFW_FOCUSED](<see cref="FOCUSED_hint"/>) to
        /// disable this behavior.
        /// </para>
        /// <para>
        /// Also by default, windowed mode windows are focused when shown
        /// with <see cref="ShowWindow"/>. Set the
        /// [GLFW_FOCUS_ON_SHOW](<see cref="FOCUS_ON_SHOW_hint"/>) to disable this behavior.
        /// </para>
        /// <para>
        /// __Do not use this function__ to steal focus from other applications unless
        /// you are certain that is what the user wants.  Focus stealing can be
        /// extremely disruptive.
        /// </para>
        /// <para>
        /// For a less disruptive way of getting the user's attention, see
        /// [attention requests](@ref window_attention).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwFocusWindow(GLFWwindow* window);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to give input focus.</param>
        /// <remarks>
        /// [wayland] It is not possible for an application to bring its windows
        /// to front, this function will always emit <see cref="PLATFORM_ERROR"/>.
        /// </remarks>
        public static void FocusWindow(IntPtr window) {
            GLFWNative.glfwFocusWindow(window);
        }
        /// <summary>
        /// Requests user attention to the specified window.
        /// <para>
        /// This function requests user attention to the specified window.  On
        /// platforms where this is not supported, attention is requested to the
        /// application as a whole.
        /// </para>
        /// <para>
        /// Once the user has given attention, usually by focusing the window or
        /// application, the system will end the request automatically.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwRequestWindowAttention(GLFWwindow* window);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to request attention to.</param>
        /// <remarks>
        /// [macos] Attention is requested to the application as a whole, not the
        /// specific window.
        /// </remarks>
        public static void RequestWindowAttention(IntPtr window) {
            GLFWNative.glfwRequestWindowAttention(window);
        }
        /// <summary>
        /// Returns the monitor that the window uses for full screen mode.
        /// <para>
        /// This function returns the handle of the monitor that the specified window is
        /// in full screen on.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWmonitor* glfwGetWindowMonitor(GLFWwindow* window);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to query.</param>
        /// <returns>
        /// The monitor, or <c>NULL</c> if the window is in windowed mode or an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        /// <seealso cref="SetWindowMonitor"/>
        public static IntPtr GetWindowMonitor(IntPtr window) {
            return GLFWNative.glfwGetWindowMonitor(window);
        }
        /// <summary>
        /// Sets the mode, monitor, video mode and placement of a window.
        /// <para>
        /// This function sets the monitor that the window uses for full screen mode or,
        /// if the monitor is <c>NULL</c>, makes it windowed mode.
        /// </para>
        /// <para>
        /// When setting a monitor, this function updates the width, height and refresh
        /// rate of the desired video mode and switches to the video mode closest to it.
        /// The window position is ignored when setting a monitor.
        /// </para>
        /// <para>
        /// When the monitor is <c>NULL</c>, the position, width and height are used to
        /// place the window content area.  The refresh rate is ignored when no monitor
        /// is specified.
        /// </para>
        /// <para>
        /// If you only wish to update the resolution of a full screen window or the
        /// size of a windowed mode window, see <see cref="SetWindowSize"/>.
        /// </para>
        /// <para>
        /// When a window transitions from full screen to windowed mode, this function
        /// restores any previous window settings such as whether it is decorated,
        /// floating, resizable, has size or aspect ratio limits, etc.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetWindowMonitor(GLFWwindow* window, GLFWmonitor* monitor, int xpos, int ypos, int width, int height, int refreshRate);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose monitor, size or video mode to set.</param>
        /// <param name="monitor">[in] The desired monitor, or <c>NULL</c> to set windowed mode.</param>
        /// <param name="xpos">
        /// [in] The desired x-coordinate of the upper-left corner of the
        /// content area.
        /// </param>
        /// <param name="ypos">
        /// [in] The desired y-coordinate of the upper-left corner of the
        /// content area.
        /// </param>
        /// <param name="width">
        /// [in] The desired with, in screen coordinates, of the content
        /// area or video mode.
        /// </param>
        /// <param name="height">
        /// [in] The desired height, in screen coordinates, of the content
        /// area or video mode.
        /// </param>
        /// <param name="refreshRate">
        /// [in] The desired refresh rate, in Hz, of the video mode,
        /// or <c>GLFW_DONT_CARE</c>.
        /// </param>
        /// <remarks>
        /// The OpenGL or OpenGL ES context will not be destroyed or otherwise
        /// affected by any resizing or mode switching, although you may need to update
        /// your viewport if the framebuffer size has changed.
        /// </remarks>
        /// <remarks>
        /// [wayland] The desired window position is ignored, as there is no way
        /// for an application to set this property.
        /// </remarks>
        /// <remarks>
        /// [wayland] Setting the window to full screen will not attempt to
        /// change the mode, no matter what the requested size or refresh rate.
        /// </remarks>
        /// <seealso cref="GetWindowMonitor"/>
        /// <seealso cref="SetWindowSize"/>
        public static void SetWindowMonitor(IntPtr window, IntPtr monitor, int xpos, int ypos, int width, int height, int refreshRate) {
            GLFWNative.glfwSetWindowMonitor(window, monitor, xpos, ypos, width, height, refreshRate);
        }
        /// <summary>
        /// Returns an attribute of the specified window.
        /// <para>
        /// This function returns the value of an attribute of the specified window or
        /// its OpenGL or OpenGL ES context.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="INVALID_ENUM"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI int glfwGetWindowAttrib(GLFWwindow* window, int attrib);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to query.</param>
        /// <param name="attrib">
        /// [in] The [window attribute](@ref window_attribs) whose value to
        /// return.
        /// </param>
        /// <returns>
        /// The value of the attribute, or zero if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        /// <remarks>
        /// Framebuffer related hints are not window attributes.  See @ref
        /// window_attribs_fb for more information.
        /// </remarks>
        /// <remarks>
        /// Zero is a valid value for many window and context related
        /// attributes so you cannot use a return value of zero as an indication of
        /// errors.  However, this function should not fail as long as it is passed
        /// valid arguments and the library has been [initialized](@ref intro_init).
        /// </remarks>
        /// <seealso cref="SetWindowAttrib"/>
        public static int GetWindowAttrib(IntPtr window, int attrib) {
            return GLFWNative.glfwGetWindowAttrib(window, attrib);
        }
        /// <summary>
        /// Sets an attribute of the specified window.
        /// <para>This function sets the value of an attribute of the specified window.</para>
        /// <para>
        /// The supported attributes are [GLFW_DECORATED](<see cref="DECORATED_attrib"/>),
        /// [GLFW_RESIZABLE](<see cref="RESIZABLE_attrib"/>),
        /// [GLFW_FLOATING](<see cref="FLOATING_attrib"/>),
        /// [GLFW_AUTO_ICONIFY](<see cref="AUTO_ICONIFY_attrib"/>) and
        /// [GLFW_FOCUS_ON_SHOW](<see cref="FOCUS_ON_SHOW_attrib"/>).
        /// </para>
        /// <para>
        /// Some of these attributes are ignored for full screen windows.  The new
        /// value will take effect if the window is later made windowed.
        /// </para>
        /// <para>
        /// Some of these attributes are ignored for windowed mode windows.  The new
        /// value will take effect if the window is later made full screen.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="INVALID_ENUM"/>, <see cref="INVALID_VALUE"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetWindowAttrib(GLFWwindow* window, int attrib, int value);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to set the attribute for.</param>
        /// <param name="attrib">[in] A supported window attribute.</param>
        /// <param name="value">[in] <c>GLFW_TRUE</c> or <c>GLFW_FALSE</c>.</param>
        /// <remarks>
        /// Calling <see cref="GetWindowAttrib"/> will always return the latest
        /// value, even if that value is ignored by the current mode of the window.
        /// </remarks>
        /// <seealso cref="GetWindowAttrib"/>
        public static void SetWindowAttrib(IntPtr window, int attrib, int value) {
            GLFWNative.glfwSetWindowAttrib(window, attrib, value);
        }
        /// <summary>
        /// Sets the position callback for the specified window.
        /// <para>
        /// This function sets the position callback of the specified window, which is
        /// called when the window is moved.  The callback is provided with the
        /// position, in screen coordinates, of the upper-left corner of the content
        /// area of the window.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int xpos, int ypos)
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWwindowposfun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWwindowposfun glfwSetWindowPosCallback(GLFWwindow* window, GLFWwindowposfun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose callback to set.</param>
        /// <param name="callback">
        /// [in] The new callback, or <c>NULL</c> to remove the currently set
        /// callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        /// <remarks>
        /// [wayland] This callback will never be called, as there is no way for
        /// an application to know its global position.
        /// </remarks>
        public static CBWindowPos SetWindowPosCallback(IntPtr window, CBWindowPos callback) {
            m_cb_window_pos = callback;
            return GLFW.glfwSetWindowPosCallback(window, m_cb_window_pos);
        }
        /// <summary>
        /// Sets the size callback for the specified window.
        /// <para>
        /// This function sets the size callback of the specified window, which is
        /// called when the window is resized.  The callback is provided with the size,
        /// in screen coordinates, of the content area of the window.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int width, int height)
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWwindowsizefun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>glfw3: Added window handle parameter and return value.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWwindowsizefun glfwSetWindowSizeCallback(GLFWwindow* window, GLFWwindowsizefun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose callback to set.</param>
        /// <param name="callback">
        /// [in] The new callback, or <c>NULL</c> to remove the currently set
        /// callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        public static CBWindowSize SetWindowSizeCallback(IntPtr window, CBWindowSize callback) {
            m_cb_window_size = callback;
            return GLFW.glfwSetWindowSizeCallback(window, m_cb_window_size);
        }
        /// <summary>
        /// Sets the close callback for the specified window.
        /// <para>
        /// This function sets the close callback of the specified window, which is
        /// called when the user attempts to close the window, for example by clicking
        /// the close widget in the title bar.
        /// </para>
        /// <para>
        /// The close flag is set before this callback is called, but you can modify it
        /// at any time with <see cref="SetWindowShouldClose"/>.
        /// </para>
        /// <para>The close callback is not triggered by <see cref="DestroyWindow"/>.</para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWwindow* window)
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWwindowclosefun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>glfw3: Added window handle parameter and return value.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWwindowclosefun glfwSetWindowCloseCallback(GLFWwindow* window, GLFWwindowclosefun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose callback to set.</param>
        /// <param name="callback">
        /// [in] The new callback, or <c>NULL</c> to remove the currently set
        /// callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        /// <remarks>
        /// [macos] Selecting Quit from the application menu will trigger the
        /// close callback for all windows.
        /// </remarks>
        public static CBWindowClose SetWindowCloseCallback(IntPtr window, CBWindowClose callback) {
            m_cb_window_close = callback;
            return GLFW.glfwSetWindowCloseCallback(window, m_cb_window_close);
        }
        /// <summary>
        /// Sets the refresh callback for the specified window.
        /// <para>
        /// This function sets the refresh callback of the specified window, which is
        /// called when the content area of the window needs to be redrawn, for example
        /// if the window has been exposed after having been covered by another window.
        /// </para>
        /// <para>
        /// On compositing window systems such as Aero, Compiz, Aqua or Wayland, where
        /// the window contents are saved off-screen, this callback may be called only
        /// very infrequently or never at all.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWwindow* window);
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWwindowrefreshfun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>glfw3: Added window handle parameter and return value.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWwindowrefreshfun glfwSetWindowRefreshCallback(GLFWwindow* window, GLFWwindowrefreshfun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose callback to set.</param>
        /// <param name="callback">
        /// [in] The new callback, or <c>NULL</c> to remove the currently set
        /// callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        public static CBWindowRefresh SetWindowRefreshCallback(IntPtr window, CBWindowRefresh callback) {
            m_cb_window_refresh = callback;
            return GLFW.glfwSetWindowRefreshCallback(window, m_cb_window_refresh);
        }
        /// <summary>
        /// Sets the focus callback for the specified window.
        /// <para>
        /// This function sets the focus callback of the specified window, which is
        /// called when the window gains or loses input focus.
        /// </para>
        /// <para>
        /// After the focus callback is called for a window that lost input focus,
        /// synthetic key and mouse button release events will be generated for all such
        /// that had been pressed.  For more information, see <see cref="SetKeyCallback"/>
        /// and <see cref="SetMouseButtonCallback"/>.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int focused)
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWwindowfocusfun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWwindowfocusfun glfwSetWindowFocusCallback(GLFWwindow* window, GLFWwindowfocusfun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose callback to set.</param>
        /// <param name="callback">
        /// [in] The new callback, or <c>NULL</c> to remove the currently set
        /// callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        public static CBWindowFocus SetWindowFocusCallback(IntPtr window, CBWindowFocus callback) {
            m_cb_window_focus = callback;
            return GLFW.glfwSetWindowFocusCallback(window, m_cb_window_focus);
        }
        /// <summary>
        /// Sets the iconify callback for the specified window.
        /// <para>
        /// This function sets the iconification callback of the specified window, which
        /// is called when the window is iconified or restored.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int iconified)
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWwindowiconifyfun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWwindowiconifyfun glfwSetWindowIconifyCallback(GLFWwindow* window, GLFWwindowiconifyfun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose callback to set.</param>
        /// <param name="callback">
        /// [in] The new callback, or <c>NULL</c> to remove the currently set
        /// callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        /// <remarks>
        /// [wayland] The wl_shell protocol has no concept of iconification,
        /// this callback will never be called when using this deprecated protocol.
        /// </remarks>
        public static CBWindowIconify SetWindowIconifyCallback(IntPtr window, CBWindowIconify callback) {
            m_cb_window_iconify = callback;
            return GLFW.glfwSetWindowIconifyCallback(window, m_cb_window_iconify);
        }
        /// <summary>
        /// Sets the maximize callback for the specified window.
        /// <para>
        /// This function sets the maximization callback of the specified window, which
        /// is called when the window is maximized or restored.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int maximized)
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWwindowmaximizefun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWwindowmaximizefun glfwSetWindowMaximizeCallback(GLFWwindow* window, GLFWwindowmaximizefun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose callback to set.</param>
        /// <param name="callback">
        /// [in] The new callback, or <c>NULL</c> to remove the currently set
        /// callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        public static CBWindowMaximize SetWindowMaximizeCallback(IntPtr window, CBWindowMaximize callback) {
            m_cb_window_maximize = callback;
            return GLFW.glfwSetWindowMaximizeCallback(window,m_cb_window_maximize);
        }
        /// <summary>
        /// Sets the framebuffer resize callback for the specified window.
        /// <para>
        /// This function sets the framebuffer resize callback of the specified window,
        /// which is called when the framebuffer of the specified window is resized.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int width, int height)
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWframebuffersizefun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWframebuffersizefun glfwSetFramebufferSizeCallback(GLFWwindow* window, GLFWframebuffersizefun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose callback to set.</param>
        /// <param name="callback">
        /// [in] The new callback, or <c>NULL</c> to remove the currently set
        /// callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        public static CBFrameBufferSize SetFramebufferSizeCallback(IntPtr window, CBFrameBufferSize callback) {
            m_cb_frame_buffer_size = callback;
            return GLFW.glfwSetFramebufferSizeCallback(window, m_cb_frame_buffer_size);
        }
        /// <summary>
        /// Sets the window content scale callback for the specified window.
        /// <para>
        /// This function sets the window content scale callback of the specified window,
        /// which is called when the content scale of the specified window changes.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWwindow* window, float xscale, float yscale)
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWwindowcontentscalefun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWwindowcontentscalefun glfwSetWindowContentScaleCallback(GLFWwindow* window, GLFWwindowcontentscalefun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose callback to set.</param>
        /// <param name="callback">
        /// [in] The new callback, or <c>NULL</c> to remove the currently set
        /// callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        /// <seealso cref="GetWindowContentScale"/>
        public static CBWindowContentScale SetWindowContentScaleCallback(IntPtr window, CBWindowContentScale callback) {
            m_cb_window_content_scale = callback;
            return GLFW.glfwSetWindowContentScaleCallback(window, m_cb_window_content_scale);
        }
        /// <summary>
        /// Processes all pending events.
        /// <para>
        /// This function processes only those events that are already in the event
        /// queue and then returns immediately.  Processing events will cause the window
        /// and input callbacks associated with those events to be called.
        /// </para>
        /// <para>
        /// On some platforms, a window move, resize or menu operation will cause event
        /// processing to block.  This is due to how event processing is designed on
        /// those platforms.  You can use the
        /// [window refresh callback](@ref window_refresh) to redraw the contents of
        /// your window when necessary during such operations.
        /// </para>
        /// <para>
        /// Do not assume that callbacks you set will _only_ be called in response to
        /// event processing functions like this one.  While it is necessary to poll for
        /// events, window systems that require GLFW to register callbacks of its own
        /// can pass events to GLFW in response to many window system function calls.
        /// GLFW will pass those events on to the application callbacks before
        /// returning.
        /// </para>
        /// <para>Event processing is not required for joystick input to work.</para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>reentrancy: This function must not be called from a callback.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwPollEvents(void);
        /// </code>
        /// </para>
        /// </summary>
        /// <seealso cref="WaitEvents"/>
        /// <seealso cref="WaitEventsTimeout"/>
        public static void PollEvents() {
            GLFWNative.glfwPollEvents();
        }
        /// <summary>
        /// Waits until events are queued and processes them.
        /// <para>
        /// This function puts the calling thread to sleep until at least one event is
        /// available in the event queue.  Once one or more events are available,
        /// it behaves exactly like <see cref="PollEvents"/>, i.e. the events in the queue
        /// are processed and the function then returns immediately.  Processing events
        /// will cause the window and input callbacks associated with those events to be
        /// called.
        /// </para>
        /// <para>
        /// Since not all events are associated with callbacks, this function may return
        /// without a callback having been called even if you are monitoring all
        /// callbacks.
        /// </para>
        /// <para>
        /// On some platforms, a window move, resize or menu operation will cause event
        /// processing to block.  This is due to how event processing is designed on
        /// those platforms.  You can use the
        /// [window refresh callback](@ref window_refresh) to redraw the contents of
        /// your window when necessary during such operations.
        /// </para>
        /// <para>
        /// Do not assume that callbacks you set will _only_ be called in response to
        /// event processing functions like this one.  While it is necessary to poll for
        /// events, window systems that require GLFW to register callbacks of its own
        /// can pass events to GLFW in response to many window system function calls.
        /// GLFW will pass those events on to the application callbacks before
        /// returning.
        /// </para>
        /// <para>Event processing is not required for joystick input to work.</para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>reentrancy: This function must not be called from a callback.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwWaitEvents(void);
        /// </code>
        /// </para>
        /// </summary>
        /// <seealso cref="PollEvents"/>
        /// <seealso cref="WaitEventsTimeout"/>
        public static void WaitEvents() {
            GLFWNative.glfwWaitEvents();
        }
        /// <summary>
        /// Waits with timeout until events are queued and processes them.
        /// <para>
        /// This function puts the calling thread to sleep until at least one event is
        /// available in the event queue, or until the specified timeout is reached.  If
        /// one or more events are available, it behaves exactly like <see cref="PollEvents"/>, i.e. the events in the queue are processed and the function
        /// then returns immediately.  Processing events will cause the window and input
        /// callbacks associated with those events to be called.
        /// </para>
        /// <para>The timeout value must be a positive finite number.</para>
        /// <para>
        /// Since not all events are associated with callbacks, this function may return
        /// without a callback having been called even if you are monitoring all
        /// callbacks.
        /// </para>
        /// <para>
        /// On some platforms, a window move, resize or menu operation will cause event
        /// processing to block.  This is due to how event processing is designed on
        /// those platforms.  You can use the
        /// [window refresh callback](@ref window_refresh) to redraw the contents of
        /// your window when necessary during such operations.
        /// </para>
        /// <para>
        /// Do not assume that callbacks you set will _only_ be called in response to
        /// event processing functions like this one.  While it is necessary to poll for
        /// events, window systems that require GLFW to register callbacks of its own
        /// can pass events to GLFW in response to many window system function calls.
        /// GLFW will pass those events on to the application callbacks before
        /// returning.
        /// </para>
        /// <para>Event processing is not required for joystick input to work.</para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="INVALID_VALUE"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>reentrancy: This function must not be called from a callback.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwWaitEventsTimeout(double timeout);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="timeout">[in] The maximum amount of time, in seconds, to wait.</param>
        /// <seealso cref="PollEvents"/>
        /// <seealso cref="WaitEvents"/>
        public static void WaitEventsTimeout(double timeout) {
            GLFWNative.glfwWaitEventsTimeout(timeout);
        }
        /// <summary>
        /// Posts an empty event to the event queue.
        /// <para>
        /// This function posts an empty event from the current thread to the event
        /// queue, causing <see cref="WaitEvents"/> or <see cref="WaitEventsTimeout"/> to return.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function may be called from any thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwPostEmptyEvent(void);
        /// </code>
        /// </para>
        /// </summary>
        /// <seealso cref="WaitEvents"/>
        /// <seealso cref="WaitEventsTimeout"/>
        public static void PostEmptyEvent() {
            GLFWNative.glfwPostEmptyEvent();
        }
        /// <summary>
        /// Returns the value of an input option for the specified window.
        /// <para>
        /// This function returns the value of an input option for the specified window.
        /// The mode must be one of <see cref="CURSOR"/>, <see cref="STICKY_KEYS"/>,
        /// <see cref="STICKY_MOUSE_BUTTONS"/>, <see cref="LOCK_KEY_MODS"/> or
        /// <see cref="RAW_MOUSE_MOTION"/>.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="INVALID_ENUM"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI int glfwGetInputMode(GLFWwindow* window, int mode);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to query.</param>
        /// <param name="mode">
        /// [in] One of <c>GLFW_CURSOR</c>, <c>GLFW_STICKY_KEYS</c>,
        /// <c>GLFW_STICKY_MOUSE_BUTTONS</c>, <c>GLFW_LOCK_KEY_MODS</c> or
        /// <c>GLFW_RAW_MOUSE_MOTION</c>.
        /// </param>
        /// <seealso cref="SetInputMode"/>
        public static int GetInputMode(IntPtr window, int mode) {
            return GLFWNative.glfwGetInputMode(window, mode);
        }
        /// <summary>
        /// Sets an input option for the specified window.
        /// <para>
        /// This function sets an input mode option for the specified window.  The mode
        /// must be one of <see cref="CURSOR"/>, <see cref="STICKY_KEYS"/>,
        /// <see cref="STICKY_MOUSE_BUTTONS"/>, <see cref="LOCK_KEY_MODS"/> or
        /// <see cref="RAW_MOUSE_MOTION"/>.
        /// </para>
        /// <para>
        /// If the mode is <c>GLFW_CURSOR</c>, the value must be one of the following cursor
        /// modes:
        /// - <c>GLFW_CURSOR_NORMAL</c> makes the cursor visible and behaving normally.
        /// - <c>GLFW_CURSOR_HIDDEN</c> makes the cursor invisible when it is over the
        /// content area of the window but does not restrict the cursor from leaving.
        /// - <c>GLFW_CURSOR_DISABLED</c> hides and grabs the cursor, providing virtual
        /// and unlimited cursor movement.  This is useful for implementing for
        /// example 3D camera controls.
        /// </para>
        /// <para>
        /// If the mode is <c>GLFW_STICKY_KEYS</c>, the value must be either <c>GLFW_TRUE</c> to
        /// enable sticky keys, or <c>GLFW_FALSE</c> to disable it.  If sticky keys are
        /// enabled, a key press will ensure that <see cref="GetKey"/> returns <c>GLFW_PRESS</c>
        /// the next time it is called even if the key had been released before the
        /// call.  This is useful when you are only interested in whether keys have been
        /// pressed but not when or in which order.
        /// </para>
        /// <para>
        /// If the mode is <c>GLFW_STICKY_MOUSE_BUTTONS</c>, the value must be either
        /// <c>GLFW_TRUE</c> to enable sticky mouse buttons, or <c>GLFW_FALSE</c> to disable it.
        /// If sticky mouse buttons are enabled, a mouse button press will ensure that
        /// <see cref="GetMouseButton"/> returns <c>GLFW_PRESS</c> the next time it is called even
        /// if the mouse button had been released before the call.  This is useful when
        /// you are only interested in whether mouse buttons have been pressed but not
        /// when or in which order.
        /// </para>
        /// <para>
        /// If the mode is <c>GLFW_LOCK_KEY_MODS</c>, the value must be either <c>GLFW_TRUE</c> to
        /// enable lock key modifier bits, or <c>GLFW_FALSE</c> to disable them.  If enabled,
        /// callbacks that receive modifier bits will also have the <see cref="MOD_CAPS_LOCK"/> bit set when the event was generated with Caps Lock on,
        /// and the <see cref="MOD_NUM_LOCK"/> bit when Num Lock was on.
        /// </para>
        /// <para>
        /// If the mode is <c>GLFW_RAW_MOUSE_MOTION</c>, the value must be either <c>GLFW_TRUE</c>
        /// to enable raw (unscaled and unaccelerated) mouse motion when the cursor is
        /// disabled, or <c>GLFW_FALSE</c> to disable it.  If raw motion is not supported,
        /// attempting to set this will emit <see cref="PLATFORM_ERROR"/>.  Call <see cref="RawMouseMotionSupported"/> to check for support.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="INVALID_ENUM"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetInputMode(GLFWwindow* window, int mode, int value);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose input mode to set.</param>
        /// <param name="mode">
        /// [in] One of <c>GLFW_CURSOR</c>, <c>GLFW_STICKY_KEYS</c>,
        /// <c>GLFW_STICKY_MOUSE_BUTTONS</c>, <c>GLFW_LOCK_KEY_MODS</c> or
        /// <c>GLFW_RAW_MOUSE_MOTION</c>.
        /// </param>
        /// <param name="value">[in] The new value of the specified input mode.</param>
        /// <seealso cref="GetInputMode"/>
        public static void SetInputMode(IntPtr window, int mode, int value) {
            GLFWNative.glfwSetInputMode(window, mode, value);
        }
        /// <summary>
        /// Returns whether raw mouse motion is supported.
        /// <para>
        /// This function returns whether raw mouse motion is supported on the current
        /// system.  This status does not change after GLFW has been initialized so you
        /// only need to check this once.  If you attempt to enable raw motion on
        /// a system that does not support it, <see cref="PLATFORM_ERROR"/> will be emitted.
        /// </para>
        /// <para>
        /// Raw mouse motion is closer to the actual motion of the mouse across
        /// a surface.  It is not affected by the scaling and acceleration applied to
        /// the motion of the desktop cursor.  That processing is suitable for a cursor
        /// while raw motion is better for controlling for example a 3D camera.  Because
        /// of this, raw mouse motion is only provided when the cursor is disabled.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI int glfwRawMouseMotionSupported(void);
        /// </code>
        /// </para>
        /// </summary>
        /// <returns>
        /// <c>GLFW_TRUE</c> if raw mouse motion is supported on the current machine,
        /// or <c>GLFW_FALSE</c> otherwise.
        /// </returns>
        /// <seealso cref="SetInputMode"/>
        public static int RawMouseMotionSupported() {
            return GLFWNative.glfwRawMouseMotionSupported();
        }
        /// <summary>
        /// Returns the layout-specific name of the specified printable key.
        /// <para>
        /// This function returns the name of the specified printable key, encoded as
        /// UTF-8.  This is typically the character that key would produce without any
        /// modifier keys, intended for displaying key bindings to the user.  For dead
        /// keys, it is typically the diacritic it would add to a character.
        /// </para>
        /// <para>
        /// __Do not use this function__ for [text input](@ref input_char).  You will
        /// break text input for many languages even if it happens to work for yours.
        /// </para>
        /// <para>
        /// If the key is <c>GLFW_KEY_UNKNOWN</c>, the scancode is used to identify the key,
        /// otherwise the scancode is ignored.  If you specify a non-printable key, or
        /// <c>GLFW_KEY_UNKNOWN</c> and a scancode that maps to a non-printable key, this
        /// function returns <c>NULL</c> but does not emit an error.
        /// </para>
        /// <para>
        /// This behavior allows you to always pass in the arguments in the
        /// [key callback](@ref input_key) without modification.
        /// </para>
        /// <para>
        /// The printable keys are:
        /// - <c>GLFW_KEY_APOSTROPHE</c>
        /// - <c>GLFW_KEY_COMMA</c>
        /// - <c>GLFW_KEY_MINUS</c>
        /// - <c>GLFW_KEY_PERIOD</c>
        /// - <c>GLFW_KEY_SLASH</c>
        /// - <c>GLFW_KEY_SEMICOLON</c>
        /// - <c>GLFW_KEY_EQUAL</c>
        /// - <c>GLFW_KEY_LEFT_BRACKET</c>
        /// - <c>GLFW_KEY_RIGHT_BRACKET</c>
        /// - <c>GLFW_KEY_BACKSLASH</c>
        /// - <c>GLFW_KEY_WORLD_1</c>
        /// - <c>GLFW_KEY_WORLD_2</c>
        /// - <c>GLFW_KEY_0</c> to <c>GLFW_KEY_9</c>
        /// - <c>GLFW_KEY_A</c> to <c>GLFW_KEY_Z</c>
        /// - <c>GLFW_KEY_KP_0</c> to <c>GLFW_KEY_KP_9</c>
        /// - <c>GLFW_KEY_KP_DECIMAL</c>
        /// - <c>GLFW_KEY_KP_DIVIDE</c>
        /// - <c>GLFW_KEY_KP_MULTIPLY</c>
        /// - <c>GLFW_KEY_KP_SUBTRACT</c>
        /// - <c>GLFW_KEY_KP_ADD</c>
        /// - <c>GLFW_KEY_KP_EQUAL</c>
        /// </para>
        /// <para>
        /// Names for printable keys depend on keyboard layout, while names for
        /// non-printable keys are the same across layouts but depend on the application
        /// language and should be localized along with other user interface text.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The returned string is allocated and freed by GLFW.  You
        /// should not free it yourself.  It is valid until the library is terminated.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI const char* glfwGetKeyName(int key, int scancode);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="key">[in] The key to query, or <c>GLFW_KEY_UNKNOWN</c>.</param>
        /// <param name="scancode">[in] The scancode of the key to query.</param>
        /// <returns>The UTF-8 encoded, layout-specific name of the key, or <c>NULL</c>.</returns>
        /// <remarks>
        /// The contents of the returned string may change when a keyboard
        /// layout change event is received.
        /// </remarks>
        public static unsafe string GetKeyName(int key, int scancode) {
            byte* ptr = GLFWNative.glfwGetKeyName(key, scancode);
            if (ptr == null) return null;
            return MarshalExtend.PtrToString(ptr);
        }
        /// <summary>
        /// Returns the platform-specific scancode of the specified key.
        /// <para>This function returns the platform-specific scancode of the specified key.</para>
        /// <para>
        /// If the key is <c>GLFW_KEY_UNKNOWN</c> or does not exist on the keyboard this
        /// method will return <c>-1</c>.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="INVALID_ENUM"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function may be called from any thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI int glfwGetKeyScancode(int key);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="key">[in] Any [named key](@ref keys).</param>
        /// <returns>
        /// The platform-specific scancode for the key, or <c>-1</c> if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        public static int GetKeyScancode(int key) {
            return GLFWNative.glfwGetKeyScancode(key);
        }
        /// <summary>
        /// Returns the last reported state of a keyboard key for the specified
        /// window.
        /// <para>
        /// This function returns the last state reported for the specified key to the
        /// specified window.  The returned state is one of <c>GLFW_PRESS</c> or
        /// <c>GLFW_RELEASE</c>.  The higher-level action <c>GLFW_REPEAT</c> is only reported to
        /// the key callback.
        /// </para>
        /// <para>
        /// If the <see cref="STICKY_KEYS"/> input mode is enabled, this function returns
        /// <c>GLFW_PRESS</c> the first time you call it for a key that was pressed, even if
        /// that key has already been released.
        /// </para>
        /// <para>
        /// The key functions deal with physical keys, with [key tokens](@ref keys)
        /// named after their use on the standard US keyboard layout.  If you want to
        /// input text, use the Unicode character callback instead.
        /// </para>
        /// <para>
        /// The [modifier key bit masks](@ref mods) are not key tokens and cannot be
        /// used with this function.
        /// </para>
        /// <para>__Do not use this function__ to implement [text input](@ref input_char).</para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="INVALID_ENUM"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>glfw3: Added window handle parameter.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI int glfwGetKey(GLFWwindow* window, int key);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The desired window.</param>
        /// <param name="key">
        /// [in] The desired [keyboard key](@ref keys).  <c>GLFW_KEY_UNKNOWN</c> is
        /// not a valid key for this function.
        /// </param>
        /// <returns>One of <c>GLFW_PRESS</c> or <c>GLFW_RELEASE</c>.</returns>
        public static int GetKey(IntPtr window, int key) {
            return GLFWNative.glfwGetKey(window, key);
        }
        /// <summary>
        /// Returns the last reported state of a mouse button for the specified
        /// window.
        /// <para>
        /// This function returns the last state reported for the specified mouse button
        /// to the specified window.  The returned state is one of <c>GLFW_PRESS</c> or
        /// <c>GLFW_RELEASE</c>.
        /// </para>
        /// <para>
        /// If the <see cref="STICKY_MOUSE_BUTTONS"/> input mode is enabled, this function
        /// returns <c>GLFW_PRESS</c> the first time you call it for a mouse button that was
        /// pressed, even if that mouse button has already been released.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="INVALID_ENUM"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>glfw3: Added window handle parameter.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI int glfwGetMouseButton(GLFWwindow* window, int button);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The desired window.</param>
        /// <param name="button">[in] The desired [mouse button](@ref buttons).</param>
        /// <returns>One of <c>GLFW_PRESS</c> or <c>GLFW_RELEASE</c>.</returns>
        public static int GetMouseButton(IntPtr window, int button) {
            return GLFWNative.glfwGetMouseButton(window, button);
        }
        /// <summary>
        /// Sets the position of the cursor, relative to the content area of the
        /// window.
        /// <para>
        /// This function sets the position, in screen coordinates, of the cursor
        /// relative to the upper-left corner of the content area of the specified
        /// window.  The window must have input focus.  If the window does not have
        /// input focus when this function is called, it fails silently.
        /// </para>
        /// <para>
        /// __Do not use this function__ to implement things like camera controls.  GLFW
        /// already provides the <c>GLFW_CURSOR_DISABLED</c> cursor mode that hides the
        /// cursor, transparently re-centers it and provides unconstrained cursor
        /// motion.  See <see cref="SetInputMode"/> for more information.
        /// </para>
        /// <para>
        /// If the cursor mode is <c>GLFW_CURSOR_DISABLED</c> then the cursor position is
        /// unconstrained and limited only by the minimum and maximum values of
        /// a <c>double</c>.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetCursorPos(GLFWwindow* window, double xpos, double ypos);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The desired window.</param>
        /// <param name="xpos">
        /// [in] The desired x-coordinate, relative to the left edge of the
        /// content area.
        /// </param>
        /// <param name="ypos">
        /// [in] The desired y-coordinate, relative to the top edge of the
        /// content area.
        /// </param>
        /// <remarks>
        /// [wayland] This function will only work when the cursor mode is
        /// <c>GLFW_CURSOR_DISABLED</c>, otherwise it will do nothing.
        /// </remarks>
        /// <seealso cref="GetCursorPos"/>
        public static void SetCursorPos(IntPtr window, double xpos, double ypos) {
            GLFWNative.glfwSetCursorPos(window, xpos, ypos);
        }
        /// <summary>
        /// Creates a custom cursor.
        /// <para>
        /// Creates a new custom cursor image that can be set for a window with <see cref="SetCursor"/>.  The cursor can be destroyed with <see cref="DestroyCursor"/>.
        /// Any remaining cursors are destroyed by <see cref="Terminate"/>.
        /// </para>
        /// <para>
        /// The pixels are 32-bit, little-endian, non-premultiplied RGBA, i.e. eight
        /// bits per channel with the red channel first.  They are arranged canonically
        /// as packed sequential rows, starting from the top-left corner.
        /// </para>
        /// <para>
        /// The cursor hotspot is specified in pixels, relative to the upper-left corner
        /// of the cursor image.  Like all other coordinate systems in GLFW, the X-axis
        /// points to the right and the Y-axis points down.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The specified image data is copied before this function
        /// returns.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWcursor* glfwCreateCursor(const GLFWimage* image, int xhot, int yhot);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="image">[in] The desired cursor image.</param>
        /// <param name="xhot">[in] The desired x-coordinate, in pixels, of the cursor hotspot.</param>
        /// <param name="yhot">[in] The desired y-coordinate, in pixels, of the cursor hotspot.</param>
        /// <returns>
        /// The handle of the created cursor, or <c>NULL</c> if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        /// <seealso cref="DestroyCursor"/>
        /// <seealso cref="CreateStandardCursor"/>
        public static unsafe IntPtr CreateCursor(GLFWImage image, int xhot, int yhot) {
            if (image == GLFWImage.Empty) {
                return GLFWNative.glfwCreateCursor(null, xhot, yhot);
            }
            GLFWNative.GLFWimage img = new GLFWNative.GLFWimage();
            fixed (byte* ptr_pixels = &(image.Pixels[0])) {
                img.width = image.Width;
                img.height = image.Height;
                img.pixels = ptr_pixels;
                GLFWNative.GLFWimage* ptr = &img;
                return GLFWNative.glfwCreateCursor(ptr, xhot, yhot);
            }
        }
        /// <summary>
        /// Creates a cursor with a standard shape.
        /// <para>
        /// Returns a cursor with a [standard shape](@ref shapes), that can be set for
        /// a window with <see cref="SetCursor"/>.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="INVALID_ENUM"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWcursor* glfwCreateStandardCursor(int shape);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="shape">[in] One of the [standard shapes](@ref shapes).</param>
        /// <returns>
        /// A new cursor ready to use or <c>NULL</c> if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        /// <seealso cref="CreateCursor"/>
        public static IntPtr CreateStandardCursor(int shape) {
            return GLFWNative.glfwCreateStandardCursor(shape);
        }
        /// <summary>
        /// Destroys a cursor.
        /// <para>This function destroys a cursor previously created with <see cref="CreateCursor"/>.  Any remaining cursors will be destroyed by <see cref="Terminate"/>.</para>
        /// <para>
        /// If the specified cursor is current for any window, that window will be
        /// reverted to the default cursor.  This does not affect the cursor mode.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>reentrancy: This function must not be called from a callback.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwDestroyCursor(GLFWcursor* cursor);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="cursor">[in] The cursor object to destroy.</param>
        /// <seealso cref="CreateCursor"/>
        public static void DestroyCursor(IntPtr cursor) {
            GLFWNative.glfwDestroyCursor(cursor);
        }
        /// <summary>
        /// Sets the cursor for the window.
        /// <para>
        /// This function sets the cursor image to be used when the cursor is over the
        /// content area of the specified window.  The set cursor will only be visible
        /// when the [cursor mode](@ref cursor_mode) of the window is
        /// <c>GLFW_CURSOR_NORMAL</c>.
        /// </para>
        /// <para>
        /// On some platforms, the set cursor may not be visible unless the window also
        /// has input focus.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetCursor(GLFWwindow* window, GLFWcursor* cursor);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window to set the cursor for.</param>
        /// <param name="cursor">
        /// [in] The cursor to set, or <c>NULL</c> to switch back to the default
        /// arrow cursor.
        /// </param>
        public static void SetCursor(IntPtr window, IntPtr cursor) {
            GLFWNative.glfwSetCursor(window, cursor);
        }
        /// <summary>
        /// Sets the key callback.
        /// <para>
        /// This function sets the key callback of the specified window, which is called
        /// when a key is pressed, repeated or released.
        /// </para>
        /// <para>
        /// The key functions deal with physical keys, with layout independent
        /// [key tokens](@ref keys) named after their values in the standard US keyboard
        /// layout.  If you want to input text, use the
        /// [character callback](<see cref="SetCharCallback"/>) instead.
        /// </para>
        /// <para>
        /// When a window loses input focus, it will generate synthetic key release
        /// events for all pressed keys.  You can tell these events from user-generated
        /// events by the fact that the synthetic ones are generated after the focus
        /// loss event has been processed, i.e. after the
        /// [window focus callback](<see cref="SetWindowFocusCallback"/>) has been called.
        /// </para>
        /// <para>
        /// The scancode of a key is specific to that platform or sometimes even to that
        /// machine.  Scancodes are intended to allow users to bind keys that don't have
        /// a GLFW key token.  Such keys have <c>key</c> set to <c>GLFW_KEY_UNKNOWN</c>, their
        /// state is not saved and so it cannot be queried with <see cref="GetKey"/>.
        /// </para>
        /// <para>
        /// Sometimes GLFW needs to generate synthetic key events, in which case the
        /// scancode may be zero.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int key, int scancode, int action, int mods)
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWkeyfun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>glfw3: Added window handle parameter and return value.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWkeyfun glfwSetKeyCallback(GLFWwindow* window, GLFWkeyfun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose callback to set.</param>
        /// <param name="callback">
        /// [in] The new key callback, or <c>NULL</c> to remove the currently
        /// set callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        public static CBKey SetKeyCallback(IntPtr window, CBKey callback) {
            m_cb_key = callback;
            return GLFW.glfwSetKeyCallback(window, m_cb_key);
        }
        /// <summary>
        /// Sets the Unicode character callback.
        /// <para>
        /// This function sets the character callback of the specified window, which is
        /// called when a Unicode character is input.
        /// </para>
        /// <para>
        /// The character callback is intended for Unicode text input.  As it deals with
        /// characters, it is keyboard layout dependent, whereas the
        /// [key callback](<see cref="SetKeyCallback"/>) is not.  Characters do not map 1:1
        /// to physical keys, as a key may produce zero, one or more characters.  If you
        /// want to know whether a specific physical key was pressed or released, see
        /// the key callback instead.
        /// </para>
        /// <para>
        /// The character callback behaves as system text input normally does and will
        /// not be called if modifier keys are held down that would prevent normal text
        /// input on that platform, for example a Super (Command) key on macOS or Alt key
        /// on Windows.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWwindow* window, unsigned int codepoint)
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWcharfun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>glfw3: Added window handle parameter and return value.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWcharfun glfwSetCharCallback(GLFWwindow* window, GLFWcharfun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose callback to set.</param>
        /// <param name="callback">
        /// [in] The new callback, or <c>NULL</c> to remove the currently set
        /// callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        [Obsolete("Scheduled for removal in version 4.0.")]
        public static CBChar SetCharCallback(IntPtr window, CBChar callback) {
            m_cb_char = callback;
            return GLFW.glfwSetCharCallback(window, m_cb_char);
        }
        /// Sets the Unicode character with modifiers callback.
        /// <para>
        /// This function sets the character with modifiers callback of the specified
        /// window, which is called when a Unicode character is input regardless of what
        /// modifier keys are used.
        /// </para>
        /// <para>
        /// The character with modifiers callback is intended for implementing custom
        /// Unicode character input.  For regular Unicode text input, see the
        /// [character callback](<see cref="SetCharCallback"/>).  Like the character
        /// callback, the character with modifiers callback deals with characters and is
        /// keyboard layout dependent.  Characters do not map 1:1 to physical keys, as
        /// a key may produce zero, one or more characters.  If you want to know whether
        /// a specific physical key was pressed or released, see the
        /// [key callback](<see cref="SetKeyCallback"/>) instead.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWwindow* window, unsigned int codepoint, int mods)
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWcharmodsfun).
        /// </para>
        /// <para>deprecated: Scheduled for removal in version 4.0.</para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWcharmodsfun glfwSetCharModsCallback(GLFWwindow* window, GLFWcharmodsfun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose callback to set.</param>
        /// <param name="callback">
        /// [in] The new callback, or <c>NULL</c> to remove the currently set
        /// callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        [Obsolete("Scheduled for removal in version 4.0.")]
        public static CBCharMods SetCharModsCallback(IntPtr window, CBCharMods callback) {
            m_cb_char_mods = callback;
            return GLFW.glfwSetCharModsCallback(window, m_cb_char_mods);
        }
        /// <summary>
        /// Sets the mouse button callback.
        /// <para>
        /// This function sets the mouse button callback of the specified window, which
        /// is called when a mouse button is pressed or released.
        /// </para>
        /// <para>
        /// When a window loses input focus, it will generate synthetic mouse button
        /// release events for all pressed mouse buttons.  You can tell these events
        /// from user-generated events by the fact that the synthetic ones are generated
        /// after the focus loss event has been processed, i.e. after the
        /// [window focus callback](<see cref="SetWindowFocusCallback"/>) has been called.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int button, int action, int mods)
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWmousebuttonfun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>glfw3: Added window handle parameter and return value.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWmousebuttonfun glfwSetMouseButtonCallback(GLFWwindow* window, GLFWmousebuttonfun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose callback to set.</param>
        /// <param name="callback">
        /// [in] The new callback, or <c>NULL</c> to remove the currently set
        /// callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        public static CBMouseButton SetMouseButtonCallback(IntPtr window, CBMouseButton callback) {
            m_cb_mouse_button = callback;
            return GLFW.glfwSetMouseButtonCallback(window, m_cb_mouse_button);
        }
        /// <summary>
        /// Sets the cursor position callback.
        /// <para>
        /// This function sets the cursor position callback of the specified window,
        /// which is called when the cursor is moved.  The callback is provided with the
        /// position, in screen coordinates, relative to the upper-left corner of the
        /// content area of the window.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWwindow* window, double xpos, double ypos);
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWcursorposfun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWcursorposfun glfwSetCursorPosCallback(GLFWwindow* window, GLFWcursorposfun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose callback to set.</param>
        /// <param name="callback">
        /// [in] The new callback, or <c>NULL</c> to remove the currently set
        /// callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        public static CBCursorPos SetCursorPosCallback(IntPtr window, CBCursorPos callback) {
            m_cb_cursor_pos = callback;
            return GLFW.glfwSetCursorPosCallback(window, m_cb_cursor_pos);
        }
        /// <summary>
        /// Sets the cursor enter/leave callback.
        /// <para>
        /// This function sets the cursor boundary crossing callback of the specified
        /// window, which is called when the cursor enters or leaves the content area of
        /// the window.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int entered)
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWcursorenterfun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWcursorenterfun glfwSetCursorEnterCallback(GLFWwindow* window, GLFWcursorenterfun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose callback to set.</param>
        /// <param name="callback">
        /// [in] The new callback, or <c>NULL</c> to remove the currently set
        /// callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        public static CBCursorEnter SetCursorEnterCallback(IntPtr window, CBCursorEnter callback) {
            m_cb_cursor_enter = callback;
            return GLFW.glfwSetCursorEnterCallback(window, m_cb_cursor_enter);
        }
        /// <summary>
        /// Sets the scroll callback.
        /// <para>
        /// This function sets the scroll callback of the specified window, which is
        /// called when a scrolling device is used, such as a mouse wheel or scrolling
        /// area of a touchpad.
        /// </para>
        /// <para>
        /// The scroll callback receives all scrolling input, like that from a mouse
        /// wheel or a touchpad scrolling area.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWwindow* window, double xoffset, double yoffset)
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWscrollfun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWscrollfun glfwSetScrollCallback(GLFWwindow* window, GLFWscrollfun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose callback to set.</param>
        /// <param name="callback">
        /// [in] The new scroll callback, or <c>NULL</c> to remove the
        /// currently set callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        public static CBScroll SetScrollCallback(IntPtr window, CBScroll callback) {
            m_cb_scroll = callback;
            return GLFW.glfwSetScrollCallback(window, m_cb_scroll);
        }
        /// <summary>
        /// Sets the path drop callback.
        /// <para>
        /// This function sets the path drop callback of the specified window, which is
        /// called when one or more dragged paths are dropped on the window.
        /// </para>
        /// <para>
        /// Because the path array and its strings may have been generated specifically
        /// for that event, they are not guaranteed to be valid after the callback has
        /// returned.  If you wish to use them after the callback returns, you need to
        /// make a deep copy.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int path_count, const char* paths[])
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWdropfun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWdropfun glfwSetDropCallback(GLFWwindow* window, GLFWdropfun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose callback to set.</param>
        /// <param name="callback">
        /// [in] The new file drop callback, or <c>NULL</c> to remove the
        /// currently set callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        /// <remarks>[wayland] File drop is currently unimplemented.</remarks>
        public static unsafe CBDrop SetDropCallback(IntPtr window, CBDrop callback) {
            // TODO: test;
            CBDrop fun_old = null;
            if (callback == null) {
                GLFWNative.glfwSetDropCallback(window, null);
            } else {
                GLFWNative.glfwSetDropCallback(window, GLFW.DropFunCallBack);
            }
            lock (m_dic_callback_drop) {
                if (callback != null) {
                    if (m_dic_callback_drop.ContainsKey(window)) {
                        fun_old = m_dic_callback_drop[window];
                        m_dic_callback_drop[window] = callback;
                    } else {
                        m_dic_callback_drop.Add(window, callback);
                    }
                } else {
                    if (m_dic_callback_drop.ContainsKey(window)) {
                        fun_old = m_dic_callback_drop[window];
                        m_dic_callback_drop.Remove(window);
                    }
                }
            }
            return fun_old;
        }
        /// <summary>
        /// Returns whether the specified joystick is present.
        /// <para>This function returns whether the specified joystick is present.</para>
        /// <para>
        /// There is no need to call this function before other functions that accept
        /// a joystick ID, as they all check for presence before performing any other
        /// work.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="INVALID_ENUM"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI int glfwJoystickPresent(int jid);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="jid">[in] The [joystick](@ref joysticks) to query.</param>
        /// <returns><c>GLFW_TRUE</c> if the joystick is present, or <c>GLFW_FALSE</c> otherwise.</returns>
        public static int JoystickPresent(int jid) {
            return GLFWNative.glfwJoystickPresent(jid);
        }
        /// <summary>
        /// Returns the values of all axes of the specified joystick.
        /// <para>
        /// This function returns the values of all axes of the specified joystick.
        /// Each element in the array is a value between -1.0 and 1.0.
        /// </para>
        /// <para>
        /// If the specified joystick is not present this function will return <c>NULL</c>
        /// but will not generate an error.  This can be used instead of first calling
        /// <see cref="JoystickPresent"/>.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="INVALID_ENUM"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The returned array is allocated and freed by GLFW.  You
        /// should not free it yourself.  It is valid until the specified joystick is
        /// disconnected or the library is terminated.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI const float* glfwGetJoystickAxes(int jid, int* count);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="jid">[in] The [joystick](@ref joysticks) to query.</param>
        /// <returns>
        /// An array of axis values, or <c>NULL</c> if the joystick is not present or
        /// an [error](@ref error_handling) occurred.
        /// </returns>
        public static unsafe float[] GetJoystickAxes(int jid) {
            int nCount = 0;
            float* ptr = GLFWNative.glfwGetJoystickAxes(jid, &nCount);
            if (ptr == null) {
                return null;
            }
            float[] ret = new float[nCount];
            for (int i = 0; i < nCount; i++) {
                ret[i] = *(ptr + i);
            }
            return ret;
        }
        /// <summary>
        /// Returns the state of all buttons of the specified joystick.
        /// <para>
        /// This function returns the state of all buttons of the specified joystick.
        /// Each element in the array is either <c>GLFW_PRESS</c> or <c>GLFW_RELEASE</c>.
        /// </para>
        /// <para>
        /// For backward compatibility with earlier versions that did not have <see cref="GetJoystickHats"/>, the button array also includes all hats, each
        /// represented as four buttons.  The hats are in the same order as returned by
        /// __glfwGetJoystickHats__ and are in the order _up_, _right_, _down_ and
        /// _left_.  To disable these extra buttons, set the <see cref="JOYSTICK_HAT_BUTTONS"/> init hint before initialization.
        /// </para>
        /// <para>
        /// If the specified joystick is not present this function will return <c>NULL</c>
        /// but will not generate an error.  This can be used instead of first calling
        /// <see cref="JoystickPresent"/>.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="INVALID_ENUM"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The returned array is allocated and freed by GLFW.  You
        /// should not free it yourself.  It is valid until the specified joystick is
        /// disconnected or the library is terminated.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>glfw3: Changed to return a dynamic array.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI const unsigned char* glfwGetJoystickButtons(int jid, int* count);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="jid">[in] The [joystick](@ref joysticks) to query.</param>
        /// <param name="count">
        /// [out] Where to store the number of button states in the returned
        /// array.  This is set to zero if the joystick is not present or an error
        /// occurred.
        /// </param>
        /// <returns>
        /// An array of button states, or <c>NULL</c> if the joystick is not present
        /// or an [error](@ref error_handling) occurred.
        /// </returns>
        public static unsafe byte[] GetJoystickButtons(int jid) {
            int nCount = 0;
            byte* ptr = GLFWNative.glfwGetJoystickButtons(jid, &nCount);
            if (ptr == null) {
                return null;
            }
            byte[] ret = new byte[nCount];
            for (int i = 0; i < nCount; i++) {
                ret[i] = *(ptr + i);
            }
            return ret;
        }
        /// <summary>
        /// Returns the state of all hats of the specified joystick.
        /// <para>
        /// This function returns the state of all hats of the specified joystick.
        /// Each element in the array is one of the following values:
        /// </para>
        /// <para>
        /// Name                  | Value
        /// ----                  | -----
        /// <c>GLFW_HAT_CENTERED</c>   | 0
        /// <c>GLFW_HAT_UP</c>         | 1
        /// <c>GLFW_HAT_RIGHT</c>      | 2
        /// <c>GLFW_HAT_DOWN</c>       | 4
        /// <c>GLFW_HAT_LEFT</c>       | 8
        /// <c>GLFW_HAT_RIGHT_UP</c>   | <c>GLFW_HAT_RIGHT</c> \| <c>GLFW_HAT_UP</c>
        /// <c>GLFW_HAT_RIGHT_DOWN</c> | <c>GLFW_HAT_RIGHT</c> \| <c>GLFW_HAT_DOWN</c>
        /// <c>GLFW_HAT_LEFT_UP</c>    | <c>GLFW_HAT_LEFT</c> \| <c>GLFW_HAT_UP</c>
        /// <c>GLFW_HAT_LEFT_DOWN</c>  | <c>GLFW_HAT_LEFT</c> \| <c>GLFW_HAT_DOWN</c>
        /// </para>
        /// <para>
        /// The diagonal directions are bitwise combinations of the primary (up, right,
        /// down and left) directions and you can test for these individually by ANDing
        /// it with the corresponding direction.
        /// </para>
        /// <para>
        /// <code>
        /// if (hats[2] & GLFW_HAT_RIGHT)
        /// {
        /// State of hat 2 could be right-up, right or right-down
        /// }
        /// </code>
        /// </para>
        /// <para>
        /// If the specified joystick is not present this function will return <c>NULL</c>
        /// but will not generate an error.  This can be used instead of first calling
        /// <see cref="JoystickPresent"/>.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="INVALID_ENUM"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The returned array is allocated and freed by GLFW.  You
        /// should not free it yourself.  It is valid until the specified joystick is
        /// disconnected, this function is called again for that joystick or the library
        /// is terminated.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI const unsigned char* glfwGetJoystickHats(int jid, int* count);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="jid">[in] The [joystick](@ref joysticks) to query.</param>
        /// <returns>
        /// An array of hat states, or <c>NULL</c> if the joystick is not present
        /// or an [error](@ref error_handling) occurred.
        /// </returns>
        public static unsafe byte[] GetJoystickHats(int jid) {
            int nCount = 0;
            byte* ptr = GLFWNative.glfwGetJoystickHats(jid, &nCount);
            if (ptr == null) {
                return null;
            }
            byte[] ret = new byte[nCount];
            for (int i = 0; i < nCount; i++) {
                ret[i] = *(ptr + i);
            }
            return ret;
        }
        /// <summary>
        /// Returns the name of the specified joystick.
        /// <para>
        /// This function returns the name, encoded as UTF-8, of the specified joystick.
        /// The returned string is allocated and freed by GLFW.  You should not free it
        /// yourself.
        /// </para>
        /// <para>
        /// If the specified joystick is not present this function will return <c>NULL</c>
        /// but will not generate an error.  This can be used instead of first calling
        /// <see cref="JoystickPresent"/>.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="INVALID_ENUM"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The returned string is allocated and freed by GLFW.  You
        /// should not free it yourself.  It is valid until the specified joystick is
        /// disconnected or the library is terminated.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI const char* glfwGetJoystickName(int jid);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="jid">[in] The [joystick](@ref joysticks) to query.</param>
        /// <returns>
        /// The UTF-8 encoded name of the joystick, or <c>NULL</c> if the joystick
        /// is not present or an [error](@ref error_handling) occurred.
        /// </returns>
        public static unsafe string GetJoystickName(int jid) {
            byte* ptr = GLFWNative.glfwGetJoystickName(jid);
            if (ptr == null) return null;
            return MarshalExtend.PtrToString(ptr);
        }
        /// <summary>
        /// Returns the SDL compatible GUID of the specified joystick.
        /// <para>
        /// This function returns the SDL compatible GUID, as a UTF-8 encoded
        /// hexadecimal string, of the specified joystick.  The returned string is
        /// allocated and freed by GLFW.  You should not free it yourself.
        /// </para>
        /// <para>
        /// The GUID is what connects a joystick to a gamepad mapping.  A connected
        /// joystick will always have a GUID even if there is no gamepad mapping
        /// assigned to it.
        /// </para>
        /// <para>
        /// If the specified joystick is not present this function will return <c>NULL</c>
        /// but will not generate an error.  This can be used instead of first calling
        /// <see cref="JoystickPresent"/>.
        /// </para>
        /// <para>
        /// The GUID uses the format introduced in SDL 2.0.5.  This GUID tries to
        /// uniquely identify the make and model of a joystick but does not identify
        /// a specific unit, e.g. all wired Xbox 360 controllers will have the same
        /// GUID on that platform.  The GUID for a unit may vary between platforms
        /// depending on what hardware information the platform specific APIs provide.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="INVALID_ENUM"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The returned string is allocated and freed by GLFW.  You
        /// should not free it yourself.  It is valid until the specified joystick is
        /// disconnected or the library is terminated.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI const char* glfwGetJoystickGUID(int jid);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="jid">[in] The [joystick](@ref joysticks) to query.</param>
        /// <returns>
        /// The UTF-8 encoded GUID of the joystick, or <c>NULL</c> if the joystick
        /// is not present or an [error](@ref error_handling) occurred.
        /// </returns>
        public static unsafe string GetJoystickGUID(int jid) {
            byte* ptr = GLFWNative.glfwGetJoystickGUID(jid);
            if (ptr == null) return null;
            return MarshalExtend.PtrToString(ptr);
        }
        /// <summary>
        /// Returns whether the specified joystick has a gamepad mapping.
        /// <para>
        /// This function returns whether the specified joystick is both present and has
        /// a gamepad mapping.
        /// </para>
        /// <para>
        /// If the specified joystick is present but does not have a gamepad mapping
        /// this function will return <c>GLFW_FALSE</c> but will not generate an error.  Call
        /// <see cref="JoystickPresent"/> to check if a joystick is present regardless of
        /// whether it has a mapping.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="INVALID_ENUM"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI int glfwJoystickIsGamepad(int jid);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="jid">[in] The [joystick](@ref joysticks) to query.</param>
        /// <returns>
        /// <c>GLFW_TRUE</c> if a joystick is both present and has a gamepad mapping,
        /// or <c>GLFW_FALSE</c> otherwise.
        /// </returns>
        /// <seealso cref="GetGamepadState"/>
        public static int JoystickIsGamepad(int jid) {
            return GLFWNative.glfwJoystickIsGamepad(jid);
        }
        /// <summary>
        /// Sets the joystick configuration callback.
        /// <para>
        /// This function sets the joystick configuration callback, or removes the
        /// currently set callback.  This is called when a joystick is connected to or
        /// disconnected from the system.
        /// </para>
        /// <para>
        /// For joystick connection and disconnection events to be delivered on all
        /// platforms, you need to call one of the [event processing](@ref events)
        /// functions.  Joystick disconnection may also be detected and the callback
        /// called by joystick functions.  The function will then return whatever it
        /// returns if the joystick is not present.
        /// </para>
        /// <para>
        /// callback_signature:
        /// <code>
        /// void function_name(int jid, int event)
        /// </code>
        /// For more information about the callback parameters, see the
        /// [function pointer type](@ref GLFWjoystickfun).
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWjoystickfun glfwSetJoystickCallback(GLFWjoystickfun callback);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="callback">
        /// [in] The new callback, or <c>NULL</c> to remove the currently set
        /// callback.
        /// </param>
        /// <returns>
        /// The previously set callback, or <c>NULL</c> if no callback was set or the
        /// library had not been [initialized](@ref intro_init).
        /// </returns>
        public static CBJoystick SetJoystickCallback(CBJoystick callback) {
            m_cb_joystick = callback;
            return GLFW.glfwSetJoystickCallback(m_cb_joystick);
        }
        /// <summary>
        /// Adds the specified SDL_GameControllerDB gamepad mappings.
        /// <para>
        /// This function parses the specified ASCII encoded string and updates the
        /// internal list with any gamepad mappings it finds.  This string may
        /// contain either a single gamepad mapping or many mappings separated by
        /// newlines.  The parser supports the full format of the <c>gamecontrollerdb.txt</c>
        /// source file including empty lines and comments.
        /// </para>
        /// <para>See @ref gamepad_mapping for a description of the format.</para>
        /// <para>
        /// If there is already a gamepad mapping for a given GUID in the internal list,
        /// it will be replaced by the one passed to this function.  If the library is
        /// terminated and re-initialized the internal list will revert to the built-in
        /// default.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="INVALID_VALUE"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI int glfwUpdateGamepadMappings(const char* string);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="str">[in] The string containing the gamepad mappings.</param>
        /// <returns>
        /// <c>GLFW_TRUE</c> if successful, or <c>GLFW_FALSE</c> if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        /// <seealso cref="JoystickIsGamepad"/>
        /// <seealso cref="GetGamepadName"/>
        public static unsafe int UpdateGamepadMappings(string str) {
            byte[] byStr = Encoding.ASCII.GetBytes(str);
            fixed (byte* ptr = &(byStr[0])) {
                return GLFWNative.glfwUpdateGamepadMappings(ptr);
            }
        }
        /// <summary>
        /// Returns the human-readable gamepad name for the specified joystick.
        /// <para>
        /// This function returns the human-readable name of the gamepad from the
        /// gamepad mapping assigned to the specified joystick.
        /// </para>
        /// <para>
        /// If the specified joystick is not present or does not have a gamepad mapping
        /// this function will return <c>NULL</c> but will not generate an error.  Call
        /// <see cref="JoystickPresent"/> to check whether it is present regardless of
        /// whether it has a mapping.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="INVALID_ENUM"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The returned string is allocated and freed by GLFW.  You
        /// should not free it yourself.  It is valid until the specified joystick is
        /// disconnected, the gamepad mappings are updated or the library is terminated.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI const char* glfwGetGamepadName(int jid);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="jid">[in] The [joystick](@ref joysticks) to query.</param>
        /// <returns>
        /// The UTF-8 encoded name of the gamepad, or <c>NULL</c> if the
        /// joystick is not present, does not have a mapping or an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        /// <seealso cref="JoystickIsGamepad"/>
        public static unsafe string GetGamepadName(int jid) {
            byte* ptr = GLFWNative.glfwGetGamepadName(jid);
            if (ptr == null) return null;
            return MarshalExtend.PtrToString(ptr);
        }
        /// <summary>
        /// Retrieves the state of the specified joystick remapped as a gamepad.
        /// <para>
        /// This function retrieves the state of the specified joystick remapped to
        /// an Xbox-like gamepad.
        /// </para>
        /// <para>
        /// If the specified joystick is not present or does not have a gamepad mapping
        /// this function will return <c>GLFW_FALSE</c> but will not generate an error.  Call
        /// <see cref="JoystickPresent"/> to check whether it is present regardless of
        /// whether it has a mapping.
        /// </para>
        /// <para>
        /// The Guide button may not be available for input as it is often hooked by the
        /// system or the Steam client.
        /// </para>
        /// <para>
        /// Not all devices have all the buttons or axes provided by @ref
        /// GLFWgamepadstate.  Unavailable buttons and axes will always report
        /// <c>GLFW_RELEASE</c> and 0.0 respectively.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="INVALID_ENUM"/>.</para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI int glfwGetGamepadState(int jid, GLFWgamepadstate* state);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="jid">[in] The [joystick](@ref joysticks) to query.</param>
        /// <param name="state">[out] The gamepad input state of the joystick.</param>
        /// <returns>
        /// <c>GLFW_TRUE</c> if successful, or <c>GLFW_FALSE</c> if no joystick is
        /// connected, it has no gamepad mapping or an [error](@ref error_handling)
        /// occurred.
        /// </returns>
        /// <seealso cref="UpdateGamepadMappings"/>
        /// <seealso cref="JoystickIsGamepad"/>
        public static int GetGamepadState(int jid, GamePadState state) {
            int nLen = Marshal.SizeOf(state);
            IntPtr ptr = Marshal.AllocHGlobal(nLen);
            Marshal.StructureToPtr(state, ptr, true);
            int ret = GLFWNative.glfwGetGamepadState(jid, ptr);
            Marshal.FreeHGlobal(ptr);
            return ret;
        }
        /// <summary>
        /// Sets the clipboard to the specified string.
        /// <para>
        /// This function sets the system clipboard to the specified, UTF-8 encoded
        /// string.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The specified string is copied before this function
        /// returns.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetClipboardString(GLFWwindow* window, const char* string);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] Deprecated.  Any valid window or <c>NULL</c>.</param>
        /// <param name="str">[in] A UTF-8 encoded string.</param>
        /// <seealso cref="GetClipboardString"/>
        public static unsafe void SetClipboardString(IntPtr window, string str) {
            byte[] byStr = Encoding.UTF8.GetBytes(str);
            fixed (byte* ptr = &(byStr[0])) {
                GLFWNative.glfwSetClipboardString(window, ptr);
            }
        }
        /// <summary>
        /// Returns the contents of the clipboard as a string.
        /// <para>
        /// This function returns the contents of the system clipboard, if it contains
        /// or is convertible to a UTF-8 encoded string.  If the clipboard is empty or
        /// if its contents cannot be converted, <c>NULL</c> is returned and a <see cref="FORMAT_UNAVAILABLE"/> error is generated.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="FORMAT_UNAVAILABLE"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The returned string is allocated and freed by GLFW.  You
        /// should not free it yourself.  It is valid until the next call to <see cref="GetClipboardString"/> or <see cref="SetClipboardString"/>, or until the library
        /// is terminated.
        /// </para>
        /// <para>thread_safety: This function must only be called from the main thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI const char* glfwGetClipboardString(GLFWwindow* window);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] Deprecated.  Any valid window or <c>NULL</c>.</param>
        /// <returns>
        /// The contents of the clipboard as a UTF-8 encoded string, or <c>NULL</c>
        /// if an [error](@ref error_handling) occurred.
        /// </returns>
        /// <seealso cref="SetClipboardString"/>
        public static unsafe string GetClipboardString(IntPtr window) {
            byte* ptr = GLFWNative.glfwGetClipboardString(window);
            if (ptr == null) return null;
            return MarshalExtend.PtrToString(ptr);
        }
        /// <summary>
        /// Returns the GLFW time.
        /// <para>
        /// This function returns the current GLFW time, in seconds.  Unless the time
        /// has been set using <see cref="SetTime"/> it measures time elapsed since GLFW was
        /// initialized.
        /// </para>
        /// <para>This function and <see cref="SetTime"/> are helper functions on top of <see cref="GetTimerFrequency"/> and <see cref="GetTimerValue"/>.</para>
        /// <para>
        /// The resolution of the timer is system dependent, but is usually on the order
        /// of a few micro- or nanoseconds.  It uses the highest-resolution monotonic
        /// time source on each supported platform.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>
        /// thread_safety:
        /// This function may be called from any thread.  Reading and
        /// writing of the internal base time is not atomic, so it needs to be
        /// externally synchronized with calls to <see cref="SetTime"/>.
        /// </para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI double glfwGetTime(void);
        /// </code>
        /// </para>
        /// </summary>
        /// <returns>
        /// The current time, in seconds, or zero if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        public static double GetTime() {
            return GLFWNative.glfwGetTime();
        }
        /// <summary>
        /// Sets the GLFW time.
        /// <para>
        /// This function sets the current GLFW time, in seconds.  The value must be
        /// a positive finite number less than or equal to 18446744073.0, which is
        /// approximately 584.5 years.
        /// </para>
        /// <para>This function and <see cref="GetTime"/> are helper functions on top of <see cref="GetTimerFrequency"/> and <see cref="GetTimerValue"/>.</para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="INVALID_VALUE"/>.</para>
        /// <para>
        /// thread_safety:
        /// This function may be called from any thread.  Reading and
        /// writing of the internal base time is not atomic, so it needs to be
        /// externally synchronized with calls to <see cref="GetTime"/>.
        /// </para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSetTime(double time);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="time">[in] The new value, in seconds.</param>
        /// <remarks>
        /// The upper limit of GLFW time is calculated as
        /// floor((2<sup>64</sup> - 1) / 10<sup>9</sup>) and is due to implementations
        /// storing nanoseconds in 64 bits.  The limit may be increased in the future.
        /// </remarks>
        public static void SetTime(double time) {
            GLFWNative.glfwSetTime(time);
        }
        /// <summary>
        /// Returns the current value of the raw timer.
        /// <para>
        /// This function returns the current value of the raw timer, measured in
        /// 1&nbsp;/&nbsp;frequency seconds.  To get the frequency, call <see cref="GetTimerFrequency"/>.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function may be called from any thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI uint64_t glfwGetTimerValue(void);
        /// </code>
        /// </para>
        /// </summary>
        /// <returns>
        /// The value of the timer, or zero if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        /// <seealso cref="GetTimerFrequency"/>
        public static UInt64 GetTimerValue() {
            return GLFWNative.glfwGetTimerValue();
        }
        /// <summary>
        /// Returns the frequency, in Hz, of the raw timer.
        /// <para>This function returns the frequency, in Hz, of the raw timer.</para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function may be called from any thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI uint64_t glfwGetTimerFrequency(void);
        /// </code>
        /// </para>
        /// </summary>
        /// <returns>
        /// The frequency of the timer, in Hz, or zero if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        /// <seealso cref="GetTimerValue"/>
        public static UInt64 GetTimerFrequency() {
            return GLFWNative.glfwGetTimerFrequency();
        }
        /// <summary>
        /// Makes the context of the specified window current for the calling
        /// thread.
        /// <para>
        /// This function makes the OpenGL or OpenGL ES context of the specified window
        /// current on the calling thread.  A context must only be made current on
        /// a single thread at a time and each thread can have only a single current
        /// context at a time.
        /// </para>
        /// <para>
        /// When moving a context between threads, you must make it non-current on the
        /// old thread before making it current on the new one.
        /// </para>
        /// <para>
        /// By default, making a context non-current implicitly forces a pipeline flush.
        /// On machines that support <c>GL_KHR_context_flush_control</c>, you can control
        /// whether a context performs this flush by setting the
        /// [GLFW_CONTEXT_RELEASE_BEHAVIOR](<see cref="CONTEXT_RELEASE_BEHAVIOR_hint"/>)
        /// hint.
        /// </para>
        /// <para>
        /// The specified window must have an OpenGL or OpenGL ES context.  Specifying
        /// a window without a context will generate a <see cref="NO_WINDOW_CONTEXT"/>
        /// error.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="NO_WINDOW_CONTEXT"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function may be called from any thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwMakeContextCurrent(GLFWwindow* window);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">
        /// [in] The window whose context to make current, or <c>NULL</c> to
        /// detach the current context.
        /// </param>
        /// <seealso cref="GetCurrentContext"/>
        public static void MakeContextCurrent(IntPtr window) {
            GLFWNative.glfwMakeContextCurrent(window);
        }
        /// <summary>
        /// Returns the window whose context is current on the calling thread.
        /// <para>
        /// This function returns the window whose OpenGL or OpenGL ES context is
        /// current on the calling thread.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function may be called from any thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWwindow* glfwGetCurrentContext(void);
        /// </code>
        /// </para>
        /// </summary>
        /// <returns>
        /// The window whose context is current, or <c>NULL</c> if no window's
        /// context is current.
        /// </returns>
        /// <seealso cref="MakeContextCurrent"/>
        public static IntPtr GetCurrentContext() {
            return GLFWNative.glfwGetCurrentContext();
        }
        /// <summary>
        /// Swaps the front and back buffers of the specified window.
        /// <para>
        /// This function swaps the front and back buffers of the specified window when
        /// rendering with OpenGL or OpenGL ES.  If the swap interval is greater than
        /// zero, the GPU driver waits the specified number of screen updates before
        /// swapping the buffers.
        /// </para>
        /// <para>
        /// The specified window must have an OpenGL or OpenGL ES context.  Specifying
        /// a window without a context will generate a <see cref="NO_WINDOW_CONTEXT"/>
        /// error.
        /// </para>
        /// <para>
        /// This function does not apply to Vulkan.  If you are rendering with Vulkan,
        /// see <c>vkQueuePresentKHR</c> instead.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="NO_WINDOW_CONTEXT"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function may be called from any thread.</para>
        /// <para>glfw3: Added window handle parameter.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSwapBuffers(GLFWwindow* window);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose buffers to swap.</param>
        /// <remarks>
        /// __EGL:__ The context of the specified window must be current on the
        /// calling thread.
        /// </remarks>
        /// <seealso cref="SwapInterval"/>
        public static void SwapBuffers(IntPtr window) {
            GLFWNative.glfwSwapBuffers(window);
        }
        /// <summary>
        /// Sets the swap interval for the current context.
        /// <para>
        /// This function sets the swap interval for the current OpenGL or OpenGL ES
        /// context, i.e. the number of screen updates to wait from the time <see cref="SwapBuffers"/> was called before swapping the buffers and returning.  This
        /// is sometimes called _vertical synchronization_, _vertical retrace
        /// synchronization_ or just _vsync_.
        /// </para>
        /// <para>
        /// A context that supports either of the <c>WGL_EXT_swap_control_tear</c> and
        /// <c>GLX_EXT_swap_control_tear</c> extensions also accepts _negative_ swap
        /// intervals, which allows the driver to swap immediately even if a frame
        /// arrives a little bit late.  You can check for these extensions with <see cref="ExtensionSupported"/>.
        /// </para>
        /// <para>
        /// A context must be current on the calling thread.  Calling this function
        /// without a current context will cause a <see cref="NO_CURRENT_CONTEXT"/> error.
        /// </para>
        /// <para>
        /// This function does not apply to Vulkan.  If you are rendering with Vulkan,
        /// see the present mode of your swapchain instead.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="NO_CURRENT_CONTEXT"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function may be called from any thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI void glfwSwapInterval(int interval);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="interval">
        /// [in] The minimum number of screen updates to wait for
        /// until the buffers are swapped by <see cref="SwapBuffers"/>.
        /// </param>
        /// <remarks>
        /// This function is not called during context creation, leaving the
        /// swap interval set to whatever is the default on that platform.  This is done
        /// because some swap interval extensions used by GLFW do not allow the swap
        /// interval to be reset to zero once it has been set to a non-zero value.
        /// </remarks>
        /// <remarks>
        /// Some GPU drivers do not honor the requested swap interval, either
        /// because of a user setting that overrides the application's request or due to
        /// bugs in the driver.
        /// </remarks>
        /// <seealso cref="SwapBuffers"/>
        public static void SwapInterval(int interval) {
            GLFWNative.glfwSwapInterval(interval);
        }
        /// <summary>
        /// Returns whether the specified extension is available.
        /// <para>
        /// This function returns whether the specified
        /// [API extension](@ref context_glext) is supported by the current OpenGL or
        /// OpenGL ES context.  It searches both for client API extension and context
        /// creation API extensions.
        /// </para>
        /// <para>
        /// A context must be current on the calling thread.  Calling this function
        /// without a current context will cause a <see cref="NO_CURRENT_CONTEXT"/> error.
        /// </para>
        /// <para>
        /// As this functions retrieves and searches one or more extension strings each
        /// call, it is recommended that you cache its results if it is going to be used
        /// frequently.  The extension strings will not change during the lifetime of
        /// a context, so there is no danger in doing this.
        /// </para>
        /// <para>
        /// This function does not apply to Vulkan.  If you are using Vulkan, see <see cref="GetRequiredInstanceExtensions"/>, <c>vkEnumerateInstanceExtensionProperties</c>
        /// and <c>vkEnumerateDeviceExtensionProperties</c> instead.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="NO_CURRENT_CONTEXT"/>, <see cref="INVALID_VALUE"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>thread_safety: This function may be called from any thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI int glfwExtensionSupported(const char* extension);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="extension">[in] The ASCII encoded name of the extension.</param>
        /// <returns>
        /// <c>GLFW_TRUE</c> if the extension is available, or <c>GLFW_FALSE</c>
        /// otherwise.
        /// </returns>
        /// <seealso cref="GetProcAddress"/>
        public static unsafe int ExtensionSupported(string extension) {
            byte[] byStr = Encoding.ASCII.GetBytes(extension);
            fixed (byte* ptr = &(byStr[0])) {
                return GLFWNative.glfwExtensionSupported(ptr);
            }
        }
        /// <summary>
        /// Returns the address of the specified function for the current
        /// context.
        /// <para>
        /// This function returns the address of the specified OpenGL or OpenGL ES
        /// [core or extension function](@ref context_glext), if it is supported
        /// by the current context.
        /// </para>
        /// <para>
        /// A context must be current on the calling thread.  Calling this function
        /// without a current context will cause a <see cref="NO_CURRENT_CONTEXT"/> error.
        /// </para>
        /// <para>
        /// This function does not apply to Vulkan.  If you are rendering with Vulkan,
        /// see <see cref="GetInstanceProcAddress"/>, <c>vkGetInstanceProcAddr</c> and
        /// <c>vkGetDeviceProcAddr</c> instead.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="NO_CURRENT_CONTEXT"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The returned function pointer is valid until the context
        /// is destroyed or the library is terminated.
        /// </para>
        /// <para>thread_safety: This function may be called from any thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWglproc glfwGetProcAddress(const char* procname);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="procname">[in] The ASCII encoded name of the function.</param>
        /// <returns>
        /// The address of the function, or <c>NULL</c> if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        /// <remarks>
        /// The address of a given function is not guaranteed to be the same
        /// between contexts.
        /// </remarks>
        /// <remarks>
        /// This function may return a non-<c>NULL</c> address despite the
        /// associated version or extension not being available.  Always check the
        /// context version or extension string first.
        /// </remarks>
        /// <seealso cref="ExtensionSupported"/>
        public static unsafe IntPtr GetProcAddress(string procname) {
            byte[] byStr = Encoding.ASCII.GetBytes(procname);
            fixed (byte* ptr = &(byStr[0])) {
                return GLFWNative.glfwGetProcAddress(ptr);
            }
        }
        /// <summary>
        /// Returns whether the Vulkan loader and an ICD have been found.
        /// <para>
        /// This function returns whether the Vulkan loader and any minimally functional
        /// ICD have been found.
        /// </para>
        /// <para>
        /// The availability of a Vulkan loader and even an ICD does not by itself guarantee that
        /// surface creation or even instance creation is possible.  Call <see cref="GetRequiredInstanceExtensions"/> to check whether the extensions necessary for Vulkan
        /// surface creation are available and <see cref="GetPhysicalDevicePresentationSupport"/> to
        /// check whether a queue family of a physical device supports image presentation.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>.</para>
        /// <para>thread_safety: This function may be called from any thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI int glfwVulkanSupported(void);
        /// </code>
        /// </para>
        /// </summary>
        /// <returns>
        /// <c>GLFW_TRUE</c> if Vulkan is minimally available, or <c>GLFW_FALSE</c>
        /// otherwise.
        /// </returns>
        public static int VulkanSupported() {
            return GLFWNative.glfwVulkanSupported();
        }
        /// <summary>
        /// Returns the Vulkan instance extensions required by GLFW.
        /// <para>
        /// This function returns an array of names of Vulkan instance extensions required
        /// by GLFW for creating Vulkan surfaces for GLFW windows.  If successful, the
        /// list will always contain <c>VK_KHR_surface</c>, so if you don't require any
        /// additional extensions you can pass this list directly to the
        /// <c>VkInstanceCreateInfo</c> struct.
        /// </para>
        /// <para>
        /// If Vulkan is not available on the machine, this function returns <c>NULL</c> and
        /// generates a <see cref="API_UNAVAILABLE"/> error.  Call <see cref="VulkanSupported"/>
        /// to check whether Vulkan is at least minimally available.
        /// </para>
        /// <para>
        /// If Vulkan is available but no set of extensions allowing window surface
        /// creation was found, this function returns <c>NULL</c>.  You may still use Vulkan
        /// for off-screen rendering and compute work.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="API_UNAVAILABLE"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The returned array is allocated and freed by GLFW.  You
        /// should not free it yourself.  It is guaranteed to be valid only until the
        /// library is terminated.
        /// </para>
        /// <para>thread_safety: This function may be called from any thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI const char** glfwGetRequiredInstanceExtensions(uint32_t* count);
        /// </code>
        /// </para>
        /// </summary>
        /// <returns>
        /// An array of ASCII encoded extension names, or <c>NULL</c> if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        /// <remarks>
        /// Additional extensions may be required by future versions of GLFW.
        /// You should check if any extensions you wish to enable are already in the
        /// returned array, as it is an error to specify an extension more than once in
        /// the <c>VkInstanceCreateInfo</c> struct.
        /// </remarks>
        /// <seealso cref="CreateWindowSurface"/>
        public static unsafe string[] GetRequiredInstanceExtensions() {
            UInt32 nCount = 0;
            byte** ptr = GLFWNative.glfwGetRequiredInstanceExtensions(&nCount);
            if (ptr == null) {
                return null;
            }
            string[] ret = new string[nCount];
            for (int i = 0; i < nCount; i++) {
                if (*(ptr + i) == null) {
                    ret[i] = null;
                    continue;
                }
                ret[i] = MarshalExtend.PtrToString(*(ptr + i));
            }
            return ret;
        }
        /// <summary>
        /// Returns the address of the specified Vulkan instance function.
        /// <para>
        /// This function returns the address of the specified Vulkan core or extension
        /// function for the specified instance.  If instance is set to <c>NULL</c> it can
        /// return any function exported from the Vulkan loader, including at least the
        /// following functions:
        /// </para>
        /// <para>
        /// - <c>vkEnumerateInstanceExtensionProperties</c>
        /// - <c>vkEnumerateInstanceLayerProperties</c>
        /// - <c>vkCreateInstance</c>
        /// - <c>vkGetInstanceProcAddr</c>
        /// </para>
        /// <para>
        /// If Vulkan is not available on the machine, this function returns <c>NULL</c> and
        /// generates a <see cref="API_UNAVAILABLE"/> error.  Call <see cref="VulkanSupported"/>
        /// to check whether Vulkan is at least minimally available.
        /// </para>
        /// <para>
        /// This function is equivalent to calling <c>vkGetInstanceProcAddr</c> with
        /// a platform-specific query of the Vulkan loader as a fallback.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/> and <see cref="API_UNAVAILABLE"/>.</para>
        /// <para>
        /// pointer_lifetime:
        /// The returned function pointer is valid until the library
        /// is terminated.
        /// </para>
        /// <para>thread_safety: This function may be called from any thread.</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI GLFWvkproc glfwGetInstanceProcAddress(VkInstance instance, const char* procname);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="instance">
        /// [in] The Vulkan instance to query, or <c>NULL</c> to retrieve
        /// functions related to instance creation.
        /// </param>
        /// <param name="procname">[in] The ASCII encoded name of the function.</param>
        /// <returns>
        /// The address of the function, or <c>NULL</c> if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        public static unsafe IntPtr GetInstanceProcAddress(IntPtr instance, string procname) {
            byte[] byStr = Encoding.UTF8.GetBytes(procname);
            fixed (byte* ptr_str = &(byStr[0])) {
                return GLFWNative.glfwGetInstanceProcAddress(instance, ptr_str);
            }
        }
        /// <summary>
        /// Returns whether the specified queue family can present images.
        /// <para>
        /// This function returns whether the specified queue family of the specified
        /// physical device supports presentation to the platform GLFW was built for.
        /// </para>
        /// <para>
        /// If Vulkan or the required window surface creation instance extensions are
        /// not available on the machine, or if the specified instance was not created
        /// with the required extensions, this function returns <c>GLFW_FALSE</c> and
        /// generates a <see cref="API_UNAVAILABLE"/> error.  Call <see cref="VulkanSupported"/>
        /// to check whether Vulkan is at least minimally available and <see cref="GetRequiredInstanceExtensions"/> to check what instance extensions are
        /// required.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="API_UNAVAILABLE"/> and <see cref="PLATFORM_ERROR"/>.</para>
        /// <para>
        /// thread_safety:
        /// This function may be called from any thread.  For
        /// synchronization details of Vulkan objects, see the Vulkan specification.
        /// </para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI int glfwGetPhysicalDevicePresentationSupport(VkInstance instance, VkPhysicalDevice device, uint32_t queuefamily);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="instance">[in] The instance that the physical device belongs to.</param>
        /// <param name="device">[in] The physical device that the queue family belongs to.</param>
        /// <param name="queuefamily">[in] The index of the queue family to query.</param>
        /// <returns>
        /// <c>GLFW_TRUE</c> if the queue family supports presentation, or
        /// <c>GLFW_FALSE</c> otherwise.
        /// </returns>
        /// <remarks>
        /// [macos] This function currently always returns <c>GLFW_TRUE</c>, as the
        /// <c>VK_MVK_macos_surface</c> and <c>VK_EXT_metal_surface</c> extensions do not provide
        /// a <c>vkGetPhysicalDevice*PresentationSupport</c> type function.
        /// </remarks>
        public static int GetPhysicalDevicePresentationSupport(IntPtr instance, IntPtr device, UInt32 queuefamily) {
            return GLFWNative.glfwGetPhysicalDevicePresentationSupport(instance, device, queuefamily);
        }
        /// <summary>
        /// Creates a Vulkan surface for the specified window.
        /// <para>This function creates a Vulkan surface for the specified window.</para>
        /// <para>
        /// If the Vulkan loader or at least one minimally functional ICD were not found,
        /// this function returns <c>VK_ERROR_INITIALIZATION_FAILED</c> and generates a <see cref="API_UNAVAILABLE"/> error.  Call <see cref="VulkanSupported"/> to check whether
        /// Vulkan is at least minimally available.
        /// </para>
        /// <para>
        /// If the required window surface creation instance extensions are not
        /// available or if the specified instance was not created with these extensions
        /// enabled, this function returns <c>VK_ERROR_EXTENSION_NOT_PRESENT</c> and
        /// generates a <see cref="API_UNAVAILABLE"/> error.  Call <see cref="GetRequiredInstanceExtensions"/> to check what instance extensions are
        /// required.
        /// </para>
        /// <para>
        /// The window surface cannot be shared with another API so the window must
        /// have been created with the [client api hint](<see cref="CLIENT_API_attrib"/>)
        /// set to <c>GLFW_NO_API</c> otherwise it generates a <see cref="INVALID_VALUE"/> error
        /// and returns <c>VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</c>.
        /// </para>
        /// <para>
        /// The window surface must be destroyed before the specified Vulkan instance.
        /// It is the responsibility of the caller to destroy the window surface.  GLFW
        /// does not destroy it for you.  Call <c>vkDestroySurfaceKHR</c> to destroy the
        /// surface.
        /// </para>
        /// <para>errors: Possible errors include <see cref="NOT_INITIALIZED"/>, <see cref="API_UNAVAILABLE"/>, <see cref="PLATFORM_ERROR"/> and <see cref="INVALID_VALUE"/></para>
        /// <para>
        /// thread_safety:
        /// This function may be called from any thread.  For
        /// synchronization details of Vulkan objects, see the Vulkan specification.
        /// </para>
        /// <para>
        /// original_signature:
        /// <code>
        /// GLFWAPI VkResult glfwCreateWindowSurface(VkInstance instance, GLFWwindow* window, const VkAllocationCallbacks* allocator, VkSurfaceKHR* surface);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="instance">[in] The Vulkan instance to create the surface in.</param>
        /// <param name="window">[in] The window to create the surface for.</param>
        /// <param name="allocator">
        /// [in] The allocator to use, or <c>NULL</c> to use the default
        /// allocator.
        /// </param>
        /// <param name="surface">
        /// [out] Where to store the handle of the surface.  This is set
        /// to <c>VK_NULL_HANDLE</c> if an error occurred.
        /// </param>
        /// <returns>
        /// <c>VK_SUCCESS</c> if successful, or a Vulkan error code if an
        /// [error](@ref error_handling) occurred.
        /// </returns>
        /// <remarks>
        /// If an error occurs before the creation call is made, GLFW returns
        /// the Vulkan error code most appropriate for the error.  Appropriate use of
        /// <see cref="VulkanSupported"/> and <see cref="GetRequiredInstanceExtensions"/> should
        /// eliminate almost all occurrences of these errors.
        /// </remarks>
        /// <remarks>
        /// [macos] GLFW prefers the <c>VK_EXT_metal_surface</c> extension, with the
        /// <c>VK_MVK_macos_surface</c> extension as a fallback.  The name of the selected
        /// extension, if any, is included in the array returned by <see cref="GetRequiredInstanceExtensions"/>.
        /// </remarks>
        /// <remarks>
        /// [macos] This function creates and sets a <c>CAMetalLayer</c> instance for
        /// the window content view, which is required for MoltenVK to function.
        /// </remarks>
        /// <seealso cref="GetRequiredInstanceExtensions"/>
        public static int CreateWindowSurface(IntPtr instance, IntPtr window, IntPtr allocator, IntPtr surface) {
            return GLFWNative.glfwCreateWindowSurface(instance, window, allocator, surface);
        }
    }
}
