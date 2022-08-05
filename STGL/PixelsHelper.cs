using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace STGL
{
    /*
     * Note: this code can only run in .Net Framework. 
     * Becasue .Net Core or .NetX not have System.Drawing.Bitmap;
     */
    public class PixelsHelper
    {
        public struct PixelsInfo
        {
            public int Width;
            public int Height;
            public int Channel;
            public byte[] Pixels;
        }

        public static PixelsInfo GetPixelsInfo(string strImageFile, PixelFormat format) {
            PixelsInfo pi = new PixelsInfo();
            Bitmap bmp = (Bitmap)Bitmap.FromFile(strImageFile);
            BitmapData bmpData = bmp.LockBits(new Rectangle(Point.Empty, bmp.Size), ImageLockMode.ReadOnly, format);
            pi.Width = bmp.Width;
            pi.Height = bmp.Height;
            pi.Channel = (bmpData.Stride / 4 * 4) / bmp.Width;
            pi.Pixels = new byte[pi.Width * pi.Height * pi.Channel];
            byte[] bySrc = new byte[bmpData.Stride * bmpData.Height];
            Marshal.Copy(bmpData.Scan0, bySrc, 0, bySrc.Length);
            int nLineWidth = pi.Channel * pi.Width;
            int nIndexDst = 0;
            int nIndexSrc = (bmp.Height - 1) * bmpData.Stride;
            for (int y = bmp.Height - 1; y >= 0; y--) {
                for (int x = 0, nLen = bmp.Width * pi.Channel; x < nLen; x += pi.Channel) {
                    int nTemp = nIndexSrc + x + pi.Channel - 1;
                    for (int c = 0; c < pi.Channel; c++) {
                        pi.Pixels[nIndexDst++] = bySrc[nTemp - c];
                    }
                }
                nIndexSrc -= bmpData.Stride;
            }
            bmp.UnlockBits(bmpData);
            bmp.Dispose();
            return pi;
        }
    }
}
