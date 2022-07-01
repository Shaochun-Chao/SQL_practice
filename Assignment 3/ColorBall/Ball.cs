using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorBall
{
    public class Ball : Color
    {
        public Ball(int r, int g, int b, int a,int s) : base(r, g, b, a)
        {
            red = r;
            green = g;
            blue = b;
            alpha = a;
            size = s;
        }

        public int size { get; set; }
        public int cthrow { get; set; }

        public int Pop()
        {
            return size = 0;
        }

        public int Throw()
        {
            if(size != 0)
            {
                return cthrow += 1;
            }
            return cthrow;
            
        }

        public void PrintCount()
        {
            Console.WriteLine(cthrow);
        }
    }
}
