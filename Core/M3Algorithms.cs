using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IPA.Core
{
	public class M3Algorithms
	{
		public static int[,] PixelHistogram(Bitmap image)
		{
			var rgb = new int[3, 256];

			for (int i = 0; i < 256; i++)
			{
				for (int y = 0; y < image.Height; y++)
				{
					for (int x = 0; x < image.Width; x++)
					{
						var p = image.GetPixel(x, y);

						if (p.R == i)
						{
							rgb[0, i]++;
						}
						if (p.G == i)
						{
							rgb[1, i]++;
						}
						if (p.B == i)
						{
							rgb[2, i]++;
						}
					}
				}
			}

			return rgb;
		}

		public static Bitmap ZoomIn(Bitmap image, int factor)
		{
			Bitmap applyed = new Bitmap(image.Width * factor, image.Height * factor);
			for (int y = 0; y < image.Height; y++)
			{
				for (int x = 0; x < image.Width; x++)
				{
					for (int my = y * factor; my < y * factor + factor; my++)
					{
						var p = image.GetPixel(x, y);
						for (int mx = x * factor; mx < x * factor + factor; mx++)
						{
							applyed.SetPixel(mx, my, Color.FromArgb(p.A, p.R, p.G, p.B));
						}
					}
				}
			}
			return applyed;
		}

		public static Bitmap ZoomOut(Bitmap image, int factor)
		{
			Bitmap applyed = new Bitmap(image.Width / factor, image.Height / factor);
			for (int y = 0; y < applyed.Height; y++)
			{
				for (int x = 0; x < applyed.Width; x++)
				{
					int a = 0, r = 0, g = 0, b = 0;
					for (int my = y * factor; my < y * factor + factor; my++)
					{
						for (int mx = x * factor; mx < x * factor + factor; mx++)
						{
							var p = image.GetPixel(mx, my);
							a += p.A;
							r += p.R;
							g += p.G;
							b += p.B;
						}
					}
					applyed.SetPixel(x, y, Color.FromArgb(a / (factor * factor),
														  r / (factor * factor),
														  g / (factor * factor),
														  b / (factor * factor)));
				}
			}
			return applyed;
		}

		public static string BackgroundSubtraction(string path)
		{
			var frames = Util.GetVideoFrames(path);
			var fps = new VideoCapture(path).GetCaptureProperty(CapProp.Fps);
			int w = frames[0].Width, h = frames[0].Height;
			string newPath = path.Substring(0, path.Length - 4) + "_no-background.mp4";
			var videoWriter = new VideoWriter(newPath, VideoWriter.Fourcc('M', 'P', '4', 'V'), fps, new Size(w, h), true);

			var bg = Util.BitmapToBlack(new Bitmap(w, h));

			foreach (var frame in frames)
			{
				var btmFrame = Util.MatToBitmap(frame);
				for (int y = 0; y < bg.Height; y++)
				{
					for (int x = 0; x < bg.Width; x++)
					{
						var bgPixel = bg.GetPixel(x, y);
						var btmPixel = btmFrame.GetPixel(x, y);
						byte bgR, bgG, bgB, btmR, btmG, btmB;

						var val = 0.99;

						bgR = (byte)((bgPixel.R * val) + (btmPixel.R * (1.0 - val)));
						bgG = (byte)((bgPixel.G * val) + (btmPixel.G * (1.0 - val)));
						bgB = (byte)((bgPixel.B * val) + (btmPixel.B * (1.0 - val)));

						btmR = (byte)(btmPixel.R - bgR);
						btmG = (byte)(btmPixel.G - bgG);
						btmB = (byte)(btmPixel.B - bgB);

						bg.SetPixel(x, y, Color.FromArgb(byte.MaxValue, bgR, bgG, bgB));
						btmFrame.SetPixel(x, y, Color.FromArgb(byte.MaxValue, btmR, btmG, btmB));
					}
				}
				videoWriter.Write(Util.BitmapToMat(btmFrame));
				btmFrame.Dispose();
			}
			videoWriter.Dispose();

			return newPath;
		}
	}
}
