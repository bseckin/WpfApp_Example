using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class GeoObject
    {
        public GeoObject(string shape, int posX, int posY, int height, int width)
        {
            Shape = shape;
            PosX = posX;
            PosY = posY;
            Height = height;
            Width = width;
        }

        public string Shape { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

    }
}
