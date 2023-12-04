using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITCMestecko
{
    internal class RodinnyDum : Budova
    {
        bool sviti = true;
        public RodinnyDum(string nazev) : base(nazev)
        {
        }
        protected override void NactiObrazek()
        {
            if (sviti)
                Image = Image.FromFile("sviti.jpg");
            else
                Image = Image.FromFile("nesviti.jpg");
        }
        protected override void ReagujNaKlik(MouseButtons tlacitko)
        {
            sviti = !sviti;
            NactiObrazek();
        }
    }
}
