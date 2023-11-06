namespace _2ITCPismenkovaHra
{
    public partial class Form1 : Form
    {
        public Pismenko pismenko;
        public int skore = 0;
        public Form1()
        {
            InitializeComponent();
            VytvorPismenko();
        }
        public void VytvorPismenko()
        {
            char pismenko = (char)Random.Shared.Next(65, 91);
            int x = Random.Shared.Next(pictureBox1.Width - 10);
            int y = Random.Shared.Next(pictureBox1.Height - 10);

            this.pismenko = new Pismenko(pismenko, x, y);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(pismenko.pismenko.ToString(),
            Font,
            Brushes.Black,
            pismenko.x,
            pismenko.y
            );
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if((char)e.KeyValue == pismenko.pismenko)
            {
                skore++;
                label1.Text = $"Skóre: {skore}";

                timer1.Stop();
                MessageBox.Show("Trefil jsi to");
                timer1.Start();
                
                VytvorPismenko();
            }
            Refresh();    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Jseš nula Skill Issue");
            Application.Exit();
        }
    }
}