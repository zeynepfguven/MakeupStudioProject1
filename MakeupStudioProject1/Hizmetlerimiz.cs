using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeupStudioProject1
{
    public partial class Hizmetlerimiz : Form
    {
        public Hizmetlerimiz()
        {
            InitializeComponent();
        }

        private void Hizmetlerimiz_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RandevuAl randevuAl = new RandevuAl();
            randevuAl.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa anasayfa = new Anasayfa(); 
            anasayfa.Show();    
        }
    }
}
