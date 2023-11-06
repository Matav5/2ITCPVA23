using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITCPuntickovac
{
    internal class Zmetek
    {
        string jmeno;
        int puntiky;
        public int Puntiky => puntiky;
        Label label;

        public Zmetek(string Jmeno, int Puntiky, Label Label)
        {
            this.jmeno = Jmeno;
            this.puntiky = Puntiky;
            this.label = Label;
        }
        public override string ToString()
        {
            return $"{jmeno} má {Puntiky.ToString()}x ⚫";
        }

        internal void PridejPuntik()
        {
            puntiky++;
            label.Text = ToString();
        }
    }
}
