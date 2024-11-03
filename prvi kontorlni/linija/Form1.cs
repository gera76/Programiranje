using linija;
namespace linija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        linija pocetnalinija;
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
           
            try
            {
                linija krajnjalinija = new(e.X, e.Y, Color.Red);
                Graphics g = CreateGraphics();
                g.DrawLine(
                    Pens.Black,
                    pocetnalinija.procitajX(),
                    pocetnalinija.procitajY(),
                    krajnjalinija.procitajX(),
                    krajnjalinija.procitajY()
                    );
                pocetnalinija.crtaj(g);
                krajnjalinija.crtaj(g);
            }
            catch (Exception ect)
            {
                MessageBox.Show(
                    ect.Message,
                    "greska",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                pocetnalinija = new(e.X, e.Y, Color.Green);
            }
            catch (Exception ect)
            {
                MessageBox.Show(
                    ect.Message,
                    "greska",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}