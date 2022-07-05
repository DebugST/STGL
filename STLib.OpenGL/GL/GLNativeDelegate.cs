using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace STLib.OpenGL.GL
{
    public class GLNativeDelegate
    {

        /**********************************************************************************
         * Note: These codes are automatically created from OpenGL's documentation.
         *       If there is something wrong, it must be because the author is too stupid.
         * Link: https://github.com/KhronosGroup/OpenGL-Registry/xml/gl.xml
         **********************************************************************************/

        #region GL_VERSION_1_0

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCullFace(uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFrontFace(uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglHint(uint target, uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLineWidth(float width);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPointSize(float size);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPolygonMode(uint face, uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglScissor(int x, int y, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexParameterf(uint target, uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexParameterfv(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexParameteri(uint target, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexParameteriv(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexImage1D(uint target, int level, int publicFormat, int width, int border, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexImage2D(uint target, int level, int publicFormat, int width, int height, int border, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawBuffer(uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClear(uint mask);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClearColor(float red, float green, float blue, float alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClearStencil(int s);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClearDepth(double depth);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglStencilMask(uint mask);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColorMask(bool red, bool green, bool blue, bool alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDepthMask(bool flag);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDisable(uint cap);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEnable(uint cap);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFinish();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFlush();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendFunc(uint sfactor, uint dfactor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLogicOp(uint opcode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglStencilFunc(uint func, int r, uint mask);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglStencilOp(uint sfail, uint dpfail, uint dppass);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDepthFunc(uint func);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPixelStoref(uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPixelStorei(uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglReadBuffer(uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglReadPixels(int x, int y, int width, int height, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetBooleanv(uint pname, bool* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetDoublev(uint pname, double* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglGetError();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetFloatv(uint pname, float* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetIntegerv(uint pname, int* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate byte* FNglGetString(uint name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexImage(uint target, int level, uint format, uint type, void* img);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexParameterfv(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexParameteriv(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexLevelParameterfv(uint target, int level, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexLevelParameteriv(uint target, int level, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsEnabled(uint cap);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDepthRange(double nearVal, double farVal);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglViewport(int x, int y, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNewList(uint list, uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEndList();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCallList(uint list);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCallLists(int n, uint type, void* lists);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDeleteLists(uint list, int range);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglGenLists(int range);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglListBase(uint b);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBegin(uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor3b(byte red, byte green, byte blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor3bv(byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor3d(double red, double green, double blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor3dv(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor3f(float red, float green, float blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor3fv(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor3i(int red, int green, int blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor3iv(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor3s(short red, short green, short blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor3sv(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor3ub(byte red, byte green, byte blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor3ubv(byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor3ui(uint red, uint green, uint blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor3uiv(uint* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor3us(ushort red, ushort green, ushort blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor3usv(ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor4b(byte red, byte green, byte blue, byte alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor4bv(byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor4d(double red, double green, double blue, double alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor4dv(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor4f(float red, float green, float blue, float alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor4fv(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor4i(int red, int green, int blue, int alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor4iv(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor4s(short red, short green, short blue, short alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor4sv(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor4ub(byte red, byte green, byte blue, byte alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor4ubv(byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor4ui(uint red, uint green, uint blue, uint alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor4uiv(uint* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor4us(ushort red, ushort green, ushort blue, ushort alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor4usv(ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEdgeFlag(bool flag);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglEdgeFlagv(bool* flag);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEnd();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglIndexd(double c);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglIndexdv(double* c);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglIndexf(float c);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglIndexfv(float* c);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglIndexi(int c);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglIndexiv(int* c);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglIndexs(short c);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglIndexsv(short* c);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNormal3b(byte nx, byte ny, byte nz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormal3bv(byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNormal3d(double nx, double ny, double nz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormal3dv(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNormal3f(float nx, float ny, float nz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormal3fv(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNormal3i(int nx, int ny, int nz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormal3iv(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNormal3s(short nx, short ny, short nz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormal3sv(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRasterPos2d(double x, double y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRasterPos2dv(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRasterPos2f(float x, float y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRasterPos2fv(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRasterPos2i(int x, int y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRasterPos2iv(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRasterPos2s(short x, short y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRasterPos2sv(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRasterPos3d(double x, double y, double z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRasterPos3dv(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRasterPos3f(float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRasterPos3fv(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRasterPos3i(int x, int y, int z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRasterPos3iv(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRasterPos3s(short x, short y, short z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRasterPos3sv(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRasterPos4d(double x, double y, double z, double w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRasterPos4dv(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRasterPos4f(float x, float y, float z, float w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRasterPos4fv(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRasterPos4i(int x, int y, int z, int w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRasterPos4iv(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRasterPos4s(short x, short y, short z, short w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRasterPos4sv(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRectd(double x1, double y1, double x2, double y2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRectdv(double* v1, double* v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRectf(float x1, float y1, float x2, float y2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRectfv(float* v1, float* v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRecti(int x1, int y1, int x2, int y2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRectiv(int* v1, int* v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRects(short x1, short y1, short x2, short y2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRectsv(short* v1, short* v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord1d(double s);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord1dv(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord1f(float s);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord1fv(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord1i(int s);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord1iv(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord1s(short s);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord1sv(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord2d(double s, double t);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord2dv(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord2f(float s, float t);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord2fv(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord2i(int s, int t);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord2iv(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord2s(short s, short t);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord2sv(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord3d(double s, double t, double r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord3dv(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord3f(float s, float t, float r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord3fv(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord3i(int s, int t, int r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord3iv(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord3s(short s, short t, short r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord3sv(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord4d(double s, double t, double r, double q);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord4dv(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord4f(float s, float t, float r, float q);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord4fv(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord4i(int s, int t, int r, int q);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord4iv(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord4s(short s, short t, short r, short q);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord4sv(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex2d(double x, double y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex2dv(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex2f(float x, float y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex2fv(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex2i(int x, int y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex2iv(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex2s(short x, short y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex2sv(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex3d(double x, double y, double z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex3dv(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex3f(float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex3fv(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex3i(int x, int y, int z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex3iv(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex3s(short x, short y, short z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex3sv(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex4d(double x, double y, double z, double w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex4dv(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex4f(float x, float y, float z, float w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex4fv(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex4i(int x, int y, int z, int w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex4iv(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex4s(short x, short y, short z, short w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex4sv(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglClipPlane(uint plane, double* equation);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColorMaterial(uint face, uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFogf(uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFogfv(uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFogi(uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFogiv(uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLightf(uint light, uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglLightfv(uint light, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLighti(uint light, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglLightiv(uint light, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLightModelf(uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglLightModelfv(uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLightModeli(uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglLightModeliv(uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLineStipple(int factor, ushort pattern);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMaterialf(uint face, uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMaterialfv(uint face, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMateriali(uint face, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMaterialiv(uint face, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPolygonStipple(byte* pattern);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglShadeModel(uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexEnvf(uint target, uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexEnvfv(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexEnvi(uint target, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexEnviv(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexGend(uint coord, uint pname, double param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexGendv(uint coord, uint pname, double* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexGenf(uint coord, uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexGenfv(uint coord, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexGeni(uint coord, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexGeniv(uint coord, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFeedbackBuffer(int size, uint type, float* buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSelectBuffer(int size, uint* buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int FNglRenderMode(uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglInitNames();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLoadName(uint name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPassThrough(float token);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPopName();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPushName(uint name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClearAccum(float red, float green, float blue, float alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClearIndex(float c);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglIndexMask(uint mask);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglAccum(uint op, float value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPopAttrib();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPushAttrib(uint mask);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMap1d(uint target, double u1, double u2, int stride, int order, double* points);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMap1f(uint target, float u1, float u2, int stride, int order, float* points);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMap2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMap2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMapGrid1d(int un, double u1, double u2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMapGrid1f(int un, float u1, float u2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEvalCoord1d(double u);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglEvalCoord1dv(double* u);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEvalCoord1f(float u);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglEvalCoord1fv(float* u);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEvalCoord2d(double u, double v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglEvalCoord2dv(double* u);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEvalCoord2f(float u, float v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglEvalCoord2fv(float* u);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEvalMesh1(uint mode, int i1, int i2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEvalPoint1(int i);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEvalMesh2(uint mode, int i1, int i2, int j1, int j2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEvalPoint2(int i, int j);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglAlphaFunc(uint func, float r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPixelZoom(float xfactor, float yfactor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPixelTransferf(uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPixelTransferi(uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPixelMapfv(uint map, int mapsize, float* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPixelMapuiv(uint map, int mapsize, uint* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPixelMapusv(uint map, int mapsize, ushort* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyPixels(int x, int y, int width, int height, uint type);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawPixels(int width, int height, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetClipPlane(uint plane, double* equation);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetLightfv(uint light, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetLightiv(uint light, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMapdv(uint target, uint query, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMapfv(uint target, uint query, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMapiv(uint target, uint query, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMaterialfv(uint face, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMaterialiv(uint face, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPixelMapfv(uint map, float* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPixelMapuiv(uint map, uint* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPixelMapusv(uint map, ushort* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPolygonStipple(byte* pattern);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexEnvfv(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexEnviv(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexGendv(uint coord, uint pname, double* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexGenfv(uint coord, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexGeniv(uint coord, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsList(uint list);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFrustum(double left, double right, double bottom, double top, double nearVal, double farVal);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLoadIdentity();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglLoadMatrixf(float* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglLoadMatrixd(double* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMatrixMode(uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultMatrixf(float* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultMatrixd(double* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglOrtho(double left, double right, double bottom, double top, double nearVal, double farVal);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPopMatrix();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPushMatrix();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRotated(double angle, double x, double y, double z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRotatef(float angle, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglScaled(double x, double y, double z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglScalef(float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTranslated(double x, double y, double z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTranslatef(float x, float y, float z);

        #endregion GL_VERSION_1_0

        #region GL_VERSION_1_1

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawArrays(uint mode, int first, int count);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawElements(uint mode, int count, uint type, void* indices);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPointerv(uint pname, void** ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPolygonOffset(float factor, float units);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyTexImage1D(uint target, int level, uint publicformat, int x, int y, int width, int border);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyTexImage2D(uint target, int level, uint publicformat, int x, int y, int width, int height, int border);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindTexture(uint target, uint texture);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteTextures(int n, uint* textures);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenTextures(int n, uint* textures);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsTexture(uint texture);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglArrayElement(int i);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColorPointer(int size, uint type, int stride, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDisableClientState(uint cap);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglEdgeFlagPointer(int stride, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEnableClientState(uint cap);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglIndexPointer(uint type, int stride, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglInterleavedArrays(uint format, int stride, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormalPointer(uint type, int stride, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoordPointer(int size, uint type, int stride, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexPointer(int size, uint type, int stride, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate bool FNglAreTexturesResident(int n, uint* textures, bool* residences);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPrioritizeTextures(int n, uint* textures, float* priorities);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglIndexub(byte c);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglIndexubv(byte* c);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPopClientAttrib();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPushClientAttrib(uint mask);

        #endregion GL_VERSION_1_1

        #region GL_VERSION_1_2

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexImage3D(uint target, int level, int publicFormat, int width, int height, int depth, int border, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

        #endregion GL_VERSION_1_2

        #region GL_VERSION_1_3

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglActiveTexture(uint texture);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSampleCoverage(float value, bool invert);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCompressedTexImage3D(uint target, int level, uint publicformat, int width, int height, int depth, int border, int imageSize, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCompressedTexImage2D(uint target, int level, uint publicformat, int width, int height, int border, int imageSize, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCompressedTexImage1D(uint target, int level, uint publicformat, int width, int border, int imageSize, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetCompressedTexImage(uint target, int lod, void* img);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClientActiveTexture(uint texture);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord1d(uint target, double s);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord1dv(uint target, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord1f(uint target, float s);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord1fv(uint target, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord1i(uint target, int s);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord1iv(uint target, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord1s(uint target, short s);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord1sv(uint target, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord2d(uint target, double s, double t);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord2dv(uint target, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord2f(uint target, float s, float t);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord2fv(uint target, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord2i(uint target, int s, int t);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord2iv(uint target, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord2s(uint target, short s, short t);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord2sv(uint target, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord3d(uint target, double s, double t, double r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord3dv(uint target, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord3f(uint target, float s, float t, float r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord3fv(uint target, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord3i(uint target, int s, int t, int r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord3iv(uint target, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord3s(uint target, short s, short t, short r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord3sv(uint target, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord4d(uint target, double s, double t, double r, double q);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord4dv(uint target, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord4f(uint target, float s, float t, float r, float q);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord4fv(uint target, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord4i(uint target, int s, int t, int r, int q);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord4iv(uint target, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord4s(uint target, short s, short t, short r, short q);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord4sv(uint target, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglLoadTransposeMatrixf(float* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglLoadTransposeMatrixd(double* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultTransposeMatrixf(float* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultTransposeMatrixd(double* m);

        #endregion GL_VERSION_1_3

        #region GL_VERSION_1_4

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendFuncSeparate(uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawArrays(uint mode, int* first, int* count, int primcount);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawElements(uint mode, int* count, uint type, void** indices, int primcount);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPointParameterf(uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPointParameterfv(uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPointParameteri(uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPointParameteriv(uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFogCoordf(float coord);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFogCoordfv(float* coord);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFogCoordd(double coord);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFogCoorddv(double* coord);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFogCoordPointer(uint type, int stride, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColor3b(byte red, byte green, byte blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColor3bv(byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColor3d(double red, double green, double blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColor3dv(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColor3f(float red, float green, float blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColor3fv(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColor3i(int red, int green, int blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColor3iv(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColor3s(short red, short green, short blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColor3sv(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColor3ub(byte red, byte green, byte blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColor3ubv(byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColor3ui(uint red, uint green, uint blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColor3uiv(uint* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColor3us(ushort red, ushort green, ushort blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColor3usv(ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColorPointer(int size, uint type, int stride, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos2d(double x, double y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos2dv(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos2f(float x, float y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos2fv(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos2i(int x, int y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos2iv(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos2s(short x, short y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos2sv(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos3d(double x, double y, double z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos3dv(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos3f(float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos3fv(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos3i(int x, int y, int z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos3iv(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos3s(short x, short y, short z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos3sv(short* v);

        #region Promoted from ARB_imaging subset to core

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendColor(float red, float green, float blue, float alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendEquation(uint mode);

        #endregion Promoted from ARB_imaging subset to core

        #endregion GL_VERSION_1_4

        #region GL_VERSION_1_5

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenQueries(int n, uint* ids);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteQueries(int n, uint* ids);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsQuery(uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBeginQuery(uint target, uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEndQuery(uint target);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetQueryiv(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetQueryObjectiv(uint id, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetQueryObjectuiv(uint id, uint pname, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindBuffer(uint target, uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteBuffers(int n, uint* buffers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenBuffers(int n, uint* buffers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsBuffer(uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBufferData(uint target, IntPtr size, void* data, uint usage);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBufferSubData(uint target, IntPtr offset, IntPtr size, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetBufferSubData(uint target, IntPtr offset, IntPtr size, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void* FNglMapBuffer(uint target, uint access);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglUnmapBuffer(uint target);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetBufferParameteriv(uint target, uint value, int* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetBufferPointerv(uint target, uint pname, void** ps);

        #endregion GL_VERSION_1_5

        #region GL_VERSION_2_0

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendEquationSeparate(uint modeRGB, uint modeAlpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawBuffers(int n, uint* bufs);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglStencilFuncSeparate(uint face, uint func, int r, uint mask);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglStencilMaskSeparate(uint face, uint mask);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglAttachShader(uint program, uint shader);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBindAttribLocation(uint program, uint index, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCompileShader(uint shader);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglCreateProgram();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglCreateShader(uint shaderType);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDeleteProgram(uint program);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDeleteShader(uint shader);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDetachShader(uint program, uint shader);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDisableVertexAttribArray(uint index);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEnableVertexAttribArray(uint index);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int FNglGetAttribLocation(uint program, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramiv(uint program, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramInfoLog(uint program, int maxLength, int* length, byte* infoLog);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetShaderiv(uint shader, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetShaderInfoLog(uint shader, int maxLength, int* length, byte* infoLog);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetShaderSource(uint shader, int bufSize, int* length, byte* source);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int FNglGetUniformLocation(uint program, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetUniformfv(uint program, int location, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetUniformiv(uint program, int location, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribdv(uint index, uint pname, double* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribfv(uint index, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribiv(uint index, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribPointerv(uint index, uint pname, void** pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsProgram(uint program);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsShader(uint shader);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLinkProgram(uint program);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglShaderSource(uint shader, int count, byte** str, int* length);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUseProgram(uint program);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform1f(int location, float v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform2f(int location, float v0, float v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform3f(int location, float v0, float v1, float v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform4f(int location, float v0, float v1, float v2, float v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform1i(int location, int v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform2i(int location, int v0, int v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform3i(int location, int v0, int v1, int v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform4i(int location, int v0, int v1, int v2, int v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform1fv(int location, int count, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform2fv(int location, int count, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform3fv(int location, int count, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform4fv(int location, int count, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform1iv(int location, int count, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform2iv(int location, int count, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform3iv(int location, int count, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform4iv(int location, int count, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix2fv(int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix3fv(int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix4fv(int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglValidateProgram(uint program);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib1d(uint index, double v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib1dv(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib1f(uint index, float v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib1fv(uint index, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib1s(uint index, short v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib1sv(uint index, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib2d(uint index, double v0, double v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib2dv(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib2f(uint index, float v0, float v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib2fv(uint index, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib2s(uint index, short v0, short v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib2sv(uint index, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib3d(uint index, double v0, double v1, double v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib3dv(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib3f(uint index, float v0, float v1, float v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib3fv(uint index, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib3s(uint index, short v0, short v1, short v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib3sv(uint index, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4Nbv(uint index, byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4Niv(uint index, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4Nsv(uint index, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib4Nub(uint index, byte v0, byte v1, byte v2, byte v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4Nubv(uint index, byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4Nuiv(uint index, uint* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4Nusv(uint index, ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4bv(uint index, byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib4d(uint index, double v0, double v1, double v2, double v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4dv(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib4f(uint index, float v0, float v1, float v2, float v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4fv(uint index, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4iv(uint index, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib4s(uint index, short v0, short v1, short v2, short v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4sv(uint index, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4ubv(uint index, byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4uiv(uint index, uint* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4usv(uint index, ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, void* pointer);

        #endregion GL_VERSION_2_0

        #region GL_VERSION_2_1

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix2x3fv(int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix3x2fv(int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix2x4fv(int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix4x2fv(int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix3x4fv(int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix4x3fv(int location, int count, bool transpose, float* value);

        #endregion GL_VERSION_2_1

        #region GL_VERSION_3_0

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColorMaski(uint buf, bool red, bool green, bool blue, bool alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetBooleani_v(uint target, uint index, bool* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetIntegeri_v(uint target, uint index, int* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEnablei(uint cap, uint index);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDisablei(uint cap, uint index);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsEnabledi(uint cap, uint index);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBeginTransformFeedback(uint primitiveMode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEndTransformFeedback();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindBufferRange(uint target, uint index, uint buffer, IntPtr offset, IntPtr size);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindBufferBase(uint target, uint index, uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTransformFeedbackVaryings(uint program, int count, byte** varyings, uint bufferMode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClampColor(uint target, uint clamp);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBeginConditionalRender(uint id, uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEndConditionalRender();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribIPointer(uint index, int size, uint type, int stride, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribIiv(uint index, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribIuiv(uint index, uint pname, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribI1i(uint index, int v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribI2i(uint index, int v0, int v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribI3i(uint index, int v0, int v1, int v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribI4i(uint index, int v0, int v1, int v2, int v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribI1ui(uint index, uint v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribI2ui(uint index, uint v0, uint v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribI3ui(uint index, uint v0, uint v1, uint v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribI4ui(uint index, uint v0, uint v1, uint v2, uint v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI1iv(uint index, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI2iv(uint index, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI3iv(uint index, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI4iv(uint index, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI1uiv(uint index, uint* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI2uiv(uint index, uint* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI3uiv(uint index, uint* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI4uiv(uint index, uint* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI4bv(uint index, byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI4sv(uint index, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI4ubv(uint index, byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI4usv(uint index, ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetUniformuiv(uint program, int location, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBindFragDataLocation(uint program, uint colorNumber, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int FNglGetFragDataLocation(uint program, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform1ui(int location, uint v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform2ui(int location, uint v0, uint v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform3ui(int location, uint v0, uint v1, uint v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform4ui(int location, uint v0, uint v1, uint v2, uint v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform1uiv(int location, int count, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform2uiv(int location, int count, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform3uiv(int location, int count, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform4uiv(int location, int count, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexParameterIiv(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexParameterIuiv(uint target, uint pname, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexParameterIiv(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexParameterIuiv(uint target, uint pname, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglClearBufferiv(uint buffer, int drawbuffer, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglClearBufferuiv(uint buffer, int drawbuffer, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglClearBufferfv(uint buffer, int drawbuffer, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate byte* FNglGetStringi(uint name, uint index);

        #region Reuse ARB_framebuffer_object

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsRenderbuffer(uint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindRenderbuffer(uint target, uint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteRenderbuffers(int n, uint* renderbuffers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenRenderbuffers(int n, uint* renderbuffers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRenderbufferStorage(uint target, uint publicformat, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetRenderbufferParameteriv(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsFramebuffer(uint framebuffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindFramebuffer(uint target, uint framebuffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteFramebuffers(int n, uint* framebuffers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenFramebuffers(int n, uint* ids);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglCheckFramebufferStatus(uint target);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int layer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglGenerateMipmap(uint target);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRenderbufferStorageMultisample(uint target, int samples, uint publicformat, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer);

        #endregion Reuse ARB_framebuffer_object

        #region Reuse ARB_map_buffer_range

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void* FNglMapBufferRange(uint target, IntPtr offset, IntPtr length, uint access);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFlushMappedBufferRange(uint target, IntPtr offset, IntPtr length);

        #endregion Reuse ARB_map_buffer_range

        #region Reuse ARB_vertex_array_object

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindVertexArray(uint array);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteVertexArrays(int n, uint* arrays);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenVertexArrays(int n, uint* arrays);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsVertexArray(uint array);

        #endregion Reuse ARB_vertex_array_object

        #endregion GL_VERSION_3_0

        #region GL_VERSION_3_1

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawArraysInstanced(uint mode, int first, int count, int instancecount);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawElementsInstanced(uint mode, int count, uint type, void* indices, int instancecount);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexBuffer(uint target, uint publicformat, uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPrimitiveRestartIndex(uint index);

        #region Reuse ARB_copy_buffer

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyBufferSubData(uint readTarget, uint writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);

        #endregion Reuse ARB_copy_buffer

        #region Reuse ARB_uniform_buffer_object

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetUniformIndices(uint program, int uniformCount, byte** uniformNames, uint* uniformIndices);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetActiveUniformName(uint program, uint uniformIndex, int bufSize, int* length, byte* uniformName);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglGetUniformBlockIndex(uint program, byte* uniformBlockName);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, byte* uniformBlockName);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
        // public delegate void FNglBindBufferRange(uint target,uint index,uint buffer,IntPtr offset,IntPtr size);
        // public delegate void FNglBindBufferBase(uint target,uint index,uint buffer);
        // public unsafe delegate void FNglGetIntegeri_v(uint target,uint index,int* data);

        #endregion Reuse ARB_uniform_buffer_object

        #endregion GL_VERSION_3_1

        #region GL_VERSION_3_2


        #region Reuse ARB_draw_elements_base_vertex

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawElementsBaseVertex(uint mode, int count, uint type, void* indices, int basevertex);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawElementsInstancedBaseVertex(uint mode, int count, uint type, void* indices, int instancecount, int basevertex);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawElementsBaseVertex(uint mode, int* count, uint type, IntPtr indices, int drawcount, int* basevertex);

        #endregion Reuse ARB_draw_elements_base_vertex

        #region Reuse ARB_provoking_vertex

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProvokingVertex(uint provokeMode);

        #endregion Reuse ARB_provoking_vertex

        #region Reuse ARB_sync

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr FNglFenceSync(uint condition, uint flags);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsSync(IntPtr sync);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDeleteSync(IntPtr sync);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglClientWaitSync(IntPtr sync, uint flags, UInt64 timeout);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWaitSync(IntPtr sync, uint flags, UInt64 timeout);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetInteger64v(uint pname, UInt64* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetSynciv(IntPtr sync, uint pname, int bufSize, int* length, int* values);

        #endregion Reuse ARB_sync

        #region Reuse ARB_texture_multisample

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetInteger64i_v(uint target, uint index, UInt64* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetBufferParameteri64v(uint target, uint value, UInt64* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferTexture(uint target, uint attachment, uint texture, int level);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexImage2DMultisample(uint target, int samples, uint publicformat, int width, int height, bool fixedsamplelocations);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexImage3DMultisample(uint target, int samples, uint publicformat, int width, int height, int depth, bool fixedsamplelocations);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMultisamplefv(uint pname, uint index, float* val);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSampleMaski(uint maskNumber, uint mask);

        #endregion Reuse ARB_texture_multisample

        #region Compatibility-only GL 1.0 features removed from GL 3.2

        // public delegate void FNglNewList(uint list,uint mode);
        // public delegate void FNglEndList();
        // public delegate void FNglCallList(uint list);
        // public unsafe delegate void FNglCallLists(int n,uint type,void* lists);
        // public delegate void FNglDeleteLists(uint list,int range);
        // public delegate uint FNglGenLists(int range);
        // public delegate void FNglListBase(uint b);
        // public delegate void FNglBegin(uint mode);
        // public unsafe delegate void FNglBitmap(int width,int height,float xorig,float yorig,float xmove,float ymove,byte* bitmap);
        // public delegate void FNglColor3b(byte red,byte green,byte blue);
        // public unsafe delegate void FNglColor3bv(byte* v);
        // public delegate void FNglColor3d(double red,double green,double blue);
        // public unsafe delegate void FNglColor3dv(double* v);
        // public delegate void FNglColor3f(float red,float green,float blue);
        // public unsafe delegate void FNglColor3fv(float* v);
        // public delegate void FNglColor3i(int red,int green,int blue);
        // public unsafe delegate void FNglColor3iv(int* v);
        // public delegate void FNglColor3s(short red,short green,short blue);
        // public unsafe delegate void FNglColor3sv(short* v);
        // public delegate void FNglColor3ub(byte red,byte green,byte blue);
        // public unsafe delegate void FNglColor3ubv(byte* v);
        // public delegate void FNglColor3ui(uint red,uint green,uint blue);
        // public unsafe delegate void FNglColor3uiv(uint* v);
        // public delegate void FNglColor3us(ushort red,ushort green,ushort blue);
        // public unsafe delegate void FNglColor3usv(ushort* v);
        // public delegate void FNglColor4b(byte red,byte green,byte blue,byte alpha);
        // public unsafe delegate void FNglColor4bv(byte* v);
        // public delegate void FNglColor4d(double red,double green,double blue,double alpha);
        // public unsafe delegate void FNglColor4dv(double* v);
        // public delegate void FNglColor4f(float red,float green,float blue,float alpha);
        // public unsafe delegate void FNglColor4fv(float* v);
        // public delegate void FNglColor4i(int red,int green,int blue,int alpha);
        // public unsafe delegate void FNglColor4iv(int* v);
        // public delegate void FNglColor4s(short red,short green,short blue,short alpha);
        // public unsafe delegate void FNglColor4sv(short* v);
        // public delegate void FNglColor4ub(byte red,byte green,byte blue,byte alpha);
        // public unsafe delegate void FNglColor4ubv(byte* v);
        // public delegate void FNglColor4ui(uint red,uint green,uint blue,uint alpha);
        // public unsafe delegate void FNglColor4uiv(uint* v);
        // public delegate void FNglColor4us(ushort red,ushort green,ushort blue,ushort alpha);
        // public unsafe delegate void FNglColor4usv(ushort* v);
        // public delegate void FNglEdgeFlag(bool flag);
        // public unsafe delegate void FNglEdgeFlagv(bool* flag);
        // public delegate void FNglEnd();
        // public delegate void FNglIndexd(double c);
        // public unsafe delegate void FNglIndexdv(double* c);
        // public delegate void FNglIndexf(float c);
        // public unsafe delegate void FNglIndexfv(float* c);
        // public delegate void FNglIndexi(int c);
        // public unsafe delegate void FNglIndexiv(int* c);
        // public delegate void FNglIndexs(short c);
        // public unsafe delegate void FNglIndexsv(short* c);
        // public delegate void FNglNormal3b(byte nx,byte ny,byte nz);
        // public unsafe delegate void FNglNormal3bv(byte* v);
        // public delegate void FNglNormal3d(double nx,double ny,double nz);
        // public unsafe delegate void FNglNormal3dv(double* v);
        // public delegate void FNglNormal3f(float nx,float ny,float nz);
        // public unsafe delegate void FNglNormal3fv(float* v);
        // public delegate void FNglNormal3i(int nx,int ny,int nz);
        // public unsafe delegate void FNglNormal3iv(int* v);
        // public delegate void FNglNormal3s(short nx,short ny,short nz);
        // public unsafe delegate void FNglNormal3sv(short* v);
        // public delegate void FNglRasterPos2d(double x,double y);
        // public unsafe delegate void FNglRasterPos2dv(double* v);
        // public delegate void FNglRasterPos2f(float x,float y);
        // public unsafe delegate void FNglRasterPos2fv(float* v);
        // public delegate void FNglRasterPos2i(int x,int y);
        // public unsafe delegate void FNglRasterPos2iv(int* v);
        // public delegate void FNglRasterPos2s(short x,short y);
        // public unsafe delegate void FNglRasterPos2sv(short* v);
        // public delegate void FNglRasterPos3d(double x,double y,double z);
        // public unsafe delegate void FNglRasterPos3dv(double* v);
        // public delegate void FNglRasterPos3f(float x,float y,float z);
        // public unsafe delegate void FNglRasterPos3fv(float* v);
        // public delegate void FNglRasterPos3i(int x,int y,int z);
        // public unsafe delegate void FNglRasterPos3iv(int* v);
        // public delegate void FNglRasterPos3s(short x,short y,short z);
        // public unsafe delegate void FNglRasterPos3sv(short* v);
        // public delegate void FNglRasterPos4d(double x,double y,double z,double w);
        // public unsafe delegate void FNglRasterPos4dv(double* v);
        // public delegate void FNglRasterPos4f(float x,float y,float z,float w);
        // public unsafe delegate void FNglRasterPos4fv(float* v);
        // public delegate void FNglRasterPos4i(int x,int y,int z,int w);
        // public unsafe delegate void FNglRasterPos4iv(int* v);
        // public delegate void FNglRasterPos4s(short x,short y,short z,short w);
        // public unsafe delegate void FNglRasterPos4sv(short* v);
        // public delegate void FNglRectd(double x1,double y1,double x2,double y2);
        // public unsafe delegate void FNglRectdv(double* v1,double* v2);
        // public delegate void FNglRectf(float x1,float y1,float x2,float y2);
        // public unsafe delegate void FNglRectfv(float* v1,float* v2);
        // public delegate void FNglRecti(int x1,int y1,int x2,int y2);
        // public unsafe delegate void FNglRectiv(int* v1,int* v2);
        // public delegate void FNglRects(short x1,short y1,short x2,short y2);
        // public unsafe delegate void FNglRectsv(short* v1,short* v2);
        // public delegate void FNglTexCoord1d(double s);
        // public unsafe delegate void FNglTexCoord1dv(double* v);
        // public delegate void FNglTexCoord1f(float s);
        // public unsafe delegate void FNglTexCoord1fv(float* v);
        // public delegate void FNglTexCoord1i(int s);
        // public unsafe delegate void FNglTexCoord1iv(int* v);
        // public delegate void FNglTexCoord1s(short s);
        // public unsafe delegate void FNglTexCoord1sv(short* v);
        // public delegate void FNglTexCoord2d(double s,double t);
        // public unsafe delegate void FNglTexCoord2dv(double* v);
        // public delegate void FNglTexCoord2f(float s,float t);
        // public unsafe delegate void FNglTexCoord2fv(float* v);
        // public delegate void FNglTexCoord2i(int s,int t);
        // public unsafe delegate void FNglTexCoord2iv(int* v);
        // public delegate void FNglTexCoord2s(short s,short t);
        // public unsafe delegate void FNglTexCoord2sv(short* v);
        // public delegate void FNglTexCoord3d(double s,double t,double r);
        // public unsafe delegate void FNglTexCoord3dv(double* v);
        // public delegate void FNglTexCoord3f(float s,float t,float r);
        // public unsafe delegate void FNglTexCoord3fv(float* v);
        // public delegate void FNglTexCoord3i(int s,int t,int r);
        // public unsafe delegate void FNglTexCoord3iv(int* v);
        // public delegate void FNglTexCoord3s(short s,short t,short r);
        // public unsafe delegate void FNglTexCoord3sv(short* v);
        // public delegate void FNglTexCoord4d(double s,double t,double r,double q);
        // public unsafe delegate void FNglTexCoord4dv(double* v);
        // public delegate void FNglTexCoord4f(float s,float t,float r,float q);
        // public unsafe delegate void FNglTexCoord4fv(float* v);
        // public delegate void FNglTexCoord4i(int s,int t,int r,int q);
        // public unsafe delegate void FNglTexCoord4iv(int* v);
        // public delegate void FNglTexCoord4s(short s,short t,short r,short q);
        // public unsafe delegate void FNglTexCoord4sv(short* v);
        // public delegate void FNglVertex2d(double x,double y);
        // public unsafe delegate void FNglVertex2dv(double* v);
        // public delegate void FNglVertex2f(float x,float y);
        // public unsafe delegate void FNglVertex2fv(float* v);
        // public delegate void FNglVertex2i(int x,int y);
        // public unsafe delegate void FNglVertex2iv(int* v);
        // public delegate void FNglVertex2s(short x,short y);
        // public unsafe delegate void FNglVertex2sv(short* v);
        // public delegate void FNglVertex3d(double x,double y,double z);
        // public unsafe delegate void FNglVertex3dv(double* v);
        // public delegate void FNglVertex3f(float x,float y,float z);
        // public unsafe delegate void FNglVertex3fv(float* v);
        // public delegate void FNglVertex3i(int x,int y,int z);
        // public unsafe delegate void FNglVertex3iv(int* v);
        // public delegate void FNglVertex3s(short x,short y,short z);
        // public unsafe delegate void FNglVertex3sv(short* v);
        // public delegate void FNglVertex4d(double x,double y,double z,double w);
        // public unsafe delegate void FNglVertex4dv(double* v);
        // public delegate void FNglVertex4f(float x,float y,float z,float w);
        // public unsafe delegate void FNglVertex4fv(float* v);
        // public delegate void FNglVertex4i(int x,int y,int z,int w);
        // public unsafe delegate void FNglVertex4iv(int* v);
        // public delegate void FNglVertex4s(short x,short y,short z,short w);
        // public unsafe delegate void FNglVertex4sv(short* v);
        // public unsafe delegate void FNglClipPlane(uint plane,double* equation);
        // public delegate void FNglColorMaterial(uint face,uint mode);
        // public delegate void FNglFogf(uint pname,float param);
        // public unsafe delegate void FNglFogfv(uint pname,float* ps);
        // public delegate void FNglFogi(uint pname,int param);
        // public unsafe delegate void FNglFogiv(uint pname,int* ps);
        // public delegate void FNglLightf(uint light,uint pname,float param);
        // public unsafe delegate void FNglLightfv(uint light,uint pname,float* ps);
        // public delegate void FNglLighti(uint light,uint pname,int param);
        // public unsafe delegate void FNglLightiv(uint light,uint pname,int* ps);
        // public delegate void FNglLightModelf(uint pname,float param);
        // public unsafe delegate void FNglLightModelfv(uint pname,float* ps);
        // public delegate void FNglLightModeli(uint pname,int param);
        // public unsafe delegate void FNglLightModeliv(uint pname,int* ps);
        // public delegate void FNglLineStipple(int factor,ushort pattern);
        // public delegate void FNglMaterialf(uint face,uint pname,float param);
        // public unsafe delegate void FNglMaterialfv(uint face,uint pname,float* ps);
        // public delegate void FNglMateriali(uint face,uint pname,int param);
        // public unsafe delegate void FNglMaterialiv(uint face,uint pname,int* ps);
        // public unsafe delegate void FNglPolygonStipple(byte* pattern);
        // public delegate void FNglShadeModel(uint mode);
        // public delegate void FNglTexEnvf(uint target,uint pname,float param);
        // public unsafe delegate void FNglTexEnvfv(uint target,uint pname,float* ps);
        // public delegate void FNglTexEnvi(uint target,uint pname,int param);
        // public unsafe delegate void FNglTexEnviv(uint target,uint pname,int* ps);
        // public delegate void FNglTexGend(uint coord,uint pname,double param);
        // public unsafe delegate void FNglTexGendv(uint coord,uint pname,double* ps);
        // public delegate void FNglTexGenf(uint coord,uint pname,float param);
        // public unsafe delegate void FNglTexGenfv(uint coord,uint pname,float* ps);
        // public delegate void FNglTexGeni(uint coord,uint pname,int param);
        // public unsafe delegate void FNglTexGeniv(uint coord,uint pname,int* ps);
        // public unsafe delegate void FNglFeedbackBuffer(int size,uint type,float* buffer);
        // public unsafe delegate void FNglSelectBuffer(int size,uint* buffer);
        // public delegate int FNglRenderMode(uint mode);
        // public delegate void FNglInitNames();
        // public delegate void FNglLoadName(uint name);
        // public delegate void FNglPassThrough(float token);
        // public delegate void FNglPopName();
        // public delegate void FNglPushName(uint name);
        // public delegate void FNglClearAccum(float red,float green,float blue,float alpha);
        // public delegate void FNglClearIndex(float c);
        // public delegate void FNglIndexMask(uint mask);
        // public delegate void FNglAccum(uint op,float value);
        // public delegate void FNglPopAttrib();
        // public delegate void FNglPushAttrib(uint mask);
        // public unsafe delegate void FNglMap1d(uint target,double u1,double u2,int stride,int order,double* points);
        // public unsafe delegate void FNglMap1f(uint target,float u1,float u2,int stride,int order,float* points);
        // public unsafe delegate void FNglMap2d(uint target,double u1,double u2,int ustride,int uorder,double v1,double v2,int vstride,int vorder,double* points);
        // public unsafe delegate void FNglMap2f(uint target,float u1,float u2,int ustride,int uorder,float v1,float v2,int vstride,int vorder,float* points);
        // public delegate void FNglMapGrid1d(int un,double u1,double u2);
        // public delegate void FNglMapGrid1f(int un,float u1,float u2);
        // public delegate void FNglMapGrid2d(int un,double u1,double u2,int vn,double v1,double v2);
        // public delegate void FNglMapGrid2f(int un,float u1,float u2,int vn,float v1,float v2);
        // public delegate void FNglEvalCoord1d(double u);
        // public unsafe delegate void FNglEvalCoord1dv(double* u);
        // public delegate void FNglEvalCoord1f(float u);
        // public unsafe delegate void FNglEvalCoord1fv(float* u);
        // public delegate void FNglEvalCoord2d(double u,double v);
        // public unsafe delegate void FNglEvalCoord2dv(double* u);
        // public delegate void FNglEvalCoord2f(float u,float v);
        // public unsafe delegate void FNglEvalCoord2fv(float* u);
        // public delegate void FNglEvalMesh1(uint mode,int i1,int i2);
        // public delegate void FNglEvalPoint1(int i);
        // public delegate void FNglEvalMesh2(uint mode,int i1,int i2,int j1,int j2);
        // public delegate void FNglEvalPoint2(int i,int j);
        // public delegate void FNglAlphaFunc(uint func,float r);
        // public delegate void FNglPixelZoom(float xfactor,float yfactor);
        // public delegate void FNglPixelTransferf(uint pname,float param);
        // public delegate void FNglPixelTransferi(uint pname,int param);
        // public unsafe delegate void FNglPixelMapfv(uint map,int mapsize,float* values);
        // public unsafe delegate void FNglPixelMapuiv(uint map,int mapsize,uint* values);
        // public unsafe delegate void FNglPixelMapusv(uint map,int mapsize,ushort* values);
        // public delegate void FNglCopyPixels(int x,int y,int width,int height,uint type);
        // public unsafe delegate void FNglDrawPixels(int width,int height,uint format,uint type,void* data);
        // public unsafe delegate void FNglGetClipPlane(uint plane,double* equation);
        // public unsafe delegate void FNglGetLightfv(uint light,uint pname,float* ps);
        // public unsafe delegate void FNglGetLightiv(uint light,uint pname,int* ps);
        // public unsafe delegate void FNglGetMapdv(uint target,uint query,double* v);
        // public unsafe delegate void FNglGetMapfv(uint target,uint query,float* v);
        // public unsafe delegate void FNglGetMapiv(uint target,uint query,int* v);
        // public unsafe delegate void FNglGetMaterialfv(uint face,uint pname,float* ps);
        // public unsafe delegate void FNglGetMaterialiv(uint face,uint pname,int* ps);
        // public unsafe delegate void FNglGetPixelMapfv(uint map,float* data);
        // public unsafe delegate void FNglGetPixelMapuiv(uint map,uint* data);
        // public unsafe delegate void FNglGetPixelMapusv(uint map,ushort* data);
        // public unsafe delegate void FNglGetPolygonStipple(byte* pattern);
        // public unsafe delegate void FNglGetTexEnvfv(uint target,uint pname,float* ps);
        // public unsafe delegate void FNglGetTexEnviv(uint target,uint pname,int* ps);
        // public unsafe delegate void FNglGetTexGendv(uint coord,uint pname,double* ps);
        // public unsafe delegate void FNglGetTexGenfv(uint coord,uint pname,float* ps);
        // public unsafe delegate void FNglGetTexGeniv(uint coord,uint pname,int* ps);
        // public delegate bool FNglIsList(uint list);
        // public delegate void FNglFrustum(double left,double right,double bottom,double top,double nearVal,double farVal);
        // public delegate void FNglLoadIdentity();
        // public unsafe delegate void FNglLoadMatrixf(float* m);
        // public unsafe delegate void FNglLoadMatrixd(double* m);
        // public delegate void FNglMatrixMode(uint mode);
        // public unsafe delegate void FNglMultMatrixf(float* m);
        // public unsafe delegate void FNglMultMatrixd(double* m);
        // public delegate void FNglOrtho(double left,double right,double bottom,double top,double nearVal,double farVal);
        // public delegate void FNglPopMatrix();
        // public delegate void FNglPushMatrix();
        // public delegate void FNglRotated(double angle,double x,double y,double z);
        // public delegate void FNglRotatef(float angle,float x,float y,float z);
        // public delegate void FNglScaled(double x,double y,double z);
        // public delegate void FNglScalef(float x,float y,float z);
        // public delegate void FNglTranslated(double x,double y,double z);
        // public delegate void FNglTranslatef(float x,float y,float z);

        #endregion Compatibility-only GL 1.0 features removed from GL 3.2

        #region Compatibility-only GL 1.1 features removed from GL 3.2

        // public delegate void FNglArrayElement(int i);
        // public unsafe delegate void FNglColorPointer(int size,uint type,int stride,void* pointer);
        // public delegate void FNglDisableClientState(uint cap);
        // public unsafe delegate void FNglEdgeFlagPointer(int stride,void* pointer);
        // public delegate void FNglEnableClientState(uint cap);
        // public unsafe delegate void FNglIndexPointer(uint type,int stride,void* pointer);
        // public unsafe delegate void FNglGetPointerv(uint pname,void** ps);
        // public unsafe delegate void FNglInterleavedArrays(uint format,int stride,void* pointer);
        // public unsafe delegate void FNglNormalPointer(uint type,int stride,void* pointer);
        // public unsafe delegate void FNglTexCoordPointer(int size,uint type,int stride,void* pointer);
        // public unsafe delegate void FNglVertexPointer(int size,uint type,int stride,void* pointer);
        // public unsafe delegate bool FNglAreTexturesResident(int n,uint* textures,bool* residences);
        // public unsafe delegate void FNglPrioritizeTextures(int n,uint* textures,float* priorities);
        // public delegate void FNglIndexub(byte c);
        // public unsafe delegate void FNglIndexubv(byte* c);
        // public delegate void FNglPopClientAttrib();
        // public delegate void FNglPushClientAttrib(uint mask);

        #endregion Compatibility-only GL 1.1 features removed from GL 3.2

        #region Compatibility-only GL 1.2 features removed from GL 3.2


        #endregion Compatibility-only GL 1.2 features removed from GL 3.2

        #region Compatibility-only GL 1.3 features removed from GL 3.2

        // public delegate void FNglClientActiveTexture(uint texture);
        // public delegate void FNglMultiTexCoord1d(uint target,double s);
        // public unsafe delegate void FNglMultiTexCoord1dv(uint target,double* v);
        // public delegate void FNglMultiTexCoord1f(uint target,float s);
        // public unsafe delegate void FNglMultiTexCoord1fv(uint target,float* v);
        // public delegate void FNglMultiTexCoord1i(uint target,int s);
        // public unsafe delegate void FNglMultiTexCoord1iv(uint target,int* v);
        // public delegate void FNglMultiTexCoord1s(uint target,short s);
        // public unsafe delegate void FNglMultiTexCoord1sv(uint target,short* v);
        // public delegate void FNglMultiTexCoord2d(uint target,double s,double t);
        // public unsafe delegate void FNglMultiTexCoord2dv(uint target,double* v);
        // public delegate void FNglMultiTexCoord2f(uint target,float s,float t);
        // public unsafe delegate void FNglMultiTexCoord2fv(uint target,float* v);
        // public delegate void FNglMultiTexCoord2i(uint target,int s,int t);
        // public unsafe delegate void FNglMultiTexCoord2iv(uint target,int* v);
        // public delegate void FNglMultiTexCoord2s(uint target,short s,short t);
        // public unsafe delegate void FNglMultiTexCoord2sv(uint target,short* v);
        // public delegate void FNglMultiTexCoord3d(uint target,double s,double t,double r);
        // public unsafe delegate void FNglMultiTexCoord3dv(uint target,double* v);
        // public delegate void FNglMultiTexCoord3f(uint target,float s,float t,float r);
        // public unsafe delegate void FNglMultiTexCoord3fv(uint target,float* v);
        // public delegate void FNglMultiTexCoord3i(uint target,int s,int t,int r);
        // public unsafe delegate void FNglMultiTexCoord3iv(uint target,int* v);
        // public delegate void FNglMultiTexCoord3s(uint target,short s,short t,short r);
        // public unsafe delegate void FNglMultiTexCoord3sv(uint target,short* v);
        // public delegate void FNglMultiTexCoord4d(uint target,double s,double t,double r,double q);
        // public unsafe delegate void FNglMultiTexCoord4dv(uint target,double* v);
        // public delegate void FNglMultiTexCoord4f(uint target,float s,float t,float r,float q);
        // public unsafe delegate void FNglMultiTexCoord4fv(uint target,float* v);
        // public delegate void FNglMultiTexCoord4i(uint target,int s,int t,int r,int q);
        // public unsafe delegate void FNglMultiTexCoord4iv(uint target,int* v);
        // public delegate void FNglMultiTexCoord4s(uint target,short s,short t,short r,short q);
        // public unsafe delegate void FNglMultiTexCoord4sv(uint target,short* v);
        // public unsafe delegate void FNglLoadTransposeMatrixf(float* m);
        // public unsafe delegate void FNglLoadTransposeMatrixd(double* m);
        // public unsafe delegate void FNglMultTransposeMatrixf(float* m);
        // public unsafe delegate void FNglMultTransposeMatrixd(double* m);

        #endregion Compatibility-only GL 1.3 features removed from GL 3.2

        #region Compatibility-only GL 1.4 features removed from GL 3.2

        // public delegate void FNglFogCoordf(float coord);
        // public unsafe delegate void FNglFogCoordfv(float* coord);
        // public delegate void FNglFogCoordd(double coord);
        // public unsafe delegate void FNglFogCoorddv(double* coord);
        // public unsafe delegate void FNglFogCoordPointer(uint type,int stride,void* pointer);
        // public delegate void FNglSecondaryColor3b(byte red,byte green,byte blue);
        // public unsafe delegate void FNglSecondaryColor3bv(byte* v);
        // public delegate void FNglSecondaryColor3d(double red,double green,double blue);
        // public unsafe delegate void FNglSecondaryColor3dv(double* v);
        // public delegate void FNglSecondaryColor3f(float red,float green,float blue);
        // public unsafe delegate void FNglSecondaryColor3fv(float* v);
        // public delegate void FNglSecondaryColor3i(int red,int green,int blue);
        // public unsafe delegate void FNglSecondaryColor3iv(int* v);
        // public delegate void FNglSecondaryColor3s(short red,short green,short blue);
        // public unsafe delegate void FNglSecondaryColor3sv(short* v);
        // public delegate void FNglSecondaryColor3ub(byte red,byte green,byte blue);
        // public unsafe delegate void FNglSecondaryColor3ubv(byte* v);
        // public delegate void FNglSecondaryColor3ui(uint red,uint green,uint blue);
        // public unsafe delegate void FNglSecondaryColor3uiv(uint* v);
        // public delegate void FNglSecondaryColor3us(ushort red,ushort green,ushort blue);
        // public unsafe delegate void FNglSecondaryColor3usv(ushort* v);
        // public unsafe delegate void FNglSecondaryColorPointer(int size,uint type,int stride,void* pointer);
        // public delegate void FNglWindowPos2d(double x,double y);
        // public unsafe delegate void FNglWindowPos2dv(double* v);
        // public delegate void FNglWindowPos2f(float x,float y);
        // public unsafe delegate void FNglWindowPos2fv(float* v);
        // public delegate void FNglWindowPos2i(int x,int y);
        // public unsafe delegate void FNglWindowPos2iv(int* v);
        // public delegate void FNglWindowPos2s(short x,short y);
        // public unsafe delegate void FNglWindowPos2sv(short* v);
        // public delegate void FNglWindowPos3d(double x,double y,double z);
        // public unsafe delegate void FNglWindowPos3dv(double* v);
        // public delegate void FNglWindowPos3f(float x,float y,float z);
        // public unsafe delegate void FNglWindowPos3fv(float* v);
        // public delegate void FNglWindowPos3i(int x,int y,int z);
        // public unsafe delegate void FNglWindowPos3iv(int* v);
        // public delegate void FNglWindowPos3s(short x,short y,short z);
        // public unsafe delegate void FNglWindowPos3sv(short* v);

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

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int FNglGetFragDataIndex(uint program, byte* name);

        #endregion Reuse ARB_blend_func_extended

        #region Reuse ARB_sampler_objects

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenSamplers(int n, uint* samplers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteSamplers(int n, uint* samplers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsSampler(uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindSampler(uint unit, uint sampler);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSamplerParameteri(uint sampler, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSamplerParameteriv(uint sampler, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSamplerParameterf(uint sampler, uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSamplerParameterfv(uint sampler, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSamplerParameterIiv(uint sampler, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSamplerParameterIuiv(uint sampler, uint pname, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetSamplerParameteriv(uint sampler, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetSamplerParameterIiv(uint sampler, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetSamplerParameterfv(uint sampler, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetSamplerParameterIuiv(uint sampler, uint pname, uint* ps);

        #endregion Reuse ARB_sampler_objects

        #region Reuse ARB_timer_query

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglQueryCounter(uint id, uint target);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetQueryObjecti64v(uint id, uint pname, UInt64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetQueryObjectui64v(uint id, uint pname, UInt64* ps);

        #endregion Reuse ARB_timer_query

        #region Reuse ARB_vertex_type_2_10_10_10_rev

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribDivisor(uint index, uint divisor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribP1ui(uint index, uint type, bool normalized, uint value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribP1uiv(uint index, uint type, bool normalized, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribP2ui(uint index, uint type, bool normalized, uint value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribP2uiv(uint index, uint type, bool normalized, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribP3ui(uint index, uint type, bool normalized, uint value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribP3uiv(uint index, uint type, bool normalized, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribP4ui(uint index, uint type, bool normalized, uint value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribP4uiv(uint index, uint type, bool normalized, uint* value);

        #endregion Reuse ARB_vertex_type_2_10_10_10_rev

        #region Reuse ARB_vertex_type_2_10_10_10_rev compatibility profile

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexP2ui(uint type, uint value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexP2uiv(uint type, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexP3ui(uint type, uint value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexP3uiv(uint type, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexP4ui(uint type, uint value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexP4uiv(uint type, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoordP1ui(uint type, uint coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoordP1uiv(uint type, uint* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoordP2ui(uint type, uint coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoordP2uiv(uint type, uint* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoordP3ui(uint type, uint coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoordP3uiv(uint type, uint* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoordP4ui(uint type, uint coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoordP4uiv(uint type, uint* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoordP1ui(uint texture, uint type, uint coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoordP1uiv(uint texture, uint type, uint* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoordP2ui(uint texture, uint type, uint coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoordP2uiv(uint texture, uint type, uint* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoordP3ui(uint texture, uint type, uint coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoordP3uiv(uint texture, uint type, uint* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoordP4ui(uint texture, uint type, uint coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoordP4uiv(uint texture, uint type, uint* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNormalP3ui(uint type, uint coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormalP3uiv(uint type, uint* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColorP3ui(uint type, uint color);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColorP3uiv(uint type, uint* color);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColorP4ui(uint type, uint color);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColorP4uiv(uint type, uint* color);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColorP3ui(uint type, uint color);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColorP3uiv(uint type, uint* color);

        #endregion Reuse ARB_vertex_type_2_10_10_10_rev compatibility profile

        #endregion GL_VERSION_3_3

        #region GL_VERSION_4_0

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMinSampleShading(float value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendEquationi(uint buf, uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendFunci(uint buf, uint sfactor, uint dfactor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);

        #region Reuse ARB_draw_indirect

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawArraysIndirect(uint mode, void* indirect);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawElementsIndirect(uint mode, uint type, void* indirect);

        #endregion Reuse ARB_draw_indirect

        #region Reuse ARB_gpu_shader_fp64

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform1d(int location, double x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform2d(int location, double x, double y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform3d(int location, double x, double y, double z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform4d(int location, double x, double y, double z, double w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform1dv(int location, int count, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform2dv(int location, int count, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform3dv(int location, int count, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform4dv(int location, int count, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix2dv(int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix3dv(int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix4dv(int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix2x3dv(int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix2x4dv(int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix3x2dv(int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix3x4dv(int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix4x2dv(int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix4x3dv(int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetUniformdv(uint program, int location, double* ps);

        #endregion Reuse ARB_gpu_shader_fp64

        #region Reuse ARB_shader_subroutine

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int FNglGetSubroutineUniformLocation(uint program, uint shadertype, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglGetSubroutineIndex(uint program, uint shadertype, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufSize, int* length, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetActiveSubroutineName(uint program, uint shadertype, uint index, int bufSize, int* length, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformSubroutinesuiv(uint shadertype, int count, uint* indices);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetUniformSubroutineuiv(uint shadertype, int location, uint* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramStageiv(uint program, uint shadertype, uint pname, int* values);

        #endregion Reuse ARB_shader_subroutine

        #region Reuse ARB_tessellation_shader

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPatchParameteri(uint pname, int value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPatchParameterfv(uint pname, float* values);

        #endregion Reuse ARB_tessellation_shader

        #region Reuse ARB_transform_feedback2

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindTransformFeedback(uint target, uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteTransformFeedbacks(int n, uint* ids);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenTransformFeedbacks(int n, uint* ids);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsTransformFeedback(uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPauseTransformFeedback();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglResumeTransformFeedback();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawTransformFeedback(uint mode, uint id);

        #endregion Reuse ARB_transform_feedback2

        #region Reuse ARB_transform_feedback3

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawTransformFeedbackStream(uint mode, uint id, uint stream);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBeginQueryIndexed(uint target, uint index, uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEndQueryIndexed(uint target, uint index);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetQueryIndexediv(uint target, uint index, uint pname, int* ps);

        #endregion Reuse ARB_transform_feedback3

        #endregion GL_VERSION_4_0

        #region GL_VERSION_4_1


        #region Reuse commands from ARB_ES2_compatibility

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglReleaseShaderCompiler();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglShaderBinary(int count, uint* shaders, uint binaryFormat, void* binary, int length);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetShaderPrecisionFormat(uint shaderType, uint precisionType, int* range, int* precision);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDepthRangef(float nearVal, float farVal);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClearDepthf(float depth);

        #endregion Reuse commands from ARB_ES2_compatibility

        #region Reuse commands from ARB_get_program_binary

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramBinary(uint program, uint binaryFormat, void* binary, int length);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramParameteri(uint program, uint pname, int value);

        #endregion Reuse commands from ARB_get_program_binary

        #region Reuse commands from ARB_separate_shader_objects

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUseProgramStages(uint pipeline, uint stages, uint program);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglActiveShaderProgram(uint pipeline, uint program);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglCreateShaderProgramv(uint type, int count, byte** strings);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindProgramPipeline(uint pipeline);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteProgramPipelines(int n, uint* pipelines);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenProgramPipelines(int n, uint* pipelines);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsProgramPipeline(uint pipeline);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramPipelineiv(uint pipeline, uint pname, int* ps);
        // public delegate void FNglProgramParameteri(uint program,uint pname,int value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform1i(uint program, int location, int v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform1iv(uint program, int location, int count, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform1f(uint program, int location, float v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform1fv(uint program, int location, int count, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform1d(uint program, int location, double v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform1dv(uint program, int location, int count, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform1ui(uint program, int location, uint v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform1uiv(uint program, int location, int count, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform2i(uint program, int location, int v0, int v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform2iv(uint program, int location, int count, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform2f(uint program, int location, float v0, float v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform2fv(uint program, int location, int count, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform2d(uint program, int location, double v0, double v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform2dv(uint program, int location, int count, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform2ui(uint program, int location, uint v0, uint v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform2uiv(uint program, int location, int count, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform3i(uint program, int location, int v0, int v1, int v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform3iv(uint program, int location, int count, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform3f(uint program, int location, float v0, float v1, float v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform3fv(uint program, int location, int count, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform3d(uint program, int location, double v0, double v1, double v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform3dv(uint program, int location, int count, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform3uiv(uint program, int location, int count, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform4iv(uint program, int location, int count, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform4fv(uint program, int location, int count, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform4dv(uint program, int location, int count, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform4uiv(uint program, int location, int count, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, double* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglValidateProgramPipeline(uint pipeline);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, byte* infoLog);

        #endregion Reuse commands from ARB_separate_shader_objects

        #region Reuse commands from ARB_vertex_attrib_64bit

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribL1d(uint index, double v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribL2d(uint index, double v0, double v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribL3d(uint index, double v0, double v1, double v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribL4d(uint index, double v0, double v1, double v2, double v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribL1dv(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribL2dv(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribL3dv(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribL4dv(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribLPointer(uint index, int size, uint type, int stride, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribLdv(uint index, uint pname, double* ps);

        #endregion Reuse commands from ARB_vertex_attrib_64bit

        #region Reuse commands from ARB_viewport_array

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglViewportArrayv(uint first, int count, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglViewportIndexedf(uint index, float x, float y, float w, float h);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglViewportIndexedfv(uint index, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglScissorArrayv(uint first, int count, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglScissorIndexed(uint index, int left, int bottom, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglScissorIndexedv(uint index, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDepthRangeArrayv(uint first, int count, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDepthRangeIndexed(uint index, double nearVal, double farVal);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetFloati_v(uint target, uint index, float* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetDoublei_v(uint target, uint index, double* data);

        #endregion Reuse commands from ARB_viewport_array

        #endregion GL_VERSION_4_1

        #region GL_VERSION_4_2


        #region Reuse commands from ARB_base_instance

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawElementsInstancedBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, uint baseinstance);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, int basevertex, uint baseinstance);

        #endregion Reuse commands from ARB_base_instance

        #region Reuse commands from ARB_publicformat_query

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetInternalformativ(uint target, uint publicformat, uint pname, int bufSize, int* ps);

        #endregion Reuse commands from ARB_publicformat_query

        #region Reuse commands from ARB_shader_atomic_counters

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int* ps);

        #endregion Reuse commands from ARB_shader_atomic_counters

        #region Reuse commands from ARB_shader_image_load_store

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMemoryBarrier(uint barriers);

        #endregion Reuse commands from ARB_shader_image_load_store

        #region Reuse commands from ARB_texture_storage

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexStorage1D(uint target, int levels, uint publicformat, int width);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexStorage2D(uint target, int levels, uint publicformat, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexStorage3D(uint target, int levels, uint publicformat, int width, int height, int depth);

        #endregion Reuse commands from ARB_texture_storage

        #region Reuse commands from ARB_transform_feedback_instanced

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawTransformFeedbackInstanced(uint mode, uint id, int instancecount);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount);

        #endregion Reuse commands from ARB_transform_feedback_instanced

        #endregion GL_VERSION_4_2

        #region GL_VERSION_4_3


        #region Reuse commands from ARB_clear_buffer_object

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglClearBufferData(uint target, uint publicformat, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglClearBufferSubData(uint target, uint publicformat, IntPtr offset, IntPtr size, uint format, uint type, void* data);

        #endregion Reuse commands from ARB_clear_buffer_object

        #region Reuse commands from ARB_compute_shader

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDispatchComputeIndirect(IntPtr indirect);

        #endregion Reuse commands from ARB_compute_shader

        #region Reuse commands from ARB_copy_image

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);

        #endregion Reuse commands from ARB_copy_image

        #region Reuse commands from ARB_framebuffer_no_attachments

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferParameteri(uint target, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetFramebufferParameteriv(uint target, uint pname, int* ps);

        #endregion Reuse commands from ARB_framebuffer_no_attachments

        #region Reuse commands from ARB_publicformat_query2

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetInternalformati64v(uint target, uint publicformat, uint pname, int bufSize, UInt64* ps);

        #endregion Reuse commands from ARB_publicformat_query2

        #region Reuse commands from ARB_invalidate_subdata

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglInvalidateTexImage(uint texture, int level);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglInvalidateBufferSubData(uint buffer, IntPtr offset, IntPtr length);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglInvalidateBufferData(uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglInvalidateFramebuffer(uint target, int numAttachments, uint* attachments);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglInvalidateSubFramebuffer(uint target, int numAttachments, uint* attachments, int x, int y, int width, int height);

        #endregion Reuse commands from ARB_invalidate_subdata

        #region Reuse commands from ARB_multi_draw_indirect

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawArraysIndirect(uint mode, void* indirect, int drawcount, int stride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawElementsIndirect(uint mode, uint type, void* indirect, int drawcount, int stride);

        #endregion Reuse commands from ARB_multi_draw_indirect

        #region Reuse commands from ARB_program_interface_query

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramInterfaceiv(uint program, uint programInterface, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglGetProgramResourceIndex(uint program, uint programInterface, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int* length, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint* props, int bufSize, int* length, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int FNglGetProgramResourceLocation(uint program, uint programInterface, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int FNglGetProgramResourceLocationIndex(uint program, uint programInterface, byte* name);

        #endregion Reuse commands from ARB_program_interface_query

        #region Reuse commands from ARB_shader_storage_buffer_object

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding);

        #endregion Reuse commands from ARB_shader_storage_buffer_object

        #region Reuse commands from ARB_texture_buffer_range

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexBufferRange(uint target, uint publicformat, uint buffer, IntPtr offset, IntPtr size);

        #endregion Reuse commands from ARB_texture_buffer_range

        #region Reuse commands from ARB_texture_storage_multisample

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexStorage2DMultisample(uint target, int samples, uint publicformat, int width, int height, bool fixedsamplelocations);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexStorage3DMultisample(uint target, int samples, uint publicformat, int width, int height, int depth, bool fixedsamplelocations);

        #endregion Reuse commands from ARB_texture_storage_multisample

        #region Reuse commands from ARB_texture_view

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureView(uint texture, uint target, uint origtexture, uint publicformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);

        #endregion Reuse commands from ARB_texture_view

        #region Reuse commands from ARB_vertex_attrib_binding

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindVertexBuffer(uint bindingindex, uint buffer, IntPtr offset, int stride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribFormat(uint attribindex, int size, uint type, bool normalized, uint relativeoffset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribBinding(uint attribindex, uint bindingindex);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexBindingDivisor(uint bindingindex, uint divisor);

        #endregion Reuse commands from ARB_vertex_attrib_binding

        #region Reuse commands from KHR_debug (includes ARB_debug_output commands promoted to KHR without suffixes)

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void GLDEBUGPROC(uint source, uint type, uint id, uint severity, int length, byte* message, void* userParam);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDebugMessageControl(uint source, uint type, uint severity, int count, uint* ids, bool enabled);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDebugMessageInsert(uint source, uint type, uint id, uint severity, int length, byte* message);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDebugMessageCallback(GLDEBUGPROC callback, void* userParam);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglGetDebugMessageLog(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, byte* messageLog);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPushDebugGroup(uint source, uint id, int length, byte* message);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPopDebugGroup();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglObjectLabel(uint identifier, uint name, int length, byte* label);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetObjectLabel(uint identifier, uint name, int bufSize, int* length, byte* label);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglObjectPtrLabel(void* ptr, int length, byte* label);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label);
        // public unsafe delegate void FNglGetPointerv(uint pname,void** ps);

        #endregion Reuse commands from KHR_debug (includes ARB_debug_output commands promoted to KHR without suffixes)

        #endregion GL_VERSION_4_3

        #region GL_VERSION_4_4


        #region Reuse GL_ARB_buffer_storage

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBufferStorage(uint target, IntPtr size, void* data, uint flags);

        #endregion Reuse GL_ARB_buffer_storage

        #region Reuse GL_ARB_clear_texture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglClearTexImage(uint texture, int level, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* data);

        #endregion Reuse GL_ARB_clear_texture

        #region Reuse GL_ARB_multi_bind (none)

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBindBuffersBase(uint target, uint first, int count, uint* buffers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBindBuffersRange(uint target, uint first, int count, uint* buffers, IntPtr offsets, IntPtr sizes);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBindTextures(uint first, int count, uint* textures);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBindSamplers(uint first, int count, uint* samplers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBindImageTextures(uint first, int count, uint* textures);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBindVertexBuffers(uint first, int count, uint* buffers, IntPtr offsets, int* strides);

        #endregion Reuse GL_ARB_multi_bind (none)

        #endregion GL_VERSION_4_4

        #region GL_VERSION_4_5


        #region Reuse GL_ARB_clip_control

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClipControl(uint origin, uint depth);

        #endregion Reuse GL_ARB_clip_control

        #region Reuse GL_ARB_direct_state_access

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCreateTransformFeedbacks(int n, uint* ids);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTransformFeedbackBufferBase(uint xfb, uint index, uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTransformFeedbackBufferRange(uint xfb, uint index, uint buffer, IntPtr offset, int size);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTransformFeedbackiv(uint xfb, uint pname, int* param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTransformFeedbacki_v(uint xfb, uint pname, uint index, int* param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTransformFeedbacki64_v(uint xfb, uint pname, uint index, UInt64* param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCreateBuffers(int n, uint* buffers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNamedBufferStorage(uint buffer, IntPtr size, void* data, uint flags);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNamedBufferData(uint buffer, IntPtr size, void* data, uint usage);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNamedBufferSubData(uint buffer, IntPtr offset, IntPtr size, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyNamedBufferSubData(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglClearNamedBufferData(uint buffer, uint publicformat, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglClearNamedBufferSubData(uint buffer, uint publicformat, IntPtr offset, IntPtr size, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void* FNglMapNamedBuffer(uint buffer, uint access);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void* FNglMapNamedBufferRange(uint buffer, IntPtr offset, IntPtr length, uint access);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglUnmapNamedBuffer(uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFlushMappedNamedBufferRange(uint buffer, IntPtr offset, IntPtr length);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetNamedBufferParameteriv(uint buffer, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetNamedBufferParameteri64v(uint buffer, uint pname, UInt64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetNamedBufferPointerv(uint buffer, uint pname, void** ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetNamedBufferSubData(uint buffer, IntPtr offset, IntPtr size, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCreateFramebuffers(int n, uint* framebuffers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNamedFramebufferParameteri(uint framebuffer, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNamedFramebufferDrawBuffer(uint framebuffer, uint buf);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNamedFramebufferDrawBuffers(uint framebuffer, int n, uint* bufs);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNamedFramebufferReadBuffer(uint framebuffer, uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglInvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint* attachments);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglInvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint* attachments, int x, int y, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglCheckNamedFramebufferStatus(uint framebuffer, uint target);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetNamedFramebufferParameteriv(uint framebuffer, uint pname, int* param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCreateRenderbuffers(int n, uint* renderbuffers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNamedRenderbufferStorage(uint renderbuffer, uint publicformat, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint publicformat, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCreateTextures(uint target, int n, uint* textures);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureBuffer(uint texture, uint publicformat, uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureBufferRange(uint texture, uint publicformat, uint buffer, IntPtr offset, int size);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureStorage1D(uint texture, int levels, uint publicformat, int width);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureStorage2D(uint texture, int levels, uint publicformat, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureStorage3D(uint texture, int levels, uint publicformat, int width, int height, int depth);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureStorage2DMultisample(uint texture, int samples, uint publicformat, int width, int height, bool fixedsamplelocations);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureStorage3DMultisample(uint texture, int samples, uint publicformat, int width, int height, int depth, bool fixedsamplelocations);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, void* pixels);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureParameterf(uint texture, uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTextureParameterfv(uint texture, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureParameteri(uint texture, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTextureParameterIiv(uint texture, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTextureParameterIuiv(uint texture, uint pname, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTextureParameteriv(uint texture, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglGenerateTextureMipmap(uint texture);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindTextureUnit(uint unit, uint texture);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTextureImage(uint texture, int level, uint format, uint type, int bufSize, void* pixels);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetCompressedTextureImage(uint texture, int level, int bufSize, void* pixels);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTextureLevelParameterfv(uint texture, int level, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTextureLevelParameteriv(uint texture, int level, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTextureParameterfv(uint texture, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTextureParameterIiv(uint texture, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTextureParameterIuiv(uint texture, uint pname, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTextureParameteriv(uint texture, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCreateVertexArrays(int n, uint* arrays);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDisableVertexArrayAttrib(uint vaobj, uint index);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEnableVertexArrayAttrib(uint vaobj, uint index);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexArrayElementBuffer(uint vaobj, uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, IntPtr offset, int stride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexArrayVertexBuffers(uint vaobj, uint first, int count, uint* buffers, IntPtr offsets, int* strides);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexArrayiv(uint vaobj, uint pname, int* param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int* param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, UInt64* param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCreateSamplers(int n, uint* samplers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCreateProgramPipelines(int n, uint* pipelines);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCreateQueries(uint target, int n, uint* ids);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglGetQueryBufferObjecti64v(uint id, uint buffer, uint pname, IntPtr offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglGetQueryBufferObjectiv(uint id, uint buffer, uint pname, IntPtr offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglGetQueryBufferObjectui64v(uint id, uint buffer, uint pname, IntPtr offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglGetQueryBufferObjectuiv(uint id, uint buffer, uint pname, IntPtr offset);

        #endregion Reuse GL_ARB_direct_state_access

        #region Reuse GL_ARB_ES3_1_compatibility

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMemoryBarrierByRegion(uint barriers);

        #endregion Reuse GL_ARB_ES3_1_compatibility

        #region Reuse GL_ARB_get_texture_sub_image

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, void* pixels);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, void* pixels);

        #endregion Reuse GL_ARB_get_texture_sub_image

        #region Reuse GL_ARB_robustness

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglGetGraphicsResetStatus();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnCompressedTexImage(uint target, int level, int bufSize, void* pixels);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnTexImage(uint target, int level, uint format, uint type, int bufSize, void* pixels);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnUniformdv(uint program, int location, int bufSize, double* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnUniformfv(uint program, int location, int bufSize, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnUniformiv(uint program, int location, int bufSize, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnUniformuiv(uint program, int location, int bufSize, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, void* data);

        #endregion Reuse GL_ARB_robustness

        #region Reuse GL_ARB_robustness

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnMapdv(uint target, uint query, int bufSize, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnMapfv(uint target, uint query, int bufSize, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnMapiv(uint target, uint query, int bufSize, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnPixelMapfv(uint map, int bufSize, float* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnPixelMapuiv(uint map, int bufSize, uint* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnPixelMapusv(uint map, int bufSize, ushort* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnPolygonStipple(int bufSize, byte* pattern);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnColorTable(uint target, uint format, uint type, int bufSize, void* table);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnConvolutionFilter(uint target, uint format, uint type, int bufSize, void* image);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnSeparableFilter(uint target, uint format, uint type, int rowBufSize, void* row, int columnBufSize, void* column, void* span);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnHistogram(uint target, bool reset, uint format, uint type, int bufSize, void* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnMinmax(uint target, bool reset, uint format, uint type, int bufSize, void* values);

        #endregion Reuse GL_ARB_robustness

        #region Reuse GL_ARB_texture_barrier

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureBarrier();

        #endregion Reuse GL_ARB_texture_barrier

        #endregion GL_VERSION_4_5

        #region GL_VERSION_4_6


        #region Reuse GL_ARB_gl_spirv

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSpecializeShader(uint shader, byte* pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue);

        #endregion Reuse GL_ARB_gl_spirv

        #region Reuse GL_ARB_indirect_parameters

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawArraysIndirectCount(uint mode, void* indirect, IntPtr drawcount, int maxdrawcount, int stride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawElementsIndirectCount(uint mode, uint type, void* indirect, IntPtr drawcount, int maxdrawcount, int stride);

        #endregion Reuse GL_ARB_indirect_parameters

        #region Reuse GL_ARB_polygon_offset_clamp

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPolygonOffsetClamp(float factor, float units, float clamp);

        #endregion Reuse GL_ARB_polygon_offset_clamp

        #endregion GL_VERSION_4_6

        #region GL_3DFX_tbuffer

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTbufferMask3DFX(uint mask);

        #endregion GL_3DFX_tbuffer

        #region GL_AMD_debug_output

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void GLDEBUGPROCAMD(uint source, uint type, uint id, uint severity, int length, byte* message, void* userParam);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDebugMessageEnableAMD(uint category, uint severity, int count, uint* ids, bool enabled);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDebugMessageInsertAMD(uint category, uint severity, uint id, int length, byte* buf);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDebugMessageCallbackAMD(GLDEBUGPROCAMD callback, void* userParam);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglGetDebugMessageLogAMD(uint count, int bufSize, uint* categories, uint* severities, uint* ids, int* lengths, byte* message);

        #endregion GL_AMD_debug_output

        #region GL_AMD_draw_buffers_blend

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendFuncIndexedAMD(uint buf, uint src, uint dst);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendFuncSeparateIndexedAMD(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendEquationIndexedAMD(uint buf, uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendEquationSeparateIndexedAMD(uint buf, uint modeRGB, uint modeAlpha);

        #endregion GL_AMD_draw_buffers_blend

        #region GL_AMD_framebuffer_multisample_advanced

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRenderbufferStorageMultisampleAdvancedAMD(uint target, int samples, int storageSamples, uint publicformat, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNamedRenderbufferStorageMultisampleAdvancedAMD(uint renderbuffer, int samples, int storageSamples, uint publicformat, int width, int height);

        #endregion GL_AMD_framebuffer_multisample_advanced

        #region GL_AMD_framebuffer_sample_positions

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFramebufferSamplePositionsfvAMD(uint target, uint numsamples, uint pixelindex, float* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNamedFramebufferSamplePositionsfvAMD(uint framebuffer, uint numsamples, uint pixelindex, float* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetFramebufferParameterfvAMD(uint target, uint pname, uint numsamples, uint pixelindex, int size, float* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetNamedFramebufferParameterfvAMD(uint framebuffer, uint pname, uint numsamples, uint pixelindex, int size, float* values);

        #endregion GL_AMD_framebuffer_sample_positions

        #region GL_AMD_gpu_shader_int64

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform1i64NV(int location, Int64 x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform2i64NV(int location, Int64 x, Int64 y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform3i64NV(int location, Int64 x, Int64 y, Int64 z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform4i64NV(int location, Int64 x, Int64 y, Int64 z, Int64 w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform1i64vNV(int location, int count, Int64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform2i64vNV(int location, int count, Int64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform3i64vNV(int location, int count, Int64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform4i64vNV(int location, int count, Int64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform1ui64NV(int location, UInt64 x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform2ui64NV(int location, UInt64 x, UInt64 y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform3ui64NV(int location, UInt64 x, UInt64 y, UInt64 z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform4ui64NV(int location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform1ui64vNV(int location, int count, UInt64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform2ui64vNV(int location, int count, UInt64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform3ui64vNV(int location, int count, UInt64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform4ui64vNV(int location, int count, UInt64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetUniformi64vNV(uint program, int location, Int64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetUniformui64vNV(uint program, int location, UInt64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform1i64NV(uint program, int location, Int64 x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform2i64NV(uint program, int location, Int64 x, Int64 y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform3i64NV(uint program, int location, Int64 x, Int64 y, Int64 z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform4i64NV(uint program, int location, Int64 x, Int64 y, Int64 z, Int64 w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform1i64vNV(uint program, int location, int count, Int64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform2i64vNV(uint program, int location, int count, Int64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform3i64vNV(uint program, int location, int count, Int64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform4i64vNV(uint program, int location, int count, Int64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform1ui64NV(uint program, int location, UInt64 x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform2ui64NV(uint program, int location, UInt64 x, UInt64 y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform3ui64NV(uint program, int location, UInt64 x, UInt64 y, UInt64 z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform4ui64NV(uint program, int location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform1ui64vNV(uint program, int location, int count, UInt64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform2ui64vNV(uint program, int location, int count, UInt64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform3ui64vNV(uint program, int location, int count, UInt64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform4ui64vNV(uint program, int location, int count, UInt64* value);

        #endregion GL_AMD_gpu_shader_int64

        #region GL_AMD_interleaved_elements

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribParameteriAMD(uint index, uint pname, int param);

        #endregion GL_AMD_interleaved_elements

        #region GL_AMD_multi_draw_indirect

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawArraysIndirectAMD(uint mode, void* indirect, int primcount, int stride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawElementsIndirectAMD(uint mode, uint type, void* indirect, int primcount, int stride);

        #endregion GL_AMD_multi_draw_indirect

        #region GL_AMD_name_gen_delete

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenNamesAMD(uint identifier, uint num, uint* names);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteNamesAMD(uint identifier, uint num, uint* names);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsNameAMD(uint identifier, uint name);

        #endregion GL_AMD_name_gen_delete

        #region GL_AMD_occlusion_query_event

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglQueryObjectParameteruiAMD(uint target, uint id, uint pname, uint param);

        #endregion GL_AMD_occlusion_query_event

        #region GL_AMD_performance_monitor

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPerfMonitorGroupsAMD(int* numGroups, int groupsSize, uint* groups);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPerfMonitorCountersAMD(uint group, int* numCounters, int* maxActiveCounters, int counterSize, uint* counters);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPerfMonitorGroupStringAMD(uint group, int bufSize, int* length, byte* groupString);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, int* length, byte* counterString);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPerfMonitorCounterInfoAMD(uint group, uint counter, uint pname, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenPerfMonitorsAMD(int n, uint* monitors);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeletePerfMonitorsAMD(int n, uint* monitors);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSelectPerfMonitorCountersAMD(uint monitor, bool enable, uint group, int numCounters, uint* counterList);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBeginPerfMonitorAMD(uint monitor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEndPerfMonitorAMD(uint monitor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPerfMonitorCounterDataAMD(uint monitor, uint pname, int dataSize, uint* data, int* bytesWritten);

        #endregion GL_AMD_performance_monitor

        #region GL_AMD_sample_positions

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSetMultisamplefvAMD(uint pname, uint index, float* val);

        #endregion GL_AMD_sample_positions

        #region GL_AMD_sparse_texture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexStorageSparseAMD(uint target, uint publicFormat, int width, int height, int depth, int layers, uint flags);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureStorageSparseAMD(uint texture, uint target, uint publicFormat, int width, int height, int depth, int layers, uint flags);

        #endregion GL_AMD_sparse_texture

        #region GL_AMD_stencil_operation_extended

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglStencilOpValueAMD(uint face, uint value);

        #endregion GL_AMD_stencil_operation_extended

        #region GL_AMD_vertex_shader_tessellator

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTessellationFactorAMD(float factor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTessellationModeAMD(uint mode);

        #endregion GL_AMD_vertex_shader_tessellator

        #region GL_APPLE_element_array

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglElementPointerAPPLE(uint type, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawElementArrayAPPLE(uint mode, int first, int count);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawRangeElementArrayAPPLE(uint mode, uint start, uint end, int first, int count);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawElementArrayAPPLE(uint mode, int* first, int* count, int primcount);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawRangeElementArrayAPPLE(uint mode, uint start, uint end, int* first, int* count, int primcount);

        #endregion GL_APPLE_element_array

        #region GL_APPLE_fence

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenFencesAPPLE(int n, uint* fences);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteFencesAPPLE(int n, uint* fences);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSetFenceAPPLE(uint fence);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsFenceAPPLE(uint fence);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglTestFenceAPPLE(uint fence);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFinishFenceAPPLE(uint fence);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglTestObjectAPPLE(uint obj, uint name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFinishObjectAPPLE(uint obj, int name);

        #endregion GL_APPLE_fence

        #region GL_APPLE_flush_buffer_range

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBufferParameteriAPPLE(uint target, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFlushMappedBufferRangeAPPLE(uint target, IntPtr offset, IntPtr size);

        #endregion GL_APPLE_flush_buffer_range

        #region GL_APPLE_object_purgeable

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglObjectPurgeableAPPLE(uint objectType, uint name, uint option);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglObjectUnpurgeableAPPLE(uint objectType, uint name, uint option);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetObjectParameterivAPPLE(uint objectType, uint name, uint pname, int* ps);

        #endregion GL_APPLE_object_purgeable

        #region GL_APPLE_texture_range

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTextureRangeAPPLE(uint target, int length, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexParameterPointervAPPLE(uint target, uint pname, void** ps);

        #endregion GL_APPLE_texture_range

        #region GL_APPLE_vertex_array_object

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindVertexArrayAPPLE(uint array);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteVertexArraysAPPLE(int n, uint* arrays);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenVertexArraysAPPLE(int n, uint* arrays);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsVertexArrayAPPLE(uint array);

        #endregion GL_APPLE_vertex_array_object

        #region GL_APPLE_vertex_array_range

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexArrayRangeAPPLE(int length, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFlushVertexArrayRangeAPPLE(int length, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexArrayParameteriAPPLE(uint pname, int param);

        #endregion GL_APPLE_vertex_array_range

        #region GL_APPLE_vertex_program_evaluators

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEnableVertexAttribAPPLE(uint index, uint pname);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDisableVertexAttribAPPLE(uint index, uint pname);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsVertexAttribEnabledAPPLE(uint index, uint pname);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMapVertexAttrib1dAPPLE(uint index, uint size, double u1, double u2, int stride, int order, double* points);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMapVertexAttrib1fAPPLE(uint index, uint size, float u1, float u2, int stride, int order, float* points);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMapVertexAttrib2dAPPLE(uint index, uint size, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMapVertexAttrib2fAPPLE(uint index, uint size, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);

        #endregion GL_APPLE_vertex_program_evaluators

        #region GL_ARB_ES2_compatibility

        // public delegate void FNglReleaseShaderCompiler();
        // public unsafe delegate void FNglShaderBinary(int count,uint* shaders,uint binaryFormat,void* binary,int length);
        // public unsafe delegate void FNglGetShaderPrecisionFormat(uint shaderType,uint precisionType,int* range,int* precision);
        // public delegate void FNglDepthRangef(float nearVal,float farVal);
        // public delegate void FNglClearDepthf(float depth);

        #endregion GL_ARB_ES2_compatibility

        #region GL_ARB_ES3_1_compatibility

        // public delegate void FNglMemoryBarrierByRegion(uint barriers);

        #endregion GL_ARB_ES3_1_compatibility

        #region GL_ARB_ES3_2_compatibility

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPrimitiveBoundingBoxARB(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);

        #endregion GL_ARB_ES3_2_compatibility

        #region GL_ARB_base_instance

        // public delegate void FNglDrawArraysInstancedBaseInstance(uint mode,int first,int count,int instancecount,uint baseinstance);
        // public unsafe delegate void FNglDrawElementsInstancedBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,uint baseinstance);
        // public unsafe delegate void FNglDrawElementsInstancedBaseVertexBaseInstance(uint mode,int count,uint type,void* indices,int instancecount,int basevertex,uint baseinstance);

        #endregion GL_ARB_base_instance

        #region GL_ARB_bindless_texture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate UInt64 FNglGetTextureHandleARB(uint texture);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate UInt64 FNglGetTextureSamplerHandleARB(uint texture, uint sampler);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMakeTextureHandleResidentARB(UInt64 handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMakeTextureHandleNonResidentARB(UInt64 handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate UInt64 FNglGetImageHandleARB(uint texture, int level, bool layered, int layer, uint format);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMakeImageHandleResidentARB(UInt64 handle, uint access);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMakeImageHandleNonResidentARB(UInt64 handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniformHandleui64ARB(int location, UInt64 value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformHandleui64vARB(int location, int count, UInt64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniformHandleui64ARB(uint program, int location, UInt64 value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformHandleui64vARB(uint program, int location, int count, UInt64* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsTextureHandleResidentARB(UInt64 handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsImageHandleResidentARB(UInt64 handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribL1ui64ARB(uint index, UInt64 x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribL1ui64vARB(uint index, UInt64* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribLui64vARB(uint index, uint pname, UInt64* ps);

        #endregion GL_ARB_bindless_texture

        #region GL_ARB_blend_func_extended

        // public unsafe delegate void FNglBindFragDataLocationIndexed(uint program,uint colorNumber,uint index,byte* name);
        // public unsafe delegate int FNglGetFragDataIndex(uint program,byte* name);

        #endregion GL_ARB_blend_func_extended

        #region GL_ARB_buffer_storage

        // public unsafe delegate void FNglBufferStorage(uint target,IntPtr size,void* data,uint flags);

        #endregion GL_ARB_buffer_storage

        #region GL_ARB_cl_event

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr FNglCreateSyncFromCLeventARB(IntPtr context, IntPtr e, uint flags);

        #endregion GL_ARB_cl_event

        #region GL_ARB_clear_buffer_object

        // public unsafe delegate void FNglClearBufferData(uint target,uint publicformat,uint format,uint type,void* data);
        // public unsafe delegate void FNglClearBufferSubData(uint target,uint publicformat,IntPtr offset,IntPtr size,uint format,uint type,void* data);

        #endregion GL_ARB_clear_buffer_object

        #region GL_ARB_clear_texture

        // public unsafe delegate void FNglClearTexImage(uint texture,int level,uint format,uint type,void* data);
        // public unsafe delegate void FNglClearTexSubImage(uint texture,int level,int xoffset,int yoffset,int zoffset,int width,int height,int depth,uint format,uint type,void* data);

        #endregion GL_ARB_clear_texture

        #region GL_ARB_clip_control

        // public delegate void FNglClipControl(uint origin,uint depth);

        #endregion GL_ARB_clip_control

        #region GL_ARB_color_buffer_float

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClampColorARB(uint target, uint clamp);

        #endregion GL_ARB_color_buffer_float

        #region GL_ARB_compute_shader

        // public delegate void FNglDispatchCompute(uint num_groups_x,uint num_groups_y,uint num_groups_z);
        // public delegate void FNglDispatchComputeIndirect(IntPtr indirect);

        #endregion GL_ARB_compute_shader

        #region GL_ARB_compute_variable_group_size

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDispatchComputeGroupSizeARB(uint num_groups_x, uint num_groups_y, uint num_groups_z, uint group_size_x, uint group_size_y, uint group_size_z);

        #endregion GL_ARB_compute_variable_group_size

        #region GL_ARB_copy_buffer

        // public delegate void FNglCopyBufferSubData(uint readTarget,uint writeTarget,IntPtr readOffset,IntPtr writeOffset,IntPtr size);

        #endregion GL_ARB_copy_buffer

        #region GL_ARB_copy_image

        // public delegate void FNglCopyImageSubData(uint srcName,uint srcTarget,int srcLevel,int srcX,int srcY,int srcZ,uint dstName,uint dstTarget,int dstLevel,int dstX,int dstY,int dstZ,int srcWidth,int srcHeight,int srcDepth);

        #endregion GL_ARB_copy_image

        #region GL_ARB_debug_output

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void GLDEBUGPROCARB(uint source, uint type, uint id, uint severity, int length, byte* message, void* userParam);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDebugMessageControlARB(uint source, uint type, uint severity, int count, uint* ids, bool enabled);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDebugMessageInsertARB(uint source, uint type, uint id, uint severity, int length, byte* buf);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDebugMessageCallbackARB(GLDEBUGPROCARB callback, void* userParam);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglGetDebugMessageLogARB(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, byte* messageLog);

        #endregion GL_ARB_debug_output

        #region GL_ARB_draw_buffers

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawBuffersARB(int n, uint* bufs);

        #endregion GL_ARB_draw_buffers

        #region GL_ARB_draw_buffers_blend

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendEquationiARB(uint buf, uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendEquationSeparateiARB(uint buf, uint modeRGB, uint modeAlpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendFunciARB(uint buf, uint src, uint dst);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendFuncSeparateiARB(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);

        #endregion GL_ARB_draw_buffers_blend

        #region GL_ARB_draw_elements_base_vertex

        // public unsafe delegate void FNglDrawElementsBaseVertex(uint mode,int count,uint type,void* indices,int basevertex);
        // public unsafe delegate void FNglDrawRangeElementsBaseVertex(uint mode,uint start,uint end,int count,uint type,void* indices,int basevertex);
        // public unsafe delegate void FNglDrawElementsInstancedBaseVertex(uint mode,int count,uint type,void* indices,int instancecount,int basevertex);
        // public unsafe delegate void FNglMultiDrawElementsBaseVertex(uint mode,int* count,uint type,IntPtr indices,int drawcount,int* basevertex);

        #endregion GL_ARB_draw_elements_base_vertex

        #region GL_ARB_draw_indirect

        // public unsafe delegate void FNglDrawArraysIndirect(uint mode,void* indirect);
        // public unsafe delegate void FNglDrawElementsIndirect(uint mode,uint type,void* indirect);

        #endregion GL_ARB_draw_indirect

        #region GL_ARB_draw_instanced

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawArraysInstancedARB(uint mode, int first, int count, int primcount);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawElementsInstancedARB(uint mode, int count, uint type, void* indices, int primcount);

        #endregion GL_ARB_draw_instanced

        #region GL_ARB_framebuffer_no_attachments

        // public delegate void FNglFramebufferParameteri(uint target,uint pname,int param);
        // public unsafe delegate void FNglGetFramebufferParameteriv(uint target,uint pname,int* ps);

        #endregion GL_ARB_framebuffer_no_attachments

        #region GL_ARB_framebuffer_object

        // public delegate bool FNglIsRenderbuffer(uint renderbuffer);
        // public delegate void FNglBindRenderbuffer(uint target,uint renderbuffer);
        // public unsafe delegate void FNglDeleteRenderbuffers(int n,uint* renderbuffers);
        // public unsafe delegate void FNglGenRenderbuffers(int n,uint* renderbuffers);
        // public delegate void FNglRenderbufferStorage(uint target,uint publicformat,int width,int height);
        // public unsafe delegate void FNglGetRenderbufferParameteriv(uint target,uint pname,int* ps);
        // public delegate bool FNglIsFramebuffer(uint framebuffer);
        // public delegate void FNglBindFramebuffer(uint target,uint framebuffer);
        // public unsafe delegate void FNglDeleteFramebuffers(int n,uint* framebuffers);
        // public unsafe delegate void FNglGenFramebuffers(int n,uint* ids);
        // public delegate uint FNglCheckFramebufferStatus(uint target);
        // public delegate void FNglFramebufferTexture1D(uint target,uint attachment,uint textarget,uint texture,int level);
        // public delegate void FNglFramebufferTexture2D(uint target,uint attachment,uint textarget,uint texture,int level);
        // public delegate void FNglFramebufferTexture3D(uint target,uint attachment,uint textarget,uint texture,int level,int layer);
        // public delegate void FNglFramebufferRenderbuffer(uint target,uint attachment,uint renderbuffertarget,uint renderbuffer);
        // public unsafe delegate void FNglGetFramebufferAttachmentParameteriv(uint target,uint attachment,uint pname,int* ps);
        // public delegate void FNglGenerateMipmap(uint target);
        // public delegate void FNglBlitFramebuffer(int srcX0,int srcY0,int srcX1,int srcY1,int dstX0,int dstY0,int dstX1,int dstY1,uint mask,uint filter);
        // public delegate void FNglRenderbufferStorageMultisample(uint target,int samples,uint publicformat,int width,int height);
        // public delegate void FNglFramebufferTextureLayer(uint target,uint attachment,uint texture,int level,int layer);

        #endregion GL_ARB_framebuffer_object

        #region GL_ARB_geometry_shader4

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramParameteriARB(uint program, uint pname, int value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferTextureARB(uint target, uint attachment, uint texture, int level);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferTextureLayerARB(uint target, uint attachment, uint texture, int level, int layer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferTextureFaceARB(uint target, uint attachment, uint texture, int level, uint face);

        #endregion GL_ARB_geometry_shader4

        #region GL_ARB_get_program_binary

        // public unsafe delegate void FNglGetProgramBinary(uint program,int bufSize,int* length,uint* binaryFormat,void* binary);
        // public unsafe delegate void FNglProgramBinary(uint program,uint binaryFormat,void* binary,int length);
        // public delegate void FNglProgramParameteri(uint program,uint pname,int value);

        #endregion GL_ARB_get_program_binary

        #region GL_ARB_get_texture_sub_image

        // public unsafe delegate void FNglGetTextureSubImage(uint texture,int level,int xoffset,int yoffset,int zoffset,int width,int height,int depth,uint format,uint type,int bufSize,void* pixels);
        // public unsafe delegate void FNglGetCompressedTextureSubImage(uint texture,int level,int xoffset,int yoffset,int zoffset,int width,int height,int depth,int bufSize,void* pixels);

        #endregion GL_ARB_get_texture_sub_image

        #region GL_ARB_gl_spirv

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSpecializeShaderARB(uint shader, byte* pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue);

        #endregion GL_ARB_gl_spirv

        #region GL_ARB_gpu_shader_fp64

        // public delegate void FNglUniform1d(int location,double x);
        // public delegate void FNglUniform2d(int location,double x,double y);
        // public delegate void FNglUniform3d(int location,double x,double y,double z);
        // public delegate void FNglUniform4d(int location,double x,double y,double z,double w);
        // public unsafe delegate void FNglUniform1dv(int location,int count,double* value);
        // public unsafe delegate void FNglUniform2dv(int location,int count,double* value);
        // public unsafe delegate void FNglUniform3dv(int location,int count,double* value);
        // public unsafe delegate void FNglUniform4dv(int location,int count,double* value);
        // public unsafe delegate void FNglUniformMatrix2dv(int location,int count,bool transpose,double* value);
        // public unsafe delegate void FNglUniformMatrix3dv(int location,int count,bool transpose,double* value);
        // public unsafe delegate void FNglUniformMatrix4dv(int location,int count,bool transpose,double* value);
        // public unsafe delegate void FNglUniformMatrix2x3dv(int location,int count,bool transpose,double* value);
        // public unsafe delegate void FNglUniformMatrix2x4dv(int location,int count,bool transpose,double* value);
        // public unsafe delegate void FNglUniformMatrix3x2dv(int location,int count,bool transpose,double* value);
        // public unsafe delegate void FNglUniformMatrix3x4dv(int location,int count,bool transpose,double* value);
        // public unsafe delegate void FNglUniformMatrix4x2dv(int location,int count,bool transpose,double* value);
        // public unsafe delegate void FNglUniformMatrix4x3dv(int location,int count,bool transpose,double* value);
        // public unsafe delegate void FNglGetUniformdv(uint program,int location,double* ps);

        #endregion GL_ARB_gpu_shader_fp64

        #region GL_ARB_gpu_shader_int64

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform1i64ARB(int location, Int64 x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform2i64ARB(int location, Int64 x, Int64 y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform3i64ARB(int location, Int64 x, Int64 y, Int64 z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform4i64ARB(int location, Int64 x, Int64 y, Int64 z, Int64 w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform1i64vARB(int location, int count, Int64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform2i64vARB(int location, int count, Int64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform3i64vARB(int location, int count, Int64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform4i64vARB(int location, int count, Int64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform1ui64ARB(int location, UInt64 x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform2ui64ARB(int location, UInt64 x, UInt64 y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform3ui64ARB(int location, UInt64 x, UInt64 y, UInt64 z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform4ui64ARB(int location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform1ui64vARB(int location, int count, UInt64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform2ui64vARB(int location, int count, UInt64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform3ui64vARB(int location, int count, UInt64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform4ui64vARB(int location, int count, UInt64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetUniformi64vARB(uint program, int location, UInt64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetUniformui64vARB(uint program, int location, UInt64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnUniformi64vARB(uint program, int location, int bufSize, UInt64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnUniformui64vARB(uint program, int location, int bufSize, UInt64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform1i64ARB(uint program, int location, Int64 x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform2i64ARB(uint program, int location, Int64 x, Int64 y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform3i64ARB(uint program, int location, Int64 x, Int64 y, Int64 z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform4i64ARB(uint program, int location, Int64 x, Int64 y, Int64 z, Int64 w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform1i64vARB(uint program, int location, int count, Int64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform2i64vARB(uint program, int location, int count, Int64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform3i64vARB(uint program, int location, int count, Int64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform4i64vARB(uint program, int location, int count, Int64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform1ui64ARB(uint program, int location, UInt64 x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform2ui64ARB(uint program, int location, UInt64 x, UInt64 y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform3ui64ARB(uint program, int location, UInt64 x, UInt64 y, UInt64 z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform4ui64ARB(uint program, int location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform1ui64vARB(uint program, int location, int count, UInt64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform2ui64vARB(uint program, int location, int count, UInt64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform3ui64vARB(uint program, int location, int count, UInt64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform4ui64vARB(uint program, int location, int count, UInt64* value);

        #endregion GL_ARB_gpu_shader_int64

        #region GL_ARB_imaging

        // public delegate void FNglBlendColor(float red,float green,float blue,float alpha);
        // public delegate void FNglBlendEquation(uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColorTable(uint target, uint publicformat, int width, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColorTableParameterfv(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColorTableParameteriv(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyColorTable(uint target, uint publicformat, int x, int y, int width);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetColorTable(uint target, uint format, uint type, void* table);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetColorTableParameterfv(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetColorTableParameteriv(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColorSubTable(uint target, int start, int count, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyColorSubTable(uint target, int start, int x, int y, int width);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglConvolutionFilter1D(uint target, uint publicformat, int width, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglConvolutionFilter2D(uint target, uint publicformat, int width, int height, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglConvolutionParameterf(uint target, uint pname, float ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglConvolutionParameterfv(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglConvolutionParameteri(uint target, uint pname, int ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglConvolutionParameteriv(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyConvolutionFilter1D(uint target, uint publicformat, int x, int y, int width);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyConvolutionFilter2D(uint target, uint publicformat, int x, int y, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetConvolutionFilter(uint target, uint format, uint type, void* image);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetConvolutionParameterfv(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetConvolutionParameteriv(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetSeparableFilter(uint target, uint format, uint type, void* row, void* column, void* span);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSeparableFilter2D(uint target, uint publicformat, int width, int height, uint format, uint type, void* row, void* column);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetHistogram(uint target, bool reset, uint format, uint type, void* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetHistogramParameterfv(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetHistogramParameteriv(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMinmax(uint target, bool reset, uint format, uint types, void* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMinmaxParameterfv(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMinmaxParameteriv(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglHistogram(uint target, int width, uint publicformat, bool sink);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMinmax(uint target, uint publicformat, bool sink);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglResetHistogram(uint target);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglResetMinmax(uint target);

        #endregion GL_ARB_imaging

        #region GL_ARB_indirect_parameters

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawArraysIndirectCountARB(uint mode, void* indirect, IntPtr drawcount, int maxdrawcount, int stride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawElementsIndirectCountARB(uint mode, uint type, void* indirect, IntPtr drawcount, int maxdrawcount, int stride);

        #endregion GL_ARB_indirect_parameters

        #region GL_ARB_instanced_arrays

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribDivisorARB(uint index, uint divisor);

        #endregion GL_ARB_instanced_arrays

        #region GL_ARB_publicformat_query

        // public unsafe delegate void FNglGetInternalformativ(uint target,uint publicformat,uint pname,int bufSize,int* ps);

        #endregion GL_ARB_publicformat_query

        #region GL_ARB_invalidate_subdata

        // public delegate void FNglInvalidateTexSubImage(uint texture,int level,int xoffset,int yoffset,int zoffset,int width,int height,int depth);
        // public delegate void FNglInvalidateTexImage(uint texture,int level);
        // public delegate void FNglInvalidateBufferSubData(uint buffer,IntPtr offset,IntPtr length);
        // public delegate void FNglInvalidateBufferData(uint buffer);
        // public unsafe delegate void FNglInvalidateFramebuffer(uint target,int numAttachments,uint* attachments);
        // public unsafe delegate void FNglInvalidateSubFramebuffer(uint target,int numAttachments,uint* attachments,int x,int y,int width,int height);

        #endregion GL_ARB_invalidate_subdata

        #region GL_ARB_map_buffer_range

        // public unsafe delegate void* FNglMapBufferRange(uint target,IntPtr offset,IntPtr length,uint access);
        // public delegate void FNglFlushMappedBufferRange(uint target,IntPtr offset,IntPtr length);

        #endregion GL_ARB_map_buffer_range

        #region GL_ARB_matrix_palette

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCurrentPaletteMatrixARB(int index);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixIndexubvARB(int size, byte* indices);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixIndexusvARB(int size, ushort* indices);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixIndexuivARB(int size, uint* indices);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixIndexPointerARB(int size, uint type, int stride, void* pointer);

        #endregion GL_ARB_matrix_palette

        #region GL_ARB_multi_bind

        // public unsafe delegate void FNglBindBuffersBase(uint target,uint first,int count,uint* buffers);
        // public unsafe delegate void FNglBindBuffersRange(uint target,uint first,int count,uint* buffers,IntPtr offsets,IntPtr sizes);
        // public unsafe delegate void FNglBindTextures(uint first,int count,uint* textures);
        // public unsafe delegate void FNglBindSamplers(uint first,int count,uint* samplers);
        // public unsafe delegate void FNglBindImageTextures(uint first,int count,uint* textures);
        // public unsafe delegate void FNglBindVertexBuffers(uint first,int count,uint* buffers,IntPtr offsets,int* strides);

        #endregion GL_ARB_multi_bind

        #region GL_ARB_multi_draw_indirect

        // public unsafe delegate void FNglMultiDrawArraysIndirect(uint mode,void* indirect,int drawcount,int stride);
        // public unsafe delegate void FNglMultiDrawElementsIndirect(uint mode,uint type,void* indirect,int drawcount,int stride);

        #endregion GL_ARB_multi_draw_indirect

        #region GL_ARB_multisample

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSampleCoverageARB(float value, bool invert);

        #endregion GL_ARB_multisample

        #region GL_ARB_multitexture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglActiveTextureARB(uint texture);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClientActiveTextureARB(uint texture);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord1dARB(uint target, double s);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord1dvARB(uint target, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord1fARB(uint target, float s);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord1fvARB(uint target, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord1iARB(uint target, int s);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord1ivARB(uint target, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord1sARB(uint target, short s);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord1svARB(uint target, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord2dARB(uint target, double s, double t);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord2dvARB(uint target, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord2fARB(uint target, float s, float t);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord2fvARB(uint target, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord2iARB(uint target, int s, int t);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord2ivARB(uint target, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord2sARB(uint target, short s, short t);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord2svARB(uint target, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord3dARB(uint target, double s, double t, double r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord3dvARB(uint target, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord3fARB(uint target, float s, float t, float r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord3fvARB(uint target, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord3iARB(uint target, int s, int t, int r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord3ivARB(uint target, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord3sARB(uint target, short s, short t, short r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord3svARB(uint target, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord4dARB(uint target, double s, double t, double r, double q);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord4dvARB(uint target, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord4fARB(uint target, float s, float t, float r, float q);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord4fvARB(uint target, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord4iARB(uint target, int s, int t, int r, int q);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord4ivARB(uint target, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord4sARB(uint target, short s, short t, short r, short q);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord4svARB(uint target, short* v);

        #endregion GL_ARB_multitexture

        #region GL_ARB_occlusion_query

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenQueriesARB(int n, uint* ids);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteQueriesARB(int n, uint* ids);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsQueryARB(uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBeginQueryARB(uint target, uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEndQueryARB(uint target);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetQueryivARB(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetQueryObjectivARB(uint id, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetQueryObjectuivARB(uint id, uint pname, uint* ps);

        #endregion GL_ARB_occlusion_query

        #region GL_ARB_parallel_shader_compile

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMaxShaderCompilerThreadsARB(uint count);

        #endregion GL_ARB_parallel_shader_compile

        #region GL_ARB_point_parameters

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPointParameterfARB(uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPointParameterfvARB(uint pname, float* ps);

        #endregion GL_ARB_point_parameters

        #region GL_ARB_polygon_offset_clamp

        // public delegate void FNglPolygonOffsetClamp(float factor,float units,float clamp);

        #endregion GL_ARB_polygon_offset_clamp

        #region GL_ARB_program_interface_query

        // public unsafe delegate void FNglGetProgramInterfaceiv(uint program,uint programInterface,uint pname,int* ps);
        // public unsafe delegate uint FNglGetProgramResourceIndex(uint program,uint programInterface,byte* name);
        // public unsafe delegate void FNglGetProgramResourceName(uint program,uint programInterface,uint index,int bufSize,int* length,byte* name);
        // public unsafe delegate void FNglGetProgramResourceiv(uint program,uint programInterface,uint index,int propCount,uint* props,int bufSize,int* length,int* ps);
        // public unsafe delegate int FNglGetProgramResourceLocation(uint program,uint programInterface,byte* name);
        // public unsafe delegate int FNglGetProgramResourceLocationIndex(uint program,uint programInterface,byte* name);

        #endregion GL_ARB_program_interface_query

        #region GL_ARB_provoking_vertex

        // public delegate void FNglProvokingVertex(uint provokeMode);

        #endregion GL_ARB_provoking_vertex

        #region GL_ARB_robustness

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglGetGraphicsResetStatusARB();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnTexImageARB(uint target, int level, uint format, uint type, int bufSize, void* img);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglReadnPixelsARB(int x, int y, int width, int height, uint format, uint type, int bufSize, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnCompressedTexImageARB(uint target, int lod, int bufSize, void* img);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnUniformfvARB(uint program, int location, int bufSize, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnUniformivARB(uint program, int location, int bufSize, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnUniformuivARB(uint program, int location, int bufSize, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnUniformdvARB(uint program, int location, int bufSize, double* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnMapdvARB(uint target, uint query, int bufSize, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnMapfvARB(uint target, uint query, int bufSize, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnMapivARB(uint target, uint query, int bufSize, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnPixelMapfvARB(uint map, int bufSize, float* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnPixelMapuivARB(uint map, int bufSize, uint* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnPixelMapusvARB(uint map, int bufSize, ushort* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnPolygonStippleARB(int bufSize, byte* pattern);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnColorTableARB(uint target, uint format, uint type, int bufSize, void* table);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnConvolutionFilterARB(uint target, uint format, uint type, int bufSize, void* image);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnSeparableFilterARB(uint target, uint format, uint type, int rowBufSize, void* row, int columnBufSize, void* column, void* span);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnHistogramARB(uint target, bool reset, uint format, uint type, int bufSize, void* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnMinmaxARB(uint target, bool reset, uint format, uint type, int bufSize, void* values);

        #endregion GL_ARB_robustness

        #region GL_ARB_sample_locations

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFramebufferSampleLocationsfvARB(uint target, uint start, int count, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNamedFramebufferSampleLocationsfvARB(uint framebuffer, uint start, int count, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEvaluateDepthValuesARB();

        #endregion GL_ARB_sample_locations

        #region GL_ARB_sample_shading

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMinSampleShadingARB(float value);

        #endregion GL_ARB_sample_shading

        #region GL_ARB_sampler_objects

        // public unsafe delegate void FNglGenSamplers(int n,uint* samplers);
        // public unsafe delegate void FNglDeleteSamplers(int n,uint* samplers);
        // public delegate bool FNglIsSampler(uint id);
        // public delegate void FNglBindSampler(uint unit,uint sampler);
        // public delegate void FNglSamplerParameteri(uint sampler,uint pname,int param);
        // public unsafe delegate void FNglSamplerParameteriv(uint sampler,uint pname,int* ps);
        // public delegate void FNglSamplerParameterf(uint sampler,uint pname,float param);
        // public unsafe delegate void FNglSamplerParameterfv(uint sampler,uint pname,float* ps);
        // public unsafe delegate void FNglSamplerParameterIiv(uint sampler,uint pname,int* ps);
        // public unsafe delegate void FNglSamplerParameterIuiv(uint sampler,uint pname,uint* ps);
        // public unsafe delegate void FNglGetSamplerParameteriv(uint sampler,uint pname,int* ps);
        // public unsafe delegate void FNglGetSamplerParameterIiv(uint sampler,uint pname,int* ps);
        // public unsafe delegate void FNglGetSamplerParameterfv(uint sampler,uint pname,float* ps);
        // public unsafe delegate void FNglGetSamplerParameterIuiv(uint sampler,uint pname,uint* ps);

        #endregion GL_ARB_sampler_objects

        #region GL_ARB_separate_shader_objects

        // public delegate void FNglUseProgramStages(uint pipeline,uint stages,uint program);
        // public delegate void FNglActiveShaderProgram(uint pipeline,uint program);
        // public unsafe delegate uint FNglCreateShaderProgramv(uint type,int count,byte** strings);
        // public delegate void FNglBindProgramPipeline(uint pipeline);
        // public unsafe delegate void FNglDeleteProgramPipelines(int n,uint* pipelines);
        // public unsafe delegate void FNglGenProgramPipelines(int n,uint* pipelines);
        // public delegate bool FNglIsProgramPipeline(uint pipeline);
        // public unsafe delegate void FNglGetProgramPipelineiv(uint pipeline,uint pname,int* ps);
        // public delegate void FNglProgramParameteri(uint program,uint pname,int value);
        // public delegate void FNglProgramUniform1i(uint program,int location,int v0);
        // public unsafe delegate void FNglProgramUniform1iv(uint program,int location,int count,int* value);
        // public delegate void FNglProgramUniform1f(uint program,int location,float v0);
        // public unsafe delegate void FNglProgramUniform1fv(uint program,int location,int count,float* value);
        // public delegate void FNglProgramUniform1d(uint program,int location,double v0);
        // public unsafe delegate void FNglProgramUniform1dv(uint program,int location,int count,double* value);
        // public delegate void FNglProgramUniform1ui(uint program,int location,uint v0);
        // public unsafe delegate void FNglProgramUniform1uiv(uint program,int location,int count,uint* value);
        // public delegate void FNglProgramUniform2i(uint program,int location,int v0,int v1);
        // public unsafe delegate void FNglProgramUniform2iv(uint program,int location,int count,int* value);
        // public delegate void FNglProgramUniform2f(uint program,int location,float v0,float v1);
        // public unsafe delegate void FNglProgramUniform2fv(uint program,int location,int count,float* value);
        // public delegate void FNglProgramUniform2d(uint program,int location,double v0,double v1);
        // public unsafe delegate void FNglProgramUniform2dv(uint program,int location,int count,double* value);
        // public delegate void FNglProgramUniform2ui(uint program,int location,uint v0,uint v1);
        // public unsafe delegate void FNglProgramUniform2uiv(uint program,int location,int count,uint* value);
        // public delegate void FNglProgramUniform3i(uint program,int location,int v0,int v1,int v2);
        // public unsafe delegate void FNglProgramUniform3iv(uint program,int location,int count,int* value);
        // public delegate void FNglProgramUniform3f(uint program,int location,float v0,float v1,float v2);
        // public unsafe delegate void FNglProgramUniform3fv(uint program,int location,int count,float* value);
        // public delegate void FNglProgramUniform3d(uint program,int location,double v0,double v1,double v2);
        // public unsafe delegate void FNglProgramUniform3dv(uint program,int location,int count,double* value);
        // public delegate void FNglProgramUniform3ui(uint program,int location,uint v0,uint v1,uint v2);
        // public unsafe delegate void FNglProgramUniform3uiv(uint program,int location,int count,uint* value);
        // public delegate void FNglProgramUniform4i(uint program,int location,int v0,int v1,int v2,int v3);
        // public unsafe delegate void FNglProgramUniform4iv(uint program,int location,int count,int* value);
        // public delegate void FNglProgramUniform4f(uint program,int location,float v0,float v1,float v2,float v3);
        // public unsafe delegate void FNglProgramUniform4fv(uint program,int location,int count,float* value);
        // public delegate void FNglProgramUniform4d(uint program,int location,double v0,double v1,double v2,double v3);
        // public unsafe delegate void FNglProgramUniform4dv(uint program,int location,int count,double* value);
        // public delegate void FNglProgramUniform4ui(uint program,int location,uint v0,uint v1,uint v2,uint v3);
        // public unsafe delegate void FNglProgramUniform4uiv(uint program,int location,int count,uint* value);
        // public unsafe delegate void FNglProgramUniformMatrix2fv(uint program,int location,int count,bool transpose,float* value);
        // public unsafe delegate void FNglProgramUniformMatrix3fv(uint program,int location,int count,bool transpose,float* value);
        // public unsafe delegate void FNglProgramUniformMatrix4fv(uint program,int location,int count,bool transpose,float* value);
        // public unsafe delegate void FNglProgramUniformMatrix2dv(uint program,int location,int count,bool transpose,double* value);
        // public unsafe delegate void FNglProgramUniformMatrix3dv(uint program,int location,int count,bool transpose,double* value);
        // public unsafe delegate void FNglProgramUniformMatrix4dv(uint program,int location,int count,bool transpose,double* value);
        // public unsafe delegate void FNglProgramUniformMatrix2x3fv(uint program,int location,int count,bool transpose,float* value);
        // public unsafe delegate void FNglProgramUniformMatrix3x2fv(uint program,int location,int count,bool transpose,float* value);
        // public unsafe delegate void FNglProgramUniformMatrix2x4fv(uint program,int location,int count,bool transpose,float* value);
        // public unsafe delegate void FNglProgramUniformMatrix4x2fv(uint program,int location,int count,bool transpose,float* value);
        // public unsafe delegate void FNglProgramUniformMatrix3x4fv(uint program,int location,int count,bool transpose,float* value);
        // public unsafe delegate void FNglProgramUniformMatrix4x3fv(uint program,int location,int count,bool transpose,float* value);
        // public unsafe delegate void FNglProgramUniformMatrix2x3dv(uint program,int location,int count,bool transpose,double* value);
        // public unsafe delegate void FNglProgramUniformMatrix3x2dv(uint program,int location,int count,bool transpose,double* value);
        // public unsafe delegate void FNglProgramUniformMatrix2x4dv(uint program,int location,int count,bool transpose,double* value);
        // public unsafe delegate void FNglProgramUniformMatrix4x2dv(uint program,int location,int count,bool transpose,double* value);
        // public unsafe delegate void FNglProgramUniformMatrix3x4dv(uint program,int location,int count,bool transpose,double* value);
        // public unsafe delegate void FNglProgramUniformMatrix4x3dv(uint program,int location,int count,bool transpose,double* value);
        // public delegate void FNglValidateProgramPipeline(uint pipeline);
        // public unsafe delegate void FNglGetProgramPipelineInfoLog(uint pipeline,int bufSize,int* length,byte* infoLog);

        #endregion GL_ARB_separate_shader_objects

        #region GL_ARB_shader_atomic_counters

        // public unsafe delegate void FNglGetActiveAtomicCounterBufferiv(uint program,uint bufferIndex,uint pname,int* ps);

        #endregion GL_ARB_shader_atomic_counters

        #region GL_ARB_shader_image_load_store

        // public delegate void FNglBindImageTexture(uint unit,uint texture,int level,bool layered,int layer,uint access,uint format);
        // public delegate void FNglMemoryBarrier(uint barriers);

        #endregion GL_ARB_shader_image_load_store

        #region GL_ARB_shader_objects

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDeleteObjectARB(uint obj);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglGetHandleARB(uint pname);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDetachObjectARB(uint containerObj, uint attachedObj);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglCreateShaderObjectARB(uint shaderType);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglShaderSourceARB(uint shaderObj, int count, uint** str, int* length);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCompileShaderARB(uint shaderObj);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglCreateProgramObjectARB();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglAttachObjectARB(uint containerObj, uint obj);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLinkProgramARB(uint programObj);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUseProgramObjectARB(uint programObj);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglValidateProgramARB(uint programObj);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform1fARB(int location, float v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform2fARB(int location, float v0, float v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform3fARB(int location, float v0, float v1, float v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform4fARB(int location, float v0, float v1, float v2, float v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform1iARB(int location, int v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform2iARB(int location, int v0, int v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform3iARB(int location, int v0, int v1, int v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform4iARB(int location, int v0, int v1, int v2, int v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform1fvARB(int location, int count, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform2fvARB(int location, int count, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform3fvARB(int location, int count, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform4fvARB(int location, int count, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform1ivARB(int location, int count, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform2ivARB(int location, int count, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform3ivARB(int location, int count, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform4ivARB(int location, int count, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix2fvARB(int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix3fvARB(int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformMatrix4fvARB(int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetObjectParameterfvARB(uint obj, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetObjectParameterivARB(uint obj, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetInfoLogARB(uint obj, int maxLength, int* length, uint* infoLog);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetAttachedObjectsARB(uint containerObj, int maxCount, int* count, uint* obj);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int FNglGetUniformLocationARB(uint programObj, uint* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetActiveUniformARB(uint programObj, uint index, int maxLength, int* length, int* size, uint* type, uint* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetUniformfvARB(uint programObj, int location, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetUniformivARB(uint programObj, int location, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetShaderSourceARB(uint obj, int maxLength, int* length, uint* source);

        #endregion GL_ARB_shader_objects

        #region GL_ARB_shader_storage_buffer_object

        // public delegate void FNglShaderStorageBlockBinding(uint program,uint storageBlockIndex,uint storageBlockBinding);

        #endregion GL_ARB_shader_storage_buffer_object

        #region GL_ARB_shader_subroutine

        // public unsafe delegate int FNglGetSubroutineUniformLocation(uint program,uint shadertype,byte* name);
        // public unsafe delegate uint FNglGetSubroutineIndex(uint program,uint shadertype,byte* name);
        // public unsafe delegate void FNglGetActiveSubroutineUniformiv(uint program,uint shadertype,uint index,uint pname,int* values);
        // public unsafe delegate void FNglGetActiveSubroutineUniformName(uint program,uint shadertype,uint index,int bufSize,int* length,byte* name);
        // public unsafe delegate void FNglGetActiveSubroutineName(uint program,uint shadertype,uint index,int bufSize,int* length,byte* name);
        // public unsafe delegate void FNglUniformSubroutinesuiv(uint shadertype,int count,uint* indices);
        // public unsafe delegate void FNglGetUniformSubroutineuiv(uint shadertype,int location,uint* values);
        // public unsafe delegate void FNglGetProgramStageiv(uint program,uint shadertype,uint pname,int* values);

        #endregion GL_ARB_shader_subroutine

        #region GL_ARB_shading_language_include

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNamedStringARB(uint type, int namelen, byte* name, int stringlen, byte* str);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteNamedStringARB(int namelen, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCompileShaderIncludeARB(uint shader, int count, byte** path, int* length);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate bool FNglIsNamedStringARB(int namelen, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetNamedStringARB(int namelen, byte* name, int bufSize, int* stringlen, byte* str);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetNamedStringivARB(int namelen, byte* name, uint pname, int* ps);

        #endregion GL_ARB_shading_language_include

        #region GL_ARB_sparse_buffer

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBufferPageCommitmentARB(uint target, IntPtr offset, IntPtr size, bool commit);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNamedBufferPageCommitmentEXT(uint buffer, IntPtr offset, IntPtr size, bool commit);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNamedBufferPageCommitmentARB(uint buffer, IntPtr offset, IntPtr size, bool commit);

        #endregion GL_ARB_sparse_buffer

        #region GL_ARB_sparse_texture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexPageCommitmentARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit);

        #endregion GL_ARB_sparse_texture

        #region GL_ARB_sync

        // public delegate IntPtr FNglFenceSync(uint condition,uint flags);
        // public delegate bool FNglIsSync(IntPtr sync);
        // public delegate void FNglDeleteSync(IntPtr sync);
        // public delegate uint FNglClientWaitSync(IntPtr sync,uint flags,UInt64 timeout);
        // public delegate void FNglWaitSync(IntPtr sync,uint flags,UInt64 timeout);
        // public unsafe delegate void FNglGetInteger64v(uint pname,UInt64* data);
        // public unsafe delegate void FNglGetSynciv(IntPtr sync,uint pname,int bufSize,int* length,int* values);

        #endregion GL_ARB_sync

        #region GL_ARB_tessellation_shader

        // public delegate void FNglPatchParameteri(uint pname,int value);
        // public unsafe delegate void FNglPatchParameterfv(uint pname,float* values);

        #endregion GL_ARB_tessellation_shader

        #region GL_ARB_texture_barrier

        // public delegate void FNglTextureBarrier();

        #endregion GL_ARB_texture_barrier

        #region GL_ARB_texture_buffer_object

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexBufferARB(uint target, uint publicformat, uint buffer);

        #endregion GL_ARB_texture_buffer_object

        #region GL_ARB_texture_buffer_range

        // public delegate void FNglTexBufferRange(uint target,uint publicformat,uint buffer,IntPtr offset,IntPtr size);

        #endregion GL_ARB_texture_buffer_range

        #region GL_ARB_texture_compression

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCompressedTexImage3DARB(uint target, int level, uint publicformat, int width, int height, int depth, int border, int imageSize, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCompressedTexImage2DARB(uint target, int level, uint publicformat, int width, int height, int border, int imageSize, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCompressedTexImage1DARB(uint target, int level, uint publicformat, int width, int border, int imageSize, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetCompressedTexImageARB(uint target, int level, void* img);

        #endregion GL_ARB_texture_compression

        #region GL_ARB_texture_multisample

        // public delegate void FNglTexImage2DMultisample(uint target,int samples,uint publicformat,int width,int height,bool fixedsamplelocations);
        // public delegate void FNglTexImage3DMultisample(uint target,int samples,uint publicformat,int width,int height,int depth,bool fixedsamplelocations);
        // public unsafe delegate void FNglGetMultisamplefv(uint pname,uint index,float* val);
        // public delegate void FNglSampleMaski(uint maskNumber,uint mask);

        #endregion GL_ARB_texture_multisample

        #region GL_ARB_texture_storage

        // public delegate void FNglTexStorage1D(uint target,int levels,uint publicformat,int width);
        // public delegate void FNglTexStorage2D(uint target,int levels,uint publicformat,int width,int height);
        // public delegate void FNglTexStorage3D(uint target,int levels,uint publicformat,int width,int height,int depth);

        #endregion GL_ARB_texture_storage

        #region GL_ARB_texture_storage_multisample

        // public delegate void FNglTexStorage2DMultisample(uint target,int samples,uint publicformat,int width,int height,bool fixedsamplelocations);
        // public delegate void FNglTexStorage3DMultisample(uint target,int samples,uint publicformat,int width,int height,int depth,bool fixedsamplelocations);

        #endregion GL_ARB_texture_storage_multisample

        #region GL_ARB_texture_view

        // public delegate void FNglTextureView(uint texture,uint target,uint origtexture,uint publicformat,uint minlevel,uint numlevels,uint minlayer,uint numlayers);

        #endregion GL_ARB_texture_view

        #region GL_ARB_timer_query

        // public delegate void FNglQueryCounter(uint id,uint target);
        // public unsafe delegate void FNglGetQueryObjecti64v(uint id,uint pname,UInt64* ps);
        // public unsafe delegate void FNglGetQueryObjectui64v(uint id,uint pname,UInt64* ps);

        #endregion GL_ARB_timer_query

        #region GL_ARB_transform_feedback2

        // public delegate void FNglBindTransformFeedback(uint target,uint id);
        // public unsafe delegate void FNglDeleteTransformFeedbacks(int n,uint* ids);
        // public unsafe delegate void FNglGenTransformFeedbacks(int n,uint* ids);
        // public delegate bool FNglIsTransformFeedback(uint id);
        // public delegate void FNglPauseTransformFeedback();
        // public delegate void FNglResumeTransformFeedback();
        // public delegate void FNglDrawTransformFeedback(uint mode,uint id);

        #endregion GL_ARB_transform_feedback2

        #region GL_ARB_transform_feedback3

        // public delegate void FNglDrawTransformFeedbackStream(uint mode,uint id,uint stream);
        // public delegate void FNglBeginQueryIndexed(uint target,uint index,uint id);
        // public delegate void FNglEndQueryIndexed(uint target,uint index);
        // public unsafe delegate void FNglGetQueryIndexediv(uint target,uint index,uint pname,int* ps);

        #endregion GL_ARB_transform_feedback3

        #region GL_ARB_transform_feedback_instanced

        // public delegate void FNglDrawTransformFeedbackInstanced(uint mode,uint id,int instancecount);
        // public delegate void FNglDrawTransformFeedbackStreamInstanced(uint mode,uint id,uint stream,int instancecount);

        #endregion GL_ARB_transform_feedback_instanced

        #region GL_ARB_transpose_matrix

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglLoadTransposeMatrixfARB(float* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglLoadTransposeMatrixdARB(double* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultTransposeMatrixfARB(float* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultTransposeMatrixdARB(double* m);

        #endregion GL_ARB_transpose_matrix

        #region GL_ARB_uniform_buffer_object

        // public unsafe delegate void FNglGetUniformIndices(uint program,int uniformCount,byte** uniformNames,uint* uniformIndices);
        // public unsafe delegate void FNglGetActiveUniformsiv(uint program,int uniformCount,uint* uniformIndices,uint pname,int* ps);
        // public unsafe delegate void FNglGetActiveUniformName(uint program,uint uniformIndex,int bufSize,int* length,byte* uniformName);
        // public unsafe delegate uint FNglGetUniformBlockIndex(uint program,byte* uniformBlockName);
        // public unsafe delegate void FNglGetActiveUniformBlockiv(uint program,uint uniformBlockIndex,uint pname,int* ps);
        // public unsafe delegate void FNglGetActiveUniformBlockName(uint program,uint uniformBlockIndex,int bufSize,int* length,byte* uniformBlockName);
        // public delegate void FNglUniformBlockBinding(uint program,uint uniformBlockIndex,uint uniformBlockBinding);
        // public delegate void FNglBindBufferRange(uint target,uint index,uint buffer,IntPtr offset,IntPtr size);
        // public delegate void FNglBindBufferBase(uint target,uint index,uint buffer);
        // public unsafe delegate void FNglGetIntegeri_v(uint target,uint index,int* data);

        #endregion GL_ARB_uniform_buffer_object

        #region GL_ARB_vertex_array_object

        // public delegate void FNglBindVertexArray(uint array);
        // public unsafe delegate void FNglDeleteVertexArrays(int n,uint* arrays);
        // public unsafe delegate void FNglGenVertexArrays(int n,uint* arrays);
        // public delegate bool FNglIsVertexArray(uint array);

        #endregion GL_ARB_vertex_array_object

        #region GL_ARB_vertex_attrib_64bit

        // public delegate void FNglVertexAttribL1d(uint index,double v0);
        // public delegate void FNglVertexAttribL2d(uint index,double v0,double v1);
        // public delegate void FNglVertexAttribL3d(uint index,double v0,double v1,double v2);
        // public delegate void FNglVertexAttribL4d(uint index,double v0,double v1,double v2,double v3);
        // public unsafe delegate void FNglVertexAttribL1dv(uint index,double* v);
        // public unsafe delegate void FNglVertexAttribL2dv(uint index,double* v);
        // public unsafe delegate void FNglVertexAttribL3dv(uint index,double* v);
        // public unsafe delegate void FNglVertexAttribL4dv(uint index,double* v);
        // public unsafe delegate void FNglVertexAttribLPointer(uint index,int size,uint type,int stride,void* pointer);
        // public unsafe delegate void FNglGetVertexAttribLdv(uint index,uint pname,double* ps);

        #endregion GL_ARB_vertex_attrib_64bit

        #region GL_ARB_vertex_attrib_binding

        // public delegate void FNglBindVertexBuffer(uint bindingindex,uint buffer,IntPtr offset,int stride);
        // public delegate void FNglVertexAttribFormat(uint attribindex,int size,uint type,bool normalized,uint relativeoffset);
        // public delegate void FNglVertexAttribIFormat(uint attribindex,int size,uint type,uint relativeoffset);
        // public delegate void FNglVertexAttribLFormat(uint attribindex,int size,uint type,uint relativeoffset);
        // public delegate void FNglVertexAttribBinding(uint attribindex,uint bindingindex);
        // public delegate void FNglVertexBindingDivisor(uint bindingindex,uint divisor);

        #endregion GL_ARB_vertex_attrib_binding

        #region GL_ARB_vertex_blend

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWeightbvARB(int size, byte* weights);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWeightsvARB(int size, short* weights);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWeightivARB(int size, int* weights);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWeightfvARB(int size, float* weights);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWeightdvARB(int size, double* weights);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWeightubvARB(int size, byte* weights);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWeightusvARB(int size, ushort* weights);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWeightuivARB(int size, uint* weights);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWeightPointerARB(int size, uint type, int stride, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexBlendARB(int count);

        #endregion GL_ARB_vertex_blend

        #region GL_ARB_vertex_buffer_object

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindBufferARB(uint target, uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteBuffersARB(int n, uint* buffers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenBuffersARB(int n, uint* buffers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsBufferARB(uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBufferDataARB(uint target, IntPtr size, void* data, uint usage);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBufferSubDataARB(uint target, IntPtr offset, IntPtr size, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetBufferSubDataARB(uint target, IntPtr offset, IntPtr size, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void* FNglMapBufferARB(uint target, uint access);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglUnmapBufferARB(uint target);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetBufferParameterivARB(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetBufferPointervARB(uint target, uint pname, void** ps);

        #endregion GL_ARB_vertex_buffer_object

        #region GL_ARB_vertex_program

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib1dARB(uint index, double x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib1dvARB(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib1fARB(uint index, float x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib1fvARB(uint index, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib1sARB(uint index, short x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib1svARB(uint index, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib2dARB(uint index, double x, double y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib2dvARB(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib2fARB(uint index, float x, float y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib2fvARB(uint index, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib2sARB(uint index, short x, short y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib2svARB(uint index, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib3dARB(uint index, double x, double y, double z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib3dvARB(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib3fARB(uint index, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib3fvARB(uint index, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib3sARB(uint index, short x, short y, short z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib3svARB(uint index, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4NbvARB(uint index, byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4NivARB(uint index, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4NsvARB(uint index, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib4NubARB(uint index, byte x, byte y, byte z, byte w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4NubvARB(uint index, byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4NuivARB(uint index, uint* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4NusvARB(uint index, ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4bvARB(uint index, byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib4dARB(uint index, double x, double y, double z, double w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4dvARB(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib4fARB(uint index, float x, float y, float z, float w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4fvARB(uint index, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4ivARB(uint index, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib4sARB(uint index, short x, short y, short z, short w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4svARB(uint index, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4ubvARB(uint index, byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4uivARB(uint index, uint* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4usvARB(uint index, ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribPointerARB(uint index, int size, uint type, bool normalized, int stride, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEnableVertexAttribArrayARB(uint index);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDisableVertexAttribArrayARB(uint index);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramStringARB(uint target, uint format, int len, void* str);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindProgramARB(uint target, uint program);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteProgramsARB(int n, uint* programs);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenProgramsARB(int n, uint* programs);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramEnvParameter4dARB(uint target, uint index, double x, double y, double z, double w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramEnvParameter4dvARB(uint target, uint index, double* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramEnvParameter4fARB(uint target, uint index, float x, float y, float z, float w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramEnvParameter4fvARB(uint target, uint index, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramLocalParameter4dARB(uint target, uint index, double x, double y, double z, double w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramLocalParameter4dvARB(uint target, uint index, double* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramLocalParameter4fARB(uint target, uint index, float x, float y, float z, float w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramLocalParameter4fvARB(uint target, uint index, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramEnvParameterdvARB(uint target, uint index, double* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramEnvParameterfvARB(uint target, uint index, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramLocalParameterdvARB(uint target, uint index, double* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramLocalParameterfvARB(uint target, uint index, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramivARB(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramStringARB(uint target, uint pname, void* str);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribdvARB(uint index, uint pname, double* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribfvARB(uint index, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribivARB(uint index, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribPointervARB(uint index, uint pname, void** pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsProgramARB(uint program);

        #endregion GL_ARB_vertex_program

        #region GL_ARB_vertex_shader

        // public delegate void FNglVertexAttrib1fARB(uint index,float x);
        // public delegate void FNglVertexAttrib1sARB(uint index,short x);
        // public delegate void FNglVertexAttrib1dARB(uint index,double x);
        // public delegate void FNglVertexAttrib2fARB(uint index,float x,float y);
        // public delegate void FNglVertexAttrib2sARB(uint index,short x,short y);
        // public delegate void FNglVertexAttrib2dARB(uint index,double x,double y);
        // public delegate void FNglVertexAttrib3fARB(uint index,float x,float y,float z);
        // public delegate void FNglVertexAttrib3sARB(uint index,short x,short y,short z);
        // public delegate void FNglVertexAttrib3dARB(uint index,double x,double y,double z);
        // public delegate void FNglVertexAttrib4fARB(uint index,float x,float y,float z,float w);
        // public delegate void FNglVertexAttrib4sARB(uint index,short x,short y,short z,short w);
        // public delegate void FNglVertexAttrib4dARB(uint index,double x,double y,double z,double w);
        // public delegate void FNglVertexAttrib4NubARB(uint index,byte x,byte y,byte z,byte w);
        // public unsafe delegate void FNglVertexAttrib1fvARB(uint index,float* v);
        // public unsafe delegate void FNglVertexAttrib1svARB(uint index,short* v);
        // public unsafe delegate void FNglVertexAttrib1dvARB(uint index,double* v);
        // public unsafe delegate void FNglVertexAttrib2fvARB(uint index,float* v);
        // public unsafe delegate void FNglVertexAttrib2svARB(uint index,short* v);
        // public unsafe delegate void FNglVertexAttrib2dvARB(uint index,double* v);
        // public unsafe delegate void FNglVertexAttrib3fvARB(uint index,float* v);
        // public unsafe delegate void FNglVertexAttrib3svARB(uint index,short* v);
        // public unsafe delegate void FNglVertexAttrib3dvARB(uint index,double* v);
        // public unsafe delegate void FNglVertexAttrib4fvARB(uint index,float* v);
        // public unsafe delegate void FNglVertexAttrib4svARB(uint index,short* v);
        // public unsafe delegate void FNglVertexAttrib4dvARB(uint index,double* v);
        // public unsafe delegate void FNglVertexAttrib4ivARB(uint index,int* v);
        // public unsafe delegate void FNglVertexAttrib4bvARB(uint index,byte* v);
        // public unsafe delegate void FNglVertexAttrib4ubvARB(uint index,byte* v);
        // public unsafe delegate void FNglVertexAttrib4usvARB(uint index,ushort* v);
        // public unsafe delegate void FNglVertexAttrib4uivARB(uint index,uint* v);
        // public unsafe delegate void FNglVertexAttrib4NbvARB(uint index,byte* v);
        // public unsafe delegate void FNglVertexAttrib4NsvARB(uint index,short* v);
        // public unsafe delegate void FNglVertexAttrib4NivARB(uint index,int* v);
        // public unsafe delegate void FNglVertexAttrib4NubvARB(uint index,byte* v);
        // public unsafe delegate void FNglVertexAttrib4NusvARB(uint index,ushort* v);
        // public unsafe delegate void FNglVertexAttrib4NuivARB(uint index,uint* v);
        // public unsafe delegate void FNglVertexAttribPointerARB(uint index,int size,uint type,bool normalized,int stride,void* pointer);
        // public delegate void FNglEnableVertexAttribArrayARB(uint index);
        // public delegate void FNglDisableVertexAttribArrayARB(uint index);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBindAttribLocationARB(uint programObj, uint index, uint* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetActiveAttribARB(uint programObj, uint index, int maxLength, int* length, int* size, uint* type, uint* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int FNglGetAttribLocationARB(uint programObj, uint* name);
        // public unsafe delegate void FNglGetVertexAttribdvARB(uint index,uint pname,double* ps);
        // public unsafe delegate void FNglGetVertexAttribfvARB(uint index,uint pname,float* ps);
        // public unsafe delegate void FNglGetVertexAttribivARB(uint index,uint pname,int* ps);
        // public unsafe delegate void FNglGetVertexAttribPointervARB(uint index,uint pname,void** pointer);

        #endregion GL_ARB_vertex_shader

        #region GL_ARB_vertex_type_2_10_10_10_rev

        // public delegate void FNglVertexAttribP1ui(uint index,uint type,bool normalized,uint value);
        // public unsafe delegate void FNglVertexAttribP1uiv(uint index,uint type,bool normalized,uint* value);
        // public delegate void FNglVertexAttribP2ui(uint index,uint type,bool normalized,uint value);
        // public unsafe delegate void FNglVertexAttribP2uiv(uint index,uint type,bool normalized,uint* value);
        // public delegate void FNglVertexAttribP3ui(uint index,uint type,bool normalized,uint value);
        // public unsafe delegate void FNglVertexAttribP3uiv(uint index,uint type,bool normalized,uint* value);
        // public delegate void FNglVertexAttribP4ui(uint index,uint type,bool normalized,uint value);
        // public unsafe delegate void FNglVertexAttribP4uiv(uint index,uint type,bool normalized,uint* value);
        // public delegate void FNglVertexP2ui(uint type,uint value);
        // public unsafe delegate void FNglVertexP2uiv(uint type,uint* value);
        // public delegate void FNglVertexP3ui(uint type,uint value);
        // public unsafe delegate void FNglVertexP3uiv(uint type,uint* value);
        // public delegate void FNglVertexP4ui(uint type,uint value);
        // public unsafe delegate void FNglVertexP4uiv(uint type,uint* value);
        // public delegate void FNglTexCoordP1ui(uint type,uint coords);
        // public unsafe delegate void FNglTexCoordP1uiv(uint type,uint* coords);
        // public delegate void FNglTexCoordP2ui(uint type,uint coords);
        // public unsafe delegate void FNglTexCoordP2uiv(uint type,uint* coords);
        // public delegate void FNglTexCoordP3ui(uint type,uint coords);
        // public unsafe delegate void FNglTexCoordP3uiv(uint type,uint* coords);
        // public delegate void FNglTexCoordP4ui(uint type,uint coords);
        // public unsafe delegate void FNglTexCoordP4uiv(uint type,uint* coords);
        // public delegate void FNglMultiTexCoordP1ui(uint texture,uint type,uint coords);
        // public unsafe delegate void FNglMultiTexCoordP1uiv(uint texture,uint type,uint* coords);
        // public delegate void FNglMultiTexCoordP2ui(uint texture,uint type,uint coords);
        // public unsafe delegate void FNglMultiTexCoordP2uiv(uint texture,uint type,uint* coords);
        // public delegate void FNglMultiTexCoordP3ui(uint texture,uint type,uint coords);
        // public unsafe delegate void FNglMultiTexCoordP3uiv(uint texture,uint type,uint* coords);
        // public delegate void FNglMultiTexCoordP4ui(uint texture,uint type,uint coords);
        // public unsafe delegate void FNglMultiTexCoordP4uiv(uint texture,uint type,uint* coords);
        // public delegate void FNglNormalP3ui(uint type,uint coords);
        // public unsafe delegate void FNglNormalP3uiv(uint type,uint* coords);
        // public delegate void FNglColorP3ui(uint type,uint color);
        // public unsafe delegate void FNglColorP3uiv(uint type,uint* color);
        // public delegate void FNglColorP4ui(uint type,uint color);
        // public unsafe delegate void FNglColorP4uiv(uint type,uint* color);
        // public delegate void FNglSecondaryColorP3ui(uint type,uint color);
        // public unsafe delegate void FNglSecondaryColorP3uiv(uint type,uint* color);

        #endregion GL_ARB_vertex_type_2_10_10_10_rev

        #region GL_ARB_viewport_array

        // public unsafe delegate void FNglViewportArrayv(uint first,int count,float* v);
        // public delegate void FNglViewportIndexedf(uint index,float x,float y,float w,float h);
        // public unsafe delegate void FNglViewportIndexedfv(uint index,float* v);
        // public unsafe delegate void FNglScissorArrayv(uint first,int count,int* v);
        // public delegate void FNglScissorIndexed(uint index,int left,int bottom,int width,int height);
        // public unsafe delegate void FNglScissorIndexedv(uint index,int* v);
        // public unsafe delegate void FNglDepthRangeArrayv(uint first,int count,double* v);
        // public delegate void FNglDepthRangeIndexed(uint index,double nearVal,double farVal);
        // public unsafe delegate void FNglGetFloati_v(uint target,uint index,float* data);
        // public unsafe delegate void FNglGetDoublei_v(uint target,uint index,double* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDepthRangeArraydvNV(uint first, int count, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDepthRangeIndexeddNV(uint index, double n, double f);

        #endregion GL_ARB_viewport_array

        #region GL_ARB_window_pos

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos2dARB(double x, double y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos2dvARB(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos2fARB(float x, float y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos2fvARB(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos2iARB(int x, int y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos2ivARB(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos2sARB(short x, short y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos2svARB(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos3dARB(double x, double y, double z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos3dvARB(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos3fARB(float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos3fvARB(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos3iARB(int x, int y, int z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos3ivARB(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos3sARB(short x, short y, short z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos3svARB(short* v);

        #endregion GL_ARB_window_pos

        #region GL_ATI_draw_buffers

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawBuffersATI(int n, uint* bufs);

        #endregion GL_ATI_draw_buffers

        #region GL_ATI_element_array

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglElementPointerATI(uint type, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawElementArrayATI(uint mode, int count);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawRangeElementArrayATI(uint mode, uint start, uint end, int count);

        #endregion GL_ATI_element_array

        #region GL_ATI_envmap_bumpmap

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexBumpParameterivATI(uint pname, int* param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexBumpParameterfvATI(uint pname, float* param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexBumpParameterivATI(uint pname, int* param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexBumpParameterfvATI(uint pname, float* param);

        #endregion GL_ATI_envmap_bumpmap

        #region GL_ATI_fragment_shader

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglGenFragmentShadersATI(uint range);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindFragmentShaderATI(uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDeleteFragmentShaderATI(uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBeginFragmentShaderATI();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEndFragmentShaderATI();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPassTexCoordATI(uint dst, uint coord, uint swizzle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSampleMapATI(uint dst, uint interp, uint swizzle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColorFragmentOp1ATI(uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColorFragmentOp2ATI(uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColorFragmentOp3ATI(uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglAlphaFragmentOp1ATI(uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglAlphaFragmentOp2ATI(uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglAlphaFragmentOp3ATI(uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSetFragmentShaderConstantATI(uint dst, float* value);

        #endregion GL_ATI_fragment_shader

        #region GL_ATI_map_object_buffer

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void* FNglMapObjectBufferATI(uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUnmapObjectBufferATI(uint buffer);

        #endregion GL_ATI_map_object_buffer

        #region GL_ATI_pn_triangles

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPNTrianglesiATI(uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPNTrianglesfATI(uint pname, float param);

        #endregion GL_ATI_pn_triangles

        #region GL_ATI_separate_stencil

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglStencilOpSeparateATI(uint face, uint sfail, uint dpfail, uint dppass);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglStencilFuncSeparateATI(uint frontfunc, uint backfunc, int r, uint mask);

        #endregion GL_ATI_separate_stencil

        #region GL_ATI_vertex_array_object

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglNewObjectBufferATI(int size, void* pointer, uint usage);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsObjectBufferATI(uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUpdateObjectBufferATI(uint buffer, uint offset, int size, void* pointer, uint preserve);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetObjectBufferfvATI(uint buffer, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetObjectBufferivATI(uint buffer, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFreeObjectBufferATI(uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglArrayObjectATI(uint array, int size, uint type, int stride, uint buffer, uint offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetArrayObjectfvATI(uint array, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetArrayObjectivATI(uint array, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVariantArrayObjectATI(uint id, uint type, int stride, uint buffer, uint offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVariantArrayObjectfvATI(uint id, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVariantArrayObjectivATI(uint id, uint pname, int* ps);

        #endregion GL_ATI_vertex_array_object

        #region GL_ATI_vertex_attrib_array_object

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribArrayObjectATI(uint index, int size, uint type, bool normalized, int stride, uint buffer, uint offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribArrayObjectfvATI(uint index, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribArrayObjectivATI(uint index, uint pname, int* ps);

        #endregion GL_ATI_vertex_attrib_array_object

        #region GL_ATI_vertex_streams

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexStream1sATI(uint stream, short x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexStream1svATI(uint stream, short* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexStream1iATI(uint stream, int x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexStream1ivATI(uint stream, int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexStream1fATI(uint stream, float x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexStream1fvATI(uint stream, float* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexStream1dATI(uint stream, double x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexStream1dvATI(uint stream, double* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexStream2sATI(uint stream, short x, short y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexStream2svATI(uint stream, short* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexStream2iATI(uint stream, int x, int y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexStream2ivATI(uint stream, int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexStream2fATI(uint stream, float x, float y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexStream2fvATI(uint stream, float* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexStream2dATI(uint stream, double x, double y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexStream2dvATI(uint stream, double* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexStream3sATI(uint stream, short x, short y, short z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexStream3svATI(uint stream, short* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexStream3iATI(uint stream, int x, int y, int z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexStream3ivATI(uint stream, int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexStream3fATI(uint stream, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexStream3fvATI(uint stream, float* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexStream3dATI(uint stream, double x, double y, double z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexStream3dvATI(uint stream, double* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexStream4sATI(uint stream, short x, short y, short z, short w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexStream4svATI(uint stream, short* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexStream4iATI(uint stream, int x, int y, int z, int w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexStream4ivATI(uint stream, int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexStream4fATI(uint stream, float x, float y, float z, float w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexStream4fvATI(uint stream, float* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexStream4dATI(uint stream, double x, double y, double z, double w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexStream4dvATI(uint stream, double* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNormalStream3bATI(uint stream, byte nx, byte ny, byte nz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormalStream3bvATI(uint stream, byte* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNormalStream3sATI(uint stream, short nx, short ny, short nz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormalStream3svATI(uint stream, short* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNormalStream3iATI(uint stream, int nx, int ny, int nz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormalStream3ivATI(uint stream, int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNormalStream3fATI(uint stream, float nx, float ny, float nz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormalStream3fvATI(uint stream, float* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNormalStream3dATI(uint stream, double nx, double ny, double nz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormalStream3dvATI(uint stream, double* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClientActiveVertexStreamATI(uint stream);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexBlendEnviATI(uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexBlendEnvfATI(uint pname, float param);

        #endregion GL_ATI_vertex_streams

        #region GL_EXT_EGL_image_storage

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglEGLImageTargetTexStorageEXT(uint target, IntPtr image, int* attrib_list);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglEGLImageTargetTextureStorageEXT(uint texture, IntPtr image, int* attrib_list);

        #endregion GL_EXT_EGL_image_storage

        #region GL_EXT_bindable_uniform

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniformBufferEXT(uint program, int location, uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int FNglGetUniformBufferSizeEXT(uint program, int location);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr FNglGetUniformOffsetEXT(uint program, int location);

        #endregion GL_EXT_bindable_uniform

        #region GL_EXT_blend_color

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendColorEXT(float red, float green, float blue, float alpha);

        #endregion GL_EXT_blend_color

        #region GL_EXT_blend_equation_separate

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendEquationSeparateEXT(uint modeRGB, uint modeAlpha);

        #endregion GL_EXT_blend_equation_separate

        #region GL_EXT_blend_func_separate

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendFuncSeparateEXT(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);

        #endregion GL_EXT_blend_func_separate

        #region GL_EXT_color_subtable

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColorSubTableEXT(uint target, int start, int count, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyColorSubTableEXT(uint target, int start, int x, int y, int width);

        #endregion GL_EXT_color_subtable

        #region GL_EXT_compiled_vertex_array

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLockArraysEXT(int first, int count);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUnlockArraysEXT();

        #endregion GL_EXT_compiled_vertex_array

        #region GL_EXT_convolution

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglConvolutionFilter1DEXT(uint target, uint publicformat, int width, uint format, uint type, void* image);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglConvolutionFilter2DEXT(uint target, uint publicformat, int width, int height, uint format, uint type, void* image);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglConvolutionParameterfEXT(uint target, uint pname, float ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglConvolutionParameterfvEXT(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglConvolutionParameteriEXT(uint target, uint pname, int ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglConvolutionParameterivEXT(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyConvolutionFilter1DEXT(uint target, uint publicformat, int x, int y, int width);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyConvolutionFilter2DEXT(uint target, uint publicformat, int x, int y, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetConvolutionFilterEXT(uint target, uint format, uint type, void* image);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetConvolutionParameterfvEXT(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetConvolutionParameterivEXT(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetSeparableFilterEXT(uint target, uint format, uint type, void* row, void* column, void* span);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSeparableFilter2DEXT(uint target, uint publicformat, int width, int height, uint format, uint type, void* row, void* column);

        #endregion GL_EXT_convolution

        #region GL_EXT_coordinate_frame

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTangent3bEXT(byte tx, byte ty, byte tz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTangent3bvEXT(byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTangent3dEXT(double tx, double ty, double tz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTangent3dvEXT(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTangent3fEXT(float tx, float ty, float tz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTangent3fvEXT(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTangent3iEXT(int tx, int ty, int tz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTangent3ivEXT(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTangent3sEXT(short tx, short ty, short tz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTangent3svEXT(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBinormal3bEXT(byte bx, byte by, byte bz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBinormal3bvEXT(byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBinormal3dEXT(double bx, double by, double bz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBinormal3dvEXT(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBinormal3fEXT(float bx, float by, float bz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBinormal3fvEXT(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBinormal3iEXT(int bx, int by, int bz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBinormal3ivEXT(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBinormal3sEXT(short bx, short by, short bz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBinormal3svEXT(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTangentPointerEXT(uint type, int stride, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBinormalPointerEXT(uint type, int stride, void* pointer);

        #endregion GL_EXT_coordinate_frame

        #region GL_EXT_copy_texture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyTexImage1DEXT(uint target, int level, uint publicformat, int x, int y, int width, int border);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyTexImage2DEXT(uint target, int level, uint publicformat, int x, int y, int width, int height, int border);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyTexSubImage1DEXT(uint target, int level, int xoffset, int x, int y, int width);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyTexSubImage2DEXT(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyTexSubImage3DEXT(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

        #endregion GL_EXT_copy_texture

        #region GL_EXT_cull_vertex

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCullParameterdvEXT(uint pname, double* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCullParameterfvEXT(uint pname, float* ps);

        #endregion GL_EXT_cull_vertex

        #region GL_EXT_debug_label

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglLabelObjectEXT(uint type, uint obj, int length, byte* label);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetObjectLabelEXT(uint type, uint obj, int bufSize, int* length, byte* label);

        #endregion GL_EXT_debug_label

        #region GL_EXT_debug_marker

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglInsertEventMarkerEXT(int length, byte* marker);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPushGroupMarkerEXT(int length, byte* marker);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPopGroupMarkerEXT();

        #endregion GL_EXT_debug_marker

        #region GL_EXT_depth_bounds_test

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDepthBoundsEXT(double zmin, double zmax);

        #endregion GL_EXT_depth_bounds_test

        #region GL_EXT_draw_buffers2

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColorMaskIndexedEXT(uint index, bool r, bool g, bool b, bool a);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetBooleanIndexedvEXT(uint target, uint index, bool* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetIntegerIndexedvEXT(uint target, uint index, int* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEnableIndexedEXT(uint target, uint index);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDisableIndexedEXT(uint target, uint index);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsEnabledIndexedEXT(uint target, uint index);

        #endregion GL_EXT_draw_buffers2

        #region GL_EXT_draw_instanced

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawArraysInstancedEXT(uint mode, int start, int count, int primcount);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawElementsInstancedEXT(uint mode, int count, uint type, void* indices, int primcount);

        #endregion GL_EXT_draw_instanced

        #region GL_EXT_draw_range_elements

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawRangeElementsEXT(uint mode, uint start, uint end, int count, uint type, void* indices);

        #endregion GL_EXT_draw_range_elements

        #region GL_EXT_external_buffer

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBufferStorageExternalEXT(uint target, IntPtr offset, IntPtr size, IntPtr clientBuffer, uint flags);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNamedBufferStorageExternalEXT(uint buffer, IntPtr offset, IntPtr size, IntPtr clientBuffer, uint flags);

        #endregion GL_EXT_external_buffer

        #region GL_EXT_fog_coord

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFogCoordfEXT(float coord);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFogCoordfvEXT(float* coord);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFogCoorddEXT(double coord);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFogCoorddvEXT(double* coord);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFogCoordPointerEXT(uint type, int stride, void* pointer);

        #endregion GL_EXT_fog_coord

        #region GL_EXT_framebuffer_blit

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlitFramebufferEXT(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

        #endregion GL_EXT_framebuffer_blit

        #region GL_EXT_framebuffer_multisample

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRenderbufferStorageMultisampleEXT(uint target, int samples, uint publicformat, int width, int height);

        #endregion GL_EXT_framebuffer_multisample

        #region GL_EXT_framebuffer_object

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsRenderbufferEXT(uint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindRenderbufferEXT(uint target, uint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteRenderbuffersEXT(int n, uint* renderbuffers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenRenderbuffersEXT(int n, uint* renderbuffers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRenderbufferStorageEXT(uint target, uint publicformat, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetRenderbufferParameterivEXT(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsFramebufferEXT(uint framebuffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindFramebufferEXT(uint target, uint framebuffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteFramebuffersEXT(int n, uint* framebuffers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenFramebuffersEXT(int n, uint* framebuffers);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglCheckFramebufferStatusEXT(uint target);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferTexture1DEXT(uint target, uint attachment, uint textarget, uint texture, int level);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferTexture2DEXT(uint target, uint attachment, uint textarget, uint texture, int level);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferTexture3DEXT(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferRenderbufferEXT(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetFramebufferAttachmentParameterivEXT(uint target, uint attachment, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglGenerateMipmapEXT(uint target);

        #endregion GL_EXT_framebuffer_object

        #region GL_EXT_geometry_shader4

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramParameteriEXT(uint program, uint pname, int value);

        #endregion GL_EXT_geometry_shader4

        #region GL_EXT_gpu_program_parameters

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramEnvParameters4fvEXT(uint target, uint index, int count, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramLocalParameters4fvEXT(uint target, uint index, int count, float* ps);

        #endregion GL_EXT_gpu_program_parameters

        #region GL_EXT_gpu_shader4

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetUniformuivEXT(uint program, int location, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBindFragDataLocationEXT(uint program, uint color, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int FNglGetFragDataLocationEXT(uint program, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform1uiEXT(int location, uint v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform2uiEXT(int location, uint v0, uint v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform3uiEXT(int location, uint v0, uint v1, uint v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniform4uiEXT(int location, uint v0, uint v1, uint v2, uint v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform1uivEXT(int location, int count, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform2uivEXT(int location, int count, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform3uivEXT(int location, int count, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniform4uivEXT(int location, int count, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribI1iEXT(uint index, int x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribI2iEXT(uint index, int x, int y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribI3iEXT(uint index, int x, int y, int z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribI4iEXT(uint index, int x, int y, int z, int w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribI1uiEXT(uint index, uint x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribI2uiEXT(uint index, uint x, uint y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribI3uiEXT(uint index, uint x, uint y, uint z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribI4uiEXT(uint index, uint x, uint y, uint z, uint w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI1ivEXT(uint index, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI2ivEXT(uint index, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI3ivEXT(uint index, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI4ivEXT(uint index, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI1uivEXT(uint index, uint* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI2uivEXT(uint index, uint* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI3uivEXT(uint index, uint* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI4uivEXT(uint index, uint* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI4bvEXT(uint index, byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI4svEXT(uint index, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI4ubvEXT(uint index, byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribI4usvEXT(uint index, ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribIPointerEXT(uint index, int size, uint type, int stride, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribIivEXT(uint index, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribIuivEXT(uint index, uint pname, uint* ps);

        #endregion GL_EXT_gpu_shader4

        #region GL_EXT_histogram

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetHistogramEXT(uint target, bool reset, uint format, uint type, void* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetHistogramParameterfvEXT(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetHistogramParameterivEXT(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMinmaxEXT(uint target, bool reset, uint format, uint type, void* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMinmaxParameterfvEXT(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMinmaxParameterivEXT(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglHistogramEXT(uint target, int width, uint publicformat, bool sink);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMinmaxEXT(uint target, uint publicformat, bool sink);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglResetHistogramEXT(uint target);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglResetMinmaxEXT(uint target);

        #endregion GL_EXT_histogram

        #region GL_EXT_index_func

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglIndexFuncEXT(uint func, float r);

        #endregion GL_EXT_index_func

        #region GL_EXT_index_material

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglIndexMaterialEXT(uint face, uint mode);

        #endregion GL_EXT_index_material

        #region GL_EXT_light_texture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglApplyTextureEXT(uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureLightEXT(uint pname);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureMaterialEXT(uint face, uint mode);

        #endregion GL_EXT_light_texture

        #region GL_EXT_memory_object

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetUnsignedBytevEXT(uint pname, byte* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetUnsignedBytei_vEXT(uint target, uint index, byte* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteMemoryObjectsEXT(int n, uint* memoryObjects);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsMemoryObjectEXT(uint memoryObject);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCreateMemoryObjectsEXT(int n, uint* memoryObjects);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMemoryObjectParameterivEXT(uint memoryObject, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMemoryObjectParameterivEXT(uint memoryObject, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexStorageMem2DEXT(uint target, int levels, uint publicFormat, int width, int height, uint memory, UInt64 offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexStorageMem2DMultisampleEXT(uint target, int samples, uint publicFormat, int width, int height, bool fixedSampleLocations, uint memory, UInt64 offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexStorageMem3DEXT(uint target, int levels, uint publicFormat, int width, int height, int depth, uint memory, UInt64 offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexStorageMem3DMultisampleEXT(uint target, int samples, uint publicFormat, int width, int height, int depth, bool fixedSampleLocations, uint memory, UInt64 offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBufferStorageMemEXT(uint target, IntPtr size, uint memory, UInt64 offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureStorageMem2DEXT(uint texture, int levels, uint publicFormat, int width, int height, uint memory, UInt64 offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureStorageMem2DMultisampleEXT(uint texture, int samples, uint publicFormat, int width, int height, bool fixedSampleLocations, uint memory, UInt64 offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureStorageMem3DEXT(uint texture, int levels, uint publicFormat, int width, int height, int depth, uint memory, UInt64 offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureStorageMem3DMultisampleEXT(uint texture, int samples, uint publicFormat, int width, int height, int depth, bool fixedSampleLocations, uint memory, UInt64 offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNamedBufferStorageMemEXT(uint buffer, IntPtr size, uint memory, UInt64 offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexStorageMem1DEXT(uint target, int levels, uint publicFormat, int width, uint memory, UInt64 offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureStorageMem1DEXT(uint texture, int levels, uint publicFormat, int width, uint memory, UInt64 offset);

        #endregion GL_EXT_memory_object

        #region GL_EXT_memory_object_fd

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglImportMemoryFdEXT(uint memory, UInt64 size, uint handleType, int fd);

        #endregion GL_EXT_memory_object_fd

        #region GL_EXT_memory_object_win32

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglImportMemoryWin32HandleEXT(uint memory, UInt64 size, uint handleType, void* handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglImportMemoryWin32NameEXT(uint memory, UInt64 size, uint handleType, void* name);

        #endregion GL_EXT_memory_object_win32

        #region GL_EXT_multi_draw_arrays

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawArraysEXT(uint mode, int* first, int* count, int primcount);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawElementsEXT(uint mode, int* count, uint type, IntPtr indices, int primcount);

        #endregion GL_EXT_multi_draw_arrays

        #region GL_EXT_multisample

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSampleMaskEXT(float value, bool invert);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSamplePatternEXT(uint pattern);

        #endregion GL_EXT_multisample

        #region GL_EXT_paletted_texture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColorTableEXT(uint target, uint publicFormat, int width, uint format, uint type, void* table);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetColorTableEXT(uint target, uint format, uint type, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetColorTableParameterivEXT(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetColorTableParameterfvEXT(uint target, uint pname, float* ps);

        #endregion GL_EXT_paletted_texture

        #region GL_EXT_pixel_transform

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPixelTransformParameteriEXT(uint target, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPixelTransformParameterfEXT(uint target, uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPixelTransformParameterivEXT(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPixelTransformParameterfvEXT(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPixelTransformParameterivEXT(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPixelTransformParameterfvEXT(uint target, uint pname, float* ps);

        #endregion GL_EXT_pixel_transform

        #region GL_EXT_point_parameters

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPointParameterfEXT(uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPointParameterfvEXT(uint pname, float* ps);

        #endregion GL_EXT_point_parameters

        #region GL_EXT_polygon_offset

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPolygonOffsetEXT(float factor, float bias);

        #endregion GL_EXT_polygon_offset

        #region GL_EXT_polygon_offset_clamp

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPolygonOffsetClampEXT(float factor, float units, float clamp);

        #endregion GL_EXT_polygon_offset_clamp

        #region GL_EXT_provoking_vertex

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProvokingVertexEXT(uint mode);

        #endregion GL_EXT_provoking_vertex

        #region GL_EXT_raster_multisample

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRasterSamplesEXT(uint samples, bool fixedsamplelocations);

        #endregion GL_EXT_raster_multisample

        #region GL_EXT_semaphore

        // public unsafe delegate void FNglGetUnsignedBytevEXT(uint pname,byte* data);
        // public unsafe delegate void FNglGetUnsignedBytei_vEXT(uint target,uint index,byte* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenSemaphoresEXT(int n, uint* semaphores);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteSemaphoresEXT(int n, uint* semaphores);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsSemaphoreEXT(uint semaphore);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSemaphoreParameterui64vEXT(uint semaphore, uint pname, UInt64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetSemaphoreParameterui64vEXT(uint semaphore, uint pname, UInt64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, uint* textures, uint* srcLayouts);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, uint* textures, uint* dstLayouts);

        #endregion GL_EXT_semaphore

        #region GL_EXT_semaphore_fd

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglImportSemaphoreFdEXT(uint semaphore, uint handleType, int fd);

        #endregion GL_EXT_semaphore_fd

        #region GL_EXT_semaphore_win32

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglImportSemaphoreWin32HandleEXT(uint semaphore, uint handleType, void* handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglImportSemaphoreWin32NameEXT(uint semaphore, uint handleType, void* name);

        #endregion GL_EXT_semaphore_win32

        #region GL_EXT_secondary_color

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColor3bEXT(byte red, byte green, byte blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColor3bvEXT(byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColor3dEXT(double red, double green, double blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColor3dvEXT(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColor3fEXT(float red, float green, float blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColor3fvEXT(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColor3iEXT(int red, int green, int blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColor3ivEXT(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColor3sEXT(short red, short green, short blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColor3svEXT(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColor3ubEXT(byte red, byte green, byte blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColor3ubvEXT(byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColor3uiEXT(uint red, uint green, uint blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColor3uivEXT(uint* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColor3usEXT(ushort red, ushort green, ushort blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColor3usvEXT(ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColorPointerEXT(int size, uint type, int stride, void* pointer);

        #endregion GL_EXT_secondary_color

        #region GL_EXT_separate_shader_objects

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUseShaderProgramEXT(uint type, uint program);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglActiveProgramEXT(uint program);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglCreateShaderProgramEXT(uint type, byte* str);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglActiveShaderProgramEXT(uint pipeline, uint program);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindProgramPipelineEXT(uint pipeline);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglCreateShaderProgramvEXT(uint type, int count, byte** strings);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteProgramPipelinesEXT(int n, uint* pipelines);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenProgramPipelinesEXT(int n, uint* pipelines);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramPipelineInfoLogEXT(uint pipeline, int bufSize, int* length, byte* infoLog);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramPipelineivEXT(uint pipeline, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsProgramPipelineEXT(uint pipeline);
        // public delegate void FNglProgramParameteriEXT(uint program,uint pname,int value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform1fEXT(uint program, int location, float v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform1fvEXT(uint program, int location, int count, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform1iEXT(uint program, int location, int v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform1ivEXT(uint program, int location, int count, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform2fEXT(uint program, int location, float v0, float v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform2fvEXT(uint program, int location, int count, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform2iEXT(uint program, int location, int v0, int v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform2ivEXT(uint program, int location, int count, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform3fEXT(uint program, int location, float v0, float v1, float v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform3fvEXT(uint program, int location, int count, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform3iEXT(uint program, int location, int v0, int v1, int v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform3ivEXT(uint program, int location, int count, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform4fEXT(uint program, int location, float v0, float v1, float v2, float v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform4fvEXT(uint program, int location, int count, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform4iEXT(uint program, int location, int v0, int v1, int v2, int v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform4ivEXT(uint program, int location, int count, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix2fvEXT(uint program, int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix3fvEXT(uint program, int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix4fvEXT(uint program, int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUseProgramStagesEXT(uint pipeline, uint stages, uint program);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglValidateProgramPipelineEXT(uint pipeline);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform1uiEXT(uint program, int location, uint v0);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform2uiEXT(uint program, int location, uint v0, uint v1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform3uiEXT(uint program, int location, uint v0, uint v1, uint v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniform4uiEXT(uint program, int location, uint v0, uint v1, uint v2, uint v3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform1uivEXT(uint program, int location, int count, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform2uivEXT(uint program, int location, int count, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform3uivEXT(uint program, int location, int count, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniform4uivEXT(uint program, int location, int count, uint* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix2x3fvEXT(uint program, int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix3x2fvEXT(uint program, int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix2x4fvEXT(uint program, int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix4x2fvEXT(uint program, int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix3x4fvEXT(uint program, int location, int count, bool transpose, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformMatrix4x3fvEXT(uint program, int location, int count, bool transpose, float* value);

        #endregion GL_EXT_separate_shader_objects

        #region GL_EXT_shader_framebuffer_fetch_non_coherent

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferFetchBarrierEXT();

        #endregion GL_EXT_shader_framebuffer_fetch_non_coherent

        #region GL_EXT_shader_image_load_store

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindImageTextureEXT(uint index, uint texture, int level, bool layered, int layer, uint access, int format);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMemoryBarrierEXT(uint barriers);

        #endregion GL_EXT_shader_image_load_store

        #region GL_EXT_stencil_clear_tag

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglStencilClearTagEXT(int stencilTagBits, uint stencilClearTag);

        #endregion GL_EXT_stencil_clear_tag

        #region GL_EXT_stencil_two_side

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglActiveStencilFaceEXT(uint face);

        #endregion GL_EXT_stencil_two_side

        #region GL_EXT_subtexture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexSubImage1DEXT(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexSubImage2DEXT(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);

        #endregion GL_EXT_subtexture

        #region GL_EXT_texture3D

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexImage3DEXT(uint target, int level, uint publicformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexSubImage3DEXT(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);

        #endregion GL_EXT_texture3D

        #region GL_EXT_texture_array

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferTextureLayerEXT(uint target, uint attachment, uint texture, int level, int layer);

        #endregion GL_EXT_texture_array

        #region GL_EXT_texture_buffer_object

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexBufferEXT(uint target, uint publicformat, uint buffer);

        #endregion GL_EXT_texture_buffer_object

        #region GL_EXT_texture_integer

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexParameterIivEXT(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexParameterIuivEXT(uint target, uint pname, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexParameterIivEXT(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexParameterIuivEXT(uint target, uint pname, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClearColorIiEXT(int red, int green, int blue, int alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClearColorIuiEXT(uint red, uint green, uint blue, uint alpha);

        #endregion GL_EXT_texture_integer

        #region GL_EXT_texture_object

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate bool FNglAreTexturesResidentEXT(int n, uint* textures, bool* residences);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindTextureEXT(uint target, uint texture);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteTexturesEXT(int n, uint* textures);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenTexturesEXT(int n, uint* textures);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsTextureEXT(uint texture);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPrioritizeTexturesEXT(int n, uint* textures, float* priorities);

        #endregion GL_EXT_texture_object

        #region GL_EXT_texture_perturb_normal

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureNormalEXT(uint mode);

        #endregion GL_EXT_texture_perturb_normal

        #region GL_EXT_texture_storage

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexStorage1DEXT(uint target, int levels, uint publicformat, int width);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexStorage2DEXT(uint target, int levels, uint publicformat, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexStorage3DEXT(uint target, int levels, uint publicformat, int width, int height, int depth);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureStorage1DEXT(uint texture, uint target, int levels, uint publicformat, int width);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureStorage2DEXT(uint texture, uint target, int levels, uint publicformat, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureStorage3DEXT(uint texture, uint target, int levels, uint publicformat, int width, int height, int depth);

        #endregion GL_EXT_texture_storage

        #region GL_NV_timeline_semaphore

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCreateSemaphoresNV(int n, uint* semaphores);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSemaphoreParameterivNV(uint semaphore, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetSemaphoreParameterivNV(uint semaphore, uint pname, int* ps);

        #endregion GL_NV_timeline_semaphore

        #region GL_EXT_timer_query

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetQueryObjecti64vEXT(uint id, uint pname, UInt64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetQueryObjectui64vEXT(uint id, uint pname, UInt64* ps);

        #endregion GL_EXT_timer_query

        #region GL_EXT_transform_feedback

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBeginTransformFeedbackEXT(uint primitiveMode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEndTransformFeedbackEXT();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindBufferRangeEXT(uint target, uint index, uint buffer, IntPtr offset, IntPtr size);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindBufferOffsetEXT(uint target, uint index, uint buffer, IntPtr offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindBufferBaseEXT(uint target, uint index, uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTransformFeedbackVaryingsEXT(uint program, int count, byte** varyings, uint bufferMode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name);

        #endregion GL_EXT_transform_feedback

        #region GL_EXT_vertex_array

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglArrayElementEXT(int i);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColorPointerEXT(int size, uint type, int stride, int count, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawArraysEXT(uint mode, int first, int count);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglEdgeFlagPointerEXT(int stride, int count, bool* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPointervEXT(uint pname, void** ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglIndexPointerEXT(uint type, int stride, int count, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormalPointerEXT(uint type, int stride, int count, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoordPointerEXT(int size, uint type, int stride, int count, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexPointerEXT(int size, uint type, int stride, int count, void* pointer);

        #endregion GL_EXT_vertex_array

        #region GL_EXT_vertex_attrib_64bit

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribL1dEXT(uint index, double x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribL2dEXT(uint index, double x, double y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribL3dEXT(uint index, double x, double y, double z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribL4dEXT(uint index, double x, double y, double z, double w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribL1dvEXT(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribL2dvEXT(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribL3dvEXT(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribL4dvEXT(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribLPointerEXT(uint index, int size, uint type, int stride, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribLdvEXT(uint index, uint pname, double* ps);

        #endregion GL_EXT_vertex_attrib_64bit

        #region GL_EXT_vertex_shader

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBeginVertexShaderEXT();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEndVertexShaderEXT();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindVertexShaderEXT(uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglGenVertexShadersEXT(uint range);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDeleteVertexShaderEXT(uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglShaderOp1EXT(uint op, uint res, uint arg1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglShaderOp2EXT(uint op, uint res, uint arg1, uint arg2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglShaderOp3EXT(uint op, uint res, uint arg1, uint arg2, uint arg3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSwizzleEXT(uint res, uint i, uint outX, uint outY, uint outZ, uint outW);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWriteMaskEXT(uint res, uint i, uint outX, uint outY, uint outZ, uint outW);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglInsertComponentEXT(uint res, uint src, uint num);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglExtractComponentEXT(uint res, uint src, uint num);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglGenSymbolsEXT(uint datatype, uint storagetype, uint range, uint components);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSetInvariantEXT(uint id, uint type, void* addr);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSetLocalConstantEXT(uint id, uint type, void* addr);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVariantbvEXT(uint id, byte* addr);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVariantsvEXT(uint id, short* addr);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVariantivEXT(uint id, int* addr);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVariantfvEXT(uint id, float* addr);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVariantdvEXT(uint id, double* addr);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVariantubvEXT(uint id, byte* addr);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVariantusvEXT(uint id, ushort* addr);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVariantuivEXT(uint id, uint* addr);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVariantPointerEXT(uint id, uint type, uint stride, void* addr);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEnableVariantClientStateEXT(uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDisableVariantClientStateEXT(uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglBindLightParameterEXT(uint light, uint value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglBindMaterialParameterEXT(uint face, uint value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglBindTexGenParameterEXT(uint unit, uint coord, uint value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglBindTextureUnitParameterEXT(uint unit, uint value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglBindParameterEXT(uint value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsVariantEnabledEXT(uint id, uint cap);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVariantBooleanvEXT(uint id, uint value, bool* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVariantIntegervEXT(uint id, uint value, int* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVariantFloatvEXT(uint id, uint value, float* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVariantPointervEXT(uint id, uint value, void** data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetInvariantBooleanvEXT(uint id, uint value, bool* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetInvariantIntegervEXT(uint id, uint value, int* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetInvariantFloatvEXT(uint id, uint value, float* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetLocalConstantBooleanvEXT(uint id, uint value, bool* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetLocalConstantIntegervEXT(uint id, uint value, int* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetLocalConstantFloatvEXT(uint id, uint value, float* data);

        #endregion GL_EXT_vertex_shader

        #region GL_EXT_vertex_weighting

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexWeightfEXT(float weight);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexWeightfvEXT(float* weight);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexWeightPointerEXT(int size, uint type, int stride, void* pointer);

        #endregion GL_EXT_vertex_weighting

        #region GL_EXT_win32_keyed_mutex

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglAcquireKeyedMutexWin32EXT(uint memory, UInt64 key, uint timeout);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglReleaseKeyedMutexWin32EXT(uint memory, UInt64 key);

        #endregion GL_EXT_win32_keyed_mutex

        #region GL_EXT_window_rectangles

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowRectanglesEXT(uint mode, int count, int* box);

        #endregion GL_EXT_window_rectangles

        #region GL_EXT_x11_sync_object

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr FNglImportSyncEXT(uint external_sync_type, IntPtr external_sync, uint flags);

        #endregion GL_EXT_x11_sync_object

        #region GL_GREMEDY_frame_terminator

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFrameTerminatorGREMEDY();

        #endregion GL_GREMEDY_frame_terminator

        #region GL_GREMEDY_string_marker

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglStringMarkerGREMEDY(int len, void* str);

        #endregion GL_GREMEDY_string_marker

        #region GL_HP_image_transform

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglImageTransformParameteriHP(uint target, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglImageTransformParameterfHP(uint target, uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglImageTransformParameterivHP(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglImageTransformParameterfvHP(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetImageTransformParameterivHP(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetImageTransformParameterfvHP(uint target, uint pname, float* ps);

        #endregion GL_HP_image_transform

        #region GL_IBM_multimode_draw_arrays

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiModeDrawArraysIBM(uint* mode, int* first, int* count, int primcount, int modestride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiModeDrawElementsIBM(uint* mode, int* count, uint type, IntPtr indices, int primcount, int modestride);

        #endregion GL_IBM_multimode_draw_arrays

        #region GL_IBM_static_data

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFlushStaticDataIBM(uint target);

        #endregion GL_IBM_static_data

        #region GL_IBM_vertex_array_lists

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColorPointerListIBM(int size, uint type, int stride, void** pointer, int ptrstride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColorPointerListIBM(int size, uint type, int stride, void** pointer, int ptrstride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglEdgeFlagPointerListIBM(int stride, bool** pointer, int ptrstride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFogCoordPointerListIBM(uint type, int stride, void** pointer, int ptrstride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglIndexPointerListIBM(uint type, int stride, void** pointer, int ptrstride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormalPointerListIBM(uint type, int stride, void** pointer, int ptrstride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoordPointerListIBM(int size, uint type, int stride, void** pointer, int ptrstride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexPointerListIBM(int size, uint type, int stride, void** pointer, int ptrstride);

        #endregion GL_IBM_vertex_array_lists

        #region GL_INGR_blend_func_separate

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendFuncSeparateINGR(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);

        #endregion GL_INGR_blend_func_separate

        #region GL_INTEL_framebuffer_CMAA

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglApplyFramebufferAttachmentCMAAINTEL();

        #endregion GL_INTEL_framebuffer_CMAA

        #region GL_INTEL_map_texture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSyncTextureINTEL(uint texture);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUnmapTexture2DINTEL(uint texture, int level);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void* FNglMapTexture2DINTEL(uint texture, int level, uint access, int* stride, uint* layout);

        #endregion GL_INTEL_map_texture

        #region GL_INTEL_parallel_arrays

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexPointervINTEL(int size, uint type, void** pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormalPointervINTEL(uint type, void** pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColorPointervINTEL(int size, uint type, void** pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoordPointervINTEL(int size, uint type, void** pointer);

        #endregion GL_INTEL_parallel_arrays

        #region GL_INTEL_performance_query

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBeginPerfQueryINTEL(uint queryHandle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCreatePerfQueryINTEL(uint queryId, uint* queryHandle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDeletePerfQueryINTEL(uint queryHandle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEndPerfQueryINTEL(uint queryHandle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetFirstPerfQueryIdINTEL(uint* queryId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetNextPerfQueryIdINTEL(uint queryId, uint* nextQueryId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPerfCounterInfoINTEL(uint queryId, uint counterId, uint counterNameLength, byte* counterName, uint counterDescLength, byte* counterDesc, uint* counterOffset, uint* counterDataSize, uint* counterTypeEnum, uint* counterDataTypeEnum, UInt64* rawCounterMaxValue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPerfQueryDataINTEL(uint queryHandle, uint flags, int dataSize, void* data, uint* bytesWritten);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPerfQueryIdByNameINTEL(byte* queryName, uint* queryId);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPerfQueryInfoINTEL(uint queryId, uint queryNameLength, byte* queryName, uint* dataSize, uint* noCounters, uint* noInstances, uint* capsMask);

        #endregion GL_INTEL_performance_query

        #region GL_KHR_blend_equation_advanced

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendBarrierKHR();

        #endregion GL_KHR_blend_equation_advanced

        #region GL_KHR_debug

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void GLDEBUGPROCKHR(uint source, uint type, uint id, uint severity, int length, byte* message, void* userParam);

        // public unsafe delegate void FNglDebugMessageControl(uint source,uint type,uint severity,int count,uint* ids,bool enabled);
        // public unsafe delegate void FNglDebugMessageInsert(uint source,uint type,uint id,uint severity,int length,byte* message);
        // public unsafe delegate void FNglDebugMessageCallback(GLDEBUGPROC callback,void* userParam);
        // public unsafe delegate uint FNglGetDebugMessageLog(uint count,int bufSize,uint* sources,uint* types,uint* ids,uint* severities,int* lengths,byte* messageLog);
        // public unsafe delegate void FNglPushDebugGroup(uint source,uint id,int length,byte* message);
        // public delegate void FNglPopDebugGroup();
        // public unsafe delegate void FNglObjectLabel(uint identifier,uint name,int length,byte* label);
        // public unsafe delegate void FNglGetObjectLabel(uint identifier,uint name,int bufSize,int* length,byte* label);
        // public unsafe delegate void FNglObjectPtrLabel(void* ptr,int length,byte* label);
        // public unsafe delegate void FNglGetObjectPtrLabel(void* ptr,int bufSize,int* length,byte* label);
        // public unsafe delegate void FNglGetPointerv(uint pname,void** ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDebugMessageControlKHR(uint source, uint type, uint severity, int count, uint* ids, bool enabled);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDebugMessageInsertKHR(uint source, uint type, uint id, uint severity, int length, byte* buf);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDebugMessageCallbackKHR(GLDEBUGPROCKHR callback, void* userParam);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglGetDebugMessageLogKHR(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, byte* messageLog);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPushDebugGroupKHR(uint source, uint id, int length, byte* message);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPopDebugGroupKHR();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglObjectLabelKHR(uint identifier, uint name, int length, byte* label);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetObjectLabelKHR(uint identifier, uint name, int bufSize, int* length, byte* label);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglObjectPtrLabelKHR(void* ptr, int length, byte* label);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetObjectPtrLabelKHR(void* ptr, int bufSize, int* length, byte* label);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPointervKHR(uint pname, void** ps);

        #endregion GL_KHR_debug

        #region GL_KHR_robustness

        // public delegate uint FNglGetGraphicsResetStatus();
        // public unsafe delegate void FNglReadnPixels(int x,int y,int width,int height,uint format,uint type,int bufSize,void* data);
        // public unsafe delegate void FNglGetnUniformfv(uint program,int location,int bufSize,float* ps);
        // public unsafe delegate void FNglGetnUniformiv(uint program,int location,int bufSize,int* ps);
        // public unsafe delegate void FNglGetnUniformuiv(uint program,int location,int bufSize,uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglGetGraphicsResetStatusKHR();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglReadnPixelsKHR(int x, int y, int width, int height, uint format, uint type, int bufSize, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnUniformfvKHR(uint program, int location, int bufSize, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnUniformivKHR(uint program, int location, int bufSize, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetnUniformuivKHR(uint program, int location, int bufSize, uint* ps);

        #endregion GL_KHR_robustness

        #region GL_KHR_parallel_shader_compile

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMaxShaderCompilerThreadsKHR(uint count);

        #endregion GL_KHR_parallel_shader_compile

        #region GL_MESA_framebuffer_flip_y

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferParameteriMESA(uint target, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetFramebufferParameterivMESA(uint target, uint pname, int* ps);

        #endregion GL_MESA_framebuffer_flip_y

        #region GL_MESA_resize_buffers

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglResizeBuffersMESA();

        #endregion GL_MESA_resize_buffers

        #region GL_MESA_window_pos

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos2dMESA(double x, double y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos2dvMESA(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos2fMESA(float x, float y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos2fvMESA(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos2iMESA(int x, int y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos2ivMESA(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos2sMESA(short x, short y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos2svMESA(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos3dMESA(double x, double y, double z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos3dvMESA(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos3fMESA(float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos3fvMESA(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos3iMESA(int x, int y, int z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos3ivMESA(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos3sMESA(short x, short y, short z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos3svMESA(short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos4dMESA(double x, double y, double z, double w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos4dvMESA(double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos4fMESA(float x, float y, float z, float w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos4fvMESA(float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos4iMESA(int x, int y, int z, int w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos4ivMESA(int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWindowPos4sMESA(short x, short y, short z, short w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWindowPos4svMESA(short* v);

        #endregion GL_MESA_window_pos

        #region GL_NVX_conditional_render

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBeginConditionalRenderNVX(uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEndConditionalRenderNVX();

        #endregion GL_NVX_conditional_render

        #region GL_NVX_linked_gpu_multicast

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglLGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, IntPtr offset, IntPtr size, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLGPUCopyImageSubDataNVX(uint sourceGpu, uint destinationGpuMask, uint srcName, uint srcTarget, int srcLevel, int srcX, int srxY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLGPUInterlockNVX();

        #endregion GL_NVX_linked_gpu_multicast

        #region GL_NV_alpha_to_coverage_dither_control

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglAlphaToCoverageDitherControlNV(uint mode);

        #endregion GL_NV_alpha_to_coverage_dither_control

        #region GL_NV_bindless_multi_draw_indirect

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawArraysIndirectBindlessNV(uint mode, void* indirect, int drawCount, int stride, int vertexBufferCount);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawElementsIndirectBindlessNV(uint mode, uint type, void* indirect, int drawCount, int stride, int vertexBufferCount);

        #endregion GL_NV_bindless_multi_draw_indirect

        #region GL_NV_bindless_multi_draw_indirect_count

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawArraysIndirectBindlessCountNV(uint mode, void* indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiDrawElementsIndirectBindlessCountNV(uint mode, uint type, void* indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount);

        #endregion GL_NV_bindless_multi_draw_indirect_count

        #region GL_NV_bindless_texture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate UInt64 FNglGetTextureHandleNV(uint texture);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate UInt64 FNglGetTextureSamplerHandleNV(uint texture, uint sampler);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMakeTextureHandleResidentNV(UInt64 handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMakeTextureHandleNonResidentNV(UInt64 handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate UInt64 FNglGetImageHandleNV(uint texture, int level, bool layered, int layer, uint format);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMakeImageHandleResidentNV(UInt64 handle, uint access);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMakeImageHandleNonResidentNV(UInt64 handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniformHandleui64NV(int location, UInt64 value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformHandleui64vNV(int location, int count, UInt64* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniformHandleui64NV(uint program, int location, UInt64 value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformHandleui64vNV(uint program, int location, int count, UInt64* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsTextureHandleResidentNV(UInt64 handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsImageHandleResidentNV(UInt64 handle);

        #endregion GL_NV_bindless_texture

        #region GL_NV_blend_equation_advanced

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendParameteriNV(uint pname, int value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendBarrierNV();

        #endregion GL_NV_blend_equation_advanced

        #region GL_NV_clip_space_w_scaling

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglViewportPositionWScaleNV(uint index, float xcoeff, float ycoeff);

        #endregion GL_NV_clip_space_w_scaling

        #region GL_NV_command_list

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCreateStatesNV(int n, uint* states);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteStatesNV(int n, uint* states);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsStateNV(uint state);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglStateCaptureNV(uint state, uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglGetCommandHeaderNV(uint tokenID, uint size);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ushort FNglGetStageIndexNV(uint shadertype);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawCommandsNV(uint primitiveMode, uint buffer, IntPtr indirects, int* sizes, uint count);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawCommandsAddressNV(uint primitiveMode, UInt64* indirects, int* sizes, uint count);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawCommandsStatesNV(uint buffer, IntPtr indirects, int* sizes, uint* states, uint* fbos, uint count);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDrawCommandsStatesAddressNV(UInt64* indirects, int* sizes, uint* states, uint* fbos, uint count);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCreateCommandListsNV(int n, uint* lists);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteCommandListsNV(int n, uint* lists);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsCommandListNV(uint list);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglListDrawCommandsStatesClientNV(uint list, uint segment, void** indirects, int* sizes, uint* states, uint* fbos, uint count);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCommandListSegmentsNV(uint list, uint segments);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCompileCommandListNV(uint list);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCallCommandListNV(uint list);

        #endregion GL_NV_command_list

        #region GL_NV_conditional_render

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBeginConditionalRenderNV(uint id, uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEndConditionalRenderNV();

        #endregion GL_NV_conditional_render

        #region GL_NV_conservative_raster

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSubpixelPrecisionBiasNV(uint xbits, uint ybits);

        #endregion GL_NV_conservative_raster

        #region GL_NV_conservative_raster_dilate

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglConservativeRasterParameterfNV(uint pname, float value);

        #endregion GL_NV_conservative_raster_dilate

        #region GL_NV_conservative_raster_pre_snap_triangles

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglConservativeRasterParameteriNV(uint pname, int param);

        #endregion GL_NV_conservative_raster_pre_snap_triangles

        #region GL_NV_copy_image

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyImageSubDataNV(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth);

        #endregion GL_NV_copy_image

        #region GL_NV_depth_buffer_float

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDepthRangedNV(double zNear, double zFar);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClearDepthdNV(double depth);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDepthBoundsdNV(double zmin, double zmax);

        #endregion GL_NV_depth_buffer_float

        #region GL_NV_draw_texture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawTextureNV(uint texture, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);

        #endregion GL_NV_draw_texture

        #region GL_NV_draw_vulkan_image

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawVkImageNV(UInt64 vkImage, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate IntPtr FNglGetVkProcAddrNV(byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglWaitVkSemaphoreNV(UInt64 vkSemaphore);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSignalVkSemaphoreNV(UInt64 vkSemaphore);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSignalVkFenceNV(UInt64 vkFence);

        #endregion GL_NV_draw_vulkan_image

        #region GL_NV_evaluators

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, bool packed, void* points);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMapParameterivNV(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMapParameterfvNV(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, bool packed, void* points);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMapParameterivNV(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMapParameterfvNV(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMapAttribParameterivNV(uint target, uint index, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMapAttribParameterfvNV(uint target, uint index, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEvalMapsNV(uint target, uint mode);

        #endregion GL_NV_evaluators

        #region GL_NV_explicit_multisample

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMultisamplefvNV(uint pname, uint index, float* val);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSampleMaskIndexedNV(uint index, uint mask);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexRenderbufferNV(uint target, uint renderbuffer);

        #endregion GL_NV_explicit_multisample

        #region GL_NV_fence

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteFencesNV(int n, uint* fences);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenFencesNV(int n, uint* fences);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsFenceNV(uint fence);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglTestFenceNV(uint fence);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetFenceivNV(uint fence, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFinishFenceNV(uint fence);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSetFenceNV(uint fence, uint condition);

        #endregion GL_NV_fence

        #region GL_NV_fragment_coverage_to_color

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFragmentCoverageColorNV(uint color);

        #endregion GL_NV_fragment_coverage_to_color

        #region GL_NV_framebuffer_mixed_samples

        // public delegate void FNglRasterSamplesEXT(uint samples,bool fixedsamplelocations);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCoverageModulationTableNV(int n, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetCoverageModulationTableNV(int bufSize, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCoverageModulationNV(uint components);

        #endregion GL_NV_framebuffer_mixed_samples

        #region GL_NV_framebuffer_multisample_coverage

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRenderbufferStorageMultisampleCoverageNV(uint target, int coverageSamples, int colorSamples, uint publicformat, int width, int height);

        #endregion GL_NV_framebuffer_multisample_coverage

        #region GL_NV_geometry_program4

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramVertexLimitNV(uint target, int limit);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferTextureEXT(uint target, uint attachment, uint texture, int level);
        // public delegate void FNglFramebufferTextureLayerEXT(uint target,uint attachment,uint texture,int level,int layer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferTextureFaceEXT(uint target, uint attachment, uint texture, int level, uint face);

        #endregion GL_NV_geometry_program4

        #region GL_NV_gpu_program4

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramLocalParameterI4iNV(uint target, uint index, int x, int y, int z, int w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramLocalParameterI4ivNV(uint target, uint index, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramLocalParametersI4ivNV(uint target, uint index, int count, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramLocalParameterI4uiNV(uint target, uint index, uint x, uint y, uint z, uint w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramLocalParameterI4uivNV(uint target, uint index, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramLocalParametersI4uivNV(uint target, uint index, int count, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramEnvParameterI4iNV(uint target, uint index, int x, int y, int z, int w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramEnvParameterI4ivNV(uint target, uint index, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramEnvParametersI4ivNV(uint target, uint index, int count, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramEnvParameterI4uiNV(uint target, uint index, uint x, uint y, uint z, uint w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramEnvParameterI4uivNV(uint target, uint index, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramEnvParametersI4uivNV(uint target, uint index, int count, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramLocalParameterIivNV(uint target, uint index, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramLocalParameterIuivNV(uint target, uint index, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramEnvParameterIivNV(uint target, uint index, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramEnvParameterIuivNV(uint target, uint index, uint* ps);

        #endregion GL_NV_gpu_program4

        #region GL_NV_gpu_program5

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramSubroutineParametersuivNV(uint target, int count, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramSubroutineParameteruivNV(uint target, uint index, uint* param);

        #endregion GL_NV_gpu_program5

        #region GL_NV_gpu_shader5

        // public delegate void FNglUniform1i64NV(int location,Int64 x);
        // public delegate void FNglUniform2i64NV(int location,Int64 x,Int64 y);
        // public delegate void FNglUniform3i64NV(int location,Int64 x,Int64 y,Int64 z);
        // public delegate void FNglUniform4i64NV(int location,Int64 x,Int64 y,Int64 z,Int64 w);
        // public unsafe delegate void FNglUniform1i64vNV(int location,int count,Int64* value);
        // public unsafe delegate void FNglUniform2i64vNV(int location,int count,Int64* value);
        // public unsafe delegate void FNglUniform3i64vNV(int location,int count,Int64* value);
        // public unsafe delegate void FNglUniform4i64vNV(int location,int count,Int64* value);
        // public delegate void FNglUniform1ui64NV(int location,UInt64 x);
        // public delegate void FNglUniform2ui64NV(int location,UInt64 x,UInt64 y);
        // public delegate void FNglUniform3ui64NV(int location,UInt64 x,UInt64 y,UInt64 z);
        // public delegate void FNglUniform4ui64NV(int location,UInt64 x,UInt64 y,UInt64 z,UInt64 w);
        // public unsafe delegate void FNglUniform1ui64vNV(int location,int count,UInt64* value);
        // public unsafe delegate void FNglUniform2ui64vNV(int location,int count,UInt64* value);
        // public unsafe delegate void FNglUniform3ui64vNV(int location,int count,UInt64* value);
        // public unsafe delegate void FNglUniform4ui64vNV(int location,int count,UInt64* value);
        // public unsafe delegate void FNglGetUniformi64vNV(uint program,int location,Int64* ps);
        // public delegate void FNglProgramUniform1i64NV(uint program,int location,Int64 x);
        // public delegate void FNglProgramUniform2i64NV(uint program,int location,Int64 x,Int64 y);
        // public delegate void FNglProgramUniform3i64NV(uint program,int location,Int64 x,Int64 y,Int64 z);
        // public delegate void FNglProgramUniform4i64NV(uint program,int location,Int64 x,Int64 y,Int64 z,Int64 w);
        // public unsafe delegate void FNglProgramUniform1i64vNV(uint program,int location,int count,Int64* value);
        // public unsafe delegate void FNglProgramUniform2i64vNV(uint program,int location,int count,Int64* value);
        // public unsafe delegate void FNglProgramUniform3i64vNV(uint program,int location,int count,Int64* value);
        // public unsafe delegate void FNglProgramUniform4i64vNV(uint program,int location,int count,Int64* value);
        // public delegate void FNglProgramUniform1ui64NV(uint program,int location,UInt64 x);
        // public delegate void FNglProgramUniform2ui64NV(uint program,int location,UInt64 x,UInt64 y);
        // public delegate void FNglProgramUniform3ui64NV(uint program,int location,UInt64 x,UInt64 y,UInt64 z);
        // public delegate void FNglProgramUniform4ui64NV(uint program,int location,UInt64 x,UInt64 y,UInt64 z,UInt64 w);
        // public unsafe delegate void FNglProgramUniform1ui64vNV(uint program,int location,int count,UInt64* value);
        // public unsafe delegate void FNglProgramUniform2ui64vNV(uint program,int location,int count,UInt64* value);
        // public unsafe delegate void FNglProgramUniform3ui64vNV(uint program,int location,int count,UInt64* value);
        // public unsafe delegate void FNglProgramUniform4ui64vNV(uint program,int location,int count,UInt64* value);

        #endregion GL_NV_gpu_shader5

        #region GL_NV_half_float

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex2hNV(ushort x, ushort y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex2hvNV(ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex3hNV(ushort x, ushort y, ushort z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex3hvNV(ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex4hNV(ushort x, ushort y, ushort z, ushort w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex4hvNV(ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNormal3hNV(ushort nx, ushort ny, ushort nz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormal3hvNV(ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor3hNV(ushort red, ushort green, ushort blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor3hvNV(ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor4hNV(ushort red, ushort green, ushort blue, ushort alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor4hvNV(ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord1hNV(ushort s);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord1hvNV(ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord2hNV(ushort s, ushort t);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord2hvNV(ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord3hNV(ushort s, ushort t, ushort r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord3hvNV(ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord4hNV(ushort s, ushort t, ushort r, ushort q);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord4hvNV(ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord1hNV(uint target, ushort s);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord1hvNV(uint target, ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord2hNV(uint target, ushort s, ushort t);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord2hvNV(uint target, ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord3hNV(uint target, ushort s, ushort t, ushort r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord3hvNV(uint target, ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord4hNV(uint target, ushort s, ushort t, ushort r, ushort q);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord4hvNV(uint target, ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFogCoordhNV(ushort fog);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFogCoordhvNV(ushort* fog);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColor3hNV(ushort red, ushort green, ushort blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSecondaryColor3hvNV(ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexWeighthNV(ushort weight);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexWeighthvNV(ushort* weight);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib1hNV(uint index, ushort x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib1hvNV(uint index, ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib2hNV(uint index, ushort x, ushort y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib2hvNV(uint index, ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib3hNV(uint index, ushort x, ushort y, ushort z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib3hvNV(uint index, ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib4hNV(uint index, ushort x, ushort y, ushort z, ushort w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4hvNV(uint index, ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribs1hvNV(uint index, int n, ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribs2hvNV(uint index, int n, ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribs3hvNV(uint index, int n, ushort* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribs4hvNV(uint index, int n, ushort* v);

        #endregion GL_NV_half_float

        #region GL_NV_publicformat_sample_query

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetInternalformatSampleivNV(uint target, uint publicformat, int samples, uint pname, int count, int* ps);

        #endregion GL_NV_publicformat_sample_query

        #region GL_NV_gpu_multicast

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRenderGpuMaskNV(uint mask);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMulticastBufferSubDataNV(uint gpuMask, uint buffer, IntPtr offset, IntPtr size, void* data);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMulticastCopyBufferSubDataNV(uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMulticastCopyImageSubDataNV(uint srcGpu, uint dstGpuMask, uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMulticastBlitFramebufferNV(uint srcGpu, uint dstGpu, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMulticastFramebufferSampleLocationsfvNV(uint gpu, uint framebuffer, uint start, int count, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMulticastBarrierNV();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMulticastWaitSyncNV(uint signalGpu, uint waitGpuMask);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMulticastGetQueryObjectivNV(uint gpu, uint id, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMulticastGetQueryObjectuivNV(uint gpu, uint id, uint pname, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMulticastGetQueryObjecti64vNV(uint gpu, uint id, uint pname, UInt64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMulticastGetQueryObjectui64vNV(uint gpu, uint id, uint pname, UInt64* ps);

        #endregion GL_NV_gpu_multicast

        #region GL_NVX_gpu_multicast2

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUploadGpuMaskNVX(uint mask);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMulticastViewportArrayvNVX(uint gpu, uint first, int count, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMulticastViewportPositionWScaleNVX(uint gpu, uint index, float xcoeff, float ycoeff);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMulticastScissorArrayvNVX(uint gpu, uint first, int count, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglAsyncCopyBufferSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, UInt64* fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size, int signalSemaphoreCount, uint* signalSemaphoreArray, UInt64* signalValueArray);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglAsyncCopyImageSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, UInt64* waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, uint* signalSemaphoreArray, UInt64* signalValueArray);

        #endregion GL_NVX_gpu_multicast2

        #region GL_NVX_progress_fence

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglCreateProgressFenceNVX();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSignalSemaphoreui64NVX(uint signalGpu, int fenceObjectCount, uint* semaphoreArray, UInt64* fenceValueArray);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWaitSemaphoreui64NVX(uint waitGpu, int fenceObjectCount, uint* semaphoreArray, UInt64* fenceValueArray);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglClientWaitSemaphoreui64NVX(int fenceObjectCount, uint* semaphoreArray, UInt64* fenceValueArray);

        #endregion GL_NVX_progress_fence

        #region GL_NV_memory_attachment

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMemoryObjectDetachedResourcesuivNV(uint memory, uint pname, int first, int count, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglResetMemoryObjectParameterNV(uint memory, uint pname);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexAttachMemoryNV(uint target, uint memory, UInt64 offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBufferAttachMemoryNV(uint target, uint memory, UInt64 offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureAttachMemoryNV(uint texture, uint memory, UInt64 offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNamedBufferAttachMemoryNV(uint buffer, uint memory, UInt64 offset);

        #endregion GL_NV_memory_attachment

        #region GL_NV_memory_object_sparse

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBufferPageCommitmentMemNV(uint target, IntPtr offset, IntPtr size, uint memory, UInt64 memOffset, bool commit);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexPageCommitmentMemNV(uint target, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, UInt64 offset, bool commit);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNamedBufferPageCommitmentMemNV(uint buffer, IntPtr offset, IntPtr size, uint memory, UInt64 memOffset, bool commit);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexturePageCommitmentMemNV(uint texture, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, UInt64 offset, bool commit);

        #endregion GL_NV_memory_object_sparse

        #region GL_NV_mesh_shader

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawMeshTasksNV(uint first, uint count);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawMeshTasksIndirectNV(IntPtr indirect);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiDrawMeshTasksIndirectNV(IntPtr indirect, int drawcount, int stride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiDrawMeshTasksIndirectCountNV(IntPtr indirect, IntPtr drawcount, int maxdrawcount, int stride);

        #endregion GL_NV_mesh_shader

        #region GL_NV_occlusion_query

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenOcclusionQueriesNV(int n, uint* ids);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteOcclusionQueriesNV(int n, uint* ids);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsOcclusionQueryNV(uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBeginOcclusionQueryNV(uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEndOcclusionQueryNV();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetOcclusionQueryivNV(uint id, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetOcclusionQueryuivNV(uint id, uint pname, uint* ps);

        #endregion GL_NV_occlusion_query

        #region GL_NV_parameter_buffer_object

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramBufferParametersfvNV(uint target, uint bindingIndex, uint wordIndex, int count, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramBufferParametersIivNV(uint target, uint bindingIndex, uint wordIndex, int count, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramBufferParametersIuivNV(uint target, uint bindingIndex, uint wordIndex, int count, uint* ps);

        #endregion GL_NV_parameter_buffer_object

        #region GL_NV_path_rendering

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglGenPathsNV(int range);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDeletePathsNV(uint path, int range);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsPathNV(uint path);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPathCommandsNV(uint path, int numCommands, byte* commands, int numCoords, uint coordType, void* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPathCoordsNV(uint path, int numCoords, uint coordType, void* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPathSubCommandsNV(uint path, int commandStart, int commandsToDelete, int numCommands, byte* commands, int numCoords, uint coordType, void* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPathSubCoordsNV(uint path, int coordStart, int numCoords, uint coordType, void* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPathStringNV(uint path, uint format, int length, void* pathString);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPathGlyphsNV(uint firstPathName, uint fontTarget, void* fontName, uint fontStyle, int numGlyphs, uint type, void* charcodes, uint handleMissingGlyphs, uint pathParameterTemplate, float emScale);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPathGlyphRangeNV(uint firstPathName, uint fontTarget, void* fontName, uint fontStyle, uint firstGlyph, int numGlyphs, uint handleMissingGlyphs, uint pathParameterTemplate, float emScale);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglWeightPathsNV(uint resultPath, int numPaths, uint* paths, float* weights);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyPathNV(uint resultPath, uint srcPath);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglInterpolatePathsNV(uint resultPath, uint pathA, uint pathB, float weight);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTransformPathNV(uint resultPath, uint srcPath, uint transformType, float* transformValues);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPathParameterivNV(uint path, uint pname, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPathParameteriNV(uint path, uint pname, int value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPathParameterfvNV(uint path, uint pname, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPathParameterfNV(uint path, uint pname, float value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPathDashArrayNV(uint path, int dashCount, float* dashArray);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPathStencilFuncNV(uint func, int r, uint mask);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPathStencilDepthOffsetNV(float factor, float units);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglStencilFillPathNV(uint path, uint fillMode, uint mask);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglStencilStrokePathNV(uint path, int reference, uint mask);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglStencilFillPathInstancedNV(int numPaths, uint pathNameType, void* paths, uint pathBase, uint fillMode, uint mask, uint transformType, float* transformValues);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglStencilStrokePathInstancedNV(int numPaths, uint pathNameType, void* paths, uint pathBase, int reference, uint mask, uint transformType, float* transformValues);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPathCoverDepthFuncNV(uint func);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCoverFillPathNV(uint path, uint coverMode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCoverStrokePathNV(uint path, uint coverMode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCoverFillPathInstancedNV(int numPaths, uint pathNameType, void* paths, uint pathBase, uint coverMode, uint transformType, float* transformValues);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCoverStrokePathInstancedNV(int numPaths, uint pathNameType, void* paths, uint pathBase, uint coverMode, uint transformType, float* transformValues);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPathParameterivNV(uint path, uint pname, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPathParameterfvNV(uint path, uint pname, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPathCommandsNV(uint path, byte* commands);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPathCoordsNV(uint path, float* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPathDashArrayNV(uint path, float* dashArray);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPathMetricsNV(uint metricQueryMask, int numPaths, uint pathNameType, void* paths, uint pathBase, int stride, float* metrics);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPathMetricRangeNV(uint metricQueryMask, uint firstPathName, int numPaths, int stride, float* metrics);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPathSpacingNV(uint pathListMode, int numPaths, uint pathNameType, void* paths, uint pathBase, float advanceScale, float kerningScale, uint transformType, float* returnedSpacing);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsPointInFillPathNV(uint path, uint mask, float x, float y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsPointInStrokePathNV(uint path, float x, float y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float FNglGetPathLengthNV(uint path, int startSegment, int numSegments);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate bool FNglPointAlongPathNV(uint path, int startSegment, int numSegments, float distance, float* x, float* y, float* tangentX, float* tangentY);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixLoad3x2fNV(uint matrixMode, float* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixLoad3x3fNV(uint matrixMode, float* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixLoadTranspose3x3fNV(uint matrixMode, float* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixMult3x2fNV(uint matrixMode, float* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixMult3x3fNV(uint matrixMode, float* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixMultTranspose3x3fNV(uint matrixMode, float* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglStencilThenCoverFillPathNV(uint path, uint fillMode, uint mask, uint coverMode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglStencilThenCoverStrokePathNV(uint path, int reference, uint mask, uint coverMode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglStencilThenCoverFillPathInstancedNV(int numPaths, uint pathNameType, void* paths, uint pathBase, uint fillMode, uint mask, uint coverMode, uint transformType, float* transformValues);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglStencilThenCoverStrokePathInstancedNV(int numPaths, uint pathNameType, void* paths, uint pathBase, int reference, uint mask, uint coverMode, uint transformType, float* transformValues);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglPathGlyphIndexRangeNV(uint fontTarget, void* fontName, uint fontStyle, uint pathParameterTemplate, float emScale, uint* baseAndCount);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglPathGlyphIndexArrayNV(uint firstPathName, uint fontTarget, void* fontName, uint fontStyle, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglPathMemoryGlyphIndexArrayNV(uint firstPathName, uint fontTarget, IntPtr fontSize, void* fontData, int faceIndex, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramPathFragmentInputGenNV(uint program, int location, uint genMode, int components, float* coeffs);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramResourcefvNV(uint program, uint programInterface, uint index, int propCount, uint* props, int count, int* length, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPathColorGenNV(uint color, uint genMode, uint colorFormat, float* coeffs);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPathTexGenNV(uint texCoordSet, uint genMode, int components, float* coeffs);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPathFogGenNV(uint genMode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPathColorGenivNV(uint color, uint pname, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPathColorGenfvNV(uint color, uint pname, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPathTexGenivNV(uint texCoordSet, uint pname, int* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPathTexGenfvNV(uint texCoordSet, uint pname, float* value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMatrixFrustumEXT(uint mode, double left, double right, double bottom, double top, double zNear, double zFar);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMatrixLoadIdentityEXT(uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixLoadTransposefEXT(uint mode, float* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixLoadTransposedEXT(uint mode, double* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixLoadfEXT(uint mode, float* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixLoaddEXT(uint mode, double* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixMultTransposefEXT(uint mode, float* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixMultTransposedEXT(uint mode, double* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixMultfEXT(uint mode, float* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMatrixMultdEXT(uint mode, double* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMatrixOrthoEXT(uint mode, double left, double right, double bottom, double top, double zNear, double zFar);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMatrixPopEXT(uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMatrixPushEXT(uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMatrixRotatefEXT(uint mode, float angle, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMatrixRotatedEXT(uint mode, double angle, double x, double y, double z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMatrixScalefEXT(uint mode, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMatrixScaledEXT(uint mode, double x, double y, double z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMatrixTranslatefEXT(uint mode, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMatrixTranslatedEXT(uint mode, double x, double y, double z);

        #endregion GL_NV_path_rendering

        #region GL_NV_pixel_data_range

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPixelDataRangeNV(uint target, int length, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFlushPixelDataRangeNV(uint target);

        #endregion GL_NV_pixel_data_range

        #region GL_NV_point_sprite

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPointParameteriNV(uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPointParameterivNV(uint pname, int* ps);

        #endregion GL_NV_point_sprite

        #region GL_NV_present_video

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPresentFrameKeyedNV(uint video_slot, UInt64 minPresentTime, uint beginPresentTimeId, uint presentDurationId, uint type, uint target0, uint fill0, uint key0, uint target1, uint fill1, uint key1);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPresentFrameDualFillNV(uint video_slot, UInt64 minPresentTime, uint beginPresentTimeId, uint presentDurationId, uint type, uint target0, uint fill0, uint target1, uint fill1, uint target2, uint fill2, uint target3, uint fill3);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVideoivNV(uint video_slot, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVideouivNV(uint video_slot, uint pname, uint* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVideoi64vNV(uint video_slot, uint pname, Int64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVideoui64vNV(uint video_slot, uint pname, UInt64* ps);

        #endregion GL_NV_present_video

        #region GL_NV_primitive_restart

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPrimitiveRestartNV();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPrimitiveRestartIndexNV(uint index);

        #endregion GL_NV_primitive_restart

        #region GL_NV_query_resource

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int FNglQueryResourceNV(uint queryType, int tagId, uint count, int* buffer);

        #endregion GL_NV_query_resource

        #region GL_NV_query_resource_tag

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenQueryResourceTagNV(int n, int* tagIds);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteQueryResourceTagNV(int n, int* tagIds);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglQueryResourceTagNV(int tagId, byte* tagString);

        #endregion GL_NV_query_resource_tag

        #region GL_NV_register_combiners

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCombinerParameterfvNV(uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCombinerParameterfNV(uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCombinerParameterivNV(uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCombinerParameteriNV(uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCombinerInputNV(uint stage, uint portion, uint variable, uint input, uint mapping, uint componentUsage);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCombinerOutputNV(uint stage, uint portion, uint abOutput, uint cdOutput, uint sumOutput, uint scale, uint bias, bool abDotProduct, bool cdDotProduct, bool muxSum);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFinalCombinerInputNV(uint variable, uint input, uint mapping, uint componentUsage);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetCombinerInputParameterfvNV(uint stage, uint portion, uint variable, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetCombinerInputParameterivNV(uint stage, uint portion, uint variable, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetCombinerOutputParameterfvNV(uint stage, uint portion, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetCombinerOutputParameterivNV(uint stage, uint portion, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetFinalCombinerInputParameterfvNV(uint variable, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetFinalCombinerInputParameterivNV(uint variable, uint pname, int* ps);

        #endregion GL_NV_register_combiners

        #region GL_NV_register_combiners2

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglCombinerStageParameterfvNV(uint stage, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetCombinerStageParameterfvNV(uint stage, uint pname, float* ps);

        #endregion GL_NV_register_combiners2

        #region GL_NV_sample_locations

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFramebufferSampleLocationsfvNV(uint target, uint start, int count, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNamedFramebufferSampleLocationsfvNV(uint framebuffer, uint start, int count, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglResolveDepthValuesNV();

        #endregion GL_NV_sample_locations

        #region GL_NV_scissor_exclusive

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglScissorExclusiveNV(int x, int y, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglScissorExclusiveArrayvNV(uint first, int count, int* v);

        #endregion GL_NV_scissor_exclusive

        #region GL_NV_shader_buffer_load

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMakeBufferResidentNV(uint target, uint access);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMakeBufferNonResidentNV(uint target);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsBufferResidentNV(uint target);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMakeNamedBufferResidentNV(uint buffer, uint access);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMakeNamedBufferNonResidentNV(uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsNamedBufferResidentNV(uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetBufferParameterui64vNV(uint target, uint pname, UInt64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetNamedBufferParameterui64vNV(uint buffer, uint pname, UInt64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetIntegerui64vNV(uint value, UInt64* result);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglUniformui64NV(int location, UInt64 value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglUniformui64vNV(int location, int count, UInt64* value);
        // public unsafe delegate void FNglGetUniformui64vNV(uint program,int location,UInt64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramUniformui64NV(uint program, int location, UInt64 value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramUniformui64vNV(uint program, int location, int count, UInt64* value);

        #endregion GL_NV_shader_buffer_load

        #region GL_NV_shading_rate_image

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindShadingRateImageNV(uint texture);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetShadingRateImagePaletteNV(uint viewport, uint entry, uint* rate);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetShadingRateSampleLocationivNV(uint rate, uint samples, uint index, int* location);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglShadingRateImageBarrierNV(bool synchronize);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglShadingRateImagePaletteNV(uint viewport, uint first, int count, uint* rates);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglShadingRateSampleOrderNV(uint order);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglShadingRateSampleOrderCustomNV(uint rate, uint samples, int* locations);

        #endregion GL_NV_shading_rate_image

        #region GL_NV_texture_barrier

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureBarrierNV();

        #endregion GL_NV_texture_barrier

        #region GL_NV_texture_multisample

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexImage2DMultisampleCoverageNV(uint target, int coverageSamples, int colorSamples, int publicFormat, int width, int height, bool fixedSampleLocations);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexImage3DMultisampleCoverageNV(uint target, int coverageSamples, int colorSamples, int publicFormat, int width, int height, int depth, bool fixedSampleLocations);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureImage2DMultisampleNV(uint texture, uint target, int samples, int publicFormat, int width, int height, bool fixedSampleLocations);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureImage3DMultisampleNV(uint texture, uint target, int samples, int publicFormat, int width, int height, int depth, bool fixedSampleLocations);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureImage2DMultisampleCoverageNV(uint texture, uint target, int coverageSamples, int colorSamples, int publicFormat, int width, int height, bool fixedSampleLocations);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureImage3DMultisampleCoverageNV(uint texture, uint target, int coverageSamples, int colorSamples, int publicFormat, int width, int height, int depth, bool fixedSampleLocations);

        #endregion GL_NV_texture_multisample

        #region GL_NV_transform_feedback

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBeginTransformFeedbackNV(uint primitiveMode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEndTransformFeedbackNV();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTransformFeedbackAttribsNV(int count, int* attribs, uint bufferMode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindBufferRangeNV(uint target, uint index, uint buffer, IntPtr offset, IntPtr size);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindBufferOffsetNV(uint target, uint index, uint buffer, IntPtr offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindBufferBaseNV(uint target, uint index, uint buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTransformFeedbackVaryingsNV(uint program, int count, int* locations, uint bufferMode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglActiveVaryingNV(uint program, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int FNglGetVaryingLocationNV(uint program, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetActiveVaryingNV(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTransformFeedbackVaryingNV(uint program, uint index, int* location);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTransformFeedbackStreamAttribsNV(int count, int* attribs, int nbuffers, int* bufstreams, uint bufferMode);

        #endregion GL_NV_transform_feedback

        #region GL_NV_transform_feedback2

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindTransformFeedbackNV(uint target, uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteTransformFeedbacksNV(int n, uint* ids);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenTransformFeedbacksNV(int n, uint* ids);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsTransformFeedbackNV(uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPauseTransformFeedbackNV();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglResumeTransformFeedbackNV();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawTransformFeedbackNV(uint mode, uint id);

        #endregion GL_NV_transform_feedback2

        #region GL_NV_vdpau_interop

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVDPAUInitNV(void* vdpDevice, void* getProcAddress);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVDPAUFiniNV();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate IntPtr FNglVDPAURegisterVideoSurfaceNV(void* vdpSurface, uint target, int numTextureNames, uint* textureNames);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate IntPtr FNglVDPAURegisterOutputSurfaceNV(void* vdpSurface, uint target, int numTextureNames, uint* textureNames);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglVDPAUIsSurfaceNV(IntPtr surface);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVDPAUUnregisterSurfaceNV(IntPtr surface);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVDPAUGetSurfaceivNV(IntPtr surface, uint pname, int count, int* length, int* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVDPAUSurfaceAccessNV(IntPtr surface, uint access);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVDPAUMapSurfacesNV(int numSurfaces, IntPtr surfaces);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVDPAUUnmapSurfacesNV(int numSurface, IntPtr surfaces);

        #endregion GL_NV_vdpau_interop

        #region GL_NV_vdpau_interop2

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate IntPtr FNglVDPAURegisterVideoSurfaceWithPictureStructureNV(void* vdpSurface, uint target, int numTextureNames, uint* textureNames, bool isFrameStructure);

        #endregion GL_NV_vdpau_interop2

        #region GL_NV_vertex_array_range

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFlushVertexArrayRangeNV();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexArrayRangeNV(int length, void* pointer);

        #endregion GL_NV_vertex_array_range

        #region GL_NV_vertex_attrib_integer_64bit

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribL1i64NV(uint index, Int64 x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribL2i64NV(uint index, Int64 x, Int64 y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribL3i64NV(uint index, Int64 x, Int64 y, Int64 z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribL4i64NV(uint index, Int64 x, Int64 y, Int64 z, Int64 w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribL1i64vNV(uint index, Int64* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribL2i64vNV(uint index, Int64* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribL3i64vNV(uint index, Int64* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribL4i64vNV(uint index, Int64* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribL1ui64NV(uint index, UInt64 x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribL2ui64NV(uint index, UInt64 x, UInt64 y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribL3ui64NV(uint index, UInt64 x, UInt64 y, UInt64 z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribL4ui64NV(uint index, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribL1ui64vNV(uint index, UInt64* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribL2ui64vNV(uint index, UInt64* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribL3ui64vNV(uint index, UInt64* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribL4ui64vNV(uint index, UInt64* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribLi64vNV(uint index, uint pname, Int64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribLui64vNV(uint index, uint pname, UInt64* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribLFormatNV(uint index, int size, uint type, int stride);

        #endregion GL_NV_vertex_attrib_integer_64bit

        #region GL_NV_vertex_buffer_unified_memory

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBufferAddressRangeNV(uint pname, uint index, UInt64 address, IntPtr length);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexFormatNV(int size, uint type, int stride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNormalFormatNV(uint type, int stride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColorFormatNV(int size, uint type, int stride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglIndexFormatNV(uint type, int stride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoordFormatNV(int size, uint type, int stride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEdgeFlagFormatNV(int stride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSecondaryColorFormatNV(int size, uint type, int stride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFogCoordFormatNV(uint type, int stride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribFormatNV(uint index, int size, uint type, bool normalized, int stride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttribIFormatNV(uint index, int size, uint type, int stride);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetIntegerui64i_vNV(uint value, uint index, UInt64* result);

        #endregion GL_NV_vertex_buffer_unified_memory

        #region GL_NV_vertex_program

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate bool FNglAreProgramsResidentNV(int n, uint* programs, bool* residences);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindProgramNV(uint target, uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeleteProgramsNV(int n, uint* programs);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglExecuteProgramNV(uint target, uint id, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGenProgramsNV(int n, uint* programs);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramParameterdvNV(uint target, uint index, uint pname, double* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramParameterfvNV(uint target, uint index, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramivNV(uint id, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetProgramStringNV(uint id, uint pname, byte* program);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTrackMatrixivNV(uint target, uint address, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribdvNV(uint index, uint pname, double* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribfvNV(uint index, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribivNV(uint index, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVertexAttribPointervNV(uint index, uint pname, void** pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsProgramNV(uint id);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglLoadProgramNV(uint target, uint id, int len, byte* program);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramParameter4dNV(uint target, uint index, double x, double y, double z, double w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramParameter4dvNV(uint target, uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglProgramParameter4fNV(uint target, uint index, float x, float y, float z, float w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramParameter4fvNV(uint target, uint index, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramParameters4dvNV(uint target, uint index, int count, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglProgramParameters4fvNV(uint target, uint index, int count, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRequestResidentProgramsNV(int n, uint* programs);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTrackMatrixNV(uint target, uint address, uint matrix, uint transform);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribPointerNV(uint index, int fsize, uint type, int stride, void* pointer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib1dNV(uint index, double x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib1dvNV(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib1fNV(uint index, float x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib1fvNV(uint index, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib1sNV(uint index, short x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib1svNV(uint index, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib2dNV(uint index, double x, double y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib2dvNV(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib2fNV(uint index, float x, float y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib2fvNV(uint index, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib2sNV(uint index, short x, short y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib2svNV(uint index, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib3dNV(uint index, double x, double y, double z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib3dvNV(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib3fNV(uint index, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib3fvNV(uint index, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib3sNV(uint index, short x, short y, short z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib3svNV(uint index, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib4dNV(uint index, double x, double y, double z, double w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4dvNV(uint index, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib4fNV(uint index, float x, float y, float z, float w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4fvNV(uint index, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib4sNV(uint index, short x, short y, short z, short w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4svNV(uint index, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertexAttrib4ubNV(uint index, byte x, byte y, byte z, byte w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttrib4ubvNV(uint index, byte* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribs1dvNV(uint index, int count, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribs1fvNV(uint index, int count, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribs1svNV(uint index, int count, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribs2dvNV(uint index, int count, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribs2fvNV(uint index, int count, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribs2svNV(uint index, int count, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribs3dvNV(uint index, int count, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribs3fvNV(uint index, int count, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribs3svNV(uint index, int count, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribs4dvNV(uint index, int count, double* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribs4fvNV(uint index, int count, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribs4svNV(uint index, int count, short* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertexAttribs4ubvNV(uint index, int count, byte* v);

        #endregion GL_NV_vertex_program

        #region GL_NV_vertex_program4

        // public delegate void FNglVertexAttribI1iEXT(uint index,int x);
        // public delegate void FNglVertexAttribI2iEXT(uint index,int x,int y);
        // public delegate void FNglVertexAttribI3iEXT(uint index,int x,int y,int z);
        // public delegate void FNglVertexAttribI4iEXT(uint index,int x,int y,int z,int w);
        // public delegate void FNglVertexAttribI1uiEXT(uint index,uint x);
        // public delegate void FNglVertexAttribI2uiEXT(uint index,uint x,uint y);
        // public delegate void FNglVertexAttribI3uiEXT(uint index,uint x,uint y,uint z);
        // public delegate void FNglVertexAttribI4uiEXT(uint index,uint x,uint y,uint z,uint w);
        // public unsafe delegate void FNglVertexAttribI1ivEXT(uint index,int* v);
        // public unsafe delegate void FNglVertexAttribI2ivEXT(uint index,int* v);
        // public unsafe delegate void FNglVertexAttribI3ivEXT(uint index,int* v);
        // public unsafe delegate void FNglVertexAttribI4ivEXT(uint index,int* v);
        // public unsafe delegate void FNglVertexAttribI1uivEXT(uint index,uint* v);
        // public unsafe delegate void FNglVertexAttribI2uivEXT(uint index,uint* v);
        // public unsafe delegate void FNglVertexAttribI3uivEXT(uint index,uint* v);
        // public unsafe delegate void FNglVertexAttribI4uivEXT(uint index,uint* v);
        // public unsafe delegate void FNglVertexAttribI4bvEXT(uint index,byte* v);
        // public unsafe delegate void FNglVertexAttribI4svEXT(uint index,short* v);
        // public unsafe delegate void FNglVertexAttribI4ubvEXT(uint index,byte* v);
        // public unsafe delegate void FNglVertexAttribI4usvEXT(uint index,ushort* v);
        // public unsafe delegate void FNglVertexAttribIPointerEXT(uint index,int size,uint type,int stride,void* pointer);
        // public unsafe delegate void FNglGetVertexAttribIivEXT(uint index,uint pname,int* ps);
        // public unsafe delegate void FNglGetVertexAttribIuivEXT(uint index,uint pname,uint* ps);

        #endregion GL_NV_vertex_program4

        #region GL_NV_video_capture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBeginVideoCaptureNV(uint video_capture_slot);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindVideoCaptureStreamBufferNV(uint video_capture_slot, uint stream, uint frame_region, IntPtr offset);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBindVideoCaptureStreamTextureNV(uint video_capture_slot, uint stream, uint frame_region, uint target, uint texture);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEndVideoCaptureNV(uint video_capture_slot);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVideoCaptureivNV(uint video_capture_slot, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVideoCaptureStreamivNV(uint video_capture_slot, uint stream, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVideoCaptureStreamfvNV(uint video_capture_slot, uint stream, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetVideoCaptureStreamdvNV(uint video_capture_slot, uint stream, uint pname, double* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglVideoCaptureNV(uint video_capture_slot, uint* sequence_num, UInt64* capture_time);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVideoCaptureStreamParameterivNV(uint video_capture_slot, uint stream, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVideoCaptureStreamParameterfvNV(uint video_capture_slot, uint stream, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVideoCaptureStreamParameterdvNV(uint video_capture_slot, uint stream, uint pname, double* ps);

        #endregion GL_NV_video_capture

        #region GL_NV_viewport_swizzle

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglViewportSwizzleNV(uint index, uint swizzlex, uint swizzley, uint swizzlez, uint swizzlew);

        #endregion GL_NV_viewport_swizzle

        #region GL_OES_fixed_point

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglAlphaFuncxOES(uint func, int r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClearColorxOES(int red, int green, int blue, int alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClearDepthxOES(int depth);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglClipPlanexOES(uint plane, int* equation);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor4xOES(int red, int green, int blue, int alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDepthRangexOES(int n, int f);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFogxOES(uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFogxvOES(uint pname, int* param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFrustumxOES(int l, int r, int b, int t, int n, int f);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetClipPlanexOES(uint plane, int* equation);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetFixedvOES(uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexEnvxvOES(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexParameterxvOES(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLightModelxOES(uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglLightModelxvOES(uint pname, int* param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLightxOES(uint light, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglLightxvOES(uint light, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLineWidthxOES(int width);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglLoadMatrixxOES(int* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMaterialxOES(uint face, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMaterialxvOES(uint face, uint pname, int* param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultMatrixxOES(int* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord4xOES(uint texture, int s, int t, int r, int q);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNormal3xOES(int nx, int ny, int nz);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglOrthoxOES(int l, int r, int b, int t, int n, int f);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPointParameterxvOES(uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPointSizexOES(int size);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPolygonOffsetxOES(int factor, int units);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRotatexOES(int angle, int x, int y, int z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglScalexOES(int x, int y, int z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexEnvxOES(uint target, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexEnvxvOES(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexParameterxOES(uint target, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexParameterxvOES(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTranslatexOES(int x, int y, int z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetLightxvOES(uint light, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMaterialxvOES(uint face, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPointParameterxOES(uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSampleCoveragexOES(Int32 value, bool invert);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglAccumxOES(uint op, int value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglBitmapxOES(int width, int height, int xorig, int yorig, int xmove, int ymove, byte* bitmap);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglBlendColorxOES(int red, int green, int blue, int alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClearAccumxOES(int red, int green, int blue, int alpha);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor3xOES(int red, int green, int blue);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor3xvOES(int* components);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor4xvOES(int* components);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglConvolutionParameterxOES(uint target, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglConvolutionParameterxvOES(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEvalCoord1xOES(int u);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglEvalCoord1xvOES(int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglEvalCoord2xOES(int u, int v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglEvalCoord2xvOES(int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFeedbackBufferxOES(int n, uint type, int* buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetConvolutionParameterxvOES(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetHistogramParameterxvOES(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetLightxOES(uint light, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetMapxvOES(uint target, uint query, int* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglGetMaterialxOES(uint face, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPixelMapxv(uint map, int size, int* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexGenxvOES(uint coord, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexLevelParameterxvOES(uint target, int level, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglIndexxOES(int component);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglIndexxvOES(int* component);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglLoadTransposeMatrixxOES(int* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMap1xOES(uint target, int u1, int u2, int stride, int order, int points);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMap2xOES(uint target, int u1, int u2, int ustride, int uorder, int v1, int v2, int vstride, int vorder, int points);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMapGrid1xOES(int n, int u1, int u2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMapGrid2xOES(int n, int u1, int u2, int v1, int v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultTransposeMatrixxOES(int* m);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord1xOES(uint texture, int s);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord1xvOES(uint texture, int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord2xOES(uint texture, int s, int t);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord2xvOES(uint texture, int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglMultiTexCoord3xOES(uint texture, int s, int t, int r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord3xvOES(uint texture, int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglMultiTexCoord4xvOES(uint texture, int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormal3xvOES(int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPassThroughxOES(int token);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPixelMapx(uint map, int size, int* values);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPixelStorex(uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPixelTransferxOES(uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPixelZoomxOES(int xfactor, int yfactor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPrioritizeTexturesxOES(int n, uint* textures, int* priorities);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRasterPos2xOES(int x, int y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRasterPos2xvOES(int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRasterPos3xOES(int x, int y, int z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRasterPos3xvOES(int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRasterPos4xOES(int x, int y, int z, int w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRasterPos4xvOES(int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglRectxOES(int x1, int y1, int x2, int y2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglRectxvOES(int* v1, int* v2);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord1xOES(int s);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord1xvOES(int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord2xOES(int s, int t);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord2xvOES(int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord3xOES(int s, int t, int r);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord3xvOES(int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord4xOES(int s, int t, int r, int q);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord4xvOES(int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexGenxOES(uint coord, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexGenxvOES(uint coord, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex2xOES(int x);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex2xvOES(int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex3xOES(int x, int y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex3xvOES(int* coords);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglVertex4xOES(int x, int y, int z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglVertex4xvOES(int* coords);

        #endregion GL_OES_fixed_point

        #region GL_OES_query_matrix

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate uint FNglQueryMatrixxOES(int* mantissa, int* exponent);

        #endregion GL_OES_query_matrix

        #region GL_OES_single_precision

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglClearDepthfOES(float depth);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglClipPlanefOES(uint plane, float* equation);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDepthRangefOES(float n, float f);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFrustumfOES(float l, float r, float b, float t, float n, float f);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetClipPlanefOES(uint plane, float* equation);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglOrthofOES(float l, float r, float b, float t, float n, float f);

        #endregion GL_OES_single_precision

        #region GL_OVR_multiview

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFramebufferTextureMultiviewOVR(uint target, uint attachment, uint texture, int level, int baseViewIndex, int numViews);

        #endregion GL_OVR_multiview

        #region GL_PGI_misc_hints

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglHintPGI(uint target, int mode);

        #endregion GL_PGI_misc_hints

        #region GL_SGIS_detail_texture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDetailTexFuncSGIS(uint target, int n, float* points);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetDetailTexFuncSGIS(uint target, float* points);

        #endregion GL_SGIS_detail_texture

        #region GL_SGIS_fog_function

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFogFuncSGIS(int n, float* points);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetFogFuncSGIS(float* points);

        #endregion GL_SGIS_fog_function

        #region GL_SGIS_multisample

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSampleMaskSGIS(float value, bool invert);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSamplePatternSGIS(uint pattern);

        #endregion GL_SGIS_multisample

        #region GL_SGIS_pixel_texture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPixelTexGenParameteriSGIS(uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPixelTexGenParameterivSGIS(uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPixelTexGenParameterfSGIS(uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPixelTexGenParameterfvSGIS(uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPixelTexGenParameterivSGIS(uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetPixelTexGenParameterfvSGIS(uint pname, float* ps);

        #endregion GL_SGIS_pixel_texture

        #region GL_SGIS_point_parameters

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPointParameterfSGIS(uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglPointParameterfvSGIS(uint pname, float* ps);

        #endregion GL_SGIS_point_parameters

        #region GL_SGIS_sharpen_texture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSharpenTexFuncSGIS(uint target, int n, float* points);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetSharpenTexFuncSGIS(uint target, float* points);

        #endregion GL_SGIS_sharpen_texture

        #region GL_SGIS_texture4D

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexImage4DSGIS(uint target, int level, uint publicformat, int width, int height, int depth, int size4d, int border, uint format, uint type, void* pixels);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexSubImage4DSGIS(uint target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, uint format, uint type, void* pixels);

        #endregion GL_SGIS_texture4D

        #region GL_SGIS_texture_color_mask

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTextureColorMaskSGIS(bool red, bool green, bool blue, bool alpha);

        #endregion GL_SGIS_texture_color_mask

        #region GL_SGIS_texture_filter4

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetTexFilterFuncSGIS(uint target, uint filter, float* weights);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexFilterFuncSGIS(uint target, uint filter, int n, float* weights);

        #endregion GL_SGIS_texture_filter4

        #region GL_SGIX_async

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglAsyncMarkerSGIX(uint marker);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int FNglFinishAsyncSGIX(uint* markerp);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int FNglPollAsyncSGIX(uint* markerp);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint FNglGenAsyncMarkersSGIX(int range);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDeleteAsyncMarkersSGIX(uint marker, int range);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool FNglIsAsyncMarkerSGIX(uint marker);

        #endregion GL_SGIX_async

        #region GL_SGIX_flush_raster

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFlushRasterSGIX();

        #endregion GL_SGIX_flush_raster

        #region GL_SGIX_fragment_lighting

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFragmentColorMaterialSGIX(uint face, uint mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFragmentLightfSGIX(uint light, uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFragmentLightfvSGIX(uint light, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFragmentLightiSGIX(uint light, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFragmentLightivSGIX(uint light, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFragmentLightModelfSGIX(uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFragmentLightModelfvSGIX(uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFragmentLightModeliSGIX(uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFragmentLightModelivSGIX(uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFragmentMaterialfSGIX(uint face, uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFragmentMaterialfvSGIX(uint face, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFragmentMaterialiSGIX(uint face, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglFragmentMaterialivSGIX(uint face, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetFragmentLightfvSGIX(uint light, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetFragmentLightivSGIX(uint light, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetFragmentMaterialfvSGIX(uint face, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetFragmentMaterialivSGIX(uint face, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLightEnviSGIX(uint pname, int param);

        #endregion GL_SGIX_fragment_lighting

        #region GL_SGIX_framezoom

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFrameZoomSGIX(int factor);

        #endregion GL_SGIX_framezoom

        #region GL_SGIX_igloo_interface

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglIglooInterfaceSGIX(uint pname, void* ps);

        #endregion GL_SGIX_igloo_interface

        #region GL_SGIX_instruments

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int FNglGetInstrumentsSGIX();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglInstrumentsBufferSGIX(int size, int* buffer);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int FNglPollInstrumentsSGIX(int* marker_p);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglReadInstrumentsSGIX(int marker);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglStartInstrumentsSGIX();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglStopInstrumentsSGIX(int marker);

        #endregion GL_SGIX_instruments

        #region GL_SGIX_list_priority

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetListParameterfvSGIX(uint list, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetListParameterivSGIX(uint list, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglListParameterfSGIX(uint list, uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglListParameterfvSGIX(uint list, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglListParameteriSGIX(uint list, uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglListParameterivSGIX(uint list, uint pname, int* ps);

        #endregion GL_SGIX_list_priority

        #region GL_SGIX_pixel_texture

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglPixelTexGenSGIX(uint mode);

        #endregion GL_SGIX_pixel_texture

        #region GL_SGIX_polynomial_ffd

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeformationMap3dSGIX(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double* points);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglDeformationMap3fSGIX(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float* points);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDeformSGIX(uint mask);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglLoadIdentityDeformationMapSGIX(uint mask);

        #endregion GL_SGIX_polynomial_ffd

        #region GL_SGIX_reference_plane

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglReferencePlaneSGIX(double* equation);

        #endregion GL_SGIX_reference_plane

        #region GL_SGIX_sprite

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSpriteParameterfSGIX(uint pname, float param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSpriteParameterfvSGIX(uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglSpriteParameteriSGIX(uint pname, int param);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglSpriteParameterivSGIX(uint pname, int* ps);

        #endregion GL_SGIX_sprite

        #region GL_SGIX_tag_sample_buffer

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTagSampleBufferSGIX();

        #endregion GL_SGIX_tag_sample_buffer

        #region GL_SGI_color_table

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColorTableSGI(uint target, uint publicformat, int width, uint format, uint type, void* table);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColorTableParameterfvSGI(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColorTableParameterivSGI(uint target, uint pname, int* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglCopyColorTableSGI(uint target, uint publicformat, int x, int y, int width);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetColorTableSGI(uint target, uint format, uint type, void* table);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetColorTableParameterfvSGI(uint target, uint pname, float* ps);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglGetColorTableParameterivSGI(uint target, uint pname, int* ps);

        #endregion GL_SGI_color_table

        #region GL_SUNX_constant_data

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglFinishTextureSUNX();

        #endregion GL_SUNX_constant_data

        #region GL_SUN_global_alpha

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglGlobalAlphaFactorbSUN(byte factor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglGlobalAlphaFactorsSUN(short factor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglGlobalAlphaFactoriSUN(int factor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglGlobalAlphaFactorfSUN(float factor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglGlobalAlphaFactordSUN(double factor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglGlobalAlphaFactorubSUN(byte factor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglGlobalAlphaFactorusSUN(ushort factor);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglGlobalAlphaFactoruiSUN(uint factor);

        #endregion GL_SUN_global_alpha

        #region GL_SUN_mesh_array

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglDrawMeshArraysSUN(uint mode, int first, int count, int width);

        #endregion GL_SUN_mesh_array

        #region GL_SUN_triangle_list

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglReplacementCodeuiSUN(uint code);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglReplacementCodeusSUN(ushort code);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglReplacementCodeubSUN(byte code);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglReplacementCodeuivSUN(uint* code);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglReplacementCodeusvSUN(ushort* code);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglReplacementCodeubvSUN(byte* code);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglReplacementCodePointerSUN(uint type, int stride, void** pointer);

        #endregion GL_SUN_triangle_list

        #region GL_SUN_vertex

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor4ubVertex2fSUN(byte r, byte g, byte b, byte a, float x, float y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor4ubVertex2fvSUN(byte* c, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor4ubVertex3fSUN(byte r, byte g, byte b, byte a, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor4ubVertex3fvSUN(byte* c, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor3fVertex3fSUN(float r, float g, float b, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor3fVertex3fvSUN(float* c, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglNormal3fVertex3fSUN(float nx, float ny, float nz, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglNormal3fVertex3fvSUN(float* n, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglColor4fNormal3fVertex3fSUN(float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglColor4fNormal3fVertex3fvSUN(float* c, float* n, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord2fVertex3fSUN(float s, float t, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord2fVertex3fvSUN(float* tc, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord4fVertex4fSUN(float s, float t, float p, float q, float x, float y, float z, float w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord4fVertex4fvSUN(float* tc, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord2fColor4ubVertex3fSUN(float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord2fColor4ubVertex3fvSUN(float* tc, byte* c, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord2fColor3fVertex3fSUN(float s, float t, float r, float g, float b, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord2fColor3fVertex3fvSUN(float* tc, float* c, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord2fNormal3fVertex3fSUN(float s, float t, float nx, float ny, float nz, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord2fNormal3fVertex3fvSUN(float* tc, float* n, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord2fColor4fNormal3fVertex3fSUN(float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord2fColor4fNormal3fVertex3fvSUN(float* tc, float* c, float* n, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglTexCoord4fColor4fNormal3fVertex4fSUN(float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglTexCoord4fColor4fNormal3fVertex4fvSUN(float* tc, float* c, float* n, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglReplacementCodeuiVertex3fSUN(uint rc, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglReplacementCodeuiVertex3fvSUN(uint* rc, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglReplacementCodeuiColor4ubVertex3fSUN(uint rc, byte r, byte g, byte b, byte a, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglReplacementCodeuiColor4ubVertex3fvSUN(uint* rc, byte* c, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglReplacementCodeuiColor3fVertex3fSUN(uint rc, float r, float g, float b, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglReplacementCodeuiColor3fVertex3fvSUN(uint* rc, float* c, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglReplacementCodeuiNormal3fVertex3fSUN(uint rc, float nx, float ny, float nz, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglReplacementCodeuiNormal3fVertex3fvSUN(uint* rc, float* n, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglReplacementCodeuiColor4fNormal3fVertex3fSUN(uint rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglReplacementCodeuiColor4fNormal3fVertex3fvSUN(uint* rc, float* c, float* n, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglReplacementCodeuiTexCoord2fVertex3fSUN(uint rc, float s, float t, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglReplacementCodeuiTexCoord2fVertex3fvSUN(uint* rc, float* tc, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(uint rc, float s, float t, float nx, float ny, float nz, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(uint* rc, float* tc, float* n, float* v);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FNglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(uint rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void FNglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(uint* rc, float* tc, float* c, float* n, float* v);

        #endregion GL_SUN_vertex

    }
}
