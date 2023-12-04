using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITCMestecko
{
    internal class MiziciBudova : Budova
    {
        public MiziciBudova(string nazev) : base(nazev)
        {
        }

        protected override void ReagujNaKlik(MouseButtons tlacitko)
        {
            Parent.Controls.Remove(this);
        }
    }
}
