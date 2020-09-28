using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basketbol_Akademisi
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
            timer1.Stop();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
        }
    }
}
