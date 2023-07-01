
namespace EtutSistemi15
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.msktxtSaat = new System.Windows.Forms.MaskedTextBox();
            this.msktxtTarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbOgretmenler = new System.Windows.Forms.ComboBox();
            this.cmbDersler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEtutVer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menustripitemYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripitemOgrenciEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripitemOgretmenEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripitemHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEtutID = new System.Windows.Forms.TextBox();
            this.txtOgrID = new System.Windows.Forms.TextBox();
            this.rbtnEtutler = new System.Windows.Forms.RadioButton();
            this.rbtnOgrenciler = new System.Windows.Forms.RadioButton();
            this.rbtnOgretmenler = new System.Windows.Forms.RadioButton();
            this.menustripitemDersEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.msktxtSaat);
            this.groupBox1.Controls.Add(this.msktxtTarih);
            this.groupBox1.Controls.Add(this.cmbOgretmenler);
            this.groupBox1.Controls.Add(this.cmbDersler);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Etüt Ekleme";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.ForestGreen;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(125, 191);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 35);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Oluştur";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // msktxtSaat
            // 
            this.msktxtSaat.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxtSaat.Location = new System.Drawing.Point(125, 139);
            this.msktxtSaat.Mask = "00:00";
            this.msktxtSaat.Name = "msktxtSaat";
            this.msktxtSaat.Size = new System.Drawing.Size(134, 24);
            this.msktxtSaat.TabIndex = 7;
            this.msktxtSaat.ValidatingType = typeof(System.DateTime);
            // 
            // msktxtTarih
            // 
            this.msktxtTarih.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxtTarih.Location = new System.Drawing.Point(125, 108);
            this.msktxtTarih.Mask = "00/00/0000";
            this.msktxtTarih.Name = "msktxtTarih";
            this.msktxtTarih.Size = new System.Drawing.Size(134, 24);
            this.msktxtTarih.TabIndex = 5;
            this.msktxtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbOgretmenler
            // 
            this.cmbOgretmenler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgretmenler.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOgretmenler.FormattingEnabled = true;
            this.cmbOgretmenler.Location = new System.Drawing.Point(125, 76);
            this.cmbOgretmenler.Name = "cmbOgretmenler";
            this.cmbOgretmenler.Size = new System.Drawing.Size(208, 25);
            this.cmbOgretmenler.TabIndex = 3;
            // 
            // cmbDersler
            // 
            this.cmbDersler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDersler.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDersler.FormattingEnabled = true;
            this.cmbDersler.Location = new System.Drawing.Point(125, 44);
            this.cmbDersler.Name = "cmbDersler";
            this.cmbDersler.Size = new System.Drawing.Size(208, 25);
            this.cmbDersler.TabIndex = 1;
            this.cmbDersler.SelectedIndexChanged += new System.EventHandler(this.cmbDersler_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(83, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(82, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğretmen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(81, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOgrID);
            this.groupBox2.Controls.Add(this.txtEtutID);
            this.groupBox2.Controls.Add(this.btnEtutVer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(492, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 255);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenciye Etüt Atama";
            // 
            // btnEtutVer
            // 
            this.btnEtutVer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEtutVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEtutVer.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnEtutVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtutVer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEtutVer.Location = new System.Drawing.Point(128, 191);
            this.btnEtutVer.Name = "btnEtutVer";
            this.btnEtutVer.Size = new System.Drawing.Size(200, 35);
            this.btnEtutVer.TabIndex = 16;
            this.btnEtutVer.Text = "Etüt Atama";
            this.btnEtutVer.UseVisualStyleBackColor = false;
            this.btnEtutVer.Click += new System.EventHandler(this.btnEtutVer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(78, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Öğrenci ID/No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(126, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Etüt ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 375);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(954, 375);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustripitemYeni,
            this.menustripitemHakkinda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menustripitemYeni
            // 
            this.menustripitemYeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menustripitemYeni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustripitemOgrenciEkle,
            this.menustripitemOgretmenEkle,
            this.menustripitemDersEkle});
            this.menustripitemYeni.ForeColor = System.Drawing.Color.Black;
            this.menustripitemYeni.Name = "menustripitemYeni";
            this.menustripitemYeni.Size = new System.Drawing.Size(41, 20);
            this.menustripitemYeni.Text = "Yeni";
            // 
            // menustripitemOgrenciEkle
            // 
            this.menustripitemOgrenciEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menustripitemOgrenciEkle.Name = "menustripitemOgrenciEkle";
            this.menustripitemOgrenciEkle.Size = new System.Drawing.Size(180, 22);
            this.menustripitemOgrenciEkle.Text = "Öğrenci Ekle";
            this.menustripitemOgrenciEkle.Click += new System.EventHandler(this.menustripitemOgrenciEkle_Click);
            // 
            // menustripitemOgretmenEkle
            // 
            this.menustripitemOgretmenEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menustripitemOgretmenEkle.Name = "menustripitemOgretmenEkle";
            this.menustripitemOgretmenEkle.Size = new System.Drawing.Size(180, 22);
            this.menustripitemOgretmenEkle.Text = "Öğretmen Ekle";
            this.menustripitemOgretmenEkle.Click += new System.EventHandler(this.menustripitemOgretmenEkle_Click);
            // 
            // menustripitemHakkinda
            // 
            this.menustripitemHakkinda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menustripitemHakkinda.ForeColor = System.Drawing.Color.Black;
            this.menustripitemHakkinda.Name = "menustripitemHakkinda";
            this.menustripitemHakkinda.Size = new System.Drawing.Size(69, 20);
            this.menustripitemHakkinda.Text = "Hakkında";
            this.menustripitemHakkinda.Click += new System.EventHandler(this.menustripitemHakkinda_Click);
            // 
            // txtEtutID
            // 
            this.txtEtutID.Enabled = false;
            this.txtEtutID.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEtutID.Location = new System.Drawing.Point(188, 70);
            this.txtEtutID.Name = "txtEtutID";
            this.txtEtutID.Size = new System.Drawing.Size(140, 24);
            this.txtEtutID.TabIndex = 17;
            // 
            // txtOgrID
            // 
            this.txtOgrID.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrID.Location = new System.Drawing.Point(188, 102);
            this.txtOgrID.Name = "txtOgrID";
            this.txtOgrID.Size = new System.Drawing.Size(140, 24);
            this.txtOgrID.TabIndex = 18;
            // 
            // rbtnEtutler
            // 
            this.rbtnEtutler.AutoSize = true;
            this.rbtnEtutler.Checked = true;
            this.rbtnEtutler.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnEtutler.Location = new System.Drawing.Point(33, 288);
            this.rbtnEtutler.Name = "rbtnEtutler";
            this.rbtnEtutler.Size = new System.Drawing.Size(67, 20);
            this.rbtnEtutler.TabIndex = 11;
            this.rbtnEtutler.TabStop = true;
            this.rbtnEtutler.Text = "Etütler";
            this.rbtnEtutler.UseVisualStyleBackColor = true;
            this.rbtnEtutler.CheckedChanged += new System.EventHandler(this.rbtnEtutler_CheckedChanged);
            // 
            // rbtnOgrenciler
            // 
            this.rbtnOgrenciler.AutoSize = true;
            this.rbtnOgrenciler.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnOgrenciler.Location = new System.Drawing.Point(126, 288);
            this.rbtnOgrenciler.Name = "rbtnOgrenciler";
            this.rbtnOgrenciler.Size = new System.Drawing.Size(92, 20);
            this.rbtnOgrenciler.TabIndex = 12;
            this.rbtnOgrenciler.Text = "Öğrenciler";
            this.rbtnOgrenciler.UseVisualStyleBackColor = true;
            this.rbtnOgrenciler.CheckedChanged += new System.EventHandler(this.rbtnOgrenciler_CheckedChanged);
            // 
            // rbtnOgretmenler
            // 
            this.rbtnOgretmenler.AutoSize = true;
            this.rbtnOgretmenler.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnOgretmenler.Location = new System.Drawing.Point(241, 288);
            this.rbtnOgretmenler.Name = "rbtnOgretmenler";
            this.rbtnOgretmenler.Size = new System.Drawing.Size(105, 20);
            this.rbtnOgretmenler.TabIndex = 13;
            this.rbtnOgretmenler.Text = "Öğretmenler";
            this.rbtnOgretmenler.UseVisualStyleBackColor = true;
            this.rbtnOgretmenler.CheckedChanged += new System.EventHandler(this.rbtnOgretmenler_CheckedChanged);
            // 
            // menustripitemDersEkle
            // 
            this.menustripitemDersEkle.Name = "menustripitemDersEkle";
            this.menustripitemDersEkle.Size = new System.Drawing.Size(180, 22);
            this.menustripitemDersEkle.Text = "Ders Ekle";
            this.menustripitemDersEkle.Click += new System.EventHandler(this.menustripitemDersEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(954, 701);
            this.Controls.Add(this.rbtnOgretmenler);
            this.Controls.Add(this.rbtnOgrenciler);
            this.Controls.Add(this.rbtnEtutler);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders - Etüt Sistemi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox msktxtSaat;
        private System.Windows.Forms.MaskedTextBox msktxtTarih;
        private System.Windows.Forms.ComboBox cmbOgretmenler;
        private System.Windows.Forms.ComboBox cmbDersler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEtutVer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menustripitemYeni;
        private System.Windows.Forms.ToolStripMenuItem menustripitemOgrenciEkle;
        private System.Windows.Forms.ToolStripMenuItem menustripitemOgretmenEkle;
        private System.Windows.Forms.ToolStripMenuItem menustripitemHakkinda;
        private System.Windows.Forms.TextBox txtOgrID;
        private System.Windows.Forms.TextBox txtEtutID;
        private System.Windows.Forms.RadioButton rbtnEtutler;
        private System.Windows.Forms.RadioButton rbtnOgrenciler;
        private System.Windows.Forms.RadioButton rbtnOgretmenler;
        private System.Windows.Forms.ToolStripMenuItem menustripitemDersEkle;
    }
}

