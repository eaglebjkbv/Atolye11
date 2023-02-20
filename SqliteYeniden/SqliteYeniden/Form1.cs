using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqliteYeniden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SQLiteConnection con;
        //SQLiteDataAdapter da;
        //SQLiteCommand cmd;
        //DataSet ds;
        private void listele()
        {
            SQLiteConnection baglanti = 
                new SQLiteConnection
                ("Data Source=D:\\bv\\Amp11A\\SQL\\okul2.db;version=3");
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
            int num =Convert.ToInt32(textBox1.Text);
            string ad = textBox2.Text;
            string soyad = textBox3.Text;
            int yas = Convert.ToInt32(textBox4.Text);
            SQLiteConnection baglanti =
                new SQLiteConnection
                ("Data Source=D:\\bv\\Amp11A\\SQL\\okul2.db;version=3");
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = "INSERT INTO ogrenci values('"+num+"','"+ad+"','"+soyad+"','"+yas+"')";
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
         }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            SQLiteConnection baglanti =
                new SQLiteConnection
                ("Data Source=D:\\bv\\Amp11A\\SQL\\okul2.db;version=3");
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = "DELETE FROM ogrenci WHERE numara='" + num + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();

        }
    }
}
