using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_256color
{
    internal class Util
    {
        public static Color get256Color(Color col)
        {
            //256色模式： 共8 bits (B: 2 bits; G: 3 bits; R: 3 bits)。
            int r = col.R, g = col.G, b = col.B;
            r = r & 0xC0;
            g = g & 0xC0;
            b = b & 0xC0;

            return Color.FromArgb(r, g, b);
        }
    }
}
