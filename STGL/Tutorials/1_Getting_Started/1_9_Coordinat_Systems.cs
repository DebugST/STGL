using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using STLib.OpenGL;
using STLib.OpenGL.GL;
using STLib.OpenGL.GLM;
using STLib.OpenGL.GLFW;
using System.Drawing.Imaging;

namespace STGL.Tutorials
{
    public class _1_9_Coordinat_Systems
    {
        private static string m_str_vertex_shader = @"
            #version 330 core

            layout (location = 0) in vec3 dotPos;
            layout (location = 1) in vec3 dotColor;
            layout (location = 2) in vec2 dotTexCoord;
            
            out vec3 DotColor;
            out vec2 DotTexCoord;
            
            uniform mat4 mat_transform;
            void main(){
                gl_Position = mat_transform * vec4(dotPos, 1.0);
                DotColor = dotColor;
                DotTexCoord = dotTexCoord;
            }";
        private static string m_str_fragment_shader = @"
            #version 330 core

            in vec3 DotColor;
            in vec2 DotTexCoord;

            out vec4 fragColor;

            uniform sampler2D tex_1;
            uniform sampler2D tex_2;

            void main(){
                fragColor = mix(texture(tex_1, DotTexCoord), texture(tex_2, DotTexCoord), 0.2);
            }";
        private static int m_nWidth = 0;
        private static int m_nHeight = 0;
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
            //int nWidth = 0, nHeight = 0;
            GLFW.GetFramebufferSize(window, ref m_nWidth, ref m_nHeight);
            GL.Viewport(0, 0, m_nWidth, m_nHeight);

            //====================================
            float[] vertices = {
                -0.5f, -0.5f, -0.5f,  0.0f, 0.0f,
                 0.5f, -0.5f, -0.5f,  1.0f, 0.0f,
                 0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
                 0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
                -0.5f,  0.5f, -0.5f,  0.0f, 1.0f,
                -0.5f, -0.5f, -0.5f,  0.0f, 0.0f,

                -0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
                 0.5f, -0.5f,  0.5f,  1.0f, 0.0f,
                 0.5f,  0.5f,  0.5f,  1.0f, 1.0f,
                 0.5f,  0.5f,  0.5f,  1.0f, 1.0f,
                -0.5f,  0.5f,  0.5f,  0.0f, 1.0f,
                -0.5f, -0.5f,  0.5f,  0.0f, 0.0f,

                -0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
                -0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
                -0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
                -0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
                -0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
                -0.5f,  0.5f,  0.5f,  1.0f, 0.0f,

                 0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
                 0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
                 0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
                 0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
                 0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
                 0.5f,  0.5f,  0.5f,  1.0f, 0.0f,

                -0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
                 0.5f, -0.5f, -0.5f,  1.0f, 1.0f,
                 0.5f, -0.5f,  0.5f,  1.0f, 0.0f,
                 0.5f, -0.5f,  0.5f,  1.0f, 0.0f,
                -0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
                -0.5f, -0.5f, -0.5f,  0.0f, 1.0f,

                -0.5f,  0.5f, -0.5f,  0.0f, 1.0f,
                 0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
                 0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
                 0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
                -0.5f,  0.5f,  0.5f,  0.0f, 0.0f,
                -0.5f,  0.5f, -0.5f,  0.0f, 1.0f
            };

            uint vao = GL.GenVertexArrays();
            GL.BindVertexArray(vao);

            uint vbo = GL.GenBuffers();
            GL.BindBuffer(GL.GL_ARRAY_BUFFER, vbo);
            GL.BufferData(GL.GL_ARRAY_BUFFER, vertices, GL.GL_STATIC_DRAW);

            GL.VertexAttribPointer(0, 3, GL.GL_FLOAT, false, 5 * sizeof(float), IntPtr.Zero);
            GL.EnableVertexAttribArray(0);

            GL.VertexAttribPointer(2, 3, GL.GL_FLOAT, false, 5 * sizeof(float), (IntPtr)(3 * sizeof(float)));
            GL.EnableVertexAttribArray(2);

            var program = GLProgram.Create(m_str_vertex_shader, m_str_fragment_shader);
            program.Use();
            var pi = PixelsHelper.GetPixelsInfo("./container.png", PixelFormat.Format24bppRgb);
            var texture_1 = GLTexture2D.Create();
            texture_1.BindUnit(GLTexture2D.Unit.Texture00);
            texture_1.SetPixels(pi.Pixels, (int)GL.GL_RGB, pi.Width, pi.Height, GL.GL_RGB);

            pi = PixelsHelper.GetPixelsInfo("./awesomeface.png", PixelFormat.Format24bppRgb);
            var texture_2 = GLTexture2D.Create(GLTexture2D.Unit.Texture01);
            texture_2.SetPixels(pi.Pixels, (int)GL.GL_RGB, pi.Width, pi.Height, GL.GL_RGB);

            program.SetUniform("tex_1", 0);
            program.SetUniform("tex_2", 1);

            //GL.PolygonMode(GL.GL_FRONT_AND_BACK, GL.GL_LINE);
            //====================================
            GL.Enable(GL.GL_DEPTH_TEST);
            while (!GLFW.WindowShouldClose(window)) {
                processInput(window);

                GL.ClearColor(.5f, .5f, .5f, 1f);
                GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);
                // GL.BindVertexArray(vao);
                var matM = GLM.Rotate(-45, new Vector3F(1, 0, 0));
                var matV = GLM.Translate(new Vector3F(0, 0, -3));
                var matP = GLM.Perspective(45, (float)m_nWidth / m_nHeight, .1f, 100f);
                program.SetUniform("mat_transform", matP * matV * matM);
                //GL.DrawElements(GL.GL_TRIANGLES, 6, GL.GL_UNSIGNED_INT, IntPtr.Zero);
                GL.DrawArrays(GL.GL_TRIANGLES, 0, 36);

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
