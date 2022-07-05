using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;

namespace STLib.OpenGL
{
    public struct Pointer
    {
        private IntPtr m_pointer;
        public IntPtr IntPtr { get { return m_pointer; } }

        public Pointer(IntPtr ptr) {
            m_pointer = ptr;
        }

        public byte GetByte() { return this.GetByte(0); }
        public unsafe byte GetByte(long nIndex) {
            var nWidth = sizeof(byte);
            return *((byte*)((long)m_pointer + nIndex * nWidth));
        }
        public byte[] GetBytes(long nCount) { return this.GetBytes(0, nCount); }
        public unsafe byte[] GetBytes(long nIndex, long nCount) {
            var nWidth = sizeof(byte);
            var ret = new byte[nCount];
            nCount *= nWidth;
            var src = (void*)((long)m_pointer + nIndex * nWidth);
            fixed (void* dst = &ret[0]) {
                Pointer.Copy(dst, src, nCount);
            }
            return ret;
        }

        public Boolean GetBoolean() { return this.GetBoolean(0); }
        public unsafe Boolean GetBoolean(long nIndex) {
            var nWidth = sizeof(Boolean);
            return *((Boolean*)((long)m_pointer + nIndex * nWidth));
        }
        public Boolean[] GetBooleans(long nCount) { return this.GetBooleans(0, nCount); }
        public unsafe Boolean[] GetBooleans(long nIndex, long nCount) {
            var nWidth = sizeof(Boolean);
            var ret = new Boolean[nCount];
            nCount *= nWidth;
            var src = (void*)((long)m_pointer + nIndex * nWidth);
            fixed (void* dst = &ret[0]) {
                Pointer.Copy(dst, src, nCount);
            }
            return ret;
        }

        public Int16 GetInt16() { return this.GetInt16(0); }
        public unsafe Int16 GetInt16(long nIndex) {
            var nWidth = sizeof(Int16);
            return *((Int16*)((long)m_pointer + nIndex * nWidth));
        }
        public Int16[] GetInt16s(long nCount) { return this.GetInt16s(0, nCount); }
        public unsafe Int16[] GetInt16s(long nIndex, long nCount) {
            var nWidth = sizeof(Int16);
            var ret = new Int16[nCount];
            nCount *= nWidth;
            var src = (void*)((long)m_pointer + nIndex * nWidth);
            fixed (void* dst = &ret[0]) {
                Pointer.Copy(dst, src, nCount);
            }
            return ret;
        }

        public UInt16 GetUInt16() { return this.GetUInt16(0); }
        public unsafe UInt16 GetUInt16(long nIndex) {
            var nWidth = sizeof(UInt16);
            return *((UInt16*)((long)m_pointer + nIndex * nWidth));
        }
        public UInt16[] GetUInt16s(long nCount) { return this.GetUInt16s(0, nCount); }
        public unsafe UInt16[] GetUInt16s(long nIndex, long nCount) {
            var nWidth = sizeof(UInt16);
            var ret = new UInt16[nCount];
            nCount *= nWidth;
            var src = (void*)((long)m_pointer + nIndex * nWidth);
            fixed (void* dst = &ret[0]) {
                Pointer.Copy(dst, src, nCount);
            }
            return ret;
        }

        public Int32 GetInt32() { return this.GetInt32(0); }
        public unsafe Int32 GetInt32(long nIndex) {
            var nWidth = sizeof(Int32);
            return *((Int32*)((long)m_pointer + nIndex * nWidth));
        }
        public Int32[] GetInt32s(long nCount) { return this.GetInt32s(0, nCount); }
        public unsafe Int32[] GetInt32s(long nIndex, long nCount) {
            var nWidth = sizeof(Int32);
            var ret = new Int32[nCount];
            nCount *= nWidth;
            var src = (void*)((long)m_pointer + nIndex * nWidth);
            fixed (void* dst = &ret[0]) {
                Pointer.Copy(dst, src, nCount);
            }
            return ret;
        }

