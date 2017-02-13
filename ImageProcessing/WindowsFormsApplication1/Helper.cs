using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Helper
    {
        public void ResizeTo(string path, string pathToSave)
        {
            var image = AForge.Imaging.Image.FromFile(path);
            ResizeBicubic filter = new ResizeBicubic(480, 640);
            Bitmap toSave = filter.Apply(image);
            toSave.Save(pathToSave);
        }
    }
}
