﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anaokulu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OgrenciEkle ekle = new OgrenciEkle();
            ekle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SubeEkle subeEkle = new SubeEkle();
            subeEkle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OgretmenEkle ogretmenEkle = new OgretmenEkle();
            ogretmenEkle.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OgrenciListele ogrenciListele = new OgrenciListele();
            ogrenciListele.Show();
        }
    }
}
