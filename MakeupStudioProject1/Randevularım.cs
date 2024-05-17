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
    public partial class Randevularım : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LII6161\\SQLKURS;Initial Catalog=MakeupStudio;Integrated Security=True");


        public Randevularım()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RandevuAl randevuAl = new RandevuAl();  
            randevuAl.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            string uzman = txtuzmanıd.Text;
            string uzmanAd = "";
            string hizmet=cmbhizmet.SelectedItem.ToString();
            string randevu=txtid.Text;
            DateTime dateTime = dateTimePicker1.Value.Date;
            string saat=comboBox1.SelectedItem.ToString();
            TimeSpan saatsec=TimeSpan.Parse(saat);
            dateTime = dateTime.Add(saatsec);

            string queryselect = "select İsim from Uzmanlar where ID=@uzman";
            
            string queryUpdate = "UPDATE Randevular SET ID=@randevuId,Hizmet=@hizmet,Uzman=@uzman,Tarih=@tarih WHERE DanışanMail=@mail";

            SqlCommand command= new SqlCommand(queryselect, connection);
            command.Parameters.AddWithValue("@uzman", uzman);
            uzmanAd =(string)command.ExecuteScalar();
            command.ExecuteNonQuery();

            SqlCommand cmd=new SqlCommand(queryUpdate, connection);
            cmd.Parameters.AddWithValue("@mail",txtmail.Text);
            cmd.Parameters.AddWithValue("@randevuId", randevu);
            cmd.Parameters.AddWithValue("@hizmet", hizmet);
            cmd.Parameters.AddWithValue("@uzman", uzmanAd);
            cmd.Parameters.AddWithValue("@tarih", dateTime);
            
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Randevu Bilgileri Başarıyla Güncellendi");
            this.Hide();
            Anasayfa anasayfa = new Anasayfa(); 
            anasayfa.Show();    

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciMail = txtmail.Text;
            connection.Open();
            string query = "SELECT ID,Hizmet,Uzman,Tarih FROM Randevular WHERE DanışanMail=@mail";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@mail", kullaniciMail);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            string randevuId=txtid.Text;

            string querydelete = "delete from Randevular where ID=@randevuId";

            SqlCommand command = new SqlCommand(querydelete,connection);

            command.Parameters.AddWithValue("@randevuId", randevuId);
            command.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Randevu Silme İşlemi Başarıyla Gerçekleşti");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa anasayfa=new Anasayfa();   
            anasayfa.Show();
        }
    }

}
