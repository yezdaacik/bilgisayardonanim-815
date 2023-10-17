namespace bilgisayar_donanım_815
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
            this.lbBilgisayar = new System.Windows.Forms.ListBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBilgisayar
            // 
            this.lbBilgisayar.FormattingEnabled = true;
            this.lbBilgisayar.Items.AddRange(new object[] {
            "Mouse",
            "Yazıcı",
            "Klavye",
            "Hoparlör",
            "Kamera",
            "Tarayıcı",
            "Pojeksiyon"});
            this.lbBilgisayar.Location = new System.Drawing.Point(12, 12);
            this.lbBilgisayar.Name = "lbBilgisayar";
            this.lbBilgisayar.Size = new System.Drawing.Size(120, 108);
            this.lbBilgisayar.TabIndex = 0;
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(12, 122);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(120, 31);
            this.btnKontrol.TabIndex = 1;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(152, 186);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.lbBilgisayar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBilgisayar;
        private System.Windows.Forms.Button btnKontrol;
    }
}

