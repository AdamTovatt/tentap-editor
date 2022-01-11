using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaPEditor
{
    public class ImageHelper
    {
        private static Image errorImage = null;

        public static Image GetErrorImage()
        {
            if (errorImage == null)
            {
                Bitmap bitmap = new Bitmap(64, 64);

                for (int i = 0; i < 64; i++)
                {
                    for (int j = 0; j < 64; j++)
                    {
                        if (i == j || i + 1 == j || i - 1 == j)
                            bitmap.SetPixel(i, j, Color.Red);
                        else
                            bitmap.SetPixel(i, j, Color.White);
                    }
                }

                errorImage = bitmap;
            }

            return errorImage;
        }
    }
}
