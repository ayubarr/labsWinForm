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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 100;
            label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value - 100;
            label1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Form11();
            form.Show();
            this.Close();
        }
    }
}
