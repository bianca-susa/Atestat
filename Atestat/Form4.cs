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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Today;
            DateTime dt2 = new DateTime(2022, 07, 15);
            TimeSpan ts = dt2.Subtract(dt1);
                label1.Text = "Mai sunt ";
                label2.Text = Convert.ToString(ts.TotalDays);
                label3.Text = "zile pana la premiera!"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
