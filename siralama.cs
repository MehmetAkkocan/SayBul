using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SayBul
{
    public partial class siralama : Form
    {
        public siralama()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select top 10 o.oyunAD as İsim, p.puan as Puan From OYUNCU o , PUAN p Where o.oyunID = p.oyunID Order by p.puan desc", con);
            da.Fill(dt);            
            //SqlCommand kmt = new SqlCommand("Select o.oyunAD, p.puan From OYUNCU o , PUAN p Where o.oyunID = p.oyunID",con);
            //DataSet ds = new DataSet();
            //con.Open();
            //da.Fill(ds, "Puan");
            //con.Close();
            this.dataGridView1.DataSource = Otosira(dt);
        }
        SqlConnection con = new SqlConnection(giris.bagla);
        private DataTable Otosira(DataTable os)
        {
            DataTable st = new DataTable();
            DataColumn sira = new DataColumn();
            sira.ColumnName = "Sıra NO";
            sira.DataType = typeof(int);
            sira.AutoIncrement = true;
            sira.AutoIncrementSeed = 1;
            sira.AutoIncrementStep = 1;
            st.Columns.Add(sira);
            st.Merge(os);
            return st;
        }
        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
            menu go = new menu();
            go.Show();
        }

        private void siralama_Load(object sender, EventArgs e)
        {
            
        }
    }
}
