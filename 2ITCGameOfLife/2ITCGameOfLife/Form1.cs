using System.Threading;

namespace _2ITCGameOfLife
{
    public partial class Form1 : Form
    {
        private Bunka[,] pole;
        public Form1()
        {
            InitializeComponent();
        }

        private void VygenerujPole()
        {
            Random r = new Random();
            //Vytvoøí pole
            pole = new Bunka[50, 50];
            //Zaplní ho buòkama => zajistí aby byly nìjaké naživu
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    bool jeNazivu = r.Next(0, 100) < numericUpDown1.Value;
                    pole[i, j] = new Bunka(j, i,
                         jeNazivu
                        );
                }
            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (pole == null)
                return;
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j].Vykresli(e.Graphics);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VygenerujPole();
            Refresh();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DalsiGenerace();
        }

        private void DalsiGenerace()
        {
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    int pocetZivych = PocetZivychSousedu(pole[i, j]);


                    bool budeNazivu = BudeBunkaNazivu(pole[i, j], pocetZivych);

                }
            }
        }

        private bool BudeBunkaNazivu(Bunka bunka, int pocetZivych)
        {

            if (bunka.JeNazivu)
            {
                //Any live cell with fewer than two live neighbours dies, as if by underpopulation.

                if (pocetZivych < 2)
                    return false;
                //Any live cell with more than three live neighbours dies, as if by overpopulation.
                if (pocetZivych > 3)
                    return false;
                //Any live cell with two or three live neighbours lives on to the next generation.
                return true;
            }
            else
            {
                //Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
                if (pocetZivych == 3)
                    return true;
                return false;
            }

        }

        private int PocetZivychSousedu(Bunka bunka)
        {
            int pocetZivych = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {

                    int x = bunka.X + j;
                    int y = bunka.Y + i;
                    //Pøeskoè když je mimo pole
                    if (x < 0 || y < 0 || x >= pole.GetLength(1) || y >= pole.GetLength(0))
                        continue;
                    //Pøeskoè prostøedek
                    if (i == 0 && j == 0)
                        continue;

                    //Pøièti pokud naživu
                    if (pole[y, x].JeNazivu)
                        pocetZivych++;
                }
            }
            return pocetZivych;
        }
    }
}