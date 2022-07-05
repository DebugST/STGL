using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL
{
    public partial class GL // GL.Method.Overload.cs
    {

        /**********************************************************************************
         * Note: These codes are automatically created from OpenGL's documentation.
         *       If there is something wrong, it must be because the author is too stupid.
         * Link: https://github.com/KhronosGroup/OpenGL-Registry/xml/gl.xml
         **********************************************************************************/

        #region GL_VERSION_1_0

        // [not processed] - void TexParameterfv(uint target,uint pname,float* ps)
        // [not processed] - void TexParameteriv(uint target,uint pname,int* ps)
        // [not processed] - void TexImage1D(uint target,int level,int internalFormat,int width,int border,uint format,uint type,void* data)
        // [not processed] - void TexImage2D(uint target,int level,int internalFormat,int width,int height,int border,uint format,uint type,void* data)
        // [not processed] - void ReadPixels(int x,int y,int width,int height,uint format,uint type,void* data)
        /// <summary>
        /// [Overload] - void GetBooleanv(uint pname,bool* ps)
        /// </summary>
        public unsafe static bool GetBooleanv(uint pname) {
            bool ps = false;
            GLNative.glGetBooleanv(pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetDoublev(uint pname,double* data)
        /// </summary>
        public unsafe static double GetDoublev(uint pname) {
            double data = 0;
            GLNative.glGetDoublev(pname, &data);
            return data;
        }

        /// <summary>
        /// [Overload] - void GetFloatv(uint pname,float* data)
        /// </summary>
        public unsafe static float GetFloatv(uint pname) {
            float data = 0;
            GLNative.glGetFloatv(pname, &data);
            return data;
        }

        /// <summary>
        /// [Overload] - void GetIntegerv(uint pname,int* data)
        /// </summary>
        public unsafe static int GetIntegerv(uint pname) {
            int data = 0;
            GLNative.glGetIntegerv(pname, &data);
            return data;
        }

        // [not processed] - byte* GetString(uint name)
        // [ignore] - void GetTexImage(uint target,int level,uint format,uint type,void* img)
        /// <summary>
        /// [Overload] - void GetTexParameterfv(uint target,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetTexParameterfv(uint target, uint pname) {
            float ps = 0;
            GLNative.glGetTexParameterfv(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetTexParameteriv(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetTexParameteriv(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetTexParameteriv(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetTexLevelParameterfv(uint target,int level,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetTexLevelParameterfv(uint target, int level, uint pname) {
            float ps = 0;
            GLNative.glGetTexLevelParameterfv(target, level, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetTexLevelParameteriv(uint target,int level,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetTexLevelParameteriv(uint target, int level, uint pname) {
            int ps = 0;
            GLNative.glGetTexLevelParameteriv(target, level, pname, &ps);
            return ps;
        }

        // [not processed] - void CallLists(int n,uint type,void* lists)
        // [not processed] - void Bitmap(int width,int height,float xorig,float yorig,float xmove,float ymove,byte* bitmap)
        // [not processed] - void Color3bv(byte* v)
        // [not processed] - void Color3dv(double* v)
        // [not processed] - void Color3fv(float* v)
        // [not processed] - void Color3iv(int* v)
        // [not processed] - void Color3sv(short* v)
        // [not processed] - void Color3ubv(byte* v)
        // [not processed] - void Color3uiv(uint* v)
        // [not processed] - void Color3usv(ushort* v)
        // [not processed] - void Color4bv(byte* v)
        // [not processed] - void Color4dv(double* v)
        // [not processed] - void Color4fv(float* v)
        // [not processed] - void Color4iv(int* v)
        // [not processed] - void Color4sv(short* v)
        // [not processed] - void Color4ubv(byte* v)
        // [not processed] - void Color4uiv(uint* v)
        // [not processed] - void Color4usv(ushort* v)
        // [not processed] - void EdgeFlagv(bool* flag)
        // [not processed] - void Indexdv(double* c)
        // [not processed] - void Indexfv(float* c)
        // [not processed] - void Indexiv(int* c)
        // [not processed] - void Indexsv(short* c)
        // [not processed] - void Normal3bv(byte* v)
        // [not processed] - void Normal3dv(double* v)
        // [not processed] - void Normal3fv(float* v)
        // [not processed] - void Normal3iv(int* v)
        // [not processed] - void Normal3sv(short* v)
        // [not processed] - void RasterPos2dv(double* v)
        // [not processed] - void RasterPos2fv(float* v)
        // [not processed] - void RasterPos2iv(int* v)
        // [not processed] - void RasterPos2sv(short* v)
        // [not processed] - void RasterPos3dv(double* v)
        // [not processed] - void RasterPos3fv(float* v)
        // [not processed] - void RasterPos3iv(int* v)
        // [not processed] - void RasterPos3sv(short* v)
        // [not processed] - void RasterPos4dv(double* v)
        // [not processed] - void RasterPos4fv(float* v)
        // [not processed] - void RasterPos4iv(int* v)
        // [not processed] - void RasterPos4sv(short* v)
        // [not processed] - void Rectdv(double* v1,double* v2)
        // [not processed] - void Rectfv(float* v1,float* v2)
        // [not processed] - void Rectiv(int* v1,int* v2)
        // [not processed] - void Rectsv(short* v1,short* v2)
        // [not processed] - void TexCoord1dv(double* v)
        // [not processed] - void TexCoord1fv(float* v)
        // [not processed] - void TexCoord1iv(int* v)
        // [not processed] - void TexCoord1sv(short* v)
        // [not processed] - void TexCoord2dv(double* v)
        // [not processed] - void TexCoord2fv(float* v)
        // [not processed] - void TexCoord2iv(int* v)
        // [not processed] - void TexCoord2sv(short* v)
        // [not processed] - void TexCoord3dv(double* v)
        // [not processed] - void TexCoord3fv(float* v)
        // [not processed] - void TexCoord3iv(int* v)
        // [not processed] - void TexCoord3sv(short* v)
        // [not processed] - void TexCoord4dv(double* v)
        // [not processed] - void TexCoord4fv(float* v)
        // [not processed] - void TexCoord4iv(int* v)
        // [not processed] - void TexCoord4sv(short* v)
        // [not processed] - void Vertex2dv(double* v)
        // [not processed] - void Vertex2fv(float* v)
        // [not processed] - void Vertex2iv(int* v)
        // [not processed] - void Vertex2sv(short* v)
        // [not processed] - void Vertex3dv(double* v)
        // [not processed] - void Vertex3fv(float* v)
        // [not processed] - void Vertex3iv(int* v)
        // [not processed] - void Vertex3sv(short* v)
        // [not processed] - void Vertex4dv(double* v)
        // [not processed] - void Vertex4fv(float* v)
        // [not processed] - void Vertex4iv(int* v)
        // [not processed] - void Vertex4sv(short* v)
        // [not processed] - void ClipPlane(uint plane,double* equation)
        // [not processed] - void Fogfv(uint pname,float* ps)
        // [not processed] - void Fogiv(uint pname,int* ps)
        // [not processed] - void Lightfv(uint light,uint pname,float* ps)
        // [not processed] - void Lightiv(uint light,uint pname,int* ps)
        // [not processed] - void LightModelfv(uint pname,float* ps)
        // [not processed] - void LightModeliv(uint pname,int* ps)
        // [not processed] - void Materialfv(uint face,uint pname,float* ps)
        // [not processed] - void Materialiv(uint face,uint pname,int* ps)
        // [not processed] - void PolygonStipple(byte* pattern)
        // [not processed] - void TexEnvfv(uint target,uint pname,float* ps)
        // [not processed] - void TexEnviv(uint target,uint pname,int* ps)
        // [not processed] - void TexGendv(uint coord,uint pname,double* ps)
        // [not processed] - void TexGenfv(uint coord,uint pname,float* ps)
        // [not processed] - void TexGeniv(uint coord,uint pname,int* ps)
        // [not processed] - void FeedbackBuffer(int size,uint type,float* buffer)
        // [not processed] - void SelectBuffer(int size,uint* buffer)
        // [not processed] - void Map1d(uint target,double u1,double u2,int stride,int order,double* points)
        // [not processed] - void Map1f(uint target,float u1,float u2,int stride,int order,float* points)
        // [not processed] - void Map2d(uint target,double u1,double u2,int ustride,int uorder,double v1,double v2,int vstride,int vorder,double* points)
        // [not processed] - void Map2f(uint target,float u1,float u2,int ustride,int uorder,float v1,float v2,int vstride,int vorder,float* points)
        // [not processed] - void EvalCoord1dv(double* u)
        // [not processed] - void EvalCoord1fv(float* u)
        // [not processed] - void EvalCoord2dv(double* u)
        // [not processed] - void EvalCoord2fv(float* u)
        // [not processed] - void PixelMapfv(uint map,int mapsize,float* values)
        // [not processed] - void PixelMapuiv(uint map,int mapsize,uint* values)
        // [not processed] - void PixelMapusv(uint map,int mapsize,ushort* values)
        // [not processed] - void DrawPixels(int width,int height,uint format,uint type,void* data)
        /// <summary>
        /// [Overload] - void GetClipPlane(uint plane,double* equation)
        /// </summary>
        public unsafe static double GetClipPlane(uint plane) {
            double equation = 0;
            GLNative.glGetClipPlane(plane, &equation);
            return equation;
        }

        /// <summary>
        /// [Overload] - void GetLightfv(uint light,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetLightfv(uint light, uint pname) {
            float ps = 0;
            GLNative.glGetLightfv(light, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetLightiv(uint light,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetLightiv(uint light, uint pname) {
            int ps = 0;
            GLNative.glGetLightiv(light, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetMapdv(uint target,uint query,double* v)
        /// </summary>
        public unsafe static double GetMapdv(uint target, uint query) {
            double v = 0;
            GLNative.glGetMapdv(target, query, &v);
            return v;
        }

        /// <summary>
        /// [Overload] - void GetMapfv(uint target,uint query,float* v)
        /// </summary>
        public unsafe static float GetMapfv(uint target, uint query) {
            float v = 0;
            GLNative.glGetMapfv(target, query, &v);
            return v;
        }

        /// <summary>
        /// [Overload] - void GetMapiv(uint target,uint query,int* v)
        /// </summary>
        public unsafe static int GetMapiv(uint target, uint query) {
            int v = 0;
            GLNative.glGetMapiv(target, query, &v);
            return v;
        }

        /// <summary>
        /// [Overload] - void GetMaterialfv(uint face,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetMaterialfv(uint face, uint pname) {
            float ps = 0;
            GLNative.glGetMaterialfv(face, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetMaterialiv(uint face,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetMaterialiv(uint face, uint pname) {
            int ps = 0;
            GLNative.glGetMaterialiv(face, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetPixelMapfv(uint map,float* data)
        /// </summary>
        public unsafe static float GetPixelMapfv(uint map) {
            float data = 0;
            GLNative.glGetPixelMapfv(map, &data);
            return data;
        }

        /// <summary>
        /// [Overload] - void GetPixelMapuiv(uint map,uint* data)
        /// </summary>
        public unsafe static uint GetPixelMapuiv(uint map) {
            uint data = 0;
            GLNative.glGetPixelMapuiv(map, &data);
            return data;
        }

        /// <summary>
        /// [Overload] - void GetPixelMapusv(uint map,ushort* data)
        /// </summary>
        public unsafe static ushort GetPixelMapusv(uint map) {
            ushort data = 0;
            GLNative.glGetPixelMapusv(map, &data);
            return data;
        }

        // [ignore] - void GetPolygonStipple(byte* pattern)
        /// <summary>
        /// [Overload] - void GetTexEnvfv(uint target,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetTexEnvfv(uint target, uint pname) {
            float ps = 0;
            GLNative.glGetTexEnvfv(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetTexEnviv(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetTexEnviv(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetTexEnviv(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetTexGendv(uint coord,uint pname,double* ps)
        /// </summary>
        public unsafe static double GetTexGendv(uint coord, uint pname) {
            double ps = 0;
            GLNative.glGetTexGendv(coord, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetTexGenfv(uint coord,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetTexGenfv(uint coord, uint pname) {
            float ps = 0;
            GLNative.glGetTexGenfv(coord, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetTexGeniv(uint coord,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetTexGeniv(uint coord, uint pname) {
            int ps = 0;
            GLNative.glGetTexGeniv(coord, pname, &ps);
            return ps;
        }

        // [not processed] - void LoadMatrixf(float* m)
        // [not processed] - void LoadMatrixd(double* m)
        // [not processed] - void MultMatrixf(float* m)
        // [not processed] - void MultMatrixd(double* m)

        #endregion GL_VERSION_1_0

        #region GL_VERSION_1_1

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, byte[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_BYTE, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, uint type, byte[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, int count, uint type, byte[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, count, type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, short[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, (indices == null ? 0 : indices.Length), GL.GL_SHORT, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, uint type, short[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, int count, uint type, short[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, count, type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, ushort[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_SHORT, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, uint type, ushort[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, int count, uint type, ushort[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, count, type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, int[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, (indices == null ? 0 : indices.Length), GL.GL_INT, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, uint type, int[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, int count, uint type, int[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, count, type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, uint[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_INT, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, uint type, uint[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, int count, uint type, uint[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, count, type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, float[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, (indices == null ? 0 : indices.Length), GL.GL_FLOAT, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, uint type, float[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElements(uint mode,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawElements(uint mode, int count, uint type, float[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElements(mode, count, type, pIndices);
            }
        }

        // [not processed] - void GetPointerv(uint pname,void** ps)
        // [not processed] - void TexSubImage1D(uint target,int level,int xoffset,int width,uint format,uint type,void* data)
        // [not processed] - void TexSubImage2D(uint target,int level,int xoffset,int yoffset,int width,int height,uint format,uint type,void* data)
        /// <summary>
        /// [Overload] - void DeleteTextures(int n,uint* textures)
        /// </summary>
        public unsafe static void DeleteTextures(uint[] textures) {
            fixed (uint* pTextures = &textures[0]) {
                GLNative.glDeleteTextures(textures.Length, pTextures);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteTextures(int n,uint* textures)
        /// </summary>
        public unsafe static void DeleteTextures(uint[] textures, int n) {
            fixed (uint* pTextures = &textures[0]) {
                GLNative.glDeleteTextures(n, pTextures);
            }
        }

        /// <summary>
        /// [Overload] - void GenTextures(int n,uint* textures)
        /// </summary>
        public unsafe static uint GenTextures() {
            uint textures = 0;
            GLNative.glGenTextures(1, &textures);
            return textures;
        }

        /// <summary>
        /// [Overload] - void GenTextures(int n,uint* textures)
        /// </summary>
        public unsafe static uint[] GenTextures(int n) {
            uint[] textures = new uint[n];
            fixed (uint* pTextures = &textures[0]) {
                GLNative.glGenTextures(n, pTextures);
            }
            return textures;
        }

        // [not processed] - void ColorPointer(int size,uint type,int stride,void* pointer)
        // [not processed] - void EdgeFlagPointer(int stride,void* pointer)
        // [not processed] - void IndexPointer(uint type,int stride,void* pointer)
        // [not processed] - void InterleavedArrays(uint format,int stride,void* pointer)
        // [not processed] - void NormalPointer(uint type,int stride,void* pointer)
        // [not processed] - void TexCoordPointer(int size,uint type,int stride,void* pointer)
        // [not processed] - void VertexPointer(int size,uint type,int stride,void* pointer)
        // [not processed] - bool AreTexturesResident(int n,uint* textures,bool* residences)
        // [not processed] - void PrioritizeTextures(int n,uint* textures,float* priorities)
        // [not processed] - void Indexubv(byte* c)

        #endregion GL_VERSION_1_1

        #region GL_VERSION_1_2

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, byte[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_BYTE, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, uint type, byte[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, byte[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, count, type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, short[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_SHORT, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, uint type, short[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, short[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, count, type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, ushort[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_SHORT, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, uint type, ushort[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, ushort[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, count, type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, int[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_INT, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, uint type, int[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, int[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, count, type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, uint[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_INT, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, uint type, uint[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, uint[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, count, type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, float[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_FLOAT, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, uint type, float[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElements(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, float[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElements(mode, start, end, count, type, pIndices);
            }
        }

        // [not processed] - void TexImage3D(uint target,int level,int internalFormat,int width,int height,int depth,int border,uint format,uint type,void* data)
        // [not processed] - void TexSubImage3D(uint target,int level,int xoffset,int yoffset,int zoffset,int width,int height,int depth,uint format,uint type,void* data)

        #endregion GL_VERSION_1_2

        #region GL_VERSION_1_3

        // [not processed] - void CompressedTexImage3D(uint target,int level,uint internalformat,int width,int height,int depth,int border,int imageSize,void* data)
        // [not processed] - void CompressedTexImage2D(uint target,int level,uint internalformat,int width,int height,int border,int imageSize,void* data)
        // [not processed] - void CompressedTexImage1D(uint target,int level,uint internalformat,int width,int border,int imageSize,void* data)
        // [not processed] - void CompressedTexSubImage3D(uint target,int level,int xoffset,int yoffset,int zoffset,int width,int height,int depth,uint format,int imageSize,void* data)
        // [not processed] - void CompressedTexSubImage2D(uint target,int level,int xoffset,int yoffset,int width,int height,uint format,int imageSize,void* data)
        // [not processed] - void CompressedTexSubImage1D(uint target,int level,int xoffset,int width,uint format,int imageSize,void* data)
        // [ignore] - void GetCompressedTexImage(uint target,int lod,void* img)
        // [not processed] - void MultiTexCoord1dv(uint target,double* v)
        // [not processed] - void MultiTexCoord1fv(uint target,float* v)
        // [not processed] - void MultiTexCoord1iv(uint target,int* v)
        // [not processed] - void MultiTexCoord1sv(uint target,short* v)
        // [not processed] - void MultiTexCoord2dv(uint target,double* v)
        // [not processed] - void MultiTexCoord2fv(uint target,float* v)
        // [not processed] - void MultiTexCoord2iv(uint target,int* v)
        // [not processed] - void MultiTexCoord2sv(uint target,short* v)
        // [not processed] - void MultiTexCoord3dv(uint target,double* v)
        // [not processed] - void MultiTexCoord3fv(uint target,float* v)
        // [not processed] - void MultiTexCoord3iv(uint target,int* v)
        // [not processed] - void MultiTexCoord3sv(uint target,short* v)
        // [not processed] - void MultiTexCoord4dv(uint target,double* v)
        // [not processed] - void MultiTexCoord4fv(uint target,float* v)
        // [not processed] - void MultiTexCoord4iv(uint target,int* v)
        // [not processed] - void MultiTexCoord4sv(uint target,short* v)
        // [not processed] - void LoadTransposeMatrixf(float* m)
        // [not processed] - void LoadTransposeMatrixd(double* m)
        // [not processed] - void MultTransposeMatrixf(float* m)
        // [not processed] - void MultTransposeMatrixd(double* m)

        #endregion GL_VERSION_1_3

        #region GL_VERSION_1_4

        // [not processed] - void MultiDrawArrays(uint mode,int* first,int* count,int primcount)
        // [not processed] - void MultiDrawElements(uint mode,int* count,uint type,void** indices,int primcount)
        // [not processed] - void PointParameterfv(uint pname,float* ps)
        // [not processed] - void PointParameteriv(uint pname,int* ps)
        // [not processed] - void FogCoordfv(float* coord)
        // [not processed] - void FogCoorddv(double* coord)
        // [not processed] - void FogCoordPointer(uint type,int stride,void* pointer)
        // [not processed] - void SecondaryColor3bv(byte* v)
        // [not processed] - void SecondaryColor3dv(double* v)
        // [not processed] - void SecondaryColor3fv(float* v)
        // [not processed] - void SecondaryColor3iv(int* v)
        // [not processed] - void SecondaryColor3sv(short* v)
        // [not processed] - void SecondaryColor3ubv(byte* v)
        // [not processed] - void SecondaryColor3uiv(uint* v)
        // [not processed] - void SecondaryColor3usv(ushort* v)
        // [not processed] - void SecondaryColorPointer(int size,uint type,int stride,void* pointer)
        // [not processed] - void WindowPos2dv(double* v)
        // [not processed] - void WindowPos2fv(float* v)
        // [not processed] - void WindowPos2iv(int* v)
        // [not processed] - void WindowPos2sv(short* v)
        // [not processed] - void WindowPos3dv(double* v)
        // [not processed] - void WindowPos3fv(float* v)
        // [not processed] - void WindowPos3iv(int* v)
        // [not processed] - void WindowPos3sv(short* v)

        #region Promoted from ARB_imaging subset to core


        #endregion Promoted from ARB_imaging subset to core

        #endregion GL_VERSION_1_4

        #region GL_VERSION_1_5

        /// <summary>
        /// [Overload] - void GenQueries(int n,uint* ids)
        /// </summary>
        public unsafe static uint GenQueries() {
            uint ids = 0;
            GLNative.glGenQueries(1, &ids);
            return ids;
        }

        /// <summary>
        /// [Overload] - void GenQueries(int n,uint* ids)
        /// </summary>
        public unsafe static uint[] GenQueries(int n) {
            uint[] ids = new uint[n];
            fixed (uint* pIds = &ids[0]) {
                GLNative.glGenQueries(n, pIds);
            }
            return ids;
        }

        /// <summary>
        /// [Overload] - void DeleteQueries(int n,uint* ids)
        /// </summary>
        public unsafe static void DeleteQueries(uint[] ids) {
            fixed (uint* pIds = &ids[0]) {
                GLNative.glDeleteQueries(ids.Length, pIds);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteQueries(int n,uint* ids)
        /// </summary>
        public unsafe static void DeleteQueries(uint[] ids, int n) {
            fixed (uint* pIds = &ids[0]) {
                GLNative.glDeleteQueries(n, pIds);
            }
        }

        /// <summary>
        /// [Overload] - void GetQueryiv(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetQueryiv(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetQueryiv(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetQueryObjectiv(uint id,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetQueryObjectiv(uint id, uint pname) {
            int ps = 0;
            GLNative.glGetQueryObjectiv(id, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetQueryObjectuiv(uint id,uint pname,uint* ps)
        /// </summary>
        public unsafe static uint GetQueryObjectuiv(uint id, uint pname) {
            uint ps = 0;
            GLNative.glGetQueryObjectuiv(id, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void DeleteBuffers(int n,uint* buffers)
        /// </summary>
        public unsafe static void DeleteBuffers(uint[] buffers) {
            fixed (uint* pBuffers = &buffers[0]) {
                GLNative.glDeleteBuffers(buffers.Length, pBuffers);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteBuffers(int n,uint* buffers)
        /// </summary>
        public unsafe static void DeleteBuffers(uint[] buffers, int n) {
            fixed (uint* pBuffers = &buffers[0]) {
                GLNative.glDeleteBuffers(n, pBuffers);
            }
        }

        /// <summary>
        /// [Overload] - void GenBuffers(int n,uint* buffers)
        /// </summary>
        public unsafe static uint GenBuffers() {
            uint buffers = 0;
            GLNative.glGenBuffers(1, &buffers);
            return buffers;
        }

        /// <summary>
        /// [Overload] - void GenBuffers(int n,uint* buffers)
        /// </summary>
        public unsafe static uint[] GenBuffers(int n) {
            uint[] buffers = new uint[n];
            fixed (uint* pBuffers = &buffers[0]) {
                GLNative.glGenBuffers(n, pBuffers);
            }
            return buffers;
        }

        /// <summary>
        /// [Overload] - void BufferData(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferData(uint target, byte[] data, uint usage) {
            long size = data.Length * sizeof(byte);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferData(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferData(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferData(uint target, long size, byte[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferData(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferData(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferData(uint target, short[] data, uint usage) {
            long size = data.Length * sizeof(short);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferData(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferData(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferData(uint target, long size, short[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferData(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferData(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferData(uint target, ushort[] data, uint usage) {
            long size = data.Length * sizeof(ushort);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferData(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferData(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferData(uint target, long size, ushort[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferData(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferData(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferData(uint target, int[] data, uint usage) {
            long size = data.Length * sizeof(int);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferData(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferData(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferData(uint target, long size, int[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferData(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferData(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferData(uint target, uint[] data, uint usage) {
            long size = data.Length * sizeof(uint);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferData(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferData(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferData(uint target, long size, uint[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferData(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferData(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferData(uint target, float[] data, uint usage) {
            long size = data.Length * sizeof(float);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferData(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferData(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferData(uint target, long size, float[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferData(target, (IntPtr)size, pData, usage);
            }
        }

        // [not processed] - void BufferData(uint target,IntPtr size,void* data,uint usage)
        /// <summary>
        /// [Overload] - void BufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubData(uint target, IntPtr offset, byte[] data) {
            long size = data.Length * sizeof(byte);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubData(uint target, IntPtr offset, long size, byte[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubData(uint target, IntPtr offset, short[] data) {
            long size = data.Length * sizeof(short);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubData(uint target, IntPtr offset, long size, short[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubData(uint target, IntPtr offset, ushort[] data) {
            long size = data.Length * sizeof(ushort);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubData(uint target, IntPtr offset, long size, ushort[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubData(uint target, IntPtr offset, int[] data) {
            long size = data.Length * sizeof(int);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubData(uint target, IntPtr offset, long size, int[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubData(uint target, IntPtr offset, uint[] data) {
            long size = data.Length * sizeof(uint);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubData(uint target, IntPtr offset, long size, uint[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubData(uint target, IntPtr offset, float[] data) {
            long size = data.Length * sizeof(float);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubData(uint target, IntPtr offset, long size, float[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        // [not processed] - void BufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// <summary>
        /// [Overload] - void GetBufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubData(uint target, IntPtr offset, byte[] data) {
            long size = data.Length * sizeof(byte);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubData(uint target, IntPtr offset, long size, byte[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubData(uint target, IntPtr offset, short[] data) {
            long size = data.Length * sizeof(short);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubData(uint target, IntPtr offset, long size, short[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubData(uint target, IntPtr offset, ushort[] data) {
            long size = data.Length * sizeof(ushort);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubData(uint target, IntPtr offset, long size, ushort[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubData(uint target, IntPtr offset, int[] data) {
            long size = data.Length * sizeof(int);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubData(uint target, IntPtr offset, long size, int[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubData(uint target, IntPtr offset, uint[] data) {
            long size = data.Length * sizeof(uint);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubData(uint target, IntPtr offset, long size, uint[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubData(uint target, IntPtr offset, float[] data) {
            long size = data.Length * sizeof(float);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubData(uint target, IntPtr offset, long size, float[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubData(target, offset, (IntPtr)size, pData);
            }
        }

        // [ignore] - void GetBufferSubData(uint target,IntPtr offset,IntPtr size,void* data)
        // [not processed] - void* MapBuffer(uint target,uint access)
        /// <summary>
        /// [Overload] - void GetBufferParameteriv(uint target,uint value,int* data)
        /// </summary>
        public unsafe static int GetBufferParameteriv(uint target, uint value) {
            int data = 0;
            GLNative.glGetBufferParameteriv(target, value, &data);
            return data;
        }

        // [not processed] - void GetBufferPointerv(uint target,uint pname,void** ps)

        #endregion GL_VERSION_1_5

        #region GL_VERSION_2_0

        // [not processed] - void DrawBuffers(int n,uint* bufs)
        // [not processed] - void BindAttribLocation(uint program,uint index,byte* name)
        // [not processed] - void GetActiveAttrib(uint program,uint index,int bufSize,int* length,int* size,uint* type,byte* name)
        // [not processed] - void GetActiveUniform(uint program,uint index,int bufSize,int* length,int* size,uint* type,byte* name)
        // [not processed] - void GetAttachedShaders(uint program,int maxCount,int* count,uint* shaders)
        // [not processed] - int GetAttribLocation(uint program,byte* name)
        /// <summary>
        /// [Overload] - void GetProgramiv(uint program,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetProgramiv(uint program, uint pname) {
            int ps = 0;
            GLNative.glGetProgramiv(program, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetProgramInfoLog(uint program,int maxLength,int* length,byte* infoLog)
        /// </summary>
        public unsafe static string GetProgramInfoLog(uint program) {
            int length = 0;
            byte[] infoLog = new byte[1024];
            fixed (byte* pInfoLog = &infoLog[0]) {
                GLNative.glGetProgramInfoLog(program, infoLog.Length, &length, pInfoLog);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(infoLog, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetProgramInfoLog(uint program,int maxLength,int* length,byte* infoLog)
        /// </summary>
        public unsafe static string GetProgramInfoLog(uint program, int maxLength) {
            int length = 0;
            byte[] infoLog = new byte[maxLength];
            fixed (byte* pInfoLog = &infoLog[0]) {
                GLNative.glGetProgramInfoLog(program, maxLength, &length, pInfoLog);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(infoLog, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetShaderiv(uint shader,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetShaderiv(uint shader, uint pname) {
            int ps = 0;
            GLNative.glGetShaderiv(shader, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetShaderInfoLog(uint shader,int maxLength,int* length,byte* infoLog)
        /// </summary>
        public unsafe static string GetShaderInfoLog(uint shader) {
            int length = 0;
            byte[] infoLog = new byte[1024];
            fixed (byte* pInfoLog = &infoLog[0]) {
                GLNative.glGetShaderInfoLog(shader, infoLog.Length, &length, pInfoLog);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(infoLog, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetShaderInfoLog(uint shader,int maxLength,int* length,byte* infoLog)
        /// </summary>
        public unsafe static string GetShaderInfoLog(uint shader, int maxLength) {
            int length = 0;
            byte[] infoLog = new byte[maxLength];
            fixed (byte* pInfoLog = &infoLog[0]) {
                GLNative.glGetShaderInfoLog(shader, maxLength, &length, pInfoLog);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(infoLog, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetShaderSource(uint shader,int bufSize,int* length,byte* source)
        /// </summary>
        public unsafe static string GetShaderSource(uint shader) {
            int length = 0;
            byte[] source = new byte[1024];
            fixed (byte* pSource = &source[0]) {
                GLNative.glGetShaderSource(shader, source.Length, &length, pSource);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(source, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetShaderSource(uint shader,int bufSize,int* length,byte* source)
        /// </summary>
        public unsafe static string GetShaderSource(uint shader, int bufSize) {
            int length = 0;
            byte[] source = new byte[bufSize];
            fixed (byte* pSource = &source[0]) {
                GLNative.glGetShaderSource(shader, bufSize, &length, pSource);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(source, 0, length);
            }
        }

        // [not processed] - int GetUniformLocation(uint program,byte* name)
        /// <summary>
        /// [Overload] - void GetUniformfv(uint program,int location,float* ps)
        /// </summary>
        public unsafe static float GetUniformfv(uint program, int location) {
            float ps = 0;
            GLNative.glGetUniformfv(program, location, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetUniformiv(uint program,int location,int* ps)
        /// </summary>
        public unsafe static int GetUniformiv(uint program, int location) {
            int ps = 0;
            GLNative.glGetUniformiv(program, location, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVertexAttribdv(uint index,uint pname,double* ps)
        /// </summary>
        public unsafe static double GetVertexAttribdv(uint index, uint pname) {
            double ps = 0;
            GLNative.glGetVertexAttribdv(index, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVertexAttribfv(uint index,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetVertexAttribfv(uint index, uint pname) {
            float ps = 0;
            GLNative.glGetVertexAttribfv(index, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVertexAttribiv(uint index,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetVertexAttribiv(uint index, uint pname) {
            int ps = 0;
            GLNative.glGetVertexAttribiv(index, pname, &ps);
            return ps;
        }

        // [not processed] - void GetVertexAttribPointerv(uint index,uint pname,void** pointer)
        /// <summary>
        /// [Overload] - void ShaderSource(uint shader,int count,byte** str,int* length)
        /// </summary>
        public unsafe static void ShaderSource(uint shader, string str) {
            GL.ShaderSource(shader, new string[] { str }, 1);
        }
        /// <summary>
        /// [Overload] - void ShaderSource(uint shader,int count,byte** str,int* length)
        /// </summary>
        public unsafe static void ShaderSource(uint shader, string[] strs) {
            GL.ShaderSource(shader, strs, strs.Length);
        }
        /// <summary>
        /// [Overload] - void ShaderSource(uint shader,int count,byte** str,int* length)
        /// </summary>
        public unsafe static void ShaderSource(uint shader, string[] strs, int count) {
            int[] nLens = new int[strs.Length];
            IntPtr ptr = MarshalExtend.AllocStringArr(strs, nLens, Encoding.UTF8);
            try {
                fixed (int* pNLens = &nLens[0]) {
                    GLNative.glShaderSource(shader, strs.Length, (byte**)ptr, pNLens);
                }
            } finally {
                MarshalExtend.FreeStringArr(ptr, strs.Length);
            }
        }
        // [not processed] - void Uniform1fv(int location,int count,float* value)
        // [not processed] - void Uniform2fv(int location,int count,float* value)
        // [not processed] - void Uniform3fv(int location,int count,float* value)
        // [not processed] - void Uniform4fv(int location,int count,float* value)
        // [not processed] - void Uniform1iv(int location,int count,int* value)
        // [not processed] - void Uniform2iv(int location,int count,int* value)
        // [not processed] - void Uniform3iv(int location,int count,int* value)
        // [not processed] - void Uniform4iv(int location,int count,int* value)
        // [not processed] - void UniformMatrix2fv(int location,int count,bool transpose,float* value)
        // [not processed] - void UniformMatrix3fv(int location,int count,bool transpose,float* value)
        // [not processed] - void UniformMatrix4fv(int location,int count,bool transpose,float* value)
        // [not processed] - void VertexAttrib1dv(uint index,double* v)
        // [not processed] - void VertexAttrib1fv(uint index,float* v)
        // [not processed] - void VertexAttrib1sv(uint index,short* v)
        // [not processed] - void VertexAttrib2dv(uint index,double* v)
        // [not processed] - void VertexAttrib2fv(uint index,float* v)
        // [not processed] - void VertexAttrib2sv(uint index,short* v)
        // [not processed] - void VertexAttrib3dv(uint index,double* v)
        // [not processed] - void VertexAttrib3fv(uint index,float* v)
        // [not processed] - void VertexAttrib3sv(uint index,short* v)
        // [not processed] - void VertexAttrib4Nbv(uint index,byte* v)
        // [not processed] - void VertexAttrib4Niv(uint index,int* v)
        // [not processed] - void VertexAttrib4Nsv(uint index,short* v)
        // [not processed] - void VertexAttrib4Nubv(uint index,byte* v)
        // [not processed] - void VertexAttrib4Nuiv(uint index,uint* v)
        // [not processed] - void VertexAttrib4Nusv(uint index,ushort* v)
        // [not processed] - void VertexAttrib4bv(uint index,byte* v)
        // [not processed] - void VertexAttrib4dv(uint index,double* v)
        // [not processed] - void VertexAttrib4fv(uint index,float* v)
        // [not processed] - void VertexAttrib4iv(uint index,int* v)
        // [not processed] - void VertexAttrib4sv(uint index,short* v)
        // [not processed] - void VertexAttrib4ubv(uint index,byte* v)
        // [not processed] - void VertexAttrib4uiv(uint index,uint* v)
        // [not processed] - void VertexAttrib4usv(uint index,ushort* v)
        // [not processed] - void VertexAttribPointer(uint index,int size,uint type,bool normalized,int stride,void* pointer)

        #endregion GL_VERSION_2_0

        #region GL_VERSION_2_1

        // [not processed] - void UniformMatrix2x3fv(int location,int count,bool transpose,float* value)
        // [not processed] - void UniformMatrix3x2fv(int location,int count,bool transpose,float* value)
        // [not processed] - void UniformMatrix2x4fv(int location,int count,bool transpose,float* value)
        // [not processed] - void UniformMatrix4x2fv(int location,int count,bool transpose,float* value)
        // [not processed] - void UniformMatrix3x4fv(int location,int count,bool transpose,float* value)
        // [not processed] - void UniformMatrix4x3fv(int location,int count,bool transpose,float* value)

        #endregion GL_VERSION_2_1

        #region GL_VERSION_3_0

        /// <summary>
        /// [Overload] - void GetBooleani_v(uint target,uint index,bool* data)
        /// </summary>
        public unsafe static bool GetBooleani_v(uint target, uint index) {
            bool data = false;
            GLNative.glGetBooleani_v(target, index, &data);
            return data;
        }

        /// <summary>
        /// [Overload] - void GetIntegeri_v(uint target,uint index,int* data)
        /// </summary>
        public unsafe static int GetIntegeri_v(uint target, uint index) {
            int data = 0;
            GLNative.glGetIntegeri_v(target, index, &data);
            return data;
        }

        // [not processed] - void TransformFeedbackVaryings(uint program,int count,byte** varyings,uint bufferMode)
        // [not processed] - void GetTransformFeedbackVarying(uint program,uint index,int bufSize,int* length,int* size,uint* type,byte* name)
        // [not processed] - void VertexAttribIPointer(uint index,int size,uint type,int stride,void* pointer)
        /// <summary>
        /// [Overload] - void GetVertexAttribIiv(uint index,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetVertexAttribIiv(uint index, uint pname) {
            int ps = 0;
            GLNative.glGetVertexAttribIiv(index, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVertexAttribIuiv(uint index,uint pname,uint* ps)
        /// </summary>
        public unsafe static uint GetVertexAttribIuiv(uint index, uint pname) {
            uint ps = 0;
            GLNative.glGetVertexAttribIuiv(index, pname, &ps);
            return ps;
        }

        // [not processed] - void VertexAttribI1iv(uint index,int* v)
        // [not processed] - void VertexAttribI2iv(uint index,int* v)
        // [not processed] - void VertexAttribI3iv(uint index,int* v)
        // [not processed] - void VertexAttribI4iv(uint index,int* v)
        // [not processed] - void VertexAttribI1uiv(uint index,uint* v)
        // [not processed] - void VertexAttribI2uiv(uint index,uint* v)
        // [not processed] - void VertexAttribI3uiv(uint index,uint* v)
        // [not processed] - void VertexAttribI4uiv(uint index,uint* v)
        // [not processed] - void VertexAttribI4bv(uint index,byte* v)
        // [not processed] - void VertexAttribI4sv(uint index,short* v)
        // [not processed] - void VertexAttribI4ubv(uint index,byte* v)
        // [not processed] - void VertexAttribI4usv(uint index,ushort* v)
        /// <summary>
        /// [Overload] - void GetUniformuiv(uint program,int location,uint* ps)
        /// </summary>
        public unsafe static uint GetUniformuiv(uint program, int location) {
            uint ps = 0;
            GLNative.glGetUniformuiv(program, location, &ps);
            return ps;
        }

        // [not processed] - void BindFragDataLocation(uint program,uint colorNumber,byte* name)
        // [not processed] - int GetFragDataLocation(uint program,byte* name)
        // [not processed] - void Uniform1uiv(int location,int count,uint* value)
        // [not processed] - void Uniform2uiv(int location,int count,uint* value)
        // [not processed] - void Uniform3uiv(int location,int count,uint* value)
        // [not processed] - void Uniform4uiv(int location,int count,uint* value)
        // [not processed] - void TexParameterIiv(uint target,uint pname,int* ps)
        // [not processed] - void TexParameterIuiv(uint target,uint pname,uint* ps)
        /// <summary>
        /// [Overload] - void GetTexParameterIiv(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetTexParameterIiv(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetTexParameterIiv(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetTexParameterIuiv(uint target,uint pname,uint* ps)
        /// </summary>
        public unsafe static uint GetTexParameterIuiv(uint target, uint pname) {
            uint ps = 0;
            GLNative.glGetTexParameterIuiv(target, pname, &ps);
            return ps;
        }

        // [not processed] - void ClearBufferiv(uint buffer,int drawbuffer,int* value)
        // [not processed] - void ClearBufferuiv(uint buffer,int drawbuffer,uint* value)
        // [not processed] - void ClearBufferfv(uint buffer,int drawbuffer,float* value)
        // [not processed] - byte* GetStringi(uint name,uint index)

        #region Reuse ARB_framebuffer_object

        /// <summary>
        /// [Overload] - void DeleteRenderbuffers(int n,uint* renderbuffers)
        /// </summary>
        public unsafe static void DeleteRenderbuffers(uint[] renderbuffers) {
            fixed (uint* pRenderbuffers = &renderbuffers[0]) {
                GLNative.glDeleteRenderbuffers(renderbuffers.Length, pRenderbuffers);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteRenderbuffers(int n,uint* renderbuffers)
        /// </summary>
        public unsafe static void DeleteRenderbuffers(uint[] renderbuffers, int n) {
            fixed (uint* pRenderbuffers = &renderbuffers[0]) {
                GLNative.glDeleteRenderbuffers(n, pRenderbuffers);
            }
        }

        /// <summary>
        /// [Overload] - void GenRenderbuffers(int n,uint* renderbuffers)
        /// </summary>
        public unsafe static uint GenRenderbuffers() {
            uint renderbuffers = 0;
            GLNative.glGenRenderbuffers(1, &renderbuffers);
            return renderbuffers;
        }

        /// <summary>
        /// [Overload] - void GenRenderbuffers(int n,uint* renderbuffers)
        /// </summary>
        public unsafe static uint[] GenRenderbuffers(int n) {
            uint[] renderbuffers = new uint[n];
            fixed (uint* pRenderbuffers = &renderbuffers[0]) {
                GLNative.glGenRenderbuffers(n, pRenderbuffers);
            }
            return renderbuffers;
        }

        /// <summary>
        /// [Overload] - void GetRenderbufferParameteriv(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetRenderbufferParameteriv(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetRenderbufferParameteriv(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void DeleteFramebuffers(int n,uint* framebuffers)
        /// </summary>
        public unsafe static void DeleteFramebuffers(uint[] framebuffers) {
            fixed (uint* pFramebuffers = &framebuffers[0]) {
                GLNative.glDeleteFramebuffers(framebuffers.Length, pFramebuffers);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteFramebuffers(int n,uint* framebuffers)
        /// </summary>
        public unsafe static void DeleteFramebuffers(uint[] framebuffers, int n) {
            fixed (uint* pFramebuffers = &framebuffers[0]) {
                GLNative.glDeleteFramebuffers(n, pFramebuffers);
            }
        }

        /// <summary>
        /// [Overload] - void GenFramebuffers(int n,uint* ids)
        /// </summary>
        public unsafe static uint GenFramebuffers() {
            uint ids = 0;
            GLNative.glGenFramebuffers(1, &ids);
            return ids;
        }

        /// <summary>
        /// [Overload] - void GenFramebuffers(int n,uint* ids)
        /// </summary>
        public unsafe static uint[] GenFramebuffers(int n) {
            uint[] ids = new uint[n];
            fixed (uint* pIds = &ids[0]) {
                GLNative.glGenFramebuffers(n, pIds);
            }
            return ids;
        }

        /// <summary>
        /// [Overload] - void GetFramebufferAttachmentParameteriv(uint target,uint attachment,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname) {
            int ps = 0;
            GLNative.glGetFramebufferAttachmentParameteriv(target, attachment, pname, &ps);
            return ps;
        }


        #endregion Reuse ARB_framebuffer_object

        #region Reuse ARB_map_buffer_range

        // [not processed] - void* MapBufferRange(uint target,IntPtr offset,IntPtr length,uint access)

        #endregion Reuse ARB_map_buffer_range

        #region Reuse ARB_vertex_array_object

        /// <summary>
        /// [Overload] - void DeleteVertexArrays(int n,uint* arrays)
        /// </summary>
        public unsafe static void DeleteVertexArrays(uint[] arrays) {
            fixed (uint* pArrays = &arrays[0]) {
                GLNative.glDeleteVertexArrays(arrays.Length, pArrays);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteVertexArrays(int n,uint* arrays)
        /// </summary>
        public unsafe static void DeleteVertexArrays(uint[] arrays, int n) {
            fixed (uint* pArrays = &arrays[0]) {
                GLNative.glDeleteVertexArrays(n, pArrays);
            }
        }

        /// <summary>
        /// [Overload] - void GenVertexArrays(int n,uint* arrays)
        /// </summary>
        public unsafe static uint GenVertexArrays() {
            uint arrays = 0;
            GLNative.glGenVertexArrays(1, &arrays);
            return arrays;
        }

        /// <summary>
        /// [Overload] - void GenVertexArrays(int n,uint* arrays)
        /// </summary>
        public unsafe static uint[] GenVertexArrays(int n) {
            uint[] arrays = new uint[n];
            fixed (uint* pArrays = &arrays[0]) {
                GLNative.glGenVertexArrays(n, pArrays);
            }
            return arrays;
        }


        #endregion Reuse ARB_vertex_array_object

        #endregion GL_VERSION_3_0

        #region GL_VERSION_3_1

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, byte[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_BYTE, pIndices, instancecount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, uint type, byte[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, int count, uint type, byte[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, count, type, pIndices, instancecount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, short[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, (indices == null ? 0 : indices.Length), GL.GL_SHORT, pIndices, instancecount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, uint type, short[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, int count, uint type, short[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, count, type, pIndices, instancecount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, ushort[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_SHORT, pIndices, instancecount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, uint type, ushort[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, int count, uint type, ushort[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, count, type, pIndices, instancecount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, int[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, (indices == null ? 0 : indices.Length), GL.GL_INT, pIndices, instancecount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, uint type, int[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, int count, uint type, int[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, count, type, pIndices, instancecount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, uint[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_INT, pIndices, instancecount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, uint type, uint[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, int count, uint type, uint[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, count, type, pIndices, instancecount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, float[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, (indices == null ? 0 : indices.Length), GL.GL_FLOAT, pIndices, instancecount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, uint type, float[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstanced(uint mode,int count,uint type,void* indices,int instancecount)
        /// </summary>
        public unsafe static void DrawElementsInstanced(uint mode, int count, uint type, float[] indices, int instancecount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstanced(mode, count, type, pIndices, instancecount);
            }
        }


        #region Reuse ARB_copy_buffer


        #endregion Reuse ARB_copy_buffer

        #region Reuse ARB_uniform_buffer_object

        // [not processed] - void GetUniformIndices(uint program,int uniformCount,byte** uniformNames,uint* uniformIndices)
        // [not processed] - void GetActiveUniformsiv(uint program,int uniformCount,uint* uniformIndices,uint pname,int* ps)
        /// <summary>
        /// [Overload] - void GetActiveUniformName(uint program,uint uniformIndex,int bufSize,int* length,byte* uniformName)
        /// </summary>
        public unsafe static string GetActiveUniformName(uint program, uint uniformIndex) {
            int length = 0;
            byte[] uniformName = new byte[1024];
            fixed (byte* pUniformName = &uniformName[0]) {
                GLNative.glGetActiveUniformName(program, uniformIndex, uniformName.Length, &length, pUniformName);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(uniformName, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetActiveUniformName(uint program,uint uniformIndex,int bufSize,int* length,byte* uniformName)
        /// </summary>
        public unsafe static string GetActiveUniformName(uint program, uint uniformIndex, int bufSize) {
            int length = 0;
            byte[] uniformName = new byte[bufSize];
            fixed (byte* pUniformName = &uniformName[0]) {
                GLNative.glGetActiveUniformName(program, uniformIndex, bufSize, &length, pUniformName);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(uniformName, 0, length);
            }
        }

        // [not processed] - uint GetUniformBlockIndex(uint program,byte* uniformBlockName)
        /// <summary>
        /// [Overload] - void GetActiveUniformBlockiv(uint program,uint uniformBlockIndex,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname) {
            int ps = 0;
            GLNative.glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetActiveUniformBlockName(uint program,uint uniformBlockIndex,int bufSize,int* length,byte* uniformBlockName)
        /// </summary>
        public unsafe static string GetActiveUniformBlockName(uint program, uint uniformBlockIndex) {
            int length = 0;
            byte[] uniformBlockName = new byte[1024];
            fixed (byte* pUniformBlockName = &uniformBlockName[0]) {
                GLNative.glGetActiveUniformBlockName(program, uniformBlockIndex, uniformBlockName.Length, &length, pUniformBlockName);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(uniformBlockName, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetActiveUniformBlockName(uint program,uint uniformBlockIndex,int bufSize,int* length,byte* uniformBlockName)
        /// </summary>
        public unsafe static string GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize) {
            int length = 0;
            byte[] uniformBlockName = new byte[bufSize];
            fixed (byte* pUniformBlockName = &uniformBlockName[0]) {
                GLNative.glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, &length, pUniformBlockName);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(uniformBlockName, 0, length);
            }
        }


        #endregion Reuse ARB_uniform_buffer_object

        #endregion GL_VERSION_3_1

        #region GL_VERSION_3_2


        #region Reuse ARB_draw_elements_base_vertex

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, byte[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_BYTE, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, uint type, byte[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, (indices == null ? 0 : indices.Length), type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, int count, uint type, byte[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, count, type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, short[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, (indices == null ? 0 : indices.Length), GL.GL_SHORT, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, uint type, short[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, (indices == null ? 0 : indices.Length), type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, int count, uint type, short[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, count, type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, ushort[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_SHORT, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, uint type, ushort[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, (indices == null ? 0 : indices.Length), type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, int count, uint type, ushort[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, count, type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, int[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, (indices == null ? 0 : indices.Length), GL.GL_INT, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, uint type, int[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, (indices == null ? 0 : indices.Length), type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, int count, uint type, int[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, count, type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, uint[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_INT, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, uint type, uint[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, (indices == null ? 0 : indices.Length), type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, int count, uint type, uint[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, count, type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, float[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, (indices == null ? 0 : indices.Length), GL.GL_FLOAT, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, uint type, float[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, (indices == null ? 0 : indices.Length), type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsBaseVertex(uint mode, int count, uint type, float[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsBaseVertex(mode, count, type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, byte[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_BYTE, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, uint type, byte[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, byte[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, count, type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, short[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_SHORT, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, uint type, short[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, short[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, count, type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, ushort[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_SHORT, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, uint type, ushort[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, ushort[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, count, type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_INT, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, uint type, int[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, int[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, count, type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, uint[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_INT, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, uint type, uint[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, uint[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, count, type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, float[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_FLOAT, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, uint type, float[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex)
        /// </summary>
        public unsafe static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, float[] indices, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsBaseVertex(mode, start, end, count, type, pIndices, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, byte[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_BYTE, pIndices, instancecount, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, uint type, byte[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, byte[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, count, type, pIndices, instancecount, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, short[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, (indices == null ? 0 : indices.Length), GL.GL_SHORT, pIndices, instancecount, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, uint type, short[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, short[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, count, type, pIndices, instancecount, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, ushort[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_SHORT, pIndices, instancecount, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, uint type, ushort[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, ushort[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, count, type, pIndices, instancecount, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, int[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, (indices == null ? 0 : indices.Length), GL.GL_INT, pIndices, instancecount, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, uint type, int[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, int[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, count, type, pIndices, instancecount, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, uint[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_INT, pIndices, instancecount, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, uint type, uint[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, uint[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, count, type, pIndices, instancecount, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, float[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, (indices == null ? 0 : indices.Length), GL.GL_FLOAT, pIndices, instancecount, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, uint type, float[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, basevertex);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, float[] indices, int instancecount, int basevertex) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertex(mode, count, type, pIndices, instancecount, basevertex);
            }
        }

        // [not processed] - void MultiDrawElementsBaseVertex(uint mode,int* count,uint type,IntPtr indices,int drawcount,int* basevertex)

        #endregion Reuse ARB_draw_elements_base_vertex

        #region Reuse ARB_provoking_vertex


        #endregion Reuse ARB_provoking_vertex

        #region Reuse ARB_sync

        /// <summary>
        /// [Overload] - void GetInteger64v(uint pname,UInt64* data)
        /// </summary>
        public unsafe static UInt64 GetInteger64v(uint pname) {
            UInt64 data = 0;
            GLNative.glGetInteger64v(pname, &data);
            return data;
        }

        // [not processed] - void GetSynciv(IntPtr sync,uint pname,int bufSize,int* length,int* values)

        #endregion Reuse ARB_sync

        #region Reuse ARB_texture_multisample

        /// <summary>
        /// [Overload] - void GetInteger64i_v(uint target,uint index,UInt64* data)
        /// </summary>
        public unsafe static UInt64 GetInteger64i_v(uint target, uint index) {
            UInt64 data = 0;
            GLNative.glGetInteger64i_v(target, index, &data);
            return data;
        }

        /// <summary>
        /// [Overload] - void GetBufferParameteri64v(uint target,uint value,UInt64* data)
        /// </summary>
        public unsafe static UInt64 GetBufferParameteri64v(uint target, uint value) {
            UInt64 data = 0;
            GLNative.glGetBufferParameteri64v(target, value, &data);
            return data;
        }

        /// <summary>
        /// [Overload] - void GetMultisamplefv(uint pname,uint index,float* val)
        /// </summary>
        public unsafe static float GetMultisamplefv(uint pname, uint index) {
            float val = 0;
            GLNative.glGetMultisamplefv(pname, index, &val);
            return val;
        }


        #endregion Reuse ARB_texture_multisample

        #region Compatibility-only GL 1.0 features removed from GL 3.2


        #endregion Compatibility-only GL 1.0 features removed from GL 3.2

        #region Compatibility-only GL 1.1 features removed from GL 3.2


        #endregion Compatibility-only GL 1.1 features removed from GL 3.2

        #region Compatibility-only GL 1.2 features removed from GL 3.2


        #endregion Compatibility-only GL 1.2 features removed from GL 3.2

        #region Compatibility-only GL 1.3 features removed from GL 3.2


        #endregion Compatibility-only GL 1.3 features removed from GL 3.2

        #region Compatibility-only GL 1.4 features removed from GL 3.2


        #endregion Compatibility-only GL 1.4 features removed from GL 3.2

        #region Compatibility-only GL 1.5 features removed from GL 3.2


        #endregion Compatibility-only GL 1.5 features removed from GL 3.2

        #region Compatibility-only GL 2.0 features removed from GL 3.2


        #endregion Compatibility-only GL 2.0 features removed from GL 3.2

        #region Compatibility-only GL 2.1 features removed from GL 3.2


        #endregion Compatibility-only GL 2.1 features removed from GL 3.2

        #region Compatibility-only GL 3.0 features removed from GL 3.2


        #endregion Compatibility-only GL 3.0 features removed from GL 3.2

        #endregion GL_VERSION_3_2

        #region GL_VERSION_3_3


        #region Reuse ARB_blend_func_extended

        // [not processed] - void BindFragDataLocationIndexed(uint program,uint colorNumber,uint index,byte* name)
        // [not processed] - int GetFragDataIndex(uint program,byte* name)

        #endregion Reuse ARB_blend_func_extended

        #region Reuse ARB_sampler_objects

        /// <summary>
        /// [Overload] - void GenSamplers(int n,uint* samplers)
        /// </summary>
        public unsafe static uint GenSamplers() {
            uint samplers = 0;
            GLNative.glGenSamplers(1, &samplers);
            return samplers;
        }

        /// <summary>
        /// [Overload] - void GenSamplers(int n,uint* samplers)
        /// </summary>
        public unsafe static uint[] GenSamplers(int n) {
            uint[] samplers = new uint[n];
            fixed (uint* pSamplers = &samplers[0]) {
                GLNative.glGenSamplers(n, pSamplers);
            }
            return samplers;
        }

        /// <summary>
        /// [Overload] - void DeleteSamplers(int n,uint* samplers)
        /// </summary>
        public unsafe static void DeleteSamplers(uint[] samplers) {
            fixed (uint* pSamplers = &samplers[0]) {
                GLNative.glDeleteSamplers(samplers.Length, pSamplers);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteSamplers(int n,uint* samplers)
        /// </summary>
        public unsafe static void DeleteSamplers(uint[] samplers, int n) {
            fixed (uint* pSamplers = &samplers[0]) {
                GLNative.glDeleteSamplers(n, pSamplers);
            }
        }

        // [not processed] - void SamplerParameteriv(uint sampler,uint pname,int* ps)
        // [not processed] - void SamplerParameterfv(uint sampler,uint pname,float* ps)
        // [not processed] - void SamplerParameterIiv(uint sampler,uint pname,int* ps)
        // [not processed] - void SamplerParameterIuiv(uint sampler,uint pname,uint* ps)
        /// <summary>
        /// [Overload] - void GetSamplerParameteriv(uint sampler,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetSamplerParameteriv(uint sampler, uint pname) {
            int ps = 0;
            GLNative.glGetSamplerParameteriv(sampler, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetSamplerParameterIiv(uint sampler,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetSamplerParameterIiv(uint sampler, uint pname) {
            int ps = 0;
            GLNative.glGetSamplerParameterIiv(sampler, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetSamplerParameterfv(uint sampler,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetSamplerParameterfv(uint sampler, uint pname) {
            float ps = 0;
            GLNative.glGetSamplerParameterfv(sampler, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetSamplerParameterIuiv(uint sampler,uint pname,uint* ps)
        /// </summary>
        public unsafe static uint GetSamplerParameterIuiv(uint sampler, uint pname) {
            uint ps = 0;
            GLNative.glGetSamplerParameterIuiv(sampler, pname, &ps);
            return ps;
        }


        #endregion Reuse ARB_sampler_objects

        #region Reuse ARB_timer_query

        /// <summary>
        /// [Overload] - void GetQueryObjecti64v(uint id,uint pname,UInt64* ps)
        /// </summary>
        public unsafe static UInt64 GetQueryObjecti64v(uint id, uint pname) {
            UInt64 ps = 0;
            GLNative.glGetQueryObjecti64v(id, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetQueryObjectui64v(uint id,uint pname,UInt64* ps)
        /// </summary>
        public unsafe static UInt64 GetQueryObjectui64v(uint id, uint pname) {
            UInt64 ps = 0;
            GLNative.glGetQueryObjectui64v(id, pname, &ps);
            return ps;
        }


        #endregion Reuse ARB_timer_query

        #region Reuse ARB_vertex_type_2_10_10_10_rev

        // [not processed] - void VertexAttribP1uiv(uint index,uint type,bool normalized,uint* value)
        // [not processed] - void VertexAttribP2uiv(uint index,uint type,bool normalized,uint* value)
        // [not processed] - void VertexAttribP3uiv(uint index,uint type,bool normalized,uint* value)
        // [not processed] - void VertexAttribP4uiv(uint index,uint type,bool normalized,uint* value)

        #endregion Reuse ARB_vertex_type_2_10_10_10_rev

        #region Reuse ARB_vertex_type_2_10_10_10_rev compatibility profile

        // [not processed] - void VertexP2uiv(uint type,uint* value)
        // [not processed] - void VertexP3uiv(uint type,uint* value)
        // [not processed] - void VertexP4uiv(uint type,uint* value)
        // [not processed] - void TexCoordP1uiv(uint type,uint* coords)
        // [not processed] - void TexCoordP2uiv(uint type,uint* coords)
        // [not processed] - void TexCoordP3uiv(uint type,uint* coords)
        // [not processed] - void TexCoordP4uiv(uint type,uint* coords)
        // [not processed] - void MultiTexCoordP1uiv(uint texture,uint type,uint* coords)
        // [not processed] - void MultiTexCoordP2uiv(uint texture,uint type,uint* coords)
        // [not processed] - void MultiTexCoordP3uiv(uint texture,uint type,uint* coords)
        // [not processed] - void MultiTexCoordP4uiv(uint texture,uint type,uint* coords)
        // [not processed] - void NormalP3uiv(uint type,uint* coords)
        // [not processed] - void ColorP3uiv(uint type,uint* color)
        // [not processed] - void ColorP4uiv(uint type,uint* color)
        // [not processed] - void SecondaryColorP3uiv(uint type,uint* color)

        #endregion Reuse ARB_vertex_type_2_10_10_10_rev compatibility profile

        #endregion GL_VERSION_3_3

        #region GL_VERSION_4_0


        #region Reuse ARB_draw_indirect

        // [not processed] - void DrawArraysIndirect(uint mode,void* indirect)
        // [not processed] - void DrawElementsIndirect(uint mode,uint type,void* indirect)

        #endregion Reuse ARB_draw_indirect

        #region Reuse ARB_gpu_shader_fp64

        // [not processed] - void Uniform1dv(int location,int count,double* value)
        // [not processed] - void Uniform2dv(int location,int count,double* value)
        // [not processed] - void Uniform3dv(int location,int count,double* value)
        // [not processed] - void Uniform4dv(int location,int count,double* value)
        // [not processed] - void UniformMatrix2dv(int location,int count,bool transpose,double* value)
        // [not processed] - void UniformMatrix3dv(int location,int count,bool transpose,double* value)
        // [not processed] - void UniformMatrix4dv(int location,int count,bool transpose,double* value)
        // [not processed] - void UniformMatrix2x3dv(int location,int count,bool transpose,double* value)
        // [not processed] - void UniformMatrix2x4dv(int location,int count,bool transpose,double* value)
        // [not processed] - void UniformMatrix3x2dv(int location,int count,bool transpose,double* value)
        // [not processed] - void UniformMatrix3x4dv(int location,int count,bool transpose,double* value)
        // [not processed] - void UniformMatrix4x2dv(int location,int count,bool transpose,double* value)
        // [not processed] - void UniformMatrix4x3dv(int location,int count,bool transpose,double* value)
        /// <summary>
        /// [Overload] - void GetUniformdv(uint program,int location,double* ps)
        /// </summary>
        public unsafe static double GetUniformdv(uint program, int location) {
            double ps = 0;
            GLNative.glGetUniformdv(program, location, &ps);
            return ps;
        }


        #endregion Reuse ARB_gpu_shader_fp64

        #region Reuse ARB_shader_subroutine

        // [not processed] - int GetSubroutineUniformLocation(uint program,uint shadertype,byte* name)
        // [not processed] - uint GetSubroutineIndex(uint program,uint shadertype,byte* name)
        /// <summary>
        /// [Overload] - void GetActiveSubroutineUniformiv(uint program,uint shadertype,uint index,uint pname,int* values)
        /// </summary>
        public unsafe static int GetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname) {
            int values = 0;
            GLNative.glGetActiveSubroutineUniformiv(program, shadertype, index, pname, &values);
            return values;
        }

        /// <summary>
        /// [Overload] - void GetActiveSubroutineUniformName(uint program,uint shadertype,uint index,int bufSize,int* length,byte* name)
        /// </summary>
        public unsafe static string GetActiveSubroutineUniformName(uint program, uint shadertype, uint index) {
            int length = 0;
            byte[] name = new byte[1024];
            fixed (byte* pName = &name[0]) {
                GLNative.glGetActiveSubroutineUniformName(program, shadertype, index, name.Length, &length, pName);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(name, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetActiveSubroutineUniformName(uint program,uint shadertype,uint index,int bufSize,int* length,byte* name)
        /// </summary>
        public unsafe static string GetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufSize) {
            int length = 0;
            byte[] name = new byte[bufSize];
            fixed (byte* pName = &name[0]) {
                GLNative.glGetActiveSubroutineUniformName(program, shadertype, index, bufSize, &length, pName);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(name, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetActiveSubroutineName(uint program,uint shadertype,uint index,int bufSize,int* length,byte* name)
        /// </summary>
        public unsafe static string GetActiveSubroutineName(uint program, uint shadertype, uint index) {
            int length = 0;
            byte[] name = new byte[1024];
            fixed (byte* pName = &name[0]) {
                GLNative.glGetActiveSubroutineName(program, shadertype, index, name.Length, &length, pName);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(name, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetActiveSubroutineName(uint program,uint shadertype,uint index,int bufSize,int* length,byte* name)
        /// </summary>
        public unsafe static string GetActiveSubroutineName(uint program, uint shadertype, uint index, int bufSize) {
            int length = 0;
            byte[] name = new byte[bufSize];
            fixed (byte* pName = &name[0]) {
                GLNative.glGetActiveSubroutineName(program, shadertype, index, bufSize, &length, pName);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(name, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void UniformSubroutinesuiv(uint shadertype,int count,uint* indices)
        /// </summary>
        public unsafe static void UniformSubroutinesuiv(uint shadertype, uint[] indices) {
            fixed (uint* pIndices = &indices[0]) {
                GLNative.glUniformSubroutinesuiv(shadertype, (indices == null ? 0 : indices.Length), pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void UniformSubroutinesuiv(uint shadertype,int count,uint* indices)
        /// </summary>
        public unsafe static void UniformSubroutinesuiv(uint shadertype, int count, uint[] indices) {
            fixed (uint* pIndices = &indices[0]) {
                GLNative.glUniformSubroutinesuiv(shadertype, count, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void GetUniformSubroutineuiv(uint shadertype,int location,uint* values)
        /// </summary>
        public unsafe static uint GetUniformSubroutineuiv(uint shadertype, int location) {
            uint values = 0;
            GLNative.glGetUniformSubroutineuiv(shadertype, location, &values);
            return values;
        }

        /// <summary>
        /// [Overload] - void GetProgramStageiv(uint program,uint shadertype,uint pname,int* values)
        /// </summary>
        public unsafe static int GetProgramStageiv(uint program, uint shadertype, uint pname) {
            int values = 0;
            GLNative.glGetProgramStageiv(program, shadertype, pname, &values);
            return values;
        }


        #endregion Reuse ARB_shader_subroutine

        #region Reuse ARB_tessellation_shader

        // [not processed] - void PatchParameterfv(uint pname,float* values)

        #endregion Reuse ARB_tessellation_shader

        #region Reuse ARB_transform_feedback2

        /// <summary>
        /// [Overload] - void DeleteTransformFeedbacks(int n,uint* ids)
        /// </summary>
        public unsafe static void DeleteTransformFeedbacks(uint[] ids) {
            fixed (uint* pIds = &ids[0]) {
                GLNative.glDeleteTransformFeedbacks(ids.Length, pIds);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteTransformFeedbacks(int n,uint* ids)
        /// </summary>
        public unsafe static void DeleteTransformFeedbacks(uint[] ids, int n) {
            fixed (uint* pIds = &ids[0]) {
                GLNative.glDeleteTransformFeedbacks(n, pIds);
            }
        }

        /// <summary>
        /// [Overload] - void GenTransformFeedbacks(int n,uint* ids)
        /// </summary>
        public unsafe static uint GenTransformFeedbacks() {
            uint ids = 0;
            GLNative.glGenTransformFeedbacks(1, &ids);
            return ids;
        }

        /// <summary>
        /// [Overload] - void GenTransformFeedbacks(int n,uint* ids)
        /// </summary>
        public unsafe static uint[] GenTransformFeedbacks(int n) {
            uint[] ids = new uint[n];
            fixed (uint* pIds = &ids[0]) {
                GLNative.glGenTransformFeedbacks(n, pIds);
            }
            return ids;
        }


        #endregion Reuse ARB_transform_feedback2

        #region Reuse ARB_transform_feedback3

        /// <summary>
        /// [Overload] - void GetQueryIndexediv(uint target,uint index,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetQueryIndexediv(uint target, uint index, uint pname) {
            int ps = 0;
            GLNative.glGetQueryIndexediv(target, index, pname, &ps);
            return ps;
        }


        #endregion Reuse ARB_transform_feedback3

        #endregion GL_VERSION_4_0

        #region GL_VERSION_4_1


        #region Reuse commands from ARB_ES2_compatibility

        // [not processed] - void ShaderBinary(int count,uint* shaders,uint binaryFormat,void* binary,int length)
        // [not processed] - void GetShaderPrecisionFormat(uint shaderType,uint precisionType,int* range,int* precision)

        #endregion Reuse commands from ARB_ES2_compatibility

        #region Reuse commands from ARB_get_program_binary

        // [not processed] - void GetProgramBinary(uint program,int bufSize,int* length,uint* binaryFormat,void* binary)
        // [not processed] - void ProgramBinary(uint program,uint binaryFormat,void* binary,int length)

        #endregion Reuse commands from ARB_get_program_binary

        #region Reuse commands from ARB_separate_shader_objects

        // [not processed] - uint CreateShaderProgramv(uint type,int count,byte** strings)
        /// <summary>
        /// [Overload] - void DeleteProgramPipelines(int n,uint* pipelines)
        /// </summary>
        public unsafe static void DeleteProgramPipelines(uint[] pipelines) {
            fixed (uint* pPipelines = &pipelines[0]) {
                GLNative.glDeleteProgramPipelines(pipelines.Length, pPipelines);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteProgramPipelines(int n,uint* pipelines)
        /// </summary>
        public unsafe static void DeleteProgramPipelines(uint[] pipelines, int n) {
            fixed (uint* pPipelines = &pipelines[0]) {
                GLNative.glDeleteProgramPipelines(n, pPipelines);
            }
        }

        /// <summary>
        /// [Overload] - void GenProgramPipelines(int n,uint* pipelines)
        /// </summary>
        public unsafe static uint GenProgramPipelines() {
            uint pipelines = 0;
            GLNative.glGenProgramPipelines(1, &pipelines);
            return pipelines;
        }

        /// <summary>
        /// [Overload] - void GenProgramPipelines(int n,uint* pipelines)
        /// </summary>
        public unsafe static uint[] GenProgramPipelines(int n) {
            uint[] pipelines = new uint[n];
            fixed (uint* pPipelines = &pipelines[0]) {
                GLNative.glGenProgramPipelines(n, pPipelines);
            }
            return pipelines;
        }

        /// <summary>
        /// [Overload] - void GetProgramPipelineiv(uint pipeline,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetProgramPipelineiv(uint pipeline, uint pname) {
            int ps = 0;
            GLNative.glGetProgramPipelineiv(pipeline, pname, &ps);
            return ps;
        }

        // [not processed] - void ProgramUniform1iv(uint program,int location,int count,int* value)
        // [not processed] - void ProgramUniform1fv(uint program,int location,int count,float* value)
        // [not processed] - void ProgramUniform1dv(uint program,int location,int count,double* value)
        // [not processed] - void ProgramUniform1uiv(uint program,int location,int count,uint* value)
        // [not processed] - void ProgramUniform2iv(uint program,int location,int count,int* value)
        // [not processed] - void ProgramUniform2fv(uint program,int location,int count,float* value)
        // [not processed] - void ProgramUniform2dv(uint program,int location,int count,double* value)
        // [not processed] - void ProgramUniform2uiv(uint program,int location,int count,uint* value)
        // [not processed] - void ProgramUniform3iv(uint program,int location,int count,int* value)
        // [not processed] - void ProgramUniform3fv(uint program,int location,int count,float* value)
        // [not processed] - void ProgramUniform3dv(uint program,int location,int count,double* value)
        // [not processed] - void ProgramUniform3uiv(uint program,int location,int count,uint* value)
        // [not processed] - void ProgramUniform4iv(uint program,int location,int count,int* value)
        // [not processed] - void ProgramUniform4fv(uint program,int location,int count,float* value)
        // [not processed] - void ProgramUniform4dv(uint program,int location,int count,double* value)
        // [not processed] - void ProgramUniform4uiv(uint program,int location,int count,uint* value)
        // [not processed] - void ProgramUniformMatrix2fv(uint program,int location,int count,bool transpose,float* value)
        // [not processed] - void ProgramUniformMatrix3fv(uint program,int location,int count,bool transpose,float* value)
        // [not processed] - void ProgramUniformMatrix4fv(uint program,int location,int count,bool transpose,float* value)
        // [not processed] - void ProgramUniformMatrix2dv(uint program,int location,int count,bool transpose,double* value)
        // [not processed] - void ProgramUniformMatrix3dv(uint program,int location,int count,bool transpose,double* value)
        // [not processed] - void ProgramUniformMatrix4dv(uint program,int location,int count,bool transpose,double* value)
        // [not processed] - void ProgramUniformMatrix2x3fv(uint program,int location,int count,bool transpose,float* value)
        // [not processed] - void ProgramUniformMatrix3x2fv(uint program,int location,int count,bool transpose,float* value)
        // [not processed] - void ProgramUniformMatrix2x4fv(uint program,int location,int count,bool transpose,float* value)
        // [not processed] - void ProgramUniformMatrix4x2fv(uint program,int location,int count,bool transpose,float* value)
        // [not processed] - void ProgramUniformMatrix3x4fv(uint program,int location,int count,bool transpose,float* value)
        // [not processed] - void ProgramUniformMatrix4x3fv(uint program,int location,int count,bool transpose,float* value)
        // [not processed] - void ProgramUniformMatrix2x3dv(uint program,int location,int count,bool transpose,double* value)
        // [not processed] - void ProgramUniformMatrix3x2dv(uint program,int location,int count,bool transpose,double* value)
        // [not processed] - void ProgramUniformMatrix2x4dv(uint program,int location,int count,bool transpose,double* value)
        // [not processed] - void ProgramUniformMatrix4x2dv(uint program,int location,int count,bool transpose,double* value)
        // [not processed] - void ProgramUniformMatrix3x4dv(uint program,int location,int count,bool transpose,double* value)
        // [not processed] - void ProgramUniformMatrix4x3dv(uint program,int location,int count,bool transpose,double* value)
        /// <summary>
        /// [Overload] - void GetProgramPipelineInfoLog(uint pipeline,int bufSize,int* length,byte* infoLog)
        /// </summary>
        public unsafe static string GetProgramPipelineInfoLog(uint pipeline) {
            int length = 0;
            byte[] infoLog = new byte[1024];
            fixed (byte* pInfoLog = &infoLog[0]) {
                GLNative.glGetProgramPipelineInfoLog(pipeline, infoLog.Length, &length, pInfoLog);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(infoLog, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetProgramPipelineInfoLog(uint pipeline,int bufSize,int* length,byte* infoLog)
        /// </summary>
        public unsafe static string GetProgramPipelineInfoLog(uint pipeline, int bufSize) {
            int length = 0;
            byte[] infoLog = new byte[bufSize];
            fixed (byte* pInfoLog = &infoLog[0]) {
                GLNative.glGetProgramPipelineInfoLog(pipeline, bufSize, &length, pInfoLog);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(infoLog, 0, length);
            }
        }


        #endregion Reuse commands from ARB_separate_shader_objects

        #region Reuse commands from ARB_vertex_attrib_64bit

        // [not processed] - void VertexAttribL1dv(uint index,double* v)
        // [not processed] - void VertexAttribL2dv(uint index,double* v)
        // [not processed] - void VertexAttribL3dv(uint index,double* v)
        // [not processed] - void VertexAttribL4dv(uint index,double* v)
        // [not processed] - void VertexAttribLPointer(uint index,int size,uint type,int stride,void* pointer)
        /// <summary>
        /// [Overload] - void GetVertexAttribLdv(uint index,uint pname,double* ps)
        /// </summary>
        public unsafe static double GetVertexAttribLdv(uint index, uint pname) {
            double ps = 0;
            GLNative.glGetVertexAttribLdv(index, pname, &ps);
            return ps;
        }


        #endregion Reuse commands from ARB_vertex_attrib_64bit

        #region Reuse commands from ARB_viewport_array

        // [not processed] - void ViewportArrayv(uint first,int count,float* v)
        // [not processed] - void ViewportIndexedfv(uint index,float* v)
        // [not processed] - void ScissorArrayv(uint first,int count,int* v)
        // [not processed] - void ScissorIndexedv(uint index,int* v)
        // [not processed] - void DepthRangeArrayv(uint first,int count,double* v)
        /// <summary>
        /// [Overload] - void GetFloati_v(uint target,uint index,float* data)
        /// </summary>
        public unsafe static float GetFloati_v(uint target, uint index) {
            float data = 0;
            GLNative.glGetFloati_v(target, index, &data);
            return data;
        }

        /// <summary>
        /// [Overload] - void GetDoublei_v(uint target,uint index,double* data)
        /// </summary>
        public unsafe static double GetDoublei_v(uint target, uint index) {
            double data = 0;
            GLNative.glGetDoublei_v(target, index, &data);
            return data;
        }


        #endregion Reuse commands from ARB_viewport_array

        #endregion GL_VERSION_4_1

        #region GL_VERSION_4_2


        #region Reuse commands from ARB_base_instance

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, byte[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_BYTE, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, uint type, byte[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, int count, uint type, byte[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, count, type, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, short[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, (indices == null ? 0 : indices.Length), GL.GL_SHORT, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, uint type, short[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, int count, uint type, short[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, count, type, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, ushort[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_SHORT, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, uint type, ushort[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, int count, uint type, ushort[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, count, type, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, int[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, (indices == null ? 0 : indices.Length), GL.GL_INT, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, uint type, int[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, int count, uint type, int[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, count, type, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, uint[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_INT, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, uint type, uint[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, int count, uint type, uint[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, count, type, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, float[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, (indices == null ? 0 : indices.Length), GL.GL_FLOAT, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, uint type, float[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseInstance(uint mode, int count, uint type, float[] indices, int instancecount, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseInstance(mode, count, type, pIndices, instancecount, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, byte[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_BYTE, pIndices, instancecount, basevertex, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, uint type, byte[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, basevertex, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, byte[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, pIndices, instancecount, basevertex, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, short[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, (indices == null ? 0 : indices.Length), GL.GL_SHORT, pIndices, instancecount, basevertex, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, uint type, short[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, basevertex, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, short[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, pIndices, instancecount, basevertex, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, ushort[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_SHORT, pIndices, instancecount, basevertex, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, uint type, ushort[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, basevertex, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, ushort[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, pIndices, instancecount, basevertex, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, int[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, (indices == null ? 0 : indices.Length), GL.GL_INT, pIndices, instancecount, basevertex, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, uint type, int[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, basevertex, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, int[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, pIndices, instancecount, basevertex, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, uint[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_INT, pIndices, instancecount, basevertex, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, uint type, uint[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, basevertex, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, uint[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, pIndices, instancecount, basevertex, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, float[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, (indices == null ? 0 : indices.Length), GL.GL_FLOAT, pIndices, instancecount, basevertex, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, uint type, float[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, (indices == null ? 0 : indices.Length), type, pIndices, instancecount, basevertex, baseinstance);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance)
        /// </summary>
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, float[] indices, int instancecount, int basevertex, uint baseinstance) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, pIndices, instancecount, basevertex, baseinstance);
            }
        }


        #endregion Reuse commands from ARB_base_instance

        #region Reuse commands from ARB_internalformat_query

        /// <summary>
        /// [Overload] - void GetInternalformativ(uint target,uint internalformat,uint pname,int bufSize,int* ps)
        /// </summary>
        public unsafe static int GetInternalformativ(uint target, uint internalformat, uint pname, int bufSize) {
            int ps = 0;
            GLNative.glGetInternalformativ(target, internalformat, pname, bufSize, &ps);
            return ps;
        }


        #endregion Reuse commands from ARB_internalformat_query

        #region Reuse commands from ARB_shader_atomic_counters

        /// <summary>
        /// [Overload] - void GetActiveAtomicCounterBufferiv(uint program,uint bufferIndex,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname) {
            int ps = 0;
            GLNative.glGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, &ps);
            return ps;
        }


        #endregion Reuse commands from ARB_shader_atomic_counters

        #region Reuse commands from ARB_shader_image_load_store


        #endregion Reuse commands from ARB_shader_image_load_store

        #region Reuse commands from ARB_texture_storage


        #endregion Reuse commands from ARB_texture_storage

        #region Reuse commands from ARB_transform_feedback_instanced


        #endregion Reuse commands from ARB_transform_feedback_instanced

        #endregion GL_VERSION_4_2

        #region GL_VERSION_4_3


        #region Reuse commands from ARB_clear_buffer_object

        // [not processed] - void ClearBufferData(uint target,uint internalformat,uint format,uint type,void* data)
        // [not processed] - void ClearBufferSubData(uint target,uint internalformat,IntPtr offset,IntPtr size,uint format,uint type,void* data)

        #endregion Reuse commands from ARB_clear_buffer_object

        #region Reuse commands from ARB_compute_shader


        #endregion Reuse commands from ARB_compute_shader

        #region Reuse commands from ARB_copy_image


        #endregion Reuse commands from ARB_copy_image

        #region Reuse commands from ARB_framebuffer_no_attachments

        /// <summary>
        /// [Overload] - void GetFramebufferParameteriv(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetFramebufferParameteriv(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetFramebufferParameteriv(target, pname, &ps);
            return ps;
        }


        #endregion Reuse commands from ARB_framebuffer_no_attachments

        #region Reuse commands from ARB_internalformat_query2

        /// <summary>
        /// [Overload] - void GetInternalformati64v(uint target,uint internalformat,uint pname,int bufSize,UInt64* ps)
        /// </summary>
        public unsafe static UInt64 GetInternalformati64v(uint target, uint internalformat, uint pname, int bufSize) {
            UInt64 ps = 0;
            GLNative.glGetInternalformati64v(target, internalformat, pname, bufSize, &ps);
            return ps;
        }


        #endregion Reuse commands from ARB_internalformat_query2

        #region Reuse commands from ARB_invalidate_subdata

        // [not processed] - void InvalidateFramebuffer(uint target,int numAttachments,uint* attachments)
        // [not processed] - void InvalidateSubFramebuffer(uint target,int numAttachments,uint* attachments,int x,int y,int width,int height)

        #endregion Reuse commands from ARB_invalidate_subdata

        #region Reuse commands from ARB_multi_draw_indirect

        // [not processed] - void MultiDrawArraysIndirect(uint mode,void* indirect,int drawcount,int stride)
        // [not processed] - void MultiDrawElementsIndirect(uint mode,uint type,void* indirect,int drawcount,int stride)

        #endregion Reuse commands from ARB_multi_draw_indirect

        #region Reuse commands from ARB_program_interface_query

        /// <summary>
        /// [Overload] - void GetProgramInterfaceiv(uint program,uint programInterface,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetProgramInterfaceiv(uint program, uint programInterface, uint pname) {
            int ps = 0;
            GLNative.glGetProgramInterfaceiv(program, programInterface, pname, &ps);
            return ps;
        }

        // [not processed] - uint GetProgramResourceIndex(uint program,uint programInterface,byte* name)
        /// <summary>
        /// [Overload] - void GetProgramResourceName(uint program,uint programInterface,uint index,int bufSize,int* length,byte* name)
        /// </summary>
        public unsafe static string GetProgramResourceName(uint program, uint programInterface, uint index) {
            int length = 0;
            byte[] name = new byte[1024];
            fixed (byte* pName = &name[0]) {
                GLNative.glGetProgramResourceName(program, programInterface, index, name.Length, &length, pName);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(name, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetProgramResourceName(uint program,uint programInterface,uint index,int bufSize,int* length,byte* name)
        /// </summary>
        public unsafe static string GetProgramResourceName(uint program, uint programInterface, uint index, int bufSize) {
            int length = 0;
            byte[] name = new byte[bufSize];
            fixed (byte* pName = &name[0]) {
                GLNative.glGetProgramResourceName(program, programInterface, index, bufSize, &length, pName);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(name, 0, length);
            }
        }

        // [not processed] - void GetProgramResourceiv(uint program,uint programInterface,uint index,int propCount,uint* props,int bufSize,int* length,int* ps)
        // [not processed] - int GetProgramResourceLocation(uint program,uint programInterface,byte* name)
        // [not processed] - int GetProgramResourceLocationIndex(uint program,uint programInterface,byte* name)

        #endregion Reuse commands from ARB_program_interface_query

        #region Reuse commands from ARB_shader_storage_buffer_object


        #endregion Reuse commands from ARB_shader_storage_buffer_object

        #region Reuse commands from ARB_texture_buffer_range


        #endregion Reuse commands from ARB_texture_buffer_range

        #region Reuse commands from ARB_texture_storage_multisample


        #endregion Reuse commands from ARB_texture_storage_multisample

        #region Reuse commands from ARB_texture_view


        #endregion Reuse commands from ARB_texture_view

        #region Reuse commands from ARB_vertex_attrib_binding


        #endregion Reuse commands from ARB_vertex_attrib_binding

        #region Reuse commands from KHR_debug (includes ARB_debug_output commands promoted to KHR without suffixes)

        // [not processed] - void DebugMessageControl(uint source,uint type,uint severity,int count,uint* ids,bool enabled)
        /// <summary>
        /// [Overload] - void DebugMessageInsert(uint source,uint type,uint id,uint severity,int length,byte* message)
        /// </summary>
        public unsafe static void DebugMessageInsert(uint source, uint type, uint id, uint severity, string message) {
            byte[] byBuffer = Encoding.UTF8.GetBytes(message);
            fixed (byte* pMessage = &byBuffer[0]) {
                GLNative.glDebugMessageInsert(source, type, id, severity, message.Length, pMessage);
            }
        }

        // [not processed] - void DebugMessageCallback(GLDEBUGPROC callback,void* userParam)
        // [not processed] - uint GetDebugMessageLog(uint count,int bufSize,uint* sources,uint* types,uint* ids,uint* severities,int* lengths,byte* messageLog)
        /// <summary>
        /// [Overload] - void PushDebugGroup(uint source,uint id,int length,byte* message)
        /// </summary>
        public unsafe static void PushDebugGroup(uint source, uint id, string message) {
            byte[] byBuffer = Encoding.UTF8.GetBytes(message);
            fixed (byte* pMessage = &byBuffer[0]) {
                GLNative.glPushDebugGroup(source, id, message.Length, pMessage);
            }
        }

        /// <summary>
        /// [Overload] - void ObjectLabel(uint identifier,uint name,int length,byte* label)
        /// </summary>
        public unsafe static void ObjectLabel(uint identifier, uint name, string label) {
            byte[] byBuffer = Encoding.UTF8.GetBytes(label);
            fixed (byte* pLabel = &byBuffer[0]) {
                GLNative.glObjectLabel(identifier, name, label.Length, pLabel);
            }
        }

        /// <summary>
        /// [Overload] - void GetObjectLabel(uint identifier,uint name,int bufSize,int* length,byte* label)
        /// </summary>
        public unsafe static string GetObjectLabel(uint identifier, uint name) {
            int length = 0;
            byte[] label = new byte[1024];
            fixed (byte* pLabel = &label[0]) {
                GLNative.glGetObjectLabel(identifier, name, label.Length, &length, pLabel);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(label, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetObjectLabel(uint identifier,uint name,int bufSize,int* length,byte* label)
        /// </summary>
        public unsafe static string GetObjectLabel(uint identifier, uint name, int bufSize) {
            int length = 0;
            byte[] label = new byte[bufSize];
            fixed (byte* pLabel = &label[0]) {
                GLNative.glGetObjectLabel(identifier, name, bufSize, &length, pLabel);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(label, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void ObjectPtrLabel(void* ptr,int length,byte* label)
        /// </summary>
        public unsafe static void ObjectPtrLabel(IntPtr ptr, string label) {
            byte[] byBuffer = Encoding.UTF8.GetBytes(label);
            fixed (byte* pLabel = &byBuffer[0]) {
                GLNative.glObjectPtrLabel((void*)ptr, label.Length, pLabel);
            }
        }

        /// <summary>
        /// [Overload] - void GetObjectPtrLabel(void* ptr,int bufSize,int* length,byte* label)
        /// </summary>
        public unsafe static string GetObjectPtrLabel(IntPtr ptr) {
            int length = 0;
            byte[] label = new byte[1024];
            fixed (byte* pLabel = &label[0]) {
                GLNative.glGetObjectPtrLabel((void*)ptr, label.Length, &length, pLabel);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(label, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetObjectPtrLabel(void* ptr,int bufSize,int* length,byte* label)
        /// </summary>
        public unsafe static string GetObjectPtrLabel(IntPtr ptr, int bufSize) {
            int length = 0;
            byte[] label = new byte[bufSize];
            fixed (byte* pLabel = &label[0]) {
                GLNative.glGetObjectPtrLabel((void*)ptr, bufSize, &length, pLabel);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(label, 0, length);
            }
        }


        #endregion Reuse commands from KHR_debug (includes ARB_debug_output commands promoted to KHR without suffixes)

        #endregion GL_VERSION_4_3

        #region GL_VERSION_4_4


        #region Reuse GL_ARB_buffer_storage

        /// <summary>
        /// [Overload] - void BufferStorage(uint target,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void BufferStorage(uint target, byte[] data, uint flags) {
            long size = data.Length * sizeof(byte);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferStorage(target, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void BufferStorage(uint target,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void BufferStorage(uint target, long size, byte[] data, uint flags) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferStorage(target, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void BufferStorage(uint target,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void BufferStorage(uint target, short[] data, uint flags) {
            long size = data.Length * sizeof(short);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferStorage(target, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void BufferStorage(uint target,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void BufferStorage(uint target, long size, short[] data, uint flags) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferStorage(target, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void BufferStorage(uint target,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void BufferStorage(uint target, ushort[] data, uint flags) {
            long size = data.Length * sizeof(ushort);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferStorage(target, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void BufferStorage(uint target,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void BufferStorage(uint target, long size, ushort[] data, uint flags) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferStorage(target, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void BufferStorage(uint target,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void BufferStorage(uint target, int[] data, uint flags) {
            long size = data.Length * sizeof(int);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferStorage(target, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void BufferStorage(uint target,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void BufferStorage(uint target, long size, int[] data, uint flags) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferStorage(target, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void BufferStorage(uint target,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void BufferStorage(uint target, uint[] data, uint flags) {
            long size = data.Length * sizeof(uint);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferStorage(target, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void BufferStorage(uint target,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void BufferStorage(uint target, long size, uint[] data, uint flags) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferStorage(target, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void BufferStorage(uint target,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void BufferStorage(uint target, float[] data, uint flags) {
            long size = data.Length * sizeof(float);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferStorage(target, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void BufferStorage(uint target,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void BufferStorage(uint target, long size, float[] data, uint flags) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferStorage(target, (IntPtr)size, pData, flags);
            }
        }

        // [not processed] - void BufferStorage(uint target,IntPtr size,void* data,uint flags)

        #endregion Reuse GL_ARB_buffer_storage

        #region Reuse GL_ARB_clear_texture

        // [not processed] - void ClearTexImage(uint texture,int level,uint format,uint type,void* data)
        // [not processed] - void ClearTexSubImage(uint texture,int level,int xoffset,int yoffset,int zoffset,int width,int height,int depth,uint format,uint type,void* data)

        #endregion Reuse GL_ARB_clear_texture

        #region Reuse GL_ARB_multi_bind (none)

        // [not processed] - void BindBuffersBase(uint target,uint first,int count,uint* buffers)
        // [not processed] - void BindBuffersRange(uint target,uint first,int count,uint* buffers,IntPtr offsets,IntPtr sizes)
        // [not processed] - void BindTextures(uint first,int count,uint* textures)
        // [not processed] - void BindSamplers(uint first,int count,uint* samplers)
        // [not processed] - void BindImageTextures(uint first,int count,uint* textures)
        // [not processed] - void BindVertexBuffers(uint first,int count,uint* buffers,IntPtr offsets,int* strides)

        #endregion Reuse GL_ARB_multi_bind (none)

        #endregion GL_VERSION_4_4

        #region GL_VERSION_4_5


        #region Reuse GL_ARB_clip_control


        #endregion Reuse GL_ARB_clip_control

        #region Reuse GL_ARB_direct_state_access

        /// <summary>
        /// [Overload] - void CreateTransformFeedbacks(int n,uint* ids)
        /// </summary>
        public unsafe static uint CreateTransformFeedbacks() {
            uint ids = 0;
            GLNative.glCreateTransformFeedbacks(1, &ids);
            return ids;
        }

        /// <summary>
        /// [Overload] - void CreateTransformFeedbacks(int n,uint* ids)
        /// </summary>
        public unsafe static uint[] CreateTransformFeedbacks(int n) {
            uint[] ids = new uint[n];
            fixed (uint* pIds = &ids[0]) {
                GLNative.glCreateTransformFeedbacks(n, pIds);
            }
            return ids;
        }

        /// <summary>
        /// [Overload] - void GetTransformFeedbackiv(uint xfb,uint pname,int* param)
        /// </summary>
        public unsafe static int GetTransformFeedbackiv(uint xfb, uint pname) {
            int param = 0;
            GLNative.glGetTransformFeedbackiv(xfb, pname, &param);
            return param;
        }

        /// <summary>
        /// [Overload] - void GetTransformFeedbacki_v(uint xfb,uint pname,uint index,int* param)
        /// </summary>
        public unsafe static int GetTransformFeedbacki_v(uint xfb, uint pname, uint index) {
            int param = 0;
            GLNative.glGetTransformFeedbacki_v(xfb, pname, index, &param);
            return param;
        }

        /// <summary>
        /// [Overload] - void GetTransformFeedbacki64_v(uint xfb,uint pname,uint index,UInt64* param)
        /// </summary>
        public unsafe static UInt64 GetTransformFeedbacki64_v(uint xfb, uint pname, uint index) {
            UInt64 param = 0;
            GLNative.glGetTransformFeedbacki64_v(xfb, pname, index, &param);
            return param;
        }

        /// <summary>
        /// [Overload] - void CreateBuffers(int n,uint* buffers)
        /// </summary>
        public unsafe static uint CreateBuffers() {
            uint buffers = 0;
            GLNative.glCreateBuffers(1, &buffers);
            return buffers;
        }

        /// <summary>
        /// [Overload] - void CreateBuffers(int n,uint* buffers)
        /// </summary>
        public unsafe static uint[] CreateBuffers(int n) {
            uint[] buffers = new uint[n];
            fixed (uint* pBuffers = &buffers[0]) {
                GLNative.glCreateBuffers(n, pBuffers);
            }
            return buffers;
        }

        /// <summary>
        /// [Overload] - void NamedBufferStorage(uint buffer,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void NamedBufferStorage(uint buffer, byte[] data, uint flags) {
            long size = data.Length * sizeof(byte);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferStorage(buffer, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferStorage(uint buffer,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void NamedBufferStorage(uint buffer, long size, byte[] data, uint flags) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferStorage(buffer, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferStorage(uint buffer,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void NamedBufferStorage(uint buffer, short[] data, uint flags) {
            long size = data.Length * sizeof(short);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferStorage(buffer, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferStorage(uint buffer,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void NamedBufferStorage(uint buffer, long size, short[] data, uint flags) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferStorage(buffer, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferStorage(uint buffer,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void NamedBufferStorage(uint buffer, ushort[] data, uint flags) {
            long size = data.Length * sizeof(ushort);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferStorage(buffer, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferStorage(uint buffer,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void NamedBufferStorage(uint buffer, long size, ushort[] data, uint flags) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferStorage(buffer, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferStorage(uint buffer,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void NamedBufferStorage(uint buffer, int[] data, uint flags) {
            long size = data.Length * sizeof(int);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferStorage(buffer, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferStorage(uint buffer,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void NamedBufferStorage(uint buffer, long size, int[] data, uint flags) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferStorage(buffer, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferStorage(uint buffer,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void NamedBufferStorage(uint buffer, uint[] data, uint flags) {
            long size = data.Length * sizeof(uint);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferStorage(buffer, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferStorage(uint buffer,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void NamedBufferStorage(uint buffer, long size, uint[] data, uint flags) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferStorage(buffer, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferStorage(uint buffer,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void NamedBufferStorage(uint buffer, float[] data, uint flags) {
            long size = data.Length * sizeof(float);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferStorage(buffer, (IntPtr)size, pData, flags);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferStorage(uint buffer,IntPtr size,void* data,uint flags)
        /// </summary>
        public unsafe static void NamedBufferStorage(uint buffer, long size, float[] data, uint flags) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferStorage(buffer, (IntPtr)size, pData, flags);
            }
        }

        // [not processed] - void NamedBufferStorage(uint buffer,IntPtr size,void* data,uint flags)
        /// <summary>
        /// [Overload] - void NamedBufferData(uint buffer,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void NamedBufferData(uint buffer, byte[] data, uint usage) {
            long size = data.Length * sizeof(byte);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferData(buffer, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferData(uint buffer,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void NamedBufferData(uint buffer, long size, byte[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferData(buffer, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferData(uint buffer,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void NamedBufferData(uint buffer, short[] data, uint usage) {
            long size = data.Length * sizeof(short);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferData(buffer, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferData(uint buffer,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void NamedBufferData(uint buffer, long size, short[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferData(buffer, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferData(uint buffer,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void NamedBufferData(uint buffer, ushort[] data, uint usage) {
            long size = data.Length * sizeof(ushort);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferData(buffer, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferData(uint buffer,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void NamedBufferData(uint buffer, long size, ushort[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferData(buffer, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferData(uint buffer,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void NamedBufferData(uint buffer, int[] data, uint usage) {
            long size = data.Length * sizeof(int);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferData(buffer, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferData(uint buffer,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void NamedBufferData(uint buffer, long size, int[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferData(buffer, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferData(uint buffer,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void NamedBufferData(uint buffer, uint[] data, uint usage) {
            long size = data.Length * sizeof(uint);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferData(buffer, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferData(uint buffer,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void NamedBufferData(uint buffer, long size, uint[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferData(buffer, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferData(uint buffer,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void NamedBufferData(uint buffer, float[] data, uint usage) {
            long size = data.Length * sizeof(float);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferData(buffer, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferData(uint buffer,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void NamedBufferData(uint buffer, long size, float[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferData(buffer, (IntPtr)size, pData, usage);
            }
        }

        // [not processed] - void NamedBufferData(uint buffer,IntPtr size,void* data,uint usage)
        /// <summary>
        /// [Overload] - void NamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void NamedBufferSubData(uint buffer, IntPtr offset, byte[] data) {
            long size = data.Length * sizeof(byte);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void NamedBufferSubData(uint buffer, IntPtr offset, long size, byte[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void NamedBufferSubData(uint buffer, IntPtr offset, short[] data) {
            long size = data.Length * sizeof(short);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void NamedBufferSubData(uint buffer, IntPtr offset, long size, short[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void NamedBufferSubData(uint buffer, IntPtr offset, ushort[] data) {
            long size = data.Length * sizeof(ushort);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void NamedBufferSubData(uint buffer, IntPtr offset, long size, ushort[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void NamedBufferSubData(uint buffer, IntPtr offset, int[] data) {
            long size = data.Length * sizeof(int);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void NamedBufferSubData(uint buffer, IntPtr offset, long size, int[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void NamedBufferSubData(uint buffer, IntPtr offset, uint[] data) {
            long size = data.Length * sizeof(uint);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void NamedBufferSubData(uint buffer, IntPtr offset, long size, uint[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void NamedBufferSubData(uint buffer, IntPtr offset, float[] data) {
            long size = data.Length * sizeof(float);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void NamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void NamedBufferSubData(uint buffer, IntPtr offset, long size, float[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        // [not processed] - void NamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        // [not processed] - void ClearNamedBufferData(uint buffer,uint internalformat,uint format,uint type,void* data)
        // [not processed] - void ClearNamedBufferSubData(uint buffer,uint internalformat,IntPtr offset,IntPtr size,uint format,uint type,void* data)
        // [not processed] - void* MapNamedBuffer(uint buffer,uint access)
        // [not processed] - void* MapNamedBufferRange(uint buffer,IntPtr offset,IntPtr length,uint access)
        /// <summary>
        /// [Overload] - void GetNamedBufferParameteriv(uint buffer,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetNamedBufferParameteriv(uint buffer, uint pname) {
            int ps = 0;
            GLNative.glGetNamedBufferParameteriv(buffer, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetNamedBufferParameteri64v(uint buffer,uint pname,UInt64* ps)
        /// </summary>
        public unsafe static UInt64 GetNamedBufferParameteri64v(uint buffer, uint pname) {
            UInt64 ps = 0;
            GLNative.glGetNamedBufferParameteri64v(buffer, pname, &ps);
            return ps;
        }

        // [not processed] - void GetNamedBufferPointerv(uint buffer,uint pname,void** ps)
        /// <summary>
        /// [Overload] - void GetNamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetNamedBufferSubData(uint buffer, IntPtr offset, byte[] data) {
            long size = data.Length * sizeof(byte);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetNamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetNamedBufferSubData(uint buffer, IntPtr offset, long size, byte[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetNamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetNamedBufferSubData(uint buffer, IntPtr offset, short[] data) {
            long size = data.Length * sizeof(short);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetNamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetNamedBufferSubData(uint buffer, IntPtr offset, long size, short[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetNamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetNamedBufferSubData(uint buffer, IntPtr offset, ushort[] data) {
            long size = data.Length * sizeof(ushort);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetNamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetNamedBufferSubData(uint buffer, IntPtr offset, long size, ushort[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetNamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetNamedBufferSubData(uint buffer, IntPtr offset, int[] data) {
            long size = data.Length * sizeof(int);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetNamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetNamedBufferSubData(uint buffer, IntPtr offset, long size, int[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetNamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetNamedBufferSubData(uint buffer, IntPtr offset, uint[] data) {
            long size = data.Length * sizeof(uint);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetNamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetNamedBufferSubData(uint buffer, IntPtr offset, long size, uint[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetNamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetNamedBufferSubData(uint buffer, IntPtr offset, float[] data) {
            long size = data.Length * sizeof(float);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetNamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetNamedBufferSubData(uint buffer, IntPtr offset, long size, float[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetNamedBufferSubData(buffer, offset, (IntPtr)size, pData);
            }
        }

        // [ignore] - void GetNamedBufferSubData(uint buffer,IntPtr offset,IntPtr size,void* data)
        /// <summary>
        /// [Overload] - void CreateFramebuffers(int n,uint* framebuffers)
        /// </summary>
        public unsafe static uint CreateFramebuffers() {
            uint framebuffers = 0;
            GLNative.glCreateFramebuffers(1, &framebuffers);
            return framebuffers;
        }

        /// <summary>
        /// [Overload] - void CreateFramebuffers(int n,uint* framebuffers)
        /// </summary>
        public unsafe static uint[] CreateFramebuffers(int n) {
            uint[] framebuffers = new uint[n];
            fixed (uint* pFramebuffers = &framebuffers[0]) {
                GLNative.glCreateFramebuffers(n, pFramebuffers);
            }
            return framebuffers;
        }

        // [not processed] - void NamedFramebufferDrawBuffers(uint framebuffer,int n,uint* bufs)
        // [not processed] - void InvalidateNamedFramebufferData(uint framebuffer,int numAttachments,uint* attachments)
        // [not processed] - void InvalidateNamedFramebufferSubData(uint framebuffer,int numAttachments,uint* attachments,int x,int y,int width,int height)
        // [not processed] - void ClearNamedFramebufferiv(uint framebuffer,uint buffer,int drawbuffer,int* value)
        // [not processed] - void ClearNamedFramebufferuiv(uint framebuffer,uint buffer,int drawbuffer,uint* value)
        // [not processed] - void ClearNamedFramebufferfv(uint framebuffer,uint buffer,int drawbuffer,float* value)
        /// <summary>
        /// [Overload] - void GetNamedFramebufferParameteriv(uint framebuffer,uint pname,int* param)
        /// </summary>
        public unsafe static int GetNamedFramebufferParameteriv(uint framebuffer, uint pname) {
            int param = 0;
            GLNative.glGetNamedFramebufferParameteriv(framebuffer, pname, &param);
            return param;
        }

        /// <summary>
        /// [Overload] - void GetNamedFramebufferAttachmentParameteriv(uint framebuffer,uint attachment,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname) {
            int ps = 0;
            GLNative.glGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void CreateRenderbuffers(int n,uint* renderbuffers)
        /// </summary>
        public unsafe static uint CreateRenderbuffers() {
            uint renderbuffers = 0;
            GLNative.glCreateRenderbuffers(1, &renderbuffers);
            return renderbuffers;
        }

        /// <summary>
        /// [Overload] - void CreateRenderbuffers(int n,uint* renderbuffers)
        /// </summary>
        public unsafe static uint[] CreateRenderbuffers(int n) {
            uint[] renderbuffers = new uint[n];
            fixed (uint* pRenderbuffers = &renderbuffers[0]) {
                GLNative.glCreateRenderbuffers(n, pRenderbuffers);
            }
            return renderbuffers;
        }

        /// <summary>
        /// [Overload] - void GetNamedRenderbufferParameteriv(uint renderbuffer,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetNamedRenderbufferParameteriv(uint renderbuffer, uint pname) {
            int ps = 0;
            GLNative.glGetNamedRenderbufferParameteriv(renderbuffer, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void CreateTextures(uint target,int n,uint* textures)
        /// </summary>
        public unsafe static uint CreateTextures(uint target) {
            uint textures = 0;
            GLNative.glCreateTextures(target, 1, &textures);
            return textures;
        }

        /// <summary>
        /// [Overload] - void CreateTextures(uint target,int n,uint* textures)
        /// </summary>
        public unsafe static uint[] CreateTextures(uint target, int n) {
            uint[] textures = new uint[n];
            fixed (uint* pTextures = &textures[0]) {
                GLNative.glCreateTextures(target, n, pTextures);
            }
            return textures;
        }

        // [not processed] - void TextureSubImage1D(uint texture,int level,int xoffset,int width,uint format,uint type,void* pixels)
        // [not processed] - void TextureSubImage2D(uint texture,int level,int xoffset,int yoffset,int width,int height,uint format,uint type,void* pixels)
        // [not processed] - void TextureSubImage3D(uint texture,int level,int xoffset,int yoffset,int zoffset,int width,int height,int depth,uint format,uint type,void* pixels)
        // [not processed] - void CompressedTextureSubImage1D(uint texture,int level,int xoffset,int width,uint format,int imageSize,void* data)
        // [not processed] - void CompressedTextureSubImage2D(uint texture,int level,int xoffset,int yoffset,int width,int height,uint format,int imageSize,void* data)
        // [not processed] - void CompressedTextureSubImage3D(uint texture,int level,int xoffset,int yoffset,int zoffset,int width,int height,int depth,uint format,int imageSize,void* data)
        // [not processed] - void TextureParameterfv(uint texture,uint pname,float* ps)
        // [not processed] - void TextureParameterIiv(uint texture,uint pname,int* ps)
        // [not processed] - void TextureParameterIuiv(uint texture,uint pname,uint* ps)
        // [not processed] - void TextureParameteriv(uint texture,uint pname,int* ps)
        // [ignore] - void GetTextureImage(uint texture,int level,uint format,uint type,int bufSize,void* pixels)
        // [ignore] - void GetCompressedTextureImage(uint texture,int level,int bufSize,void* pixels)
        /// <summary>
        /// [Overload] - void GetTextureLevelParameterfv(uint texture,int level,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetTextureLevelParameterfv(uint texture, int level, uint pname) {
            float ps = 0;
            GLNative.glGetTextureLevelParameterfv(texture, level, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetTextureLevelParameteriv(uint texture,int level,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetTextureLevelParameteriv(uint texture, int level, uint pname) {
            int ps = 0;
            GLNative.glGetTextureLevelParameteriv(texture, level, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetTextureParameterfv(uint texture,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetTextureParameterfv(uint texture, uint pname) {
            float ps = 0;
            GLNative.glGetTextureParameterfv(texture, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetTextureParameterIiv(uint texture,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetTextureParameterIiv(uint texture, uint pname) {
            int ps = 0;
            GLNative.glGetTextureParameterIiv(texture, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetTextureParameterIuiv(uint texture,uint pname,uint* ps)
        /// </summary>
        public unsafe static uint GetTextureParameterIuiv(uint texture, uint pname) {
            uint ps = 0;
            GLNative.glGetTextureParameterIuiv(texture, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetTextureParameteriv(uint texture,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetTextureParameteriv(uint texture, uint pname) {
            int ps = 0;
            GLNative.glGetTextureParameteriv(texture, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void CreateVertexArrays(int n,uint* arrays)
        /// </summary>
        public unsafe static uint CreateVertexArrays() {
            uint arrays = 0;
            GLNative.glCreateVertexArrays(1, &arrays);
            return arrays;
        }

        /// <summary>
        /// [Overload] - void CreateVertexArrays(int n,uint* arrays)
        /// </summary>
        public unsafe static uint[] CreateVertexArrays(int n) {
            uint[] arrays = new uint[n];
            fixed (uint* pArrays = &arrays[0]) {
                GLNative.glCreateVertexArrays(n, pArrays);
            }
            return arrays;
        }

        // [not processed] - void VertexArrayVertexBuffers(uint vaobj,uint first,int count,uint* buffers,IntPtr offsets,int* strides)
        /// <summary>
        /// [Overload] - void GetVertexArrayiv(uint vaobj,uint pname,int* param)
        /// </summary>
        public unsafe static int GetVertexArrayiv(uint vaobj, uint pname) {
            int param = 0;
            GLNative.glGetVertexArrayiv(vaobj, pname, &param);
            return param;
        }

        /// <summary>
        /// [Overload] - void GetVertexArrayIndexediv(uint vaobj,uint index,uint pname,int* param)
        /// </summary>
        public unsafe static int GetVertexArrayIndexediv(uint vaobj, uint index, uint pname) {
            int param = 0;
            GLNative.glGetVertexArrayIndexediv(vaobj, index, pname, &param);
            return param;
        }

        /// <summary>
        /// [Overload] - void GetVertexArrayIndexed64iv(uint vaobj,uint index,uint pname,UInt64* param)
        /// </summary>
        public unsafe static UInt64 GetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname) {
            UInt64 param = 0;
            GLNative.glGetVertexArrayIndexed64iv(vaobj, index, pname, &param);
            return param;
        }

        /// <summary>
        /// [Overload] - void CreateSamplers(int n,uint* samplers)
        /// </summary>
        public unsafe static uint CreateSamplers() {
            uint samplers = 0;
            GLNative.glCreateSamplers(1, &samplers);
            return samplers;
        }

        /// <summary>
        /// [Overload] - void CreateSamplers(int n,uint* samplers)
        /// </summary>
        public unsafe static uint[] CreateSamplers(int n) {
            uint[] samplers = new uint[n];
            fixed (uint* pSamplers = &samplers[0]) {
                GLNative.glCreateSamplers(n, pSamplers);
            }
            return samplers;
        }

        /// <summary>
        /// [Overload] - void CreateProgramPipelines(int n,uint* pipelines)
        /// </summary>
        public unsafe static uint CreateProgramPipelines() {
            uint pipelines = 0;
            GLNative.glCreateProgramPipelines(1, &pipelines);
            return pipelines;
        }

        /// <summary>
        /// [Overload] - void CreateProgramPipelines(int n,uint* pipelines)
        /// </summary>
        public unsafe static uint[] CreateProgramPipelines(int n) {
            uint[] pipelines = new uint[n];
            fixed (uint* pPipelines = &pipelines[0]) {
                GLNative.glCreateProgramPipelines(n, pPipelines);
            }
            return pipelines;
        }

        /// <summary>
        /// [Overload] - void CreateQueries(uint target,int n,uint* ids)
        /// </summary>
        public unsafe static uint CreateQueries(uint target) {
            uint ids = 0;
            GLNative.glCreateQueries(target, 1, &ids);
            return ids;
        }

        /// <summary>
        /// [Overload] - void CreateQueries(uint target,int n,uint* ids)
        /// </summary>
        public unsafe static uint[] CreateQueries(uint target, int n) {
            uint[] ids = new uint[n];
            fixed (uint* pIds = &ids[0]) {
                GLNative.glCreateQueries(target, n, pIds);
            }
            return ids;
        }


        #endregion Reuse GL_ARB_direct_state_access

        #region Reuse GL_ARB_ES3_1_compatibility


        #endregion Reuse GL_ARB_ES3_1_compatibility

        #region Reuse GL_ARB_get_texture_sub_image

        // [ignore] - void GetTextureSubImage(uint texture,int level,int xoffset,int yoffset,int zoffset,int width,int height,int depth,uint format,uint type,int bufSize,void* pixels)
        // [ignore] - void GetCompressedTextureSubImage(uint texture,int level,int xoffset,int yoffset,int zoffset,int width,int height,int depth,int bufSize,void* pixels)

        #endregion Reuse GL_ARB_get_texture_sub_image

        #region Reuse GL_ARB_robustness

        // [ignore] - void GetnCompressedTexImage(uint target,int level,int bufSize,void* pixels)
        // [ignore] - void GetnTexImage(uint target,int level,uint format,uint type,int bufSize,void* pixels)
        /// <summary>
        /// [Overload] - void GetnUniformdv(uint program,int location,int bufSize,double* ps)
        /// </summary>
        public unsafe static double GetnUniformdv(uint program, int location, int bufSize) {
            double ps = 0;
            GLNative.glGetnUniformdv(program, location, bufSize, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetnUniformfv(uint program,int location,int bufSize,float* ps)
        /// </summary>
        public unsafe static float GetnUniformfv(uint program, int location, int bufSize) {
            float ps = 0;
            GLNative.glGetnUniformfv(program, location, bufSize, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetnUniformiv(uint program,int location,int bufSize,int* ps)
        /// </summary>
        public unsafe static int GetnUniformiv(uint program, int location, int bufSize) {
            int ps = 0;
            GLNative.glGetnUniformiv(program, location, bufSize, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetnUniformuiv(uint program,int location,int bufSize,uint* ps)
        /// </summary>
        public unsafe static uint GetnUniformuiv(uint program, int location, int bufSize) {
            uint ps = 0;
            GLNative.glGetnUniformuiv(program, location, bufSize, &ps);
            return ps;
        }

        // [not processed] - void ReadnPixels(int x,int y,int width,int height,uint format,uint type,int bufSize,void* data)

        #endregion Reuse GL_ARB_robustness

        #region Reuse GL_ARB_robustness

        /// <summary>
        /// [Overload] - void GetnMapdv(uint target,uint query,int bufSize,double* v)
        /// </summary>
        public unsafe static double GetnMapdv(uint target, uint query, int bufSize) {
            double v = 0;
            GLNative.glGetnMapdv(target, query, bufSize, &v);
            return v;
        }

        /// <summary>
        /// [Overload] - void GetnMapfv(uint target,uint query,int bufSize,float* v)
        /// </summary>
        public unsafe static float GetnMapfv(uint target, uint query, int bufSize) {
            float v = 0;
            GLNative.glGetnMapfv(target, query, bufSize, &v);
            return v;
        }

        /// <summary>
        /// [Overload] - void GetnMapiv(uint target,uint query,int bufSize,int* v)
        /// </summary>
        public unsafe static int GetnMapiv(uint target, uint query, int bufSize) {
            int v = 0;
            GLNative.glGetnMapiv(target, query, bufSize, &v);
            return v;
        }

        /// <summary>
        /// [Overload] - void GetnPixelMapfv(uint map,int bufSize,float* values)
        /// </summary>
        public unsafe static float GetnPixelMapfv(uint map, int bufSize) {
            float values = 0;
            GLNative.glGetnPixelMapfv(map, bufSize, &values);
            return values;
        }

        /// <summary>
        /// [Overload] - void GetnPixelMapuiv(uint map,int bufSize,uint* values)
        /// </summary>
        public unsafe static uint GetnPixelMapuiv(uint map, int bufSize) {
            uint values = 0;
            GLNative.glGetnPixelMapuiv(map, bufSize, &values);
            return values;
        }

        /// <summary>
        /// [Overload] - void GetnPixelMapusv(uint map,int bufSize,ushort* values)
        /// </summary>
        public unsafe static ushort GetnPixelMapusv(uint map, int bufSize) {
            ushort values = 0;
            GLNative.glGetnPixelMapusv(map, bufSize, &values);
            return values;
        }

        // [ignore] - void GetnPolygonStipple(int bufSize,byte* pattern)
        // [ignore] - void GetnColorTable(uint target,uint format,uint type,int bufSize,void* table)
        // [ignore] - void GetnConvolutionFilter(uint target,uint format,uint type,int bufSize,void* image)
        // [not processed] - void GetnSeparableFilter(uint target,uint format,uint type,int rowBufSize,void* row,int columnBufSize,void* column,void* span)
        // [ignore] - void GetnHistogram(uint target,bool reset,uint format,uint type,int bufSize,void* values)
        // [ignore] - void GetnMinmax(uint target,bool reset,uint format,uint type,int bufSize,void* values)

        #endregion Reuse GL_ARB_robustness

        #region Reuse GL_ARB_texture_barrier


        #endregion Reuse GL_ARB_texture_barrier

        #endregion GL_VERSION_4_5

        #region GL_VERSION_4_6


        #region Reuse GL_ARB_gl_spirv

        // [not processed] - void SpecializeShader(uint shader,byte* pEntryPoint,uint numSpecializationConstants,uint* pConstantIndex,uint* pConstantValue)

        #endregion Reuse GL_ARB_gl_spirv

        #region Reuse GL_ARB_indirect_parameters

        // [not processed] - void MultiDrawArraysIndirectCount(uint mode,void* indirect,IntPtr drawcount,int maxdrawcount,int stride)
        // [not processed] - void MultiDrawElementsIndirectCount(uint mode,uint type,void* indirect,IntPtr drawcount,int maxdrawcount,int stride)

        #endregion Reuse GL_ARB_indirect_parameters

        #region Reuse GL_ARB_polygon_offset_clamp


        #endregion Reuse GL_ARB_polygon_offset_clamp

        #endregion GL_VERSION_4_6

        #region GL_3DFX_tbuffer


        #endregion GL_3DFX_tbuffer

        #region GL_AMD_debug_output

        // [not processed] - void DebugMessageEnableAMD(uint category,uint severity,int count,uint* ids,bool enabled)
        /// <summary>
        /// [Overload] - void DebugMessageInsertAMD(uint category,uint severity,uint id,int length,byte* buf)
        /// </summary>
        public unsafe static void DebugMessageInsertAMD(uint category, uint severity, uint id, string buf) {
            byte[] byBuffer = Encoding.UTF8.GetBytes(buf);
            fixed (byte* pBuf = &byBuffer[0]) {
                GLNative.glDebugMessageInsertAMD(category, severity, id, buf.Length, pBuf);
            }
        }

        // [not processed] - void DebugMessageCallbackAMD(GLDEBUGPROCAMD callback,void* userParam)
        // [not processed] - uint GetDebugMessageLogAMD(uint count,int bufSize,uint* categories,uint* severities,uint* ids,int* lengths,byte* message)

        #endregion GL_AMD_debug_output

        #region GL_AMD_draw_buffers_blend


        #endregion GL_AMD_draw_buffers_blend

        #region GL_AMD_framebuffer_multisample_advanced


        #endregion GL_AMD_framebuffer_multisample_advanced

        #region GL_AMD_framebuffer_sample_positions

        // [not processed] - void FramebufferSamplePositionsfvAMD(uint target,uint numsamples,uint pixelindex,float* values)
        // [not processed] - void NamedFramebufferSamplePositionsfvAMD(uint framebuffer,uint numsamples,uint pixelindex,float* values)
        /// <summary>
        /// [Overload] - void GetFramebufferParameterfvAMD(uint target,uint pname,uint numsamples,uint pixelindex,int size,float* values)
        /// </summary>
        public unsafe static float GetFramebufferParameterfvAMD(uint target, uint pname, uint numsamples, uint pixelindex, int size) {
            float values = 0;
            GLNative.glGetFramebufferParameterfvAMD(target, pname, numsamples, pixelindex, size, &values);
            return values;
        }

        /// <summary>
        /// [Overload] - void GetNamedFramebufferParameterfvAMD(uint framebuffer,uint pname,uint numsamples,uint pixelindex,int size,float* values)
        /// </summary>
        public unsafe static float GetNamedFramebufferParameterfvAMD(uint framebuffer, uint pname, uint numsamples, uint pixelindex, int size) {
            float values = 0;
            GLNative.glGetNamedFramebufferParameterfvAMD(framebuffer, pname, numsamples, pixelindex, size, &values);
            return values;
        }


        #endregion GL_AMD_framebuffer_sample_positions

        #region GL_AMD_gpu_shader_int64

        // [not processed] - void Uniform1i64vNV(int location,int count,Int64* value)
        // [not processed] - void Uniform2i64vNV(int location,int count,Int64* value)
        // [not processed] - void Uniform3i64vNV(int location,int count,Int64* value)
        // [not processed] - void Uniform4i64vNV(int location,int count,Int64* value)
        // [not processed] - void Uniform1ui64vNV(int location,int count,UInt64* value)
        // [not processed] - void Uniform2ui64vNV(int location,int count,UInt64* value)
        // [not processed] - void Uniform3ui64vNV(int location,int count,UInt64* value)
        // [not processed] - void Uniform4ui64vNV(int location,int count,UInt64* value)
        /// <summary>
        /// [Overload] - void GetUniformi64vNV(uint program,int location,Int64* ps)
        /// </summary>
        public unsafe static Int64 GetUniformi64vNV(uint program, int location) {
            Int64 ps = 0;
            GLNative.glGetUniformi64vNV(program, location, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetUniformui64vNV(uint program,int location,UInt64* ps)
        /// </summary>
        public unsafe static UInt64 GetUniformui64vNV(uint program, int location) {
            UInt64 ps = 0;
            GLNative.glGetUniformui64vNV(program, location, &ps);
            return ps;
        }

        // [not processed] - void ProgramUniform1i64vNV(uint program,int location,int count,Int64* value)
        // [not processed] - void ProgramUniform2i64vNV(uint program,int location,int count,Int64* value)
        // [not processed] - void ProgramUniform3i64vNV(uint program,int location,int count,Int64* value)
        // [not processed] - void ProgramUniform4i64vNV(uint program,int location,int count,Int64* value)
        // [not processed] - void ProgramUniform1ui64vNV(uint program,int location,int count,UInt64* value)
        // [not processed] - void ProgramUniform2ui64vNV(uint program,int location,int count,UInt64* value)
        // [not processed] - void ProgramUniform3ui64vNV(uint program,int location,int count,UInt64* value)
        // [not processed] - void ProgramUniform4ui64vNV(uint program,int location,int count,UInt64* value)

        #endregion GL_AMD_gpu_shader_int64

        #region GL_AMD_interleaved_elements


        #endregion GL_AMD_interleaved_elements

        #region GL_AMD_multi_draw_indirect

        // [not processed] - void MultiDrawArraysIndirectAMD(uint mode,void* indirect,int primcount,int stride)
        // [not processed] - void MultiDrawElementsIndirectAMD(uint mode,uint type,void* indirect,int primcount,int stride)

        #endregion GL_AMD_multi_draw_indirect

        #region GL_AMD_name_gen_delete

        /// <summary>
        /// [Overload] - void GenNamesAMD(uint identifier,uint num,uint* names)
        /// </summary>
        public unsafe static uint GenNamesAMD(uint identifier) {
            uint names = 0;
            GLNative.glGenNamesAMD(identifier, 1, &names);
            return names;
        }
        /// <summary>
        /// [Overload] - void GenNamesAMD(uint identifier,uint num,uint* names)
        /// </summary>
        public unsafe static uint[] GenNamesAMD(uint identifier, uint num) {
            uint[] names = new uint[num];
            fixed (uint* pNames = &names[0]) {
                GLNative.glGenNamesAMD(identifier, num, pNames);
            }
            return names;
        }
        /// <summary>
        /// [Overload] - void DeleteNamesAMD(uint identifier,uint num,uint* names)
        /// </summary>
        public unsafe static void DeleteNamesAMD(uint identifier, uint[] names) {
            fixed (uint* pNames = &names[0]) {
                GLNative.glDeleteNamesAMD(identifier, (uint)names.Length, pNames);
            }
        }
        /// <summary>
        /// [Overload] - void DeleteNamesAMD(uint identifier,uint num,uint* names)
        /// </summary>
        public unsafe static void DeleteNamesAMD(uint identifier, uint[] names, uint num) {
            fixed (uint* pNames = &names[0]) {
                GLNative.glDeleteNamesAMD(identifier, num, pNames);
            }
        }

        #endregion GL_AMD_name_gen_delete

        #region GL_AMD_occlusion_query_event


        #endregion GL_AMD_occlusion_query_event

        #region GL_AMD_performance_monitor

        // [not processed] - void GetPerfMonitorGroupsAMD(int* numGroups,int groupsSize,uint* groups)
        // [not processed] - void GetPerfMonitorCountersAMD(uint group,int* numCounters,int* maxActiveCounters,int counterSize,uint* counters)
        /// <summary>
        /// [Overload] - void GetPerfMonitorGroupStringAMD(uint group,int bufSize,int* length,byte* groupString)
        /// </summary>
        public unsafe static string GetPerfMonitorGroupStringAMD(uint group) {
            int length = 0;
            byte[] groupString = new byte[1024];
            fixed (byte* pGroupString = &groupString[0]) {
                GLNative.glGetPerfMonitorGroupStringAMD(group, groupString.Length, &length, pGroupString);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(groupString, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetPerfMonitorGroupStringAMD(uint group,int bufSize,int* length,byte* groupString)
        /// </summary>
        public unsafe static string GetPerfMonitorGroupStringAMD(uint group, int bufSize) {
            int length = 0;
            byte[] groupString = new byte[bufSize];
            fixed (byte* pGroupString = &groupString[0]) {
                GLNative.glGetPerfMonitorGroupStringAMD(group, bufSize, &length, pGroupString);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(groupString, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetPerfMonitorCounterStringAMD(uint group,uint counter,int bufSize,int* length,byte* counterString)
        /// </summary>
        public unsafe static string GetPerfMonitorCounterStringAMD(uint group, uint counter) {
            int length = 0;
            byte[] counterString = new byte[1024];
            fixed (byte* pCounterString = &counterString[0]) {
                GLNative.glGetPerfMonitorCounterStringAMD(group, counter, counterString.Length, &length, pCounterString);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(counterString, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetPerfMonitorCounterStringAMD(uint group,uint counter,int bufSize,int* length,byte* counterString)
        /// </summary>
        public unsafe static string GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize) {
            int length = 0;
            byte[] counterString = new byte[bufSize];
            fixed (byte* pCounterString = &counterString[0]) {
                GLNative.glGetPerfMonitorCounterStringAMD(group, counter, bufSize, &length, pCounterString);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(counterString, 0, length);
            }
        }

        // [ignore] - void GetPerfMonitorCounterInfoAMD(uint group,uint counter,uint pname,void* data)
        /// <summary>
        /// [Overload] - void GenPerfMonitorsAMD(int n,uint* monitors)
        /// </summary>
        public unsafe static uint GenPerfMonitorsAMD() {
            uint monitors = 0;
            GLNative.glGenPerfMonitorsAMD(1, &monitors);
            return monitors;
        }

        /// <summary>
        /// [Overload] - void GenPerfMonitorsAMD(int n,uint* monitors)
        /// </summary>
        public unsafe static uint[] GenPerfMonitorsAMD(int n) {
            uint[] monitors = new uint[n];
            fixed (uint* pMonitors = &monitors[0]) {
                GLNative.glGenPerfMonitorsAMD(n, pMonitors);
            }
            return monitors;
        }

        /// <summary>
        /// [Overload] - void DeletePerfMonitorsAMD(int n,uint* monitors)
        /// </summary>
        public unsafe static void DeletePerfMonitorsAMD(uint[] monitors) {
            fixed (uint* pMonitors = &monitors[0]) {
                GLNative.glDeletePerfMonitorsAMD(monitors.Length, pMonitors);
            }
        }

        /// <summary>
        /// [Overload] - void DeletePerfMonitorsAMD(int n,uint* monitors)
        /// </summary>
        public unsafe static void DeletePerfMonitorsAMD(uint[] monitors, int n) {
            fixed (uint* pMonitors = &monitors[0]) {
                GLNative.glDeletePerfMonitorsAMD(n, pMonitors);
            }
        }

        // [not processed] - void SelectPerfMonitorCountersAMD(uint monitor,bool enable,uint group,int numCounters,uint* counterList)
        // [not processed] - void GetPerfMonitorCounterDataAMD(uint monitor,uint pname,int dataSize,uint* data,int* bytesWritten)

        #endregion GL_AMD_performance_monitor

        #region GL_AMD_sample_positions

        // [not processed] - void SetMultisamplefvAMD(uint pname,uint index,float* val)

        #endregion GL_AMD_sample_positions

        #region GL_AMD_sparse_texture


        #endregion GL_AMD_sparse_texture

        #region GL_AMD_stencil_operation_extended


        #endregion GL_AMD_stencil_operation_extended

        #region GL_AMD_vertex_shader_tessellator


        #endregion GL_AMD_vertex_shader_tessellator

        #region GL_APPLE_element_array

        // [not processed] - void ElementPointerAPPLE(uint type,void* pointer)
        // [not processed] - void MultiDrawElementArrayAPPLE(uint mode,int* first,int* count,int primcount)
        // [not processed] - void MultiDrawRangeElementArrayAPPLE(uint mode,uint start,uint end,int* first,int* count,int primcount)

        #endregion GL_APPLE_element_array

        #region GL_APPLE_fence

        /// <summary>
        /// [Overload] - void GenFencesAPPLE(int n,uint* fences)
        /// </summary>
        public unsafe static uint GenFencesAPPLE() {
            uint fences = 0;
            GLNative.glGenFencesAPPLE(1, &fences);
            return fences;
        }

        /// <summary>
        /// [Overload] - void GenFencesAPPLE(int n,uint* fences)
        /// </summary>
        public unsafe static uint[] GenFencesAPPLE(int n) {
            uint[] fences = new uint[n];
            fixed (uint* pFences = &fences[0]) {
                GLNative.glGenFencesAPPLE(n, pFences);
            }
            return fences;
        }

        /// <summary>
        /// [Overload] - void DeleteFencesAPPLE(int n,uint* fences)
        /// </summary>
        public unsafe static void DeleteFencesAPPLE(uint[] fences) {
            fixed (uint* pFences = &fences[0]) {
                GLNative.glDeleteFencesAPPLE(fences.Length, pFences);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteFencesAPPLE(int n,uint* fences)
        /// </summary>
        public unsafe static void DeleteFencesAPPLE(uint[] fences, int n) {
            fixed (uint* pFences = &fences[0]) {
                GLNative.glDeleteFencesAPPLE(n, pFences);
            }
        }


        #endregion GL_APPLE_fence

        #region GL_APPLE_flush_buffer_range


        #endregion GL_APPLE_flush_buffer_range

        #region GL_APPLE_object_purgeable

        /// <summary>
        /// [Overload] - void GetObjectParameterivAPPLE(uint objectType,uint name,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetObjectParameterivAPPLE(uint objectType, uint name, uint pname) {
            int ps = 0;
            GLNative.glGetObjectParameterivAPPLE(objectType, name, pname, &ps);
            return ps;
        }


        #endregion GL_APPLE_object_purgeable

        #region GL_APPLE_texture_range

        // [not processed] - void TextureRangeAPPLE(uint target,int length,void* pointer)
        // [not processed] - void GetTexParameterPointervAPPLE(uint target,uint pname,void** ps)

        #endregion GL_APPLE_texture_range

        #region GL_APPLE_vertex_array_object

        /// <summary>
        /// [Overload] - void DeleteVertexArraysAPPLE(int n,uint* arrays)
        /// </summary>
        public unsafe static void DeleteVertexArraysAPPLE(uint[] arrays) {
            fixed (uint* pArrays = &arrays[0]) {
                GLNative.glDeleteVertexArraysAPPLE(arrays.Length, pArrays);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteVertexArraysAPPLE(int n,uint* arrays)
        /// </summary>
        public unsafe static void DeleteVertexArraysAPPLE(uint[] arrays, int n) {
            fixed (uint* pArrays = &arrays[0]) {
                GLNative.glDeleteVertexArraysAPPLE(n, pArrays);
            }
        }

        /// <summary>
        /// [Overload] - void GenVertexArraysAPPLE(int n,uint* arrays)
        /// </summary>
        public unsafe static uint GenVertexArraysAPPLE() {
            uint arrays = 0;
            GLNative.glGenVertexArraysAPPLE(1, &arrays);
            return arrays;
        }

        /// <summary>
        /// [Overload] - void GenVertexArraysAPPLE(int n,uint* arrays)
        /// </summary>
        public unsafe static uint[] GenVertexArraysAPPLE(int n) {
            uint[] arrays = new uint[n];
            fixed (uint* pArrays = &arrays[0]) {
                GLNative.glGenVertexArraysAPPLE(n, pArrays);
            }
            return arrays;
        }


        #endregion GL_APPLE_vertex_array_object

        #region GL_APPLE_vertex_array_range

        // [not processed] - void VertexArrayRangeAPPLE(int length,void* pointer)
        // [not processed] - void FlushVertexArrayRangeAPPLE(int length,void* pointer)

        #endregion GL_APPLE_vertex_array_range

        #region GL_APPLE_vertex_program_evaluators

        // [not processed] - void MapVertexAttrib1dAPPLE(uint index,uint size,double u1,double u2,int stride,int order,double* points)
        // [not processed] - void MapVertexAttrib1fAPPLE(uint index,uint size,float u1,float u2,int stride,int order,float* points)
        // [not processed] - void MapVertexAttrib2dAPPLE(uint index,uint size,double u1,double u2,int ustride,int uorder,double v1,double v2,int vstride,int vorder,double* points)
        // [not processed] - void MapVertexAttrib2fAPPLE(uint index,uint size,float u1,float u2,int ustride,int uorder,float v1,float v2,int vstride,int vorder,float* points)

        #endregion GL_APPLE_vertex_program_evaluators

        #region GL_ARB_ES2_compatibility


        #endregion GL_ARB_ES2_compatibility

        #region GL_ARB_ES3_1_compatibility


        #endregion GL_ARB_ES3_1_compatibility

        #region GL_ARB_ES3_2_compatibility


        #endregion GL_ARB_ES3_2_compatibility

        #region GL_ARB_base_instance


        #endregion GL_ARB_base_instance

        #region GL_ARB_bindless_texture

        // [not processed] - void UniformHandleui64vARB(int location,int count,UInt64* value)
        // [not processed] - void ProgramUniformHandleui64vARB(uint program,int location,int count,UInt64* values)
        // [not processed] - void VertexAttribL1ui64vARB(uint index,UInt64* v)
        /// <summary>
        /// [Overload] - void GetVertexAttribLui64vARB(uint index,uint pname,UInt64* ps)
        /// </summary>
        public unsafe static UInt64 GetVertexAttribLui64vARB(uint index, uint pname) {
            UInt64 ps = 0;
            GLNative.glGetVertexAttribLui64vARB(index, pname, &ps);
            return ps;
        }


        #endregion GL_ARB_bindless_texture

        #region GL_ARB_blend_func_extended


        #endregion GL_ARB_blend_func_extended

        #region GL_ARB_buffer_storage


        #endregion GL_ARB_buffer_storage

        #region GL_ARB_cl_event

        // [not processed] - IntPtr CreateSyncFromCLeventARB(IntPtr context,IntPtr e,uint flags)

        #endregion GL_ARB_cl_event

        #region GL_ARB_clear_buffer_object


        #endregion GL_ARB_clear_buffer_object

        #region GL_ARB_clear_texture


        #endregion GL_ARB_clear_texture

        #region GL_ARB_clip_control


        #endregion GL_ARB_clip_control

        #region GL_ARB_color_buffer_float


        #endregion GL_ARB_color_buffer_float

        #region GL_ARB_compute_shader


        #endregion GL_ARB_compute_shader

        #region GL_ARB_compute_variable_group_size


        #endregion GL_ARB_compute_variable_group_size

        #region GL_ARB_copy_buffer


        #endregion GL_ARB_copy_buffer

        #region GL_ARB_copy_image


        #endregion GL_ARB_copy_image

        #region GL_ARB_debug_output

        // [not processed] - void DebugMessageControlARB(uint source,uint type,uint severity,int count,uint* ids,bool enabled)
        /// <summary>
        /// [Overload] - void DebugMessageInsertARB(uint source,uint type,uint id,uint severity,int length,byte* buf)
        /// </summary>
        public unsafe static void DebugMessageInsertARB(uint source, uint type, uint id, uint severity, string buf) {
            byte[] byBuffer = Encoding.UTF8.GetBytes(buf);
            fixed (byte* pBuf = &byBuffer[0]) {
                GLNative.glDebugMessageInsertARB(source, type, id, severity, buf.Length, pBuf);
            }
        }

        // [not processed] - void DebugMessageCallbackARB(GLDEBUGPROCARB callback,void* userParam)
        // [not processed] - uint GetDebugMessageLogARB(uint count,int bufSize,uint* sources,uint* types,uint* ids,uint* severities,int* lengths,byte* messageLog)

        #endregion GL_ARB_debug_output

        #region GL_ARB_draw_buffers

        // [not processed] - void DrawBuffersARB(int n,uint* bufs)

        #endregion GL_ARB_draw_buffers

        #region GL_ARB_draw_buffers_blend


        #endregion GL_ARB_draw_buffers_blend

        #region GL_ARB_draw_elements_base_vertex


        #endregion GL_ARB_draw_elements_base_vertex

        #region GL_ARB_draw_indirect


        #endregion GL_ARB_draw_indirect

        #region GL_ARB_draw_instanced

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, byte[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_BYTE, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, uint type, byte[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, (indices == null ? 0 : indices.Length), type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, int count, uint type, byte[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, count, type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, short[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, (indices == null ? 0 : indices.Length), GL.GL_SHORT, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, uint type, short[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, (indices == null ? 0 : indices.Length), type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, int count, uint type, short[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, count, type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, ushort[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_SHORT, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, uint type, ushort[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, (indices == null ? 0 : indices.Length), type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, int count, uint type, ushort[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, count, type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, int[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, (indices == null ? 0 : indices.Length), GL.GL_INT, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, uint type, int[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, (indices == null ? 0 : indices.Length), type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, int count, uint type, int[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, count, type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, uint[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_INT, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, uint type, uint[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, (indices == null ? 0 : indices.Length), type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, int count, uint type, uint[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, count, type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, float[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, (indices == null ? 0 : indices.Length), GL.GL_FLOAT, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, uint type, float[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, (indices == null ? 0 : indices.Length), type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedARB(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedARB(uint mode, int count, uint type, float[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedARB(mode, count, type, pIndices, primcount);
            }
        }


        #endregion GL_ARB_draw_instanced

        #region GL_ARB_framebuffer_no_attachments


        #endregion GL_ARB_framebuffer_no_attachments

        #region GL_ARB_framebuffer_object


        #endregion GL_ARB_framebuffer_object

        #region GL_ARB_geometry_shader4


        #endregion GL_ARB_geometry_shader4

        #region GL_ARB_get_program_binary


        #endregion GL_ARB_get_program_binary

        #region GL_ARB_get_texture_sub_image


        #endregion GL_ARB_get_texture_sub_image

        #region GL_ARB_gl_spirv

        // [not processed] - void SpecializeShaderARB(uint shader,byte* pEntryPoint,uint numSpecializationConstants,uint* pConstantIndex,uint* pConstantValue)

        #endregion GL_ARB_gl_spirv

        #region GL_ARB_gpu_shader_fp64


        #endregion GL_ARB_gpu_shader_fp64

        #region GL_ARB_gpu_shader_int64

        // [not processed] - void Uniform1i64vARB(int location,int count,Int64* value)
        // [not processed] - void Uniform2i64vARB(int location,int count,Int64* value)
        // [not processed] - void Uniform3i64vARB(int location,int count,Int64* value)
        // [not processed] - void Uniform4i64vARB(int location,int count,Int64* value)
        // [not processed] - void Uniform1ui64vARB(int location,int count,UInt64* value)
        // [not processed] - void Uniform2ui64vARB(int location,int count,UInt64* value)
        // [not processed] - void Uniform3ui64vARB(int location,int count,UInt64* value)
        // [not processed] - void Uniform4ui64vARB(int location,int count,UInt64* value)
        /// <summary>
        /// [Overload] - void GetUniformi64vARB(uint program,int location,UInt64* ps)
        /// </summary>
        public unsafe static UInt64 GetUniformi64vARB(uint program, int location) {
            UInt64 ps = 0;
            GLNative.glGetUniformi64vARB(program, location, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetUniformui64vARB(uint program,int location,UInt64* ps)
        /// </summary>
        public unsafe static UInt64 GetUniformui64vARB(uint program, int location) {
            UInt64 ps = 0;
            GLNative.glGetUniformui64vARB(program, location, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetnUniformi64vARB(uint program,int location,int bufSize,UInt64* ps)
        /// </summary>
        public unsafe static UInt64 GetnUniformi64vARB(uint program, int location, int bufSize) {
            UInt64 ps = 0;
            GLNative.glGetnUniformi64vARB(program, location, bufSize, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetnUniformui64vARB(uint program,int location,int bufSize,UInt64* ps)
        /// </summary>
        public unsafe static UInt64 GetnUniformui64vARB(uint program, int location, int bufSize) {
            UInt64 ps = 0;
            GLNative.glGetnUniformui64vARB(program, location, bufSize, &ps);
            return ps;
        }

        // [not processed] - void ProgramUniform1i64vARB(uint program,int location,int count,Int64* value)
        // [not processed] - void ProgramUniform2i64vARB(uint program,int location,int count,Int64* value)
        // [not processed] - void ProgramUniform3i64vARB(uint program,int location,int count,Int64* value)
        // [not processed] - void ProgramUniform4i64vARB(uint program,int location,int count,Int64* value)
        // [not processed] - void ProgramUniform1ui64vARB(uint program,int location,int count,UInt64* value)
        // [not processed] - void ProgramUniform2ui64vARB(uint program,int location,int count,UInt64* value)
        // [not processed] - void ProgramUniform3ui64vARB(uint program,int location,int count,UInt64* value)
        // [not processed] - void ProgramUniform4ui64vARB(uint program,int location,int count,UInt64* value)

        #endregion GL_ARB_gpu_shader_int64

        #region GL_ARB_imaging

        // [not processed] - void ColorTable(uint target,uint internalformat,int width,uint format,uint type,void* data)
        // [not processed] - void ColorTableParameterfv(uint target,uint pname,float* ps)
        // [not processed] - void ColorTableParameteriv(uint target,uint pname,int* ps)
        // [ignore] - void GetColorTable(uint target,uint format,uint type,void* table)
        /// <summary>
        /// [Overload] - void GetColorTableParameterfv(uint target,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetColorTableParameterfv(uint target, uint pname) {
            float ps = 0;
            GLNative.glGetColorTableParameterfv(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetColorTableParameteriv(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetColorTableParameteriv(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetColorTableParameteriv(target, pname, &ps);
            return ps;
        }

        // [not processed] - void ColorSubTable(uint target,int start,int count,uint format,uint type,void* data)
        // [not processed] - void ConvolutionFilter1D(uint target,uint internalformat,int width,uint format,uint type,void* data)
        // [not processed] - void ConvolutionFilter2D(uint target,uint internalformat,int width,int height,uint format,uint type,void* data)
        // [not processed] - void ConvolutionParameterfv(uint target,uint pname,float* ps)
        // [not processed] - void ConvolutionParameteriv(uint target,uint pname,int* ps)
        // [ignore] - void GetConvolutionFilter(uint target,uint format,uint type,void* image)
        /// <summary>
        /// [Overload] - void GetConvolutionParameterfv(uint target,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetConvolutionParameterfv(uint target, uint pname) {
            float ps = 0;
            GLNative.glGetConvolutionParameterfv(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetConvolutionParameteriv(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetConvolutionParameteriv(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetConvolutionParameteriv(target, pname, &ps);
            return ps;
        }

        // [not processed] - void GetSeparableFilter(uint target,uint format,uint type,void* row,void* column,void* span)
        // [not processed] - void SeparableFilter2D(uint target,uint internalformat,int width,int height,uint format,uint type,void* row,void* column)
        // [ignore] - void GetHistogram(uint target,bool reset,uint format,uint type,void* values)
        /// <summary>
        /// [Overload] - void GetHistogramParameterfv(uint target,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetHistogramParameterfv(uint target, uint pname) {
            float ps = 0;
            GLNative.glGetHistogramParameterfv(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetHistogramParameteriv(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetHistogramParameteriv(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetHistogramParameteriv(target, pname, &ps);
            return ps;
        }

        // [ignore] - void GetMinmax(uint target,bool reset,uint format,uint types,void* values)
        /// <summary>
        /// [Overload] - void GetMinmaxParameterfv(uint target,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetMinmaxParameterfv(uint target, uint pname) {
            float ps = 0;
            GLNative.glGetMinmaxParameterfv(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetMinmaxParameteriv(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetMinmaxParameteriv(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetMinmaxParameteriv(target, pname, &ps);
            return ps;
        }


        #endregion GL_ARB_imaging

        #region GL_ARB_indirect_parameters

        // [not processed] - void MultiDrawArraysIndirectCountARB(uint mode,void* indirect,IntPtr drawcount,int maxdrawcount,int stride)
        // [not processed] - void MultiDrawElementsIndirectCountARB(uint mode,uint type,void* indirect,IntPtr drawcount,int maxdrawcount,int stride)

        #endregion GL_ARB_indirect_parameters

        #region GL_ARB_instanced_arrays


        #endregion GL_ARB_instanced_arrays

        #region GL_ARB_internalformat_query


        #endregion GL_ARB_internalformat_query

        #region GL_ARB_invalidate_subdata


        #endregion GL_ARB_invalidate_subdata

        #region GL_ARB_map_buffer_range


        #endregion GL_ARB_map_buffer_range

        #region GL_ARB_matrix_palette

        /// <summary>
        /// [Overload] - void MatrixIndexubvARB(int size,byte* indices)
        /// </summary>
        public unsafe static void MatrixIndexubvARB(byte[] indices) {
            fixed (byte* pIndices = &indices[0]) {
                GLNative.glMatrixIndexubvARB(indices.Length, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void MatrixIndexubvARB(int size,byte* indices)
        /// </summary>
        public unsafe static void MatrixIndexubvARB(byte[] indices, int size) {
            fixed (byte* pIndices = &indices[0]) {
                GLNative.glMatrixIndexubvARB(size, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void MatrixIndexusvARB(int size,ushort* indices)
        /// </summary>
        public unsafe static void MatrixIndexusvARB(ushort[] indices) {
            fixed (ushort* pIndices = &indices[0]) {
                GLNative.glMatrixIndexusvARB(indices.Length * sizeof(ushort), pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void MatrixIndexusvARB(int size,ushort* indices)
        /// </summary>
        public unsafe static void MatrixIndexusvARB(ushort[] indices, int size) {
            fixed (ushort* pIndices = &indices[0]) {
                GLNative.glMatrixIndexusvARB(size, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void MatrixIndexuivARB(int size,uint* indices)
        /// </summary>
        public unsafe static void MatrixIndexuivARB(uint[] indices) {
            fixed (uint* pIndices = &indices[0]) {
                GLNative.glMatrixIndexuivARB(indices.Length * sizeof(uint), pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void MatrixIndexuivARB(int size,uint* indices)
        /// </summary>
        public unsafe static void MatrixIndexuivARB(uint[] indices, int size) {
            fixed (uint* pIndices = &indices[0]) {
                GLNative.glMatrixIndexuivARB(size, pIndices);
            }
        }

        // [not processed] - void MatrixIndexPointerARB(int size,uint type,int stride,void* pointer)

        #endregion GL_ARB_matrix_palette

        #region GL_ARB_multi_bind


        #endregion GL_ARB_multi_bind

        #region GL_ARB_multi_draw_indirect


        #endregion GL_ARB_multi_draw_indirect

        #region GL_ARB_multisample


        #endregion GL_ARB_multisample

        #region GL_ARB_multitexture

        // [not processed] - void MultiTexCoord1dvARB(uint target,double* v)
        // [not processed] - void MultiTexCoord1fvARB(uint target,float* v)
        // [not processed] - void MultiTexCoord1ivARB(uint target,int* v)
        // [not processed] - void MultiTexCoord1svARB(uint target,short* v)
        // [not processed] - void MultiTexCoord2dvARB(uint target,double* v)
        // [not processed] - void MultiTexCoord2fvARB(uint target,float* v)
        // [not processed] - void MultiTexCoord2ivARB(uint target,int* v)
        // [not processed] - void MultiTexCoord2svARB(uint target,short* v)
        // [not processed] - void MultiTexCoord3dvARB(uint target,double* v)
        // [not processed] - void MultiTexCoord3fvARB(uint target,float* v)
        // [not processed] - void MultiTexCoord3ivARB(uint target,int* v)
        // [not processed] - void MultiTexCoord3svARB(uint target,short* v)
        // [not processed] - void MultiTexCoord4dvARB(uint target,double* v)
        // [not processed] - void MultiTexCoord4fvARB(uint target,float* v)
        // [not processed] - void MultiTexCoord4ivARB(uint target,int* v)
        // [not processed] - void MultiTexCoord4svARB(uint target,short* v)

        #endregion GL_ARB_multitexture

        #region GL_ARB_occlusion_query

        /// <summary>
        /// [Overload] - void GenQueriesARB(int n,uint* ids)
        /// </summary>
        public unsafe static uint GenQueriesARB() {
            uint ids = 0;
            GLNative.glGenQueriesARB(1, &ids);
            return ids;
        }

        /// <summary>
        /// [Overload] - void GenQueriesARB(int n,uint* ids)
        /// </summary>
        public unsafe static uint[] GenQueriesARB(int n) {
            uint[] ids = new uint[n];
            fixed (uint* pIds = &ids[0]) {
                GLNative.glGenQueriesARB(n, pIds);
            }
            return ids;
        }

        /// <summary>
        /// [Overload] - void DeleteQueriesARB(int n,uint* ids)
        /// </summary>
        public unsafe static void DeleteQueriesARB(uint[] ids) {
            fixed (uint* pIds = &ids[0]) {
                GLNative.glDeleteQueriesARB(ids.Length, pIds);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteQueriesARB(int n,uint* ids)
        /// </summary>
        public unsafe static void DeleteQueriesARB(uint[] ids, int n) {
            fixed (uint* pIds = &ids[0]) {
                GLNative.glDeleteQueriesARB(n, pIds);
            }
        }

        /// <summary>
        /// [Overload] - void GetQueryivARB(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetQueryivARB(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetQueryivARB(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetQueryObjectivARB(uint id,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetQueryObjectivARB(uint id, uint pname) {
            int ps = 0;
            GLNative.glGetQueryObjectivARB(id, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetQueryObjectuivARB(uint id,uint pname,uint* ps)
        /// </summary>
        public unsafe static uint GetQueryObjectuivARB(uint id, uint pname) {
            uint ps = 0;
            GLNative.glGetQueryObjectuivARB(id, pname, &ps);
            return ps;
        }


        #endregion GL_ARB_occlusion_query

        #region GL_ARB_parallel_shader_compile


        #endregion GL_ARB_parallel_shader_compile

        #region GL_ARB_point_parameters

        // [not processed] - void PointParameterfvARB(uint pname,float* ps)

        #endregion GL_ARB_point_parameters

        #region GL_ARB_polygon_offset_clamp


        #endregion GL_ARB_polygon_offset_clamp

        #region GL_ARB_program_interface_query


        #endregion GL_ARB_program_interface_query

        #region GL_ARB_provoking_vertex


        #endregion GL_ARB_provoking_vertex

        #region GL_ARB_robustness

        // [ignore] - void GetnTexImageARB(uint target,int level,uint format,uint type,int bufSize,void* img)
        // [not processed] - void ReadnPixelsARB(int x,int y,int width,int height,uint format,uint type,int bufSize,void* data)
        // [ignore] - void GetnCompressedTexImageARB(uint target,int lod,int bufSize,void* img)
        /// <summary>
        /// [Overload] - void GetnUniformfvARB(uint program,int location,int bufSize,float* ps)
        /// </summary>
        public unsafe static float GetnUniformfvARB(uint program, int location, int bufSize) {
            float ps = 0;
            GLNative.glGetnUniformfvARB(program, location, bufSize, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetnUniformivARB(uint program,int location,int bufSize,int* ps)
        /// </summary>
        public unsafe static int GetnUniformivARB(uint program, int location, int bufSize) {
            int ps = 0;
            GLNative.glGetnUniformivARB(program, location, bufSize, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetnUniformuivARB(uint program,int location,int bufSize,uint* ps)
        /// </summary>
        public unsafe static uint GetnUniformuivARB(uint program, int location, int bufSize) {
            uint ps = 0;
            GLNative.glGetnUniformuivARB(program, location, bufSize, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetnUniformdvARB(uint program,int location,int bufSize,double* ps)
        /// </summary>
        public unsafe static double GetnUniformdvARB(uint program, int location, int bufSize) {
            double ps = 0;
            GLNative.glGetnUniformdvARB(program, location, bufSize, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetnMapdvARB(uint target,uint query,int bufSize,double* v)
        /// </summary>
        public unsafe static double GetnMapdvARB(uint target, uint query, int bufSize) {
            double v = 0;
            GLNative.glGetnMapdvARB(target, query, bufSize, &v);
            return v;
        }

        /// <summary>
        /// [Overload] - void GetnMapfvARB(uint target,uint query,int bufSize,float* v)
        /// </summary>
        public unsafe static float GetnMapfvARB(uint target, uint query, int bufSize) {
            float v = 0;
            GLNative.glGetnMapfvARB(target, query, bufSize, &v);
            return v;
        }

        /// <summary>
        /// [Overload] - void GetnMapivARB(uint target,uint query,int bufSize,int* v)
        /// </summary>
        public unsafe static int GetnMapivARB(uint target, uint query, int bufSize) {
            int v = 0;
            GLNative.glGetnMapivARB(target, query, bufSize, &v);
            return v;
        }

        /// <summary>
        /// [Overload] - void GetnPixelMapfvARB(uint map,int bufSize,float* values)
        /// </summary>
        public unsafe static float GetnPixelMapfvARB(uint map, int bufSize) {
            float values = 0;
            GLNative.glGetnPixelMapfvARB(map, bufSize, &values);
            return values;
        }

        /// <summary>
        /// [Overload] - void GetnPixelMapuivARB(uint map,int bufSize,uint* values)
        /// </summary>
        public unsafe static uint GetnPixelMapuivARB(uint map, int bufSize) {
            uint values = 0;
            GLNative.glGetnPixelMapuivARB(map, bufSize, &values);
            return values;
        }

        /// <summary>
        /// [Overload] - void GetnPixelMapusvARB(uint map,int bufSize,ushort* values)
        /// </summary>
        public unsafe static ushort GetnPixelMapusvARB(uint map, int bufSize) {
            ushort values = 0;
            GLNative.glGetnPixelMapusvARB(map, bufSize, &values);
            return values;
        }

        // [ignore] - void GetnPolygonStippleARB(int bufSize,byte* pattern)
        // [ignore] - void GetnColorTableARB(uint target,uint format,uint type,int bufSize,void* table)
        // [ignore] - void GetnConvolutionFilterARB(uint target,uint format,uint type,int bufSize,void* image)
        // [not processed] - void GetnSeparableFilterARB(uint target,uint format,uint type,int rowBufSize,void* row,int columnBufSize,void* column,void* span)
        // [ignore] - void GetnHistogramARB(uint target,bool reset,uint format,uint type,int bufSize,void* values)
        // [ignore] - void GetnMinmaxARB(uint target,bool reset,uint format,uint type,int bufSize,void* values)

        #endregion GL_ARB_robustness

        #region GL_ARB_sample_locations

        // [not processed] - void FramebufferSampleLocationsfvARB(uint target,uint start,int count,float* v)
        // [not processed] - void NamedFramebufferSampleLocationsfvARB(uint framebuffer,uint start,int count,float* v)

        #endregion GL_ARB_sample_locations

        #region GL_ARB_sample_shading


        #endregion GL_ARB_sample_shading

        #region GL_ARB_sampler_objects


        #endregion GL_ARB_sampler_objects

        #region GL_ARB_separate_shader_objects


        #endregion GL_ARB_separate_shader_objects

        #region GL_ARB_shader_atomic_counters


        #endregion GL_ARB_shader_atomic_counters

        #region GL_ARB_shader_image_load_store


        #endregion GL_ARB_shader_image_load_store

        #region GL_ARB_shader_objects

        // [not processed] - void ShaderSourceARB(uint shaderObj,int count,uint** str,int* length)
        // [not processed] - void Uniform1fvARB(int location,int count,float* value)
        // [not processed] - void Uniform2fvARB(int location,int count,float* value)
        // [not processed] - void Uniform3fvARB(int location,int count,float* value)
        // [not processed] - void Uniform4fvARB(int location,int count,float* value)
        // [not processed] - void Uniform1ivARB(int location,int count,int* value)
        // [not processed] - void Uniform2ivARB(int location,int count,int* value)
        // [not processed] - void Uniform3ivARB(int location,int count,int* value)
        // [not processed] - void Uniform4ivARB(int location,int count,int* value)
        // [not processed] - void UniformMatrix2fvARB(int location,int count,bool transpose,float* value)
        // [not processed] - void UniformMatrix3fvARB(int location,int count,bool transpose,float* value)
        // [not processed] - void UniformMatrix4fvARB(int location,int count,bool transpose,float* value)
        /// <summary>
        /// [Overload] - void GetObjectParameterfvARB(uint obj,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetObjectParameterfvARB(uint obj, uint pname) {
            float ps = 0;
            GLNative.glGetObjectParameterfvARB(obj, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetObjectParameterivARB(uint obj,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetObjectParameterivARB(uint obj, uint pname) {
            int ps = 0;
            GLNative.glGetObjectParameterivARB(obj, pname, &ps);
            return ps;
        }

        // [not processed] - void GetInfoLogARB(uint obj,int maxLength,int* length,uint* infoLog)
        // [not processed] - void GetAttachedObjectsARB(uint containerObj,int maxCount,int* count,uint* obj)
        // [not processed] - int GetUniformLocationARB(uint programObj,uint* name)
        // [not processed] - void GetActiveUniformARB(uint programObj,uint index,int maxLength,int* length,int* size,uint* type,uint* name)
        /// <summary>
        /// [Overload] - void GetUniformfvARB(uint programObj,int location,float* ps)
        /// </summary>
        public unsafe static float GetUniformfvARB(uint programObj, int location) {
            float ps = 0;
            GLNative.glGetUniformfvARB(programObj, location, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetUniformivARB(uint programObj,int location,int* ps)
        /// </summary>
        public unsafe static int GetUniformivARB(uint programObj, int location) {
            int ps = 0;
            GLNative.glGetUniformivARB(programObj, location, &ps);
            return ps;
        }

        // [not processed] - void GetShaderSourceARB(uint obj,int maxLength,int* length,uint* source)

        #endregion GL_ARB_shader_objects

        #region GL_ARB_shader_storage_buffer_object


        #endregion GL_ARB_shader_storage_buffer_object

        #region GL_ARB_shader_subroutine


        #endregion GL_ARB_shader_subroutine

        #region GL_ARB_shading_language_include

        // [not processed] - void NamedStringARB(uint type,int namelen,byte* name,int stringlen,byte* str)
        // [ignore] - void DeleteNamedStringARB(int namelen,byte* name)
        // [not processed] - void CompileShaderIncludeARB(uint shader,int count,byte** path,int* length)
        // [not processed] - bool IsNamedStringARB(int namelen,byte* name)
        // [not processed] - void GetNamedStringARB(int namelen,byte* name,int bufSize,int* stringlen,byte* str)
        // [not processed] - void GetNamedStringivARB(int namelen,byte* name,uint pname,int* ps)

        #endregion GL_ARB_shading_language_include

        #region GL_ARB_sparse_buffer


        #endregion GL_ARB_sparse_buffer

        #region GL_ARB_sparse_texture


        #endregion GL_ARB_sparse_texture

        #region GL_ARB_sync


        #endregion GL_ARB_sync

        #region GL_ARB_tessellation_shader


        #endregion GL_ARB_tessellation_shader

        #region GL_ARB_texture_barrier


        #endregion GL_ARB_texture_barrier

        #region GL_ARB_texture_buffer_object


        #endregion GL_ARB_texture_buffer_object

        #region GL_ARB_texture_buffer_range


        #endregion GL_ARB_texture_buffer_range

        #region GL_ARB_texture_compression

        // [not processed] - void CompressedTexImage3DARB(uint target,int level,uint internalformat,int width,int height,int depth,int border,int imageSize,void* data)
        // [not processed] - void CompressedTexImage2DARB(uint target,int level,uint internalformat,int width,int height,int border,int imageSize,void* data)
        // [not processed] - void CompressedTexImage1DARB(uint target,int level,uint internalformat,int width,int border,int imageSize,void* data)
        // [not processed] - void CompressedTexSubImage3DARB(uint target,int level,int xoffset,int yoffset,int zoffset,int width,int height,int depth,uint format,int imageSize,void* data)
        // [not processed] - void CompressedTexSubImage2DARB(uint target,int level,int xoffset,int yoffset,int width,int height,uint format,int imageSize,void* data)
        // [not processed] - void CompressedTexSubImage1DARB(uint target,int level,int xoffset,int width,uint format,int imageSize,void* data)
        // [ignore] - void GetCompressedTexImageARB(uint target,int level,void* img)

        #endregion GL_ARB_texture_compression

        #region GL_ARB_texture_multisample


        #endregion GL_ARB_texture_multisample

        #region GL_ARB_texture_storage


        #endregion GL_ARB_texture_storage

        #region GL_ARB_texture_storage_multisample


        #endregion GL_ARB_texture_storage_multisample

        #region GL_ARB_texture_view


        #endregion GL_ARB_texture_view

        #region GL_ARB_timer_query


        #endregion GL_ARB_timer_query

        #region GL_ARB_transform_feedback2


        #endregion GL_ARB_transform_feedback2

        #region GL_ARB_transform_feedback3


        #endregion GL_ARB_transform_feedback3

        #region GL_ARB_transform_feedback_instanced


        #endregion GL_ARB_transform_feedback_instanced

        #region GL_ARB_transpose_matrix

        // [not processed] - void LoadTransposeMatrixfARB(float* m)
        // [not processed] - void LoadTransposeMatrixdARB(double* m)
        // [not processed] - void MultTransposeMatrixfARB(float* m)
        // [not processed] - void MultTransposeMatrixdARB(double* m)

        #endregion GL_ARB_transpose_matrix

        #region GL_ARB_uniform_buffer_object


        #endregion GL_ARB_uniform_buffer_object

        #region GL_ARB_vertex_array_object


        #endregion GL_ARB_vertex_array_object

        #region GL_ARB_vertex_attrib_64bit


        #endregion GL_ARB_vertex_attrib_64bit

        #region GL_ARB_vertex_attrib_binding


        #endregion GL_ARB_vertex_attrib_binding

        #region GL_ARB_vertex_blend

        // [not processed] - void WeightbvARB(int size,byte* weights)
        // [not processed] - void WeightsvARB(int size,short* weights)
        // [not processed] - void WeightivARB(int size,int* weights)
        // [not processed] - void WeightfvARB(int size,float* weights)
        // [not processed] - void WeightdvARB(int size,double* weights)
        // [not processed] - void WeightubvARB(int size,byte* weights)
        // [not processed] - void WeightusvARB(int size,ushort* weights)
        // [not processed] - void WeightuivARB(int size,uint* weights)
        // [not processed] - void WeightPointerARB(int size,uint type,int stride,void* pointer)

        #endregion GL_ARB_vertex_blend

        #region GL_ARB_vertex_buffer_object

        /// <summary>
        /// [Overload] - void DeleteBuffersARB(int n,uint* buffers)
        /// </summary>
        public unsafe static void DeleteBuffersARB(uint[] buffers) {
            fixed (uint* pBuffers = &buffers[0]) {
                GLNative.glDeleteBuffersARB(buffers.Length, pBuffers);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteBuffersARB(int n,uint* buffers)
        /// </summary>
        public unsafe static void DeleteBuffersARB(uint[] buffers, int n) {
            fixed (uint* pBuffers = &buffers[0]) {
                GLNative.glDeleteBuffersARB(n, pBuffers);
            }
        }

        /// <summary>
        /// [Overload] - void GenBuffersARB(int n,uint* buffers)
        /// </summary>
        public unsafe static uint GenBuffersARB() {
            uint buffers = 0;
            GLNative.glGenBuffersARB(1, &buffers);
            return buffers;
        }

        /// <summary>
        /// [Overload] - void GenBuffersARB(int n,uint* buffers)
        /// </summary>
        public unsafe static uint[] GenBuffersARB(int n) {
            uint[] buffers = new uint[n];
            fixed (uint* pBuffers = &buffers[0]) {
                GLNative.glGenBuffersARB(n, pBuffers);
            }
            return buffers;
        }

        /// <summary>
        /// [Overload] - void BufferDataARB(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferDataARB(uint target, byte[] data, uint usage) {
            long size = data.Length * sizeof(byte);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferDataARB(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferDataARB(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferDataARB(uint target, long size, byte[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferDataARB(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferDataARB(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferDataARB(uint target, short[] data, uint usage) {
            long size = data.Length * sizeof(short);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferDataARB(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferDataARB(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferDataARB(uint target, long size, short[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferDataARB(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferDataARB(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferDataARB(uint target, ushort[] data, uint usage) {
            long size = data.Length * sizeof(ushort);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferDataARB(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferDataARB(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferDataARB(uint target, long size, ushort[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferDataARB(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferDataARB(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferDataARB(uint target, int[] data, uint usage) {
            long size = data.Length * sizeof(int);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferDataARB(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferDataARB(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferDataARB(uint target, long size, int[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferDataARB(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferDataARB(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferDataARB(uint target, uint[] data, uint usage) {
            long size = data.Length * sizeof(uint);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferDataARB(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferDataARB(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferDataARB(uint target, long size, uint[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferDataARB(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferDataARB(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferDataARB(uint target, float[] data, uint usage) {
            long size = data.Length * sizeof(float);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferDataARB(target, (IntPtr)size, pData, usage);
            }
        }

        /// <summary>
        /// [Overload] - void BufferDataARB(uint target,IntPtr size,void* data,uint usage)
        /// </summary>
        public unsafe static void BufferDataARB(uint target, long size, float[] data, uint usage) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferDataARB(target, (IntPtr)size, pData, usage);
            }
        }

        // [not processed] - void BufferDataARB(uint target,IntPtr size,void* data,uint usage)
        /// <summary>
        /// [Overload] - void BufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubDataARB(uint target, IntPtr offset, byte[] data) {
            long size = data.Length * sizeof(byte);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubDataARB(uint target, IntPtr offset, long size, byte[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubDataARB(uint target, IntPtr offset, short[] data) {
            long size = data.Length * sizeof(short);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubDataARB(uint target, IntPtr offset, long size, short[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubDataARB(uint target, IntPtr offset, ushort[] data) {
            long size = data.Length * sizeof(ushort);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubDataARB(uint target, IntPtr offset, long size, ushort[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubDataARB(uint target, IntPtr offset, int[] data) {
            long size = data.Length * sizeof(int);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubDataARB(uint target, IntPtr offset, long size, int[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubDataARB(uint target, IntPtr offset, uint[] data) {
            long size = data.Length * sizeof(uint);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubDataARB(uint target, IntPtr offset, long size, uint[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubDataARB(uint target, IntPtr offset, float[] data) {
            long size = data.Length * sizeof(float);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void BufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void BufferSubDataARB(uint target, IntPtr offset, long size, float[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        // [not processed] - void BufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// <summary>
        /// [Overload] - void GetBufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubDataARB(uint target, IntPtr offset, byte[] data) {
            long size = data.Length * sizeof(byte);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubDataARB(uint target, IntPtr offset, long size, byte[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubDataARB(uint target, IntPtr offset, short[] data) {
            long size = data.Length * sizeof(short);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubDataARB(uint target, IntPtr offset, long size, short[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubDataARB(uint target, IntPtr offset, ushort[] data) {
            long size = data.Length * sizeof(ushort);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubDataARB(uint target, IntPtr offset, long size, ushort[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubDataARB(uint target, IntPtr offset, int[] data) {
            long size = data.Length * sizeof(int);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubDataARB(uint target, IntPtr offset, long size, int[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubDataARB(uint target, IntPtr offset, uint[] data) {
            long size = data.Length * sizeof(uint);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubDataARB(uint target, IntPtr offset, long size, uint[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubDataARB(uint target, IntPtr offset, float[] data) {
            long size = data.Length * sizeof(float);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void GetBufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void GetBufferSubDataARB(uint target, IntPtr offset, long size, float[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glGetBufferSubDataARB(target, offset, (IntPtr)size, pData);
            }
        }

        // [ignore] - void GetBufferSubDataARB(uint target,IntPtr offset,IntPtr size,void* data)
        // [not processed] - void* MapBufferARB(uint target,uint access)
        /// <summary>
        /// [Overload] - void GetBufferParameterivARB(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetBufferParameterivARB(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetBufferParameterivARB(target, pname, &ps);
            return ps;
        }

        // [not processed] - void GetBufferPointervARB(uint target,uint pname,void** ps)

        #endregion GL_ARB_vertex_buffer_object

        #region GL_ARB_vertex_program

        // [not processed] - void VertexAttrib1dvARB(uint index,double* v)
        // [not processed] - void VertexAttrib1fvARB(uint index,float* v)
        // [not processed] - void VertexAttrib1svARB(uint index,short* v)
        // [not processed] - void VertexAttrib2dvARB(uint index,double* v)
        // [not processed] - void VertexAttrib2fvARB(uint index,float* v)
        // [not processed] - void VertexAttrib2svARB(uint index,short* v)
        // [not processed] - void VertexAttrib3dvARB(uint index,double* v)
        // [not processed] - void VertexAttrib3fvARB(uint index,float* v)
        // [not processed] - void VertexAttrib3svARB(uint index,short* v)
        // [not processed] - void VertexAttrib4NbvARB(uint index,byte* v)
        // [not processed] - void VertexAttrib4NivARB(uint index,int* v)
        // [not processed] - void VertexAttrib4NsvARB(uint index,short* v)
        // [not processed] - void VertexAttrib4NubvARB(uint index,byte* v)
        // [not processed] - void VertexAttrib4NuivARB(uint index,uint* v)
        // [not processed] - void VertexAttrib4NusvARB(uint index,ushort* v)
        // [not processed] - void VertexAttrib4bvARB(uint index,byte* v)
        // [not processed] - void VertexAttrib4dvARB(uint index,double* v)
        // [not processed] - void VertexAttrib4fvARB(uint index,float* v)
        // [not processed] - void VertexAttrib4ivARB(uint index,int* v)
        // [not processed] - void VertexAttrib4svARB(uint index,short* v)
        // [not processed] - void VertexAttrib4ubvARB(uint index,byte* v)
        // [not processed] - void VertexAttrib4uivARB(uint index,uint* v)
        // [not processed] - void VertexAttrib4usvARB(uint index,ushort* v)
        // [not processed] - void VertexAttribPointerARB(uint index,int size,uint type,bool normalized,int stride,void* pointer)
        // [not processed] - void ProgramStringARB(uint target,uint format,int len,void* str)
        /// <summary>
        /// [Overload] - void DeleteProgramsARB(int n,uint* programs)
        /// </summary>
        public unsafe static void DeleteProgramsARB(uint[] programs) {
            fixed (uint* pPrograms = &programs[0]) {
                GLNative.glDeleteProgramsARB(programs.Length, pPrograms);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteProgramsARB(int n,uint* programs)
        /// </summary>
        public unsafe static void DeleteProgramsARB(uint[] programs, int n) {
            fixed (uint* pPrograms = &programs[0]) {
                GLNative.glDeleteProgramsARB(n, pPrograms);
            }
        }

        /// <summary>
        /// [Overload] - void GenProgramsARB(int n,uint* programs)
        /// </summary>
        public unsafe static uint GenProgramsARB() {
            uint programs = 0;
            GLNative.glGenProgramsARB(1, &programs);
            return programs;
        }

        /// <summary>
        /// [Overload] - void GenProgramsARB(int n,uint* programs)
        /// </summary>
        public unsafe static uint[] GenProgramsARB(int n) {
            uint[] programs = new uint[n];
            fixed (uint* pPrograms = &programs[0]) {
                GLNative.glGenProgramsARB(n, pPrograms);
            }
            return programs;
        }

        // [not processed] - void ProgramEnvParameter4dvARB(uint target,uint index,double* ps)
        // [not processed] - void ProgramEnvParameter4fvARB(uint target,uint index,float* ps)
        // [not processed] - void ProgramLocalParameter4dvARB(uint target,uint index,double* ps)
        // [not processed] - void ProgramLocalParameter4fvARB(uint target,uint index,float* ps)
        /// <summary>
        /// [Overload] - void GetProgramEnvParameterdvARB(uint target,uint index,double* ps)
        /// </summary>
        public unsafe static double GetProgramEnvParameterdvARB(uint target, uint index) {
            double ps = 0;
            GLNative.glGetProgramEnvParameterdvARB(target, index, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetProgramEnvParameterfvARB(uint target,uint index,float* ps)
        /// </summary>
        public unsafe static float GetProgramEnvParameterfvARB(uint target, uint index) {
            float ps = 0;
            GLNative.glGetProgramEnvParameterfvARB(target, index, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetProgramLocalParameterdvARB(uint target,uint index,double* ps)
        /// </summary>
        public unsafe static double GetProgramLocalParameterdvARB(uint target, uint index) {
            double ps = 0;
            GLNative.glGetProgramLocalParameterdvARB(target, index, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetProgramLocalParameterfvARB(uint target,uint index,float* ps)
        /// </summary>
        public unsafe static float GetProgramLocalParameterfvARB(uint target, uint index) {
            float ps = 0;
            GLNative.glGetProgramLocalParameterfvARB(target, index, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetProgramivARB(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetProgramivARB(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetProgramivARB(target, pname, &ps);
            return ps;
        }

        // [ignore] - void GetProgramStringARB(uint target,uint pname,void* str)
        /// <summary>
        /// [Overload] - void GetVertexAttribdvARB(uint index,uint pname,double* ps)
        /// </summary>
        public unsafe static double GetVertexAttribdvARB(uint index, uint pname) {
            double ps = 0;
            GLNative.glGetVertexAttribdvARB(index, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVertexAttribfvARB(uint index,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetVertexAttribfvARB(uint index, uint pname) {
            float ps = 0;
            GLNative.glGetVertexAttribfvARB(index, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVertexAttribivARB(uint index,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetVertexAttribivARB(uint index, uint pname) {
            int ps = 0;
            GLNative.glGetVertexAttribivARB(index, pname, &ps);
            return ps;
        }

        // [not processed] - void GetVertexAttribPointervARB(uint index,uint pname,void** pointer)

        #endregion GL_ARB_vertex_program

        #region GL_ARB_vertex_shader

        // [not processed] - void BindAttribLocationARB(uint programObj,uint index,uint* name)
        // [not processed] - void GetActiveAttribARB(uint programObj,uint index,int maxLength,int* length,int* size,uint* type,uint* name)
        // [not processed] - int GetAttribLocationARB(uint programObj,uint* name)

        #endregion GL_ARB_vertex_shader

        #region GL_ARB_vertex_type_2_10_10_10_rev


        #endregion GL_ARB_vertex_type_2_10_10_10_rev

        #region GL_ARB_viewport_array

        // [not processed] - void DepthRangeArraydvNV(uint first,int count,double* v)

        #endregion GL_ARB_viewport_array

        #region GL_ARB_window_pos

        // [not processed] - void WindowPos2dvARB(double* v)
        // [not processed] - void WindowPos2fvARB(float* v)
        // [not processed] - void WindowPos2ivARB(int* v)
        // [not processed] - void WindowPos2svARB(short* v)
        // [not processed] - void WindowPos3dvARB(double* v)
        // [not processed] - void WindowPos3fvARB(float* v)
        // [not processed] - void WindowPos3ivARB(int* v)
        // [not processed] - void WindowPos3svARB(short* v)

        #endregion GL_ARB_window_pos

        #region GL_ATI_draw_buffers

        // [not processed] - void DrawBuffersATI(int n,uint* bufs)

        #endregion GL_ATI_draw_buffers

        #region GL_ATI_element_array

        // [not processed] - void ElementPointerATI(uint type,void* pointer)

        #endregion GL_ATI_element_array

        #region GL_ATI_envmap_bumpmap

        // [not processed] - void TexBumpParameterivATI(uint pname,int* param)
        // [not processed] - void TexBumpParameterfvATI(uint pname,float* param)
        /// <summary>
        /// [Overload] - void GetTexBumpParameterivATI(uint pname,int* param)
        /// </summary>
        public unsafe static int GetTexBumpParameterivATI(uint pname) {
            int param = 0;
            GLNative.glGetTexBumpParameterivATI(pname, &param);
            return param;
        }

        /// <summary>
        /// [Overload] - void GetTexBumpParameterfvATI(uint pname,float* param)
        /// </summary>
        public unsafe static float GetTexBumpParameterfvATI(uint pname) {
            float param = 0;
            GLNative.glGetTexBumpParameterfvATI(pname, &param);
            return param;
        }


        #endregion GL_ATI_envmap_bumpmap

        #region GL_ATI_fragment_shader

        // [not processed] - void SetFragmentShaderConstantATI(uint dst,float* value)

        #endregion GL_ATI_fragment_shader

        #region GL_ATI_map_object_buffer

        // [not processed] - void* MapObjectBufferATI(uint buffer)

        #endregion GL_ATI_map_object_buffer

        #region GL_ATI_pn_triangles


        #endregion GL_ATI_pn_triangles

        #region GL_ATI_separate_stencil


        #endregion GL_ATI_separate_stencil

        #region GL_ATI_vertex_array_object

        // [not processed] - uint NewObjectBufferATI(int size,void* pointer,uint usage)
        // [not processed] - void UpdateObjectBufferATI(uint buffer,uint offset,int size,void* pointer,uint preserve)
        /// <summary>
        /// [Overload] - void GetObjectBufferfvATI(uint buffer,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetObjectBufferfvATI(uint buffer, uint pname) {
            float ps = 0;
            GLNative.glGetObjectBufferfvATI(buffer, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetObjectBufferivATI(uint buffer,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetObjectBufferivATI(uint buffer, uint pname) {
            int ps = 0;
            GLNative.glGetObjectBufferivATI(buffer, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetArrayObjectfvATI(uint array,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetArrayObjectfvATI(uint array, uint pname) {
            float ps = 0;
            GLNative.glGetArrayObjectfvATI(array, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetArrayObjectivATI(uint array,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetArrayObjectivATI(uint array, uint pname) {
            int ps = 0;
            GLNative.glGetArrayObjectivATI(array, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVariantArrayObjectfvATI(uint id,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetVariantArrayObjectfvATI(uint id, uint pname) {
            float ps = 0;
            GLNative.glGetVariantArrayObjectfvATI(id, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVariantArrayObjectivATI(uint id,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetVariantArrayObjectivATI(uint id, uint pname) {
            int ps = 0;
            GLNative.glGetVariantArrayObjectivATI(id, pname, &ps);
            return ps;
        }


        #endregion GL_ATI_vertex_array_object

        #region GL_ATI_vertex_attrib_array_object

        /// <summary>
        /// [Overload] - void GetVertexAttribArrayObjectfvATI(uint index,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetVertexAttribArrayObjectfvATI(uint index, uint pname) {
            float ps = 0;
            GLNative.glGetVertexAttribArrayObjectfvATI(index, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVertexAttribArrayObjectivATI(uint index,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetVertexAttribArrayObjectivATI(uint index, uint pname) {
            int ps = 0;
            GLNative.glGetVertexAttribArrayObjectivATI(index, pname, &ps);
            return ps;
        }


        #endregion GL_ATI_vertex_attrib_array_object

        #region GL_ATI_vertex_streams

        // [not processed] - void VertexStream1svATI(uint stream,short* coords)
        // [not processed] - void VertexStream1ivATI(uint stream,int* coords)
        // [not processed] - void VertexStream1fvATI(uint stream,float* coords)
        // [not processed] - void VertexStream1dvATI(uint stream,double* coords)
        // [not processed] - void VertexStream2svATI(uint stream,short* coords)
        // [not processed] - void VertexStream2ivATI(uint stream,int* coords)
        // [not processed] - void VertexStream2fvATI(uint stream,float* coords)
        // [not processed] - void VertexStream2dvATI(uint stream,double* coords)
        // [not processed] - void VertexStream3svATI(uint stream,short* coords)
        // [not processed] - void VertexStream3ivATI(uint stream,int* coords)
        // [not processed] - void VertexStream3fvATI(uint stream,float* coords)
        // [not processed] - void VertexStream3dvATI(uint stream,double* coords)
        // [not processed] - void VertexStream4svATI(uint stream,short* coords)
        // [not processed] - void VertexStream4ivATI(uint stream,int* coords)
        // [not processed] - void VertexStream4fvATI(uint stream,float* coords)
        // [not processed] - void VertexStream4dvATI(uint stream,double* coords)
        // [not processed] - void NormalStream3bvATI(uint stream,byte* coords)
        // [not processed] - void NormalStream3svATI(uint stream,short* coords)
        // [not processed] - void NormalStream3ivATI(uint stream,int* coords)
        // [not processed] - void NormalStream3fvATI(uint stream,float* coords)
        // [not processed] - void NormalStream3dvATI(uint stream,double* coords)

        #endregion GL_ATI_vertex_streams

        #region GL_EXT_EGL_image_storage

        // [not processed] - void EGLImageTargetTexStorageEXT(uint target,IntPtr image,int* attrib_list)
        // [not processed] - void EGLImageTargetTextureStorageEXT(uint texture,IntPtr image,int* attrib_list)

        #endregion GL_EXT_EGL_image_storage

        #region GL_EXT_bindable_uniform


        #endregion GL_EXT_bindable_uniform

        #region GL_EXT_blend_color


        #endregion GL_EXT_blend_color

        #region GL_EXT_blend_equation_separate


        #endregion GL_EXT_blend_equation_separate

        #region GL_EXT_blend_func_separate


        #endregion GL_EXT_blend_func_separate

        #region GL_EXT_color_subtable

        // [not processed] - void ColorSubTableEXT(uint target,int start,int count,uint format,uint type,void* data)

        #endregion GL_EXT_color_subtable

        #region GL_EXT_compiled_vertex_array


        #endregion GL_EXT_compiled_vertex_array

        #region GL_EXT_convolution

        // [not processed] - void ConvolutionFilter1DEXT(uint target,uint internalformat,int width,uint format,uint type,void* image)
        // [not processed] - void ConvolutionFilter2DEXT(uint target,uint internalformat,int width,int height,uint format,uint type,void* image)
        // [not processed] - void ConvolutionParameterfvEXT(uint target,uint pname,float* ps)
        // [not processed] - void ConvolutionParameterivEXT(uint target,uint pname,int* ps)
        // [ignore] - void GetConvolutionFilterEXT(uint target,uint format,uint type,void* image)
        /// <summary>
        /// [Overload] - void GetConvolutionParameterfvEXT(uint target,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetConvolutionParameterfvEXT(uint target, uint pname) {
            float ps = 0;
            GLNative.glGetConvolutionParameterfvEXT(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetConvolutionParameterivEXT(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetConvolutionParameterivEXT(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetConvolutionParameterivEXT(target, pname, &ps);
            return ps;
        }

        // [not processed] - void GetSeparableFilterEXT(uint target,uint format,uint type,void* row,void* column,void* span)
        // [not processed] - void SeparableFilter2DEXT(uint target,uint internalformat,int width,int height,uint format,uint type,void* row,void* column)

        #endregion GL_EXT_convolution

        #region GL_EXT_coordinate_frame

        // [not processed] - void Tangent3bvEXT(byte* v)
        // [not processed] - void Tangent3dvEXT(double* v)
        // [not processed] - void Tangent3fvEXT(float* v)
        // [not processed] - void Tangent3ivEXT(int* v)
        // [not processed] - void Tangent3svEXT(short* v)
        // [not processed] - void Binormal3bvEXT(byte* v)
        // [not processed] - void Binormal3dvEXT(double* v)
        // [not processed] - void Binormal3fvEXT(float* v)
        // [not processed] - void Binormal3ivEXT(int* v)
        // [not processed] - void Binormal3svEXT(short* v)
        // [not processed] - void TangentPointerEXT(uint type,int stride,void* pointer)
        // [not processed] - void BinormalPointerEXT(uint type,int stride,void* pointer)

        #endregion GL_EXT_coordinate_frame

        #region GL_EXT_copy_texture


        #endregion GL_EXT_copy_texture

        #region GL_EXT_cull_vertex

        // [not processed] - void CullParameterdvEXT(uint pname,double* ps)
        // [not processed] - void CullParameterfvEXT(uint pname,float* ps)

        #endregion GL_EXT_cull_vertex

        #region GL_EXT_debug_label

        /// <summary>
        /// [Overload] - void LabelObjectEXT(uint type,uint obj,int length,byte* label)
        /// </summary>
        public unsafe static void LabelObjectEXT(uint type, uint obj, string label) {
            byte[] byBuffer = Encoding.UTF8.GetBytes(label);
            fixed (byte* pLabel = &byBuffer[0]) {
                GLNative.glLabelObjectEXT(type, obj, label.Length, pLabel);
            }
        }

        /// <summary>
        /// [Overload] - void GetObjectLabelEXT(uint type,uint obj,int bufSize,int* length,byte* label)
        /// </summary>
        public unsafe static string GetObjectLabelEXT(uint type, uint obj) {
            int length = 0;
            byte[] label = new byte[1024];
            fixed (byte* pLabel = &label[0]) {
                GLNative.glGetObjectLabelEXT(type, obj, label.Length, &length, pLabel);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(label, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetObjectLabelEXT(uint type,uint obj,int bufSize,int* length,byte* label)
        /// </summary>
        public unsafe static string GetObjectLabelEXT(uint type, uint obj, int bufSize) {
            int length = 0;
            byte[] label = new byte[bufSize];
            fixed (byte* pLabel = &label[0]) {
                GLNative.glGetObjectLabelEXT(type, obj, bufSize, &length, pLabel);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(label, 0, length);
            }
        }


        #endregion GL_EXT_debug_label

        #region GL_EXT_debug_marker

        /// <summary>
        /// [Overload] - void InsertEventMarkerEXT(int length,byte* marker)
        /// </summary>
        public unsafe static void InsertEventMarkerEXT(string marker) {
            byte[] byBuffer = Encoding.UTF8.GetBytes(marker);
            fixed (byte* pMarker = &byBuffer[0]) {
                GLNative.glInsertEventMarkerEXT(marker.Length, pMarker);
            }
        }

        /// <summary>
        /// [Overload] - void PushGroupMarkerEXT(int length,byte* marker)
        /// </summary>
        public unsafe static void PushGroupMarkerEXT(string marker) {
            byte[] byBuffer = Encoding.UTF8.GetBytes(marker);
            fixed (byte* pMarker = &byBuffer[0]) {
                GLNative.glPushGroupMarkerEXT(marker.Length, pMarker);
            }
        }


        #endregion GL_EXT_debug_marker

        #region GL_EXT_depth_bounds_test


        #endregion GL_EXT_depth_bounds_test

        #region GL_EXT_draw_buffers2

        /// <summary>
        /// [Overload] - void GetBooleanIndexedvEXT(uint target,uint index,bool* data)
        /// </summary>
        public unsafe static bool GetBooleanIndexedvEXT(uint target, uint index) {
            bool data = false;
            GLNative.glGetBooleanIndexedvEXT(target, index, &data);
            return data;
        }

        /// <summary>
        /// [Overload] - void GetIntegerIndexedvEXT(uint target,uint index,int* data)
        /// </summary>
        public unsafe static int GetIntegerIndexedvEXT(uint target, uint index) {
            int data = 0;
            GLNative.glGetIntegerIndexedvEXT(target, index, &data);
            return data;
        }


        #endregion GL_EXT_draw_buffers2

        #region GL_EXT_draw_instanced

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, byte[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_BYTE, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, uint type, byte[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, (indices == null ? 0 : indices.Length), type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, int count, uint type, byte[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, count, type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, short[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, (indices == null ? 0 : indices.Length), GL.GL_SHORT, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, uint type, short[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, (indices == null ? 0 : indices.Length), type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, int count, uint type, short[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, count, type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, ushort[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_SHORT, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, uint type, ushort[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, (indices == null ? 0 : indices.Length), type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, int count, uint type, ushort[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, count, type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, int[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, (indices == null ? 0 : indices.Length), GL.GL_INT, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, uint type, int[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, (indices == null ? 0 : indices.Length), type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, int count, uint type, int[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, count, type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, uint[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_INT, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, uint type, uint[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, (indices == null ? 0 : indices.Length), type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, int count, uint type, uint[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, count, type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, float[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, (indices == null ? 0 : indices.Length), GL.GL_FLOAT, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, uint type, float[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, (indices == null ? 0 : indices.Length), type, pIndices, primcount);
            }
        }

        /// <summary>
        /// [Overload] - void DrawElementsInstancedEXT(uint mode,int count,uint type,void* indices,int primcount)
        /// </summary>
        public unsafe static void DrawElementsInstancedEXT(uint mode, int count, uint type, float[] indices, int primcount) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawElementsInstancedEXT(mode, count, type, pIndices, primcount);
            }
        }


        #endregion GL_EXT_draw_instanced

        #region GL_EXT_draw_range_elements

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, byte[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_BYTE, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, uint type, byte[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, int count, uint type, byte[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, count, type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, short[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_SHORT, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, uint type, short[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, int count, uint type, short[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, count, type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, ushort[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_SHORT, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, uint type, ushort[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, int count, uint type, ushort[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, count, type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, int[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_INT, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, uint type, int[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, int count, uint type, int[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, count, type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, uint[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_UNSIGNED_INT, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, uint type, uint[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, int count, uint type, uint[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, count, type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, float[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, (indices == null ? 0 : indices.Length), GL.GL_FLOAT, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, uint type, float[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, (indices == null ? 0 : indices.Length), type, pIndices);
            }
        }

        /// <summary>
        /// [Overload] - void DrawRangeElementsEXT(uint mode,uint start,uint end,int count,uint type,void* indices)
        /// </summary>
        public unsafe static void DrawRangeElementsEXT(uint mode, uint start, uint end, int count, uint type, float[] indices) {
            fixed (void* pIndices = &indices[0]) {
                GLNative.glDrawRangeElementsEXT(mode, start, end, count, type, pIndices);
            }
        }


        #endregion GL_EXT_draw_range_elements

        #region GL_EXT_external_buffer


        #endregion GL_EXT_external_buffer

        #region GL_EXT_fog_coord

        // [not processed] - void FogCoordfvEXT(float* coord)
        // [not processed] - void FogCoorddvEXT(double* coord)
        // [not processed] - void FogCoordPointerEXT(uint type,int stride,void* pointer)

        #endregion GL_EXT_fog_coord

        #region GL_EXT_framebuffer_blit


        #endregion GL_EXT_framebuffer_blit

        #region GL_EXT_framebuffer_multisample


        #endregion GL_EXT_framebuffer_multisample

        #region GL_EXT_framebuffer_object

        /// <summary>
        /// [Overload] - void DeleteRenderbuffersEXT(int n,uint* renderbuffers)
        /// </summary>
        public unsafe static void DeleteRenderbuffersEXT(uint[] renderbuffers) {
            fixed (uint* pRenderbuffers = &renderbuffers[0]) {
                GLNative.glDeleteRenderbuffersEXT(renderbuffers.Length, pRenderbuffers);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteRenderbuffersEXT(int n,uint* renderbuffers)
        /// </summary>
        public unsafe static void DeleteRenderbuffersEXT(uint[] renderbuffers, int n) {
            fixed (uint* pRenderbuffers = &renderbuffers[0]) {
                GLNative.glDeleteRenderbuffersEXT(n, pRenderbuffers);
            }
        }

        /// <summary>
        /// [Overload] - void GenRenderbuffersEXT(int n,uint* renderbuffers)
        /// </summary>
        public unsafe static uint GenRenderbuffersEXT() {
            uint renderbuffers = 0;
            GLNative.glGenRenderbuffersEXT(1, &renderbuffers);
            return renderbuffers;
        }

        /// <summary>
        /// [Overload] - void GenRenderbuffersEXT(int n,uint* renderbuffers)
        /// </summary>
        public unsafe static uint[] GenRenderbuffersEXT(int n) {
            uint[] renderbuffers = new uint[n];
            fixed (uint* pRenderbuffers = &renderbuffers[0]) {
                GLNative.glGenRenderbuffersEXT(n, pRenderbuffers);
            }
            return renderbuffers;
        }

        /// <summary>
        /// [Overload] - void GetRenderbufferParameterivEXT(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetRenderbufferParameterivEXT(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetRenderbufferParameterivEXT(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void DeleteFramebuffersEXT(int n,uint* framebuffers)
        /// </summary>
        public unsafe static void DeleteFramebuffersEXT(uint[] framebuffers) {
            fixed (uint* pFramebuffers = &framebuffers[0]) {
                GLNative.glDeleteFramebuffersEXT(framebuffers.Length, pFramebuffers);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteFramebuffersEXT(int n,uint* framebuffers)
        /// </summary>
        public unsafe static void DeleteFramebuffersEXT(uint[] framebuffers, int n) {
            fixed (uint* pFramebuffers = &framebuffers[0]) {
                GLNative.glDeleteFramebuffersEXT(n, pFramebuffers);
            }
        }

        /// <summary>
        /// [Overload] - void GenFramebuffersEXT(int n,uint* framebuffers)
        /// </summary>
        public unsafe static uint GenFramebuffersEXT() {
            uint framebuffers = 0;
            GLNative.glGenFramebuffersEXT(1, &framebuffers);
            return framebuffers;
        }

        /// <summary>
        /// [Overload] - void GenFramebuffersEXT(int n,uint* framebuffers)
        /// </summary>
        public unsafe static uint[] GenFramebuffersEXT(int n) {
            uint[] framebuffers = new uint[n];
            fixed (uint* pFramebuffers = &framebuffers[0]) {
                GLNative.glGenFramebuffersEXT(n, pFramebuffers);
            }
            return framebuffers;
        }

        /// <summary>
        /// [Overload] - void GetFramebufferAttachmentParameterivEXT(uint target,uint attachment,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetFramebufferAttachmentParameterivEXT(uint target, uint attachment, uint pname) {
            int ps = 0;
            GLNative.glGetFramebufferAttachmentParameterivEXT(target, attachment, pname, &ps);
            return ps;
        }


        #endregion GL_EXT_framebuffer_object

        #region GL_EXT_geometry_shader4


        #endregion GL_EXT_geometry_shader4

        #region GL_EXT_gpu_program_parameters

        // [not processed] - void ProgramEnvParameters4fvEXT(uint target,uint index,int count,float* ps)
        // [not processed] - void ProgramLocalParameters4fvEXT(uint target,uint index,int count,float* ps)

        #endregion GL_EXT_gpu_program_parameters

        #region GL_EXT_gpu_shader4

        /// <summary>
        /// [Overload] - void GetUniformuivEXT(uint program,int location,uint* ps)
        /// </summary>
        public unsafe static uint GetUniformuivEXT(uint program, int location) {
            uint ps = 0;
            GLNative.glGetUniformuivEXT(program, location, &ps);
            return ps;
        }

        // [not processed] - void BindFragDataLocationEXT(uint program,uint color,byte* name)
        // [not processed] - int GetFragDataLocationEXT(uint program,byte* name)
        // [not processed] - void Uniform1uivEXT(int location,int count,uint* value)
        // [not processed] - void Uniform2uivEXT(int location,int count,uint* value)
        // [not processed] - void Uniform3uivEXT(int location,int count,uint* value)
        // [not processed] - void Uniform4uivEXT(int location,int count,uint* value)
        // [not processed] - void VertexAttribI1ivEXT(uint index,int* v)
        // [not processed] - void VertexAttribI2ivEXT(uint index,int* v)
        // [not processed] - void VertexAttribI3ivEXT(uint index,int* v)
        // [not processed] - void VertexAttribI4ivEXT(uint index,int* v)
        // [not processed] - void VertexAttribI1uivEXT(uint index,uint* v)
        // [not processed] - void VertexAttribI2uivEXT(uint index,uint* v)
        // [not processed] - void VertexAttribI3uivEXT(uint index,uint* v)
        // [not processed] - void VertexAttribI4uivEXT(uint index,uint* v)
        // [not processed] - void VertexAttribI4bvEXT(uint index,byte* v)
        // [not processed] - void VertexAttribI4svEXT(uint index,short* v)
        // [not processed] - void VertexAttribI4ubvEXT(uint index,byte* v)
        // [not processed] - void VertexAttribI4usvEXT(uint index,ushort* v)
        // [not processed] - void VertexAttribIPointerEXT(uint index,int size,uint type,int stride,void* pointer)
        /// <summary>
        /// [Overload] - void GetVertexAttribIivEXT(uint index,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetVertexAttribIivEXT(uint index, uint pname) {
            int ps = 0;
            GLNative.glGetVertexAttribIivEXT(index, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVertexAttribIuivEXT(uint index,uint pname,uint* ps)
        /// </summary>
        public unsafe static uint GetVertexAttribIuivEXT(uint index, uint pname) {
            uint ps = 0;
            GLNative.glGetVertexAttribIuivEXT(index, pname, &ps);
            return ps;
        }


        #endregion GL_EXT_gpu_shader4

        #region GL_EXT_histogram

        // [ignore] - void GetHistogramEXT(uint target,bool reset,uint format,uint type,void* values)
        /// <summary>
        /// [Overload] - void GetHistogramParameterfvEXT(uint target,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetHistogramParameterfvEXT(uint target, uint pname) {
            float ps = 0;
            GLNative.glGetHistogramParameterfvEXT(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetHistogramParameterivEXT(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetHistogramParameterivEXT(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetHistogramParameterivEXT(target, pname, &ps);
            return ps;
        }

        // [ignore] - void GetMinmaxEXT(uint target,bool reset,uint format,uint type,void* values)
        /// <summary>
        /// [Overload] - void GetMinmaxParameterfvEXT(uint target,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetMinmaxParameterfvEXT(uint target, uint pname) {
            float ps = 0;
            GLNative.glGetMinmaxParameterfvEXT(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetMinmaxParameterivEXT(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetMinmaxParameterivEXT(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetMinmaxParameterivEXT(target, pname, &ps);
            return ps;
        }


        #endregion GL_EXT_histogram

        #region GL_EXT_index_func


        #endregion GL_EXT_index_func

        #region GL_EXT_index_material


        #endregion GL_EXT_index_material

        #region GL_EXT_light_texture


        #endregion GL_EXT_light_texture

        #region GL_EXT_memory_object

        // [ignore] - void GetUnsignedBytevEXT(uint pname,byte* data)
        // [ignore] - void GetUnsignedBytei_vEXT(uint target,uint index,byte* data)
        /// <summary>
        /// [Overload] - void DeleteMemoryObjectsEXT(int n,uint* memoryObjects)
        /// </summary>
        public unsafe static void DeleteMemoryObjectsEXT(uint[] memoryObjects) {
            fixed (uint* pMemoryObjects = &memoryObjects[0]) {
                GLNative.glDeleteMemoryObjectsEXT(memoryObjects.Length, pMemoryObjects);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteMemoryObjectsEXT(int n,uint* memoryObjects)
        /// </summary>
        public unsafe static void DeleteMemoryObjectsEXT(uint[] memoryObjects, int n) {
            fixed (uint* pMemoryObjects = &memoryObjects[0]) {
                GLNative.glDeleteMemoryObjectsEXT(n, pMemoryObjects);
            }
        }

        /// <summary>
        /// [Overload] - void CreateMemoryObjectsEXT(int n,uint* memoryObjects)
        /// </summary>
        public unsafe static uint CreateMemoryObjectsEXT() {
            uint memoryObjects = 0;
            GLNative.glCreateMemoryObjectsEXT(1, &memoryObjects);
            return memoryObjects;
        }

        /// <summary>
        /// [Overload] - void CreateMemoryObjectsEXT(int n,uint* memoryObjects)
        /// </summary>
        public unsafe static uint[] CreateMemoryObjectsEXT(int n) {
            uint[] memoryObjects = new uint[n];
            fixed (uint* pMemoryObjects = &memoryObjects[0]) {
                GLNative.glCreateMemoryObjectsEXT(n, pMemoryObjects);
            }
            return memoryObjects;
        }

        // [not processed] - void MemoryObjectParameterivEXT(uint memoryObject,uint pname,int* ps)
        /// <summary>
        /// [Overload] - void GetMemoryObjectParameterivEXT(uint memoryObject,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetMemoryObjectParameterivEXT(uint memoryObject, uint pname) {
            int ps = 0;
            GLNative.glGetMemoryObjectParameterivEXT(memoryObject, pname, &ps);
            return ps;
        }


        #endregion GL_EXT_memory_object

        #region GL_EXT_memory_object_fd


        #endregion GL_EXT_memory_object_fd

        #region GL_EXT_memory_object_win32

        // [not processed] - void ImportMemoryWin32HandleEXT(uint memory,UInt64 size,uint handleType,void* handle)
        // [not processed] - void ImportMemoryWin32NameEXT(uint memory,UInt64 size,uint handleType,void* name)

        #endregion GL_EXT_memory_object_win32

        #region GL_EXT_multi_draw_arrays

        // [not processed] - void MultiDrawArraysEXT(uint mode,int* first,int* count,int primcount)
        // [ignore] - void MultiDrawElementsEXT(uint mode,int* count,uint type,IntPtr indices,int primcount)

        #endregion GL_EXT_multi_draw_arrays

        #region GL_EXT_multisample


        #endregion GL_EXT_multisample

        #region GL_EXT_paletted_texture

        // [not processed] - void ColorTableEXT(uint target,uint internalFormat,int width,uint format,uint type,void* table)
        // [ignore] - void GetColorTableEXT(uint target,uint format,uint type,void* data)
        /// <summary>
        /// [Overload] - void GetColorTableParameterivEXT(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetColorTableParameterivEXT(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetColorTableParameterivEXT(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetColorTableParameterfvEXT(uint target,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetColorTableParameterfvEXT(uint target, uint pname) {
            float ps = 0;
            GLNative.glGetColorTableParameterfvEXT(target, pname, &ps);
            return ps;
        }


        #endregion GL_EXT_paletted_texture

        #region GL_EXT_pixel_transform

        // [not processed] - void PixelTransformParameterivEXT(uint target,uint pname,int* ps)
        // [not processed] - void PixelTransformParameterfvEXT(uint target,uint pname,float* ps)
        /// <summary>
        /// [Overload] - void GetPixelTransformParameterivEXT(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetPixelTransformParameterivEXT(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetPixelTransformParameterivEXT(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetPixelTransformParameterfvEXT(uint target,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetPixelTransformParameterfvEXT(uint target, uint pname) {
            float ps = 0;
            GLNative.glGetPixelTransformParameterfvEXT(target, pname, &ps);
            return ps;
        }


        #endregion GL_EXT_pixel_transform

        #region GL_EXT_point_parameters

        // [not processed] - void PointParameterfvEXT(uint pname,float* ps)

        #endregion GL_EXT_point_parameters

        #region GL_EXT_polygon_offset


        #endregion GL_EXT_polygon_offset

        #region GL_EXT_polygon_offset_clamp


        #endregion GL_EXT_polygon_offset_clamp

        #region GL_EXT_provoking_vertex


        #endregion GL_EXT_provoking_vertex

        #region GL_EXT_raster_multisample


        #endregion GL_EXT_raster_multisample

        #region GL_EXT_semaphore

        /// <summary>
        /// [Overload] - void GenSemaphoresEXT(int n,uint* semaphores)
        /// </summary>
        public unsafe static uint GenSemaphoresEXT() {
            uint semaphores = 0;
            GLNative.glGenSemaphoresEXT(1, &semaphores);
            return semaphores;
        }

        /// <summary>
        /// [Overload] - void GenSemaphoresEXT(int n,uint* semaphores)
        /// </summary>
        public unsafe static uint[] GenSemaphoresEXT(int n) {
            uint[] semaphores = new uint[n];
            fixed (uint* pSemaphores = &semaphores[0]) {
                GLNative.glGenSemaphoresEXT(n, pSemaphores);
            }
            return semaphores;
        }

        /// <summary>
        /// [Overload] - void DeleteSemaphoresEXT(int n,uint* semaphores)
        /// </summary>
        public unsafe static void DeleteSemaphoresEXT(uint[] semaphores) {
            fixed (uint* pSemaphores = &semaphores[0]) {
                GLNative.glDeleteSemaphoresEXT(semaphores.Length, pSemaphores);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteSemaphoresEXT(int n,uint* semaphores)
        /// </summary>
        public unsafe static void DeleteSemaphoresEXT(uint[] semaphores, int n) {
            fixed (uint* pSemaphores = &semaphores[0]) {
                GLNative.glDeleteSemaphoresEXT(n, pSemaphores);
            }
        }

        // [not processed] - void SemaphoreParameterui64vEXT(uint semaphore,uint pname,UInt64* ps)
        /// <summary>
        /// [Overload] - void GetSemaphoreParameterui64vEXT(uint semaphore,uint pname,UInt64* ps)
        /// </summary>
        public unsafe static UInt64 GetSemaphoreParameterui64vEXT(uint semaphore, uint pname) {
            UInt64 ps = 0;
            GLNative.glGetSemaphoreParameterui64vEXT(semaphore, pname, &ps);
            return ps;
        }

        // [not processed] - void WaitSemaphoreEXT(uint semaphore,uint numBufferBarriers,uint* buffers,uint numTextureBarriers,uint* textures,uint* srcLayouts)
        // [not processed] - void SignalSemaphoreEXT(uint semaphore,uint numBufferBarriers,uint* buffers,uint numTextureBarriers,uint* textures,uint* dstLayouts)

        #endregion GL_EXT_semaphore

        #region GL_EXT_semaphore_fd


        #endregion GL_EXT_semaphore_fd

        #region GL_EXT_semaphore_win32

        // [not processed] - void ImportSemaphoreWin32HandleEXT(uint semaphore,uint handleType,void* handle)
        // [not processed] - void ImportSemaphoreWin32NameEXT(uint semaphore,uint handleType,void* name)

        #endregion GL_EXT_semaphore_win32

        #region GL_EXT_secondary_color

        // [not processed] - void SecondaryColor3bvEXT(byte* v)
        // [not processed] - void SecondaryColor3dvEXT(double* v)
        // [not processed] - void SecondaryColor3fvEXT(float* v)
        // [not processed] - void SecondaryColor3ivEXT(int* v)
        // [not processed] - void SecondaryColor3svEXT(short* v)
        // [not processed] - void SecondaryColor3ubvEXT(byte* v)
        // [not processed] - void SecondaryColor3uivEXT(uint* v)
        // [not processed] - void SecondaryColor3usvEXT(ushort* v)
        // [not processed] - void SecondaryColorPointerEXT(int size,uint type,int stride,void* pointer)

        #endregion GL_EXT_secondary_color

        #region GL_EXT_separate_shader_objects

        // [not processed] - uint CreateShaderProgramEXT(uint type,byte* str)
        // [not processed] - uint CreateShaderProgramvEXT(uint type,int count,byte** strings)
        /// <summary>
        /// [Overload] - void DeleteProgramPipelinesEXT(int n,uint* pipelines)
        /// </summary>
        public unsafe static void DeleteProgramPipelinesEXT(uint[] pipelines) {
            fixed (uint* pPipelines = &pipelines[0]) {
                GLNative.glDeleteProgramPipelinesEXT(pipelines.Length, pPipelines);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteProgramPipelinesEXT(int n,uint* pipelines)
        /// </summary>
        public unsafe static void DeleteProgramPipelinesEXT(uint[] pipelines, int n) {
            fixed (uint* pPipelines = &pipelines[0]) {
                GLNative.glDeleteProgramPipelinesEXT(n, pPipelines);
            }
        }

        /// <summary>
        /// [Overload] - void GenProgramPipelinesEXT(int n,uint* pipelines)
        /// </summary>
        public unsafe static uint GenProgramPipelinesEXT() {
            uint pipelines = 0;
            GLNative.glGenProgramPipelinesEXT(1, &pipelines);
            return pipelines;
        }

        /// <summary>
        /// [Overload] - void GenProgramPipelinesEXT(int n,uint* pipelines)
        /// </summary>
        public unsafe static uint[] GenProgramPipelinesEXT(int n) {
            uint[] pipelines = new uint[n];
            fixed (uint* pPipelines = &pipelines[0]) {
                GLNative.glGenProgramPipelinesEXT(n, pPipelines);
            }
            return pipelines;
        }

        /// <summary>
        /// [Overload] - void GetProgramPipelineInfoLogEXT(uint pipeline,int bufSize,int* length,byte* infoLog)
        /// </summary>
        public unsafe static string GetProgramPipelineInfoLogEXT(uint pipeline) {
            int length = 0;
            byte[] infoLog = new byte[1024];
            fixed (byte* pInfoLog = &infoLog[0]) {
                GLNative.glGetProgramPipelineInfoLogEXT(pipeline, infoLog.Length, &length, pInfoLog);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(infoLog, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetProgramPipelineInfoLogEXT(uint pipeline,int bufSize,int* length,byte* infoLog)
        /// </summary>
        public unsafe static string GetProgramPipelineInfoLogEXT(uint pipeline, int bufSize) {
            int length = 0;
            byte[] infoLog = new byte[bufSize];
            fixed (byte* pInfoLog = &infoLog[0]) {
                GLNative.glGetProgramPipelineInfoLogEXT(pipeline, bufSize, &length, pInfoLog);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(infoLog, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetProgramPipelineivEXT(uint pipeline,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetProgramPipelineivEXT(uint pipeline, uint pname) {
            int ps = 0;
            GLNative.glGetProgramPipelineivEXT(pipeline, pname, &ps);
            return ps;
        }

        // [not processed] - void ProgramUniform1fvEXT(uint program,int location,int count,float* value)
        // [not processed] - void ProgramUniform1ivEXT(uint program,int location,int count,int* value)
        // [not processed] - void ProgramUniform2fvEXT(uint program,int location,int count,float* value)
        // [not processed] - void ProgramUniform2ivEXT(uint program,int location,int count,int* value)
        // [not processed] - void ProgramUniform3fvEXT(uint program,int location,int count,float* value)
        // [not processed] - void ProgramUniform3ivEXT(uint program,int location,int count,int* value)
        // [not processed] - void ProgramUniform4fvEXT(uint program,int location,int count,float* value)
        // [not processed] - void ProgramUniform4ivEXT(uint program,int location,int count,int* value)
        // [not processed] - void ProgramUniformMatrix2fvEXT(uint program,int location,int count,bool transpose,float* value)
        // [not processed] - void ProgramUniformMatrix3fvEXT(uint program,int location,int count,bool transpose,float* value)
        // [not processed] - void ProgramUniformMatrix4fvEXT(uint program,int location,int count,bool transpose,float* value)
        // [not processed] - void ProgramUniform1uivEXT(uint program,int location,int count,uint* value)
        // [not processed] - void ProgramUniform2uivEXT(uint program,int location,int count,uint* value)
        // [not processed] - void ProgramUniform3uivEXT(uint program,int location,int count,uint* value)
        // [not processed] - void ProgramUniform4uivEXT(uint program,int location,int count,uint* value)
        // [not processed] - void ProgramUniformMatrix2x3fvEXT(uint program,int location,int count,bool transpose,float* value)
        // [not processed] - void ProgramUniformMatrix3x2fvEXT(uint program,int location,int count,bool transpose,float* value)
        // [not processed] - void ProgramUniformMatrix2x4fvEXT(uint program,int location,int count,bool transpose,float* value)
        // [not processed] - void ProgramUniformMatrix4x2fvEXT(uint program,int location,int count,bool transpose,float* value)
        // [not processed] - void ProgramUniformMatrix3x4fvEXT(uint program,int location,int count,bool transpose,float* value)
        // [not processed] - void ProgramUniformMatrix4x3fvEXT(uint program,int location,int count,bool transpose,float* value)

        #endregion GL_EXT_separate_shader_objects

        #region GL_EXT_shader_framebuffer_fetch_non_coherent


        #endregion GL_EXT_shader_framebuffer_fetch_non_coherent

        #region GL_EXT_shader_image_load_store


        #endregion GL_EXT_shader_image_load_store

        #region GL_EXT_stencil_clear_tag


        #endregion GL_EXT_stencil_clear_tag

        #region GL_EXT_stencil_two_side


        #endregion GL_EXT_stencil_two_side

        #region GL_EXT_subtexture

        // [not processed] - void TexSubImage1DEXT(uint target,int level,int xoffset,int width,uint format,uint type,void* pixels)
        // [not processed] - void TexSubImage2DEXT(uint target,int level,int xoffset,int yoffset,int width,int height,uint format,uint type,void* pixels)

        #endregion GL_EXT_subtexture

        #region GL_EXT_texture3D

        // [not processed] - void TexImage3DEXT(uint target,int level,uint internalformat,int width,int height,int depth,int border,uint format,uint type,void* pixels)
        // [not processed] - void TexSubImage3DEXT(uint target,int level,int xoffset,int yoffset,int zoffset,int width,int height,int depth,uint format,uint type,void* pixels)

        #endregion GL_EXT_texture3D

        #region GL_EXT_texture_array


        #endregion GL_EXT_texture_array

        #region GL_EXT_texture_buffer_object


        #endregion GL_EXT_texture_buffer_object

        #region GL_EXT_texture_integer

        // [not processed] - void TexParameterIivEXT(uint target,uint pname,int* ps)
        // [not processed] - void TexParameterIuivEXT(uint target,uint pname,uint* ps)
        /// <summary>
        /// [Overload] - void GetTexParameterIivEXT(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetTexParameterIivEXT(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetTexParameterIivEXT(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetTexParameterIuivEXT(uint target,uint pname,uint* ps)
        /// </summary>
        public unsafe static uint GetTexParameterIuivEXT(uint target, uint pname) {
            uint ps = 0;
            GLNative.glGetTexParameterIuivEXT(target, pname, &ps);
            return ps;
        }


        #endregion GL_EXT_texture_integer

        #region GL_EXT_texture_object

        // [not processed] - bool AreTexturesResidentEXT(int n,uint* textures,bool* residences)
        /// <summary>
        /// [Overload] - void DeleteTexturesEXT(int n,uint* textures)
        /// </summary>
        public unsafe static void DeleteTexturesEXT(uint[] textures) {
            fixed (uint* pTextures = &textures[0]) {
                GLNative.glDeleteTexturesEXT(textures.Length, pTextures);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteTexturesEXT(int n,uint* textures)
        /// </summary>
        public unsafe static void DeleteTexturesEXT(uint[] textures, int n) {
            fixed (uint* pTextures = &textures[0]) {
                GLNative.glDeleteTexturesEXT(n, pTextures);
            }
        }

        /// <summary>
        /// [Overload] - void GenTexturesEXT(int n,uint* textures)
        /// </summary>
        public unsafe static uint GenTexturesEXT() {
            uint textures = 0;
            GLNative.glGenTexturesEXT(1, &textures);
            return textures;
        }

        /// <summary>
        /// [Overload] - void GenTexturesEXT(int n,uint* textures)
        /// </summary>
        public unsafe static uint[] GenTexturesEXT(int n) {
            uint[] textures = new uint[n];
            fixed (uint* pTextures = &textures[0]) {
                GLNative.glGenTexturesEXT(n, pTextures);
            }
            return textures;
        }

        // [not processed] - void PrioritizeTexturesEXT(int n,uint* textures,float* priorities)

        #endregion GL_EXT_texture_object

        #region GL_EXT_texture_perturb_normal


        #endregion GL_EXT_texture_perturb_normal

        #region GL_EXT_texture_storage


        #endregion GL_EXT_texture_storage

        #region GL_NV_timeline_semaphore

        /// <summary>
        /// [Overload] - void CreateSemaphoresNV(int n,uint* semaphores)
        /// </summary>
        public unsafe static uint CreateSemaphoresNV() {
            uint semaphores = 0;
            GLNative.glCreateSemaphoresNV(1, &semaphores);
            return semaphores;
        }

        /// <summary>
        /// [Overload] - void CreateSemaphoresNV(int n,uint* semaphores)
        /// </summary>
        public unsafe static uint[] CreateSemaphoresNV(int n) {
            uint[] semaphores = new uint[n];
            fixed (uint* pSemaphores = &semaphores[0]) {
                GLNative.glCreateSemaphoresNV(n, pSemaphores);
            }
            return semaphores;
        }

        // [not processed] - void SemaphoreParameterivNV(uint semaphore,uint pname,int* ps)
        /// <summary>
        /// [Overload] - void GetSemaphoreParameterivNV(uint semaphore,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetSemaphoreParameterivNV(uint semaphore, uint pname) {
            int ps = 0;
            GLNative.glGetSemaphoreParameterivNV(semaphore, pname, &ps);
            return ps;
        }


        #endregion GL_NV_timeline_semaphore

        #region GL_EXT_timer_query

        /// <summary>
        /// [Overload] - void GetQueryObjecti64vEXT(uint id,uint pname,UInt64* ps)
        /// </summary>
        public unsafe static UInt64 GetQueryObjecti64vEXT(uint id, uint pname) {
            UInt64 ps = 0;
            GLNative.glGetQueryObjecti64vEXT(id, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetQueryObjectui64vEXT(uint id,uint pname,UInt64* ps)
        /// </summary>
        public unsafe static UInt64 GetQueryObjectui64vEXT(uint id, uint pname) {
            UInt64 ps = 0;
            GLNative.glGetQueryObjectui64vEXT(id, pname, &ps);
            return ps;
        }


        #endregion GL_EXT_timer_query

        #region GL_EXT_transform_feedback

        // [not processed] - void TransformFeedbackVaryingsEXT(uint program,int count,byte** varyings,uint bufferMode)
        // [not processed] - void GetTransformFeedbackVaryingEXT(uint program,uint index,int bufSize,int* length,int* size,uint* type,byte* name)

        #endregion GL_EXT_transform_feedback

        #region GL_EXT_vertex_array

        // [not processed] - void ColorPointerEXT(int size,uint type,int stride,int count,void* pointer)
        // [not processed] - void EdgeFlagPointerEXT(int stride,int count,bool* pointer)
        // [not processed] - void GetPointervEXT(uint pname,void** ps)
        // [not processed] - void IndexPointerEXT(uint type,int stride,int count,void* pointer)
        // [not processed] - void NormalPointerEXT(uint type,int stride,int count,void* pointer)
        // [not processed] - void TexCoordPointerEXT(int size,uint type,int stride,int count,void* pointer)
        // [not processed] - void VertexPointerEXT(int size,uint type,int stride,int count,void* pointer)

        #endregion GL_EXT_vertex_array

        #region GL_EXT_vertex_attrib_64bit

        // [not processed] - void VertexAttribL1dvEXT(uint index,double* v)
        // [not processed] - void VertexAttribL2dvEXT(uint index,double* v)
        // [not processed] - void VertexAttribL3dvEXT(uint index,double* v)
        // [not processed] - void VertexAttribL4dvEXT(uint index,double* v)
        // [not processed] - void VertexAttribLPointerEXT(uint index,int size,uint type,int stride,void* pointer)
        /// <summary>
        /// [Overload] - void GetVertexAttribLdvEXT(uint index,uint pname,double* ps)
        /// </summary>
        public unsafe static double GetVertexAttribLdvEXT(uint index, uint pname) {
            double ps = 0;
            GLNative.glGetVertexAttribLdvEXT(index, pname, &ps);
            return ps;
        }


        #endregion GL_EXT_vertex_attrib_64bit

        #region GL_EXT_vertex_shader

        // [not processed] - void SetInvariantEXT(uint id,uint type,void* addr)
        // [not processed] - void SetLocalConstantEXT(uint id,uint type,void* addr)
        // [not processed] - void VariantbvEXT(uint id,byte* addr)
        // [not processed] - void VariantsvEXT(uint id,short* addr)
        // [not processed] - void VariantivEXT(uint id,int* addr)
        // [not processed] - void VariantfvEXT(uint id,float* addr)
        // [not processed] - void VariantdvEXT(uint id,double* addr)
        // [not processed] - void VariantubvEXT(uint id,byte* addr)
        // [not processed] - void VariantusvEXT(uint id,ushort* addr)
        // [not processed] - void VariantuivEXT(uint id,uint* addr)
        // [not processed] - void VariantPointerEXT(uint id,uint type,uint stride,void* addr)
        /// <summary>
        /// [Overload] - void GetVariantBooleanvEXT(uint id,uint value,bool* data)
        /// </summary>
        public unsafe static bool GetVariantBooleanvEXT(uint id, uint value) {
            bool data = false;
            GLNative.glGetVariantBooleanvEXT(id, value, &data);
            return data;
        }

        /// <summary>
        /// [Overload] - void GetVariantIntegervEXT(uint id,uint value,int* data)
        /// </summary>
        public unsafe static int GetVariantIntegervEXT(uint id, uint value) {
            int data = 0;
            GLNative.glGetVariantIntegervEXT(id, value, &data);
            return data;
        }

        /// <summary>
        /// [Overload] - void GetVariantFloatvEXT(uint id,uint value,float* data)
        /// </summary>
        public unsafe static float GetVariantFloatvEXT(uint id, uint value) {
            float data = 0;
            GLNative.glGetVariantFloatvEXT(id, value, &data);
            return data;
        }

        // [not processed] - void GetVariantPointervEXT(uint id,uint value,void** data)
        /// <summary>
        /// [Overload] - void GetInvariantBooleanvEXT(uint id,uint value,bool* data)
        /// </summary>
        public unsafe static bool GetInvariantBooleanvEXT(uint id, uint value) {
            bool data = false;
            GLNative.glGetInvariantBooleanvEXT(id, value, &data);
            return data;
        }

        /// <summary>
        /// [Overload] - void GetInvariantIntegervEXT(uint id,uint value,int* data)
        /// </summary>
        public unsafe static int GetInvariantIntegervEXT(uint id, uint value) {
            int data = 0;
            GLNative.glGetInvariantIntegervEXT(id, value, &data);
            return data;
        }

        /// <summary>
        /// [Overload] - void GetInvariantFloatvEXT(uint id,uint value,float* data)
        /// </summary>
        public unsafe static float GetInvariantFloatvEXT(uint id, uint value) {
            float data = 0;
            GLNative.glGetInvariantFloatvEXT(id, value, &data);
            return data;
        }

        /// <summary>
        /// [Overload] - void GetLocalConstantBooleanvEXT(uint id,uint value,bool* data)
        /// </summary>
        public unsafe static bool GetLocalConstantBooleanvEXT(uint id, uint value) {
            bool data = false;
            GLNative.glGetLocalConstantBooleanvEXT(id, value, &data);
            return data;
        }

        /// <summary>
        /// [Overload] - void GetLocalConstantIntegervEXT(uint id,uint value,int* data)
        /// </summary>
        public unsafe static int GetLocalConstantIntegervEXT(uint id, uint value) {
            int data = 0;
            GLNative.glGetLocalConstantIntegervEXT(id, value, &data);
            return data;
        }

        /// <summary>
        /// [Overload] - void GetLocalConstantFloatvEXT(uint id,uint value,float* data)
        /// </summary>
        public unsafe static float GetLocalConstantFloatvEXT(uint id, uint value) {
            float data = 0;
            GLNative.glGetLocalConstantFloatvEXT(id, value, &data);
            return data;
        }


        #endregion GL_EXT_vertex_shader

        #region GL_EXT_vertex_weighting

        // [not processed] - void VertexWeightfvEXT(float* weight)
        // [not processed] - void VertexWeightPointerEXT(int size,uint type,int stride,void* pointer)

        #endregion GL_EXT_vertex_weighting

        #region GL_EXT_win32_keyed_mutex


        #endregion GL_EXT_win32_keyed_mutex

        #region GL_EXT_window_rectangles

        // [not processed] - void WindowRectanglesEXT(uint mode,int count,int* box)

        #endregion GL_EXT_window_rectangles

        #region GL_EXT_x11_sync_object


        #endregion GL_EXT_x11_sync_object

        #region GL_GREMEDY_frame_terminator


        #endregion GL_GREMEDY_frame_terminator

        #region GL_GREMEDY_string_marker

        // [not processed] - void StringMarkerGREMEDY(int len,void* str)

        #endregion GL_GREMEDY_string_marker

        #region GL_HP_image_transform

        // [not processed] - void ImageTransformParameterivHP(uint target,uint pname,int* ps)
        // [not processed] - void ImageTransformParameterfvHP(uint target,uint pname,float* ps)
        /// <summary>
        /// [Overload] - void GetImageTransformParameterivHP(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetImageTransformParameterivHP(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetImageTransformParameterivHP(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetImageTransformParameterfvHP(uint target,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetImageTransformParameterfvHP(uint target, uint pname) {
            float ps = 0;
            GLNative.glGetImageTransformParameterfvHP(target, pname, &ps);
            return ps;
        }


        #endregion GL_HP_image_transform

        #region GL_IBM_multimode_draw_arrays

        // [not processed] - void MultiModeDrawArraysIBM(uint* mode,int* first,int* count,int primcount,int modestride)
        // [not processed] - void MultiModeDrawElementsIBM(uint* mode,int* count,uint type,IntPtr indices,int primcount,int modestride)

        #endregion GL_IBM_multimode_draw_arrays

        #region GL_IBM_static_data


        #endregion GL_IBM_static_data

        #region GL_IBM_vertex_array_lists

        // [not processed] - void ColorPointerListIBM(int size,uint type,int stride,void** pointer,int ptrstride)
        // [not processed] - void SecondaryColorPointerListIBM(int size,uint type,int stride,void** pointer,int ptrstride)
        // [not processed] - void EdgeFlagPointerListIBM(int stride,bool** pointer,int ptrstride)
        // [not processed] - void FogCoordPointerListIBM(uint type,int stride,void** pointer,int ptrstride)
        // [not processed] - void IndexPointerListIBM(uint type,int stride,void** pointer,int ptrstride)
        // [not processed] - void NormalPointerListIBM(uint type,int stride,void** pointer,int ptrstride)
        // [not processed] - void TexCoordPointerListIBM(int size,uint type,int stride,void** pointer,int ptrstride)
        // [not processed] - void VertexPointerListIBM(int size,uint type,int stride,void** pointer,int ptrstride)

        #endregion GL_IBM_vertex_array_lists

        #region GL_INGR_blend_func_separate


        #endregion GL_INGR_blend_func_separate

        #region GL_INTEL_framebuffer_CMAA


        #endregion GL_INTEL_framebuffer_CMAA

        #region GL_INTEL_map_texture

        // [not processed] - void* MapTexture2DINTEL(uint texture,int level,uint access,int* stride,uint* layout)

        #endregion GL_INTEL_map_texture

        #region GL_INTEL_parallel_arrays

        // [not processed] - void VertexPointervINTEL(int size,uint type,void** pointer)
        // [not processed] - void NormalPointervINTEL(uint type,void** pointer)
        // [not processed] - void ColorPointervINTEL(int size,uint type,void** pointer)
        // [not processed] - void TexCoordPointervINTEL(int size,uint type,void** pointer)

        #endregion GL_INTEL_parallel_arrays

        #region GL_INTEL_performance_query

        // [ignore] - void CreatePerfQueryINTEL(uint queryId,uint* queryHandle)
        /// <summary>
        /// [Overload] - void GetFirstPerfQueryIdINTEL(uint* queryId)
        /// </summary>
        public unsafe static uint GetFirstPerfQueryIdINTEL() {
            uint queryId = 0;
            GLNative.glGetFirstPerfQueryIdINTEL(&queryId);
            return queryId;
        }

        /// <summary>
        /// [Overload] - void GetNextPerfQueryIdINTEL(uint queryId,uint* nextQueryId)
        /// </summary>
        public unsafe static uint GetNextPerfQueryIdINTEL(uint queryId) {
            uint nextQueryId = 0;
            GLNative.glGetNextPerfQueryIdINTEL(queryId, &nextQueryId);
            return nextQueryId;
        }

        // [not processed] - void GetPerfCounterInfoINTEL(uint queryId,uint counterId,uint counterNameLength,byte* counterName,uint counterDescLength,byte* counterDesc,uint* counterOffset,uint* counterDataSize,uint* counterTypeEnum,uint* counterDataTypeEnum,UInt64* rawCounterMaxValue)
        // [not processed] - void GetPerfQueryDataINTEL(uint queryHandle,uint flags,int dataSize,void* data,uint* bytesWritten)
        // [not processed] - void GetPerfQueryIdByNameINTEL(byte* queryName,uint* queryId)
        // [not processed] - void GetPerfQueryInfoINTEL(uint queryId,uint queryNameLength,byte* queryName,uint* dataSize,uint* noCounters,uint* noInstances,uint* capsMask)

        #endregion GL_INTEL_performance_query

        #region GL_KHR_blend_equation_advanced


        #endregion GL_KHR_blend_equation_advanced

        #region GL_KHR_debug

        // [not processed] - void DebugMessageControlKHR(uint source,uint type,uint severity,int count,uint* ids,bool enabled)
        /// <summary>
        /// [Overload] - void DebugMessageInsertKHR(uint source,uint type,uint id,uint severity,int length,byte* buf)
        /// </summary>
        public unsafe static void DebugMessageInsertKHR(uint source, uint type, uint id, uint severity, string buf) {
            byte[] byBuffer = Encoding.UTF8.GetBytes(buf);
            fixed (byte* pBuf = &byBuffer[0]) {
                GLNative.glDebugMessageInsertKHR(source, type, id, severity, buf.Length, pBuf);
            }
        }

        // [not processed] - void DebugMessageCallbackKHR(GLDEBUGPROCKHR callback,void* userParam)
        // [not processed] - uint GetDebugMessageLogKHR(uint count,int bufSize,uint* sources,uint* types,uint* ids,uint* severities,int* lengths,byte* messageLog)
        /// <summary>
        /// [Overload] - void PushDebugGroupKHR(uint source,uint id,int length,byte* message)
        /// </summary>
        public unsafe static void PushDebugGroupKHR(uint source, uint id, string message) {
            byte[] byBuffer = Encoding.UTF8.GetBytes(message);
            fixed (byte* pMessage = &byBuffer[0]) {
                GLNative.glPushDebugGroupKHR(source, id, message.Length, pMessage);
            }
        }

        /// <summary>
        /// [Overload] - void ObjectLabelKHR(uint identifier,uint name,int length,byte* label)
        /// </summary>
        public unsafe static void ObjectLabelKHR(uint identifier, uint name, string label) {
            byte[] byBuffer = Encoding.UTF8.GetBytes(label);
            fixed (byte* pLabel = &byBuffer[0]) {
                GLNative.glObjectLabelKHR(identifier, name, label.Length, pLabel);
            }
        }

        /// <summary>
        /// [Overload] - void GetObjectLabelKHR(uint identifier,uint name,int bufSize,int* length,byte* label)
        /// </summary>
        public unsafe static string GetObjectLabelKHR(uint identifier, uint name) {
            int length = 0;
            byte[] label = new byte[1024];
            fixed (byte* pLabel = &label[0]) {
                GLNative.glGetObjectLabelKHR(identifier, name, label.Length, &length, pLabel);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(label, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetObjectLabelKHR(uint identifier,uint name,int bufSize,int* length,byte* label)
        /// </summary>
        public unsafe static string GetObjectLabelKHR(uint identifier, uint name, int bufSize) {
            int length = 0;
            byte[] label = new byte[bufSize];
            fixed (byte* pLabel = &label[0]) {
                GLNative.glGetObjectLabelKHR(identifier, name, bufSize, &length, pLabel);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(label, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void ObjectPtrLabelKHR(void* ptr,int length,byte* label)
        /// </summary>
        public unsafe static void ObjectPtrLabelKHR(IntPtr ptr, string label) {
            byte[] byBuffer = Encoding.UTF8.GetBytes(label);
            fixed (byte* pLabel = &byBuffer[0]) {
                GLNative.glObjectPtrLabelKHR((void*)ptr, label.Length, pLabel);
            }
        }

        /// <summary>
        /// [Overload] - void GetObjectPtrLabelKHR(void* ptr,int bufSize,int* length,byte* label)
        /// </summary>
        public unsafe static string GetObjectPtrLabelKHR(IntPtr ptr) {
            int length = 0;
            byte[] label = new byte[1024];
            fixed (byte* pLabel = &label[0]) {
                GLNative.glGetObjectPtrLabelKHR((void*)ptr, label.Length, &length, pLabel);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(label, 0, length);
            }
        }

        /// <summary>
        /// [Overload] - void GetObjectPtrLabelKHR(void* ptr,int bufSize,int* length,byte* label)
        /// </summary>
        public unsafe static string GetObjectPtrLabelKHR(IntPtr ptr, int bufSize) {
            int length = 0;
            byte[] label = new byte[bufSize];
            fixed (byte* pLabel = &label[0]) {
                GLNative.glGetObjectPtrLabelKHR((void*)ptr, bufSize, &length, pLabel);
                if (length == 0) return null;
                return Encoding.UTF8.GetString(label, 0, length);
            }
        }

        // [not processed] - void GetPointervKHR(uint pname,void** ps)

        #endregion GL_KHR_debug

        #region GL_KHR_robustness

        // [not processed] - void ReadnPixelsKHR(int x,int y,int width,int height,uint format,uint type,int bufSize,void* data)
        /// <summary>
        /// [Overload] - void GetnUniformfvKHR(uint program,int location,int bufSize,float* ps)
        /// </summary>
        public unsafe static float GetnUniformfvKHR(uint program, int location, int bufSize) {
            float ps = 0;
            GLNative.glGetnUniformfvKHR(program, location, bufSize, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetnUniformivKHR(uint program,int location,int bufSize,int* ps)
        /// </summary>
        public unsafe static int GetnUniformivKHR(uint program, int location, int bufSize) {
            int ps = 0;
            GLNative.glGetnUniformivKHR(program, location, bufSize, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetnUniformuivKHR(uint program,int location,int bufSize,uint* ps)
        /// </summary>
        public unsafe static uint GetnUniformuivKHR(uint program, int location, int bufSize) {
            uint ps = 0;
            GLNative.glGetnUniformuivKHR(program, location, bufSize, &ps);
            return ps;
        }


        #endregion GL_KHR_robustness

        #region GL_KHR_parallel_shader_compile


        #endregion GL_KHR_parallel_shader_compile

        #region GL_MESA_framebuffer_flip_y

        /// <summary>
        /// [Overload] - void GetFramebufferParameterivMESA(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetFramebufferParameterivMESA(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetFramebufferParameterivMESA(target, pname, &ps);
            return ps;
        }


        #endregion GL_MESA_framebuffer_flip_y

        #region GL_MESA_resize_buffers


        #endregion GL_MESA_resize_buffers

        #region GL_MESA_window_pos

        // [not processed] - void WindowPos2dvMESA(double* v)
        // [not processed] - void WindowPos2fvMESA(float* v)
        // [not processed] - void WindowPos2ivMESA(int* v)
        // [not processed] - void WindowPos2svMESA(short* v)
        // [not processed] - void WindowPos3dvMESA(double* v)
        // [not processed] - void WindowPos3fvMESA(float* v)
        // [not processed] - void WindowPos3ivMESA(int* v)
        // [not processed] - void WindowPos3svMESA(short* v)
        // [not processed] - void WindowPos4dvMESA(double* v)
        // [not processed] - void WindowPos4fvMESA(float* v)
        // [not processed] - void WindowPos4ivMESA(int* v)
        // [not processed] - void WindowPos4svMESA(short* v)

        #endregion GL_MESA_window_pos

        #region GL_NVX_conditional_render


        #endregion GL_NVX_conditional_render

        #region GL_NVX_linked_gpu_multicast

        /// <summary>
        /// [Overload] - void LGPUNamedBufferSubDataNVX(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void LGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, IntPtr offset, byte[] data) {
            long size = data.Length * sizeof(byte);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glLGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void LGPUNamedBufferSubDataNVX(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void LGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, IntPtr offset, long size, byte[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glLGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void LGPUNamedBufferSubDataNVX(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void LGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, IntPtr offset, short[] data) {
            long size = data.Length * sizeof(short);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glLGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void LGPUNamedBufferSubDataNVX(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void LGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, IntPtr offset, long size, short[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glLGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void LGPUNamedBufferSubDataNVX(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void LGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, IntPtr offset, ushort[] data) {
            long size = data.Length * sizeof(ushort);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glLGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void LGPUNamedBufferSubDataNVX(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void LGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, IntPtr offset, long size, ushort[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glLGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void LGPUNamedBufferSubDataNVX(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void LGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, IntPtr offset, int[] data) {
            long size = data.Length * sizeof(int);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glLGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void LGPUNamedBufferSubDataNVX(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void LGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, IntPtr offset, long size, int[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glLGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void LGPUNamedBufferSubDataNVX(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void LGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, IntPtr offset, uint[] data) {
            long size = data.Length * sizeof(uint);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glLGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void LGPUNamedBufferSubDataNVX(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void LGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, IntPtr offset, long size, uint[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glLGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void LGPUNamedBufferSubDataNVX(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void LGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, IntPtr offset, float[] data) {
            long size = data.Length * sizeof(float);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glLGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void LGPUNamedBufferSubDataNVX(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void LGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, IntPtr offset, long size, float[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glLGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        // [not processed] - void LGPUNamedBufferSubDataNVX(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)

        #endregion GL_NVX_linked_gpu_multicast

        #region GL_NV_alpha_to_coverage_dither_control


        #endregion GL_NV_alpha_to_coverage_dither_control

        #region GL_NV_bindless_multi_draw_indirect

        // [not processed] - void MultiDrawArraysIndirectBindlessNV(uint mode,void* indirect,int drawCount,int stride,int vertexBufferCount)
        // [not processed] - void MultiDrawElementsIndirectBindlessNV(uint mode,uint type,void* indirect,int drawCount,int stride,int vertexBufferCount)

        #endregion GL_NV_bindless_multi_draw_indirect

        #region GL_NV_bindless_multi_draw_indirect_count

        // [not processed] - void MultiDrawArraysIndirectBindlessCountNV(uint mode,void* indirect,int drawCount,int maxDrawCount,int stride,int vertexBufferCount)
        // [not processed] - void MultiDrawElementsIndirectBindlessCountNV(uint mode,uint type,void* indirect,int drawCount,int maxDrawCount,int stride,int vertexBufferCount)

        #endregion GL_NV_bindless_multi_draw_indirect_count

        #region GL_NV_bindless_texture

        // [not processed] - void UniformHandleui64vNV(int location,int count,UInt64* value)
        // [not processed] - void ProgramUniformHandleui64vNV(uint program,int location,int count,UInt64* values)

        #endregion GL_NV_bindless_texture

        #region GL_NV_blend_equation_advanced


        #endregion GL_NV_blend_equation_advanced

        #region GL_NV_clip_space_w_scaling


        #endregion GL_NV_clip_space_w_scaling

        #region GL_NV_command_list

        /// <summary>
        /// [Overload] - void CreateStatesNV(int n,uint* states)
        /// </summary>
        public unsafe static uint CreateStatesNV() {
            uint states = 0;
            GLNative.glCreateStatesNV(1, &states);
            return states;
        }

        /// <summary>
        /// [Overload] - void CreateStatesNV(int n,uint* states)
        /// </summary>
        public unsafe static uint[] CreateStatesNV(int n) {
            uint[] states = new uint[n];
            fixed (uint* pStates = &states[0]) {
                GLNative.glCreateStatesNV(n, pStates);
            }
            return states;
        }

        /// <summary>
        /// [Overload] - void DeleteStatesNV(int n,uint* states)
        /// </summary>
        public unsafe static void DeleteStatesNV(uint[] states) {
            fixed (uint* pStates = &states[0]) {
                GLNative.glDeleteStatesNV(states.Length, pStates);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteStatesNV(int n,uint* states)
        /// </summary>
        public unsafe static void DeleteStatesNV(uint[] states, int n) {
            fixed (uint* pStates = &states[0]) {
                GLNative.glDeleteStatesNV(n, pStates);
            }
        }

        // [not processed] - void DrawCommandsNV(uint primitiveMode,uint buffer,IntPtr indirects,int* sizes,uint count)
        // [not processed] - void DrawCommandsAddressNV(uint primitiveMode,UInt64* indirects,int* sizes,uint count)
        // [not processed] - void DrawCommandsStatesNV(uint buffer,IntPtr indirects,int* sizes,uint* states,uint* fbos,uint count)
        // [not processed] - void DrawCommandsStatesAddressNV(UInt64* indirects,int* sizes,uint* states,uint* fbos,uint count)
        /// <summary>
        /// [Overload] - void CreateCommandListsNV(int n,uint* lists)
        /// </summary>
        public unsafe static uint CreateCommandListsNV() {
            uint lists = 0;
            GLNative.glCreateCommandListsNV(1, &lists);
            return lists;
        }

        /// <summary>
        /// [Overload] - void CreateCommandListsNV(int n,uint* lists)
        /// </summary>
        public unsafe static uint[] CreateCommandListsNV(int n) {
            uint[] lists = new uint[n];
            fixed (uint* pLists = &lists[0]) {
                GLNative.glCreateCommandListsNV(n, pLists);
            }
            return lists;
        }

        /// <summary>
        /// [Overload] - void DeleteCommandListsNV(int n,uint* lists)
        /// </summary>
        public unsafe static void DeleteCommandListsNV(uint[] lists) {
            fixed (uint* pLists = &lists[0]) {
                GLNative.glDeleteCommandListsNV(lists.Length, pLists);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteCommandListsNV(int n,uint* lists)
        /// </summary>
        public unsafe static void DeleteCommandListsNV(uint[] lists, int n) {
            fixed (uint* pLists = &lists[0]) {
                GLNative.glDeleteCommandListsNV(n, pLists);
            }
        }

        // [not processed] - void ListDrawCommandsStatesClientNV(uint list,uint segment,void** indirects,int* sizes,uint* states,uint* fbos,uint count)

        #endregion GL_NV_command_list

        #region GL_NV_conditional_render


        #endregion GL_NV_conditional_render

        #region GL_NV_conservative_raster


        #endregion GL_NV_conservative_raster

        #region GL_NV_conservative_raster_dilate


        #endregion GL_NV_conservative_raster_dilate

        #region GL_NV_conservative_raster_pre_snap_triangles


        #endregion GL_NV_conservative_raster_pre_snap_triangles

        #region GL_NV_copy_image


        #endregion GL_NV_copy_image

        #region GL_NV_depth_buffer_float


        #endregion GL_NV_depth_buffer_float

        #region GL_NV_draw_texture


        #endregion GL_NV_draw_texture

        #region GL_NV_draw_vulkan_image

        // [not processed] - GLVULKANPROCNV GetVkProcAddrNV(byte* name)

        #endregion GL_NV_draw_vulkan_image

        #region GL_NV_evaluators

        // [not processed] - void MapControlPointsNV(uint target,uint index,uint type,int ustride,int vstride,int uorder,int vorder,bool packed,void* points)
        // [not processed] - void MapParameterivNV(uint target,uint pname,int* ps)
        // [not processed] - void MapParameterfvNV(uint target,uint pname,float* ps)
        // [ignore] - void GetMapControlPointsNV(uint target,uint index,uint type,int ustride,int vstride,bool packed,void* points)
        /// <summary>
        /// [Overload] - void GetMapParameterivNV(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetMapParameterivNV(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetMapParameterivNV(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetMapParameterfvNV(uint target,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetMapParameterfvNV(uint target, uint pname) {
            float ps = 0;
            GLNative.glGetMapParameterfvNV(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetMapAttribParameterivNV(uint target,uint index,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetMapAttribParameterivNV(uint target, uint index, uint pname) {
            int ps = 0;
            GLNative.glGetMapAttribParameterivNV(target, index, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetMapAttribParameterfvNV(uint target,uint index,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetMapAttribParameterfvNV(uint target, uint index, uint pname) {
            float ps = 0;
            GLNative.glGetMapAttribParameterfvNV(target, index, pname, &ps);
            return ps;
        }


        #endregion GL_NV_evaluators

        #region GL_NV_explicit_multisample

        /// <summary>
        /// [Overload] - void GetMultisamplefvNV(uint pname,uint index,float* val)
        /// </summary>
        public unsafe static float GetMultisamplefvNV(uint pname, uint index) {
            float val = 0;
            GLNative.glGetMultisamplefvNV(pname, index, &val);
            return val;
        }


        #endregion GL_NV_explicit_multisample

        #region GL_NV_fence

        /// <summary>
        /// [Overload] - void DeleteFencesNV(int n,uint* fences)
        /// </summary>
        public unsafe static void DeleteFencesNV(uint[] fences) {
            fixed (uint* pFences = &fences[0]) {
                GLNative.glDeleteFencesNV(fences.Length, pFences);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteFencesNV(int n,uint* fences)
        /// </summary>
        public unsafe static void DeleteFencesNV(uint[] fences, int n) {
            fixed (uint* pFences = &fences[0]) {
                GLNative.glDeleteFencesNV(n, pFences);
            }
        }

        /// <summary>
        /// [Overload] - void GenFencesNV(int n,uint* fences)
        /// </summary>
        public unsafe static uint GenFencesNV() {
            uint fences = 0;
            GLNative.glGenFencesNV(1, &fences);
            return fences;
        }

        /// <summary>
        /// [Overload] - void GenFencesNV(int n,uint* fences)
        /// </summary>
        public unsafe static uint[] GenFencesNV(int n) {
            uint[] fences = new uint[n];
            fixed (uint* pFences = &fences[0]) {
                GLNative.glGenFencesNV(n, pFences);
            }
            return fences;
        }

        /// <summary>
        /// [Overload] - void GetFenceivNV(uint fence,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetFenceivNV(uint fence, uint pname) {
            int ps = 0;
            GLNative.glGetFenceivNV(fence, pname, &ps);
            return ps;
        }


        #endregion GL_NV_fence

        #region GL_NV_fragment_coverage_to_color


        #endregion GL_NV_fragment_coverage_to_color

        #region GL_NV_framebuffer_mixed_samples

        // [not processed] - void CoverageModulationTableNV(int n,float* v)
        /// <summary>
        /// [Overload] - void GetCoverageModulationTableNV(int bufSize,float* v)
        /// </summary>
        public unsafe static float GetCoverageModulationTableNV(int bufSize) {
            float v = 0;
            GLNative.glGetCoverageModulationTableNV(bufSize, &v);
            return v;
        }


        #endregion GL_NV_framebuffer_mixed_samples

        #region GL_NV_framebuffer_multisample_coverage


        #endregion GL_NV_framebuffer_multisample_coverage

        #region GL_NV_geometry_program4


        #endregion GL_NV_geometry_program4

        #region GL_NV_gpu_program4

        // [not processed] - void ProgramLocalParameterI4ivNV(uint target,uint index,int* ps)
        // [not processed] - void ProgramLocalParametersI4ivNV(uint target,uint index,int count,int* ps)
        // [not processed] - void ProgramLocalParameterI4uivNV(uint target,uint index,uint* ps)
        // [not processed] - void ProgramLocalParametersI4uivNV(uint target,uint index,int count,uint* ps)
        // [not processed] - void ProgramEnvParameterI4ivNV(uint target,uint index,int* ps)
        // [not processed] - void ProgramEnvParametersI4ivNV(uint target,uint index,int count,int* ps)
        // [not processed] - void ProgramEnvParameterI4uivNV(uint target,uint index,uint* ps)
        // [not processed] - void ProgramEnvParametersI4uivNV(uint target,uint index,int count,uint* ps)
        /// <summary>
        /// [Overload] - void GetProgramLocalParameterIivNV(uint target,uint index,int* ps)
        /// </summary>
        public unsafe static int GetProgramLocalParameterIivNV(uint target, uint index) {
            int ps = 0;
            GLNative.glGetProgramLocalParameterIivNV(target, index, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetProgramLocalParameterIuivNV(uint target,uint index,uint* ps)
        /// </summary>
        public unsafe static uint GetProgramLocalParameterIuivNV(uint target, uint index) {
            uint ps = 0;
            GLNative.glGetProgramLocalParameterIuivNV(target, index, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetProgramEnvParameterIivNV(uint target,uint index,int* ps)
        /// </summary>
        public unsafe static int GetProgramEnvParameterIivNV(uint target, uint index) {
            int ps = 0;
            GLNative.glGetProgramEnvParameterIivNV(target, index, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetProgramEnvParameterIuivNV(uint target,uint index,uint* ps)
        /// </summary>
        public unsafe static uint GetProgramEnvParameterIuivNV(uint target, uint index) {
            uint ps = 0;
            GLNative.glGetProgramEnvParameterIuivNV(target, index, &ps);
            return ps;
        }


        #endregion GL_NV_gpu_program4

        #region GL_NV_gpu_program5

        // [not processed] - void ProgramSubroutineParametersuivNV(uint target,int count,uint* ps)
        /// <summary>
        /// [Overload] - void GetProgramSubroutineParameteruivNV(uint target,uint index,uint* param)
        /// </summary>
        public unsafe static uint GetProgramSubroutineParameteruivNV(uint target, uint index) {
            uint param = 0;
            GLNative.glGetProgramSubroutineParameteruivNV(target, index, &param);
            return param;
        }


        #endregion GL_NV_gpu_program5

        #region GL_NV_gpu_shader5


        #endregion GL_NV_gpu_shader5

        #region GL_NV_half_float

        // [not processed] - void Vertex2hvNV(ushort* v)
        // [not processed] - void Vertex3hvNV(ushort* v)
        // [not processed] - void Vertex4hvNV(ushort* v)
        // [not processed] - void Normal3hvNV(ushort* v)
        // [not processed] - void Color3hvNV(ushort* v)
        // [not processed] - void Color4hvNV(ushort* v)
        // [not processed] - void TexCoord1hvNV(ushort* v)
        // [not processed] - void TexCoord2hvNV(ushort* v)
        // [not processed] - void TexCoord3hvNV(ushort* v)
        // [not processed] - void TexCoord4hvNV(ushort* v)
        // [not processed] - void MultiTexCoord1hvNV(uint target,ushort* v)
        // [not processed] - void MultiTexCoord2hvNV(uint target,ushort* v)
        // [not processed] - void MultiTexCoord3hvNV(uint target,ushort* v)
        // [not processed] - void MultiTexCoord4hvNV(uint target,ushort* v)
        // [not processed] - void FogCoordhvNV(ushort* fog)
        // [not processed] - void SecondaryColor3hvNV(ushort* v)
        // [not processed] - void VertexWeighthvNV(ushort* weight)
        // [not processed] - void VertexAttrib1hvNV(uint index,ushort* v)
        // [not processed] - void VertexAttrib2hvNV(uint index,ushort* v)
        // [not processed] - void VertexAttrib3hvNV(uint index,ushort* v)
        // [not processed] - void VertexAttrib4hvNV(uint index,ushort* v)
        // [not processed] - void VertexAttribs1hvNV(uint index,int n,ushort* v)
        // [not processed] - void VertexAttribs2hvNV(uint index,int n,ushort* v)
        // [not processed] - void VertexAttribs3hvNV(uint index,int n,ushort* v)
        // [not processed] - void VertexAttribs4hvNV(uint index,int n,ushort* v)

        #endregion GL_NV_half_float

        #region GL_NV_internalformat_sample_query

        /// <summary>
        /// [Overload] - void GetInternalformatSampleivNV(uint target,uint internalformat,int samples,uint pname,int count,int* ps)
        /// </summary>
        public unsafe static int GetInternalformatSampleivNV(uint target, uint internalformat, int samples, uint pname, int count) {
            int ps = 0;
            GLNative.glGetInternalformatSampleivNV(target, internalformat, samples, pname, count, &ps);
            return ps;
        }


        #endregion GL_NV_internalformat_sample_query

        #region GL_NV_gpu_multicast

        /// <summary>
        /// [Overload] - void MulticastBufferSubDataNV(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void MulticastBufferSubDataNV(uint gpuMask, uint buffer, IntPtr offset, byte[] data) {
            long size = data.Length * sizeof(byte);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glMulticastBufferSubDataNV(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void MulticastBufferSubDataNV(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void MulticastBufferSubDataNV(uint gpuMask, uint buffer, IntPtr offset, long size, byte[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glMulticastBufferSubDataNV(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void MulticastBufferSubDataNV(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void MulticastBufferSubDataNV(uint gpuMask, uint buffer, IntPtr offset, short[] data) {
            long size = data.Length * sizeof(short);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glMulticastBufferSubDataNV(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void MulticastBufferSubDataNV(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void MulticastBufferSubDataNV(uint gpuMask, uint buffer, IntPtr offset, long size, short[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glMulticastBufferSubDataNV(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void MulticastBufferSubDataNV(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void MulticastBufferSubDataNV(uint gpuMask, uint buffer, IntPtr offset, ushort[] data) {
            long size = data.Length * sizeof(ushort);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glMulticastBufferSubDataNV(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void MulticastBufferSubDataNV(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void MulticastBufferSubDataNV(uint gpuMask, uint buffer, IntPtr offset, long size, ushort[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glMulticastBufferSubDataNV(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void MulticastBufferSubDataNV(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void MulticastBufferSubDataNV(uint gpuMask, uint buffer, IntPtr offset, int[] data) {
            long size = data.Length * sizeof(int);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glMulticastBufferSubDataNV(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void MulticastBufferSubDataNV(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void MulticastBufferSubDataNV(uint gpuMask, uint buffer, IntPtr offset, long size, int[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glMulticastBufferSubDataNV(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void MulticastBufferSubDataNV(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void MulticastBufferSubDataNV(uint gpuMask, uint buffer, IntPtr offset, uint[] data) {
            long size = data.Length * sizeof(uint);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glMulticastBufferSubDataNV(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void MulticastBufferSubDataNV(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void MulticastBufferSubDataNV(uint gpuMask, uint buffer, IntPtr offset, long size, uint[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glMulticastBufferSubDataNV(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void MulticastBufferSubDataNV(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void MulticastBufferSubDataNV(uint gpuMask, uint buffer, IntPtr offset, float[] data) {
            long size = data.Length * sizeof(float);
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glMulticastBufferSubDataNV(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        /// <summary>
        /// [Overload] - void MulticastBufferSubDataNV(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        /// </summary>
        public unsafe static void MulticastBufferSubDataNV(uint gpuMask, uint buffer, IntPtr offset, long size, float[] data) {
            if (IntPtr.Size == 4) size = (int)size;
            fixed (void* pData = &data[0]) {
                GLNative.glMulticastBufferSubDataNV(gpuMask, buffer, offset, (IntPtr)size, pData);
            }
        }

        // [not processed] - void MulticastBufferSubDataNV(uint gpuMask,uint buffer,IntPtr offset,IntPtr size,void* data)
        // [not processed] - void MulticastFramebufferSampleLocationsfvNV(uint gpu,uint framebuffer,uint start,int count,float* v)
        // [not processed] - void MulticastGetQueryObjectivNV(uint gpu,uint id,uint pname,int* ps)
        // [not processed] - void MulticastGetQueryObjectuivNV(uint gpu,uint id,uint pname,uint* ps)
        // [not processed] - void MulticastGetQueryObjecti64vNV(uint gpu,uint id,uint pname,UInt64* ps)
        // [not processed] - void MulticastGetQueryObjectui64vNV(uint gpu,uint id,uint pname,UInt64* ps)

        #endregion GL_NV_gpu_multicast

        #region GL_NVX_gpu_multicast2

        // [not processed] - void MulticastViewportArrayvNVX(uint gpu,uint first,int count,float* v)
        // [not processed] - void MulticastScissorArrayvNVX(uint gpu,uint first,int count,int* v)
        // [not processed] - uint AsyncCopyBufferSubDataNVX(int waitSemaphoreCount,uint* waitSemaphoreArray,UInt64* fenceValueArray,uint readGpu,uint writeGpuMask,uint readBuffer,uint writeBuffer,IntPtr readOffset,IntPtr writeOffset,IntPtr size,int signalSemaphoreCount,uint* signalSemaphoreArray,UInt64* signalValueArray)
        // [not processed] - uint AsyncCopyImageSubDataNVX(int waitSemaphoreCount,uint* waitSemaphoreArray,UInt64* waitValueArray,uint srcGpu,uint dstGpuMask,uint srcName,uint srcTarget,int srcLevel,int srcX,int srcY,int srcZ,uint dstName,uint dstTarget,int dstLevel,int dstX,int dstY,int dstZ,int srcWidth,int srcHeight,int srcDepth,int signalSemaphoreCount,uint* signalSemaphoreArray,UInt64* signalValueArray)

        #endregion GL_NVX_gpu_multicast2

        #region GL_NVX_progress_fence

        // [not processed] - void SignalSemaphoreui64NVX(uint signalGpu,int fenceObjectCount,uint* semaphoreArray,UInt64* fenceValueArray)
        // [not processed] - void WaitSemaphoreui64NVX(uint waitGpu,int fenceObjectCount,uint* semaphoreArray,UInt64* fenceValueArray)
        // [not processed] - void ClientWaitSemaphoreui64NVX(int fenceObjectCount,uint* semaphoreArray,UInt64* fenceValueArray)

        #endregion GL_NVX_progress_fence

        #region GL_NV_memory_attachment

        /// <summary>
        /// [Overload] - void GetMemoryObjectDetachedResourcesuivNV(uint memory,uint pname,int first,int count,uint* ps)
        /// </summary>
        public unsafe static uint GetMemoryObjectDetachedResourcesuivNV(uint memory, uint pname, int first, int count) {
            uint ps = 0;
            GLNative.glGetMemoryObjectDetachedResourcesuivNV(memory, pname, first, count, &ps);
            return ps;
        }


        #endregion GL_NV_memory_attachment

        #region GL_NV_memory_object_sparse


        #endregion GL_NV_memory_object_sparse

        #region GL_NV_mesh_shader


        #endregion GL_NV_mesh_shader

        #region GL_NV_occlusion_query

        /// <summary>
        /// [Overload] - void GenOcclusionQueriesNV(int n,uint* ids)
        /// </summary>
        public unsafe static uint GenOcclusionQueriesNV() {
            uint ids = 0;
            GLNative.glGenOcclusionQueriesNV(1, &ids);
            return ids;
        }

        /// <summary>
        /// [Overload] - void GenOcclusionQueriesNV(int n,uint* ids)
        /// </summary>
        public unsafe static uint[] GenOcclusionQueriesNV(int n) {
            uint[] ids = new uint[n];
            fixed (uint* pIds = &ids[0]) {
                GLNative.glGenOcclusionQueriesNV(n, pIds);
            }
            return ids;
        }

        /// <summary>
        /// [Overload] - void DeleteOcclusionQueriesNV(int n,uint* ids)
        /// </summary>
        public unsafe static void DeleteOcclusionQueriesNV(uint[] ids) {
            fixed (uint* pIds = &ids[0]) {
                GLNative.glDeleteOcclusionQueriesNV(ids.Length, pIds);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteOcclusionQueriesNV(int n,uint* ids)
        /// </summary>
        public unsafe static void DeleteOcclusionQueriesNV(uint[] ids, int n) {
            fixed (uint* pIds = &ids[0]) {
                GLNative.glDeleteOcclusionQueriesNV(n, pIds);
            }
        }

        /// <summary>
        /// [Overload] - void GetOcclusionQueryivNV(uint id,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetOcclusionQueryivNV(uint id, uint pname) {
            int ps = 0;
            GLNative.glGetOcclusionQueryivNV(id, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetOcclusionQueryuivNV(uint id,uint pname,uint* ps)
        /// </summary>
        public unsafe static uint GetOcclusionQueryuivNV(uint id, uint pname) {
            uint ps = 0;
            GLNative.glGetOcclusionQueryuivNV(id, pname, &ps);
            return ps;
        }


        #endregion GL_NV_occlusion_query

        #region GL_NV_parameter_buffer_object

        // [not processed] - void ProgramBufferParametersfvNV(uint target,uint bindingIndex,uint wordIndex,int count,float* ps)
        // [not processed] - void ProgramBufferParametersIivNV(uint target,uint bindingIndex,uint wordIndex,int count,int* ps)
        // [not processed] - void ProgramBufferParametersIuivNV(uint target,uint bindingIndex,uint wordIndex,int count,uint* ps)

        #endregion GL_NV_parameter_buffer_object

        #region GL_NV_path_rendering

        // [not processed] - void PathCommandsNV(uint path,int numCommands,byte* commands,int numCoords,uint coordType,void* coords)
        // [not processed] - void PathCoordsNV(uint path,int numCoords,uint coordType,void* coords)
        // [not processed] - void PathSubCommandsNV(uint path,int commandStart,int commandsToDelete,int numCommands,byte* commands,int numCoords,uint coordType,void* coords)
        // [not processed] - void PathSubCoordsNV(uint path,int coordStart,int numCoords,uint coordType,void* coords)
        // [not processed] - void PathStringNV(uint path,uint format,int length,void* pathString)
        // [not processed] - void PathGlyphsNV(uint firstPathName,uint fontTarget,void* fontName,uint fontStyle,int numGlyphs,uint type,void* charcodes,uint handleMissingGlyphs,uint pathParameterTemplate,float emScale)
        // [not processed] - void PathGlyphRangeNV(uint firstPathName,uint fontTarget,void* fontName,uint fontStyle,uint firstGlyph,int numGlyphs,uint handleMissingGlyphs,uint pathParameterTemplate,float emScale)
        // [not processed] - void WeightPathsNV(uint resultPath,int numPaths,uint* paths,float* weights)
        // [not processed] - void TransformPathNV(uint resultPath,uint srcPath,uint transformType,float* transformValues)
        // [not processed] - void PathParameterivNV(uint path,uint pname,int* value)
        // [not processed] - void PathParameterfvNV(uint path,uint pname,float* value)
        // [not processed] - void PathDashArrayNV(uint path,int dashCount,float* dashArray)
        // [not processed] - void StencilFillPathInstancedNV(int numPaths,uint pathNameType,void* paths,uint pathBase,uint fillMode,uint mask,uint transformType,float* transformValues)
        // [not processed] - void StencilStrokePathInstancedNV(int numPaths,uint pathNameType,void* paths,uint pathBase,int reference,uint mask,uint transformType,float* transformValues)
        // [not processed] - void CoverFillPathInstancedNV(int numPaths,uint pathNameType,void* paths,uint pathBase,uint coverMode,uint transformType,float* transformValues)
        // [not processed] - void CoverStrokePathInstancedNV(int numPaths,uint pathNameType,void* paths,uint pathBase,uint coverMode,uint transformType,float* transformValues)
        /// <summary>
        /// [Overload] - void GetPathParameterivNV(uint path,uint pname,int* value)
        /// </summary>
        public unsafe static int GetPathParameterivNV(uint path, uint pname) {
            int value = 0;
            GLNative.glGetPathParameterivNV(path, pname, &value);
            return value;
        }

        /// <summary>
        /// [Overload] - void GetPathParameterfvNV(uint path,uint pname,float* value)
        /// </summary>
        public unsafe static float GetPathParameterfvNV(uint path, uint pname) {
            float value = 0;
            GLNative.glGetPathParameterfvNV(path, pname, &value);
            return value;
        }

        // [ignore] - void GetPathCommandsNV(uint path,byte* commands)
        /// <summary>
        /// [Overload] - void GetPathCoordsNV(uint path,float* coords)
        /// </summary>
        public unsafe static float GetPathCoordsNV(uint path) {
            float coords = 0;
            GLNative.glGetPathCoordsNV(path, &coords);
            return coords;
        }

        /// <summary>
        /// [Overload] - void GetPathDashArrayNV(uint path,float* dashArray)
        /// </summary>
        public unsafe static float GetPathDashArrayNV(uint path) {
            float dashArray = 0;
            GLNative.glGetPathDashArrayNV(path, &dashArray);
            return dashArray;
        }

        // [not processed] - void GetPathMetricsNV(uint metricQueryMask,int numPaths,uint pathNameType,void* paths,uint pathBase,int stride,float* metrics)
        /// <summary>
        /// [Overload] - void GetPathMetricRangeNV(uint metricQueryMask,uint firstPathName,int numPaths,int stride,float* metrics)
        /// </summary>
        public unsafe static float GetPathMetricRangeNV(uint metricQueryMask, uint firstPathName, int numPaths, int stride) {
            float metrics = 0;
            GLNative.glGetPathMetricRangeNV(metricQueryMask, firstPathName, numPaths, stride, &metrics);
            return metrics;
        }

        // [not processed] - void GetPathSpacingNV(uint pathListMode,int numPaths,uint pathNameType,void* paths,uint pathBase,float advanceScale,float kerningScale,uint transformType,float* returnedSpacing)
        // [not processed] - bool PointAlongPathNV(uint path,int startSegment,int numSegments,float distance,float* x,float* y,float* tangentX,float* tangentY)
        // [not processed] - void MatrixLoad3x2fNV(uint matrixMode,float* m)
        // [not processed] - void MatrixLoad3x3fNV(uint matrixMode,float* m)
        // [not processed] - void MatrixLoadTranspose3x3fNV(uint matrixMode,float* m)
        // [not processed] - void MatrixMult3x2fNV(uint matrixMode,float* m)
        // [not processed] - void MatrixMult3x3fNV(uint matrixMode,float* m)
        // [not processed] - void MatrixMultTranspose3x3fNV(uint matrixMode,float* m)
        // [not processed] - void StencilThenCoverFillPathInstancedNV(int numPaths,uint pathNameType,void* paths,uint pathBase,uint fillMode,uint mask,uint coverMode,uint transformType,float* transformValues)
        // [not processed] - void StencilThenCoverStrokePathInstancedNV(int numPaths,uint pathNameType,void* paths,uint pathBase,int reference,uint mask,uint coverMode,uint transformType,float* transformValues)
        // [not processed] - uint PathGlyphIndexRangeNV(uint fontTarget,void* fontName,uint fontStyle,uint pathParameterTemplate,float emScale,uint* baseAndCount)
        // [not processed] - uint PathGlyphIndexArrayNV(uint firstPathName,uint fontTarget,void* fontName,uint fontStyle,uint firstGlyphIndex,int numGlyphs,uint pathParameterTemplate,float emScale)
        // [not processed] - uint PathMemoryGlyphIndexArrayNV(uint firstPathName,uint fontTarget,IntPtr fontSize,void* fontData,int faceIndex,uint firstGlyphIndex,int numGlyphs,uint pathParameterTemplate,float emScale)
        // [not processed] - void ProgramPathFragmentInputGenNV(uint program,int location,uint genMode,int components,float* coeffs)
        // [not processed] - void GetProgramResourcefvNV(uint program,uint programInterface,uint index,int propCount,uint* props,int count,int* length,float* ps)
        // [not processed] - void PathColorGenNV(uint color,uint genMode,uint colorFormat,float* coeffs)
        // [not processed] - void PathTexGenNV(uint texCoordSet,uint genMode,int components,float* coeffs)
        /// <summary>
        /// [Overload] - void GetPathColorGenivNV(uint color,uint pname,int* value)
        /// </summary>
        public unsafe static int GetPathColorGenivNV(uint color, uint pname) {
            int value = 0;
            GLNative.glGetPathColorGenivNV(color, pname, &value);
            return value;
        }

        /// <summary>
        /// [Overload] - void GetPathColorGenfvNV(uint color,uint pname,float* value)
        /// </summary>
        public unsafe static float GetPathColorGenfvNV(uint color, uint pname) {
            float value = 0;
            GLNative.glGetPathColorGenfvNV(color, pname, &value);
            return value;
        }

        /// <summary>
        /// [Overload] - void GetPathTexGenivNV(uint texCoordSet,uint pname,int* value)
        /// </summary>
        public unsafe static int GetPathTexGenivNV(uint texCoordSet, uint pname) {
            int value = 0;
            GLNative.glGetPathTexGenivNV(texCoordSet, pname, &value);
            return value;
        }

        /// <summary>
        /// [Overload] - void GetPathTexGenfvNV(uint texCoordSet,uint pname,float* value)
        /// </summary>
        public unsafe static float GetPathTexGenfvNV(uint texCoordSet, uint pname) {
            float value = 0;
            GLNative.glGetPathTexGenfvNV(texCoordSet, pname, &value);
            return value;
        }

        // [not processed] - void MatrixLoadTransposefEXT(uint mode,float* m)
        // [not processed] - void MatrixLoadTransposedEXT(uint mode,double* m)
        // [not processed] - void MatrixLoadfEXT(uint mode,float* m)
        // [not processed] - void MatrixLoaddEXT(uint mode,double* m)
        // [not processed] - void MatrixMultTransposefEXT(uint mode,float* m)
        // [not processed] - void MatrixMultTransposedEXT(uint mode,double* m)
        // [not processed] - void MatrixMultfEXT(uint mode,float* m)
        // [not processed] - void MatrixMultdEXT(uint mode,double* m)

        #endregion GL_NV_path_rendering

        #region GL_NV_pixel_data_range

        // [not processed] - void PixelDataRangeNV(uint target,int length,void* pointer)

        #endregion GL_NV_pixel_data_range

        #region GL_NV_point_sprite

        // [not processed] - void PointParameterivNV(uint pname,int* ps)

        #endregion GL_NV_point_sprite

        #region GL_NV_present_video

        /// <summary>
        /// [Overload] - void GetVideoivNV(uint video_slot,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetVideoivNV(uint video_slot, uint pname) {
            int ps = 0;
            GLNative.glGetVideoivNV(video_slot, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVideouivNV(uint video_slot,uint pname,uint* ps)
        /// </summary>
        public unsafe static uint GetVideouivNV(uint video_slot, uint pname) {
            uint ps = 0;
            GLNative.glGetVideouivNV(video_slot, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVideoi64vNV(uint video_slot,uint pname,Int64* ps)
        /// </summary>
        public unsafe static Int64 GetVideoi64vNV(uint video_slot, uint pname) {
            Int64 ps = 0;
            GLNative.glGetVideoi64vNV(video_slot, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVideoui64vNV(uint video_slot,uint pname,UInt64* ps)
        /// </summary>
        public unsafe static UInt64 GetVideoui64vNV(uint video_slot, uint pname) {
            UInt64 ps = 0;
            GLNative.glGetVideoui64vNV(video_slot, pname, &ps);
            return ps;
        }


        #endregion GL_NV_present_video

        #region GL_NV_primitive_restart


        #endregion GL_NV_primitive_restart

        #region GL_NV_query_resource

        // [not processed] - int QueryResourceNV(uint queryType,int tagId,uint count,int* buffer)

        #endregion GL_NV_query_resource

        #region GL_NV_query_resource_tag

        /// <summary>
        /// [Overload] - void GenQueryResourceTagNV(int n,int* tagIds)
        /// </summary>
        public unsafe static int GenQueryResourceTagNV() {
            int tagIds = 0;
            GLNative.glGenQueryResourceTagNV(1, &tagIds);
            return tagIds;
        }

        /// <summary>
        /// [Overload] - void GenQueryResourceTagNV(int n,int* tagIds)
        /// </summary>
        public unsafe static int[] GenQueryResourceTagNV(int n) {
            int[] tagIds = new int[n];
            fixed (int* pTagIds = &tagIds[0]) {
                GLNative.glGenQueryResourceTagNV(n, pTagIds);
            }
            return tagIds;
        }

        /// <summary>
        /// [Overload] - void DeleteQueryResourceTagNV(int n,int* tagIds)
        /// </summary>
        public unsafe static void DeleteQueryResourceTagNV(int[] tagIds) {
            fixed (int* pTagIds = &tagIds[0]) {
                GLNative.glDeleteQueryResourceTagNV(tagIds.Length, pTagIds);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteQueryResourceTagNV(int n,int* tagIds)
        /// </summary>
        public unsafe static void DeleteQueryResourceTagNV(int[] tagIds, int n) {
            fixed (int* pTagIds = &tagIds[0]) {
                GLNative.glDeleteQueryResourceTagNV(n, pTagIds);
            }
        }

        // [not processed] - void QueryResourceTagNV(int tagId,byte* tagString)

        #endregion GL_NV_query_resource_tag

        #region GL_NV_register_combiners

        // [not processed] - void CombinerParameterfvNV(uint pname,float* ps)
        // [not processed] - void CombinerParameterivNV(uint pname,int* ps)
        /// <summary>
        /// [Overload] - void GetCombinerInputParameterfvNV(uint stage,uint portion,uint variable,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetCombinerInputParameterfvNV(uint stage, uint portion, uint variable, uint pname) {
            float ps = 0;
            GLNative.glGetCombinerInputParameterfvNV(stage, portion, variable, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetCombinerInputParameterivNV(uint stage,uint portion,uint variable,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetCombinerInputParameterivNV(uint stage, uint portion, uint variable, uint pname) {
            int ps = 0;
            GLNative.glGetCombinerInputParameterivNV(stage, portion, variable, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetCombinerOutputParameterfvNV(uint stage,uint portion,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetCombinerOutputParameterfvNV(uint stage, uint portion, uint pname) {
            float ps = 0;
            GLNative.glGetCombinerOutputParameterfvNV(stage, portion, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetCombinerOutputParameterivNV(uint stage,uint portion,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetCombinerOutputParameterivNV(uint stage, uint portion, uint pname) {
            int ps = 0;
            GLNative.glGetCombinerOutputParameterivNV(stage, portion, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetFinalCombinerInputParameterfvNV(uint variable,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetFinalCombinerInputParameterfvNV(uint variable, uint pname) {
            float ps = 0;
            GLNative.glGetFinalCombinerInputParameterfvNV(variable, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetFinalCombinerInputParameterivNV(uint variable,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetFinalCombinerInputParameterivNV(uint variable, uint pname) {
            int ps = 0;
            GLNative.glGetFinalCombinerInputParameterivNV(variable, pname, &ps);
            return ps;
        }


        #endregion GL_NV_register_combiners

        #region GL_NV_register_combiners2

        // [not processed] - void CombinerStageParameterfvNV(uint stage,uint pname,float* ps)
        /// <summary>
        /// [Overload] - void GetCombinerStageParameterfvNV(uint stage,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetCombinerStageParameterfvNV(uint stage, uint pname) {
            float ps = 0;
            GLNative.glGetCombinerStageParameterfvNV(stage, pname, &ps);
            return ps;
        }


        #endregion GL_NV_register_combiners2

        #region GL_NV_sample_locations

        // [not processed] - void FramebufferSampleLocationsfvNV(uint target,uint start,int count,float* v)
        // [not processed] - void NamedFramebufferSampleLocationsfvNV(uint framebuffer,uint start,int count,float* v)

        #endregion GL_NV_sample_locations

        #region GL_NV_scissor_exclusive

        // [not processed] - void ScissorExclusiveArrayvNV(uint first,int count,int* v)

        #endregion GL_NV_scissor_exclusive

        #region GL_NV_shader_buffer_load

        /// <summary>
        /// [Overload] - void GetBufferParameterui64vNV(uint target,uint pname,UInt64* ps)
        /// </summary>
        public unsafe static UInt64 GetBufferParameterui64vNV(uint target, uint pname) {
            UInt64 ps = 0;
            GLNative.glGetBufferParameterui64vNV(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetNamedBufferParameterui64vNV(uint buffer,uint pname,UInt64* ps)
        /// </summary>
        public unsafe static UInt64 GetNamedBufferParameterui64vNV(uint buffer, uint pname) {
            UInt64 ps = 0;
            GLNative.glGetNamedBufferParameterui64vNV(buffer, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetIntegerui64vNV(uint value,UInt64* result)
        /// </summary>
        public unsafe static UInt64 GetIntegerui64vNV(uint value) {
            UInt64 result = 0;
            GLNative.glGetIntegerui64vNV(value, &result);
            return result;
        }

        // [not processed] - void Uniformui64vNV(int location,int count,UInt64* value)
        // [not processed] - void ProgramUniformui64vNV(uint program,int location,int count,UInt64* value)

        #endregion GL_NV_shader_buffer_load

        #region GL_NV_shading_rate_image

        /// <summary>
        /// [Overload] - void GetShadingRateImagePaletteNV(uint viewport,uint entry,uint* rate)
        /// </summary>
        public unsafe static uint GetShadingRateImagePaletteNV(uint viewport, uint entry) {
            uint rate = 0;
            GLNative.glGetShadingRateImagePaletteNV(viewport, entry, &rate);
            return rate;
        }

        /// <summary>
        /// [Overload] - void GetShadingRateSampleLocationivNV(uint rate,uint samples,uint index,int* location)
        /// </summary>
        public unsafe static int GetShadingRateSampleLocationivNV(uint rate, uint samples, uint index) {
            int location = 0;
            GLNative.glGetShadingRateSampleLocationivNV(rate, samples, index, &location);
            return location;
        }

        // [not processed] - void ShadingRateImagePaletteNV(uint viewport,uint first,int count,uint* rates)
        // [not processed] - void ShadingRateSampleOrderCustomNV(uint rate,uint samples,int* locations)

        #endregion GL_NV_shading_rate_image

        #region GL_NV_texture_barrier


        #endregion GL_NV_texture_barrier

        #region GL_NV_texture_multisample


        #endregion GL_NV_texture_multisample

        #region GL_NV_transform_feedback

        // [not processed] - void TransformFeedbackAttribsNV(int count,int* attribs,uint bufferMode)
        // [not processed] - void TransformFeedbackVaryingsNV(uint program,int count,int* locations,uint bufferMode)
        // [not processed] - void ActiveVaryingNV(uint program,byte* name)
        // [not processed] - int GetVaryingLocationNV(uint program,byte* name)
        // [not processed] - void GetActiveVaryingNV(uint program,uint index,int bufSize,int* length,int* size,uint* type,byte* name)
        /// <summary>
        /// [Overload] - void GetTransformFeedbackVaryingNV(uint program,uint index,int* location)
        /// </summary>
        public unsafe static int GetTransformFeedbackVaryingNV(uint program, uint index) {
            int location = 0;
            GLNative.glGetTransformFeedbackVaryingNV(program, index, &location);
            return location;
        }

        // [not processed] - void TransformFeedbackStreamAttribsNV(int count,int* attribs,int nbuffers,int* bufstreams,uint bufferMode)

        #endregion GL_NV_transform_feedback

        #region GL_NV_transform_feedback2

        /// <summary>
        /// [Overload] - void DeleteTransformFeedbacksNV(int n,uint* ids)
        /// </summary>
        public unsafe static void DeleteTransformFeedbacksNV(uint[] ids) {
            fixed (uint* pIds = &ids[0]) {
                GLNative.glDeleteTransformFeedbacksNV(ids.Length, pIds);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteTransformFeedbacksNV(int n,uint* ids)
        /// </summary>
        public unsafe static void DeleteTransformFeedbacksNV(uint[] ids, int n) {
            fixed (uint* pIds = &ids[0]) {
                GLNative.glDeleteTransformFeedbacksNV(n, pIds);
            }
        }

        /// <summary>
        /// [Overload] - void GenTransformFeedbacksNV(int n,uint* ids)
        /// </summary>
        public unsafe static uint GenTransformFeedbacksNV() {
            uint ids = 0;
            GLNative.glGenTransformFeedbacksNV(1, &ids);
            return ids;
        }

        /// <summary>
        /// [Overload] - void GenTransformFeedbacksNV(int n,uint* ids)
        /// </summary>
        public unsafe static uint[] GenTransformFeedbacksNV(int n) {
            uint[] ids = new uint[n];
            fixed (uint* pIds = &ids[0]) {
                GLNative.glGenTransformFeedbacksNV(n, pIds);
            }
            return ids;
        }


        #endregion GL_NV_transform_feedback2

        #region GL_NV_vdpau_interop

        // [not processed] - void VDPAUInitNV(void* vdpDevice,void* getProcAddress)
        // [not processed] - IntPtr VDPAURegisterVideoSurfaceNV(void* vdpSurface,uint target,int numTextureNames,uint* textureNames)
        // [not processed] - IntPtr VDPAURegisterOutputSurfaceNV(void* vdpSurface,uint target,int numTextureNames,uint* textureNames)
        // [not processed] - void VDPAUGetSurfaceivNV(IntPtr surface,uint pname,int count,int* length,int* values)
        // [not processed] - void VDPAUMapSurfacesNV(int numSurfaces,IntPtr surfaces)
        // [not processed] - void VDPAUUnmapSurfacesNV(int numSurface,IntPtr surfaces)

        #endregion GL_NV_vdpau_interop

        #region GL_NV_vdpau_interop2

        // [not processed] - IntPtr VDPAURegisterVideoSurfaceWithPictureStructureNV(void* vdpSurface,uint target,int numTextureNames,uint* textureNames,bool isFrameStructure)

        #endregion GL_NV_vdpau_interop2

        #region GL_NV_vertex_array_range

        // [not processed] - void VertexArrayRangeNV(int length,void* pointer)

        #endregion GL_NV_vertex_array_range

        #region GL_NV_vertex_attrib_integer_64bit

        // [not processed] - void VertexAttribL1i64vNV(uint index,Int64* v)
        // [not processed] - void VertexAttribL2i64vNV(uint index,Int64* v)
        // [not processed] - void VertexAttribL3i64vNV(uint index,Int64* v)
        // [not processed] - void VertexAttribL4i64vNV(uint index,Int64* v)
        // [not processed] - void VertexAttribL1ui64vNV(uint index,UInt64* v)
        // [not processed] - void VertexAttribL2ui64vNV(uint index,UInt64* v)
        // [not processed] - void VertexAttribL3ui64vNV(uint index,UInt64* v)
        // [not processed] - void VertexAttribL4ui64vNV(uint index,UInt64* v)
        /// <summary>
        /// [Overload] - void GetVertexAttribLi64vNV(uint index,uint pname,Int64* ps)
        /// </summary>
        public unsafe static Int64 GetVertexAttribLi64vNV(uint index, uint pname) {
            Int64 ps = 0;
            GLNative.glGetVertexAttribLi64vNV(index, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVertexAttribLui64vNV(uint index,uint pname,UInt64* ps)
        /// </summary>
        public unsafe static UInt64 GetVertexAttribLui64vNV(uint index, uint pname) {
            UInt64 ps = 0;
            GLNative.glGetVertexAttribLui64vNV(index, pname, &ps);
            return ps;
        }


        #endregion GL_NV_vertex_attrib_integer_64bit

        #region GL_NV_vertex_buffer_unified_memory

        /// <summary>
        /// [Overload] - void GetIntegerui64i_vNV(uint value,uint index,UInt64* result)
        /// </summary>
        public unsafe static UInt64 GetIntegerui64i_vNV(uint value, uint index) {
            UInt64 result = 0;
            GLNative.glGetIntegerui64i_vNV(value, index, &result);
            return result;
        }


        #endregion GL_NV_vertex_buffer_unified_memory

        #region GL_NV_vertex_program

        // [not processed] - bool AreProgramsResidentNV(int n,uint* programs,bool* residences)
        /// <summary>
        /// [Overload] - void DeleteProgramsNV(int n,uint* programs)
        /// </summary>
        public unsafe static void DeleteProgramsNV(uint[] programs) {
            fixed (uint* pPrograms = &programs[0]) {
                GLNative.glDeleteProgramsNV(programs.Length, pPrograms);
            }
        }

        /// <summary>
        /// [Overload] - void DeleteProgramsNV(int n,uint* programs)
        /// </summary>
        public unsafe static void DeleteProgramsNV(uint[] programs, int n) {
            fixed (uint* pPrograms = &programs[0]) {
                GLNative.glDeleteProgramsNV(n, pPrograms);
            }
        }

        // [not processed] - void ExecuteProgramNV(uint target,uint id,float* ps)
        /// <summary>
        /// [Overload] - void GenProgramsNV(int n,uint* programs)
        /// </summary>
        public unsafe static uint GenProgramsNV() {
            uint programs = 0;
            GLNative.glGenProgramsNV(1, &programs);
            return programs;
        }

        /// <summary>
        /// [Overload] - void GenProgramsNV(int n,uint* programs)
        /// </summary>
        public unsafe static uint[] GenProgramsNV(int n) {
            uint[] programs = new uint[n];
            fixed (uint* pPrograms = &programs[0]) {
                GLNative.glGenProgramsNV(n, pPrograms);
            }
            return programs;
        }

        /// <summary>
        /// [Overload] - void GetProgramParameterdvNV(uint target,uint index,uint pname,double* ps)
        /// </summary>
        public unsafe static double GetProgramParameterdvNV(uint target, uint index, uint pname) {
            double ps = 0;
            GLNative.glGetProgramParameterdvNV(target, index, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetProgramParameterfvNV(uint target,uint index,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetProgramParameterfvNV(uint target, uint index, uint pname) {
            float ps = 0;
            GLNative.glGetProgramParameterfvNV(target, index, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetProgramivNV(uint id,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetProgramivNV(uint id, uint pname) {
            int ps = 0;
            GLNative.glGetProgramivNV(id, pname, &ps);
            return ps;
        }

        // [ignore] - void GetProgramStringNV(uint id,uint pname,byte* program)
        /// <summary>
        /// [Overload] - void GetTrackMatrixivNV(uint target,uint address,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetTrackMatrixivNV(uint target, uint address, uint pname) {
            int ps = 0;
            GLNative.glGetTrackMatrixivNV(target, address, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVertexAttribdvNV(uint index,uint pname,double* ps)
        /// </summary>
        public unsafe static double GetVertexAttribdvNV(uint index, uint pname) {
            double ps = 0;
            GLNative.glGetVertexAttribdvNV(index, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVertexAttribfvNV(uint index,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetVertexAttribfvNV(uint index, uint pname) {
            float ps = 0;
            GLNative.glGetVertexAttribfvNV(index, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVertexAttribivNV(uint index,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetVertexAttribivNV(uint index, uint pname) {
            int ps = 0;
            GLNative.glGetVertexAttribivNV(index, pname, &ps);
            return ps;
        }

        // [not processed] - void GetVertexAttribPointervNV(uint index,uint pname,void** pointer)
        // [not processed] - void LoadProgramNV(uint target,uint id,int len,byte* program)
        // [not processed] - void ProgramParameter4dvNV(uint target,uint index,double* v)
        // [not processed] - void ProgramParameter4fvNV(uint target,uint index,float* v)
        // [not processed] - void ProgramParameters4dvNV(uint target,uint index,int count,double* v)
        // [not processed] - void ProgramParameters4fvNV(uint target,uint index,int count,float* v)
        // [not processed] - void RequestResidentProgramsNV(int n,uint* programs)
        // [not processed] - void VertexAttribPointerNV(uint index,int fsize,uint type,int stride,void* pointer)
        // [not processed] - void VertexAttrib1dvNV(uint index,double* v)
        // [not processed] - void VertexAttrib1fvNV(uint index,float* v)
        // [not processed] - void VertexAttrib1svNV(uint index,short* v)
        // [not processed] - void VertexAttrib2dvNV(uint index,double* v)
        // [not processed] - void VertexAttrib2fvNV(uint index,float* v)
        // [not processed] - void VertexAttrib2svNV(uint index,short* v)
        // [not processed] - void VertexAttrib3dvNV(uint index,double* v)
        // [not processed] - void VertexAttrib3fvNV(uint index,float* v)
        // [not processed] - void VertexAttrib3svNV(uint index,short* v)
        // [not processed] - void VertexAttrib4dvNV(uint index,double* v)
        // [not processed] - void VertexAttrib4fvNV(uint index,float* v)
        // [not processed] - void VertexAttrib4svNV(uint index,short* v)
        // [not processed] - void VertexAttrib4ubvNV(uint index,byte* v)
        // [not processed] - void VertexAttribs1dvNV(uint index,int count,double* v)
        // [not processed] - void VertexAttribs1fvNV(uint index,int count,float* v)
        // [not processed] - void VertexAttribs1svNV(uint index,int count,short* v)
        // [not processed] - void VertexAttribs2dvNV(uint index,int count,double* v)
        // [not processed] - void VertexAttribs2fvNV(uint index,int count,float* v)
        // [not processed] - void VertexAttribs2svNV(uint index,int count,short* v)
        // [not processed] - void VertexAttribs3dvNV(uint index,int count,double* v)
        // [not processed] - void VertexAttribs3fvNV(uint index,int count,float* v)
        // [not processed] - void VertexAttribs3svNV(uint index,int count,short* v)
        // [not processed] - void VertexAttribs4dvNV(uint index,int count,double* v)
        // [not processed] - void VertexAttribs4fvNV(uint index,int count,float* v)
        // [not processed] - void VertexAttribs4svNV(uint index,int count,short* v)
        // [not processed] - void VertexAttribs4ubvNV(uint index,int count,byte* v)

        #endregion GL_NV_vertex_program

        #region GL_NV_vertex_program4


        #endregion GL_NV_vertex_program4

        #region GL_NV_video_capture

        /// <summary>
        /// [Overload] - void GetVideoCaptureivNV(uint video_capture_slot,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetVideoCaptureivNV(uint video_capture_slot, uint pname) {
            int ps = 0;
            GLNative.glGetVideoCaptureivNV(video_capture_slot, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVideoCaptureStreamivNV(uint video_capture_slot,uint stream,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetVideoCaptureStreamivNV(uint video_capture_slot, uint stream, uint pname) {
            int ps = 0;
            GLNative.glGetVideoCaptureStreamivNV(video_capture_slot, stream, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVideoCaptureStreamfvNV(uint video_capture_slot,uint stream,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetVideoCaptureStreamfvNV(uint video_capture_slot, uint stream, uint pname) {
            float ps = 0;
            GLNative.glGetVideoCaptureStreamfvNV(video_capture_slot, stream, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetVideoCaptureStreamdvNV(uint video_capture_slot,uint stream,uint pname,double* ps)
        /// </summary>
        public unsafe static double GetVideoCaptureStreamdvNV(uint video_capture_slot, uint stream, uint pname) {
            double ps = 0;
            GLNative.glGetVideoCaptureStreamdvNV(video_capture_slot, stream, pname, &ps);
            return ps;
        }

        // [not processed] - uint VideoCaptureNV(uint video_capture_slot,uint* sequence_num,UInt64* capture_time)
        // [not processed] - void VideoCaptureStreamParameterivNV(uint video_capture_slot,uint stream,uint pname,int* ps)
        // [not processed] - void VideoCaptureStreamParameterfvNV(uint video_capture_slot,uint stream,uint pname,float* ps)
        // [not processed] - void VideoCaptureStreamParameterdvNV(uint video_capture_slot,uint stream,uint pname,double* ps)

        #endregion GL_NV_video_capture

        #region GL_NV_viewport_swizzle


        #endregion GL_NV_viewport_swizzle

        #region GL_OES_fixed_point

        // [not processed] - void ClipPlanexOES(uint plane,int* equation)
        // [not processed] - void FogxvOES(uint pname,int* param)
        /// <summary>
        /// [Overload] - void GetClipPlanexOES(uint plane,int* equation)
        /// </summary>
        public unsafe static int GetClipPlanexOES(uint plane) {
            int equation = 0;
            GLNative.glGetClipPlanexOES(plane, &equation);
            return equation;
        }

        /// <summary>
        /// [Overload] - void GetFixedvOES(uint pname,int* ps)
        /// </summary>
        public unsafe static int GetFixedvOES(uint pname) {
            int ps = 0;
            GLNative.glGetFixedvOES(pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetTexEnvxvOES(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetTexEnvxvOES(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetTexEnvxvOES(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetTexParameterxvOES(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetTexParameterxvOES(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetTexParameterxvOES(target, pname, &ps);
            return ps;
        }

        // [not processed] - void LightModelxvOES(uint pname,int* param)
        // [not processed] - void LightxvOES(uint light,uint pname,int* ps)
        // [not processed] - void LoadMatrixxOES(int* m)
        // [not processed] - void MaterialxvOES(uint face,uint pname,int* param)
        // [not processed] - void MultMatrixxOES(int* m)
        // [not processed] - void PointParameterxvOES(uint pname,int* ps)
        // [not processed] - void TexEnvxvOES(uint target,uint pname,int* ps)
        // [not processed] - void TexParameterxvOES(uint target,uint pname,int* ps)
        /// <summary>
        /// [Overload] - void GetLightxvOES(uint light,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetLightxvOES(uint light, uint pname) {
            int ps = 0;
            GLNative.glGetLightxvOES(light, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetMaterialxvOES(uint face,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetMaterialxvOES(uint face, uint pname) {
            int ps = 0;
            GLNative.glGetMaterialxvOES(face, pname, &ps);
            return ps;
        }

        // [not processed] - void BitmapxOES(int width,int height,int xorig,int yorig,int xmove,int ymove,byte* bitmap)
        // [not processed] - void Color3xvOES(int* components)
        // [not processed] - void Color4xvOES(int* components)
        // [not processed] - void ConvolutionParameterxvOES(uint target,uint pname,int* ps)
        // [not processed] - void EvalCoord1xvOES(int* coords)
        // [not processed] - void EvalCoord2xvOES(int* coords)
        // [not processed] - void FeedbackBufferxOES(int n,uint type,int* buffer)
        /// <summary>
        /// [Overload] - void GetConvolutionParameterxvOES(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetConvolutionParameterxvOES(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetConvolutionParameterxvOES(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetHistogramParameterxvOES(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetHistogramParameterxvOES(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetHistogramParameterxvOES(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetLightxOES(uint light,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetLightxOES(uint light, uint pname) {
            int ps = 0;
            GLNative.glGetLightxOES(light, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetMapxvOES(uint target,uint query,int* v)
        /// </summary>
        public unsafe static int GetMapxvOES(uint target, uint query) {
            int v = 0;
            GLNative.glGetMapxvOES(target, query, &v);
            return v;
        }

        /// <summary>
        /// [Overload] - void GetPixelMapxv(uint map,int size,int* values)
        /// </summary>
        public unsafe static int GetPixelMapxv(uint map, int size) {
            int values = 0;
            GLNative.glGetPixelMapxv(map, size, &values);
            return values;
        }

        /// <summary>
        /// [Overload] - void GetTexGenxvOES(uint coord,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetTexGenxvOES(uint coord, uint pname) {
            int ps = 0;
            GLNative.glGetTexGenxvOES(coord, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetTexLevelParameterxvOES(uint target,int level,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetTexLevelParameterxvOES(uint target, int level, uint pname) {
            int ps = 0;
            GLNative.glGetTexLevelParameterxvOES(target, level, pname, &ps);
            return ps;
        }

        // [not processed] - void IndexxvOES(int* component)
        // [not processed] - void LoadTransposeMatrixxOES(int* m)
        // [not processed] - void MultTransposeMatrixxOES(int* m)
        // [not processed] - void MultiTexCoord1xvOES(uint texture,int* coords)
        // [not processed] - void MultiTexCoord2xvOES(uint texture,int* coords)
        // [not processed] - void MultiTexCoord3xvOES(uint texture,int* coords)
        // [not processed] - void MultiTexCoord4xvOES(uint texture,int* coords)
        // [not processed] - void Normal3xvOES(int* coords)
        // [not processed] - void PixelMapx(uint map,int size,int* values)
        // [not processed] - void PrioritizeTexturesxOES(int n,uint* textures,int* priorities)
        // [not processed] - void RasterPos2xvOES(int* coords)
        // [not processed] - void RasterPos3xvOES(int* coords)
        // [not processed] - void RasterPos4xvOES(int* coords)
        // [not processed] - void RectxvOES(int* v1,int* v2)
        // [not processed] - void TexCoord1xvOES(int* coords)
        // [not processed] - void TexCoord2xvOES(int* coords)
        // [not processed] - void TexCoord3xvOES(int* coords)
        // [not processed] - void TexCoord4xvOES(int* coords)
        // [not processed] - void TexGenxvOES(uint coord,uint pname,int* ps)
        // [not processed] - void Vertex2xvOES(int* coords)
        // [not processed] - void Vertex3xvOES(int* coords)
        // [not processed] - void Vertex4xvOES(int* coords)

        #endregion GL_OES_fixed_point

        #region GL_OES_query_matrix

        // [not processed] - uint QueryMatrixxOES(int* mantissa,int* exponent)

        #endregion GL_OES_query_matrix

        #region GL_OES_single_precision

        // [not processed] - void ClipPlanefOES(uint plane,float* equation)
        /// <summary>
        /// [Overload] - void GetClipPlanefOES(uint plane,float* equation)
        /// </summary>
        public unsafe static float GetClipPlanefOES(uint plane) {
            float equation = 0;
            GLNative.glGetClipPlanefOES(plane, &equation);
            return equation;
        }


        #endregion GL_OES_single_precision

        #region GL_OVR_multiview


        #endregion GL_OVR_multiview

        #region GL_PGI_misc_hints


        #endregion GL_PGI_misc_hints

        #region GL_SGIS_detail_texture

        // [not processed] - void DetailTexFuncSGIS(uint target,int n,float* points)
        /// <summary>
        /// [Overload] - void GetDetailTexFuncSGIS(uint target,float* points)
        /// </summary>
        public unsafe static float GetDetailTexFuncSGIS(uint target) {
            float points = 0;
            GLNative.glGetDetailTexFuncSGIS(target, &points);
            return points;
        }


        #endregion GL_SGIS_detail_texture

        #region GL_SGIS_fog_function

        // [not processed] - void FogFuncSGIS(int n,float* points)
        /// <summary>
        /// [Overload] - void GetFogFuncSGIS(float* points)
        /// </summary>
        public unsafe static float GetFogFuncSGIS() {
            float points = 0;
            GLNative.glGetFogFuncSGIS(&points);
            return points;
        }


        #endregion GL_SGIS_fog_function

        #region GL_SGIS_multisample


        #endregion GL_SGIS_multisample

        #region GL_SGIS_pixel_texture

        // [not processed] - void PixelTexGenParameterivSGIS(uint pname,int* ps)
        // [not processed] - void PixelTexGenParameterfvSGIS(uint pname,float* ps)
        /// <summary>
        /// [Overload] - void GetPixelTexGenParameterivSGIS(uint pname,int* ps)
        /// </summary>
        public unsafe static int GetPixelTexGenParameterivSGIS(uint pname) {
            int ps = 0;
            GLNative.glGetPixelTexGenParameterivSGIS(pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetPixelTexGenParameterfvSGIS(uint pname,float* ps)
        /// </summary>
        public unsafe static float GetPixelTexGenParameterfvSGIS(uint pname) {
            float ps = 0;
            GLNative.glGetPixelTexGenParameterfvSGIS(pname, &ps);
            return ps;
        }


        #endregion GL_SGIS_pixel_texture

        #region GL_SGIS_point_parameters

        // [not processed] - void PointParameterfvSGIS(uint pname,float* ps)

        #endregion GL_SGIS_point_parameters

        #region GL_SGIS_sharpen_texture

        // [not processed] - void SharpenTexFuncSGIS(uint target,int n,float* points)
        /// <summary>
        /// [Overload] - void GetSharpenTexFuncSGIS(uint target,float* points)
        /// </summary>
        public unsafe static float GetSharpenTexFuncSGIS(uint target) {
            float points = 0;
            GLNative.glGetSharpenTexFuncSGIS(target, &points);
            return points;
        }


        #endregion GL_SGIS_sharpen_texture

        #region GL_SGIS_texture4D

        // [not processed] - void TexImage4DSGIS(uint target,int level,uint internalformat,int width,int height,int depth,int size4d,int border,uint format,uint type,void* pixels)
        // [not processed] - void TexSubImage4DSGIS(uint target,int level,int xoffset,int yoffset,int zoffset,int woffset,int width,int height,int depth,int size4d,uint format,uint type,void* pixels)

        #endregion GL_SGIS_texture4D

        #region GL_SGIS_texture_color_mask


        #endregion GL_SGIS_texture_color_mask

        #region GL_SGIS_texture_filter4

        /// <summary>
        /// [Overload] - void GetTexFilterFuncSGIS(uint target,uint filter,float* weights)
        /// </summary>
        public unsafe static float GetTexFilterFuncSGIS(uint target, uint filter) {
            float weights = 0;
            GLNative.glGetTexFilterFuncSGIS(target, filter, &weights);
            return weights;
        }

        // [not processed] - void TexFilterFuncSGIS(uint target,uint filter,int n,float* weights)

        #endregion GL_SGIS_texture_filter4

        #region GL_SGIX_async

        // [not processed] - int FinishAsyncSGIX(uint* markerp)
        // [not processed] - int PollAsyncSGIX(uint* markerp)

        #endregion GL_SGIX_async

        #region GL_SGIX_flush_raster


        #endregion GL_SGIX_flush_raster

        #region GL_SGIX_fragment_lighting

        // [not processed] - void FragmentLightfvSGIX(uint light,uint pname,float* ps)
        // [not processed] - void FragmentLightivSGIX(uint light,uint pname,int* ps)
        // [not processed] - void FragmentLightModelfvSGIX(uint pname,float* ps)
        // [not processed] - void FragmentLightModelivSGIX(uint pname,int* ps)
        // [not processed] - void FragmentMaterialfvSGIX(uint face,uint pname,float* ps)
        // [not processed] - void FragmentMaterialivSGIX(uint face,uint pname,int* ps)
        /// <summary>
        /// [Overload] - void GetFragmentLightfvSGIX(uint light,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetFragmentLightfvSGIX(uint light, uint pname) {
            float ps = 0;
            GLNative.glGetFragmentLightfvSGIX(light, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetFragmentLightivSGIX(uint light,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetFragmentLightivSGIX(uint light, uint pname) {
            int ps = 0;
            GLNative.glGetFragmentLightivSGIX(light, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetFragmentMaterialfvSGIX(uint face,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetFragmentMaterialfvSGIX(uint face, uint pname) {
            float ps = 0;
            GLNative.glGetFragmentMaterialfvSGIX(face, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetFragmentMaterialivSGIX(uint face,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetFragmentMaterialivSGIX(uint face, uint pname) {
            int ps = 0;
            GLNative.glGetFragmentMaterialivSGIX(face, pname, &ps);
            return ps;
        }


        #endregion GL_SGIX_fragment_lighting

        #region GL_SGIX_framezoom


        #endregion GL_SGIX_framezoom

        #region GL_SGIX_igloo_interface

        // [not processed] - void IglooInterfaceSGIX(uint pname,void* ps)

        #endregion GL_SGIX_igloo_interface

        #region GL_SGIX_instruments

        // [not processed] - void InstrumentsBufferSGIX(int size,int* buffer)
        // [not processed] - int PollInstrumentsSGIX(int* marker_p)

        #endregion GL_SGIX_instruments

        #region GL_SGIX_list_priority

        /// <summary>
        /// [Overload] - void GetListParameterfvSGIX(uint list,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetListParameterfvSGIX(uint list, uint pname) {
            float ps = 0;
            GLNative.glGetListParameterfvSGIX(list, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetListParameterivSGIX(uint list,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetListParameterivSGIX(uint list, uint pname) {
            int ps = 0;
            GLNative.glGetListParameterivSGIX(list, pname, &ps);
            return ps;
        }

        // [not processed] - void ListParameterfvSGIX(uint list,uint pname,float* ps)
        // [not processed] - void ListParameterivSGIX(uint list,uint pname,int* ps)

        #endregion GL_SGIX_list_priority

        #region GL_SGIX_pixel_texture


        #endregion GL_SGIX_pixel_texture

        #region GL_SGIX_polynomial_ffd

        // [not processed] - void DeformationMap3dSGIX(uint target,double u1,double u2,int ustride,int uorder,double v1,double v2,int vstride,int vorder,double w1,double w2,int wstride,int worder,double* points)
        // [not processed] - void DeformationMap3fSGIX(uint target,float u1,float u2,int ustride,int uorder,float v1,float v2,int vstride,int vorder,float w1,float w2,int wstride,int worder,float* points)

        #endregion GL_SGIX_polynomial_ffd

        #region GL_SGIX_reference_plane

        // [not processed] - void ReferencePlaneSGIX(double* equation)

        #endregion GL_SGIX_reference_plane

        #region GL_SGIX_sprite

        // [not processed] - void SpriteParameterfvSGIX(uint pname,float* ps)
        // [not processed] - void SpriteParameterivSGIX(uint pname,int* ps)

        #endregion GL_SGIX_sprite

        #region GL_SGIX_tag_sample_buffer


        #endregion GL_SGIX_tag_sample_buffer

        #region GL_SGI_color_table

        // [not processed] - void ColorTableSGI(uint target,uint internalformat,int width,uint format,uint type,void* table)
        // [not processed] - void ColorTableParameterfvSGI(uint target,uint pname,float* ps)
        // [not processed] - void ColorTableParameterivSGI(uint target,uint pname,int* ps)
        // [ignore] - void GetColorTableSGI(uint target,uint format,uint type,void* table)
        /// <summary>
        /// [Overload] - void GetColorTableParameterfvSGI(uint target,uint pname,float* ps)
        /// </summary>
        public unsafe static float GetColorTableParameterfvSGI(uint target, uint pname) {
            float ps = 0;
            GLNative.glGetColorTableParameterfvSGI(target, pname, &ps);
            return ps;
        }

        /// <summary>
        /// [Overload] - void GetColorTableParameterivSGI(uint target,uint pname,int* ps)
        /// </summary>
        public unsafe static int GetColorTableParameterivSGI(uint target, uint pname) {
            int ps = 0;
            GLNative.glGetColorTableParameterivSGI(target, pname, &ps);
            return ps;
        }


        #endregion GL_SGI_color_table

        #region GL_SUNX_constant_data


        #endregion GL_SUNX_constant_data

        #region GL_SUN_global_alpha


        #endregion GL_SUN_global_alpha

        #region GL_SUN_mesh_array


        #endregion GL_SUN_mesh_array

        #region GL_SUN_triangle_list

        // [not processed] - void ReplacementCodeuivSUN(uint* code)
        // [not processed] - void ReplacementCodeusvSUN(ushort* code)
        // [not processed] - void ReplacementCodeubvSUN(byte* code)
        // [not processed] - void ReplacementCodePointerSUN(uint type,int stride,void** pointer)

        #endregion GL_SUN_triangle_list

        #region GL_SUN_vertex

        // [not processed] - void Color4ubVertex2fvSUN(byte* c,float* v)
        // [not processed] - void Color4ubVertex3fvSUN(byte* c,float* v)
        // [not processed] - void Color3fVertex3fvSUN(float* c,float* v)
        // [not processed] - void Normal3fVertex3fvSUN(float* n,float* v)
        // [not processed] - void Color4fNormal3fVertex3fvSUN(float* c,float* n,float* v)
        // [not processed] - void TexCoord2fVertex3fvSUN(float* tc,float* v)
        // [not processed] - void TexCoord4fVertex4fvSUN(float* tc,float* v)
        // [not processed] - void TexCoord2fColor4ubVertex3fvSUN(float* tc,byte* c,float* v)
        // [not processed] - void TexCoord2fColor3fVertex3fvSUN(float* tc,float* c,float* v)
        // [not processed] - void TexCoord2fNormal3fVertex3fvSUN(float* tc,float* n,float* v)
        // [not processed] - void TexCoord2fColor4fNormal3fVertex3fvSUN(float* tc,float* c,float* n,float* v)
        // [not processed] - void TexCoord4fColor4fNormal3fVertex4fvSUN(float* tc,float* c,float* n,float* v)
        // [not processed] - void ReplacementCodeuiVertex3fvSUN(uint* rc,float* v)
        // [not processed] - void ReplacementCodeuiColor4ubVertex3fvSUN(uint* rc,byte* c,float* v)
        // [not processed] - void ReplacementCodeuiColor3fVertex3fvSUN(uint* rc,float* c,float* v)
        // [not processed] - void ReplacementCodeuiNormal3fVertex3fvSUN(uint* rc,float* n,float* v)
        // [not processed] - void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(uint* rc,float* c,float* n,float* v)
        // [not processed] - void ReplacementCodeuiTexCoord2fVertex3fvSUN(uint* rc,float* tc,float* v)
        // [not processed] - void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(uint* rc,float* tc,float* n,float* v)
        // [not processed] - void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(uint* rc,float* tc,float* c,float* n,float* v)

        #endregion GL_SUN_vertex
    }
}
