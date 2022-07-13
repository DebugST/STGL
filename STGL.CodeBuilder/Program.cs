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
            Directory.CreateDirectory("./OutPath");
            char[] chs = { 'I', 'F', 'D' };
            for (int i = 2; i < 5; i++) {
                for (int j = 0; j < chs.Length; j++) {
                    using (StreamWriter writer = new StreamWriter("./OutPath/Vector" + i + chs[j] + ".cs", false, Encoding.UTF8)) {
                        writer.WriteLine(@"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL.Mathematics
{");
                        writer.WriteLine(VectorHelper.GetCode(i, chs[j]));
                        writer.WriteLine("}");
                    }
                }
            }
            var vec = VectorHelper.GetCode(2, 'F');
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
