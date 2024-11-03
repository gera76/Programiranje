namespace pravugaonici_rendom
{
    public partial class Form1 : Form
    {
       // List <Pravugaonici> pravugaonici_rendom = [];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // uvodimo novu stvar timer
            timer1.Interval = 500;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();

            Random random = new Random();
            // uvodimo random
            Pravugaonici p = new(
                x: random.Next(ClientRectangle.Width),
                y: random.Next(ClientRectangle.Height),
                duzina: random.Next(25, 51),
                sirina: random.Next(51,101),
                boja: Color.FromArgb(
                   alpha:random.Next(50,256),
                   red:random.Next(0,256),
                    blue: random.Next(0, 256),
                     green: random.Next(0, 256)
                     ));

            p.Crtaj(g);
            
        }
    }
}