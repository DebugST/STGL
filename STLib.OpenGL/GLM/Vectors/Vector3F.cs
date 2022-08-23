using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GLM
{
    public struct Vector3F
    {
        public float X;
        public float Y;
        public float Z;

        public static readonly Vector3F Zero;
        public static readonly Vector3F One = new Vector3F(1, 1, 1);
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

        public Vector3F(Vector4F v) {
            this.X = v.X;
            this.Y = v.Y;
            this.Z = v.Z;
        }

        public override string ToString() {
            return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
        }

        public float this[int nIndex] {
            get {
                switch (nIndex) {
                    case 0: return this.X;
                    case 1: return this.Y;
                    case 2: return this.Z;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set {
                switch (nIndex) {
                    case 0: this.X = value; break;
                    case 1: this.Y = value; break;
                    case 2: this.Z = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
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
            return this * (float)(1 / this.Length);
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

        public static Vector3F operator -(float v, Vector3F vec) {
            vec.X = v - vec.X;
            vec.Y = v - vec.Y;
            vec.Z = v - vec.Z;
            return vec;
        }

        public static Vector3F operator -(Vector3F vec) {
            vec.X = -vec.X;
            vec.Y = -vec.Y;
            vec.Z = -vec.Z;
            return vec;
        }


        public static Vector3F operator *(Vector3F a, Vector4F b) {
            return new Vector3F(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        }

        public static Vector3F operator *(float v, Vector3F vec) {
            vec.X *= v;
            vec.Y *= v;
            vec.Z *= v;
            return vec;
        }

        public static Vector3F operator *(Vector3F vec, float v) {
            vec.X *= v;
            vec.Y *= v;
            vec.Z *= v;
            return vec;
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

        public static Vector3F operator /(float v, Vector3F vec) {
            vec.X = v / vec.X;
            vec.Y = v / vec.Y;
            vec.Z = v / vec.Z;
            return vec;
        }

        public static bool operator ==(Vector3F a, Vector3F b) {
            if (a.X != b.X) return false;
            if (a.Y != b.Y) return false;
            if (a.Z != b.Z) return false;
            return true;
        }

        public static bool operator !=(Vector3F a, Vector3F b) {
            return !(a == b);
        }
    }
}
