namespace Oto_Galeri
{
    partial class G_Depo_Tutar
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
            this.gbTeslim = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btTutar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tbTutar = new System.Windows.Forms.TextBox();
            this.gbTeslim.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTeslim
            // 
            this.gbTeslim.Controls.Add(this.label13);
            this.gbTeslim.Controls.Add(this.label14);
            this.gbTeslim.Controls.Add(this.btTutar);
            this.gbTeslim.Controls.Add(this.tbTutar);
            this.gbTeslim.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTeslim.Location = new System.Drawing.Point(9, 10);
            this.gbTeslim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTeslim.Name = "gbTeslim";
            this.gbTeslim.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTeslim.Size = new System.Drawing.Size(188, 167);
            this.gbTeslim.TabIndex = 14;
            this.gbTeslim.TabStop = false;
            this.gbTeslim.Text = "SATIŞ FİYAT BELİRLEME";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(64, 35);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "TUTAR";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(166, 65);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 21);
            this.label14.TabIndex = 28;
            this.label14.Text = "₺";
            // 
            // btTutar
            // 
            this.btTutar.Location = new System.Drawing.Point(40, 102);
            this.btTutar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTutar.Name = "btTutar";
            this.btTutar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.btTutar.Size = new System.Drawing.Size(106, 41);
            this.btTutar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btTutar.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btTutar.StateCommon.Border.Rounding = 10;
            this.btTutar.TabIndex = 29;
            this.btTutar.Values.Text = "Galeriye Çıkar";
            this.btTutar.Click += new System.EventHandler(this.btTutar_Click);
            // 
            // tbTutar
            // 
            this.tbTutar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTutar.Location = new System.Drawing.Point(20, 62);
            this.tbTutar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTutar.Name = "tbTutar";
            this.tbTutar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTutar.Size = new System.Drawing.Size(144, 28);
            this.tbTutar.TabIndex = 26;
            this.tbTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTutar_KeyPress);
            // 
            // G_Depo_Tutar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 183);
            this.Controls.Add(this.gbTeslim);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "G_Depo_Tutar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "G_Depo_Tutar";
            this.gbTeslim.ResumeLayout(false);
            this.gbTeslim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTeslim;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btTutar;
        private System.Windows.Forms.TextBox tbTutar;
    }
}