using veci_manji_krug;
namespace padanjekrugova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        krug[] krugovi = new krug[20];
        Random rand= new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < krugovi.Length; i++)
            {
                int r=rand.Next(10,51);
                krugovi[i] = new(
                    x:rand.Next(ClientRectangle.Width),
                    y:r,
                    r,
                    boja:Color.FromArgb(
                    red :rand.Next(0,256),
                    green: rand.Next(0, 256),
                    blue: rand.Next(0, 256),
                    alpha:rand.Next(50, 255)
                    ));
            }
            timer1.Interval = 200;
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < krugovi.Length; i++)
            {
                krugovi[i].Pomeri(dx:0,dy:rand.Next(1,21));
            }
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < krugovi.Length; i++)
            {
                krugovi[i].crtaj(e.Graphics);
            }
        }
    }
}