using System.Drawing;

namespace IPA.Core
{
    public class SpaceEffects
    {
        public static Bitmap Convoluction(Bitmap image, int[][] mask, int size, bool applyR, bool applyG, bool applyB)
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
                        applyed.SetPixel(x, y, Color.FromArgb(255, Util.Clamp(sr, 0, 255), p.G, p.B));
                    }
                    if (applyG)
                    {
                        var p = applyed.GetPixel(x, y);
                        applyed.SetPixel(x, y, Color.FromArgb(255, p.R, Util.Clamp(sg, 0, 255), p.B));
                    }
                    if (applyB)
                    {
                        var p = applyed.GetPixel(x, y);
                        applyed.SetPixel(x, y, Color.FromArgb(255, p.R, p.G, Util.Clamp(sb, 0, 255)));
                    }
                }
            }
            return applyed;
        }
    }
}
