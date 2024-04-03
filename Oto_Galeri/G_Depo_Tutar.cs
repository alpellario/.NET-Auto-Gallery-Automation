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
    public partial class G_Depo_Tutar : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=OtoGaleri; Integrated Security=true");
        public int arac_id;
        public G_Depo_Tutar()
        {
            InitializeComponent();
        }

        private void btTutar_Click(object sender, EventArgs e)
        {
            if(tbTutar.Text != "")
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show(tbTutar.Text + "₺ tutarı ile Galeriye gönderilecek. Onaylıyor musunuz?", "ONAY", MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    SqlCommand up_depo = new SqlCommand();
                    up_depo.Connection = conn;
                    up_depo.CommandText = "UPDATE AracDepo SET depo_durum=@depo_durum WHERE arac_id=@arac_id";
                    up_depo.Parameters.AddWithValue("@depo_durum", 0);
                    up_depo.Parameters.AddWithValue("@arac_id", arac_id);
                    up_depo.ExecuteNonQuery();

                    SqlCommand tutar_ekle = new SqlCommand();
                    tutar_ekle.Connection = conn;
                    tutar_ekle.CommandText = "INSERT INTO SatisFiyat(arac_id,satis_tutar) VALUES(@arac_id,@satis_tutar)";
                    tutar_ekle.Parameters.AddWithValue("@arac_id", arac_id);
                    tutar_ekle.Parameters.AddWithValue("@satis_tutar", tbTutar.Text);
                    tutar_ekle.ExecuteNonQuery();
                                        
                    SqlCommand galeriye_ekle = new SqlCommand();
                    galeriye_ekle.Connection = conn;
                    galeriye_ekle.CommandText = "INSERT INTO Galeri(arac_id) VALUES(@arac_id)";
                    galeriye_ekle.Parameters.AddWithValue("@arac_id", arac_id);
                    galeriye_ekle.ExecuteNonQuery();

                    MessageBox.Show("Galeriye göndirildi", "Bilgilendirme");
                    conn.Close();
                    this.Close();
                }
                else MessageBox.Show("İptal Edildi", "Bilgilendirme");

            }
            
        }

        private void tbTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
