namespace _2ITCMestecko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TypBudovy[] moznosti = Enum.GetValues<TypBudovy>();
            foreach (TypBudovy moznost in moznosti)
            {
                comboBox1.Items.Add(moznost);
            }
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            if(panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(panel1.Controls.Count - 1);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            VytvorBudovu(e.Location);
        }

        private void VytvorBudovu(Point pozice)
        {
            TypBudovy typBudovy = (TypBudovy) comboBox1.SelectedItem;
            Budova budova = null;
            switch (typBudovy)
            {
                case TypBudovy.RodinnyDum:
                    budova = new RodinnyDum("U Hajlomanù");
                    break;
                case TypBudovy.MiziciBudova:
                    budova = new MiziciBudova("U Stroskotalù");
                    break;
                case TypBudovy.BudovaSNohama:
                    //TODO BudovaSNohama
                    break;
            }
            budova.Location = pozice;
            panel1.Controls.Add(budova);
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