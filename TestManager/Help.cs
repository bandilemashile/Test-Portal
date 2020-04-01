using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestManager
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help helpPage = new Help();
            this.Hide();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Test start = new Test();
            this.Hide();
            start.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
