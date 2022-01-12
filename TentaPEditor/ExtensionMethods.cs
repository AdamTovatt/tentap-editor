using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaPEditor
{
    public static class ExtensionMethods
    {
        public static byte[] ToByteArray(this Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, ImageFormat.Jpeg);
                return memoryStream.ToArray();
            }
        }

        public static string ToBase64(this byte[] array)
        {
            return Convert.ToBase64String(array);
        }
    }
}
