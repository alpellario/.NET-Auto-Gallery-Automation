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
using System.IO;

namespace Oto_Galeri
{
    public partial class SaticiAracKayit : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=OtoGaleri; Integrated Security=true");
        string image_loc = "";
        
        public SaticiAracKayit()
        {
            InitializeComponent();
            gbArac.Enabled = false;
            gbSatici.Enabled = false;
            gbTeslim.Enabled = false;
            cbDurum.SelectedIndex = 0;
            
        }

        private void yeniSatici_CheckedChanged(object sender, EventArgs e)
        {
            if (yeniSatici.Checked)
            {
                gbSatici.Enabled = true;
                gbArac.Enabled = false;
                tbTc.Clear(); tbAd.Clear(); tbSoyad.Clear(); tbTelefon.Clear(); tbAdres.Clear();
            }
            else gbSatici.Enabled = false;
        }
        int kayitli_tutulan = 0;
        string ktc = "", kad = "", ksoyad = "", ktelefon = "", kadres = "";
        private void kayitliSatici_CheckedChanged(object sender, EventArgs e)
        {

            if (kayitliSatici.Checked)
            {

                Saticilar satici_secim = new Saticilar()
                {
                    kayitli_satici_id = kayitli_tutulan,
                    tc = ktc,
                    ad = kad,
                    soyad = ksoyad,
                    telefon = ktelefon,
                    adres = kadres
                };
                satici_secim.ShowDialog();
                kayitli_tutulan = satici_secim.kayitli_satici_id;
                tbTc.Text = satici_secim.tc;
                tbAd.Text = satici_secim.ad;
                tbSoyad.Text = satici_secim.soyad;
                tbTelefon.Text = satici_secim.telefon;
                tbAdres.Text = satici_secim.adres;
                if (satici_secim.ad != "")
                {
                    gbArac.Enabled = true;
                    if (satici_secim.tc == "") cbYabanci.Checked = true;
                }



            }
        }

        private void btAracKaydet_Click(object sender, EventArgs e)
        {
            if (tbMarka.Text != "" && tbModel.Text != "" && tbYil.Text != "" && tbPlaka.Text != "" && tbRenk.Text != "")
            {
                gbArac.Enabled = false;
                gbTeslim.Enabled = true;
            }
            else MessageBox.Show("Araç bilgileri boş bırakılamaz.", "Hata");

        }

