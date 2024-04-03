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
    public partial class Musteri_Eylem : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=OtoGaleri; Integrated Security=true");

        public int oncekiForm_musteri_id;
        public string tc, ad, soyad, telefon, adres = string.Empty;

        private void Musteri_Eylem_Load(object sender, EventArgs e)
        {

        }

        public Musteri_Eylem()
        {
            InitializeComponent();
        }

        private void btMsil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Müsteri silinecek. Onaylıyormusun ?", "Bilgilendirme", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand sil = new SqlCommand();
                sil.Connection = conn;
                sil.CommandText = "DELETE FROM Musteri WHERE musteri_id=@musteri_id";
                sil.Parameters.AddWithValue("@musteri_id", oncekiForm_musteri_id);
                sil.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Müşteri silindi", "Bilgilendirme");
                this.Close();
            }
            else MessageBox.Show("Silme iptal edildi", "Bilgilendirme");
            
        }

        private void btMguncelle_Click(object sender, EventArgs e)
        {
            Musteri_Guncelle guncelle = new Musteri_Guncelle();
            guncelle.oncekiForm_musteri_id = oncekiForm_musteri_id;
            guncelle.tc = tc;
            guncelle.ad = ad;
            guncelle.soyad = soyad;
            guncelle.tel = telefon;
            guncelle.adres = adres;
            guncelle.ShowDialog();
            this.Close();
        }
    }
}
