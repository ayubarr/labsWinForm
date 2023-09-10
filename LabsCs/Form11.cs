using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabsCs
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) + 1).ToString();

            if (label1.Text == "10")
            {
                button2.BackColor = Color.Yellow;
            }

            if (label1.Text == "20")
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.White;
            }

            if (label1.Text == "30")
            {
                button3.BackColor = Color.Green;
                button1.BackColor = Color.White;
            }

            if (label1.Text == "15")
            {
                label1.Text = "Переходите Дорогу";
                timer1.Enabled = false;
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new Form12();
            form.Show();
            this.Close();
        }
    }
}