        public UInt32 GetUInt32() { return this.GetUInt32(0); }
        public unsafe UInt32 GetUInt32(long nIndex) {
            var nWidth = sizeof(UInt32);
            return *((UInt32*)((long)m_pointer + nIndex * nWidth));
        }
        public UInt32[] GetUInt32s(long nCount) { return this.GetUInt32s(0, nCount); }
        public unsafe UInt32[] GetUInt32s(long nIndex, long nCount) {
            var nWidth = sizeof(UInt32);
            var ret = new UInt32[nCount];
            nCount *= nWidth;
            var src = (void*)((long)m_pointer + nIndex * nWidth);
            fixed (void* dst = &ret[0]) {
                Pointer.Copy(dst, src, nCount);
            }
            return ret;
        }

        public Int64 GetInt64() { return this.GetInt64(0); }
        public unsafe Int64 GetInt64(long nIndex) {
            var nWidth = sizeof(Int64);
            return *((Int64*)((long)m_pointer + nIndex * nWidth));
        }
        public Int64[] GetInt64s(long nCount) { return this.GetInt64s(0, nCount); }
        public unsafe Int64[] GetInt64s(long nIndex, long nCount) {
            var nWidth = sizeof(Int64);
            var ret = new Int64[nCount];
            nCount *= nWidth;
            var src = (void*)((long)m_pointer + nIndex * nWidth);
            fixed (void* dst = &ret[0]) {
                Pointer.Copy(dst, src, nCount);
            }
            return ret;
        }

        public UInt64 GetUInt64() { return this.GetUInt64(0); }
        public unsafe UInt64 GetUInt64(long nIndex) {
            var nWidth = sizeof(UInt64);
            return *((UInt64*)((long)m_pointer + nIndex * nWidth));
        }
        public UInt64[] GetUInt64s(long nCount) { return this.GetUInt64s(0, nCount); }
        public unsafe UInt64[] GetUInt64s(long nIndex, long nCount) {
            var nWidth = sizeof(UInt64);
            var ret = new UInt64[nCount];
            nCount *= nWidth;
            var src = (void*)((long)m_pointer + nIndex * nWidth);
            fixed (void* dst = &ret[0]) {
                Pointer.Copy(dst, src, nCount);
            }
            return ret;
        }

        public float GetFloat() { return this.GetFloat(0); }
        public unsafe float GetFloat(long nIndex) {
            var nWidth = sizeof(float);
            return *((float*)((long)m_pointer + nIndex * nWidth));
        }
        public float[] GetFloats(long nCount) { return this.GetFloats(0, nCount); }
        public unsafe float[] GetFloats(long nIndex, long nCount) {
            var nWidth = sizeof(float);
            var ret = new float[nCount];
            nCount *= nWidth;
            var src = (void*)((long)m_pointer + nIndex * nWidth);
            fixed (void* dst = &ret[0]) {
                Pointer.Copy(dst, src, nCount);
            }
            return ret;
        }

        public double GetDouble() { return this.GetDouble(0); }
        public unsafe double GetDouble(long nIndex) {
            var nWidth = sizeof(double);
            return *((double*)((long)m_pointer + nIndex * nWidth));
        }
        public double[] GetDoubles(long nCount) { return this.GetDoubles(0, nCount); }
        public unsafe double[] GetDoubles(long nIndex, long nCount) {
            var nWidth = sizeof(double);
            var ret = new double[nCount];
            nCount *= nWidth;
            var src = (void*)((long)m_pointer + nIndex * nWidth);
            fixed (void* dst = &ret[0]) {
                Pointer.Copy(dst, src, nCount);
            }
            return ret;
        }

        public string GetString() { return this.GetString(Encoding.Default); }
        public string GetString(Encoding coding) {
            int nLen = Pointer.StrLen(m_pointer);
            if (nLen == 0) return string.Empty;
            byte[] byBuffer = new byte[nLen];
            Marshal.Copy(m_pointer, byBuffer, 0, nLen);
            return coding.GetString(byBuffer);
        }

