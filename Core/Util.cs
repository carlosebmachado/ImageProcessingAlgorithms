using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace IPA.Core
{
    public class Util
    {
        public static void PlotImage(Bitmap image)
		{
            var form = new Form
            {
                Text = "Image",
                Size = new Size(image.Width, image.Height)
            };
            var pb = new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = image
            };
            form.Controls.Add(pb);
            form.ShowDialog();
		}

        // função básica de clamp
        public static int Clamp(int val, int min, int max)
        {
            if (val < min) return min;
            else if (val > max) return max;
            else return val;
        }

        public static Bitmap BitmapToBlack(Bitmap image)
        {
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    image.SetPixel(x, y, Color.FromArgb(255, 0, 0, 0));
                }
            }
            return image;
        }

        public static Bitmap BitmapToWhite(Bitmap image)
        {
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    image.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));
                }
            }
            return image;
        }

        public static Mat BitmapToMat(Bitmap bitmap)
        {
            var mat = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);
            return new Image<Bgr, byte>(mat.Width, mat.Height, mat.Stride, mat.Scan0).Mat;
        }

        public static Bitmap MatToBitmap(Mat mat)
        {
            return (Bitmap)Image.FromStream(new MemoryStream(mat.ToImage<Bgr, byte>().ToJpegData()));
        }

        public static List<Mat> GetVideoFrames(string fileName)
        {
            var imageArray = new List<Mat>();
            var capture = new VideoCapture(fileName);
            var frameCount = capture.GetCaptureProperty(CapProp.FrameCount);
            //MessageBox.Show("Frames: " + frameCount);
            for (int i = 0; i < frameCount; i++)
            {
                var frame = capture.QuerySmallFrame();
                if (frame != null)
                {
                    imageArray.Add(frame);
                }
                else
                {
                    break;
                }
            }
            return imageArray;
        }
    }
}
