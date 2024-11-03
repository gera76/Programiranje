namespace bojenje_tacaka_kilkom
{
    public partial class Form1 : Form
    {
        tacka[] tacke;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tacke = new tacka[900];
            Random random = new Random();
            for(int i = 0; i < tacke.Length; i++)
            {
                 tacke[i] = new tacka(
                     // budi mi u formi
                   x: random.Next(ClientRectangle.Width),
                   y: random.Next(ClientRectangle.Height));
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Array.Sort(
                tacke,
                (tacka t1,tacka t2) =>
                {
                    double d1= t1.udaljenost(e.X, e.Y);
                    double d2= t2.udaljenost(e.X, e.Y);
                    return Math.Sign(d1 - d2);
                });

            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int grupa = tacke.Length/6;
            for(int i=0;i<tacke.Length;i++)
            {
                Color boja =
                    i < grupa ?
                    Color.Red :
                    i < 2 * grupa ?
                    Color.Yellow :
                    i < 3 * grupa ?
                    Color.Green :
                   Color.Black;
                tacke[i].Crtaj(e.Graphics, boja);
            }
        }
    }
}