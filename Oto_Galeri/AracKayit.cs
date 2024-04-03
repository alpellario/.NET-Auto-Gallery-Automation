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
    public partial class AracKayit : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=OtoGaleri; Integrated Security=true");
        string image_loc = "";
        public bool guncelleme_mi = false;
        public int oncekiForm_arac_id;
        public AracKayit()
        {
            InitializeComponent();
            cbDurum.SelectedIndex = 0;

        }
        private void AracKayit_Load(object sender, EventArgs e)
        {
            if (guncelleme_mi == true)
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                SqlCommand arac_bilgi = new SqlCommand();
                arac_bilgi.Connection = conn;
                arac_bilgi.CommandText = "SELECT arac_marka,arac_model,arac_yil,arac_plaka,arac_renk,arac_durum,arac_bilgi" +
                    ",arac_resim FROM ARAC WHERE arac_id=@arac_id";
                arac_bilgi.Parameters.AddWithValue("@arac_id", oncekiForm_arac_id);
                SqlDataReader dr = arac_bilgi.ExecuteReader();

                while (dr.Read())
                {
                    tbMarka.Text = dr["arac_marka"].ToString();
                    tbModel.Text = dr["arac_model"].ToString();
                    tbYil.Text = dr["arac_yil"].ToString();
                    tbPlaka.Text = dr["arac_plaka"].ToString();
                    tbRenk.Text = dr["arac_renk"].ToString();
                    cbDurum.Text = dr["arac_durum"].ToString();
                    tbBilgi.Text = dr["arac_bilgi"].ToString();
                    string imageName = dr["arac_resim"].ToString();
                    string imagePath = Application.StartupPath + "\\pictures\\" + imageName;
                    pictureBox1.ImageLocation = imagePath;
                }
                btAracKaydet.Text = "ARAÇ GÜNCELLE";
                dr.Close();
                conn.Close();
            }
        }

        private void btAracKaydet_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            if (guncelleme_mi == false)
            {
                if (tbMarka.Text != "" && tbModel.Text != "" && tbYil.Text != "" && tbRenk.Text != "")
                {
                    dialog = MessageBox.Show("Araç kaydedilecek. Onaylıyor musunuz ?", "ONAY", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        string kaynak = image_loc;
                        string hedef = Application.StartupPath + @"\pictures\";
                        string yeniad = Guid.NewGuid() + ".jpg"; //benzersiz isim verme
                        string dosyaAdi = yeniad;
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
                        arac_kaydet.Parameters.AddWithValue("@arac_resim", dosyaAdi);
                        arac_kaydet.Parameters.Add("@arac_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                        arac_kaydet.ExecuteNonQuery();
                        arac_id = Convert.ToInt32(arac_kaydet.Parameters["@arac_id"].Value);

                        SqlCommand arac_depo = new SqlCommand();
                        arac_depo.Connection = conn;
                        arac_depo.CommandText = "INSERT INTO AracDepo(arac_id,depo_durum) VALUES(@arac_id,@depo_durum)";
                        arac_depo.Parameters.AddWithValue("@arac_id", arac_id);
                        arac_depo.Parameters.AddWithValue("@depo_durum", 1);
                        arac_depo.ExecuteNonQuery();

                        SqlCommand arac_tutar = new SqlCommand();
                        arac_tutar.Connection = conn;
                        arac_tutar.CommandText = "INSERT INTO AlisFiyat(arac_id,alis_tutar) VALUES(@arac_id,@alis_tutar)";
                        arac_tutar.Parameters.AddWithValue("@arac_id", arac_id);
                        arac_tutar.Parameters.AddWithValue("@alis_tutar", 0);
                        arac_tutar.ExecuteNonQuery();

                        conn.Close();
                        MessageBox.Show("Araç Kaydı Yapıldı.", "Bilgiledirme");
                        this.Close();
                    }
                    else MessageBox.Show("Kayıt iptal edildi", "Bilgilendirme");

                }
                else MessageBox.Show("Araç bilgileri boş bırakılamaz.", "Hata");
            }
            else if (guncelleme_mi == true)
            {
                if (tbMarka.Text != "" && tbModel.Text != "" && tbYil.Text != "" && tbRenk.Text != "")
                {
                    dialog = MessageBox.Show("Araç kaydedilecek. Onaylıyor musunuz ?", "ONAY", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        string kaynak = pictureBox1.ImageLocation;
                        string hedef = Application.StartupPath + @"\pictures\";
                        string yeniad = Guid.NewGuid() + ".jpg"; //benzersiz isim verme
                        string dosyaAdi = yeniad;
                        File.Copy(kaynak, hedef + yeniad);

                        if (conn.State == ConnectionState.Closed) conn.Open();
                        SqlCommand arac_guncelle = new SqlCommand();
                        arac_guncelle.Connection = conn;
                        arac_guncelle.CommandText = "UPDATE Arac SET arac_plaka=@arac_plaka, arac_marka=@arac_marka, arac_model=@arac_model,arac_yil=@arac_yil," +
                            "arac_renk=@arac_renk, arac_durum=@arac_durum, arac_bilgi=@arac_bilgi, arac_resim=@arac_resim WHERE arac_id=@arac_id";
                        arac_guncelle.Parameters.AddWithValue("@arac_plaka", tbPlaka.Text);
                        arac_guncelle.Parameters.AddWithValue("@arac_marka", tbMarka.Text);
                        arac_guncelle.Parameters.AddWithValue("@arac_model", tbModel.Text);
                        arac_guncelle.Parameters.AddWithValue("@arac_yil", tbYil.Text);
                        arac_guncelle.Parameters.AddWithValue("@arac_renk", tbRenk.Text);
                        arac_guncelle.Parameters.AddWithValue("@arac_durum", cbDurum.Text);
                        arac_guncelle.Parameters.AddWithValue("@arac_bilgi", tbBilgi.Text);
                        arac_guncelle.Parameters.AddWithValue("@arac_resim", dosyaAdi);
                        arac_guncelle.Parameters.AddWithValue("@arac_id", oncekiForm_arac_id);
                        arac_guncelle.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Araç Kaydı Güncellendi", "Bilgilendirme");
                        this.Close();
                    }
                    else MessageBox.Show("Güncelleme iptal edildi", "Bilgilendirme");

                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = Application.StartupPath + "\\pictures\\";
                DialogResult sonuc = openFileDialog1.ShowDialog();
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                image_loc = pictureBox1.ImageLocation;
            }
            catch { }
        }

        private void tbYil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
