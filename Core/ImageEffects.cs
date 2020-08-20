using System;
using System.Collections.Generic;
using System.Drawing;

namespace IPA.Core
{
    public class ImageEffects
    {
        public static List<Bitmap> SimpleGrayScale(List<Bitmap> images)
        {
            List<Bitmap> applyed = new List<Bitmap>();
            foreach (Bitmap img in images)
            {
                Bitmap modImg = (Bitmap)img.Clone();
                for (int x = 0; x < modImg.Width; x++)
                {
                    for (int y = 0; y < modImg.Height; y++)
                    {
                        var p = modImg.GetPixel(x, y);
                        var l = (p.R + p.G + p.B) / 3;
                        modImg.SetPixel(x, y, Color.FromArgb(p.A, l, l, l));
                    }
                }
                applyed.Add(modImg);
            }
            return applyed;
        }

        public static List<Bitmap> WeightedGrayScale(List<Bitmap> images)
        {
            List<Bitmap> applyed = new List<Bitmap>();
            foreach (Bitmap img in images)
            {
                Bitmap cImg = (Bitmap)img.Clone();
                for (int x = 0; x < cImg.Width; x++)
                {
                    for (int y = 0; y < cImg.Height; y++)
                    {
                        var p = cImg.GetPixel(x, y);
                        var l = p.R * 0.299 + p.G * 0.587 + p.B * 0.114;
                        cImg.SetPixel(x, y, Color.FromArgb(p.A, (int)l, (int)l, (int)l));
                    }
                }
                applyed.Add(cImg);
            }
            return applyed;
        }

        public static List<Bitmap> Negative(List<Bitmap> images)
        {
            List<Bitmap> applyed = new List<Bitmap>();
            foreach (Bitmap img in images)
            {
                Bitmap cImg = (Bitmap)img.Clone();
                for (int x = 0; x < cImg.Width; x++)
                {
                    for (int y = 0; y < cImg.Height; y++)
                    {
                        var p = cImg.GetPixel(x, y);
                        cImg.SetPixel(x, y, Color.FromArgb(p.A, 255 - p.R, 255 - p.G, 255 - p.B));
                    }
                }
                applyed.Add(cImg);
            }
            return applyed;
        }

        public static List<Bitmap> Threshold(List<Bitmap> images, int L)
        {
            List<Bitmap> applyed = new List<Bitmap>();
            foreach (Bitmap img in images)
            {
                Bitmap cImg = (Bitmap)img.Clone();
                for (int x = 0; x < cImg.Width; x++)
                {
                    for (int y = 0; y < cImg.Height; y++)
                    {
                        var p = cImg.GetPixel(x, y);
                        if (p.R > L)
                        {
                            cImg.SetPixel(x, y, Color.FromArgb(p.A, 255, 255, 255));
                        }
                        else
                        {
                            cImg.SetPixel(x, y, Color.FromArgb(p.A, 0, 0, 0));
                        }
                    }
                }
                applyed.Add(cImg);
            }
            return applyed;
        }

        public static List<Bitmap> Adiction(Bitmap image1, Bitmap image2, float p)
        {
            Bitmap cImage1 = (Bitmap)image1.Clone();
            Bitmap cImage2 = (Bitmap)image2.Clone();
            int w, h;
            Bitmap res;
            List<Bitmap> applyed = new List<Bitmap>();

            if (cImage1.Width < cImage2.Width)
            {
                w = cImage1.Width;
                h = cImage1.Height;
                res = (Bitmap)image1.Clone();
            }
            else
            {
                w = cImage2.Width;
                h = cImage2.Height;
                res = (Bitmap)image2.Clone();
            }

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    var l1 = cImage1.GetPixel(x, y);
                    var l2 = cImage2.GetPixel(x, y);
                    res.SetPixel(x, y, Color.FromArgb(l1.A, 
                        (int)((l1.R * (1F - p)) + (l2.R * p)),
                        (int)((l1.G * (1F - p)) + (l2.G * p)),
                        (int)((l1.B * (1F - p)) + (l2.B * p))));
                }
            }

            applyed.Add(res);

            return applyed;
        }

        public static List<Bitmap> Subtraction(Bitmap image1, Bitmap image2, bool invert)
        {
            Bitmap cImage1 = (Bitmap)image1.Clone();
            Bitmap cImage2 = (Bitmap)image2.Clone();
            int w, h;
            Bitmap res;
            List<Bitmap> applyed = new List<Bitmap>();

            if (cImage1.Width < cImage2.Width)
            {
                w = cImage1.Width;
                h = cImage1.Height;
                res = (Bitmap)image1.Clone();
            }
            else
            {
                w = cImage2.Width;
                h = cImage2.Height;
                res = (Bitmap)image2.Clone();
            }

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    var l1 = cImage1.GetPixel(x, y);
                    var l2 = cImage2.GetPixel(x, y);
                    if (invert)
                    {
                        res.SetPixel(x, y, Color.FromArgb(l1.A,
                        Clamp(l2.R - l1.R, 0, 255),
                        Clamp(l2.G - l1.G, 0, 255),
                        Clamp(l2.B - l1.B, 0, 255)));
                    }
                    else
                    {
                        res.SetPixel(x, y, Color.FromArgb(l1.A,
                        Clamp(l1.R - l2.R, 0, 255),
                        Clamp(l1.G - l2.G, 0, 255),
                        Clamp(l1.B - l2.B, 0, 255)));
                    }
                    
                }
            }

            applyed.Add(res);

            return applyed;
        }

        public static int Clamp(int val, int min, int max)
        {
            if (val < min) return min;
            else if (val > max) return max;
            else return val;
        }
    }
}
