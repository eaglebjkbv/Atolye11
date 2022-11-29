using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemComponent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text;
            label2.Text = comboBox1.SelectedItem.ToString();
            textBox1.Text = comboBox1.SelectedIndex.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] meyveler= { "Muz", "Elma", "Armut" };
            label2.Text = comboBox1.Text;
            comboBox1.DataSource = meyveler;
            //for (int i = 0; i < 3; i++)
            //{
            //    comboBox1.Items.Add(meyveler[i]);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBoxEkle.Text);
        }
    }
}
