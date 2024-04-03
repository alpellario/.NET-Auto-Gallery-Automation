namespace Oto_Galeri
{
    partial class Eylem
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
            this.btGuncelle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btGonder = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btAracSat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // btGuncelle
            // 
            this.btGuncelle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btGuncelle.Location = new System.Drawing.Point(9, 8);
            this.btGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btGuncelle.Name = "btGuncelle";
            this.btGuncelle.Size = new System.Drawing.Size(100, 98);
            this.btGuncelle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btGuncelle.TabIndex = 0;
            this.btGuncelle.Values.Text = "Araç Bilgilerini \r\n     Güncelle";
            this.btGuncelle.Click += new System.EventHandler(this.btGuncelle_Click);
            // 
            // btGonder
            // 
            this.btGonder.Location = new System.Drawing.Point(114, 8);
            this.btGonder.Margin = new System.Windows.Forms.Padding(2);
            this.btGonder.Name = "btGonder";
            this.btGonder.Size = new System.Drawing.Size(100, 98);
            this.btGonder.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btGonder.TabIndex = 1;
            this.btGonder.Values.Text = "Aracı Depoya \r\n     Gönder";
            this.btGonder.Click += new System.EventHandler(this.btGonder_Click);
            // 
            // btAracSat
            // 
            this.btAracSat.Location = new System.Drawing.Point(219, 8);
            this.btAracSat.Margin = new System.Windows.Forms.Padding(2);
            this.btAracSat.Name = "btAracSat";
            this.btAracSat.Size = new System.Drawing.Size(100, 98);
            this.btAracSat.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btAracSat.TabIndex = 2;
            this.btAracSat.Values.Text = "Aracı Sat";
            this.btAracSat.Click += new System.EventHandler(this.btAracSat_Click);
            // 
            // Eylem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 112);
            this.Controls.Add(this.btAracSat);
            this.Controls.Add(this.btGonder);
            this.Controls.Add(this.btGuncelle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Eylem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eylem";
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btGuncelle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btGonder;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btAracSat;
    }
}