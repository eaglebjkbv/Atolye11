using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animasyon2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            pictureBox1.SetBounds(i, 10, 82, 137);
            if (i > 170) {
                i = 170;
                timer2.Enabled = false;
            }       
        }
        int a = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            a++;
            if (a == 1)
            {
                pictureBox1.Image = Properties.Resources.k1;
            }
            if (a == 2)
            {
                pictureBox1.Image = Properties.Resources.k2;
            }
            if (a == 3)
            {
                pictureBox1.Image = Properties.Resources.k3;
            }
            if (a == 4)
            {
                pictureBox1.Image = Properties.Resources.k4;
            }
            if (a > 4) a = 0;
        }
    }
}
