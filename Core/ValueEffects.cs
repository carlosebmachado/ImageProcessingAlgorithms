using System.Drawing;

namespace IPA.Core
{
    public class ValueEffects
    {
        // EFEITO: 1
        public static Bitmap GrayScale(Bitmap image, bool weighted)
        {
            // percorre pixel a pixel bi-dimensionalmente
            Bitmap applyed = (Bitmap)image.Clone();
            for (int y = 0; y < applyed.Height; y++)
            {
                for (int x = 0; x < applyed.Width; x++)
                {
                    // pega o pixel e aplica o efeito
                    var p = applyed.GetPixel(x, y);
                    double l;
                    if (weighted) l = p.R * 0.299 + p.G * 0.587 + p.B * 0.114;
                    else l = (p.R + p.G + p.B) / 3;
                    applyed.SetPixel(x, y, Color.FromArgb(p.A, (int)l, (int)l, (int)l));
                }
            }
            return applyed;
        }

        // EFEITO: 2
        public static Bitmap Threshold(Bitmap image, int L)
        {
            Bitmap applyed = (Bitmap)image.Clone();
            for (int y = 0; y < applyed.Height; y++)
            {
                for (int x = 0; x < applyed.Width; x++)
                {
                    // atraves do limiar definido, define a cor do pixel
                    var p = applyed.GetPixel(x, y);
                    if (p.R > L)
                    {
                        applyed.SetPixel(x, y, Color.FromArgb(p.A, 255, 255, 255));
                    }
                    else
                    {
                        applyed.SetPixel(x, y, Color.FromArgb(p.A, 0, 0, 0));
                    }
                }
            }
            return applyed;
        }

        // EFEITO: 3
        public static Bitmap Negative(Bitmap image)
        {
            Bitmap applyed = (Bitmap)image.Clone();
            for (int y = 0; y < applyed.Height; y++)
            {
                for (int x = 0; x < applyed.Width; x++)
                {
                    var p = applyed.GetPixel(x, y);
                    applyed.SetPixel(x, y, Color.FromArgb(p.A, 255 - p.R, 255 - p.G, 255 - p.B));
                }
            }
            return applyed;
        }

        // EFEITO: 4
        public static Bitmap Adiction(Bitmap image1, Bitmap image2)
        {
            Bitmap cImage1 = (Bitmap)image1.Clone();
            Bitmap cImage2 = (Bitmap)image2.Clone();
            int w, h;
            Bitmap applyed;
            // verifica a menor imagem para ser a base
            if (cImage1.Width < cImage2.Width)
            {
                w = cImage1.Width;
                h = cImage1.Height;
                applyed = (Bitmap)image1.Clone();
            }
            else
            {
                w = cImage2.Width;
                h = cImage2.Height;
                applyed = (Bitmap)image2.Clone();
            }

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    // é feita a soma das imagens atraves do peso definido para cada img
                    var l1 = cImage1.GetPixel(x, y);
                    var l2 = cImage2.GetPixel(x, y);
                    applyed.SetPixel(x, y, Color.FromArgb(l1.A,
                        (l1.R + l2.R) / 2,
                        (l1.G + l2.G) / 2,
                        (l1.B + l2.B) / 2));
                }
            }

            return applyed;
        }

        // EFEITO: 5
        public static Bitmap AdictionWeighted(Bitmap image1, Bitmap image2, float p)
        {
            Bitmap cImage1 = (Bitmap)image1.Clone();
            Bitmap cImage2 = (Bitmap)image2.Clone();
            int w, h;
            Bitmap applyed;
            // verifica a menor imagem para ser a base
            if (cImage1.Width < cImage2.Width)
            {
                w = cImage1.Width;
                h = cImage1.Height;
                applyed = (Bitmap)image1.Clone();
            }
            else
            {
                w = cImage2.Width;
                h = cImage2.Height;
                applyed = (Bitmap)image2.Clone();
            }

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    // é feita a soma das imagens atraves do peso definido para cada img
                    var l1 = cImage1.GetPixel(x, y);
                    var l2 = cImage2.GetPixel(x, y);
                    applyed.SetPixel(x, y, Color.FromArgb(l1.A, 
                        (int)((l1.R * (1F - p)) + (l2.R * p)),
                        (int)((l1.G * (1F - p)) + (l2.G * p)),
                        (int)((l1.B * (1F - p)) + (l2.B * p))));
                }
            }

            return applyed;
        }

        // EFEITO: 6
        public static Bitmap Subtraction(Bitmap image1, Bitmap image2, bool invert)
        {
            Bitmap cImage1 = (Bitmap)image1.Clone();
            Bitmap cImage2 = (Bitmap)image2.Clone();
            int w, h;
            Bitmap applyed;

            if (cImage1.Width < cImage2.Width)
            {
                w = cImage1.Width;
                h = cImage1.Height;
                applyed = (Bitmap)image1.Clone();
            }
            else
            {
                w = cImage2.Width;
                h = cImage2.Height;
                applyed = (Bitmap)image2.Clone();
            }

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    var l1 = cImage1.GetPixel(x, y);
                    var l2 = cImage2.GetPixel(x, y);
                    // possivel inversao de subtração
                    if (invert)
                    {
                        applyed.SetPixel(x, y, Color.FromArgb(l1.A,
                        Util.Clamp(l2.R - l1.R, 0, 255),
                        Util.Clamp(l2.G - l1.G, 0, 255),
                        Util.Clamp(l2.B - l1.B, 0, 255)));
                    }
                    else
                    {
                        applyed.SetPixel(x, y, Color.FromArgb(l1.A,
                        Util.Clamp(l1.R - l2.R, 0, 255),
                        Util.Clamp(l1.G - l2.G, 0, 255),
                        Util.Clamp(l1.B - l2.B, 0, 255)));
                    }
                    
                }
            }

            return applyed;
        }
    }
}
