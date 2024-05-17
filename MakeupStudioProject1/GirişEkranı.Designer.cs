namespace MakeupStudioProject1
{
    partial class GirişEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirişEkranı));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btngiris = new System.Windows.Forms.Button();
            this.btnsifreunuttum = new System.Windows.Forms.Button();
            this.btnkayıtol = new System.Windows.Forms.Button();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsifregoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(83, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.MistyRose;
            this.btngiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngiris.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.ForeColor = System.Drawing.Color.Black;
            this.btngiris.Location = new System.Drawing.Point(148, 199);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(124, 29);
            this.btngiris.TabIndex = 2;
            this.btngiris.Text = "GİRİŞ";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // btnsifreunuttum
            // 
            this.btnsifreunuttum.BackColor = System.Drawing.Color.MistyRose;
            this.btnsifreunuttum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsifreunuttum.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsifreunuttum.ForeColor = System.Drawing.Color.Black;
            this.btnsifreunuttum.Location = new System.Drawing.Point(148, 239);
            this.btnsifreunuttum.Name = "btnsifreunuttum";
            this.btnsifreunuttum.Size = new System.Drawing.Size(124, 25);
            this.btnsifreunuttum.TabIndex = 3;
            this.btnsifreunuttum.Text = "Şifremi Unuttum";
            this.btnsifreunuttum.UseVisualStyleBackColor = false;
            this.btnsifreunuttum.Click += new System.EventHandler(this.btnsifreunuttum_Click);
            // 
            // btnkayıtol
            // 
            this.btnkayıtol.BackColor = System.Drawing.Color.MistyRose;
            this.btnkayıtol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkayıtol.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkayıtol.ForeColor = System.Drawing.Color.Black;
            this.btnkayıtol.Location = new System.Drawing.Point(148, 307);
            this.btnkayıtol.Name = "btnkayıtol";
            this.btnkayıtol.Size = new System.Drawing.Size(124, 29);
            this.btnkayıtol.TabIndex = 4;
            this.btnkayıtol.Text = "KAYIT OL";
            this.btnkayıtol.UseVisualStyleBackColor = false;
            this.btnkayıtol.Click += new System.EventHandler(this.btnkayıtol_Click);
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.BackColor = System.Drawing.Color.MistyRose;
            this.txtKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(148, 103);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(124, 26);
            this.txtKullanıcıAdı.TabIndex = 5;
            // 
            // txtŞifre
            // 
            this.txtŞifre.BackColor = System.Drawing.Color.MistyRose;
            this.txtŞifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtŞifre.Location = new System.Drawing.Point(148, 153);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.PasswordChar = '●';
            this.txtŞifre.Size = new System.Drawing.Size(124, 26);
            this.txtŞifre.TabIndex = 6;
            this.txtŞifre.TextChanged += new System.EventHandler(this.txtŞifre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(132, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Henüz bir hesabınız yok mu? \r\n                 Hemen";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnsifregoster
            // 
            this.btnsifregoster.BackColor = System.Drawing.Color.LightPink;
            this.btnsifregoster.Location = new System.Drawing.Point(278, 156);
            this.btnsifregoster.Name = "btnsifregoster";
            this.btnsifregoster.Size = new System.Drawing.Size(24, 22);
            this.btnsifregoster.TabIndex = 8;
            this.btnsifregoster.Text = "👁️";
            this.btnsifregoster.UseVisualStyleBackColor = false;
            this.btnsifregoster.Click += new System.EventHandler(this.btnsifregoster_Click);
            // 
            // GirişEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsifregoster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.Controls.Add(this.btnkayıtol);
            this.Controls.Add(this.btnsifreunuttum);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GirişEkranı";
            this.Text = "GirişEkranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Button btnsifreunuttum;
        private System.Windows.Forms.Button btnkayıtol;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsifregoster;
    }
}