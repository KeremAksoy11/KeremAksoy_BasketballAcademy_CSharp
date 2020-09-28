using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Basketbol_Akademisi
{
    public partial class Form3 : Form
    {
        public Form3()
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
        private void Form3_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM basketbol", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }
        void Listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM basketbol", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM basketbol", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult tus = MessageBox.Show("Kaydı Silmek İstiyor Musunuz?", "Kayıt Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tus == DialogResult.Yes)
            {
                baglanti.Open();
                string secilen_kimlik = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                OleDbCommand komut = new OleDbCommand("DELETE FROM basketbol WHERE kimlik = @kimlik", baglanti);
                komut.Parameters.AddWithValue("@kimlik", secilen_kimlik);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Listele();
            }
            else
            {
                Listele();
            }
            Listele();
        }

        private void ErkekOlanlarıFiltreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM basketbol WHERE b_cinsiyet='ERKEK' ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void KızOlanlarıFiltreleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM basketbol WHERE b_cinsiyet='KIZ' ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void ErlekVe180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM basketbol WHERE b_pakettürü='12 Aylık Profesiyonel Paket ' ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Yaşı18ÜstüOlanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM basketbol WHERE b_yaş >='18' ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Boyu180CmdenBüyükOlanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM basketbol WHERE b_boy >='180' ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void İlk10KayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM basketbol WHERE kimlik <=10 ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void EnYeniKayıtlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM basketbol ORDER BY kimlik DESC", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void EnSonKayıtlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM basketbol ORDER BY kimlik ASC", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void YaşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT b_yaş FROM basketbol GROUP BY b_yaş ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void ToolStripSplitButton4_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT b_yaş FROM basketbol GROUP BY b_yaş ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void ToolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM basketbol WHERE b_ad LIKE '"+toolStripTextBox1.Text +"%'", baglanti);
            DataTable dt = new DataTable();         
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            this.Hide();
            frm6.Show();
        }

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
