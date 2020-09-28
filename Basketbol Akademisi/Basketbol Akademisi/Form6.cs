using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basketbol_Akademisi
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=basketbol.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        OleDbDataAdapter da;
        DataTable dt;
        OleDbCommand sqlkomutu;
        string sql = "SELECT * FROM basketbol";
        void LİSTELE()
        {

            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM basketbol", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);





        }
        private void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("INSERT INTO basketbol(b_ad,b_soyad,b_yaş,b_cinsiyet,b_boy,b_forma,b_fiyat,b_pakettürü,b_tarih,b_saat) VALUES(@b_ad,@b_soyad,@b_yaş,@b_cinsiyet,@b_boy,@b_forma,@b_fiyat,b_pakettürü,@b_tarih,b_saat)", baglanti);
            komut.Parameters.AddWithValue("@b_ad", textBox1.Text);
            komut.Parameters.AddWithValue("@b_soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@b_yaş", textBox3.Text);
            komut.Parameters.AddWithValue("@b_cinsiyet", label10.Text);
            komut.Parameters.AddWithValue("@b_boy", textBox5.Text);
            komut.Parameters.AddWithValue("@b_forma", label11.Text);
            komut.Parameters.AddWithValue("@b_fiyat", label9.Text);
            komut.Parameters.AddWithValue("@b_pakettürü", label13.Text);
            komut.Parameters.AddWithValue("@b_tarih", label15.Text);
            komut.Parameters.AddWithValue("@b_saat", label14.Text);
            komut.ExecuteNonQuery();
            LİSTELE();
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
            baglanti.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.Text = comboBox1.SelectedItem.ToString();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Text = comboBox2.SelectedItem.ToString();
            string turusec = comboBox2.SelectedItem.ToString();

          
            switch (turusec)
            {
                case "60₺":
                    label13.Text = "3 Aylık Temel Paket";
                    label13.Visible = true;
                    break;
                case "180₺":
                    label13.Text = "6 Aylık Gelişim Paket";
                    label13.Visible = true;
                    break;
                case "240₺":
                    label13.Text = "12 Aylık Profesiyonel Paket";
                    label13.Visible = true;
                    break;
                    

            }
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label11.Text = comboBox3.SelectedItem.ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime zaman = DateTime.Now;
            label14.Text = DateTime.Now.ToLongTimeString();
            label15.Text = zaman.ToLongDateString();
        }
    }
}
