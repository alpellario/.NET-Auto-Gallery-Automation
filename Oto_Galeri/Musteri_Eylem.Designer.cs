namespace Oto_Galeri
{
    partial class Musteri_Eylem
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
            this.btMsil = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btMguncelle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // btMsil
            // 
            this.btMsil.Location = new System.Drawing.Point(9, 10);
            this.btMsil.Margin = new System.Windows.Forms.Padding(2);
            this.btMsil.Name = "btMsil";
            this.btMsil.Size = new System.Drawing.Size(143, 97);
            this.btMsil.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btMsil.TabIndex = 2;
            this.btMsil.Values.Text = "Müşteri Sil";
            this.btMsil.Click += new System.EventHandler(this.btMsil_Click);
            // 
            // btMguncelle
            // 
            this.btMguncelle.Location = new System.Drawing.Point(164, 10);
            this.btMguncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btMguncelle.Name = "btMguncelle";
            this.btMguncelle.Size = new System.Drawing.Size(143, 97);
            this.btMguncelle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btMguncelle.TabIndex = 3;
            this.btMguncelle.Values.Text = "Müşteri Güncelle";
            this.btMguncelle.Click += new System.EventHandler(this.btMguncelle_Click);
            // 
            // Musteri_Eylem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 114);
            this.Controls.Add(this.btMguncelle);
            this.Controls.Add(this.btMsil);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Musteri_Eylem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Musteri_Eylem";
            this.Load += new System.EventHandler(this.Musteri_Eylem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btMsil;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btMguncelle;
    }
}