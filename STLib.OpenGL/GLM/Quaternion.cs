using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GLM
{
    public struct Quaternion
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        public static readonly Quaternion Unit = new Quaternion(0, 0, 0, 1);

        public override string ToString() {
            return string.Format("({0},{1},{2},{3})", this.W, this.X, this.Y, this.Z);
        }

        public Quaternion(Vector3F v, float w) {
            this.X = v.X;
            this.Y = v.Y;
            this.Z = v.Z;
            this.W = w;
        }

        public Quaternion(float x, float y, float z, float w) {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }

        public Quaternion(Vector3F eulerAngle) {
            var v = new Vector3F(
                (float)GLM.Radians(eulerAngle.X),
                (float)GLM.Radians(eulerAngle.Y),
                (float)GLM.Radians(eulerAngle.Z)
            );
            v *= 0.5f;
            var c = new Vector3F((float)Math.Cos(v.X), (float)Math.Cos(v.Y), (float)Math.Cos(v.Z));
            var s = new Vector3F((float)Math.Sin(v.X), (float)Math.Sin(v.Y), (float)Math.Sin(v.Z));

            this.W = c.X * c.Y * c.Z + s.X * s.Y * s.Z;
            this.X = s.X * c.Y * c.Z - c.X * s.Y * s.Z;
            this.Y = c.X * s.Y * c.Z + s.X * c.Y * s.Z;
            this.Z = c.X * c.Y * s.Z - s.X * s.Y * c.Z;
        }

        // ==================================================
        public static Quaternion operator -(Quaternion q) {
            return new Quaternion(-q.X, -q.Y, -q.Z, -q.W);
        }

        public static Quaternion operator +(Quaternion p, Quaternion q) {
            return new Quaternion(
                p.X + q.X,
                p.Y + q.Y,
                p.Z + q.Z,
                p.W + q.W
                );
        }

        public static Quaternion operator *(Quaternion q, Quaternion p) {
            return new Quaternion(
                q.W * p.X + q.X * p.W + q.Y * p.Z - q.Z * p.Y,
                q.W * p.Y + q.Y * p.W + q.Z * p.X - q.X * p.Z,
                q.W * p.Z + q.Z * p.W + q.X * p.Y - q.Y * p.X,
                q.W * p.W - q.X * p.X - q.Y * p.Y - q.Z * p.Z
                );
        }

        public static Quaternion operator /(Quaternion q, float s) {
            return new Quaternion(q.X / s, q.Y / s, q.Z / s, q.W / s);
        }
        // ==================================================
        public float Dot(Quaternion q) {
            return this.X * q.X + this.Y * q.Y + this.Z * q.Z + this.W * q.W;
        }

        public Quaternion Cross(Quaternion q) {
            return this * q;
        }

        public Quaternion Conjugate() {
            return new Quaternion(-this.X, -this.Y, -this.Z, this.W);
        }

        public Quaternion Inverse() {
            return this.Conjugate() / this.Dot(this);
        }

        public Matrix3F ToMatrix3F() {
            var q = this;
            Matrix3F mat = Matrix3F.Identity;
            mat[0, 0] = 1 - 2 * q.Y * q.Y - 2 * q.Z * q.Z;
            mat[0, 1] = 2 * q.X * q.Y + 2 * q.W * q.Z;
            mat[0, 2] = 2 * q.X * q.Z - 2 * q.W * q.Y;

            mat[1, 0] = 2 * q.X * q.Y - 2 * q.W * q.Z;
            mat[1, 1] = 1 - 2 * q.X * q.X - 2 * q.Z * q.Z;
            mat[1, 2] = 2 * q.Y * q.Z + 2 * q.W * q.X;

            mat[2, 0] = 2 * q.X * q.Z + 2 * q.W * q.Y;
            mat[2, 1] = 2 * q.Y * q.Z - 2 * q.W * q.X;
            mat[2, 2] = 1 - 2 * q.X * q.X - 2 * q.Y * q.Y;
            return mat;
        }

        public Matrix4F ToMatrix4F() {
            var mat = this.ToMatrix3F();
            return new Matrix4F(
                new Vector4F(mat[0, 0], mat[0, 1], mat[0, 2], 0),
                new Vector4F(mat[1, 0], mat[1, 1], mat[1, 2], 0),
                new Vector4F(mat[2, 0], mat[2, 1], mat[2, 2], 0),
                Vector4F.UnitW
                );
        }
    }
}
