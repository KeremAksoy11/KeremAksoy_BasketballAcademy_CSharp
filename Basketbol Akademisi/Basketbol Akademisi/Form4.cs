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
    public partial class Form4 : Form
    {
        public Form4()
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        void LİSTELE()
        {

            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Shop", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT *  FROM basketbol", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                listBox1.Items.Add(oku["b_ad"].ToString() + " " + oku["b_soyad"].ToString() + " " + oku["b_forma"].ToString());
            }
            komut.Dispose();
            baglanti.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string turusec = comboBox1.SelectedItem.ToString();
            switch (turusec)
            {
                case "Kyrie İrving Air Max Sarı":
                    label5.Text = "Kyrie İrving Air Max Sarı";
                    label10.Text = "560₺";
                    label10.Visible = true;
                    label5.Visible = true;      
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    
                    break;
                case "Kyrie İrving Air Max Yeşil":
                    label5.Text = "Kyrie İrving Air Max Yeşil";
                    label5.Visible = true;
                    label10.Text = "690₺";
                    label10.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;


                    break;
                case "Kyrie İrving Air Max Kırmızı":
                    label5.Text = "Kyrie İrving Air Max Kırmızı";
                    label5.Visible = true;
                    label10.Text = "984₺";
                    label10.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;

                    break;
                case "Kyrie İrving Air Max Beyaz":
                    label5.Text = "Kyrie İrving Air Max Beyaz";
                    label5.Visible = true;
                    label10.Text = "410₺";
                    label10.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;

                    break;


            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           

            string turusec = comboBox2.SelectedItem.ToString();
            switch (turusec)
            {




                case "Golden State Warriors Mavi Klasik Forma":
                    label5.Text = "Golden State Warriors Mavi Klasik Forma";
                    label5.Visible = true;
                    label10.Text = "250₺";
                    label10.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;

                    break;
                case "Cavs 23 Forma":
                    label5.Text = "Cavs 23 Forma";
                    label5.Visible = true;
                    label10.Text = "350₺";
                    label10.Visible = true;
                    pictureBox8.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;


                    break;
                case "Boston Celtics Beyaz Forma":
                    label5.Text = "Boston Celtics Beyaz Forma";
                    label10.Text = "250₺";
                    label10.Visible = true;
                    label5.Visible = true;
                    pictureBox9.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;

                    break;
                case "Sporcu Taytı":
                    label5.Text = "Sporcu Taytı";
                    label5.Visible = true;
                    label10.Text = "56₺";
                    label10.Visible = true;
                    pictureBox10.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;

                    break;
            }
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string turusec = comboBox3.SelectedItem.ToString();
            switch (turusec)
            {
                case "Red Bull":
                    label5.Text = "Red Bull";
                    label5.Visible = true;
                    label10.Text = "5₺";
                    label10.Visible = true;
                    pictureBox11.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox12.Visible = false;

                    break;
                case "Burn":
                    label5.Text = "Burn";
                    label5.Visible = true;
                    label10.Text = "5₺";
                    label10.Visible = true;
                    pictureBox12.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox11.Visible = false;
                    break;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("INSERT INTO Shop(b_ad,b_alınan,b_tarih,b_saat,b_fiyat) VALUES(@b_gelmeyen,b_alınan,@b_tarih,b_saat,b_fiyat)", baglanti);
            komut.Parameters.AddWithValue("@b_ad", label9.Text);
            komut.Parameters.AddWithValue("@b_alınan", label5.Text);
            komut.Parameters.AddWithValue("@b_tarih", label7.Text);
            komut.Parameters.AddWithValue("@b_saat", label6.Text);
            komut.Parameters.AddWithValue("@b_fiyat", label10.Text);
            komut.ExecuteNonQuery();
            LİSTELE();
            baglanti.Close();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Text = Convert.ToString(listBox1.SelectedItem); label9.Visible = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime zaman = DateTime.Now;
            label6.Text = DateTime.Now.ToLongTimeString();
            label7.Text = zaman.ToLongDateString();
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM shop WHERE b_alınan LIKE '" + textBox1.Text + "%' OR  b_ad LIKE '" +textBox1.Text+ "%'" , baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

