using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2ITCSpiraly
{
    public partial class Form1 : Form
    {
        List<Spirala> seznamSpiral = new List<Spirala>()
        {
            new Spirala(5, new Point(100,100),Color.Red)
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Spirala spirala in seznamSpiral)
            {
                spirala.OtocSe();
            }
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach(Spirala spirala in seznamSpiral)
            {
                spirala.Vykresli(e.Graphics);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            seznamSpiral.Add(new Spirala(
                    (int)numericUpDown1.Value,
                    e.Location,
                    Color.Red
                ));
            Refresh();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }
    }
}
