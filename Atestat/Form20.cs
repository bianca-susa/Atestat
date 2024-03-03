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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Today;
            DateTime dt2 = new DateTime(2022, 08, 21);
            TimeSpan ts = dt2.Subtract(dt1);
            label1.Text = "Mai sunt ";
            label2.Text = Convert.ToString(ts.TotalDays);
            label3.Text = "zile pana la premiera!";
        }
    }
}
