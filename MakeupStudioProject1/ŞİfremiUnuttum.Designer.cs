namespace MakeupStudioProject1
{
    partial class ŞİfremiUnuttum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ŞİfremiUnuttum));
            this.gboxys = new System.Windows.Forms.GroupBox();
            this.btnsifrekaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtyenisifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.gboxmail = new System.Windows.Forms.GroupBox();
            this.btnkodgönder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gboxkod = new System.Windows.Forms.GroupBox();
            this.btnkokaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsifregoster = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gboxys.SuspendLayout();
            this.gboxmail.SuspendLayout();
            this.gboxkod.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxys
            // 
            this.gboxys.BackColor = System.Drawing.Color.Transparent;
            this.gboxys.Controls.Add(this.btnsifregoster);
            this.gboxys.Controls.Add(this.btnsifrekaydet);
            this.gboxys.Controls.Add(this.label6);
            this.gboxys.Controls.Add(this.txtyenisifre);
            this.gboxys.Controls.Add(this.label2);
            this.gboxys.Location = new System.Drawing.Point(254, 277);
            this.gboxys.Name = "gboxys";
            this.gboxys.Size = new System.Drawing.Size(261, 110);
            this.gboxys.TabIndex = 3;
            this.gboxys.TabStop = false;
            // 
            // btnsifrekaydet
            // 
            this.btnsifrekaydet.BackColor = System.Drawing.Color.Pink;
            this.btnsifrekaydet.ForeColor = System.Drawing.Color.DeepPink;
            this.btnsifrekaydet.Location = new System.Drawing.Point(122, 70);
            this.btnsifrekaydet.Name = "btnsifrekaydet";
            this.btnsifrekaydet.Size = new System.Drawing.Size(75, 23);
            this.btnsifrekaydet.TabIndex = 5;
            this.btnsifrekaydet.Text = "KAYDET";
            this.btnsifrekaydet.UseVisualStyleBackColor = false;
            this.btnsifrekaydet.Click += new System.EventHandler(this.btnsifrekaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LavenderBlush;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DeepPink;
            this.label6.Location = new System.Drawing.Point(57, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "YENİ ŞİFRENİZİ GİRİNİZ";
            // 
            // txtyenisifre
            // 
            this.txtyenisifre.Location = new System.Drawing.Point(102, 44);
            this.txtyenisifre.Name = "txtyenisifre";
            this.txtyenisifre.PasswordChar = '●';
            this.txtyenisifre.Size = new System.Drawing.Size(134, 20);
            this.txtyenisifre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LavenderBlush;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "YENİ ŞİFRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(37, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAİL";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(92, 52);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(134, 20);
            this.txtmail.TabIndex = 1;
            // 
            // gboxmail
            // 
            this.gboxmail.BackColor = System.Drawing.Color.Transparent;
            this.gboxmail.Controls.Add(this.btnkodgönder);
            this.gboxmail.Controls.Add(this.label3);
            this.gboxmail.Controls.Add(this.txtmail);
            this.gboxmail.Controls.Add(this.label1);
            this.gboxmail.Location = new System.Drawing.Point(254, 12);
            this.gboxmail.Name = "gboxmail";
            this.gboxmail.Size = new System.Drawing.Size(261, 110);
            this.gboxmail.TabIndex = 2;
            this.gboxmail.TabStop = false;
            // 
            // btnkodgönder
            // 
            this.btnkodgönder.BackColor = System.Drawing.Color.Pink;
            this.btnkodgönder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkodgönder.ForeColor = System.Drawing.Color.DeepPink;
            this.btnkodgönder.Location = new System.Drawing.Point(122, 78);
            this.btnkodgönder.Name = "btnkodgönder";
            this.btnkodgönder.Size = new System.Drawing.Size(75, 23);
            this.btnkodgönder.TabIndex = 3;
            this.btnkodgönder.Text = "KOD GÖNDER";
            this.btnkodgönder.UseVisualStyleBackColor = false;
            this.btnkodgönder.Click += new System.EventHandler(this.btnkodgönder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LavenderBlush;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "MAİLİNİZE BİR KOD GÖNDERECEĞİZ";
            // 
            // gboxkod
            // 
            this.gboxkod.BackColor = System.Drawing.Color.Transparent;
            this.gboxkod.Controls.Add(this.btnkokaydet);
            this.gboxkod.Controls.Add(this.label4);
            this.gboxkod.Controls.Add(this.txtkod);
            this.gboxkod.Controls.Add(this.label5);
            this.gboxkod.Location = new System.Drawing.Point(254, 144);
            this.gboxkod.Name = "gboxkod";
            this.gboxkod.Size = new System.Drawing.Size(261, 110);
            this.gboxkod.TabIndex = 4;
            this.gboxkod.TabStop = false;
            // 
            // btnkokaydet
            // 
            this.btnkokaydet.BackColor = System.Drawing.Color.Pink;
            this.btnkokaydet.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkokaydet.ForeColor = System.Drawing.Color.DeepPink;
            this.btnkokaydet.Location = new System.Drawing.Point(122, 77);
            this.btnkokaydet.Name = "btnkokaydet";
            this.btnkokaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkokaydet.TabIndex = 4;
            this.btnkokaydet.Text = "OK";
            this.btnkokaydet.UseVisualStyleBackColor = false;
            this.btnkokaydet.Click += new System.EventHandler(this.btnkokaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LavenderBlush;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(30, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "MAİLİNİZE GELEN KODU GİRİNİZ";
            // 
            // txtkod
            // 
            this.txtkod.Location = new System.Drawing.Point(92, 51);
            this.txtkod.Name = "txtkod";
            this.txtkod.Size = new System.Drawing.Size(134, 20);
            this.txtkod.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LavenderBlush;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(42, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "KOD";
            // 
            // btnsifregoster
            // 
            this.btnsifregoster.BackColor = System.Drawing.Color.LightPink;
            this.btnsifregoster.Location = new System.Drawing.Point(237, 42);
            this.btnsifregoster.Name = "btnsifregoster";
            this.btnsifregoster.Size = new System.Drawing.Size(24, 22);
            this.btnsifregoster.TabIndex = 9;
            this.btnsifregoster.Text = "👁️";
            this.btnsifregoster.UseVisualStyleBackColor = false;
            this.btnsifregoster.Click += new System.EventHandler(this.btnsifregoster_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button1.Location = new System.Drawing.Point(12, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ŞİfremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gboxkod);
            this.Controls.Add(this.gboxys);
            this.Controls.Add(this.gboxmail);
            this.Name = "ŞİfremiUnuttum";
            this.Text = "ŞİfremiUnuttum";
            this.Load += new System.EventHandler(this.ŞİfremiUnuttum_Load);
            this.gboxys.ResumeLayout(false);
            this.gboxys.PerformLayout();
            this.gboxmail.ResumeLayout(false);
            this.gboxmail.PerformLayout();
            this.gboxkod.ResumeLayout(false);
            this.gboxkod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxys;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtyenisifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.GroupBox gboxmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gboxkod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsifrekaydet;
        private System.Windows.Forms.Button btnkodgönder;
        private System.Windows.Forms.Button btnkokaydet;
        private System.Windows.Forms.Button btnsifregoster;
        private System.Windows.Forms.Button button1;
    }
}