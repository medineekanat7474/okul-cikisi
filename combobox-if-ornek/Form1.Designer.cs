namespace combobox_if_ornek
{
    partial class Form1
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
            this.cbgünler = new System.Windows.Forms.ComboBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbgünler
            // 
            this.cbgünler.FormattingEnabled = true;
            this.cbgünler.Items.AddRange(new object[] {
            "pazartesi",
            "salı",
            "çarşamba",
            "perşembe",
            "cuma",
            "cumartesi"});
            this.cbgünler.Location = new System.Drawing.Point(12, 12);
            this.cbgünler.Name = "cbgünler";
            this.cbgünler.Size = new System.Drawing.Size(176, 21);
            this.cbgünler.TabIndex = 0;
            this.cbgünler.SelectedIndexChanged += new System.EventHandler(this.cbgünler_SelectedIndexChanged);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(8, 138);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(64, 20);
            this.lblDurum.TabIndex = 1;
            this.lblDurum.Text = "durum:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 185);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.cbgünler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbgünler;
        private System.Windows.Forms.Label lblDurum;
    }
}

