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
    public partial class ListeAracAlis : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=OtoGaleri; Integrated Security=true");
        DataSet dsSatislar = new DataSet();
        BindingSource bsSatislar = new BindingSource();
        DataSet dsArama = new DataSet();
        BindingSource bsArama = new BindingSource();
        public ListeAracAlis()
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
        private void ListeAracAlis_Load(object sender, EventArgs e)
        {
            datadoldur();
            for (int i = 0; i < 7; i++)
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
            SqlDataAdapter daSatis = new SqlDataAdapter("SELECT alis_id AS 'ALIŞ ID', " +
                                              "satici_tc AS TC,satici_ad + ' ' + satici_soyad AS 'SATICI AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'ALINAN ARAÇ', arac_durum AS DURUM," +
                                              "FORMAT(alis_tutar,'N','tr-TR') + ' TL' AS 'ALIŞ TUTARI'," +
                                              "alis_tarih AS 'ALIŞ TARİHİ' " +
                                       "FROM AracAlis AA INNER JOIN Satici S ON AA.satici_id=S.satici_id " +
                                                        "INNER JOIN Arac AR ON AA.arac_id=AR.arac_id " +
                                                        "INNER JOIN AlisFiyat AF ON AA.arac_id=AF.arac_id", conn);
            daSatis.Fill(dsSatislar, "Alislar");
            bsSatislar.DataSource = dsSatislar.Tables["Alislar"];
            dataGridView1.DataSource = bsSatislar;
            conn.Close();

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
                SqlDataAdapter da = new SqlDataAdapter("SELECT alis_id AS 'ALIŞ ID', " +
                                              "satici_tc AS TC,satici_ad + ' ' + satici_soyad AS 'SATICI AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'ALINAN ARAÇ', arac_durum AS DURUM," +
                                              "FORMAT(alis_tutar,'N','tr-TR') + ' TL' AS 'ALIŞ TUTARI'," +
                                              "alis_tarih AS 'ALIŞ TARİHİ' " +
                                       "FROM AracAlis AA INNER JOIN Satici S ON AA.satici_id=S.satici_id " +
                                                        "INNER JOIN Arac AR ON AA.arac_id=AR.arac_id " +
                                                        "INNER JOIN AlisFiyat AF ON AA.arac_id=AF.arac_id WHERE  alis_id LIKE '"+tbIDsatis.Text+"%'", conn);

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
                SqlDataAdapter da = new SqlDataAdapter("SELECT alis_id AS 'ALIŞ ID', " +
                                              "satici_tc AS TC,satici_ad + ' ' + satici_soyad AS 'SATICI AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'ALINAN ARAÇ', arac_durum AS DURUM," +
                                              "FORMAT(alis_tutar,'N','tr-TR') + ' TL' AS 'ALIŞ TUTARI'," +
                                              "alis_tarih AS 'ALIŞ TARİHİ' " +
                                       "FROM AracAlis AA INNER JOIN Satici S ON AA.satici_id=S.satici_id " +
                                                        "INNER JOIN Arac AR ON AA.arac_id=AR.arac_id " +
                                                        "INNER JOIN AlisFiyat AF ON AA.arac_id=AF.arac_id WHERE  AA.arac_id LIKE '" + tbIDarac.Text + "%'", conn);

                da.Fill(dsArama, "Satislar");
                bsArama.DataSource = dsArama.Tables["Satislar"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void tbIDsatici_TextChanged(object sender, EventArgs e)
        {
            if (tbIDsatici.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsSatislar;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT alis_id AS 'ALIŞ ID', " +
                                              "satici_tc AS TC,satici_ad + ' ' + satici_soyad AS 'SATICI AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'ALINAN ARAÇ', arac_durum AS DURUM," +
                                              "FORMAT(alis_tutar,'N','tr-TR') + ' TL' AS 'ALIŞ TUTARI'," +
                                              "alis_tarih AS 'ALIŞ TARİHİ' " +
                                       "FROM AracAlis AA INNER JOIN Satici S ON AA.satici_id=S.satici_id " +
                                                        "INNER JOIN Arac AR ON AA.arac_id=AR.arac_id " +
                                                        "INNER JOIN AlisFiyat AF ON AA.arac_id=AF.arac_id WHERE  AA.satici_id LIKE '" + tbIDsatici.Text + "%'", conn);

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
                SqlDataAdapter da = new SqlDataAdapter("SELECT alis_id AS 'ALIŞ ID', " +
                                              "satici_tc AS TC,satici_ad + ' ' + satici_soyad AS 'SATICI AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'ALINAN ARAÇ', arac_durum AS DURUM," +
                                              "FORMAT(alis_tutar,'N','tr-TR') + ' TL' AS 'ALIŞ TUTARI'," +
                                              "alis_tarih AS 'ALIŞ TARİHİ' " +
                                       "FROM AracAlis AA INNER JOIN Satici S ON AA.satici_id=S.satici_id " +
                                                        "INNER JOIN Arac AR ON AA.arac_id=AR.arac_id " +
                                                        "INNER JOIN AlisFiyat AF ON AA.arac_id=AF.arac_id WHERE  satici_tc LIKE '" + tbTc.Text + "%'", conn);

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
                SqlDataAdapter da = new SqlDataAdapter("SELECT alis_id AS 'ALIŞ ID', " +
                                              "satici_tc AS TC,satici_ad + ' ' + satici_soyad AS 'SATICI AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'ALINAN ARAÇ', arac_durum AS DURUM," +
                                              "FORMAT(alis_tutar,'N','tr-TR') + ' TL' AS 'ALIŞ TUTARI'," +
                                              "alis_tarih AS 'ALIŞ TARİHİ' " +
                                       "FROM AracAlis AA INNER JOIN Satici S ON AA.satici_id=S.satici_id " +
                                                        "INNER JOIN Arac AR ON AA.arac_id=AR.arac_id " +
                                                        "INNER JOIN AlisFiyat AF ON AA.arac_id=AF.arac_id WHERE  satici_ad LIKE '" + tbAd.Text + "%'", conn);

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
                SqlDataAdapter da = new SqlDataAdapter("SELECT alis_id AS 'ALIŞ ID', " +
                                              "satici_tc AS TC,satici_ad + ' ' + satici_soyad AS 'SATICI AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'ALINAN ARAÇ', arac_durum AS DURUM," +
                                              "FORMAT(alis_tutar,'N','tr-TR') + ' TL' AS 'ALIŞ TUTARI'," +
                                              "alis_tarih AS 'ALIŞ TARİHİ' " +
                                       "FROM AracAlis AA INNER JOIN Satici S ON AA.satici_id=S.satici_id " +
                                                        "INNER JOIN Arac AR ON AA.arac_id=AR.arac_id " +
                                                        "INNER JOIN AlisFiyat AF ON AA.arac_id=AF.arac_id WHERE  satici_soyad LIKE '" + tbSoyad.Text + "%'", conn);

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
                SqlDataAdapter da = new SqlDataAdapter("SELECT alis_id AS 'ALIŞ ID', " +
                                              "satici_tc AS TC,satici_ad + ' ' + satici_soyad AS 'SATICI AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'ALINAN ARAÇ', arac_durum AS DURUM," +
                                              "FORMAT(alis_tutar,'N','tr-TR') + ' TL' AS 'ALIŞ TUTARI'," +
                                              "alis_tarih AS 'ALIŞ TARİHİ' " +
                                       "FROM AracAlis AA INNER JOIN Satici S ON AA.satici_id=S.satici_id " +
                                                        "INNER JOIN Arac AR ON AA.arac_id=AR.arac_id " +
                                                        "INNER JOIN AlisFiyat AF ON AA.arac_id=AF.arac_id WHERE  arac_marka LIKE '" + tbMarka.Text + "%'", conn);

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
                SqlDataAdapter da = new SqlDataAdapter("SELECT alis_id AS 'ALIŞ ID', " +
                                              "satici_tc AS TC,satici_ad + ' ' + satici_soyad AS 'SATICI AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'ALINAN ARAÇ', arac_durum AS DURUM," +
                                              "FORMAT(alis_tutar,'N','tr-TR') + ' TL' AS 'ALIŞ TUTARI'," +
                                              "alis_tarih AS 'ALIŞ TARİHİ' " +
                                       "FROM AracAlis AA INNER JOIN Satici S ON AA.satici_id=S.satici_id " +
                                                        "INNER JOIN Arac AR ON AA.arac_id=AR.arac_id " +
                                                        "INNER JOIN AlisFiyat AF ON AA.arac_id=AF.arac_id WHERE  arac_model LIKE '" + tbModel.Text + "%'", conn);

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
                SqlDataAdapter da = new SqlDataAdapter("SELECT alis_id AS 'ALIŞ ID', " +
                                              "satici_tc AS TC,satici_ad + ' ' + satici_soyad AS 'SATICI AD SOYAD', " +
                                              "arac_marka + ' ' + arac_model AS 'ALINAN ARAÇ', arac_durum AS DURUM," +
                                              "FORMAT(alis_tutar,'N','tr-TR') + ' TL' AS 'ALIŞ TUTARI'," +
                                              "alis_tarih AS 'ALIŞ TARİHİ' " +
                                       "FROM AracAlis AA INNER JOIN Satici S ON AA.satici_id=S.satici_id " +
                                                        "INNER JOIN Arac AR ON AA.arac_id=AR.arac_id " +
                                                        "INNER JOIN AlisFiyat AF ON AA.arac_id=AF.arac_id WHERE  arac_durum LIKE '" + tbDurum.Text + "%'", conn);

                da.Fill(dsArama, "Satislar");
                bsArama.DataSource = dsArama.Tables["Satislar"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ListeAracAlis_Detay fr_alisDetay = new ListeAracAlis_Detay();
            fr_alisDetay.oncekiForm_alis_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            fr_alisDetay.ShowDialog();
        }
    }
}
