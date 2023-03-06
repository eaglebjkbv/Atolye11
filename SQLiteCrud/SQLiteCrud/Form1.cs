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

namespace SQLiteCRUD
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
                new SQLiteConnection("Data Source=D:\\bv\\Amp11A\\SQL\\okul2.db;version=3");
            baglanti.Open();
            SQLiteDataAdapter da = 
                new SQLiteDataAdapter("SELECT * FROM ogrenci",baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection baglanti =
                    new SQLiteConnection("Data Source=D:\\bv\\Amp11A\\SQL\\okul2.db;version=3");
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText =
                    "INSERT INTO ogrenci VALUES('" + textBox1.Text + "','" +
                    textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();  
            }
            catch(Exception ex)
            {
                MessageBox.Show("HATA " + ex.Message);
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        { 
            try
            {
                SQLiteConnection baglanti =
                    new SQLiteConnection("Data Source=D:\\bv\\Amp11A\\SQL\\okul2.db;version=3");
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = 
                    "DELETE FROM ogrenci WHERE numara='"+textBox5.Text+"'";
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA : " + ex.Message);
            }
            finally
            {
                textBox5.Clear();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SQLiteConnection baglanti =
                new SQLiteConnection("Data Source=D:\\bv\\Amp11A\\SQL\\okul2.db;version=3");
            baglanti.Open();
            SQLiteCommand komut = 
                new SQLiteCommand("SELECT * FROM ogrenci " +
                "WHERE numara='"+textBox1.Text+"'",baglanti);
            SQLiteDataReader reader = komut.ExecuteReader();
            if (reader.HasRows==true)
            {
                reader.Read();
                textBox2.Text = reader["ad"].ToString();
                textBox3.Text = reader["soyad"].ToString();
                textBox4.Text = reader["yas"].ToString();
            }
            else
            {
                MessageBox.Show("Veri Bulunamadı");
            }
            reader.Close();
            baglanti.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = textBox2.Text;
                string soyad = textBox3.Text;
                string yas = textBox4.Text;
                SQLiteConnection baglanti =
                    new SQLiteConnection("Data Source=D:\\bv\\Amp11A\\SQL\\okul2.db;version=3");
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;

                komut.CommandText =
                    "UPDATE ogrenci SET ad='"+ad+"', soyad='"+soyad+"',yas='"+yas+"' " +
                    "WHERE numara='"+textBox1.Text+"'";
               
                
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA " + ex.Message);
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
