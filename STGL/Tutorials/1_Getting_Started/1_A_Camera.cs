using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using STLib.OpenGL;
using STLib.OpenGL.GL;
using STLib.OpenGL.GLM;
using STLib.OpenGL.GLFW;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace STGL.Tutorials
{
    public class _1_A_Camera
    {
        static double m_pos_y = 0;
        static double m_pos_x = 0;
        static bool m_b_inited;
        static bool m_b_captured;
        static GLCamera m_camera = new GLCamera(new Vector3F(0, 0, 3));

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
            GLFW.SetErrorCallback((int n, string strs) => {
                Console.WriteLine(n + "," + strs);
            });
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
            GLFW.SetKeyCallback(window, OnKeyDown);
            GLFW.SetMouseButtonCallback(window, onMouseButton);
            GLFW.SetCursorPosCallback(window, OnMouseMove);
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

            Vector3F[] cubePositions = {
                new Vector3F( 0.0f,  0.0f,  0.0f), 
                new Vector3F( 2.0f,  5.0f, -15.0f), 
                new Vector3F(-1.5f, -2.2f, -2.5f),  
                new Vector3F(-3.8f, -2.0f, -12.3f),  
                new Vector3F( 2.4f, -0.4f, -3.5f),  
                new Vector3F(-1.7f,  3.0f, -7.5f),  
                new Vector3F( 1.3f, -2.0f, -2.5f),  
                new Vector3F( 1.5f,  2.0f, -2.5f), 
                new Vector3F( 1.5f,  0.2f, -1.5f), 
                new Vector3F(-1.3f,  1.0f, -1.5f)
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
                //processInput(window);
                GL.ClearColor(.5f, .5f, .5f, 1f);
                GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);

                var matP = GLM.Perspective(45, (float)m_nWidth / m_nHeight, .1f, 100f);
                var matV = m_camera.ViewMatrix;
                for (int i = 0; i < cubePositions.Length; i++) {
                    float radius = 10.0f;
                    float camX = (float)Math.Sin(GLFW.GetTime()) * radius;
                    float camZ = (float)Math.Cos(GLFW.GetTime()) * radius;
                    var matM = GLM.Translate(cubePositions[i]);
                    matM.Rotate(20 * i, new Vector3F(1, .3f, .5f));

                    program.SetUniform("mat_transform", matP * matV * matM);
                    //GL.DrawElements(GL.GL_TRIANGLES, 6, GL.GL_UNSIGNED_INT, IntPtr.Zero);
                    GL.DrawArrays(GL.GL_TRIANGLES, 0, 36);
                }
                GLFW.SwapBuffers(window);
                GLFW.PollEvents();
                System.Threading.Thread.Sleep(100);
            }
            GLFW.Terminate();
        }

        static void framebuffer_size_callback(IntPtr window, int width, int height) {
            m_nWidth = width;
            m_nHeight = height;
            GL.Viewport(0, 0, width, height);
        }

        static void OnKeyDown(IntPtr window, int key, int scancode, int action, int mods) {
            switch (key) {
                case GLFW.KEY_ESCAPE:
                    GLFW.SetInputMode(window, GLFW.CURSOR, GLFW.CURSOR_NORMAL);
                    m_b_captured = false;
                    m_b_inited = false;
                    return;
                case GLFW.KEY_UP:
                    m_camera.PitchUp(1f);
                    break;
                case GLFW.KEY_DOWN:
                    m_camera.PitchDown(1f);
                    break;
                case GLFW.KEY_LEFT:
                    m_camera.YawLeft(1f);
                    break;
                case GLFW.KEY_RIGHT:
                    m_camera.YawRight(1f);
                    break;
                case GLFW.KEY_A:
                    m_camera.MoveLeft(.1f);
                    break;
                case GLFW.KEY_D:
                    m_camera.MoveRight(.1f);
                    break;
                case GLFW.KEY_W:
                    m_camera.MoveForward(.1f);
                    break;
                case GLFW.KEY_S:
                    m_camera.MoveBack(.1f);
                    break;
                case GLFW.KEY_I:
                    m_camera.MoveUp(.1f);
                    break;
                case GLFW.KEY_K:
                    m_camera.MoveDown(.1f);
                    break;
                case GLFW.KEY_J:
                    m_camera.RollLeft(1);
                    break;
                case GLFW.KEY_L:
                    m_camera.RollRight(1);
                    break;
            }
        }

        static void onMouseButton(IntPtr window, int button, int action, int mods) {
            if (action == GLFW.PRESS) {
                switch (button) {
                    case GLFW.MOUSE_BUTTON_LEFT:
                        GLFW.SetInputMode(window, GLFW.CURSOR, GLFW.CURSOR_DISABLED);
                        m_b_captured = true;
                        return;
                }
            }
        }

        static void OnMouseMove(IntPtr window, double xpos, double ypos) {
            Console.WriteLine("Right:" + m_camera.Right);
            if (!m_b_captured) return;
            if (!m_b_inited) {
                m_pos_x = xpos;
                m_pos_y = ypos;
                m_b_inited = true;
            }
            float f = 0.1f;
            var pitch = (float)(ypos - m_pos_y) * f;
            var yaw = (float)(xpos - m_pos_x) * f;
            m_camera.Yaw(yaw);
            m_camera.Pitch(pitch);
            m_pos_x = xpos;
            m_pos_y = ypos;
            //Console.WriteLine("UP:" + m_camera.UP);
            //Console.WriteLine("Forward:" + m_camera.Forward);
        }
    }
}
