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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }



        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) + 1).ToString();
            if (label1.Text == "10")
            {
                timer1.Stop();
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form9();
            form.Show();
            this.Close();
        }
    }
}
