namespace Oto_Galeri
{
    partial class G_Depo_Onay
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
            this.btOnay = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.arac_guncelle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // btOnay
            // 
            this.btOnay.Location = new System.Drawing.Point(183, 22);
            this.btOnay.Margin = new System.Windows.Forms.Padding(2);
            this.btOnay.Name = "btOnay";
            this.btOnay.Size = new System.Drawing.Size(143, 97);
            this.btOnay.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btOnay.TabIndex = 0;
            this.btOnay.Values.Text = "Galeriye Gönder";
            this.btOnay.Click += new System.EventHandler(this.btOnay_Click);
            // 
            // arac_guncelle
            // 
            this.arac_guncelle.Location = new System.Drawing.Point(18, 22);
            this.arac_guncelle.Margin = new System.Windows.Forms.Padding(2);
            this.arac_guncelle.Name = "arac_guncelle";
            this.arac_guncelle.Size = new System.Drawing.Size(143, 97);
            this.arac_guncelle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arac_guncelle.TabIndex = 1;
            this.arac_guncelle.Values.Text = "Araç Bilgileri Güncelle";
            this.arac_guncelle.Click += new System.EventHandler(this.arac_guncelle_Click);
            // 
            // G_Depo_Onay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 135);
            this.Controls.Add(this.arac_guncelle);
            this.Controls.Add(this.btOnay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "G_Depo_Onay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ONAY";
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btOnay;
        private ComponentFactory.Krypton.Toolkit.KryptonButton arac_guncelle;
    }
}