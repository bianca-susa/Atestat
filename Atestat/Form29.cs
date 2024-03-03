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
    public partial class Form29 : Form
    {
        public Form29()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (numericUpDown1.Value > Globals.maxnf)
            {
                Globals.maxnf = numericUpDown1.Value;
                Globals.nrf = 0;
                Globals.f[0] = 3;
            }
            else if (numericUpDown1.Value == Globals.maxnf)
            {
                Globals.nrf = Globals.nrf + 1;
                Globals.f[Globals.nrf] = 3;
            }
        }

        private void Form29_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
