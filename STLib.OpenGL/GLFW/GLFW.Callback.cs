using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GLFW
{
    partial class GLFW
    {
        /// <summary>
        /// The function pointer type for error callbacks.
        /// <para>
        /// This is the function pointer type for error callbacks.  An error callback
        /// function has the following signature:
        /// <code>
        /// void callback_name(int error_code, const char* description)
        /// </code>
        /// </para>
        /// <para>
        /// pointer_lifetime:
        /// The error description string is valid until the callback
        /// function returns.
        /// </para>
        /// <para>ingroup: init</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWerrorfun)(int error_code, const char* description);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="error_code">
        /// [in] An [error code](@ref errors).  Future releases may add
        /// more error codes.
        /// </param>
        /// <param name="description">[in] A UTF-8 encoded string describing the error.</param>
        /// <seealso cref="SetErrorCallback"/>
        public delegate void FunError(int error_code, string description);
        /// <summary>
        /// The function pointer type for window position callbacks.
        /// <para>
        /// This is the function pointer type for window position callbacks.  A window
        /// position callback function has the following signature:
        /// <code>
        /// void callback_name(GLFWwindow* window, int xpos, int ypos)
        /// </code>
        /// </para>
        /// <para>ingroup: window</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWwindowposfun)(GLFWwindow* window, int xpos, int ypos);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window that was moved.</param>
        /// <param name="xpos">
        /// [in] The new x-coordinate, in screen coordinates, of the
        /// upper-left corner of the content area of the window.
        /// </param>
        /// <param name="ypos">
        /// [in] The new y-coordinate, in screen coordinates, of the
        /// upper-left corner of the content area of the window.
        /// </param>
        /// <seealso cref="SetWindowPosCallback"/>
        public delegate void FunWindowPos(IntPtr window, int xpos, int ypos);
        /// <summary>
        /// The function pointer type for window size callbacks.
        /// <para>
        /// This is the function pointer type for window size callbacks.  A window size
        /// callback function has the following signature:
        /// <code>
        /// void callback_name(GLFWwindow* window, int width, int height)
        /// </code>
        /// </para>
        /// <para>glfw3: Added window handle parameter.</para>
        /// <para>ingroup: window</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWwindowsizefun)(GLFWwindow* window, int width, int height);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window that was resized.</param>
        /// <param name="width">[in] The new width, in screen coordinates, of the window.</param>
        /// <param name="height">[in] The new height, in screen coordinates, of the window.</param>
        /// <seealso cref="SetWindowSizeCallback"/>
        public delegate void FunWindowSize(IntPtr window, int width, int height);
        /// <summary>
        /// The function pointer type for window close callbacks.
        /// <para>
        /// This is the function pointer type for window close callbacks.  A window
        /// close callback function has the following signature:
        /// <code>
        /// void function_name(GLFWwindow* window)
        /// </code>
        /// </para>
        /// <para>glfw3: Added window handle parameter.</para>
        /// <para>ingroup: window</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWwindowclosefun)(GLFWwindow* window);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window that the user attempted to close.</param>
        /// <seealso cref="SetWindowCloseCallback"/>
        public delegate void FunWindowClose(IntPtr window);
        /// <summary>
        /// The function pointer type for window content refresh callbacks.
        /// <para>
        /// This is the function pointer type for window content refresh callbacks.
        /// A window content refresh callback function has the following signature:
        /// <code>
        /// void function_name(GLFWwindow* window);
        /// </code>
        /// </para>
        /// <para>glfw3: Added window handle parameter.</para>
        /// <para>ingroup: window</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWwindowrefreshfun)(GLFWwindow* window);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose content needs to be refreshed.</param>
        /// <seealso cref="SetWindowRefreshCallback"/>
        public delegate void FunWindowRefresh(IntPtr window);
        /// <summary>
        /// The function pointer type for window focus callbacks.
        /// <para>
        /// This is the function pointer type for window focus callbacks.  A window
        /// focus callback function has the following signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int focused)
        /// </code>
        /// </para>
        /// <para>ingroup: window</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWwindowfocusfun)(GLFWwindow* window, int focused);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window that gained or lost input focus.</param>
        /// <param name="focused">
        /// [in] <c>GLFW_TRUE</c> if the window was given input focus, or
        /// <c>GLFW_FALSE</c> if it lost it.
        /// </param>
        /// <seealso cref="SetWindowFocusCallback"/>
        public delegate void FunWindowFocus(IntPtr window, int focused);
        /// <summary>
        /// The function pointer type for window iconify callbacks.
        /// <para>
        /// This is the function pointer type for window iconify callbacks.  A window
        /// iconify callback function has the following signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int iconified)
        /// </code>
        /// </para>
        /// <para>ingroup: window</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWwindowiconifyfun)(GLFWwindow* window, int iconified);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window that was iconified or restored.</param>
        /// <param name="iconified">
        /// [in] <c>GLFW_TRUE</c> if the window was iconified, or
        /// <c>GLFW_FALSE</c> if it was restored.
        /// </param>
        /// <seealso cref="SetWindowIconifyCallback"/>
        public delegate void FunWindowIconify(IntPtr window, int iconified);
        /// <summary>
        /// The function pointer type for window maximize callbacks.
        /// <para>
        /// This is the function pointer type for window maximize callbacks.  A window
        /// maximize callback function has the following signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int maximized)
        /// </code>
        /// </para>
        /// <para>ingroup: window</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWwindowmaximizefun)(GLFWwindow* window, int maximized);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window that was maximized or restored.</param>
        /// <param name="maximized">
        /// [in] <c>GLFW_TRUE</c> if the window was maximized, or
        /// <c>GLFW_FALSE</c> if it was restored.
        /// </param>
        public delegate void FunWindowMaximize(IntPtr window, int maximized);
        /// <summary>
        /// The function pointer type for framebuffer size callbacks.
        /// <para>
        /// This is the function pointer type for framebuffer size callbacks.
        /// A framebuffer size callback function has the following signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int width, int height)
        /// </code>
        /// </para>
        /// <para>ingroup: window</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWframebuffersizefun)(GLFWwindow* window, int width, int height);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose framebuffer was resized.</param>
        /// <param name="width">[in] The new width, in pixels, of the framebuffer.</param>
        /// <param name="height">[in] The new height, in pixels, of the framebuffer.</param>
        /// <seealso cref="SetFramebufferSizeCallback"/>
        public delegate void FunFrameBufferSize(IntPtr window, int width, int height);
        /// <summary>
        /// The function pointer type for window content scale callbacks.
        /// <para>
        /// This is the function pointer type for window content scale callbacks.
        /// A window content scale callback function has the following signature:
        /// <code>
        /// void function_name(GLFWwindow* window, float xscale, float yscale)
        /// </code>
        /// </para>
        /// <para>ingroup: window</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWwindowcontentscalefun)(GLFWwindow* window, float xscale, float yscale);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window whose content scale changed.</param>
        /// <param name="xscale">[in] The new x-axis content scale of the window.</param>
        /// <param name="yscale">[in] The new y-axis content scale of the window.</param>
        /// <seealso cref="SetWindowContentScaleCallback"/>
        public delegate void FunWindowContentScale(IntPtr window, float xscale, float yscale);
        /// <summary>
        /// The function pointer type for mouse button callbacks.
        /// <para>
        /// This is the function pointer type for mouse button callback functions.
        /// A mouse button callback function has the following signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int button, int action, int mods)
        /// </code>
        /// </para>
        /// <para>glfw3: Added window handle and modifier mask parameters.</para>
        /// <para>ingroup: input</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWmousebuttonfun)(GLFWwindow* window, int button, int action, int mods);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window that received the event.</param>
        /// <param name="button">
        /// [in] The [mouse button](@ref buttons) that was pressed or
        /// released.
        /// </param>
        /// <param name="action">
        /// [in] One of <c>GLFW_PRESS</c> or <c>GLFW_RELEASE</c>.  Future releases
        /// may add more actions.
        /// </param>
        /// <param name="mods">
        /// [in] Bit field describing which [modifier keys](@ref mods) were
        /// held down.
        /// </param>
        /// <seealso cref="SetMouseButtonCallback"/>
        public delegate void FunMouseButton(IntPtr window, int button, int action, int mods);
        /// <summary>
        /// The function pointer type for cursor position callbacks.
        /// <para>
        /// This is the function pointer type for cursor position callbacks.  A cursor
        /// position callback function has the following signature:
        /// <code>
        /// void function_name(GLFWwindow* window, double xpos, double ypos);
        /// </code>
        /// </para>
        /// <para>ingroup: input</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWcursorposfun)(GLFWwindow* window, double xpos, double ypos);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window that received the event.</param>
        /// <param name="xpos">
        /// [in] The new cursor x-coordinate, relative to the left edge of
        /// the content area.
        /// </param>
        /// <param name="ypos">
        /// [in] The new cursor y-coordinate, relative to the top edge of the
        /// content area.
        /// </param>
        /// <seealso cref="SetCursorPosCallback"/>
        public delegate void FunCursorPos(IntPtr window, double xpos, double ypos);
        /// <summary>
        /// The function pointer type for cursor enter/leave callbacks.
        /// <para>
        /// This is the function pointer type for cursor enter/leave callbacks.
        /// A cursor enter/leave callback function has the following signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int entered)
        /// </code>
        /// </para>
        /// <para>ingroup: input</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWcursorenterfun)(GLFWwindow* window, int entered);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window that received the event.</param>
        /// <param name="entered">
        /// [in] <c>GLFW_TRUE</c> if the cursor entered the window's content
        /// area, or <c>GLFW_FALSE</c> if it left it.
        /// </param>
        /// <seealso cref="SetCursorEnterCallback"/>
        public delegate void FunCursorEnter(IntPtr window, int entered);
        /// <summary>
        /// The function pointer type for scroll callbacks.
        /// <para>
        /// This is the function pointer type for scroll callbacks.  A scroll callback
        /// function has the following signature:
        /// <code>
        /// void function_name(GLFWwindow* window, double xoffset, double yoffset)
        /// </code>
        /// </para>
        /// <para>ingroup: input</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWscrollfun)(GLFWwindow* window, double xoffset, double yoffset);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window that received the event.</param>
        /// <param name="xoffset">[in] The scroll offset along the x-axis.</param>
        /// <param name="yoffset">[in] The scroll offset along the y-axis.</param>
        /// <seealso cref="SetScrollCallback"/>
        public delegate void FunScroll(IntPtr window, double xoffset, double yoffset);
        /// <summary>
        /// The function pointer type for keyboard key callbacks.
        /// <para>
        /// This is the function pointer type for keyboard key callbacks.  A keyboard
        /// key callback function has the following signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int key, int scancode, int action, int mods)
        /// </code>
        /// </para>
        /// <para>glfw3: Added window handle, scancode and modifier mask parameters.</para>
        /// <para>ingroup: input</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWkeyfun)(GLFWwindow* window, int key, int scancode, int action, int mods);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window that received the event.</param>
        /// <param name="key">[in] The [keyboard key](@ref keys) that was pressed or released.</param>
        /// <param name="scancode">[in] The system-specific scancode of the key.</param>
        /// <param name="action">
        /// [in] <c>GLFW_PRESS</c>, <c>GLFW_RELEASE</c> or <c>GLFW_REPEAT</c>.  Future
        /// releases may add more actions.
        /// </param>
        /// <param name="mods">
        /// [in] Bit field describing which [modifier keys](@ref mods) were
        /// held down.
        /// </param>
        /// <seealso cref="SetKeyCallback"/>
        public delegate void FunKey(IntPtr window, int key, int scancode, int action, int mods);
        /// <summary>
        /// The function pointer type for Unicode character callbacks.
        /// <para>
        /// This is the function pointer type for Unicode character callbacks.
        /// A Unicode character callback function has the following signature:
        /// <code>
        /// void function_name(GLFWwindow* window, unsigned int codepoint)
        /// </code>
        /// </para>
        /// <para>glfw3: Added window handle parameter.</para>
        /// <para>ingroup: input</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWcharfun)(GLFWwindow* window, unsigned int codepoint);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window that received the event.</param>
        /// <param name="codepoint">[in] The Unicode code point of the character.</param>
        /// <seealso cref="SetCharCallback"/>
        [Obsolete("Scheduled for removal in version 4.0.")]
        public delegate void FunChar(IntPtr window, uint codepoint);
        /// <summary>
        /// The function pointer type for Unicode character with modifiers
        /// callbacks.
        /// <para>
        /// This is the function pointer type for Unicode character with modifiers
        /// callbacks.  It is called for each input character, regardless of what
        /// modifier keys are held down.  A Unicode character with modifiers callback
        /// function has the following signature:
        /// <code>
        /// void function_name(GLFWwindow* window, unsigned int codepoint, int mods)
        /// </code>
        /// </para>
        /// <para>deprecated: Scheduled for removal in version 4.0.</para>
        /// <para>ingroup: input</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWcharmodsfun)(GLFWwindow* window, unsigned int codepoint, int mods);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window that received the event.</param>
        /// <param name="codepoint">[in] The Unicode code point of the character.</param>
        /// <param name="mods">
        /// [in] Bit field describing which [modifier keys](@ref mods) were
        /// held down.
        /// </param>
        /// <seealso cref="SetCharModsCallback"/>
        public delegate void FunCharMods(IntPtr window, uint codepoint, int mods);
        /// <summary>
        /// The function pointer type for path drop callbacks.
        /// <para>
        /// This is the function pointer type for path drop callbacks.  A path drop
        /// callback function has the following signature:
        /// <code>
        /// void function_name(GLFWwindow* window, int path_count, const char* paths[])
        /// </code>
        /// </para>
        /// <para>
        /// pointer_lifetime:
        /// The path array and its strings are valid until the
        /// callback function returns.
        /// </para>
        /// <para>ingroup: input</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWdropfun)(GLFWwindow* window, int path_count, const char* paths[]);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="window">[in] The window that received the event.</param>
        /// <param name="paths">[in] The UTF-8 encoded file and/or directory path names.</param>
        /// <seealso cref="SetDropCallback"/>
        public delegate void FunDrop(IntPtr window, string[] paths);
        /// <summary>
        /// The function pointer type for monitor configuration callbacks.
        /// <para>
        /// This is the function pointer type for monitor configuration callbacks.
        /// A monitor callback function has the following signature:
        /// <code>
        /// void function_name(GLFWmonitor* monitor, int event)
        /// </code>
        /// </para>
        /// <para>ingroup: monitor</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWmonitorfun)(GLFWmonitor* monitor, int event);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="monitor">[in] The monitor that was connected or disconnected.</param>
        /// <param name="event_num">
        /// [in] One of <c>GLFW_CONNECTED</c> or <c>GLFW_DISCONNECTED</c>.  Future
        /// releases may add more events.
        /// </param>
        /// <seealso cref="SetMonitorCallback"/>
        public delegate void FunMonitor(IntPtr monitor, int event_num);
        /// <summary>
        /// The function pointer type for joystick configuration callbacks.
        /// <para>
        /// This is the function pointer type for joystick configuration callbacks.
        /// A joystick configuration callback function has the following signature:
        /// <code>
        /// void function_name(int jid, int event)
        /// </code>
        /// </para>
        /// <para>ingroup: input</para>
        /// <para>
        /// original_signature:
        /// <code>
        /// typedef void (* GLFWjoystickfun)(int jid, int event);
        /// </code>
        /// </para>
        /// </summary>
        /// <param name="jid">[in] The joystick that was connected or disconnected.</param>
        /// <param name="event_num">
        /// [in] One of <c>GLFW_CONNECTED</c> or <c>GLFW_DISCONNECTED</c>.  Future
        /// releases may add more events.
        /// </param>
        /// <seealso cref="SetJoystickCallback"/>
        public delegate void FunJoystick(int jid, int event_num);
    }
}
