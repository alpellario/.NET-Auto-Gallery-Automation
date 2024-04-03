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
    public partial class Eylem : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=OtoGaleri; Integrated Security=true");
        public int temp_arac_id;
        public Eylem()
        {
            InitializeComponent();
        }

        private void btAracSat_Click(object sender, EventArgs e)
        {
            AracSatis fr_aracsatis = new AracSatis();
            fr_aracsatis.temp_arac_id = temp_arac_id;
            fr_aracsatis.ShowDialog();
            this.Close();

        }

        private void btGonder_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Araç depoya gönderilecek. Onaylıyor musunuz ?", "ONAY", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand up_depo = new SqlCommand();
                up_depo.Connection = conn;
                up_depo.CommandText = "UPDATE AracDepo SET depo_durum=@depo_durum WHERE arac_id=@arac_id";
                up_depo.Parameters.AddWithValue("@depo_durum", 1);
                up_depo.Parameters.AddWithValue("@arac_id", temp_arac_id);
                up_depo.ExecuteNonQuery();

                SqlCommand del_satis_tutar = new SqlCommand();
                del_satis_tutar.Connection = conn;
                del_satis_tutar.CommandText = "DELETE FROM SatisFiyat WHERE arac_id=@arac_id";
                del_satis_tutar.Parameters.AddWithValue("@arac_id", temp_arac_id);
                del_satis_tutar.ExecuteNonQuery();

                SqlCommand del_galeri = new SqlCommand();
                del_galeri.Connection = conn;
                del_galeri.CommandText = "DELETE FROM Galeri WHERE arac_id=@arac_id";
                del_galeri.Parameters.AddWithValue("@arac_id", temp_arac_id);
                del_galeri.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Araç depoya gönderildi", "Bilgilendirme");
                this.Close();
            }
            else MessageBox.Show("İptal edildi", "Bilgilendirme");
            

        }

        private void btGuncelle_Click(object sender, EventArgs e)
        {
            AracKayit arac_guncelle = new AracKayit();
            arac_guncelle.guncelleme_mi = true;
            arac_guncelle.oncekiForm_arac_id = temp_arac_id;
            arac_guncelle.ShowDialog();
        }
    }
}
