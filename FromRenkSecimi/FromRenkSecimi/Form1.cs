using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromRenkSecimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKırmızı_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 0, 0);
        }
        int red=0;
        int green=0;
        int blue=0;

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            red = trackBarRed.Value;
            this.BackColor = Color.FromArgb(red, green, blue);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }
        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            green = trackBarGreen.Value;
            this.BackColor = Color.FromArgb(red, green, blue);
        }
        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            blue = trackBarBlue.Value;
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void buttonRastgele_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            red = rnd.Next(0, 255);
            green = rnd.Next(0, 255);
            blue = rnd.Next(0, 255);
            this.BackColor = Color.FromArgb(red, green, blue);
            trackBarRed.Value = red;
            trackBarGreen.Value = green;
            trackBarBlue.Value = blue;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            red = rnd.Next(0, 255);
            green = rnd.Next(0, 255);
            blue = rnd.Next(0, 255);
            this.BackColor = Color.FromArgb(red, green, blue);
            trackBarRed.Value = red;
            trackBarGreen.Value = green;
            trackBarBlue.Value = blue;        }
    }
}