        public static unsafe void Copy(void* dst, void* src, long nlen) {
            if (nlen >= 16384) {
                Pointer.Copy16384(dst, src, nlen);
            } else if (nlen >= 8192) {
                Pointer.Copy8192(dst, src, nlen);
            } else if (nlen >= 4096) {
                Pointer.Copy4096(dst, src, nlen);
            } else if (nlen >= 2048) {
                Pointer.Copy2048(dst, src, nlen);
            } else if (nlen >= 1024) {
                Pointer.Copy1024(dst, src, nlen);
            } else if (nlen >= 512) {
                Pointer.Copy512(dst, src, nlen);
            } else if (nlen >= 256) {
                Pointer.Copy256(dst, src, nlen);
            } else if (nlen >= 128) {
                Pointer.Copy128(dst, src, nlen);
            } else if (nlen >= 64) {
                Pointer.Copy64(dst, src, nlen);
            } else {
                Pointer.Copy32(dst, src, nlen);
            }
        }

        private static unsafe void Copy32(void* dst, void* src, long nLen) {
            long nWidth = sizeof(Block32);
            long nBlock = nLen / nWidth;
            Block32* pdst = (Block32*)dst;
            Block32* psrc = (Block32*)src;
            for (long i = 0; i < nBlock; i++) {
                *pdst = *psrc;
                pdst++;
                psrc++;
            }
            nLen = nLen % nWidth;
            if (nLen == 0) return;
            byte* pdst_new = (byte*)pdst;
            byte* psrc_new = (byte*)psrc;
            for (long i = 0; i < nLen; i++) {
                *pdst_new = *psrc_new;
                pdst_new++;
                psrc_new++;
            }
        }

        private static unsafe void Copy64(void* dst, void* src, long nLen) {
            long nWidth = sizeof(Block64);
            long nBlock = nLen / nWidth;
            Block64* pdst = (Block64*)dst;
            Block64* psrc = (Block64*)src;
            for (long i = 0; i < nBlock; i++) {
                *pdst = *psrc;
                pdst++;
                psrc++;
            }
            nLen = nLen % nWidth;
            if (nLen == 0) return;
            Copy32(pdst, psrc, nLen);
        }

        private static unsafe void Copy128(void* dst, void* src, long nLen) {
            long nWidth = sizeof(Block128);  // CPU cache lines are usually 64-byte aligned
            long nBlock = nLen / nWidth;
            Block128* pdst = (Block128*)dst;
            Block128* psrc = (Block128*)src;
            for (long i = 0; i < nBlock; i++) {
                *pdst = *psrc;
                pdst++;
                psrc++;
            }
            nLen = nLen % nWidth;
            if (nLen == 0) return;
            Copy64(pdst, psrc, nLen);
        }

        private static unsafe void Copy256(void* dst, void* src, long nLen) {
            long nWidth = sizeof(Block256);
            long nBlock = nLen / nWidth;
            Block256* pdst = (Block256*)dst;
            Block256* psrc = (Block256*)src;
            for (long i = 0; i < nBlock; i++) {
                *pdst = *psrc;
                pdst++;
                psrc++;
            }
            nLen = nLen % nWidth;
            if (nLen == 0) return;
            Copy128(pdst, psrc, nLen);
        }

        private static unsafe void Copy512(void* dst, void* src, long nLen) {
            long nWidth = sizeof(Block512);
            long nBlock = nLen / nWidth;
            Block512* pdst = (Block512*)dst;
            Block512* psrc = (Block512*)src;
            for (long i = 0; i < nBlock; i++) {
                *pdst = *psrc;
                pdst++;
                psrc++;
            }
            nLen = nLen % nWidth;
            if (nLen == 0) return;
            Copy256(pdst, psrc, nLen);
        }

