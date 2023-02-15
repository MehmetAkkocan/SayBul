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
    public partial class antreman : Form
    {
        public antreman()
        {
            InitializeComponent();
            timer1.Start();
            btnsayi6.Enabled = false;
            btnsayi7.Enabled = false;
            btnsayi8.Enabled = false;
            btnsayi9.Enabled = false;
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
            menu go = new menu();
            go.Show();
        }
        public bool lblBosmu(Label lbl)
        {
            if (lbl.Text == "")
            {
                return true;
            }
            return false;

        }
        public void sayiTasi(Button btn)
        {
            if (btn.Text!="")
            {
                if (lblBosmu(lblsayi1) == true)
                {
                    lblsayi1.Text = btn.Text;
                    btn.Enabled = false;
                }
                else if (lblBosmu(lblsayi2) == true)
                {
                    lblsayi2.Text = btn.Text;
                    btn.Enabled = false;
                }
                else if (lblBosmu(lblsayi3) == true)
                {
                    lblsayi3.Text = btn.Text;
                    btn.Enabled = false;
                }
                else if (lblBosmu(lblsayi4) == true)
                {
                    lblsayi4.Text = btn.Text;
                    btn.Enabled = false;
                }
                else if (lblBosmu(lblsayi5) == true)
                {
                    lblsayi5.Text = btn.Text;
                    btn.Enabled = false;
                }
                else if (lblBosmu(lblsayi6) == true)
                {
                    lblsayi6.Text = btn.Text;
                    btn.Enabled = false;
                }
                else if (lblBosmu(lblsayi7) == true)
                {
                    lblsayi7.Text = btn.Text;
                    btn.Enabled = false;
                }
                else if (lblBosmu(lblsayi8) == true)
                {
                    lblsayi8.Text = btn.Text;
                    btn.Enabled = false;
                }
            }
        }
        int sure = 90;
        public void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            sure -= 1;
            lblsure.Text = sure.ToString();
            if (sure == 0)
            {
                timer1.Stop();
                lblsure.Text = "0";
                lblsure.BackColor = Color.GhostWhite;
            }
        }
        public void HedefKontrol(Button btn1)
        {
            if (btn1.Text==lblhedef.Text)
            {
                timer1.Stop();
                int  puan = PuanHesapla(sure,0,4);
                MessageBox.Show("Tebrikler Hedeflenen Sayıya Ulaştınız\nPuanınız: "+puan);
                DialogResult result = MessageBox.Show("Yeniden Oynamak İster misiniz?", "Tebrikler", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Yeniden();
                }
                else
                {
                    this.Close();
                    menu go = new menu();
                    go.Show();
                }
            }            
        }
        public int PuanHesapla(int a, int b, int c)
        {
            double d = (1600 - b) + (a * c*(1/(b+1)));
            Math.Ceiling(d);
            int e = Convert.ToInt32(d);
            return e;
        }
        private void btnsayi1_Click(object sender, EventArgs e)
        {
            sayiTasi(btnsayi1);
        }

        private void btnsayi2_Click(object sender, EventArgs e)
        {
            sayiTasi(btnsayi2);
        }

        private void btnsayi3_Click(object sender, EventArgs e)
        {
            sayiTasi(btnsayi3);
        }

        private void btnsayi4_Click(object sender, EventArgs e)
        {
            sayiTasi(btnsayi4);
        }

        private void btnsayi5_Click(object sender, EventArgs e)
        {
            sayiTasi(btnsayi5);
        }

        private void btnsayi6_Click(object sender, EventArgs e)
        {
            sayiTasi(btnsayi6);            
        }

        private void btnsayi7_Click(object sender, EventArgs e)
        {
            sayiTasi(btnsayi7);            
        }

        private void btnsayi8_Click(object sender, EventArgs e)
        {            
            sayiTasi(btnsayi8);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblsayi1.Text!="" && lblsayi2.Text!="")
            {
                int a = Convert.ToInt32(lblsayi1.Text) + Convert.ToInt32(lblsayi2.Text);
                btnsayi6.Text = a.ToString();
                HedefKontrol(btnsayi6);
                btnsayi6.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblsayi1.Text != "" && lblsayi2.Text != "")
            {
                int a = Convert.ToInt32(lblsayi1.Text) - Convert.ToInt32(lblsayi2.Text);
                btnsayi6.Text = a.ToString();
                HedefKontrol(btnsayi6);
                btnsayi6.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lblsayi1.Text != "" && lblsayi2.Text != "")
            {
                int a = Convert.ToInt32(lblsayi1.Text) * Convert.ToInt32(lblsayi2.Text);
                btnsayi6.Text = a.ToString();
                HedefKontrol(btnsayi6);
                btnsayi6.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lblsayi1.Text != "" && lblsayi2.Text != "")
            {
                int b = Convert.ToInt32(lblsayi1.Text);
                int c = Convert.ToInt32(lblsayi2.Text);
                if (b % c == 0)
                {
                    int a = b / c;
                    btnsayi6.Text = a.ToString();
                    HedefKontrol(btnsayi6);
                    btnsayi6.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sayı Tam Bölünmez!");
                }
            }

        }
        public void GeriAl(Label lbl1, Label lbl2)
        {
            if (btnsayi1.Text == lbl1.Text)
            {
                btnsayi1.Enabled = true;
            }
            else if (btnsayi2.Text == lbl1.Text)
            {
                btnsayi2.Enabled = true;
            }
            else if (btnsayi3.Text == lbl1.Text)
            {
                btnsayi3.Enabled = true;
            }
            else if (btnsayi4.Text == lbl1.Text)
            {
                btnsayi4.Enabled = true;
            }
            else if (btnsayi5.Text == lbl1.Text)
            {
                btnsayi5.Enabled = true;
            }
            else if (btnsayi6.Text == lbl1.Text)
            {
                btnsayi6.Enabled = true;
            }
            else if (btnsayi7.Text == lbl1.Text)
            {
                btnsayi7.Enabled = true;
            }
            else if (btnsayi8.Text == lbl1.Text)
            {
                btnsayi8.Enabled = true;
            }
            else if (btnsayi9.Text == lbl1.Text)
            {
                btnsayi9.Enabled = true;
            }
            lbl1.Text = "";
            if (btnsayi1.Text == lbl2.Text)
            {
                btnsayi1.Enabled = true;
            }
            else if (btnsayi2.Text == lbl2.Text)
            {
                btnsayi2.Enabled = true;
            }
            else if (btnsayi3.Text == lbl2.Text)
            {
                btnsayi3.Enabled = true;
            }
            else if (btnsayi4.Text == lbl2.Text)
            {
                btnsayi4.Enabled = true;
            }
            else if (btnsayi5.Text == lbl2.Text)
            {
                btnsayi5.Enabled = true;
            }
            else if (btnsayi6.Text == lbl2.Text)
            {
                btnsayi6.Enabled = true;
            }
            else if (btnsayi7.Text == lbl2.Text)
            {
                btnsayi7.Enabled = true;
            }
            else if (btnsayi8.Text == lbl2.Text)
            {
                btnsayi8.Enabled = true;
            }
            else if (btnsayi9.Text == lbl2.Text)
            {
                btnsayi9.Enabled = true;
            }
            else
            {
                
            }
            lbl2.Text = "";
        }
        private void btngeri_Click(object sender, EventArgs e)
        {
            if (btnsayi6.Text == "")
            {
                GeriAl(lblsayi1, lblsayi2);
            }
            
            if (btnsayi7.Text == "")
            {
                GeriAl(lblsayi3, lblsayi4);
            }
            
            if (btnsayi8.Text == "")
            {
                GeriAl(lblsayi5, lblsayi6);
            }
            
            if (btnsayi9.Text == "")
            {
                GeriAl(lblsayi7, lblsayi8);
            }
            
        }
        public void Resetle()
        {
            btnsayi1.Enabled = true;
            btnsayi2.Enabled = true;
            btnsayi3.Enabled = true;
            btnsayi4.Enabled = true;
            btnsayi5.Enabled = true;
            btnsayi6.Enabled = false;
            btnsayi7.Enabled = false;
            btnsayi8.Enabled = false;
            btnsayi9.Enabled = false;
            lblsayi1.Text = "";
            lblsayi2.Text = "";
            lblsayi3.Text = "";
            lblsayi4.Text = "";
            lblsayi5.Text = "";
            lblsayi6.Text = "";
            lblsayi7.Text = "";
            lblsayi8.Text = "";
            btnsayi6.Text = "";
            btnsayi7.Text = "";
            btnsayi8.Text = "";
            btnsayi9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
        }
        public void Yeniden()
        {
            sure = 90;
            lblsure.Text = sure.ToString();
            timer1.Start();
            btnsayi1.Enabled = true;
            btnsayi2.Enabled = true;
            btnsayi3.Enabled = true;
            btnsayi4.Enabled = true;
            btnsayi5.Enabled = true;
            btnsayi6.Enabled = false;
            btnsayi7.Enabled = false;
            btnsayi8.Enabled = false;
            btnsayi9.Enabled = false;
            lblsayi1.Text = "";
            lblsayi2.Text = "";
            lblsayi3.Text = "";
            lblsayi4.Text = "";
            lblsayi5.Text = "";
            lblsayi6.Text = "";
            lblsayi7.Text = "";
            lblsayi8.Text = "";
            btnsayi6.Text = "";
            btnsayi7.Text = "";
            btnsayi8.Text = "";
            btnsayi9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            Resetle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lblsayi3.Text != "" && lblsayi4.Text != "")
            {
                int a = Convert.ToInt32(lblsayi3.Text) + Convert.ToInt32(lblsayi4.Text);
                btnsayi7.Text = a.ToString();
                HedefKontrol(btnsayi7);
                btnsayi7.Enabled = true;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
            }            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lblsayi3.Text != "" && lblsayi4.Text != "")
            {
                int a = Convert.ToInt32(lblsayi3.Text) - Convert.ToInt32(lblsayi4.Text);
                btnsayi7.Text = a.ToString();
                HedefKontrol(btnsayi7);
                btnsayi7.Enabled = true;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lblsayi3.Text != "" && lblsayi4.Text != "")
            {
                int a = Convert.ToInt32(lblsayi3.Text) * Convert.ToInt32(lblsayi4.Text);
                btnsayi7.Text = a.ToString();
                HedefKontrol(btnsayi7);
                btnsayi7.Enabled = true;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (lblsayi3.Text != "" && lblsayi4.Text != "")
            {
                int b = Convert.ToInt32(lblsayi3.Text);
                int c = Convert.ToInt32(lblsayi4.Text);
                if (b % c == 0)
                {
                    int a = b / c;
                    btnsayi7.Text = a.ToString();
                    HedefKontrol(btnsayi7);
                    btnsayi7.Enabled = true;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sayı Tam Bölünmez!");
                }
            }            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lblsayi5.Text != "" && lblsayi6.Text != "")
            {
                int a = Convert.ToInt32(lblsayi5.Text) + Convert.ToInt32(lblsayi6.Text);
                btnsayi8.Text = a.ToString();
                HedefKontrol(btnsayi8);
                btnsayi8.Enabled = true;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
            }            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (lblsayi5.Text != "" && lblsayi6.Text != "")
            {
                int a = Convert.ToInt32(lblsayi5.Text) - Convert.ToInt32(lblsayi6.Text);
                btnsayi8.Text = a.ToString();
                HedefKontrol(btnsayi8);
                btnsayi8.Enabled = true;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (lblsayi5.Text != "" && lblsayi6.Text != "")
            {
                int a = Convert.ToInt32(lblsayi5.Text) * Convert.ToInt32(lblsayi6.Text);
                btnsayi8.Text = a.ToString();
                HedefKontrol(btnsayi8);
                btnsayi8.Enabled = true;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (lblsayi5.Text != "" && lblsayi6.Text != "")
            {
                int b = Convert.ToInt32(lblsayi5.Text);
                int c = Convert.ToInt32(lblsayi6.Text);
                if (b % c == 0)
                {
                    int a = b / c;
                    btnsayi8.Text = a.ToString();
                    HedefKontrol(btnsayi8);
                    btnsayi8.Enabled = true;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sayı Tam Bölünmez!");
                }
            }            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (lblsayi7.Text != "" && lblsayi8.Text != "")
            {
                int b = Convert.ToInt32(lblsayi7.Text);
                int c = Convert.ToInt32(lblsayi8.Text);
                if (b % c == 0)
                {
                    int a = b / c;
                    btnsayi9.Text = a.ToString();
                    HedefKontrol(btnsayi9);
                    btnsayi9.Enabled = true;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sayı Tam Bölünmez!");
                }
            }            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (lblsayi7.Text != "" && lblsayi8.Text != "")
            {
                int a = Convert.ToInt32(lblsayi7.Text) * Convert.ToInt32(lblsayi8.Text);
                btnsayi9.Text = a.ToString();
                HedefKontrol(btnsayi9);
                btnsayi9.Enabled = true;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
            }            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (lblsayi7.Text != "" && lblsayi8.Text != "")
            {
                int a = Convert.ToInt32(lblsayi7.Text) - Convert.ToInt32(lblsayi8.Text);
                btnsayi9.Text = a.ToString();
                HedefKontrol(btnsayi9);
                btnsayi9.Enabled = true;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (lblsayi7.Text != "" && lblsayi8.Text != "")
            {
                int a = Convert.ToInt32(lblsayi7.Text) + Convert.ToInt32(lblsayi8.Text);
                btnsayi9.Text = a.ToString();
                HedefKontrol(btnsayi9);
                btnsayi9.Enabled = true;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
            }
        }

        private void btnyak_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (btnsayi9.Text != "")
            {
                int yak = Convert.ToInt32(lblhedef.Text) - Convert.ToInt32(btnsayi9.Text);
                Math.Abs(yak);
                MessageBox.Show("Hedeflenen Sayıya "+yak+" Sayı Yaklaştınız\nPuanınız: " + PuanHesapla(sure, yak, 4));
                DialogResult result = MessageBox.Show("Yeniden Oynamak İster misiniz?", "Tebrikler", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Yeniden();
                }
                else
                {
                    this.Close();
                    menu go = new menu();
                    go.Show();
                }
            }
            else if (btnsayi8.Text != "")
            {
                int yak = Convert.ToInt32(lblhedef.Text) - Convert.ToInt32(btnsayi8.Text);
                Math.Abs(yak);
                MessageBox.Show("Hedeflenen Sayıya " + yak + " Sayı Yaklaştınız\nPuanınız: " + PuanHesapla(sure, yak, 4));
                DialogResult result = MessageBox.Show("Yeniden Oynamak İster misiniz?", "Tebrikler", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Yeniden();
                }
                else
                {
                    this.Close();
                    menu go = new menu();
                    go.Show();
                }

            }
            else if (btnsayi7.Text != "")
            {
                int yak = Convert.ToInt32(lblhedef.Text) - Convert.ToInt32(btnsayi7.Text);
                Math.Abs(yak);
                MessageBox.Show("Hedeflenen Sayıya " + yak + " Sayı Yaklaştınız\nPuanınız: " + PuanHesapla(sure, yak, 4));
                DialogResult result = MessageBox.Show("Yeniden Oynamak İster misiniz?", "Tebrikler", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Yeniden();
                }
                else
                {
                    this.Close();
                    menu go = new menu();
                    go.Show();
                }

            }
            else if (btnsayi6.Text != "")
            {
                int yak = Convert.ToInt32(lblhedef.Text) - Convert.ToInt32(btnsayi6.Text);
                Math.Abs(yak);
                MessageBox.Show("Hedeflenen Sayıya " + yak + " Sayı Yaklaştınız\nPuanınız: " + PuanHesapla(sure, yak, 4));
                DialogResult result = MessageBox.Show("Yeniden Oynamak İster misiniz?", "Tebrikler", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Yeniden();
                }
                else
                {
                    this.Close();
                    menu go = new menu();
                    go.Show();
                }
            }
        }
    }
}
