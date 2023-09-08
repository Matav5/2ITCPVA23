using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITAProc
{
    internal class Baracek
    {
        int sirka;
        int vyska;
        Color barvaDomu;
        Point pozice;

        public Baracek(int sirka, int vyska, Color barvaDomu, Point pozice)
        {
            this.sirka = sirka;
            this.vyska = vyska;
            this.barvaDomu = barvaDomu;
            this.pozice = pozice;
        }
        public void Vykresli(Graphics g)
        {
            g.FillRectangle(Brushes.HotPink, pozice.X, pozice.Y, sirka, vyska);
            Point[] vrcholy = new Point[]
            {
                new Point(pozice.X,pozice.Y),
                new Point(pozice.X + sirka, pozice.Y),
                new Point(pozice.X + sirka / 2, pozice.Y - vyska)
            };
            g.FillPolygon(Brushes.Red, vrcholy);
        }
    }
}
