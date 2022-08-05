using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using STLib.OpenGL;
using STLib.OpenGL.GL;
using STLib.OpenGL.GLFW;

namespace STGL.Tutorials
{
    class _1_6_Uniform_STGL
    {
        private static string m_str_vertex_shader = @"
            #version 330 core

            layout (location = 0) in vec3 dotPos;

            void main(){
                gl_Position = vec4(dotPos, 1.0);
            }";
        private static string m_str_fragment_shader = @"
            #version 330 core

            out vec4 fragColor;

            uniform vec4 ourColor;            

            void main(){
                fragColor = ourColor;
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
                -0.5f, -0.5f, 0.0f, // 第一个顶点
                 0.5f, -0.5f, 0.0f, // 第二个顶点
                 0.0f,  0.5f, 0.0f  // 第三个顶点
            };

            uint vao = GL.GenVertexArrays();
            GL.BindVertexArray(vao);

            uint vbo = GL.GenBuffers(); // 创建一个buffer对象并得到id STGL对此函数进行了多个重载
            GL.BindBuffer(GL.GL_ARRAY_BUFFER, vbo); // 将对象绑定到Context中
            GL.BufferData(GL.GL_ARRAY_BUFFER, vertices, GL.GL_STATIC_DRAW);
            GL.VertexAttribPointer(0, 3, GL.GL_FLOAT, false, 3 * sizeof(float), IntPtr.Zero);
            GL.EnableVertexAttribArray(0);

            GLProgram program = GLProgram.Create(m_str_vertex_shader, m_str_fragment_shader);
            program.Use();

            //var vertShader = GLShader.Create(m_str_vertex_shader,GLShaderType.Vertex);
            //var fragShader = GLShader.Create(m_str_fragment_shader, GLShaderType.Fragment);
            //GLProgram program = GLProgram.Create(vertShader, fragShader);
            //vertShader.Dispose();
            //fragShader.Dispose();
            //program.Use();
            //====================================

            while (!GLFW.WindowShouldClose(window)) {
                processInput(window);

                GL.ClearColor(.5f, .5f, .5f, 1f);
                GL.Clear(GL.GL_COLOR_BUFFER_BIT);
                // GL.BindVertexArray(vao);
                float greenValue = (float)(Math.Sin(GLFW.GetTime()) / 2.0f) + 0.5f;
                program.SetUniform("ourColor", 0, greenValue, 0, 1);
                GL.DrawArrays(GL.GL_TRIANGLES, 0, 3);

                GLFW.SwapBuffers(window);
                GLFW.PollEvents();
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
