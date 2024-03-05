namespace Turtle_Bank
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bpersonelid = new System.Windows.Forms.TextBox();
            this.bpersonelsifre = new System.Windows.Forms.TextBox();
            this.girisyap = new System.Windows.Forms.Button();
            this.cikisyap = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // bpersonelid
            // 
            this.bpersonelid.Location = new System.Drawing.Point(163, 79);
            this.bpersonelid.Name = "bpersonelid";
            this.bpersonelid.Size = new System.Drawing.Size(100, 20);
            this.bpersonelid.TabIndex = 2;
            // 
            // bpersonelsifre
            // 
            this.bpersonelsifre.Location = new System.Drawing.Point(163, 107);
            this.bpersonelsifre.Name = "bpersonelsifre";
            this.bpersonelsifre.Size = new System.Drawing.Size(100, 20);
            this.bpersonelsifre.TabIndex = 3;
            // 
            // girisyap
            // 
            this.girisyap.Location = new System.Drawing.Point(188, 146);
            this.girisyap.Name = "girisyap";
            this.girisyap.Size = new System.Drawing.Size(75, 23);
            this.girisyap.TabIndex = 4;
            this.girisyap.Text = "Giriş Yap";
            this.girisyap.UseVisualStyleBackColor = true;
            this.girisyap.Click += new System.EventHandler(this.girisyap_Click);
            // 
            // cikisyap
            // 
            this.cikisyap.Location = new System.Drawing.Point(240, 217);
            this.cikisyap.Name = "cikisyap";
            this.cikisyap.Size = new System.Drawing.Size(75, 23);
            this.cikisyap.TabIndex = 5;
            this.cikisyap.Text = "Çıkış Yap";
            this.cikisyap.UseVisualStyleBackColor = true;
            this.cikisyap.Click += new System.EventHandler(this.cikisyap_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateBatchSize = 0;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(327, 252);
            this.Controls.Add(this.cikisyap);
            this.Controls.Add(this.girisyap);
            this.Controls.Add(this.bpersonelsifre);
            this.Controls.Add(this.bpersonelid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Turtle Bank Personel Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bpersonelid;
        private System.Windows.Forms.TextBox bpersonelsifre;
        private System.Windows.Forms.Button girisyap;
        private System.Windows.Forms.Button cikisyap;
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
    }
}

