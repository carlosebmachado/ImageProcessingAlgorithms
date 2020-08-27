using System.Drawing;

namespace IPA.Core
{
    public class ImageData
    {
        public Bitmap Image { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }

        public ImageData(Bitmap image, string path)
        {
            var we = path.Substring(0, path.Length - 4);
            var splitted = we.Split('\\');
            Name = splitted[splitted.Length - 1];
            Image = image;
            for (int i = 0; i < splitted.Length - 1; i++)
            {
                Path += splitted[i] + '\\';
            }
            //Path += "images\\";
            //MessageBox.Show("Name: " + Name + "\nPath: " + Path + "\nFull: "+GetFullName());
        }

        public string GetFullName()
        {
            return Path + Name;
        }
    }
}
