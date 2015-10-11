namespace IspitniProjekat
{
    partial class EntForma
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnOtkazi = new MetroFramework.Controls.MetroButton();
            this.btnSacuvaj = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnSacuvaj);
            this.metroPanel1.Controls.Add(this.btnOtkazi);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(5, 394);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(551, 41);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOtkazi.Location = new System.Drawing.Point(416, 0);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(135, 41);
            this.btnOtkazi.TabIndex = 2;
            this.btnOtkazi.TabStop = false;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOtkazi.UseSelectable = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSacuvaj.Location = new System.Drawing.Point(281, 0);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(135, 41);
            this.btnSacuvaj.TabIndex = 3;
            this.btnSacuvaj.TabStop = false;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSacuvaj.UseSelectable = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // EntForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 440);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "EntForma";
            this.Padding = new System.Windows.Forms.Padding(5, 60, 5, 5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Entitet";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnSacuvaj;
        private MetroFramework.Controls.MetroButton btnOtkazi;
    }
}