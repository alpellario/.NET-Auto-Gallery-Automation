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
    public partial class Satici_Eylem : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=OtoGaleri; Integrated Security=true");
        public string tc, ad, soyad, telefon, adres = string.Empty;

        public int oncekiForm_satici_id;
        public Satici_Eylem()
        {
            InitializeComponent();
        }

        private void btSsil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Satıcı silinecek. Onaylıyormusun ?", "Bilgilendirme", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand sil = new SqlCommand();
                sil.Connection = conn;
                sil.CommandText = "DELETE FROM Satici WHERE satici_id=@satici_id";
                sil.Parameters.AddWithValue("@satici_id", oncekiForm_satici_id);
                sil.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Satici silindi", "Bilgilendirme");
                this.Close();
            }
            else MessageBox.Show("Silme iptal edildi", "Bilgilendirme");
            
        }

        private void btSguncelle_Click(object sender, EventArgs e)
        {
            Musteri_Guncelle guncelle = new Musteri_Guncelle();
            guncelle.satici_mi = true;
            guncelle.oncekiForm_satici_id = oncekiForm_satici_id;
            guncelle.tc = tc;
            guncelle.ad = ad;
            guncelle.soyad = soyad;
            guncelle.tel = telefon;
            guncelle.adres = adres;
            guncelle.ShowDialog();
            this.Close();
        }

        private void Satici_Eylem_Load(object sender, EventArgs e)
        {

        }
    }
}
