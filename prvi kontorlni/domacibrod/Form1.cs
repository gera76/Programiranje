using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using brod;

namespace domacibrod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // lista me je zezala posto sam koristio vec gotovu klasu i onda mi je internet pomogao sa onim using
        // i dodavanje ovo <brod.brod> svugde.
        List<brod.brod> brodovi = new();
        Random random = new Random();
        bool iciLevo=false;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
              BackColor = Color.Blue;
            this.DoubleBuffered = true;

            brodovi.Add(new brod.brod(
              // sredina forme je clientSize je cela sirina odnostno visina forme a polovina toga je nasa forma
              x: ClientSize.Width / 2,
              y: ClientSize.Height / 2,
              dimenzija: random.Next(10, 41),
              brushKorito: Color.FromArgb(
                  red: random.Next(153, 154),
                  blue: random.Next(254, 255),
                  green: random.Next(254, 255),
                  alpha: random.Next(50, 256)),
          bruhJedra: Color.FromArgb(
            red: random.Next(254, 255),
            blue: random.Next(153, 154),
            green: random.Next(254, 255),
            alpha: random.Next(50, 256)

         )));
            // posto imamo samo 1 ovaj ne treba nam refreah();
            //Refresh();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                iciLevo=true;
            }
            else if(e.Button == MouseButtons.Right)
            {
                iciLevo = false;
            }

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a;
            // posto je podrazumevana vredost ici levo netacna ukoliko ne ide levo ide desno(zato -5)
            // ako je netacna trvdnja netacna odna je trvdnja tacna i ide se levo
            if(iciLevo)
            {
                a = -5;
            }
            else
            {
                a = 5;
            } 
           
            foreach (brod.brod brod in brodovi)
            {
                brod.Pomeri(a);
            }
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (brod.brod brod in brodovi)
            {
                brod.Crtaj(e.Graphics);
            }

        }
    }
}