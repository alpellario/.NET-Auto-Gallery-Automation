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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=OtoGaleri;Integrated Security=true");
        public Form1()
        {
            InitializeComponent();
        }


        private void btSaticiArac_Click(object sender, EventArgs e)
        {
            SaticiAracKayit saticiForm = new SaticiAracKayit();
            saticiForm.ShowDialog();
        }

        private void btAracKayit_Click(object sender, EventArgs e)
        {
            AracKayit fr_arackayit = new AracKayit();
            fr_arackayit.ShowDialog();
        }

        private void btGaleri_Click(object sender, EventArgs e)
        {
            Galeri fr_galeri = new Galeri();
            fr_galeri.ShowDialog();
        }

        private void btDepo_Click(object sender, EventArgs e)
        {
            G_Depo depo = new G_Depo();
            depo.ShowDialog();
        }

        private void btSatislar_Click(object sender, EventArgs e)
        {
            ListeAracSatis fr_satislar = new ListeAracSatis();
            fr_satislar.ShowDialog();
        }

        private void btAlislar_Click(object sender, EventArgs e)
        {
            ListeAracAlis fr_alis = new ListeAracAlis();
            fr_alis.ShowDialog();
        }

        private void btMusteriler_Click(object sender, EventArgs e)
        {
            Musteriler fr_musteri = new Musteriler();
            fr_musteri.anaMenu = true;
            fr_musteri.ShowDialog();
        }

        private void btSaticilar_Click(object sender, EventArgs e)
        {
            Saticilar fr_satici = new Saticilar();
            fr_satici.anaMenu = true;
            fr_satici.ShowDialog();
        }
    }
}
