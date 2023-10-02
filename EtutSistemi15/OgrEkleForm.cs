using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace EtutSistemi15
{
    public partial class OgrEkleForm : Form
    {
        SqlConnection baglan = new SqlConnection(@"");

        public OgrEkleForm()
        {
            InitializeComponent();
        }

        private void btnFotografSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pbFotograf.ImageLocation = openFileDialog1.FileName;
        }

        private void btnOgrKaydet_Click(object sender, EventArgs e)
        {
            baglan.Close();
            baglan.Open();
            SqlCommand cmd1 = new SqlCommand("insert into TBL_OGRENCI (ADSOYAD,SINIF,FOTOGRAF,TELEFON) values (@P1,@P2,@P3,@P4)", baglan);
            cmd1.Parameters.AddWithValue("@P1", txtAdSoyad.Text);
            cmd1.Parameters.AddWithValue("@P2", txtSinif.Text);
            cmd1.Parameters.AddWithValue("@P3", pbFotograf.ImageLocation);
            cmd1.Parameters.AddWithValue("@P4", msktxtTelefon.Text);
            cmd1.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Öğrenci sisteme başarıyla kaydedilmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
