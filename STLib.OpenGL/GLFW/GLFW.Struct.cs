using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;

namespace STLib.OpenGL.GLFW
{
	partial class GLFW
	{
        /// <summary>
        /// Video mode type.
        /// <para>This describes a single video mode.</para>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct VidMode
        {
            /// <summary>
            /// The width, in screen coordinates, of the video mode.
            /// </summary>
            public int Width;
            /// <summary>
            /// The height, in screen coordinates, of the video mode.
            /// </summary>
            public int Height;
            /// <summary>
            /// The bit depth of the red channel of the video mode.
            /// </summary>
            public int RedBits;
            /// <summary>
            /// The bit depth of the green channel of the video mode.
            /// </summary>
            public int GreenBits;
            /// <summary>
            /// The bit depth of the blue channel of the video mode.
            /// </summary>
            public int BlueBits;
            /// <summary>
            /// The refresh rate, in Hz, of the video mode.
            /// </summary>
            public int RefreshRate;
            /// <summary>
            /// The empty struct;
            /// </summary>
            public static readonly VidMode Empty = new VidMode();
        }

        /// <summary>
        /// Gamma ramp.
        /// <para>This describes the gamma ramp for a monitor.</para>
        /// </summary>
        public struct GammaRamp
        {
            /// <summary>
            /// An array of value describing the response of the red channel.
            /// </summary>
            public ushort[] Red;
            /// <summary>
            /// An array of value describing the response of the green channel.
            /// </summary>
            public ushort[] Green;
            /// <summary>
            /// An array of value describing the response of the blue channel.
            /// </summary>
            public ushort[] Blue;
            /// <summary>
            /// The empty struct;
            /// </summary>
            public static readonly GammaRamp Empty = new GammaRamp();
        }

        /// <summary>
        /// Image data.
        /// <para>This describes a single 2D image.  See the documentation for each related
        /// function what the expected pixel format is.</para>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct GLFWImage
        {
            /// <summary>
            /// The width, in pixels, of this image.
            /// </summary>
            public int Width;
            /// <summary>
            /// The height, in pixels, of this image.
            /// </summary>
            public int Height;
            /// <summary>
            /// The pixel data of this image, arranged left-to-right, top-to-bottom.
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray)]
            public byte[] Pixels;
            /// <summary>
            /// The empty struct;
            /// </summary>
            public static readonly GLFWImage Empty = new GLFWImage();

            public static bool operator ==(GLFWImage a, GLFWImage b) {
                if (a.Width != b.Width) return false;
                if (a.Height != b.Height) return false;
                if (a.Pixels.Length != b.Pixels.Length) return false;
                for (int i = 0; i < a.Pixels.Length; i++) {
                    if (a.Pixels[i] != b.Pixels[i]) {
                        return false;
                    }
                }
                return true;
            }

            public static bool operator !=(GLFWImage a, GLFWImage b) {
                return !(a == b);
            }
        }

        /// <summary>
        /// Gamepad input state
        /// <para>This describes the input state of a gamepad.</para>
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct GamePadState
        {
            /// <summary>
            /// The states of each [gamepad button](@ref gamepad_buttons), <c>GLFW_PRESS</c>
            /// or <c>GLFW_RELEASE</c>.
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
            public byte[] Buttons;
            /// <summary>
            /// The states of each [gamepad axis](@ref gamepad_axes), in the range -1.0
            /// to 1.0 inclusive.
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public float[] Axes;
            /// <summary>
            /// The empty struct;
            /// </summary>
            public static readonly GammaRamp Empty = new GammaRamp();
        }
	}
}
