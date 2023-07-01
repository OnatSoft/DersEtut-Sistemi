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
    public partial class DersEkleForm : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-ONATSOFT\ONATSOFT;Initial Catalog=EtutSistemiDB;Integrated Security=True");

        public DersEkleForm()
        {
            InitializeComponent();
        }

        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            baglan.Close();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("insert into TBL_DERSLER (DERSAD) values (@PR1)", baglan);
            cmd.Parameters.AddWithValue("@PR1", txtDersAD.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Sisteme yeni Ders başarıyla eklenmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDersAD.Clear();
        }
    }
}
