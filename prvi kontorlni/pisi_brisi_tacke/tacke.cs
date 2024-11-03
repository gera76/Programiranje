using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasatacka
{
    public class tacke
    {
        private int x;
        private int y;
        private Brush brush;
        public tacke(int x, int y, Color boja)
        {
            this.x = x;
            this.y = y;
            this.brush = new SolidBrush(boja);
        }
        public double udaljenost(int x,int y)
        {
            return Math.Sqrt(Math.Pow(this.x-x,2) + Math.Pow(this.y-y,2));
        }
        public void crtaj(Graphics g)
        {
            Random rand = new Random();
            int d = rand.Next(10, 24);
            g.FillEllipse(brush, this.x - d / 2, this.y - d / 2, d, d);
        }

        // 2 getera koja nam sugerisu da mozemo menjati ovo i van klase
        public int ProcitajX()
        {
            return this.x;
        }
        public int ProcitajY()
        {
            return this.y;
        }
    }
}
