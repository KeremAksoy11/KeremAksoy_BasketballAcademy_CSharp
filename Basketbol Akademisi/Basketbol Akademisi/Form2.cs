using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace Basketbol_Akademisi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
       
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            this.Hide();
            frm4.Show();
            
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            this.Hide();
            frm5.Show();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            this.Hide();
            frm6.Show();
        }
    }
}
