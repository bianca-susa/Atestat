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
    public partial class Form37 : Form
    {
        public Form37()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (numericUpDown1.Value > Globals.maxns)
            {
                Globals.maxns = numericUpDown1.Value;
                Globals.nrs = 0;
                Globals.s[0] = 2;
            }
            else if (numericUpDown1.Value == Globals.maxnf)
            {
                Globals.nrs = Globals.nrs + 1;
                Globals.s[Globals.nrf] = 2;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Form37_Load(object sender, EventArgs e)
        {

        }
    }
}
