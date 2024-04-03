namespace Oto_Galeri
{
    partial class Galeri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAracGiris = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSatisTutar = new System.Windows.Forms.Label();
            this.lbBilgi = new System.Windows.Forms.Label();
            this.lbDurum = new System.Windows.Forms.Label();
            this.lbRenk = new System.Windows.Forms.Label();
            this.lbYil = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbMarka = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btAracGiris
            // 
            this.btAracGiris.Location = new System.Drawing.Point(26, 120);
            this.btAracGiris.Margin = new System.Windows.Forms.Padding(2);
            this.btAracGiris.Name = "btAracGiris";
            this.btAracGiris.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.btAracGiris.Size = new System.Drawing.Size(167, 105);
            this.btAracGiris.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btAracGiris.StateNormal.Content.ShortText.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btAracGiris.TabIndex = 0;
            this.btAracGiris.Values.Text = "DEPODAN ARAÇ \r\n     GİRİŞİ YAP";
            this.btAracGiris.Click += new System.EventHandler(this.btAracGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eylemde bulunmak istediğiniz aracın üzerine çift tıklayınız.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(9, 254);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 258);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSatisTutar);
            this.groupBox1.Controls.Add(this.lbBilgi);
            this.groupBox1.Controls.Add(this.lbDurum);
            this.groupBox1.Controls.Add(this.lbRenk);
            this.groupBox1.Controls.Add(this.lbYil);
            this.groupBox1.Controls.Add(this.lbModel);
            this.groupBox1.Controls.Add(this.lbMarka);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(228, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(524, 153);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri";
            // 
            // lbSatisTutar
            // 
            this.lbSatisTutar.AutoSize = true;
            this.lbSatisTutar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSatisTutar.Location = new System.Drawing.Point(335, 94);
            this.lbSatisTutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSatisTutar.Name = "lbSatisTutar";
            this.lbSatisTutar.Size = new System.Drawing.Size(66, 21);
            this.lbSatisTutar.TabIndex = 11;
            this.lbSatisTutar.Text = "label15";
            // 
            // lbBilgi
            // 
            this.lbBilgi.AutoSize = true;
            this.lbBilgi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBilgi.Location = new System.Drawing.Point(335, 63);
            this.lbBilgi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBilgi.Name = "lbBilgi";
            this.lbBilgi.Size = new System.Drawing.Size(66, 21);
            this.lbBilgi.TabIndex = 10;
            this.lbBilgi.Text = "label14";
            // 
            // lbDurum
            // 
            this.lbDurum.AutoSize = true;
            this.lbDurum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDurum.Location = new System.Drawing.Point(335, 29);
            this.lbDurum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDurum.Name = "lbDurum";
            this.lbDurum.Size = new System.Drawing.Size(66, 21);
            this.lbDurum.TabIndex = 9;
            this.lbDurum.Text = "label13";
            // 
            // lbRenk
            // 
            this.lbRenk.AutoSize = true;
            this.lbRenk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbRenk.Location = new System.Drawing.Point(84, 124);
            this.lbRenk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRenk.Name = "lbRenk";
            this.lbRenk.Size = new System.Drawing.Size(66, 21);
            this.lbRenk.TabIndex = 8;
            this.lbRenk.Text = "label12";
            // 
            // lbYil
            // 
            this.lbYil.AutoSize = true;
            this.lbYil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbYil.Location = new System.Drawing.Point(84, 94);
            this.lbYil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbYil.Name = "lbYil";
            this.lbYil.Size = new System.Drawing.Size(66, 21);
            this.lbYil.TabIndex = 7;
            this.lbYil.Text = "label11";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbModel.Location = new System.Drawing.Point(84, 63);
            this.lbModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(66, 21);
            this.lbModel.TabIndex = 6;
            this.lbModel.Text = "label10";
            // 
            // lbMarka
            // 
            this.lbMarka.AutoSize = true;
            this.lbMarka.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbMarka.Location = new System.Drawing.Point(84, 29);
            this.lbMarka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMarka.Name = "lbMarka";
            this.lbMarka.Size = new System.Drawing.Size(57, 21);
            this.lbMarka.TabIndex = 5;
            this.lbMarka.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(229, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "SATIS TUTARI :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(280, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "BİLGİ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(262, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "DURUM :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(26, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "RENK :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(44, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "YIL :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "MODEL :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(10, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "MARKA :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(782, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(216, 239);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Fotoğrafı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(441, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 33);
            this.label9.TabIndex = 31;
            this.label9.Text = "GALERİ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Oto_Galeri.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(34, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // Galeri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1022, 522);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAracGiris);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Galeri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galeri";
            this.Load += new System.EventHandler(this.Galeri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btAracGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSatisTutar;
        private System.Windows.Forms.Label lbBilgi;
        private System.Windows.Forms.Label lbDurum;
        private System.Windows.Forms.Label lbRenk;
        private System.Windows.Forms.Label lbYil;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbMarka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}