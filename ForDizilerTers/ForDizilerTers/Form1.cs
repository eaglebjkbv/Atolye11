using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDizilerTers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] meyveler = { "Elma", "Armut", "Muz", "Portakal", "Mandalina" };
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < meyveler.Length; i++)
            {
                listBox1.Items.Add(meyveler[i]);
            }
        }
        int a = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (a == 1)
            {
                for (int i = meyveler.Length - 1; i >= 0; i--)
                {
                    listBox1.Items.Add(meyveler[i]);
                }
                a = 0;
            }
            else
            {
                for (int i = 0; i < meyveler.Length; i++)
                {
                    listBox1.Items.Add(meyveler[i]);
                }
                a = 1;
            }  
        }
    }
}
