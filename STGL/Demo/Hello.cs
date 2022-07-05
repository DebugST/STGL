using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using STLib.OpenGL;
using STLib.OpenGL.GL;
using STLib.OpenGL.GLFW;

namespace STGL.Demo
{
    class Hello
    {
        const int SCR_WIDTH = 400;
        const int SCR_HEIGHT = 300;

        static string vertexShaderSource = "#version 330 core\n" +
            "layout (location = 0) in vec3 position;\n" +
            "void main()\n" +
            "{\n" +
            "gl_Position = vec4(position.x, position.y, position.z, 1.0);\n" +
            "}\0";
        static string fragmentShaderSource = "#version 330 core\n" +
            "out vec4 color;\n" +
            "void main()\n" +
            "{\n" +
            "color = vec4(1.0f, 0.5f, 0.2f, 1.0f);\n" +
            "}\n\0";

        public static int Start() {
            // Init GLFW
            GLFW.Init();
            // Set all the required options for GLFW
            GLFW.WindowHint(GLFW.CONTEXT_VERSION_MAJOR, 3);
            GLFW.WindowHint(GLFW.CONTEXT_VERSION_MINOR, 3);
            GLFW.WindowHint(GLFW.OPENGL_PROFILE, GLFW.OPENGL_CORE_PROFILE);
            GLFW.WindowHint(GLFW.RESIZABLE, GL.GL_FALSE);
            if (RuntimeInfo.System == RuntimeInfo.SystemType.Mac) {
                GLFW.WindowHint(GLFW.OPENGL_FORWARD_COMPAT, GL.GL_TRUE);
            }
            // Create a GLFWwindow object that we can use for GLFW's functions
            IntPtr window = GLFW.CreateWindow(SCR_WIDTH, SCR_HEIGHT,
                "[" + RuntimeInfo.System + "][" + RuntimeInfo.Platform + "][" + RuntimeInfo.Bit + "] - " + RuntimeInfo.Version,
                IntPtr.Zero, IntPtr.Zero);
            GLFW.MakeContextCurrent(window);

            // Set the required callback functions
            GLFW.SetKeyCallback(window, key_callback);

            // Set this to true so GLEW knows to use a modern approach to retrieving function pointers and extensions
            //glewExperimental = GL_TRUE;
            // Initialize GLEW to setup the OpenGL Function pointers
            //glewInit();
            try {
                GL.Init(GLFW.GetProcAddress);
                Console.WriteLine("GLFW: " + GLFW.GetVersionString());
                Console.WriteLine(GL.Info);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                GLFW.Terminate();
                return -1;
            }

            // Define the viewport dimensions
            int width = 0, height = 0;
            GLFW.GetFramebufferSize(window, ref width, ref height);
            GL.Viewport(0, 0, width, height);


            // Build and compile our shader program
            // Vertex shader
            var vertexShader = GL.CreateShader(GL.GL_VERTEX_SHADER);
            GL.ShaderSource(vertexShader, vertexShaderSource);
            GL.CompileShader(vertexShader);
            // Check for compile time errors
            int success = 0, nLen = 0;
            byte[] infoLog = new byte[512];
            GL.GetShaderiv(vertexShader, GL.GL_COMPILE_STATUS, ref success);
            if (success == 0) {
                GL.GetShaderInfoLog(vertexShader, 512, ref nLen, ref infoLog[0]);
                Console.WriteLine("ERROR::SHADER::VERTEX::COMPILATION_FAILED");
                Console.WriteLine(Encoding.UTF8.GetString(infoLog, 0, nLen));
            }
            // Fragment shader
            var fragmentShader = GL.CreateShader(GL.GL_FRAGMENT_SHADER);
            string[] strs = new string[] { fragmentShaderSource };
            GL.ShaderSource(fragmentShader, strs);
            GL.CompileShader(fragmentShader);
            // Check for compile time errors
            success = GL.GetShaderiv(fragmentShader, GL.GL_COMPILE_STATUS);
            if (success == 0) {
                //glGetShaderInfoLog(fragmentShader, 512, NULL, infoLog);
                Console.WriteLine("ERROR::SHADER::FRAGMENT::COMPILATION_FAILED");
                Console.WriteLine(GL.GetShaderInfoLog(fragmentShader));
            }
            // Link shaders
            var shaderProgram = GL.CreateProgram();
            GL.AttachShader(shaderProgram, vertexShader);
            GL.AttachShader(shaderProgram, fragmentShader);
            GL.LinkProgram(shaderProgram);
            // Check for linking errors
            success = GL.GetProgramiv(shaderProgram, GL.GL_LINK_STATUS);
            if (success == 0) {
                //glGetProgramInfoLog(shaderProgram, 512, NULL, infoLog);
                Console.WriteLine("ERROR::SHADER::PROGRAM::LINKING_FAILED");
                Console.WriteLine(GL.GetProgramInfoLog(shaderProgram));
            }
            GL.DeleteShader(vertexShader);
            GL.DeleteShader(fragmentShader);


            // Set up vertex data (and buffer(s)) and attribute pointers
            // We add a new set of vertices to form a second triangle (a total of 6 vertices); the vertex attribute configuration remains the same (still one 3-float position vector per vertex)
            float[] firstTriangle = {
                -0.9f,  0.5f, 0.0f,  // Left 
                -0.0f,  0.5f, 0.0f,  // Right
                -0.45f,-0.5f, 0.0f,  // bottom 
            };
            float[] secondTriangle = {
                 0.0f, -0.5f, 0.0f,  // Left
                 0.9f, -0.5f, 0.0f,  // Right
                 0.45f, 0.5f, 0.0f   // Top 
            };
            uint[] VBOs = new uint[2];//, VAOs = new uint[2];
            var VAOs = GL.GenVertexArrays(2); // We can also generate multiple VAOs or buffers at the same time
            GL.GenBuffers(2, ref VBOs[0]);
            // ================================
            // First Triangle setup
            // ===============================
            GL.BindVertexArray(VAOs[0]);
            GL.BindBuffer(GL.GL_ARRAY_BUFFER, VBOs[0]);
            GL.BufferData(GL.GL_ARRAY_BUFFER, MarshalExtend.SizeOf(firstTriangle), firstTriangle, GL.GL_STATIC_DRAW);
            GL.VertexAttribPointer(0, 3, GL.GL_FLOAT, false, 3 * sizeof(float), IntPtr.Zero);   // Vertex attributes stay the same
            GL.EnableVertexAttribArray(0);
            GL.BindVertexArray(0);
            // ================================
            // Second Triangle setup
            // ===============================
            GL.BindVertexArray(VAOs[1]); // Note that we bind to a different VAO now
            GL.BindBuffer(GL.GL_ARRAY_BUFFER, VBOs[1]); // And a different VBO
            GL.BufferData(GL.GL_ARRAY_BUFFER, MarshalExtend.SizeOf(secondTriangle), secondTriangle, GL.GL_STATIC_DRAW);
            GL.VertexAttribPointer(0, 3, GL.GL_FLOAT, false, 0, IntPtr.Zero); // Because the vertex data is tightly packed we can also specify 0 as the vertex attribute's stride to let OpenGL figure it out.
            GL.EnableVertexAttribArray(0);
            GL.BindVertexArray(0);

            // Game loop
            while (!GLFW.WindowShouldClose(window)) {
                // Check if any events have been activiated (key pressed, mouse moved etc.) and call corresponding response functions
                GLFW.WaitEvents();

                // Render
                // Clear the colorbuffer
                GL.ClearColor(1f, 1f, 1f, 1.0f);
                GL.Clear(GL.GL_COLOR_BUFFER_BIT);

                // Activate shader (same shader for both triangles)
                GL.UseProgram(shaderProgram);
                // Draw first triangle using the data from the first VAO
                GL.BindVertexArray(VAOs[0]);
                GL.DrawArrays(GL.GL_TRIANGLES, 0, 3);
                // Then we draw the second triangle using the data from the second VAO
                GL.BindVertexArray(VAOs[1]);
                GL.DrawArrays(GL.GL_TRIANGLES, 0, 3);
                GL.BindVertexArray(0);

                // Swap the screen buffers
                GLFW.SwapBuffers(window);
            }
            // Properly de-allocate all resources once they've outlived their purpose
            GL.DeleteVertexArrays(VAOs);
            GL.DeleteBuffers(VBOs, 2);
            // Terminate GLFW, clearing any resources allocated by GLFW.
            GLFW.Terminate();
            return 0;
        }

        // Is called whenever a key is pressed/released via GLFW
        static void key_callback(IntPtr window, int key, int scancode, int action, int mode) {
            if (key == GLFW.KEY_ESCAPE && action == GLFW.PRESS)
                GLFW.SetWindowShouldClose(window, true);
        }
    }
}
