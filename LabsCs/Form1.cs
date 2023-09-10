namespace LabsCs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Test";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
           // this.Close();
        }
    }
}