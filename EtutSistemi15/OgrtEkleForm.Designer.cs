
namespace EtutSistemi15
{
    partial class OgrtEkleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOgrtAdSoyad = new System.Windows.Forms.TextBox();
            this.cmbOgrtDers = new System.Windows.Forms.ComboBox();
            this.msktxtOgrtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtOgrtEmail = new System.Windows.Forms.TextBox();
            this.btnOgrtKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni Öğretmen Ekle - Güncelle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Branş Dersi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(89, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(84, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "E-posta:";
            // 
            // txtOgrtAdSoyad
            // 
            this.txtOgrtAdSoyad.Location = new System.Drawing.Point(153, 69);
            this.txtOgrtAdSoyad.Name = "txtOgrtAdSoyad";
            this.txtOgrtAdSoyad.Size = new System.Drawing.Size(150, 24);
            this.txtOgrtAdSoyad.TabIndex = 2;
            // 
            // cmbOgrtDers
            // 
            this.cmbOgrtDers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrtDers.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOgrtDers.FormattingEnabled = true;
            this.cmbOgrtDers.Location = new System.Drawing.Point(153, 103);
            this.cmbOgrtDers.Name = "cmbOgrtDers";
            this.cmbOgrtDers.Size = new System.Drawing.Size(150, 25);
            this.cmbOgrtDers.TabIndex = 4;
            // 
            // msktxtOgrtTelefon
            // 
            this.msktxtOgrtTelefon.Location = new System.Drawing.Point(153, 138);
            this.msktxtOgrtTelefon.Mask = "(999) 000-0000";
            this.msktxtOgrtTelefon.Name = "msktxtOgrtTelefon";
            this.msktxtOgrtTelefon.Size = new System.Drawing.Size(150, 24);
            this.msktxtOgrtTelefon.TabIndex = 6;
            // 
            // txtOgrtEmail
            // 
            this.txtOgrtEmail.Location = new System.Drawing.Point(153, 172);
            this.txtOgrtEmail.Name = "txtOgrtEmail";
            this.txtOgrtEmail.Size = new System.Drawing.Size(150, 24);
            this.txtOgrtEmail.TabIndex = 8;
            // 
            // btnOgrtKaydet
            // 
            this.btnOgrtKaydet.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOgrtKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgrtKaydet.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnOgrtKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrtKaydet.ForeColor = System.Drawing.Color.White;
            this.btnOgrtKaydet.Location = new System.Drawing.Point(103, 222);
            this.btnOgrtKaydet.Name = "btnOgrtKaydet";
            this.btnOgrtKaydet.Size = new System.Drawing.Size(200, 35);
            this.btnOgrtKaydet.TabIndex = 9;
            this.btnOgrtKaydet.Text = "Kaydet";
            this.btnOgrtKaydet.UseVisualStyleBackColor = false;
            this.btnOgrtKaydet.Click += new System.EventHandler(this.btnOgrtKaydet_Click);
            // 
            // OgrtEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(397, 269);
            this.Controls.Add(this.btnOgrtKaydet);
            this.Controls.Add(this.txtOgrtEmail);
            this.Controls.Add(this.msktxtOgrtTelefon);
            this.Controls.Add(this.cmbOgrtDers);
            this.Controls.Add(this.txtOgrtAdSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OgrtEkleForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders - Etüt Sistemi";
            this.Load += new System.EventHandler(this.OgrtEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOgrtAdSoyad;
        private System.Windows.Forms.ComboBox cmbOgrtDers;
        private System.Windows.Forms.MaskedTextBox msktxtOgrtTelefon;
        private System.Windows.Forms.TextBox txtOgrtEmail;
        private System.Windows.Forms.Button btnOgrtKaydet;
    }
}