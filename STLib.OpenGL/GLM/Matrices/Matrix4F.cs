using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GLM
{
    public struct Matrix4F
    {
        public Vector4F Col0;
        public Vector4F Col1;
        public Vector4F Col2;
        public Vector4F Col3;

        public Vector4F Row0 { get { return new Vector4F(this.Col0.X, this.Col1.X, this.Col2.X, this.Col3.X); } }
        public Vector4F Row1 { get { return new Vector4F(this.Col0.Y, this.Col1.Y, this.Col2.Y, this.Col3.Y); } }
        public Vector4F Row2 { get { return new Vector4F(this.Col0.Z, this.Col1.Z, this.Col2.Z, this.Col3.Z); } }
        public Vector4F Row3 { get { return new Vector4F(this.Col0.W, this.Col1.W, this.Col2.W, this.Col3.W); } }

        public static readonly Matrix4F Zero;
        public static readonly Matrix4F Identity = new Matrix4F(Vector4F.UnitX, Vector4F.UnitY, Vector4F.UnitZ, Vector4F.UnitW);

        public Matrix4F(Vector4F col0, Vector4F col1, Vector4F col2, Vector4F col3) {
            this.Col0 = col0;
            this.Col1 = col1;
            this.Col2 = col2;
            this.Col3 = col3;
        }

        public override string ToString() {
            return string.Format("[{0}, {1}, {2}, {3}]", this.Row0, this.Row1, this.Row2, this.Row3);
        }

        public Vector4F this[int nIndex] {
            get {
                switch (nIndex) {
                    case 0: return this.Col0;
                    case 1: return this.Col1;
                    case 2: return this.Col2;
                    case 3: return this.Col3;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set {
                switch (nIndex) {
                    case 0: this.Col0 = value; break;
                    case 1: this.Col1 = value; break;
                    case 2: this.Col2 = value; break;
                    case 3: this.Col3 = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }

        public float this[int nColIndex, int nRowIndex] {
            get {
                switch (nColIndex) {
                    case 0: return this.Col0[nRowIndex];
                    case 1: return this.Col1[nRowIndex];
                    case 2: return this.Col2[nRowIndex];
                    case 3: return this.Col3[nRowIndex];
                    default: throw new IndexOutOfRangeException();
                }
            }
            set {
                switch (nColIndex) {
                    case 0: this.Col0[nRowIndex] = value; break;
                    case 1: this.Col1[nRowIndex] = value; break;
                    case 2: this.Col2[nRowIndex] = value; break;
                    case 3: this.Col3[nRowIndex] = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }

        public Matrix4F SwapRowCol() {
            var mat = Matrix4F.Zero;
            mat.Col0 = this.Row0;
            mat.Col1 = this.Row1;
            mat.Col2 = this.Row2;
            mat.Col3 = this.Row3;
            return mat;
        }

        // ============================================

        public static Matrix4F operator +(Matrix4F a, Matrix4F b) {
            return new Matrix4F(a.Col0 + b.Col0, a.Col1 + b.Col1, a.Col2 + b.Col2, a.Col3 + b.Col3);
        }

        public static Matrix4F operator +(Matrix4F a, float v) {
            return new Matrix4F(a.Col0 + v, a.Col1 + v, a.Col2 + v, a.Col3 + v);
        }

        public static Matrix4F operator +(float v, Matrix4F a) {
            return new Matrix4F(a.Col0 + v, a.Col1 + v, a.Col2 + v, a.Col3 + v);
        }

        public static Matrix4F operator -(Matrix4F a, Matrix4F b) {
            return new Matrix4F(a.Col0 - b.Col0, a.Col1 - b.Col1, a.Col2 - b.Col2, a.Col3 - b.Col3);
        }

        public static Matrix4F operator -(Matrix4F a, float v) {
            return new Matrix4F(a.Col0 - v, a.Col1 - v, a.Col2 - v, a.Col3 - v);
        }

        public static Matrix4F operator -(float v, Matrix4F a) {
            return new Matrix4F(a.Col0 - v, a.Col1 - v, a.Col2 - v, a.Col3 - v);
        }

        public static Matrix4F operator *(Matrix4F a, Matrix4F b) {
            var a0 = a.Col0;
            var a1 = a.Col1;
            var a2 = a.Col2;
            var a3 = a.Col3;

            var bc0 = b.Col0;
            var b1 = b.Col1;
            var b2 = b.Col2;
            var b3 = b.Col3;

            Matrix4F mat = Matrix4F.Zero;
            mat[0] = a0 * bc0[0] + a1 * bc0[1] + a2 * bc0[2] + a3 * bc0[3];
            mat[1] = a0 * b1[0] + a1 * b1[1] + a2 * b1[2] + a3 * b1[3];
            mat[2] = a0 * b2[0] + a1 * b2[1] + a2 * b2[2] + a3 * b2[3];
            mat[3] = a0 * b3[0] + a1 * b3[1] + a2 * b3[2] + a3 * b3[3];
            return mat;
        }

        public static Matrix4F operator *(Matrix4F m, float v) {
            return new Matrix4F(m.Col0 * v, m.Col1 * v, m.Col2 * v, m.Col3 * v);
        }

        public static Matrix4F operator *(float v, Matrix4F m) {
            return new Matrix4F(m.Col0 * v, m.Col1 * v, m.Col2 * v, m.Col3 * v);
        }

        public static Matrix4F operator /(Matrix4F m, float v) {
            Matrix4F mat = new Matrix4F(m.Row0 / v, m.Row1 / v, m.Row2 / v, m.Row3 / v);
            return mat;
        }

        public static Matrix4F operator /(float v, Matrix4F m) {
            Matrix4F mat = new Matrix4F(m.Row0 / v, m.Row1 / v, m.Row2 / v, m.Row3 / v);
            return mat;
        }

        public static Vector4F operator *(Matrix4F m, Vector4F v) {
            float x = m[0][0] * v.X + m[1][0] * v.Y + m[2][0] * v.Z + m[3][0] * v.W;
            float y = m[0][1] * v.X + m[1][1] * v.Y + m[2][1] * v.Z + m[3][1] * v.W;
            float z = m[0][2] * v.X + m[1][2] * v.Y + m[2][2] * v.Z + m[3][2] * v.W;
            float w = m[0][3] * v.X + m[1][3] * v.Y + m[2][3] * v.Z + m[3][3] * v.W;
            return new Vector4F(x, y, z, w);
        }

        //===================================================

        public Matrix4F Inverse() {
            Matrix4F m = this;
            float Coef00 = m[2][2] * m[3][3] - m[3][2] * m[2][3];
            float Coef02 = m[1][2] * m[3][3] - m[3][2] * m[1][3];
            float Coef03 = m[1][2] * m[2][3] - m[2][2] * m[1][3];

            float Coef04 = m[2][1] * m[3][3] - m[3][1] * m[2][3];
            float Coef06 = m[1][1] * m[3][3] - m[3][1] * m[1][3];
            float Coef07 = m[1][1] * m[2][3] - m[2][1] * m[1][3];

            float Coef08 = m[2][1] * m[3][2] - m[3][1] * m[2][2];
            float Coef10 = m[1][1] * m[3][2] - m[3][1] * m[1][2];
            float Coef11 = m[1][1] * m[2][2] - m[2][1] * m[1][2];

            float Coef12 = m[2][0] * m[3][3] - m[3][0] * m[2][3];
            float Coef14 = m[1][0] * m[3][3] - m[3][0] * m[1][3];
            float Coef15 = m[1][0] * m[2][3] - m[2][0] * m[1][3];

            float Coef16 = m[2][0] * m[3][2] - m[3][0] * m[2][2];
            float Coef18 = m[1][0] * m[3][2] - m[3][0] * m[1][2];
            float Coef19 = m[1][0] * m[2][2] - m[2][0] * m[1][2];

            float Coef20 = m[2][0] * m[3][1] - m[3][0] * m[2][1];
            float Coef22 = m[1][0] * m[3][1] - m[3][0] * m[1][1];
            float Coef23 = m[1][0] * m[2][1] - m[2][0] * m[1][1];

            Vector4F SignA = new Vector4F(+1, -1, +1, -1);
            Vector4F SignB = new Vector4F(-1, +1, -1, +1);

            Vector4F Fac0 = new Vector4F(Coef00, Coef00, Coef02, Coef03);
            Vector4F Fac1 = new Vector4F(Coef04, Coef04, Coef06, Coef07);
            Vector4F Fac2 = new Vector4F(Coef08, Coef08, Coef10, Coef11);
            Vector4F Fac3 = new Vector4F(Coef12, Coef12, Coef14, Coef15);
            Vector4F Fac4 = new Vector4F(Coef16, Coef16, Coef18, Coef19);
            Vector4F Fac5 = new Vector4F(Coef20, Coef20, Coef22, Coef23);

            Vector4F Vec0 = new Vector4F(m[1][0], m[0][0], m[0][0], m[0][0]);
            Vector4F Vec1 = new Vector4F(m[1][1], m[0][1], m[0][1], m[0][1]);
            Vector4F Vec2 = new Vector4F(m[1][2], m[0][2], m[0][2], m[0][2]);
            Vector4F Vec3 = new Vector4F(m[1][3], m[0][3], m[0][3], m[0][3]);

            Vector4F Inv0 = SignA * (Vec1 * Fac0 - Vec2 * Fac1 + Vec3 * Fac2);
            Vector4F Inv1 = SignB * (Vec0 * Fac0 - Vec2 * Fac3 + Vec3 * Fac4);
            Vector4F Inv2 = SignA * (Vec0 * Fac1 - Vec1 * Fac3 + Vec3 * Fac5);
            Vector4F Inv3 = SignB * (Vec0 * Fac2 - Vec1 * Fac4 + Vec2 * Fac5);

            Matrix4F Inverse = new Matrix4F(Inv0, Inv1, Inv2, Inv3);

            Vector4F Row0 = new Vector4F(Inverse[0][0], Inverse[1][0], Inverse[2][0], Inverse[3][0]);

            float Determinant = m[0].Dot(Row0);

            Inverse /= Determinant;

            return Inverse;
        }
    }
}
