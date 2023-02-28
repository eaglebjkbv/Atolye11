using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLiteCrud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void listele()
        {
            SQLiteConnection baglanti = 
                new SQLiteConnection("Data Source=D:\\bv\\Atp11A\\sql\\okul2.db;version=3");
            baglanti.Open();
            SQLiteDataAdapter adaptor = 
                new SQLiteDataAdapter("SELECT * FROM ogrenci",baglanti);
            DataSet dataSet = new DataSet();
            adaptor.Fill(dataSet, "ogrenci");
            dataGridView1.DataSource = dataSet.Tables["ogrenci"];
            baglanti.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            string ad = textBox2.Text;
            string soyad = textBox3.Text;
            string dtarih = textBox5.Text;
            string cinsiyet;
            if (radioButton1.Checked == true)
            {
                cinsiyet = "E";
            }else
            {
                cinsiyet = "K";
            }
            try
            {        
                SQLiteConnection baglanti =
                    new SQLiteConnection("Data Source=D:\\bv\\Atp11A\\sql\\okul2.db;version=3");
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO " +
                    "ogrenci VALUES('"+num+"','"+ad+"','"+soyad+"','"+cinsiyet+"','"+dtarih+"')";
                komut.ExecuteNonQuery();
                listele();
                baglanti.Close();  
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata :" + ex.Message);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string num = textBox4.Text;
                SQLiteConnection baglanti =
                    new SQLiteConnection("Data Source=D:\\bv\\Atp11A\\sql\\okul2.db;version=3");
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = "DELETE FROM ogrenci WHERE num='"+num+"'";
                komut.ExecuteNonQuery();
                listele();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string num = textBox10.Text;
                SQLiteConnection baglanti =
                    new SQLiteConnection("Data Source=D:\\bv\\Atp11A\\sql\\okul2.db;version=3");
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM ogrenci WHERE num='" + num + "'";
                SQLiteDataReader okuyucu = komut.ExecuteReader();
                okuyucu.Read();
                textBox1.Text=okuyucu["num"].ToString().Trim();
                textBox2.Text = okuyucu["ad"].ToString().Trim();
                textBox3.Text = okuyucu["soyad"].ToString().Trim();
                textBox5.Text = okuyucu["dtarih"].ToString().Trim();
                if (okuyucu["cinsiyet"].ToString() == "E")
                {
                    
                    radioButton1.Checked = true;
                    
                }
                else
                {
                    radioButton2.Checked = true;
                }
                okuyucu.Close();
                baglanti.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string num = textBox10.Text;
            string ad = textBox2.Text;
            string soyad = textBox3.Text;
            string dtarih = textBox5.Text;
            string cinsiyet;
            if (radioButton1.Checked == true)
            {
                cinsiyet = "E";
            }
            else
            {
                cinsiyet = "K";
            }
            try
            {
                SQLiteConnection baglanti = new SQLiteConnection("Data Source=D:\\bv\\Atp11A\\sql\\okul2.db;version=3");
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
         
                komut.CommandText = "UPDATE ogrenci SET ad = '" + ad + "',soyad = '" + soyad + "'" +
                    ",cinsiyet='"+cinsiyet+ "', dtarih='" + dtarih + "' WHERE num = '" + num + "'";
                komut.Prepare();
                komut.Parameters.AddWithValue("@C", ad);
                komut.Parameters.AddWithValue("@A", soyad);
                komut.Parameters.AddWithValue("@L", cinsiyet);
                komut.Parameters.AddWithValue("@I", num);
                    
                komut.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
    }
}
