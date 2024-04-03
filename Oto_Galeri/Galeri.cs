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
    public partial class Galeri : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=OtoGaleri;Integrated Security=true");
        DataSet dsArac = new DataSet();
        BindingSource bsArac = new BindingSource();
        string image = string.Empty;

        void datadoldur()
        {
            dsArac.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT AR.arac_id AS 'ARAC ID',AR.arac_plaka AS 'ARAC PLAKA',AR.arac_marka AS 'ARAC MARKA', AR.arac_model AS 'ARAC MODEL', AR.arac_yil " +
                "AS 'ARAC YIL', AR.arac_renk AS 'ARAC RENK', AR.arac_durum AS 'ARAC DURUM', AR.arac_bilgi AS 'ARAC BİLGİ', FORMAT(SF.satis_tutar,'N','tr-TR') + ' TL' AS 'SATİS TUTAR' " +
                "FROM Arac AR INNER JOIN SatisFiyat SF ON AR.arac_id=SF.arac_id " +
                             "INNER JOIN Galeri GA ON AR.arac_id=GA.arac_id ORDER BY AR.arac_id DESC", conn);
            da.Fill(dsArac, "Galeri");
            conn.Close();
            bsArac.DataSource = dsArac.Tables["Galeri"];
            dataGridView1.DataSource = bsArac;
        }
        public Galeri()
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
        private void Galeri_Load(object sender, EventArgs e)
        {
            temizle();
            dataGridView1.RowTemplate.Height = 30;
            datadoldur();
            for (int i = 0; i < 9; i++)
            {
                this.dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.SpringGreen;
            this.dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11);
            this.dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 12);

        }


        private void btAracGiris_Click(object sender, EventArgs e)
        {
            G_Depo gdepo = new G_Depo();
            gdepo.ShowDialog();
            datadoldur();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Eylem fr_eylem = new Eylem();
            fr_eylem.temp_arac_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            fr_eylem.ShowDialog();
            datadoldur();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temizle();
            SqlCommand resim = new SqlCommand();
            resim.Connection = conn;
            resim.CommandText = "SELECT arac_resim,arac_marka,arac_model,arac_yil,arac_renk,arac_durum,arac_bilgi,satis_tutar " +
                "FROM Arac INNER JOIN SatisFiyat ON ARAC.arac_id=SatisFiyat.arac_id WHERE Arac.arac_id=@arac_id";
            resim.Parameters.AddWithValue("@arac_id", int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = resim.ExecuteReader();
            while (dr.Read())
            {
                image = dr["arac_resim"].ToString();
                lbMarka.Text = dr["arac_marka"].ToString();
                lbModel.Text = dr["arac_model"].ToString();
                lbYil.Text = dr["arac_yil"].ToString();
                lbRenk.Text = dr["arac_renk"].ToString();
                lbDurum.Text = dr["arac_durum"].ToString();
                lbBilgi.Text = dr["arac_bilgi"].ToString();
                lbSatisTutar.Text = dr["satis_tutar"].ToString()+" ₺";
            }
            dr.Close();
            conn.Close();
            string imagePath = Application.StartupPath + "\\pictures\\" + image;
            pictureBox1.ImageLocation = imagePath;
        }

        void temizle()
        {
            lbMarka.Text = ""; lbModel.Text = ""; lbYil.Text = ""; lbRenk.Text = "";lbDurum.Text = "";lbBilgi.Text = "";lbSatisTutar.Text = "";
            image = "";
        }

       
    }
}
