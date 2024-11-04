using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace mousemove
{
    public class Brod

    {
        private int x;
        private int y;
        private int dimenzija;
        private Brush cetkaJedra;
        private Brush cetkaKorita;
        public Brod(int x, int y, int dimenzija, Color bojaJedra, Color bojaKorita)
        {
            this.x = x;
            this.y = y;
            this.dimenzija = dimenzija;
            this.cetkaJedra = new SolidBrush(bojaJedra);
            this.cetkaKorita = new SolidBrush(bojaKorita);
        }
        public Brod(int x,int y,int dimenzija): 
            this(x,y,dimenzija,Color.Brown,Color.Red)
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
        public void Pomeri(int dx,int dy)
        {
           x+=dx;
           y+=dy;
        }
        public void Crtaj(Graphics g)
        {
            Point[]jedro=new Point[]
            {
                new Point(x-dimenzija, y),
                new Point(x-dimenzija/2,y- dimenzija),
                new Point(x+dimenzija/2,y- dimenzija),
                new Point(x+dimenzija,y),
            };
            g.FillPolygon(cetkaJedra,jedro);
           g.DrawPolygon(Pens.Black, jedro);

            Point[] korito = new Point[]
            {
                new Point(x-dimenzija,y),
                new Point(x-dimenzija,y+2*dimenzija),
                new Point(x+dimenzija,y+ 2*dimenzija),
                 new Point(x+dimenzija,y),
            };
            g.FillPolygon(cetkaKorita,korito);
            g.DrawPolygon(Pens.Black, korito);
        }
        public void crtajStrelicu( Graphics g)
        {
            Point[] jedrno = new Point[]
            {
                new Point (x,y),
                new Point(x-dimenzija/3,y+dimenzija/3),
                new Point(x+dimenzija/3,y+dimenzija/3)       
            };
            g.FillPolygon(cetkaJedra, jedrno);
            g.DrawPolygon(Pens.Black, jedrno);


            Point[] korito = new Point[]
            {
                new Point (x,y),
                new Point(x,y+dimenzija)
            };
            g.FillPolygon(cetkaJedra, korito);
            g.DrawPolygon(Pens.Black, korito);
        }
    }
}
