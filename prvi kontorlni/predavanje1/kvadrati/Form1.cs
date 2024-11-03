namespace kvadrati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            kvadrat k = new kvadrat(Color.Blue, e.X, e.Y, 50);
            k.Crtaj(g);
        }
    }
}