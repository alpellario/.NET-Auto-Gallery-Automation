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
    public partial class Saticilar : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=OtoGaleri; Integrated Security=true");
        DataSet dsSatici = new DataSet();
        BindingSource bsSatici = new BindingSource();

        public int kayitli_satici_id;
        public string tc, ad, soyad, telefon, adres = string.Empty;

        public bool anaMenu = false;
        public Saticilar()
        {
            InitializeComponent();
            

        }

        void dataDoldur()
        {
            dsSatici.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter daSatici = new SqlDataAdapter("SELECT satici_id AS ID,satici_tc AS TC,satici_ad AS AD, satici_soyad AS SOYAD," +
                "satici_telefon AS TELEFON,satici_adres AS ADRES FROM Satici ORDER BY satici_id DESC",conn);
            daSatici.Fill(dsSatici, "Satici");
            bsSatici.DataSource = dsSatici.Tables["Satici"];
            dataGridView1.DataSource = bsSatici;
            conn.Close();
            
        }
        DataSet dsArama = new DataSet();
        BindingSource bsArama = new BindingSource();
        private void tbTc_TextChanged(object sender, EventArgs e)
        {
            if (tbTc.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsSatici;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT satici_id AS ID,satici_tc AS TC,satici_ad AS AD, satici_soyad AS SOYAD," +
                "satici_telefon AS TELEFON,satici_adres AS ADRES FROM Satici Where satici_tc Like'" + tbTc.Text + "%' ORDER BY satici_ad", conn);

                da.Fill(dsArama, "Satici");
                bsArama.DataSource = dsArama.Tables["Satici"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void Saticilar_Load(object sender, EventArgs e)
        {
            dataDoldur();


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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void tbTel_TextChanged(object sender, EventArgs e)
        {
            if (tbTel.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsSatici;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT satici_id AS ID,satici_tc AS TC,satici_ad AS AD, satici_soyad AS SOYAD," +
                "satici_telefon AS TELEFON,satici_adres AS ADRES FROM Satici Where satici_telefon Like'" + tbTel.Text + "%' ORDER BY satici_ad", conn);

                da.Fill(dsArama, "Satici");
                bsArama.DataSource = dsArama.Tables["Satici"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void tbAd_TextChanged(object sender, EventArgs e)
        {
            if (tbAd.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsSatici;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT satici_id AS ID,satici_tc AS TC,satici_ad AS AD, satici_soyad AS SOYAD," +
                "satici_telefon AS TELEFON,satici_adres AS ADRES FROM Satici Where satici_ad Like'" + tbAd.Text + "%' ORDER BY satici_ad", conn);

                da.Fill(dsArama, "Satici");
                bsArama.DataSource = dsArama.Tables["Satici"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void tbSoyad_TextChanged(object sender, EventArgs e)
        {
            if (tbSoyad.Text.Trim() == "")
            {
                dataGridView1.DataSource = bsSatici;
            }
            else
            {
                dsArama.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT satici_id AS ID,satici_tc AS TC,satici_ad AS AD, satici_soyad AS SOYAD," +
                "satici_telefon AS TELEFON,satici_adres AS ADRES FROM Satici Where satici_soyad Like'" + tbSoyad.Text + "%' ORDER BY satici_ad", conn);

                da.Fill(dsArama, "Satici");
                bsArama.DataSource = dsArama.Tables["Satici"];
                dataGridView1.DataSource = bsArama;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (anaMenu == false)
            {
                kayitli_satici_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                tc = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                ad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                soyad = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                telefon = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                adres = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                this.Close();
            }
            else if(anaMenu == true)
            {
                Satici_Eylem eylem = new Satici_Eylem();
                eylem.oncekiForm_satici_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                eylem.tc = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                eylem.ad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                eylem.soyad = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                eylem.telefon = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                eylem.adres = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                eylem.ShowDialog();
                dataDoldur();
            }
            
        }

        
    }
}
