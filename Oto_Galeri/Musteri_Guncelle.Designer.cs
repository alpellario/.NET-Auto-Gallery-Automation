namespace Oto_Galeri
{
    partial class Musteri_Guncelle
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
            this.gbMusteri = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbYabanci = new System.Windows.Forms.CheckBox();
            this.tbMtc = new System.Windows.Forms.TextBox();
            this.btMusteriKaydet = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMtel = new System.Windows.Forms.TextBox();
            this.tbMadres = new System.Windows.Forms.TextBox();
            this.gbMusteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMusteri
            // 
            this.gbMusteri.Controls.Add(this.label15);
            this.gbMusteri.Controls.Add(this.cbYabanci);
            this.gbMusteri.Controls.Add(this.tbMtc);
            this.gbMusteri.Controls.Add(this.btMusteriKaydet);
            this.gbMusteri.Controls.Add(this.label1);
            this.gbMusteri.Controls.Add(this.label4);
            this.gbMusteri.Controls.Add(this.tbMad);
            this.gbMusteri.Controls.Add(this.label3);
            this.gbMusteri.Controls.Add(this.tbMsoyad);
            this.gbMusteri.Controls.Add(this.label2);
            this.gbMusteri.Controls.Add(this.tbMtel);
            this.gbMusteri.Controls.Add(this.tbMadres);
            this.gbMusteri.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMusteri.Location = new System.Drawing.Point(9, 10);
            this.gbMusteri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMusteri.Name = "gbMusteri";
            this.gbMusteri.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMusteri.Size = new System.Drawing.Size(263, 342);
            this.gbMusteri.TabIndex = 16;
            this.gbMusteri.TabStop = false;
            this.gbMusteri.Text = "Müşteri Bilgileri";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(59, 58);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 21);
            this.label15.TabIndex = 17;
            this.label15.Text = "TC : ";
            // 
            // cbYabanci
            // 
            this.cbYabanci.AutoSize = true;
            this.cbYabanci.Location = new System.Drawing.Point(106, 27);
            this.cbYabanci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbYabanci.Name = "cbYabanci";
            this.cbYabanci.Size = new System.Drawing.Size(142, 25);
            this.cbYabanci.TabIndex = 16;
            this.cbYabanci.Text = "Yabancı Uyruklu";
            this.cbYabanci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbYabanci.UseVisualStyleBackColor = true;
            this.cbYabanci.CheckedChanged += new System.EventHandler(this.cbYabanci_CheckedChanged);
            // 
            // tbMtc
            // 
            this.tbMtc.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMtc.Location = new System.Drawing.Point(106, 55);
            this.tbMtc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMtc.MaxLength = 12;
            this.tbMtc.Name = "tbMtc";
            this.tbMtc.Size = new System.Drawing.Size(144, 28);
            this.tbMtc.TabIndex = 15;
            this.tbMtc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btMusteriKaydet
            // 
            this.btMusteriKaydet.Location = new System.Drawing.Point(73, 285);
            this.btMusteriKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btMusteriKaydet.Name = "btMusteriKaydet";
            this.btMusteriKaydet.Size = new System.Drawing.Size(133, 52);
            this.btMusteriKaydet.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btMusteriKaydet.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btMusteriKaydet.StateCommon.Border.Rounding = 10;
            this.btMusteriKaydet.TabIndex = 12;
            this.btMusteriKaydet.Values.Text = "Müşteri Güncelle";
            this.btMusteriKaydet.Click += new System.EventHandler(this.btMusteriKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "AD : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "ADRES : ";
            // 
            // tbMad
            // 
            this.tbMad.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMad.Location = new System.Drawing.Point(106, 87);
            this.tbMad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMad.Name = "tbMad";
            this.tbMad.Size = new System.Drawing.Size(144, 28);
            this.tbMad.TabIndex = 4;
            this.tbMad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "TELEFON : ";
            // 
            // tbMsoyad
            // 
            this.tbMsoyad.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMsoyad.Location = new System.Drawing.Point(106, 120);
            this.tbMsoyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMsoyad.Name = "tbMsoyad";
            this.tbMsoyad.Size = new System.Drawing.Size(144, 28);
            this.tbMsoyad.TabIndex = 5;
            this.tbMsoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "SOYAD : ";
            // 
            // tbMtel
            // 
            this.tbMtel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMtel.Location = new System.Drawing.Point(106, 154);
            this.tbMtel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMtel.MaxLength = 11;
            this.tbMtel.Name = "tbMtel";
            this.tbMtel.Size = new System.Drawing.Size(144, 28);
            this.tbMtel.TabIndex = 6;
            this.tbMtel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMadres
            // 
            this.tbMadres.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMadres.Location = new System.Drawing.Point(106, 187);
            this.tbMadres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMadres.Multiline = true;
            this.tbMadres.Name = "tbMadres";
            this.tbMadres.Size = new System.Drawing.Size(144, 84);
            this.tbMadres.TabIndex = 7;
            // 
            // Musteri_Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.gbMusteri);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Musteri_Guncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Musteri_Guncelle";
            this.Load += new System.EventHandler(this.Musteri_Guncelle_Load);
            this.gbMusteri.ResumeLayout(false);
            this.gbMusteri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMusteri;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox cbYabanci;
        private System.Windows.Forms.TextBox tbMtc;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btMusteriKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMtel;
        private System.Windows.Forms.TextBox tbMadres;
    }
}