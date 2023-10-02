using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EtutSistemi15
{
    public partial class Form1 : Form
    {
        SqlConnection baglan = new SqlConnection(@"");
        public Form1()
        {
            InitializeComponent();
        }

        private void dersListesi()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select * from TBL_DERSLER", baglan);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cmbDersler.ValueMember = "DERSID";
            cmbDersler.DisplayMember = "DERSAD";
            cmbDersler.DataSource = dt1;
        }

        private void etutListesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("execute etutTablo", baglan);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        private void ogrenciListesi()
        {
            SqlDataAdapter da4 = new SqlDataAdapter("select * from TBL_OGRENCI", baglan);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            dataGridView1.DataSource = dt4;
        }

        private void ogretmenListesi()
        {
            SqlDataAdapter da5 = new SqlDataAdapter("execute ogretmenTablo", baglan);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            dataGridView1.DataSource = dt5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dersListesi();
            etutListesi();
        }

        private void cmbDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select * from TBL_OGRETMEN where BRANSID=" + cmbDersler.SelectedValue, baglan);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbOgretmenler.ValueMember = "OGRTID";
            cmbOgretmenler.DisplayMember = "ADSOYAD";
            cmbOgretmenler.DataSource = dt2;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglan.Close();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("insert into TBL_ETUT (DERSID,OGRETMENID,TARİH,SAAT) values (@pr1,@pr2,@pr3,@pr4)", baglan);
            cmd.Parameters.AddWithValue("@pr1", cmbDersler.SelectedValue);
            cmd.Parameters.AddWithValue("@pr2", cmbOgretmenler.SelectedValue);
            cmd.Parameters.AddWithValue("@pr3", msktxtTarih.Text);
            cmd.Parameters.AddWithValue("@pr4", msktxtSaat.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Etüt kaydı başarıyla oluşturuldu.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            msktxtTarih.Clear();
            msktxtSaat.Clear();
            baglan.Close();
            etutListesi();
        }

        private void menustripitemHakkinda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("iletişim ve Destek için: www.osomerr.cf ya da onat.somer2018@gmail.com\nMade BY EchoSoft - 2023\nSürüm: 1.0", "HAKKINDA");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rbtnEtutler.Checked == true)
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                txtEtutID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            }
            else
            {
                txtEtutID.Clear();
            }
        }

        private void btnEtutVer_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd2 = new SqlCommand("update TBL_ETUT set OGRENCIID=@p1, DURUM=@p2 where ID=@p3", baglan);
            cmd2.Parameters.AddWithValue("@p1", txtOgrID.Text);
            cmd2.Parameters.AddWithValue("@p2", "True");
            cmd2.Parameters.AddWithValue("@p3", txtEtutID.Text);
            cmd2.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Belirtilen öğrenciye seçili olan etüt atanmıştır.", "İŞLEM BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtOgrID.Clear();
            etutListesi();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult mesaj;
            mesaj = MessageBox.Show("Sistemden çıkış yapmak istiyor musunuz?", "GÜVENLİ ÇIKIŞ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (mesaj == DialogResult.OK)
            {
                Environment.Exit(0);
            }
            else if (mesaj == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void rbtnEtutler_CheckedChanged(object sender, EventArgs e)
        {
            etutListesi();
        }

        private void rbtnOgrenciler_CheckedChanged(object sender, EventArgs e)
        {
            ogrenciListesi();
        }

        private void rbtnOgretmenler_CheckedChanged(object sender, EventArgs e)
        {
            ogretmenListesi();
        }

        private void menustripitemOgrenciEkle_Click(object sender, EventArgs e)
        {
            OgrEkleForm frm2 = new OgrEkleForm();
            frm2.Show();
        }

        private void menustripitemOgretmenEkle_Click(object sender, EventArgs e)
        {
            OgrtEkleForm frm3 = new OgrtEkleForm();
            frm3.Show();
        }

        private void menustripitemDersEkle_Click(object sender, EventArgs e)
        {
            DersEkleForm frm4 = new DersEkleForm();
            frm4.Show();
        }
    }
}
