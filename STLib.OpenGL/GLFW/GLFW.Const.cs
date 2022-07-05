using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GLFW
{
    partial class GLFW
    {
        #region GLFW version macros

        /// <summary>
        /// The major version number of the GLFW header.
        /// <para>
        /// The major version number of the GLFW header.  This is incremented when the
        /// API is changed in non-compatible ways.
        /// </para>
        /// </summary>
        public const int VERSION_MAJOR = 3;
        /// <summary>
        /// The minor version number of the GLFW header.
        /// <para>
        /// The minor version number of the GLFW header.  This is incremented when
        /// features are added to the API but it remains backward-compatible.
        /// </para>
        /// </summary>
        public const int VERSION_MINOR = 3;
        /// <summary>
        /// The revision number of the GLFW header.
        /// <para>
        /// The revision number of the GLFW header.  This is incremented when a bug fix
        /// release is made that does not contain any API changes.
        /// </para>
        /// </summary>
        public const int VERSION_REVISION = 7;

        #endregion GLFW version macros

        /// <summary>
        /// One.
        /// <para>
        /// This is only semantic sugar for the number 1.  You can instead use <c>1</c> or
        /// <c>true</c> or <c>_True</c> or <c>GL_TRUE</c> or <c>VK_TRUE</c> or anything else that is equal
        /// to one.
        /// </para>
        /// </summary>
        public const int TRUE = 1;
        /// <summary>
        /// Zero.
        /// <para>
        /// This is only semantic sugar for the number 0.  You can instead use <c>0</c> or
        /// <c>false</c> or <c>_False</c> or <c>GL_FALSE</c> or <c>VK_FALSE</c> or anything else that is
        /// equal to zero.
        /// </para>
        /// </summary>
        public const int FALSE = 0;

        #region Key and button actions

        /// <summary>
        /// The key or mouse button was released.
        /// </summary>
        public const int RELEASE = 0;
        /// <summary>
        /// The key or mouse button was pressed.
        /// </summary>
        public const int PRESS = 1;
        /// <summary>
        /// The key was held down until it repeated.
        /// </summary>
        public const int REPEAT = 2;

        #endregion Key and button actions


        #region hat_state Joystick hat states

        public const int HAT_CENTERED = 0;
        public const int HAT_UP = 1;
        public const int HAT_RIGHT = 2;
        public const int HAT_DOWN = 4;
        public const int HAT_LEFT = 8;
        public const int HAT_RIGHT_UP = (HAT_RIGHT | HAT_UP);
        public const int HAT_RIGHT_DOWN = (HAT_RIGHT | HAT_DOWN);
        public const int HAT_LEFT_UP = (HAT_LEFT | HAT_UP);
        public const int HAT_LEFT_DOWN = (HAT_LEFT | HAT_DOWN);

        #endregion hat_state Joystick hat states


        #region keys Keyboard keys

        /* The unknown key */
        public const int KEY_UNKNOWN = -1;
        /* Printable keys */
        public const int KEY_SPACE = 32;
        public const int KEY_APOSTROPHE = 39  /* ' */;
        public const int KEY_COMMA = 44  /* , */;
        public const int KEY_MINUS = 45  /* - */;
        public const int KEY_PERIOD = 46  /* . */;
        public const int KEY_SLASH = 47  /* / */;
        public const int KEY_0 = 48;
        public const int KEY_1 = 49;
        public const int KEY_2 = 50;
        public const int KEY_3 = 51;
        public const int KEY_4 = 52;
        public const int KEY_5 = 53;
        public const int KEY_6 = 54;
        public const int KEY_7 = 55;
        public const int KEY_8 = 56;
        public const int KEY_9 = 57;
        public const int KEY_SEMICOLON = 59  /* ; */;
        public const int KEY_EQUAL = 61  /* = */;
        public const int KEY_A = 65;
        public const int KEY_B = 66;
        public const int KEY_C = 67;
        public const int KEY_D = 68;
        public const int KEY_E = 69;
        public const int KEY_F = 70;
        public const int KEY_G = 71;
        public const int KEY_H = 72;
        public const int KEY_I = 73;
        public const int KEY_J = 74;
        public const int KEY_K = 75;
        public const int KEY_L = 76;
        public const int KEY_M = 77;
        public const int KEY_N = 78;
        public const int KEY_O = 79;
        public const int KEY_P = 80;
        public const int KEY_Q = 81;
        public const int KEY_R = 82;
        public const int KEY_S = 83;
        public const int KEY_T = 84;
        public const int KEY_U = 85;
        public const int KEY_V = 86;
        public const int KEY_W = 87;
        public const int KEY_X = 88;
        public const int KEY_Y = 89;
        public const int KEY_Z = 90;
        public const int KEY_LEFT_BRACKET = 91  /* [ */;
        public const int KEY_BACKSLASH = 92  /* \ */;
        public const int KEY_RIGHT_BRACKET = 93  /* ] */;
        public const int KEY_GRAVE_ACCENT = 96  /* ` */;
        public const int KEY_WORLD_1 = 161 /* non-US #1 */;
        public const int KEY_WORLD_2 = 162 /* non-US #2 */;
        /* Function keys */
        public const int KEY_ESCAPE = 256;
        public const int KEY_ENTER = 257;
        public const int KEY_TAB = 258;
        public const int KEY_BACKSPACE = 259;
        public const int KEY_INSERT = 260;
        public const int KEY_DELETE = 261;
        public const int KEY_RIGHT = 262;
        public const int KEY_LEFT = 263;
        public const int KEY_DOWN = 264;
        public const int KEY_UP = 265;
        public const int KEY_PAGE_UP = 266;
        public const int KEY_PAGE_DOWN = 267;
        public const int KEY_HOME = 268;
        public const int KEY_END = 269;
        public const int KEY_CAPS_LOCK = 280;
        public const int KEY_SCROLL_LOCK = 281;
        public const int KEY_NUM_LOCK = 282;
        public const int KEY_PRINT_SCREEN = 283;
        public const int KEY_PAUSE = 284;
        public const int KEY_F1 = 290;
        public const int KEY_F2 = 291;
        public const int KEY_F3 = 292;
        public const int KEY_F4 = 293;
        public const int KEY_F5 = 294;
        public const int KEY_F6 = 295;
        public const int KEY_F7 = 296;
        public const int KEY_F8 = 297;
        public const int KEY_F9 = 298;
        public const int KEY_F10 = 299;
        public const int KEY_F11 = 300;
        public const int KEY_F12 = 301;
        public const int KEY_F13 = 302;
        public const int KEY_F14 = 303;
        public const int KEY_F15 = 304;
        public const int KEY_F16 = 305;
        public const int KEY_F17 = 306;
        public const int KEY_F18 = 307;
        public const int KEY_F19 = 308;
        public const int KEY_F20 = 309;
        public const int KEY_F21 = 310;
        public const int KEY_F22 = 311;
        public const int KEY_F23 = 312;
        public const int KEY_F24 = 313;
        public const int KEY_F25 = 314;
        public const int KEY_KP_0 = 320;
        public const int KEY_KP_1 = 321;
        public const int KEY_KP_2 = 322;
        public const int KEY_KP_3 = 323;
        public const int KEY_KP_4 = 324;
        public const int KEY_KP_5 = 325;
        public const int KEY_KP_6 = 326;
        public const int KEY_KP_7 = 327;
        public const int KEY_KP_8 = 328;
        public const int KEY_KP_9 = 329;
        public const int KEY_KP_DECIMAL = 330;
        public const int KEY_KP_DIVIDE = 331;
        public const int KEY_KP_MULTIPLY = 332;
        public const int KEY_KP_SUBTRACT = 333;
        public const int KEY_KP_ADD = 334;
        public const int KEY_KP_ENTER = 335;
        public const int KEY_KP_EQUAL = 336;
        public const int KEY_LEFT_SHIFT = 340;
        public const int KEY_LEFT_CONTROL = 341;
        public const int KEY_LEFT_ALT = 342;
        public const int KEY_LEFT_SUPER = 343;
        public const int KEY_RIGHT_SHIFT = 344;
        public const int KEY_RIGHT_CONTROL = 345;
        public const int KEY_RIGHT_ALT = 346;
        public const int KEY_RIGHT_SUPER = 347;
        public const int KEY_MENU = 348;
        public const int KEY_LAST = KEY_MENU;

        #endregion keys Keyboard keys


        #region mods Modifier key flags

        /// <summary>
        /// If this bit is set one or more Shift keys were held down.
        /// </summary>
        public const int MOD_SHIFT = 0x0001;
        /// <summary>
        /// If this bit is set one or more Control keys were held down.
        /// </summary>
        public const int MOD_CONTROL = 0x0002;
        /// <summary>
        /// If this bit is set one or more Alt keys were held down.
        /// </summary>
        public const int MOD_ALT = 0x0004;
        /// <summary>
        /// If this bit is set one or more Super keys were held down.
        /// </summary>
        public const int MOD_SUPER = 0x0008;
        /// <summary>
        /// If this bit is set the Caps Lock key is enabled.
        /// <para>If this bit is set the Caps Lock key is enabled and the <see cref="LOCK_KEY_MODS"/> input mode is set.</para>
        /// </summary>
        public const int MOD_CAPS_LOCK = 0x0010;
        /// <summary>
        /// If this bit is set the Num Lock key is enabled.
        /// <para>If this bit is set the Num Lock key is enabled and the <see cref="LOCK_KEY_MODS"/> input mode is set.</para>
        /// </summary>
        public const int MOD_NUM_LOCK = 0x0020;

        #endregion mods Modifier key flags


        #region buttons Mouse buttons

        public const int MOUSE_BUTTON_1 = 0;
        public const int MOUSE_BUTTON_2 = 1;
        public const int MOUSE_BUTTON_3 = 2;
        public const int MOUSE_BUTTON_4 = 3;
        public const int MOUSE_BUTTON_5 = 4;
        public const int MOUSE_BUTTON_6 = 5;
        public const int MOUSE_BUTTON_7 = 6;
        public const int MOUSE_BUTTON_8 = 7;
        public const int MOUSE_BUTTON_LAST = MOUSE_BUTTON_8;
        public const int MOUSE_BUTTON_LEFT = MOUSE_BUTTON_1;
        public const int MOUSE_BUTTON_RIGHT = MOUSE_BUTTON_2;
        public const int MOUSE_BUTTON_MIDDLE = MOUSE_BUTTON_3;

        #endregion buttons Mouse buttons


        #region joysticks Joysticks

        public const int JOYSTICK_1 = 0;
        public const int JOYSTICK_2 = 1;
        public const int JOYSTICK_3 = 2;
        public const int JOYSTICK_4 = 3;
        public const int JOYSTICK_5 = 4;
        public const int JOYSTICK_6 = 5;
        public const int JOYSTICK_7 = 6;
        public const int JOYSTICK_8 = 7;
        public const int JOYSTICK_9 = 8;
        public const int JOYSTICK_10 = 9;
        public const int JOYSTICK_11 = 10;
        public const int JOYSTICK_12 = 11;
        public const int JOYSTICK_13 = 12;
        public const int JOYSTICK_14 = 13;
        public const int JOYSTICK_15 = 14;
        public const int JOYSTICK_16 = 15;
        public const int JOYSTICK_LAST = JOYSTICK_16;

        #endregion joysticks Joysticks


        #region gamepad_buttons Gamepad buttons

        public const int GAMEPAD_BUTTON_A = 0;
        public const int GAMEPAD_BUTTON_B = 1;
        public const int GAMEPAD_BUTTON_X = 2;
        public const int GAMEPAD_BUTTON_Y = 3;
        public const int GAMEPAD_BUTTON_LEFT_BUMPER = 4;
        public const int GAMEPAD_BUTTON_RIGHT_BUMPER = 5;
        public const int GAMEPAD_BUTTON_BACK = 6;
        public const int GAMEPAD_BUTTON_START = 7;
        public const int GAMEPAD_BUTTON_GUIDE = 8;
        public const int GAMEPAD_BUTTON_LEFT_THUMB = 9;
        public const int GAMEPAD_BUTTON_RIGHT_THUMB = 10;
        public const int GAMEPAD_BUTTON_DPAD_UP = 11;
        public const int GAMEPAD_BUTTON_DPAD_RIGHT = 12;
        public const int GAMEPAD_BUTTON_DPAD_DOWN = 13;
        public const int GAMEPAD_BUTTON_DPAD_LEFT = 14;
        public const int GAMEPAD_BUTTON_LAST = GAMEPAD_BUTTON_DPAD_LEFT;
        public const int GAMEPAD_BUTTON_CROSS = GAMEPAD_BUTTON_A;
        public const int GAMEPAD_BUTTON_CIRCLE = GAMEPAD_BUTTON_B;
        public const int GAMEPAD_BUTTON_SQUARE = GAMEPAD_BUTTON_X;
        public const int GAMEPAD_BUTTON_TRIANGLE = GAMEPAD_BUTTON_Y;

        #endregion gamepad_buttons Gamepad buttons


        #region gamepad_axes Gamepad axes

        public const int GAMEPAD_AXIS_LEFT_X = 0;
        public const int GAMEPAD_AXIS_LEFT_Y = 1;
        public const int GAMEPAD_AXIS_RIGHT_X = 2;
        public const int GAMEPAD_AXIS_RIGHT_Y = 3;
        public const int GAMEPAD_AXIS_LEFT_TRIGGER = 4;
        public const int GAMEPAD_AXIS_RIGHT_TRIGGER = 5;
        public const int GAMEPAD_AXIS_LAST = GAMEPAD_AXIS_RIGHT_TRIGGER;

        #endregion gamepad_axes Gamepad axes


        #region errors Error codes

        /// <summary>
        /// No error has occurred.
        /// </summary>
        public const int NO_ERROR = 0;
        /// <summary>
        /// GLFW has not been initialized.
        /// <para>
        /// This occurs if a GLFW function was called that must not be called unless the
        /// library is [initialized](@ref intro_init).
        /// </para>
        /// </summary>
        public const int NOT_INITIALIZED = 0x00010001;
        /// <summary>
        /// No context is current for this thread.
        /// <para>
        /// This occurs if a GLFW function was called that needs and operates on the
        /// current OpenGL or OpenGL ES context but no context is current on the calling
        /// thread.  One such function is <see cref="SwapInterval"/>.
        /// </para>
        /// </summary>
        public const int NO_CURRENT_CONTEXT = 0x00010002;
        /// <summary>
        /// One of the arguments to the function was an invalid enum value.
        /// <para>
        /// One of the arguments to the function was an invalid enum value, for example
        /// requesting <see cref="RED_BITS"/> with <see cref="GetWindowAttrib"/>.
        /// </para>
        /// </summary>
        public const int INVALID_ENUM = 0x00010003;
        /// <summary>
        /// One of the arguments to the function was an invalid value.
        /// <para>
        /// One of the arguments to the function was an invalid value, for example
        /// requesting a non-existent OpenGL or OpenGL ES version like 2.7.
        /// </para>
        /// <para>
        /// Requesting a valid but unavailable OpenGL or OpenGL ES version will instead
        /// result in a <see cref="VERSION_UNAVAILABLE"/> error.
        /// </para>
        /// </summary>
        public const int INVALID_VALUE = 0x00010004;
        /// <summary>
        /// A memory allocation failed.
        /// </summary>
        public const int OUT_OF_MEMORY = 0x00010005;
        /// <summary>
        /// GLFW could not find support for the requested API on the system.
        /// <para>
        /// analysis:
        /// The installed graphics driver does not support the requested
        /// API, or does not support it via the chosen context creation backend.
        /// Below are a few examples.
        /// </para>
        /// </summary>
        public const int API_UNAVAILABLE = 0x00010006;
        /// <summary>
        /// The requested OpenGL or OpenGL ES version is not available.
        /// <para>
        /// The requested OpenGL or OpenGL ES version (including any requested context
        /// or framebuffer hints) is not available on this machine.
        /// </para>
        /// <para>
        /// analysis:
        /// The machine does not support your requirements.  If your
        /// application is sufficiently flexible, downgrade your requirements and try
        /// again.  Otherwise, inform the user that their machine does not match your
        /// requirements.
        /// </para>
        /// </summary>
        public const int VERSION_UNAVAILABLE = 0x00010007;
        /// <summary>
        /// A platform-specific error occurred that does not match any of the
        /// more specific categories.
        /// <para>
        /// A platform-specific error occurred that does not match any of the more
        /// specific categories.
        /// </para>
        /// </summary>
        public const int PLATFORM_ERROR = 0x00010008;
        /// <summary>
        /// The requested format is not supported or available.
        /// <para>
        /// If emitted during window creation, the requested pixel format is not
        /// supported.
        /// </para>
        /// <para>
        /// If emitted when querying the clipboard, the contents of the clipboard could
        /// not be converted to the requested format.
        /// </para>
        /// <para>
        /// analysis:
        /// If emitted during window creation, one or more
        /// [hard constraints](@ref window_hints_hard) did not match any of the
        /// available pixel formats.  If your application is sufficiently flexible,
        /// downgrade your requirements and try again.  Otherwise, inform the user that
        /// their machine does not match your requirements.
        /// </para>
        /// </summary>
        public const int FORMAT_UNAVAILABLE = 0x00010009;
        /// <summary>
        /// The specified window does not have an OpenGL or OpenGL ES context.
        /// <para>
        /// A window that does not have an OpenGL or OpenGL ES context was passed to
        /// a function that requires it to have one.
        /// </para>
        /// </summary>
        public const int NO_WINDOW_CONTEXT = 0x0001000A;

        #endregion errors Error codes


        #region window

        /// <summary>
        /// Input focus window hint and attribute
        /// <para>
        /// Input focus [window hint](<see cref="FOCUSED_hint"/>) or
        /// [window attribute](<see cref="FOCUSED_attrib"/>).
        /// </para>
        /// </summary>
        public const int FOCUSED = 0x00020001;
        /// <summary>
        /// Window iconification window attribute
        /// <para>Window iconification [window attribute](<see cref="ICONIFIED_attrib"/>).</para>
        /// </summary>
        public const int ICONIFIED = 0x00020002;
        /// <summary>
        /// Window resize-ability window hint and attribute
        /// <para>
        /// Window resize-ability [window hint](<see cref="RESIZABLE_hint"/>) and
        /// [window attribute](<see cref="RESIZABLE_attrib"/>).
        /// </para>
        /// </summary>
        public const int RESIZABLE = 0x00020003;
        /// <summary>
        /// Window visibility window hint and attribute
        /// <para>
        /// Window visibility [window hint](<see cref="VISIBLE_hint"/>) and
        /// [window attribute](<see cref="VISIBLE_attrib"/>).
        /// </para>
        /// </summary>
        public const int VISIBLE = 0x00020004;
        /// <summary>
        /// Window decoration window hint and attribute
        /// <para>
        /// Window decoration [window hint](<see cref="DECORATED_hint"/>) and
        /// [window attribute](<see cref="DECORATED_attrib"/>).
        /// </para>
        /// </summary>
        public const int DECORATED = 0x00020005;
        /// <summary>
        /// Window auto-iconification window hint and attribute
        /// <para>
        /// Window auto-iconification [window hint](<see cref="AUTO_ICONIFY_hint"/>) and
        /// [window attribute](<see cref="AUTO_ICONIFY_attrib"/>).
        /// </para>
        /// </summary>
        public const int AUTO_ICONIFY = 0x00020006;
        /// <summary>
        /// Window decoration window hint and attribute
        /// <para>
        /// Window decoration [window hint](<see cref="FLOATING_hint"/>) and
        /// [window attribute](<see cref="FLOATING_attrib"/>).
        /// </para>
        /// </summary>
        public const int FLOATING = 0x00020007;
        /// <summary>
        /// Window maximization window hint and attribute
        /// <para>
        /// Window maximization [window hint](<see cref="MAXIMIZED_hint"/>) and
        /// [window attribute](<see cref="MAXIMIZED_attrib"/>).
        /// </para>
        /// </summary>
        public const int MAXIMIZED = 0x00020008;
        /// <summary>
        /// Cursor centering window hint
        /// <para>Cursor centering [window hint](<see cref="CENTER_CURSOR_hint"/>).</para>
        /// </summary>
        public const int CENTER_CURSOR = 0x00020009;
        /// <summary>
        /// Window framebuffer transparency hint and attribute
        /// <para>
        /// Window framebuffer transparency
        /// [window hint](<see cref="TRANSPARENT_FRAMEBUFFER_hint"/>) and
        /// [window attribute](<see cref="TRANSPARENT_FRAMEBUFFER_attrib"/>).
        /// </para>
        /// </summary>
        public const int TRANSPARENT_FRAMEBUFFER = 0x0002000A;
        /// <summary>
        /// Mouse cursor hover window attribute.
        /// <para>Mouse cursor hover [window attribute](<see cref="HOVERED_attrib"/>).</para>
        /// </summary>
        public const int HOVERED = 0x0002000B;
        /// <summary>
        /// Input focus on calling show window hint and attribute
        /// <para>
        /// Input focus [window hint](<see cref="FOCUS_ON_SHOW_hint"/>) or
        /// [window attribute](<see cref="FOCUS_ON_SHOW_attrib"/>).
        /// </para>
        /// </summary>
        public const int FOCUS_ON_SHOW = 0x0002000C;
        /// <summary>
        /// Framebuffer bit depth hint.
        /// <para>Framebuffer bit depth [hint](<see cref="RED_BITS"/>).</para>
        /// </summary>
        public const int RED_BITS = 0x00021001;
        /// <summary>
        /// Framebuffer bit depth hint.
        /// <para>Framebuffer bit depth [hint](<see cref="GREEN_BITS"/>).</para>
        /// </summary>
        public const int GREEN_BITS = 0x00021002;
        /// <summary>
        /// Framebuffer bit depth hint.
        /// <para>Framebuffer bit depth [hint](<see cref="BLUE_BITS"/>).</para>
        /// </summary>
        public const int BLUE_BITS = 0x00021003;
        /// <summary>
        /// Framebuffer bit depth hint.
        /// <para>Framebuffer bit depth [hint](<see cref="ALPHA_BITS"/>).</para>
        /// </summary>
        public const int ALPHA_BITS = 0x00021004;
        /// <summary>
        /// Framebuffer bit depth hint.
        /// <para>Framebuffer bit depth [hint](<see cref="DEPTH_BITS"/>).</para>
        /// </summary>
        public const int DEPTH_BITS = 0x00021005;
        /// <summary>
        /// Framebuffer bit depth hint.
        /// <para>Framebuffer bit depth [hint](<see cref="STENCIL_BITS"/>).</para>
        /// </summary>
        public const int STENCIL_BITS = 0x00021006;
        /// <summary>
        /// Framebuffer bit depth hint.
        /// <para>Framebuffer bit depth [hint](<see cref="ACCUM_RED_BITS"/>).</para>
        /// </summary>
        public const int ACCUM_RED_BITS = 0x00021007;
        /// <summary>
        /// Framebuffer bit depth hint.
        /// <para>Framebuffer bit depth [hint](<see cref="ACCUM_GREEN_BITS"/>).</para>
        /// </summary>
        public const int ACCUM_GREEN_BITS = 0x00021008;
        /// <summary>
        /// Framebuffer bit depth hint.
        /// <para>Framebuffer bit depth [hint](<see cref="ACCUM_BLUE_BITS"/>).</para>
        /// </summary>
        public const int ACCUM_BLUE_BITS = 0x00021009;
        /// <summary>
        /// Framebuffer bit depth hint.
        /// <para>Framebuffer bit depth [hint](<see cref="ACCUM_ALPHA_BITS"/>).</para>
        /// </summary>
        public const int ACCUM_ALPHA_BITS = 0x0002100A;
        /// <summary>
        /// Framebuffer auxiliary buffer hint.
        /// <para>Framebuffer auxiliary buffer [hint](<see cref="AUX_BUFFERS"/>).</para>
        /// </summary>
        public const int AUX_BUFFERS = 0x0002100B;
        /// <summary>
        /// OpenGL stereoscopic rendering hint.
        /// <para>OpenGL stereoscopic rendering [hint](<see cref="STEREO"/>).</para>
        /// </summary>
        public const int STEREO = 0x0002100C;
        /// <summary>
        /// Framebuffer MSAA samples hint.
        /// <para>Framebuffer MSAA samples [hint](<see cref="SAMPLES"/>).</para>
        /// </summary>
        public const int SAMPLES = 0x0002100D;
        /// <summary>
        /// Framebuffer sRGB hint.
        /// <para>Framebuffer sRGB [hint](<see cref="SRGB_CAPABLE"/>).</para>
        /// </summary>
        public const int SRGB_CAPABLE = 0x0002100E;
        /// <summary>
        /// Monitor refresh rate hint.
        /// <para>Monitor refresh rate [hint](<see cref="REFRESH_RATE"/>).</para>
        /// </summary>
        public const int REFRESH_RATE = 0x0002100F;
        /// <summary>
        /// Framebuffer double buffering hint.
        /// <para>Framebuffer double buffering [hint](<see cref="DOUBLEBUFFER"/>).</para>
        /// </summary>
        public const int DOUBLEBUFFER = 0x00021010;
        /// <summary>
        /// Context client API hint and attribute.
        /// <para>
        /// Context client API [hint](<see cref="CLIENT_API_hint"/>) and
        /// [attribute](<see cref="CLIENT_API_attrib"/>).
        /// </para>
        /// </summary>
        public const int CLIENT_API = 0x00022001;
        /// <summary>
        /// Context client API major version hint and attribute.
        /// <para>
        /// Context client API major version [hint](<see cref="CONTEXT_VERSION_MAJOR_hint"/>)
        /// and [attribute](<see cref="CONTEXT_VERSION_MAJOR_attrib"/>).
        /// </para>
        /// </summary>
        public const int CONTEXT_VERSION_MAJOR = 0x00022002;
        /// <summary>
        /// Context client API minor version hint and attribute.
        /// <para>
        /// Context client API minor version [hint](<see cref="CONTEXT_VERSION_MINOR_hint"/>)
        /// and [attribute](<see cref="CONTEXT_VERSION_MINOR_attrib"/>).
        /// </para>
        /// </summary>
        public const int CONTEXT_VERSION_MINOR = 0x00022003;
        /// <summary>
        /// Context client API revision number attribute.
        /// <para>
        /// Context client API revision number
        /// [attribute](<see cref="CONTEXT_REVISION_attrib"/>).
        /// </para>
        /// </summary>
        public const int CONTEXT_REVISION = 0x00022004;
        /// <summary>
        /// Context robustness hint and attribute.
        /// <para>
        /// Context client API revision number [hint](<see cref="CONTEXT_ROBUSTNESS_hint"/>)
        /// and [attribute](<see cref="CONTEXT_ROBUSTNESS_attrib"/>).
        /// </para>
        /// </summary>
        public const int CONTEXT_ROBUSTNESS = 0x00022005;
        /// <summary>
        /// OpenGL forward-compatibility hint and attribute.
        /// <para>
        /// OpenGL forward-compatibility [hint](<see cref="OPENGL_FORWARD_COMPAT_hint"/>)
        /// and [attribute](<see cref="OPENGL_FORWARD_COMPAT_attrib"/>).
        /// </para>
        /// </summary>
        public const int OPENGL_FORWARD_COMPAT = 0x00022006;
        /// <summary>
        /// Debug mode context hint and attribute.
        /// <para>
        /// Debug mode context [hint](<see cref="OPENGL_DEBUG_CONTEXT_hint"/>) and
        /// [attribute](<see cref="OPENGL_DEBUG_CONTEXT_attrib"/>).
        /// </para>
        /// </summary>
        public const int OPENGL_DEBUG_CONTEXT = 0x00022007;
        /// <summary>
        /// OpenGL profile hint and attribute.
        /// <para>
        /// OpenGL profile [hint](<see cref="OPENGL_PROFILE_hint"/>) and
        /// [attribute](<see cref="OPENGL_PROFILE_attrib"/>).
        /// </para>
        /// </summary>
        public const int OPENGL_PROFILE = 0x00022008;
        /// <summary>
        /// Context flush-on-release hint and attribute.
        /// <para>
        /// Context flush-on-release [hint](<see cref="CONTEXT_RELEASE_BEHAVIOR_hint"/>) and
        /// [attribute](<see cref="CONTEXT_RELEASE_BEHAVIOR_attrib"/>).
        /// </para>
        /// </summary>
        public const int CONTEXT_RELEASE_BEHAVIOR = 0x00022009;
        /// <summary>
        /// Context error suppression hint and attribute.
        /// <para>
        /// Context error suppression [hint](<see cref="CONTEXT_NO_ERROR_hint"/>) and
        /// [attribute](<see cref="CONTEXT_NO_ERROR_attrib"/>).
        /// </para>
        /// </summary>
        public const int CONTEXT_NO_ERROR = 0x0002200A;
        /// <summary>
        /// Context creation API hint and attribute.
        /// <para>
        /// Context creation API [hint](<see cref="CONTEXT_CREATION_API_hint"/>) and
        /// [attribute](<see cref="CONTEXT_CREATION_API_attrib"/>).
        /// </para>
        /// </summary>
        public const int CONTEXT_CREATION_API = 0x0002200B;
        /// <summary>
        /// Window content area scaling window
        /// [window hint](<see cref="SCALE_TO_MONITOR"/>).
        /// </summary>
        public const int SCALE_TO_MONITOR = 0x0002200C;
        /// <summary>
        /// macOS specific
        /// [window hint](<see cref="COCOA_RETINA_FRAMEBUFFER_hint"/>).
        /// </summary>
        public const int COCOA_RETINA_FRAMEBUFFER = 0x00023001;
        /// <summary>
        /// macOS specific
        /// [window hint](<see cref="COCOA_FRAME_NAME_hint"/>).
        /// </summary>
        public const int COCOA_FRAME_NAME = 0x00023002;
        /// <summary>
        /// macOS specific
        /// [window hint](<see cref="COCOA_GRAPHICS_SWITCHING_hint"/>).
        /// </summary>
        public const int COCOA_GRAPHICS_SWITCHING = 0x00023003;
        /// <summary>
        /// X11 specific
        /// [window hint](<see cref="X11_CLASS_NAME_hint"/>).
        /// </summary>
        public const int X11_CLASS_NAME = 0x00024001;
        /// <summary>
        /// X11 specific
        /// [window hint](<see cref="X11_CLASS_NAME_hint"/>).
        /// </summary>
        public const int X11_INSTANCE_NAME = 0x00024002;

        #endregion window

        public const int NO_API = 0;
        public const int OPENGL_API = 0x00030001;
        public const int OPENGL_ES_API = 0x00030002;
        public const int NO_ROBUSTNESS = 0;
        public const int NO_RESET_NOTIFICATION = 0x00031001;
        public const int LOSE_CONTEXT_ON_RESET = 0x00031002;
        public const int OPENGL_ANY_PROFILE = 0;
        public const int OPENGL_CORE_PROFILE = 0x00032001;
        public const int OPENGL_COMPAT_PROFILE = 0x00032002;
        public const int CURSOR = 0x00033001;
        public const int STICKY_KEYS = 0x00033002;
        public const int STICKY_MOUSE_BUTTONS = 0x00033003;
        public const int LOCK_KEY_MODS = 0x00033004;
        public const int RAW_MOUSE_MOTION = 0x00033005;
        public const int CURSOR_NORMAL = 0x00034001;
        public const int CURSOR_HIDDEN = 0x00034002;
        public const int CURSOR_DISABLED = 0x00034003;
        public const int ANY_RELEASE_BEHAVIOR = 0;
        public const int RELEASE_BEHAVIOR_FLUSH = 0x00035001;
        public const int RELEASE_BEHAVIOR_NONE = 0x00035002;
        public const int NATIVE_CONTEXT_API = 0x00036001;
        public const int EGL_CONTEXT_API = 0x00036002;
        public const int OSMESA_CONTEXT_API = 0x00036003;

        #region shapes Standard cursor shapes

        /// <summary>
        /// The regular arrow cursor shape.
        /// <para>The regular arrow cursor.</para>
        /// </summary>
        public const int ARROW_CURSOR = 0x00036001;
        /// <summary>
        /// The text input I-beam cursor shape.
        /// </summary>
        public const int IBEAM_CURSOR = 0x00036002;
        /// <summary>
        /// The crosshair shape.
        /// </summary>
        public const int CROSSHAIR_CURSOR = 0x00036003;
        /// <summary>
        /// The hand shape.
        /// </summary>
        public const int HAND_CURSOR = 0x00036004;
        /// <summary>
        /// The horizontal resize arrow shape.
        /// </summary>
        public const int HRESIZE_CURSOR = 0x00036005;
        /// <summary>
        /// The vertical resize arrow shape.
        /// </summary>
        public const int VRESIZE_CURSOR = 0x00036006;

        #endregion shapes Standard cursor shapes

        public const int CONNECTED = 0x00040001;
        public const int DISCONNECTED = 0x00040002;

        #region init

        /// <summary>
        /// Joystick hat buttons init hint.
        /// <para>Joystick hat buttons [init hint](<see cref="JOYSTICK_HAT_BUTTONS"/>).</para>
        /// </summary>
        public const int JOYSTICK_HAT_BUTTONS = 0x00050001;
        /// <summary>
        /// macOS specific init hint.
        /// <para>macOS specific [init hint](<see cref="COCOA_CHDIR_RESOURCES_hint"/>).</para>
        /// </summary>
        public const int COCOA_CHDIR_RESOURCES = 0x00051001;
        /// <summary>
        /// macOS specific init hint.
        /// <para>macOS specific [init hint](<see cref="COCOA_MENUBAR_hint"/>).</para>
        /// </summary>
        public const int COCOA_MENUBAR = 0x00051002;

        #endregion init

        public const int DONT_CARE = -1;
    }
}
