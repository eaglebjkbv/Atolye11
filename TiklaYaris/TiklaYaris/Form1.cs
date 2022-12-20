using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiklaYaris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int highScore = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("d:\\bv\\HighScores.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            String ilkSatir = sr.ReadLine();
            highScore = Convert.ToInt32(ilkSatir);
            sr.Close();
            fs.Close();
            label2.Text = ilkSatir;
            button2.Visible = false;
        }
        int score = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                a = 0;
            }
            score++;
            label6.Text = score.ToString();

                
        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            label4.Text = (10 - a).ToString();
            if (a == 10)
            {
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Visible = true;
                if (score > highScore)
                {
                    FileStream fs = new FileStream("d:\\bv\\HighScores.txt", FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(score.ToString());
                    sw.Close();
                    fs.Close();
                    highScore = score;
                    label2.Text = highScore.ToString();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = 0;
            button1.Enabled = true;
            button2.Visible = false;
            label4.Text = "10";
            score = 0;
            label6.Text = "0";
        }
    }
}
