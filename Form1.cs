namespace Practica_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, count = 0, limite;
            n = int.Parse(textBox1.Text);
            limite = int.Parse(textBox2.Text);
            do
            {
                listBox1.Items.Add(n + " * " + count + "=" + n * count);
                count++;
            }
            while (count <= limite);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = " ";
            textBox2.Text = " ";

        }
    }
}