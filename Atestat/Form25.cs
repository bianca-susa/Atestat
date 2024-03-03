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
    public static class Globals
    {
        public static decimal maxnf = 0, maxns=0;
        public static int nrf, nrs;
        public static int[] s, f;
    }
    public partial class Form25 : Form
    {

        public Form25()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if(numericUpDown1.Value>Globals.maxnf)
            {
                Globals.maxnf = numericUpDown1.Value;
                Globals.nrf = 0;
                Globals.f[0] = 1;
            }
            else if(numericUpDown1.Value == Globals.maxnf)
            {
                Globals.nrf = Globals.nrf + 1;
                Globals.f[Globals.nrf] = 1;
            }
            this.Close();
        }

        private void Form25_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
