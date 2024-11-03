using System;
using System.Collections.Generic;
using System.Drawing;
namespace brod
{
    public class brod
    {
        private int x;
        private int y;
        private int dimenzija;
        private Brush brushKorito;
        private Brush brushJedra;
        public brod(int x, int y, int dimenzija, Color brushKorito, Color bruhJedra)
        {
            this.x = x;
            this.y = y;
            this.dimenzija = dimenzija;
            this.brushKorito =new SolidBrush(brushKorito);
            this.brushJedra = new SolidBrush(bruhJedra);
        }
        public brod(int x,int y,int dimenzija):this
            (x,y,dimenzija,Color.Red,Color.Brown)
        {

        }
        public void Pomeri()
        {
            Pomeri(1, 0);
        }
        public void Pomeri(int dx)
        {
            Pomeri(dx, 0);
        }
        public void Pomeri(int dx, int dy)
        {
            x += dx;
            y += dy;
        }
       
        public void Crtaj(Graphics g)
        {
            Point[] jedro = new Point[]
            {
                new Point(x,y),
                new Point(x,y-2*dimenzija),
                new Point(x+dimenzija,y-dimenzija),
            };
        
            g.FillPolygon(brushJedra, jedro);
            g.DrawPolygon(Pens.Black, jedro);

            Point[] korito = new Point[]
            {
                new Point(x+2*dimenzija,y),
                new Point(x+dimenzija,y+dimenzija),
                new Point(x-dimenzija,y+dimenzija),
                new Point(x-2*dimenzija,y),
            };
            g.FillPolygon(brushKorito, korito);
            g.DrawPolygon(Pens.Black, korito);
        }
    }
}
