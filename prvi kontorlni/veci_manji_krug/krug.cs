using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veci_manji_krug
{
   public  class krug
    {
        private int x;
        private int y;
        private int r;
        private Color boja;
        public krug(int x, int y, int r, Color boja)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            this.boja = boja;
        }
        public void crtaj(Graphics graphics)
        {
            Pen olovka = new Pen(boja,3);
            graphics.DrawEllipse(
                pen: olovka,
                x: x - r,
                y: y-r,
               width:r-2,
               height:r-2
                ) ;
        }
        public void Povecaj()
        {
            Povecaj(1);
        }
        public void Povecaj(int uvecanje)
        {
            r += uvecanje;
        }
        public void Smanji()
        {
            Smanji(1);
        }
        public void Smanji(int umanjenje)
        {
            if(umanjenje>r)
            {
                throw new Exception($"Ne možemo umanjiti krug poluprečnika {r}");
            }
            r-=umanjenje;
        }
        public void Postaviboju(Color boja)
        {
            this.boja=boja;
        }
    }
    
}