        private void btSatinAl_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show(tbTutar.Text + "₺. Onaylıyor musunuz ?", "ONAY", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (yeniSatici.Checked)
                {

                    if (tbTutar.Text != "")
                    {
                        string kaynak = dosyaYolu;
                        string hedef = Application.StartupPath + @"\pictures\";
                        string yeniad = Guid.NewGuid() + ".jpg"; //Benzersiz isim verme
                        File.Copy(kaynak, hedef + yeniad);

                        int satici_id;
                        int arac_id;

                        if (conn.State == ConnectionState.Closed) conn.Open();
                        SqlCommand satici_kaydet = new SqlCommand();
                        satici_kaydet.Connection = conn;
                        satici_kaydet.CommandText = "INSERT INTO Satici(satici_ad,satici_soyad,satici_telefon,satici_adres,satici_tc) VALUES(@satici_ad,@satici_soyad,@satici_telefon,@satici_adres,@satici_tc) SET @satici_id = SCOPE_IDENTITY()";
                        satici_kaydet.Parameters.AddWithValue("@satici_ad", tbAd.Text);
                        satici_kaydet.Parameters.AddWithValue("@satici_soyad", tbSoyad.Text);
                        satici_kaydet.Parameters.AddWithValue("@satici_telefon", tbTelefon.Text);
                        satici_kaydet.Parameters.AddWithValue("@satici_adres", tbAdres.Text);
                        satici_kaydet.Parameters.AddWithValue("@satici_tc", tbTc.Text);
                        satici_kaydet.Parameters.Add("@satici_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                        satici_kaydet.ExecuteNonQuery();
                        satici_id = Convert.ToInt32(satici_kaydet.Parameters["@satici_id"].Value);


                        SqlCommand arac_kaydet = new SqlCommand();
                        arac_kaydet.Connection = conn;
                        arac_kaydet.CommandText = "INSERT INTO Arac(arac_plaka,arac_marka,arac_model,arac_yil,arac_renk,arac_durum,arac_bilgi,arac_resim) VALUES(@arac_plaka,@arac_marka,@arac_model,@arac_yil,@arac_renk,@arac_durum,@arac_bilgi,@arac_resim) SET @arac_id = SCOPE_IDENTITY()";
                        arac_kaydet.Parameters.AddWithValue("@arac_plaka", tbPlaka.Text);
                        arac_kaydet.Parameters.AddWithValue("@arac_marka", tbMarka.Text);
                        arac_kaydet.Parameters.AddWithValue("@arac_model", tbModel.Text);
                        arac_kaydet.Parameters.AddWithValue("@arac_yil", tbYil.Text);
                        arac_kaydet.Parameters.AddWithValue("@arac_renk", tbRenk.Text);
                        arac_kaydet.Parameters.AddWithValue("@arac_durum", cbDurum.Text);
                        arac_kaydet.Parameters.AddWithValue("@arac_bilgi", tbBilgi.Text);
                        arac_kaydet.Parameters.AddWithValue("@arac_resim", yeniad);
                        arac_kaydet.Parameters.Add("@arac_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                        arac_kaydet.ExecuteNonQuery();
                        arac_id = Convert.ToInt32(arac_kaydet.Parameters["@arac_id"].Value);


                        SqlCommand arac_tutar = new SqlCommand();
                        arac_tutar.Connection = conn;
                        arac_tutar.CommandText = "INSERT INTO AlisFiyat(arac_id,alis_tutar) VALUES(@arac_id,@alis_tutar)";
                        arac_tutar.Parameters.AddWithValue("@arac_id", arac_id);
                        arac_tutar.Parameters.AddWithValue("@alis_tutar", tbTutar.Text);
                        arac_tutar.ExecuteNonQuery();

                        SqlCommand arac_alis = new SqlCommand();
                        arac_alis.Connection = conn;
                        arac_alis.CommandText = "INSERT INTO AracAlis(satici_id,arac_id,alis_tarih) VALUES(@satici_id,@arac_id,@alis_tarih)";
                        arac_alis.Parameters.AddWithValue("@satici_id", satici_id);
                        arac_alis.Parameters.AddWithValue("@arac_id", arac_id);
                        arac_alis.Parameters.AddWithValue("@alis_tarih", DateTime.Now.ToShortDateString());
                        arac_alis.ExecuteNonQuery();

                        SqlCommand arac_depo = new SqlCommand();
                        arac_depo.Connection = conn;
                        arac_depo.CommandText = "INSERT INTO AracDepo(arac_id,depo_durum) VALUES(@arac_id,@depo_durum)";
                        arac_depo.Parameters.AddWithValue("@arac_id", arac_id);
                        arac_depo.Parameters.AddWithValue("@depo_durum", 1);
                        arac_depo.ExecuteNonQuery();

                        conn.Close();
                        MessageBox.Show("Araç alış kaydı yapıldı.", "Bilgilendirme");
                        this.Close();
                    }
                    else MessageBox.Show("Tutar Giriniz", "Hata");
                }
                else if (kayitliSatici.Checked)
                {
                    if (tbTutar.Text != "")
                    {
                        string kaynak = dosyaYolu;
                        string hedef = Application.StartupPath + @"\pictures\";
                        string yeniad = Guid.NewGuid() + ".jpg"; //Benzersiz isim verme
                        File.Copy(kaynak, hedef + yeniad);


                        int arac_id;

                        if (conn.State == ConnectionState.Closed) conn.Open();

                        SqlCommand arac_kaydet = new SqlCommand();
                        arac_kaydet.Connection = conn;
                        arac_kaydet.CommandText = "INSERT INTO Arac(arac_plaka,arac_marka,arac_model,arac_yil,arac_renk,arac_durum,arac_bilgi,arac_resim) VALUES(@arac_plaka,@arac_marka,@arac_model,@arac_yil,@arac_renk,@arac_durum,@arac_bilgi,@arac_resim) SET @arac_id = SCOPE_IDENTITY()";
                        arac_kaydet.Parameters.AddWithValue("@arac_plaka", tbPlaka.Text);
                        arac_kaydet.Parameters.AddWithValue("@arac_marka", tbMarka.Text);
                        arac_kaydet.Parameters.AddWithValue("@arac_model", tbModel.Text);
                        arac_kaydet.Parameters.AddWithValue("@arac_yil", tbYil.Text);
                        arac_kaydet.Parameters.AddWithValue("@arac_renk", tbRenk.Text);
                        arac_kaydet.Parameters.AddWithValue("@arac_durum", cbDurum.Text);
                        arac_kaydet.Parameters.AddWithValue("@arac_bilgi", tbBilgi.Text);
                        arac_kaydet.Parameters.Add("@arac_id", SqlDbType.Int).Direction = ParameterDirection.Output;                                              
                        arac_kaydet.Parameters.AddWithValue("@arac_resim", yeniad);
                        arac_id = Convert.ToInt32(arac_kaydet.Parameters["@arac_id"].Value);
                        arac_kaydet.ExecuteNonQuery();
                        arac_id = Convert.ToInt32(arac_kaydet.Parameters["@arac_id"].Value);


                        SqlCommand arac_tutar = new SqlCommand();
                        arac_tutar.Connection = conn;
                        arac_tutar.CommandText = "INSERT INTO AlisFiyat(arac_id,alis_tutar) VALUES(@arac_id,@alis_tutar)";
                        arac_tutar.Parameters.AddWithValue("@arac_id", arac_id);
                        arac_tutar.Parameters.AddWithValue("@alis_tutar", tbTutar.Text);
                        arac_tutar.ExecuteNonQuery();

                        SqlCommand arac_alis = new SqlCommand();
                        arac_alis.Connection = conn;
                        arac_alis.CommandText = "INSERT INTO AracAlis(satici_id,arac_id,alis_tarih) VALUES(@satici_id,@arac_id,@alis_tarih)";
                        arac_alis.Parameters.AddWithValue("@satici_id", kayitli_tutulan);
                        arac_alis.Parameters.AddWithValue("@arac_id", arac_id);
                        arac_alis.Parameters.AddWithValue("@alis_tarih", DateTime.Now.ToShortDateString());
                        arac_alis.ExecuteNonQuery();

                        SqlCommand arac_depo = new SqlCommand();
                        arac_depo.Connection = conn;
                        arac_depo.CommandText = "INSERT INTO AracDepo(arac_id,depo_durum) VALUES(@arac_id,@depo_durum)";
                        arac_depo.Parameters.AddWithValue("@arac_id", arac_id);
                        arac_depo.Parameters.AddWithValue("@depo_durum", 1);
                        arac_depo.ExecuteNonQuery();


                        conn.Close();
                        MessageBox.Show("Araç alış kaydı yapıldı.","Bilgilendirme");
                        this.Close();
                    }
                    else MessageBox.Show("Tutar Giriniz", "Hata");
                }
            }
            else MessageBox.Show("İptal Edildi","Bilgilendirme");

            


        }

        private void btSaticiKaydet_Click(object sender, EventArgs e)
        {
            if (tbAd.Text != "" && tbTelefon.Text != "" && tbAdres.Text != "")
            {
                if (cbYabanci.Checked || tbTc.Text.ToString().Length == 11)
                {
                    yeniSatici.Enabled = kayitliSatici.Enabled = false;
                    gbSatici.Enabled = false;
                    gbArac.Enabled = true;
                }
                else MessageBox.Show("Satici Uyruğu veya Tc'sini belirleyiniz.");

            }
            else MessageBox.Show("Ad, telefon ve adres bilgileri boş bırakılamaz.", "Hata");

        }

        private void SaticiAracKayit_Load(object sender, EventArgs e)
        {

        }

        private void cbYabanci_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYabanci.Checked)
            {
                tbTc.Enabled = false;
                tbTc.Text = null;
            }
            else
            {
                tbTc.Enabled = true;
                tbTc.Text = null;
            }
        }

        private void tbTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);
        }

        private void tbSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);
        }

        private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbYil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        string dosyaYolu;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\pictures\\";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            dosyaYolu = openFileDialog1.FileName;
            pictureBox1.ImageLocation = dosyaYolu;

        }


    }
}
