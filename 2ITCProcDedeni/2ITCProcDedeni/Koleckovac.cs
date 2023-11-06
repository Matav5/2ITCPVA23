using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITCProcDedeni
{
    internal class Koleckovac : Vykreslovatelny
    {
        public Koleckovac(Point pozice, Size velikost, Color barvicka) : base(pozice, velikost, barvicka)
        {

        }
        public override void Vykresli(Graphics g)
        {
            base.Vykresli(g);
            Pen pero = new Pen(barvicka);
            int sirkaKolecka = velikost.Width / 2;
            int vyskaKolecka = velikost.Height / 2;
            g.DrawEllipse(pero, pozice.X, pozice.Y, sirkaKolecka, vyskaKolecka);
            g.DrawEllipse(pero, pozice.X + sirkaKolecka, pozice.Y, sirkaKolecka, vyskaKolecka);
            g.DrawEllipse(pero, pozice.X, pozice.Y + vyskaKolecka, sirkaKolecka, vyskaKolecka);
            g.DrawEllipse(pero, pozice.X + sirkaKolecka, pozice.Y + vyskaKolecka, sirkaKolecka, vyskaKolecka);
        }
    }
}
