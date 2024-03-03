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
    public partial class Form27 : Form
    {
        
        public Form27()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > Globals.maxnf)
            {
                Globals.maxnf = numericUpDown1.Value;
                Globals.nrf = 0;
                Globals.f[0] = 2;
            }
            else if (numericUpDown1.Value == Globals.maxnf)
            {
                Globals.nrf = Globals.nrf + 1;
                Globals.f[Globals.nrf] = 2;
            }
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Form27_Load(object sender, EventArgs e)
        {

        }
    }
}
