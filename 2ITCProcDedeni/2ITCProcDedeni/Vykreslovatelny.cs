using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITCProcDedeni
{
    internal class Vykreslovatelny
    {
        protected Point pozice;
        protected Size velikost;
        protected Color barvicka;
        public Vykreslovatelny(Point pozice, Size velikost, Color barvicka)
        {
            this.pozice = pozice;
            this.velikost = velikost;
            this.barvicka = barvicka;
        }
        public virtual void Vykresli(Graphics g)
        {
            g.DrawRectangle(
                new Pen(barvicka),
                pozice.X,
                pozice.Y,
                velikost.Width,
                velikost.Height
                );
        }


    }
}
