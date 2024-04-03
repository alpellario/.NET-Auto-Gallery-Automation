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
    public partial class AracSatis : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=OtoGaleri; Integrated Security=true");
        public int temp_arac_id;
        int kayitli_musteri_id;
        int donen_musteri_id;
        
        public AracSatis()
        {
            InitializeComponent();
            gbSatis.Enabled = false;
            

        }
        private void AracSatis_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand arac_bilgi = new SqlCommand();
            arac_bilgi.Connection = conn;
            arac_bilgi.CommandText = "SELECT arac_marka, arac_model, arac_yil, arac_plaka, arac_renk, arac_durum, arac_bilgi, arac_resim" +
                " FROM Arac WHERE arac_id=@arac_id";
            arac_bilgi.Parameters.AddWithValue("@arac_id", temp_arac_id);
            SqlDataReader dr = arac_bilgi.ExecuteReader();
            while (dr.Read())
            {
                tbMarka.Text = dr["arac_marka"].ToString();
                tbModel.Text = dr["arac_model"].ToString();
                tbYil.Text = dr["arac_yil"].ToString();
                tbPlaka.Text = dr["arac_plaka"].ToString();
                tbRenk.Text = dr["arac_renk"].ToString();
                tbDurum.Text = dr["arac_durum"].ToString();
                tbBilgi.Text = dr["arac_bilgi"].ToString();
                string imageName = dr["arac_resim"].ToString();
                string imagePath = Application.StartupPath + "\\pictures\\" + imageName;
                pictureBox1.ImageLocation = imagePath;
            }
            dr.Close();
            conn.Close();
            this.ActiveControl = tbMtc;
            yeniMusteri.Checked = true;

        }

        private void btMusteriKaydet_Click(object sender, EventArgs e)
        {
            if(tbMad.Text != "" && tbMsoyad.Text != "" && tbMtel.Text != "" && tbMadres.Text != "")
            {
                if(tbMtc.Text.Length ==11 || cbYabanci.Checked)
                {
                    gbMusteri.Enabled = false;
                    gbSatis.Enabled = true;
                }
                else { MessageBox.Show("Uyruk bilgilerini giriniz"); }
            }
            else { MessageBox.Show("Müşteri bilgileri boş bırakılamaz!", "Hata"); }           
        }

        private void btSat_Click(object sender, EventArgs e)
        {
            if (tbTutar.Text != "")
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show(tbTutar.Text + "₺. Onaylıyor musunuz ?", "ONAY", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (yeniMusteri.Checked)
                    {
                        if (conn.State == ConnectionState.Closed) conn.Open();
                        SqlCommand musteri_kaydet = new SqlCommand();
                        musteri_kaydet.Connection = conn;
                        musteri_kaydet.CommandText = "INSERT INTO Musteri(musteri_tc, musteri_ad, musteri_soyad, musteri_telefon, musteri_adres)" +
                            " VALUES(@musteri_tc, @musteri_ad, @musteri_soyad, @musteri_telefon, @musteri_adres) SET @musteri_id= SCOPE_IDENTITY()";
                        musteri_kaydet.Parameters.AddWithValue("@musteri_tc", tbMtc.Text);
                        musteri_kaydet.Parameters.AddWithValue("@musteri_ad", tbMad.Text);
                        musteri_kaydet.Parameters.AddWithValue("@musteri_soyad", tbMsoyad.Text);
                        musteri_kaydet.Parameters.AddWithValue("@musteri_telefon", tbMtel.Text);
                        musteri_kaydet.Parameters.AddWithValue("@musteri_adres", tbMadres.Text);
                        musteri_kaydet.Parameters.Add("@musteri_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                        musteri_kaydet.ExecuteNonQuery();
                        donen_musteri_id = Convert.ToInt32(musteri_kaydet.Parameters["@musteri_id"].Value);

                        SqlCommand satis_kaydet = new SqlCommand();
                        satis_kaydet.Connection = conn;
                        satis_kaydet.CommandText = "INSERT INTO AracSatis(musteri_id, arac_id, satis_tutar, satis_tarih) VALUES(@musteri_id, @arac_id, @satis_tutar, @satis_tarih)";
                        satis_kaydet.Parameters.AddWithValue("@musteri_id", donen_musteri_id);
                        satis_kaydet.Parameters.AddWithValue("@arac_id", temp_arac_id);
                        satis_kaydet.Parameters.AddWithValue("@satis_tutar", tbTutar.Text);
                        satis_kaydet.Parameters.AddWithValue("@satis_tarih", DateTime.Now.ToShortDateString());                        
                        satis_kaydet.ExecuteNonQuery();


                        SqlCommand depodan_sil = new SqlCommand();
                        depodan_sil.Connection = conn;
                        depodan_sil.CommandText = "DELETE FROM AracDepo WHERE arac_id=@arac_id";
                        depodan_sil.Parameters.AddWithValue("@arac_id", temp_arac_id);
                        depodan_sil.ExecuteNonQuery();

                        SqlCommand satisFiyat_sil = new SqlCommand();
                        satisFiyat_sil.Connection = conn;
                        satisFiyat_sil.CommandText = "DELETE FROM SatisFiyat WHERE arac_id=@arac_id";
                        satisFiyat_sil.Parameters.AddWithValue("@arac_id", temp_arac_id);
                        satisFiyat_sil.ExecuteNonQuery();

                        SqlCommand del_galeri = new SqlCommand();
                        del_galeri.Connection = conn;
                        del_galeri.CommandText = "DELETE FROM Galeri WHERE arac_id=@arac_id";
                        del_galeri.Parameters.AddWithValue("@arac_id", temp_arac_id);
                        del_galeri.ExecuteNonQuery();

                        conn.Close();
                        MessageBox.Show("Satış Kaydı Yapıldı","Bilgilendirme");
                        this.Close();
                    }
                    else if (kayitliMusteri.Checked)
                    {
                        if (conn.State == ConnectionState.Closed) conn.Open();
                        SqlCommand satis_kaydet = new SqlCommand();
                        satis_kaydet.Connection = conn;
                        satis_kaydet.CommandText = "INSERT INTO AracSatis(musteri_id, arac_id, satis_tutar, satis_tarih) VALUES(@musteri_id, @arac_id, @satis_tutar, @satis_tarih)";
                        satis_kaydet.Parameters.AddWithValue("@musteri_id", kayitli_musteri_id);
                        satis_kaydet.Parameters.AddWithValue("@arac_id", temp_arac_id);
                        satis_kaydet.Parameters.AddWithValue("@satis_tutar", tbTutar.Text);
                        satis_kaydet.Parameters.AddWithValue("@satis_tarih", DateTime.Now.ToShortDateString());
                        satis_kaydet.ExecuteNonQuery();


                        SqlCommand depodan_sil = new SqlCommand();
                        depodan_sil.Connection = conn;
                        depodan_sil.CommandText = "DELETE FROM AracDepo WHERE arac_id=@arac_id";
                        depodan_sil.Parameters.AddWithValue("@arac_id", temp_arac_id);
                        depodan_sil.ExecuteNonQuery();

                        SqlCommand satisFiyat_sil = new SqlCommand();
                        satisFiyat_sil.Connection = conn;
                        satisFiyat_sil.CommandText = "DELETE FROM SatisFiyat WHERE arac_id=@arac_id";
                        satisFiyat_sil.Parameters.AddWithValue("@arac_id", temp_arac_id);
                        satisFiyat_sil.ExecuteNonQuery();

                        SqlCommand del_galeri = new SqlCommand();
                        del_galeri.Connection = conn;
                        del_galeri.CommandText = "DELETE FROM Galeri WHERE arac_id=@arac_id";
                        del_galeri.Parameters.AddWithValue("@arac_id", temp_arac_id);
                        del_galeri.ExecuteNonQuery();

                        conn.Close();
                        MessageBox.Show("Satış Kaydı Yapıldı", "Bilgilendirme");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Satış Kaydı İptal Edildi", "Bilgilendirme");
                    
                }
                
                
            }
            
        }

        private void cbYabanci_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYabanci.Checked)
            {
                tbMtc.Enabled = false;
                tbMtc.Clear();
            }
            else
            {
                tbMtc.Enabled = true;
            }
        }

        private void kayitliMusteri_CheckedChanged(object sender, EventArgs e)
        {
            if (kayitliMusteri.Checked)
            {
                gbMusteri.Enabled = false;
                tbMad.Clear(); tbMtc.Clear(); tbMsoyad.Clear(); tbMtel.Clear(); tbMadres.Clear(); cbYabanci.Checked = false;
                Musteriler musteri = new Musteriler();
                musteri.ShowDialog();
                kayitli_musteri_id = musteri.kayitli_musteri_id;
                tbMtc.Text = musteri.tc;
                tbMad.Text = musteri.ad;
                tbMsoyad.Text = musteri.soyad;
                tbMtel.Text = musteri.telefon;
                tbMadres.Text = musteri.adres;
                if (tbMad.Text != "")
                {
                    gbSatis.Enabled = true;
                }
                
            }
        }

        private void yeniMusteri_CheckedChanged(object sender, EventArgs e)
        {
            if (yeniMusteri.Checked)
            {
                gbMusteri.Enabled = true;
                gbSatis.Enabled = false;
                tbMad.Clear(); tbMtc.Clear(); tbMsoyad.Clear(); tbMtel.Clear(); tbMadres.Clear(); cbYabanci.Checked = false;

            }
        }

        private void tbTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbMtc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbMtel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbMad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);
        }

        private void tbMsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);
        }
    }
}
