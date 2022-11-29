using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrayListOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList isimler = new ArrayList();
        ArrayList adresler = new ArrayList();
        ArrayList telefonlar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            isimler.Add(textBox1.Text);
            adresler.Add(textBox2.Text);
            telefonlar.Add(textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            for(int i = 0; i < isimler.Count; i++)
            {
                listBox1.Items.Add(isimler[i]);
                listBox2.Items.Add(adresler[i]);
                listBox3.Items.Add(telefonlar[i]);

            }
        }
    }
}
