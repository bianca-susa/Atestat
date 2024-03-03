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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime dt1 = DateTime.Today;
            DateTime dt2 = new DateTime(2022, 02, 11);
            TimeSpan ts = dt2.Subtract(dt1);
            if (ts.TotalDays > 0)
            {
                Form10 Form10 = new Form10();
                Form10.Show();
            }
            else MessageBox.Show("Premiera a avut loc!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
