namespace _2ITAProc
{
    public partial class Form1 : Form
    {

        List<Baracek> seznamBaracku = new List<Baracek>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Baracek novyBaracek = new Baracek(100, 25, Color.Honeydew, e.Location);
            seznamBaracku.Add(novyBaracek);
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Baracek baracek in seznamBaracku) {
                baracek.Vykresli(e.Graphics);
            }
        }

    }
}