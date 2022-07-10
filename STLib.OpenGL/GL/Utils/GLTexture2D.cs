using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL
{
    public class GLTexture2D : IDisposable
    {
        public enum Unit : uint
        {
            Texture00 = GL.GL_TEXTURE0,
            Texture01, Texture02, Texture03, Texture04, Texture05, Texture06, Texture07, Texture08, Texture09,
            Texture10, Texture11, Texture12, Texture13, Texture14, Texture15, Texture16, Texture17, Texture18, Texture19,
            Texture20, Texture21, Texture22, Texture23, Texture24, Texture25, Texture26, Texture27, Texture28, Texture29,
            Texture30, Texture31
        }
        /*
         * GL_NEAREST_MIPMAP_NEAREST	使用最邻近的多级渐远纹理来匹配像素大小，并使用邻近插值进行纹理采样
GL_LINEAR_MIPMAP_NEAREST	使用最邻近的多级渐远纹理级别，并使用线性插值进行采样
GL_NEAREST_MIPMAP_LINEAR	在两个最匹配像素大小的多级渐远纹理之间进行线性插值，使用邻近插值进行采样
GL_LINEAR_MIPMAP_LINEAR	在两个邻近的多级渐远纹理之间使用线性插值，并使用线性插值进行采样
         */
        public enum Filter : int
        {
            Linear = (int)GL.GL_LINEAR,
            LInearMipmapLinear = (int)GL.GL_LINEAR_MIPMAP_LINEAR,
            LinearMipmapNearest = (int)GL.GL_LINEAR_MIPMAP_NEAREST,
            Nearest = (int)GL.GL_NEAREST,
            NearestMipmapLinear = (int)GL.GL_NEAREST_MIPMAP_LINEAR,
            NearestMipmapNearest = (int)GL.GL_NEAREST_MIPMAP_NEAREST
        }

        /*
         * GL_REPEAT	对纹理的默认行为。重复纹理图像。
GL_MIRRORED_REPEAT	和GL_REPEAT一样，但每次重复图片是镜像放置的。
GL_CLAMP_TO_EDGE	纹理坐标会被约束在0到1之间，超出的部分会重复纹理坐标的边缘，产生一种边缘被拉伸的效果。
GL_CLAMP_TO_BORDER	超出的坐标为用户指定的边缘颜色。
         */

        public enum Repeat : int
        {
            Repeat = (int)GL.GL_REPEAT,
            MirroredRepeat = (int)GL.GL_MIRRORED_REPEAT,
            ClampToEdge = (int)GL.GL_CLAMP_TO_EDGE,
            ClampToBorder = (int)GL.GL_CLAMP_TO_BORDER
        }

        private static GLTexture2D m_current_texture; // current context used texture

        public uint UID { get; private set; }

        private void Select() {
            if (m_current_texture == this) {
                return;
            }
            GL.BindTexture(GL.GL_TEXTURE_2D, this.UID);
            m_current_texture = this;
        }

        public void UnSelect() {
            GL.BindTexture(GL.GL_TEXTURE_2D, 0);
            m_current_texture = null;
        }

        public void BindUnit(Unit unit) {
            GL.ActiveTexture((uint)unit);
            GL.BindTexture(GL.GL_TEXTURE_2D, this.UID);
        }

        public void SetSRepeat(Repeat repeat) {
            this.Select();
            GL.TexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_WRAP_S, (int)repeat);
        }

        public void SetTRepeat(Repeat repeat) {
            this.Select();
            GL.TexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_WRAP_T, (int)repeat);
        }

        public void SetRepeat(Repeat sRepeat, Repeat tRepeat) {
            this.Select();
            GL.TexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_WRAP_S, (int)sRepeat);
            GL.TexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_WRAP_T, (int)tRepeat);
        }

        public void SetBorderColor(int r, int g, int b, int a) {
            this.SetBorderColor(r / 255F, g / 255F, b / 255F, a / 255F);
        }

        public void SetBorderColor(float r, float g, float b, float a) {
            this.Select();
            float[] borderColor = { r, g, b, a };
            GL.TexParameterfv(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_BORDER_COLOR, ref borderColor[0]);
        }

        public void SetMinFilter(Filter filter) {
            this.Select();
            GL.TextureParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_MIN_FILTER, (int)filter);
        }

        public void SetMagFilter(Filter filter) {
            this.Select();
            GL.TexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_MAG_FILTER, (int)filter);
        }

        public void SetFilter(Filter minFilter, Filter magFilter) {
            this.Select();
            GL.TexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_MIN_FILTER, (int)minFilter);
            GL.TexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_MAG_FILTER, (int)magFilter);
        }

        public void SetPixels(byte[] byPixels, int nInternalFormat, int nWidth, int nHeight, uint nFormat) {
            this.SetPixels(byPixels, 0, nInternalFormat, nWidth, nHeight, nFormat);
            GL.GenerateMipmap(GL.GL_TEXTURE_2D);
        }

        public void SetPixels(byte[] byPixels, int nLevel, int nInternalFormat, int nWidth, int nHeight, uint nFormat) {
            this.Select();
            unsafe {
                fixed (byte* ptr = &byPixels[0]) {
                    GL.TexImage2D(GL.GL_TEXTURE_2D, nLevel, nInternalFormat, nWidth, nHeight, 0, nFormat, GL.GL_UNSIGNED_BYTE, (IntPtr)ptr);
                }
            }
        }

        public void Dispose() {
            var uid = this.UID;
            GL.DeleteTextures(1, ref uid);
        }

        public static GLTexture2D Create() {
            GLTexture2D t = new GLTexture2D();
            t.UID = GL.GenTextures();
            return t;
        }
    }
}
