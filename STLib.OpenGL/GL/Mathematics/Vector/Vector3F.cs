using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL.Mathematics
{

    public struct Vector3F
    {
        public float X;
        public float Y;
        public float Z;

        public static readonly Vector3F Zero;
        public static readonly Vector3F UnitX = new Vector3F(1, 0, 0);
        public static readonly Vector3F UnitY = new Vector3F(0, 1, 0);
        public static readonly Vector3F UnitZ = new Vector3F(0, 0, 0);

        public double Length {
            get {
                return Math.Sqrt(this.X * this.X + this.Y * this.Y + this.Z * this.Z);
            }
        }

        public Vector3F(float x, float y, float z) {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString() {
            return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
        }

        public float Dot(Vector3F vec) {
            float ret = 0;
            ret += this.X * vec.X;
            ret += this.Y * vec.Y;
            ret += this.Z * vec.Z;
            return ret;
        }

        public Vector3F Cross(Vector3F vec) {
            var ret = Vector3F.Zero;
            ret.X = this.Y * vec.Z - this.Z * vec.Y;
            ret.Y = this.Z * vec.X - this.X * vec.Z;
            ret.Z = this.X * vec.Y - this.Y * vec.X;
            return ret;
        }

        public Vector3F GetNormalize() {
            var vec = Vector3F.Zero;
            var f = 1 / this.Length;
            vec.X = (float)(this.X * f);
            vec.Y = (float)(this.Y * f);
            vec.Z = (float)(this.Z * f);
            return vec;
        }

        public void Normalize() {
            var f = 1 / this.Length;
            this.X = (float)(this.X * f);
            this.Y = (float)(this.Y * f);
            this.Z = (float)(this.Z * f);
        }

        public static Vector3F operator +(Vector3F a, Vector3F b) {
            a.X += b.X;
            a.Y += b.Y;
            a.Z += b.Z;
            return a;
        }

        public static Vector3F operator +(Vector3F vec, float v) {
            vec.X += v;
            vec.Y += v;
            vec.Z += v;
            return vec;
        }

        public static Vector3F operator +(float v, Vector3F vec) {
            vec.X += v;
            vec.Y += v;
            vec.Z += v;
            return vec;
        }


        public static Vector3F operator -(Vector3F a, Vector3F b) {
            a.X -= b.X;
            a.Y -= b.Y;
            a.Z -= b.Z;
            return a;
        }

        public static Vector3F operator -(Vector3F vec, float v) {
            vec.X -= v;
            vec.Y -= v;
            vec.Z -= v;
            return vec;
        }

        //public static Vector3F operator -(float v, Vector3F vec) {
        //    vec.X = v - vec.X;
        //    vec.Y = v - vec.Y;
        //    vec.Z = v - vec.Z;
        //    return vec;
        //}

        public static Vector3F operator -(Vector3F v3f) {
            v3f.X = -v3f.X;
            v3f.Y = -v3f.Y;
            v3f.Z = -v3f.Z;
            return v3f;
        }

        public static Vector3F operator /(Vector3F a, Vector3F b) {
            a.X /= b.X;
            a.Y /= b.Y;
            a.Z /= b.Z;
            return a;
        }

        public static Vector3F operator /(Vector3F vec, float v) {
            vec.X /= v;
            vec.Y /= v;
            vec.Z /= v;
            return vec;
        }

        //public static Vector3F operator /(float v, Vector3F vec) {
        //    vec.X = v / vec.X;
        //    vec.Y = v / vec.Y;
        //    vec.Z = v / vec.Z;
        //    return vec;
        //}
    }
}
