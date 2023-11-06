using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITCBarvicky
{
    internal class MujPictureBox : PictureBox
    {
        public MujPictureBox()
        {
           
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Parent.Controls.Remove(this);
        }

    }
}
