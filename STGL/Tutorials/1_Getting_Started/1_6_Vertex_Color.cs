﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using STLib.OpenGL;
using STLib.OpenGL.GL;
using STLib.OpenGL.GLFW;

namespace STGL.Tutorials
{
    class _1_6_Vertex_Color
    {
        private static string m_str_vertex_shader = @"
            #version 330 core

            layout (location = 0) in vec3 dotPos;
            layout (location = 1) in vec3 dotClr;

            out vec3 ourColor;

            void main(){
                gl_Position = vec4(dotPos, 1.0);
                ourColor = dotClr;
            }";
        private static string m_str_fragment_shader = @"
            #version 330 core

            out vec4 fragColor;

            in vec3 ourColor;            

            void main(){
                fragColor = vec4(ourColor, 1.0);
            }";
        public static void Run() {
            GLFW.Init();
            GLFW.WindowHint(GLFW.CONTEXT_VERSION_MAJOR, 3);
            GLFW.WindowHint(GLFW.CONTEXT_VERSION_MINOR, 3);
            GLFW.WindowHint(GLFW.OPENGL_PROFILE, GLFW.OPENGL_CORE_PROFILE);
            if (RuntimeInfo.System == RuntimeInfo.SystemType.Mac) {
                GLFW.WindowHint(GLFW.OPENGL_FORWARD_COMPAT, GL.GL_TRUE); // For Mac system
            }
            IntPtr window = GLFW.CreateWindow(400, 300, "LearnOpenGL", IntPtr.Zero, IntPtr.Zero);
            if (window == IntPtr.Zero) {
                Console.WriteLine("Failed to create GLFW window");
                GLFW.Terminate();
                return;
            }
            GLFW.MakeContextCurrent(window);
            GLFW.SetFramebufferSizeCallback(window, framebuffer_size_callback);
            try {
                GL.Init(GLFW.GetProcAddress);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                GLFW.Terminate();
                return;
            }
            int nWidth = 0, nHeight = 0;
            GLFW.GetFramebufferSize(window, ref nWidth, ref nHeight);
            GL.Viewport(0, 0, nWidth, nHeight);

            //====================================
            float[] vertices = {
                // 顶点                 // 颜色  
                -0.5f, -0.5f, 0.0f,     1.0f, 0.0f, 0.0f,
                 0.5f, -0.5f, 0.0f,     0.0f, 1.0f, 0.0f,
                 0.0f,  0.5f, 0.0f,     0.0f, 0.0f, 1.0f
            };

            uint vao = GL.GenVertexArrays();
            GL.BindVertexArray(vao);

            uint vbo = GL.GenBuffers();
            GL.BindBuffer(GL.GL_ARRAY_BUFFER, vbo);
            GL.BufferData(GL.GL_ARRAY_BUFFER, vertices, GL.GL_STATIC_DRAW);
            GL.VertexAttribPointer(0, 3, GL.GL_FLOAT, false, 6 * sizeof(float), IntPtr.Zero);
            GL.EnableVertexAttribArray(0);
            GL.VertexAttribPointer(1, 3, GL.GL_FLOAT, false, 6 * sizeof(float), (IntPtr)(sizeof(float) * 3));
            GL.EnableVertexAttribArray(1);

            var vertexShader = GL.CreateShader(GL.GL_VERTEX_SHADER);
            GL.ShaderSource(vertexShader, m_str_vertex_shader);
            GL.CompileShader(vertexShader);
            int nFlag = GL.GetShaderiv(vertexShader, GL.GL_COMPILE_STATUS);
            if (nFlag == 0) {
                int nLen = 0;
                byte[] byBuffer = new byte[1024];
                GL.GetShaderInfoLog(vertexShader, byBuffer.Length, ref nLen, ref byBuffer[0]);
                GL.DeleteShader(vertexShader);
                string strError = Encoding.UTF8.GetString(byBuffer, 0, nLen);
                throw new GLShaderCompileException(strError);
            }

            var fragmentShader = GL.CreateShader(GL.GL_FRAGMENT_SHADER);
            GL.ShaderSource(fragmentShader, m_str_fragment_shader);
            GL.CompileShader(fragmentShader);
            nFlag = GL.GetShaderiv(fragmentShader, GL.GL_COMPILE_STATUS);
            if (nFlag == 0) {
                int nLen = 0;
                byte[] byBuffer = new byte[1024];
                GL.GetShaderInfoLog(fragmentShader, byBuffer.Length, ref nLen, ref byBuffer[0]);
                GL.DeleteShader(fragmentShader);
                string strError = Encoding.UTF8.GetString(byBuffer, 0, nLen);
                throw new GLShaderCompileException(strError);
            }

            var program = GL.CreateProgram();
            GL.AttachShader(program, vertexShader);
            GL.AttachShader(program, fragmentShader);
            GL.LinkProgram(program);
            nFlag = GL.GetProgramiv(program, GL.GL_LINK_STATUS);
            if (nFlag == 0) {
                int nLen = 0;
                byte[] byBuffer = new byte[1024];
                GL.GetProgramInfoLog(program, byBuffer.Length, ref nLen, ref byBuffer[0]);
                GL.DeleteProgram(program);
                string strError = Encoding.UTF8.GetString(byBuffer, 0, nLen);
                throw new GLProgramLinkException(strError);
            }
            GL.UseProgram(program);
            GL.DeleteShader(vertexShader);
            GL.DeleteShader(fragmentShader);
            //====================================

            while (!GLFW.WindowShouldClose(window)) {
                processInput(window);

                GL.ClearColor(.5f, .5f, .5f, 1f);
                GL.Clear(GL.GL_COLOR_BUFFER_BIT);
                // GL.BindVertexArray(vao);
                GL.DrawArrays(GL.GL_TRIANGLES, 0, 3);

                GLFW.SwapBuffers(window);
                GLFW.WaitEvents();
            }
            GLFW.Terminate();
        }

        static void processInput(IntPtr window) {
            if (GLFW.GetKey(window, GLFW.KEY_ESCAPE) == GLFW.PRESS)
                GLFW.SetWindowShouldClose(window, true);
        }

        static void framebuffer_size_callback(IntPtr window, int width, int height) {
            GL.Viewport(0, 0, width, height);
        }
    }
}
