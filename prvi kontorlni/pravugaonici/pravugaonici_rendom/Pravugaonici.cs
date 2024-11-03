using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pravugaonici_rendom
{
    public  class Pravugaonici
    {
        private int x;
        private int y;
        private int duzina;
        private int sirina;
        // brush kad je odojen a pen kada nije obojen
        private Brush Cetka;

        public Pravugaonici(int x, int y, int duzina, int sirina, Color boja)
        {
            this.x = x;
            this.y = y;
            this.duzina = duzina;
            this.sirina = sirina;
            // solidbrush kao novi atribut
            this.Cetka = new SolidBrush(boja);
        }

        internal void Crtaj(Graphics g)
        {
            // sada hocemo popunjeno i korstimo fill a ne draW
            g.FillRectangle(Cetka, x, y, sirina, duzina);
        }
    }
   
}
