using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hosgeldin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            int sayi =Convert.ToInt32(textBox1.Text);
            if (sayi % 2 == 0)
            {
                listBox2.Items.Add(sayi);
            }
            else
            {
                listBox1.Items.Add(sayi);
            }
        }
    }
}
