using brod;
namespace brod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<brod>brodovi= new ();
        Random random= new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
          //  BackColor = Color.Blue;
            this.DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(brod brod in brodovi)
            {
                brod.Pomeri(5);
            }
            Refresh();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            brodovi.Add(new brod(
                x:e.X,
                y: e.Y,
                dimenzija: random.Next(10,41),
                brushKorito: Color.FromArgb(
                    red:random.Next(153, 154),
                    blue:random.Next(254,255),
                    green:random.Next(254,255),
                    alpha:random.Next(50,256)),
            bruhJedra: Color.FromArgb(
              red: random.Next(254,255),
              blue: random.Next(153,154),
              green: random.Next(254,255),
              alpha: random.Next(50, 256)
               
           )));
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach(brod brod in brodovi)
            {
                brod.Crtaj(e.Graphics);
            }
        }
    }
}