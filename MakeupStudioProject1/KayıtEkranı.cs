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
    public partial class KayıtEkranı : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LII6161\\SQLKURS;Initial Catalog=MakeupStudio;Integrated Security=True");
        
        public KayıtEkranı()
        {
            InitializeComponent();
        }
        private void btnKAYIT_Click(object sender, EventArgs e)
        {
            if (rdbKullanıcıSözleşme.Checked == true)
            {
                connection.Open();
                string query = "INSERT INTO KayıtListesi (Ad,Soyad,Mail,KullanıcıAdı,Telefon,Şifre,Cinsiyet,DoğumTarihi,Adres) VALUES (@Ad,@Soyad,@Mail,@KullanıcıAdı,@Telefon,@Şifre,@Cinsiyet,@DoğumTarihi,@Adres)";
                SqlCommand command = new SqlCommand(query, connection);


                command.Parameters.AddWithValue("@Ad", txtad.Text);
                command.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
                command.Parameters.AddWithValue("@Mail", txtmail.Text);
                command.Parameters.AddWithValue("@KullanıcıAdı", txtkullanıcıad.Text);
                command.Parameters.AddWithValue("@Telefon", txttel.Text);
                command.Parameters.AddWithValue("@Şifre", txtşifre.Text);
                command.Parameters.AddWithValue("@Cinsiyet", txtcinsiyet.Text);
                command.Parameters.AddWithValue("@DoğumTarihi", txtdogumtarihi.Text);
                command.Parameters.AddWithValue("@Adres", txtadres.Text);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("KAYIT BAŞARILI");
            }
            else
            {
                MessageBox.Show("Kullanıcı Sözleşmesini kabul etmediniz! ");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            GirişEkranı girişEkranı=new GirişEkranı();
            girişEkranı.Show();
        }
    }
}
