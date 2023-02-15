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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        // TODO : SQL connection string
        public static string bagla= "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = db_saybul; Integrated Security = True";
        SqlConnection con = new SqlConnection(bagla);
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static string nickname;
        private void btngiris_Click(object sender, EventArgs e)
        {
            nickname = txtgiris.Text;
            if (nickname == "")
            {
                MessageBox.Show("Lütfen Bir İsim Giriniz!");
            }
            else
            {
                con.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM OYUNCU where oyunAD = @n", con);
                komut.Parameters.AddWithValue("@n", nickname);
                SqlDataReader a = komut.ExecuteReader();
                Boolean b = a.Read();
                con.Close();
                if (b == true)
                {
                    this.Hide();
                    menu go = new menu();
                    go.Show();

                }
                else
                {
                    con.Open();
                    SqlCommand ekle = new SqlCommand("Insert into OYUNCU(oyunAD) values(@m) ", con);
                    ekle.Parameters.AddWithValue("@m", nickname);
                    ekle.ExecuteNonQuery();
                    con.Close();
                    this.Hide();
                    menu go = new menu();
                    go.Show();

                }
            }
        }
    }
}
