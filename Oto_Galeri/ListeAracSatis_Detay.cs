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

namespace Oto_Galeri
{
    public partial class ListeAracSatis_Detay : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=OtoGaleri;Integrated Security=true");

        public int oncekiForm_satis_id;
        public ListeAracSatis_Detay()
        {
            InitializeComponent();
        }
        void temizle()
        {
            lbMarka.Text = ""; lbModel.Text = ""; lbYil.Text = "";lbRenk.Text = "";lbDurum.Text = "";lbBilgi.Text = "";
            lbTc.Text = "";lbAd.Text = "";lbSoyad.Text = "";lbTel.Text = "";lbAd.Text = "";
            lbIDsatis.Text = "";lbIDmusteri.Text = "";lbIDarac.Text = ""; lbTutar.Text=""; lbTarih.Text = "";

        }

        private void ListeAracSatis_Detay_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand detay = new SqlCommand();
            detay.Connection = conn;
            detay.CommandText = "SELECT AR.arac_id,arac_marka,arac_model,arac_yil,arac_renk,arac_durum,arac_bilgi,arac_resim," +
                "M.musteri_id,musteri_tc,musteri_ad,musteri_soyad,musteri_telefon,musteri_adres," +
                "satis_id,satis_tarih,FORMAT(satis_tutar,'N','tr-TR') AS s_tutar " +
                "FROM AracSatis ARS INNER JOIN Musteri M ON ARS.musteri_id=M.musteri_id " +
                                   "INNER JOIN Arac AR ON ARS.arac_id=AR.arac_id WHERE ARS.satis_id=@satis_id";
            detay.Parameters.AddWithValue("@satis_id", oncekiForm_satis_id);
            SqlDataReader dr = detay.ExecuteReader();

            while (dr.Read())
            {
                lbMarka.Text = dr["arac_marka"].ToString();
                lbModel.Text = dr["arac_model"].ToString();
                lbYil.Text = dr["arac_yil"].ToString();
                lbDurum.Text = dr["arac_durum"].ToString();
                lbBilgi.Text = dr["arac_bilgi"].ToString();
                lbRenk.Text = dr["arac_renk"].ToString();
                string imageName = dr["arac_resim"].ToString();
                string imagePath = Application.StartupPath + "\\pictures\\" + imageName;
                pictureBox1.ImageLocation = imagePath;

                lbTc.Text = dr["musteri_tc"].ToString();
                lbAd.Text = dr["musteri_ad"].ToString();
                lbSoyad.Text = dr["musteri_soyad"].ToString();
                lbTel.Text = dr["musteri_telefon"].ToString();
                lbAdres.Text = dr["musteri_adres"].ToString();

                lbIDsatis.Text = dr["satis_id"].ToString();
                lbIDmusteri.Text = dr["musteri_id"].ToString();
                lbIDarac.Text = dr["arac_id"].ToString();
                lbTarih.Text = dr["satis_tarih"].ToString();
                lbTutar.Text = dr["s_tutar"].ToString() + " ₺";

            }
            dr.Close();
            conn.Close();
        }
    }
}
