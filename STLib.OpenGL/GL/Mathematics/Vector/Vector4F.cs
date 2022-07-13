using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL.Mathematics
{

    public struct Vector4F
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        public static readonly Vector4F Zero;
        public static readonly Vector4F UnitX = new Vector4F(1, 0, 0, 0);
        public static readonly Vector4F UnitY = new Vector4F(0, 1, 0, 0);
        public static readonly Vector4F UnitZ = new Vector4F(0, 0, 1, 0);
        public static readonly Vector4F UnitW = new Vector4F(0, 0, 0, 1);

        public double Length {
            get {
                return Math.Sqrt(this.X * this.X + this.Y * this.Y + this.Z * this.Z + this.W * this.W);
            }
        }

        public Vector4F(float x, float y, float z, float w) {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }

        public override string ToString() {
            return string.Format("({0}, {1}, {2}, {3})", this.X, this.Y, this.Z, this.W);
        }

        public float Dot(Vector4F vec) {
            float ret = 0;
            ret += this.X * vec.X;
            ret += this.Y * vec.Y;
            ret += this.Z * vec.Z;
            ret += this.W * vec.W;
            return ret;
        }

        public Vector4F GetNormalize() {
            var vec = Vector4F.Zero;
            var f = 1 / this.Length;
            vec.X = (float)(this.X * f);
            vec.Y = (float)(this.Y * f);
            vec.Z = (float)(this.Z * f);
            vec.W = (float)(this.W * f);
            return vec;
        }

        public void Normalize() {
            var f = 1 / this.Length;
            this.X = (float)(this.X * f);
            this.Y = (float)(this.Y * f);
            this.Z = (float)(this.Z * f);
            this.W = (float)(this.W * f);
        }

        public static Vector4F operator +(Vector4F a, Vector4F b) {
            a.X += b.X;
            a.Y += b.Y;
            a.Z += b.Z;
            a.W += b.W;
            return a;
        }

        public static Vector4F operator +(Vector4F vec, float v) {
            vec.X += v;
            vec.Y += v;
            vec.Z += v;
            vec.W += v;
            return vec;
        }

        public static Vector4F operator +(float v, Vector4F vec) {
            vec.X += v;
            vec.Y += v;
            vec.Z += v;
            vec.W += v;
            return vec;
        }


        public static Vector4F operator -(Vector4F a, Vector4F b) {
            a.X -= b.X;
            a.Y -= b.Y;
            a.Z -= b.Z;
            a.W -= b.W;
            return a;
        }

        public static Vector4F operator -(Vector4F vec, float v) {
            vec.X -= v;
            vec.Y -= v;
            vec.Z -= v;
            vec.W -= v;
            return vec;
        }

        //public static Vector4F operator -(float v, Vector4F vec) {
        //    vec.X = v - vec.X;
        //    vec.Y = v - vec.Y;
        //    vec.Z = v - vec.Z;
        //    vec.W = v - vec.W;
        //    return vec;
        //}

        public static Vector4F operator -(Vector4F vec) {
            vec.X = -vec.X;
            vec.Y = -vec.Y;
            vec.Z = -vec.Z;
            vec.W = -vec.W;
            return vec;
        }


        public static Vector4F operator /(Vector4F a, Vector4F b) {
            a.X /= b.X;
            a.Y /= b.Y;
            a.Z /= b.Z;
            a.W /= b.W;
            return a;
        }

        public static Vector4F operator /(Vector4F vec, float v) {
            vec.X /= v;
            vec.Y /= v;
            vec.Z /= v;
            vec.W /= v;
            return vec;
        }

        //public static Vector4F operator /(float v, Vector4F vec) {
        //    vec.X = v / vec.X;
        //    vec.Y = v / vec.Y;
        //    vec.Z = v / vec.Z;
        //    vec.W = v / vec.W;
        //    return vec;
        //}
    }
}
