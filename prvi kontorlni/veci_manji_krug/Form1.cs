namespace veci_manji_krug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        krug Krug;
        bool krugrastje;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 200;
            Krug = new(
                x: ClientRectangle.Width/2,
                y:ClientRectangle.Height/2,
                r: Math.Min(ClientRectangle.Height,ClientRectangle.Width)/4,
                boja: Color.Blue
                 );
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (krugrastje)
                {
                    Krug.Povecaj(uvecanje:5);

                }
                else
                {
                    Krug.Smanji(umanjenje:5);
                }
            }
            catch(Exception exc)
            {
                timer1.Stop();
                MessageBox.Show(exc.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Refresh();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                krugrastje = true;
                Krug.Postaviboju(Color.Green);
            }
           else if (e.Button == MouseButtons.Right)
            {
                krugrastje = false;
                Krug.Postaviboju(Color.Red);
            }
            else
            {
                return;
            }
            timer1.Start();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Krug.crtaj(e.Graphics);
        }
    }
}