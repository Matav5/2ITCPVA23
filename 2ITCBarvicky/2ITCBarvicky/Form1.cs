namespace _2ITCBarvicky
{
    public partial class Form1 : Form
    {
        Color barvicka;
        int indexBarvicky = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            //Cervena = hodnota;

            VytvorBarvicku();
        }

        private void VytvorBarvicku()
        {
            barvicka = Color.FromArgb(
                trackBar1.Value,
                trackBar2.Value,
                trackBar3.Value
                );
            UkazBarvicku();
        }
        private void UkazBarvicku()
        {
            pictureBox1.BackColor = barvicka;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MujPictureBox pictureBoxBarvicka = new MujPictureBox();
            pictureBoxBarvicka.BackColor = barvicka;
          /*  pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
            pictureBox1.Location.Offset(10, 5);
          */
            flowLayoutPanel1.Controls.Add(pictureBoxBarvicka);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                button2.Text = "Spus Light Show";
            }
            else
            {
                timer1.Start();
                button2.Text = "Zastav Light Show";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ZmenBarvu();
        }

        private void ZmenBarvu()
        {
            if (flowLayoutPanel1.Controls.Count == 0)
                return;

            indexBarvicky++;

            if (indexBarvicky >= flowLayoutPanel1.Controls.Count)
                indexBarvicky = 0;
            //PictureBox pictureBox = (PictureBox)flowLayoutPanel1.Controls[indexBarvicky]
            pictureBox1.BackColor = flowLayoutPanel1.Controls[indexBarvicky].BackColor;
        }
    }
}