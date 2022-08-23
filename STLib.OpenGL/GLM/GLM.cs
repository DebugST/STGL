using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GLM
{
    public partial class GLM
    {
        public static double Radians(double angle) {
            return angle * (Math.PI / 180);
        }

        public static double Degress(double angle) {
            return angle * (180 / Math.PI);
        }
    }
}
