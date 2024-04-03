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
    public partial class ListeAracSatis : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=OtoGaleri; Integrated Security=true");
        DataSet dsSatislar = new DataSet();
        BindingSource bsSatislar = new BindingSource();
        DataSet dsArama = new DataSet();
        BindingSource bsArama = new BindingSource();
        public ListeAracSatis()
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
        private void ListeAracSatis_Load(object sender, EventArgs e)
        {
            datadoldur();
            for (int i = 0; i < 5; i++)
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

        private void datadoldur()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();            
            SqlDataAdapter daSatis = new SqlDataAdapter("SELECT satis_id AS 'SATIŞ ID', " +
                                              "musteri_ad + ' ' + musteri_soyad AS 'MÜŞTERİ AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'SATILAN ARAÇ'," +
                                              "FORMAT(satis_tutar,'N','tr-TR') + ' TL' AS 'SATIŞ TUTARI'," +
                                              "satis_tarih AS 'SATIŞ TARİHİ' " +
                                       "FROM AracSatis ARS INNER JOIN Musteri M ON ARS.musteri_id=M.musteri_id " +
                                                         "INNER JOIN Arac AR ON ARS.arac_id=AR.arac_id",conn);
            daSatis.Fill(dsSatislar, "Satislar");
            bsSatislar.DataSource = dsSatislar.Tables["Satislar"];
            dataGridView1.DataSource = bsSatislar;
            conn.Close();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ListeAracSatis_Detay fr_detay = new ListeAracSatis_Detay();
            fr_detay.oncekiForm_satis_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            fr_detay.ShowDialog();
        }

        private void tbIDsatis_TextChanged(object sender, EventArgs e)
        {
            if (tbIDsatis.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsSatislar;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT satis_id AS 'SATIŞ ID', " +
                                              "musteri_ad + ' ' + musteri_soyad AS 'MÜŞTERİ AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'SATILAN ARAÇ'," +
                                              "FORMAT(satis_tutar,'N','tr-TR') + ' TL' AS 'SATIŞ TUTARI'," +
                                              "satis_tarih AS 'SATIŞ TARİHİ' " +
                                       "FROM AracSatis ARS INNER JOIN Musteri M ON ARS.musteri_id=M.musteri_id " +
                                                          "INNER JOIN Arac AR ON ARS.arac_id=AR.arac_id WHERE satis_id LIKE '"+ tbIDsatis.Text +"%' ", conn);

                da.Fill(dsArama, "Satislar");
                bsArama.DataSource = dsArama.Tables["Satislar"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void tbIDarac_TextChanged(object sender, EventArgs e)
        {
            if (tbIDarac.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsSatislar;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT satis_id AS 'SATIŞ ID', " +
                                              "musteri_ad + ' ' + musteri_soyad AS 'MÜŞTERİ AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'SATILAN ARAÇ'," +
                                              "FORMAT(satis_tutar,'N','tr-TR') + ' TL' AS 'SATIŞ TUTARI'," +
                                              "satis_tarih AS 'SATIŞ TARİHİ' " +
                                       "FROM AracSatis ARS INNER JOIN Musteri M ON ARS.musteri_id=M.musteri_id " +
                                                          "INNER JOIN Arac AR ON ARS.arac_id=AR.arac_id WHERE ARS.arac_id LIKE '" + tbIDarac.Text + "%' ", conn);

                da.Fill(dsArama, "Satislar");
                bsArama.DataSource = dsArama.Tables["Satislar"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void tbIDmusteri_TextChanged(object sender, EventArgs e)
        {
            if (tbIDmusteri.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsSatislar;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT satis_id AS 'SATIŞ ID', " +
                                              "musteri_ad + ' ' + musteri_soyad AS 'MÜŞTERİ AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'SATILAN ARAÇ'," +
                                              "FORMAT(satis_tutar,'N','tr-TR') + ' TL' AS 'SATIŞ TUTARI'," +
                                              "satis_tarih AS 'SATIŞ TARİHİ' " +
                                       "FROM AracSatis ARS INNER JOIN Musteri M ON ARS.musteri_id=M.musteri_id " +
                                                          "INNER JOIN Arac AR ON ARS.arac_id=AR.arac_id WHERE ARS.musteri_id LIKE '" + tbIDmusteri.Text + "%' ", conn);

                da.Fill(dsArama, "Satislar");
                bsArama.DataSource = dsArama.Tables["Satislar"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void tbTc_TextChanged(object sender, EventArgs e)
        {
            if (tbTc.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsSatislar;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT satis_id AS 'SATIŞ ID', " +
                                              "musteri_ad + ' ' + musteri_soyad AS 'MÜŞTERİ AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'SATILAN ARAÇ'," +
                                              "FORMAT(satis_tutar,'N','tr-TR') + ' TL' AS 'SATIŞ TUTARI'," +
                                              "satis_tarih AS 'SATIŞ TARİHİ' " +
                                       "FROM AracSatis ARS INNER JOIN Musteri M ON ARS.musteri_id=M.musteri_id " +
                                                          "INNER JOIN Arac AR ON ARS.arac_id=AR.arac_id WHERE M.musteri_tc LIKE '" + tbTc.Text + "%' ", conn);

                da.Fill(dsArama, "Satislar");
                bsArama.DataSource = dsArama.Tables["Satislar"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void tbAd_TextChanged(object sender, EventArgs e)
        {
            if (tbAd.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsSatislar;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT satis_id AS 'SATIŞ ID', " +
                                              "musteri_ad + ' ' + musteri_soyad AS 'MÜŞTERİ AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'SATILAN ARAÇ'," +
                                              "FORMAT(satis_tutar,'N','tr-TR') + ' TL' AS 'SATIŞ TUTARI'," +
                                              "satis_tarih AS 'SATIŞ TARİHİ' " +
                                       "FROM AracSatis ARS INNER JOIN Musteri M ON ARS.musteri_id=M.musteri_id " +
                                                          "INNER JOIN Arac AR ON ARS.arac_id=AR.arac_id WHERE M.musteri_ad LIKE '" + tbAd.Text + "%' ", conn);

                da.Fill(dsArama, "Satislar");
                bsArama.DataSource = dsArama.Tables["Satislar"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void tbSoyad_TextChanged(object sender, EventArgs e)
        {
            if (tbSoyad.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsSatislar;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT satis_id AS 'SATIŞ ID', " +
                                              "musteri_ad + ' ' + musteri_soyad AS 'MÜŞTERİ AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'SATILAN ARAÇ'," +
                                              "FORMAT(satis_tutar,'N','tr-TR') + ' TL' AS 'SATIŞ TUTARI'," +
                                              "satis_tarih AS 'SATIŞ TARİHİ' " +
                                       "FROM AracSatis ARS INNER JOIN Musteri M ON ARS.musteri_id=M.musteri_id " +
                                                          "INNER JOIN Arac AR ON ARS.arac_id=AR.arac_id WHERE M.musteri_soyad LIKE '" + tbSoyad.Text + "%' ", conn);

                da.Fill(dsArama, "Satislar");
                bsArama.DataSource = dsArama.Tables["Satislar"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void tbMarka_TextChanged(object sender, EventArgs e)
        {
            if (tbMarka.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsSatislar;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT satis_id AS 'SATIŞ ID', " +
                                              "musteri_ad + ' ' + musteri_soyad AS 'MÜŞTERİ AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'SATILAN ARAÇ'," +
                                              "FORMAT(satis_tutar,'N','tr-TR') + ' TL' AS 'SATIŞ TUTARI'," +
                                              "satis_tarih AS 'SATIŞ TARİHİ' " +
                                       "FROM AracSatis ARS INNER JOIN Musteri M ON ARS.musteri_id=M.musteri_id " +
                                                          "INNER JOIN Arac AR ON ARS.arac_id=AR.arac_id WHERE arac_marka LIKE '" + tbMarka.Text + "%' ", conn);

                da.Fill(dsArama, "Satislar");
                bsArama.DataSource = dsArama.Tables["Satislar"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void tbModel_TextChanged(object sender, EventArgs e)
        {
            if (tbModel.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsSatislar;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT satis_id AS 'SATIŞ ID', " +
                                              "musteri_ad + ' ' + musteri_soyad AS 'MÜŞTERİ AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'SATILAN ARAÇ'," +
                                              "FORMAT(satis_tutar,'N','tr-TR') + ' TL' AS 'SATIŞ TUTARI'," +
                                              "satis_tarih AS 'SATIŞ TARİHİ' " +
                                       "FROM AracSatis ARS INNER JOIN Musteri M ON ARS.musteri_id=M.musteri_id " +
                                                          "INNER JOIN Arac AR ON ARS.arac_id=AR.arac_id WHERE arac_model LIKE '" + tbModel.Text + "%' ", conn);

                da.Fill(dsArama, "Satislar");
                bsArama.DataSource = dsArama.Tables["Satislar"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void tbDurum_TextChanged(object sender, EventArgs e)
        {
            if (tbDurum.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsSatislar;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT satis_id AS 'SATIŞ ID', " +
                                              "musteri_ad + ' ' + musteri_soyad AS 'MÜŞTERİ AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'SATILAN ARAÇ'," +
                                              "FORMAT(satis_tutar,'N','tr-TR') + ' TL' AS 'SATIŞ TUTARI'," +
                                              "satis_tarih AS 'SATIŞ TARİHİ' " +
                                       "FROM AracSatis ARS INNER JOIN Musteri M ON ARS.musteri_id=M.musteri_id " +
                                                          "INNER JOIN Arac AR ON ARS.arac_id=AR.arac_id WHERE arac_durum LIKE '" + tbDurum.Text + "%' ", conn);

                da.Fill(dsArama, "Satislar");
                bsArama.DataSource = dsArama.Tables["Satislar"];
                dataGridView1.DataSource = bsArama;
            }
        }
    }
}
