using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bojenje_tacaka_kilkom
{
    public class tacka
    {
        private int x;
        private int y;
        public tacka(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double udaljenost(int x,int y)
        {
            return Math.Sqrt(Math.Abs(Math.Pow(x-this.x,2)) + Math.Abs(Math.Pow(y - this.y, 2)));
        }

        public void Crtaj(Graphics graphics, Color boja)
        {
            int d = 10;
            graphics.FillEllipse(new SolidBrush(boja),x-d/2,y-d/2,d,d);
        }
    }
}
