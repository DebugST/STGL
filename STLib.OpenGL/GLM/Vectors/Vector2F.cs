using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GLM
{
    public struct Vector2F
    {
        public float X;
        public float Y;

        public static readonly Vector2F Zero;
        public static readonly Vector2F One = new Vector2F(1, 1);
        public static readonly Vector2F UnitX = new Vector2F(1, 0);
        public static readonly Vector2F UnitY = new Vector2F(0, 1);
        public static readonly Vector2F UnitZ = new Vector2F(0, 0);

        public double Length {
            get {
                return Math.Abs(this.X - this.Y);
            }
        }

        public Vector2F(float x, float y) {
            this.X = x;
            this.Y = y;
        }

        public override string ToString() {
            return string.Format("({0}, {1})", this.X, this.Y);
        }

        public float this[int nIndex] {
            get {
                switch (nIndex) {
                    case 0: return this.X;
                    case 1: return this.Y;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set {
                switch (nIndex) {
                    case 0: this.X = value; break;
                    case 1: this.Y = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }

        public float Dot(Vector2F vec) {
            float ret = 0;
            ret += this.X * vec.X;
            ret += this.Y * vec.Y;
            return ret;
        }

        public Vector2F GetNormalize() {
            return this * (float)(1 / this.Length);
        }

        public void Normalize() {
            var f = 1 / this.Length;
            this.X = (float)(this.X * f);
            this.Y = (float)(this.Y * f);
        }

        public static Vector2F operator +(Vector2F a, Vector2F b) {
            a.X += b.X;
            a.Y += b.Y;
            return a;
        }

        public static Vector2F operator +(Vector2F vec, float v) {
            vec.X += v;
            vec.Y += v;
            return vec;
        }

        public static Vector2F operator +(float v, Vector2F vec) {
            vec.X += v;
            vec.Y += v;
            return vec;
        }


        public static Vector2F operator -(Vector2F a, Vector2F b) {
            a.X -= b.X;
            a.Y -= b.Y;
            return a;
        }

        public static Vector2F operator -(Vector2F vec, float v) {
            vec.X -= v;
            vec.Y -= v;
            return vec;
        }

        public static Vector2F operator -(float v, Vector2F vec) {
            vec.X = v - vec.X;
            vec.Y = v - vec.Y;
            return vec;
        }

        public static Vector2F operator -(Vector2F vec) {
            vec.X = -vec.X;
            vec.Y = -vec.Y;
            return vec;
        }


        public static Vector2F operator *(Vector2F a, Vector4F b) {
            return new Vector2F(a.X * b.X, a.Y * b.Y);
        }

        public static Vector2F operator *(float v, Vector2F vec) {
            vec.X *= v;
            vec.Y *= v;
            return vec;
        }

        public static Vector2F operator *(Vector2F vec, float v) {
            vec.X *= v;
            vec.Y *= v;
            return vec;
        }


        public static Vector2F operator /(Vector2F a, Vector2F b) {
            a.X /= b.X;
            a.Y /= b.Y;
            return a;
        }

        public static Vector2F operator /(Vector2F vec, float v) {
            vec.X /= v;
            vec.Y /= v;
            return vec;
        }

        public static Vector2F operator /(float v, Vector2F vec) {
            vec.X = v / vec.X;
            vec.Y = v / vec.Y;
            return vec;
        }
    }
}
