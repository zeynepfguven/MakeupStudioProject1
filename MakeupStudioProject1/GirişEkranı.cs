using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeupStudioProject1
{
    public partial class GirişEkranı : Form
    {
        string connectionString = "Data Source=DESKTOP-LII6161\\SQLKURS;Initial Catalog=MakeupStudio;Integrated Security=True";
        
       
        public GirişEkranı()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            string username = txtKullanıcıAdı.Text;
            string password = txtŞifre.Text;

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Şifre FROM KayıtListesi WHERE KullanıcıAdı=@username";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@username", username);
                    string savedpassword=(string)cmd.ExecuteScalar();

                    if (savedpassword ==password )
                    {
                        this.Hide();
                        Anasayfa anasayfa = new Anasayfa();
                        anasayfa.Show();
                    }
                    else
                    {
                        MessageBox.Show("HATALI KULLANICI ADI VEYA ŞİFRE");
                    }
                }
               

            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnkayıtol_Click(object sender, EventArgs e)
        {
            this.Hide();
            KayıtEkranı kayıtEkranı = new KayıtEkranı();
            kayıtEkranı.Show();
        }

        private void btnsifreunuttum_Click(object sender, EventArgs e)
        {
            this.Hide();
            ŞİfremiUnuttum şİfremiUnuttum=new ŞİfremiUnuttum();
            şİfremiUnuttum.Show();
        }

        private void txtŞifre_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnsifregoster_Click(object sender, EventArgs e)
        {
            if (txtŞifre.PasswordChar == '●')
            {
                txtŞifre.PasswordChar = '\0';

            }
            else
            {
                txtŞifre.PasswordChar = '●';

            }
        }
    }
}
