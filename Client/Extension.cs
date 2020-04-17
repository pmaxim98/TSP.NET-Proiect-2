using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosGUI
{
    public static class Extension
    {
        private static readonly string[] MOVIE_EXTENSIONS = new string[] { ".mp4", ".avi", ".flv", ".wmv", ".mov" };
        private static readonly string[] IMAGE_EXTENSIONS = new string[] { ".png", ".bmp", ".jpg", ".jpeg", ".gif", ".tiff" };

        public static bool IsVideo(string filename)
        {
            return MOVIE_EXTENSIONS.Contains(Path.GetExtension(filename));
        }

        public static bool IsImage(string filename)
        {
            return IMAGE_EXTENSIONS.Contains(Path.GetExtension(filename));
        }

        public static bool IsMedia(string filename)
        {
            return IsVideo(filename) || IsImage(filename);
        }
    }
}
