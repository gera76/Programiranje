using mousemove;
namespace mousemove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    // 2)    Brod brod;
       /*1) */ List<Brod>brod= new List<Brod>();
          bool tasterpritisnut=false;
        Point PoslednjaPoznatatackamisa = new();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered=true;
            //1)
            brod.Add(new Brod(
                // 2)  brod = new Brod(
                x: ClientRectangle.Width / 2,
                y:ClientRectangle.Height/2,
                dimenzija: 50
            ) );
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // ne treba
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // 1)
            foreach(Brod brod in brod)
            brod.Crtaj(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // ne treba
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!tasterpritisnut)
            {
                return;
            }
            //1)
            foreach(Brod brod in brod)
            brod.Pomeri(
                dx: e.X - PoslednjaPoznatatackamisa.X,
                dy: e.Y - PoslednjaPoznatatackamisa.Y
                );
            PoslednjaPoznatatackamisa.X = e.X;
            PoslednjaPoznatatackamisa.Y = e.Y;
            Refresh();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            tasterpritisnut = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            tasterpritisnut = true;
            PoslednjaPoznatatackamisa.X = e.X;
            PoslednjaPoznatatackamisa.Y = e.Y;
        }
    }
}