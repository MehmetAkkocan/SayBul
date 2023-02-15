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
    public partial class oynanis : Form
    {
        public oynanis()
        {
            InitializeComponent();
            label1.Text = "Hoşgeldin " + giris.nickname;
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
            menu go = new menu();
            go.Show();
        }
    }
}
