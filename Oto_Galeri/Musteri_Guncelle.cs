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
    public partial class Musteri_Guncelle : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=OtoGaleri; Integrated Security=true");
        public int oncekiForm_musteri_id;
        public int oncekiForm_satici_id;
        public string tc, ad, soyad, tel, adres = string.Empty;
        public bool satici_mi = false;

        private void btMusteriKaydet_Click(object sender, EventArgs e)
        {
            if (tbMad.Text != "")
            {
                if (satici_mi==false)
                {
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show("Güncellenecek. Onaylıyor musunuz ?", "ONAY", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        if (conn.State == ConnectionState.Closed) conn.Open();
                        SqlCommand musteri_kaydet = new SqlCommand();
                        musteri_kaydet.Connection = conn;
                        musteri_kaydet.CommandText = "UPDATE Musteri SET musteri_tc=@musteri_tc, musteri_ad=@musteri_ad, musteri_soyad=@musteri_soyad" +
                            ", musteri_telefon=@musteri_telefon, musteri_adres=@musteri_adres WHERE musteri_id=@musteri_id";
                        musteri_kaydet.Parameters.AddWithValue("@musteri_tc", tbMtc.Text);
                        musteri_kaydet.Parameters.AddWithValue("@musteri_ad", tbMad.Text);
                        musteri_kaydet.Parameters.AddWithValue("@musteri_soyad", tbMsoyad.Text);
                        musteri_kaydet.Parameters.AddWithValue("@musteri_telefon", tbMtel.Text);
                        musteri_kaydet.Parameters.AddWithValue("@musteri_adres", tbMadres.Text);
                        musteri_kaydet.Parameters.AddWithValue("@musteri_id", oncekiForm_musteri_id);
                        musteri_kaydet.ExecuteNonQuery();
                        conn.Close();
                        this.Close();
                    }

                }
                else
                {
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show("Güncellenecek. Onaylıyor musunuz ?", "ONAY", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        if (conn.State == ConnectionState.Closed) conn.Open();
                        SqlCommand satici_kaydet = new SqlCommand();
                        satici_kaydet.Connection = conn;
                        satici_kaydet.CommandText = "UPDATE Satici SET satici_tc=@satici_tc, satici_ad=@satici_ad, satici_soyad=@satici_soyad" +
                            ", satici_telefon=@satici_telefon, satici_adres=@satici_adres WHERE satici_id=@satici_id";
                        satici_kaydet.Parameters.AddWithValue("@satici_tc", tbMtc.Text);
                        satici_kaydet.Parameters.AddWithValue("@satici_ad", tbMad.Text);
                        satici_kaydet.Parameters.AddWithValue("@satici_soyad", tbMsoyad.Text);
                        satici_kaydet.Parameters.AddWithValue("@satici_telefon", tbMtel.Text);
                        satici_kaydet.Parameters.AddWithValue("@satici_adres", tbMadres.Text);
                        satici_kaydet.Parameters.AddWithValue("@satici_id", oncekiForm_satici_id);
                        satici_kaydet.ExecuteNonQuery();
                        conn.Close();
                        this.Close();
                    }
                }
            }
            
            
        }

        public Musteri_Guncelle()
        {
            InitializeComponent();
        }

        private void Musteri_Guncelle_Load(object sender, EventArgs e)
        {
            if (satici_mi ==false)
            {
                tbMtc.Text = tc;
                tbMad.Text = ad;
                tbMsoyad.Text = soyad;
                tbMtel.Text = tel;
                tbMadres.Text = adres;
                if (tbMtc.Text == "")
                {
                    cbYabanci.Checked = true;
                }
            }
            else
            {
                btMusteriKaydet.Text = "Satici Kaydet";
                tbMtc.Text = tc;
                tbMad.Text = ad;
                tbMsoyad.Text = soyad;
                tbMtel.Text = tel;
                tbMadres.Text = adres;
                if (tbMtc.Text == "")
                {
                    cbYabanci.Checked = true;
                }
            }
            
        }

        private void cbYabanci_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYabanci.Checked)
            {
                tbMtc.Clear();
                tbMtc.Enabled = false;

            }
            else
            {
                tbMtc.Clear();
                tbMtc.Enabled = true;
            }
        }
    }
}
