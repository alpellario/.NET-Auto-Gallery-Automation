namespace Oto_Galeri
{
    partial class Satici_Eylem
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
            this.btSguncelle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btSsil = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // btSguncelle
            // 
            this.btSguncelle.Location = new System.Drawing.Point(159, 10);
            this.btSguncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btSguncelle.Name = "btSguncelle";
            this.btSguncelle.Size = new System.Drawing.Size(143, 97);
            this.btSguncelle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSguncelle.TabIndex = 5;
            this.btSguncelle.Values.Text = "Satici Güncelle";
            this.btSguncelle.Click += new System.EventHandler(this.btSguncelle_Click);
            // 
            // btSsil
            // 
            this.btSsil.Location = new System.Drawing.Point(4, 10);
            this.btSsil.Margin = new System.Windows.Forms.Padding(2);
            this.btSsil.Name = "btSsil";
            this.btSsil.Size = new System.Drawing.Size(143, 97);
            this.btSsil.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSsil.TabIndex = 4;
            this.btSsil.Values.Text = "Satıcı Sil";
            this.btSsil.Click += new System.EventHandler(this.btSsil_Click);
            // 
            // Satici_Eylem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 115);
            this.Controls.Add(this.btSguncelle);
            this.Controls.Add(this.btSsil);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Satici_Eylem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Satici_Eylem";
            this.Load += new System.EventHandler(this.Satici_Eylem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btSguncelle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btSsil;
    }
}