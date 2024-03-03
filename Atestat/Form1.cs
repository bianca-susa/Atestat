using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form23 Form23 = new Form23();
            Form23.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            label1.BringToFront();
            label2.BringToFront();
            label3.BringToFront();
        }
    }
}
