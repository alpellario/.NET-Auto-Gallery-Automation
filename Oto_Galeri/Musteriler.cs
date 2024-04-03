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
    public partial class Musteriler : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=OtoGaleri; Integrated Security=true");
        DataSet dsMusteri = new DataSet();
        BindingSource bsMusteri = new BindingSource();
        DataSet dsArama = new DataSet();
        BindingSource bsArama = new BindingSource();

        public bool anaMenu = false;
        public int kayitli_musteri_id;
        public string tc, ad, soyad, telefon, adres = string.Empty;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (anaMenu == false)
            {
                kayitli_musteri_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                tc = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                ad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                soyad = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                telefon = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                adres = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                this.Close();
            }else if(anaMenu == true)
            {
                Musteri_Eylem eylem = new Musteri_Eylem();
                eylem.oncekiForm_musteri_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                eylem.tc = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                eylem.ad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                eylem.soyad = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                eylem.telefon = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                eylem.adres = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                eylem.ShowDialog();
                dataDoldur();
            }

        }
        public Musteriler()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void Musteriler_Load(object sender, EventArgs e)
        {
            dataDoldur();

            label3.Text = "";


            for (int i = 0; i < 6; i++)
            {
                this.dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.SpringGreen;
            this.dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11);
            this.dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 12);
        }
        void dataDoldur()
        {
            dsMusteri.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter daSatici = new SqlDataAdapter("SELECT musteri_id AS ID,musteri_tc AS TC,musteri_ad AS AD, musteri_soyad AS SOYAD," +
                "musteri_telefon AS TELEFON,musteri_adres AS ADRES FROM Musteri ORDER BY musteri_id DESC", conn);
            daSatici.Fill(dsMusteri, "Musteri");
            bsMusteri.DataSource = dsMusteri.Tables["Musteri"];
            dataGridView1.DataSource = bsMusteri;
            conn.Close();

        }
        private void tbTc_TextChanged(object sender, EventArgs e)
        {
            if (tbTc.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsMusteri;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT musteri_id AS ID,musteri_tc AS TC,musteri_ad AS AD, musteri_soyad AS SOYAD," +
                "musteri_telefon AS TELEFON,musteri_adres AS ADRES FROM Musteri WHERE musteri_tc LIKE '" + tbTc.Text + "%' ORDER BY musteri_id DESC", conn);

                da.Fill(dsArama, "Satici");
                bsArama.DataSource = dsArama.Tables["Satici"];
                dataGridView1.DataSource = bsArama;
            }
        }
        private void tbTel_TextChanged(object sender, EventArgs e)
        {
            if (tbTel.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsMusteri;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT musteri_id AS ID,musteri_tc AS TC,musteri_ad AS AD, musteri_soyad AS SOYAD," +
                "musteri_telefon AS TELEFON,musteri_adres AS ADRES FROM Musteri WHERE musteri_telefon LIKE '" + tbTel.Text + "%' ORDER BY musteri_id DESC", conn);

                da.Fill(dsArama, "Satici");
                bsArama.DataSource = dsArama.Tables["Satici"];
                dataGridView1.DataSource = bsArama;
            }
        }
        private void tbAd_TextChanged(object sender, EventArgs e)
        {
            if (tbAd.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsMusteri;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT musteri_id AS ID,musteri_tc AS TC,musteri_ad AS AD, musteri_soyad AS SOYAD," +
                "musteri_telefon AS TELEFON,musteri_adres AS ADRES FROM Musteri WHERE musteri_ad LIKE '" + tbAd.Text + "%' ORDER BY musteri_id DESC", conn);

                da.Fill(dsArama, "Satici");
                bsArama.DataSource = dsArama.Tables["Satici"];
                dataGridView1.DataSource = bsArama;
            }
        }
        private void tbSoyad_TextChanged(object sender, EventArgs e)
        {
            if (tbSoyad.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsMusteri;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT musteri_id AS ID,musteri_tc AS TC,musteri_ad AS AD, musteri_soyad AS SOYAD," +
                "musteri_telefon AS TELEFON,musteri_adres AS ADRES FROM Musteri WHERE musteri_soyad LIKE '" + tbSoyad.Text + "%' ORDER BY musteri_id DESC", conn);

                da.Fill(dsArama, "Satici");
                bsArama.DataSource = dsArama.Tables["Satici"];
                dataGridView1.DataSource = bsArama;
            }
        }
    }
}
