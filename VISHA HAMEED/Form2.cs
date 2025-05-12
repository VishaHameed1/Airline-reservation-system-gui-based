using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISHA_HAMEED
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object? sender, EventArgs e)
        {
            // Create and show Form4
            Form4 f4 = new Form4();
            f4.Show();
        }
        private void Button2_Click(object? sender, EventArgs e)
        {
            // Create and show Form4
            Form3 f3 = new Form3();
            f3.Show();
        }
        private void Button3_Click(object? sender, EventArgs e)
        {
            // Create and show Form4
            Form9 f9 = new Form9();
            f9.Show();
        }
    }
}
