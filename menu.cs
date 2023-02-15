using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayBul
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            label1.Text = "Hoşgeldin " + giris.nickname;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Oyun Kapatılacak Emin misiniz?", "Kapatma Uyarısı!", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (Cikis == DialogResult.No)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            antreman go = new antreman();
            go.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            siralama go = new siralama();
            go.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            oynanis go = new oynanis();
            go.Show();
        }

        private void btnbasla_Click(object sender, EventArgs e)
        {
            DialogResult rslt = MessageBox.Show(" Oyunun Oynanış Menüsünü İncelediniz mi? \n \n Eğer Oyuna Devam Etmek İstiyorsanız 'Evet' Oynanış Menüsüne Gitmek İçin 'Hayır'a Tıklayınız","",MessageBoxButtons.YesNo);
            if (rslt == DialogResult.Yes )
            {
                this.Close();
                oyun go = new oyun();
                go.Show();
            }
            else
            {
                this.Close();
                oynanis go = new oynanis();
                go.Show();
            }
            
        }
    }
}
