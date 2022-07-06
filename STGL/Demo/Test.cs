using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using STLib.OpenGL;
using STLib.OpenGL.GL;
using STLib.OpenGL.GLFW;

namespace STGL.Demo
{
    class Test
    {
        static uint m_pid;
        static string vertexShaderSource = "#version 330 core\n" +
            "layout (location = 0) in vec3 position;\n" +
            "layout (location = 1) in vec3 clr;\n" +
            "out vec3 ccc;\n" +
            "void main()\n" +
            "{\n" +
            "gl_Position = vec4(position.x, position.y, position.z, 1.0);\n" +
            "ccc=clr;" +
            "}\0";
        static string fragmentShaderSource = "#version 330 core\n" +
            "in vec3 ccc;\n" +
            "out vec4 colorb;\n" +
            "out vec4 colora;\n" +
            "uniform vec4 outClr;\n" +
            "void main()\n" +
            "{\n" +
            //"color = vec4(1.0f, 0.5f, 0.2f, 1.0f);\n" +
            "colora = outClr;\n" +
            "colorb = vec4(ccc.x, ccc.y, ccc.z, 1.0f);\n" +
            "}\n\0";

        public static int Start() {
            GLFW.Init();
            GLFW.WindowHint(GLFW.CONTEXT_VERSION_MAJOR, 3);
            GLFW.WindowHint(GLFW.CONTEXT_VERSION_MINOR, 3);
            GLFW.WindowHint(GLFW.OPENGL_PROFILE, GLFW.OPENGL_CORE_PROFILE);

            if (RuntimeInfo.System == RuntimeInfo.SystemType.Mac) {
                GLFW.WindowHint(GLFW.OPENGL_FORWARD_COMPAT, GL.GL_TRUE); // For Mac system
            }

            // glfw window creation
            // --------------------
            IntPtr window = GLFW.CreateWindow(800, 600, "LearnOpenGL", IntPtr.Zero, IntPtr.Zero);
            if (window == IntPtr.Zero) {
                Console.WriteLine("Failed to create GLFW window");
                GLFW.Terminate();
                return -1;
            }
            GLFW.MakeContextCurrent(window);
            GLFW.SetFramebufferSizeCallback(window, framebuffer_size_callback);

            // glad: load all OpenGL function pointers
            // ---------------------------------------
            //if (!gladLoadGLLoader((GLADloadproc)glfwGetProcAddress))
            //{
            //    std::cout << "Failed to initialize GLAD" << std::endl;
            //    return -1;
            //}    
            try {
                GL.Init(GLFW.GetProcAddress);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                GLFW.Terminate();
                return -1;
            }

            var vertexShader = GL.CreateShader(GL.GL_VERTEX_SHADER);
            GL.ShaderSource(vertexShader, vertexShaderSource);
            GL.CompileShader(vertexShader);

            var fragmentShader = GL.CreateShader(GL.GL_FRAGMENT_SHADER);
            GL.ShaderSource(fragmentShader, fragmentShaderSource);
            GL.CompileShader(fragmentShader);

            var program = GL.CreateProgram();
            GL.AttachShader(program, vertexShader);
            GL.AttachShader(program, fragmentShader);
            GL.LinkProgram(program);
            m_pid = program;

            GL.DeleteShader(vertexShader);
            GL.DeleteShader(fragmentShader);

            float[] vertices = {
                               0.0f,0.5f,0.0f,
                               -0.5f,-0.5f,0.0f,
                               0.5f,-0.5f,0.0f
                               };
            float[] colors = {
                               1.0f,0.0f,0.0f,
                               0.0f,1.0f,0.0f,
                               0.0f,0.0f,1.0f
                               };
            float[] indices = { 0, 1, 2 };

            var vbos = GL.GenBuffers(2);
            GL.BindBuffer(GL.GL_ARRAY_BUFFER, vbos[0]);
            GL.BufferData(GL.GL_ARRAY_BUFFER, vertices, GL.GL_STATIC_DRAW);
            GL.BindBuffer(GL.GL_ARRAY_BUFFER, vbos[1]);
            GL.BufferData(GL.GL_ARRAY_BUFFER, colors, GL.GL_STATIC_DRAW);

            //var ebo = GL.GenBuffers();
            //GL.BindBuffer(GL.GL_ELEMENT_ARRAY_BUFFER, ebo);
            //GL.BufferData(GL.GL_ELEMENT_ARRAY_BUFFER, indices, GL.GL_STATIC_DRAW);
            int fsda = GL.GetIntegerv(GL.GL_MAX_VERTEX_ATTRIBS);
            var vao = GL.GenVertexArrays();
            GL.BindVertexArray(vao);

            //GL.VertexAttribPointer(0, 3, GL.GL_FLOAT, false, 3 * sizeof(float), IntPtr.Zero);
            //GL.EnableVertexAttribArray(0);
            //GL.VertexAttribPointer(1, 3, GL.GL_FLOAT, false, 3 * sizeof(float), IntPtr.Zero);
            //GL.EnableVertexAttribArray(1);

            // render loop
            // -----------
            while (!GLFW.WindowShouldClose(window)) {
                // input
                // -----
                processInput(window);

                // render
                // ------
                GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
                GL.Clear(GL.GL_COLOR_BUFFER_BIT);

                GL.UseProgram(program);
                GL.BindVertexArray(vao);

                GL.BindVertexBuffer(0, vbos[0], IntPtr.Zero, 3 * sizeof(float));
                GL.EnableVertexAttribArray(0);
                GL.DrawElements(GL.GL_TRIANGLES, GL.GL_UNSIGNED_INT, indices);
                GL.BindVertexBuffer(1, vbos[1], IntPtr.Zero, 3 * sizeof(float));
                GL.EnableVertexAttribArray(1);
                GL.DrawArrays(GL.GL_TRIANGLES, 0, 3);

                GL.BindVertexArray(0);

                // glfw: swap buffers and poll IO events (keys pressed/released, mouse moved etc.)
                // -------------------------------------------------------------------------------
                GLFW.SwapBuffers(window);
                GLFW.WaitEvents();
            }

            // glfw: terminate, clearing all previously allocated GLFW resources.
            // ------------------------------------------------------------------
            GLFW.Terminate();
            return 0;
        }

        // process all input: query GLFW whether relevant keys are pressed/released this frame and react accordingly
        // ---------------------------------------------------------------------------------------------------------
        static void processInput(IntPtr window) {
            if (GLFW.GetKey(window, GLFW.KEY_ESCAPE) == GLFW.PRESS)
                GLFW.SetWindowShouldClose(window, true);
            if (GLFW.GetKey(window, GLFW.KEY_A) == GLFW.PRESS) {
                Random rnd = new Random();
                int loc = GL.GetUniformLocation(m_pid, "outClr");
                GL.Uniform4f(loc, (float)rnd.NextDouble(), (float)rnd.NextDouble(), (float)rnd.NextDouble(), 1);
                Console.WriteLine(loc);
            }
        }

        // glfw: whenever the window size changed (by OS or user resize) this callback function executes
        // ---------------------------------------------------------------------------------------------
        static void framebuffer_size_callback(IntPtr window, int width, int height) {
            // make sure the viewport matches the new window dimensions; note that width and 
            // height will be significantly larger than specified on retina displays.
            GL.Viewport(0, 0, width, height);
        }
    }
}
