using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linija
{
  public class linija
    {
        private int x;
        private int y;
        private Brush brush;

        public linija(int x, int y, Color boja)
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
            this.brush = new SolidBrush(boja);
        }
        public void crtaj(Graphics g)
        {
            Random random = new Random();
            int d = random.Next(10,26);
            g.FillEllipse(brush,this.x-d/2,this.y-d/2,d,d);
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
