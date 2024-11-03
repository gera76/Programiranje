using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krug_domaci1
{
  public class tacka
    {
        private int x;
        private int y;
        private Brush brush;
        public tacka(int x, int y,Color boja)
        {
            this.x = x;
            this.y = y;
            this.brush = new  SolidBrush(Color.Gray);
        }
        public double rastojanje(int x,int y)
        {
            // po formuili za rastojanje utrvidili smo sta znaci udaljenost 2 tacke 
            return Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));
        }

      public void Crtaj(Graphics graphics, Color boja)
        {
            // 2) precnik je sada radnom
            Random random = new Random();
            int d = random.Next(10,25);
            graphics.FillEllipse( new SolidBrush(boja), this.x - d / 2, this.y - d / 2, d, d);
        }
    }
}
