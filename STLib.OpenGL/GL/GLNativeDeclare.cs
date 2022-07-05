using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL
{
    internal class GLNativeDeclare
    {

        /**********************************************************************************
         * Note: These codes are automatically created from OpenGL's documentation.
         *       If there is something wrong, it must be because the author is too stupid.
         * Link: https://github.com/KhronosGroup/OpenGL-Registry/xml/gl.xml
         **********************************************************************************/

        internal struct ProcInfo
        {
            public string Name;
            public Type Type;

            public ProcInfo(string strName, Type t) {
                this.Name = strName;
                this.Type = t;
            }
        }

        internal static IEnumerable<ProcInfo> GetAllProcInfos() {

            #region GL_VERSION_1_0

            yield return new ProcInfo("glCullFace", typeof(GLNativeDelegate.FNglCullFace));
            yield return new ProcInfo("glFrontFace", typeof(GLNativeDelegate.FNglFrontFace));
            yield return new ProcInfo("glHint", typeof(GLNativeDelegate.FNglHint));
            yield return new ProcInfo("glLineWidth", typeof(GLNativeDelegate.FNglLineWidth));
            yield return new ProcInfo("glPointSize", typeof(GLNativeDelegate.FNglPointSize));
            yield return new ProcInfo("glPolygonMode", typeof(GLNativeDelegate.FNglPolygonMode));
            yield return new ProcInfo("glScissor", typeof(GLNativeDelegate.FNglScissor));
            yield return new ProcInfo("glTexParameterf", typeof(GLNativeDelegate.FNglTexParameterf));
            yield return new ProcInfo("glTexParameterfv", typeof(GLNativeDelegate.FNglTexParameterfv));
            yield return new ProcInfo("glTexParameteri", typeof(GLNativeDelegate.FNglTexParameteri));
            yield return new ProcInfo("glTexParameteriv", typeof(GLNativeDelegate.FNglTexParameteriv));
            yield return new ProcInfo("glTexImage1D", typeof(GLNativeDelegate.FNglTexImage1D));
            yield return new ProcInfo("glTexImage2D", typeof(GLNativeDelegate.FNglTexImage2D));
            yield return new ProcInfo("glDrawBuffer", typeof(GLNativeDelegate.FNglDrawBuffer));
            yield return new ProcInfo("glClear", typeof(GLNativeDelegate.FNglClear));
            yield return new ProcInfo("glClearColor", typeof(GLNativeDelegate.FNglClearColor));
            yield return new ProcInfo("glClearStencil", typeof(GLNativeDelegate.FNglClearStencil));
            yield return new ProcInfo("glClearDepth", typeof(GLNativeDelegate.FNglClearDepth));
            yield return new ProcInfo("glStencilMask", typeof(GLNativeDelegate.FNglStencilMask));
            yield return new ProcInfo("glColorMask", typeof(GLNativeDelegate.FNglColorMask));
            yield return new ProcInfo("glDepthMask", typeof(GLNativeDelegate.FNglDepthMask));
            yield return new ProcInfo("glDisable", typeof(GLNativeDelegate.FNglDisable));
            yield return new ProcInfo("glEnable", typeof(GLNativeDelegate.FNglEnable));
            yield return new ProcInfo("glFinish", typeof(GLNativeDelegate.FNglFinish));
            yield return new ProcInfo("glFlush", typeof(GLNativeDelegate.FNglFlush));
            yield return new ProcInfo("glBlendFunc", typeof(GLNativeDelegate.FNglBlendFunc));
            yield return new ProcInfo("glLogicOp", typeof(GLNativeDelegate.FNglLogicOp));
            yield return new ProcInfo("glStencilFunc", typeof(GLNativeDelegate.FNglStencilFunc));
            yield return new ProcInfo("glStencilOp", typeof(GLNativeDelegate.FNglStencilOp));
            yield return new ProcInfo("glDepthFunc", typeof(GLNativeDelegate.FNglDepthFunc));
            yield return new ProcInfo("glPixelStoref", typeof(GLNativeDelegate.FNglPixelStoref));
            yield return new ProcInfo("glPixelStorei", typeof(GLNativeDelegate.FNglPixelStorei));
            yield return new ProcInfo("glReadBuffer", typeof(GLNativeDelegate.FNglReadBuffer));
            yield return new ProcInfo("glReadPixels", typeof(GLNativeDelegate.FNglReadPixels));
            yield return new ProcInfo("glGetBooleanv", typeof(GLNativeDelegate.FNglGetBooleanv));
            yield return new ProcInfo("glGetDoublev", typeof(GLNativeDelegate.FNglGetDoublev));
            yield return new ProcInfo("glGetError", typeof(GLNativeDelegate.FNglGetError));
            yield return new ProcInfo("glGetFloatv", typeof(GLNativeDelegate.FNglGetFloatv));
            yield return new ProcInfo("glGetIntegerv", typeof(GLNativeDelegate.FNglGetIntegerv));
            yield return new ProcInfo("glGetString", typeof(GLNativeDelegate.FNglGetString));
            yield return new ProcInfo("glGetTexImage", typeof(GLNativeDelegate.FNglGetTexImage));
            yield return new ProcInfo("glGetTexParameterfv", typeof(GLNativeDelegate.FNglGetTexParameterfv));
            yield return new ProcInfo("glGetTexParameteriv", typeof(GLNativeDelegate.FNglGetTexParameteriv));
            yield return new ProcInfo("glGetTexLevelParameterfv", typeof(GLNativeDelegate.FNglGetTexLevelParameterfv));
            yield return new ProcInfo("glGetTexLevelParameteriv", typeof(GLNativeDelegate.FNglGetTexLevelParameteriv));
            yield return new ProcInfo("glIsEnabled", typeof(GLNativeDelegate.FNglIsEnabled));
            yield return new ProcInfo("glDepthRange", typeof(GLNativeDelegate.FNglDepthRange));
            yield return new ProcInfo("glViewport", typeof(GLNativeDelegate.FNglViewport));
            yield return new ProcInfo("glNewList", typeof(GLNativeDelegate.FNglNewList));
            yield return new ProcInfo("glEndList", typeof(GLNativeDelegate.FNglEndList));
            yield return new ProcInfo("glCallList", typeof(GLNativeDelegate.FNglCallList));
            yield return new ProcInfo("glCallLists", typeof(GLNativeDelegate.FNglCallLists));
            yield return new ProcInfo("glDeleteLists", typeof(GLNativeDelegate.FNglDeleteLists));
            yield return new ProcInfo("glGenLists", typeof(GLNativeDelegate.FNglGenLists));
            yield return new ProcInfo("glListBase", typeof(GLNativeDelegate.FNglListBase));
            yield return new ProcInfo("glBegin", typeof(GLNativeDelegate.FNglBegin));
            yield return new ProcInfo("glBitmap", typeof(GLNativeDelegate.FNglBitmap));
            yield return new ProcInfo("glColor3b", typeof(GLNativeDelegate.FNglColor3b));
            yield return new ProcInfo("glColor3bv", typeof(GLNativeDelegate.FNglColor3bv));
            yield return new ProcInfo("glColor3d", typeof(GLNativeDelegate.FNglColor3d));
            yield return new ProcInfo("glColor3dv", typeof(GLNativeDelegate.FNglColor3dv));
            yield return new ProcInfo("glColor3f", typeof(GLNativeDelegate.FNglColor3f));
            yield return new ProcInfo("glColor3fv", typeof(GLNativeDelegate.FNglColor3fv));
            yield return new ProcInfo("glColor3i", typeof(GLNativeDelegate.FNglColor3i));
            yield return new ProcInfo("glColor3iv", typeof(GLNativeDelegate.FNglColor3iv));
            yield return new ProcInfo("glColor3s", typeof(GLNativeDelegate.FNglColor3s));
            yield return new ProcInfo("glColor3sv", typeof(GLNativeDelegate.FNglColor3sv));
            yield return new ProcInfo("glColor3ub", typeof(GLNativeDelegate.FNglColor3ub));
            yield return new ProcInfo("glColor3ubv", typeof(GLNativeDelegate.FNglColor3ubv));
            yield return new ProcInfo("glColor3ui", typeof(GLNativeDelegate.FNglColor3ui));
            yield return new ProcInfo("glColor3uiv", typeof(GLNativeDelegate.FNglColor3uiv));
            yield return new ProcInfo("glColor3us", typeof(GLNativeDelegate.FNglColor3us));
            yield return new ProcInfo("glColor3usv", typeof(GLNativeDelegate.FNglColor3usv));
            yield return new ProcInfo("glColor4b", typeof(GLNativeDelegate.FNglColor4b));
            yield return new ProcInfo("glColor4bv", typeof(GLNativeDelegate.FNglColor4bv));
            yield return new ProcInfo("glColor4d", typeof(GLNativeDelegate.FNglColor4d));
            yield return new ProcInfo("glColor4dv", typeof(GLNativeDelegate.FNglColor4dv));
            yield return new ProcInfo("glColor4f", typeof(GLNativeDelegate.FNglColor4f));
            yield return new ProcInfo("glColor4fv", typeof(GLNativeDelegate.FNglColor4fv));
            yield return new ProcInfo("glColor4i", typeof(GLNativeDelegate.FNglColor4i));
            yield return new ProcInfo("glColor4iv", typeof(GLNativeDelegate.FNglColor4iv));
            yield return new ProcInfo("glColor4s", typeof(GLNativeDelegate.FNglColor4s));
            yield return new ProcInfo("glColor4sv", typeof(GLNativeDelegate.FNglColor4sv));
            yield return new ProcInfo("glColor4ub", typeof(GLNativeDelegate.FNglColor4ub));
            yield return new ProcInfo("glColor4ubv", typeof(GLNativeDelegate.FNglColor4ubv));
            yield return new ProcInfo("glColor4ui", typeof(GLNativeDelegate.FNglColor4ui));
            yield return new ProcInfo("glColor4uiv", typeof(GLNativeDelegate.FNglColor4uiv));
            yield return new ProcInfo("glColor4us", typeof(GLNativeDelegate.FNglColor4us));
            yield return new ProcInfo("glColor4usv", typeof(GLNativeDelegate.FNglColor4usv));
            yield return new ProcInfo("glEdgeFlag", typeof(GLNativeDelegate.FNglEdgeFlag));
            yield return new ProcInfo("glEdgeFlagv", typeof(GLNativeDelegate.FNglEdgeFlagv));
            yield return new ProcInfo("glEnd", typeof(GLNativeDelegate.FNglEnd));
            yield return new ProcInfo("glIndexd", typeof(GLNativeDelegate.FNglIndexd));
            yield return new ProcInfo("glIndexdv", typeof(GLNativeDelegate.FNglIndexdv));
            yield return new ProcInfo("glIndexf", typeof(GLNativeDelegate.FNglIndexf));
            yield return new ProcInfo("glIndexfv", typeof(GLNativeDelegate.FNglIndexfv));
            yield return new ProcInfo("glIndexi", typeof(GLNativeDelegate.FNglIndexi));
            yield return new ProcInfo("glIndexiv", typeof(GLNativeDelegate.FNglIndexiv));
            yield return new ProcInfo("glIndexs", typeof(GLNativeDelegate.FNglIndexs));
            yield return new ProcInfo("glIndexsv", typeof(GLNativeDelegate.FNglIndexsv));
            yield return new ProcInfo("glNormal3b", typeof(GLNativeDelegate.FNglNormal3b));
            yield return new ProcInfo("glNormal3bv", typeof(GLNativeDelegate.FNglNormal3bv));
            yield return new ProcInfo("glNormal3d", typeof(GLNativeDelegate.FNglNormal3d));
            yield return new ProcInfo("glNormal3dv", typeof(GLNativeDelegate.FNglNormal3dv));
            yield return new ProcInfo("glNormal3f", typeof(GLNativeDelegate.FNglNormal3f));
            yield return new ProcInfo("glNormal3fv", typeof(GLNativeDelegate.FNglNormal3fv));
            yield return new ProcInfo("glNormal3i", typeof(GLNativeDelegate.FNglNormal3i));
            yield return new ProcInfo("glNormal3iv", typeof(GLNativeDelegate.FNglNormal3iv));
            yield return new ProcInfo("glNormal3s", typeof(GLNativeDelegate.FNglNormal3s));
            yield return new ProcInfo("glNormal3sv", typeof(GLNativeDelegate.FNglNormal3sv));
            yield return new ProcInfo("glRasterPos2d", typeof(GLNativeDelegate.FNglRasterPos2d));
            yield return new ProcInfo("glRasterPos2dv", typeof(GLNativeDelegate.FNglRasterPos2dv));
            yield return new ProcInfo("glRasterPos2f", typeof(GLNativeDelegate.FNglRasterPos2f));
            yield return new ProcInfo("glRasterPos2fv", typeof(GLNativeDelegate.FNglRasterPos2fv));
            yield return new ProcInfo("glRasterPos2i", typeof(GLNativeDelegate.FNglRasterPos2i));
            yield return new ProcInfo("glRasterPos2iv", typeof(GLNativeDelegate.FNglRasterPos2iv));
            yield return new ProcInfo("glRasterPos2s", typeof(GLNativeDelegate.FNglRasterPos2s));
            yield return new ProcInfo("glRasterPos2sv", typeof(GLNativeDelegate.FNglRasterPos2sv));
            yield return new ProcInfo("glRasterPos3d", typeof(GLNativeDelegate.FNglRasterPos3d));
            yield return new ProcInfo("glRasterPos3dv", typeof(GLNativeDelegate.FNglRasterPos3dv));
            yield return new ProcInfo("glRasterPos3f", typeof(GLNativeDelegate.FNglRasterPos3f));
            yield return new ProcInfo("glRasterPos3fv", typeof(GLNativeDelegate.FNglRasterPos3fv));
            yield return new ProcInfo("glRasterPos3i", typeof(GLNativeDelegate.FNglRasterPos3i));
            yield return new ProcInfo("glRasterPos3iv", typeof(GLNativeDelegate.FNglRasterPos3iv));
            yield return new ProcInfo("glRasterPos3s", typeof(GLNativeDelegate.FNglRasterPos3s));
            yield return new ProcInfo("glRasterPos3sv", typeof(GLNativeDelegate.FNglRasterPos3sv));
            yield return new ProcInfo("glRasterPos4d", typeof(GLNativeDelegate.FNglRasterPos4d));
            yield return new ProcInfo("glRasterPos4dv", typeof(GLNativeDelegate.FNglRasterPos4dv));
            yield return new ProcInfo("glRasterPos4f", typeof(GLNativeDelegate.FNglRasterPos4f));
            yield return new ProcInfo("glRasterPos4fv", typeof(GLNativeDelegate.FNglRasterPos4fv));
            yield return new ProcInfo("glRasterPos4i", typeof(GLNativeDelegate.FNglRasterPos4i));
            yield return new ProcInfo("glRasterPos4iv", typeof(GLNativeDelegate.FNglRasterPos4iv));
            yield return new ProcInfo("glRasterPos4s", typeof(GLNativeDelegate.FNglRasterPos4s));
            yield return new ProcInfo("glRasterPos4sv", typeof(GLNativeDelegate.FNglRasterPos4sv));
            yield return new ProcInfo("glRectd", typeof(GLNativeDelegate.FNglRectd));
            yield return new ProcInfo("glRectdv", typeof(GLNativeDelegate.FNglRectdv));
            yield return new ProcInfo("glRectf", typeof(GLNativeDelegate.FNglRectf));
            yield return new ProcInfo("glRectfv", typeof(GLNativeDelegate.FNglRectfv));
            yield return new ProcInfo("glRecti", typeof(GLNativeDelegate.FNglRecti));
            yield return new ProcInfo("glRectiv", typeof(GLNativeDelegate.FNglRectiv));
            yield return new ProcInfo("glRects", typeof(GLNativeDelegate.FNglRects));
            yield return new ProcInfo("glRectsv", typeof(GLNativeDelegate.FNglRectsv));
            yield return new ProcInfo("glTexCoord1d", typeof(GLNativeDelegate.FNglTexCoord1d));
            yield return new ProcInfo("glTexCoord1dv", typeof(GLNativeDelegate.FNglTexCoord1dv));
            yield return new ProcInfo("glTexCoord1f", typeof(GLNativeDelegate.FNglTexCoord1f));
            yield return new ProcInfo("glTexCoord1fv", typeof(GLNativeDelegate.FNglTexCoord1fv));
            yield return new ProcInfo("glTexCoord1i", typeof(GLNativeDelegate.FNglTexCoord1i));
            yield return new ProcInfo("glTexCoord1iv", typeof(GLNativeDelegate.FNglTexCoord1iv));
            yield return new ProcInfo("glTexCoord1s", typeof(GLNativeDelegate.FNglTexCoord1s));
            yield return new ProcInfo("glTexCoord1sv", typeof(GLNativeDelegate.FNglTexCoord1sv));
            yield return new ProcInfo("glTexCoord2d", typeof(GLNativeDelegate.FNglTexCoord2d));
            yield return new ProcInfo("glTexCoord2dv", typeof(GLNativeDelegate.FNglTexCoord2dv));
            yield return new ProcInfo("glTexCoord2f", typeof(GLNativeDelegate.FNglTexCoord2f));
            yield return new ProcInfo("glTexCoord2fv", typeof(GLNativeDelegate.FNglTexCoord2fv));
            yield return new ProcInfo("glTexCoord2i", typeof(GLNativeDelegate.FNglTexCoord2i));
            yield return new ProcInfo("glTexCoord2iv", typeof(GLNativeDelegate.FNglTexCoord2iv));
            yield return new ProcInfo("glTexCoord2s", typeof(GLNativeDelegate.FNglTexCoord2s));
            yield return new ProcInfo("glTexCoord2sv", typeof(GLNativeDelegate.FNglTexCoord2sv));
            yield return new ProcInfo("glTexCoord3d", typeof(GLNativeDelegate.FNglTexCoord3d));
            yield return new ProcInfo("glTexCoord3dv", typeof(GLNativeDelegate.FNglTexCoord3dv));
            yield return new ProcInfo("glTexCoord3f", typeof(GLNativeDelegate.FNglTexCoord3f));
            yield return new ProcInfo("glTexCoord3fv", typeof(GLNativeDelegate.FNglTexCoord3fv));
            yield return new ProcInfo("glTexCoord3i", typeof(GLNativeDelegate.FNglTexCoord3i));
            yield return new ProcInfo("glTexCoord3iv", typeof(GLNativeDelegate.FNglTexCoord3iv));
            yield return new ProcInfo("glTexCoord3s", typeof(GLNativeDelegate.FNglTexCoord3s));
            yield return new ProcInfo("glTexCoord3sv", typeof(GLNativeDelegate.FNglTexCoord3sv));
            yield return new ProcInfo("glTexCoord4d", typeof(GLNativeDelegate.FNglTexCoord4d));
            yield return new ProcInfo("glTexCoord4dv", typeof(GLNativeDelegate.FNglTexCoord4dv));
            yield return new ProcInfo("glTexCoord4f", typeof(GLNativeDelegate.FNglTexCoord4f));
            yield return new ProcInfo("glTexCoord4fv", typeof(GLNativeDelegate.FNglTexCoord4fv));
            yield return new ProcInfo("glTexCoord4i", typeof(GLNativeDelegate.FNglTexCoord4i));
            yield return new ProcInfo("glTexCoord4iv", typeof(GLNativeDelegate.FNglTexCoord4iv));
            yield return new ProcInfo("glTexCoord4s", typeof(GLNativeDelegate.FNglTexCoord4s));
            yield return new ProcInfo("glTexCoord4sv", typeof(GLNativeDelegate.FNglTexCoord4sv));
            yield return new ProcInfo("glVertex2d", typeof(GLNativeDelegate.FNglVertex2d));
            yield return new ProcInfo("glVertex2dv", typeof(GLNativeDelegate.FNglVertex2dv));
            yield return new ProcInfo("glVertex2f", typeof(GLNativeDelegate.FNglVertex2f));
            yield return new ProcInfo("glVertex2fv", typeof(GLNativeDelegate.FNglVertex2fv));
            yield return new ProcInfo("glVertex2i", typeof(GLNativeDelegate.FNglVertex2i));
            yield return new ProcInfo("glVertex2iv", typeof(GLNativeDelegate.FNglVertex2iv));
            yield return new ProcInfo("glVertex2s", typeof(GLNativeDelegate.FNglVertex2s));
            yield return new ProcInfo("glVertex2sv", typeof(GLNativeDelegate.FNglVertex2sv));
            yield return new ProcInfo("glVertex3d", typeof(GLNativeDelegate.FNglVertex3d));
            yield return new ProcInfo("glVertex3dv", typeof(GLNativeDelegate.FNglVertex3dv));
            yield return new ProcInfo("glVertex3f", typeof(GLNativeDelegate.FNglVertex3f));
            yield return new ProcInfo("glVertex3fv", typeof(GLNativeDelegate.FNglVertex3fv));
            yield return new ProcInfo("glVertex3i", typeof(GLNativeDelegate.FNglVertex3i));
            yield return new ProcInfo("glVertex3iv", typeof(GLNativeDelegate.FNglVertex3iv));
            yield return new ProcInfo("glVertex3s", typeof(GLNativeDelegate.FNglVertex3s));
            yield return new ProcInfo("glVertex3sv", typeof(GLNativeDelegate.FNglVertex3sv));
            yield return new ProcInfo("glVertex4d", typeof(GLNativeDelegate.FNglVertex4d));
            yield return new ProcInfo("glVertex4dv", typeof(GLNativeDelegate.FNglVertex4dv));
            yield return new ProcInfo("glVertex4f", typeof(GLNativeDelegate.FNglVertex4f));
            yield return new ProcInfo("glVertex4fv", typeof(GLNativeDelegate.FNglVertex4fv));
            yield return new ProcInfo("glVertex4i", typeof(GLNativeDelegate.FNglVertex4i));
            yield return new ProcInfo("glVertex4iv", typeof(GLNativeDelegate.FNglVertex4iv));
            yield return new ProcInfo("glVertex4s", typeof(GLNativeDelegate.FNglVertex4s));
            yield return new ProcInfo("glVertex4sv", typeof(GLNativeDelegate.FNglVertex4sv));
            yield return new ProcInfo("glClipPlane", typeof(GLNativeDelegate.FNglClipPlane));
            yield return new ProcInfo("glColorMaterial", typeof(GLNativeDelegate.FNglColorMaterial));
            yield return new ProcInfo("glFogf", typeof(GLNativeDelegate.FNglFogf));
            yield return new ProcInfo("glFogfv", typeof(GLNativeDelegate.FNglFogfv));
            yield return new ProcInfo("glFogi", typeof(GLNativeDelegate.FNglFogi));
            yield return new ProcInfo("glFogiv", typeof(GLNativeDelegate.FNglFogiv));
            yield return new ProcInfo("glLightf", typeof(GLNativeDelegate.FNglLightf));
            yield return new ProcInfo("glLightfv", typeof(GLNativeDelegate.FNglLightfv));
            yield return new ProcInfo("glLighti", typeof(GLNativeDelegate.FNglLighti));
            yield return new ProcInfo("glLightiv", typeof(GLNativeDelegate.FNglLightiv));
            yield return new ProcInfo("glLightModelf", typeof(GLNativeDelegate.FNglLightModelf));
            yield return new ProcInfo("glLightModelfv", typeof(GLNativeDelegate.FNglLightModelfv));
            yield return new ProcInfo("glLightModeli", typeof(GLNativeDelegate.FNglLightModeli));
            yield return new ProcInfo("glLightModeliv", typeof(GLNativeDelegate.FNglLightModeliv));
            yield return new ProcInfo("glLineStipple", typeof(GLNativeDelegate.FNglLineStipple));
            yield return new ProcInfo("glMaterialf", typeof(GLNativeDelegate.FNglMaterialf));
            yield return new ProcInfo("glMaterialfv", typeof(GLNativeDelegate.FNglMaterialfv));
            yield return new ProcInfo("glMateriali", typeof(GLNativeDelegate.FNglMateriali));
            yield return new ProcInfo("glMaterialiv", typeof(GLNativeDelegate.FNglMaterialiv));
            yield return new ProcInfo("glPolygonStipple", typeof(GLNativeDelegate.FNglPolygonStipple));
            yield return new ProcInfo("glShadeModel", typeof(GLNativeDelegate.FNglShadeModel));
            yield return new ProcInfo("glTexEnvf", typeof(GLNativeDelegate.FNglTexEnvf));
            yield return new ProcInfo("glTexEnvfv", typeof(GLNativeDelegate.FNglTexEnvfv));
            yield return new ProcInfo("glTexEnvi", typeof(GLNativeDelegate.FNglTexEnvi));
            yield return new ProcInfo("glTexEnviv", typeof(GLNativeDelegate.FNglTexEnviv));
            yield return new ProcInfo("glTexGend", typeof(GLNativeDelegate.FNglTexGend));
            yield return new ProcInfo("glTexGendv", typeof(GLNativeDelegate.FNglTexGendv));
            yield return new ProcInfo("glTexGenf", typeof(GLNativeDelegate.FNglTexGenf));
            yield return new ProcInfo("glTexGenfv", typeof(GLNativeDelegate.FNglTexGenfv));
            yield return new ProcInfo("glTexGeni", typeof(GLNativeDelegate.FNglTexGeni));
            yield return new ProcInfo("glTexGeniv", typeof(GLNativeDelegate.FNglTexGeniv));
            yield return new ProcInfo("glFeedbackBuffer", typeof(GLNativeDelegate.FNglFeedbackBuffer));
            yield return new ProcInfo("glSelectBuffer", typeof(GLNativeDelegate.FNglSelectBuffer));
            yield return new ProcInfo("glRenderMode", typeof(GLNativeDelegate.FNglRenderMode));
            yield return new ProcInfo("glInitNames", typeof(GLNativeDelegate.FNglInitNames));
            yield return new ProcInfo("glLoadName", typeof(GLNativeDelegate.FNglLoadName));
            yield return new ProcInfo("glPassThrough", typeof(GLNativeDelegate.FNglPassThrough));
            yield return new ProcInfo("glPopName", typeof(GLNativeDelegate.FNglPopName));
            yield return new ProcInfo("glPushName", typeof(GLNativeDelegate.FNglPushName));
            yield return new ProcInfo("glClearAccum", typeof(GLNativeDelegate.FNglClearAccum));
            yield return new ProcInfo("glClearIndex", typeof(GLNativeDelegate.FNglClearIndex));
            yield return new ProcInfo("glIndexMask", typeof(GLNativeDelegate.FNglIndexMask));
            yield return new ProcInfo("glAccum", typeof(GLNativeDelegate.FNglAccum));
            yield return new ProcInfo("glPopAttrib", typeof(GLNativeDelegate.FNglPopAttrib));
            yield return new ProcInfo("glPushAttrib", typeof(GLNativeDelegate.FNglPushAttrib));
            yield return new ProcInfo("glMap1d", typeof(GLNativeDelegate.FNglMap1d));
            yield return new ProcInfo("glMap1f", typeof(GLNativeDelegate.FNglMap1f));
            yield return new ProcInfo("glMap2d", typeof(GLNativeDelegate.FNglMap2d));
            yield return new ProcInfo("glMap2f", typeof(GLNativeDelegate.FNglMap2f));
            yield return new ProcInfo("glMapGrid1d", typeof(GLNativeDelegate.FNglMapGrid1d));
            yield return new ProcInfo("glMapGrid1f", typeof(GLNativeDelegate.FNglMapGrid1f));
            yield return new ProcInfo("glMapGrid2d", typeof(GLNativeDelegate.FNglMapGrid2d));
            yield return new ProcInfo("glMapGrid2f", typeof(GLNativeDelegate.FNglMapGrid2f));
            yield return new ProcInfo("glEvalCoord1d", typeof(GLNativeDelegate.FNglEvalCoord1d));
            yield return new ProcInfo("glEvalCoord1dv", typeof(GLNativeDelegate.FNglEvalCoord1dv));
            yield return new ProcInfo("glEvalCoord1f", typeof(GLNativeDelegate.FNglEvalCoord1f));
            yield return new ProcInfo("glEvalCoord1fv", typeof(GLNativeDelegate.FNglEvalCoord1fv));
            yield return new ProcInfo("glEvalCoord2d", typeof(GLNativeDelegate.FNglEvalCoord2d));
            yield return new ProcInfo("glEvalCoord2dv", typeof(GLNativeDelegate.FNglEvalCoord2dv));
            yield return new ProcInfo("glEvalCoord2f", typeof(GLNativeDelegate.FNglEvalCoord2f));
            yield return new ProcInfo("glEvalCoord2fv", typeof(GLNativeDelegate.FNglEvalCoord2fv));
            yield return new ProcInfo("glEvalMesh1", typeof(GLNativeDelegate.FNglEvalMesh1));
            yield return new ProcInfo("glEvalPoint1", typeof(GLNativeDelegate.FNglEvalPoint1));
            yield return new ProcInfo("glEvalMesh2", typeof(GLNativeDelegate.FNglEvalMesh2));
            yield return new ProcInfo("glEvalPoint2", typeof(GLNativeDelegate.FNglEvalPoint2));
            yield return new ProcInfo("glAlphaFunc", typeof(GLNativeDelegate.FNglAlphaFunc));
            yield return new ProcInfo("glPixelZoom", typeof(GLNativeDelegate.FNglPixelZoom));
            yield return new ProcInfo("glPixelTransferf", typeof(GLNativeDelegate.FNglPixelTransferf));
            yield return new ProcInfo("glPixelTransferi", typeof(GLNativeDelegate.FNglPixelTransferi));
            yield return new ProcInfo("glPixelMapfv", typeof(GLNativeDelegate.FNglPixelMapfv));
            yield return new ProcInfo("glPixelMapuiv", typeof(GLNativeDelegate.FNglPixelMapuiv));
            yield return new ProcInfo("glPixelMapusv", typeof(GLNativeDelegate.FNglPixelMapusv));
            yield return new ProcInfo("glCopyPixels", typeof(GLNativeDelegate.FNglCopyPixels));
            yield return new ProcInfo("glDrawPixels", typeof(GLNativeDelegate.FNglDrawPixels));
            yield return new ProcInfo("glGetClipPlane", typeof(GLNativeDelegate.FNglGetClipPlane));
            yield return new ProcInfo("glGetLightfv", typeof(GLNativeDelegate.FNglGetLightfv));
            yield return new ProcInfo("glGetLightiv", typeof(GLNativeDelegate.FNglGetLightiv));
            yield return new ProcInfo("glGetMapdv", typeof(GLNativeDelegate.FNglGetMapdv));
            yield return new ProcInfo("glGetMapfv", typeof(GLNativeDelegate.FNglGetMapfv));
            yield return new ProcInfo("glGetMapiv", typeof(GLNativeDelegate.FNglGetMapiv));
            yield return new ProcInfo("glGetMaterialfv", typeof(GLNativeDelegate.FNglGetMaterialfv));
            yield return new ProcInfo("glGetMaterialiv", typeof(GLNativeDelegate.FNglGetMaterialiv));
            yield return new ProcInfo("glGetPixelMapfv", typeof(GLNativeDelegate.FNglGetPixelMapfv));
            yield return new ProcInfo("glGetPixelMapuiv", typeof(GLNativeDelegate.FNglGetPixelMapuiv));
            yield return new ProcInfo("glGetPixelMapusv", typeof(GLNativeDelegate.FNglGetPixelMapusv));
            yield return new ProcInfo("glGetPolygonStipple", typeof(GLNativeDelegate.FNglGetPolygonStipple));
            yield return new ProcInfo("glGetTexEnvfv", typeof(GLNativeDelegate.FNglGetTexEnvfv));
            yield return new ProcInfo("glGetTexEnviv", typeof(GLNativeDelegate.FNglGetTexEnviv));
            yield return new ProcInfo("glGetTexGendv", typeof(GLNativeDelegate.FNglGetTexGendv));
            yield return new ProcInfo("glGetTexGenfv", typeof(GLNativeDelegate.FNglGetTexGenfv));
            yield return new ProcInfo("glGetTexGeniv", typeof(GLNativeDelegate.FNglGetTexGeniv));
            yield return new ProcInfo("glIsList", typeof(GLNativeDelegate.FNglIsList));
            yield return new ProcInfo("glFrustum", typeof(GLNativeDelegate.FNglFrustum));
            yield return new ProcInfo("glLoadIdentity", typeof(GLNativeDelegate.FNglLoadIdentity));
            yield return new ProcInfo("glLoadMatrixf", typeof(GLNativeDelegate.FNglLoadMatrixf));
            yield return new ProcInfo("glLoadMatrixd", typeof(GLNativeDelegate.FNglLoadMatrixd));
            yield return new ProcInfo("glMatrixMode", typeof(GLNativeDelegate.FNglMatrixMode));
            yield return new ProcInfo("glMultMatrixf", typeof(GLNativeDelegate.FNglMultMatrixf));
            yield return new ProcInfo("glMultMatrixd", typeof(GLNativeDelegate.FNglMultMatrixd));
            yield return new ProcInfo("glOrtho", typeof(GLNativeDelegate.FNglOrtho));
            yield return new ProcInfo("glPopMatrix", typeof(GLNativeDelegate.FNglPopMatrix));
            yield return new ProcInfo("glPushMatrix", typeof(GLNativeDelegate.FNglPushMatrix));
            yield return new ProcInfo("glRotated", typeof(GLNativeDelegate.FNglRotated));
            yield return new ProcInfo("glRotatef", typeof(GLNativeDelegate.FNglRotatef));
            yield return new ProcInfo("glScaled", typeof(GLNativeDelegate.FNglScaled));
            yield return new ProcInfo("glScalef", typeof(GLNativeDelegate.FNglScalef));
            yield return new ProcInfo("glTranslated", typeof(GLNativeDelegate.FNglTranslated));
            yield return new ProcInfo("glTranslatef", typeof(GLNativeDelegate.FNglTranslatef));

            #endregion GL_VERSION_1_0

            #region GL_VERSION_1_1

            yield return new ProcInfo("glDrawArrays", typeof(GLNativeDelegate.FNglDrawArrays));
            yield return new ProcInfo("glDrawElements", typeof(GLNativeDelegate.FNglDrawElements));
            yield return new ProcInfo("glGetPointerv", typeof(GLNativeDelegate.FNglGetPointerv));
            yield return new ProcInfo("glPolygonOffset", typeof(GLNativeDelegate.FNglPolygonOffset));
            yield return new ProcInfo("glCopyTexImage1D", typeof(GLNativeDelegate.FNglCopyTexImage1D));
            yield return new ProcInfo("glCopyTexImage2D", typeof(GLNativeDelegate.FNglCopyTexImage2D));
            yield return new ProcInfo("glCopyTexSubImage1D", typeof(GLNativeDelegate.FNglCopyTexSubImage1D));
            yield return new ProcInfo("glCopyTexSubImage2D", typeof(GLNativeDelegate.FNglCopyTexSubImage2D));
            yield return new ProcInfo("glTexSubImage1D", typeof(GLNativeDelegate.FNglTexSubImage1D));
            yield return new ProcInfo("glTexSubImage2D", typeof(GLNativeDelegate.FNglTexSubImage2D));
            yield return new ProcInfo("glBindTexture", typeof(GLNativeDelegate.FNglBindTexture));
            yield return new ProcInfo("glDeleteTextures", typeof(GLNativeDelegate.FNglDeleteTextures));
            yield return new ProcInfo("glGenTextures", typeof(GLNativeDelegate.FNglGenTextures));
            yield return new ProcInfo("glIsTexture", typeof(GLNativeDelegate.FNglIsTexture));
            yield return new ProcInfo("glArrayElement", typeof(GLNativeDelegate.FNglArrayElement));
            yield return new ProcInfo("glColorPointer", typeof(GLNativeDelegate.FNglColorPointer));
            yield return new ProcInfo("glDisableClientState", typeof(GLNativeDelegate.FNglDisableClientState));
            yield return new ProcInfo("glEdgeFlagPointer", typeof(GLNativeDelegate.FNglEdgeFlagPointer));
            yield return new ProcInfo("glEnableClientState", typeof(GLNativeDelegate.FNglEnableClientState));
            yield return new ProcInfo("glIndexPointer", typeof(GLNativeDelegate.FNglIndexPointer));
            yield return new ProcInfo("glInterleavedArrays", typeof(GLNativeDelegate.FNglInterleavedArrays));
            yield return new ProcInfo("glNormalPointer", typeof(GLNativeDelegate.FNglNormalPointer));
            yield return new ProcInfo("glTexCoordPointer", typeof(GLNativeDelegate.FNglTexCoordPointer));
            yield return new ProcInfo("glVertexPointer", typeof(GLNativeDelegate.FNglVertexPointer));
            yield return new ProcInfo("glAreTexturesResident", typeof(GLNativeDelegate.FNglAreTexturesResident));
            yield return new ProcInfo("glPrioritizeTextures", typeof(GLNativeDelegate.FNglPrioritizeTextures));
            yield return new ProcInfo("glIndexub", typeof(GLNativeDelegate.FNglIndexub));
            yield return new ProcInfo("glIndexubv", typeof(GLNativeDelegate.FNglIndexubv));
            yield return new ProcInfo("glPopClientAttrib", typeof(GLNativeDelegate.FNglPopClientAttrib));
            yield return new ProcInfo("glPushClientAttrib", typeof(GLNativeDelegate.FNglPushClientAttrib));

            #endregion GL_VERSION_1_1

            #region GL_VERSION_1_2

            yield return new ProcInfo("glDrawRangeElements", typeof(GLNativeDelegate.FNglDrawRangeElements));
            yield return new ProcInfo("glTexImage3D", typeof(GLNativeDelegate.FNglTexImage3D));
            yield return new ProcInfo("glTexSubImage3D", typeof(GLNativeDelegate.FNglTexSubImage3D));
            yield return new ProcInfo("glCopyTexSubImage3D", typeof(GLNativeDelegate.FNglCopyTexSubImage3D));

            #endregion GL_VERSION_1_2

            #region GL_VERSION_1_3

            yield return new ProcInfo("glActiveTexture", typeof(GLNativeDelegate.FNglActiveTexture));
            yield return new ProcInfo("glSampleCoverage", typeof(GLNativeDelegate.FNglSampleCoverage));
            yield return new ProcInfo("glCompressedTexImage3D", typeof(GLNativeDelegate.FNglCompressedTexImage3D));
            yield return new ProcInfo("glCompressedTexImage2D", typeof(GLNativeDelegate.FNglCompressedTexImage2D));
            yield return new ProcInfo("glCompressedTexImage1D", typeof(GLNativeDelegate.FNglCompressedTexImage1D));
            yield return new ProcInfo("glCompressedTexSubImage3D", typeof(GLNativeDelegate.FNglCompressedTexSubImage3D));
            yield return new ProcInfo("glCompressedTexSubImage2D", typeof(GLNativeDelegate.FNglCompressedTexSubImage2D));
            yield return new ProcInfo("glCompressedTexSubImage1D", typeof(GLNativeDelegate.FNglCompressedTexSubImage1D));
            yield return new ProcInfo("glGetCompressedTexImage", typeof(GLNativeDelegate.FNglGetCompressedTexImage));
            yield return new ProcInfo("glClientActiveTexture", typeof(GLNativeDelegate.FNglClientActiveTexture));
            yield return new ProcInfo("glMultiTexCoord1d", typeof(GLNativeDelegate.FNglMultiTexCoord1d));
            yield return new ProcInfo("glMultiTexCoord1dv", typeof(GLNativeDelegate.FNglMultiTexCoord1dv));
            yield return new ProcInfo("glMultiTexCoord1f", typeof(GLNativeDelegate.FNglMultiTexCoord1f));
            yield return new ProcInfo("glMultiTexCoord1fv", typeof(GLNativeDelegate.FNglMultiTexCoord1fv));
            yield return new ProcInfo("glMultiTexCoord1i", typeof(GLNativeDelegate.FNglMultiTexCoord1i));
            yield return new ProcInfo("glMultiTexCoord1iv", typeof(GLNativeDelegate.FNglMultiTexCoord1iv));
            yield return new ProcInfo("glMultiTexCoord1s", typeof(GLNativeDelegate.FNglMultiTexCoord1s));
            yield return new ProcInfo("glMultiTexCoord1sv", typeof(GLNativeDelegate.FNglMultiTexCoord1sv));
            yield return new ProcInfo("glMultiTexCoord2d", typeof(GLNativeDelegate.FNglMultiTexCoord2d));
            yield return new ProcInfo("glMultiTexCoord2dv", typeof(GLNativeDelegate.FNglMultiTexCoord2dv));
            yield return new ProcInfo("glMultiTexCoord2f", typeof(GLNativeDelegate.FNglMultiTexCoord2f));
            yield return new ProcInfo("glMultiTexCoord2fv", typeof(GLNativeDelegate.FNglMultiTexCoord2fv));
            yield return new ProcInfo("glMultiTexCoord2i", typeof(GLNativeDelegate.FNglMultiTexCoord2i));
            yield return new ProcInfo("glMultiTexCoord2iv", typeof(GLNativeDelegate.FNglMultiTexCoord2iv));
            yield return new ProcInfo("glMultiTexCoord2s", typeof(GLNativeDelegate.FNglMultiTexCoord2s));
            yield return new ProcInfo("glMultiTexCoord2sv", typeof(GLNativeDelegate.FNglMultiTexCoord2sv));
            yield return new ProcInfo("glMultiTexCoord3d", typeof(GLNativeDelegate.FNglMultiTexCoord3d));
            yield return new ProcInfo("glMultiTexCoord3dv", typeof(GLNativeDelegate.FNglMultiTexCoord3dv));
            yield return new ProcInfo("glMultiTexCoord3f", typeof(GLNativeDelegate.FNglMultiTexCoord3f));
            yield return new ProcInfo("glMultiTexCoord3fv", typeof(GLNativeDelegate.FNglMultiTexCoord3fv));
            yield return new ProcInfo("glMultiTexCoord3i", typeof(GLNativeDelegate.FNglMultiTexCoord3i));
            yield return new ProcInfo("glMultiTexCoord3iv", typeof(GLNativeDelegate.FNglMultiTexCoord3iv));
            yield return new ProcInfo("glMultiTexCoord3s", typeof(GLNativeDelegate.FNglMultiTexCoord3s));
            yield return new ProcInfo("glMultiTexCoord3sv", typeof(GLNativeDelegate.FNglMultiTexCoord3sv));
            yield return new ProcInfo("glMultiTexCoord4d", typeof(GLNativeDelegate.FNglMultiTexCoord4d));
            yield return new ProcInfo("glMultiTexCoord4dv", typeof(GLNativeDelegate.FNglMultiTexCoord4dv));
            yield return new ProcInfo("glMultiTexCoord4f", typeof(GLNativeDelegate.FNglMultiTexCoord4f));
            yield return new ProcInfo("glMultiTexCoord4fv", typeof(GLNativeDelegate.FNglMultiTexCoord4fv));
            yield return new ProcInfo("glMultiTexCoord4i", typeof(GLNativeDelegate.FNglMultiTexCoord4i));
            yield return new ProcInfo("glMultiTexCoord4iv", typeof(GLNativeDelegate.FNglMultiTexCoord4iv));
            yield return new ProcInfo("glMultiTexCoord4s", typeof(GLNativeDelegate.FNglMultiTexCoord4s));
            yield return new ProcInfo("glMultiTexCoord4sv", typeof(GLNativeDelegate.FNglMultiTexCoord4sv));
            yield return new ProcInfo("glLoadTransposeMatrixf", typeof(GLNativeDelegate.FNglLoadTransposeMatrixf));
            yield return new ProcInfo("glLoadTransposeMatrixd", typeof(GLNativeDelegate.FNglLoadTransposeMatrixd));
            yield return new ProcInfo("glMultTransposeMatrixf", typeof(GLNativeDelegate.FNglMultTransposeMatrixf));
            yield return new ProcInfo("glMultTransposeMatrixd", typeof(GLNativeDelegate.FNglMultTransposeMatrixd));

            #endregion GL_VERSION_1_3

            #region GL_VERSION_1_4

            yield return new ProcInfo("glBlendFuncSeparate", typeof(GLNativeDelegate.FNglBlendFuncSeparate));
            yield return new ProcInfo("glMultiDrawArrays", typeof(GLNativeDelegate.FNglMultiDrawArrays));
            yield return new ProcInfo("glMultiDrawElements", typeof(GLNativeDelegate.FNglMultiDrawElements));
            yield return new ProcInfo("glPointParameterf", typeof(GLNativeDelegate.FNglPointParameterf));
            yield return new ProcInfo("glPointParameterfv", typeof(GLNativeDelegate.FNglPointParameterfv));
            yield return new ProcInfo("glPointParameteri", typeof(GLNativeDelegate.FNglPointParameteri));
            yield return new ProcInfo("glPointParameteriv", typeof(GLNativeDelegate.FNglPointParameteriv));
            yield return new ProcInfo("glFogCoordf", typeof(GLNativeDelegate.FNglFogCoordf));
            yield return new ProcInfo("glFogCoordfv", typeof(GLNativeDelegate.FNglFogCoordfv));
            yield return new ProcInfo("glFogCoordd", typeof(GLNativeDelegate.FNglFogCoordd));
            yield return new ProcInfo("glFogCoorddv", typeof(GLNativeDelegate.FNglFogCoorddv));
            yield return new ProcInfo("glFogCoordPointer", typeof(GLNativeDelegate.FNglFogCoordPointer));
            yield return new ProcInfo("glSecondaryColor3b", typeof(GLNativeDelegate.FNglSecondaryColor3b));
            yield return new ProcInfo("glSecondaryColor3bv", typeof(GLNativeDelegate.FNglSecondaryColor3bv));
            yield return new ProcInfo("glSecondaryColor3d", typeof(GLNativeDelegate.FNglSecondaryColor3d));
            yield return new ProcInfo("glSecondaryColor3dv", typeof(GLNativeDelegate.FNglSecondaryColor3dv));
            yield return new ProcInfo("glSecondaryColor3f", typeof(GLNativeDelegate.FNglSecondaryColor3f));
            yield return new ProcInfo("glSecondaryColor3fv", typeof(GLNativeDelegate.FNglSecondaryColor3fv));
            yield return new ProcInfo("glSecondaryColor3i", typeof(GLNativeDelegate.FNglSecondaryColor3i));
            yield return new ProcInfo("glSecondaryColor3iv", typeof(GLNativeDelegate.FNglSecondaryColor3iv));
            yield return new ProcInfo("glSecondaryColor3s", typeof(GLNativeDelegate.FNglSecondaryColor3s));
            yield return new ProcInfo("glSecondaryColor3sv", typeof(GLNativeDelegate.FNglSecondaryColor3sv));
            yield return new ProcInfo("glSecondaryColor3ub", typeof(GLNativeDelegate.FNglSecondaryColor3ub));
            yield return new ProcInfo("glSecondaryColor3ubv", typeof(GLNativeDelegate.FNglSecondaryColor3ubv));
            yield return new ProcInfo("glSecondaryColor3ui", typeof(GLNativeDelegate.FNglSecondaryColor3ui));
            yield return new ProcInfo("glSecondaryColor3uiv", typeof(GLNativeDelegate.FNglSecondaryColor3uiv));
            yield return new ProcInfo("glSecondaryColor3us", typeof(GLNativeDelegate.FNglSecondaryColor3us));
            yield return new ProcInfo("glSecondaryColor3usv", typeof(GLNativeDelegate.FNglSecondaryColor3usv));
            yield return new ProcInfo("glSecondaryColorPointer", typeof(GLNativeDelegate.FNglSecondaryColorPointer));
            yield return new ProcInfo("glWindowPos2d", typeof(GLNativeDelegate.FNglWindowPos2d));
            yield return new ProcInfo("glWindowPos2dv", typeof(GLNativeDelegate.FNglWindowPos2dv));
            yield return new ProcInfo("glWindowPos2f", typeof(GLNativeDelegate.FNglWindowPos2f));
            yield return new ProcInfo("glWindowPos2fv", typeof(GLNativeDelegate.FNglWindowPos2fv));
            yield return new ProcInfo("glWindowPos2i", typeof(GLNativeDelegate.FNglWindowPos2i));
            yield return new ProcInfo("glWindowPos2iv", typeof(GLNativeDelegate.FNglWindowPos2iv));
            yield return new ProcInfo("glWindowPos2s", typeof(GLNativeDelegate.FNglWindowPos2s));
            yield return new ProcInfo("glWindowPos2sv", typeof(GLNativeDelegate.FNglWindowPos2sv));
            yield return new ProcInfo("glWindowPos3d", typeof(GLNativeDelegate.FNglWindowPos3d));
            yield return new ProcInfo("glWindowPos3dv", typeof(GLNativeDelegate.FNglWindowPos3dv));
            yield return new ProcInfo("glWindowPos3f", typeof(GLNativeDelegate.FNglWindowPos3f));
            yield return new ProcInfo("glWindowPos3fv", typeof(GLNativeDelegate.FNglWindowPos3fv));
            yield return new ProcInfo("glWindowPos3i", typeof(GLNativeDelegate.FNglWindowPos3i));
            yield return new ProcInfo("glWindowPos3iv", typeof(GLNativeDelegate.FNglWindowPos3iv));
            yield return new ProcInfo("glWindowPos3s", typeof(GLNativeDelegate.FNglWindowPos3s));
            yield return new ProcInfo("glWindowPos3sv", typeof(GLNativeDelegate.FNglWindowPos3sv));

            #region Promoted from ARB_imaging subset to core

            yield return new ProcInfo("glBlendColor", typeof(GLNativeDelegate.FNglBlendColor));
            yield return new ProcInfo("glBlendEquation", typeof(GLNativeDelegate.FNglBlendEquation));

            #endregion Promoted from ARB_imaging subset to core

            #endregion GL_VERSION_1_4

            #region GL_VERSION_1_5

            yield return new ProcInfo("glGenQueries", typeof(GLNativeDelegate.FNglGenQueries));
            yield return new ProcInfo("glDeleteQueries", typeof(GLNativeDelegate.FNglDeleteQueries));
            yield return new ProcInfo("glIsQuery", typeof(GLNativeDelegate.FNglIsQuery));
            yield return new ProcInfo("glBeginQuery", typeof(GLNativeDelegate.FNglBeginQuery));
            yield return new ProcInfo("glEndQuery", typeof(GLNativeDelegate.FNglEndQuery));
            yield return new ProcInfo("glGetQueryiv", typeof(GLNativeDelegate.FNglGetQueryiv));
            yield return new ProcInfo("glGetQueryObjectiv", typeof(GLNativeDelegate.FNglGetQueryObjectiv));
            yield return new ProcInfo("glGetQueryObjectuiv", typeof(GLNativeDelegate.FNglGetQueryObjectuiv));
            yield return new ProcInfo("glBindBuffer", typeof(GLNativeDelegate.FNglBindBuffer));
            yield return new ProcInfo("glDeleteBuffers", typeof(GLNativeDelegate.FNglDeleteBuffers));
            yield return new ProcInfo("glGenBuffers", typeof(GLNativeDelegate.FNglGenBuffers));
            yield return new ProcInfo("glIsBuffer", typeof(GLNativeDelegate.FNglIsBuffer));
            yield return new ProcInfo("glBufferData", typeof(GLNativeDelegate.FNglBufferData));
            yield return new ProcInfo("glBufferSubData", typeof(GLNativeDelegate.FNglBufferSubData));
            yield return new ProcInfo("glGetBufferSubData", typeof(GLNativeDelegate.FNglGetBufferSubData));
            yield return new ProcInfo("glMapBuffer", typeof(GLNativeDelegate.FNglMapBuffer));
            yield return new ProcInfo("glUnmapBuffer", typeof(GLNativeDelegate.FNglUnmapBuffer));
            yield return new ProcInfo("glGetBufferParameteriv", typeof(GLNativeDelegate.FNglGetBufferParameteriv));
            yield return new ProcInfo("glGetBufferPointerv", typeof(GLNativeDelegate.FNglGetBufferPointerv));

            #endregion GL_VERSION_1_5

            #region GL_VERSION_2_0

            yield return new ProcInfo("glBlendEquationSeparate", typeof(GLNativeDelegate.FNglBlendEquationSeparate));
            yield return new ProcInfo("glDrawBuffers", typeof(GLNativeDelegate.FNglDrawBuffers));
            yield return new ProcInfo("glStencilOpSeparate", typeof(GLNativeDelegate.FNglStencilOpSeparate));
            yield return new ProcInfo("glStencilFuncSeparate", typeof(GLNativeDelegate.FNglStencilFuncSeparate));
            yield return new ProcInfo("glStencilMaskSeparate", typeof(GLNativeDelegate.FNglStencilMaskSeparate));
            yield return new ProcInfo("glAttachShader", typeof(GLNativeDelegate.FNglAttachShader));
            yield return new ProcInfo("glBindAttribLocation", typeof(GLNativeDelegate.FNglBindAttribLocation));
            yield return new ProcInfo("glCompileShader", typeof(GLNativeDelegate.FNglCompileShader));
            yield return new ProcInfo("glCreateProgram", typeof(GLNativeDelegate.FNglCreateProgram));
            yield return new ProcInfo("glCreateShader", typeof(GLNativeDelegate.FNglCreateShader));
            yield return new ProcInfo("glDeleteProgram", typeof(GLNativeDelegate.FNglDeleteProgram));
            yield return new ProcInfo("glDeleteShader", typeof(GLNativeDelegate.FNglDeleteShader));
            yield return new ProcInfo("glDetachShader", typeof(GLNativeDelegate.FNglDetachShader));
            yield return new ProcInfo("glDisableVertexAttribArray", typeof(GLNativeDelegate.FNglDisableVertexAttribArray));
            yield return new ProcInfo("glEnableVertexAttribArray", typeof(GLNativeDelegate.FNglEnableVertexAttribArray));
            yield return new ProcInfo("glGetActiveAttrib", typeof(GLNativeDelegate.FNglGetActiveAttrib));
            yield return new ProcInfo("glGetActiveUniform", typeof(GLNativeDelegate.FNglGetActiveUniform));
            yield return new ProcInfo("glGetAttachedShaders", typeof(GLNativeDelegate.FNglGetAttachedShaders));
            yield return new ProcInfo("glGetAttribLocation", typeof(GLNativeDelegate.FNglGetAttribLocation));
            yield return new ProcInfo("glGetProgramiv", typeof(GLNativeDelegate.FNglGetProgramiv));
            yield return new ProcInfo("glGetProgramInfoLog", typeof(GLNativeDelegate.FNglGetProgramInfoLog));
            yield return new ProcInfo("glGetShaderiv", typeof(GLNativeDelegate.FNglGetShaderiv));
            yield return new ProcInfo("glGetShaderInfoLog", typeof(GLNativeDelegate.FNglGetShaderInfoLog));
            yield return new ProcInfo("glGetShaderSource", typeof(GLNativeDelegate.FNglGetShaderSource));
            yield return new ProcInfo("glGetUniformLocation", typeof(GLNativeDelegate.FNglGetUniformLocation));
            yield return new ProcInfo("glGetUniformfv", typeof(GLNativeDelegate.FNglGetUniformfv));
            yield return new ProcInfo("glGetUniformiv", typeof(GLNativeDelegate.FNglGetUniformiv));
            yield return new ProcInfo("glGetVertexAttribdv", typeof(GLNativeDelegate.FNglGetVertexAttribdv));
            yield return new ProcInfo("glGetVertexAttribfv", typeof(GLNativeDelegate.FNglGetVertexAttribfv));
            yield return new ProcInfo("glGetVertexAttribiv", typeof(GLNativeDelegate.FNglGetVertexAttribiv));
            yield return new ProcInfo("glGetVertexAttribPointerv", typeof(GLNativeDelegate.FNglGetVertexAttribPointerv));
            yield return new ProcInfo("glIsProgram", typeof(GLNativeDelegate.FNglIsProgram));
            yield return new ProcInfo("glIsShader", typeof(GLNativeDelegate.FNglIsShader));
            yield return new ProcInfo("glLinkProgram", typeof(GLNativeDelegate.FNglLinkProgram));
            yield return new ProcInfo("glShaderSource", typeof(GLNativeDelegate.FNglShaderSource));
            yield return new ProcInfo("glUseProgram", typeof(GLNativeDelegate.FNglUseProgram));
            yield return new ProcInfo("glUniform1f", typeof(GLNativeDelegate.FNglUniform1f));
            yield return new ProcInfo("glUniform2f", typeof(GLNativeDelegate.FNglUniform2f));
            yield return new ProcInfo("glUniform3f", typeof(GLNativeDelegate.FNglUniform3f));
            yield return new ProcInfo("glUniform4f", typeof(GLNativeDelegate.FNglUniform4f));
            yield return new ProcInfo("glUniform1i", typeof(GLNativeDelegate.FNglUniform1i));
            yield return new ProcInfo("glUniform2i", typeof(GLNativeDelegate.FNglUniform2i));
            yield return new ProcInfo("glUniform3i", typeof(GLNativeDelegate.FNglUniform3i));
            yield return new ProcInfo("glUniform4i", typeof(GLNativeDelegate.FNglUniform4i));
            yield return new ProcInfo("glUniform1fv", typeof(GLNativeDelegate.FNglUniform1fv));
            yield return new ProcInfo("glUniform2fv", typeof(GLNativeDelegate.FNglUniform2fv));
            yield return new ProcInfo("glUniform3fv", typeof(GLNativeDelegate.FNglUniform3fv));
            yield return new ProcInfo("glUniform4fv", typeof(GLNativeDelegate.FNglUniform4fv));
            yield return new ProcInfo("glUniform1iv", typeof(GLNativeDelegate.FNglUniform1iv));
            yield return new ProcInfo("glUniform2iv", typeof(GLNativeDelegate.FNglUniform2iv));
            yield return new ProcInfo("glUniform3iv", typeof(GLNativeDelegate.FNglUniform3iv));
            yield return new ProcInfo("glUniform4iv", typeof(GLNativeDelegate.FNglUniform4iv));
            yield return new ProcInfo("glUniformMatrix2fv", typeof(GLNativeDelegate.FNglUniformMatrix2fv));
            yield return new ProcInfo("glUniformMatrix3fv", typeof(GLNativeDelegate.FNglUniformMatrix3fv));
            yield return new ProcInfo("glUniformMatrix4fv", typeof(GLNativeDelegate.FNglUniformMatrix4fv));
            yield return new ProcInfo("glValidateProgram", typeof(GLNativeDelegate.FNglValidateProgram));
            yield return new ProcInfo("glVertexAttrib1d", typeof(GLNativeDelegate.FNglVertexAttrib1d));
            yield return new ProcInfo("glVertexAttrib1dv", typeof(GLNativeDelegate.FNglVertexAttrib1dv));
            yield return new ProcInfo("glVertexAttrib1f", typeof(GLNativeDelegate.FNglVertexAttrib1f));
            yield return new ProcInfo("glVertexAttrib1fv", typeof(GLNativeDelegate.FNglVertexAttrib1fv));
            yield return new ProcInfo("glVertexAttrib1s", typeof(GLNativeDelegate.FNglVertexAttrib1s));
            yield return new ProcInfo("glVertexAttrib1sv", typeof(GLNativeDelegate.FNglVertexAttrib1sv));
            yield return new ProcInfo("glVertexAttrib2d", typeof(GLNativeDelegate.FNglVertexAttrib2d));
            yield return new ProcInfo("glVertexAttrib2dv", typeof(GLNativeDelegate.FNglVertexAttrib2dv));
            yield return new ProcInfo("glVertexAttrib2f", typeof(GLNativeDelegate.FNglVertexAttrib2f));
            yield return new ProcInfo("glVertexAttrib2fv", typeof(GLNativeDelegate.FNglVertexAttrib2fv));
            yield return new ProcInfo("glVertexAttrib2s", typeof(GLNativeDelegate.FNglVertexAttrib2s));
            yield return new ProcInfo("glVertexAttrib2sv", typeof(GLNativeDelegate.FNglVertexAttrib2sv));
            yield return new ProcInfo("glVertexAttrib3d", typeof(GLNativeDelegate.FNglVertexAttrib3d));
            yield return new ProcInfo("glVertexAttrib3dv", typeof(GLNativeDelegate.FNglVertexAttrib3dv));
            yield return new ProcInfo("glVertexAttrib3f", typeof(GLNativeDelegate.FNglVertexAttrib3f));
            yield return new ProcInfo("glVertexAttrib3fv", typeof(GLNativeDelegate.FNglVertexAttrib3fv));
            yield return new ProcInfo("glVertexAttrib3s", typeof(GLNativeDelegate.FNglVertexAttrib3s));
            yield return new ProcInfo("glVertexAttrib3sv", typeof(GLNativeDelegate.FNglVertexAttrib3sv));
            yield return new ProcInfo("glVertexAttrib4Nbv", typeof(GLNativeDelegate.FNglVertexAttrib4Nbv));
            yield return new ProcInfo("glVertexAttrib4Niv", typeof(GLNativeDelegate.FNglVertexAttrib4Niv));
            yield return new ProcInfo("glVertexAttrib4Nsv", typeof(GLNativeDelegate.FNglVertexAttrib4Nsv));
            yield return new ProcInfo("glVertexAttrib4Nub", typeof(GLNativeDelegate.FNglVertexAttrib4Nub));
            yield return new ProcInfo("glVertexAttrib4Nubv", typeof(GLNativeDelegate.FNglVertexAttrib4Nubv));
            yield return new ProcInfo("glVertexAttrib4Nuiv", typeof(GLNativeDelegate.FNglVertexAttrib4Nuiv));
            yield return new ProcInfo("glVertexAttrib4Nusv", typeof(GLNativeDelegate.FNglVertexAttrib4Nusv));
            yield return new ProcInfo("glVertexAttrib4bv", typeof(GLNativeDelegate.FNglVertexAttrib4bv));
            yield return new ProcInfo("glVertexAttrib4d", typeof(GLNativeDelegate.FNglVertexAttrib4d));
            yield return new ProcInfo("glVertexAttrib4dv", typeof(GLNativeDelegate.FNglVertexAttrib4dv));
            yield return new ProcInfo("glVertexAttrib4f", typeof(GLNativeDelegate.FNglVertexAttrib4f));
            yield return new ProcInfo("glVertexAttrib4fv", typeof(GLNativeDelegate.FNglVertexAttrib4fv));
            yield return new ProcInfo("glVertexAttrib4iv", typeof(GLNativeDelegate.FNglVertexAttrib4iv));
            yield return new ProcInfo("glVertexAttrib4s", typeof(GLNativeDelegate.FNglVertexAttrib4s));
            yield return new ProcInfo("glVertexAttrib4sv", typeof(GLNativeDelegate.FNglVertexAttrib4sv));
            yield return new ProcInfo("glVertexAttrib4ubv", typeof(GLNativeDelegate.FNglVertexAttrib4ubv));
            yield return new ProcInfo("glVertexAttrib4uiv", typeof(GLNativeDelegate.FNglVertexAttrib4uiv));
            yield return new ProcInfo("glVertexAttrib4usv", typeof(GLNativeDelegate.FNglVertexAttrib4usv));
            yield return new ProcInfo("glVertexAttribPointer", typeof(GLNativeDelegate.FNglVertexAttribPointer));

            #endregion GL_VERSION_2_0

            #region GL_VERSION_2_1

            yield return new ProcInfo("glUniformMatrix2x3fv", typeof(GLNativeDelegate.FNglUniformMatrix2x3fv));
            yield return new ProcInfo("glUniformMatrix3x2fv", typeof(GLNativeDelegate.FNglUniformMatrix3x2fv));
            yield return new ProcInfo("glUniformMatrix2x4fv", typeof(GLNativeDelegate.FNglUniformMatrix2x4fv));
            yield return new ProcInfo("glUniformMatrix4x2fv", typeof(GLNativeDelegate.FNglUniformMatrix4x2fv));
            yield return new ProcInfo("glUniformMatrix3x4fv", typeof(GLNativeDelegate.FNglUniformMatrix3x4fv));
            yield return new ProcInfo("glUniformMatrix4x3fv", typeof(GLNativeDelegate.FNglUniformMatrix4x3fv));

            #endregion GL_VERSION_2_1

            #region GL_VERSION_3_0

            yield return new ProcInfo("glColorMaski", typeof(GLNativeDelegate.FNglColorMaski));
            yield return new ProcInfo("glGetBooleani_v", typeof(GLNativeDelegate.FNglGetBooleani_v));
            yield return new ProcInfo("glGetIntegeri_v", typeof(GLNativeDelegate.FNglGetIntegeri_v));
            yield return new ProcInfo("glEnablei", typeof(GLNativeDelegate.FNglEnablei));
            yield return new ProcInfo("glDisablei", typeof(GLNativeDelegate.FNglDisablei));
            yield return new ProcInfo("glIsEnabledi", typeof(GLNativeDelegate.FNglIsEnabledi));
            yield return new ProcInfo("glBeginTransformFeedback", typeof(GLNativeDelegate.FNglBeginTransformFeedback));
            yield return new ProcInfo("glEndTransformFeedback", typeof(GLNativeDelegate.FNglEndTransformFeedback));
            yield return new ProcInfo("glBindBufferRange", typeof(GLNativeDelegate.FNglBindBufferRange));
            yield return new ProcInfo("glBindBufferBase", typeof(GLNativeDelegate.FNglBindBufferBase));
            yield return new ProcInfo("glTransformFeedbackVaryings", typeof(GLNativeDelegate.FNglTransformFeedbackVaryings));
            yield return new ProcInfo("glGetTransformFeedbackVarying", typeof(GLNativeDelegate.FNglGetTransformFeedbackVarying));
            yield return new ProcInfo("glClampColor", typeof(GLNativeDelegate.FNglClampColor));
            yield return new ProcInfo("glBeginConditionalRender", typeof(GLNativeDelegate.FNglBeginConditionalRender));
            yield return new ProcInfo("glEndConditionalRender", typeof(GLNativeDelegate.FNglEndConditionalRender));
            yield return new ProcInfo("glVertexAttribIPointer", typeof(GLNativeDelegate.FNglVertexAttribIPointer));
            yield return new ProcInfo("glGetVertexAttribIiv", typeof(GLNativeDelegate.FNglGetVertexAttribIiv));
            yield return new ProcInfo("glGetVertexAttribIuiv", typeof(GLNativeDelegate.FNglGetVertexAttribIuiv));
            yield return new ProcInfo("glVertexAttribI1i", typeof(GLNativeDelegate.FNglVertexAttribI1i));
            yield return new ProcInfo("glVertexAttribI2i", typeof(GLNativeDelegate.FNglVertexAttribI2i));
            yield return new ProcInfo("glVertexAttribI3i", typeof(GLNativeDelegate.FNglVertexAttribI3i));
            yield return new ProcInfo("glVertexAttribI4i", typeof(GLNativeDelegate.FNglVertexAttribI4i));
            yield return new ProcInfo("glVertexAttribI1ui", typeof(GLNativeDelegate.FNglVertexAttribI1ui));
            yield return new ProcInfo("glVertexAttribI2ui", typeof(GLNativeDelegate.FNglVertexAttribI2ui));
            yield return new ProcInfo("glVertexAttribI3ui", typeof(GLNativeDelegate.FNglVertexAttribI3ui));
            yield return new ProcInfo("glVertexAttribI4ui", typeof(GLNativeDelegate.FNglVertexAttribI4ui));
            yield return new ProcInfo("glVertexAttribI1iv", typeof(GLNativeDelegate.FNglVertexAttribI1iv));
            yield return new ProcInfo("glVertexAttribI2iv", typeof(GLNativeDelegate.FNglVertexAttribI2iv));
            yield return new ProcInfo("glVertexAttribI3iv", typeof(GLNativeDelegate.FNglVertexAttribI3iv));
            yield return new ProcInfo("glVertexAttribI4iv", typeof(GLNativeDelegate.FNglVertexAttribI4iv));
            yield return new ProcInfo("glVertexAttribI1uiv", typeof(GLNativeDelegate.FNglVertexAttribI1uiv));
            yield return new ProcInfo("glVertexAttribI2uiv", typeof(GLNativeDelegate.FNglVertexAttribI2uiv));
            yield return new ProcInfo("glVertexAttribI3uiv", typeof(GLNativeDelegate.FNglVertexAttribI3uiv));
            yield return new ProcInfo("glVertexAttribI4uiv", typeof(GLNativeDelegate.FNglVertexAttribI4uiv));
            yield return new ProcInfo("glVertexAttribI4bv", typeof(GLNativeDelegate.FNglVertexAttribI4bv));
            yield return new ProcInfo("glVertexAttribI4sv", typeof(GLNativeDelegate.FNglVertexAttribI4sv));
            yield return new ProcInfo("glVertexAttribI4ubv", typeof(GLNativeDelegate.FNglVertexAttribI4ubv));
            yield return new ProcInfo("glVertexAttribI4usv", typeof(GLNativeDelegate.FNglVertexAttribI4usv));
            yield return new ProcInfo("glGetUniformuiv", typeof(GLNativeDelegate.FNglGetUniformuiv));
            yield return new ProcInfo("glBindFragDataLocation", typeof(GLNativeDelegate.FNglBindFragDataLocation));
            yield return new ProcInfo("glGetFragDataLocation", typeof(GLNativeDelegate.FNglGetFragDataLocation));
            yield return new ProcInfo("glUniform1ui", typeof(GLNativeDelegate.FNglUniform1ui));
            yield return new ProcInfo("glUniform2ui", typeof(GLNativeDelegate.FNglUniform2ui));
            yield return new ProcInfo("glUniform3ui", typeof(GLNativeDelegate.FNglUniform3ui));
            yield return new ProcInfo("glUniform4ui", typeof(GLNativeDelegate.FNglUniform4ui));
            yield return new ProcInfo("glUniform1uiv", typeof(GLNativeDelegate.FNglUniform1uiv));
            yield return new ProcInfo("glUniform2uiv", typeof(GLNativeDelegate.FNglUniform2uiv));
            yield return new ProcInfo("glUniform3uiv", typeof(GLNativeDelegate.FNglUniform3uiv));
            yield return new ProcInfo("glUniform4uiv", typeof(GLNativeDelegate.FNglUniform4uiv));
            yield return new ProcInfo("glTexParameterIiv", typeof(GLNativeDelegate.FNglTexParameterIiv));
            yield return new ProcInfo("glTexParameterIuiv", typeof(GLNativeDelegate.FNglTexParameterIuiv));
            yield return new ProcInfo("glGetTexParameterIiv", typeof(GLNativeDelegate.FNglGetTexParameterIiv));
            yield return new ProcInfo("glGetTexParameterIuiv", typeof(GLNativeDelegate.FNglGetTexParameterIuiv));
            yield return new ProcInfo("glClearBufferiv", typeof(GLNativeDelegate.FNglClearBufferiv));
            yield return new ProcInfo("glClearBufferuiv", typeof(GLNativeDelegate.FNglClearBufferuiv));
            yield return new ProcInfo("glClearBufferfv", typeof(GLNativeDelegate.FNglClearBufferfv));
            yield return new ProcInfo("glClearBufferfi", typeof(GLNativeDelegate.FNglClearBufferfi));
            yield return new ProcInfo("glGetStringi", typeof(GLNativeDelegate.FNglGetStringi));

            #region Reuse ARB_framebuffer_object

            yield return new ProcInfo("glIsRenderbuffer", typeof(GLNativeDelegate.FNglIsRenderbuffer));
            yield return new ProcInfo("glBindRenderbuffer", typeof(GLNativeDelegate.FNglBindRenderbuffer));
            yield return new ProcInfo("glDeleteRenderbuffers", typeof(GLNativeDelegate.FNglDeleteRenderbuffers));
            yield return new ProcInfo("glGenRenderbuffers", typeof(GLNativeDelegate.FNglGenRenderbuffers));
            yield return new ProcInfo("glRenderbufferStorage", typeof(GLNativeDelegate.FNglRenderbufferStorage));
            yield return new ProcInfo("glGetRenderbufferParameteriv", typeof(GLNativeDelegate.FNglGetRenderbufferParameteriv));
            yield return new ProcInfo("glIsFramebuffer", typeof(GLNativeDelegate.FNglIsFramebuffer));
            yield return new ProcInfo("glBindFramebuffer", typeof(GLNativeDelegate.FNglBindFramebuffer));
            yield return new ProcInfo("glDeleteFramebuffers", typeof(GLNativeDelegate.FNglDeleteFramebuffers));
            yield return new ProcInfo("glGenFramebuffers", typeof(GLNativeDelegate.FNglGenFramebuffers));
            yield return new ProcInfo("glCheckFramebufferStatus", typeof(GLNativeDelegate.FNglCheckFramebufferStatus));
            yield return new ProcInfo("glFramebufferTexture1D", typeof(GLNativeDelegate.FNglFramebufferTexture1D));
            yield return new ProcInfo("glFramebufferTexture2D", typeof(GLNativeDelegate.FNglFramebufferTexture2D));
            yield return new ProcInfo("glFramebufferTexture3D", typeof(GLNativeDelegate.FNglFramebufferTexture3D));
            yield return new ProcInfo("glFramebufferRenderbuffer", typeof(GLNativeDelegate.FNglFramebufferRenderbuffer));
            yield return new ProcInfo("glGetFramebufferAttachmentParameteriv", typeof(GLNativeDelegate.FNglGetFramebufferAttachmentParameteriv));
            yield return new ProcInfo("glGenerateMipmap", typeof(GLNativeDelegate.FNglGenerateMipmap));
            yield return new ProcInfo("glBlitFramebuffer", typeof(GLNativeDelegate.FNglBlitFramebuffer));
            yield return new ProcInfo("glRenderbufferStorageMultisample", typeof(GLNativeDelegate.FNglRenderbufferStorageMultisample));
            yield return new ProcInfo("glFramebufferTextureLayer", typeof(GLNativeDelegate.FNglFramebufferTextureLayer));

            #endregion Reuse ARB_framebuffer_object

            #region Reuse ARB_map_buffer_range

            yield return new ProcInfo("glMapBufferRange", typeof(GLNativeDelegate.FNglMapBufferRange));
            yield return new ProcInfo("glFlushMappedBufferRange", typeof(GLNativeDelegate.FNglFlushMappedBufferRange));

            #endregion Reuse ARB_map_buffer_range

            #region Reuse ARB_vertex_array_object

            yield return new ProcInfo("glBindVertexArray", typeof(GLNativeDelegate.FNglBindVertexArray));
            yield return new ProcInfo("glDeleteVertexArrays", typeof(GLNativeDelegate.FNglDeleteVertexArrays));
            yield return new ProcInfo("glGenVertexArrays", typeof(GLNativeDelegate.FNglGenVertexArrays));
            yield return new ProcInfo("glIsVertexArray", typeof(GLNativeDelegate.FNglIsVertexArray));

            #endregion Reuse ARB_vertex_array_object

            #endregion GL_VERSION_3_0

            #region GL_VERSION_3_1

            yield return new ProcInfo("glDrawArraysInstanced", typeof(GLNativeDelegate.FNglDrawArraysInstanced));
            yield return new ProcInfo("glDrawElementsInstanced", typeof(GLNativeDelegate.FNglDrawElementsInstanced));
            yield return new ProcInfo("glTexBuffer", typeof(GLNativeDelegate.FNglTexBuffer));
            yield return new ProcInfo("glPrimitiveRestartIndex", typeof(GLNativeDelegate.FNglPrimitiveRestartIndex));

            #region Reuse ARB_copy_buffer

            yield return new ProcInfo("glCopyBufferSubData", typeof(GLNativeDelegate.FNglCopyBufferSubData));

            #endregion Reuse ARB_copy_buffer

            #region Reuse ARB_uniform_buffer_object

            yield return new ProcInfo("glGetUniformIndices", typeof(GLNativeDelegate.FNglGetUniformIndices));
            yield return new ProcInfo("glGetActiveUniformsiv", typeof(GLNativeDelegate.FNglGetActiveUniformsiv));
            yield return new ProcInfo("glGetActiveUniformName", typeof(GLNativeDelegate.FNglGetActiveUniformName));
            yield return new ProcInfo("glGetUniformBlockIndex", typeof(GLNativeDelegate.FNglGetUniformBlockIndex));
            yield return new ProcInfo("glGetActiveUniformBlockiv", typeof(GLNativeDelegate.FNglGetActiveUniformBlockiv));
            yield return new ProcInfo("glGetActiveUniformBlockName", typeof(GLNativeDelegate.FNglGetActiveUniformBlockName));
            yield return new ProcInfo("glUniformBlockBinding", typeof(GLNativeDelegate.FNglUniformBlockBinding));
            // yield return new ProcInfo("glBindBufferRange", typeof(GLNativeDelegate.FNglBindBufferRange));
            // yield return new ProcInfo("glBindBufferBase", typeof(GLNativeDelegate.FNglBindBufferBase));
            // yield return new ProcInfo("glGetIntegeri_v", typeof(GLNativeDelegate.FNglGetIntegeri_v));

            #endregion Reuse ARB_uniform_buffer_object

            #endregion GL_VERSION_3_1

            #region GL_VERSION_3_2


            #region Reuse ARB_draw_elements_base_vertex

            yield return new ProcInfo("glDrawElementsBaseVertex", typeof(GLNativeDelegate.FNglDrawElementsBaseVertex));
            yield return new ProcInfo("glDrawRangeElementsBaseVertex", typeof(GLNativeDelegate.FNglDrawRangeElementsBaseVertex));
            yield return new ProcInfo("glDrawElementsInstancedBaseVertex", typeof(GLNativeDelegate.FNglDrawElementsInstancedBaseVertex));
            yield return new ProcInfo("glMultiDrawElementsBaseVertex", typeof(GLNativeDelegate.FNglMultiDrawElementsBaseVertex));

            #endregion Reuse ARB_draw_elements_base_vertex

            #region Reuse ARB_provoking_vertex

            yield return new ProcInfo("glProvokingVertex", typeof(GLNativeDelegate.FNglProvokingVertex));

            #endregion Reuse ARB_provoking_vertex

            #region Reuse ARB_sync

            yield return new ProcInfo("glFenceSync", typeof(GLNativeDelegate.FNglFenceSync));
            yield return new ProcInfo("glIsSync", typeof(GLNativeDelegate.FNglIsSync));
            yield return new ProcInfo("glDeleteSync", typeof(GLNativeDelegate.FNglDeleteSync));
            yield return new ProcInfo("glClientWaitSync", typeof(GLNativeDelegate.FNglClientWaitSync));
            yield return new ProcInfo("glWaitSync", typeof(GLNativeDelegate.FNglWaitSync));
            yield return new ProcInfo("glGetInteger64v", typeof(GLNativeDelegate.FNglGetInteger64v));
            yield return new ProcInfo("glGetSynciv", typeof(GLNativeDelegate.FNglGetSynciv));

            #endregion Reuse ARB_sync

            #region Reuse ARB_texture_multisample

            yield return new ProcInfo("glGetInteger64i_v", typeof(GLNativeDelegate.FNglGetInteger64i_v));
            yield return new ProcInfo("glGetBufferParameteri64v", typeof(GLNativeDelegate.FNglGetBufferParameteri64v));
            yield return new ProcInfo("glFramebufferTexture", typeof(GLNativeDelegate.FNglFramebufferTexture));
            yield return new ProcInfo("glTexImage2DMultisample", typeof(GLNativeDelegate.FNglTexImage2DMultisample));
            yield return new ProcInfo("glTexImage3DMultisample", typeof(GLNativeDelegate.FNglTexImage3DMultisample));
            yield return new ProcInfo("glGetMultisamplefv", typeof(GLNativeDelegate.FNglGetMultisamplefv));
            yield return new ProcInfo("glSampleMaski", typeof(GLNativeDelegate.FNglSampleMaski));

            #endregion Reuse ARB_texture_multisample

            #region Compatibility-only GL 1.0 features removed from GL 3.2

            // yield return new ProcInfo("glNewList", typeof(GLNativeDelegate.FNglNewList));
            // yield return new ProcInfo("glEndList", typeof(GLNativeDelegate.FNglEndList));
            // yield return new ProcInfo("glCallList", typeof(GLNativeDelegate.FNglCallList));
            // yield return new ProcInfo("glCallLists", typeof(GLNativeDelegate.FNglCallLists));
            // yield return new ProcInfo("glDeleteLists", typeof(GLNativeDelegate.FNglDeleteLists));
            // yield return new ProcInfo("glGenLists", typeof(GLNativeDelegate.FNglGenLists));
            // yield return new ProcInfo("glListBase", typeof(GLNativeDelegate.FNglListBase));
            // yield return new ProcInfo("glBegin", typeof(GLNativeDelegate.FNglBegin));
            // yield return new ProcInfo("glBitmap", typeof(GLNativeDelegate.FNglBitmap));
            // yield return new ProcInfo("glColor3b", typeof(GLNativeDelegate.FNglColor3b));
            // yield return new ProcInfo("glColor3bv", typeof(GLNativeDelegate.FNglColor3bv));
            // yield return new ProcInfo("glColor3d", typeof(GLNativeDelegate.FNglColor3d));
            // yield return new ProcInfo("glColor3dv", typeof(GLNativeDelegate.FNglColor3dv));
            // yield return new ProcInfo("glColor3f", typeof(GLNativeDelegate.FNglColor3f));
            // yield return new ProcInfo("glColor3fv", typeof(GLNativeDelegate.FNglColor3fv));
            // yield return new ProcInfo("glColor3i", typeof(GLNativeDelegate.FNglColor3i));
            // yield return new ProcInfo("glColor3iv", typeof(GLNativeDelegate.FNglColor3iv));
            // yield return new ProcInfo("glColor3s", typeof(GLNativeDelegate.FNglColor3s));
            // yield return new ProcInfo("glColor3sv", typeof(GLNativeDelegate.FNglColor3sv));
            // yield return new ProcInfo("glColor3ub", typeof(GLNativeDelegate.FNglColor3ub));
            // yield return new ProcInfo("glColor3ubv", typeof(GLNativeDelegate.FNglColor3ubv));
            // yield return new ProcInfo("glColor3ui", typeof(GLNativeDelegate.FNglColor3ui));
            // yield return new ProcInfo("glColor3uiv", typeof(GLNativeDelegate.FNglColor3uiv));
            // yield return new ProcInfo("glColor3us", typeof(GLNativeDelegate.FNglColor3us));
            // yield return new ProcInfo("glColor3usv", typeof(GLNativeDelegate.FNglColor3usv));
            // yield return new ProcInfo("glColor4b", typeof(GLNativeDelegate.FNglColor4b));
            // yield return new ProcInfo("glColor4bv", typeof(GLNativeDelegate.FNglColor4bv));
            // yield return new ProcInfo("glColor4d", typeof(GLNativeDelegate.FNglColor4d));
            // yield return new ProcInfo("glColor4dv", typeof(GLNativeDelegate.FNglColor4dv));
            // yield return new ProcInfo("glColor4f", typeof(GLNativeDelegate.FNglColor4f));
            // yield return new ProcInfo("glColor4fv", typeof(GLNativeDelegate.FNglColor4fv));
            // yield return new ProcInfo("glColor4i", typeof(GLNativeDelegate.FNglColor4i));
            // yield return new ProcInfo("glColor4iv", typeof(GLNativeDelegate.FNglColor4iv));
            // yield return new ProcInfo("glColor4s", typeof(GLNativeDelegate.FNglColor4s));
            // yield return new ProcInfo("glColor4sv", typeof(GLNativeDelegate.FNglColor4sv));
            // yield return new ProcInfo("glColor4ub", typeof(GLNativeDelegate.FNglColor4ub));
            // yield return new ProcInfo("glColor4ubv", typeof(GLNativeDelegate.FNglColor4ubv));
            // yield return new ProcInfo("glColor4ui", typeof(GLNativeDelegate.FNglColor4ui));
            // yield return new ProcInfo("glColor4uiv", typeof(GLNativeDelegate.FNglColor4uiv));
            // yield return new ProcInfo("glColor4us", typeof(GLNativeDelegate.FNglColor4us));
            // yield return new ProcInfo("glColor4usv", typeof(GLNativeDelegate.FNglColor4usv));
            // yield return new ProcInfo("glEdgeFlag", typeof(GLNativeDelegate.FNglEdgeFlag));
            // yield return new ProcInfo("glEdgeFlagv", typeof(GLNativeDelegate.FNglEdgeFlagv));
            // yield return new ProcInfo("glEnd", typeof(GLNativeDelegate.FNglEnd));
            // yield return new ProcInfo("glIndexd", typeof(GLNativeDelegate.FNglIndexd));
            // yield return new ProcInfo("glIndexdv", typeof(GLNativeDelegate.FNglIndexdv));
            // yield return new ProcInfo("glIndexf", typeof(GLNativeDelegate.FNglIndexf));
            // yield return new ProcInfo("glIndexfv", typeof(GLNativeDelegate.FNglIndexfv));
            // yield return new ProcInfo("glIndexi", typeof(GLNativeDelegate.FNglIndexi));
            // yield return new ProcInfo("glIndexiv", typeof(GLNativeDelegate.FNglIndexiv));
            // yield return new ProcInfo("glIndexs", typeof(GLNativeDelegate.FNglIndexs));
            // yield return new ProcInfo("glIndexsv", typeof(GLNativeDelegate.FNglIndexsv));
            // yield return new ProcInfo("glNormal3b", typeof(GLNativeDelegate.FNglNormal3b));
            // yield return new ProcInfo("glNormal3bv", typeof(GLNativeDelegate.FNglNormal3bv));
            // yield return new ProcInfo("glNormal3d", typeof(GLNativeDelegate.FNglNormal3d));
            // yield return new ProcInfo("glNormal3dv", typeof(GLNativeDelegate.FNglNormal3dv));
            // yield return new ProcInfo("glNormal3f", typeof(GLNativeDelegate.FNglNormal3f));
            // yield return new ProcInfo("glNormal3fv", typeof(GLNativeDelegate.FNglNormal3fv));
            // yield return new ProcInfo("glNormal3i", typeof(GLNativeDelegate.FNglNormal3i));
            // yield return new ProcInfo("glNormal3iv", typeof(GLNativeDelegate.FNglNormal3iv));
            // yield return new ProcInfo("glNormal3s", typeof(GLNativeDelegate.FNglNormal3s));
            // yield return new ProcInfo("glNormal3sv", typeof(GLNativeDelegate.FNglNormal3sv));
            // yield return new ProcInfo("glRasterPos2d", typeof(GLNativeDelegate.FNglRasterPos2d));
            // yield return new ProcInfo("glRasterPos2dv", typeof(GLNativeDelegate.FNglRasterPos2dv));
            // yield return new ProcInfo("glRasterPos2f", typeof(GLNativeDelegate.FNglRasterPos2f));
            // yield return new ProcInfo("glRasterPos2fv", typeof(GLNativeDelegate.FNglRasterPos2fv));
            // yield return new ProcInfo("glRasterPos2i", typeof(GLNativeDelegate.FNglRasterPos2i));
            // yield return new ProcInfo("glRasterPos2iv", typeof(GLNativeDelegate.FNglRasterPos2iv));
            // yield return new ProcInfo("glRasterPos2s", typeof(GLNativeDelegate.FNglRasterPos2s));
            // yield return new ProcInfo("glRasterPos2sv", typeof(GLNativeDelegate.FNglRasterPos2sv));
            // yield return new ProcInfo("glRasterPos3d", typeof(GLNativeDelegate.FNglRasterPos3d));
            // yield return new ProcInfo("glRasterPos3dv", typeof(GLNativeDelegate.FNglRasterPos3dv));
            // yield return new ProcInfo("glRasterPos3f", typeof(GLNativeDelegate.FNglRasterPos3f));
            // yield return new ProcInfo("glRasterPos3fv", typeof(GLNativeDelegate.FNglRasterPos3fv));
            // yield return new ProcInfo("glRasterPos3i", typeof(GLNativeDelegate.FNglRasterPos3i));
            // yield return new ProcInfo("glRasterPos3iv", typeof(GLNativeDelegate.FNglRasterPos3iv));
            // yield return new ProcInfo("glRasterPos3s", typeof(GLNativeDelegate.FNglRasterPos3s));
            // yield return new ProcInfo("glRasterPos3sv", typeof(GLNativeDelegate.FNglRasterPos3sv));
            // yield return new ProcInfo("glRasterPos4d", typeof(GLNativeDelegate.FNglRasterPos4d));
            // yield return new ProcInfo("glRasterPos4dv", typeof(GLNativeDelegate.FNglRasterPos4dv));
            // yield return new ProcInfo("glRasterPos4f", typeof(GLNativeDelegate.FNglRasterPos4f));
            // yield return new ProcInfo("glRasterPos4fv", typeof(GLNativeDelegate.FNglRasterPos4fv));
            // yield return new ProcInfo("glRasterPos4i", typeof(GLNativeDelegate.FNglRasterPos4i));
            // yield return new ProcInfo("glRasterPos4iv", typeof(GLNativeDelegate.FNglRasterPos4iv));
            // yield return new ProcInfo("glRasterPos4s", typeof(GLNativeDelegate.FNglRasterPos4s));
            // yield return new ProcInfo("glRasterPos4sv", typeof(GLNativeDelegate.FNglRasterPos4sv));
            // yield return new ProcInfo("glRectd", typeof(GLNativeDelegate.FNglRectd));
            // yield return new ProcInfo("glRectdv", typeof(GLNativeDelegate.FNglRectdv));
            // yield return new ProcInfo("glRectf", typeof(GLNativeDelegate.FNglRectf));
            // yield return new ProcInfo("glRectfv", typeof(GLNativeDelegate.FNglRectfv));
            // yield return new ProcInfo("glRecti", typeof(GLNativeDelegate.FNglRecti));
            // yield return new ProcInfo("glRectiv", typeof(GLNativeDelegate.FNglRectiv));
            // yield return new ProcInfo("glRects", typeof(GLNativeDelegate.FNglRects));
            // yield return new ProcInfo("glRectsv", typeof(GLNativeDelegate.FNglRectsv));
            // yield return new ProcInfo("glTexCoord1d", typeof(GLNativeDelegate.FNglTexCoord1d));
            // yield return new ProcInfo("glTexCoord1dv", typeof(GLNativeDelegate.FNglTexCoord1dv));
            // yield return new ProcInfo("glTexCoord1f", typeof(GLNativeDelegate.FNglTexCoord1f));
            // yield return new ProcInfo("glTexCoord1fv", typeof(GLNativeDelegate.FNglTexCoord1fv));
            // yield return new ProcInfo("glTexCoord1i", typeof(GLNativeDelegate.FNglTexCoord1i));
            // yield return new ProcInfo("glTexCoord1iv", typeof(GLNativeDelegate.FNglTexCoord1iv));
            // yield return new ProcInfo("glTexCoord1s", typeof(GLNativeDelegate.FNglTexCoord1s));
            // yield return new ProcInfo("glTexCoord1sv", typeof(GLNativeDelegate.FNglTexCoord1sv));
            // yield return new ProcInfo("glTexCoord2d", typeof(GLNativeDelegate.FNglTexCoord2d));
            // yield return new ProcInfo("glTexCoord2dv", typeof(GLNativeDelegate.FNglTexCoord2dv));
            // yield return new ProcInfo("glTexCoord2f", typeof(GLNativeDelegate.FNglTexCoord2f));
            // yield return new ProcInfo("glTexCoord2fv", typeof(GLNativeDelegate.FNglTexCoord2fv));
            // yield return new ProcInfo("glTexCoord2i", typeof(GLNativeDelegate.FNglTexCoord2i));
            // yield return new ProcInfo("glTexCoord2iv", typeof(GLNativeDelegate.FNglTexCoord2iv));
            // yield return new ProcInfo("glTexCoord2s", typeof(GLNativeDelegate.FNglTexCoord2s));
            // yield return new ProcInfo("glTexCoord2sv", typeof(GLNativeDelegate.FNglTexCoord2sv));
            // yield return new ProcInfo("glTexCoord3d", typeof(GLNativeDelegate.FNglTexCoord3d));
            // yield return new ProcInfo("glTexCoord3dv", typeof(GLNativeDelegate.FNglTexCoord3dv));
            // yield return new ProcInfo("glTexCoord3f", typeof(GLNativeDelegate.FNglTexCoord3f));
            // yield return new ProcInfo("glTexCoord3fv", typeof(GLNativeDelegate.FNglTexCoord3fv));
            // yield return new ProcInfo("glTexCoord3i", typeof(GLNativeDelegate.FNglTexCoord3i));
            // yield return new ProcInfo("glTexCoord3iv", typeof(GLNativeDelegate.FNglTexCoord3iv));
            // yield return new ProcInfo("glTexCoord3s", typeof(GLNativeDelegate.FNglTexCoord3s));
            // yield return new ProcInfo("glTexCoord3sv", typeof(GLNativeDelegate.FNglTexCoord3sv));
            // yield return new ProcInfo("glTexCoord4d", typeof(GLNativeDelegate.FNglTexCoord4d));
            // yield return new ProcInfo("glTexCoord4dv", typeof(GLNativeDelegate.FNglTexCoord4dv));
            // yield return new ProcInfo("glTexCoord4f", typeof(GLNativeDelegate.FNglTexCoord4f));
            // yield return new ProcInfo("glTexCoord4fv", typeof(GLNativeDelegate.FNglTexCoord4fv));
            // yield return new ProcInfo("glTexCoord4i", typeof(GLNativeDelegate.FNglTexCoord4i));
            // yield return new ProcInfo("glTexCoord4iv", typeof(GLNativeDelegate.FNglTexCoord4iv));
            // yield return new ProcInfo("glTexCoord4s", typeof(GLNativeDelegate.FNglTexCoord4s));
            // yield return new ProcInfo("glTexCoord4sv", typeof(GLNativeDelegate.FNglTexCoord4sv));
            // yield return new ProcInfo("glVertex2d", typeof(GLNativeDelegate.FNglVertex2d));
            // yield return new ProcInfo("glVertex2dv", typeof(GLNativeDelegate.FNglVertex2dv));
            // yield return new ProcInfo("glVertex2f", typeof(GLNativeDelegate.FNglVertex2f));
            // yield return new ProcInfo("glVertex2fv", typeof(GLNativeDelegate.FNglVertex2fv));
            // yield return new ProcInfo("glVertex2i", typeof(GLNativeDelegate.FNglVertex2i));
            // yield return new ProcInfo("glVertex2iv", typeof(GLNativeDelegate.FNglVertex2iv));
            // yield return new ProcInfo("glVertex2s", typeof(GLNativeDelegate.FNglVertex2s));
            // yield return new ProcInfo("glVertex2sv", typeof(GLNativeDelegate.FNglVertex2sv));
            // yield return new ProcInfo("glVertex3d", typeof(GLNativeDelegate.FNglVertex3d));
            // yield return new ProcInfo("glVertex3dv", typeof(GLNativeDelegate.FNglVertex3dv));
            // yield return new ProcInfo("glVertex3f", typeof(GLNativeDelegate.FNglVertex3f));
            // yield return new ProcInfo("glVertex3fv", typeof(GLNativeDelegate.FNglVertex3fv));
            // yield return new ProcInfo("glVertex3i", typeof(GLNativeDelegate.FNglVertex3i));
            // yield return new ProcInfo("glVertex3iv", typeof(GLNativeDelegate.FNglVertex3iv));
            // yield return new ProcInfo("glVertex3s", typeof(GLNativeDelegate.FNglVertex3s));
            // yield return new ProcInfo("glVertex3sv", typeof(GLNativeDelegate.FNglVertex3sv));
            // yield return new ProcInfo("glVertex4d", typeof(GLNativeDelegate.FNglVertex4d));
            // yield return new ProcInfo("glVertex4dv", typeof(GLNativeDelegate.FNglVertex4dv));
            // yield return new ProcInfo("glVertex4f", typeof(GLNativeDelegate.FNglVertex4f));
            // yield return new ProcInfo("glVertex4fv", typeof(GLNativeDelegate.FNglVertex4fv));
            // yield return new ProcInfo("glVertex4i", typeof(GLNativeDelegate.FNglVertex4i));
            // yield return new ProcInfo("glVertex4iv", typeof(GLNativeDelegate.FNglVertex4iv));
            // yield return new ProcInfo("glVertex4s", typeof(GLNativeDelegate.FNglVertex4s));
            // yield return new ProcInfo("glVertex4sv", typeof(GLNativeDelegate.FNglVertex4sv));
            // yield return new ProcInfo("glClipPlane", typeof(GLNativeDelegate.FNglClipPlane));
            // yield return new ProcInfo("glColorMaterial", typeof(GLNativeDelegate.FNglColorMaterial));
            // yield return new ProcInfo("glFogf", typeof(GLNativeDelegate.FNglFogf));
            // yield return new ProcInfo("glFogfv", typeof(GLNativeDelegate.FNglFogfv));
            // yield return new ProcInfo("glFogi", typeof(GLNativeDelegate.FNglFogi));
            // yield return new ProcInfo("glFogiv", typeof(GLNativeDelegate.FNglFogiv));
            // yield return new ProcInfo("glLightf", typeof(GLNativeDelegate.FNglLightf));
            // yield return new ProcInfo("glLightfv", typeof(GLNativeDelegate.FNglLightfv));
            // yield return new ProcInfo("glLighti", typeof(GLNativeDelegate.FNglLighti));
            // yield return new ProcInfo("glLightiv", typeof(GLNativeDelegate.FNglLightiv));
            // yield return new ProcInfo("glLightModelf", typeof(GLNativeDelegate.FNglLightModelf));
            // yield return new ProcInfo("glLightModelfv", typeof(GLNativeDelegate.FNglLightModelfv));
            // yield return new ProcInfo("glLightModeli", typeof(GLNativeDelegate.FNglLightModeli));
            // yield return new ProcInfo("glLightModeliv", typeof(GLNativeDelegate.FNglLightModeliv));
            // yield return new ProcInfo("glLineStipple", typeof(GLNativeDelegate.FNglLineStipple));
            // yield return new ProcInfo("glMaterialf", typeof(GLNativeDelegate.FNglMaterialf));
            // yield return new ProcInfo("glMaterialfv", typeof(GLNativeDelegate.FNglMaterialfv));
            // yield return new ProcInfo("glMateriali", typeof(GLNativeDelegate.FNglMateriali));
            // yield return new ProcInfo("glMaterialiv", typeof(GLNativeDelegate.FNglMaterialiv));
            // yield return new ProcInfo("glPolygonStipple", typeof(GLNativeDelegate.FNglPolygonStipple));
            // yield return new ProcInfo("glShadeModel", typeof(GLNativeDelegate.FNglShadeModel));
            // yield return new ProcInfo("glTexEnvf", typeof(GLNativeDelegate.FNglTexEnvf));
            // yield return new ProcInfo("glTexEnvfv", typeof(GLNativeDelegate.FNglTexEnvfv));
            // yield return new ProcInfo("glTexEnvi", typeof(GLNativeDelegate.FNglTexEnvi));
            // yield return new ProcInfo("glTexEnviv", typeof(GLNativeDelegate.FNglTexEnviv));
            // yield return new ProcInfo("glTexGend", typeof(GLNativeDelegate.FNglTexGend));
            // yield return new ProcInfo("glTexGendv", typeof(GLNativeDelegate.FNglTexGendv));
            // yield return new ProcInfo("glTexGenf", typeof(GLNativeDelegate.FNglTexGenf));
            // yield return new ProcInfo("glTexGenfv", typeof(GLNativeDelegate.FNglTexGenfv));
            // yield return new ProcInfo("glTexGeni", typeof(GLNativeDelegate.FNglTexGeni));
            // yield return new ProcInfo("glTexGeniv", typeof(GLNativeDelegate.FNglTexGeniv));
            // yield return new ProcInfo("glFeedbackBuffer", typeof(GLNativeDelegate.FNglFeedbackBuffer));
            // yield return new ProcInfo("glSelectBuffer", typeof(GLNativeDelegate.FNglSelectBuffer));
            // yield return new ProcInfo("glRenderMode", typeof(GLNativeDelegate.FNglRenderMode));
            // yield return new ProcInfo("glInitNames", typeof(GLNativeDelegate.FNglInitNames));
            // yield return new ProcInfo("glLoadName", typeof(GLNativeDelegate.FNglLoadName));
            // yield return new ProcInfo("glPassThrough", typeof(GLNativeDelegate.FNglPassThrough));
            // yield return new ProcInfo("glPopName", typeof(GLNativeDelegate.FNglPopName));
            // yield return new ProcInfo("glPushName", typeof(GLNativeDelegate.FNglPushName));
            // yield return new ProcInfo("glClearAccum", typeof(GLNativeDelegate.FNglClearAccum));
            // yield return new ProcInfo("glClearIndex", typeof(GLNativeDelegate.FNglClearIndex));
            // yield return new ProcInfo("glIndexMask", typeof(GLNativeDelegate.FNglIndexMask));
            // yield return new ProcInfo("glAccum", typeof(GLNativeDelegate.FNglAccum));
            // yield return new ProcInfo("glPopAttrib", typeof(GLNativeDelegate.FNglPopAttrib));
            // yield return new ProcInfo("glPushAttrib", typeof(GLNativeDelegate.FNglPushAttrib));
            // yield return new ProcInfo("glMap1d", typeof(GLNativeDelegate.FNglMap1d));
            // yield return new ProcInfo("glMap1f", typeof(GLNativeDelegate.FNglMap1f));
            // yield return new ProcInfo("glMap2d", typeof(GLNativeDelegate.FNglMap2d));
            // yield return new ProcInfo("glMap2f", typeof(GLNativeDelegate.FNglMap2f));
            // yield return new ProcInfo("glMapGrid1d", typeof(GLNativeDelegate.FNglMapGrid1d));
            // yield return new ProcInfo("glMapGrid1f", typeof(GLNativeDelegate.FNglMapGrid1f));
            // yield return new ProcInfo("glMapGrid2d", typeof(GLNativeDelegate.FNglMapGrid2d));
            // yield return new ProcInfo("glMapGrid2f", typeof(GLNativeDelegate.FNglMapGrid2f));
            // yield return new ProcInfo("glEvalCoord1d", typeof(GLNativeDelegate.FNglEvalCoord1d));
            // yield return new ProcInfo("glEvalCoord1dv", typeof(GLNativeDelegate.FNglEvalCoord1dv));
            // yield return new ProcInfo("glEvalCoord1f", typeof(GLNativeDelegate.FNglEvalCoord1f));
            // yield return new ProcInfo("glEvalCoord1fv", typeof(GLNativeDelegate.FNglEvalCoord1fv));
            // yield return new ProcInfo("glEvalCoord2d", typeof(GLNativeDelegate.FNglEvalCoord2d));
            // yield return new ProcInfo("glEvalCoord2dv", typeof(GLNativeDelegate.FNglEvalCoord2dv));
            // yield return new ProcInfo("glEvalCoord2f", typeof(GLNativeDelegate.FNglEvalCoord2f));
            // yield return new ProcInfo("glEvalCoord2fv", typeof(GLNativeDelegate.FNglEvalCoord2fv));
            // yield return new ProcInfo("glEvalMesh1", typeof(GLNativeDelegate.FNglEvalMesh1));
            // yield return new ProcInfo("glEvalPoint1", typeof(GLNativeDelegate.FNglEvalPoint1));
            // yield return new ProcInfo("glEvalMesh2", typeof(GLNativeDelegate.FNglEvalMesh2));
            // yield return new ProcInfo("glEvalPoint2", typeof(GLNativeDelegate.FNglEvalPoint2));
            // yield return new ProcInfo("glAlphaFunc", typeof(GLNativeDelegate.FNglAlphaFunc));
            // yield return new ProcInfo("glPixelZoom", typeof(GLNativeDelegate.FNglPixelZoom));
            // yield return new ProcInfo("glPixelTransferf", typeof(GLNativeDelegate.FNglPixelTransferf));
            // yield return new ProcInfo("glPixelTransferi", typeof(GLNativeDelegate.FNglPixelTransferi));
            // yield return new ProcInfo("glPixelMapfv", typeof(GLNativeDelegate.FNglPixelMapfv));
            // yield return new ProcInfo("glPixelMapuiv", typeof(GLNativeDelegate.FNglPixelMapuiv));
            // yield return new ProcInfo("glPixelMapusv", typeof(GLNativeDelegate.FNglPixelMapusv));
            // yield return new ProcInfo("glCopyPixels", typeof(GLNativeDelegate.FNglCopyPixels));
            // yield return new ProcInfo("glDrawPixels", typeof(GLNativeDelegate.FNglDrawPixels));
            // yield return new ProcInfo("glGetClipPlane", typeof(GLNativeDelegate.FNglGetClipPlane));
            // yield return new ProcInfo("glGetLightfv", typeof(GLNativeDelegate.FNglGetLightfv));
            // yield return new ProcInfo("glGetLightiv", typeof(GLNativeDelegate.FNglGetLightiv));
            // yield return new ProcInfo("glGetMapdv", typeof(GLNativeDelegate.FNglGetMapdv));
            // yield return new ProcInfo("glGetMapfv", typeof(GLNativeDelegate.FNglGetMapfv));
            // yield return new ProcInfo("glGetMapiv", typeof(GLNativeDelegate.FNglGetMapiv));
            // yield return new ProcInfo("glGetMaterialfv", typeof(GLNativeDelegate.FNglGetMaterialfv));
            // yield return new ProcInfo("glGetMaterialiv", typeof(GLNativeDelegate.FNglGetMaterialiv));
            // yield return new ProcInfo("glGetPixelMapfv", typeof(GLNativeDelegate.FNglGetPixelMapfv));
            // yield return new ProcInfo("glGetPixelMapuiv", typeof(GLNativeDelegate.FNglGetPixelMapuiv));
            // yield return new ProcInfo("glGetPixelMapusv", typeof(GLNativeDelegate.FNglGetPixelMapusv));
            // yield return new ProcInfo("glGetPolygonStipple", typeof(GLNativeDelegate.FNglGetPolygonStipple));
            // yield return new ProcInfo("glGetTexEnvfv", typeof(GLNativeDelegate.FNglGetTexEnvfv));
            // yield return new ProcInfo("glGetTexEnviv", typeof(GLNativeDelegate.FNglGetTexEnviv));
            // yield return new ProcInfo("glGetTexGendv", typeof(GLNativeDelegate.FNglGetTexGendv));
            // yield return new ProcInfo("glGetTexGenfv", typeof(GLNativeDelegate.FNglGetTexGenfv));
            // yield return new ProcInfo("glGetTexGeniv", typeof(GLNativeDelegate.FNglGetTexGeniv));
            // yield return new ProcInfo("glIsList", typeof(GLNativeDelegate.FNglIsList));
            // yield return new ProcInfo("glFrustum", typeof(GLNativeDelegate.FNglFrustum));
            // yield return new ProcInfo("glLoadIdentity", typeof(GLNativeDelegate.FNglLoadIdentity));
            // yield return new ProcInfo("glLoadMatrixf", typeof(GLNativeDelegate.FNglLoadMatrixf));
            // yield return new ProcInfo("glLoadMatrixd", typeof(GLNativeDelegate.FNglLoadMatrixd));
            // yield return new ProcInfo("glMatrixMode", typeof(GLNativeDelegate.FNglMatrixMode));
            // yield return new ProcInfo("glMultMatrixf", typeof(GLNativeDelegate.FNglMultMatrixf));
            // yield return new ProcInfo("glMultMatrixd", typeof(GLNativeDelegate.FNglMultMatrixd));
            // yield return new ProcInfo("glOrtho", typeof(GLNativeDelegate.FNglOrtho));
            // yield return new ProcInfo("glPopMatrix", typeof(GLNativeDelegate.FNglPopMatrix));
            // yield return new ProcInfo("glPushMatrix", typeof(GLNativeDelegate.FNglPushMatrix));
            // yield return new ProcInfo("glRotated", typeof(GLNativeDelegate.FNglRotated));
            // yield return new ProcInfo("glRotatef", typeof(GLNativeDelegate.FNglRotatef));
            // yield return new ProcInfo("glScaled", typeof(GLNativeDelegate.FNglScaled));
            // yield return new ProcInfo("glScalef", typeof(GLNativeDelegate.FNglScalef));
            // yield return new ProcInfo("glTranslated", typeof(GLNativeDelegate.FNglTranslated));
            // yield return new ProcInfo("glTranslatef", typeof(GLNativeDelegate.FNglTranslatef));

            #endregion Compatibility-only GL 1.0 features removed from GL 3.2

            #region Compatibility-only GL 1.1 features removed from GL 3.2

            // yield return new ProcInfo("glArrayElement", typeof(GLNativeDelegate.FNglArrayElement));
            // yield return new ProcInfo("glColorPointer", typeof(GLNativeDelegate.FNglColorPointer));
            // yield return new ProcInfo("glDisableClientState", typeof(GLNativeDelegate.FNglDisableClientState));
            // yield return new ProcInfo("glEdgeFlagPointer", typeof(GLNativeDelegate.FNglEdgeFlagPointer));
            // yield return new ProcInfo("glEnableClientState", typeof(GLNativeDelegate.FNglEnableClientState));
            // yield return new ProcInfo("glIndexPointer", typeof(GLNativeDelegate.FNglIndexPointer));
            // yield return new ProcInfo("glGetPointerv", typeof(GLNativeDelegate.FNglGetPointerv));
            // yield return new ProcInfo("glInterleavedArrays", typeof(GLNativeDelegate.FNglInterleavedArrays));
            // yield return new ProcInfo("glNormalPointer", typeof(GLNativeDelegate.FNglNormalPointer));
            // yield return new ProcInfo("glTexCoordPointer", typeof(GLNativeDelegate.FNglTexCoordPointer));
            // yield return new ProcInfo("glVertexPointer", typeof(GLNativeDelegate.FNglVertexPointer));
            // yield return new ProcInfo("glAreTexturesResident", typeof(GLNativeDelegate.FNglAreTexturesResident));
            // yield return new ProcInfo("glPrioritizeTextures", typeof(GLNativeDelegate.FNglPrioritizeTextures));
            // yield return new ProcInfo("glIndexub", typeof(GLNativeDelegate.FNglIndexub));
            // yield return new ProcInfo("glIndexubv", typeof(GLNativeDelegate.FNglIndexubv));
            // yield return new ProcInfo("glPopClientAttrib", typeof(GLNativeDelegate.FNglPopClientAttrib));
            // yield return new ProcInfo("glPushClientAttrib", typeof(GLNativeDelegate.FNglPushClientAttrib));

            #endregion Compatibility-only GL 1.1 features removed from GL 3.2

            #region Compatibility-only GL 1.2 features removed from GL 3.2


            #endregion Compatibility-only GL 1.2 features removed from GL 3.2

            #region Compatibility-only GL 1.3 features removed from GL 3.2

            // yield return new ProcInfo("glClientActiveTexture", typeof(GLNativeDelegate.FNglClientActiveTexture));
            // yield return new ProcInfo("glMultiTexCoord1d", typeof(GLNativeDelegate.FNglMultiTexCoord1d));
            // yield return new ProcInfo("glMultiTexCoord1dv", typeof(GLNativeDelegate.FNglMultiTexCoord1dv));
            // yield return new ProcInfo("glMultiTexCoord1f", typeof(GLNativeDelegate.FNglMultiTexCoord1f));
            // yield return new ProcInfo("glMultiTexCoord1fv", typeof(GLNativeDelegate.FNglMultiTexCoord1fv));
            // yield return new ProcInfo("glMultiTexCoord1i", typeof(GLNativeDelegate.FNglMultiTexCoord1i));
            // yield return new ProcInfo("glMultiTexCoord1iv", typeof(GLNativeDelegate.FNglMultiTexCoord1iv));
            // yield return new ProcInfo("glMultiTexCoord1s", typeof(GLNativeDelegate.FNglMultiTexCoord1s));
            // yield return new ProcInfo("glMultiTexCoord1sv", typeof(GLNativeDelegate.FNglMultiTexCoord1sv));
            // yield return new ProcInfo("glMultiTexCoord2d", typeof(GLNativeDelegate.FNglMultiTexCoord2d));
            // yield return new ProcInfo("glMultiTexCoord2dv", typeof(GLNativeDelegate.FNglMultiTexCoord2dv));
            // yield return new ProcInfo("glMultiTexCoord2f", typeof(GLNativeDelegate.FNglMultiTexCoord2f));
            // yield return new ProcInfo("glMultiTexCoord2fv", typeof(GLNativeDelegate.FNglMultiTexCoord2fv));
            // yield return new ProcInfo("glMultiTexCoord2i", typeof(GLNativeDelegate.FNglMultiTexCoord2i));
            // yield return new ProcInfo("glMultiTexCoord2iv", typeof(GLNativeDelegate.FNglMultiTexCoord2iv));
            // yield return new ProcInfo("glMultiTexCoord2s", typeof(GLNativeDelegate.FNglMultiTexCoord2s));
            // yield return new ProcInfo("glMultiTexCoord2sv", typeof(GLNativeDelegate.FNglMultiTexCoord2sv));
            // yield return new ProcInfo("glMultiTexCoord3d", typeof(GLNativeDelegate.FNglMultiTexCoord3d));
            // yield return new ProcInfo("glMultiTexCoord3dv", typeof(GLNativeDelegate.FNglMultiTexCoord3dv));
            // yield return new ProcInfo("glMultiTexCoord3f", typeof(GLNativeDelegate.FNglMultiTexCoord3f));
            // yield return new ProcInfo("glMultiTexCoord3fv", typeof(GLNativeDelegate.FNglMultiTexCoord3fv));
            // yield return new ProcInfo("glMultiTexCoord3i", typeof(GLNativeDelegate.FNglMultiTexCoord3i));
            // yield return new ProcInfo("glMultiTexCoord3iv", typeof(GLNativeDelegate.FNglMultiTexCoord3iv));
            // yield return new ProcInfo("glMultiTexCoord3s", typeof(GLNativeDelegate.FNglMultiTexCoord3s));
            // yield return new ProcInfo("glMultiTexCoord3sv", typeof(GLNativeDelegate.FNglMultiTexCoord3sv));
            // yield return new ProcInfo("glMultiTexCoord4d", typeof(GLNativeDelegate.FNglMultiTexCoord4d));
            // yield return new ProcInfo("glMultiTexCoord4dv", typeof(GLNativeDelegate.FNglMultiTexCoord4dv));
            // yield return new ProcInfo("glMultiTexCoord4f", typeof(GLNativeDelegate.FNglMultiTexCoord4f));
            // yield return new ProcInfo("glMultiTexCoord4fv", typeof(GLNativeDelegate.FNglMultiTexCoord4fv));
            // yield return new ProcInfo("glMultiTexCoord4i", typeof(GLNativeDelegate.FNglMultiTexCoord4i));
            // yield return new ProcInfo("glMultiTexCoord4iv", typeof(GLNativeDelegate.FNglMultiTexCoord4iv));
            // yield return new ProcInfo("glMultiTexCoord4s", typeof(GLNativeDelegate.FNglMultiTexCoord4s));
            // yield return new ProcInfo("glMultiTexCoord4sv", typeof(GLNativeDelegate.FNglMultiTexCoord4sv));
            // yield return new ProcInfo("glLoadTransposeMatrixf", typeof(GLNativeDelegate.FNglLoadTransposeMatrixf));
            // yield return new ProcInfo("glLoadTransposeMatrixd", typeof(GLNativeDelegate.FNglLoadTransposeMatrixd));
            // yield return new ProcInfo("glMultTransposeMatrixf", typeof(GLNativeDelegate.FNglMultTransposeMatrixf));
            // yield return new ProcInfo("glMultTransposeMatrixd", typeof(GLNativeDelegate.FNglMultTransposeMatrixd));

            #endregion Compatibility-only GL 1.3 features removed from GL 3.2

            #region Compatibility-only GL 1.4 features removed from GL 3.2

            // yield return new ProcInfo("glFogCoordf", typeof(GLNativeDelegate.FNglFogCoordf));
            // yield return new ProcInfo("glFogCoordfv", typeof(GLNativeDelegate.FNglFogCoordfv));
            // yield return new ProcInfo("glFogCoordd", typeof(GLNativeDelegate.FNglFogCoordd));
            // yield return new ProcInfo("glFogCoorddv", typeof(GLNativeDelegate.FNglFogCoorddv));
            // yield return new ProcInfo("glFogCoordPointer", typeof(GLNativeDelegate.FNglFogCoordPointer));
            // yield return new ProcInfo("glSecondaryColor3b", typeof(GLNativeDelegate.FNglSecondaryColor3b));
            // yield return new ProcInfo("glSecondaryColor3bv", typeof(GLNativeDelegate.FNglSecondaryColor3bv));
            // yield return new ProcInfo("glSecondaryColor3d", typeof(GLNativeDelegate.FNglSecondaryColor3d));
            // yield return new ProcInfo("glSecondaryColor3dv", typeof(GLNativeDelegate.FNglSecondaryColor3dv));
            // yield return new ProcInfo("glSecondaryColor3f", typeof(GLNativeDelegate.FNglSecondaryColor3f));
            // yield return new ProcInfo("glSecondaryColor3fv", typeof(GLNativeDelegate.FNglSecondaryColor3fv));
            // yield return new ProcInfo("glSecondaryColor3i", typeof(GLNativeDelegate.FNglSecondaryColor3i));
            // yield return new ProcInfo("glSecondaryColor3iv", typeof(GLNativeDelegate.FNglSecondaryColor3iv));
            // yield return new ProcInfo("glSecondaryColor3s", typeof(GLNativeDelegate.FNglSecondaryColor3s));
            // yield return new ProcInfo("glSecondaryColor3sv", typeof(GLNativeDelegate.FNglSecondaryColor3sv));
            // yield return new ProcInfo("glSecondaryColor3ub", typeof(GLNativeDelegate.FNglSecondaryColor3ub));
            // yield return new ProcInfo("glSecondaryColor3ubv", typeof(GLNativeDelegate.FNglSecondaryColor3ubv));
            // yield return new ProcInfo("glSecondaryColor3ui", typeof(GLNativeDelegate.FNglSecondaryColor3ui));
            // yield return new ProcInfo("glSecondaryColor3uiv", typeof(GLNativeDelegate.FNglSecondaryColor3uiv));
            // yield return new ProcInfo("glSecondaryColor3us", typeof(GLNativeDelegate.FNglSecondaryColor3us));
            // yield return new ProcInfo("glSecondaryColor3usv", typeof(GLNativeDelegate.FNglSecondaryColor3usv));
            // yield return new ProcInfo("glSecondaryColorPointer", typeof(GLNativeDelegate.FNglSecondaryColorPointer));
            // yield return new ProcInfo("glWindowPos2d", typeof(GLNativeDelegate.FNglWindowPos2d));
            // yield return new ProcInfo("glWindowPos2dv", typeof(GLNativeDelegate.FNglWindowPos2dv));
            // yield return new ProcInfo("glWindowPos2f", typeof(GLNativeDelegate.FNglWindowPos2f));
            // yield return new ProcInfo("glWindowPos2fv", typeof(GLNativeDelegate.FNglWindowPos2fv));
            // yield return new ProcInfo("glWindowPos2i", typeof(GLNativeDelegate.FNglWindowPos2i));
            // yield return new ProcInfo("glWindowPos2iv", typeof(GLNativeDelegate.FNglWindowPos2iv));
            // yield return new ProcInfo("glWindowPos2s", typeof(GLNativeDelegate.FNglWindowPos2s));
            // yield return new ProcInfo("glWindowPos2sv", typeof(GLNativeDelegate.FNglWindowPos2sv));
            // yield return new ProcInfo("glWindowPos3d", typeof(GLNativeDelegate.FNglWindowPos3d));
            // yield return new ProcInfo("glWindowPos3dv", typeof(GLNativeDelegate.FNglWindowPos3dv));
            // yield return new ProcInfo("glWindowPos3f", typeof(GLNativeDelegate.FNglWindowPos3f));
            // yield return new ProcInfo("glWindowPos3fv", typeof(GLNativeDelegate.FNglWindowPos3fv));
            // yield return new ProcInfo("glWindowPos3i", typeof(GLNativeDelegate.FNglWindowPos3i));
            // yield return new ProcInfo("glWindowPos3iv", typeof(GLNativeDelegate.FNglWindowPos3iv));
            // yield return new ProcInfo("glWindowPos3s", typeof(GLNativeDelegate.FNglWindowPos3s));
            // yield return new ProcInfo("glWindowPos3sv", typeof(GLNativeDelegate.FNglWindowPos3sv));

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

            yield return new ProcInfo("glBindFragDataLocationIndexed", typeof(GLNativeDelegate.FNglBindFragDataLocationIndexed));
            yield return new ProcInfo("glGetFragDataIndex", typeof(GLNativeDelegate.FNglGetFragDataIndex));

            #endregion Reuse ARB_blend_func_extended

            #region Reuse ARB_sampler_objects

            yield return new ProcInfo("glGenSamplers", typeof(GLNativeDelegate.FNglGenSamplers));
            yield return new ProcInfo("glDeleteSamplers", typeof(GLNativeDelegate.FNglDeleteSamplers));
            yield return new ProcInfo("glIsSampler", typeof(GLNativeDelegate.FNglIsSampler));
            yield return new ProcInfo("glBindSampler", typeof(GLNativeDelegate.FNglBindSampler));
            yield return new ProcInfo("glSamplerParameteri", typeof(GLNativeDelegate.FNglSamplerParameteri));
            yield return new ProcInfo("glSamplerParameteriv", typeof(GLNativeDelegate.FNglSamplerParameteriv));
            yield return new ProcInfo("glSamplerParameterf", typeof(GLNativeDelegate.FNglSamplerParameterf));
            yield return new ProcInfo("glSamplerParameterfv", typeof(GLNativeDelegate.FNglSamplerParameterfv));
            yield return new ProcInfo("glSamplerParameterIiv", typeof(GLNativeDelegate.FNglSamplerParameterIiv));
            yield return new ProcInfo("glSamplerParameterIuiv", typeof(GLNativeDelegate.FNglSamplerParameterIuiv));
            yield return new ProcInfo("glGetSamplerParameteriv", typeof(GLNativeDelegate.FNglGetSamplerParameteriv));
            yield return new ProcInfo("glGetSamplerParameterIiv", typeof(GLNativeDelegate.FNglGetSamplerParameterIiv));
            yield return new ProcInfo("glGetSamplerParameterfv", typeof(GLNativeDelegate.FNglGetSamplerParameterfv));
            yield return new ProcInfo("glGetSamplerParameterIuiv", typeof(GLNativeDelegate.FNglGetSamplerParameterIuiv));

            #endregion Reuse ARB_sampler_objects

            #region Reuse ARB_timer_query

            yield return new ProcInfo("glQueryCounter", typeof(GLNativeDelegate.FNglQueryCounter));
            yield return new ProcInfo("glGetQueryObjecti64v", typeof(GLNativeDelegate.FNglGetQueryObjecti64v));
            yield return new ProcInfo("glGetQueryObjectui64v", typeof(GLNativeDelegate.FNglGetQueryObjectui64v));

            #endregion Reuse ARB_timer_query

            #region Reuse ARB_vertex_type_2_10_10_10_rev

            yield return new ProcInfo("glVertexAttribDivisor", typeof(GLNativeDelegate.FNglVertexAttribDivisor));
            yield return new ProcInfo("glVertexAttribP1ui", typeof(GLNativeDelegate.FNglVertexAttribP1ui));
            yield return new ProcInfo("glVertexAttribP1uiv", typeof(GLNativeDelegate.FNglVertexAttribP1uiv));
            yield return new ProcInfo("glVertexAttribP2ui", typeof(GLNativeDelegate.FNglVertexAttribP2ui));
            yield return new ProcInfo("glVertexAttribP2uiv", typeof(GLNativeDelegate.FNglVertexAttribP2uiv));
            yield return new ProcInfo("glVertexAttribP3ui", typeof(GLNativeDelegate.FNglVertexAttribP3ui));
            yield return new ProcInfo("glVertexAttribP3uiv", typeof(GLNativeDelegate.FNglVertexAttribP3uiv));
            yield return new ProcInfo("glVertexAttribP4ui", typeof(GLNativeDelegate.FNglVertexAttribP4ui));
            yield return new ProcInfo("glVertexAttribP4uiv", typeof(GLNativeDelegate.FNglVertexAttribP4uiv));

            #endregion Reuse ARB_vertex_type_2_10_10_10_rev

            #region Reuse ARB_vertex_type_2_10_10_10_rev compatibility profile

            yield return new ProcInfo("glVertexP2ui", typeof(GLNativeDelegate.FNglVertexP2ui));
            yield return new ProcInfo("glVertexP2uiv", typeof(GLNativeDelegate.FNglVertexP2uiv));
            yield return new ProcInfo("glVertexP3ui", typeof(GLNativeDelegate.FNglVertexP3ui));
            yield return new ProcInfo("glVertexP3uiv", typeof(GLNativeDelegate.FNglVertexP3uiv));
            yield return new ProcInfo("glVertexP4ui", typeof(GLNativeDelegate.FNglVertexP4ui));
            yield return new ProcInfo("glVertexP4uiv", typeof(GLNativeDelegate.FNglVertexP4uiv));
            yield return new ProcInfo("glTexCoordP1ui", typeof(GLNativeDelegate.FNglTexCoordP1ui));
            yield return new ProcInfo("glTexCoordP1uiv", typeof(GLNativeDelegate.FNglTexCoordP1uiv));
            yield return new ProcInfo("glTexCoordP2ui", typeof(GLNativeDelegate.FNglTexCoordP2ui));
            yield return new ProcInfo("glTexCoordP2uiv", typeof(GLNativeDelegate.FNglTexCoordP2uiv));
            yield return new ProcInfo("glTexCoordP3ui", typeof(GLNativeDelegate.FNglTexCoordP3ui));
            yield return new ProcInfo("glTexCoordP3uiv", typeof(GLNativeDelegate.FNglTexCoordP3uiv));
            yield return new ProcInfo("glTexCoordP4ui", typeof(GLNativeDelegate.FNglTexCoordP4ui));
            yield return new ProcInfo("glTexCoordP4uiv", typeof(GLNativeDelegate.FNglTexCoordP4uiv));
            yield return new ProcInfo("glMultiTexCoordP1ui", typeof(GLNativeDelegate.FNglMultiTexCoordP1ui));
            yield return new ProcInfo("glMultiTexCoordP1uiv", typeof(GLNativeDelegate.FNglMultiTexCoordP1uiv));
            yield return new ProcInfo("glMultiTexCoordP2ui", typeof(GLNativeDelegate.FNglMultiTexCoordP2ui));
            yield return new ProcInfo("glMultiTexCoordP2uiv", typeof(GLNativeDelegate.FNglMultiTexCoordP2uiv));
            yield return new ProcInfo("glMultiTexCoordP3ui", typeof(GLNativeDelegate.FNglMultiTexCoordP3ui));
            yield return new ProcInfo("glMultiTexCoordP3uiv", typeof(GLNativeDelegate.FNglMultiTexCoordP3uiv));
            yield return new ProcInfo("glMultiTexCoordP4ui", typeof(GLNativeDelegate.FNglMultiTexCoordP4ui));
            yield return new ProcInfo("glMultiTexCoordP4uiv", typeof(GLNativeDelegate.FNglMultiTexCoordP4uiv));
            yield return new ProcInfo("glNormalP3ui", typeof(GLNativeDelegate.FNglNormalP3ui));
            yield return new ProcInfo("glNormalP3uiv", typeof(GLNativeDelegate.FNglNormalP3uiv));
            yield return new ProcInfo("glColorP3ui", typeof(GLNativeDelegate.FNglColorP3ui));
            yield return new ProcInfo("glColorP3uiv", typeof(GLNativeDelegate.FNglColorP3uiv));
            yield return new ProcInfo("glColorP4ui", typeof(GLNativeDelegate.FNglColorP4ui));
            yield return new ProcInfo("glColorP4uiv", typeof(GLNativeDelegate.FNglColorP4uiv));
            yield return new ProcInfo("glSecondaryColorP3ui", typeof(GLNativeDelegate.FNglSecondaryColorP3ui));
            yield return new ProcInfo("glSecondaryColorP3uiv", typeof(GLNativeDelegate.FNglSecondaryColorP3uiv));

            #endregion Reuse ARB_vertex_type_2_10_10_10_rev compatibility profile

            #endregion GL_VERSION_3_3

            #region GL_VERSION_4_0

            yield return new ProcInfo("glMinSampleShading", typeof(GLNativeDelegate.FNglMinSampleShading));
            yield return new ProcInfo("glBlendEquationi", typeof(GLNativeDelegate.FNglBlendEquationi));
            yield return new ProcInfo("glBlendEquationSeparatei", typeof(GLNativeDelegate.FNglBlendEquationSeparatei));
            yield return new ProcInfo("glBlendFunci", typeof(GLNativeDelegate.FNglBlendFunci));
            yield return new ProcInfo("glBlendFuncSeparatei", typeof(GLNativeDelegate.FNglBlendFuncSeparatei));

            #region Reuse ARB_draw_indirect

            yield return new ProcInfo("glDrawArraysIndirect", typeof(GLNativeDelegate.FNglDrawArraysIndirect));
            yield return new ProcInfo("glDrawElementsIndirect", typeof(GLNativeDelegate.FNglDrawElementsIndirect));

            #endregion Reuse ARB_draw_indirect

            #region Reuse ARB_gpu_shader_fp64

            yield return new ProcInfo("glUniform1d", typeof(GLNativeDelegate.FNglUniform1d));
            yield return new ProcInfo("glUniform2d", typeof(GLNativeDelegate.FNglUniform2d));
            yield return new ProcInfo("glUniform3d", typeof(GLNativeDelegate.FNglUniform3d));
            yield return new ProcInfo("glUniform4d", typeof(GLNativeDelegate.FNglUniform4d));
            yield return new ProcInfo("glUniform1dv", typeof(GLNativeDelegate.FNglUniform1dv));
            yield return new ProcInfo("glUniform2dv", typeof(GLNativeDelegate.FNglUniform2dv));
            yield return new ProcInfo("glUniform3dv", typeof(GLNativeDelegate.FNglUniform3dv));
            yield return new ProcInfo("glUniform4dv", typeof(GLNativeDelegate.FNglUniform4dv));
            yield return new ProcInfo("glUniformMatrix2dv", typeof(GLNativeDelegate.FNglUniformMatrix2dv));
            yield return new ProcInfo("glUniformMatrix3dv", typeof(GLNativeDelegate.FNglUniformMatrix3dv));
            yield return new ProcInfo("glUniformMatrix4dv", typeof(GLNativeDelegate.FNglUniformMatrix4dv));
            yield return new ProcInfo("glUniformMatrix2x3dv", typeof(GLNativeDelegate.FNglUniformMatrix2x3dv));
            yield return new ProcInfo("glUniformMatrix2x4dv", typeof(GLNativeDelegate.FNglUniformMatrix2x4dv));
            yield return new ProcInfo("glUniformMatrix3x2dv", typeof(GLNativeDelegate.FNglUniformMatrix3x2dv));
            yield return new ProcInfo("glUniformMatrix3x4dv", typeof(GLNativeDelegate.FNglUniformMatrix3x4dv));
            yield return new ProcInfo("glUniformMatrix4x2dv", typeof(GLNativeDelegate.FNglUniformMatrix4x2dv));
            yield return new ProcInfo("glUniformMatrix4x3dv", typeof(GLNativeDelegate.FNglUniformMatrix4x3dv));
            yield return new ProcInfo("glGetUniformdv", typeof(GLNativeDelegate.FNglGetUniformdv));

            #endregion Reuse ARB_gpu_shader_fp64

            #region Reuse ARB_shader_subroutine

            yield return new ProcInfo("glGetSubroutineUniformLocation", typeof(GLNativeDelegate.FNglGetSubroutineUniformLocation));
            yield return new ProcInfo("glGetSubroutineIndex", typeof(GLNativeDelegate.FNglGetSubroutineIndex));
            yield return new ProcInfo("glGetActiveSubroutineUniformiv", typeof(GLNativeDelegate.FNglGetActiveSubroutineUniformiv));
            yield return new ProcInfo("glGetActiveSubroutineUniformName", typeof(GLNativeDelegate.FNglGetActiveSubroutineUniformName));
            yield return new ProcInfo("glGetActiveSubroutineName", typeof(GLNativeDelegate.FNglGetActiveSubroutineName));
            yield return new ProcInfo("glUniformSubroutinesuiv", typeof(GLNativeDelegate.FNglUniformSubroutinesuiv));
            yield return new ProcInfo("glGetUniformSubroutineuiv", typeof(GLNativeDelegate.FNglGetUniformSubroutineuiv));
            yield return new ProcInfo("glGetProgramStageiv", typeof(GLNativeDelegate.FNglGetProgramStageiv));

            #endregion Reuse ARB_shader_subroutine

            #region Reuse ARB_tessellation_shader

            yield return new ProcInfo("glPatchParameteri", typeof(GLNativeDelegate.FNglPatchParameteri));
            yield return new ProcInfo("glPatchParameterfv", typeof(GLNativeDelegate.FNglPatchParameterfv));

            #endregion Reuse ARB_tessellation_shader

            #region Reuse ARB_transform_feedback2

            yield return new ProcInfo("glBindTransformFeedback", typeof(GLNativeDelegate.FNglBindTransformFeedback));
            yield return new ProcInfo("glDeleteTransformFeedbacks", typeof(GLNativeDelegate.FNglDeleteTransformFeedbacks));
            yield return new ProcInfo("glGenTransformFeedbacks", typeof(GLNativeDelegate.FNglGenTransformFeedbacks));
            yield return new ProcInfo("glIsTransformFeedback", typeof(GLNativeDelegate.FNglIsTransformFeedback));
            yield return new ProcInfo("glPauseTransformFeedback", typeof(GLNativeDelegate.FNglPauseTransformFeedback));
            yield return new ProcInfo("glResumeTransformFeedback", typeof(GLNativeDelegate.FNglResumeTransformFeedback));
            yield return new ProcInfo("glDrawTransformFeedback", typeof(GLNativeDelegate.FNglDrawTransformFeedback));

            #endregion Reuse ARB_transform_feedback2

            #region Reuse ARB_transform_feedback3

            yield return new ProcInfo("glDrawTransformFeedbackStream", typeof(GLNativeDelegate.FNglDrawTransformFeedbackStream));
            yield return new ProcInfo("glBeginQueryIndexed", typeof(GLNativeDelegate.FNglBeginQueryIndexed));
            yield return new ProcInfo("glEndQueryIndexed", typeof(GLNativeDelegate.FNglEndQueryIndexed));
            yield return new ProcInfo("glGetQueryIndexediv", typeof(GLNativeDelegate.FNglGetQueryIndexediv));

            #endregion Reuse ARB_transform_feedback3

            #endregion GL_VERSION_4_0

            #region GL_VERSION_4_1


            #region Reuse commands from ARB_ES2_compatibility

            yield return new ProcInfo("glReleaseShaderCompiler", typeof(GLNativeDelegate.FNglReleaseShaderCompiler));
            yield return new ProcInfo("glShaderBinary", typeof(GLNativeDelegate.FNglShaderBinary));
            yield return new ProcInfo("glGetShaderPrecisionFormat", typeof(GLNativeDelegate.FNglGetShaderPrecisionFormat));
            yield return new ProcInfo("glDepthRangef", typeof(GLNativeDelegate.FNglDepthRangef));
            yield return new ProcInfo("glClearDepthf", typeof(GLNativeDelegate.FNglClearDepthf));

            #endregion Reuse commands from ARB_ES2_compatibility

            #region Reuse commands from ARB_get_program_binary

            yield return new ProcInfo("glGetProgramBinary", typeof(GLNativeDelegate.FNglGetProgramBinary));
            yield return new ProcInfo("glProgramBinary", typeof(GLNativeDelegate.FNglProgramBinary));
            yield return new ProcInfo("glProgramParameteri", typeof(GLNativeDelegate.FNglProgramParameteri));

            #endregion Reuse commands from ARB_get_program_binary

            #region Reuse commands from ARB_separate_shader_objects

            yield return new ProcInfo("glUseProgramStages", typeof(GLNativeDelegate.FNglUseProgramStages));
            yield return new ProcInfo("glActiveShaderProgram", typeof(GLNativeDelegate.FNglActiveShaderProgram));
            yield return new ProcInfo("glCreateShaderProgramv", typeof(GLNativeDelegate.FNglCreateShaderProgramv));
            yield return new ProcInfo("glBindProgramPipeline", typeof(GLNativeDelegate.FNglBindProgramPipeline));
            yield return new ProcInfo("glDeleteProgramPipelines", typeof(GLNativeDelegate.FNglDeleteProgramPipelines));
            yield return new ProcInfo("glGenProgramPipelines", typeof(GLNativeDelegate.FNglGenProgramPipelines));
            yield return new ProcInfo("glIsProgramPipeline", typeof(GLNativeDelegate.FNglIsProgramPipeline));
            yield return new ProcInfo("glGetProgramPipelineiv", typeof(GLNativeDelegate.FNglGetProgramPipelineiv));
            // yield return new ProcInfo("glProgramParameteri", typeof(GLNativeDelegate.FNglProgramParameteri));
            yield return new ProcInfo("glProgramUniform1i", typeof(GLNativeDelegate.FNglProgramUniform1i));
            yield return new ProcInfo("glProgramUniform1iv", typeof(GLNativeDelegate.FNglProgramUniform1iv));
            yield return new ProcInfo("glProgramUniform1f", typeof(GLNativeDelegate.FNglProgramUniform1f));
            yield return new ProcInfo("glProgramUniform1fv", typeof(GLNativeDelegate.FNglProgramUniform1fv));
            yield return new ProcInfo("glProgramUniform1d", typeof(GLNativeDelegate.FNglProgramUniform1d));
            yield return new ProcInfo("glProgramUniform1dv", typeof(GLNativeDelegate.FNglProgramUniform1dv));
            yield return new ProcInfo("glProgramUniform1ui", typeof(GLNativeDelegate.FNglProgramUniform1ui));
            yield return new ProcInfo("glProgramUniform1uiv", typeof(GLNativeDelegate.FNglProgramUniform1uiv));
            yield return new ProcInfo("glProgramUniform2i", typeof(GLNativeDelegate.FNglProgramUniform2i));
            yield return new ProcInfo("glProgramUniform2iv", typeof(GLNativeDelegate.FNglProgramUniform2iv));
            yield return new ProcInfo("glProgramUniform2f", typeof(GLNativeDelegate.FNglProgramUniform2f));
            yield return new ProcInfo("glProgramUniform2fv", typeof(GLNativeDelegate.FNglProgramUniform2fv));
            yield return new ProcInfo("glProgramUniform2d", typeof(GLNativeDelegate.FNglProgramUniform2d));
            yield return new ProcInfo("glProgramUniform2dv", typeof(GLNativeDelegate.FNglProgramUniform2dv));
            yield return new ProcInfo("glProgramUniform2ui", typeof(GLNativeDelegate.FNglProgramUniform2ui));
            yield return new ProcInfo("glProgramUniform2uiv", typeof(GLNativeDelegate.FNglProgramUniform2uiv));
            yield return new ProcInfo("glProgramUniform3i", typeof(GLNativeDelegate.FNglProgramUniform3i));
            yield return new ProcInfo("glProgramUniform3iv", typeof(GLNativeDelegate.FNglProgramUniform3iv));
            yield return new ProcInfo("glProgramUniform3f", typeof(GLNativeDelegate.FNglProgramUniform3f));
            yield return new ProcInfo("glProgramUniform3fv", typeof(GLNativeDelegate.FNglProgramUniform3fv));
            yield return new ProcInfo("glProgramUniform3d", typeof(GLNativeDelegate.FNglProgramUniform3d));
            yield return new ProcInfo("glProgramUniform3dv", typeof(GLNativeDelegate.FNglProgramUniform3dv));
            yield return new ProcInfo("glProgramUniform3ui", typeof(GLNativeDelegate.FNglProgramUniform3ui));
            yield return new ProcInfo("glProgramUniform3uiv", typeof(GLNativeDelegate.FNglProgramUniform3uiv));
            yield return new ProcInfo("glProgramUniform4i", typeof(GLNativeDelegate.FNglProgramUniform4i));
            yield return new ProcInfo("glProgramUniform4iv", typeof(GLNativeDelegate.FNglProgramUniform4iv));
            yield return new ProcInfo("glProgramUniform4f", typeof(GLNativeDelegate.FNglProgramUniform4f));
            yield return new ProcInfo("glProgramUniform4fv", typeof(GLNativeDelegate.FNglProgramUniform4fv));
            yield return new ProcInfo("glProgramUniform4d", typeof(GLNativeDelegate.FNglProgramUniform4d));
            yield return new ProcInfo("glProgramUniform4dv", typeof(GLNativeDelegate.FNglProgramUniform4dv));
            yield return new ProcInfo("glProgramUniform4ui", typeof(GLNativeDelegate.FNglProgramUniform4ui));
            yield return new ProcInfo("glProgramUniform4uiv", typeof(GLNativeDelegate.FNglProgramUniform4uiv));
            yield return new ProcInfo("glProgramUniformMatrix2fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix2fv));
            yield return new ProcInfo("glProgramUniformMatrix3fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix3fv));
            yield return new ProcInfo("glProgramUniformMatrix4fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix4fv));
            yield return new ProcInfo("glProgramUniformMatrix2dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix2dv));
            yield return new ProcInfo("glProgramUniformMatrix3dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix3dv));
            yield return new ProcInfo("glProgramUniformMatrix4dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix4dv));
            yield return new ProcInfo("glProgramUniformMatrix2x3fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix2x3fv));
            yield return new ProcInfo("glProgramUniformMatrix3x2fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix3x2fv));
            yield return new ProcInfo("glProgramUniformMatrix2x4fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix2x4fv));
            yield return new ProcInfo("glProgramUniformMatrix4x2fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix4x2fv));
            yield return new ProcInfo("glProgramUniformMatrix3x4fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix3x4fv));
            yield return new ProcInfo("glProgramUniformMatrix4x3fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix4x3fv));
            yield return new ProcInfo("glProgramUniformMatrix2x3dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix2x3dv));
            yield return new ProcInfo("glProgramUniformMatrix3x2dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix3x2dv));
            yield return new ProcInfo("glProgramUniformMatrix2x4dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix2x4dv));
            yield return new ProcInfo("glProgramUniformMatrix4x2dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix4x2dv));
            yield return new ProcInfo("glProgramUniformMatrix3x4dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix3x4dv));
            yield return new ProcInfo("glProgramUniformMatrix4x3dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix4x3dv));
            yield return new ProcInfo("glValidateProgramPipeline", typeof(GLNativeDelegate.FNglValidateProgramPipeline));
            yield return new ProcInfo("glGetProgramPipelineInfoLog", typeof(GLNativeDelegate.FNglGetProgramPipelineInfoLog));

            #endregion Reuse commands from ARB_separate_shader_objects

            #region Reuse commands from ARB_vertex_attrib_64bit

            yield return new ProcInfo("glVertexAttribL1d", typeof(GLNativeDelegate.FNglVertexAttribL1d));
            yield return new ProcInfo("glVertexAttribL2d", typeof(GLNativeDelegate.FNglVertexAttribL2d));
            yield return new ProcInfo("glVertexAttribL3d", typeof(GLNativeDelegate.FNglVertexAttribL3d));
            yield return new ProcInfo("glVertexAttribL4d", typeof(GLNativeDelegate.FNglVertexAttribL4d));
            yield return new ProcInfo("glVertexAttribL1dv", typeof(GLNativeDelegate.FNglVertexAttribL1dv));
            yield return new ProcInfo("glVertexAttribL2dv", typeof(GLNativeDelegate.FNglVertexAttribL2dv));
            yield return new ProcInfo("glVertexAttribL3dv", typeof(GLNativeDelegate.FNglVertexAttribL3dv));
            yield return new ProcInfo("glVertexAttribL4dv", typeof(GLNativeDelegate.FNglVertexAttribL4dv));
            yield return new ProcInfo("glVertexAttribLPointer", typeof(GLNativeDelegate.FNglVertexAttribLPointer));
            yield return new ProcInfo("glGetVertexAttribLdv", typeof(GLNativeDelegate.FNglGetVertexAttribLdv));

            #endregion Reuse commands from ARB_vertex_attrib_64bit

            #region Reuse commands from ARB_viewport_array

            yield return new ProcInfo("glViewportArrayv", typeof(GLNativeDelegate.FNglViewportArrayv));
            yield return new ProcInfo("glViewportIndexedf", typeof(GLNativeDelegate.FNglViewportIndexedf));
            yield return new ProcInfo("glViewportIndexedfv", typeof(GLNativeDelegate.FNglViewportIndexedfv));
            yield return new ProcInfo("glScissorArrayv", typeof(GLNativeDelegate.FNglScissorArrayv));
            yield return new ProcInfo("glScissorIndexed", typeof(GLNativeDelegate.FNglScissorIndexed));
            yield return new ProcInfo("glScissorIndexedv", typeof(GLNativeDelegate.FNglScissorIndexedv));
            yield return new ProcInfo("glDepthRangeArrayv", typeof(GLNativeDelegate.FNglDepthRangeArrayv));
            yield return new ProcInfo("glDepthRangeIndexed", typeof(GLNativeDelegate.FNglDepthRangeIndexed));
            yield return new ProcInfo("glGetFloati_v", typeof(GLNativeDelegate.FNglGetFloati_v));
            yield return new ProcInfo("glGetDoublei_v", typeof(GLNativeDelegate.FNglGetDoublei_v));

            #endregion Reuse commands from ARB_viewport_array

            #endregion GL_VERSION_4_1

            #region GL_VERSION_4_2


            #region Reuse commands from ARB_base_instance

            yield return new ProcInfo("glDrawArraysInstancedBaseInstance", typeof(GLNativeDelegate.FNglDrawArraysInstancedBaseInstance));
            yield return new ProcInfo("glDrawElementsInstancedBaseInstance", typeof(GLNativeDelegate.FNglDrawElementsInstancedBaseInstance));
            yield return new ProcInfo("glDrawElementsInstancedBaseVertexBaseInstance", typeof(GLNativeDelegate.FNglDrawElementsInstancedBaseVertexBaseInstance));

            #endregion Reuse commands from ARB_base_instance

            #region Reuse commands from ARB_internalformat_query

            yield return new ProcInfo("glGetInternalformativ", typeof(GLNativeDelegate.FNglGetInternalformativ));

            #endregion Reuse commands from ARB_internalformat_query

            #region Reuse commands from ARB_shader_atomic_counters

            yield return new ProcInfo("glGetActiveAtomicCounterBufferiv", typeof(GLNativeDelegate.FNglGetActiveAtomicCounterBufferiv));

            #endregion Reuse commands from ARB_shader_atomic_counters

            #region Reuse commands from ARB_shader_image_load_store

            yield return new ProcInfo("glBindImageTexture", typeof(GLNativeDelegate.FNglBindImageTexture));
            yield return new ProcInfo("glMemoryBarrier", typeof(GLNativeDelegate.FNglMemoryBarrier));

            #endregion Reuse commands from ARB_shader_image_load_store

            #region Reuse commands from ARB_texture_storage

            yield return new ProcInfo("glTexStorage1D", typeof(GLNativeDelegate.FNglTexStorage1D));
            yield return new ProcInfo("glTexStorage2D", typeof(GLNativeDelegate.FNglTexStorage2D));
            yield return new ProcInfo("glTexStorage3D", typeof(GLNativeDelegate.FNglTexStorage3D));

            #endregion Reuse commands from ARB_texture_storage

            #region Reuse commands from ARB_transform_feedback_instanced

            yield return new ProcInfo("glDrawTransformFeedbackInstanced", typeof(GLNativeDelegate.FNglDrawTransformFeedbackInstanced));
            yield return new ProcInfo("glDrawTransformFeedbackStreamInstanced", typeof(GLNativeDelegate.FNglDrawTransformFeedbackStreamInstanced));

            #endregion Reuse commands from ARB_transform_feedback_instanced

            #endregion GL_VERSION_4_2

            #region GL_VERSION_4_3


            #region Reuse commands from ARB_clear_buffer_object

            yield return new ProcInfo("glClearBufferData", typeof(GLNativeDelegate.FNglClearBufferData));
            yield return new ProcInfo("glClearBufferSubData", typeof(GLNativeDelegate.FNglClearBufferSubData));

            #endregion Reuse commands from ARB_clear_buffer_object

            #region Reuse commands from ARB_compute_shader

            yield return new ProcInfo("glDispatchCompute", typeof(GLNativeDelegate.FNglDispatchCompute));
            yield return new ProcInfo("glDispatchComputeIndirect", typeof(GLNativeDelegate.FNglDispatchComputeIndirect));

            #endregion Reuse commands from ARB_compute_shader

            #region Reuse commands from ARB_copy_image

            yield return new ProcInfo("glCopyImageSubData", typeof(GLNativeDelegate.FNglCopyImageSubData));

            #endregion Reuse commands from ARB_copy_image

            #region Reuse commands from ARB_framebuffer_no_attachments

            yield return new ProcInfo("glFramebufferParameteri", typeof(GLNativeDelegate.FNglFramebufferParameteri));
            yield return new ProcInfo("glGetFramebufferParameteriv", typeof(GLNativeDelegate.FNglGetFramebufferParameteriv));

            #endregion Reuse commands from ARB_framebuffer_no_attachments

            #region Reuse commands from ARB_internalformat_query2

            yield return new ProcInfo("glGetInternalformati64v", typeof(GLNativeDelegate.FNglGetInternalformati64v));

            #endregion Reuse commands from ARB_internalformat_query2

            #region Reuse commands from ARB_invalidate_subdata

            yield return new ProcInfo("glInvalidateTexSubImage", typeof(GLNativeDelegate.FNglInvalidateTexSubImage));
            yield return new ProcInfo("glInvalidateTexImage", typeof(GLNativeDelegate.FNglInvalidateTexImage));
            yield return new ProcInfo("glInvalidateBufferSubData", typeof(GLNativeDelegate.FNglInvalidateBufferSubData));
            yield return new ProcInfo("glInvalidateBufferData", typeof(GLNativeDelegate.FNglInvalidateBufferData));
            yield return new ProcInfo("glInvalidateFramebuffer", typeof(GLNativeDelegate.FNglInvalidateFramebuffer));
            yield return new ProcInfo("glInvalidateSubFramebuffer", typeof(GLNativeDelegate.FNglInvalidateSubFramebuffer));

            #endregion Reuse commands from ARB_invalidate_subdata

            #region Reuse commands from ARB_multi_draw_indirect

            yield return new ProcInfo("glMultiDrawArraysIndirect", typeof(GLNativeDelegate.FNglMultiDrawArraysIndirect));
            yield return new ProcInfo("glMultiDrawElementsIndirect", typeof(GLNativeDelegate.FNglMultiDrawElementsIndirect));

            #endregion Reuse commands from ARB_multi_draw_indirect

            #region Reuse commands from ARB_program_interface_query

            yield return new ProcInfo("glGetProgramInterfaceiv", typeof(GLNativeDelegate.FNglGetProgramInterfaceiv));
            yield return new ProcInfo("glGetProgramResourceIndex", typeof(GLNativeDelegate.FNglGetProgramResourceIndex));
            yield return new ProcInfo("glGetProgramResourceName", typeof(GLNativeDelegate.FNglGetProgramResourceName));
            yield return new ProcInfo("glGetProgramResourceiv", typeof(GLNativeDelegate.FNglGetProgramResourceiv));
            yield return new ProcInfo("glGetProgramResourceLocation", typeof(GLNativeDelegate.FNglGetProgramResourceLocation));
            yield return new ProcInfo("glGetProgramResourceLocationIndex", typeof(GLNativeDelegate.FNglGetProgramResourceLocationIndex));

            #endregion Reuse commands from ARB_program_interface_query

            #region Reuse commands from ARB_shader_storage_buffer_object

            yield return new ProcInfo("glShaderStorageBlockBinding", typeof(GLNativeDelegate.FNglShaderStorageBlockBinding));

            #endregion Reuse commands from ARB_shader_storage_buffer_object

            #region Reuse commands from ARB_texture_buffer_range

            yield return new ProcInfo("glTexBufferRange", typeof(GLNativeDelegate.FNglTexBufferRange));

            #endregion Reuse commands from ARB_texture_buffer_range

            #region Reuse commands from ARB_texture_storage_multisample

            yield return new ProcInfo("glTexStorage2DMultisample", typeof(GLNativeDelegate.FNglTexStorage2DMultisample));
            yield return new ProcInfo("glTexStorage3DMultisample", typeof(GLNativeDelegate.FNglTexStorage3DMultisample));

            #endregion Reuse commands from ARB_texture_storage_multisample

            #region Reuse commands from ARB_texture_view

            yield return new ProcInfo("glTextureView", typeof(GLNativeDelegate.FNglTextureView));

            #endregion Reuse commands from ARB_texture_view

            #region Reuse commands from ARB_vertex_attrib_binding

            yield return new ProcInfo("glBindVertexBuffer", typeof(GLNativeDelegate.FNglBindVertexBuffer));
            yield return new ProcInfo("glVertexAttribFormat", typeof(GLNativeDelegate.FNglVertexAttribFormat));
            yield return new ProcInfo("glVertexAttribIFormat", typeof(GLNativeDelegate.FNglVertexAttribIFormat));
            yield return new ProcInfo("glVertexAttribLFormat", typeof(GLNativeDelegate.FNglVertexAttribLFormat));
            yield return new ProcInfo("glVertexAttribBinding", typeof(GLNativeDelegate.FNglVertexAttribBinding));
            yield return new ProcInfo("glVertexBindingDivisor", typeof(GLNativeDelegate.FNglVertexBindingDivisor));

            #endregion Reuse commands from ARB_vertex_attrib_binding

            #region Reuse commands from KHR_debug (includes ARB_debug_output commands promoted to KHR without suffixes)

            yield return new ProcInfo("glDebugMessageControl", typeof(GLNativeDelegate.FNglDebugMessageControl));
            yield return new ProcInfo("glDebugMessageInsert", typeof(GLNativeDelegate.FNglDebugMessageInsert));
            yield return new ProcInfo("glDebugMessageCallback", typeof(GLNativeDelegate.FNglDebugMessageCallback));
            yield return new ProcInfo("glGetDebugMessageLog", typeof(GLNativeDelegate.FNglGetDebugMessageLog));
            yield return new ProcInfo("glPushDebugGroup", typeof(GLNativeDelegate.FNglPushDebugGroup));
            yield return new ProcInfo("glPopDebugGroup", typeof(GLNativeDelegate.FNglPopDebugGroup));
            yield return new ProcInfo("glObjectLabel", typeof(GLNativeDelegate.FNglObjectLabel));
            yield return new ProcInfo("glGetObjectLabel", typeof(GLNativeDelegate.FNglGetObjectLabel));
            yield return new ProcInfo("glObjectPtrLabel", typeof(GLNativeDelegate.FNglObjectPtrLabel));
            yield return new ProcInfo("glGetObjectPtrLabel", typeof(GLNativeDelegate.FNglGetObjectPtrLabel));
            // yield return new ProcInfo("glGetPointerv", typeof(GLNativeDelegate.FNglGetPointerv));

            #endregion Reuse commands from KHR_debug (includes ARB_debug_output commands promoted to KHR without suffixes)

            #endregion GL_VERSION_4_3

            #region GL_VERSION_4_4


            #region Reuse GL_ARB_buffer_storage

            yield return new ProcInfo("glBufferStorage", typeof(GLNativeDelegate.FNglBufferStorage));

            #endregion Reuse GL_ARB_buffer_storage

            #region Reuse GL_ARB_clear_texture

            yield return new ProcInfo("glClearTexImage", typeof(GLNativeDelegate.FNglClearTexImage));
            yield return new ProcInfo("glClearTexSubImage", typeof(GLNativeDelegate.FNglClearTexSubImage));

            #endregion Reuse GL_ARB_clear_texture

            #region Reuse GL_ARB_multi_bind (none)

            yield return new ProcInfo("glBindBuffersBase", typeof(GLNativeDelegate.FNglBindBuffersBase));
            yield return new ProcInfo("glBindBuffersRange", typeof(GLNativeDelegate.FNglBindBuffersRange));
            yield return new ProcInfo("glBindTextures", typeof(GLNativeDelegate.FNglBindTextures));
            yield return new ProcInfo("glBindSamplers", typeof(GLNativeDelegate.FNglBindSamplers));
            yield return new ProcInfo("glBindImageTextures", typeof(GLNativeDelegate.FNglBindImageTextures));
            yield return new ProcInfo("glBindVertexBuffers", typeof(GLNativeDelegate.FNglBindVertexBuffers));

            #endregion Reuse GL_ARB_multi_bind (none)

            #endregion GL_VERSION_4_4

            #region GL_VERSION_4_5


            #region Reuse GL_ARB_clip_control

            yield return new ProcInfo("glClipControl", typeof(GLNativeDelegate.FNglClipControl));

            #endregion Reuse GL_ARB_clip_control

            #region Reuse GL_ARB_direct_state_access

            yield return new ProcInfo("glCreateTransformFeedbacks", typeof(GLNativeDelegate.FNglCreateTransformFeedbacks));
            yield return new ProcInfo("glTransformFeedbackBufferBase", typeof(GLNativeDelegate.FNglTransformFeedbackBufferBase));
            yield return new ProcInfo("glTransformFeedbackBufferRange", typeof(GLNativeDelegate.FNglTransformFeedbackBufferRange));
            yield return new ProcInfo("glGetTransformFeedbackiv", typeof(GLNativeDelegate.FNglGetTransformFeedbackiv));
            yield return new ProcInfo("glGetTransformFeedbacki_v", typeof(GLNativeDelegate.FNglGetTransformFeedbacki_v));
            yield return new ProcInfo("glGetTransformFeedbacki64_v", typeof(GLNativeDelegate.FNglGetTransformFeedbacki64_v));
            yield return new ProcInfo("glCreateBuffers", typeof(GLNativeDelegate.FNglCreateBuffers));
            yield return new ProcInfo("glNamedBufferStorage", typeof(GLNativeDelegate.FNglNamedBufferStorage));
            yield return new ProcInfo("glNamedBufferData", typeof(GLNativeDelegate.FNglNamedBufferData));
            yield return new ProcInfo("glNamedBufferSubData", typeof(GLNativeDelegate.FNglNamedBufferSubData));
            yield return new ProcInfo("glCopyNamedBufferSubData", typeof(GLNativeDelegate.FNglCopyNamedBufferSubData));
            yield return new ProcInfo("glClearNamedBufferData", typeof(GLNativeDelegate.FNglClearNamedBufferData));
            yield return new ProcInfo("glClearNamedBufferSubData", typeof(GLNativeDelegate.FNglClearNamedBufferSubData));
            yield return new ProcInfo("glMapNamedBuffer", typeof(GLNativeDelegate.FNglMapNamedBuffer));
            yield return new ProcInfo("glMapNamedBufferRange", typeof(GLNativeDelegate.FNglMapNamedBufferRange));
            yield return new ProcInfo("glUnmapNamedBuffer", typeof(GLNativeDelegate.FNglUnmapNamedBuffer));
            yield return new ProcInfo("glFlushMappedNamedBufferRange", typeof(GLNativeDelegate.FNglFlushMappedNamedBufferRange));
            yield return new ProcInfo("glGetNamedBufferParameteriv", typeof(GLNativeDelegate.FNglGetNamedBufferParameteriv));
            yield return new ProcInfo("glGetNamedBufferParameteri64v", typeof(GLNativeDelegate.FNglGetNamedBufferParameteri64v));
            yield return new ProcInfo("glGetNamedBufferPointerv", typeof(GLNativeDelegate.FNglGetNamedBufferPointerv));
            yield return new ProcInfo("glGetNamedBufferSubData", typeof(GLNativeDelegate.FNglGetNamedBufferSubData));
            yield return new ProcInfo("glCreateFramebuffers", typeof(GLNativeDelegate.FNglCreateFramebuffers));
            yield return new ProcInfo("glNamedFramebufferRenderbuffer", typeof(GLNativeDelegate.FNglNamedFramebufferRenderbuffer));
            yield return new ProcInfo("glNamedFramebufferParameteri", typeof(GLNativeDelegate.FNglNamedFramebufferParameteri));
            yield return new ProcInfo("glNamedFramebufferTexture", typeof(GLNativeDelegate.FNglNamedFramebufferTexture));
            yield return new ProcInfo("glNamedFramebufferTextureLayer", typeof(GLNativeDelegate.FNglNamedFramebufferTextureLayer));
            yield return new ProcInfo("glNamedFramebufferDrawBuffer", typeof(GLNativeDelegate.FNglNamedFramebufferDrawBuffer));
            yield return new ProcInfo("glNamedFramebufferDrawBuffers", typeof(GLNativeDelegate.FNglNamedFramebufferDrawBuffers));
            yield return new ProcInfo("glNamedFramebufferReadBuffer", typeof(GLNativeDelegate.FNglNamedFramebufferReadBuffer));
            yield return new ProcInfo("glInvalidateNamedFramebufferData", typeof(GLNativeDelegate.FNglInvalidateNamedFramebufferData));
            yield return new ProcInfo("glInvalidateNamedFramebufferSubData", typeof(GLNativeDelegate.FNglInvalidateNamedFramebufferSubData));
            yield return new ProcInfo("glClearNamedFramebufferiv", typeof(GLNativeDelegate.FNglClearNamedFramebufferiv));
            yield return new ProcInfo("glClearNamedFramebufferuiv", typeof(GLNativeDelegate.FNglClearNamedFramebufferuiv));
            yield return new ProcInfo("glClearNamedFramebufferfv", typeof(GLNativeDelegate.FNglClearNamedFramebufferfv));
            yield return new ProcInfo("glClearNamedFramebufferfi", typeof(GLNativeDelegate.FNglClearNamedFramebufferfi));
            yield return new ProcInfo("glBlitNamedFramebuffer", typeof(GLNativeDelegate.FNglBlitNamedFramebuffer));
            yield return new ProcInfo("glCheckNamedFramebufferStatus", typeof(GLNativeDelegate.FNglCheckNamedFramebufferStatus));
            yield return new ProcInfo("glGetNamedFramebufferParameteriv", typeof(GLNativeDelegate.FNglGetNamedFramebufferParameteriv));
            yield return new ProcInfo("glGetNamedFramebufferAttachmentParameteriv", typeof(GLNativeDelegate.FNglGetNamedFramebufferAttachmentParameteriv));
            yield return new ProcInfo("glCreateRenderbuffers", typeof(GLNativeDelegate.FNglCreateRenderbuffers));
            yield return new ProcInfo("glNamedRenderbufferStorage", typeof(GLNativeDelegate.FNglNamedRenderbufferStorage));
            yield return new ProcInfo("glNamedRenderbufferStorageMultisample", typeof(GLNativeDelegate.FNglNamedRenderbufferStorageMultisample));
            yield return new ProcInfo("glGetNamedRenderbufferParameteriv", typeof(GLNativeDelegate.FNglGetNamedRenderbufferParameteriv));
            yield return new ProcInfo("glCreateTextures", typeof(GLNativeDelegate.FNglCreateTextures));
            yield return new ProcInfo("glTextureBuffer", typeof(GLNativeDelegate.FNglTextureBuffer));
            yield return new ProcInfo("glTextureBufferRange", typeof(GLNativeDelegate.FNglTextureBufferRange));
            yield return new ProcInfo("glTextureStorage1D", typeof(GLNativeDelegate.FNglTextureStorage1D));
            yield return new ProcInfo("glTextureStorage2D", typeof(GLNativeDelegate.FNglTextureStorage2D));
            yield return new ProcInfo("glTextureStorage3D", typeof(GLNativeDelegate.FNglTextureStorage3D));
            yield return new ProcInfo("glTextureStorage2DMultisample", typeof(GLNativeDelegate.FNglTextureStorage2DMultisample));
            yield return new ProcInfo("glTextureStorage3DMultisample", typeof(GLNativeDelegate.FNglTextureStorage3DMultisample));
            yield return new ProcInfo("glTextureSubImage1D", typeof(GLNativeDelegate.FNglTextureSubImage1D));
            yield return new ProcInfo("glTextureSubImage2D", typeof(GLNativeDelegate.FNglTextureSubImage2D));
            yield return new ProcInfo("glTextureSubImage3D", typeof(GLNativeDelegate.FNglTextureSubImage3D));
            yield return new ProcInfo("glCompressedTextureSubImage1D", typeof(GLNativeDelegate.FNglCompressedTextureSubImage1D));
            yield return new ProcInfo("glCompressedTextureSubImage2D", typeof(GLNativeDelegate.FNglCompressedTextureSubImage2D));
            yield return new ProcInfo("glCompressedTextureSubImage3D", typeof(GLNativeDelegate.FNglCompressedTextureSubImage3D));
            yield return new ProcInfo("glCopyTextureSubImage1D", typeof(GLNativeDelegate.FNglCopyTextureSubImage1D));
            yield return new ProcInfo("glCopyTextureSubImage2D", typeof(GLNativeDelegate.FNglCopyTextureSubImage2D));
            yield return new ProcInfo("glCopyTextureSubImage3D", typeof(GLNativeDelegate.FNglCopyTextureSubImage3D));
            yield return new ProcInfo("glTextureParameterf", typeof(GLNativeDelegate.FNglTextureParameterf));
            yield return new ProcInfo("glTextureParameterfv", typeof(GLNativeDelegate.FNglTextureParameterfv));
            yield return new ProcInfo("glTextureParameteri", typeof(GLNativeDelegate.FNglTextureParameteri));
            yield return new ProcInfo("glTextureParameterIiv", typeof(GLNativeDelegate.FNglTextureParameterIiv));
            yield return new ProcInfo("glTextureParameterIuiv", typeof(GLNativeDelegate.FNglTextureParameterIuiv));
            yield return new ProcInfo("glTextureParameteriv", typeof(GLNativeDelegate.FNglTextureParameteriv));
            yield return new ProcInfo("glGenerateTextureMipmap", typeof(GLNativeDelegate.FNglGenerateTextureMipmap));
            yield return new ProcInfo("glBindTextureUnit", typeof(GLNativeDelegate.FNglBindTextureUnit));
            yield return new ProcInfo("glGetTextureImage", typeof(GLNativeDelegate.FNglGetTextureImage));
            yield return new ProcInfo("glGetCompressedTextureImage", typeof(GLNativeDelegate.FNglGetCompressedTextureImage));
            yield return new ProcInfo("glGetTextureLevelParameterfv", typeof(GLNativeDelegate.FNglGetTextureLevelParameterfv));
            yield return new ProcInfo("glGetTextureLevelParameteriv", typeof(GLNativeDelegate.FNglGetTextureLevelParameteriv));
            yield return new ProcInfo("glGetTextureParameterfv", typeof(GLNativeDelegate.FNglGetTextureParameterfv));
            yield return new ProcInfo("glGetTextureParameterIiv", typeof(GLNativeDelegate.FNglGetTextureParameterIiv));
            yield return new ProcInfo("glGetTextureParameterIuiv", typeof(GLNativeDelegate.FNglGetTextureParameterIuiv));
            yield return new ProcInfo("glGetTextureParameteriv", typeof(GLNativeDelegate.FNglGetTextureParameteriv));
            yield return new ProcInfo("glCreateVertexArrays", typeof(GLNativeDelegate.FNglCreateVertexArrays));
            yield return new ProcInfo("glDisableVertexArrayAttrib", typeof(GLNativeDelegate.FNglDisableVertexArrayAttrib));
            yield return new ProcInfo("glEnableVertexArrayAttrib", typeof(GLNativeDelegate.FNglEnableVertexArrayAttrib));
            yield return new ProcInfo("glVertexArrayElementBuffer", typeof(GLNativeDelegate.FNglVertexArrayElementBuffer));
            yield return new ProcInfo("glVertexArrayVertexBuffer", typeof(GLNativeDelegate.FNglVertexArrayVertexBuffer));
            yield return new ProcInfo("glVertexArrayVertexBuffers", typeof(GLNativeDelegate.FNglVertexArrayVertexBuffers));
            yield return new ProcInfo("glVertexArrayAttribBinding", typeof(GLNativeDelegate.FNglVertexArrayAttribBinding));
            yield return new ProcInfo("glVertexArrayAttribFormat", typeof(GLNativeDelegate.FNglVertexArrayAttribFormat));
            yield return new ProcInfo("glVertexArrayAttribIFormat", typeof(GLNativeDelegate.FNglVertexArrayAttribIFormat));
            yield return new ProcInfo("glVertexArrayAttribLFormat", typeof(GLNativeDelegate.FNglVertexArrayAttribLFormat));
            yield return new ProcInfo("glVertexArrayBindingDivisor", typeof(GLNativeDelegate.FNglVertexArrayBindingDivisor));
            yield return new ProcInfo("glGetVertexArrayiv", typeof(GLNativeDelegate.FNglGetVertexArrayiv));
            yield return new ProcInfo("glGetVertexArrayIndexediv", typeof(GLNativeDelegate.FNglGetVertexArrayIndexediv));
            yield return new ProcInfo("glGetVertexArrayIndexed64iv", typeof(GLNativeDelegate.FNglGetVertexArrayIndexed64iv));
            yield return new ProcInfo("glCreateSamplers", typeof(GLNativeDelegate.FNglCreateSamplers));
            yield return new ProcInfo("glCreateProgramPipelines", typeof(GLNativeDelegate.FNglCreateProgramPipelines));
            yield return new ProcInfo("glCreateQueries", typeof(GLNativeDelegate.FNglCreateQueries));
            yield return new ProcInfo("glGetQueryBufferObjecti64v", typeof(GLNativeDelegate.FNglGetQueryBufferObjecti64v));
            yield return new ProcInfo("glGetQueryBufferObjectiv", typeof(GLNativeDelegate.FNglGetQueryBufferObjectiv));
            yield return new ProcInfo("glGetQueryBufferObjectui64v", typeof(GLNativeDelegate.FNglGetQueryBufferObjectui64v));
            yield return new ProcInfo("glGetQueryBufferObjectuiv", typeof(GLNativeDelegate.FNglGetQueryBufferObjectuiv));

            #endregion Reuse GL_ARB_direct_state_access

            #region Reuse GL_ARB_ES3_1_compatibility

            yield return new ProcInfo("glMemoryBarrierByRegion", typeof(GLNativeDelegate.FNglMemoryBarrierByRegion));

            #endregion Reuse GL_ARB_ES3_1_compatibility

            #region Reuse GL_ARB_get_texture_sub_image

            yield return new ProcInfo("glGetTextureSubImage", typeof(GLNativeDelegate.FNglGetTextureSubImage));
            yield return new ProcInfo("glGetCompressedTextureSubImage", typeof(GLNativeDelegate.FNglGetCompressedTextureSubImage));

            #endregion Reuse GL_ARB_get_texture_sub_image

            #region Reuse GL_ARB_robustness

            yield return new ProcInfo("glGetGraphicsResetStatus", typeof(GLNativeDelegate.FNglGetGraphicsResetStatus));
            yield return new ProcInfo("glGetnCompressedTexImage", typeof(GLNativeDelegate.FNglGetnCompressedTexImage));
            yield return new ProcInfo("glGetnTexImage", typeof(GLNativeDelegate.FNglGetnTexImage));
            yield return new ProcInfo("glGetnUniformdv", typeof(GLNativeDelegate.FNglGetnUniformdv));
            yield return new ProcInfo("glGetnUniformfv", typeof(GLNativeDelegate.FNglGetnUniformfv));
            yield return new ProcInfo("glGetnUniformiv", typeof(GLNativeDelegate.FNglGetnUniformiv));
            yield return new ProcInfo("glGetnUniformuiv", typeof(GLNativeDelegate.FNglGetnUniformuiv));
            yield return new ProcInfo("glReadnPixels", typeof(GLNativeDelegate.FNglReadnPixels));

            #endregion Reuse GL_ARB_robustness

            #region Reuse GL_ARB_robustness

            yield return new ProcInfo("glGetnMapdv", typeof(GLNativeDelegate.FNglGetnMapdv));
            yield return new ProcInfo("glGetnMapfv", typeof(GLNativeDelegate.FNglGetnMapfv));
            yield return new ProcInfo("glGetnMapiv", typeof(GLNativeDelegate.FNglGetnMapiv));
            yield return new ProcInfo("glGetnPixelMapfv", typeof(GLNativeDelegate.FNglGetnPixelMapfv));
            yield return new ProcInfo("glGetnPixelMapuiv", typeof(GLNativeDelegate.FNglGetnPixelMapuiv));
            yield return new ProcInfo("glGetnPixelMapusv", typeof(GLNativeDelegate.FNglGetnPixelMapusv));
            yield return new ProcInfo("glGetnPolygonStipple", typeof(GLNativeDelegate.FNglGetnPolygonStipple));
            yield return new ProcInfo("glGetnColorTable", typeof(GLNativeDelegate.FNglGetnColorTable));
            yield return new ProcInfo("glGetnConvolutionFilter", typeof(GLNativeDelegate.FNglGetnConvolutionFilter));
            yield return new ProcInfo("glGetnSeparableFilter", typeof(GLNativeDelegate.FNglGetnSeparableFilter));
            yield return new ProcInfo("glGetnHistogram", typeof(GLNativeDelegate.FNglGetnHistogram));
            yield return new ProcInfo("glGetnMinmax", typeof(GLNativeDelegate.FNglGetnMinmax));

            #endregion Reuse GL_ARB_robustness

            #region Reuse GL_ARB_texture_barrier

            yield return new ProcInfo("glTextureBarrier", typeof(GLNativeDelegate.FNglTextureBarrier));

            #endregion Reuse GL_ARB_texture_barrier

            #endregion GL_VERSION_4_5

            #region GL_VERSION_4_6


            #region Reuse GL_ARB_gl_spirv

            yield return new ProcInfo("glSpecializeShader", typeof(GLNativeDelegate.FNglSpecializeShader));

            #endregion Reuse GL_ARB_gl_spirv

            #region Reuse GL_ARB_indirect_parameters

            yield return new ProcInfo("glMultiDrawArraysIndirectCount", typeof(GLNativeDelegate.FNglMultiDrawArraysIndirectCount));
            yield return new ProcInfo("glMultiDrawElementsIndirectCount", typeof(GLNativeDelegate.FNglMultiDrawElementsIndirectCount));

            #endregion Reuse GL_ARB_indirect_parameters

            #region Reuse GL_ARB_polygon_offset_clamp

            yield return new ProcInfo("glPolygonOffsetClamp", typeof(GLNativeDelegate.FNglPolygonOffsetClamp));

            #endregion Reuse GL_ARB_polygon_offset_clamp

            #endregion GL_VERSION_4_6

            #region GL_3DFX_tbuffer

            yield return new ProcInfo("glTbufferMask3DFX", typeof(GLNativeDelegate.FNglTbufferMask3DFX));

            #endregion GL_3DFX_tbuffer

            #region GL_AMD_debug_output

            yield return new ProcInfo("glDebugMessageEnableAMD", typeof(GLNativeDelegate.FNglDebugMessageEnableAMD));
            yield return new ProcInfo("glDebugMessageInsertAMD", typeof(GLNativeDelegate.FNglDebugMessageInsertAMD));
            yield return new ProcInfo("glDebugMessageCallbackAMD", typeof(GLNativeDelegate.FNglDebugMessageCallbackAMD));
            yield return new ProcInfo("glGetDebugMessageLogAMD", typeof(GLNativeDelegate.FNglGetDebugMessageLogAMD));

            #endregion GL_AMD_debug_output

            #region GL_AMD_draw_buffers_blend

            yield return new ProcInfo("glBlendFuncIndexedAMD", typeof(GLNativeDelegate.FNglBlendFuncIndexedAMD));
            yield return new ProcInfo("glBlendFuncSeparateIndexedAMD", typeof(GLNativeDelegate.FNglBlendFuncSeparateIndexedAMD));
            yield return new ProcInfo("glBlendEquationIndexedAMD", typeof(GLNativeDelegate.FNglBlendEquationIndexedAMD));
            yield return new ProcInfo("glBlendEquationSeparateIndexedAMD", typeof(GLNativeDelegate.FNglBlendEquationSeparateIndexedAMD));

            #endregion GL_AMD_draw_buffers_blend

            #region GL_AMD_framebuffer_multisample_advanced

            yield return new ProcInfo("glRenderbufferStorageMultisampleAdvancedAMD", typeof(GLNativeDelegate.FNglRenderbufferStorageMultisampleAdvancedAMD));
            yield return new ProcInfo("glNamedRenderbufferStorageMultisampleAdvancedAMD", typeof(GLNativeDelegate.FNglNamedRenderbufferStorageMultisampleAdvancedAMD));

            #endregion GL_AMD_framebuffer_multisample_advanced

            #region GL_AMD_framebuffer_sample_positions

            yield return new ProcInfo("glFramebufferSamplePositionsfvAMD", typeof(GLNativeDelegate.FNglFramebufferSamplePositionsfvAMD));
            yield return new ProcInfo("glNamedFramebufferSamplePositionsfvAMD", typeof(GLNativeDelegate.FNglNamedFramebufferSamplePositionsfvAMD));
            yield return new ProcInfo("glGetFramebufferParameterfvAMD", typeof(GLNativeDelegate.FNglGetFramebufferParameterfvAMD));
            yield return new ProcInfo("glGetNamedFramebufferParameterfvAMD", typeof(GLNativeDelegate.FNglGetNamedFramebufferParameterfvAMD));

            #endregion GL_AMD_framebuffer_sample_positions

            #region GL_AMD_gpu_shader_int64

            yield return new ProcInfo("glUniform1i64NV", typeof(GLNativeDelegate.FNglUniform1i64NV));
            yield return new ProcInfo("glUniform2i64NV", typeof(GLNativeDelegate.FNglUniform2i64NV));
            yield return new ProcInfo("glUniform3i64NV", typeof(GLNativeDelegate.FNglUniform3i64NV));
            yield return new ProcInfo("glUniform4i64NV", typeof(GLNativeDelegate.FNglUniform4i64NV));
            yield return new ProcInfo("glUniform1i64vNV", typeof(GLNativeDelegate.FNglUniform1i64vNV));
            yield return new ProcInfo("glUniform2i64vNV", typeof(GLNativeDelegate.FNglUniform2i64vNV));
            yield return new ProcInfo("glUniform3i64vNV", typeof(GLNativeDelegate.FNglUniform3i64vNV));
            yield return new ProcInfo("glUniform4i64vNV", typeof(GLNativeDelegate.FNglUniform4i64vNV));
            yield return new ProcInfo("glUniform1ui64NV", typeof(GLNativeDelegate.FNglUniform1ui64NV));
            yield return new ProcInfo("glUniform2ui64NV", typeof(GLNativeDelegate.FNglUniform2ui64NV));
            yield return new ProcInfo("glUniform3ui64NV", typeof(GLNativeDelegate.FNglUniform3ui64NV));
            yield return new ProcInfo("glUniform4ui64NV", typeof(GLNativeDelegate.FNglUniform4ui64NV));
            yield return new ProcInfo("glUniform1ui64vNV", typeof(GLNativeDelegate.FNglUniform1ui64vNV));
            yield return new ProcInfo("glUniform2ui64vNV", typeof(GLNativeDelegate.FNglUniform2ui64vNV));
            yield return new ProcInfo("glUniform3ui64vNV", typeof(GLNativeDelegate.FNglUniform3ui64vNV));
            yield return new ProcInfo("glUniform4ui64vNV", typeof(GLNativeDelegate.FNglUniform4ui64vNV));
            yield return new ProcInfo("glGetUniformi64vNV", typeof(GLNativeDelegate.FNglGetUniformi64vNV));
            yield return new ProcInfo("glGetUniformui64vNV", typeof(GLNativeDelegate.FNglGetUniformui64vNV));
            yield return new ProcInfo("glProgramUniform1i64NV", typeof(GLNativeDelegate.FNglProgramUniform1i64NV));
            yield return new ProcInfo("glProgramUniform2i64NV", typeof(GLNativeDelegate.FNglProgramUniform2i64NV));
            yield return new ProcInfo("glProgramUniform3i64NV", typeof(GLNativeDelegate.FNglProgramUniform3i64NV));
            yield return new ProcInfo("glProgramUniform4i64NV", typeof(GLNativeDelegate.FNglProgramUniform4i64NV));
            yield return new ProcInfo("glProgramUniform1i64vNV", typeof(GLNativeDelegate.FNglProgramUniform1i64vNV));
            yield return new ProcInfo("glProgramUniform2i64vNV", typeof(GLNativeDelegate.FNglProgramUniform2i64vNV));
            yield return new ProcInfo("glProgramUniform3i64vNV", typeof(GLNativeDelegate.FNglProgramUniform3i64vNV));
            yield return new ProcInfo("glProgramUniform4i64vNV", typeof(GLNativeDelegate.FNglProgramUniform4i64vNV));
            yield return new ProcInfo("glProgramUniform1ui64NV", typeof(GLNativeDelegate.FNglProgramUniform1ui64NV));
            yield return new ProcInfo("glProgramUniform2ui64NV", typeof(GLNativeDelegate.FNglProgramUniform2ui64NV));
            yield return new ProcInfo("glProgramUniform3ui64NV", typeof(GLNativeDelegate.FNglProgramUniform3ui64NV));
            yield return new ProcInfo("glProgramUniform4ui64NV", typeof(GLNativeDelegate.FNglProgramUniform4ui64NV));
            yield return new ProcInfo("glProgramUniform1ui64vNV", typeof(GLNativeDelegate.FNglProgramUniform1ui64vNV));
            yield return new ProcInfo("glProgramUniform2ui64vNV", typeof(GLNativeDelegate.FNglProgramUniform2ui64vNV));
            yield return new ProcInfo("glProgramUniform3ui64vNV", typeof(GLNativeDelegate.FNglProgramUniform3ui64vNV));
            yield return new ProcInfo("glProgramUniform4ui64vNV", typeof(GLNativeDelegate.FNglProgramUniform4ui64vNV));

            #endregion GL_AMD_gpu_shader_int64

            #region GL_AMD_interleaved_elements

            yield return new ProcInfo("glVertexAttribParameteriAMD", typeof(GLNativeDelegate.FNglVertexAttribParameteriAMD));

            #endregion GL_AMD_interleaved_elements

            #region GL_AMD_multi_draw_indirect

            yield return new ProcInfo("glMultiDrawArraysIndirectAMD", typeof(GLNativeDelegate.FNglMultiDrawArraysIndirectAMD));
            yield return new ProcInfo("glMultiDrawElementsIndirectAMD", typeof(GLNativeDelegate.FNglMultiDrawElementsIndirectAMD));

            #endregion GL_AMD_multi_draw_indirect

            #region GL_AMD_name_gen_delete

            yield return new ProcInfo("glGenNamesAMD", typeof(GLNativeDelegate.FNglGenNamesAMD));
            yield return new ProcInfo("glDeleteNamesAMD", typeof(GLNativeDelegate.FNglDeleteNamesAMD));
            yield return new ProcInfo("glIsNameAMD", typeof(GLNativeDelegate.FNglIsNameAMD));

            #endregion GL_AMD_name_gen_delete

            #region GL_AMD_occlusion_query_event

            yield return new ProcInfo("glQueryObjectParameteruiAMD", typeof(GLNativeDelegate.FNglQueryObjectParameteruiAMD));

            #endregion GL_AMD_occlusion_query_event

            #region GL_AMD_performance_monitor

            yield return new ProcInfo("glGetPerfMonitorGroupsAMD", typeof(GLNativeDelegate.FNglGetPerfMonitorGroupsAMD));
            yield return new ProcInfo("glGetPerfMonitorCountersAMD", typeof(GLNativeDelegate.FNglGetPerfMonitorCountersAMD));
            yield return new ProcInfo("glGetPerfMonitorGroupStringAMD", typeof(GLNativeDelegate.FNglGetPerfMonitorGroupStringAMD));
            yield return new ProcInfo("glGetPerfMonitorCounterStringAMD", typeof(GLNativeDelegate.FNglGetPerfMonitorCounterStringAMD));
            yield return new ProcInfo("glGetPerfMonitorCounterInfoAMD", typeof(GLNativeDelegate.FNglGetPerfMonitorCounterInfoAMD));
            yield return new ProcInfo("glGenPerfMonitorsAMD", typeof(GLNativeDelegate.FNglGenPerfMonitorsAMD));
            yield return new ProcInfo("glDeletePerfMonitorsAMD", typeof(GLNativeDelegate.FNglDeletePerfMonitorsAMD));
            yield return new ProcInfo("glSelectPerfMonitorCountersAMD", typeof(GLNativeDelegate.FNglSelectPerfMonitorCountersAMD));
            yield return new ProcInfo("glBeginPerfMonitorAMD", typeof(GLNativeDelegate.FNglBeginPerfMonitorAMD));
            yield return new ProcInfo("glEndPerfMonitorAMD", typeof(GLNativeDelegate.FNglEndPerfMonitorAMD));
            yield return new ProcInfo("glGetPerfMonitorCounterDataAMD", typeof(GLNativeDelegate.FNglGetPerfMonitorCounterDataAMD));

            #endregion GL_AMD_performance_monitor

            #region GL_AMD_sample_positions

            yield return new ProcInfo("glSetMultisamplefvAMD", typeof(GLNativeDelegate.FNglSetMultisamplefvAMD));

            #endregion GL_AMD_sample_positions

            #region GL_AMD_sparse_texture

            yield return new ProcInfo("glTexStorageSparseAMD", typeof(GLNativeDelegate.FNglTexStorageSparseAMD));
            yield return new ProcInfo("glTextureStorageSparseAMD", typeof(GLNativeDelegate.FNglTextureStorageSparseAMD));

            #endregion GL_AMD_sparse_texture

            #region GL_AMD_stencil_operation_extended

            yield return new ProcInfo("glStencilOpValueAMD", typeof(GLNativeDelegate.FNglStencilOpValueAMD));

            #endregion GL_AMD_stencil_operation_extended

            #region GL_AMD_vertex_shader_tessellator

            yield return new ProcInfo("glTessellationFactorAMD", typeof(GLNativeDelegate.FNglTessellationFactorAMD));
            yield return new ProcInfo("glTessellationModeAMD", typeof(GLNativeDelegate.FNglTessellationModeAMD));

            #endregion GL_AMD_vertex_shader_tessellator

            #region GL_APPLE_element_array

            yield return new ProcInfo("glElementPointerAPPLE", typeof(GLNativeDelegate.FNglElementPointerAPPLE));
            yield return new ProcInfo("glDrawElementArrayAPPLE", typeof(GLNativeDelegate.FNglDrawElementArrayAPPLE));
            yield return new ProcInfo("glDrawRangeElementArrayAPPLE", typeof(GLNativeDelegate.FNglDrawRangeElementArrayAPPLE));
            yield return new ProcInfo("glMultiDrawElementArrayAPPLE", typeof(GLNativeDelegate.FNglMultiDrawElementArrayAPPLE));
            yield return new ProcInfo("glMultiDrawRangeElementArrayAPPLE", typeof(GLNativeDelegate.FNglMultiDrawRangeElementArrayAPPLE));

            #endregion GL_APPLE_element_array

            #region GL_APPLE_fence

            yield return new ProcInfo("glGenFencesAPPLE", typeof(GLNativeDelegate.FNglGenFencesAPPLE));
            yield return new ProcInfo("glDeleteFencesAPPLE", typeof(GLNativeDelegate.FNglDeleteFencesAPPLE));
            yield return new ProcInfo("glSetFenceAPPLE", typeof(GLNativeDelegate.FNglSetFenceAPPLE));
            yield return new ProcInfo("glIsFenceAPPLE", typeof(GLNativeDelegate.FNglIsFenceAPPLE));
            yield return new ProcInfo("glTestFenceAPPLE", typeof(GLNativeDelegate.FNglTestFenceAPPLE));
            yield return new ProcInfo("glFinishFenceAPPLE", typeof(GLNativeDelegate.FNglFinishFenceAPPLE));
            yield return new ProcInfo("glTestObjectAPPLE", typeof(GLNativeDelegate.FNglTestObjectAPPLE));
            yield return new ProcInfo("glFinishObjectAPPLE", typeof(GLNativeDelegate.FNglFinishObjectAPPLE));

            #endregion GL_APPLE_fence

            #region GL_APPLE_flush_buffer_range

            yield return new ProcInfo("glBufferParameteriAPPLE", typeof(GLNativeDelegate.FNglBufferParameteriAPPLE));
            yield return new ProcInfo("glFlushMappedBufferRangeAPPLE", typeof(GLNativeDelegate.FNglFlushMappedBufferRangeAPPLE));

            #endregion GL_APPLE_flush_buffer_range

            #region GL_APPLE_object_purgeable

            yield return new ProcInfo("glObjectPurgeableAPPLE", typeof(GLNativeDelegate.FNglObjectPurgeableAPPLE));
            yield return new ProcInfo("glObjectUnpurgeableAPPLE", typeof(GLNativeDelegate.FNglObjectUnpurgeableAPPLE));
            yield return new ProcInfo("glGetObjectParameterivAPPLE", typeof(GLNativeDelegate.FNglGetObjectParameterivAPPLE));

            #endregion GL_APPLE_object_purgeable

            #region GL_APPLE_texture_range

            yield return new ProcInfo("glTextureRangeAPPLE", typeof(GLNativeDelegate.FNglTextureRangeAPPLE));
            yield return new ProcInfo("glGetTexParameterPointervAPPLE", typeof(GLNativeDelegate.FNglGetTexParameterPointervAPPLE));

            #endregion GL_APPLE_texture_range

            #region GL_APPLE_vertex_array_object

            yield return new ProcInfo("glBindVertexArrayAPPLE", typeof(GLNativeDelegate.FNglBindVertexArrayAPPLE));
            yield return new ProcInfo("glDeleteVertexArraysAPPLE", typeof(GLNativeDelegate.FNglDeleteVertexArraysAPPLE));
            yield return new ProcInfo("glGenVertexArraysAPPLE", typeof(GLNativeDelegate.FNglGenVertexArraysAPPLE));
            yield return new ProcInfo("glIsVertexArrayAPPLE", typeof(GLNativeDelegate.FNglIsVertexArrayAPPLE));

            #endregion GL_APPLE_vertex_array_object

            #region GL_APPLE_vertex_array_range

            yield return new ProcInfo("glVertexArrayRangeAPPLE", typeof(GLNativeDelegate.FNglVertexArrayRangeAPPLE));
            yield return new ProcInfo("glFlushVertexArrayRangeAPPLE", typeof(GLNativeDelegate.FNglFlushVertexArrayRangeAPPLE));
            yield return new ProcInfo("glVertexArrayParameteriAPPLE", typeof(GLNativeDelegate.FNglVertexArrayParameteriAPPLE));

            #endregion GL_APPLE_vertex_array_range

            #region GL_APPLE_vertex_program_evaluators

            yield return new ProcInfo("glEnableVertexAttribAPPLE", typeof(GLNativeDelegate.FNglEnableVertexAttribAPPLE));
            yield return new ProcInfo("glDisableVertexAttribAPPLE", typeof(GLNativeDelegate.FNglDisableVertexAttribAPPLE));
            yield return new ProcInfo("glIsVertexAttribEnabledAPPLE", typeof(GLNativeDelegate.FNglIsVertexAttribEnabledAPPLE));
            yield return new ProcInfo("glMapVertexAttrib1dAPPLE", typeof(GLNativeDelegate.FNglMapVertexAttrib1dAPPLE));
            yield return new ProcInfo("glMapVertexAttrib1fAPPLE", typeof(GLNativeDelegate.FNglMapVertexAttrib1fAPPLE));
            yield return new ProcInfo("glMapVertexAttrib2dAPPLE", typeof(GLNativeDelegate.FNglMapVertexAttrib2dAPPLE));
            yield return new ProcInfo("glMapVertexAttrib2fAPPLE", typeof(GLNativeDelegate.FNglMapVertexAttrib2fAPPLE));

            #endregion GL_APPLE_vertex_program_evaluators

            #region GL_ARB_ES2_compatibility

            // yield return new ProcInfo("glReleaseShaderCompiler", typeof(GLNativeDelegate.FNglReleaseShaderCompiler));
            // yield return new ProcInfo("glShaderBinary", typeof(GLNativeDelegate.FNglShaderBinary));
            // yield return new ProcInfo("glGetShaderPrecisionFormat", typeof(GLNativeDelegate.FNglGetShaderPrecisionFormat));
            // yield return new ProcInfo("glDepthRangef", typeof(GLNativeDelegate.FNglDepthRangef));
            // yield return new ProcInfo("glClearDepthf", typeof(GLNativeDelegate.FNglClearDepthf));

            #endregion GL_ARB_ES2_compatibility

            #region GL_ARB_ES3_1_compatibility

            // yield return new ProcInfo("glMemoryBarrierByRegion", typeof(GLNativeDelegate.FNglMemoryBarrierByRegion));

            #endregion GL_ARB_ES3_1_compatibility

            #region GL_ARB_ES3_2_compatibility

            yield return new ProcInfo("glPrimitiveBoundingBoxARB", typeof(GLNativeDelegate.FNglPrimitiveBoundingBoxARB));

            #endregion GL_ARB_ES3_2_compatibility

            #region GL_ARB_base_instance

            // yield return new ProcInfo("glDrawArraysInstancedBaseInstance", typeof(GLNativeDelegate.FNglDrawArraysInstancedBaseInstance));
            // yield return new ProcInfo("glDrawElementsInstancedBaseInstance", typeof(GLNativeDelegate.FNglDrawElementsInstancedBaseInstance));
            // yield return new ProcInfo("glDrawElementsInstancedBaseVertexBaseInstance", typeof(GLNativeDelegate.FNglDrawElementsInstancedBaseVertexBaseInstance));

            #endregion GL_ARB_base_instance

            #region GL_ARB_bindless_texture

            yield return new ProcInfo("glGetTextureHandleARB", typeof(GLNativeDelegate.FNglGetTextureHandleARB));
            yield return new ProcInfo("glGetTextureSamplerHandleARB", typeof(GLNativeDelegate.FNglGetTextureSamplerHandleARB));
            yield return new ProcInfo("glMakeTextureHandleResidentARB", typeof(GLNativeDelegate.FNglMakeTextureHandleResidentARB));
            yield return new ProcInfo("glMakeTextureHandleNonResidentARB", typeof(GLNativeDelegate.FNglMakeTextureHandleNonResidentARB));
            yield return new ProcInfo("glGetImageHandleARB", typeof(GLNativeDelegate.FNglGetImageHandleARB));
            yield return new ProcInfo("glMakeImageHandleResidentARB", typeof(GLNativeDelegate.FNglMakeImageHandleResidentARB));
            yield return new ProcInfo("glMakeImageHandleNonResidentARB", typeof(GLNativeDelegate.FNglMakeImageHandleNonResidentARB));
            yield return new ProcInfo("glUniformHandleui64ARB", typeof(GLNativeDelegate.FNglUniformHandleui64ARB));
            yield return new ProcInfo("glUniformHandleui64vARB", typeof(GLNativeDelegate.FNglUniformHandleui64vARB));
            yield return new ProcInfo("glProgramUniformHandleui64ARB", typeof(GLNativeDelegate.FNglProgramUniformHandleui64ARB));
            yield return new ProcInfo("glProgramUniformHandleui64vARB", typeof(GLNativeDelegate.FNglProgramUniformHandleui64vARB));
            yield return new ProcInfo("glIsTextureHandleResidentARB", typeof(GLNativeDelegate.FNglIsTextureHandleResidentARB));
            yield return new ProcInfo("glIsImageHandleResidentARB", typeof(GLNativeDelegate.FNglIsImageHandleResidentARB));
            yield return new ProcInfo("glVertexAttribL1ui64ARB", typeof(GLNativeDelegate.FNglVertexAttribL1ui64ARB));
            yield return new ProcInfo("glVertexAttribL1ui64vARB", typeof(GLNativeDelegate.FNglVertexAttribL1ui64vARB));
            yield return new ProcInfo("glGetVertexAttribLui64vARB", typeof(GLNativeDelegate.FNglGetVertexAttribLui64vARB));

            #endregion GL_ARB_bindless_texture

            #region GL_ARB_blend_func_extended

            // yield return new ProcInfo("glBindFragDataLocationIndexed", typeof(GLNativeDelegate.FNglBindFragDataLocationIndexed));
            // yield return new ProcInfo("glGetFragDataIndex", typeof(GLNativeDelegate.FNglGetFragDataIndex));

            #endregion GL_ARB_blend_func_extended

            #region GL_ARB_buffer_storage

            // yield return new ProcInfo("glBufferStorage", typeof(GLNativeDelegate.FNglBufferStorage));

            #endregion GL_ARB_buffer_storage

            #region GL_ARB_cl_event

            yield return new ProcInfo("glCreateSyncFromCLeventARB", typeof(GLNativeDelegate.FNglCreateSyncFromCLeventARB));

            #endregion GL_ARB_cl_event

            #region GL_ARB_clear_buffer_object

            // yield return new ProcInfo("glClearBufferData", typeof(GLNativeDelegate.FNglClearBufferData));
            // yield return new ProcInfo("glClearBufferSubData", typeof(GLNativeDelegate.FNglClearBufferSubData));

            #endregion GL_ARB_clear_buffer_object

            #region GL_ARB_clear_texture

            // yield return new ProcInfo("glClearTexImage", typeof(GLNativeDelegate.FNglClearTexImage));
            // yield return new ProcInfo("glClearTexSubImage", typeof(GLNativeDelegate.FNglClearTexSubImage));

            #endregion GL_ARB_clear_texture

            #region GL_ARB_clip_control

            // yield return new ProcInfo("glClipControl", typeof(GLNativeDelegate.FNglClipControl));

            #endregion GL_ARB_clip_control

            #region GL_ARB_color_buffer_float

            yield return new ProcInfo("glClampColorARB", typeof(GLNativeDelegate.FNglClampColorARB));

            #endregion GL_ARB_color_buffer_float

            #region GL_ARB_compute_shader

            // yield return new ProcInfo("glDispatchCompute", typeof(GLNativeDelegate.FNglDispatchCompute));
            // yield return new ProcInfo("glDispatchComputeIndirect", typeof(GLNativeDelegate.FNglDispatchComputeIndirect));

            #endregion GL_ARB_compute_shader

            #region GL_ARB_compute_variable_group_size

            yield return new ProcInfo("glDispatchComputeGroupSizeARB", typeof(GLNativeDelegate.FNglDispatchComputeGroupSizeARB));

            #endregion GL_ARB_compute_variable_group_size

            #region GL_ARB_copy_buffer

            // yield return new ProcInfo("glCopyBufferSubData", typeof(GLNativeDelegate.FNglCopyBufferSubData));

            #endregion GL_ARB_copy_buffer

            #region GL_ARB_copy_image

            // yield return new ProcInfo("glCopyImageSubData", typeof(GLNativeDelegate.FNglCopyImageSubData));

            #endregion GL_ARB_copy_image

            #region GL_ARB_debug_output

            yield return new ProcInfo("glDebugMessageControlARB", typeof(GLNativeDelegate.FNglDebugMessageControlARB));
            yield return new ProcInfo("glDebugMessageInsertARB", typeof(GLNativeDelegate.FNglDebugMessageInsertARB));
            yield return new ProcInfo("glDebugMessageCallbackARB", typeof(GLNativeDelegate.FNglDebugMessageCallbackARB));
            yield return new ProcInfo("glGetDebugMessageLogARB", typeof(GLNativeDelegate.FNglGetDebugMessageLogARB));

            #endregion GL_ARB_debug_output

            #region GL_ARB_draw_buffers

            yield return new ProcInfo("glDrawBuffersARB", typeof(GLNativeDelegate.FNglDrawBuffersARB));

            #endregion GL_ARB_draw_buffers

            #region GL_ARB_draw_buffers_blend

            yield return new ProcInfo("glBlendEquationiARB", typeof(GLNativeDelegate.FNglBlendEquationiARB));
            yield return new ProcInfo("glBlendEquationSeparateiARB", typeof(GLNativeDelegate.FNglBlendEquationSeparateiARB));
            yield return new ProcInfo("glBlendFunciARB", typeof(GLNativeDelegate.FNglBlendFunciARB));
            yield return new ProcInfo("glBlendFuncSeparateiARB", typeof(GLNativeDelegate.FNglBlendFuncSeparateiARB));

            #endregion GL_ARB_draw_buffers_blend

            #region GL_ARB_draw_elements_base_vertex

            // yield return new ProcInfo("glDrawElementsBaseVertex", typeof(GLNativeDelegate.FNglDrawElementsBaseVertex));
            // yield return new ProcInfo("glDrawRangeElementsBaseVertex", typeof(GLNativeDelegate.FNglDrawRangeElementsBaseVertex));
            // yield return new ProcInfo("glDrawElementsInstancedBaseVertex", typeof(GLNativeDelegate.FNglDrawElementsInstancedBaseVertex));
            // yield return new ProcInfo("glMultiDrawElementsBaseVertex", typeof(GLNativeDelegate.FNglMultiDrawElementsBaseVertex));

            #endregion GL_ARB_draw_elements_base_vertex

            #region GL_ARB_draw_indirect

            // yield return new ProcInfo("glDrawArraysIndirect", typeof(GLNativeDelegate.FNglDrawArraysIndirect));
            // yield return new ProcInfo("glDrawElementsIndirect", typeof(GLNativeDelegate.FNglDrawElementsIndirect));

            #endregion GL_ARB_draw_indirect

            #region GL_ARB_draw_instanced

            yield return new ProcInfo("glDrawArraysInstancedARB", typeof(GLNativeDelegate.FNglDrawArraysInstancedARB));
            yield return new ProcInfo("glDrawElementsInstancedARB", typeof(GLNativeDelegate.FNglDrawElementsInstancedARB));

            #endregion GL_ARB_draw_instanced

            #region GL_ARB_framebuffer_no_attachments

            // yield return new ProcInfo("glFramebufferParameteri", typeof(GLNativeDelegate.FNglFramebufferParameteri));
            // yield return new ProcInfo("glGetFramebufferParameteriv", typeof(GLNativeDelegate.FNglGetFramebufferParameteriv));

            #endregion GL_ARB_framebuffer_no_attachments

            #region GL_ARB_framebuffer_object

            // yield return new ProcInfo("glIsRenderbuffer", typeof(GLNativeDelegate.FNglIsRenderbuffer));
            // yield return new ProcInfo("glBindRenderbuffer", typeof(GLNativeDelegate.FNglBindRenderbuffer));
            // yield return new ProcInfo("glDeleteRenderbuffers", typeof(GLNativeDelegate.FNglDeleteRenderbuffers));
            // yield return new ProcInfo("glGenRenderbuffers", typeof(GLNativeDelegate.FNglGenRenderbuffers));
            // yield return new ProcInfo("glRenderbufferStorage", typeof(GLNativeDelegate.FNglRenderbufferStorage));
            // yield return new ProcInfo("glGetRenderbufferParameteriv", typeof(GLNativeDelegate.FNglGetRenderbufferParameteriv));
            // yield return new ProcInfo("glIsFramebuffer", typeof(GLNativeDelegate.FNglIsFramebuffer));
            // yield return new ProcInfo("glBindFramebuffer", typeof(GLNativeDelegate.FNglBindFramebuffer));
            // yield return new ProcInfo("glDeleteFramebuffers", typeof(GLNativeDelegate.FNglDeleteFramebuffers));
            // yield return new ProcInfo("glGenFramebuffers", typeof(GLNativeDelegate.FNglGenFramebuffers));
            // yield return new ProcInfo("glCheckFramebufferStatus", typeof(GLNativeDelegate.FNglCheckFramebufferStatus));
            // yield return new ProcInfo("glFramebufferTexture1D", typeof(GLNativeDelegate.FNglFramebufferTexture1D));
            // yield return new ProcInfo("glFramebufferTexture2D", typeof(GLNativeDelegate.FNglFramebufferTexture2D));
            // yield return new ProcInfo("glFramebufferTexture3D", typeof(GLNativeDelegate.FNglFramebufferTexture3D));
            // yield return new ProcInfo("glFramebufferRenderbuffer", typeof(GLNativeDelegate.FNglFramebufferRenderbuffer));
            // yield return new ProcInfo("glGetFramebufferAttachmentParameteriv", typeof(GLNativeDelegate.FNglGetFramebufferAttachmentParameteriv));
            // yield return new ProcInfo("glGenerateMipmap", typeof(GLNativeDelegate.FNglGenerateMipmap));
            // yield return new ProcInfo("glBlitFramebuffer", typeof(GLNativeDelegate.FNglBlitFramebuffer));
            // yield return new ProcInfo("glRenderbufferStorageMultisample", typeof(GLNativeDelegate.FNglRenderbufferStorageMultisample));
            // yield return new ProcInfo("glFramebufferTextureLayer", typeof(GLNativeDelegate.FNglFramebufferTextureLayer));

            #endregion GL_ARB_framebuffer_object

            #region GL_ARB_geometry_shader4

            yield return new ProcInfo("glProgramParameteriARB", typeof(GLNativeDelegate.FNglProgramParameteriARB));
            yield return new ProcInfo("glFramebufferTextureARB", typeof(GLNativeDelegate.FNglFramebufferTextureARB));
            yield return new ProcInfo("glFramebufferTextureLayerARB", typeof(GLNativeDelegate.FNglFramebufferTextureLayerARB));
            yield return new ProcInfo("glFramebufferTextureFaceARB", typeof(GLNativeDelegate.FNglFramebufferTextureFaceARB));

            #endregion GL_ARB_geometry_shader4

            #region GL_ARB_get_program_binary

            // yield return new ProcInfo("glGetProgramBinary", typeof(GLNativeDelegate.FNglGetProgramBinary));
            // yield return new ProcInfo("glProgramBinary", typeof(GLNativeDelegate.FNglProgramBinary));
            // yield return new ProcInfo("glProgramParameteri", typeof(GLNativeDelegate.FNglProgramParameteri));

            #endregion GL_ARB_get_program_binary

            #region GL_ARB_get_texture_sub_image

            // yield return new ProcInfo("glGetTextureSubImage", typeof(GLNativeDelegate.FNglGetTextureSubImage));
            // yield return new ProcInfo("glGetCompressedTextureSubImage", typeof(GLNativeDelegate.FNglGetCompressedTextureSubImage));

            #endregion GL_ARB_get_texture_sub_image

            #region GL_ARB_gl_spirv

            yield return new ProcInfo("glSpecializeShaderARB", typeof(GLNativeDelegate.FNglSpecializeShaderARB));

            #endregion GL_ARB_gl_spirv

            #region GL_ARB_gpu_shader_fp64

            // yield return new ProcInfo("glUniform1d", typeof(GLNativeDelegate.FNglUniform1d));
            // yield return new ProcInfo("glUniform2d", typeof(GLNativeDelegate.FNglUniform2d));
            // yield return new ProcInfo("glUniform3d", typeof(GLNativeDelegate.FNglUniform3d));
            // yield return new ProcInfo("glUniform4d", typeof(GLNativeDelegate.FNglUniform4d));
            // yield return new ProcInfo("glUniform1dv", typeof(GLNativeDelegate.FNglUniform1dv));
            // yield return new ProcInfo("glUniform2dv", typeof(GLNativeDelegate.FNglUniform2dv));
            // yield return new ProcInfo("glUniform3dv", typeof(GLNativeDelegate.FNglUniform3dv));
            // yield return new ProcInfo("glUniform4dv", typeof(GLNativeDelegate.FNglUniform4dv));
            // yield return new ProcInfo("glUniformMatrix2dv", typeof(GLNativeDelegate.FNglUniformMatrix2dv));
            // yield return new ProcInfo("glUniformMatrix3dv", typeof(GLNativeDelegate.FNglUniformMatrix3dv));
            // yield return new ProcInfo("glUniformMatrix4dv", typeof(GLNativeDelegate.FNglUniformMatrix4dv));
            // yield return new ProcInfo("glUniformMatrix2x3dv", typeof(GLNativeDelegate.FNglUniformMatrix2x3dv));
            // yield return new ProcInfo("glUniformMatrix2x4dv", typeof(GLNativeDelegate.FNglUniformMatrix2x4dv));
            // yield return new ProcInfo("glUniformMatrix3x2dv", typeof(GLNativeDelegate.FNglUniformMatrix3x2dv));
            // yield return new ProcInfo("glUniformMatrix3x4dv", typeof(GLNativeDelegate.FNglUniformMatrix3x4dv));
            // yield return new ProcInfo("glUniformMatrix4x2dv", typeof(GLNativeDelegate.FNglUniformMatrix4x2dv));
            // yield return new ProcInfo("glUniformMatrix4x3dv", typeof(GLNativeDelegate.FNglUniformMatrix4x3dv));
            // yield return new ProcInfo("glGetUniformdv", typeof(GLNativeDelegate.FNglGetUniformdv));

            #endregion GL_ARB_gpu_shader_fp64

            #region GL_ARB_gpu_shader_int64

            yield return new ProcInfo("glUniform1i64ARB", typeof(GLNativeDelegate.FNglUniform1i64ARB));
            yield return new ProcInfo("glUniform2i64ARB", typeof(GLNativeDelegate.FNglUniform2i64ARB));
            yield return new ProcInfo("glUniform3i64ARB", typeof(GLNativeDelegate.FNglUniform3i64ARB));
            yield return new ProcInfo("glUniform4i64ARB", typeof(GLNativeDelegate.FNglUniform4i64ARB));
            yield return new ProcInfo("glUniform1i64vARB", typeof(GLNativeDelegate.FNglUniform1i64vARB));
            yield return new ProcInfo("glUniform2i64vARB", typeof(GLNativeDelegate.FNglUniform2i64vARB));
            yield return new ProcInfo("glUniform3i64vARB", typeof(GLNativeDelegate.FNglUniform3i64vARB));
            yield return new ProcInfo("glUniform4i64vARB", typeof(GLNativeDelegate.FNglUniform4i64vARB));
            yield return new ProcInfo("glUniform1ui64ARB", typeof(GLNativeDelegate.FNglUniform1ui64ARB));
            yield return new ProcInfo("glUniform2ui64ARB", typeof(GLNativeDelegate.FNglUniform2ui64ARB));
            yield return new ProcInfo("glUniform3ui64ARB", typeof(GLNativeDelegate.FNglUniform3ui64ARB));
            yield return new ProcInfo("glUniform4ui64ARB", typeof(GLNativeDelegate.FNglUniform4ui64ARB));
            yield return new ProcInfo("glUniform1ui64vARB", typeof(GLNativeDelegate.FNglUniform1ui64vARB));
            yield return new ProcInfo("glUniform2ui64vARB", typeof(GLNativeDelegate.FNglUniform2ui64vARB));
            yield return new ProcInfo("glUniform3ui64vARB", typeof(GLNativeDelegate.FNglUniform3ui64vARB));
            yield return new ProcInfo("glUniform4ui64vARB", typeof(GLNativeDelegate.FNglUniform4ui64vARB));
            yield return new ProcInfo("glGetUniformi64vARB", typeof(GLNativeDelegate.FNglGetUniformi64vARB));
            yield return new ProcInfo("glGetUniformui64vARB", typeof(GLNativeDelegate.FNglGetUniformui64vARB));
            yield return new ProcInfo("glGetnUniformi64vARB", typeof(GLNativeDelegate.FNglGetnUniformi64vARB));
            yield return new ProcInfo("glGetnUniformui64vARB", typeof(GLNativeDelegate.FNglGetnUniformui64vARB));
            yield return new ProcInfo("glProgramUniform1i64ARB", typeof(GLNativeDelegate.FNglProgramUniform1i64ARB));
            yield return new ProcInfo("glProgramUniform2i64ARB", typeof(GLNativeDelegate.FNglProgramUniform2i64ARB));
            yield return new ProcInfo("glProgramUniform3i64ARB", typeof(GLNativeDelegate.FNglProgramUniform3i64ARB));
            yield return new ProcInfo("glProgramUniform4i64ARB", typeof(GLNativeDelegate.FNglProgramUniform4i64ARB));
            yield return new ProcInfo("glProgramUniform1i64vARB", typeof(GLNativeDelegate.FNglProgramUniform1i64vARB));
            yield return new ProcInfo("glProgramUniform2i64vARB", typeof(GLNativeDelegate.FNglProgramUniform2i64vARB));
            yield return new ProcInfo("glProgramUniform3i64vARB", typeof(GLNativeDelegate.FNglProgramUniform3i64vARB));
            yield return new ProcInfo("glProgramUniform4i64vARB", typeof(GLNativeDelegate.FNglProgramUniform4i64vARB));
            yield return new ProcInfo("glProgramUniform1ui64ARB", typeof(GLNativeDelegate.FNglProgramUniform1ui64ARB));
            yield return new ProcInfo("glProgramUniform2ui64ARB", typeof(GLNativeDelegate.FNglProgramUniform2ui64ARB));
            yield return new ProcInfo("glProgramUniform3ui64ARB", typeof(GLNativeDelegate.FNglProgramUniform3ui64ARB));
            yield return new ProcInfo("glProgramUniform4ui64ARB", typeof(GLNativeDelegate.FNglProgramUniform4ui64ARB));
            yield return new ProcInfo("glProgramUniform1ui64vARB", typeof(GLNativeDelegate.FNglProgramUniform1ui64vARB));
            yield return new ProcInfo("glProgramUniform2ui64vARB", typeof(GLNativeDelegate.FNglProgramUniform2ui64vARB));
            yield return new ProcInfo("glProgramUniform3ui64vARB", typeof(GLNativeDelegate.FNglProgramUniform3ui64vARB));
            yield return new ProcInfo("glProgramUniform4ui64vARB", typeof(GLNativeDelegate.FNglProgramUniform4ui64vARB));

            #endregion GL_ARB_gpu_shader_int64

            #region GL_ARB_imaging

            // yield return new ProcInfo("glBlendColor", typeof(GLNativeDelegate.FNglBlendColor));
            // yield return new ProcInfo("glBlendEquation", typeof(GLNativeDelegate.FNglBlendEquation));
            yield return new ProcInfo("glColorTable", typeof(GLNativeDelegate.FNglColorTable));
            yield return new ProcInfo("glColorTableParameterfv", typeof(GLNativeDelegate.FNglColorTableParameterfv));
            yield return new ProcInfo("glColorTableParameteriv", typeof(GLNativeDelegate.FNglColorTableParameteriv));
            yield return new ProcInfo("glCopyColorTable", typeof(GLNativeDelegate.FNglCopyColorTable));
            yield return new ProcInfo("glGetColorTable", typeof(GLNativeDelegate.FNglGetColorTable));
            yield return new ProcInfo("glGetColorTableParameterfv", typeof(GLNativeDelegate.FNglGetColorTableParameterfv));
            yield return new ProcInfo("glGetColorTableParameteriv", typeof(GLNativeDelegate.FNglGetColorTableParameteriv));
            yield return new ProcInfo("glColorSubTable", typeof(GLNativeDelegate.FNglColorSubTable));
            yield return new ProcInfo("glCopyColorSubTable", typeof(GLNativeDelegate.FNglCopyColorSubTable));
            yield return new ProcInfo("glConvolutionFilter1D", typeof(GLNativeDelegate.FNglConvolutionFilter1D));
            yield return new ProcInfo("glConvolutionFilter2D", typeof(GLNativeDelegate.FNglConvolutionFilter2D));
            yield return new ProcInfo("glConvolutionParameterf", typeof(GLNativeDelegate.FNglConvolutionParameterf));
            yield return new ProcInfo("glConvolutionParameterfv", typeof(GLNativeDelegate.FNglConvolutionParameterfv));
            yield return new ProcInfo("glConvolutionParameteri", typeof(GLNativeDelegate.FNglConvolutionParameteri));
            yield return new ProcInfo("glConvolutionParameteriv", typeof(GLNativeDelegate.FNglConvolutionParameteriv));
            yield return new ProcInfo("glCopyConvolutionFilter1D", typeof(GLNativeDelegate.FNglCopyConvolutionFilter1D));
            yield return new ProcInfo("glCopyConvolutionFilter2D", typeof(GLNativeDelegate.FNglCopyConvolutionFilter2D));
            yield return new ProcInfo("glGetConvolutionFilter", typeof(GLNativeDelegate.FNglGetConvolutionFilter));
            yield return new ProcInfo("glGetConvolutionParameterfv", typeof(GLNativeDelegate.FNglGetConvolutionParameterfv));
            yield return new ProcInfo("glGetConvolutionParameteriv", typeof(GLNativeDelegate.FNglGetConvolutionParameteriv));
            yield return new ProcInfo("glGetSeparableFilter", typeof(GLNativeDelegate.FNglGetSeparableFilter));
            yield return new ProcInfo("glSeparableFilter2D", typeof(GLNativeDelegate.FNglSeparableFilter2D));
            yield return new ProcInfo("glGetHistogram", typeof(GLNativeDelegate.FNglGetHistogram));
            yield return new ProcInfo("glGetHistogramParameterfv", typeof(GLNativeDelegate.FNglGetHistogramParameterfv));
            yield return new ProcInfo("glGetHistogramParameteriv", typeof(GLNativeDelegate.FNglGetHistogramParameteriv));
            yield return new ProcInfo("glGetMinmax", typeof(GLNativeDelegate.FNglGetMinmax));
            yield return new ProcInfo("glGetMinmaxParameterfv", typeof(GLNativeDelegate.FNglGetMinmaxParameterfv));
            yield return new ProcInfo("glGetMinmaxParameteriv", typeof(GLNativeDelegate.FNglGetMinmaxParameteriv));
            yield return new ProcInfo("glHistogram", typeof(GLNativeDelegate.FNglHistogram));
            yield return new ProcInfo("glMinmax", typeof(GLNativeDelegate.FNglMinmax));
            yield return new ProcInfo("glResetHistogram", typeof(GLNativeDelegate.FNglResetHistogram));
            yield return new ProcInfo("glResetMinmax", typeof(GLNativeDelegate.FNglResetMinmax));

            #endregion GL_ARB_imaging

            #region GL_ARB_indirect_parameters

            yield return new ProcInfo("glMultiDrawArraysIndirectCountARB", typeof(GLNativeDelegate.FNglMultiDrawArraysIndirectCountARB));
            yield return new ProcInfo("glMultiDrawElementsIndirectCountARB", typeof(GLNativeDelegate.FNglMultiDrawElementsIndirectCountARB));

            #endregion GL_ARB_indirect_parameters

            #region GL_ARB_instanced_arrays

            yield return new ProcInfo("glVertexAttribDivisorARB", typeof(GLNativeDelegate.FNglVertexAttribDivisorARB));

            #endregion GL_ARB_instanced_arrays

            #region GL_ARB_internalformat_query

            // yield return new ProcInfo("glGetInternalformativ", typeof(GLNativeDelegate.FNglGetInternalformativ));

            #endregion GL_ARB_internalformat_query

            #region GL_ARB_invalidate_subdata

            // yield return new ProcInfo("glInvalidateTexSubImage", typeof(GLNativeDelegate.FNglInvalidateTexSubImage));
            // yield return new ProcInfo("glInvalidateTexImage", typeof(GLNativeDelegate.FNglInvalidateTexImage));
            // yield return new ProcInfo("glInvalidateBufferSubData", typeof(GLNativeDelegate.FNglInvalidateBufferSubData));
            // yield return new ProcInfo("glInvalidateBufferData", typeof(GLNativeDelegate.FNglInvalidateBufferData));
            // yield return new ProcInfo("glInvalidateFramebuffer", typeof(GLNativeDelegate.FNglInvalidateFramebuffer));
            // yield return new ProcInfo("glInvalidateSubFramebuffer", typeof(GLNativeDelegate.FNglInvalidateSubFramebuffer));

            #endregion GL_ARB_invalidate_subdata

            #region GL_ARB_map_buffer_range

            // yield return new ProcInfo("glMapBufferRange", typeof(GLNativeDelegate.FNglMapBufferRange));
            // yield return new ProcInfo("glFlushMappedBufferRange", typeof(GLNativeDelegate.FNglFlushMappedBufferRange));

            #endregion GL_ARB_map_buffer_range

            #region GL_ARB_matrix_palette

            yield return new ProcInfo("glCurrentPaletteMatrixARB", typeof(GLNativeDelegate.FNglCurrentPaletteMatrixARB));
            yield return new ProcInfo("glMatrixIndexubvARB", typeof(GLNativeDelegate.FNglMatrixIndexubvARB));
            yield return new ProcInfo("glMatrixIndexusvARB", typeof(GLNativeDelegate.FNglMatrixIndexusvARB));
            yield return new ProcInfo("glMatrixIndexuivARB", typeof(GLNativeDelegate.FNglMatrixIndexuivARB));
            yield return new ProcInfo("glMatrixIndexPointerARB", typeof(GLNativeDelegate.FNglMatrixIndexPointerARB));

            #endregion GL_ARB_matrix_palette

            #region GL_ARB_multi_bind

            // yield return new ProcInfo("glBindBuffersBase", typeof(GLNativeDelegate.FNglBindBuffersBase));
            // yield return new ProcInfo("glBindBuffersRange", typeof(GLNativeDelegate.FNglBindBuffersRange));
            // yield return new ProcInfo("glBindTextures", typeof(GLNativeDelegate.FNglBindTextures));
            // yield return new ProcInfo("glBindSamplers", typeof(GLNativeDelegate.FNglBindSamplers));
            // yield return new ProcInfo("glBindImageTextures", typeof(GLNativeDelegate.FNglBindImageTextures));
            // yield return new ProcInfo("glBindVertexBuffers", typeof(GLNativeDelegate.FNglBindVertexBuffers));

            #endregion GL_ARB_multi_bind

            #region GL_ARB_multi_draw_indirect

            // yield return new ProcInfo("glMultiDrawArraysIndirect", typeof(GLNativeDelegate.FNglMultiDrawArraysIndirect));
            // yield return new ProcInfo("glMultiDrawElementsIndirect", typeof(GLNativeDelegate.FNglMultiDrawElementsIndirect));

            #endregion GL_ARB_multi_draw_indirect

            #region GL_ARB_multisample

            yield return new ProcInfo("glSampleCoverageARB", typeof(GLNativeDelegate.FNglSampleCoverageARB));

            #endregion GL_ARB_multisample

            #region GL_ARB_multitexture

            yield return new ProcInfo("glActiveTextureARB", typeof(GLNativeDelegate.FNglActiveTextureARB));
            yield return new ProcInfo("glClientActiveTextureARB", typeof(GLNativeDelegate.FNglClientActiveTextureARB));
            yield return new ProcInfo("glMultiTexCoord1dARB", typeof(GLNativeDelegate.FNglMultiTexCoord1dARB));
            yield return new ProcInfo("glMultiTexCoord1dvARB", typeof(GLNativeDelegate.FNglMultiTexCoord1dvARB));
            yield return new ProcInfo("glMultiTexCoord1fARB", typeof(GLNativeDelegate.FNglMultiTexCoord1fARB));
            yield return new ProcInfo("glMultiTexCoord1fvARB", typeof(GLNativeDelegate.FNglMultiTexCoord1fvARB));
            yield return new ProcInfo("glMultiTexCoord1iARB", typeof(GLNativeDelegate.FNglMultiTexCoord1iARB));
            yield return new ProcInfo("glMultiTexCoord1ivARB", typeof(GLNativeDelegate.FNglMultiTexCoord1ivARB));
            yield return new ProcInfo("glMultiTexCoord1sARB", typeof(GLNativeDelegate.FNglMultiTexCoord1sARB));
            yield return new ProcInfo("glMultiTexCoord1svARB", typeof(GLNativeDelegate.FNglMultiTexCoord1svARB));
            yield return new ProcInfo("glMultiTexCoord2dARB", typeof(GLNativeDelegate.FNglMultiTexCoord2dARB));
            yield return new ProcInfo("glMultiTexCoord2dvARB", typeof(GLNativeDelegate.FNglMultiTexCoord2dvARB));
            yield return new ProcInfo("glMultiTexCoord2fARB", typeof(GLNativeDelegate.FNglMultiTexCoord2fARB));
            yield return new ProcInfo("glMultiTexCoord2fvARB", typeof(GLNativeDelegate.FNglMultiTexCoord2fvARB));
            yield return new ProcInfo("glMultiTexCoord2iARB", typeof(GLNativeDelegate.FNglMultiTexCoord2iARB));
            yield return new ProcInfo("glMultiTexCoord2ivARB", typeof(GLNativeDelegate.FNglMultiTexCoord2ivARB));
            yield return new ProcInfo("glMultiTexCoord2sARB", typeof(GLNativeDelegate.FNglMultiTexCoord2sARB));
            yield return new ProcInfo("glMultiTexCoord2svARB", typeof(GLNativeDelegate.FNglMultiTexCoord2svARB));
            yield return new ProcInfo("glMultiTexCoord3dARB", typeof(GLNativeDelegate.FNglMultiTexCoord3dARB));
            yield return new ProcInfo("glMultiTexCoord3dvARB", typeof(GLNativeDelegate.FNglMultiTexCoord3dvARB));
            yield return new ProcInfo("glMultiTexCoord3fARB", typeof(GLNativeDelegate.FNglMultiTexCoord3fARB));
            yield return new ProcInfo("glMultiTexCoord3fvARB", typeof(GLNativeDelegate.FNglMultiTexCoord3fvARB));
            yield return new ProcInfo("glMultiTexCoord3iARB", typeof(GLNativeDelegate.FNglMultiTexCoord3iARB));
            yield return new ProcInfo("glMultiTexCoord3ivARB", typeof(GLNativeDelegate.FNglMultiTexCoord3ivARB));
            yield return new ProcInfo("glMultiTexCoord3sARB", typeof(GLNativeDelegate.FNglMultiTexCoord3sARB));
            yield return new ProcInfo("glMultiTexCoord3svARB", typeof(GLNativeDelegate.FNglMultiTexCoord3svARB));
            yield return new ProcInfo("glMultiTexCoord4dARB", typeof(GLNativeDelegate.FNglMultiTexCoord4dARB));
            yield return new ProcInfo("glMultiTexCoord4dvARB", typeof(GLNativeDelegate.FNglMultiTexCoord4dvARB));
            yield return new ProcInfo("glMultiTexCoord4fARB", typeof(GLNativeDelegate.FNglMultiTexCoord4fARB));
            yield return new ProcInfo("glMultiTexCoord4fvARB", typeof(GLNativeDelegate.FNglMultiTexCoord4fvARB));
            yield return new ProcInfo("glMultiTexCoord4iARB", typeof(GLNativeDelegate.FNglMultiTexCoord4iARB));
            yield return new ProcInfo("glMultiTexCoord4ivARB", typeof(GLNativeDelegate.FNglMultiTexCoord4ivARB));
            yield return new ProcInfo("glMultiTexCoord4sARB", typeof(GLNativeDelegate.FNglMultiTexCoord4sARB));
            yield return new ProcInfo("glMultiTexCoord4svARB", typeof(GLNativeDelegate.FNglMultiTexCoord4svARB));

            #endregion GL_ARB_multitexture

            #region GL_ARB_occlusion_query

            yield return new ProcInfo("glGenQueriesARB", typeof(GLNativeDelegate.FNglGenQueriesARB));
            yield return new ProcInfo("glDeleteQueriesARB", typeof(GLNativeDelegate.FNglDeleteQueriesARB));
            yield return new ProcInfo("glIsQueryARB", typeof(GLNativeDelegate.FNglIsQueryARB));
            yield return new ProcInfo("glBeginQueryARB", typeof(GLNativeDelegate.FNglBeginQueryARB));
            yield return new ProcInfo("glEndQueryARB", typeof(GLNativeDelegate.FNglEndQueryARB));
            yield return new ProcInfo("glGetQueryivARB", typeof(GLNativeDelegate.FNglGetQueryivARB));
            yield return new ProcInfo("glGetQueryObjectivARB", typeof(GLNativeDelegate.FNglGetQueryObjectivARB));
            yield return new ProcInfo("glGetQueryObjectuivARB", typeof(GLNativeDelegate.FNglGetQueryObjectuivARB));

            #endregion GL_ARB_occlusion_query

            #region GL_ARB_parallel_shader_compile

            yield return new ProcInfo("glMaxShaderCompilerThreadsARB", typeof(GLNativeDelegate.FNglMaxShaderCompilerThreadsARB));

            #endregion GL_ARB_parallel_shader_compile

            #region GL_ARB_point_parameters

            yield return new ProcInfo("glPointParameterfARB", typeof(GLNativeDelegate.FNglPointParameterfARB));
            yield return new ProcInfo("glPointParameterfvARB", typeof(GLNativeDelegate.FNglPointParameterfvARB));

            #endregion GL_ARB_point_parameters

            #region GL_ARB_polygon_offset_clamp

            // yield return new ProcInfo("glPolygonOffsetClamp", typeof(GLNativeDelegate.FNglPolygonOffsetClamp));

            #endregion GL_ARB_polygon_offset_clamp

            #region GL_ARB_program_interface_query

            // yield return new ProcInfo("glGetProgramInterfaceiv", typeof(GLNativeDelegate.FNglGetProgramInterfaceiv));
            // yield return new ProcInfo("glGetProgramResourceIndex", typeof(GLNativeDelegate.FNglGetProgramResourceIndex));
            // yield return new ProcInfo("glGetProgramResourceName", typeof(GLNativeDelegate.FNglGetProgramResourceName));
            // yield return new ProcInfo("glGetProgramResourceiv", typeof(GLNativeDelegate.FNglGetProgramResourceiv));
            // yield return new ProcInfo("glGetProgramResourceLocation", typeof(GLNativeDelegate.FNglGetProgramResourceLocation));
            // yield return new ProcInfo("glGetProgramResourceLocationIndex", typeof(GLNativeDelegate.FNglGetProgramResourceLocationIndex));

            #endregion GL_ARB_program_interface_query

            #region GL_ARB_provoking_vertex

            // yield return new ProcInfo("glProvokingVertex", typeof(GLNativeDelegate.FNglProvokingVertex));

            #endregion GL_ARB_provoking_vertex

            #region GL_ARB_robustness

            yield return new ProcInfo("glGetGraphicsResetStatusARB", typeof(GLNativeDelegate.FNglGetGraphicsResetStatusARB));
            yield return new ProcInfo("glGetnTexImageARB", typeof(GLNativeDelegate.FNglGetnTexImageARB));
            yield return new ProcInfo("glReadnPixelsARB", typeof(GLNativeDelegate.FNglReadnPixelsARB));
            yield return new ProcInfo("glGetnCompressedTexImageARB", typeof(GLNativeDelegate.FNglGetnCompressedTexImageARB));
            yield return new ProcInfo("glGetnUniformfvARB", typeof(GLNativeDelegate.FNglGetnUniformfvARB));
            yield return new ProcInfo("glGetnUniformivARB", typeof(GLNativeDelegate.FNglGetnUniformivARB));
            yield return new ProcInfo("glGetnUniformuivARB", typeof(GLNativeDelegate.FNglGetnUniformuivARB));
            yield return new ProcInfo("glGetnUniformdvARB", typeof(GLNativeDelegate.FNglGetnUniformdvARB));
            yield return new ProcInfo("glGetnMapdvARB", typeof(GLNativeDelegate.FNglGetnMapdvARB));
            yield return new ProcInfo("glGetnMapfvARB", typeof(GLNativeDelegate.FNglGetnMapfvARB));
            yield return new ProcInfo("glGetnMapivARB", typeof(GLNativeDelegate.FNglGetnMapivARB));
            yield return new ProcInfo("glGetnPixelMapfvARB", typeof(GLNativeDelegate.FNglGetnPixelMapfvARB));
            yield return new ProcInfo("glGetnPixelMapuivARB", typeof(GLNativeDelegate.FNglGetnPixelMapuivARB));
            yield return new ProcInfo("glGetnPixelMapusvARB", typeof(GLNativeDelegate.FNglGetnPixelMapusvARB));
            yield return new ProcInfo("glGetnPolygonStippleARB", typeof(GLNativeDelegate.FNglGetnPolygonStippleARB));
            yield return new ProcInfo("glGetnColorTableARB", typeof(GLNativeDelegate.FNglGetnColorTableARB));
            yield return new ProcInfo("glGetnConvolutionFilterARB", typeof(GLNativeDelegate.FNglGetnConvolutionFilterARB));
            yield return new ProcInfo("glGetnSeparableFilterARB", typeof(GLNativeDelegate.FNglGetnSeparableFilterARB));
            yield return new ProcInfo("glGetnHistogramARB", typeof(GLNativeDelegate.FNglGetnHistogramARB));
            yield return new ProcInfo("glGetnMinmaxARB", typeof(GLNativeDelegate.FNglGetnMinmaxARB));

            #endregion GL_ARB_robustness

            #region GL_ARB_sample_locations

            yield return new ProcInfo("glFramebufferSampleLocationsfvARB", typeof(GLNativeDelegate.FNglFramebufferSampleLocationsfvARB));
            yield return new ProcInfo("glNamedFramebufferSampleLocationsfvARB", typeof(GLNativeDelegate.FNglNamedFramebufferSampleLocationsfvARB));
            yield return new ProcInfo("glEvaluateDepthValuesARB", typeof(GLNativeDelegate.FNglEvaluateDepthValuesARB));

            #endregion GL_ARB_sample_locations

            #region GL_ARB_sample_shading

            yield return new ProcInfo("glMinSampleShadingARB", typeof(GLNativeDelegate.FNglMinSampleShadingARB));

            #endregion GL_ARB_sample_shading

            #region GL_ARB_sampler_objects

            // yield return new ProcInfo("glGenSamplers", typeof(GLNativeDelegate.FNglGenSamplers));
            // yield return new ProcInfo("glDeleteSamplers", typeof(GLNativeDelegate.FNglDeleteSamplers));
            // yield return new ProcInfo("glIsSampler", typeof(GLNativeDelegate.FNglIsSampler));
            // yield return new ProcInfo("glBindSampler", typeof(GLNativeDelegate.FNglBindSampler));
            // yield return new ProcInfo("glSamplerParameteri", typeof(GLNativeDelegate.FNglSamplerParameteri));
            // yield return new ProcInfo("glSamplerParameteriv", typeof(GLNativeDelegate.FNglSamplerParameteriv));
            // yield return new ProcInfo("glSamplerParameterf", typeof(GLNativeDelegate.FNglSamplerParameterf));
            // yield return new ProcInfo("glSamplerParameterfv", typeof(GLNativeDelegate.FNglSamplerParameterfv));
            // yield return new ProcInfo("glSamplerParameterIiv", typeof(GLNativeDelegate.FNglSamplerParameterIiv));
            // yield return new ProcInfo("glSamplerParameterIuiv", typeof(GLNativeDelegate.FNglSamplerParameterIuiv));
            // yield return new ProcInfo("glGetSamplerParameteriv", typeof(GLNativeDelegate.FNglGetSamplerParameteriv));
            // yield return new ProcInfo("glGetSamplerParameterIiv", typeof(GLNativeDelegate.FNglGetSamplerParameterIiv));
            // yield return new ProcInfo("glGetSamplerParameterfv", typeof(GLNativeDelegate.FNglGetSamplerParameterfv));
            // yield return new ProcInfo("glGetSamplerParameterIuiv", typeof(GLNativeDelegate.FNglGetSamplerParameterIuiv));

            #endregion GL_ARB_sampler_objects

            #region GL_ARB_separate_shader_objects

            // yield return new ProcInfo("glUseProgramStages", typeof(GLNativeDelegate.FNglUseProgramStages));
            // yield return new ProcInfo("glActiveShaderProgram", typeof(GLNativeDelegate.FNglActiveShaderProgram));
            // yield return new ProcInfo("glCreateShaderProgramv", typeof(GLNativeDelegate.FNglCreateShaderProgramv));
            // yield return new ProcInfo("glBindProgramPipeline", typeof(GLNativeDelegate.FNglBindProgramPipeline));
            // yield return new ProcInfo("glDeleteProgramPipelines", typeof(GLNativeDelegate.FNglDeleteProgramPipelines));
            // yield return new ProcInfo("glGenProgramPipelines", typeof(GLNativeDelegate.FNglGenProgramPipelines));
            // yield return new ProcInfo("glIsProgramPipeline", typeof(GLNativeDelegate.FNglIsProgramPipeline));
            // yield return new ProcInfo("glGetProgramPipelineiv", typeof(GLNativeDelegate.FNglGetProgramPipelineiv));
            // yield return new ProcInfo("glProgramParameteri", typeof(GLNativeDelegate.FNglProgramParameteri));
            // yield return new ProcInfo("glProgramUniform1i", typeof(GLNativeDelegate.FNglProgramUniform1i));
            // yield return new ProcInfo("glProgramUniform1iv", typeof(GLNativeDelegate.FNglProgramUniform1iv));
            // yield return new ProcInfo("glProgramUniform1f", typeof(GLNativeDelegate.FNglProgramUniform1f));
            // yield return new ProcInfo("glProgramUniform1fv", typeof(GLNativeDelegate.FNglProgramUniform1fv));
            // yield return new ProcInfo("glProgramUniform1d", typeof(GLNativeDelegate.FNglProgramUniform1d));
            // yield return new ProcInfo("glProgramUniform1dv", typeof(GLNativeDelegate.FNglProgramUniform1dv));
            // yield return new ProcInfo("glProgramUniform1ui", typeof(GLNativeDelegate.FNglProgramUniform1ui));
            // yield return new ProcInfo("glProgramUniform1uiv", typeof(GLNativeDelegate.FNglProgramUniform1uiv));
            // yield return new ProcInfo("glProgramUniform2i", typeof(GLNativeDelegate.FNglProgramUniform2i));
            // yield return new ProcInfo("glProgramUniform2iv", typeof(GLNativeDelegate.FNglProgramUniform2iv));
            // yield return new ProcInfo("glProgramUniform2f", typeof(GLNativeDelegate.FNglProgramUniform2f));
            // yield return new ProcInfo("glProgramUniform2fv", typeof(GLNativeDelegate.FNglProgramUniform2fv));
            // yield return new ProcInfo("glProgramUniform2d", typeof(GLNativeDelegate.FNglProgramUniform2d));
            // yield return new ProcInfo("glProgramUniform2dv", typeof(GLNativeDelegate.FNglProgramUniform2dv));
            // yield return new ProcInfo("glProgramUniform2ui", typeof(GLNativeDelegate.FNglProgramUniform2ui));
            // yield return new ProcInfo("glProgramUniform2uiv", typeof(GLNativeDelegate.FNglProgramUniform2uiv));
            // yield return new ProcInfo("glProgramUniform3i", typeof(GLNativeDelegate.FNglProgramUniform3i));
            // yield return new ProcInfo("glProgramUniform3iv", typeof(GLNativeDelegate.FNglProgramUniform3iv));
            // yield return new ProcInfo("glProgramUniform3f", typeof(GLNativeDelegate.FNglProgramUniform3f));
            // yield return new ProcInfo("glProgramUniform3fv", typeof(GLNativeDelegate.FNglProgramUniform3fv));
            // yield return new ProcInfo("glProgramUniform3d", typeof(GLNativeDelegate.FNglProgramUniform3d));
            // yield return new ProcInfo("glProgramUniform3dv", typeof(GLNativeDelegate.FNglProgramUniform3dv));
            // yield return new ProcInfo("glProgramUniform3ui", typeof(GLNativeDelegate.FNglProgramUniform3ui));
            // yield return new ProcInfo("glProgramUniform3uiv", typeof(GLNativeDelegate.FNglProgramUniform3uiv));
            // yield return new ProcInfo("glProgramUniform4i", typeof(GLNativeDelegate.FNglProgramUniform4i));
            // yield return new ProcInfo("glProgramUniform4iv", typeof(GLNativeDelegate.FNglProgramUniform4iv));
            // yield return new ProcInfo("glProgramUniform4f", typeof(GLNativeDelegate.FNglProgramUniform4f));
            // yield return new ProcInfo("glProgramUniform4fv", typeof(GLNativeDelegate.FNglProgramUniform4fv));
            // yield return new ProcInfo("glProgramUniform4d", typeof(GLNativeDelegate.FNglProgramUniform4d));
            // yield return new ProcInfo("glProgramUniform4dv", typeof(GLNativeDelegate.FNglProgramUniform4dv));
            // yield return new ProcInfo("glProgramUniform4ui", typeof(GLNativeDelegate.FNglProgramUniform4ui));
            // yield return new ProcInfo("glProgramUniform4uiv", typeof(GLNativeDelegate.FNglProgramUniform4uiv));
            // yield return new ProcInfo("glProgramUniformMatrix2fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix2fv));
            // yield return new ProcInfo("glProgramUniformMatrix3fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix3fv));
            // yield return new ProcInfo("glProgramUniformMatrix4fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix4fv));
            // yield return new ProcInfo("glProgramUniformMatrix2dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix2dv));
            // yield return new ProcInfo("glProgramUniformMatrix3dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix3dv));
            // yield return new ProcInfo("glProgramUniformMatrix4dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix4dv));
            // yield return new ProcInfo("glProgramUniformMatrix2x3fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix2x3fv));
            // yield return new ProcInfo("glProgramUniformMatrix3x2fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix3x2fv));
            // yield return new ProcInfo("glProgramUniformMatrix2x4fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix2x4fv));
            // yield return new ProcInfo("glProgramUniformMatrix4x2fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix4x2fv));
            // yield return new ProcInfo("glProgramUniformMatrix3x4fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix3x4fv));
            // yield return new ProcInfo("glProgramUniformMatrix4x3fv", typeof(GLNativeDelegate.FNglProgramUniformMatrix4x3fv));
            // yield return new ProcInfo("glProgramUniformMatrix2x3dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix2x3dv));
            // yield return new ProcInfo("glProgramUniformMatrix3x2dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix3x2dv));
            // yield return new ProcInfo("glProgramUniformMatrix2x4dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix2x4dv));
            // yield return new ProcInfo("glProgramUniformMatrix4x2dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix4x2dv));
            // yield return new ProcInfo("glProgramUniformMatrix3x4dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix3x4dv));
            // yield return new ProcInfo("glProgramUniformMatrix4x3dv", typeof(GLNativeDelegate.FNglProgramUniformMatrix4x3dv));
            // yield return new ProcInfo("glValidateProgramPipeline", typeof(GLNativeDelegate.FNglValidateProgramPipeline));
            // yield return new ProcInfo("glGetProgramPipelineInfoLog", typeof(GLNativeDelegate.FNglGetProgramPipelineInfoLog));

            #endregion GL_ARB_separate_shader_objects

            #region GL_ARB_shader_atomic_counters

            // yield return new ProcInfo("glGetActiveAtomicCounterBufferiv", typeof(GLNativeDelegate.FNglGetActiveAtomicCounterBufferiv));

            #endregion GL_ARB_shader_atomic_counters

            #region GL_ARB_shader_image_load_store

            // yield return new ProcInfo("glBindImageTexture", typeof(GLNativeDelegate.FNglBindImageTexture));
            // yield return new ProcInfo("glMemoryBarrier", typeof(GLNativeDelegate.FNglMemoryBarrier));

            #endregion GL_ARB_shader_image_load_store

            #region GL_ARB_shader_objects

            yield return new ProcInfo("glDeleteObjectARB", typeof(GLNativeDelegate.FNglDeleteObjectARB));
            yield return new ProcInfo("glGetHandleARB", typeof(GLNativeDelegate.FNglGetHandleARB));
            yield return new ProcInfo("glDetachObjectARB", typeof(GLNativeDelegate.FNglDetachObjectARB));
            yield return new ProcInfo("glCreateShaderObjectARB", typeof(GLNativeDelegate.FNglCreateShaderObjectARB));
            yield return new ProcInfo("glShaderSourceARB", typeof(GLNativeDelegate.FNglShaderSourceARB));
            yield return new ProcInfo("glCompileShaderARB", typeof(GLNativeDelegate.FNglCompileShaderARB));
            yield return new ProcInfo("glCreateProgramObjectARB", typeof(GLNativeDelegate.FNglCreateProgramObjectARB));
            yield return new ProcInfo("glAttachObjectARB", typeof(GLNativeDelegate.FNglAttachObjectARB));
            yield return new ProcInfo("glLinkProgramARB", typeof(GLNativeDelegate.FNglLinkProgramARB));
            yield return new ProcInfo("glUseProgramObjectARB", typeof(GLNativeDelegate.FNglUseProgramObjectARB));
            yield return new ProcInfo("glValidateProgramARB", typeof(GLNativeDelegate.FNglValidateProgramARB));
            yield return new ProcInfo("glUniform1fARB", typeof(GLNativeDelegate.FNglUniform1fARB));
            yield return new ProcInfo("glUniform2fARB", typeof(GLNativeDelegate.FNglUniform2fARB));
            yield return new ProcInfo("glUniform3fARB", typeof(GLNativeDelegate.FNglUniform3fARB));
            yield return new ProcInfo("glUniform4fARB", typeof(GLNativeDelegate.FNglUniform4fARB));
            yield return new ProcInfo("glUniform1iARB", typeof(GLNativeDelegate.FNglUniform1iARB));
            yield return new ProcInfo("glUniform2iARB", typeof(GLNativeDelegate.FNglUniform2iARB));
            yield return new ProcInfo("glUniform3iARB", typeof(GLNativeDelegate.FNglUniform3iARB));
            yield return new ProcInfo("glUniform4iARB", typeof(GLNativeDelegate.FNglUniform4iARB));
            yield return new ProcInfo("glUniform1fvARB", typeof(GLNativeDelegate.FNglUniform1fvARB));
            yield return new ProcInfo("glUniform2fvARB", typeof(GLNativeDelegate.FNglUniform2fvARB));
            yield return new ProcInfo("glUniform3fvARB", typeof(GLNativeDelegate.FNglUniform3fvARB));
            yield return new ProcInfo("glUniform4fvARB", typeof(GLNativeDelegate.FNglUniform4fvARB));
            yield return new ProcInfo("glUniform1ivARB", typeof(GLNativeDelegate.FNglUniform1ivARB));
            yield return new ProcInfo("glUniform2ivARB", typeof(GLNativeDelegate.FNglUniform2ivARB));
            yield return new ProcInfo("glUniform3ivARB", typeof(GLNativeDelegate.FNglUniform3ivARB));
            yield return new ProcInfo("glUniform4ivARB", typeof(GLNativeDelegate.FNglUniform4ivARB));
            yield return new ProcInfo("glUniformMatrix2fvARB", typeof(GLNativeDelegate.FNglUniformMatrix2fvARB));
            yield return new ProcInfo("glUniformMatrix3fvARB", typeof(GLNativeDelegate.FNglUniformMatrix3fvARB));
            yield return new ProcInfo("glUniformMatrix4fvARB", typeof(GLNativeDelegate.FNglUniformMatrix4fvARB));
            yield return new ProcInfo("glGetObjectParameterfvARB", typeof(GLNativeDelegate.FNglGetObjectParameterfvARB));
            yield return new ProcInfo("glGetObjectParameterivARB", typeof(GLNativeDelegate.FNglGetObjectParameterivARB));
            yield return new ProcInfo("glGetInfoLogARB", typeof(GLNativeDelegate.FNglGetInfoLogARB));
            yield return new ProcInfo("glGetAttachedObjectsARB", typeof(GLNativeDelegate.FNglGetAttachedObjectsARB));
            yield return new ProcInfo("glGetUniformLocationARB", typeof(GLNativeDelegate.FNglGetUniformLocationARB));
            yield return new ProcInfo("glGetActiveUniformARB", typeof(GLNativeDelegate.FNglGetActiveUniformARB));
            yield return new ProcInfo("glGetUniformfvARB", typeof(GLNativeDelegate.FNglGetUniformfvARB));
            yield return new ProcInfo("glGetUniformivARB", typeof(GLNativeDelegate.FNglGetUniformivARB));
            yield return new ProcInfo("glGetShaderSourceARB", typeof(GLNativeDelegate.FNglGetShaderSourceARB));

            #endregion GL_ARB_shader_objects

            #region GL_ARB_shader_storage_buffer_object

            // yield return new ProcInfo("glShaderStorageBlockBinding", typeof(GLNativeDelegate.FNglShaderStorageBlockBinding));

            #endregion GL_ARB_shader_storage_buffer_object

            #region GL_ARB_shader_subroutine

            // yield return new ProcInfo("glGetSubroutineUniformLocation", typeof(GLNativeDelegate.FNglGetSubroutineUniformLocation));
            // yield return new ProcInfo("glGetSubroutineIndex", typeof(GLNativeDelegate.FNglGetSubroutineIndex));
            // yield return new ProcInfo("glGetActiveSubroutineUniformiv", typeof(GLNativeDelegate.FNglGetActiveSubroutineUniformiv));
            // yield return new ProcInfo("glGetActiveSubroutineUniformName", typeof(GLNativeDelegate.FNglGetActiveSubroutineUniformName));
            // yield return new ProcInfo("glGetActiveSubroutineName", typeof(GLNativeDelegate.FNglGetActiveSubroutineName));
            // yield return new ProcInfo("glUniformSubroutinesuiv", typeof(GLNativeDelegate.FNglUniformSubroutinesuiv));
            // yield return new ProcInfo("glGetUniformSubroutineuiv", typeof(GLNativeDelegate.FNglGetUniformSubroutineuiv));
            // yield return new ProcInfo("glGetProgramStageiv", typeof(GLNativeDelegate.FNglGetProgramStageiv));

            #endregion GL_ARB_shader_subroutine

            #region GL_ARB_shading_language_include

            yield return new ProcInfo("glNamedStringARB", typeof(GLNativeDelegate.FNglNamedStringARB));
            yield return new ProcInfo("glDeleteNamedStringARB", typeof(GLNativeDelegate.FNglDeleteNamedStringARB));
            yield return new ProcInfo("glCompileShaderIncludeARB", typeof(GLNativeDelegate.FNglCompileShaderIncludeARB));
            yield return new ProcInfo("glIsNamedStringARB", typeof(GLNativeDelegate.FNglIsNamedStringARB));
            yield return new ProcInfo("glGetNamedStringARB", typeof(GLNativeDelegate.FNglGetNamedStringARB));
            yield return new ProcInfo("glGetNamedStringivARB", typeof(GLNativeDelegate.FNglGetNamedStringivARB));

            #endregion GL_ARB_shading_language_include

            #region GL_ARB_sparse_buffer

            yield return new ProcInfo("glBufferPageCommitmentARB", typeof(GLNativeDelegate.FNglBufferPageCommitmentARB));
            yield return new ProcInfo("glNamedBufferPageCommitmentEXT", typeof(GLNativeDelegate.FNglNamedBufferPageCommitmentEXT));
            yield return new ProcInfo("glNamedBufferPageCommitmentARB", typeof(GLNativeDelegate.FNglNamedBufferPageCommitmentARB));

            #endregion GL_ARB_sparse_buffer

            #region GL_ARB_sparse_texture

            yield return new ProcInfo("glTexPageCommitmentARB", typeof(GLNativeDelegate.FNglTexPageCommitmentARB));

            #endregion GL_ARB_sparse_texture

            #region GL_ARB_sync

            // yield return new ProcInfo("glFenceSync", typeof(GLNativeDelegate.FNglFenceSync));
            // yield return new ProcInfo("glIsSync", typeof(GLNativeDelegate.FNglIsSync));
            // yield return new ProcInfo("glDeleteSync", typeof(GLNativeDelegate.FNglDeleteSync));
            // yield return new ProcInfo("glClientWaitSync", typeof(GLNativeDelegate.FNglClientWaitSync));
            // yield return new ProcInfo("glWaitSync", typeof(GLNativeDelegate.FNglWaitSync));
            // yield return new ProcInfo("glGetInteger64v", typeof(GLNativeDelegate.FNglGetInteger64v));
            // yield return new ProcInfo("glGetSynciv", typeof(GLNativeDelegate.FNglGetSynciv));

            #endregion GL_ARB_sync

            #region GL_ARB_tessellation_shader

            // yield return new ProcInfo("glPatchParameteri", typeof(GLNativeDelegate.FNglPatchParameteri));
            // yield return new ProcInfo("glPatchParameterfv", typeof(GLNativeDelegate.FNglPatchParameterfv));

            #endregion GL_ARB_tessellation_shader

            #region GL_ARB_texture_barrier

            // yield return new ProcInfo("glTextureBarrier", typeof(GLNativeDelegate.FNglTextureBarrier));

            #endregion GL_ARB_texture_barrier

            #region GL_ARB_texture_buffer_object

            yield return new ProcInfo("glTexBufferARB", typeof(GLNativeDelegate.FNglTexBufferARB));

            #endregion GL_ARB_texture_buffer_object

            #region GL_ARB_texture_buffer_range

            // yield return new ProcInfo("glTexBufferRange", typeof(GLNativeDelegate.FNglTexBufferRange));

            #endregion GL_ARB_texture_buffer_range

            #region GL_ARB_texture_compression

            yield return new ProcInfo("glCompressedTexImage3DARB", typeof(GLNativeDelegate.FNglCompressedTexImage3DARB));
            yield return new ProcInfo("glCompressedTexImage2DARB", typeof(GLNativeDelegate.FNglCompressedTexImage2DARB));
            yield return new ProcInfo("glCompressedTexImage1DARB", typeof(GLNativeDelegate.FNglCompressedTexImage1DARB));
            yield return new ProcInfo("glCompressedTexSubImage3DARB", typeof(GLNativeDelegate.FNglCompressedTexSubImage3DARB));
            yield return new ProcInfo("glCompressedTexSubImage2DARB", typeof(GLNativeDelegate.FNglCompressedTexSubImage2DARB));
            yield return new ProcInfo("glCompressedTexSubImage1DARB", typeof(GLNativeDelegate.FNglCompressedTexSubImage1DARB));
            yield return new ProcInfo("glGetCompressedTexImageARB", typeof(GLNativeDelegate.FNglGetCompressedTexImageARB));

            #endregion GL_ARB_texture_compression

            #region GL_ARB_texture_multisample

            // yield return new ProcInfo("glTexImage2DMultisample", typeof(GLNativeDelegate.FNglTexImage2DMultisample));
            // yield return new ProcInfo("glTexImage3DMultisample", typeof(GLNativeDelegate.FNglTexImage3DMultisample));
            // yield return new ProcInfo("glGetMultisamplefv", typeof(GLNativeDelegate.FNglGetMultisamplefv));
            // yield return new ProcInfo("glSampleMaski", typeof(GLNativeDelegate.FNglSampleMaski));

            #endregion GL_ARB_texture_multisample

            #region GL_ARB_texture_storage

            // yield return new ProcInfo("glTexStorage1D", typeof(GLNativeDelegate.FNglTexStorage1D));
            // yield return new ProcInfo("glTexStorage2D", typeof(GLNativeDelegate.FNglTexStorage2D));
            // yield return new ProcInfo("glTexStorage3D", typeof(GLNativeDelegate.FNglTexStorage3D));

            #endregion GL_ARB_texture_storage

            #region GL_ARB_texture_storage_multisample

            // yield return new ProcInfo("glTexStorage2DMultisample", typeof(GLNativeDelegate.FNglTexStorage2DMultisample));
            // yield return new ProcInfo("glTexStorage3DMultisample", typeof(GLNativeDelegate.FNglTexStorage3DMultisample));

            #endregion GL_ARB_texture_storage_multisample

            #region GL_ARB_texture_view

            // yield return new ProcInfo("glTextureView", typeof(GLNativeDelegate.FNglTextureView));

            #endregion GL_ARB_texture_view

            #region GL_ARB_timer_query

            // yield return new ProcInfo("glQueryCounter", typeof(GLNativeDelegate.FNglQueryCounter));
            // yield return new ProcInfo("glGetQueryObjecti64v", typeof(GLNativeDelegate.FNglGetQueryObjecti64v));
            // yield return new ProcInfo("glGetQueryObjectui64v", typeof(GLNativeDelegate.FNglGetQueryObjectui64v));

            #endregion GL_ARB_timer_query

            #region GL_ARB_transform_feedback2

            // yield return new ProcInfo("glBindTransformFeedback", typeof(GLNativeDelegate.FNglBindTransformFeedback));
            // yield return new ProcInfo("glDeleteTransformFeedbacks", typeof(GLNativeDelegate.FNglDeleteTransformFeedbacks));
            // yield return new ProcInfo("glGenTransformFeedbacks", typeof(GLNativeDelegate.FNglGenTransformFeedbacks));
            // yield return new ProcInfo("glIsTransformFeedback", typeof(GLNativeDelegate.FNglIsTransformFeedback));
            // yield return new ProcInfo("glPauseTransformFeedback", typeof(GLNativeDelegate.FNglPauseTransformFeedback));
            // yield return new ProcInfo("glResumeTransformFeedback", typeof(GLNativeDelegate.FNglResumeTransformFeedback));
            // yield return new ProcInfo("glDrawTransformFeedback", typeof(GLNativeDelegate.FNglDrawTransformFeedback));

            #endregion GL_ARB_transform_feedback2

            #region GL_ARB_transform_feedback3

            // yield return new ProcInfo("glDrawTransformFeedbackStream", typeof(GLNativeDelegate.FNglDrawTransformFeedbackStream));
            // yield return new ProcInfo("glBeginQueryIndexed", typeof(GLNativeDelegate.FNglBeginQueryIndexed));
            // yield return new ProcInfo("glEndQueryIndexed", typeof(GLNativeDelegate.FNglEndQueryIndexed));
            // yield return new ProcInfo("glGetQueryIndexediv", typeof(GLNativeDelegate.FNglGetQueryIndexediv));

            #endregion GL_ARB_transform_feedback3

            #region GL_ARB_transform_feedback_instanced

            // yield return new ProcInfo("glDrawTransformFeedbackInstanced", typeof(GLNativeDelegate.FNglDrawTransformFeedbackInstanced));
            // yield return new ProcInfo("glDrawTransformFeedbackStreamInstanced", typeof(GLNativeDelegate.FNglDrawTransformFeedbackStreamInstanced));

            #endregion GL_ARB_transform_feedback_instanced

            #region GL_ARB_transpose_matrix

            yield return new ProcInfo("glLoadTransposeMatrixfARB", typeof(GLNativeDelegate.FNglLoadTransposeMatrixfARB));
            yield return new ProcInfo("glLoadTransposeMatrixdARB", typeof(GLNativeDelegate.FNglLoadTransposeMatrixdARB));
            yield return new ProcInfo("glMultTransposeMatrixfARB", typeof(GLNativeDelegate.FNglMultTransposeMatrixfARB));
            yield return new ProcInfo("glMultTransposeMatrixdARB", typeof(GLNativeDelegate.FNglMultTransposeMatrixdARB));

            #endregion GL_ARB_transpose_matrix

            #region GL_ARB_uniform_buffer_object

            // yield return new ProcInfo("glGetUniformIndices", typeof(GLNativeDelegate.FNglGetUniformIndices));
            // yield return new ProcInfo("glGetActiveUniformsiv", typeof(GLNativeDelegate.FNglGetActiveUniformsiv));
            // yield return new ProcInfo("glGetActiveUniformName", typeof(GLNativeDelegate.FNglGetActiveUniformName));
            // yield return new ProcInfo("glGetUniformBlockIndex", typeof(GLNativeDelegate.FNglGetUniformBlockIndex));
            // yield return new ProcInfo("glGetActiveUniformBlockiv", typeof(GLNativeDelegate.FNglGetActiveUniformBlockiv));
            // yield return new ProcInfo("glGetActiveUniformBlockName", typeof(GLNativeDelegate.FNglGetActiveUniformBlockName));
            // yield return new ProcInfo("glUniformBlockBinding", typeof(GLNativeDelegate.FNglUniformBlockBinding));
            // yield return new ProcInfo("glBindBufferRange", typeof(GLNativeDelegate.FNglBindBufferRange));
            // yield return new ProcInfo("glBindBufferBase", typeof(GLNativeDelegate.FNglBindBufferBase));
            // yield return new ProcInfo("glGetIntegeri_v", typeof(GLNativeDelegate.FNglGetIntegeri_v));

            #endregion GL_ARB_uniform_buffer_object

            #region GL_ARB_vertex_array_object

            // yield return new ProcInfo("glBindVertexArray", typeof(GLNativeDelegate.FNglBindVertexArray));
            // yield return new ProcInfo("glDeleteVertexArrays", typeof(GLNativeDelegate.FNglDeleteVertexArrays));
            // yield return new ProcInfo("glGenVertexArrays", typeof(GLNativeDelegate.FNglGenVertexArrays));
            // yield return new ProcInfo("glIsVertexArray", typeof(GLNativeDelegate.FNglIsVertexArray));

            #endregion GL_ARB_vertex_array_object

            #region GL_ARB_vertex_attrib_64bit

            // yield return new ProcInfo("glVertexAttribL1d", typeof(GLNativeDelegate.FNglVertexAttribL1d));
            // yield return new ProcInfo("glVertexAttribL2d", typeof(GLNativeDelegate.FNglVertexAttribL2d));
            // yield return new ProcInfo("glVertexAttribL3d", typeof(GLNativeDelegate.FNglVertexAttribL3d));
            // yield return new ProcInfo("glVertexAttribL4d", typeof(GLNativeDelegate.FNglVertexAttribL4d));
            // yield return new ProcInfo("glVertexAttribL1dv", typeof(GLNativeDelegate.FNglVertexAttribL1dv));
            // yield return new ProcInfo("glVertexAttribL2dv", typeof(GLNativeDelegate.FNglVertexAttribL2dv));
            // yield return new ProcInfo("glVertexAttribL3dv", typeof(GLNativeDelegate.FNglVertexAttribL3dv));
            // yield return new ProcInfo("glVertexAttribL4dv", typeof(GLNativeDelegate.FNglVertexAttribL4dv));
            // yield return new ProcInfo("glVertexAttribLPointer", typeof(GLNativeDelegate.FNglVertexAttribLPointer));
            // yield return new ProcInfo("glGetVertexAttribLdv", typeof(GLNativeDelegate.FNglGetVertexAttribLdv));

            #endregion GL_ARB_vertex_attrib_64bit

            #region GL_ARB_vertex_attrib_binding

            // yield return new ProcInfo("glBindVertexBuffer", typeof(GLNativeDelegate.FNglBindVertexBuffer));
            // yield return new ProcInfo("glVertexAttribFormat", typeof(GLNativeDelegate.FNglVertexAttribFormat));
            // yield return new ProcInfo("glVertexAttribIFormat", typeof(GLNativeDelegate.FNglVertexAttribIFormat));
            // yield return new ProcInfo("glVertexAttribLFormat", typeof(GLNativeDelegate.FNglVertexAttribLFormat));
            // yield return new ProcInfo("glVertexAttribBinding", typeof(GLNativeDelegate.FNglVertexAttribBinding));
            // yield return new ProcInfo("glVertexBindingDivisor", typeof(GLNativeDelegate.FNglVertexBindingDivisor));

            #endregion GL_ARB_vertex_attrib_binding

            #region GL_ARB_vertex_blend

            yield return new ProcInfo("glWeightbvARB", typeof(GLNativeDelegate.FNglWeightbvARB));
            yield return new ProcInfo("glWeightsvARB", typeof(GLNativeDelegate.FNglWeightsvARB));
            yield return new ProcInfo("glWeightivARB", typeof(GLNativeDelegate.FNglWeightivARB));
            yield return new ProcInfo("glWeightfvARB", typeof(GLNativeDelegate.FNglWeightfvARB));
            yield return new ProcInfo("glWeightdvARB", typeof(GLNativeDelegate.FNglWeightdvARB));
            yield return new ProcInfo("glWeightubvARB", typeof(GLNativeDelegate.FNglWeightubvARB));
            yield return new ProcInfo("glWeightusvARB", typeof(GLNativeDelegate.FNglWeightusvARB));
            yield return new ProcInfo("glWeightuivARB", typeof(GLNativeDelegate.FNglWeightuivARB));
            yield return new ProcInfo("glWeightPointerARB", typeof(GLNativeDelegate.FNglWeightPointerARB));
            yield return new ProcInfo("glVertexBlendARB", typeof(GLNativeDelegate.FNglVertexBlendARB));

            #endregion GL_ARB_vertex_blend

            #region GL_ARB_vertex_buffer_object

            yield return new ProcInfo("glBindBufferARB", typeof(GLNativeDelegate.FNglBindBufferARB));
            yield return new ProcInfo("glDeleteBuffersARB", typeof(GLNativeDelegate.FNglDeleteBuffersARB));
            yield return new ProcInfo("glGenBuffersARB", typeof(GLNativeDelegate.FNglGenBuffersARB));
            yield return new ProcInfo("glIsBufferARB", typeof(GLNativeDelegate.FNglIsBufferARB));
            yield return new ProcInfo("glBufferDataARB", typeof(GLNativeDelegate.FNglBufferDataARB));
            yield return new ProcInfo("glBufferSubDataARB", typeof(GLNativeDelegate.FNglBufferSubDataARB));
            yield return new ProcInfo("glGetBufferSubDataARB", typeof(GLNativeDelegate.FNglGetBufferSubDataARB));
            yield return new ProcInfo("glMapBufferARB", typeof(GLNativeDelegate.FNglMapBufferARB));
            yield return new ProcInfo("glUnmapBufferARB", typeof(GLNativeDelegate.FNglUnmapBufferARB));
            yield return new ProcInfo("glGetBufferParameterivARB", typeof(GLNativeDelegate.FNglGetBufferParameterivARB));
            yield return new ProcInfo("glGetBufferPointervARB", typeof(GLNativeDelegate.FNglGetBufferPointervARB));

            #endregion GL_ARB_vertex_buffer_object

            #region GL_ARB_vertex_program

            yield return new ProcInfo("glVertexAttrib1dARB", typeof(GLNativeDelegate.FNglVertexAttrib1dARB));
            yield return new ProcInfo("glVertexAttrib1dvARB", typeof(GLNativeDelegate.FNglVertexAttrib1dvARB));
            yield return new ProcInfo("glVertexAttrib1fARB", typeof(GLNativeDelegate.FNglVertexAttrib1fARB));
            yield return new ProcInfo("glVertexAttrib1fvARB", typeof(GLNativeDelegate.FNglVertexAttrib1fvARB));
            yield return new ProcInfo("glVertexAttrib1sARB", typeof(GLNativeDelegate.FNglVertexAttrib1sARB));
            yield return new ProcInfo("glVertexAttrib1svARB", typeof(GLNativeDelegate.FNglVertexAttrib1svARB));
            yield return new ProcInfo("glVertexAttrib2dARB", typeof(GLNativeDelegate.FNglVertexAttrib2dARB));
            yield return new ProcInfo("glVertexAttrib2dvARB", typeof(GLNativeDelegate.FNglVertexAttrib2dvARB));
            yield return new ProcInfo("glVertexAttrib2fARB", typeof(GLNativeDelegate.FNglVertexAttrib2fARB));
            yield return new ProcInfo("glVertexAttrib2fvARB", typeof(GLNativeDelegate.FNglVertexAttrib2fvARB));
            yield return new ProcInfo("glVertexAttrib2sARB", typeof(GLNativeDelegate.FNglVertexAttrib2sARB));
            yield return new ProcInfo("glVertexAttrib2svARB", typeof(GLNativeDelegate.FNglVertexAttrib2svARB));
            yield return new ProcInfo("glVertexAttrib3dARB", typeof(GLNativeDelegate.FNglVertexAttrib3dARB));
            yield return new ProcInfo("glVertexAttrib3dvARB", typeof(GLNativeDelegate.FNglVertexAttrib3dvARB));
            yield return new ProcInfo("glVertexAttrib3fARB", typeof(GLNativeDelegate.FNglVertexAttrib3fARB));
            yield return new ProcInfo("glVertexAttrib3fvARB", typeof(GLNativeDelegate.FNglVertexAttrib3fvARB));
            yield return new ProcInfo("glVertexAttrib3sARB", typeof(GLNativeDelegate.FNglVertexAttrib3sARB));
            yield return new ProcInfo("glVertexAttrib3svARB", typeof(GLNativeDelegate.FNglVertexAttrib3svARB));
            yield return new ProcInfo("glVertexAttrib4NbvARB", typeof(GLNativeDelegate.FNglVertexAttrib4NbvARB));
            yield return new ProcInfo("glVertexAttrib4NivARB", typeof(GLNativeDelegate.FNglVertexAttrib4NivARB));
            yield return new ProcInfo("glVertexAttrib4NsvARB", typeof(GLNativeDelegate.FNglVertexAttrib4NsvARB));
            yield return new ProcInfo("glVertexAttrib4NubARB", typeof(GLNativeDelegate.FNglVertexAttrib4NubARB));
            yield return new ProcInfo("glVertexAttrib4NubvARB", typeof(GLNativeDelegate.FNglVertexAttrib4NubvARB));
            yield return new ProcInfo("glVertexAttrib4NuivARB", typeof(GLNativeDelegate.FNglVertexAttrib4NuivARB));
            yield return new ProcInfo("glVertexAttrib4NusvARB", typeof(GLNativeDelegate.FNglVertexAttrib4NusvARB));
            yield return new ProcInfo("glVertexAttrib4bvARB", typeof(GLNativeDelegate.FNglVertexAttrib4bvARB));
            yield return new ProcInfo("glVertexAttrib4dARB", typeof(GLNativeDelegate.FNglVertexAttrib4dARB));
            yield return new ProcInfo("glVertexAttrib4dvARB", typeof(GLNativeDelegate.FNglVertexAttrib4dvARB));
            yield return new ProcInfo("glVertexAttrib4fARB", typeof(GLNativeDelegate.FNglVertexAttrib4fARB));
            yield return new ProcInfo("glVertexAttrib4fvARB", typeof(GLNativeDelegate.FNglVertexAttrib4fvARB));
            yield return new ProcInfo("glVertexAttrib4ivARB", typeof(GLNativeDelegate.FNglVertexAttrib4ivARB));
            yield return new ProcInfo("glVertexAttrib4sARB", typeof(GLNativeDelegate.FNglVertexAttrib4sARB));
            yield return new ProcInfo("glVertexAttrib4svARB", typeof(GLNativeDelegate.FNglVertexAttrib4svARB));
            yield return new ProcInfo("glVertexAttrib4ubvARB", typeof(GLNativeDelegate.FNglVertexAttrib4ubvARB));
            yield return new ProcInfo("glVertexAttrib4uivARB", typeof(GLNativeDelegate.FNglVertexAttrib4uivARB));
            yield return new ProcInfo("glVertexAttrib4usvARB", typeof(GLNativeDelegate.FNglVertexAttrib4usvARB));
            yield return new ProcInfo("glVertexAttribPointerARB", typeof(GLNativeDelegate.FNglVertexAttribPointerARB));
            yield return new ProcInfo("glEnableVertexAttribArrayARB", typeof(GLNativeDelegate.FNglEnableVertexAttribArrayARB));
            yield return new ProcInfo("glDisableVertexAttribArrayARB", typeof(GLNativeDelegate.FNglDisableVertexAttribArrayARB));
            yield return new ProcInfo("glProgramStringARB", typeof(GLNativeDelegate.FNglProgramStringARB));
            yield return new ProcInfo("glBindProgramARB", typeof(GLNativeDelegate.FNglBindProgramARB));
            yield return new ProcInfo("glDeleteProgramsARB", typeof(GLNativeDelegate.FNglDeleteProgramsARB));
            yield return new ProcInfo("glGenProgramsARB", typeof(GLNativeDelegate.FNglGenProgramsARB));
            yield return new ProcInfo("glProgramEnvParameter4dARB", typeof(GLNativeDelegate.FNglProgramEnvParameter4dARB));
            yield return new ProcInfo("glProgramEnvParameter4dvARB", typeof(GLNativeDelegate.FNglProgramEnvParameter4dvARB));
            yield return new ProcInfo("glProgramEnvParameter4fARB", typeof(GLNativeDelegate.FNglProgramEnvParameter4fARB));
            yield return new ProcInfo("glProgramEnvParameter4fvARB", typeof(GLNativeDelegate.FNglProgramEnvParameter4fvARB));
            yield return new ProcInfo("glProgramLocalParameter4dARB", typeof(GLNativeDelegate.FNglProgramLocalParameter4dARB));
            yield return new ProcInfo("glProgramLocalParameter4dvARB", typeof(GLNativeDelegate.FNglProgramLocalParameter4dvARB));
            yield return new ProcInfo("glProgramLocalParameter4fARB", typeof(GLNativeDelegate.FNglProgramLocalParameter4fARB));
            yield return new ProcInfo("glProgramLocalParameter4fvARB", typeof(GLNativeDelegate.FNglProgramLocalParameter4fvARB));
            yield return new ProcInfo("glGetProgramEnvParameterdvARB", typeof(GLNativeDelegate.FNglGetProgramEnvParameterdvARB));
            yield return new ProcInfo("glGetProgramEnvParameterfvARB", typeof(GLNativeDelegate.FNglGetProgramEnvParameterfvARB));
            yield return new ProcInfo("glGetProgramLocalParameterdvARB", typeof(GLNativeDelegate.FNglGetProgramLocalParameterdvARB));
            yield return new ProcInfo("glGetProgramLocalParameterfvARB", typeof(GLNativeDelegate.FNglGetProgramLocalParameterfvARB));
            yield return new ProcInfo("glGetProgramivARB", typeof(GLNativeDelegate.FNglGetProgramivARB));
            yield return new ProcInfo("glGetProgramStringARB", typeof(GLNativeDelegate.FNglGetProgramStringARB));
            yield return new ProcInfo("glGetVertexAttribdvARB", typeof(GLNativeDelegate.FNglGetVertexAttribdvARB));
            yield return new ProcInfo("glGetVertexAttribfvARB", typeof(GLNativeDelegate.FNglGetVertexAttribfvARB));
            yield return new ProcInfo("glGetVertexAttribivARB", typeof(GLNativeDelegate.FNglGetVertexAttribivARB));
            yield return new ProcInfo("glGetVertexAttribPointervARB", typeof(GLNativeDelegate.FNglGetVertexAttribPointervARB));
            yield return new ProcInfo("glIsProgramARB", typeof(GLNativeDelegate.FNglIsProgramARB));

            #endregion GL_ARB_vertex_program

            #region GL_ARB_vertex_shader

            // yield return new ProcInfo("glVertexAttrib1fARB", typeof(GLNativeDelegate.FNglVertexAttrib1fARB));
            // yield return new ProcInfo("glVertexAttrib1sARB", typeof(GLNativeDelegate.FNglVertexAttrib1sARB));
            // yield return new ProcInfo("glVertexAttrib1dARB", typeof(GLNativeDelegate.FNglVertexAttrib1dARB));
            // yield return new ProcInfo("glVertexAttrib2fARB", typeof(GLNativeDelegate.FNglVertexAttrib2fARB));
            // yield return new ProcInfo("glVertexAttrib2sARB", typeof(GLNativeDelegate.FNglVertexAttrib2sARB));
            // yield return new ProcInfo("glVertexAttrib2dARB", typeof(GLNativeDelegate.FNglVertexAttrib2dARB));
            // yield return new ProcInfo("glVertexAttrib3fARB", typeof(GLNativeDelegate.FNglVertexAttrib3fARB));
            // yield return new ProcInfo("glVertexAttrib3sARB", typeof(GLNativeDelegate.FNglVertexAttrib3sARB));
            // yield return new ProcInfo("glVertexAttrib3dARB", typeof(GLNativeDelegate.FNglVertexAttrib3dARB));
            // yield return new ProcInfo("glVertexAttrib4fARB", typeof(GLNativeDelegate.FNglVertexAttrib4fARB));
            // yield return new ProcInfo("glVertexAttrib4sARB", typeof(GLNativeDelegate.FNglVertexAttrib4sARB));
            // yield return new ProcInfo("glVertexAttrib4dARB", typeof(GLNativeDelegate.FNglVertexAttrib4dARB));
            // yield return new ProcInfo("glVertexAttrib4NubARB", typeof(GLNativeDelegate.FNglVertexAttrib4NubARB));
            // yield return new ProcInfo("glVertexAttrib1fvARB", typeof(GLNativeDelegate.FNglVertexAttrib1fvARB));
            // yield return new ProcInfo("glVertexAttrib1svARB", typeof(GLNativeDelegate.FNglVertexAttrib1svARB));
            // yield return new ProcInfo("glVertexAttrib1dvARB", typeof(GLNativeDelegate.FNglVertexAttrib1dvARB));
            // yield return new ProcInfo("glVertexAttrib2fvARB", typeof(GLNativeDelegate.FNglVertexAttrib2fvARB));
            // yield return new ProcInfo("glVertexAttrib2svARB", typeof(GLNativeDelegate.FNglVertexAttrib2svARB));
            // yield return new ProcInfo("glVertexAttrib2dvARB", typeof(GLNativeDelegate.FNglVertexAttrib2dvARB));
            // yield return new ProcInfo("glVertexAttrib3fvARB", typeof(GLNativeDelegate.FNglVertexAttrib3fvARB));
            // yield return new ProcInfo("glVertexAttrib3svARB", typeof(GLNativeDelegate.FNglVertexAttrib3svARB));
            // yield return new ProcInfo("glVertexAttrib3dvARB", typeof(GLNativeDelegate.FNglVertexAttrib3dvARB));
            // yield return new ProcInfo("glVertexAttrib4fvARB", typeof(GLNativeDelegate.FNglVertexAttrib4fvARB));
            // yield return new ProcInfo("glVertexAttrib4svARB", typeof(GLNativeDelegate.FNglVertexAttrib4svARB));
            // yield return new ProcInfo("glVertexAttrib4dvARB", typeof(GLNativeDelegate.FNglVertexAttrib4dvARB));
            // yield return new ProcInfo("glVertexAttrib4ivARB", typeof(GLNativeDelegate.FNglVertexAttrib4ivARB));
            // yield return new ProcInfo("glVertexAttrib4bvARB", typeof(GLNativeDelegate.FNglVertexAttrib4bvARB));
            // yield return new ProcInfo("glVertexAttrib4ubvARB", typeof(GLNativeDelegate.FNglVertexAttrib4ubvARB));
            // yield return new ProcInfo("glVertexAttrib4usvARB", typeof(GLNativeDelegate.FNglVertexAttrib4usvARB));
            // yield return new ProcInfo("glVertexAttrib4uivARB", typeof(GLNativeDelegate.FNglVertexAttrib4uivARB));
            // yield return new ProcInfo("glVertexAttrib4NbvARB", typeof(GLNativeDelegate.FNglVertexAttrib4NbvARB));
            // yield return new ProcInfo("glVertexAttrib4NsvARB", typeof(GLNativeDelegate.FNglVertexAttrib4NsvARB));
            // yield return new ProcInfo("glVertexAttrib4NivARB", typeof(GLNativeDelegate.FNglVertexAttrib4NivARB));
            // yield return new ProcInfo("glVertexAttrib4NubvARB", typeof(GLNativeDelegate.FNglVertexAttrib4NubvARB));
            // yield return new ProcInfo("glVertexAttrib4NusvARB", typeof(GLNativeDelegate.FNglVertexAttrib4NusvARB));
            // yield return new ProcInfo("glVertexAttrib4NuivARB", typeof(GLNativeDelegate.FNglVertexAttrib4NuivARB));
            // yield return new ProcInfo("glVertexAttribPointerARB", typeof(GLNativeDelegate.FNglVertexAttribPointerARB));
            // yield return new ProcInfo("glEnableVertexAttribArrayARB", typeof(GLNativeDelegate.FNglEnableVertexAttribArrayARB));
            // yield return new ProcInfo("glDisableVertexAttribArrayARB", typeof(GLNativeDelegate.FNglDisableVertexAttribArrayARB));
            yield return new ProcInfo("glBindAttribLocationARB", typeof(GLNativeDelegate.FNglBindAttribLocationARB));
            yield return new ProcInfo("glGetActiveAttribARB", typeof(GLNativeDelegate.FNglGetActiveAttribARB));
            yield return new ProcInfo("glGetAttribLocationARB", typeof(GLNativeDelegate.FNglGetAttribLocationARB));
            // yield return new ProcInfo("glGetVertexAttribdvARB", typeof(GLNativeDelegate.FNglGetVertexAttribdvARB));
            // yield return new ProcInfo("glGetVertexAttribfvARB", typeof(GLNativeDelegate.FNglGetVertexAttribfvARB));
            // yield return new ProcInfo("glGetVertexAttribivARB", typeof(GLNativeDelegate.FNglGetVertexAttribivARB));
            // yield return new ProcInfo("glGetVertexAttribPointervARB", typeof(GLNativeDelegate.FNglGetVertexAttribPointervARB));

            #endregion GL_ARB_vertex_shader

            #region GL_ARB_vertex_type_2_10_10_10_rev

            // yield return new ProcInfo("glVertexAttribP1ui", typeof(GLNativeDelegate.FNglVertexAttribP1ui));
            // yield return new ProcInfo("glVertexAttribP1uiv", typeof(GLNativeDelegate.FNglVertexAttribP1uiv));
            // yield return new ProcInfo("glVertexAttribP2ui", typeof(GLNativeDelegate.FNglVertexAttribP2ui));
            // yield return new ProcInfo("glVertexAttribP2uiv", typeof(GLNativeDelegate.FNglVertexAttribP2uiv));
            // yield return new ProcInfo("glVertexAttribP3ui", typeof(GLNativeDelegate.FNglVertexAttribP3ui));
            // yield return new ProcInfo("glVertexAttribP3uiv", typeof(GLNativeDelegate.FNglVertexAttribP3uiv));
            // yield return new ProcInfo("glVertexAttribP4ui", typeof(GLNativeDelegate.FNglVertexAttribP4ui));
            // yield return new ProcInfo("glVertexAttribP4uiv", typeof(GLNativeDelegate.FNglVertexAttribP4uiv));
            // yield return new ProcInfo("glVertexP2ui", typeof(GLNativeDelegate.FNglVertexP2ui));
            // yield return new ProcInfo("glVertexP2uiv", typeof(GLNativeDelegate.FNglVertexP2uiv));
            // yield return new ProcInfo("glVertexP3ui", typeof(GLNativeDelegate.FNglVertexP3ui));
            // yield return new ProcInfo("glVertexP3uiv", typeof(GLNativeDelegate.FNglVertexP3uiv));
            // yield return new ProcInfo("glVertexP4ui", typeof(GLNativeDelegate.FNglVertexP4ui));
            // yield return new ProcInfo("glVertexP4uiv", typeof(GLNativeDelegate.FNglVertexP4uiv));
            // yield return new ProcInfo("glTexCoordP1ui", typeof(GLNativeDelegate.FNglTexCoordP1ui));
            // yield return new ProcInfo("glTexCoordP1uiv", typeof(GLNativeDelegate.FNglTexCoordP1uiv));
            // yield return new ProcInfo("glTexCoordP2ui", typeof(GLNativeDelegate.FNglTexCoordP2ui));
            // yield return new ProcInfo("glTexCoordP2uiv", typeof(GLNativeDelegate.FNglTexCoordP2uiv));
            // yield return new ProcInfo("glTexCoordP3ui", typeof(GLNativeDelegate.FNglTexCoordP3ui));
            // yield return new ProcInfo("glTexCoordP3uiv", typeof(GLNativeDelegate.FNglTexCoordP3uiv));
            // yield return new ProcInfo("glTexCoordP4ui", typeof(GLNativeDelegate.FNglTexCoordP4ui));
            // yield return new ProcInfo("glTexCoordP4uiv", typeof(GLNativeDelegate.FNglTexCoordP4uiv));
            // yield return new ProcInfo("glMultiTexCoordP1ui", typeof(GLNativeDelegate.FNglMultiTexCoordP1ui));
            // yield return new ProcInfo("glMultiTexCoordP1uiv", typeof(GLNativeDelegate.FNglMultiTexCoordP1uiv));
            // yield return new ProcInfo("glMultiTexCoordP2ui", typeof(GLNativeDelegate.FNglMultiTexCoordP2ui));
            // yield return new ProcInfo("glMultiTexCoordP2uiv", typeof(GLNativeDelegate.FNglMultiTexCoordP2uiv));
            // yield return new ProcInfo("glMultiTexCoordP3ui", typeof(GLNativeDelegate.FNglMultiTexCoordP3ui));
            // yield return new ProcInfo("glMultiTexCoordP3uiv", typeof(GLNativeDelegate.FNglMultiTexCoordP3uiv));
            // yield return new ProcInfo("glMultiTexCoordP4ui", typeof(GLNativeDelegate.FNglMultiTexCoordP4ui));
            // yield return new ProcInfo("glMultiTexCoordP4uiv", typeof(GLNativeDelegate.FNglMultiTexCoordP4uiv));
            // yield return new ProcInfo("glNormalP3ui", typeof(GLNativeDelegate.FNglNormalP3ui));
            // yield return new ProcInfo("glNormalP3uiv", typeof(GLNativeDelegate.FNglNormalP3uiv));
            // yield return new ProcInfo("glColorP3ui", typeof(GLNativeDelegate.FNglColorP3ui));
            // yield return new ProcInfo("glColorP3uiv", typeof(GLNativeDelegate.FNglColorP3uiv));
            // yield return new ProcInfo("glColorP4ui", typeof(GLNativeDelegate.FNglColorP4ui));
            // yield return new ProcInfo("glColorP4uiv", typeof(GLNativeDelegate.FNglColorP4uiv));
            // yield return new ProcInfo("glSecondaryColorP3ui", typeof(GLNativeDelegate.FNglSecondaryColorP3ui));
            // yield return new ProcInfo("glSecondaryColorP3uiv", typeof(GLNativeDelegate.FNglSecondaryColorP3uiv));

            #endregion GL_ARB_vertex_type_2_10_10_10_rev

            #region GL_ARB_viewport_array

            // yield return new ProcInfo("glViewportArrayv", typeof(GLNativeDelegate.FNglViewportArrayv));
            // yield return new ProcInfo("glViewportIndexedf", typeof(GLNativeDelegate.FNglViewportIndexedf));
            // yield return new ProcInfo("glViewportIndexedfv", typeof(GLNativeDelegate.FNglViewportIndexedfv));
            // yield return new ProcInfo("glScissorArrayv", typeof(GLNativeDelegate.FNglScissorArrayv));
            // yield return new ProcInfo("glScissorIndexed", typeof(GLNativeDelegate.FNglScissorIndexed));
            // yield return new ProcInfo("glScissorIndexedv", typeof(GLNativeDelegate.FNglScissorIndexedv));
            // yield return new ProcInfo("glDepthRangeArrayv", typeof(GLNativeDelegate.FNglDepthRangeArrayv));
            // yield return new ProcInfo("glDepthRangeIndexed", typeof(GLNativeDelegate.FNglDepthRangeIndexed));
            // yield return new ProcInfo("glGetFloati_v", typeof(GLNativeDelegate.FNglGetFloati_v));
            // yield return new ProcInfo("glGetDoublei_v", typeof(GLNativeDelegate.FNglGetDoublei_v));
            yield return new ProcInfo("glDepthRangeArraydvNV", typeof(GLNativeDelegate.FNglDepthRangeArraydvNV));
            yield return new ProcInfo("glDepthRangeIndexeddNV", typeof(GLNativeDelegate.FNglDepthRangeIndexeddNV));

            #endregion GL_ARB_viewport_array

            #region GL_ARB_window_pos

            yield return new ProcInfo("glWindowPos2dARB", typeof(GLNativeDelegate.FNglWindowPos2dARB));
            yield return new ProcInfo("glWindowPos2dvARB", typeof(GLNativeDelegate.FNglWindowPos2dvARB));
            yield return new ProcInfo("glWindowPos2fARB", typeof(GLNativeDelegate.FNglWindowPos2fARB));
            yield return new ProcInfo("glWindowPos2fvARB", typeof(GLNativeDelegate.FNglWindowPos2fvARB));
            yield return new ProcInfo("glWindowPos2iARB", typeof(GLNativeDelegate.FNglWindowPos2iARB));
            yield return new ProcInfo("glWindowPos2ivARB", typeof(GLNativeDelegate.FNglWindowPos2ivARB));
            yield return new ProcInfo("glWindowPos2sARB", typeof(GLNativeDelegate.FNglWindowPos2sARB));
            yield return new ProcInfo("glWindowPos2svARB", typeof(GLNativeDelegate.FNglWindowPos2svARB));
            yield return new ProcInfo("glWindowPos3dARB", typeof(GLNativeDelegate.FNglWindowPos3dARB));
            yield return new ProcInfo("glWindowPos3dvARB", typeof(GLNativeDelegate.FNglWindowPos3dvARB));
            yield return new ProcInfo("glWindowPos3fARB", typeof(GLNativeDelegate.FNglWindowPos3fARB));
            yield return new ProcInfo("glWindowPos3fvARB", typeof(GLNativeDelegate.FNglWindowPos3fvARB));
            yield return new ProcInfo("glWindowPos3iARB", typeof(GLNativeDelegate.FNglWindowPos3iARB));
            yield return new ProcInfo("glWindowPos3ivARB", typeof(GLNativeDelegate.FNglWindowPos3ivARB));
            yield return new ProcInfo("glWindowPos3sARB", typeof(GLNativeDelegate.FNglWindowPos3sARB));
            yield return new ProcInfo("glWindowPos3svARB", typeof(GLNativeDelegate.FNglWindowPos3svARB));

            #endregion GL_ARB_window_pos

            #region GL_ATI_draw_buffers

            yield return new ProcInfo("glDrawBuffersATI", typeof(GLNativeDelegate.FNglDrawBuffersATI));

            #endregion GL_ATI_draw_buffers

            #region GL_ATI_element_array

            yield return new ProcInfo("glElementPointerATI", typeof(GLNativeDelegate.FNglElementPointerATI));
            yield return new ProcInfo("glDrawElementArrayATI", typeof(GLNativeDelegate.FNglDrawElementArrayATI));
            yield return new ProcInfo("glDrawRangeElementArrayATI", typeof(GLNativeDelegate.FNglDrawRangeElementArrayATI));

            #endregion GL_ATI_element_array

            #region GL_ATI_envmap_bumpmap

            yield return new ProcInfo("glTexBumpParameterivATI", typeof(GLNativeDelegate.FNglTexBumpParameterivATI));
            yield return new ProcInfo("glTexBumpParameterfvATI", typeof(GLNativeDelegate.FNglTexBumpParameterfvATI));
            yield return new ProcInfo("glGetTexBumpParameterivATI", typeof(GLNativeDelegate.FNglGetTexBumpParameterivATI));
            yield return new ProcInfo("glGetTexBumpParameterfvATI", typeof(GLNativeDelegate.FNglGetTexBumpParameterfvATI));

            #endregion GL_ATI_envmap_bumpmap

            #region GL_ATI_fragment_shader

            yield return new ProcInfo("glGenFragmentShadersATI", typeof(GLNativeDelegate.FNglGenFragmentShadersATI));
            yield return new ProcInfo("glBindFragmentShaderATI", typeof(GLNativeDelegate.FNglBindFragmentShaderATI));
            yield return new ProcInfo("glDeleteFragmentShaderATI", typeof(GLNativeDelegate.FNglDeleteFragmentShaderATI));
            yield return new ProcInfo("glBeginFragmentShaderATI", typeof(GLNativeDelegate.FNglBeginFragmentShaderATI));
            yield return new ProcInfo("glEndFragmentShaderATI", typeof(GLNativeDelegate.FNglEndFragmentShaderATI));
            yield return new ProcInfo("glPassTexCoordATI", typeof(GLNativeDelegate.FNglPassTexCoordATI));
            yield return new ProcInfo("glSampleMapATI", typeof(GLNativeDelegate.FNglSampleMapATI));
            yield return new ProcInfo("glColorFragmentOp1ATI", typeof(GLNativeDelegate.FNglColorFragmentOp1ATI));
            yield return new ProcInfo("glColorFragmentOp2ATI", typeof(GLNativeDelegate.FNglColorFragmentOp2ATI));
            yield return new ProcInfo("glColorFragmentOp3ATI", typeof(GLNativeDelegate.FNglColorFragmentOp3ATI));
            yield return new ProcInfo("glAlphaFragmentOp1ATI", typeof(GLNativeDelegate.FNglAlphaFragmentOp1ATI));
            yield return new ProcInfo("glAlphaFragmentOp2ATI", typeof(GLNativeDelegate.FNglAlphaFragmentOp2ATI));
            yield return new ProcInfo("glAlphaFragmentOp3ATI", typeof(GLNativeDelegate.FNglAlphaFragmentOp3ATI));
            yield return new ProcInfo("glSetFragmentShaderConstantATI", typeof(GLNativeDelegate.FNglSetFragmentShaderConstantATI));

            #endregion GL_ATI_fragment_shader

            #region GL_ATI_map_object_buffer

            yield return new ProcInfo("glMapObjectBufferATI", typeof(GLNativeDelegate.FNglMapObjectBufferATI));
            yield return new ProcInfo("glUnmapObjectBufferATI", typeof(GLNativeDelegate.FNglUnmapObjectBufferATI));

            #endregion GL_ATI_map_object_buffer

            #region GL_ATI_pn_triangles

            yield return new ProcInfo("glPNTrianglesiATI", typeof(GLNativeDelegate.FNglPNTrianglesiATI));
            yield return new ProcInfo("glPNTrianglesfATI", typeof(GLNativeDelegate.FNglPNTrianglesfATI));

            #endregion GL_ATI_pn_triangles

            #region GL_ATI_separate_stencil

            yield return new ProcInfo("glStencilOpSeparateATI", typeof(GLNativeDelegate.FNglStencilOpSeparateATI));
            yield return new ProcInfo("glStencilFuncSeparateATI", typeof(GLNativeDelegate.FNglStencilFuncSeparateATI));

            #endregion GL_ATI_separate_stencil

            #region GL_ATI_vertex_array_object

            yield return new ProcInfo("glNewObjectBufferATI", typeof(GLNativeDelegate.FNglNewObjectBufferATI));
            yield return new ProcInfo("glIsObjectBufferATI", typeof(GLNativeDelegate.FNglIsObjectBufferATI));
            yield return new ProcInfo("glUpdateObjectBufferATI", typeof(GLNativeDelegate.FNglUpdateObjectBufferATI));
            yield return new ProcInfo("glGetObjectBufferfvATI", typeof(GLNativeDelegate.FNglGetObjectBufferfvATI));
            yield return new ProcInfo("glGetObjectBufferivATI", typeof(GLNativeDelegate.FNglGetObjectBufferivATI));
            yield return new ProcInfo("glFreeObjectBufferATI", typeof(GLNativeDelegate.FNglFreeObjectBufferATI));
            yield return new ProcInfo("glArrayObjectATI", typeof(GLNativeDelegate.FNglArrayObjectATI));
            yield return new ProcInfo("glGetArrayObjectfvATI", typeof(GLNativeDelegate.FNglGetArrayObjectfvATI));
            yield return new ProcInfo("glGetArrayObjectivATI", typeof(GLNativeDelegate.FNglGetArrayObjectivATI));
            yield return new ProcInfo("glVariantArrayObjectATI", typeof(GLNativeDelegate.FNglVariantArrayObjectATI));
            yield return new ProcInfo("glGetVariantArrayObjectfvATI", typeof(GLNativeDelegate.FNglGetVariantArrayObjectfvATI));
            yield return new ProcInfo("glGetVariantArrayObjectivATI", typeof(GLNativeDelegate.FNglGetVariantArrayObjectivATI));

            #endregion GL_ATI_vertex_array_object

            #region GL_ATI_vertex_attrib_array_object

            yield return new ProcInfo("glVertexAttribArrayObjectATI", typeof(GLNativeDelegate.FNglVertexAttribArrayObjectATI));
            yield return new ProcInfo("glGetVertexAttribArrayObjectfvATI", typeof(GLNativeDelegate.FNglGetVertexAttribArrayObjectfvATI));
            yield return new ProcInfo("glGetVertexAttribArrayObjectivATI", typeof(GLNativeDelegate.FNglGetVertexAttribArrayObjectivATI));

            #endregion GL_ATI_vertex_attrib_array_object

            #region GL_ATI_vertex_streams

            yield return new ProcInfo("glVertexStream1sATI", typeof(GLNativeDelegate.FNglVertexStream1sATI));
            yield return new ProcInfo("glVertexStream1svATI", typeof(GLNativeDelegate.FNglVertexStream1svATI));
            yield return new ProcInfo("glVertexStream1iATI", typeof(GLNativeDelegate.FNglVertexStream1iATI));
            yield return new ProcInfo("glVertexStream1ivATI", typeof(GLNativeDelegate.FNglVertexStream1ivATI));
            yield return new ProcInfo("glVertexStream1fATI", typeof(GLNativeDelegate.FNglVertexStream1fATI));
            yield return new ProcInfo("glVertexStream1fvATI", typeof(GLNativeDelegate.FNglVertexStream1fvATI));
            yield return new ProcInfo("glVertexStream1dATI", typeof(GLNativeDelegate.FNglVertexStream1dATI));
            yield return new ProcInfo("glVertexStream1dvATI", typeof(GLNativeDelegate.FNglVertexStream1dvATI));
            yield return new ProcInfo("glVertexStream2sATI", typeof(GLNativeDelegate.FNglVertexStream2sATI));
            yield return new ProcInfo("glVertexStream2svATI", typeof(GLNativeDelegate.FNglVertexStream2svATI));
            yield return new ProcInfo("glVertexStream2iATI", typeof(GLNativeDelegate.FNglVertexStream2iATI));
            yield return new ProcInfo("glVertexStream2ivATI", typeof(GLNativeDelegate.FNglVertexStream2ivATI));
            yield return new ProcInfo("glVertexStream2fATI", typeof(GLNativeDelegate.FNglVertexStream2fATI));
            yield return new ProcInfo("glVertexStream2fvATI", typeof(GLNativeDelegate.FNglVertexStream2fvATI));
            yield return new ProcInfo("glVertexStream2dATI", typeof(GLNativeDelegate.FNglVertexStream2dATI));
            yield return new ProcInfo("glVertexStream2dvATI", typeof(GLNativeDelegate.FNglVertexStream2dvATI));
            yield return new ProcInfo("glVertexStream3sATI", typeof(GLNativeDelegate.FNglVertexStream3sATI));
            yield return new ProcInfo("glVertexStream3svATI", typeof(GLNativeDelegate.FNglVertexStream3svATI));
            yield return new ProcInfo("glVertexStream3iATI", typeof(GLNativeDelegate.FNglVertexStream3iATI));
            yield return new ProcInfo("glVertexStream3ivATI", typeof(GLNativeDelegate.FNglVertexStream3ivATI));
            yield return new ProcInfo("glVertexStream3fATI", typeof(GLNativeDelegate.FNglVertexStream3fATI));
            yield return new ProcInfo("glVertexStream3fvATI", typeof(GLNativeDelegate.FNglVertexStream3fvATI));
            yield return new ProcInfo("glVertexStream3dATI", typeof(GLNativeDelegate.FNglVertexStream3dATI));
            yield return new ProcInfo("glVertexStream3dvATI", typeof(GLNativeDelegate.FNglVertexStream3dvATI));
            yield return new ProcInfo("glVertexStream4sATI", typeof(GLNativeDelegate.FNglVertexStream4sATI));
            yield return new ProcInfo("glVertexStream4svATI", typeof(GLNativeDelegate.FNglVertexStream4svATI));
            yield return new ProcInfo("glVertexStream4iATI", typeof(GLNativeDelegate.FNglVertexStream4iATI));
            yield return new ProcInfo("glVertexStream4ivATI", typeof(GLNativeDelegate.FNglVertexStream4ivATI));
            yield return new ProcInfo("glVertexStream4fATI", typeof(GLNativeDelegate.FNglVertexStream4fATI));
            yield return new ProcInfo("glVertexStream4fvATI", typeof(GLNativeDelegate.FNglVertexStream4fvATI));
            yield return new ProcInfo("glVertexStream4dATI", typeof(GLNativeDelegate.FNglVertexStream4dATI));
            yield return new ProcInfo("glVertexStream4dvATI", typeof(GLNativeDelegate.FNglVertexStream4dvATI));
            yield return new ProcInfo("glNormalStream3bATI", typeof(GLNativeDelegate.FNglNormalStream3bATI));
            yield return new ProcInfo("glNormalStream3bvATI", typeof(GLNativeDelegate.FNglNormalStream3bvATI));
            yield return new ProcInfo("glNormalStream3sATI", typeof(GLNativeDelegate.FNglNormalStream3sATI));
            yield return new ProcInfo("glNormalStream3svATI", typeof(GLNativeDelegate.FNglNormalStream3svATI));
            yield return new ProcInfo("glNormalStream3iATI", typeof(GLNativeDelegate.FNglNormalStream3iATI));
            yield return new ProcInfo("glNormalStream3ivATI", typeof(GLNativeDelegate.FNglNormalStream3ivATI));
            yield return new ProcInfo("glNormalStream3fATI", typeof(GLNativeDelegate.FNglNormalStream3fATI));
            yield return new ProcInfo("glNormalStream3fvATI", typeof(GLNativeDelegate.FNglNormalStream3fvATI));
            yield return new ProcInfo("glNormalStream3dATI", typeof(GLNativeDelegate.FNglNormalStream3dATI));
            yield return new ProcInfo("glNormalStream3dvATI", typeof(GLNativeDelegate.FNglNormalStream3dvATI));
            yield return new ProcInfo("glClientActiveVertexStreamATI", typeof(GLNativeDelegate.FNglClientActiveVertexStreamATI));
            yield return new ProcInfo("glVertexBlendEnviATI", typeof(GLNativeDelegate.FNglVertexBlendEnviATI));
            yield return new ProcInfo("glVertexBlendEnvfATI", typeof(GLNativeDelegate.FNglVertexBlendEnvfATI));

            #endregion GL_ATI_vertex_streams

            #region GL_EXT_EGL_image_storage

            yield return new ProcInfo("glEGLImageTargetTexStorageEXT", typeof(GLNativeDelegate.FNglEGLImageTargetTexStorageEXT));
            yield return new ProcInfo("glEGLImageTargetTextureStorageEXT", typeof(GLNativeDelegate.FNglEGLImageTargetTextureStorageEXT));

            #endregion GL_EXT_EGL_image_storage

            #region GL_EXT_bindable_uniform

            yield return new ProcInfo("glUniformBufferEXT", typeof(GLNativeDelegate.FNglUniformBufferEXT));
            yield return new ProcInfo("glGetUniformBufferSizeEXT", typeof(GLNativeDelegate.FNglGetUniformBufferSizeEXT));
            yield return new ProcInfo("glGetUniformOffsetEXT", typeof(GLNativeDelegate.FNglGetUniformOffsetEXT));

            #endregion GL_EXT_bindable_uniform

            #region GL_EXT_blend_color

            yield return new ProcInfo("glBlendColorEXT", typeof(GLNativeDelegate.FNglBlendColorEXT));

            #endregion GL_EXT_blend_color

            #region GL_EXT_blend_equation_separate

            yield return new ProcInfo("glBlendEquationSeparateEXT", typeof(GLNativeDelegate.FNglBlendEquationSeparateEXT));

            #endregion GL_EXT_blend_equation_separate

            #region GL_EXT_blend_func_separate

            yield return new ProcInfo("glBlendFuncSeparateEXT", typeof(GLNativeDelegate.FNglBlendFuncSeparateEXT));

            #endregion GL_EXT_blend_func_separate

            #region GL_EXT_color_subtable

            yield return new ProcInfo("glColorSubTableEXT", typeof(GLNativeDelegate.FNglColorSubTableEXT));
            yield return new ProcInfo("glCopyColorSubTableEXT", typeof(GLNativeDelegate.FNglCopyColorSubTableEXT));

            #endregion GL_EXT_color_subtable

            #region GL_EXT_compiled_vertex_array

            yield return new ProcInfo("glLockArraysEXT", typeof(GLNativeDelegate.FNglLockArraysEXT));
            yield return new ProcInfo("glUnlockArraysEXT", typeof(GLNativeDelegate.FNglUnlockArraysEXT));

            #endregion GL_EXT_compiled_vertex_array

            #region GL_EXT_convolution

            yield return new ProcInfo("glConvolutionFilter1DEXT", typeof(GLNativeDelegate.FNglConvolutionFilter1DEXT));
            yield return new ProcInfo("glConvolutionFilter2DEXT", typeof(GLNativeDelegate.FNglConvolutionFilter2DEXT));
            yield return new ProcInfo("glConvolutionParameterfEXT", typeof(GLNativeDelegate.FNglConvolutionParameterfEXT));
            yield return new ProcInfo("glConvolutionParameterfvEXT", typeof(GLNativeDelegate.FNglConvolutionParameterfvEXT));
            yield return new ProcInfo("glConvolutionParameteriEXT", typeof(GLNativeDelegate.FNglConvolutionParameteriEXT));
            yield return new ProcInfo("glConvolutionParameterivEXT", typeof(GLNativeDelegate.FNglConvolutionParameterivEXT));
            yield return new ProcInfo("glCopyConvolutionFilter1DEXT", typeof(GLNativeDelegate.FNglCopyConvolutionFilter1DEXT));
            yield return new ProcInfo("glCopyConvolutionFilter2DEXT", typeof(GLNativeDelegate.FNglCopyConvolutionFilter2DEXT));
            yield return new ProcInfo("glGetConvolutionFilterEXT", typeof(GLNativeDelegate.FNglGetConvolutionFilterEXT));
            yield return new ProcInfo("glGetConvolutionParameterfvEXT", typeof(GLNativeDelegate.FNglGetConvolutionParameterfvEXT));
            yield return new ProcInfo("glGetConvolutionParameterivEXT", typeof(GLNativeDelegate.FNglGetConvolutionParameterivEXT));
            yield return new ProcInfo("glGetSeparableFilterEXT", typeof(GLNativeDelegate.FNglGetSeparableFilterEXT));
            yield return new ProcInfo("glSeparableFilter2DEXT", typeof(GLNativeDelegate.FNglSeparableFilter2DEXT));

            #endregion GL_EXT_convolution

            #region GL_EXT_coordinate_frame

            yield return new ProcInfo("glTangent3bEXT", typeof(GLNativeDelegate.FNglTangent3bEXT));
            yield return new ProcInfo("glTangent3bvEXT", typeof(GLNativeDelegate.FNglTangent3bvEXT));
            yield return new ProcInfo("glTangent3dEXT", typeof(GLNativeDelegate.FNglTangent3dEXT));
            yield return new ProcInfo("glTangent3dvEXT", typeof(GLNativeDelegate.FNglTangent3dvEXT));
            yield return new ProcInfo("glTangent3fEXT", typeof(GLNativeDelegate.FNglTangent3fEXT));
            yield return new ProcInfo("glTangent3fvEXT", typeof(GLNativeDelegate.FNglTangent3fvEXT));
            yield return new ProcInfo("glTangent3iEXT", typeof(GLNativeDelegate.FNglTangent3iEXT));
            yield return new ProcInfo("glTangent3ivEXT", typeof(GLNativeDelegate.FNglTangent3ivEXT));
            yield return new ProcInfo("glTangent3sEXT", typeof(GLNativeDelegate.FNglTangent3sEXT));
            yield return new ProcInfo("glTangent3svEXT", typeof(GLNativeDelegate.FNglTangent3svEXT));
            yield return new ProcInfo("glBinormal3bEXT", typeof(GLNativeDelegate.FNglBinormal3bEXT));
            yield return new ProcInfo("glBinormal3bvEXT", typeof(GLNativeDelegate.FNglBinormal3bvEXT));
            yield return new ProcInfo("glBinormal3dEXT", typeof(GLNativeDelegate.FNglBinormal3dEXT));
            yield return new ProcInfo("glBinormal3dvEXT", typeof(GLNativeDelegate.FNglBinormal3dvEXT));
            yield return new ProcInfo("glBinormal3fEXT", typeof(GLNativeDelegate.FNglBinormal3fEXT));
            yield return new ProcInfo("glBinormal3fvEXT", typeof(GLNativeDelegate.FNglBinormal3fvEXT));
            yield return new ProcInfo("glBinormal3iEXT", typeof(GLNativeDelegate.FNglBinormal3iEXT));
            yield return new ProcInfo("glBinormal3ivEXT", typeof(GLNativeDelegate.FNglBinormal3ivEXT));
            yield return new ProcInfo("glBinormal3sEXT", typeof(GLNativeDelegate.FNglBinormal3sEXT));
            yield return new ProcInfo("glBinormal3svEXT", typeof(GLNativeDelegate.FNglBinormal3svEXT));
            yield return new ProcInfo("glTangentPointerEXT", typeof(GLNativeDelegate.FNglTangentPointerEXT));
            yield return new ProcInfo("glBinormalPointerEXT", typeof(GLNativeDelegate.FNglBinormalPointerEXT));

            #endregion GL_EXT_coordinate_frame

            #region GL_EXT_copy_texture

            yield return new ProcInfo("glCopyTexImage1DEXT", typeof(GLNativeDelegate.FNglCopyTexImage1DEXT));
            yield return new ProcInfo("glCopyTexImage2DEXT", typeof(GLNativeDelegate.FNglCopyTexImage2DEXT));
            yield return new ProcInfo("glCopyTexSubImage1DEXT", typeof(GLNativeDelegate.FNglCopyTexSubImage1DEXT));
            yield return new ProcInfo("glCopyTexSubImage2DEXT", typeof(GLNativeDelegate.FNglCopyTexSubImage2DEXT));
            yield return new ProcInfo("glCopyTexSubImage3DEXT", typeof(GLNativeDelegate.FNglCopyTexSubImage3DEXT));

            #endregion GL_EXT_copy_texture

            #region GL_EXT_cull_vertex

            yield return new ProcInfo("glCullParameterdvEXT", typeof(GLNativeDelegate.FNglCullParameterdvEXT));
            yield return new ProcInfo("glCullParameterfvEXT", typeof(GLNativeDelegate.FNglCullParameterfvEXT));

            #endregion GL_EXT_cull_vertex

            #region GL_EXT_debug_label

            yield return new ProcInfo("glLabelObjectEXT", typeof(GLNativeDelegate.FNglLabelObjectEXT));
            yield return new ProcInfo("glGetObjectLabelEXT", typeof(GLNativeDelegate.FNglGetObjectLabelEXT));

            #endregion GL_EXT_debug_label

            #region GL_EXT_debug_marker

            yield return new ProcInfo("glInsertEventMarkerEXT", typeof(GLNativeDelegate.FNglInsertEventMarkerEXT));
            yield return new ProcInfo("glPushGroupMarkerEXT", typeof(GLNativeDelegate.FNglPushGroupMarkerEXT));
            yield return new ProcInfo("glPopGroupMarkerEXT", typeof(GLNativeDelegate.FNglPopGroupMarkerEXT));

            #endregion GL_EXT_debug_marker

            #region GL_EXT_depth_bounds_test

            yield return new ProcInfo("glDepthBoundsEXT", typeof(GLNativeDelegate.FNglDepthBoundsEXT));

            #endregion GL_EXT_depth_bounds_test

            #region GL_EXT_draw_buffers2

            yield return new ProcInfo("glColorMaskIndexedEXT", typeof(GLNativeDelegate.FNglColorMaskIndexedEXT));
            yield return new ProcInfo("glGetBooleanIndexedvEXT", typeof(GLNativeDelegate.FNglGetBooleanIndexedvEXT));
            yield return new ProcInfo("glGetIntegerIndexedvEXT", typeof(GLNativeDelegate.FNglGetIntegerIndexedvEXT));
            yield return new ProcInfo("glEnableIndexedEXT", typeof(GLNativeDelegate.FNglEnableIndexedEXT));
            yield return new ProcInfo("glDisableIndexedEXT", typeof(GLNativeDelegate.FNglDisableIndexedEXT));
            yield return new ProcInfo("glIsEnabledIndexedEXT", typeof(GLNativeDelegate.FNglIsEnabledIndexedEXT));

            #endregion GL_EXT_draw_buffers2

            #region GL_EXT_draw_instanced

            yield return new ProcInfo("glDrawArraysInstancedEXT", typeof(GLNativeDelegate.FNglDrawArraysInstancedEXT));
            yield return new ProcInfo("glDrawElementsInstancedEXT", typeof(GLNativeDelegate.FNglDrawElementsInstancedEXT));

            #endregion GL_EXT_draw_instanced

            #region GL_EXT_draw_range_elements

            yield return new ProcInfo("glDrawRangeElementsEXT", typeof(GLNativeDelegate.FNglDrawRangeElementsEXT));

            #endregion GL_EXT_draw_range_elements

            #region GL_EXT_external_buffer

            yield return new ProcInfo("glBufferStorageExternalEXT", typeof(GLNativeDelegate.FNglBufferStorageExternalEXT));
            yield return new ProcInfo("glNamedBufferStorageExternalEXT", typeof(GLNativeDelegate.FNglNamedBufferStorageExternalEXT));

            #endregion GL_EXT_external_buffer

            #region GL_EXT_fog_coord

            yield return new ProcInfo("glFogCoordfEXT", typeof(GLNativeDelegate.FNglFogCoordfEXT));
            yield return new ProcInfo("glFogCoordfvEXT", typeof(GLNativeDelegate.FNglFogCoordfvEXT));
            yield return new ProcInfo("glFogCoorddEXT", typeof(GLNativeDelegate.FNglFogCoorddEXT));
            yield return new ProcInfo("glFogCoorddvEXT", typeof(GLNativeDelegate.FNglFogCoorddvEXT));
            yield return new ProcInfo("glFogCoordPointerEXT", typeof(GLNativeDelegate.FNglFogCoordPointerEXT));

            #endregion GL_EXT_fog_coord

            #region GL_EXT_framebuffer_blit

            yield return new ProcInfo("glBlitFramebufferEXT", typeof(GLNativeDelegate.FNglBlitFramebufferEXT));

            #endregion GL_EXT_framebuffer_blit

            #region GL_EXT_framebuffer_multisample

            yield return new ProcInfo("glRenderbufferStorageMultisampleEXT", typeof(GLNativeDelegate.FNglRenderbufferStorageMultisampleEXT));

            #endregion GL_EXT_framebuffer_multisample

            #region GL_EXT_framebuffer_object

            yield return new ProcInfo("glIsRenderbufferEXT", typeof(GLNativeDelegate.FNglIsRenderbufferEXT));
            yield return new ProcInfo("glBindRenderbufferEXT", typeof(GLNativeDelegate.FNglBindRenderbufferEXT));
            yield return new ProcInfo("glDeleteRenderbuffersEXT", typeof(GLNativeDelegate.FNglDeleteRenderbuffersEXT));
            yield return new ProcInfo("glGenRenderbuffersEXT", typeof(GLNativeDelegate.FNglGenRenderbuffersEXT));
            yield return new ProcInfo("glRenderbufferStorageEXT", typeof(GLNativeDelegate.FNglRenderbufferStorageEXT));
            yield return new ProcInfo("glGetRenderbufferParameterivEXT", typeof(GLNativeDelegate.FNglGetRenderbufferParameterivEXT));
            yield return new ProcInfo("glIsFramebufferEXT", typeof(GLNativeDelegate.FNglIsFramebufferEXT));
            yield return new ProcInfo("glBindFramebufferEXT", typeof(GLNativeDelegate.FNglBindFramebufferEXT));
            yield return new ProcInfo("glDeleteFramebuffersEXT", typeof(GLNativeDelegate.FNglDeleteFramebuffersEXT));
            yield return new ProcInfo("glGenFramebuffersEXT", typeof(GLNativeDelegate.FNglGenFramebuffersEXT));
            yield return new ProcInfo("glCheckFramebufferStatusEXT", typeof(GLNativeDelegate.FNglCheckFramebufferStatusEXT));
            yield return new ProcInfo("glFramebufferTexture1DEXT", typeof(GLNativeDelegate.FNglFramebufferTexture1DEXT));
            yield return new ProcInfo("glFramebufferTexture2DEXT", typeof(GLNativeDelegate.FNglFramebufferTexture2DEXT));
            yield return new ProcInfo("glFramebufferTexture3DEXT", typeof(GLNativeDelegate.FNglFramebufferTexture3DEXT));
            yield return new ProcInfo("glFramebufferRenderbufferEXT", typeof(GLNativeDelegate.FNglFramebufferRenderbufferEXT));
            yield return new ProcInfo("glGetFramebufferAttachmentParameterivEXT", typeof(GLNativeDelegate.FNglGetFramebufferAttachmentParameterivEXT));
            yield return new ProcInfo("glGenerateMipmapEXT", typeof(GLNativeDelegate.FNglGenerateMipmapEXT));

            #endregion GL_EXT_framebuffer_object

            #region GL_EXT_geometry_shader4

            yield return new ProcInfo("glProgramParameteriEXT", typeof(GLNativeDelegate.FNglProgramParameteriEXT));

            #endregion GL_EXT_geometry_shader4

            #region GL_EXT_gpu_program_parameters

            yield return new ProcInfo("glProgramEnvParameters4fvEXT", typeof(GLNativeDelegate.FNglProgramEnvParameters4fvEXT));
            yield return new ProcInfo("glProgramLocalParameters4fvEXT", typeof(GLNativeDelegate.FNglProgramLocalParameters4fvEXT));

            #endregion GL_EXT_gpu_program_parameters

            #region GL_EXT_gpu_shader4

            yield return new ProcInfo("glGetUniformuivEXT", typeof(GLNativeDelegate.FNglGetUniformuivEXT));
            yield return new ProcInfo("glBindFragDataLocationEXT", typeof(GLNativeDelegate.FNglBindFragDataLocationEXT));
            yield return new ProcInfo("glGetFragDataLocationEXT", typeof(GLNativeDelegate.FNglGetFragDataLocationEXT));
            yield return new ProcInfo("glUniform1uiEXT", typeof(GLNativeDelegate.FNglUniform1uiEXT));
            yield return new ProcInfo("glUniform2uiEXT", typeof(GLNativeDelegate.FNglUniform2uiEXT));
            yield return new ProcInfo("glUniform3uiEXT", typeof(GLNativeDelegate.FNglUniform3uiEXT));
            yield return new ProcInfo("glUniform4uiEXT", typeof(GLNativeDelegate.FNglUniform4uiEXT));
            yield return new ProcInfo("glUniform1uivEXT", typeof(GLNativeDelegate.FNglUniform1uivEXT));
            yield return new ProcInfo("glUniform2uivEXT", typeof(GLNativeDelegate.FNglUniform2uivEXT));
            yield return new ProcInfo("glUniform3uivEXT", typeof(GLNativeDelegate.FNglUniform3uivEXT));
            yield return new ProcInfo("glUniform4uivEXT", typeof(GLNativeDelegate.FNglUniform4uivEXT));
            yield return new ProcInfo("glVertexAttribI1iEXT", typeof(GLNativeDelegate.FNglVertexAttribI1iEXT));
            yield return new ProcInfo("glVertexAttribI2iEXT", typeof(GLNativeDelegate.FNglVertexAttribI2iEXT));
            yield return new ProcInfo("glVertexAttribI3iEXT", typeof(GLNativeDelegate.FNglVertexAttribI3iEXT));
            yield return new ProcInfo("glVertexAttribI4iEXT", typeof(GLNativeDelegate.FNglVertexAttribI4iEXT));
            yield return new ProcInfo("glVertexAttribI1uiEXT", typeof(GLNativeDelegate.FNglVertexAttribI1uiEXT));
            yield return new ProcInfo("glVertexAttribI2uiEXT", typeof(GLNativeDelegate.FNglVertexAttribI2uiEXT));
            yield return new ProcInfo("glVertexAttribI3uiEXT", typeof(GLNativeDelegate.FNglVertexAttribI3uiEXT));
            yield return new ProcInfo("glVertexAttribI4uiEXT", typeof(GLNativeDelegate.FNglVertexAttribI4uiEXT));
            yield return new ProcInfo("glVertexAttribI1ivEXT", typeof(GLNativeDelegate.FNglVertexAttribI1ivEXT));
            yield return new ProcInfo("glVertexAttribI2ivEXT", typeof(GLNativeDelegate.FNglVertexAttribI2ivEXT));
            yield return new ProcInfo("glVertexAttribI3ivEXT", typeof(GLNativeDelegate.FNglVertexAttribI3ivEXT));
            yield return new ProcInfo("glVertexAttribI4ivEXT", typeof(GLNativeDelegate.FNglVertexAttribI4ivEXT));
            yield return new ProcInfo("glVertexAttribI1uivEXT", typeof(GLNativeDelegate.FNglVertexAttribI1uivEXT));
            yield return new ProcInfo("glVertexAttribI2uivEXT", typeof(GLNativeDelegate.FNglVertexAttribI2uivEXT));
            yield return new ProcInfo("glVertexAttribI3uivEXT", typeof(GLNativeDelegate.FNglVertexAttribI3uivEXT));
            yield return new ProcInfo("glVertexAttribI4uivEXT", typeof(GLNativeDelegate.FNglVertexAttribI4uivEXT));
            yield return new ProcInfo("glVertexAttribI4bvEXT", typeof(GLNativeDelegate.FNglVertexAttribI4bvEXT));
            yield return new ProcInfo("glVertexAttribI4svEXT", typeof(GLNativeDelegate.FNglVertexAttribI4svEXT));
            yield return new ProcInfo("glVertexAttribI4ubvEXT", typeof(GLNativeDelegate.FNglVertexAttribI4ubvEXT));
            yield return new ProcInfo("glVertexAttribI4usvEXT", typeof(GLNativeDelegate.FNglVertexAttribI4usvEXT));
            yield return new ProcInfo("glVertexAttribIPointerEXT", typeof(GLNativeDelegate.FNglVertexAttribIPointerEXT));
            yield return new ProcInfo("glGetVertexAttribIivEXT", typeof(GLNativeDelegate.FNglGetVertexAttribIivEXT));
            yield return new ProcInfo("glGetVertexAttribIuivEXT", typeof(GLNativeDelegate.FNglGetVertexAttribIuivEXT));

            #endregion GL_EXT_gpu_shader4

            #region GL_EXT_histogram

            yield return new ProcInfo("glGetHistogramEXT", typeof(GLNativeDelegate.FNglGetHistogramEXT));
            yield return new ProcInfo("glGetHistogramParameterfvEXT", typeof(GLNativeDelegate.FNglGetHistogramParameterfvEXT));
            yield return new ProcInfo("glGetHistogramParameterivEXT", typeof(GLNativeDelegate.FNglGetHistogramParameterivEXT));
            yield return new ProcInfo("glGetMinmaxEXT", typeof(GLNativeDelegate.FNglGetMinmaxEXT));
            yield return new ProcInfo("glGetMinmaxParameterfvEXT", typeof(GLNativeDelegate.FNglGetMinmaxParameterfvEXT));
            yield return new ProcInfo("glGetMinmaxParameterivEXT", typeof(GLNativeDelegate.FNglGetMinmaxParameterivEXT));
            yield return new ProcInfo("glHistogramEXT", typeof(GLNativeDelegate.FNglHistogramEXT));
            yield return new ProcInfo("glMinmaxEXT", typeof(GLNativeDelegate.FNglMinmaxEXT));
            yield return new ProcInfo("glResetHistogramEXT", typeof(GLNativeDelegate.FNglResetHistogramEXT));
            yield return new ProcInfo("glResetMinmaxEXT", typeof(GLNativeDelegate.FNglResetMinmaxEXT));

            #endregion GL_EXT_histogram

            #region GL_EXT_index_func

            yield return new ProcInfo("glIndexFuncEXT", typeof(GLNativeDelegate.FNglIndexFuncEXT));

            #endregion GL_EXT_index_func

            #region GL_EXT_index_material

            yield return new ProcInfo("glIndexMaterialEXT", typeof(GLNativeDelegate.FNglIndexMaterialEXT));

            #endregion GL_EXT_index_material

            #region GL_EXT_light_texture

            yield return new ProcInfo("glApplyTextureEXT", typeof(GLNativeDelegate.FNglApplyTextureEXT));
            yield return new ProcInfo("glTextureLightEXT", typeof(GLNativeDelegate.FNglTextureLightEXT));
            yield return new ProcInfo("glTextureMaterialEXT", typeof(GLNativeDelegate.FNglTextureMaterialEXT));

            #endregion GL_EXT_light_texture

            #region GL_EXT_memory_object

            yield return new ProcInfo("glGetUnsignedBytevEXT", typeof(GLNativeDelegate.FNglGetUnsignedBytevEXT));
            yield return new ProcInfo("glGetUnsignedBytei_vEXT", typeof(GLNativeDelegate.FNglGetUnsignedBytei_vEXT));
            yield return new ProcInfo("glDeleteMemoryObjectsEXT", typeof(GLNativeDelegate.FNglDeleteMemoryObjectsEXT));
            yield return new ProcInfo("glIsMemoryObjectEXT", typeof(GLNativeDelegate.FNglIsMemoryObjectEXT));
            yield return new ProcInfo("glCreateMemoryObjectsEXT", typeof(GLNativeDelegate.FNglCreateMemoryObjectsEXT));
            yield return new ProcInfo("glMemoryObjectParameterivEXT", typeof(GLNativeDelegate.FNglMemoryObjectParameterivEXT));
            yield return new ProcInfo("glGetMemoryObjectParameterivEXT", typeof(GLNativeDelegate.FNglGetMemoryObjectParameterivEXT));
            yield return new ProcInfo("glTexStorageMem2DEXT", typeof(GLNativeDelegate.FNglTexStorageMem2DEXT));
            yield return new ProcInfo("glTexStorageMem2DMultisampleEXT", typeof(GLNativeDelegate.FNglTexStorageMem2DMultisampleEXT));
            yield return new ProcInfo("glTexStorageMem3DEXT", typeof(GLNativeDelegate.FNglTexStorageMem3DEXT));
            yield return new ProcInfo("glTexStorageMem3DMultisampleEXT", typeof(GLNativeDelegate.FNglTexStorageMem3DMultisampleEXT));
            yield return new ProcInfo("glBufferStorageMemEXT", typeof(GLNativeDelegate.FNglBufferStorageMemEXT));
            yield return new ProcInfo("glTextureStorageMem2DEXT", typeof(GLNativeDelegate.FNglTextureStorageMem2DEXT));
            yield return new ProcInfo("glTextureStorageMem2DMultisampleEXT", typeof(GLNativeDelegate.FNglTextureStorageMem2DMultisampleEXT));
            yield return new ProcInfo("glTextureStorageMem3DEXT", typeof(GLNativeDelegate.FNglTextureStorageMem3DEXT));
            yield return new ProcInfo("glTextureStorageMem3DMultisampleEXT", typeof(GLNativeDelegate.FNglTextureStorageMem3DMultisampleEXT));
            yield return new ProcInfo("glNamedBufferStorageMemEXT", typeof(GLNativeDelegate.FNglNamedBufferStorageMemEXT));
            yield return new ProcInfo("glTexStorageMem1DEXT", typeof(GLNativeDelegate.FNglTexStorageMem1DEXT));
            yield return new ProcInfo("glTextureStorageMem1DEXT", typeof(GLNativeDelegate.FNglTextureStorageMem1DEXT));

            #endregion GL_EXT_memory_object

            #region GL_EXT_memory_object_fd

            yield return new ProcInfo("glImportMemoryFdEXT", typeof(GLNativeDelegate.FNglImportMemoryFdEXT));

            #endregion GL_EXT_memory_object_fd

            #region GL_EXT_memory_object_win32

            yield return new ProcInfo("glImportMemoryWin32HandleEXT", typeof(GLNativeDelegate.FNglImportMemoryWin32HandleEXT));
            yield return new ProcInfo("glImportMemoryWin32NameEXT", typeof(GLNativeDelegate.FNglImportMemoryWin32NameEXT));

            #endregion GL_EXT_memory_object_win32

            #region GL_EXT_multi_draw_arrays

            yield return new ProcInfo("glMultiDrawArraysEXT", typeof(GLNativeDelegate.FNglMultiDrawArraysEXT));
            yield return new ProcInfo("glMultiDrawElementsEXT", typeof(GLNativeDelegate.FNglMultiDrawElementsEXT));

            #endregion GL_EXT_multi_draw_arrays

            #region GL_EXT_multisample

            yield return new ProcInfo("glSampleMaskEXT", typeof(GLNativeDelegate.FNglSampleMaskEXT));
            yield return new ProcInfo("glSamplePatternEXT", typeof(GLNativeDelegate.FNglSamplePatternEXT));

            #endregion GL_EXT_multisample

            #region GL_EXT_paletted_texture

            yield return new ProcInfo("glColorTableEXT", typeof(GLNativeDelegate.FNglColorTableEXT));
            yield return new ProcInfo("glGetColorTableEXT", typeof(GLNativeDelegate.FNglGetColorTableEXT));
            yield return new ProcInfo("glGetColorTableParameterivEXT", typeof(GLNativeDelegate.FNglGetColorTableParameterivEXT));
            yield return new ProcInfo("glGetColorTableParameterfvEXT", typeof(GLNativeDelegate.FNglGetColorTableParameterfvEXT));

            #endregion GL_EXT_paletted_texture

            #region GL_EXT_pixel_transform

            yield return new ProcInfo("glPixelTransformParameteriEXT", typeof(GLNativeDelegate.FNglPixelTransformParameteriEXT));
            yield return new ProcInfo("glPixelTransformParameterfEXT", typeof(GLNativeDelegate.FNglPixelTransformParameterfEXT));
            yield return new ProcInfo("glPixelTransformParameterivEXT", typeof(GLNativeDelegate.FNglPixelTransformParameterivEXT));
            yield return new ProcInfo("glPixelTransformParameterfvEXT", typeof(GLNativeDelegate.FNglPixelTransformParameterfvEXT));
            yield return new ProcInfo("glGetPixelTransformParameterivEXT", typeof(GLNativeDelegate.FNglGetPixelTransformParameterivEXT));
            yield return new ProcInfo("glGetPixelTransformParameterfvEXT", typeof(GLNativeDelegate.FNglGetPixelTransformParameterfvEXT));

            #endregion GL_EXT_pixel_transform

            #region GL_EXT_point_parameters

            yield return new ProcInfo("glPointParameterfEXT", typeof(GLNativeDelegate.FNglPointParameterfEXT));
            yield return new ProcInfo("glPointParameterfvEXT", typeof(GLNativeDelegate.FNglPointParameterfvEXT));

            #endregion GL_EXT_point_parameters

            #region GL_EXT_polygon_offset

            yield return new ProcInfo("glPolygonOffsetEXT", typeof(GLNativeDelegate.FNglPolygonOffsetEXT));

            #endregion GL_EXT_polygon_offset

            #region GL_EXT_polygon_offset_clamp

            yield return new ProcInfo("glPolygonOffsetClampEXT", typeof(GLNativeDelegate.FNglPolygonOffsetClampEXT));

            #endregion GL_EXT_polygon_offset_clamp

            #region GL_EXT_provoking_vertex

            yield return new ProcInfo("glProvokingVertexEXT", typeof(GLNativeDelegate.FNglProvokingVertexEXT));

            #endregion GL_EXT_provoking_vertex

            #region GL_EXT_raster_multisample

            yield return new ProcInfo("glRasterSamplesEXT", typeof(GLNativeDelegate.FNglRasterSamplesEXT));

            #endregion GL_EXT_raster_multisample

            #region GL_EXT_semaphore

            // yield return new ProcInfo("glGetUnsignedBytevEXT", typeof(GLNativeDelegate.FNglGetUnsignedBytevEXT));
            // yield return new ProcInfo("glGetUnsignedBytei_vEXT", typeof(GLNativeDelegate.FNglGetUnsignedBytei_vEXT));
            yield return new ProcInfo("glGenSemaphoresEXT", typeof(GLNativeDelegate.FNglGenSemaphoresEXT));
            yield return new ProcInfo("glDeleteSemaphoresEXT", typeof(GLNativeDelegate.FNglDeleteSemaphoresEXT));
            yield return new ProcInfo("glIsSemaphoreEXT", typeof(GLNativeDelegate.FNglIsSemaphoreEXT));
            yield return new ProcInfo("glSemaphoreParameterui64vEXT", typeof(GLNativeDelegate.FNglSemaphoreParameterui64vEXT));
            yield return new ProcInfo("glGetSemaphoreParameterui64vEXT", typeof(GLNativeDelegate.FNglGetSemaphoreParameterui64vEXT));
            yield return new ProcInfo("glWaitSemaphoreEXT", typeof(GLNativeDelegate.FNglWaitSemaphoreEXT));
            yield return new ProcInfo("glSignalSemaphoreEXT", typeof(GLNativeDelegate.FNglSignalSemaphoreEXT));

            #endregion GL_EXT_semaphore

            #region GL_EXT_semaphore_fd

            yield return new ProcInfo("glImportSemaphoreFdEXT", typeof(GLNativeDelegate.FNglImportSemaphoreFdEXT));

            #endregion GL_EXT_semaphore_fd

            #region GL_EXT_semaphore_win32

            yield return new ProcInfo("glImportSemaphoreWin32HandleEXT", typeof(GLNativeDelegate.FNglImportSemaphoreWin32HandleEXT));
            yield return new ProcInfo("glImportSemaphoreWin32NameEXT", typeof(GLNativeDelegate.FNglImportSemaphoreWin32NameEXT));

            #endregion GL_EXT_semaphore_win32

            #region GL_EXT_secondary_color

            yield return new ProcInfo("glSecondaryColor3bEXT", typeof(GLNativeDelegate.FNglSecondaryColor3bEXT));
            yield return new ProcInfo("glSecondaryColor3bvEXT", typeof(GLNativeDelegate.FNglSecondaryColor3bvEXT));
            yield return new ProcInfo("glSecondaryColor3dEXT", typeof(GLNativeDelegate.FNglSecondaryColor3dEXT));
            yield return new ProcInfo("glSecondaryColor3dvEXT", typeof(GLNativeDelegate.FNglSecondaryColor3dvEXT));
            yield return new ProcInfo("glSecondaryColor3fEXT", typeof(GLNativeDelegate.FNglSecondaryColor3fEXT));
            yield return new ProcInfo("glSecondaryColor3fvEXT", typeof(GLNativeDelegate.FNglSecondaryColor3fvEXT));
            yield return new ProcInfo("glSecondaryColor3iEXT", typeof(GLNativeDelegate.FNglSecondaryColor3iEXT));
            yield return new ProcInfo("glSecondaryColor3ivEXT", typeof(GLNativeDelegate.FNglSecondaryColor3ivEXT));
            yield return new ProcInfo("glSecondaryColor3sEXT", typeof(GLNativeDelegate.FNglSecondaryColor3sEXT));
            yield return new ProcInfo("glSecondaryColor3svEXT", typeof(GLNativeDelegate.FNglSecondaryColor3svEXT));
            yield return new ProcInfo("glSecondaryColor3ubEXT", typeof(GLNativeDelegate.FNglSecondaryColor3ubEXT));
            yield return new ProcInfo("glSecondaryColor3ubvEXT", typeof(GLNativeDelegate.FNglSecondaryColor3ubvEXT));
            yield return new ProcInfo("glSecondaryColor3uiEXT", typeof(GLNativeDelegate.FNglSecondaryColor3uiEXT));
            yield return new ProcInfo("glSecondaryColor3uivEXT", typeof(GLNativeDelegate.FNglSecondaryColor3uivEXT));
            yield return new ProcInfo("glSecondaryColor3usEXT", typeof(GLNativeDelegate.FNglSecondaryColor3usEXT));
            yield return new ProcInfo("glSecondaryColor3usvEXT", typeof(GLNativeDelegate.FNglSecondaryColor3usvEXT));
            yield return new ProcInfo("glSecondaryColorPointerEXT", typeof(GLNativeDelegate.FNglSecondaryColorPointerEXT));

            #endregion GL_EXT_secondary_color

            #region GL_EXT_separate_shader_objects

            yield return new ProcInfo("glUseShaderProgramEXT", typeof(GLNativeDelegate.FNglUseShaderProgramEXT));
            yield return new ProcInfo("glActiveProgramEXT", typeof(GLNativeDelegate.FNglActiveProgramEXT));
            yield return new ProcInfo("glCreateShaderProgramEXT", typeof(GLNativeDelegate.FNglCreateShaderProgramEXT));
            yield return new ProcInfo("glActiveShaderProgramEXT", typeof(GLNativeDelegate.FNglActiveShaderProgramEXT));
            yield return new ProcInfo("glBindProgramPipelineEXT", typeof(GLNativeDelegate.FNglBindProgramPipelineEXT));
            yield return new ProcInfo("glCreateShaderProgramvEXT", typeof(GLNativeDelegate.FNglCreateShaderProgramvEXT));
            yield return new ProcInfo("glDeleteProgramPipelinesEXT", typeof(GLNativeDelegate.FNglDeleteProgramPipelinesEXT));
            yield return new ProcInfo("glGenProgramPipelinesEXT", typeof(GLNativeDelegate.FNglGenProgramPipelinesEXT));
            yield return new ProcInfo("glGetProgramPipelineInfoLogEXT", typeof(GLNativeDelegate.FNglGetProgramPipelineInfoLogEXT));
            yield return new ProcInfo("glGetProgramPipelineivEXT", typeof(GLNativeDelegate.FNglGetProgramPipelineivEXT));
            yield return new ProcInfo("glIsProgramPipelineEXT", typeof(GLNativeDelegate.FNglIsProgramPipelineEXT));
            // yield return new ProcInfo("glProgramParameteriEXT", typeof(GLNativeDelegate.FNglProgramParameteriEXT));
            yield return new ProcInfo("glProgramUniform1fEXT", typeof(GLNativeDelegate.FNglProgramUniform1fEXT));
            yield return new ProcInfo("glProgramUniform1fvEXT", typeof(GLNativeDelegate.FNglProgramUniform1fvEXT));
            yield return new ProcInfo("glProgramUniform1iEXT", typeof(GLNativeDelegate.FNglProgramUniform1iEXT));
            yield return new ProcInfo("glProgramUniform1ivEXT", typeof(GLNativeDelegate.FNglProgramUniform1ivEXT));
            yield return new ProcInfo("glProgramUniform2fEXT", typeof(GLNativeDelegate.FNglProgramUniform2fEXT));
            yield return new ProcInfo("glProgramUniform2fvEXT", typeof(GLNativeDelegate.FNglProgramUniform2fvEXT));
            yield return new ProcInfo("glProgramUniform2iEXT", typeof(GLNativeDelegate.FNglProgramUniform2iEXT));
            yield return new ProcInfo("glProgramUniform2ivEXT", typeof(GLNativeDelegate.FNglProgramUniform2ivEXT));
            yield return new ProcInfo("glProgramUniform3fEXT", typeof(GLNativeDelegate.FNglProgramUniform3fEXT));
            yield return new ProcInfo("glProgramUniform3fvEXT", typeof(GLNativeDelegate.FNglProgramUniform3fvEXT));
            yield return new ProcInfo("glProgramUniform3iEXT", typeof(GLNativeDelegate.FNglProgramUniform3iEXT));
            yield return new ProcInfo("glProgramUniform3ivEXT", typeof(GLNativeDelegate.FNglProgramUniform3ivEXT));
            yield return new ProcInfo("glProgramUniform4fEXT", typeof(GLNativeDelegate.FNglProgramUniform4fEXT));
            yield return new ProcInfo("glProgramUniform4fvEXT", typeof(GLNativeDelegate.FNglProgramUniform4fvEXT));
            yield return new ProcInfo("glProgramUniform4iEXT", typeof(GLNativeDelegate.FNglProgramUniform4iEXT));
            yield return new ProcInfo("glProgramUniform4ivEXT", typeof(GLNativeDelegate.FNglProgramUniform4ivEXT));
            yield return new ProcInfo("glProgramUniformMatrix2fvEXT", typeof(GLNativeDelegate.FNglProgramUniformMatrix2fvEXT));
            yield return new ProcInfo("glProgramUniformMatrix3fvEXT", typeof(GLNativeDelegate.FNglProgramUniformMatrix3fvEXT));
            yield return new ProcInfo("glProgramUniformMatrix4fvEXT", typeof(GLNativeDelegate.FNglProgramUniformMatrix4fvEXT));
            yield return new ProcInfo("glUseProgramStagesEXT", typeof(GLNativeDelegate.FNglUseProgramStagesEXT));
            yield return new ProcInfo("glValidateProgramPipelineEXT", typeof(GLNativeDelegate.FNglValidateProgramPipelineEXT));
            yield return new ProcInfo("glProgramUniform1uiEXT", typeof(GLNativeDelegate.FNglProgramUniform1uiEXT));
            yield return new ProcInfo("glProgramUniform2uiEXT", typeof(GLNativeDelegate.FNglProgramUniform2uiEXT));
            yield return new ProcInfo("glProgramUniform3uiEXT", typeof(GLNativeDelegate.FNglProgramUniform3uiEXT));
            yield return new ProcInfo("glProgramUniform4uiEXT", typeof(GLNativeDelegate.FNglProgramUniform4uiEXT));
            yield return new ProcInfo("glProgramUniform1uivEXT", typeof(GLNativeDelegate.FNglProgramUniform1uivEXT));
            yield return new ProcInfo("glProgramUniform2uivEXT", typeof(GLNativeDelegate.FNglProgramUniform2uivEXT));
            yield return new ProcInfo("glProgramUniform3uivEXT", typeof(GLNativeDelegate.FNglProgramUniform3uivEXT));
            yield return new ProcInfo("glProgramUniform4uivEXT", typeof(GLNativeDelegate.FNglProgramUniform4uivEXT));
            yield return new ProcInfo("glProgramUniformMatrix2x3fvEXT", typeof(GLNativeDelegate.FNglProgramUniformMatrix2x3fvEXT));
            yield return new ProcInfo("glProgramUniformMatrix3x2fvEXT", typeof(GLNativeDelegate.FNglProgramUniformMatrix3x2fvEXT));
            yield return new ProcInfo("glProgramUniformMatrix2x4fvEXT", typeof(GLNativeDelegate.FNglProgramUniformMatrix2x4fvEXT));
            yield return new ProcInfo("glProgramUniformMatrix4x2fvEXT", typeof(GLNativeDelegate.FNglProgramUniformMatrix4x2fvEXT));
            yield return new ProcInfo("glProgramUniformMatrix3x4fvEXT", typeof(GLNativeDelegate.FNglProgramUniformMatrix3x4fvEXT));
            yield return new ProcInfo("glProgramUniformMatrix4x3fvEXT", typeof(GLNativeDelegate.FNglProgramUniformMatrix4x3fvEXT));

            #endregion GL_EXT_separate_shader_objects

            #region GL_EXT_shader_framebuffer_fetch_non_coherent

            yield return new ProcInfo("glFramebufferFetchBarrierEXT", typeof(GLNativeDelegate.FNglFramebufferFetchBarrierEXT));

            #endregion GL_EXT_shader_framebuffer_fetch_non_coherent

            #region GL_EXT_shader_image_load_store

            yield return new ProcInfo("glBindImageTextureEXT", typeof(GLNativeDelegate.FNglBindImageTextureEXT));
            yield return new ProcInfo("glMemoryBarrierEXT", typeof(GLNativeDelegate.FNglMemoryBarrierEXT));

            #endregion GL_EXT_shader_image_load_store

            #region GL_EXT_stencil_clear_tag

            yield return new ProcInfo("glStencilClearTagEXT", typeof(GLNativeDelegate.FNglStencilClearTagEXT));

            #endregion GL_EXT_stencil_clear_tag

            #region GL_EXT_stencil_two_side

            yield return new ProcInfo("glActiveStencilFaceEXT", typeof(GLNativeDelegate.FNglActiveStencilFaceEXT));

            #endregion GL_EXT_stencil_two_side

            #region GL_EXT_subtexture

            yield return new ProcInfo("glTexSubImage1DEXT", typeof(GLNativeDelegate.FNglTexSubImage1DEXT));
            yield return new ProcInfo("glTexSubImage2DEXT", typeof(GLNativeDelegate.FNglTexSubImage2DEXT));

            #endregion GL_EXT_subtexture

            #region GL_EXT_texture3D

            yield return new ProcInfo("glTexImage3DEXT", typeof(GLNativeDelegate.FNglTexImage3DEXT));
            yield return new ProcInfo("glTexSubImage3DEXT", typeof(GLNativeDelegate.FNglTexSubImage3DEXT));

            #endregion GL_EXT_texture3D

            #region GL_EXT_texture_array

            yield return new ProcInfo("glFramebufferTextureLayerEXT", typeof(GLNativeDelegate.FNglFramebufferTextureLayerEXT));

            #endregion GL_EXT_texture_array

            #region GL_EXT_texture_buffer_object

            yield return new ProcInfo("glTexBufferEXT", typeof(GLNativeDelegate.FNglTexBufferEXT));

            #endregion GL_EXT_texture_buffer_object

            #region GL_EXT_texture_integer

            yield return new ProcInfo("glTexParameterIivEXT", typeof(GLNativeDelegate.FNglTexParameterIivEXT));
            yield return new ProcInfo("glTexParameterIuivEXT", typeof(GLNativeDelegate.FNglTexParameterIuivEXT));
            yield return new ProcInfo("glGetTexParameterIivEXT", typeof(GLNativeDelegate.FNglGetTexParameterIivEXT));
            yield return new ProcInfo("glGetTexParameterIuivEXT", typeof(GLNativeDelegate.FNglGetTexParameterIuivEXT));
            yield return new ProcInfo("glClearColorIiEXT", typeof(GLNativeDelegate.FNglClearColorIiEXT));
            yield return new ProcInfo("glClearColorIuiEXT", typeof(GLNativeDelegate.FNglClearColorIuiEXT));

            #endregion GL_EXT_texture_integer

            #region GL_EXT_texture_object

            yield return new ProcInfo("glAreTexturesResidentEXT", typeof(GLNativeDelegate.FNglAreTexturesResidentEXT));
            yield return new ProcInfo("glBindTextureEXT", typeof(GLNativeDelegate.FNglBindTextureEXT));
            yield return new ProcInfo("glDeleteTexturesEXT", typeof(GLNativeDelegate.FNglDeleteTexturesEXT));
            yield return new ProcInfo("glGenTexturesEXT", typeof(GLNativeDelegate.FNglGenTexturesEXT));
            yield return new ProcInfo("glIsTextureEXT", typeof(GLNativeDelegate.FNglIsTextureEXT));
            yield return new ProcInfo("glPrioritizeTexturesEXT", typeof(GLNativeDelegate.FNglPrioritizeTexturesEXT));

            #endregion GL_EXT_texture_object

            #region GL_EXT_texture_perturb_normal

            yield return new ProcInfo("glTextureNormalEXT", typeof(GLNativeDelegate.FNglTextureNormalEXT));

            #endregion GL_EXT_texture_perturb_normal

            #region GL_EXT_texture_storage

            yield return new ProcInfo("glTexStorage1DEXT", typeof(GLNativeDelegate.FNglTexStorage1DEXT));
            yield return new ProcInfo("glTexStorage2DEXT", typeof(GLNativeDelegate.FNglTexStorage2DEXT));
            yield return new ProcInfo("glTexStorage3DEXT", typeof(GLNativeDelegate.FNglTexStorage3DEXT));
            yield return new ProcInfo("glTextureStorage1DEXT", typeof(GLNativeDelegate.FNglTextureStorage1DEXT));
            yield return new ProcInfo("glTextureStorage2DEXT", typeof(GLNativeDelegate.FNglTextureStorage2DEXT));
            yield return new ProcInfo("glTextureStorage3DEXT", typeof(GLNativeDelegate.FNglTextureStorage3DEXT));

            #endregion GL_EXT_texture_storage

            #region GL_NV_timeline_semaphore

            yield return new ProcInfo("glCreateSemaphoresNV", typeof(GLNativeDelegate.FNglCreateSemaphoresNV));
            yield return new ProcInfo("glSemaphoreParameterivNV", typeof(GLNativeDelegate.FNglSemaphoreParameterivNV));
            yield return new ProcInfo("glGetSemaphoreParameterivNV", typeof(GLNativeDelegate.FNglGetSemaphoreParameterivNV));

            #endregion GL_NV_timeline_semaphore

            #region GL_EXT_timer_query

            yield return new ProcInfo("glGetQueryObjecti64vEXT", typeof(GLNativeDelegate.FNglGetQueryObjecti64vEXT));
            yield return new ProcInfo("glGetQueryObjectui64vEXT", typeof(GLNativeDelegate.FNglGetQueryObjectui64vEXT));

            #endregion GL_EXT_timer_query

            #region GL_EXT_transform_feedback

            yield return new ProcInfo("glBeginTransformFeedbackEXT", typeof(GLNativeDelegate.FNglBeginTransformFeedbackEXT));
            yield return new ProcInfo("glEndTransformFeedbackEXT", typeof(GLNativeDelegate.FNglEndTransformFeedbackEXT));
            yield return new ProcInfo("glBindBufferRangeEXT", typeof(GLNativeDelegate.FNglBindBufferRangeEXT));
            yield return new ProcInfo("glBindBufferOffsetEXT", typeof(GLNativeDelegate.FNglBindBufferOffsetEXT));
            yield return new ProcInfo("glBindBufferBaseEXT", typeof(GLNativeDelegate.FNglBindBufferBaseEXT));
            yield return new ProcInfo("glTransformFeedbackVaryingsEXT", typeof(GLNativeDelegate.FNglTransformFeedbackVaryingsEXT));
            yield return new ProcInfo("glGetTransformFeedbackVaryingEXT", typeof(GLNativeDelegate.FNglGetTransformFeedbackVaryingEXT));

            #endregion GL_EXT_transform_feedback

            #region GL_EXT_vertex_array

            yield return new ProcInfo("glArrayElementEXT", typeof(GLNativeDelegate.FNglArrayElementEXT));
            yield return new ProcInfo("glColorPointerEXT", typeof(GLNativeDelegate.FNglColorPointerEXT));
            yield return new ProcInfo("glDrawArraysEXT", typeof(GLNativeDelegate.FNglDrawArraysEXT));
            yield return new ProcInfo("glEdgeFlagPointerEXT", typeof(GLNativeDelegate.FNglEdgeFlagPointerEXT));
            yield return new ProcInfo("glGetPointervEXT", typeof(GLNativeDelegate.FNglGetPointervEXT));
            yield return new ProcInfo("glIndexPointerEXT", typeof(GLNativeDelegate.FNglIndexPointerEXT));
            yield return new ProcInfo("glNormalPointerEXT", typeof(GLNativeDelegate.FNglNormalPointerEXT));
            yield return new ProcInfo("glTexCoordPointerEXT", typeof(GLNativeDelegate.FNglTexCoordPointerEXT));
            yield return new ProcInfo("glVertexPointerEXT", typeof(GLNativeDelegate.FNglVertexPointerEXT));

            #endregion GL_EXT_vertex_array

            #region GL_EXT_vertex_attrib_64bit

            yield return new ProcInfo("glVertexAttribL1dEXT", typeof(GLNativeDelegate.FNglVertexAttribL1dEXT));
            yield return new ProcInfo("glVertexAttribL2dEXT", typeof(GLNativeDelegate.FNglVertexAttribL2dEXT));
            yield return new ProcInfo("glVertexAttribL3dEXT", typeof(GLNativeDelegate.FNglVertexAttribL3dEXT));
            yield return new ProcInfo("glVertexAttribL4dEXT", typeof(GLNativeDelegate.FNglVertexAttribL4dEXT));
            yield return new ProcInfo("glVertexAttribL1dvEXT", typeof(GLNativeDelegate.FNglVertexAttribL1dvEXT));
            yield return new ProcInfo("glVertexAttribL2dvEXT", typeof(GLNativeDelegate.FNglVertexAttribL2dvEXT));
            yield return new ProcInfo("glVertexAttribL3dvEXT", typeof(GLNativeDelegate.FNglVertexAttribL3dvEXT));
            yield return new ProcInfo("glVertexAttribL4dvEXT", typeof(GLNativeDelegate.FNglVertexAttribL4dvEXT));
            yield return new ProcInfo("glVertexAttribLPointerEXT", typeof(GLNativeDelegate.FNglVertexAttribLPointerEXT));
            yield return new ProcInfo("glGetVertexAttribLdvEXT", typeof(GLNativeDelegate.FNglGetVertexAttribLdvEXT));

            #endregion GL_EXT_vertex_attrib_64bit

            #region GL_EXT_vertex_shader

            yield return new ProcInfo("glBeginVertexShaderEXT", typeof(GLNativeDelegate.FNglBeginVertexShaderEXT));
            yield return new ProcInfo("glEndVertexShaderEXT", typeof(GLNativeDelegate.FNglEndVertexShaderEXT));
            yield return new ProcInfo("glBindVertexShaderEXT", typeof(GLNativeDelegate.FNglBindVertexShaderEXT));
            yield return new ProcInfo("glGenVertexShadersEXT", typeof(GLNativeDelegate.FNglGenVertexShadersEXT));
            yield return new ProcInfo("glDeleteVertexShaderEXT", typeof(GLNativeDelegate.FNglDeleteVertexShaderEXT));
            yield return new ProcInfo("glShaderOp1EXT", typeof(GLNativeDelegate.FNglShaderOp1EXT));
            yield return new ProcInfo("glShaderOp2EXT", typeof(GLNativeDelegate.FNglShaderOp2EXT));
            yield return new ProcInfo("glShaderOp3EXT", typeof(GLNativeDelegate.FNglShaderOp3EXT));
            yield return new ProcInfo("glSwizzleEXT", typeof(GLNativeDelegate.FNglSwizzleEXT));
            yield return new ProcInfo("glWriteMaskEXT", typeof(GLNativeDelegate.FNglWriteMaskEXT));
            yield return new ProcInfo("glInsertComponentEXT", typeof(GLNativeDelegate.FNglInsertComponentEXT));
            yield return new ProcInfo("glExtractComponentEXT", typeof(GLNativeDelegate.FNglExtractComponentEXT));
            yield return new ProcInfo("glGenSymbolsEXT", typeof(GLNativeDelegate.FNglGenSymbolsEXT));
            yield return new ProcInfo("glSetInvariantEXT", typeof(GLNativeDelegate.FNglSetInvariantEXT));
            yield return new ProcInfo("glSetLocalConstantEXT", typeof(GLNativeDelegate.FNglSetLocalConstantEXT));
            yield return new ProcInfo("glVariantbvEXT", typeof(GLNativeDelegate.FNglVariantbvEXT));
            yield return new ProcInfo("glVariantsvEXT", typeof(GLNativeDelegate.FNglVariantsvEXT));
            yield return new ProcInfo("glVariantivEXT", typeof(GLNativeDelegate.FNglVariantivEXT));
            yield return new ProcInfo("glVariantfvEXT", typeof(GLNativeDelegate.FNglVariantfvEXT));
            yield return new ProcInfo("glVariantdvEXT", typeof(GLNativeDelegate.FNglVariantdvEXT));
            yield return new ProcInfo("glVariantubvEXT", typeof(GLNativeDelegate.FNglVariantubvEXT));
            yield return new ProcInfo("glVariantusvEXT", typeof(GLNativeDelegate.FNglVariantusvEXT));
            yield return new ProcInfo("glVariantuivEXT", typeof(GLNativeDelegate.FNglVariantuivEXT));
            yield return new ProcInfo("glVariantPointerEXT", typeof(GLNativeDelegate.FNglVariantPointerEXT));
            yield return new ProcInfo("glEnableVariantClientStateEXT", typeof(GLNativeDelegate.FNglEnableVariantClientStateEXT));
            yield return new ProcInfo("glDisableVariantClientStateEXT", typeof(GLNativeDelegate.FNglDisableVariantClientStateEXT));
            yield return new ProcInfo("glBindLightParameterEXT", typeof(GLNativeDelegate.FNglBindLightParameterEXT));
            yield return new ProcInfo("glBindMaterialParameterEXT", typeof(GLNativeDelegate.FNglBindMaterialParameterEXT));
            yield return new ProcInfo("glBindTexGenParameterEXT", typeof(GLNativeDelegate.FNglBindTexGenParameterEXT));
            yield return new ProcInfo("glBindTextureUnitParameterEXT", typeof(GLNativeDelegate.FNglBindTextureUnitParameterEXT));
            yield return new ProcInfo("glBindParameterEXT", typeof(GLNativeDelegate.FNglBindParameterEXT));
            yield return new ProcInfo("glIsVariantEnabledEXT", typeof(GLNativeDelegate.FNglIsVariantEnabledEXT));
            yield return new ProcInfo("glGetVariantBooleanvEXT", typeof(GLNativeDelegate.FNglGetVariantBooleanvEXT));
            yield return new ProcInfo("glGetVariantIntegervEXT", typeof(GLNativeDelegate.FNglGetVariantIntegervEXT));
            yield return new ProcInfo("glGetVariantFloatvEXT", typeof(GLNativeDelegate.FNglGetVariantFloatvEXT));
            yield return new ProcInfo("glGetVariantPointervEXT", typeof(GLNativeDelegate.FNglGetVariantPointervEXT));
            yield return new ProcInfo("glGetInvariantBooleanvEXT", typeof(GLNativeDelegate.FNglGetInvariantBooleanvEXT));
            yield return new ProcInfo("glGetInvariantIntegervEXT", typeof(GLNativeDelegate.FNglGetInvariantIntegervEXT));
            yield return new ProcInfo("glGetInvariantFloatvEXT", typeof(GLNativeDelegate.FNglGetInvariantFloatvEXT));
            yield return new ProcInfo("glGetLocalConstantBooleanvEXT", typeof(GLNativeDelegate.FNglGetLocalConstantBooleanvEXT));
            yield return new ProcInfo("glGetLocalConstantIntegervEXT", typeof(GLNativeDelegate.FNglGetLocalConstantIntegervEXT));
            yield return new ProcInfo("glGetLocalConstantFloatvEXT", typeof(GLNativeDelegate.FNglGetLocalConstantFloatvEXT));

            #endregion GL_EXT_vertex_shader

            #region GL_EXT_vertex_weighting

            yield return new ProcInfo("glVertexWeightfEXT", typeof(GLNativeDelegate.FNglVertexWeightfEXT));
            yield return new ProcInfo("glVertexWeightfvEXT", typeof(GLNativeDelegate.FNglVertexWeightfvEXT));
            yield return new ProcInfo("glVertexWeightPointerEXT", typeof(GLNativeDelegate.FNglVertexWeightPointerEXT));

            #endregion GL_EXT_vertex_weighting

            #region GL_EXT_win32_keyed_mutex

            yield return new ProcInfo("glAcquireKeyedMutexWin32EXT", typeof(GLNativeDelegate.FNglAcquireKeyedMutexWin32EXT));
            yield return new ProcInfo("glReleaseKeyedMutexWin32EXT", typeof(GLNativeDelegate.FNglReleaseKeyedMutexWin32EXT));

            #endregion GL_EXT_win32_keyed_mutex

            #region GL_EXT_window_rectangles

            yield return new ProcInfo("glWindowRectanglesEXT", typeof(GLNativeDelegate.FNglWindowRectanglesEXT));

            #endregion GL_EXT_window_rectangles

            #region GL_EXT_x11_sync_object

            yield return new ProcInfo("glImportSyncEXT", typeof(GLNativeDelegate.FNglImportSyncEXT));

            #endregion GL_EXT_x11_sync_object

            #region GL_GREMEDY_frame_terminator

            yield return new ProcInfo("glFrameTerminatorGREMEDY", typeof(GLNativeDelegate.FNglFrameTerminatorGREMEDY));

            #endregion GL_GREMEDY_frame_terminator

            #region GL_GREMEDY_string_marker

            yield return new ProcInfo("glStringMarkerGREMEDY", typeof(GLNativeDelegate.FNglStringMarkerGREMEDY));

            #endregion GL_GREMEDY_string_marker

            #region GL_HP_image_transform

            yield return new ProcInfo("glImageTransformParameteriHP", typeof(GLNativeDelegate.FNglImageTransformParameteriHP));
            yield return new ProcInfo("glImageTransformParameterfHP", typeof(GLNativeDelegate.FNglImageTransformParameterfHP));
            yield return new ProcInfo("glImageTransformParameterivHP", typeof(GLNativeDelegate.FNglImageTransformParameterivHP));
            yield return new ProcInfo("glImageTransformParameterfvHP", typeof(GLNativeDelegate.FNglImageTransformParameterfvHP));
            yield return new ProcInfo("glGetImageTransformParameterivHP", typeof(GLNativeDelegate.FNglGetImageTransformParameterivHP));
            yield return new ProcInfo("glGetImageTransformParameterfvHP", typeof(GLNativeDelegate.FNglGetImageTransformParameterfvHP));

            #endregion GL_HP_image_transform

            #region GL_IBM_multimode_draw_arrays

            yield return new ProcInfo("glMultiModeDrawArraysIBM", typeof(GLNativeDelegate.FNglMultiModeDrawArraysIBM));
            yield return new ProcInfo("glMultiModeDrawElementsIBM", typeof(GLNativeDelegate.FNglMultiModeDrawElementsIBM));

            #endregion GL_IBM_multimode_draw_arrays

            #region GL_IBM_static_data

            yield return new ProcInfo("glFlushStaticDataIBM", typeof(GLNativeDelegate.FNglFlushStaticDataIBM));

            #endregion GL_IBM_static_data

            #region GL_IBM_vertex_array_lists

            yield return new ProcInfo("glColorPointerListIBM", typeof(GLNativeDelegate.FNglColorPointerListIBM));
            yield return new ProcInfo("glSecondaryColorPointerListIBM", typeof(GLNativeDelegate.FNglSecondaryColorPointerListIBM));
            yield return new ProcInfo("glEdgeFlagPointerListIBM", typeof(GLNativeDelegate.FNglEdgeFlagPointerListIBM));
            yield return new ProcInfo("glFogCoordPointerListIBM", typeof(GLNativeDelegate.FNglFogCoordPointerListIBM));
            yield return new ProcInfo("glIndexPointerListIBM", typeof(GLNativeDelegate.FNglIndexPointerListIBM));
            yield return new ProcInfo("glNormalPointerListIBM", typeof(GLNativeDelegate.FNglNormalPointerListIBM));
            yield return new ProcInfo("glTexCoordPointerListIBM", typeof(GLNativeDelegate.FNglTexCoordPointerListIBM));
            yield return new ProcInfo("glVertexPointerListIBM", typeof(GLNativeDelegate.FNglVertexPointerListIBM));

            #endregion GL_IBM_vertex_array_lists

            #region GL_INGR_blend_func_separate

            yield return new ProcInfo("glBlendFuncSeparateINGR", typeof(GLNativeDelegate.FNglBlendFuncSeparateINGR));

            #endregion GL_INGR_blend_func_separate

            #region GL_INTEL_framebuffer_CMAA

            yield return new ProcInfo("glApplyFramebufferAttachmentCMAAINTEL", typeof(GLNativeDelegate.FNglApplyFramebufferAttachmentCMAAINTEL));

            #endregion GL_INTEL_framebuffer_CMAA

            #region GL_INTEL_map_texture

            yield return new ProcInfo("glSyncTextureINTEL", typeof(GLNativeDelegate.FNglSyncTextureINTEL));
            yield return new ProcInfo("glUnmapTexture2DINTEL", typeof(GLNativeDelegate.FNglUnmapTexture2DINTEL));
            yield return new ProcInfo("glMapTexture2DINTEL", typeof(GLNativeDelegate.FNglMapTexture2DINTEL));

            #endregion GL_INTEL_map_texture

            #region GL_INTEL_parallel_arrays

            yield return new ProcInfo("glVertexPointervINTEL", typeof(GLNativeDelegate.FNglVertexPointervINTEL));
            yield return new ProcInfo("glNormalPointervINTEL", typeof(GLNativeDelegate.FNglNormalPointervINTEL));
            yield return new ProcInfo("glColorPointervINTEL", typeof(GLNativeDelegate.FNglColorPointervINTEL));
            yield return new ProcInfo("glTexCoordPointervINTEL", typeof(GLNativeDelegate.FNglTexCoordPointervINTEL));

            #endregion GL_INTEL_parallel_arrays

            #region GL_INTEL_performance_query

            yield return new ProcInfo("glBeginPerfQueryINTEL", typeof(GLNativeDelegate.FNglBeginPerfQueryINTEL));
            yield return new ProcInfo("glCreatePerfQueryINTEL", typeof(GLNativeDelegate.FNglCreatePerfQueryINTEL));
            yield return new ProcInfo("glDeletePerfQueryINTEL", typeof(GLNativeDelegate.FNglDeletePerfQueryINTEL));
            yield return new ProcInfo("glEndPerfQueryINTEL", typeof(GLNativeDelegate.FNglEndPerfQueryINTEL));
            yield return new ProcInfo("glGetFirstPerfQueryIdINTEL", typeof(GLNativeDelegate.FNglGetFirstPerfQueryIdINTEL));
            yield return new ProcInfo("glGetNextPerfQueryIdINTEL", typeof(GLNativeDelegate.FNglGetNextPerfQueryIdINTEL));
            yield return new ProcInfo("glGetPerfCounterInfoINTEL", typeof(GLNativeDelegate.FNglGetPerfCounterInfoINTEL));
            yield return new ProcInfo("glGetPerfQueryDataINTEL", typeof(GLNativeDelegate.FNglGetPerfQueryDataINTEL));
            yield return new ProcInfo("glGetPerfQueryIdByNameINTEL", typeof(GLNativeDelegate.FNglGetPerfQueryIdByNameINTEL));
            yield return new ProcInfo("glGetPerfQueryInfoINTEL", typeof(GLNativeDelegate.FNglGetPerfQueryInfoINTEL));

            #endregion GL_INTEL_performance_query

            #region GL_KHR_blend_equation_advanced

            yield return new ProcInfo("glBlendBarrierKHR", typeof(GLNativeDelegate.FNglBlendBarrierKHR));

            #endregion GL_KHR_blend_equation_advanced

            #region GL_KHR_debug

            // yield return new ProcInfo("glDebugMessageControl", typeof(GLNativeDelegate.FNglDebugMessageControl));
            // yield return new ProcInfo("glDebugMessageInsert", typeof(GLNativeDelegate.FNglDebugMessageInsert));
            // yield return new ProcInfo("glDebugMessageCallback", typeof(GLNativeDelegate.FNglDebugMessageCallback));
            // yield return new ProcInfo("glGetDebugMessageLog", typeof(GLNativeDelegate.FNglGetDebugMessageLog));
            // yield return new ProcInfo("glPushDebugGroup", typeof(GLNativeDelegate.FNglPushDebugGroup));
            // yield return new ProcInfo("glPopDebugGroup", typeof(GLNativeDelegate.FNglPopDebugGroup));
            // yield return new ProcInfo("glObjectLabel", typeof(GLNativeDelegate.FNglObjectLabel));
            // yield return new ProcInfo("glGetObjectLabel", typeof(GLNativeDelegate.FNglGetObjectLabel));
            // yield return new ProcInfo("glObjectPtrLabel", typeof(GLNativeDelegate.FNglObjectPtrLabel));
            // yield return new ProcInfo("glGetObjectPtrLabel", typeof(GLNativeDelegate.FNglGetObjectPtrLabel));
            // yield return new ProcInfo("glGetPointerv", typeof(GLNativeDelegate.FNglGetPointerv));
            yield return new ProcInfo("glDebugMessageControlKHR", typeof(GLNativeDelegate.FNglDebugMessageControlKHR));
            yield return new ProcInfo("glDebugMessageInsertKHR", typeof(GLNativeDelegate.FNglDebugMessageInsertKHR));
            yield return new ProcInfo("glDebugMessageCallbackKHR", typeof(GLNativeDelegate.FNglDebugMessageCallbackKHR));
            yield return new ProcInfo("glGetDebugMessageLogKHR", typeof(GLNativeDelegate.FNglGetDebugMessageLogKHR));
            yield return new ProcInfo("glPushDebugGroupKHR", typeof(GLNativeDelegate.FNglPushDebugGroupKHR));
            yield return new ProcInfo("glPopDebugGroupKHR", typeof(GLNativeDelegate.FNglPopDebugGroupKHR));
            yield return new ProcInfo("glObjectLabelKHR", typeof(GLNativeDelegate.FNglObjectLabelKHR));
            yield return new ProcInfo("glGetObjectLabelKHR", typeof(GLNativeDelegate.FNglGetObjectLabelKHR));
            yield return new ProcInfo("glObjectPtrLabelKHR", typeof(GLNativeDelegate.FNglObjectPtrLabelKHR));
            yield return new ProcInfo("glGetObjectPtrLabelKHR", typeof(GLNativeDelegate.FNglGetObjectPtrLabelKHR));
            yield return new ProcInfo("glGetPointervKHR", typeof(GLNativeDelegate.FNglGetPointervKHR));

            #endregion GL_KHR_debug

            #region GL_KHR_robustness

            // yield return new ProcInfo("glGetGraphicsResetStatus", typeof(GLNativeDelegate.FNglGetGraphicsResetStatus));
            // yield return new ProcInfo("glReadnPixels", typeof(GLNativeDelegate.FNglReadnPixels));
            // yield return new ProcInfo("glGetnUniformfv", typeof(GLNativeDelegate.FNglGetnUniformfv));
            // yield return new ProcInfo("glGetnUniformiv", typeof(GLNativeDelegate.FNglGetnUniformiv));
            // yield return new ProcInfo("glGetnUniformuiv", typeof(GLNativeDelegate.FNglGetnUniformuiv));
            yield return new ProcInfo("glGetGraphicsResetStatusKHR", typeof(GLNativeDelegate.FNglGetGraphicsResetStatusKHR));
            yield return new ProcInfo("glReadnPixelsKHR", typeof(GLNativeDelegate.FNglReadnPixelsKHR));
            yield return new ProcInfo("glGetnUniformfvKHR", typeof(GLNativeDelegate.FNglGetnUniformfvKHR));
            yield return new ProcInfo("glGetnUniformivKHR", typeof(GLNativeDelegate.FNglGetnUniformivKHR));
            yield return new ProcInfo("glGetnUniformuivKHR", typeof(GLNativeDelegate.FNglGetnUniformuivKHR));

            #endregion GL_KHR_robustness

            #region GL_KHR_parallel_shader_compile

            yield return new ProcInfo("glMaxShaderCompilerThreadsKHR", typeof(GLNativeDelegate.FNglMaxShaderCompilerThreadsKHR));

            #endregion GL_KHR_parallel_shader_compile

            #region GL_MESA_framebuffer_flip_y

            yield return new ProcInfo("glFramebufferParameteriMESA", typeof(GLNativeDelegate.FNglFramebufferParameteriMESA));
            yield return new ProcInfo("glGetFramebufferParameterivMESA", typeof(GLNativeDelegate.FNglGetFramebufferParameterivMESA));

            #endregion GL_MESA_framebuffer_flip_y

            #region GL_MESA_resize_buffers

            yield return new ProcInfo("glResizeBuffersMESA", typeof(GLNativeDelegate.FNglResizeBuffersMESA));

            #endregion GL_MESA_resize_buffers

            #region GL_MESA_window_pos

            yield return new ProcInfo("glWindowPos2dMESA", typeof(GLNativeDelegate.FNglWindowPos2dMESA));
            yield return new ProcInfo("glWindowPos2dvMESA", typeof(GLNativeDelegate.FNglWindowPos2dvMESA));
            yield return new ProcInfo("glWindowPos2fMESA", typeof(GLNativeDelegate.FNglWindowPos2fMESA));
            yield return new ProcInfo("glWindowPos2fvMESA", typeof(GLNativeDelegate.FNglWindowPos2fvMESA));
            yield return new ProcInfo("glWindowPos2iMESA", typeof(GLNativeDelegate.FNglWindowPos2iMESA));
            yield return new ProcInfo("glWindowPos2ivMESA", typeof(GLNativeDelegate.FNglWindowPos2ivMESA));
            yield return new ProcInfo("glWindowPos2sMESA", typeof(GLNativeDelegate.FNglWindowPos2sMESA));
            yield return new ProcInfo("glWindowPos2svMESA", typeof(GLNativeDelegate.FNglWindowPos2svMESA));
            yield return new ProcInfo("glWindowPos3dMESA", typeof(GLNativeDelegate.FNglWindowPos3dMESA));
            yield return new ProcInfo("glWindowPos3dvMESA", typeof(GLNativeDelegate.FNglWindowPos3dvMESA));
            yield return new ProcInfo("glWindowPos3fMESA", typeof(GLNativeDelegate.FNglWindowPos3fMESA));
            yield return new ProcInfo("glWindowPos3fvMESA", typeof(GLNativeDelegate.FNglWindowPos3fvMESA));
            yield return new ProcInfo("glWindowPos3iMESA", typeof(GLNativeDelegate.FNglWindowPos3iMESA));
            yield return new ProcInfo("glWindowPos3ivMESA", typeof(GLNativeDelegate.FNglWindowPos3ivMESA));
            yield return new ProcInfo("glWindowPos3sMESA", typeof(GLNativeDelegate.FNglWindowPos3sMESA));
            yield return new ProcInfo("glWindowPos3svMESA", typeof(GLNativeDelegate.FNglWindowPos3svMESA));
            yield return new ProcInfo("glWindowPos4dMESA", typeof(GLNativeDelegate.FNglWindowPos4dMESA));
            yield return new ProcInfo("glWindowPos4dvMESA", typeof(GLNativeDelegate.FNglWindowPos4dvMESA));
            yield return new ProcInfo("glWindowPos4fMESA", typeof(GLNativeDelegate.FNglWindowPos4fMESA));
            yield return new ProcInfo("glWindowPos4fvMESA", typeof(GLNativeDelegate.FNglWindowPos4fvMESA));
            yield return new ProcInfo("glWindowPos4iMESA", typeof(GLNativeDelegate.FNglWindowPos4iMESA));
            yield return new ProcInfo("glWindowPos4ivMESA", typeof(GLNativeDelegate.FNglWindowPos4ivMESA));
            yield return new ProcInfo("glWindowPos4sMESA", typeof(GLNativeDelegate.FNglWindowPos4sMESA));
            yield return new ProcInfo("glWindowPos4svMESA", typeof(GLNativeDelegate.FNglWindowPos4svMESA));

            #endregion GL_MESA_window_pos

            #region GL_NVX_conditional_render

            yield return new ProcInfo("glBeginConditionalRenderNVX", typeof(GLNativeDelegate.FNglBeginConditionalRenderNVX));
            yield return new ProcInfo("glEndConditionalRenderNVX", typeof(GLNativeDelegate.FNglEndConditionalRenderNVX));

            #endregion GL_NVX_conditional_render

            #region GL_NVX_linked_gpu_multicast

            yield return new ProcInfo("glLGPUNamedBufferSubDataNVX", typeof(GLNativeDelegate.FNglLGPUNamedBufferSubDataNVX));
            yield return new ProcInfo("glLGPUCopyImageSubDataNVX", typeof(GLNativeDelegate.FNglLGPUCopyImageSubDataNVX));
            yield return new ProcInfo("glLGPUInterlockNVX", typeof(GLNativeDelegate.FNglLGPUInterlockNVX));

            #endregion GL_NVX_linked_gpu_multicast

            #region GL_NV_alpha_to_coverage_dither_control

            yield return new ProcInfo("glAlphaToCoverageDitherControlNV", typeof(GLNativeDelegate.FNglAlphaToCoverageDitherControlNV));

            #endregion GL_NV_alpha_to_coverage_dither_control

            #region GL_NV_bindless_multi_draw_indirect

            yield return new ProcInfo("glMultiDrawArraysIndirectBindlessNV", typeof(GLNativeDelegate.FNglMultiDrawArraysIndirectBindlessNV));
            yield return new ProcInfo("glMultiDrawElementsIndirectBindlessNV", typeof(GLNativeDelegate.FNglMultiDrawElementsIndirectBindlessNV));

            #endregion GL_NV_bindless_multi_draw_indirect

            #region GL_NV_bindless_multi_draw_indirect_count

            yield return new ProcInfo("glMultiDrawArraysIndirectBindlessCountNV", typeof(GLNativeDelegate.FNglMultiDrawArraysIndirectBindlessCountNV));
            yield return new ProcInfo("glMultiDrawElementsIndirectBindlessCountNV", typeof(GLNativeDelegate.FNglMultiDrawElementsIndirectBindlessCountNV));

            #endregion GL_NV_bindless_multi_draw_indirect_count

            #region GL_NV_bindless_texture

            yield return new ProcInfo("glGetTextureHandleNV", typeof(GLNativeDelegate.FNglGetTextureHandleNV));
            yield return new ProcInfo("glGetTextureSamplerHandleNV", typeof(GLNativeDelegate.FNglGetTextureSamplerHandleNV));
            yield return new ProcInfo("glMakeTextureHandleResidentNV", typeof(GLNativeDelegate.FNglMakeTextureHandleResidentNV));
            yield return new ProcInfo("glMakeTextureHandleNonResidentNV", typeof(GLNativeDelegate.FNglMakeTextureHandleNonResidentNV));
            yield return new ProcInfo("glGetImageHandleNV", typeof(GLNativeDelegate.FNglGetImageHandleNV));
            yield return new ProcInfo("glMakeImageHandleResidentNV", typeof(GLNativeDelegate.FNglMakeImageHandleResidentNV));
            yield return new ProcInfo("glMakeImageHandleNonResidentNV", typeof(GLNativeDelegate.FNglMakeImageHandleNonResidentNV));
            yield return new ProcInfo("glUniformHandleui64NV", typeof(GLNativeDelegate.FNglUniformHandleui64NV));
            yield return new ProcInfo("glUniformHandleui64vNV", typeof(GLNativeDelegate.FNglUniformHandleui64vNV));
            yield return new ProcInfo("glProgramUniformHandleui64NV", typeof(GLNativeDelegate.FNglProgramUniformHandleui64NV));
            yield return new ProcInfo("glProgramUniformHandleui64vNV", typeof(GLNativeDelegate.FNglProgramUniformHandleui64vNV));
            yield return new ProcInfo("glIsTextureHandleResidentNV", typeof(GLNativeDelegate.FNglIsTextureHandleResidentNV));
            yield return new ProcInfo("glIsImageHandleResidentNV", typeof(GLNativeDelegate.FNglIsImageHandleResidentNV));

            #endregion GL_NV_bindless_texture

            #region GL_NV_blend_equation_advanced

            yield return new ProcInfo("glBlendParameteriNV", typeof(GLNativeDelegate.FNglBlendParameteriNV));
            yield return new ProcInfo("glBlendBarrierNV", typeof(GLNativeDelegate.FNglBlendBarrierNV));

            #endregion GL_NV_blend_equation_advanced

            #region GL_NV_clip_space_w_scaling

            yield return new ProcInfo("glViewportPositionWScaleNV", typeof(GLNativeDelegate.FNglViewportPositionWScaleNV));

            #endregion GL_NV_clip_space_w_scaling

            #region GL_NV_command_list

            yield return new ProcInfo("glCreateStatesNV", typeof(GLNativeDelegate.FNglCreateStatesNV));
            yield return new ProcInfo("glDeleteStatesNV", typeof(GLNativeDelegate.FNglDeleteStatesNV));
            yield return new ProcInfo("glIsStateNV", typeof(GLNativeDelegate.FNglIsStateNV));
            yield return new ProcInfo("glStateCaptureNV", typeof(GLNativeDelegate.FNglStateCaptureNV));
            yield return new ProcInfo("glGetCommandHeaderNV", typeof(GLNativeDelegate.FNglGetCommandHeaderNV));
            yield return new ProcInfo("glGetStageIndexNV", typeof(GLNativeDelegate.FNglGetStageIndexNV));
            yield return new ProcInfo("glDrawCommandsNV", typeof(GLNativeDelegate.FNglDrawCommandsNV));
            yield return new ProcInfo("glDrawCommandsAddressNV", typeof(GLNativeDelegate.FNglDrawCommandsAddressNV));
            yield return new ProcInfo("glDrawCommandsStatesNV", typeof(GLNativeDelegate.FNglDrawCommandsStatesNV));
            yield return new ProcInfo("glDrawCommandsStatesAddressNV", typeof(GLNativeDelegate.FNglDrawCommandsStatesAddressNV));
            yield return new ProcInfo("glCreateCommandListsNV", typeof(GLNativeDelegate.FNglCreateCommandListsNV));
            yield return new ProcInfo("glDeleteCommandListsNV", typeof(GLNativeDelegate.FNglDeleteCommandListsNV));
            yield return new ProcInfo("glIsCommandListNV", typeof(GLNativeDelegate.FNglIsCommandListNV));
            yield return new ProcInfo("glListDrawCommandsStatesClientNV", typeof(GLNativeDelegate.FNglListDrawCommandsStatesClientNV));
            yield return new ProcInfo("glCommandListSegmentsNV", typeof(GLNativeDelegate.FNglCommandListSegmentsNV));
            yield return new ProcInfo("glCompileCommandListNV", typeof(GLNativeDelegate.FNglCompileCommandListNV));
            yield return new ProcInfo("glCallCommandListNV", typeof(GLNativeDelegate.FNglCallCommandListNV));

            #endregion GL_NV_command_list

            #region GL_NV_conditional_render

            yield return new ProcInfo("glBeginConditionalRenderNV", typeof(GLNativeDelegate.FNglBeginConditionalRenderNV));
            yield return new ProcInfo("glEndConditionalRenderNV", typeof(GLNativeDelegate.FNglEndConditionalRenderNV));

            #endregion GL_NV_conditional_render

            #region GL_NV_conservative_raster

            yield return new ProcInfo("glSubpixelPrecisionBiasNV", typeof(GLNativeDelegate.FNglSubpixelPrecisionBiasNV));

            #endregion GL_NV_conservative_raster

            #region GL_NV_conservative_raster_dilate

            yield return new ProcInfo("glConservativeRasterParameterfNV", typeof(GLNativeDelegate.FNglConservativeRasterParameterfNV));

            #endregion GL_NV_conservative_raster_dilate

            #region GL_NV_conservative_raster_pre_snap_triangles

            yield return new ProcInfo("glConservativeRasterParameteriNV", typeof(GLNativeDelegate.FNglConservativeRasterParameteriNV));

            #endregion GL_NV_conservative_raster_pre_snap_triangles

            #region GL_NV_copy_image

            yield return new ProcInfo("glCopyImageSubDataNV", typeof(GLNativeDelegate.FNglCopyImageSubDataNV));

            #endregion GL_NV_copy_image

            #region GL_NV_depth_buffer_float

            yield return new ProcInfo("glDepthRangedNV", typeof(GLNativeDelegate.FNglDepthRangedNV));
            yield return new ProcInfo("glClearDepthdNV", typeof(GLNativeDelegate.FNglClearDepthdNV));
            yield return new ProcInfo("glDepthBoundsdNV", typeof(GLNativeDelegate.FNglDepthBoundsdNV));

            #endregion GL_NV_depth_buffer_float

            #region GL_NV_draw_texture

            yield return new ProcInfo("glDrawTextureNV", typeof(GLNativeDelegate.FNglDrawTextureNV));

            #endregion GL_NV_draw_texture

            #region GL_NV_draw_vulkan_image

            yield return new ProcInfo("glDrawVkImageNV", typeof(GLNativeDelegate.FNglDrawVkImageNV));
            yield return new ProcInfo("glGetVkProcAddrNV", typeof(GLNativeDelegate.FNglGetVkProcAddrNV));
            yield return new ProcInfo("glWaitVkSemaphoreNV", typeof(GLNativeDelegate.FNglWaitVkSemaphoreNV));
            yield return new ProcInfo("glSignalVkSemaphoreNV", typeof(GLNativeDelegate.FNglSignalVkSemaphoreNV));
            yield return new ProcInfo("glSignalVkFenceNV", typeof(GLNativeDelegate.FNglSignalVkFenceNV));

            #endregion GL_NV_draw_vulkan_image

            #region GL_NV_evaluators

            yield return new ProcInfo("glMapControlPointsNV", typeof(GLNativeDelegate.FNglMapControlPointsNV));
            yield return new ProcInfo("glMapParameterivNV", typeof(GLNativeDelegate.FNglMapParameterivNV));
            yield return new ProcInfo("glMapParameterfvNV", typeof(GLNativeDelegate.FNglMapParameterfvNV));
            yield return new ProcInfo("glGetMapControlPointsNV", typeof(GLNativeDelegate.FNglGetMapControlPointsNV));
            yield return new ProcInfo("glGetMapParameterivNV", typeof(GLNativeDelegate.FNglGetMapParameterivNV));
            yield return new ProcInfo("glGetMapParameterfvNV", typeof(GLNativeDelegate.FNglGetMapParameterfvNV));
            yield return new ProcInfo("glGetMapAttribParameterivNV", typeof(GLNativeDelegate.FNglGetMapAttribParameterivNV));
            yield return new ProcInfo("glGetMapAttribParameterfvNV", typeof(GLNativeDelegate.FNglGetMapAttribParameterfvNV));
            yield return new ProcInfo("glEvalMapsNV", typeof(GLNativeDelegate.FNglEvalMapsNV));

            #endregion GL_NV_evaluators

            #region GL_NV_explicit_multisample

            yield return new ProcInfo("glGetMultisamplefvNV", typeof(GLNativeDelegate.FNglGetMultisamplefvNV));
            yield return new ProcInfo("glSampleMaskIndexedNV", typeof(GLNativeDelegate.FNglSampleMaskIndexedNV));
            yield return new ProcInfo("glTexRenderbufferNV", typeof(GLNativeDelegate.FNglTexRenderbufferNV));

            #endregion GL_NV_explicit_multisample

            #region GL_NV_fence

            yield return new ProcInfo("glDeleteFencesNV", typeof(GLNativeDelegate.FNglDeleteFencesNV));
            yield return new ProcInfo("glGenFencesNV", typeof(GLNativeDelegate.FNglGenFencesNV));
            yield return new ProcInfo("glIsFenceNV", typeof(GLNativeDelegate.FNglIsFenceNV));
            yield return new ProcInfo("glTestFenceNV", typeof(GLNativeDelegate.FNglTestFenceNV));
            yield return new ProcInfo("glGetFenceivNV", typeof(GLNativeDelegate.FNglGetFenceivNV));
            yield return new ProcInfo("glFinishFenceNV", typeof(GLNativeDelegate.FNglFinishFenceNV));
            yield return new ProcInfo("glSetFenceNV", typeof(GLNativeDelegate.FNglSetFenceNV));

            #endregion GL_NV_fence

            #region GL_NV_fragment_coverage_to_color

            yield return new ProcInfo("glFragmentCoverageColorNV", typeof(GLNativeDelegate.FNglFragmentCoverageColorNV));

            #endregion GL_NV_fragment_coverage_to_color

            #region GL_NV_framebuffer_mixed_samples

            // yield return new ProcInfo("glRasterSamplesEXT", typeof(GLNativeDelegate.FNglRasterSamplesEXT));
            yield return new ProcInfo("glCoverageModulationTableNV", typeof(GLNativeDelegate.FNglCoverageModulationTableNV));
            yield return new ProcInfo("glGetCoverageModulationTableNV", typeof(GLNativeDelegate.FNglGetCoverageModulationTableNV));
            yield return new ProcInfo("glCoverageModulationNV", typeof(GLNativeDelegate.FNglCoverageModulationNV));

            #endregion GL_NV_framebuffer_mixed_samples

            #region GL_NV_framebuffer_multisample_coverage

            yield return new ProcInfo("glRenderbufferStorageMultisampleCoverageNV", typeof(GLNativeDelegate.FNglRenderbufferStorageMultisampleCoverageNV));

            #endregion GL_NV_framebuffer_multisample_coverage

            #region GL_NV_geometry_program4

            yield return new ProcInfo("glProgramVertexLimitNV", typeof(GLNativeDelegate.FNglProgramVertexLimitNV));
            yield return new ProcInfo("glFramebufferTextureEXT", typeof(GLNativeDelegate.FNglFramebufferTextureEXT));
            // yield return new ProcInfo("glFramebufferTextureLayerEXT", typeof(GLNativeDelegate.FNglFramebufferTextureLayerEXT));
            yield return new ProcInfo("glFramebufferTextureFaceEXT", typeof(GLNativeDelegate.FNglFramebufferTextureFaceEXT));

            #endregion GL_NV_geometry_program4

            #region GL_NV_gpu_program4

            yield return new ProcInfo("glProgramLocalParameterI4iNV", typeof(GLNativeDelegate.FNglProgramLocalParameterI4iNV));
            yield return new ProcInfo("glProgramLocalParameterI4ivNV", typeof(GLNativeDelegate.FNglProgramLocalParameterI4ivNV));
            yield return new ProcInfo("glProgramLocalParametersI4ivNV", typeof(GLNativeDelegate.FNglProgramLocalParametersI4ivNV));
            yield return new ProcInfo("glProgramLocalParameterI4uiNV", typeof(GLNativeDelegate.FNglProgramLocalParameterI4uiNV));
            yield return new ProcInfo("glProgramLocalParameterI4uivNV", typeof(GLNativeDelegate.FNglProgramLocalParameterI4uivNV));
            yield return new ProcInfo("glProgramLocalParametersI4uivNV", typeof(GLNativeDelegate.FNglProgramLocalParametersI4uivNV));
            yield return new ProcInfo("glProgramEnvParameterI4iNV", typeof(GLNativeDelegate.FNglProgramEnvParameterI4iNV));
            yield return new ProcInfo("glProgramEnvParameterI4ivNV", typeof(GLNativeDelegate.FNglProgramEnvParameterI4ivNV));
            yield return new ProcInfo("glProgramEnvParametersI4ivNV", typeof(GLNativeDelegate.FNglProgramEnvParametersI4ivNV));
            yield return new ProcInfo("glProgramEnvParameterI4uiNV", typeof(GLNativeDelegate.FNglProgramEnvParameterI4uiNV));
            yield return new ProcInfo("glProgramEnvParameterI4uivNV", typeof(GLNativeDelegate.FNglProgramEnvParameterI4uivNV));
            yield return new ProcInfo("glProgramEnvParametersI4uivNV", typeof(GLNativeDelegate.FNglProgramEnvParametersI4uivNV));
            yield return new ProcInfo("glGetProgramLocalParameterIivNV", typeof(GLNativeDelegate.FNglGetProgramLocalParameterIivNV));
            yield return new ProcInfo("glGetProgramLocalParameterIuivNV", typeof(GLNativeDelegate.FNglGetProgramLocalParameterIuivNV));
            yield return new ProcInfo("glGetProgramEnvParameterIivNV", typeof(GLNativeDelegate.FNglGetProgramEnvParameterIivNV));
            yield return new ProcInfo("glGetProgramEnvParameterIuivNV", typeof(GLNativeDelegate.FNglGetProgramEnvParameterIuivNV));

            #endregion GL_NV_gpu_program4

            #region GL_NV_gpu_program5

            yield return new ProcInfo("glProgramSubroutineParametersuivNV", typeof(GLNativeDelegate.FNglProgramSubroutineParametersuivNV));
            yield return new ProcInfo("glGetProgramSubroutineParameteruivNV", typeof(GLNativeDelegate.FNglGetProgramSubroutineParameteruivNV));

            #endregion GL_NV_gpu_program5

            #region GL_NV_gpu_shader5

            // yield return new ProcInfo("glUniform1i64NV", typeof(GLNativeDelegate.FNglUniform1i64NV));
            // yield return new ProcInfo("glUniform2i64NV", typeof(GLNativeDelegate.FNglUniform2i64NV));
            // yield return new ProcInfo("glUniform3i64NV", typeof(GLNativeDelegate.FNglUniform3i64NV));
            // yield return new ProcInfo("glUniform4i64NV", typeof(GLNativeDelegate.FNglUniform4i64NV));
            // yield return new ProcInfo("glUniform1i64vNV", typeof(GLNativeDelegate.FNglUniform1i64vNV));
            // yield return new ProcInfo("glUniform2i64vNV", typeof(GLNativeDelegate.FNglUniform2i64vNV));
            // yield return new ProcInfo("glUniform3i64vNV", typeof(GLNativeDelegate.FNglUniform3i64vNV));
            // yield return new ProcInfo("glUniform4i64vNV", typeof(GLNativeDelegate.FNglUniform4i64vNV));
            // yield return new ProcInfo("glUniform1ui64NV", typeof(GLNativeDelegate.FNglUniform1ui64NV));
            // yield return new ProcInfo("glUniform2ui64NV", typeof(GLNativeDelegate.FNglUniform2ui64NV));
            // yield return new ProcInfo("glUniform3ui64NV", typeof(GLNativeDelegate.FNglUniform3ui64NV));
            // yield return new ProcInfo("glUniform4ui64NV", typeof(GLNativeDelegate.FNglUniform4ui64NV));
            // yield return new ProcInfo("glUniform1ui64vNV", typeof(GLNativeDelegate.FNglUniform1ui64vNV));
            // yield return new ProcInfo("glUniform2ui64vNV", typeof(GLNativeDelegate.FNglUniform2ui64vNV));
            // yield return new ProcInfo("glUniform3ui64vNV", typeof(GLNativeDelegate.FNglUniform3ui64vNV));
            // yield return new ProcInfo("glUniform4ui64vNV", typeof(GLNativeDelegate.FNglUniform4ui64vNV));
            // yield return new ProcInfo("glGetUniformi64vNV", typeof(GLNativeDelegate.FNglGetUniformi64vNV));
            // yield return new ProcInfo("glProgramUniform1i64NV", typeof(GLNativeDelegate.FNglProgramUniform1i64NV));
            // yield return new ProcInfo("glProgramUniform2i64NV", typeof(GLNativeDelegate.FNglProgramUniform2i64NV));
            // yield return new ProcInfo("glProgramUniform3i64NV", typeof(GLNativeDelegate.FNglProgramUniform3i64NV));
            // yield return new ProcInfo("glProgramUniform4i64NV", typeof(GLNativeDelegate.FNglProgramUniform4i64NV));
            // yield return new ProcInfo("glProgramUniform1i64vNV", typeof(GLNativeDelegate.FNglProgramUniform1i64vNV));
            // yield return new ProcInfo("glProgramUniform2i64vNV", typeof(GLNativeDelegate.FNglProgramUniform2i64vNV));
            // yield return new ProcInfo("glProgramUniform3i64vNV", typeof(GLNativeDelegate.FNglProgramUniform3i64vNV));
            // yield return new ProcInfo("glProgramUniform4i64vNV", typeof(GLNativeDelegate.FNglProgramUniform4i64vNV));
            // yield return new ProcInfo("glProgramUniform1ui64NV", typeof(GLNativeDelegate.FNglProgramUniform1ui64NV));
            // yield return new ProcInfo("glProgramUniform2ui64NV", typeof(GLNativeDelegate.FNglProgramUniform2ui64NV));
            // yield return new ProcInfo("glProgramUniform3ui64NV", typeof(GLNativeDelegate.FNglProgramUniform3ui64NV));
            // yield return new ProcInfo("glProgramUniform4ui64NV", typeof(GLNativeDelegate.FNglProgramUniform4ui64NV));
            // yield return new ProcInfo("glProgramUniform1ui64vNV", typeof(GLNativeDelegate.FNglProgramUniform1ui64vNV));
            // yield return new ProcInfo("glProgramUniform2ui64vNV", typeof(GLNativeDelegate.FNglProgramUniform2ui64vNV));
            // yield return new ProcInfo("glProgramUniform3ui64vNV", typeof(GLNativeDelegate.FNglProgramUniform3ui64vNV));
            // yield return new ProcInfo("glProgramUniform4ui64vNV", typeof(GLNativeDelegate.FNglProgramUniform4ui64vNV));

            #endregion GL_NV_gpu_shader5

            #region GL_NV_half_float

            yield return new ProcInfo("glVertex2hNV", typeof(GLNativeDelegate.FNglVertex2hNV));
            yield return new ProcInfo("glVertex2hvNV", typeof(GLNativeDelegate.FNglVertex2hvNV));
            yield return new ProcInfo("glVertex3hNV", typeof(GLNativeDelegate.FNglVertex3hNV));
            yield return new ProcInfo("glVertex3hvNV", typeof(GLNativeDelegate.FNglVertex3hvNV));
            yield return new ProcInfo("glVertex4hNV", typeof(GLNativeDelegate.FNglVertex4hNV));
            yield return new ProcInfo("glVertex4hvNV", typeof(GLNativeDelegate.FNglVertex4hvNV));
            yield return new ProcInfo("glNormal3hNV", typeof(GLNativeDelegate.FNglNormal3hNV));
            yield return new ProcInfo("glNormal3hvNV", typeof(GLNativeDelegate.FNglNormal3hvNV));
            yield return new ProcInfo("glColor3hNV", typeof(GLNativeDelegate.FNglColor3hNV));
            yield return new ProcInfo("glColor3hvNV", typeof(GLNativeDelegate.FNglColor3hvNV));
            yield return new ProcInfo("glColor4hNV", typeof(GLNativeDelegate.FNglColor4hNV));
            yield return new ProcInfo("glColor4hvNV", typeof(GLNativeDelegate.FNglColor4hvNV));
            yield return new ProcInfo("glTexCoord1hNV", typeof(GLNativeDelegate.FNglTexCoord1hNV));
            yield return new ProcInfo("glTexCoord1hvNV", typeof(GLNativeDelegate.FNglTexCoord1hvNV));
            yield return new ProcInfo("glTexCoord2hNV", typeof(GLNativeDelegate.FNglTexCoord2hNV));
            yield return new ProcInfo("glTexCoord2hvNV", typeof(GLNativeDelegate.FNglTexCoord2hvNV));
            yield return new ProcInfo("glTexCoord3hNV", typeof(GLNativeDelegate.FNglTexCoord3hNV));
            yield return new ProcInfo("glTexCoord3hvNV", typeof(GLNativeDelegate.FNglTexCoord3hvNV));
            yield return new ProcInfo("glTexCoord4hNV", typeof(GLNativeDelegate.FNglTexCoord4hNV));
            yield return new ProcInfo("glTexCoord4hvNV", typeof(GLNativeDelegate.FNglTexCoord4hvNV));
            yield return new ProcInfo("glMultiTexCoord1hNV", typeof(GLNativeDelegate.FNglMultiTexCoord1hNV));
            yield return new ProcInfo("glMultiTexCoord1hvNV", typeof(GLNativeDelegate.FNglMultiTexCoord1hvNV));
            yield return new ProcInfo("glMultiTexCoord2hNV", typeof(GLNativeDelegate.FNglMultiTexCoord2hNV));
            yield return new ProcInfo("glMultiTexCoord2hvNV", typeof(GLNativeDelegate.FNglMultiTexCoord2hvNV));
            yield return new ProcInfo("glMultiTexCoord3hNV", typeof(GLNativeDelegate.FNglMultiTexCoord3hNV));
            yield return new ProcInfo("glMultiTexCoord3hvNV", typeof(GLNativeDelegate.FNglMultiTexCoord3hvNV));
            yield return new ProcInfo("glMultiTexCoord4hNV", typeof(GLNativeDelegate.FNglMultiTexCoord4hNV));
            yield return new ProcInfo("glMultiTexCoord4hvNV", typeof(GLNativeDelegate.FNglMultiTexCoord4hvNV));
            yield return new ProcInfo("glFogCoordhNV", typeof(GLNativeDelegate.FNglFogCoordhNV));
            yield return new ProcInfo("glFogCoordhvNV", typeof(GLNativeDelegate.FNglFogCoordhvNV));
            yield return new ProcInfo("glSecondaryColor3hNV", typeof(GLNativeDelegate.FNglSecondaryColor3hNV));
            yield return new ProcInfo("glSecondaryColor3hvNV", typeof(GLNativeDelegate.FNglSecondaryColor3hvNV));
            yield return new ProcInfo("glVertexWeighthNV", typeof(GLNativeDelegate.FNglVertexWeighthNV));
            yield return new ProcInfo("glVertexWeighthvNV", typeof(GLNativeDelegate.FNglVertexWeighthvNV));
            yield return new ProcInfo("glVertexAttrib1hNV", typeof(GLNativeDelegate.FNglVertexAttrib1hNV));
            yield return new ProcInfo("glVertexAttrib1hvNV", typeof(GLNativeDelegate.FNglVertexAttrib1hvNV));
            yield return new ProcInfo("glVertexAttrib2hNV", typeof(GLNativeDelegate.FNglVertexAttrib2hNV));
            yield return new ProcInfo("glVertexAttrib2hvNV", typeof(GLNativeDelegate.FNglVertexAttrib2hvNV));
            yield return new ProcInfo("glVertexAttrib3hNV", typeof(GLNativeDelegate.FNglVertexAttrib3hNV));
            yield return new ProcInfo("glVertexAttrib3hvNV", typeof(GLNativeDelegate.FNglVertexAttrib3hvNV));
            yield return new ProcInfo("glVertexAttrib4hNV", typeof(GLNativeDelegate.FNglVertexAttrib4hNV));
            yield return new ProcInfo("glVertexAttrib4hvNV", typeof(GLNativeDelegate.FNglVertexAttrib4hvNV));
            yield return new ProcInfo("glVertexAttribs1hvNV", typeof(GLNativeDelegate.FNglVertexAttribs1hvNV));
            yield return new ProcInfo("glVertexAttribs2hvNV", typeof(GLNativeDelegate.FNglVertexAttribs2hvNV));
            yield return new ProcInfo("glVertexAttribs3hvNV", typeof(GLNativeDelegate.FNglVertexAttribs3hvNV));
            yield return new ProcInfo("glVertexAttribs4hvNV", typeof(GLNativeDelegate.FNglVertexAttribs4hvNV));

            #endregion GL_NV_half_float

            #region GL_NV_internalformat_sample_query

            yield return new ProcInfo("glGetInternalformatSampleivNV", typeof(GLNativeDelegate.FNglGetInternalformatSampleivNV));

            #endregion GL_NV_internalformat_sample_query

            #region GL_NV_gpu_multicast

            yield return new ProcInfo("glRenderGpuMaskNV", typeof(GLNativeDelegate.FNglRenderGpuMaskNV));
            yield return new ProcInfo("glMulticastBufferSubDataNV", typeof(GLNativeDelegate.FNglMulticastBufferSubDataNV));
            yield return new ProcInfo("glMulticastCopyBufferSubDataNV", typeof(GLNativeDelegate.FNglMulticastCopyBufferSubDataNV));
            yield return new ProcInfo("glMulticastCopyImageSubDataNV", typeof(GLNativeDelegate.FNglMulticastCopyImageSubDataNV));
            yield return new ProcInfo("glMulticastBlitFramebufferNV", typeof(GLNativeDelegate.FNglMulticastBlitFramebufferNV));
            yield return new ProcInfo("glMulticastFramebufferSampleLocationsfvNV", typeof(GLNativeDelegate.FNglMulticastFramebufferSampleLocationsfvNV));
            yield return new ProcInfo("glMulticastBarrierNV", typeof(GLNativeDelegate.FNglMulticastBarrierNV));
            yield return new ProcInfo("glMulticastWaitSyncNV", typeof(GLNativeDelegate.FNglMulticastWaitSyncNV));
            yield return new ProcInfo("glMulticastGetQueryObjectivNV", typeof(GLNativeDelegate.FNglMulticastGetQueryObjectivNV));
            yield return new ProcInfo("glMulticastGetQueryObjectuivNV", typeof(GLNativeDelegate.FNglMulticastGetQueryObjectuivNV));
            yield return new ProcInfo("glMulticastGetQueryObjecti64vNV", typeof(GLNativeDelegate.FNglMulticastGetQueryObjecti64vNV));
            yield return new ProcInfo("glMulticastGetQueryObjectui64vNV", typeof(GLNativeDelegate.FNglMulticastGetQueryObjectui64vNV));

            #endregion GL_NV_gpu_multicast

            #region GL_NVX_gpu_multicast2

            yield return new ProcInfo("glUploadGpuMaskNVX", typeof(GLNativeDelegate.FNglUploadGpuMaskNVX));
            yield return new ProcInfo("glMulticastViewportArrayvNVX", typeof(GLNativeDelegate.FNglMulticastViewportArrayvNVX));
            yield return new ProcInfo("glMulticastViewportPositionWScaleNVX", typeof(GLNativeDelegate.FNglMulticastViewportPositionWScaleNVX));
            yield return new ProcInfo("glMulticastScissorArrayvNVX", typeof(GLNativeDelegate.FNglMulticastScissorArrayvNVX));
            yield return new ProcInfo("glAsyncCopyBufferSubDataNVX", typeof(GLNativeDelegate.FNglAsyncCopyBufferSubDataNVX));
            yield return new ProcInfo("glAsyncCopyImageSubDataNVX", typeof(GLNativeDelegate.FNglAsyncCopyImageSubDataNVX));

            #endregion GL_NVX_gpu_multicast2

            #region GL_NVX_progress_fence

            yield return new ProcInfo("glCreateProgressFenceNVX", typeof(GLNativeDelegate.FNglCreateProgressFenceNVX));
            yield return new ProcInfo("glSignalSemaphoreui64NVX", typeof(GLNativeDelegate.FNglSignalSemaphoreui64NVX));
            yield return new ProcInfo("glWaitSemaphoreui64NVX", typeof(GLNativeDelegate.FNglWaitSemaphoreui64NVX));
            yield return new ProcInfo("glClientWaitSemaphoreui64NVX", typeof(GLNativeDelegate.FNglClientWaitSemaphoreui64NVX));

            #endregion GL_NVX_progress_fence

            #region GL_NV_memory_attachment

            yield return new ProcInfo("glGetMemoryObjectDetachedResourcesuivNV", typeof(GLNativeDelegate.FNglGetMemoryObjectDetachedResourcesuivNV));
            yield return new ProcInfo("glResetMemoryObjectParameterNV", typeof(GLNativeDelegate.FNglResetMemoryObjectParameterNV));
            yield return new ProcInfo("glTexAttachMemoryNV", typeof(GLNativeDelegate.FNglTexAttachMemoryNV));
            yield return new ProcInfo("glBufferAttachMemoryNV", typeof(GLNativeDelegate.FNglBufferAttachMemoryNV));
            yield return new ProcInfo("glTextureAttachMemoryNV", typeof(GLNativeDelegate.FNglTextureAttachMemoryNV));
            yield return new ProcInfo("glNamedBufferAttachMemoryNV", typeof(GLNativeDelegate.FNglNamedBufferAttachMemoryNV));

            #endregion GL_NV_memory_attachment

            #region GL_NV_memory_object_sparse

            yield return new ProcInfo("glBufferPageCommitmentMemNV", typeof(GLNativeDelegate.FNglBufferPageCommitmentMemNV));
            yield return new ProcInfo("glTexPageCommitmentMemNV", typeof(GLNativeDelegate.FNglTexPageCommitmentMemNV));
            yield return new ProcInfo("glNamedBufferPageCommitmentMemNV", typeof(GLNativeDelegate.FNglNamedBufferPageCommitmentMemNV));
            yield return new ProcInfo("glTexturePageCommitmentMemNV", typeof(GLNativeDelegate.FNglTexturePageCommitmentMemNV));

            #endregion GL_NV_memory_object_sparse

            #region GL_NV_mesh_shader

            yield return new ProcInfo("glDrawMeshTasksNV", typeof(GLNativeDelegate.FNglDrawMeshTasksNV));
            yield return new ProcInfo("glDrawMeshTasksIndirectNV", typeof(GLNativeDelegate.FNglDrawMeshTasksIndirectNV));
            yield return new ProcInfo("glMultiDrawMeshTasksIndirectNV", typeof(GLNativeDelegate.FNglMultiDrawMeshTasksIndirectNV));
            yield return new ProcInfo("glMultiDrawMeshTasksIndirectCountNV", typeof(GLNativeDelegate.FNglMultiDrawMeshTasksIndirectCountNV));

            #endregion GL_NV_mesh_shader

            #region GL_NV_occlusion_query

            yield return new ProcInfo("glGenOcclusionQueriesNV", typeof(GLNativeDelegate.FNglGenOcclusionQueriesNV));
            yield return new ProcInfo("glDeleteOcclusionQueriesNV", typeof(GLNativeDelegate.FNglDeleteOcclusionQueriesNV));
            yield return new ProcInfo("glIsOcclusionQueryNV", typeof(GLNativeDelegate.FNglIsOcclusionQueryNV));
            yield return new ProcInfo("glBeginOcclusionQueryNV", typeof(GLNativeDelegate.FNglBeginOcclusionQueryNV));
            yield return new ProcInfo("glEndOcclusionQueryNV", typeof(GLNativeDelegate.FNglEndOcclusionQueryNV));
            yield return new ProcInfo("glGetOcclusionQueryivNV", typeof(GLNativeDelegate.FNglGetOcclusionQueryivNV));
            yield return new ProcInfo("glGetOcclusionQueryuivNV", typeof(GLNativeDelegate.FNglGetOcclusionQueryuivNV));

            #endregion GL_NV_occlusion_query

            #region GL_NV_parameter_buffer_object

            yield return new ProcInfo("glProgramBufferParametersfvNV", typeof(GLNativeDelegate.FNglProgramBufferParametersfvNV));
            yield return new ProcInfo("glProgramBufferParametersIivNV", typeof(GLNativeDelegate.FNglProgramBufferParametersIivNV));
            yield return new ProcInfo("glProgramBufferParametersIuivNV", typeof(GLNativeDelegate.FNglProgramBufferParametersIuivNV));

            #endregion GL_NV_parameter_buffer_object

            #region GL_NV_path_rendering

            yield return new ProcInfo("glGenPathsNV", typeof(GLNativeDelegate.FNglGenPathsNV));
            yield return new ProcInfo("glDeletePathsNV", typeof(GLNativeDelegate.FNglDeletePathsNV));
            yield return new ProcInfo("glIsPathNV", typeof(GLNativeDelegate.FNglIsPathNV));
            yield return new ProcInfo("glPathCommandsNV", typeof(GLNativeDelegate.FNglPathCommandsNV));
            yield return new ProcInfo("glPathCoordsNV", typeof(GLNativeDelegate.FNglPathCoordsNV));
            yield return new ProcInfo("glPathSubCommandsNV", typeof(GLNativeDelegate.FNglPathSubCommandsNV));
            yield return new ProcInfo("glPathSubCoordsNV", typeof(GLNativeDelegate.FNglPathSubCoordsNV));
            yield return new ProcInfo("glPathStringNV", typeof(GLNativeDelegate.FNglPathStringNV));
            yield return new ProcInfo("glPathGlyphsNV", typeof(GLNativeDelegate.FNglPathGlyphsNV));
            yield return new ProcInfo("glPathGlyphRangeNV", typeof(GLNativeDelegate.FNglPathGlyphRangeNV));
            yield return new ProcInfo("glWeightPathsNV", typeof(GLNativeDelegate.FNglWeightPathsNV));
            yield return new ProcInfo("glCopyPathNV", typeof(GLNativeDelegate.FNglCopyPathNV));
            yield return new ProcInfo("glInterpolatePathsNV", typeof(GLNativeDelegate.FNglInterpolatePathsNV));
            yield return new ProcInfo("glTransformPathNV", typeof(GLNativeDelegate.FNglTransformPathNV));
            yield return new ProcInfo("glPathParameterivNV", typeof(GLNativeDelegate.FNglPathParameterivNV));
            yield return new ProcInfo("glPathParameteriNV", typeof(GLNativeDelegate.FNglPathParameteriNV));
            yield return new ProcInfo("glPathParameterfvNV", typeof(GLNativeDelegate.FNglPathParameterfvNV));
            yield return new ProcInfo("glPathParameterfNV", typeof(GLNativeDelegate.FNglPathParameterfNV));
            yield return new ProcInfo("glPathDashArrayNV", typeof(GLNativeDelegate.FNglPathDashArrayNV));
            yield return new ProcInfo("glPathStencilFuncNV", typeof(GLNativeDelegate.FNglPathStencilFuncNV));
            yield return new ProcInfo("glPathStencilDepthOffsetNV", typeof(GLNativeDelegate.FNglPathStencilDepthOffsetNV));
            yield return new ProcInfo("glStencilFillPathNV", typeof(GLNativeDelegate.FNglStencilFillPathNV));
            yield return new ProcInfo("glStencilStrokePathNV", typeof(GLNativeDelegate.FNglStencilStrokePathNV));
            yield return new ProcInfo("glStencilFillPathInstancedNV", typeof(GLNativeDelegate.FNglStencilFillPathInstancedNV));
            yield return new ProcInfo("glStencilStrokePathInstancedNV", typeof(GLNativeDelegate.FNglStencilStrokePathInstancedNV));
            yield return new ProcInfo("glPathCoverDepthFuncNV", typeof(GLNativeDelegate.FNglPathCoverDepthFuncNV));
            yield return new ProcInfo("glCoverFillPathNV", typeof(GLNativeDelegate.FNglCoverFillPathNV));
            yield return new ProcInfo("glCoverStrokePathNV", typeof(GLNativeDelegate.FNglCoverStrokePathNV));
            yield return new ProcInfo("glCoverFillPathInstancedNV", typeof(GLNativeDelegate.FNglCoverFillPathInstancedNV));
            yield return new ProcInfo("glCoverStrokePathInstancedNV", typeof(GLNativeDelegate.FNglCoverStrokePathInstancedNV));
            yield return new ProcInfo("glGetPathParameterivNV", typeof(GLNativeDelegate.FNglGetPathParameterivNV));
            yield return new ProcInfo("glGetPathParameterfvNV", typeof(GLNativeDelegate.FNglGetPathParameterfvNV));
            yield return new ProcInfo("glGetPathCommandsNV", typeof(GLNativeDelegate.FNglGetPathCommandsNV));
            yield return new ProcInfo("glGetPathCoordsNV", typeof(GLNativeDelegate.FNglGetPathCoordsNV));
            yield return new ProcInfo("glGetPathDashArrayNV", typeof(GLNativeDelegate.FNglGetPathDashArrayNV));
            yield return new ProcInfo("glGetPathMetricsNV", typeof(GLNativeDelegate.FNglGetPathMetricsNV));
            yield return new ProcInfo("glGetPathMetricRangeNV", typeof(GLNativeDelegate.FNglGetPathMetricRangeNV));
            yield return new ProcInfo("glGetPathSpacingNV", typeof(GLNativeDelegate.FNglGetPathSpacingNV));
            yield return new ProcInfo("glIsPointInFillPathNV", typeof(GLNativeDelegate.FNglIsPointInFillPathNV));
            yield return new ProcInfo("glIsPointInStrokePathNV", typeof(GLNativeDelegate.FNglIsPointInStrokePathNV));
            yield return new ProcInfo("glGetPathLengthNV", typeof(GLNativeDelegate.FNglGetPathLengthNV));
            yield return new ProcInfo("glPointAlongPathNV", typeof(GLNativeDelegate.FNglPointAlongPathNV));
            yield return new ProcInfo("glMatrixLoad3x2fNV", typeof(GLNativeDelegate.FNglMatrixLoad3x2fNV));
            yield return new ProcInfo("glMatrixLoad3x3fNV", typeof(GLNativeDelegate.FNglMatrixLoad3x3fNV));
            yield return new ProcInfo("glMatrixLoadTranspose3x3fNV", typeof(GLNativeDelegate.FNglMatrixLoadTranspose3x3fNV));
            yield return new ProcInfo("glMatrixMult3x2fNV", typeof(GLNativeDelegate.FNglMatrixMult3x2fNV));
            yield return new ProcInfo("glMatrixMult3x3fNV", typeof(GLNativeDelegate.FNglMatrixMult3x3fNV));
            yield return new ProcInfo("glMatrixMultTranspose3x3fNV", typeof(GLNativeDelegate.FNglMatrixMultTranspose3x3fNV));
            yield return new ProcInfo("glStencilThenCoverFillPathNV", typeof(GLNativeDelegate.FNglStencilThenCoverFillPathNV));
            yield return new ProcInfo("glStencilThenCoverStrokePathNV", typeof(GLNativeDelegate.FNglStencilThenCoverStrokePathNV));
            yield return new ProcInfo("glStencilThenCoverFillPathInstancedNV", typeof(GLNativeDelegate.FNglStencilThenCoverFillPathInstancedNV));
            yield return new ProcInfo("glStencilThenCoverStrokePathInstancedNV", typeof(GLNativeDelegate.FNglStencilThenCoverStrokePathInstancedNV));
            yield return new ProcInfo("glPathGlyphIndexRangeNV", typeof(GLNativeDelegate.FNglPathGlyphIndexRangeNV));
            yield return new ProcInfo("glPathGlyphIndexArrayNV", typeof(GLNativeDelegate.FNglPathGlyphIndexArrayNV));
            yield return new ProcInfo("glPathMemoryGlyphIndexArrayNV", typeof(GLNativeDelegate.FNglPathMemoryGlyphIndexArrayNV));
            yield return new ProcInfo("glProgramPathFragmentInputGenNV", typeof(GLNativeDelegate.FNglProgramPathFragmentInputGenNV));
            yield return new ProcInfo("glGetProgramResourcefvNV", typeof(GLNativeDelegate.FNglGetProgramResourcefvNV));
            yield return new ProcInfo("glPathColorGenNV", typeof(GLNativeDelegate.FNglPathColorGenNV));
            yield return new ProcInfo("glPathTexGenNV", typeof(GLNativeDelegate.FNglPathTexGenNV));
            yield return new ProcInfo("glPathFogGenNV", typeof(GLNativeDelegate.FNglPathFogGenNV));
            yield return new ProcInfo("glGetPathColorGenivNV", typeof(GLNativeDelegate.FNglGetPathColorGenivNV));
            yield return new ProcInfo("glGetPathColorGenfvNV", typeof(GLNativeDelegate.FNglGetPathColorGenfvNV));
            yield return new ProcInfo("glGetPathTexGenivNV", typeof(GLNativeDelegate.FNglGetPathTexGenivNV));
            yield return new ProcInfo("glGetPathTexGenfvNV", typeof(GLNativeDelegate.FNglGetPathTexGenfvNV));
            yield return new ProcInfo("glMatrixFrustumEXT", typeof(GLNativeDelegate.FNglMatrixFrustumEXT));
            yield return new ProcInfo("glMatrixLoadIdentityEXT", typeof(GLNativeDelegate.FNglMatrixLoadIdentityEXT));
            yield return new ProcInfo("glMatrixLoadTransposefEXT", typeof(GLNativeDelegate.FNglMatrixLoadTransposefEXT));
            yield return new ProcInfo("glMatrixLoadTransposedEXT", typeof(GLNativeDelegate.FNglMatrixLoadTransposedEXT));
            yield return new ProcInfo("glMatrixLoadfEXT", typeof(GLNativeDelegate.FNglMatrixLoadfEXT));
            yield return new ProcInfo("glMatrixLoaddEXT", typeof(GLNativeDelegate.FNglMatrixLoaddEXT));
            yield return new ProcInfo("glMatrixMultTransposefEXT", typeof(GLNativeDelegate.FNglMatrixMultTransposefEXT));
            yield return new ProcInfo("glMatrixMultTransposedEXT", typeof(GLNativeDelegate.FNglMatrixMultTransposedEXT));
            yield return new ProcInfo("glMatrixMultfEXT", typeof(GLNativeDelegate.FNglMatrixMultfEXT));
            yield return new ProcInfo("glMatrixMultdEXT", typeof(GLNativeDelegate.FNglMatrixMultdEXT));
            yield return new ProcInfo("glMatrixOrthoEXT", typeof(GLNativeDelegate.FNglMatrixOrthoEXT));
            yield return new ProcInfo("glMatrixPopEXT", typeof(GLNativeDelegate.FNglMatrixPopEXT));
            yield return new ProcInfo("glMatrixPushEXT", typeof(GLNativeDelegate.FNglMatrixPushEXT));
            yield return new ProcInfo("glMatrixRotatefEXT", typeof(GLNativeDelegate.FNglMatrixRotatefEXT));
            yield return new ProcInfo("glMatrixRotatedEXT", typeof(GLNativeDelegate.FNglMatrixRotatedEXT));
            yield return new ProcInfo("glMatrixScalefEXT", typeof(GLNativeDelegate.FNglMatrixScalefEXT));
            yield return new ProcInfo("glMatrixScaledEXT", typeof(GLNativeDelegate.FNglMatrixScaledEXT));
            yield return new ProcInfo("glMatrixTranslatefEXT", typeof(GLNativeDelegate.FNglMatrixTranslatefEXT));
            yield return new ProcInfo("glMatrixTranslatedEXT", typeof(GLNativeDelegate.FNglMatrixTranslatedEXT));

            #endregion GL_NV_path_rendering

            #region GL_NV_pixel_data_range

            yield return new ProcInfo("glPixelDataRangeNV", typeof(GLNativeDelegate.FNglPixelDataRangeNV));
            yield return new ProcInfo("glFlushPixelDataRangeNV", typeof(GLNativeDelegate.FNglFlushPixelDataRangeNV));

            #endregion GL_NV_pixel_data_range

            #region GL_NV_point_sprite

            yield return new ProcInfo("glPointParameteriNV", typeof(GLNativeDelegate.FNglPointParameteriNV));
            yield return new ProcInfo("glPointParameterivNV", typeof(GLNativeDelegate.FNglPointParameterivNV));

            #endregion GL_NV_point_sprite

            #region GL_NV_present_video

            yield return new ProcInfo("glPresentFrameKeyedNV", typeof(GLNativeDelegate.FNglPresentFrameKeyedNV));
            yield return new ProcInfo("glPresentFrameDualFillNV", typeof(GLNativeDelegate.FNglPresentFrameDualFillNV));
            yield return new ProcInfo("glGetVideoivNV", typeof(GLNativeDelegate.FNglGetVideoivNV));
            yield return new ProcInfo("glGetVideouivNV", typeof(GLNativeDelegate.FNglGetVideouivNV));
            yield return new ProcInfo("glGetVideoi64vNV", typeof(GLNativeDelegate.FNglGetVideoi64vNV));
            yield return new ProcInfo("glGetVideoui64vNV", typeof(GLNativeDelegate.FNglGetVideoui64vNV));

            #endregion GL_NV_present_video

            #region GL_NV_primitive_restart

            yield return new ProcInfo("glPrimitiveRestartNV", typeof(GLNativeDelegate.FNglPrimitiveRestartNV));
            yield return new ProcInfo("glPrimitiveRestartIndexNV", typeof(GLNativeDelegate.FNglPrimitiveRestartIndexNV));

            #endregion GL_NV_primitive_restart

            #region GL_NV_query_resource

            yield return new ProcInfo("glQueryResourceNV", typeof(GLNativeDelegate.FNglQueryResourceNV));

            #endregion GL_NV_query_resource

            #region GL_NV_query_resource_tag

            yield return new ProcInfo("glGenQueryResourceTagNV", typeof(GLNativeDelegate.FNglGenQueryResourceTagNV));
            yield return new ProcInfo("glDeleteQueryResourceTagNV", typeof(GLNativeDelegate.FNglDeleteQueryResourceTagNV));
            yield return new ProcInfo("glQueryResourceTagNV", typeof(GLNativeDelegate.FNglQueryResourceTagNV));

            #endregion GL_NV_query_resource_tag

            #region GL_NV_register_combiners

            yield return new ProcInfo("glCombinerParameterfvNV", typeof(GLNativeDelegate.FNglCombinerParameterfvNV));
            yield return new ProcInfo("glCombinerParameterfNV", typeof(GLNativeDelegate.FNglCombinerParameterfNV));
            yield return new ProcInfo("glCombinerParameterivNV", typeof(GLNativeDelegate.FNglCombinerParameterivNV));
            yield return new ProcInfo("glCombinerParameteriNV", typeof(GLNativeDelegate.FNglCombinerParameteriNV));
            yield return new ProcInfo("glCombinerInputNV", typeof(GLNativeDelegate.FNglCombinerInputNV));
            yield return new ProcInfo("glCombinerOutputNV", typeof(GLNativeDelegate.FNglCombinerOutputNV));
            yield return new ProcInfo("glFinalCombinerInputNV", typeof(GLNativeDelegate.FNglFinalCombinerInputNV));
            yield return new ProcInfo("glGetCombinerInputParameterfvNV", typeof(GLNativeDelegate.FNglGetCombinerInputParameterfvNV));
            yield return new ProcInfo("glGetCombinerInputParameterivNV", typeof(GLNativeDelegate.FNglGetCombinerInputParameterivNV));
            yield return new ProcInfo("glGetCombinerOutputParameterfvNV", typeof(GLNativeDelegate.FNglGetCombinerOutputParameterfvNV));
            yield return new ProcInfo("glGetCombinerOutputParameterivNV", typeof(GLNativeDelegate.FNglGetCombinerOutputParameterivNV));
            yield return new ProcInfo("glGetFinalCombinerInputParameterfvNV", typeof(GLNativeDelegate.FNglGetFinalCombinerInputParameterfvNV));
            yield return new ProcInfo("glGetFinalCombinerInputParameterivNV", typeof(GLNativeDelegate.FNglGetFinalCombinerInputParameterivNV));

            #endregion GL_NV_register_combiners

            #region GL_NV_register_combiners2

            yield return new ProcInfo("glCombinerStageParameterfvNV", typeof(GLNativeDelegate.FNglCombinerStageParameterfvNV));
            yield return new ProcInfo("glGetCombinerStageParameterfvNV", typeof(GLNativeDelegate.FNglGetCombinerStageParameterfvNV));

            #endregion GL_NV_register_combiners2

            #region GL_NV_sample_locations

            yield return new ProcInfo("glFramebufferSampleLocationsfvNV", typeof(GLNativeDelegate.FNglFramebufferSampleLocationsfvNV));
            yield return new ProcInfo("glNamedFramebufferSampleLocationsfvNV", typeof(GLNativeDelegate.FNglNamedFramebufferSampleLocationsfvNV));
            yield return new ProcInfo("glResolveDepthValuesNV", typeof(GLNativeDelegate.FNglResolveDepthValuesNV));

            #endregion GL_NV_sample_locations

            #region GL_NV_scissor_exclusive

            yield return new ProcInfo("glScissorExclusiveNV", typeof(GLNativeDelegate.FNglScissorExclusiveNV));
            yield return new ProcInfo("glScissorExclusiveArrayvNV", typeof(GLNativeDelegate.FNglScissorExclusiveArrayvNV));

            #endregion GL_NV_scissor_exclusive

            #region GL_NV_shader_buffer_load

            yield return new ProcInfo("glMakeBufferResidentNV", typeof(GLNativeDelegate.FNglMakeBufferResidentNV));
            yield return new ProcInfo("glMakeBufferNonResidentNV", typeof(GLNativeDelegate.FNglMakeBufferNonResidentNV));
            yield return new ProcInfo("glIsBufferResidentNV", typeof(GLNativeDelegate.FNglIsBufferResidentNV));
            yield return new ProcInfo("glMakeNamedBufferResidentNV", typeof(GLNativeDelegate.FNglMakeNamedBufferResidentNV));
            yield return new ProcInfo("glMakeNamedBufferNonResidentNV", typeof(GLNativeDelegate.FNglMakeNamedBufferNonResidentNV));
            yield return new ProcInfo("glIsNamedBufferResidentNV", typeof(GLNativeDelegate.FNglIsNamedBufferResidentNV));
            yield return new ProcInfo("glGetBufferParameterui64vNV", typeof(GLNativeDelegate.FNglGetBufferParameterui64vNV));
            yield return new ProcInfo("glGetNamedBufferParameterui64vNV", typeof(GLNativeDelegate.FNglGetNamedBufferParameterui64vNV));
            yield return new ProcInfo("glGetIntegerui64vNV", typeof(GLNativeDelegate.FNglGetIntegerui64vNV));
            yield return new ProcInfo("glUniformui64NV", typeof(GLNativeDelegate.FNglUniformui64NV));
            yield return new ProcInfo("glUniformui64vNV", typeof(GLNativeDelegate.FNglUniformui64vNV));
            // yield return new ProcInfo("glGetUniformui64vNV", typeof(GLNativeDelegate.FNglGetUniformui64vNV));
            yield return new ProcInfo("glProgramUniformui64NV", typeof(GLNativeDelegate.FNglProgramUniformui64NV));
            yield return new ProcInfo("glProgramUniformui64vNV", typeof(GLNativeDelegate.FNglProgramUniformui64vNV));

            #endregion GL_NV_shader_buffer_load

            #region GL_NV_shading_rate_image

            yield return new ProcInfo("glBindShadingRateImageNV", typeof(GLNativeDelegate.FNglBindShadingRateImageNV));
            yield return new ProcInfo("glGetShadingRateImagePaletteNV", typeof(GLNativeDelegate.FNglGetShadingRateImagePaletteNV));
            yield return new ProcInfo("glGetShadingRateSampleLocationivNV", typeof(GLNativeDelegate.FNglGetShadingRateSampleLocationivNV));
            yield return new ProcInfo("glShadingRateImageBarrierNV", typeof(GLNativeDelegate.FNglShadingRateImageBarrierNV));
            yield return new ProcInfo("glShadingRateImagePaletteNV", typeof(GLNativeDelegate.FNglShadingRateImagePaletteNV));
            yield return new ProcInfo("glShadingRateSampleOrderNV", typeof(GLNativeDelegate.FNglShadingRateSampleOrderNV));
            yield return new ProcInfo("glShadingRateSampleOrderCustomNV", typeof(GLNativeDelegate.FNglShadingRateSampleOrderCustomNV));

            #endregion GL_NV_shading_rate_image

            #region GL_NV_texture_barrier

            yield return new ProcInfo("glTextureBarrierNV", typeof(GLNativeDelegate.FNglTextureBarrierNV));

            #endregion GL_NV_texture_barrier

            #region GL_NV_texture_multisample

            yield return new ProcInfo("glTexImage2DMultisampleCoverageNV", typeof(GLNativeDelegate.FNglTexImage2DMultisampleCoverageNV));
            yield return new ProcInfo("glTexImage3DMultisampleCoverageNV", typeof(GLNativeDelegate.FNglTexImage3DMultisampleCoverageNV));
            yield return new ProcInfo("glTextureImage2DMultisampleNV", typeof(GLNativeDelegate.FNglTextureImage2DMultisampleNV));
            yield return new ProcInfo("glTextureImage3DMultisampleNV", typeof(GLNativeDelegate.FNglTextureImage3DMultisampleNV));
            yield return new ProcInfo("glTextureImage2DMultisampleCoverageNV", typeof(GLNativeDelegate.FNglTextureImage2DMultisampleCoverageNV));
            yield return new ProcInfo("glTextureImage3DMultisampleCoverageNV", typeof(GLNativeDelegate.FNglTextureImage3DMultisampleCoverageNV));

            #endregion GL_NV_texture_multisample

            #region GL_NV_transform_feedback

            yield return new ProcInfo("glBeginTransformFeedbackNV", typeof(GLNativeDelegate.FNglBeginTransformFeedbackNV));
            yield return new ProcInfo("glEndTransformFeedbackNV", typeof(GLNativeDelegate.FNglEndTransformFeedbackNV));
            yield return new ProcInfo("glTransformFeedbackAttribsNV", typeof(GLNativeDelegate.FNglTransformFeedbackAttribsNV));
            yield return new ProcInfo("glBindBufferRangeNV", typeof(GLNativeDelegate.FNglBindBufferRangeNV));
            yield return new ProcInfo("glBindBufferOffsetNV", typeof(GLNativeDelegate.FNglBindBufferOffsetNV));
            yield return new ProcInfo("glBindBufferBaseNV", typeof(GLNativeDelegate.FNglBindBufferBaseNV));
            yield return new ProcInfo("glTransformFeedbackVaryingsNV", typeof(GLNativeDelegate.FNglTransformFeedbackVaryingsNV));
            yield return new ProcInfo("glActiveVaryingNV", typeof(GLNativeDelegate.FNglActiveVaryingNV));
            yield return new ProcInfo("glGetVaryingLocationNV", typeof(GLNativeDelegate.FNglGetVaryingLocationNV));
            yield return new ProcInfo("glGetActiveVaryingNV", typeof(GLNativeDelegate.FNglGetActiveVaryingNV));
            yield return new ProcInfo("glGetTransformFeedbackVaryingNV", typeof(GLNativeDelegate.FNglGetTransformFeedbackVaryingNV));
            yield return new ProcInfo("glTransformFeedbackStreamAttribsNV", typeof(GLNativeDelegate.FNglTransformFeedbackStreamAttribsNV));

            #endregion GL_NV_transform_feedback

            #region GL_NV_transform_feedback2

            yield return new ProcInfo("glBindTransformFeedbackNV", typeof(GLNativeDelegate.FNglBindTransformFeedbackNV));
            yield return new ProcInfo("glDeleteTransformFeedbacksNV", typeof(GLNativeDelegate.FNglDeleteTransformFeedbacksNV));
            yield return new ProcInfo("glGenTransformFeedbacksNV", typeof(GLNativeDelegate.FNglGenTransformFeedbacksNV));
            yield return new ProcInfo("glIsTransformFeedbackNV", typeof(GLNativeDelegate.FNglIsTransformFeedbackNV));
            yield return new ProcInfo("glPauseTransformFeedbackNV", typeof(GLNativeDelegate.FNglPauseTransformFeedbackNV));
            yield return new ProcInfo("glResumeTransformFeedbackNV", typeof(GLNativeDelegate.FNglResumeTransformFeedbackNV));
            yield return new ProcInfo("glDrawTransformFeedbackNV", typeof(GLNativeDelegate.FNglDrawTransformFeedbackNV));

            #endregion GL_NV_transform_feedback2

            #region GL_NV_vdpau_interop

            yield return new ProcInfo("glVDPAUInitNV", typeof(GLNativeDelegate.FNglVDPAUInitNV));
            yield return new ProcInfo("glVDPAUFiniNV", typeof(GLNativeDelegate.FNglVDPAUFiniNV));
            yield return new ProcInfo("glVDPAURegisterVideoSurfaceNV", typeof(GLNativeDelegate.FNglVDPAURegisterVideoSurfaceNV));
            yield return new ProcInfo("glVDPAURegisterOutputSurfaceNV", typeof(GLNativeDelegate.FNglVDPAURegisterOutputSurfaceNV));
            yield return new ProcInfo("glVDPAUIsSurfaceNV", typeof(GLNativeDelegate.FNglVDPAUIsSurfaceNV));
            yield return new ProcInfo("glVDPAUUnregisterSurfaceNV", typeof(GLNativeDelegate.FNglVDPAUUnregisterSurfaceNV));
            yield return new ProcInfo("glVDPAUGetSurfaceivNV", typeof(GLNativeDelegate.FNglVDPAUGetSurfaceivNV));
            yield return new ProcInfo("glVDPAUSurfaceAccessNV", typeof(GLNativeDelegate.FNglVDPAUSurfaceAccessNV));
            yield return new ProcInfo("glVDPAUMapSurfacesNV", typeof(GLNativeDelegate.FNglVDPAUMapSurfacesNV));
            yield return new ProcInfo("glVDPAUUnmapSurfacesNV", typeof(GLNativeDelegate.FNglVDPAUUnmapSurfacesNV));

            #endregion GL_NV_vdpau_interop

            #region GL_NV_vdpau_interop2

            yield return new ProcInfo("glVDPAURegisterVideoSurfaceWithPictureStructureNV", typeof(GLNativeDelegate.FNglVDPAURegisterVideoSurfaceWithPictureStructureNV));

            #endregion GL_NV_vdpau_interop2

            #region GL_NV_vertex_array_range

            yield return new ProcInfo("glFlushVertexArrayRangeNV", typeof(GLNativeDelegate.FNglFlushVertexArrayRangeNV));
            yield return new ProcInfo("glVertexArrayRangeNV", typeof(GLNativeDelegate.FNglVertexArrayRangeNV));

            #endregion GL_NV_vertex_array_range

            #region GL_NV_vertex_attrib_integer_64bit

            yield return new ProcInfo("glVertexAttribL1i64NV", typeof(GLNativeDelegate.FNglVertexAttribL1i64NV));
            yield return new ProcInfo("glVertexAttribL2i64NV", typeof(GLNativeDelegate.FNglVertexAttribL2i64NV));
            yield return new ProcInfo("glVertexAttribL3i64NV", typeof(GLNativeDelegate.FNglVertexAttribL3i64NV));
            yield return new ProcInfo("glVertexAttribL4i64NV", typeof(GLNativeDelegate.FNglVertexAttribL4i64NV));
            yield return new ProcInfo("glVertexAttribL1i64vNV", typeof(GLNativeDelegate.FNglVertexAttribL1i64vNV));
            yield return new ProcInfo("glVertexAttribL2i64vNV", typeof(GLNativeDelegate.FNglVertexAttribL2i64vNV));
            yield return new ProcInfo("glVertexAttribL3i64vNV", typeof(GLNativeDelegate.FNglVertexAttribL3i64vNV));
            yield return new ProcInfo("glVertexAttribL4i64vNV", typeof(GLNativeDelegate.FNglVertexAttribL4i64vNV));
            yield return new ProcInfo("glVertexAttribL1ui64NV", typeof(GLNativeDelegate.FNglVertexAttribL1ui64NV));
            yield return new ProcInfo("glVertexAttribL2ui64NV", typeof(GLNativeDelegate.FNglVertexAttribL2ui64NV));
            yield return new ProcInfo("glVertexAttribL3ui64NV", typeof(GLNativeDelegate.FNglVertexAttribL3ui64NV));
            yield return new ProcInfo("glVertexAttribL4ui64NV", typeof(GLNativeDelegate.FNglVertexAttribL4ui64NV));
            yield return new ProcInfo("glVertexAttribL1ui64vNV", typeof(GLNativeDelegate.FNglVertexAttribL1ui64vNV));
            yield return new ProcInfo("glVertexAttribL2ui64vNV", typeof(GLNativeDelegate.FNglVertexAttribL2ui64vNV));
            yield return new ProcInfo("glVertexAttribL3ui64vNV", typeof(GLNativeDelegate.FNglVertexAttribL3ui64vNV));
            yield return new ProcInfo("glVertexAttribL4ui64vNV", typeof(GLNativeDelegate.FNglVertexAttribL4ui64vNV));
            yield return new ProcInfo("glGetVertexAttribLi64vNV", typeof(GLNativeDelegate.FNglGetVertexAttribLi64vNV));
            yield return new ProcInfo("glGetVertexAttribLui64vNV", typeof(GLNativeDelegate.FNglGetVertexAttribLui64vNV));
            yield return new ProcInfo("glVertexAttribLFormatNV", typeof(GLNativeDelegate.FNglVertexAttribLFormatNV));

            #endregion GL_NV_vertex_attrib_integer_64bit

            #region GL_NV_vertex_buffer_unified_memory

            yield return new ProcInfo("glBufferAddressRangeNV", typeof(GLNativeDelegate.FNglBufferAddressRangeNV));
            yield return new ProcInfo("glVertexFormatNV", typeof(GLNativeDelegate.FNglVertexFormatNV));
            yield return new ProcInfo("glNormalFormatNV", typeof(GLNativeDelegate.FNglNormalFormatNV));
            yield return new ProcInfo("glColorFormatNV", typeof(GLNativeDelegate.FNglColorFormatNV));
            yield return new ProcInfo("glIndexFormatNV", typeof(GLNativeDelegate.FNglIndexFormatNV));
            yield return new ProcInfo("glTexCoordFormatNV", typeof(GLNativeDelegate.FNglTexCoordFormatNV));
            yield return new ProcInfo("glEdgeFlagFormatNV", typeof(GLNativeDelegate.FNglEdgeFlagFormatNV));
            yield return new ProcInfo("glSecondaryColorFormatNV", typeof(GLNativeDelegate.FNglSecondaryColorFormatNV));
            yield return new ProcInfo("glFogCoordFormatNV", typeof(GLNativeDelegate.FNglFogCoordFormatNV));
            yield return new ProcInfo("glVertexAttribFormatNV", typeof(GLNativeDelegate.FNglVertexAttribFormatNV));
            yield return new ProcInfo("glVertexAttribIFormatNV", typeof(GLNativeDelegate.FNglVertexAttribIFormatNV));
            yield return new ProcInfo("glGetIntegerui64i_vNV", typeof(GLNativeDelegate.FNglGetIntegerui64i_vNV));

            #endregion GL_NV_vertex_buffer_unified_memory

            #region GL_NV_vertex_program

            yield return new ProcInfo("glAreProgramsResidentNV", typeof(GLNativeDelegate.FNglAreProgramsResidentNV));
            yield return new ProcInfo("glBindProgramNV", typeof(GLNativeDelegate.FNglBindProgramNV));
            yield return new ProcInfo("glDeleteProgramsNV", typeof(GLNativeDelegate.FNglDeleteProgramsNV));
            yield return new ProcInfo("glExecuteProgramNV", typeof(GLNativeDelegate.FNglExecuteProgramNV));
            yield return new ProcInfo("glGenProgramsNV", typeof(GLNativeDelegate.FNglGenProgramsNV));
            yield return new ProcInfo("glGetProgramParameterdvNV", typeof(GLNativeDelegate.FNglGetProgramParameterdvNV));
            yield return new ProcInfo("glGetProgramParameterfvNV", typeof(GLNativeDelegate.FNglGetProgramParameterfvNV));
            yield return new ProcInfo("glGetProgramivNV", typeof(GLNativeDelegate.FNglGetProgramivNV));
            yield return new ProcInfo("glGetProgramStringNV", typeof(GLNativeDelegate.FNglGetProgramStringNV));
            yield return new ProcInfo("glGetTrackMatrixivNV", typeof(GLNativeDelegate.FNglGetTrackMatrixivNV));
            yield return new ProcInfo("glGetVertexAttribdvNV", typeof(GLNativeDelegate.FNglGetVertexAttribdvNV));
            yield return new ProcInfo("glGetVertexAttribfvNV", typeof(GLNativeDelegate.FNglGetVertexAttribfvNV));
            yield return new ProcInfo("glGetVertexAttribivNV", typeof(GLNativeDelegate.FNglGetVertexAttribivNV));
            yield return new ProcInfo("glGetVertexAttribPointervNV", typeof(GLNativeDelegate.FNglGetVertexAttribPointervNV));
            yield return new ProcInfo("glIsProgramNV", typeof(GLNativeDelegate.FNglIsProgramNV));
            yield return new ProcInfo("glLoadProgramNV", typeof(GLNativeDelegate.FNglLoadProgramNV));
            yield return new ProcInfo("glProgramParameter4dNV", typeof(GLNativeDelegate.FNglProgramParameter4dNV));
            yield return new ProcInfo("glProgramParameter4dvNV", typeof(GLNativeDelegate.FNglProgramParameter4dvNV));
            yield return new ProcInfo("glProgramParameter4fNV", typeof(GLNativeDelegate.FNglProgramParameter4fNV));
            yield return new ProcInfo("glProgramParameter4fvNV", typeof(GLNativeDelegate.FNglProgramParameter4fvNV));
            yield return new ProcInfo("glProgramParameters4dvNV", typeof(GLNativeDelegate.FNglProgramParameters4dvNV));
            yield return new ProcInfo("glProgramParameters4fvNV", typeof(GLNativeDelegate.FNglProgramParameters4fvNV));
            yield return new ProcInfo("glRequestResidentProgramsNV", typeof(GLNativeDelegate.FNglRequestResidentProgramsNV));
            yield return new ProcInfo("glTrackMatrixNV", typeof(GLNativeDelegate.FNglTrackMatrixNV));
            yield return new ProcInfo("glVertexAttribPointerNV", typeof(GLNativeDelegate.FNglVertexAttribPointerNV));
            yield return new ProcInfo("glVertexAttrib1dNV", typeof(GLNativeDelegate.FNglVertexAttrib1dNV));
            yield return new ProcInfo("glVertexAttrib1dvNV", typeof(GLNativeDelegate.FNglVertexAttrib1dvNV));
            yield return new ProcInfo("glVertexAttrib1fNV", typeof(GLNativeDelegate.FNglVertexAttrib1fNV));
            yield return new ProcInfo("glVertexAttrib1fvNV", typeof(GLNativeDelegate.FNglVertexAttrib1fvNV));
            yield return new ProcInfo("glVertexAttrib1sNV", typeof(GLNativeDelegate.FNglVertexAttrib1sNV));
            yield return new ProcInfo("glVertexAttrib1svNV", typeof(GLNativeDelegate.FNglVertexAttrib1svNV));
            yield return new ProcInfo("glVertexAttrib2dNV", typeof(GLNativeDelegate.FNglVertexAttrib2dNV));
            yield return new ProcInfo("glVertexAttrib2dvNV", typeof(GLNativeDelegate.FNglVertexAttrib2dvNV));
            yield return new ProcInfo("glVertexAttrib2fNV", typeof(GLNativeDelegate.FNglVertexAttrib2fNV));
            yield return new ProcInfo("glVertexAttrib2fvNV", typeof(GLNativeDelegate.FNglVertexAttrib2fvNV));
            yield return new ProcInfo("glVertexAttrib2sNV", typeof(GLNativeDelegate.FNglVertexAttrib2sNV));
            yield return new ProcInfo("glVertexAttrib2svNV", typeof(GLNativeDelegate.FNglVertexAttrib2svNV));
            yield return new ProcInfo("glVertexAttrib3dNV", typeof(GLNativeDelegate.FNglVertexAttrib3dNV));
            yield return new ProcInfo("glVertexAttrib3dvNV", typeof(GLNativeDelegate.FNglVertexAttrib3dvNV));
            yield return new ProcInfo("glVertexAttrib3fNV", typeof(GLNativeDelegate.FNglVertexAttrib3fNV));
            yield return new ProcInfo("glVertexAttrib3fvNV", typeof(GLNativeDelegate.FNglVertexAttrib3fvNV));
            yield return new ProcInfo("glVertexAttrib3sNV", typeof(GLNativeDelegate.FNglVertexAttrib3sNV));
            yield return new ProcInfo("glVertexAttrib3svNV", typeof(GLNativeDelegate.FNglVertexAttrib3svNV));
            yield return new ProcInfo("glVertexAttrib4dNV", typeof(GLNativeDelegate.FNglVertexAttrib4dNV));
            yield return new ProcInfo("glVertexAttrib4dvNV", typeof(GLNativeDelegate.FNglVertexAttrib4dvNV));
            yield return new ProcInfo("glVertexAttrib4fNV", typeof(GLNativeDelegate.FNglVertexAttrib4fNV));
            yield return new ProcInfo("glVertexAttrib4fvNV", typeof(GLNativeDelegate.FNglVertexAttrib4fvNV));
            yield return new ProcInfo("glVertexAttrib4sNV", typeof(GLNativeDelegate.FNglVertexAttrib4sNV));
            yield return new ProcInfo("glVertexAttrib4svNV", typeof(GLNativeDelegate.FNglVertexAttrib4svNV));
            yield return new ProcInfo("glVertexAttrib4ubNV", typeof(GLNativeDelegate.FNglVertexAttrib4ubNV));
            yield return new ProcInfo("glVertexAttrib4ubvNV", typeof(GLNativeDelegate.FNglVertexAttrib4ubvNV));
            yield return new ProcInfo("glVertexAttribs1dvNV", typeof(GLNativeDelegate.FNglVertexAttribs1dvNV));
            yield return new ProcInfo("glVertexAttribs1fvNV", typeof(GLNativeDelegate.FNglVertexAttribs1fvNV));
            yield return new ProcInfo("glVertexAttribs1svNV", typeof(GLNativeDelegate.FNglVertexAttribs1svNV));
            yield return new ProcInfo("glVertexAttribs2dvNV", typeof(GLNativeDelegate.FNglVertexAttribs2dvNV));
            yield return new ProcInfo("glVertexAttribs2fvNV", typeof(GLNativeDelegate.FNglVertexAttribs2fvNV));
            yield return new ProcInfo("glVertexAttribs2svNV", typeof(GLNativeDelegate.FNglVertexAttribs2svNV));
            yield return new ProcInfo("glVertexAttribs3dvNV", typeof(GLNativeDelegate.FNglVertexAttribs3dvNV));
            yield return new ProcInfo("glVertexAttribs3fvNV", typeof(GLNativeDelegate.FNglVertexAttribs3fvNV));
            yield return new ProcInfo("glVertexAttribs3svNV", typeof(GLNativeDelegate.FNglVertexAttribs3svNV));
            yield return new ProcInfo("glVertexAttribs4dvNV", typeof(GLNativeDelegate.FNglVertexAttribs4dvNV));
            yield return new ProcInfo("glVertexAttribs4fvNV", typeof(GLNativeDelegate.FNglVertexAttribs4fvNV));
            yield return new ProcInfo("glVertexAttribs4svNV", typeof(GLNativeDelegate.FNglVertexAttribs4svNV));
            yield return new ProcInfo("glVertexAttribs4ubvNV", typeof(GLNativeDelegate.FNglVertexAttribs4ubvNV));

            #endregion GL_NV_vertex_program

            #region GL_NV_vertex_program4

            // yield return new ProcInfo("glVertexAttribI1iEXT", typeof(GLNativeDelegate.FNglVertexAttribI1iEXT));
            // yield return new ProcInfo("glVertexAttribI2iEXT", typeof(GLNativeDelegate.FNglVertexAttribI2iEXT));
            // yield return new ProcInfo("glVertexAttribI3iEXT", typeof(GLNativeDelegate.FNglVertexAttribI3iEXT));
            // yield return new ProcInfo("glVertexAttribI4iEXT", typeof(GLNativeDelegate.FNglVertexAttribI4iEXT));
            // yield return new ProcInfo("glVertexAttribI1uiEXT", typeof(GLNativeDelegate.FNglVertexAttribI1uiEXT));
            // yield return new ProcInfo("glVertexAttribI2uiEXT", typeof(GLNativeDelegate.FNglVertexAttribI2uiEXT));
            // yield return new ProcInfo("glVertexAttribI3uiEXT", typeof(GLNativeDelegate.FNglVertexAttribI3uiEXT));
            // yield return new ProcInfo("glVertexAttribI4uiEXT", typeof(GLNativeDelegate.FNglVertexAttribI4uiEXT));
            // yield return new ProcInfo("glVertexAttribI1ivEXT", typeof(GLNativeDelegate.FNglVertexAttribI1ivEXT));
            // yield return new ProcInfo("glVertexAttribI2ivEXT", typeof(GLNativeDelegate.FNglVertexAttribI2ivEXT));
            // yield return new ProcInfo("glVertexAttribI3ivEXT", typeof(GLNativeDelegate.FNglVertexAttribI3ivEXT));
            // yield return new ProcInfo("glVertexAttribI4ivEXT", typeof(GLNativeDelegate.FNglVertexAttribI4ivEXT));
            // yield return new ProcInfo("glVertexAttribI1uivEXT", typeof(GLNativeDelegate.FNglVertexAttribI1uivEXT));
            // yield return new ProcInfo("glVertexAttribI2uivEXT", typeof(GLNativeDelegate.FNglVertexAttribI2uivEXT));
            // yield return new ProcInfo("glVertexAttribI3uivEXT", typeof(GLNativeDelegate.FNglVertexAttribI3uivEXT));
            // yield return new ProcInfo("glVertexAttribI4uivEXT", typeof(GLNativeDelegate.FNglVertexAttribI4uivEXT));
            // yield return new ProcInfo("glVertexAttribI4bvEXT", typeof(GLNativeDelegate.FNglVertexAttribI4bvEXT));
            // yield return new ProcInfo("glVertexAttribI4svEXT", typeof(GLNativeDelegate.FNglVertexAttribI4svEXT));
            // yield return new ProcInfo("glVertexAttribI4ubvEXT", typeof(GLNativeDelegate.FNglVertexAttribI4ubvEXT));
            // yield return new ProcInfo("glVertexAttribI4usvEXT", typeof(GLNativeDelegate.FNglVertexAttribI4usvEXT));
            // yield return new ProcInfo("glVertexAttribIPointerEXT", typeof(GLNativeDelegate.FNglVertexAttribIPointerEXT));
            // yield return new ProcInfo("glGetVertexAttribIivEXT", typeof(GLNativeDelegate.FNglGetVertexAttribIivEXT));
            // yield return new ProcInfo("glGetVertexAttribIuivEXT", typeof(GLNativeDelegate.FNglGetVertexAttribIuivEXT));

            #endregion GL_NV_vertex_program4

            #region GL_NV_video_capture

            yield return new ProcInfo("glBeginVideoCaptureNV", typeof(GLNativeDelegate.FNglBeginVideoCaptureNV));
            yield return new ProcInfo("glBindVideoCaptureStreamBufferNV", typeof(GLNativeDelegate.FNglBindVideoCaptureStreamBufferNV));
            yield return new ProcInfo("glBindVideoCaptureStreamTextureNV", typeof(GLNativeDelegate.FNglBindVideoCaptureStreamTextureNV));
            yield return new ProcInfo("glEndVideoCaptureNV", typeof(GLNativeDelegate.FNglEndVideoCaptureNV));
            yield return new ProcInfo("glGetVideoCaptureivNV", typeof(GLNativeDelegate.FNglGetVideoCaptureivNV));
            yield return new ProcInfo("glGetVideoCaptureStreamivNV", typeof(GLNativeDelegate.FNglGetVideoCaptureStreamivNV));
            yield return new ProcInfo("glGetVideoCaptureStreamfvNV", typeof(GLNativeDelegate.FNglGetVideoCaptureStreamfvNV));
            yield return new ProcInfo("glGetVideoCaptureStreamdvNV", typeof(GLNativeDelegate.FNglGetVideoCaptureStreamdvNV));
            yield return new ProcInfo("glVideoCaptureNV", typeof(GLNativeDelegate.FNglVideoCaptureNV));
            yield return new ProcInfo("glVideoCaptureStreamParameterivNV", typeof(GLNativeDelegate.FNglVideoCaptureStreamParameterivNV));
            yield return new ProcInfo("glVideoCaptureStreamParameterfvNV", typeof(GLNativeDelegate.FNglVideoCaptureStreamParameterfvNV));
            yield return new ProcInfo("glVideoCaptureStreamParameterdvNV", typeof(GLNativeDelegate.FNglVideoCaptureStreamParameterdvNV));

            #endregion GL_NV_video_capture

            #region GL_NV_viewport_swizzle

            yield return new ProcInfo("glViewportSwizzleNV", typeof(GLNativeDelegate.FNglViewportSwizzleNV));

            #endregion GL_NV_viewport_swizzle

            #region GL_OES_fixed_point

            yield return new ProcInfo("glAlphaFuncxOES", typeof(GLNativeDelegate.FNglAlphaFuncxOES));
            yield return new ProcInfo("glClearColorxOES", typeof(GLNativeDelegate.FNglClearColorxOES));
            yield return new ProcInfo("glClearDepthxOES", typeof(GLNativeDelegate.FNglClearDepthxOES));
            yield return new ProcInfo("glClipPlanexOES", typeof(GLNativeDelegate.FNglClipPlanexOES));
            yield return new ProcInfo("glColor4xOES", typeof(GLNativeDelegate.FNglColor4xOES));
            yield return new ProcInfo("glDepthRangexOES", typeof(GLNativeDelegate.FNglDepthRangexOES));
            yield return new ProcInfo("glFogxOES", typeof(GLNativeDelegate.FNglFogxOES));
            yield return new ProcInfo("glFogxvOES", typeof(GLNativeDelegate.FNglFogxvOES));
            yield return new ProcInfo("glFrustumxOES", typeof(GLNativeDelegate.FNglFrustumxOES));
            yield return new ProcInfo("glGetClipPlanexOES", typeof(GLNativeDelegate.FNglGetClipPlanexOES));
            yield return new ProcInfo("glGetFixedvOES", typeof(GLNativeDelegate.FNglGetFixedvOES));
            yield return new ProcInfo("glGetTexEnvxvOES", typeof(GLNativeDelegate.FNglGetTexEnvxvOES));
            yield return new ProcInfo("glGetTexParameterxvOES", typeof(GLNativeDelegate.FNglGetTexParameterxvOES));
            yield return new ProcInfo("glLightModelxOES", typeof(GLNativeDelegate.FNglLightModelxOES));
            yield return new ProcInfo("glLightModelxvOES", typeof(GLNativeDelegate.FNglLightModelxvOES));
            yield return new ProcInfo("glLightxOES", typeof(GLNativeDelegate.FNglLightxOES));
            yield return new ProcInfo("glLightxvOES", typeof(GLNativeDelegate.FNglLightxvOES));
            yield return new ProcInfo("glLineWidthxOES", typeof(GLNativeDelegate.FNglLineWidthxOES));
            yield return new ProcInfo("glLoadMatrixxOES", typeof(GLNativeDelegate.FNglLoadMatrixxOES));
            yield return new ProcInfo("glMaterialxOES", typeof(GLNativeDelegate.FNglMaterialxOES));
            yield return new ProcInfo("glMaterialxvOES", typeof(GLNativeDelegate.FNglMaterialxvOES));
            yield return new ProcInfo("glMultMatrixxOES", typeof(GLNativeDelegate.FNglMultMatrixxOES));
            yield return new ProcInfo("glMultiTexCoord4xOES", typeof(GLNativeDelegate.FNglMultiTexCoord4xOES));
            yield return new ProcInfo("glNormal3xOES", typeof(GLNativeDelegate.FNglNormal3xOES));
            yield return new ProcInfo("glOrthoxOES", typeof(GLNativeDelegate.FNglOrthoxOES));
            yield return new ProcInfo("glPointParameterxvOES", typeof(GLNativeDelegate.FNglPointParameterxvOES));
            yield return new ProcInfo("glPointSizexOES", typeof(GLNativeDelegate.FNglPointSizexOES));
            yield return new ProcInfo("glPolygonOffsetxOES", typeof(GLNativeDelegate.FNglPolygonOffsetxOES));
            yield return new ProcInfo("glRotatexOES", typeof(GLNativeDelegate.FNglRotatexOES));
            yield return new ProcInfo("glScalexOES", typeof(GLNativeDelegate.FNglScalexOES));
            yield return new ProcInfo("glTexEnvxOES", typeof(GLNativeDelegate.FNglTexEnvxOES));
            yield return new ProcInfo("glTexEnvxvOES", typeof(GLNativeDelegate.FNglTexEnvxvOES));
            yield return new ProcInfo("glTexParameterxOES", typeof(GLNativeDelegate.FNglTexParameterxOES));
            yield return new ProcInfo("glTexParameterxvOES", typeof(GLNativeDelegate.FNglTexParameterxvOES));
            yield return new ProcInfo("glTranslatexOES", typeof(GLNativeDelegate.FNglTranslatexOES));
            yield return new ProcInfo("glGetLightxvOES", typeof(GLNativeDelegate.FNglGetLightxvOES));
            yield return new ProcInfo("glGetMaterialxvOES", typeof(GLNativeDelegate.FNglGetMaterialxvOES));
            yield return new ProcInfo("glPointParameterxOES", typeof(GLNativeDelegate.FNglPointParameterxOES));
            yield return new ProcInfo("glSampleCoveragexOES", typeof(GLNativeDelegate.FNglSampleCoveragexOES));
            yield return new ProcInfo("glAccumxOES", typeof(GLNativeDelegate.FNglAccumxOES));
            yield return new ProcInfo("glBitmapxOES", typeof(GLNativeDelegate.FNglBitmapxOES));
            yield return new ProcInfo("glBlendColorxOES", typeof(GLNativeDelegate.FNglBlendColorxOES));
            yield return new ProcInfo("glClearAccumxOES", typeof(GLNativeDelegate.FNglClearAccumxOES));
            yield return new ProcInfo("glColor3xOES", typeof(GLNativeDelegate.FNglColor3xOES));
            yield return new ProcInfo("glColor3xvOES", typeof(GLNativeDelegate.FNglColor3xvOES));
            yield return new ProcInfo("glColor4xvOES", typeof(GLNativeDelegate.FNglColor4xvOES));
            yield return new ProcInfo("glConvolutionParameterxOES", typeof(GLNativeDelegate.FNglConvolutionParameterxOES));
            yield return new ProcInfo("glConvolutionParameterxvOES", typeof(GLNativeDelegate.FNglConvolutionParameterxvOES));
            yield return new ProcInfo("glEvalCoord1xOES", typeof(GLNativeDelegate.FNglEvalCoord1xOES));
            yield return new ProcInfo("glEvalCoord1xvOES", typeof(GLNativeDelegate.FNglEvalCoord1xvOES));
            yield return new ProcInfo("glEvalCoord2xOES", typeof(GLNativeDelegate.FNglEvalCoord2xOES));
            yield return new ProcInfo("glEvalCoord2xvOES", typeof(GLNativeDelegate.FNglEvalCoord2xvOES));
            yield return new ProcInfo("glFeedbackBufferxOES", typeof(GLNativeDelegate.FNglFeedbackBufferxOES));
            yield return new ProcInfo("glGetConvolutionParameterxvOES", typeof(GLNativeDelegate.FNglGetConvolutionParameterxvOES));
            yield return new ProcInfo("glGetHistogramParameterxvOES", typeof(GLNativeDelegate.FNglGetHistogramParameterxvOES));
            yield return new ProcInfo("glGetLightxOES", typeof(GLNativeDelegate.FNglGetLightxOES));
            yield return new ProcInfo("glGetMapxvOES", typeof(GLNativeDelegate.FNglGetMapxvOES));
            yield return new ProcInfo("glGetMaterialxOES", typeof(GLNativeDelegate.FNglGetMaterialxOES));
            yield return new ProcInfo("glGetPixelMapxv", typeof(GLNativeDelegate.FNglGetPixelMapxv));
            yield return new ProcInfo("glGetTexGenxvOES", typeof(GLNativeDelegate.FNglGetTexGenxvOES));
            yield return new ProcInfo("glGetTexLevelParameterxvOES", typeof(GLNativeDelegate.FNglGetTexLevelParameterxvOES));
            yield return new ProcInfo("glIndexxOES", typeof(GLNativeDelegate.FNglIndexxOES));
            yield return new ProcInfo("glIndexxvOES", typeof(GLNativeDelegate.FNglIndexxvOES));
            yield return new ProcInfo("glLoadTransposeMatrixxOES", typeof(GLNativeDelegate.FNglLoadTransposeMatrixxOES));
            yield return new ProcInfo("glMap1xOES", typeof(GLNativeDelegate.FNglMap1xOES));
            yield return new ProcInfo("glMap2xOES", typeof(GLNativeDelegate.FNglMap2xOES));
            yield return new ProcInfo("glMapGrid1xOES", typeof(GLNativeDelegate.FNglMapGrid1xOES));
            yield return new ProcInfo("glMapGrid2xOES", typeof(GLNativeDelegate.FNglMapGrid2xOES));
            yield return new ProcInfo("glMultTransposeMatrixxOES", typeof(GLNativeDelegate.FNglMultTransposeMatrixxOES));
            yield return new ProcInfo("glMultiTexCoord1xOES", typeof(GLNativeDelegate.FNglMultiTexCoord1xOES));
            yield return new ProcInfo("glMultiTexCoord1xvOES", typeof(GLNativeDelegate.FNglMultiTexCoord1xvOES));
            yield return new ProcInfo("glMultiTexCoord2xOES", typeof(GLNativeDelegate.FNglMultiTexCoord2xOES));
            yield return new ProcInfo("glMultiTexCoord2xvOES", typeof(GLNativeDelegate.FNglMultiTexCoord2xvOES));
            yield return new ProcInfo("glMultiTexCoord3xOES", typeof(GLNativeDelegate.FNglMultiTexCoord3xOES));
            yield return new ProcInfo("glMultiTexCoord3xvOES", typeof(GLNativeDelegate.FNglMultiTexCoord3xvOES));
            yield return new ProcInfo("glMultiTexCoord4xvOES", typeof(GLNativeDelegate.FNglMultiTexCoord4xvOES));
            yield return new ProcInfo("glNormal3xvOES", typeof(GLNativeDelegate.FNglNormal3xvOES));
            yield return new ProcInfo("glPassThroughxOES", typeof(GLNativeDelegate.FNglPassThroughxOES));
            yield return new ProcInfo("glPixelMapx", typeof(GLNativeDelegate.FNglPixelMapx));
            yield return new ProcInfo("glPixelStorex", typeof(GLNativeDelegate.FNglPixelStorex));
            yield return new ProcInfo("glPixelTransferxOES", typeof(GLNativeDelegate.FNglPixelTransferxOES));
            yield return new ProcInfo("glPixelZoomxOES", typeof(GLNativeDelegate.FNglPixelZoomxOES));
            yield return new ProcInfo("glPrioritizeTexturesxOES", typeof(GLNativeDelegate.FNglPrioritizeTexturesxOES));
            yield return new ProcInfo("glRasterPos2xOES", typeof(GLNativeDelegate.FNglRasterPos2xOES));
            yield return new ProcInfo("glRasterPos2xvOES", typeof(GLNativeDelegate.FNglRasterPos2xvOES));
            yield return new ProcInfo("glRasterPos3xOES", typeof(GLNativeDelegate.FNglRasterPos3xOES));
            yield return new ProcInfo("glRasterPos3xvOES", typeof(GLNativeDelegate.FNglRasterPos3xvOES));
            yield return new ProcInfo("glRasterPos4xOES", typeof(GLNativeDelegate.FNglRasterPos4xOES));
            yield return new ProcInfo("glRasterPos4xvOES", typeof(GLNativeDelegate.FNglRasterPos4xvOES));
            yield return new ProcInfo("glRectxOES", typeof(GLNativeDelegate.FNglRectxOES));
            yield return new ProcInfo("glRectxvOES", typeof(GLNativeDelegate.FNglRectxvOES));
            yield return new ProcInfo("glTexCoord1xOES", typeof(GLNativeDelegate.FNglTexCoord1xOES));
            yield return new ProcInfo("glTexCoord1xvOES", typeof(GLNativeDelegate.FNglTexCoord1xvOES));
            yield return new ProcInfo("glTexCoord2xOES", typeof(GLNativeDelegate.FNglTexCoord2xOES));
            yield return new ProcInfo("glTexCoord2xvOES", typeof(GLNativeDelegate.FNglTexCoord2xvOES));
            yield return new ProcInfo("glTexCoord3xOES", typeof(GLNativeDelegate.FNglTexCoord3xOES));
            yield return new ProcInfo("glTexCoord3xvOES", typeof(GLNativeDelegate.FNglTexCoord3xvOES));
            yield return new ProcInfo("glTexCoord4xOES", typeof(GLNativeDelegate.FNglTexCoord4xOES));
            yield return new ProcInfo("glTexCoord4xvOES", typeof(GLNativeDelegate.FNglTexCoord4xvOES));
            yield return new ProcInfo("glTexGenxOES", typeof(GLNativeDelegate.FNglTexGenxOES));
            yield return new ProcInfo("glTexGenxvOES", typeof(GLNativeDelegate.FNglTexGenxvOES));
            yield return new ProcInfo("glVertex2xOES", typeof(GLNativeDelegate.FNglVertex2xOES));
            yield return new ProcInfo("glVertex2xvOES", typeof(GLNativeDelegate.FNglVertex2xvOES));
            yield return new ProcInfo("glVertex3xOES", typeof(GLNativeDelegate.FNglVertex3xOES));
            yield return new ProcInfo("glVertex3xvOES", typeof(GLNativeDelegate.FNglVertex3xvOES));
            yield return new ProcInfo("glVertex4xOES", typeof(GLNativeDelegate.FNglVertex4xOES));
            yield return new ProcInfo("glVertex4xvOES", typeof(GLNativeDelegate.FNglVertex4xvOES));

            #endregion GL_OES_fixed_point

            #region GL_OES_query_matrix

            yield return new ProcInfo("glQueryMatrixxOES", typeof(GLNativeDelegate.FNglQueryMatrixxOES));

            #endregion GL_OES_query_matrix

            #region GL_OES_single_precision

            yield return new ProcInfo("glClearDepthfOES", typeof(GLNativeDelegate.FNglClearDepthfOES));
            yield return new ProcInfo("glClipPlanefOES", typeof(GLNativeDelegate.FNglClipPlanefOES));
            yield return new ProcInfo("glDepthRangefOES", typeof(GLNativeDelegate.FNglDepthRangefOES));
            yield return new ProcInfo("glFrustumfOES", typeof(GLNativeDelegate.FNglFrustumfOES));
            yield return new ProcInfo("glGetClipPlanefOES", typeof(GLNativeDelegate.FNglGetClipPlanefOES));
            yield return new ProcInfo("glOrthofOES", typeof(GLNativeDelegate.FNglOrthofOES));

            #endregion GL_OES_single_precision

            #region GL_OVR_multiview

            yield return new ProcInfo("glFramebufferTextureMultiviewOVR", typeof(GLNativeDelegate.FNglFramebufferTextureMultiviewOVR));

            #endregion GL_OVR_multiview

            #region GL_PGI_misc_hints

            yield return new ProcInfo("glHintPGI", typeof(GLNativeDelegate.FNglHintPGI));

            #endregion GL_PGI_misc_hints

            #region GL_SGIS_detail_texture

            yield return new ProcInfo("glDetailTexFuncSGIS", typeof(GLNativeDelegate.FNglDetailTexFuncSGIS));
            yield return new ProcInfo("glGetDetailTexFuncSGIS", typeof(GLNativeDelegate.FNglGetDetailTexFuncSGIS));

            #endregion GL_SGIS_detail_texture

            #region GL_SGIS_fog_function

            yield return new ProcInfo("glFogFuncSGIS", typeof(GLNativeDelegate.FNglFogFuncSGIS));
            yield return new ProcInfo("glGetFogFuncSGIS", typeof(GLNativeDelegate.FNglGetFogFuncSGIS));

            #endregion GL_SGIS_fog_function

            #region GL_SGIS_multisample

            yield return new ProcInfo("glSampleMaskSGIS", typeof(GLNativeDelegate.FNglSampleMaskSGIS));
            yield return new ProcInfo("glSamplePatternSGIS", typeof(GLNativeDelegate.FNglSamplePatternSGIS));

            #endregion GL_SGIS_multisample

            #region GL_SGIS_pixel_texture

            yield return new ProcInfo("glPixelTexGenParameteriSGIS", typeof(GLNativeDelegate.FNglPixelTexGenParameteriSGIS));
            yield return new ProcInfo("glPixelTexGenParameterivSGIS", typeof(GLNativeDelegate.FNglPixelTexGenParameterivSGIS));
            yield return new ProcInfo("glPixelTexGenParameterfSGIS", typeof(GLNativeDelegate.FNglPixelTexGenParameterfSGIS));
            yield return new ProcInfo("glPixelTexGenParameterfvSGIS", typeof(GLNativeDelegate.FNglPixelTexGenParameterfvSGIS));
            yield return new ProcInfo("glGetPixelTexGenParameterivSGIS", typeof(GLNativeDelegate.FNglGetPixelTexGenParameterivSGIS));
            yield return new ProcInfo("glGetPixelTexGenParameterfvSGIS", typeof(GLNativeDelegate.FNglGetPixelTexGenParameterfvSGIS));

            #endregion GL_SGIS_pixel_texture

            #region GL_SGIS_point_parameters

            yield return new ProcInfo("glPointParameterfSGIS", typeof(GLNativeDelegate.FNglPointParameterfSGIS));
            yield return new ProcInfo("glPointParameterfvSGIS", typeof(GLNativeDelegate.FNglPointParameterfvSGIS));

            #endregion GL_SGIS_point_parameters

            #region GL_SGIS_sharpen_texture

            yield return new ProcInfo("glSharpenTexFuncSGIS", typeof(GLNativeDelegate.FNglSharpenTexFuncSGIS));
            yield return new ProcInfo("glGetSharpenTexFuncSGIS", typeof(GLNativeDelegate.FNglGetSharpenTexFuncSGIS));

            #endregion GL_SGIS_sharpen_texture

            #region GL_SGIS_texture4D

            yield return new ProcInfo("glTexImage4DSGIS", typeof(GLNativeDelegate.FNglTexImage4DSGIS));
            yield return new ProcInfo("glTexSubImage4DSGIS", typeof(GLNativeDelegate.FNglTexSubImage4DSGIS));

            #endregion GL_SGIS_texture4D

            #region GL_SGIS_texture_color_mask

            yield return new ProcInfo("glTextureColorMaskSGIS", typeof(GLNativeDelegate.FNglTextureColorMaskSGIS));

            #endregion GL_SGIS_texture_color_mask

            #region GL_SGIS_texture_filter4

            yield return new ProcInfo("glGetTexFilterFuncSGIS", typeof(GLNativeDelegate.FNglGetTexFilterFuncSGIS));
            yield return new ProcInfo("glTexFilterFuncSGIS", typeof(GLNativeDelegate.FNglTexFilterFuncSGIS));

            #endregion GL_SGIS_texture_filter4

            #region GL_SGIX_async

            yield return new ProcInfo("glAsyncMarkerSGIX", typeof(GLNativeDelegate.FNglAsyncMarkerSGIX));
            yield return new ProcInfo("glFinishAsyncSGIX", typeof(GLNativeDelegate.FNglFinishAsyncSGIX));
            yield return new ProcInfo("glPollAsyncSGIX", typeof(GLNativeDelegate.FNglPollAsyncSGIX));
            yield return new ProcInfo("glGenAsyncMarkersSGIX", typeof(GLNativeDelegate.FNglGenAsyncMarkersSGIX));
            yield return new ProcInfo("glDeleteAsyncMarkersSGIX", typeof(GLNativeDelegate.FNglDeleteAsyncMarkersSGIX));
            yield return new ProcInfo("glIsAsyncMarkerSGIX", typeof(GLNativeDelegate.FNglIsAsyncMarkerSGIX));

            #endregion GL_SGIX_async

            #region GL_SGIX_flush_raster

            yield return new ProcInfo("glFlushRasterSGIX", typeof(GLNativeDelegate.FNglFlushRasterSGIX));

            #endregion GL_SGIX_flush_raster

            #region GL_SGIX_fragment_lighting

            yield return new ProcInfo("glFragmentColorMaterialSGIX", typeof(GLNativeDelegate.FNglFragmentColorMaterialSGIX));
            yield return new ProcInfo("glFragmentLightfSGIX", typeof(GLNativeDelegate.FNglFragmentLightfSGIX));
            yield return new ProcInfo("glFragmentLightfvSGIX", typeof(GLNativeDelegate.FNglFragmentLightfvSGIX));
            yield return new ProcInfo("glFragmentLightiSGIX", typeof(GLNativeDelegate.FNglFragmentLightiSGIX));
            yield return new ProcInfo("glFragmentLightivSGIX", typeof(GLNativeDelegate.FNglFragmentLightivSGIX));
            yield return new ProcInfo("glFragmentLightModelfSGIX", typeof(GLNativeDelegate.FNglFragmentLightModelfSGIX));
            yield return new ProcInfo("glFragmentLightModelfvSGIX", typeof(GLNativeDelegate.FNglFragmentLightModelfvSGIX));
            yield return new ProcInfo("glFragmentLightModeliSGIX", typeof(GLNativeDelegate.FNglFragmentLightModeliSGIX));
            yield return new ProcInfo("glFragmentLightModelivSGIX", typeof(GLNativeDelegate.FNglFragmentLightModelivSGIX));
            yield return new ProcInfo("glFragmentMaterialfSGIX", typeof(GLNativeDelegate.FNglFragmentMaterialfSGIX));
            yield return new ProcInfo("glFragmentMaterialfvSGIX", typeof(GLNativeDelegate.FNglFragmentMaterialfvSGIX));
            yield return new ProcInfo("glFragmentMaterialiSGIX", typeof(GLNativeDelegate.FNglFragmentMaterialiSGIX));
            yield return new ProcInfo("glFragmentMaterialivSGIX", typeof(GLNativeDelegate.FNglFragmentMaterialivSGIX));
            yield return new ProcInfo("glGetFragmentLightfvSGIX", typeof(GLNativeDelegate.FNglGetFragmentLightfvSGIX));
            yield return new ProcInfo("glGetFragmentLightivSGIX", typeof(GLNativeDelegate.FNglGetFragmentLightivSGIX));
            yield return new ProcInfo("glGetFragmentMaterialfvSGIX", typeof(GLNativeDelegate.FNglGetFragmentMaterialfvSGIX));
            yield return new ProcInfo("glGetFragmentMaterialivSGIX", typeof(GLNativeDelegate.FNglGetFragmentMaterialivSGIX));
            yield return new ProcInfo("glLightEnviSGIX", typeof(GLNativeDelegate.FNglLightEnviSGIX));

            #endregion GL_SGIX_fragment_lighting

            #region GL_SGIX_framezoom

            yield return new ProcInfo("glFrameZoomSGIX", typeof(GLNativeDelegate.FNglFrameZoomSGIX));

            #endregion GL_SGIX_framezoom

            #region GL_SGIX_igloo_interface

            yield return new ProcInfo("glIglooInterfaceSGIX", typeof(GLNativeDelegate.FNglIglooInterfaceSGIX));

            #endregion GL_SGIX_igloo_interface

            #region GL_SGIX_instruments

            yield return new ProcInfo("glGetInstrumentsSGIX", typeof(GLNativeDelegate.FNglGetInstrumentsSGIX));
            yield return new ProcInfo("glInstrumentsBufferSGIX", typeof(GLNativeDelegate.FNglInstrumentsBufferSGIX));
            yield return new ProcInfo("glPollInstrumentsSGIX", typeof(GLNativeDelegate.FNglPollInstrumentsSGIX));
            yield return new ProcInfo("glReadInstrumentsSGIX", typeof(GLNativeDelegate.FNglReadInstrumentsSGIX));
            yield return new ProcInfo("glStartInstrumentsSGIX", typeof(GLNativeDelegate.FNglStartInstrumentsSGIX));
            yield return new ProcInfo("glStopInstrumentsSGIX", typeof(GLNativeDelegate.FNglStopInstrumentsSGIX));

            #endregion GL_SGIX_instruments

            #region GL_SGIX_list_priority

            yield return new ProcInfo("glGetListParameterfvSGIX", typeof(GLNativeDelegate.FNglGetListParameterfvSGIX));
            yield return new ProcInfo("glGetListParameterivSGIX", typeof(GLNativeDelegate.FNglGetListParameterivSGIX));
            yield return new ProcInfo("glListParameterfSGIX", typeof(GLNativeDelegate.FNglListParameterfSGIX));
            yield return new ProcInfo("glListParameterfvSGIX", typeof(GLNativeDelegate.FNglListParameterfvSGIX));
            yield return new ProcInfo("glListParameteriSGIX", typeof(GLNativeDelegate.FNglListParameteriSGIX));
            yield return new ProcInfo("glListParameterivSGIX", typeof(GLNativeDelegate.FNglListParameterivSGIX));

            #endregion GL_SGIX_list_priority

            #region GL_SGIX_pixel_texture

            yield return new ProcInfo("glPixelTexGenSGIX", typeof(GLNativeDelegate.FNglPixelTexGenSGIX));

            #endregion GL_SGIX_pixel_texture

            #region GL_SGIX_polynomial_ffd

            yield return new ProcInfo("glDeformationMap3dSGIX", typeof(GLNativeDelegate.FNglDeformationMap3dSGIX));
            yield return new ProcInfo("glDeformationMap3fSGIX", typeof(GLNativeDelegate.FNglDeformationMap3fSGIX));
            yield return new ProcInfo("glDeformSGIX", typeof(GLNativeDelegate.FNglDeformSGIX));
            yield return new ProcInfo("glLoadIdentityDeformationMapSGIX", typeof(GLNativeDelegate.FNglLoadIdentityDeformationMapSGIX));

            #endregion GL_SGIX_polynomial_ffd

            #region GL_SGIX_reference_plane

            yield return new ProcInfo("glReferencePlaneSGIX", typeof(GLNativeDelegate.FNglReferencePlaneSGIX));

            #endregion GL_SGIX_reference_plane

            #region GL_SGIX_sprite

            yield return new ProcInfo("glSpriteParameterfSGIX", typeof(GLNativeDelegate.FNglSpriteParameterfSGIX));
            yield return new ProcInfo("glSpriteParameterfvSGIX", typeof(GLNativeDelegate.FNglSpriteParameterfvSGIX));
            yield return new ProcInfo("glSpriteParameteriSGIX", typeof(GLNativeDelegate.FNglSpriteParameteriSGIX));
            yield return new ProcInfo("glSpriteParameterivSGIX", typeof(GLNativeDelegate.FNglSpriteParameterivSGIX));

            #endregion GL_SGIX_sprite

            #region GL_SGIX_tag_sample_buffer

            yield return new ProcInfo("glTagSampleBufferSGIX", typeof(GLNativeDelegate.FNglTagSampleBufferSGIX));

            #endregion GL_SGIX_tag_sample_buffer

            #region GL_SGI_color_table

            yield return new ProcInfo("glColorTableSGI", typeof(GLNativeDelegate.FNglColorTableSGI));
            yield return new ProcInfo("glColorTableParameterfvSGI", typeof(GLNativeDelegate.FNglColorTableParameterfvSGI));
            yield return new ProcInfo("glColorTableParameterivSGI", typeof(GLNativeDelegate.FNglColorTableParameterivSGI));
            yield return new ProcInfo("glCopyColorTableSGI", typeof(GLNativeDelegate.FNglCopyColorTableSGI));
            yield return new ProcInfo("glGetColorTableSGI", typeof(GLNativeDelegate.FNglGetColorTableSGI));
            yield return new ProcInfo("glGetColorTableParameterfvSGI", typeof(GLNativeDelegate.FNglGetColorTableParameterfvSGI));
            yield return new ProcInfo("glGetColorTableParameterivSGI", typeof(GLNativeDelegate.FNglGetColorTableParameterivSGI));

            #endregion GL_SGI_color_table

            #region GL_SUNX_constant_data

            yield return new ProcInfo("glFinishTextureSUNX", typeof(GLNativeDelegate.FNglFinishTextureSUNX));

            #endregion GL_SUNX_constant_data

            #region GL_SUN_global_alpha

            yield return new ProcInfo("glGlobalAlphaFactorbSUN", typeof(GLNativeDelegate.FNglGlobalAlphaFactorbSUN));
            yield return new ProcInfo("glGlobalAlphaFactorsSUN", typeof(GLNativeDelegate.FNglGlobalAlphaFactorsSUN));
            yield return new ProcInfo("glGlobalAlphaFactoriSUN", typeof(GLNativeDelegate.FNglGlobalAlphaFactoriSUN));
            yield return new ProcInfo("glGlobalAlphaFactorfSUN", typeof(GLNativeDelegate.FNglGlobalAlphaFactorfSUN));
            yield return new ProcInfo("glGlobalAlphaFactordSUN", typeof(GLNativeDelegate.FNglGlobalAlphaFactordSUN));
            yield return new ProcInfo("glGlobalAlphaFactorubSUN", typeof(GLNativeDelegate.FNglGlobalAlphaFactorubSUN));
            yield return new ProcInfo("glGlobalAlphaFactorusSUN", typeof(GLNativeDelegate.FNglGlobalAlphaFactorusSUN));
            yield return new ProcInfo("glGlobalAlphaFactoruiSUN", typeof(GLNativeDelegate.FNglGlobalAlphaFactoruiSUN));

            #endregion GL_SUN_global_alpha

            #region GL_SUN_mesh_array

            yield return new ProcInfo("glDrawMeshArraysSUN", typeof(GLNativeDelegate.FNglDrawMeshArraysSUN));

            #endregion GL_SUN_mesh_array

            #region GL_SUN_triangle_list

            yield return new ProcInfo("glReplacementCodeuiSUN", typeof(GLNativeDelegate.FNglReplacementCodeuiSUN));
            yield return new ProcInfo("glReplacementCodeusSUN", typeof(GLNativeDelegate.FNglReplacementCodeusSUN));
            yield return new ProcInfo("glReplacementCodeubSUN", typeof(GLNativeDelegate.FNglReplacementCodeubSUN));
            yield return new ProcInfo("glReplacementCodeuivSUN", typeof(GLNativeDelegate.FNglReplacementCodeuivSUN));
            yield return new ProcInfo("glReplacementCodeusvSUN", typeof(GLNativeDelegate.FNglReplacementCodeusvSUN));
            yield return new ProcInfo("glReplacementCodeubvSUN", typeof(GLNativeDelegate.FNglReplacementCodeubvSUN));
            yield return new ProcInfo("glReplacementCodePointerSUN", typeof(GLNativeDelegate.FNglReplacementCodePointerSUN));

            #endregion GL_SUN_triangle_list

            #region GL_SUN_vertex

            yield return new ProcInfo("glColor4ubVertex2fSUN", typeof(GLNativeDelegate.FNglColor4ubVertex2fSUN));
            yield return new ProcInfo("glColor4ubVertex2fvSUN", typeof(GLNativeDelegate.FNglColor4ubVertex2fvSUN));
            yield return new ProcInfo("glColor4ubVertex3fSUN", typeof(GLNativeDelegate.FNglColor4ubVertex3fSUN));
            yield return new ProcInfo("glColor4ubVertex3fvSUN", typeof(GLNativeDelegate.FNglColor4ubVertex3fvSUN));
            yield return new ProcInfo("glColor3fVertex3fSUN", typeof(GLNativeDelegate.FNglColor3fVertex3fSUN));
            yield return new ProcInfo("glColor3fVertex3fvSUN", typeof(GLNativeDelegate.FNglColor3fVertex3fvSUN));
            yield return new ProcInfo("glNormal3fVertex3fSUN", typeof(GLNativeDelegate.FNglNormal3fVertex3fSUN));
            yield return new ProcInfo("glNormal3fVertex3fvSUN", typeof(GLNativeDelegate.FNglNormal3fVertex3fvSUN));
            yield return new ProcInfo("glColor4fNormal3fVertex3fSUN", typeof(GLNativeDelegate.FNglColor4fNormal3fVertex3fSUN));
            yield return new ProcInfo("glColor4fNormal3fVertex3fvSUN", typeof(GLNativeDelegate.FNglColor4fNormal3fVertex3fvSUN));
            yield return new ProcInfo("glTexCoord2fVertex3fSUN", typeof(GLNativeDelegate.FNglTexCoord2fVertex3fSUN));
            yield return new ProcInfo("glTexCoord2fVertex3fvSUN", typeof(GLNativeDelegate.FNglTexCoord2fVertex3fvSUN));
            yield return new ProcInfo("glTexCoord4fVertex4fSUN", typeof(GLNativeDelegate.FNglTexCoord4fVertex4fSUN));
            yield return new ProcInfo("glTexCoord4fVertex4fvSUN", typeof(GLNativeDelegate.FNglTexCoord4fVertex4fvSUN));
            yield return new ProcInfo("glTexCoord2fColor4ubVertex3fSUN", typeof(GLNativeDelegate.FNglTexCoord2fColor4ubVertex3fSUN));
            yield return new ProcInfo("glTexCoord2fColor4ubVertex3fvSUN", typeof(GLNativeDelegate.FNglTexCoord2fColor4ubVertex3fvSUN));
            yield return new ProcInfo("glTexCoord2fColor3fVertex3fSUN", typeof(GLNativeDelegate.FNglTexCoord2fColor3fVertex3fSUN));
            yield return new ProcInfo("glTexCoord2fColor3fVertex3fvSUN", typeof(GLNativeDelegate.FNglTexCoord2fColor3fVertex3fvSUN));
            yield return new ProcInfo("glTexCoord2fNormal3fVertex3fSUN", typeof(GLNativeDelegate.FNglTexCoord2fNormal3fVertex3fSUN));
            yield return new ProcInfo("glTexCoord2fNormal3fVertex3fvSUN", typeof(GLNativeDelegate.FNglTexCoord2fNormal3fVertex3fvSUN));
            yield return new ProcInfo("glTexCoord2fColor4fNormal3fVertex3fSUN", typeof(GLNativeDelegate.FNglTexCoord2fColor4fNormal3fVertex3fSUN));
            yield return new ProcInfo("glTexCoord2fColor4fNormal3fVertex3fvSUN", typeof(GLNativeDelegate.FNglTexCoord2fColor4fNormal3fVertex3fvSUN));
            yield return new ProcInfo("glTexCoord4fColor4fNormal3fVertex4fSUN", typeof(GLNativeDelegate.FNglTexCoord4fColor4fNormal3fVertex4fSUN));
            yield return new ProcInfo("glTexCoord4fColor4fNormal3fVertex4fvSUN", typeof(GLNativeDelegate.FNglTexCoord4fColor4fNormal3fVertex4fvSUN));
            yield return new ProcInfo("glReplacementCodeuiVertex3fSUN", typeof(GLNativeDelegate.FNglReplacementCodeuiVertex3fSUN));
            yield return new ProcInfo("glReplacementCodeuiVertex3fvSUN", typeof(GLNativeDelegate.FNglReplacementCodeuiVertex3fvSUN));
            yield return new ProcInfo("glReplacementCodeuiColor4ubVertex3fSUN", typeof(GLNativeDelegate.FNglReplacementCodeuiColor4ubVertex3fSUN));
            yield return new ProcInfo("glReplacementCodeuiColor4ubVertex3fvSUN", typeof(GLNativeDelegate.FNglReplacementCodeuiColor4ubVertex3fvSUN));
            yield return new ProcInfo("glReplacementCodeuiColor3fVertex3fSUN", typeof(GLNativeDelegate.FNglReplacementCodeuiColor3fVertex3fSUN));
            yield return new ProcInfo("glReplacementCodeuiColor3fVertex3fvSUN", typeof(GLNativeDelegate.FNglReplacementCodeuiColor3fVertex3fvSUN));
            yield return new ProcInfo("glReplacementCodeuiNormal3fVertex3fSUN", typeof(GLNativeDelegate.FNglReplacementCodeuiNormal3fVertex3fSUN));
            yield return new ProcInfo("glReplacementCodeuiNormal3fVertex3fvSUN", typeof(GLNativeDelegate.FNglReplacementCodeuiNormal3fVertex3fvSUN));
            yield return new ProcInfo("glReplacementCodeuiColor4fNormal3fVertex3fSUN", typeof(GLNativeDelegate.FNglReplacementCodeuiColor4fNormal3fVertex3fSUN));
            yield return new ProcInfo("glReplacementCodeuiColor4fNormal3fVertex3fvSUN", typeof(GLNativeDelegate.FNglReplacementCodeuiColor4fNormal3fVertex3fvSUN));
            yield return new ProcInfo("glReplacementCodeuiTexCoord2fVertex3fSUN", typeof(GLNativeDelegate.FNglReplacementCodeuiTexCoord2fVertex3fSUN));
            yield return new ProcInfo("glReplacementCodeuiTexCoord2fVertex3fvSUN", typeof(GLNativeDelegate.FNglReplacementCodeuiTexCoord2fVertex3fvSUN));
            yield return new ProcInfo("glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN", typeof(GLNativeDelegate.FNglReplacementCodeuiTexCoord2fNormal3fVertex3fSUN));
            yield return new ProcInfo("glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", typeof(GLNativeDelegate.FNglReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN));
            yield return new ProcInfo("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN", typeof(GLNativeDelegate.FNglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN));
            yield return new ProcInfo("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", typeof(GLNativeDelegate.FNglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN));

            #endregion GL_SUN_vertex
        }
    }
}
