namespace Oto_Galeri
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSaticiArac = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btAracKayit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btGaleri = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btDepo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btSatislar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btAlislar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btSaticilar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btMusteriler = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSaticiArac
            // 
            this.btSaticiArac.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btSaticiArac.Location = new System.Drawing.Point(14, 34);
            this.btSaticiArac.Margin = new System.Windows.Forms.Padding(2);
            this.btSaticiArac.Name = "btSaticiArac";
            this.btSaticiArac.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btSaticiArac.Size = new System.Drawing.Size(157, 49);
            this.btSaticiArac.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btSaticiArac.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btSaticiArac.StateCommon.Border.Rounding = 10;
            this.btSaticiArac.TabIndex = 0;
            this.btSaticiArac.Values.Text = "SATICI / ARAÇ KAYIT";
            this.btSaticiArac.Click += new System.EventHandler(this.btSaticiArac_Click);
            // 
            // btAracKayit
            // 
            this.btAracKayit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btAracKayit.Location = new System.Drawing.Point(175, 34);
            this.btAracKayit.Margin = new System.Windows.Forms.Padding(2);
            this.btAracKayit.Name = "btAracKayit";
            this.btAracKayit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btAracKayit.Size = new System.Drawing.Size(157, 49);
            this.btAracKayit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btAracKayit.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btAracKayit.StateCommon.Border.Rounding = 10;
            this.btAracKayit.TabIndex = 1;
            this.btAracKayit.Values.Text = "ARAÇ KAYIT";
            this.btAracKayit.Click += new System.EventHandler(this.btAracKayit_Click);
            // 
            // btGaleri
            // 
            this.btGaleri.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btGaleri.Location = new System.Drawing.Point(14, 88);
            this.btGaleri.Margin = new System.Windows.Forms.Padding(2);
            this.btGaleri.Name = "btGaleri";
            this.btGaleri.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btGaleri.Size = new System.Drawing.Size(157, 49);
            this.btGaleri.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btGaleri.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btGaleri.StateCommon.Border.Rounding = 10;
            this.btGaleri.TabIndex = 2;
            this.btGaleri.Values.Text = "GALERİ";
            this.btGaleri.Click += new System.EventHandler(this.btGaleri_Click);
            // 
            // btDepo
            // 
            this.btDepo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btDepo.Location = new System.Drawing.Point(175, 88);
            this.btDepo.Margin = new System.Windows.Forms.Padding(2);
            this.btDepo.Name = "btDepo";
            this.btDepo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btDepo.Size = new System.Drawing.Size(157, 49);
            this.btDepo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btDepo.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btDepo.StateCommon.Border.Rounding = 10;
            this.btDepo.TabIndex = 3;
            this.btDepo.Values.Text = "DEPO";
            this.btDepo.Click += new System.EventHandler(this.btDepo_Click);
            // 
            // btSatislar
            // 
            this.btSatislar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btSatislar.Location = new System.Drawing.Point(18, 32);
            this.btSatislar.Margin = new System.Windows.Forms.Padding(2);
            this.btSatislar.Name = "btSatislar";
            this.btSatislar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btSatislar.Size = new System.Drawing.Size(157, 49);
            this.btSatislar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btSatislar.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btSatislar.StateCommon.Border.Rounding = 10;
            this.btSatislar.TabIndex = 4;
            this.btSatislar.Values.Text = "ARAÇ SATIŞLARI";
            this.btSatislar.Click += new System.EventHandler(this.btSatislar_Click);
            // 
            // btAlislar
            // 
            this.btAlislar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btAlislar.Location = new System.Drawing.Point(179, 32);
            this.btAlislar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlislar.Name = "btAlislar";
            this.btAlislar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btAlislar.Size = new System.Drawing.Size(157, 49);
            this.btAlislar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btAlislar.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btAlislar.StateCommon.Border.Rounding = 10;
            this.btAlislar.TabIndex = 5;
            this.btAlislar.Values.Text = "ALINAN ARAÇLAR";
            this.btAlislar.Click += new System.EventHandler(this.btAlislar_Click);
            // 
            // btSaticilar
            // 
            this.btSaticilar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btSaticilar.Location = new System.Drawing.Point(179, 86);
            this.btSaticilar.Margin = new System.Windows.Forms.Padding(2);
            this.btSaticilar.Name = "btSaticilar";
            this.btSaticilar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btSaticilar.Size = new System.Drawing.Size(157, 49);
            this.btSaticilar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btSaticilar.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btSaticilar.StateCommon.Border.Rounding = 10;
            this.btSaticilar.TabIndex = 7;
            this.btSaticilar.Values.Text = "SATICILAR";
            this.btSaticilar.Click += new System.EventHandler(this.btSaticilar_Click);
            // 
            // btMusteriler
            // 
            this.btMusteriler.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btMusteriler.Location = new System.Drawing.Point(18, 86);
            this.btMusteriler.Margin = new System.Windows.Forms.Padding(2);
            this.btMusteriler.Name = "btMusteriler";
            this.btMusteriler.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btMusteriler.Size = new System.Drawing.Size(157, 49);
            this.btMusteriler.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btMusteriler.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btMusteriler.StateCommon.Border.Rounding = 10;
            this.btMusteriler.TabIndex = 6;
            this.btMusteriler.Values.Text = "MÜŞTERİLER";
            this.btMusteriler.Click += new System.EventHandler(this.btMusteriler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDepo);
            this.groupBox1.Controls.Add(this.btGaleri);
            this.groupBox1.Controls.Add(this.btAracKayit);
            this.groupBox1.Controls.Add(this.btSaticiArac);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(22, 307);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(352, 161);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş İşlemleri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btAlislar);
            this.groupBox2.Controls.Add(this.btSatislar);
            this.groupBox2.Controls.Add(this.btSaticilar);
            this.groupBox2.Controls.Add(this.btMusteriler);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(22, 497);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(352, 161);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listeleme İşlemleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "X OTO GALERİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Oto_Galeri.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(68, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btSaticiArac;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btAracKayit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btGaleri;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btDepo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSatislar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btAlislar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSaticilar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btMusteriler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

