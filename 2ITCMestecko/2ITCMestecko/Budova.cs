using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITCMestecko
{
    abstract internal class Budova : PictureBox
    {
        public string Nazev { get; private set; }
        public Budova(string nazev)
        {
            Nazev = nazev;
            Width = 100;
            Height = 100;
            SizeMode = PictureBoxSizeMode.StretchImage;

            NactiObrazek();
        }

        protected virtual void NactiObrazek()
        {
            this.Image = System.Drawing.Image.FromFile("budovaNotFound.jpg");
        }


        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            ReagujNaKlik(e.Button);
        }
        protected abstract void ReagujNaKlik(MouseButtons tlacitko);

        public void NasimulujKlik()
        {
            ReagujNaKlik(MouseButtons.Left);
        }
    }

    enum TypBudovy
    {
        RodinnyDum,
        MiziciBudova,
        BudovaSNohama
    }
}
