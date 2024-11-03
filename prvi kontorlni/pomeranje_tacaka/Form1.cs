using bojenje_tacaka_kilkom;
namespace pomeranje_tacaka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        tacka[] tacke = new tacka[100]; 
        Random rand = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i < tacke.Length; i++)
            {
                tacke[i] = new(
                    x: rand.Next(ClientRectangle.Width),
                    y: rand.Next(ClientRectangle.Height),
                    boja:Color.FromArgb(
                        alpha:rand.Next(50,256),
                        red: rand.Next(0,256),
                        blue: rand.Next(0,256),
                        green: rand.Next(0,256)
                    ));
                timer1.Interval = 500;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for( int i=0; i < tacke.Length; i++)
            {
                tacke[i].PostaviXY(
                      x: rand.Next(ClientRectangle.Width),
                    y: rand.Next(ClientRectangle.Height           
                    ));
            }
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for(int i=0;i<tacke.Length;i++)
            {
                tacke[i].Crtaj(e.Graphics);
            }
        }
    }
}