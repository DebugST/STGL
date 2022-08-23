using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using STLib.OpenGL.GLM;

namespace STLib.OpenGL.GL
{
    public class GLCamera : GLObject
    {
        public Vector3F Positon { get; private set; }

        public Vector3F Forward { get; private set; }
        public Vector3F UP { get; private set; }
        public Vector3F Right { get; private set; }

        public Matrix4F ViewMatrix { get; private set; }

        public bool IsLockUP { get { return m_b_lock_up; } }

        private bool m_b_lock_up;
        private float m_f_angle_pitch;
        private float m_f_angle_up;
        private float m_f_angle_down;
        private Matrix4F m_mat4_rotate = Matrix4F.Identity;

        public GLCamera(Vector3F position) : this(position, new Vector3F(0, 0, 0)) { }

        public GLCamera(Vector3F position, Vector3F target) {
            this.Positon = position;
            //Forward,Right,UP 构成相机自身坐标系统
            this.Forward = new Vector3F(0, 0, -1);  //相机朝前向量
            this.Right = new Vector3F(1, 0, 0);     //相机右侧向量
            this.UP = new Vector3F(0, 1, 0);        //相机顶部向量
            if (position == target) {
                this.UpdateMatrix();
                return;
            }
            //将相机旋转至目标
            var vec_t = (target - this.Positon).GetNormalize();
            var vec_f = this.Forward;
            Vector2F a = new Vector2F(vec_f.X, vec_f.Z);
            Vector2F b = new Vector2F(vec_t.X, vec_t.Z);
            if (a != b) {
                double d = (float)Math.Acos(a.Dot(b) / (a.Length * b.Length));
                if (!double.IsNaN(d)) this.Yaw(-(float)GLM.GLM.Degress(d));
            }
            vec_f = this.Forward;
            a = new Vector2F(vec_f.Z, vec_f.Y);
            b = new Vector2F(vec_t.Z, vec_t.Y);
            if (a != b) {
                double d = (float)Math.Acos(a.Dot(b) / (a.Length * b.Length));
                if (!double.IsNaN(d)) this.Pitch((float)GLM.GLM.Degress(d));
            }
            this.UpdateMatrix();
        }

        public GLCamera(Vector3F position, float downWardAngle, float upWardAngle) {
            this.Positon = position;
            //Forward,Right,UP 构成相机自身坐标系统
            this.Forward = new Vector3F(0, 0, -1);  //相机朝前向量
            this.Right = new Vector3F(1, 0, 0);     //相机右侧向量
            this.UP = new Vector3F(0, 1, 0);        //相机顶部向量
            m_b_lock_up = true;
            m_f_angle_down = downWardAngle;
            m_f_angle_up = -upWardAngle;
            this.UpdateMatrix();
        }

        public void Reset(Vector3F position, float yawAngle) {
            this.Positon = position;
            this.Forward = new Vector3F(0, 0, -1);  //相机朝前向量
            this.Right = new Vector3F(1, 0, 0);     //相机右侧向量
            this.UP = new Vector3F(0, 1, 0);        //相机顶部向量
            this.Yaw(yawAngle);
        }

        #region rotate

        public void Roll(float angle) {
            if (m_b_lock_up) return;
            if (angle == 0 || float.IsNaN(angle)) return;

            var mat = GLM.GLM.Rotate(angle, this.Forward);
            this.UP = new Vector3F(mat * new Vector4F(this.UP, 1));
            this.Right = new Vector3F(mat * new Vector4F(this.Right, 1));

            m_mat4_rotate *= GLM.GLM.Rotate(angle, -this.Forward);
            this.UpdateMatrix();
        }

        public void RollLeft(float angle) { this.Roll(-angle); }

        public void RollRight(float angle) { this.Roll(angle); }

        public void Yaw(float angle) {
            if (angle == 0 || float.IsNaN(angle)) return;

            var mat = GLM.GLM.Rotate(angle, -this.UP);
            this.Right = new Vector3F(mat * new Vector4F(this.Right, 1));
            this.Forward = new Vector3F(mat * new Vector4F(this.Forward, 1));

            m_mat4_rotate *= GLM.GLM.Rotate(angle, this.UP);
            this.UpdateMatrix();
        }

        public void YawLeft(float angle) { this.Yaw(-angle); }

        public void YawRight(float angle) { this.Yaw(angle); }

        public void Pitch(float angle) {
            if (angle == 0 || float.IsNaN(angle)) return;
            if (m_b_lock_up) {
                if (angle > 0) {    // down
                    if (m_f_angle_down == m_f_angle_pitch) return;
                    m_f_angle_pitch += angle;
                    if (m_f_angle_pitch > m_f_angle_down) {
                        angle -= m_f_angle_pitch - m_f_angle_down;
                        m_f_angle_pitch = m_f_angle_down;
                    }
                } else {            // up
                    if (m_f_angle_up == m_f_angle_pitch) return;
                    m_f_angle_pitch += angle;
                    if (m_f_angle_pitch < m_f_angle_up) {
                        angle -= m_f_angle_pitch - m_f_angle_up;
                        m_f_angle_pitch = m_f_angle_up;
                    }
                }
            }
            Matrix4F mat = GLM.GLM.Rotate(angle, -this.Right);
            this.Forward = new Vector3F(mat * new Vector4F(this.Forward, 1));
            if (!m_b_lock_up) {
                this.UP = new Vector3F(mat * new Vector4F(this.UP, 1));
            }
            m_mat4_rotate *= GLM.GLM.Rotate(angle, this.Right);
            this.UpdateMatrix();
        }

        public void PitchUp(float angle) { this.Pitch(-angle); }

        public void PitchDown(float angle) { this.Pitch(angle); }

        #endregion

        #region move

        public void Move(Vector3F position) {
            this.Positon = position;
            this.UpdateMatrix();
        }

        public void Move(Vector3F direction, float distance) {
            Vector3F vec = direction.GetNormalize() * distance;
            this.Positon += new Vector3F(vec.X, vec.Y, vec.Z);
            this.UpdateMatrix();
        }

        public void MoveLeft(float distance) {
            this.Move(-this.Right, distance);
        }

        public void MoveRight(float distance) {
            this.Move(this.Right, distance);
        }

        public void MoveForward(float distance) {
            this.Move(this.Forward, distance);
        }

        public void MoveBack(float distance) {
            this.Move(-this.Forward, distance);
        }

        public void MoveUp(float distance) {
            this.Move(this.UP, distance);
        }

        public void MoveDown(float distance) {
            this.Move(-this.UP, distance);
        }

        #endregion

        private void UpdateMatrix() {
            var mat = m_mat4_rotate;
            mat.Translate(-this.Positon);
            this.ViewMatrix = mat;
        }
    }
}
