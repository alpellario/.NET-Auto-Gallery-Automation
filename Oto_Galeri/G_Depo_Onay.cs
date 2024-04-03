using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Oto_Galeri
{
    public partial class G_Depo_Onay : Form
    {
        

        public int arac_id;
        public G_Depo_Onay()
        {
            InitializeComponent();
        }

        private void btOnay_Click(object sender, EventArgs e)
        {
            G_Depo_Tutar gdepotutar = new G_Depo_Tutar();
            gdepotutar.arac_id = arac_id;
            gdepotutar.ShowDialog();            
            this.Close();


        }

        private void arac_guncelle_Click(object sender, EventArgs e)
        {
            AracKayit arac_guncelleme = new AracKayit();
            arac_guncelleme.guncelleme_mi = true;
            arac_guncelleme.oncekiForm_arac_id = arac_id;
            arac_guncelleme.ShowDialog();

        }
    }
}
