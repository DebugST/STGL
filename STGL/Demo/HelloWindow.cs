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
    /// https://learnopengl.com/Getting-started/Hello-Window
    /// https://learnopengl.com/code_viewer_gh.php?code=src/1.getting_started/1.2.hello_window_clear/hello_window_clear.cpp
    /// </summary>
    class HelloWindow
    {
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
