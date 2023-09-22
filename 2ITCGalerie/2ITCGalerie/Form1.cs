namespace _2ITCGalerie
{
    public partial class Form1 : Form
    {
        public List<string> seznamCestKObrazkum = new List<string>()
        {
            "nadhera.png",
            "excuseMe.png",
            "MatavgamingForest.jpg"
        };
        public int indexObrazku = 2;
        public Form1()
        {
            InitializeComponent();
            NastavObrazek();
        }
        public void NastavObrazek()
        {
            string cestaKObrazku = seznamCestKObrazkum[indexObrazku];
            pictureBox1.Image = Image.FromFile(cestaKObrazku);
           // pictureBox1.Image = Image.FromFile("C:\\Users\\Matav\\source\\repos\\2ITCGalerie\\2ITCGalerie\\bin\\Debug\\net6.0-windows\\nadhera.png");
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            PosunNaDalsiObrazek();
        }
        public void PosunNaDalsiObrazek()
        {
            indexObrazku++;
            if (indexObrazku >= seznamCestKObrazkum.Count)
            {
                indexObrazku = 0;
            }

            NastavObrazek();
        }
        public void PosunNaPredchoziObrazek()
        {
            indexObrazku--;
            if (indexObrazku < 0)
            {
                indexObrazku = seznamCestKObrazkum.Count - 1;
            }
            NastavObrazek();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PosunNaPredchoziObrazek();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PosunNaDalsiObrazek();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
             /* Keys.Left
                Keys.Right*/

            if(e.KeyData == Keys.A)
            {
                PosunNaPredchoziObrazek();
            }

            if(e.KeyData == Keys.D)
            {
                PosunNaDalsiObrazek();
            }
        }
    }
}