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
    public partial class G_Depo : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=OtoGaleri;Integrated Security=true");
        DataSet dsArac = new DataSet();
        BindingSource bsArac = new BindingSource();
        DataSet dsArama = new DataSet();
        BindingSource bsArama = new BindingSource();

        void datadoldur()
        {
            dsArac.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT AR.arac_id AS 'ARAC ID',AR.arac_plaka AS 'ARAC PLAKA',AR.arac_marka AS 'ARAC MARKA', AR.arac_model AS 'ARAC MODEL', AR.arac_yil " +
                "AS 'ARAC YIL', AR.arac_renk AS 'ARAC RENK', AR.arac_durum AS 'ARAC DURUM', AR.arac_bilgi AS 'ARAC BİLGİ', FORMAT(ALF.alis_tutar,'N','tr-TR') + ' TL' AS 'ALİS TUTAR' " +
                          "FROM Arac AR INNER JOIN AlisFiyat ALF ON AR.arac_id=ALF.arac_id " +
                                        "INNER JOIN AracDepo AD ON AR.arac_id=AD.arac_id WHERE AD.depo_durum =1 ORDER BY AR.arac_id DESC", conn);         
            da.Fill(dsArac, "Depo");
            conn.Close();
            bsArac.DataSource = dsArac.Tables["Depo"];
            dataGridView1.DataSource = bsArac;
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
        public G_Depo()
        {
            InitializeComponent();
            
        }

        private void G_Depo_Load(object sender, EventArgs e)
        {
            datadoldur();
            for (int i = 0; i < 9; i++)
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            G_Depo_Onay depoOnay = new G_Depo_Onay();
            depoOnay.arac_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            depoOnay.ShowDialog();
            datadoldur();
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            if (tbId.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsArac;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT AR.arac_id AS 'ARAC ID',AR.arac_plaka AS 'ARAC PLAKA',AR.arac_marka AS 'ARAC MARKA', AR.arac_model AS 'ARAC MODEL', AR.arac_yil " +
                "AS 'ARAC YIL', AR.arac_renk AS 'ARAC RENK', AR.arac_durum AS 'ARAC DURUM', AR.arac_bilgi AS 'ARAC BİLGİ', FORMAT(ALF.alis_tutar,'N','tr-TR') + ' TL' AS 'ALİS TUTAR' " +
                          "FROM Arac AR INNER JOIN AlisFiyat ALF ON AR.arac_id=ALF.arac_id " +
                                        "INNER JOIN AracDepo AD ON AR.arac_id=AD.arac_id WHERE AD.depo_durum =1 AND AR.arac_id LIKE'" + tbId.Text + "%' ORDER BY AR.arac_id DESC", conn);

                da.Fill(dsArama, "Arac");
                bsArama.DataSource = dsArama.Tables["Arac"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void tbPlaka_TextChanged(object sender, EventArgs e)
        {
            if (tbPlaka.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsArac;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT AR.arac_id AS 'ARAC ID',AR.arac_plaka AS 'ARAC PLAKA',AR.arac_marka AS 'ARAC MARKA', AR.arac_model AS 'ARAC MODEL', AR.arac_yil " +
                "AS 'ARAC YIL', AR.arac_renk AS 'ARAC RENK', AR.arac_durum AS 'ARAC DURUM', AR.arac_bilgi AS 'ARAC BİLGİ', FORMAT(ALF.alis_tutar,'N','tr-TR') + ' TL' AS 'ALİS TUTAR' " +
                          "FROM Arac AR INNER JOIN AlisFiyat ALF ON AR.arac_id=ALF.arac_id " +
                                        "INNER JOIN AracDepo AD ON AR.arac_id=AD.arac_id WHERE AD.depo_durum =1 AND AR.arac_plaka LIKE'" + tbPlaka.Text + "%' ORDER BY AR.arac_id DESC", conn);

                da.Fill(dsArama, "Arac");
                bsArama.DataSource = dsArama.Tables["Arac"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void tbMarka_TextChanged(object sender, EventArgs e)
        {
            if (tbMarka.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsArac;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT AR.arac_id AS 'ARAC ID',AR.arac_plaka AS 'ARAC PLAKA',AR.arac_marka AS 'ARAC MARKA', AR.arac_model AS 'ARAC MODEL', AR.arac_yil " +
                "AS 'ARAC YIL', AR.arac_renk AS 'ARAC RENK', AR.arac_durum AS 'ARAC DURUM', AR.arac_bilgi AS 'ARAC BİLGİ', FORMAT(ALF.alis_tutar,'N','tr-TR') + ' TL' 'ALİS TUTAR' " +
                          "FROM Arac AR INNER JOIN AlisFiyat ALF ON AR.arac_id=ALF.arac_id " +
                                        "INNER JOIN AracDepo AD ON AR.arac_id=AD.arac_id WHERE AD.depo_durum =1 AND AR.arac_marka LIKE'" + tbMarka.Text + "%' ORDER BY AR.arac_id DESC", conn);

                da.Fill(dsArama, "Arac");
                bsArama.DataSource = dsArama.Tables["Arac"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void tbModel_TextChanged(object sender, EventArgs e)
        {
            if (tbModel.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsArac;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT AR.arac_id AS 'ARAC ID',AR.arac_plaka AS 'ARAC PLAKA',AR.arac_marka AS 'ARAC MARKA', AR.arac_model AS 'ARAC MODEL', AR.arac_yil " +
                "AS 'ARAC YIL', AR.arac_renk AS 'ARAC RENK', AR.arac_durum AS 'ARAC DURUM', AR.arac_bilgi AS 'ARAC BİLGİ', FORMAT(ALF.alis_tutar,'N','tr-TR') + ' TL' AS 'ALİS TUTAR' " +
                          "FROM Arac AR INNER JOIN AlisFiyat ALF ON AR.arac_id=ALF.arac_id " +
                                        "INNER JOIN AracDepo AD ON AR.arac_id=AD.arac_id WHERE AD.depo_durum =1 AND AR.arac_model LIKE'" + tbModel.Text + "%' ORDER BY AR.arac_id DESC", conn);

                da.Fill(dsArama, "Arac");
                bsArama.DataSource = dsArama.Tables["Arac"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void tbYil_TextChanged(object sender, EventArgs e)
        {
            if (tbYil.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsArac;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT AR.arac_id AS 'ARAC ID',AR.arac_plaka AS 'ARAC PLAKA',AR.arac_marka AS 'ARAC MARKA', AR.arac_model AS 'ARAC MODEL', AR.arac_yil " +
                "AS 'ARAC YIL', AR.arac_renk AS 'ARAC RENK', AR.arac_durum AS 'ARAC DURUM', AR.arac_bilgi AS 'ARAC BİLGİ', FORMAT(ALF.alis_tutar,'N','tr-TR') + ' TL' AS 'ALİS TUTAR' " +
                          "FROM Arac AR INNER JOIN AlisFiyat ALF ON AR.arac_id=ALF.arac_id " +
                                        "INNER JOIN AracDepo AD ON AR.arac_id=AD.arac_id WHERE AD.depo_durum =1 AND AR.arac_yil LIKE'" + tbYil.Text + "%' ORDER BY AR.arac_id DESC", conn);

                da.Fill(dsArama, "Arac");
                bsArama.DataSource = dsArama.Tables["Arac"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void tbRenk_TextChanged(object sender, EventArgs e)
        {
            if (tbRenk.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsArac;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT AR.arac_id AS 'ARAC ID',AR.arac_plaka AS 'ARAC PLAKA',AR.arac_marka AS 'ARAC MARKA', AR.arac_model AS 'ARAC MODEL', AR.arac_yil " +
                "AS 'ARAC YIL', AR.arac_renk AS 'ARAC RENK', AR.arac_durum AS 'ARAC DURUM', AR.arac_bilgi AS 'ARAC BİLGİ', FORMAT(ALF.alis_tutar,'N','tr-TR') + ' TL' AS 'ALİS TUTAR' " +
                          "FROM Arac AR INNER JOIN AlisFiyat ALF ON AR.arac_id=ALF.arac_id " +
                                        "INNER JOIN AracDepo AD ON AR.arac_id=AD.arac_id WHERE AD.depo_durum =1 AND AR.arac_renk LIKE'" + tbRenk.Text + "%' ORDER BY AR.arac_id DESC", conn);

                da.Fill(dsArama, "Arac");
                bsArama.DataSource = dsArama.Tables["Arac"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void tbTarih_TextChanged(object sender, EventArgs e)
        {
            if (tbTarih.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsArac;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT AR.arac_id AS 'ARAC ID',AR.arac_plaka AS 'ARAC PLAKA',AR.arac_marka AS 'ARAC MARKA', AR.arac_model AS 'ARAC MODEL', AR.arac_yil " +
                "AS 'ARAC YIL', AR.arac_renk AS 'ARAC RENK', AR.arac_durum AS 'ARAC DURUM', AR.arac_bilgi AS 'ARAC BİLGİ', FORMAT(ALF.alis_tutar,'N','tr-TR') + ' TL' AS 'ALİS TUTAR' " +
                          "FROM Arac AR INNER JOIN AlisFiyat ALF ON AR.arac_id=ALF.arac_id " +
                                        "INNER JOIN AracDepo AD ON AR.arac_id=AD.arac_id " +
                                        "INNER JOIN AracAlis AL ON AR.arac_id=AL.arac_id WHERE AD.depo_durum =1 AND AL.alis_tarih LIKE'%" + tbTarih.Text + "%' ORDER BY AR.arac_id DESC", conn);

                da.Fill(dsArama, "Arac");
                bsArama.DataSource = dsArama.Tables["Arac"];
                dataGridView1.DataSource = bsArama;
            }
        }
    }
}
