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
    public partial class OgrtEkleForm : Form
    {
        SqlConnection baglan = new SqlConnection(@"");

        public OgrtEkleForm()
        {
            InitializeComponent();
        }

        private void btnOgrtKaydet_Click(object sender, EventArgs e)
        {
            baglan.Close();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("insert into TBL_OGRETMEN (ADSOYAD,BRANSID,TELEFON,EMAIL) values (@PR1,@PR2,@PR3,@PR4)", baglan);
            cmd.Parameters.AddWithValue("@PR1", txtOgrtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@PR2", cmbOgrtDers.SelectedValue);
            cmd.Parameters.AddWithValue("@PR3", msktxtOgrtTelefon.Text);
            cmd.Parameters.AddWithValue("@PR4", txtOgrtEmail.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Öğretmen sisteme başarıyla kaydedilmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OgrtEkleForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_DERSLER", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbOgrtDers.ValueMember = "DERSID";
            cmbOgrtDers.DisplayMember = "DERSAD";
            cmbOgrtDers.DataSource = dt;
        }
    }
}
