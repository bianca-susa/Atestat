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
    public partial class Form31 : Form
    {
        public Form31()
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
                Globals.f[0] = 4;
            }
            else if (numericUpDown1.Value == Globals.maxnf)
            {
                Globals.nrf = Globals.nrf + 1;
                Globals.f[Globals.nrf] = 4;
            }
        }

        private void Form31_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
