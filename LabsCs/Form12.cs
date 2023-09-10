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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // Код, который нужно выполнить при загрузке формы
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            TextBox3.Text = (double.Parse(TextBox1.Text) + double.Parse(TextBox2.Text)).ToString();

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            TextBox6.Text = (double.Parse(TextBox4.Text) - double.Parse(TextBox5.Text)).ToString();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            TextBox9.Text = (double.Parse(TextBox7.Text) * double.Parse(TextBox8.Text)).ToString();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            TextBox12.Text = (double.Parse(TextBox10.Text) / double.Parse(TextBox11.Text)).ToString();
        }
    }
}
