namespace _2ITCMestecko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(panel1.Controls.Count - 1);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            RodinnyDum rodinnyDum = new RodinnyDum("Hurdùv dùm");
            rodinnyDum.Location = e.Location;
            panel1.Controls.Add(rodinnyDum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count > 0)
            {
                Budova budova = (Budova) panel1.Controls[panel1.Controls.Count - 1];
                budova.NasimulujKlik();
            }
        }
    }
}