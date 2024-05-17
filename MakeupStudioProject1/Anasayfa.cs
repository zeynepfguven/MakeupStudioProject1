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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnrandevual_Click(object sender, EventArgs e)
        {
            this.Hide();
            RandevuAl randevuAL = new RandevuAl();  
            randevuAL.Show();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnhizmetler_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hizmetlerimiz hizmetlerimiz = new Hizmetlerimiz();
            hizmetlerimiz.Show();
        }

        private void btn_randeularım_Click(object sender, EventArgs e)
        {
            this.Hide();
            Randevularım randevularım=new Randevularım();
            randevularım.Show();
        }

        private void btnsubeler_Click(object sender, EventArgs e)
        {
            this.Hide();
            Şubeler şubeler=new Şubeler();
            şubeler.Show();
        }

        private void btniletisim_Click(object sender, EventArgs e)
        {
            this.Hide();
            İletişimBilgileri iletişimBilgileri=new İletişimBilgileri();
            iletişimBilgileri.Show();
        }
    }
}
