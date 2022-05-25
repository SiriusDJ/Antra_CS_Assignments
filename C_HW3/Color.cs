using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW3
{
    public class Color
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        
        public Color(int red, int green, int blue, int alpha = 255)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public int getGrayscale()
        {
            int avg = (Red + Green + Blue) / 3;
            return avg;
        }
    }

    public class Ball
    {
        public int Size;
        public Color Color;
        public int Throw;

        public Ball(int size, Color color, int t)
        {
            Size = size;
            Color = color;
            Throw = t;
        }

        public void Pop()
        {
            Size = 0;

        }
        public void Throwing()
        {
            if (Size != 0)
            {
                Throw += 1;
            }
        }
        public int Getthrow()
        {
            return Throw;
        }
    }

}
