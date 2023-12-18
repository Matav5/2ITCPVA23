using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITCGameOfLife
{
    internal class Bunka
    {
        public const int VELIKOST_BUNKY = 10;
        private int x;
        public int X => x;

        private int y;
        public int Y => y;

        private bool jeNazivu;

        public bool JeNazivu => jeNazivu;
        private Brush Stetec => jeNazivu ? Brushes.Black : Brushes.White; 
        public Bunka(int x, int y, bool jeNazivu)
        {
            this.x = x;
            this.y = y;
            this.jeNazivu = jeNazivu;
        }

        internal void Vykresli(Graphics g)
        {
            g.FillRectangle(Stetec, 
                x * VELIKOST_BUNKY,
                y * VELIKOST_BUNKY,
                VELIKOST_BUNKY,
                VELIKOST_BUNKY);
        }
    }
}
