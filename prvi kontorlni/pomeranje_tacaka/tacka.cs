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
        private Brush cetka;
        public tacka(int x, int y, Color boja)
        {
            PostaviXY(x, y);
            PostaviBoju(boja);
        }
        public void PostaviXY(int x, int y)
        {
            if (x < 0)
            {
                throw new ArgumentException("X ne može biti negativno");
            }

            if (y < 0)
            {
                throw new ArgumentException("Y ne može biti negativno");
            }

            this.x = x;
            this.y = y;
        }

        // Javni metod za menjanje boje tačke.
        public void PostaviBoju(Color boja)
        {
            this.cetka = new SolidBrush(boja);
        }
        public double udaljenost(int x,int y)
        {
            return Math.Sqrt(Math.Abs(Math.Pow(x-this.x,2)) + Math.Abs(Math.Pow(y - this.y, 2)));
        }

        public void Crtaj(Graphics graphics)
        {
            int d = 10;
            graphics.FillEllipse(cetka,x-d/2,y-d/2,d,d);
        }
        public int procitajX()
        {
            return this.x;
        }
        public int procitajY()
        {
            return this.y;
        }
    }
}
