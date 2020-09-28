using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Basketbol_Akademisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            progressBar1.Value = sayac;
            progressBar1.ForeColor = Color.Black;
            label1.Text = "%" + progressBar1.Value.ToString();
            if (sayac >= 100)
            {
                timer1.Stop();
                Form frm2 = new Form2();
                this.Hide();
                frm2.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Application.StartupPath + "/bandicam 2019-02-27 16-51-36-321 (online-video-cutter.com).mp4";
            timer1.Start();
        }

        private void AxWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
