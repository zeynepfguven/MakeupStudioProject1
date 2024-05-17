using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeupStudioProject1
{
    public partial class ŞİfremiUnuttum : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LII6161\\SQLKURS;Initial Catalog=MakeupStudio;Integrated Security=True");

        public ŞİfremiUnuttum()
        {
            InitializeComponent();
        }

        private void ŞİfremiUnuttum_Load(object sender, EventArgs e)
        {
            gboxkod.Visible = false;
            gboxys.Visible = false;

            
        }

        private void btnkodgönder_Click(object sender, EventArgs e)
        {
            gboxkod.Visible = true;
           
        }

        private void btnkokaydet_Click(object sender, EventArgs e)
        {
            
            if (txtkod.Text == "0")
            {
                gboxys.Visible=true;
               
               
                
            }
        }

        private void btnsifrekaydet_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "UPDATE KayıtListesi SET Şifre=@yenişifre WHERE Mail=@mail";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd.Parameters.AddWithValue("@yenişifre", txtyenisifre.Text);
                cmd.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA");
            }
            finally
            {
                connection.Close();
            }
            MessageBox.Show("ŞİFRE BAŞARIYLA GÜNCELLENDİ");
            this.Close();

            GirişEkranı girişEkranı=new GirişEkranı();
            girişEkranı.Show();
        }

        private void btnsifregoster_Click(object sender, EventArgs e)
        {
            if (txtyenisifre.PasswordChar == '●')
            {
                txtyenisifre.PasswordChar = '\0';

            }
            else
            {
                txtyenisifre.PasswordChar = '●';

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            GirişEkranı girişEkranı = new GirişEkranı();
            girişEkranı.Show();
        }
    }
}
