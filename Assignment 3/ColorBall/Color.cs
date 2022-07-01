using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorBall
{
    public class Color
    {

        public Color(int r, int g, int b, int a)
        {
            red = r;
            green = g;
            blue = b;
            alpha = a;
        }

        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }
        public int alpha { get; set; }

        


        public int grayscale(int r, int g, int b)
        {
            int gvalue = (int)(r + g + b)/3;

            return gvalue;
        }

    }
}
