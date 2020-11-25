using System;
using System.Drawing;

namespace IPA.Core
{
    public class SpaceEffects
    {
        // EFEITO: 7
        public static Bitmap Convoluction(Bitmap image, int[][] mask, int div, int size, bool applyR, bool applyG, bool applyB)
        {
            // percorre pixel a pixel bi-dimensionalmente
            Bitmap applyed = new Bitmap(image.Width, image.Height);

            for (int y = size; y < applyed.Height - size; y++)
            {
                for (int x = size; x < applyed.Width - size; x++)
                {
                    int sr = 0, sg = 0, sb = 0;
                    int mx = 0, my = 0;
                    for (int yy = y - size; yy <= y + size; yy++)
                    {
                        for (int xx = x - size; xx <= x + size; xx++)
                        {
                            if (applyR) sr += image.GetPixel(xx, yy).R * mask[mx][my];
                            if (applyG) sg += image.GetPixel(xx, yy).G * mask[mx][my];
                            if (applyB) sb += image.GetPixel(xx, yy).B * mask[mx][my];
                            my++;
                        }
                        mx++;
                        my = 0;
                    }
                    if (applyR)
                    {
                        var p = applyed.GetPixel(x, y);
                        applyed.SetPixel(x, y, Color.FromArgb(255, Util.Clamp(sr / div, 0, 255), p.G, p.B));
                    }
                    if (applyG)
                    {
                        var p = applyed.GetPixel(x, y);
                        applyed.SetPixel(x, y, Color.FromArgb(255, p.R, Util.Clamp(sg / div, 0, 255), p.B));
                    }
                    if (applyB)
                    {
                        var p = applyed.GetPixel(x, y);
                        applyed.SetPixel(x, y, Color.FromArgb(255, p.R, p.G, Util.Clamp(sb / div, 0, 255)));
                    }
                }
            }
            return applyed;
        }

        #region Morphology

        // EFEITO: 8 E 10
        public static Bitmap Dilation(Bitmap image, int[][] mask, int size)
        {
            // percorre pixel a pixel bi-dimensionalmente
            Bitmap applyed = new Bitmap(image.Width, image.Height);
            applyed = Util.BitmapToBlack(applyed);
            for (int y = size; y < applyed.Height - size; y++)
            {
                for (int x = size; x < applyed.Width - size; x++)
                {
                    if (image.GetPixel(x, y).R > 55)
                    {
                        int mx = 0, my = 0;
                        for (int yy = y - size; yy <= y + size; yy++)
                        {
                            for (int xx = x - size; xx <= x + size; xx++)
                            {
                                if (mask[mx][my] == 1)
                                {
                                    applyed.SetPixel(xx, yy, Color.FromArgb(255, 255, 255, 255));
                                }
                                my++;
                            }
                            mx++;
                            my = 0;
                        }
                    }
                }
            }
            return applyed;
        }

        // EFEITO: 9 E 10
        public static Bitmap Erosion(Bitmap image, int[][] mask, int size)
        {
            // percorre pixel a pixel bi-dimensionalmente
            Bitmap applyed = new Bitmap(image.Width, image.Height);
            applyed = Util.BitmapToWhite(applyed);
            for (int y = size; y < applyed.Height - size; y++)
            {
                for (int x = size; x < applyed.Width - size; x++)
                {
                    if (image.GetPixel(x, y).R < 200)
                    {
                        int mx = 0, my = 0;
                        for (int yy = y - size; yy <= y + size; yy++)
                        {
                            for (int xx = x - size; xx <= x + size; xx++)
                            {
                                if (mask[mx][my] == 1)
                                {
                                    applyed.SetPixel(xx, yy, Color.FromArgb(255, 0, 0, 0));
                                }
                                my++;
                            }
                            mx++;
                            my = 0;
                        }
                    }
                }
            }
            return applyed;
        }

        #endregion Morphology

        #region EdgeDetect

        // EFEITO: 11
        public static Bitmap Roberts(Bitmap image)
        {
            // percorre pixel a pixel bi-dimensionalmente
            Bitmap applyed = new Bitmap(image.Width, image.Height);
            applyed = Util.BitmapToBlack(applyed);

            var maskx = new int[][]
            {
                new int[]{  0, 1 },
                new int[]{ -1, 0 }
            };
            var masky = new int[][]
            {
                new int[]{ 1,  0 },
                new int[]{ 0, -1 }
            };

            for (int y = 0; y < applyed.Height - 1; y++)
            {
                for (int x = 0; x < applyed.Width - 1; x++)
                {
                    int gx = 0, gy = 0;
                    int mx = 0, my = 0;
                    for (int yy = y; yy < y + 2; yy++)
                    {
                        for (int xx = x; xx < x + 2; xx++)
                        {
                            gx += image.GetPixel(xx, yy).R * maskx[mx][my];
                            gy += image.GetPixel(xx, yy).R * masky[mx][my];
                            my++;
                        }
                        mx++;
                        my = 0;
                    }
                    var g = Util.Clamp((int)Math.Sqrt(Math.Pow(gx, 2) + Math.Pow(gy, 2)), 0, 255);
                    applyed.SetPixel(x, y, Color.FromArgb(255, g, g, g));
                }
            }
            return applyed;
        }

