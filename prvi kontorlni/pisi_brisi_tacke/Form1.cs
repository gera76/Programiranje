using klasatacka;
namespace pisi_brisi_tacke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<tacke> tacka = new();
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Graphics g= CreateGraphics();
                tacke t = new( e.X, e.Y, Color.Blue);
                t.crtaj(g);
                tacka.Add(t);
            }
            else if(e.Button==MouseButtons.Right)
            {
                List<tacke> tackaZabrisanje = new();
                foreach(tacke t in tacka)
                {
                    double rastojanje2 = Math.Sqrt( Math.Pow(e.X - t.ProcitajX(), 2) + Math.Pow(e.Y - t.ProcitajY(), 2));
                    if(rastojanje2<5)
                    {
                        tackaZabrisanje.Add(t);
                    }
                }
                foreach(tacke t in tackaZabrisanje)
                {
                    tacka.Remove(t);
                }
            }
          

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (tacke t in tacka)
            {
                t.crtaj(e.Graphics);
            }
        }
    }
}