        private static unsafe void Copy1024(void* dst, void* src, long nLen) {
            long nWidth = sizeof(Block1024);
            long nBlock = nLen / nWidth;
            Block1024* pdst = (Block1024*)dst;
            Block1024* psrc = (Block1024*)src;
            for (long i = 0; i < nBlock; i++) {
                *pdst = *psrc;
                pdst++;
                psrc++;
            }
            nLen = nLen % nWidth;
            if (nLen == 0) return;
            Copy512(pdst, psrc, nLen);
        }

        private static unsafe void Copy2048(void* dst, void* src, long nLen) {
            long nWidth = sizeof(Block2048);
            long nBlock = nLen / nWidth;
            Block2048* pdst = (Block2048*)dst;
            Block2048* psrc = (Block2048*)src;
            for (long i = 0; i < nBlock; i++) {
                *pdst = *psrc;
                pdst++;
                psrc++;
            }
            nLen = nLen % nWidth;
            if (nLen == 0) return;
            Copy1024(pdst, psrc, nLen);
        }

        private static unsafe void Copy4096(void* dst, void* src, long nLen) {
            long nWidth = sizeof(Block4096);
            long nBlock = nLen / nWidth;
            Block4096* pdst = (Block4096*)dst;
            Block4096* psrc = (Block4096*)src;
            for (long i = 0; i < nBlock; i++) {
                *pdst = *psrc;
                pdst++;
                psrc++;
            }
            nLen = nLen % nWidth;
            if (nLen == 0) return;
            Copy2048(pdst, psrc, nLen);
        }

        private static unsafe void Copy8192(void* dst, void* src, long nLen) {
            long nWidth = sizeof(Block8192);
            long nBlock = nLen / nWidth;
            Block8192* pdst = (Block8192*)dst;
            Block8192* psrc = (Block8192*)src;
            for (long i = 0; i < nBlock; i++) {
                *pdst = *psrc;
                pdst++;
                psrc++;
            }
            nLen = nLen % nWidth;
            if (nLen == 0) return;
            Copy4096(pdst, psrc, nLen);
        }

        private static unsafe void Copy16384(void* dst, void* src, long nLen) {
            long nWidth = sizeof(Block16384);
            long nBlock = nLen / nWidth;
            Block16384* pdst = (Block16384*)dst;
            Block16384* psrc = (Block16384*)src;
            for (long i = 0; i < nBlock; i++) {
                *pdst = *psrc;
                pdst++;
                psrc++;
            }
            nLen = nLen % nWidth;
            if (nLen == 0) return;
            Copy8192(pdst, psrc, nLen);
        }

        [StructLayout(LayoutKind.Sequential, Size = 32)]
        private struct Block32 { }

        [StructLayout(LayoutKind.Sequential, Size = 64)]
        private struct Block64 { }

        [StructLayout(LayoutKind.Sequential, Size = 128)]
        private struct Block128 { }

        [StructLayout(LayoutKind.Sequential, Size = 256)]
        private struct Block256 { }

        [StructLayout(LayoutKind.Sequential, Size = 512)]
        private struct Block512 { }

        [StructLayout(LayoutKind.Sequential, Size = 1024)]
        private struct Block1024 { }

        [StructLayout(LayoutKind.Sequential, Size = 2048)]
        private struct Block2048 { }

        [StructLayout(LayoutKind.Sequential, Size = 4096)]
        private struct Block4096 { }

        [StructLayout(LayoutKind.Sequential, Size = 8192)]
        private struct Block8192 { }

        [StructLayout(LayoutKind.Sequential, Size = 16384)]
        private struct Block16384 { }

        #region static methods

        private static int StrLen(IntPtr ptr) {
            int nLen = 0;
            while (Marshal.ReadByte(ptr, nLen) != 0) {
                nLen++;
            }
            return nLen;
        }

        private static void Read(IntPtr ptr, byte[] buffer, long nOffset, int nLen) {
            ptr = (IntPtr)((long)ptr + nOffset);
            Marshal.Copy(ptr, buffer, 0, nLen);
        }

        #endregion

    }
}
