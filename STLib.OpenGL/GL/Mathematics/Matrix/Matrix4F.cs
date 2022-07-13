using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GL.Mathematics
{
    public struct Matrix4F
    {
        public Vector4F Row0;
        public Vector4F Row1;
        public Vector4F Row2;
        public Vector4F Row3;

        public static readonly Matrix4F Zero;
        public static readonly Matrix4F Identity = new Matrix4F(Vector4F.UnitX, Vector4F.UnitY, Vector4F.UnitZ, Vector4F.UnitW);

        public Matrix4F(Vector4F row0, Vector4F row1, Vector4F row2, Vector4F row3) {
            this.Row0 = row0;
            this.Row1 = row1;
            this.Row2 = row2;
            this.Row3 = row3;
        }

        public override string ToString() {
            return string.Format("[{0},{1},{2},{3}]", this.Row0, this.Row1, this.Row2, this.Row3);
        }

        public Matrix4F SwapRowCol() {
            Matrix4F mat;
            mat.Row0 = new Vector4F(this.Row0.X, this.Row1.X, this.Row2.X, this.Row3.X);
            mat.Row1 = new Vector4F(this.Row0.Y, this.Row1.Y, this.Row2.Y, this.Row3.Y);
            mat.Row2 = new Vector4F(this.Row0.Z, this.Row1.Z, this.Row2.Z, this.Row3.Z);
            mat.Row3 = new Vector4F(this.Row0.W, this.Row1.W, this.Row2.W, this.Row3.W);
            return mat;
        }

        public static Matrix4F operator *(Matrix4F a, Matrix4F b) {
            var mat = Matrix4F.Zero;

            var v00 = a.Row0.X * b.Row0.X + a.Row0.Y * b.Row1.X + a.Row0.Z * b.Row2.X + a.Row0.W * b.Row3.X;
            var v01 = a.Row0.X * b.Row0.Y + a.Row0.Y * b.Row1.Y + a.Row0.Z * b.Row2.Y + a.Row0.W * b.Row3.Y;
            var v02 = a.Row0.X * b.Row0.Z + a.Row0.Y * b.Row1.Z + a.Row0.Z * b.Row2.Z + a.Row0.W * b.Row3.Z;
            var v03 = a.Row0.X * b.Row0.W + a.Row0.Y * b.Row1.W + a.Row0.Z * b.Row2.W + a.Row0.W * b.Row3.W;

            var v10 = a.Row1.X * b.Row0.X + a.Row1.Y * b.Row1.X + a.Row1.Z * b.Row2.X + a.Row1.W * b.Row3.X;
            var v11 = a.Row1.X * b.Row0.Y + a.Row1.Y * b.Row1.Y + a.Row1.Z * b.Row2.Y + a.Row1.W * b.Row3.Y;
            var v12 = a.Row1.X * b.Row0.Z + a.Row1.Y * b.Row1.Z + a.Row1.Z * b.Row2.Z + a.Row1.W * b.Row3.Z;
            var v13 = a.Row1.X * b.Row0.W + a.Row1.Y * b.Row1.W + a.Row1.Z * b.Row2.W + a.Row1.W * b.Row3.W;

            var v20 = a.Row2.X * b.Row0.X + a.Row2.Y * b.Row1.X + a.Row2.Z * b.Row2.X + a.Row2.W * b.Row3.X;
            var v21 = a.Row2.X * b.Row0.Y + a.Row2.Y * b.Row1.Y + a.Row2.Z * b.Row2.Y + a.Row2.W * b.Row3.Y;
            var v22 = a.Row2.X * b.Row0.Z + a.Row2.Y * b.Row1.Z + a.Row2.Z * b.Row2.Z + a.Row2.W * b.Row3.Z;
            var v23 = a.Row2.X * b.Row0.W + a.Row2.Y * b.Row1.W + a.Row2.Z * b.Row2.W + a.Row2.W * b.Row3.W;

            var v30 = a.Row3.X * b.Row0.X + a.Row3.Y * b.Row1.X + a.Row3.Z * b.Row2.X + a.Row3.W * b.Row3.X;
            var v31 = a.Row3.X * b.Row0.Y + a.Row3.Y * b.Row1.Y + a.Row3.Z * b.Row2.Y + a.Row3.W * b.Row3.Y;
            var v32 = a.Row3.X * b.Row0.Z + a.Row3.Y * b.Row1.Z + a.Row3.Z * b.Row2.Z + a.Row3.W * b.Row3.Z;
            var v33 = a.Row3.X * b.Row0.W + a.Row3.Y * b.Row1.W + a.Row3.Z * b.Row2.W + a.Row3.W * b.Row3.W;

            mat.Row0 = new Vector4F(v00, v01, v02, v03);
            mat.Row1 = new Vector4F(v10, v11, v12, v13);
            mat.Row2 = new Vector4F(v20, v21, v22, v23);
            mat.Row3 = new Vector4F(v30, v31, v32, v33);

            return mat;
        }

        public static Vector4F operator *(Matrix4F mat, Vector4F vec) {
            Vector4F ret;
            ret.X = mat.Row0.X * vec.X + mat.Row0.Y * vec.Y + mat.Row0.Z * vec.Z + mat.Row0.W * vec.W;
            ret.Y = mat.Row1.X * vec.X + mat.Row1.Y * vec.Y + mat.Row1.Z * vec.Z + mat.Row1.W * vec.W;
            ret.Z = mat.Row2.X * vec.X + mat.Row2.Y * vec.Y + mat.Row2.Z * vec.Z + mat.Row2.W * vec.W;
            ret.W = mat.Row3.X * vec.X + mat.Row3.Y * vec.Y + mat.Row3.Z * vec.Z + mat.Row3.W * vec.W;
            return ret;
        }

        public void TranslationX(float x) {
            this *= Matrix4F.CreateTranslation(new Vector4F(x, 0, 0, 1));
        }

        public void TranslationY(float y) {
            this *= Matrix4F.CreateTranslation(new Vector4F(0, y, 0, 1));
        }

        public void TranslationZ(float z) {
            this *= Matrix4F.CreateTranslation(new Vector4F(0, 0, z, 1));
        }

        public void Translation(float x, float y, float z) {
            this *= Matrix4F.CreateTranslation(new Vector4F(x, y, z, 1));
        }

        public void Translation(Vector3F vec) {
            this *= Matrix4F.CreateTranslation(vec);
        }

        public void Translation(Vector4F vec) {
            this *= Matrix4F.CreateTranslation(vec);
        }

        public void ScaleX(float x) {
            this *= Matrix4F.CreateScale(new Vector4F(x, 1, 1, 1));
        }

        public void ScaleY(float y) {
            this *= Matrix4F.CreateScale(new Vector4F(1, y, 1, 1));
        }

        public void ScaleZ(float z) {
            this *= Matrix4F.CreateScale(new Vector4F(1, 1, z, 1));
        }

        public void Scale(float x, float y, float z) {
            this *= Matrix4F.CreateScale(new Vector4F(x, y, z, 1));
        }

        public void Scale(Vector3F vec) {
            this *= Matrix4F.CreateScale(vec);
        }

        public void Scale(Vector4F vec) {
            this *= Matrix4F.CreateScale(vec);
        }

        public void RotationX(double degpress) {
            this *= Matrix4F.CreateRotationX(degpress);
        }

        public void RotationY(double degpress) {
            this *= Matrix4F.CreateRotationY(degpress);
        }

        public void RotationZ(double degpress) {
            this *= Matrix4F.CreateRotationZ(degpress);
        }

        public void Rotation(double degpress, Vector3F vec) {
            this *= Matrix4F.CreateRotation(degpress, new Vector4F(vec.X, vec.Y, vec.Z, 1));
        }

        public void Rotation(double degpress, Vector4F vec) {
            this *= Matrix4F.CreateRotation(degpress, vec);
        }

        //==========================================

        public static Matrix4F CreateTranslation(float x, float y, float z) {
            return Matrix4F.CreateTranslation(new Vector4F(x, y, z, 1));
        }

        public static Matrix4F CreateTranslation(Vector3F vec) {
            return Matrix4F.CreateTranslation(new Vector4F(vec.X, vec.Y, vec.Z, 1));
        }

        public static Matrix4F CreateTranslation(Vector4F vec) {
            var mat = Matrix4F.Identity;
            mat.Row0.W = vec.X;
            mat.Row1.W = vec.Y;
            mat.Row2.W = vec.Z;
            return mat;
        }

        public static Matrix4F CreateScale(float x, float y, float z) {
            var mat = Matrix4F.Identity;
            mat.Row0.X = x;
            mat.Row1.Y = y;
            mat.Row2.Z = y;
            return mat;
        }

        public static Matrix4F CreateScale(Vector3F vec) {
            var mat = Matrix4F.Identity;
            mat.Row0.X = vec.X;
            mat.Row1.Y = vec.Y;
            mat.Row2.Z = vec.Z;
            return mat;
        }

        public static Matrix4F CreateScale(Vector4F vec) {
            var mat = Matrix4F.Identity;
            mat.Row0.X = vec.X;
            mat.Row1.Y = vec.Y;
            mat.Row2.Z = vec.Z;
            return mat;
        }

        public static Matrix4F CreateRotationX(double degpress) {
            var mat = Matrix4F.Identity;
            double r = MathHelper.DegressToRadians(degpress);

            mat.Row1.Y = (float)Math.Cos(r);
            mat.Row1.Z = (float)-Math.Sin(r);
            mat.Row2.Y = (float)Math.Sin(r);
            mat.Row2.Z = (float)Math.Cos(r);

            return mat;
        }

        public static Matrix4F CreateRotationY(double degpress) {
            var mat = Matrix4F.Identity;
            double r = MathHelper.DegressToRadians(degpress);

            mat.Row0.X = (float)Math.Cos(r);
            mat.Row0.Z = (float)Math.Sin(r);
            mat.Row2.X = (float)-Math.Sin(r);
            mat.Row2.Z = (float)Math.Cos(r);

            return mat;
        }

        public static Matrix4F CreateRotationZ(double degpress) {
            var mat = Matrix4F.Identity;
            double r = MathHelper.DegressToRadians(degpress);

            mat.Row0.X = (float)Math.Cos(r);
            mat.Row0.Y = (float)-Math.Sin(r);
            mat.Row1.X = (float)Math.Sin(r);
            mat.Row1.Y = (float)Math.Cos(r);

            return mat;
        }

        public static Matrix4F CreateRotation(double degpress, Vector3F vec) {
            return Matrix4F.CreateRotation(degpress, new Vector4F(vec.X, vec.Y, vec.Z, 1));
        }

        public static Matrix4F CreateRotation(double degpress, Vector4F vec) {
            var mat = Matrix4F.Identity;
            float x = vec.X, y = vec.Y, z = vec.Z;
            double r = MathHelper.DegressToRadians(degpress);

            mat.Row0.X = (float)(Math.Cos(r) + (x * x) * (1 - Math.Cos(r)));
            mat.Row0.Y = (float)(x * y * (1 - Math.Cos(r)) - (z * Math.Sin(r)));
            mat.Row0.Z = (float)(x * z * (1 - Math.Cos(r)) + (y * Math.Sin(r)));

            mat.Row1.X = (float)(y * x * (1 - Math.Cos(r)) + (z * Math.Sin(r)));
            mat.Row1.Y = (float)(Math.Cos(r) + y * y * (1 - Math.Cos(r)));
            mat.Row1.Z = (float)(y * z * (1 - Math.Cos(r)) - x * Math.Sin(r));

            mat.Row2.X = (float)(z * x * (1 - Math.Cos(r)) - (y * Math.Sin(r)));
            mat.Row2.Y = (float)(z * y * (1 - Math.Cos(r)) + (x * Math.Sin(r)));
            mat.Row2.Z = (float)(Math.Cos(r) + z * z * (1 - Math.Cos(r)));

            return mat;
        }
    }
}
