using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basketbol_Akademisi
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=basketbol.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        OleDbDataAdapter da;
        DataTable dt;
      
        string sql = "SELECT * FROM basketbol";

        private void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT *  FROM basketbol", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            { 
                listBox1.Items.Add(oku["b_ad"].ToString() + " "+  oku["b_soyad"].ToString()+ " "  + oku["b_forma"].ToString()); 
            }
            komut.Dispose();
            baglanti.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LİSTELE();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            label1.Text = Convert.ToString(listBox1.SelectedItem); label1.Visible = true;
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime zaman = DateTime.Now;
            label3.Text = DateTime.Now.ToLongTimeString();
            label4.Text = zaman.ToLongDateString();
        }
        void LİSTELE()
        {

            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM yoklama", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("INSERT INTO yoklama(b_gelmeyen,b_tarih,b_saat) VALUES(@b_gelmeyen,@b_tarih,b_saat)", baglanti);
            komut.Parameters.AddWithValue("@b_gelmeyen", label1.Text);
            komut.Parameters.AddWithValue("@b_tarih", label4.Text);
            komut.Parameters.AddWithValue("@b_saat", label3.Text);
            komut.ExecuteNonQuery();
            LİSTELE();  
            baglanti.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult tus = MessageBox.Show("Kaydı Silmek İstiyor Musunuz?", "Kayıt Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tus == DialogResult.Yes)
            {
                baglanti.Open();
                string secilen_kimlik = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                OleDbCommand komut = new OleDbCommand("DELETE FROM yoklama WHERE kimlik = @kimlik", baglanti);
                komut.Parameters.AddWithValue("@kimlik", secilen_kimlik);
                komut.ExecuteNonQuery();
                baglanti.Close();
                LİSTELE();
            }
            else
            {
                LİSTELE();
            }
            LİSTELE();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM yoklama WHERE b_gelmeyen LIKE '" + textBox1.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM yoklama ORDER BY kimlik ASC", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM yoklama ORDER BY kimlik DESC", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT b_tarih FROM yoklama GROUP BY b_tarih ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Button7_Click(object sender, EventArgs e)
        {

            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }
    }
    }

