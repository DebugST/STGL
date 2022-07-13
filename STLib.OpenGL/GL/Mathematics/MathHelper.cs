using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL.Mathematics
{
    public class MathHelper
    {
        public static double DegressToRadians(double d) {
            return d * (Math.PI / 180);
        }

        public static double RadiansToDegress(double r) {
            return r * (180 / Math.PI);
        }
    }
}
