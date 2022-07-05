using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace STLib.OpenGL
{
    public static class MarshalExtend
    {
        public unsafe static string PtrToString(byte* ptr) {
            return MarshalExtend.PtrToString((IntPtr)ptr, MarshalExtend.StrLen(ptr), Encoding.UTF8);
        }

        public unsafe static string PtrToString(byte* ptr, Encoding encoding) {
            return MarshalExtend.PtrToString((IntPtr)ptr, MarshalExtend.StrLen(ptr), encoding);
        }

        public unsafe static string PtrToString(byte* ptr, int nLen) {
            return MarshalExtend.PtrToString((IntPtr)ptr, nLen, Encoding.UTF8);
        }

        public unsafe static string PtrToString(byte* ptr, int nLen, Encoding encoding) {
            return MarshalExtend.PtrToString((IntPtr)ptr, nLen, encoding);
        }

        public static string PtrToString(IntPtr ptr) {
            return MarshalExtend.PtrToString(ptr, MarshalExtend.StrLen(ptr), Encoding.UTF8);
        }

        public static string PtrToString(IntPtr ptr, int nLen) {
            return MarshalExtend.PtrToString(ptr, nLen, Encoding.UTF8);
        }

        public static string PtrToString(IntPtr ptr, Encoding encoding) {
            return MarshalExtend.PtrToString(ptr, MarshalExtend.StrLen(ptr), encoding);
        }

        public static string PtrToString(IntPtr ptr, int nLen, Encoding encoding) {
            byte[] byBuffer = new byte[nLen];
            Marshal.Copy(ptr, byBuffer, 0, byBuffer.Length);
            return encoding.GetString(byBuffer, 0, byBuffer.Length);
        }

        public static int StrLen(IntPtr ptr) {
            int nLen = 0;
            while (Marshal.ReadByte(ptr, nLen) != 0) {
                nLen++;
            }
            return nLen;
        }

        public unsafe static int StrLen(byte* ptr) {
            return MarshalExtend.StrLen((IntPtr)ptr);
        }

        // [ArrayToPtr] =================================

        public static IntPtr AllocStringArr(string[] strs, int[] nLens, Encoding coding) {
            return MarshalExtend.AllocStringArr(strs, strs.Length, nLens, coding);
        }

        public static IntPtr AllocStringArr(string[] strs, int nCount, int[] nLens, Encoding coding) {
            if (strs == null || strs.Length == 0 || nCount == 0) {
                return IntPtr.Zero;
            }
            if (nCount > strs.Length) throw new ArgumentOutOfRangeException("strs");
            if (strs.Length > nLens.Length) throw new ArgumentOutOfRangeException("nLens");
            int nWidth = IntPtr.Size;
            IntPtr[] ps = new IntPtr[nCount];
            IntPtr ptr = Marshal.AllocHGlobal(strs.Length * nWidth);
            try {
                for (int i = 0; i < nCount; i++) {
                    var by = coding.GetBytes(strs[i]);
                    nLens[i] = by.Length;
                    IntPtr p = Marshal.AllocHGlobal(by.Length);
                    Marshal.Copy(by, 0, p, by.Length);
                    Marshal.WriteIntPtr(ptr, i * nWidth, p);
                    ps[i] = p;
                }
            } catch {
                for (int i = 0; i < ps.Length; i++) {
                    if (ps[i] == IntPtr.Zero) return IntPtr.Zero;
                    Marshal.FreeHGlobal(ps[i]);
                }
            }
            return ptr;
        }

        public static void FreeStringArr(IntPtr ptr, int nCount) {
            int nWidth = IntPtr.Size;
            for (int i = 0; i < nCount; i++) {
                IntPtr p = Marshal.ReadIntPtr(ptr, i * nWidth);
                Marshal.FreeHGlobal(p);
            }
            Marshal.FreeHGlobal(ptr);
        }

        // [sizeof] ======================================

        public static long SizeOf(byte[] arr) {
            return arr.Length * sizeof(byte);
        }

        public static int SizeOf(short[] arr) {
            return arr.Length * sizeof(short);
        }

        public static long SizeOf(ushort[] arr) {
            return arr.Length * sizeof(ushort);
        }

        public static long SizeOf(int[] arr) {
            return arr.Length * sizeof(int);
        }

        public static long SizeOf(uint[] arr) {
            return arr.Length * sizeof(uint);
        }

        public static long SizeOf(float[] arr) {
            return arr.Length * sizeof(float);
        }
    }
}
