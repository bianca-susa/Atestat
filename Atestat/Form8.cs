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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Today;
            DateTime dt2 = new DateTime(2023, 01, 05);
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
