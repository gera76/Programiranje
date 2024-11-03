
namespace krug_domaci1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        tacka[] tacke;
        // 1) psto na pocetku hocemo sivo 
        bool kliknuto=false;
        private void Form1_Load(object sender, EventArgs e)
        {
            // pravimo 900 tacaka uvek fiksirane  i zato koristimo niz a ne listu
            tacke=new tacka[900]; 
            Random rand = new Random();
            for(int i=0;i<tacke.Length;i++)
            {
                tacke[i] = new tacka(
                    x: rand.Next(ClientRectangle.Width),
                    y: rand.Next(ClientRectangle.Height),
                    Color.Gray
                    );
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //kada kliknemo misem on nam sorira tacke po udaljenosti da zna koje tacke su mu blize a koje su mu dalje
            // 4) sada nam treba samo za donji deo forme sa desne strane tkd ce se promeniti sa mousclika na desnu ivicu forme

            Array.Sort
                (tacke,
                (tacka t1, tacka t2)=>
                {
                    double d1 =t1.rastojanje(e.X, e.Y);
                    double d2 =t2.rastojanje(e.X, e.Y);
                    // math.sign vraca 3 parametra -1 0 1
                    // u ovom slucaju nam sortira po udaljenosti
                    // kad kliknemo misem negde on nam odredi koje tacke su najblize 
                    return Math.Sign(d1 - d2);
                }
                );
            kliknuto=true;
            //da bi se videla promena koristimo refresh();
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!kliknuto)
            {
                for (int i = 0; i < tacke.Length; i++)
                {
                    tacke[i].Crtaj(e.Graphics, Color.Gray);
                }
            }
            else
            {
                // 3) sada se ide na svakih 25% a i boje su promenjene
                int a = tacke.Length / 4;
                for (int i = 0; i < tacke.Length; i++)
                {
                    Color boja =
                        i < a ?
                        Color.Red :
                         i < 2 * a ?
                        Color.Orange :
                         i < 3 * a ?
                        Color.Yellow :
                        Color.Gray;
                    tacke[i].Crtaj(e.Graphics, boja);
                }
            }
        }
    }
}