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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void nextFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Form7();
            form.Show();
            this.Close();
        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            this.Close();
        }
    }
}
