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
    public partial class RandevuAl : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LII6161\\SQLKURS;Initial Catalog=MakeupStudio;Integrated Security=True");

        public RandevuAl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string uzmanID = txtuzmanıd.Text;
            string uzmanAdı = "";
            DateTime randevuTarihi = dateTimePicker1.Value.Date;
            string saatSecimi=comboBox1.SelectedItem.ToString();
            TimeSpan saat = TimeSpan.Parse(saatSecimi);
            randevuTarihi = randevuTarihi.Add(saat);

            connection.Open();
            string querycmd = "SELECT İsim FROM Uzmanlar WHERE ID=@uzmanID";
            SqlCommand command=new SqlCommand(querycmd, connection);
            command.Parameters.AddWithValue("@uzmanID",uzmanID);
            uzmanAdı=(string)command.ExecuteScalar();




            string query = "INSERT INTO Randevular (DanışanAd,DanışanSoyad,DanışanTel,DanışanMail,Uzman,Tarih) Values (@ad,@soyad,@tel,@mail,@uzman,@tarih)";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ad", txtad.Text);
            cmd.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@mail", txtmail.Text);
            cmd.Parameters.AddWithValue("@tel", txttel.Text);
            cmd.Parameters.AddWithValue("@uzman", uzmanAdı);
            cmd.Parameters.AddWithValue("@tarih", randevuTarihi);
           

            cmd.ExecuteNonQuery();




            if (checkBox1.Checked)
            {
                string query1 = "UPDATE Randevular SET Şube=@sube WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@sube", "İstanbul");
                cmd1.ExecuteNonQuery();

            }
            if (checkBox2.Checked)
            {
                string query1 = "UPDATE Randevular SET Şube=@sube WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@sube", "Bursa");
                cmd1.ExecuteNonQuery();
            }
            if (checkBox3.Checked)
            {
                string query1 = "UPDATE Randevular SET Şube=@sube WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@sube", "Ankara");
                cmd1.ExecuteNonQuery();

            }
            if(checkBox4.Checked)
            {
                string query1 = "UPDATE Randevular SET Şube=@sube WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@sube", "Adana");
                cmd1.ExecuteNonQuery();
            }
            if(checkBox5.Checked) 
            {
                string query1 = "UPDATE Randevular SET Şube=@sube WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@sube", "Samsun");
                cmd1.ExecuteNonQuery();
            }
            if(checkBox6.Checked) 
            {
                string query1 = "UPDATE Randevular SET Şube=@sube WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@sube", "Uşak");
                cmd1.ExecuteNonQuery();
            }

            if(checkBox7.Checked)
            {
                string query2 = "UPDATE Randevular SET RandevuTürü=@randevuTür,Hizmet=@randevu WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query2, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@randevuTür", "Make Up");
                cmd1.Parameters.AddWithValue("@randevu", "Gündüz Makyajı");

                cmd1.ExecuteNonQuery();
            }
            if (checkBox8.Checked)
            {
                string query2 = "UPDATE Randevular SET RandevuTürü=@randevuTür,Hizmet=@randevu WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query2, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@randevuTür", "Make Up");
                cmd1.Parameters.AddWithValue("@randevu", "Gece Makyajı");
                cmd1.ExecuteNonQuery();
            }
            if (checkBox9.Checked)
            {
                string query2 = "UPDATE Randevular SET RandevuTürü=@randevuTür,Hizmet=@randevu WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query2, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@randevuTür", "Make Up");
                cmd1.Parameters.AddWithValue("@randevu", "Tema Makyaj");
                cmd1.ExecuteNonQuery();
            }
            if (checkBox10.Checked)
            {
                string query2 = "UPDATE Randevular SET RandevuTürü=@randevuTür,Hizmet=@randevu WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query2, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@randevuTür", "Make Up");
                cmd1.Parameters.AddWithValue("@randevu", "Gelin Makyajı");
                cmd1.ExecuteNonQuery();
            }
            if (checkBox11.Checked)
            {
                string query3 = "UPDATE Randevular SET RandevuTürü=@randevuTür,Hizmet=@randevu WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query3, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@randevuTür", "Nail Bar");
                cmd1.Parameters.AddWithValue("@randevu", "Nail Art");
                cmd1.ExecuteNonQuery();
            }
            if (checkBox12.Checked)
            {
                string query2 = "UPDATE Randevular SET RandevuTürü=@randevuTür,Hizmet=@randevu WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query2, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@randevuTür", "Nail Bar");
                cmd1.Parameters.AddWithValue("@randevu", "Manikür");
                cmd1.ExecuteNonQuery();
            }
            if (checkBox13.Checked)
            {
                string query2 = "UPDATE Randevular SET RandevuTürü=@randevuTür,Hizmet=@randevu WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query2, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@randevuTür", "Nail Bar");
                cmd1.Parameters.AddWithValue("@randevu", "Protez Tırnak");
                cmd1.ExecuteNonQuery();
            }
            if (checkBox14.Checked)
            {
                string query2 = "UPDATE Randevular SET RandevuTürü=@randevuTür,Hizmet=@randevu WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query2, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@randevuTür", "Nail Bar");
                cmd1.Parameters.AddWithValue("@randevu", "Kalıcı Oje");
                cmd1.ExecuteNonQuery();
            }
            if (checkBox23.Checked)
            {
                string query2 = "UPDATE Randevular SET RandevuTürü=@randevuTür,Hizmet=@randevu WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query2, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@randevuTür", "Nail Bar");
                cmd1.Parameters.AddWithValue("@randevu", "Pedikür");
                cmd1.ExecuteNonQuery();
            }
            if (checkBox22.Checked)
            {
                string query2 = "UPDATE Randevular SET RandevuTürü=@randevuTür,Hizmet=@randevu WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query2, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@randevuTür", "Hair Design");
                cmd1.Parameters.AddWithValue("@randevu", "Saç Kesim");
                cmd1.ExecuteNonQuery();
            }
            if (checkBox21.Checked)
            {
                string query2 = "UPDATE Randevular SET RandevuTürü=@randevuTür,Hizmet=@randevu WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query2, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@randevuTür", "Hair Design");
                cmd1.Parameters.AddWithValue("@randevu", "Saç Boyama");
                cmd1.ExecuteNonQuery();
            }
            if (checkBox19.Checked)
            {
                string query2 = "UPDATE Randevular SET RandevuTürü=@randevuTür,Hizmet=@randevu WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query2, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text); 
                cmd1.Parameters.AddWithValue("@randevuTür", "Hair Design");
                cmd1.Parameters.AddWithValue("@randevu", "Keratin Bakım");
                cmd1.ExecuteNonQuery();
            }
            if (checkBox20.Checked)
            {
                string query2 = "UPDATE Randevular SET RandevuTürü=@randevuTür,Hizmet=@randevu WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query2, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text); 
                cmd1.Parameters.AddWithValue("@randevuTür", "Hair Design");
                cmd1.Parameters.AddWithValue("@randevu", "Saç Şekillendirme");
                cmd1.ExecuteNonQuery();
            }
            if (checkBox18.Checked)
            {
                string query2 = "UPDATE Randevular SET RandevuTürü=@randevuTür,Hizmet=@randevu WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query2, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@randevuTür", "Diğer İşemler");
                cmd1.Parameters.AddWithValue("@randevu", "Kaş Laminasyon");
                cmd1.ExecuteNonQuery();
            }
            if (checkBox16.Checked)
            {
                string query2 = "UPDATE Randevular SET RandevuTürü=@randevuTür,Hizmet=@randevu WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query2, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@randevuTür", "Diğer İşemler");
                cmd1.Parameters.AddWithValue("@randevu", "Kirpik Lifting");
                cmd1.ExecuteNonQuery();
            }
            if (checkBox17.Checked)
            {
                string query2 = "UPDATE Randevular SET RandevuTürü=@randevuTür,Hizmet=@randevu WHERE DanışanMail=@mail";
                SqlCommand cmd1 = new SqlCommand(query2, connection);
                cmd1.Parameters.AddWithValue("@mail", txtmail.Text);
                cmd1.Parameters.AddWithValue("@randevuTür", "Diğer İşemler");
                cmd1.Parameters.AddWithValue("@randevu", "Kaş Tasarım");
                cmd1.ExecuteNonQuery();
            }


            connection.Close();
            MessageBox.Show("Randevunuz Başarılı Bir Şekilde Kaydedildi");
            this.Hide();

            Anasayfa anasayfa = new Anasayfa();
            anasayfa.ShowDialog();
            this.Close();
            
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RandevuAl_Load(object sender, EventArgs e)
        {

        }

        private void btnmakeupartist_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Uzmanlar WHERE UzmanlıkAlanı='MakeUp Artist'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Uzmanlar WHERE UzmanlıkAlanı='Nail Artist'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Uzmanlar WHERE UzmanlıkAlanı='Hair Artist'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Uzmanlar WHERE UzmanlıkAlanı='Kaş-Kirpik'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Uzmanlar";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
