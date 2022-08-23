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
    class _1_8_Transform
    {
        private static string m_str_vertex_shader = @"
            #version 330 core

            layout (location = 0) in vec3 dotPos;
            layout (location = 1) in vec3 dotColor;
            layout (location = 2) in vec2 dotTexCoord;
            
            out vec3 DotColor;
            out vec2 DotTexCoord;

            uniform mat4 mat4_transform;

            void main(){
                gl_Position = mat4_transform * vec4(dotPos, 1.0);
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
                // location             // color            // texcoord
                -0.5f,  0.5f, 0.0f,     1.1f, 0.0f, 0.0f,   0.0f, 1.0f, // 左上角
                 0.5f,  0.5f, 0.0f,     0.0f, 1.1f, 0.0f,   1.0f, 1.0f, // 右上角
                 0.5f, -0.5f, 0.0f,     0.0f, 0.0f, 1.1f,   1.0f, 0.0f, // 右下角
                -0.5f, -0.5f, 0.0f,     1.1f, 0.0f, 1.1f,   0.0f, 0.0f, // 左下角
            };

            uint[] indices = {
                0, 3, 2,            // 第一个三角形
                0, 2, 1             // 第二个三角形
            };

            uint vao = GL.GenVertexArrays();
            GL.BindVertexArray(vao);

            uint vbo = GL.GenBuffers();
            GL.BindBuffer(GL.GL_ARRAY_BUFFER, vbo);
            GL.BufferData(GL.GL_ARRAY_BUFFER, vertices, GL.GL_STATIC_DRAW);

            GL.VertexAttribPointer(0, 3, GL.GL_FLOAT, false, 8 * sizeof(float), IntPtr.Zero);
            GL.EnableVertexAttribArray(0);

            GL.VertexAttribPointer(1, 3, GL.GL_FLOAT, false, 8 * sizeof(float), (IntPtr)(3 * sizeof(float)));
            GL.EnableVertexAttribArray(1);

            GL.VertexAttribPointer(2, 3, GL.GL_FLOAT, false, 8 * sizeof(float), (IntPtr)(6 * sizeof(float)));
            GL.EnableVertexAttribArray(2);

            uint ebo = GL.GenBuffers();
            GL.BindBuffer(GL.GL_ELEMENT_ARRAY_BUFFER, ebo);
            GL.BufferData(GL.GL_ELEMENT_ARRAY_BUFFER, indices, GL.GL_STATIC_DRAW);

            var program = GLProgram.Create(m_str_vertex_shader, m_str_fragment_shader);
            program.Use();
            var pi = PixelsHelper.GetPixelsInfo("./container.png", PixelFormat.Format24bppRgb);
            var texture_1 = GLTexture2D.Create();
            texture_1.BindUnit(GLTexture2D.Unit.Texture00);
            texture_1.SetPixels(pi.Pixels, (int)GL.GL_RGB, pi.Width, pi.Height, GL.GL_RGB);

            pi = PixelsHelper.GetPixelsInfo("./awesomeface.png", PixelFormat.Format24bppRgb);
            var texture_2 = GLTexture2D.Create(GLTexture2D.Unit.Texture01);
            texture_2.SetPixels(pi.Pixels, (int)GL.GL_RGB, pi.Width, pi.Height, GL.GL_RGB);

            //var mat = Matrix4F.Identity;
            //mat.Rotate(90, new Vector3F(0, 0, 1));
            //mat.Scale(new Vector3F(0.5f, 0.5f, 0.5f));
            //program.SetUniform("u_transform", mat);

            program.SetUniform("tex_1", 0);
            program.SetUniform("tex_2", 1);
            //====================================

            while (!GLFW.WindowShouldClose(window)) {
                processInput(window);

                GL.ClearColor(.5f, .5f, .5f, 1f);
                GL.Clear(GL.GL_COLOR_BUFFER_BIT);
                // GL.BindVertexArray(vao);
                var mat = Matrix4F.Identity;
                mat.Translate(new Vector3F(0.5f, -0.5f, 0));
                mat.Rotate((float)(DateTime.Now.Ticks / 100000 % 360), new Vector3F(0, 0, 1));
                program.SetUniform("mat4_transform", mat);
                GL.DrawElements(GL.GL_TRIANGLES, 6, GL.GL_UNSIGNED_INT, IntPtr.Zero);

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
