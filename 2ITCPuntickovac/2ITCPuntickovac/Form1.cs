namespace _2ITCPuntickovac
{
    public partial class Form1 : Form
    {
        List<Zmetek> seznamZmetku = new List<Zmetek>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label labelZmetka = new Label();
            Zmetek zmetek = new Zmetek(
                textBox1.Text,
                (int)numericUpDown1.Value,
                labelZmetka
                );
            labelZmetka.AutoSize = true;
            labelZmetka.Text = zmetek.ToString();
            flowLayoutPanel1.Controls.Add(labelZmetka);
            seznamZmetku.Add(zmetek);

            label3.Text +=  zmetek.Puntiky + ", ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < seznamZmetku.Count; i++)
            {
                seznamZmetku[i].PridejPuntik();
            }
        }
    }
}