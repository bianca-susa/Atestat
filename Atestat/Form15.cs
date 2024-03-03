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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Today;
            DateTime dt2 = new DateTime(2022, 05, 15);
            TimeSpan ts = dt2.Subtract(dt1);
            if (ts.TotalDays > 0)
            {
                Form16 Form16 = new Form16();
                Form16.Show();
            }
            else MessageBox.Show("Premiera a avut loc!");
        }
    }
    }

