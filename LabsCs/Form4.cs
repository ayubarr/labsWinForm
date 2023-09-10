using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabsCs
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                button1.Visible = false;
                maskedTextBox1.Visible = false;
                label1.Text = "Правильный ответ";
            }
            else
            {
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                button1.Visible = false;
                maskedTextBox1.Visible = false;
                label1.Text = "НЕ Правильный ответ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Form5();
            form.Show();
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
