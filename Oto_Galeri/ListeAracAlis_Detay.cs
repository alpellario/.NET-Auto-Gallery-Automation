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
    public partial class ListeAracAlis_Detay : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=OtoGaleri;Integrated Security=true");

        public int oncekiForm_alis_id;
        public ListeAracAlis_Detay()
        {
            InitializeComponent();
        }
        void temizle()
        {
            lbMarka.Text = ""; lbModel.Text = ""; lbYil.Text = ""; lbRenk.Text = ""; lbDurum.Text = ""; lbBilgi.Text = "";
            lbTc.Text = ""; lbAd.Text = ""; lbSoyad.Text = ""; lbTel.Text = ""; lbAd.Text = "";
            lbIDsatis.Text = ""; lbIDmusteri.Text = ""; lbIDarac.Text = ""; lbTutar.Text = ""; lbTarih.Text = "";

        }

        private void ListeAracAlis_Detay_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand detay = new SqlCommand();
            detay.Connection = conn;
            detay.CommandText = "SELECT AR.arac_id,arac_marka,arac_model,arac_yil,arac_renk,arac_durum,arac_bilgi,arac_resim," +
                "S.satici_id,satici_tc,satici_ad,satici_soyad,satici_telefon,satici_adres," +
                "alis_id,alis_tarih,FORMAT(alis_tutar,'N','tr-TR') AS a_tutar " +
                "FROM AracAlis AL INNER JOIN Satici S ON AL.satici_id=S.satici_id " +
                                   "INNER JOIN Arac AR ON AL.arac_id=AR.arac_id " +
                                   "INNER JOIN AlisFiyat AF ON AL.arac_id=AF.arac_id WHERE AL.alis_id=@alis_id";
            detay.Parameters.AddWithValue("@alis_id", oncekiForm_alis_id);
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

                lbTc.Text = dr["satici_tc"].ToString();
                lbAd.Text = dr["satici_ad"].ToString();
                lbSoyad.Text = dr["satici_soyad"].ToString();
                lbTel.Text = dr["satici_telefon"].ToString();
                lbAdres.Text = dr["satici_adres"].ToString();

                lbIDsatis.Text = dr["alis_id"].ToString();
                lbIDmusteri.Text = dr["satici_id"].ToString();
                lbIDarac.Text = dr["arac_id"].ToString();
                lbTarih.Text = dr["alis_tarih"].ToString();
                lbTutar.Text = dr["a_tutar"].ToString() + " ₺";

            }
            dr.Close();
            conn.Close();
        }
    }
}
