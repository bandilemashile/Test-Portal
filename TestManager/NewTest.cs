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
    public partial class NewTest : Form
    {
        public NewTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Admin manager = new Admin();
            this.Hide();
            manager.Show();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtTestName.Text = String.Empty;
            txtQuestion1.Text = String.Empty;
            txtQuestion2.Text = String.Empty;
            txtQuestion3.Text = String.Empty;
            txtQuestion4.Text = String.Empty;
            txtQuestion5.Text = String.Empty;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

            Questions test = new Questions();

            test.Question1 = txtQuestion1.Text;
            test.Question2 = txtQuestion2.Text;
            test.Question3 = txtQuestion3.Text;
            test.Question4 = txtQuestion4.Text;
            test.Question5 = txtQuestion5.Text;
            test.TestName = txtTestName.Text;

            MessageBox.Show($"Test questions for {test.TestName} have been saved successfully." +
                $"         \n       \tClick OK to continue", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Dictionary<int, string> tests = new Dictionary<int, string>

            {
            };

            BindingSource bindingsource = new BindingSource(tests.Values, null);
            





        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
