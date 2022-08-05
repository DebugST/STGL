using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GLM
{
    public partial class GLM
    {
        public static double Radians(double degress) {
            return degress * (Math.PI / 180);
        }

        public static double Degress(double radians) {
            return radians * (180 / Math.PI);
        }
    }
}
