using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kvadrati
{
    public class kvadrat
    {
        private Pen olovka;
        private int x;
        private int y;
        private int dimenzija;
        public kvadrat(Color boja, int x, int y, int dimenzija)
        {
            this.olovka = new Pen(boja,3);
            this.x = x;
            this.y = y;
            this.dimenzija = dimenzija;
        }

       public void Crtaj(Graphics g)
        {
            //  g.DrawRectangle(olovka, x - dimenzija / 2, y - dimenzija / 2, dimenzija);
            g.DrawRectangle(olovka, x - dimenzija / 2, y - dimenzija / 2, dimenzija, dimenzija);
            g.DrawLine(Pens.Black, x - dimenzija / 2, y - dimenzija / 2, x + dimenzija / 2, y + dimenzija / 2);
            g.DrawLine(Pens.Black, x - dimenzija / 2, y + dimenzija / 2, x + dimenzija / 2, y - dimenzija / 2);
        }
    }
}
