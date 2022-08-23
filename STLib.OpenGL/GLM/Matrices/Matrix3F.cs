using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GLM
{
    public struct Matrix3F
    {
        public Vector3F Col0;
        public Vector3F Col1;
        public Vector3F Col2;

        public Vector3F Row0 { get { return new Vector3F(this.Col0.X, this.Col1.X, this.Col2.X); } }
        public Vector3F Row1 { get { return new Vector3F(this.Col0.Y, this.Col1.Y, this.Col2.Y); } }
        public Vector3F Row2 { get { return new Vector3F(this.Col0.Z, this.Col1.Z, this.Col2.Z); } }

        public static readonly Matrix3F Zero;
        public static readonly Matrix3F Identity = new Matrix3F(Vector3F.UnitX, Vector3F.UnitY, Vector3F.UnitZ);

        public Matrix3F(Vector3F col0, Vector3F col1, Vector3F col2) {
            this.Col0 = col0;
            this.Col1 = col1;
            this.Col2 = col2;
        }

        public override string ToString() {
            return string.Format("[{0}, {1}, {2}, {3}]", this.Row0, this.Row1, this.Row2);
        }

        public Vector3F this[int nIndex] {
            get {
                switch (nIndex) {
                    case 0: return this.Col0;
                    case 1: return this.Col1;
                    case 2: return this.Col2;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set {
                switch (nIndex) {
                    case 0: this.Col0 = value; break;
                    case 1: this.Col1 = value; break;
                    case 2: this.Col2 = value; break;
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
                    default: throw new IndexOutOfRangeException();
                }
            }
            set {
                switch (nColIndex) {
                    case 0: this.Col0[nRowIndex] = value; break;
                    case 1: this.Col1[nRowIndex] = value; break;
                    case 2: this.Col2[nRowIndex] = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }

        public Matrix3F SwapRowCol() {
            var mat = Matrix3F.Zero;
            mat.Col0 = this.Row0;
            mat.Col1 = this.Row1;
            mat.Col2 = this.Row2;
            return mat;
        }

    }
}
