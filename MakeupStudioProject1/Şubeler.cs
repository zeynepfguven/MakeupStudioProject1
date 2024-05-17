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
    public partial class Şubeler : Form
    {
        public Şubeler()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Şubeler_Load(object sender, EventArgs e)
        {

        }

        private void btnrandevual_Click(object sender, EventArgs e)
        {
            this.Close();
            RandevuAl randevuAl = new RandevuAl();
            randevuAl.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
        }
    }
}
