using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorProject
{
    class SeqView : View
    {
        public SeqView(List<Control> objs)
            : base(objs)
        {
        }

        public static Color randColor() {
            Random random = new Random();
            return(randColor(random.Next(0, 21)));
        }
        public static Color randColor(int randomNum)
        {
            switch (randomNum % 21)
            {
                case 0:
                    return Color.Tomato;
                case 1:
                    return Color.Brown;
                case 2:
                    return Color.CadetBlue;
                case 3:
                    return Color.BurlyWood;
                case 4:
                    return Color.Coral;
                case 5:
                    return Color.CornflowerBlue;
                case 6:
                    return Color.Crimson;
                case 7:
                    return Color.Goldenrod;
                case 8:
                    return Color.DarkKhaki;
                case 9:
                    return Color.DarkSalmon;
                case 10:
                    return Color.DarkSeaGreen;
                case 11:
                    return Color.IndianRed;
                case 12:
                    return Color.MediumAquamarine;
                case 13:
                    return Color.MediumPurple;
                case 14:
                    return Color.OliveDrab;
                case 15:
                    return Color.Orchid;
                case 16:
                    return Color.PaleVioletRed;
                case 17:
                    return Color.Peru;
                case 18:
                    return Color.SandyBrown;
                case 19:
                    return Color.SlateBlue;
                case 20:
                    return Color.SteelBlue;
                default:
                    return Color.Black;
            }
        }
        public static Color getColor(char nuc)
        {
            switch (nuc)
            {
                case 'A':
                    return Color.Green;
                case 'T':
                case 'U':
                    return Color.Purple;
                case 'C':
                    return Color.Red;
                case 'G':
                    return Color.Blue;
                default:
                    return Color.Black;
            }
        }
        public static Bitmap getImg(char nuc)
        {
            switch (nuc)
            {
                case 'A':
                    return Properties.Resources.adenine;
                case 'T':
                case 'U':
                    return Properties.Resources.uracil;
                case 'C':
                    return Properties.Resources.cytosine;
                case 'G':
                    return Properties.Resources.guanine;
                default:
                    return Properties.Resources.unk;
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
