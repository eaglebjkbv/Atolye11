using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunBul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void gunHesapla()
        {
            int gun = Convert.ToInt32(textBox1.Text);
            switch (gun)
            {
                case 1:
                    label1.Text = "Pazartesi";
                    break;
                case 2:
                    label1.Text = "Salı";
                    break;
                case 3:
                    label1.Text = "Çarşamba";
                    break;
                case 4:
                    label1.Text = "Perşembe";
                    break;
                case 5:
                    label1.Text = "Cuma";
                    break;
                case 6:
                    label1.Text = "Cumartesi";
                    break;
                case 7:
                    label1.Text = "Pazar";
                    break;
                default:
                    MessageBox.Show("Lütfen 1-7 arası bir sayı giriniz...");
                    break;
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                gunHesapla();
            }
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gunHesapla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gunHesapla();
        }
    }
}
