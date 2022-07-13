using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using STLib.OpenGL;
using STLib.OpenGL.GLFW;
using STLib.OpenGL.GL;
using STLib.OpenGL.GL.Mathematics;

namespace STGL.Demo
{
    class Test
    {
        //static uint m_pid;
        //static GLProgram m_sp;
        static string vertexShaderSource =
            "#version 330 core\n" +

            "layout (location = 0) in vec3 aPos;\n" +
            "layout (location = 1) in vec3 aClr;\n" +
            "layout (location = 2) in vec2 texCoord;\n" +

            "out vec3 ourColor;\n" +
            "out vec2 TexCoord;\n" +

            "uniform mat4 transform;\n" +

            "void main()\n" +
            "{\n" +
            "   gl_Position = transform * vec4(aPos.x, aPos.y, aPos.z, 1.0);\n" +
            "   ourColor = aClr;\n" +
            "   TexCoord = texCoord;\n" +
            "}\0";
        static string fragmentShaderSource =
            "#version 330 core\n" +

            "in vec3 ourColor;\n" +
            "in vec2 TexCoord;\n" +

            "out vec4 FragColor;\n" +

            "uniform sampler2D ourTexture1;\n" +
            "uniform sampler2D ourTexture2;\n" +

            "void main()\n" +
            "{\n" +
            //"   FragColor =  vec4(ourColor, 1.0f);\n" +
            "   FragColor =  mix(texture(ourTexture1, TexCoord), texture(ourTexture2, TexCoord), 0.2);\n" +
            //"   FragColor = texture(ourTexture2, TexCoord);\n" +
            "}\n\0";

        public unsafe static int Start() {
            //var adf = Math.Sin(MathHelper.DegressToRadians(90));
            //var vec = new Vector4F(1, 2, 3, 1);
            //var mat = Matrix4F.Identity;
            //mat.Translation(1, 1, 1);
            //mat.Scale(2, 2, 2);
            //var result = mat * vec;
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
            //var cb = new GLFW.CBFrameBufferSize(framebuffer_size_callback);
            //GC.KeepAlive(cb);
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

            var program = GLProgram.CreateProgram(vertexShaderSource, fragmentShaderSource);

            float[] vertices = {
                               0.0f,  0.5f,0.0f,
                               -0.5f,-0.5f,0.0f,
                               0.5f, -0.5f,0.0f
                               };
            uint[] indices = { 0, 1, 2 };
            float[] colors = {
                               1.0f,0.0f,0.0f,
                               0.0f,1.0f,0.0f,
                               0.0f,0.0f,1.0f
                               };
            float[] textureCoords ={
                                  0.5F, 1.0F,
                                  0.0F, 0.0F,
                                  1.0F, 0.0F
                                  };

            var VAO = GL.GenVertexArrays();
            GL.BindVertexArray(VAO);

            var VBOs = GL.GenBuffers(3);
            GL.BindBuffer(GL.GL_ARRAY_BUFFER, VBOs[0]);
            GL.BufferData(GL.GL_ARRAY_BUFFER, vertices, GL.GL_STATIC_DRAW);
            GL.VertexAttribPointer(0, 3, GL.GL_FLOAT, false, 3 * sizeof(float), IntPtr.Zero);
            GL.EnableVertexAttribArray(0);

            GL.BindBuffer(GL.GL_ARRAY_BUFFER, VBOs[1]);
            GL.BufferData(GL.GL_ARRAY_BUFFER, colors, GL.GL_STATIC_DRAW);
            GL.VertexAttribPointer(1, 3, GL.GL_FLOAT, false, 3 * sizeof(float), IntPtr.Zero);
            GL.EnableVertexAttribArray(1);

            GL.BindBuffer(GL.GL_ARRAY_BUFFER, VBOs[2]);
            GL.BufferData(GL.GL_ARRAY_BUFFER, textureCoords, GL.GL_STATIC_DRAW);
            GL.VertexAttribPointer(2, 3, GL.GL_FLOAT, false, 2 * sizeof(float), IntPtr.Zero);
            GL.EnableVertexAttribArray(2);

            var EBO = GL.GenBuffers();
            GL.BindBuffer(GL.GL_ELEMENT_ARRAY_BUFFER, EBO);
            GL.BufferData(GL.GL_ELEMENT_ARRAY_BUFFER, MarshalExtend.SizeOf(indices), indices, GL.GL_STATIC_DRAW);

            GL.ActiveTexture(GL.GL_TEXTURE0);

            program.Use();

            var pi1 = PixelsHelper.GetPixelsInfo("./container.jpg", System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            var texture1 = GLTexture2D.Create();
            texture1.SetPixels(pi1.Pixels, (int)GL.GL_RGB, pi1.Width, pi1.Height, GL.GL_RGB);
            //texture1.SetRepeat(GLTexture2D.Repeat.Repeat, GLTexture2D.Repeat.Repeat);
            //texture1.SetFilter(GLTexture2D.Filter.Nearest, GLTexture2D.Filter.Linear);

            GL.ActiveTexture(GL.GL_TEXTURE0);
            var pi2 = PixelsHelper.GetPixelsInfo("./awesomeface.png", System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            var texture2 = GLTexture2D.Create();
            texture2.SetPixels(pi2.Pixels, (int)GL.GL_RGB, pi2.Width, pi2.Height, GL.GL_RGB);
            //texture2.SetRepeat(GLTexture2D.Repeat.Repeat, GLTexture2D.Repeat.Repeat);
            //texture2.SetFilter(GLTexture2D.Filter.Nearest, GLTexture2D.Filter.Linear);

            texture1.BindUnit(GLTexture2D.Unit.Texture00);
            texture2.BindUnit(GLTexture2D.Unit.Texture01);
            program.SetUniform("ourTexture1", 0);
            program.SetUniform("ourTexture2", 1);

            // create a mat for move Let the X + 0.5;
            var vec = new Vector4F(1, 0, 0, 1);
            Matrix4F mat = Matrix4F.Identity;
            mat.Translation(new Vector3F(.5f, 0f, 0));
            var result_vec = mat * vec;
            Console.WriteLine(result_vec);
            program.SetUniform("transform", mat);

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

                program.Use();
                //GL.BindVertexArray(VAO);

                //GL.BindVertexBuffer(0, vbos[0], IntPtr.Zero, 3 * sizeof(float));
                //GL.EnableVertexAttribArray(0);
                //GL.DrawArrays(GL.GL_TRIANGLES, 0, 3);
                GL.DrawElements(GL.GL_TRIANGLES, 3, GL.GL_UNSIGNED_INT, IntPtr.Zero);

                //GL.BindVertexBuffer(1, vbos[1], IntPtr.Zero, 3 * sizeof(float));
                //GL.EnableVertexAttribArray(1);
                //GL.DrawArrays(GL.GL_TRIANGLES, 0, 3);

                //GL.BindVertexArray(0);

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
                //int loc = GL.GetUniformLocation(m_pid, "outClr");
                //GL.Uniform4f(loc, (float)rnd.NextDouble(), (float)rnd.NextDouble(), (float)rnd.NextDouble(), 1);
                //Console.WriteLine(loc);
                //m_sp.SetUniform("outClr", (float)rnd.NextDouble(), (float)rnd.NextDouble(), (float)rnd.NextDouble(), 1);
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
