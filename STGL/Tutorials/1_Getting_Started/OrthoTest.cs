using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using STLib.OpenGL;
using STLib.OpenGL.GL;
using STLib.OpenGL.GLM;
using STLib.OpenGL.GLFW;

namespace STGL.Tutorials
{
    public class OrthoTest
    {
        private static int m_nWidth = 0;
        private static int m_nHeight = 0;
        private static string m_str_vertex_shader = @"
            #version 330 core

            layout (location = 0) in vec2 dotPos;

            uniform mat4 mat_transform;

            void main(){
                gl_Position = mat_transform * vec4(dotPos.x, dotPos.y, 0, 1.0);
            }";
        private static string m_str_fragment_shader = @"
            #version 330 core

            out vec4 fragColor;

            void main(){
                fragColor = vec4(1.0, 0.5, 0.2, 1.0);
            }";

        public static void Run() {
            GLFW.Init();
            GLFW.WindowHint(GLFW.CONTEXT_VERSION_MAJOR, 3);
            GLFW.WindowHint(GLFW.CONTEXT_VERSION_MINOR, 3);
            GLFW.WindowHint(GLFW.OPENGL_PROFILE, GLFW.OPENGL_CORE_PROFILE);
            if (RuntimeInfo.System == RuntimeInfo.SystemType.Mac) {
                GLFW.WindowHint(GLFW.OPENGL_FORWARD_COMPAT, GL.GL_TRUE); // For Mac system
            }
            //GLFW.show
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
            //int nWidth = 0, nHeight = 0;
            GLFW.GetFramebufferSize(window, ref m_nWidth, ref m_nHeight);
            GL.Viewport(0, 0, m_nWidth, m_nHeight);

            int[] vertices = {
                0,0, 70,0, 70,20, 0,20
            };
            uint[] indices = {
                0,3,1,
                3,2,1
            };

            var vao = GL.GenVertexArrays();
            GL.BindVertexArray(vao);

            var vbo = GL.GenBuffers();
            GL.BindBuffer(GL.GL_ARRAY_BUFFER, vbo);
            GL.BufferData(GL.GL_ARRAY_BUFFER, vertices, GL.GL_STATIC_DRAW);
            GL.VertexAttribPointer(0, 2, GL.GL_INT, false, 2 * sizeof(int), IntPtr.Zero);
            GL.EnableVertexAttribArray(0);

            var ebo = GL.GenBuffers();
            GL.BindBuffer(GL.GL_ELEMENT_ARRAY_BUFFER, ebo);
            GL.BufferData(GL.GL_ELEMENT_ARRAY_BUFFER, indices, GL.GL_STATIC_DRAW);

            var program = GLProgram.Create(m_str_vertex_shader, m_str_fragment_shader);
            program.Use();

            GL.Enable(GL.GL_MULTISAMPLE);
            while (!GLFW.WindowShouldClose(window)) {
                processInput(window);
                GL.ClearColor(.5f, .5f, .5f, 1f);
                GL.Clear(GL.GL_COLOR_BUFFER_BIT);
                var matProjection = GLM.Ortho(0, m_nWidth, m_nHeight, 0, -1, 1);
                program.SetUniform(
                    "mat_transform",
                    matProjection //* GLM.Translate(new Vector3F(10, 10, 0))
                    );
                //GL.Enable(GL.GL_SCISSOR_TEST);
                GL.Scissor(0, 280, 20, 20);
                GL.DrawElements(GL.GL_TRIANGLES, 6, GL.GL_UNSIGNED_INT, IntPtr.Zero);
                //GL.Disable(GL.GL_SCISSOR_TEST);

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
            m_nWidth = width;
            m_nHeight = height;
            GL.Viewport(0, 0, width, height);
        }
    }
}
