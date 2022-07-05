using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

using STLib.OpenGL.GLFW;

namespace STGL.CodeBuilder
{
    class Program
    {
        static void Main(string[] args) {
            byte[] byLibs = ResourceManager.CreateLibFiles("./lib");
            using (FileStream fs = new FileStream("glfw.libs", FileMode.Create)) {
                fs.Write(byLibs, 0, byLibs.Length);
            }
            var aa = ResourceManager.GetResources(File.ReadAllBytes("glfw.libs"));
            string str = PointerHelper.GetCode();
            GLDocProcessor.Start("./InPath", "./OutPath");
        }
    }
}
