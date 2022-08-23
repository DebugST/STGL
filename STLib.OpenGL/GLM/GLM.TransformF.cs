using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STLib.OpenGL.GLM
{
    partial class GLM
    {
        public enum EulerOrder
        {
            XYZ,
            XZY,
            YXZ,
            YZX,
            ZXY,
            ZYX,
        };

        public static Matrix4F Translate(Vector3F v) {
            var m = Matrix4F.Identity;
            return GLM.Translate(m, v);
        }

        public static Matrix4F Translate(Matrix4F m, Vector3F v) {
            Vector4F temp = m[0] * v[0] + m[1] * v[1] + m[2] * v[2] + m[3];
            m[3] = temp;
            return m;
        }

        public static Matrix4F Scale(Vector3F v) {
            var m = Matrix4F.Identity;
            return GLM.Scale(m, v);
        }

        public static Matrix4F Scale(Matrix4F m, Vector3F v) {
            Matrix4F result = Matrix4F.Identity;
            result[0] = m[0] * v.X;
            result[1] = m[1] * v.Y;
            result[2] = m[2] * v.Z;
            result[3] = m[3];
            return result;
        }

        public static Matrix4F Rotate(float angle, Vector3F v) {
            var m = Matrix4F.Identity;
            return GLM.Rotate(m, angle, v);
        }

        public static Matrix4F Rotate(Matrix4F m, float angle, Vector3F v) {
            float a = (float)GLM.Radians(angle);
            float c = (float)Math.Cos(a);
            float s = (float)Math.Sin(a);
            Vector3F axis = v.GetNormalize();
            Vector3F temp = (1 - c) * axis;

            Matrix4F rotate = Matrix4F.Zero;
            rotate[0, 0] = c + temp[0] * axis[0];
            rotate[0, 1] = 0 + temp[0] * axis[1] + s * axis[2];
            rotate[0, 2] = 0 + temp[0] * axis[2] - s * axis[1];

            rotate[1, 0] = 0 + temp[1] * axis[0] - s * axis[2];
            rotate[1, 1] = c + temp[1] * axis[1];
            rotate[1, 2] = 0 + temp[1] * axis[2] + s * axis[0];

            rotate[2, 0] = 0 + temp[2] * axis[0] + s * axis[1];
            rotate[2, 1] = 0 + temp[2] * axis[1] - s * axis[0];
            rotate[2, 2] = c + temp[2] * axis[2];

            Matrix4F result = Matrix4F.Zero;
            result[0] = m[0] * rotate[0][0] + m[1] * rotate[0][1] + m[2] * rotate[0][2];
            result[1] = m[0] * rotate[1][0] + m[1] * rotate[1][1] + m[2] * rotate[1][2];
            result[2] = m[0] * rotate[2][0] + m[1] * rotate[2][1] + m[2] * rotate[2][2];
            result[3] = m[3];
            return result;
        }

        public static Matrix4F EulerRotate(EulerOrder order, Vector3F vecAngle) {
            var r_x = GLM.Rotate(vecAngle.X, new Vector3F(1, 0, 0));
            var r_y = GLM.Rotate(vecAngle.Y, new Vector3F(0, 1, 0));
            var r_z = GLM.Rotate(vecAngle.Z, new Vector3F(0, 0, 1));
            switch (order) {
                case EulerOrder.XYZ:
                    return r_z * r_y * r_x;
                case EulerOrder.XZY:
                    return r_y * r_z * r_x;
                case EulerOrder.YXZ:
                    return r_z * r_x * r_y;
                case EulerOrder.YZX:
                    return r_x * r_z * r_y;
                case EulerOrder.ZXY:
                    return r_y * r_x * r_z;
                case EulerOrder.ZYX:
                    return r_x * r_y * r_z;
            }
            return Matrix4F.Identity;
        }

        public static Matrix4F EulerRotate(Matrix4F m, EulerOrder order, Vector3F vecAngle) {
            return m * GLM.EulerRotate(order, vecAngle);
        }

        //public static Matrix4F Rotate(Vector3F vecAngle) {
        //    return Matrix4F.Identity * new Quaternion(vecAngle).ToMatrix4F();
        //}

        //public static Matrix4F Rotate(Matrix4F m, Vector3F vecAngle) {
        //    return m * new Quaternion(vecAngle).ToMatrix4F();
        //}

        public static Matrix4F Ortho(float left, float right, float bottom, float top, float zNear, float zFar) {
            Matrix4F result = Matrix4F.Identity;
            result[0, 0] = 2 / (right - left);
            result[1, 1] = 2 / (top - bottom);
            result[2, 2] = -2 / (zFar - zNear);
            result[3, 0] = -(right + left) / (right - left);
            result[3, 1] = -(top + bottom) / (top - bottom);
            result[3, 2] = -(zFar + zNear) / (zFar - zNear);
            return result;
        }

        public static Matrix4F Ortho(float left, float right, float bottom, float top) {
            Matrix4F result = Matrix4F.Identity;
            result[0, 0] = 2 / (right - left);
            result[1, 1] = 2 / (top - bottom);
            result[2, 2] = -1;
            result[3, 0] = -(right + left) / (right - left);
            result[3, 1] = -(top + bottom) / (top - bottom);
            return result;
        }

        public static Matrix4F Frustum(float left, float right, float bottom, float top, float nearVal, float farVal) {
            Matrix4F result = Matrix4F.Zero;
            result[0, 0] = (2 * nearVal) / (right - left);
            result[1, 1] = (2 * nearVal) / (top - bottom);
            result[2, 0] = (right + left) / (right - left);
            result[2, 1] = (top + bottom) / (top - bottom);
            result[2, 2] = -(farVal + nearVal) / (farVal - nearVal);
            result[2, 3] = -1;
            result[3, 2] = -(2 * farVal * nearVal) / (farVal - nearVal);
            return result;
        }

        public static Matrix4F Perspective(float fovy, float aspect, float zNear, float zFar) {
            float range = (float)Math.Tan(GLM.Radians(fovy / 2)) * zNear;
            float left = -range * aspect;
            float right = range * aspect;
            float bottom = -range;
            float top = range;

            Matrix4F result = Matrix4F.Zero;
            float temp = 2 * zNear;
            result[0, 0] = temp / (right - left);
            result[1, 1] = temp / (top - bottom);
            result[2, 2] = -(zFar + zNear) / (zFar - zNear);
            result[2, 3] = -1;
            result[3, 2] = -(temp * zFar) / (zFar - zNear);
            return result;
        }

        public static Matrix4F PerspectiveFov(float fov, float width, float height, float zNear, float zFar) {
            Matrix4F mat = Matrix4F.Zero;
            float rad = (float)GLM.Radians(fov);
            float h = (float)(Math.Cos(0.5 * rad) / Math.Sin(0.5 * rad));
            float w = h * height / width;

            mat[0, 0] = w;
            mat[1, 1] = h;
            mat[2, 2] = -(zFar + zNear) / (zFar - zNear);
            mat[2, 3] = -1;
            mat[3, 2] = (2 * zFar * zNear) / (zFar - zNear);
            return mat;
        }

        public static Matrix4F InfinitePerspective(float fovy, float aspect, float zNear) {
            float range = (float)(Math.Tan(GLM.Radians(fovy / 2)) * zNear);
            float right = range * aspect;
            float left = -right;
            float bottom = -range;
            float top = range;

            Matrix4F result = Matrix4F.Zero;
            float temp = 2 * zNear;
            result[0, 0] = temp / (right - left);
            result[1, 1] = temp / (top - bottom);
            result[2, 2] = -1;
            result[2, 3] = -1;
            result[3, 2] = -temp;
            return result;
        }

        public static Matrix4F TweakedInfinitePerspective(float fovy, float aspect, float zNear) {
            float range = (float)(Math.Tan(GLM.Radians(fovy / 2)) * zNear);
            float right = range * aspect;
            float left = -right;
            float bottom = -range;
            float top = range;

            Matrix4F result = Matrix4F.Zero;
            float temp = 2 * zNear;
            result[0, 0] = temp / (right - left);
            result[1, 1] = temp / (top - bottom);
            result[2, 2] = 0.0001f - 1;
            result[2, 3] = -1;
            result[3, 2] = (0.0001f - 2) * zNear;
            return result;
        }

        public static Vector3F Project(Vector3F obj, Matrix4F model, Matrix4F proj, Vector4F viewport) {
            Vector4F tmp = new Vector4F(obj.X, obj.Y, obj.Z, 1);
            tmp = model * tmp;
            tmp = proj * tmp;
            tmp /= tmp.W;
            tmp = tmp * 0.5f + 0.5f;
            tmp.X = tmp.X * viewport[2] + viewport[0];
            tmp.Y = tmp.Y * viewport[3] + viewport[1];
            return new Vector3F(tmp.X, tmp.Y, tmp.Z);
        }

        public static Vector3F UnProject(Vector3F win, Matrix4F model, Matrix4F proj, Vector4F viewport) {
            Matrix4F inverse = (proj * model).Inverse();
            Vector4F tmp = new Vector4F(win.X, win.Y, win.Z, 1);
            tmp.X = (tmp.X - viewport[0]) / viewport[2];
            tmp.Y = (tmp.Y - viewport[1]) / viewport[3];
            tmp = tmp * 2 - 1;

            Vector4F obj = inverse * tmp;
            obj /= obj.W;

            return new Vector3F(obj.X, obj.Y, obj.Z);
        }

        public static Matrix4F PickMarix(Vector2F center, Vector2F delta, Vector4F viewport) {
            Matrix4F result = Matrix4F.Identity;
            if (!(delta.X > 0 && delta.Y > 0)) {
                return result;
            }
            float x = (viewport[2] - 2 * (center.X - viewport[0])) / delta.X;
            float y = (viewport[3] - 2 * (center.Y - viewport[1])) / delta.Y;
            Vector3F temp = new Vector3F(x, y, 0);
            result = GLM.Translate(result, temp);
            return GLM.Scale(result, new Vector3F(viewport[2] / delta.X, viewport[3] / delta.Y, 1));
        }

        public static Matrix4F LookAt(Vector3F eye, Vector3F center, Vector3F up) {
            Vector3F f = (center - eye).GetNormalize();
            Vector3F u = up.GetNormalize();
            Vector3F s = f.Cross(u).GetNormalize();
            u = s.Cross(f);

            Matrix4F result = Matrix4F.Identity;
            result[0, 0] = s.X;
            result[1, 0] = s.Y;
            result[2, 0] = s.Z;
            result[0, 1] = u.X;
            result[1, 1] = u.Y;
            result[2, 1] = u.Z;
            result[0, 2] = -f.X;
            result[1, 2] = -f.Y;
            result[2, 2] = -f.Z;
            result[3, 0] = -s.Dot(eye);
            result[3, 1] = -u.Dot(eye);
            result[3, 2] = f.Dot(eye);
            return result;
        }
    }
}
