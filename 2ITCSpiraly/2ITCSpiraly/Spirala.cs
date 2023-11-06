using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITCSpiraly
{
    internal class Spirala
    {
        int startovniDelka;
        Point pozice;
        Color barva;
        int smer;

        public Spirala(int startovniDelka, Point pozice, Color barva)
        {
            this.startovniDelka = startovniDelka;
            this.pozice = pozice;
            this.barva = barva;
        }

        public void Vykresli(Graphics g)
        {
            Point zacatek = pozice;
            Point konec;
            int delka = startovniDelka;
            int vykreslovaciSmer = smer;
            for (int i = 0; i < 16; i++)
            {

                switch (vykreslovaciSmer)
                {
                    case 0:
                        konec = new Point(zacatek.X, zacatek.Y - delka);
                        break;
                    case 1:
                        konec = new Point(zacatek.X + delka, zacatek.Y);
                        break;
                    case 2:
                        konec = new Point(zacatek.X, zacatek.Y + delka);
                        break;
                    default:
                        konec = new Point(zacatek.X - delka, zacatek.Y);
                        break;
                }

                g.DrawLine(new Pen(barva), zacatek, konec);
                delka += startovniDelka;

                vykreslovaciSmer--;
               if (vykreslovaciSmer < 0)
                    vykreslovaciSmer = 3;
              
                zacatek = konec;
            }
        }

        internal void OtocSe()
        {
            smer++;
            smer %= 4;
        }
    }
}
