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
    public partial class Form44 : Form
    {
        public Form44()
        {
            InitializeComponent();
        }

        private void Form44_Load(object sender, EventArgs e)
        {
            int ns = Globals.nrs;
            int nf = Globals.nrf;
            for(int i=0;i<=ns;i++)
            {
                if(Globals.s[i] == 1)
                richTextBox1.Text = richTextBox1.Text + "Outlander";
                if (Globals.s[i] == 2)
                    richTextBox1.Text = richTextBox1.Text + "Oameni normali";
                if (Globals.s[i] == 3)
                    richTextBox1.Text = richTextBox1.Text + "Noua straini";
                if (Globals.s[i] == 4)
                    richTextBox1.Text = richTextBox1.Text + "Gambitul damei";
                if (Globals.s[i] == 5)
                    richTextBox1.Text = richTextBox1.Text + "Regatul umbrelor";
                richTextBox1.Text = richTextBox1.Text + Environment.NewLine;
            }
            for (int i = 0; i <= nf; i++)
            {
                if (Globals.f[i] == 1)
                    richTextBox2.Text = richTextBox2.Text + "Absolut tot";
                if (Globals.f[i] == 2)
                    richTextBox2.Text = richTextBox2.Text + "Sub aceeasi stea";
                if (Globals.f[i] == 3)
                    richTextBox2.Text = richTextBox2.Text + "Dune";
                if (Globals.f[i] == 4)
                    richTextBox2.Text = richTextBox2.Text + "Doctor Sleep";
                if (Globals.f[i] == 5)
                    richTextBox2.Text = richTextBox2.Text + "Emma";
                richTextBox2.Text = richTextBox2.Text + Environment.NewLine;
            }
        }
    }
}