        // EFEITO: 12
        public static Bitmap Sobel(Bitmap image)
        {
            // percorre pixel a pixel bi-dimensionalmente
            Bitmap applyed = new Bitmap(image.Width, image.Height);
            applyed = Util.BitmapToBlack(applyed);

            var maskx = new int[][]
            {
                new int[]{ 1, 0, -1},
                new int[]{ 2, 0, -2},
                new int[]{ 1, 0, -1}
            };
            var masky = new int[][]
            {
                new int[]{  1,  2,  1},
                new int[]{  0,  0,  0},
                new int[]{ -1, -2, -1}
            };

            for (int y = 1; y < applyed.Height - 1; y++)
            {
                for (int x = 1; x < applyed.Width - 1; x++)
                {
                    int gx = 0, gy = 0;
                    int mx = 0, my = 0;
                    for (int yy = y - 1; yy < y + 2; yy++)
                    {
                        for (int xx = x - 1; xx < x + 2; xx++)
                        {
                            gx += image.GetPixel(xx, yy).R * maskx[mx][my];
                            gy += image.GetPixel(xx, yy).R * masky[mx][my];
                            my++;
                        }
                        mx++;
                        my = 0;
                    }
                    var g = Util.Clamp((int)Math.Sqrt(Math.Pow(gx, 2) + Math.Pow(gy, 2)), 0, 255);
                    applyed.SetPixel(x, y, Color.FromArgb(255, g, g, g));
                }
            }
            return applyed;
        }

        // EFEITO: 14
        public static Bitmap Robinson(Bitmap image)
        {
            // percorre pixel a pixel bi-dimensionalmente
            Bitmap applyed = new Bitmap(image.Width, image.Height);
            //Bitmap applyed = (Bitmap)image.Clone();
            applyed = Util.BitmapToBlack(applyed);
            //applyed = BitmapToWhite(applyed);

            var maskT = new int[][]
            {
                new int[]{  1,  2,  1},
                new int[]{  0,  0,  0},
                new int[]{ -1, -2, -1}
            };
            var maskL = new int[][]
            {
                new int[]{ 1, 0, -1},
                new int[]{ 2, 0, -2},
                new int[]{ 1, 0, -1}
            };
            var maskLT = new int[][]
            {
                new int[]{ 2,  1,  0},
                new int[]{ 1,  0, -1},
                new int[]{ 0, -1, -2}
            };
            var maskBL = new int[][]
            {
                new int[]{ 0, -1, -2},
                new int[]{ 1,  0, -1},
                new int[]{ 2,  1,  0}
            };

            for (int y = 1; y < applyed.Height - 1; y++)
            {
                for (int x = 1; x < applyed.Width - 1; x++)
                {
                    int gT = 0, gTR = 0, gR = 0, gRB = 0, gB = 0, gBL = 0, gL = 0, gLT = 0;
                    int mx = 0, my = 0;
                    for (int yy = y - 1; yy < y + 2; yy++)
                    {
                        for (int xx = x - 1; xx < x + 2; xx++)
                        {
                            gT += image.GetPixel(xx, yy).R * maskT[mx][my];
                            gTR += image.GetPixel(xx, yy).R * (maskBL[mx][my] * -1);
                            gR += image.GetPixel(xx, yy).R * (maskL[mx][my] * -1);
                            gRB += image.GetPixel(xx, yy).R * (maskLT[mx][my] * -1);
                            gB += image.GetPixel(xx, yy).R * (maskT[mx][my] * -1);
                            gBL += image.GetPixel(xx, yy).R * maskBL[mx][my];
                            gL += image.GetPixel(xx, yy).R * maskT[mx][my];
                            gLT += image.GetPixel(xx, yy).R * maskLT[mx][my];
                            my++;
                        }
                        mx++;
                        my = 0;
                    }
                    var g = Util.Clamp((int)Math.Sqrt(
                        Math.Pow(gT, 2) +
                        Math.Pow(gTR, 2) +
                        Math.Pow(gR, 2) +
                        Math.Pow(gRB, 2) +
                        Math.Pow(gB, 2) +
                        Math.Pow(gBL, 2) +
                        Math.Pow(gL, 2) + 
                        Math.Pow(gLT, 2)), 0, 255);
                    applyed.SetPixel(x, y, Color.FromArgb(255, g, g, g));
                }
            }
            return applyed;
        }

        #endregion EdgeDetect

    }
}
