using System;
using System.Windows.Forms;

namespace VISHA_HAMEED
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Create and show Form6
            Form6 f6 = new Form6();
            f6.Show();
            Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Create and show Form5
            Form5 f5 = new Form5();
            f5.Show();
            Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Close the form when Button3 is clicked
            Close();
        }
    }
}
