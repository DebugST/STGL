using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;

using STLib.OpenGL.GL;
using STLib.OpenGL.GLFW;

using STLib.OpenGL.GLM;
using System.Runtime.InteropServices;

namespace STGL
{
    class Program
    {
        static unsafe void Main(string[] args) {
            Tutorials._1_7_Texture.Run();
            return;
            var ortho = GLM.Ortho(0.0f, 800.0f, 0.0f, 600.0f, 0.1f, 100.0f);
            var proj = GLM.Perspective((float)GLM.Radians(45.0f), (float)800 / 600, 0.1f, 100.0f);
            var fsdf = ortho * proj;
            Matrix4F mat = Matrix4F.Identity;
            mat[0, 3] = 4f;
            var swp = mat.SwapRowCol();
            var aaa = mat[0][3];

        }
    }
}
