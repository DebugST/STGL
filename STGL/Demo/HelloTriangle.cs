using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using STLib.OpenGL;
using STLib.OpenGL.GL;
using STLib.OpenGL.GLFW;

namespace STGL.Demo
{
    /// <summary>
    /// https://learnopengl.com/Getting-started/Hello-Triangle
    /// https://learnopengl.com/code_viewer_gh.php?code=src/1.getting_started/2.2.hello_triangle_indexed/hello_triangle_indexed.cpp
    /// </summary>
    class HelloTriangle
    {
        const int SCR_WIDTH = 800;
        const int SCR_HEIGHT = 600;

        static string vertexShaderSource = "#version 330 core\n" +
            "layout (location = 0) in vec3 aPos;\n" +
            "void main()\n" +
            "{\n" +
            "   gl_Position = vec4(aPos.x, aPos.y, aPos.z, 1.0);\n" +
            "}\0";
        static string fragmentShaderSource = "#version 330 core\n" +
             "out vec4 FragColor;\n" +
             "void main()\n" +
             "{\n" +
             "   FragColor = vec4(1.0f, 0.5f, 0.2f, 1.0f);\n" +
             "}\n\0";

        public static int Start() {
            // glfw: initialize and configure
            // ------------------------------
            GLFW.Init();
            GLFW.WindowHint(GLFW.CONTEXT_VERSION_MAJOR, 3);
            GLFW.WindowHint(GLFW.CONTEXT_VERSION_MINOR, 3);
            GLFW.WindowHint(GLFW.OPENGL_PROFILE, GLFW.OPENGL_CORE_PROFILE);

            if ( RuntimeInfo.System == RuntimeInfo.SystemType.Mac) {
                GLFW.WindowHint(GLFW.OPENGL_FORWARD_COMPAT, GL.GL_TRUE); // For Mac system
            }

            // glfw window creation
            // --------------------
            IntPtr window = GLFW.CreateWindow(SCR_WIDTH, SCR_HEIGHT, "LearnOpenGL", IntPtr.Zero, IntPtr.Zero);
            if (window == IntPtr.Zero) {
                Console.WriteLine("Failed to create GLFW window");
                GLFW.Terminate();
                return -1;
            }
            GLFW.MakeContextCurrent(window);
            GLFW.SetFramebufferSizeCallback(window, framebuffer_size_callback);
            //GLFW.windows

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

            // build and compile our shader program
            // ------------------------------------
            // vertex shader
            var vertexShader = GL.CreateShader(GL.GL_VERTEX_SHADER);
            GL.ShaderSource(vertexShader, vertexShaderSource); // overload
            GL.CompileShader(vertexShader);
            // check for shader compile errors
            int success = 0;
            byte[] infoLog = new byte[512];
            GL.GetShaderiv(vertexShader, GL.GL_COMPILE_STATUS, ref success);
            if (success == 0) {
                int nLen = 0;
                GL.GetShaderInfoLog(vertexShader, 512, ref nLen, ref infoLog[0]);
                Console.WriteLine("ERROR::SHADER::VERTEX::COMPILATION_FAILED\n" + Encoding.UTF8.GetString(infoLog, 0, nLen));
            }
            // fragment shader
            var fragmentShader = GL.CreateShader(GL.GL_FRAGMENT_SHADER);
            GL.ShaderSource(fragmentShader, fragmentShaderSource); // overload
            GL.CompileShader(fragmentShader);
            // check for shader compile errors
            success = GL.GetShaderiv(fragmentShader, GL.GL_COMPILE_STATUS); // overload
            if (success == 0) {
                //glGetShaderInfoLog(fragmentShader, 512, NULL, infoLog);
                Console.WriteLine(
                    "ERROR::SHADER::FRAGMENT::COMPILATION_FAILED\n" +
                    GL.GetShaderInfoLog(fragmentShader) // overload
                    );
            }
            // link shaders
            var shaderProgram = GL.CreateProgram();
            GL.AttachShader(shaderProgram, vertexShader);
            GL.AttachShader(shaderProgram, fragmentShader);
            GL.LinkProgram(shaderProgram);
            // check for linking errors
            success = GL.GetProgramiv(shaderProgram, GL.GL_LINK_STATUS);
            if (success == 0) {
                //glGetProgramInfoLog(shaderProgram, 512, NULL, infoLog);
                Console.WriteLine(
                    "ERROR::SHADER::PROGRAM::LINKING_FAILED\n" +
                    GL.GetProgramInfoLog(shaderProgram) // overload
                    );
            }
            GL.DeleteShader(vertexShader);
            GL.DeleteShader(fragmentShader);

            // set up vertex data (and buffer(s)) and configure vertex attributes
            // ------------------------------------------------------------------
            float[] vertices = {
                 0.5f,  0.5f, 0.0f,  // top right
                 0.5f, -0.5f, 0.0f,  // bottom right
                -0.5f, -0.5f, 0.0f,  // bottom left
                -0.5f,  0.5f, 0.0f   // top left 
            };
            uint[] indices = {  // note that we start from 0!
                0, 1, 3,  // first Triangle
                1, 2, 3   // second Triangle
            };
            uint VBO = 0, VAO = 0, EBO = 0;
            GL.GenVertexArrays(1, ref VAO);
            GL.GenBuffers(1, ref VBO);
            EBO = GL.GenBuffers();  // overload
            // bind the Vertex Array Object first, then bind and set vertex buffer(s), and then configure vertex attributes(s).
            GL.BindVertexArray(VAO);

            GL.BindBuffer(GL.GL_ARRAY_BUFFER, VBO);
            GL.BufferData(GL.GL_ARRAY_BUFFER, MarshalExtend.SizeOf(vertices), vertices, GL.GL_STATIC_DRAW);

            GL.BindBuffer(GL.GL_ELEMENT_ARRAY_BUFFER, EBO);
            GL.BufferData(GL.GL_ELEMENT_ARRAY_BUFFER, MarshalExtend.SizeOf(indices), indices, GL.GL_STATIC_DRAW);

            GL.VertexAttribPointer(0, 3, GL.GL_FLOAT, false, 3 * sizeof(float), IntPtr.Zero);
            GL.EnableVertexAttribArray(0);

            // note that this is allowed, the call to glVertexAttribPointer registered VBO as the vertex attribute's bound vertex buffer object so afterwards we can safely unbind
            GL.BindBuffer(GL.GL_ARRAY_BUFFER, 0);

            // remember: do NOT unbind the EBO while a VAO is active as the bound element buffer object IS stored in the VAO; keep the EBO bound.
            //glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, 0);

            // You can unbind the VAO afterwards so other VAO calls won't accidentally modify this VAO, but this rarely happens. Modifying other
            // VAOs requires a call to glBindVertexArray anyways so we generally don't unbind VAOs (nor VBOs) when it's not directly necessary.
            GL.BindVertexArray(0);


            // uncomment this call to draw in wireframe polygons.
            //glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);

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

                // draw our first triangle
                GL.UseProgram(shaderProgram);
                GL.BindVertexArray(VAO); // seeing as we only have a single VAO there's no need to bind it every time, but we'll do so to keep things a bit more organized
                //glDrawArrays(GL_TRIANGLES, 0, 6);
                GL.DrawElements(GL.GL_TRIANGLES, 6, GL.GL_UNSIGNED_INT, IntPtr.Zero);
                // glBindVertexArray(0); // no need to unbind it every time 

                // glfw: swap buffers and poll IO events (keys pressed/released, mouse moved etc.)
                // -------------------------------------------------------------------------------
                GLFW.SwapBuffers(window);
                GLFW.WaitEvents();
            }

            // optional: de-allocate all resources once they've outlived their purpose:
            // ------------------------------------------------------------------------
            GL.DeleteVertexArrays(1, ref VAO);
            GL.DeleteBuffers(1, ref VBO);
            GL.DeleteBuffers(1, ref EBO);
            GL.DeleteProgram(shaderProgram);

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
