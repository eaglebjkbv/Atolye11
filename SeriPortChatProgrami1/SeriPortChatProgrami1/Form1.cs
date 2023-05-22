using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriPortChatProgrami1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource= SerialPort.GetPortNames();
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate=Convert.ToInt32(comboBox2.Text);
            serialPort1.DataBits = Convert.ToInt32(comboBox3.Text);
            if (comboBox4.Text == "1")
            {
                serialPort1.StopBits = StopBits.One;
            }
            else
            {
                serialPort1.StopBits = StopBits.Two;
            }
            if (comboBox5.Text == "E")
            {
                serialPort1.Parity = Parity.Even;
            }
            else if(comboBox5.Text == "N")
            {
                serialPort1.Parity = Parity.None;
            }
            else if (comboBox5.Text == "O")
            {
                serialPort1.Parity = Parity.Odd;
            }
            serialPort1.Open();
            button2.Enabled = false;
            button3.Enabled = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                button2.Enabled = true;
                button3.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write(textBox1.Text);
            textBox2.Text += textBox1.Text;
            textBox1.Text = "";
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                textBox2.Text +="\n"+ serialPort1.ReadExisting();
            }
            
        }
    }
}
