namespace _2ITCProcDedeni
{
    public partial class Form1 : Form
    {
        List<Vykreslovatelny> vykreslovatelnePrvky = new List<Vykreslovatelny>();

        TypyObrazku typObrazku = TypyObrazku.Koleckovac;
        
        public Form1()
        {
            InitializeComponent();
            Vykreslovatelny vykreslovatelny = new Vykreslovatelny(
                new Point(50, 50),
                new Size(100,50),
                Color.Thistle
                );
            vykreslovatelnePrvky.Add(vykreslovatelny);

            Vykreslovatelny koleckovac = new Koleckovac(
                new Point(100, 50),
                new Size(200, 200),
                Color.Black
            );
            vykreslovatelnePrvky.Add(koleckovac);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Vykreslovatelny prvek in vykreslovatelnePrvky)
            {
                prvek.Vykresli(e.Graphics);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            Vykreslovatelny vykreslovatelny; 
            switch (typObrazku)
            {
                case TypyObrazku.Koleckovac:
                    vykreslovatelny = new Koleckovac(
                        e.Location,
                        new Size(100, 100),
                        Color.Chocolate
                        );
                    break;
                default:
                    vykreslovatelny = new Vykreslovatelny(
                        e.Location,
                        new Size(100, 100),
                        Color.Chocolate
                        );
                    break;

            }



            vykreslovatelnePrvky.Add(vykreslovatelny);
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            typObrazku = TypyObrazku.Koleckovac;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            typObrazku = TypyObrazku.Vykreslovatelny;
        }

        enum TypyObrazku
        {
            Koleckovac,
            Vykreslovatelny,
            Domeckovac
        }
    }
}