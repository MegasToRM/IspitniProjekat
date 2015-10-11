namespace IspitniProjekat
{
    partial class GlavnaForma
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.panGlavniMeni = new MetroFramework.Controls.MetroPanel();
            this.btnObrisi = new MetroFramework.Controls.MetroButton();
            this.panListaTabela = new MetroFramework.Controls.MetroPanel();
            this.grPrikazPodataka = new MetroFramework.Controls.MetroGrid();
            this.btnIzmeni = new MetroFramework.Controls.MetroButton();
            this.btnDodaj = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiStyleManager)).BeginInit();
            this.panGlavniMeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grPrikazPodataka)).BeginInit();
            this.SuspendLayout();
            // 
            // uiStyleManager
            // 
            this.uiStyleManager.Owner = this;
            this.uiStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // panGlavniMeni
            // 
            this.panGlavniMeni.Controls.Add(this.btnDodaj);
            this.panGlavniMeni.Controls.Add(this.btnIzmeni);
            this.panGlavniMeni.Controls.Add(this.btnObrisi);
            this.panGlavniMeni.Dock = System.Windows.Forms.DockStyle.Top;
            this.panGlavniMeni.HorizontalScrollbarBarColor = true;
            this.panGlavniMeni.HorizontalScrollbarHighlightOnWheel = false;
            this.panGlavniMeni.HorizontalScrollbarSize = 10;
            this.panGlavniMeni.Location = new System.Drawing.Point(5, 60);
            this.panGlavniMeni.Name = "panGlavniMeni";
            this.panGlavniMeni.Size = new System.Drawing.Size(926, 29);
            this.panGlavniMeni.TabIndex = 1;
            this.panGlavniMeni.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panGlavniMeni.VerticalScrollbarBarColor = true;
            this.panGlavniMeni.VerticalScrollbarHighlightOnWheel = false;
            this.panGlavniMeni.VerticalScrollbarSize = 10;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnObrisi.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnObrisi.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnObrisi.Location = new System.Drawing.Point(778, 0);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(148, 29);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.TabStop = false;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnObrisi.UseSelectable = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // panListaTabela
            // 
            this.panListaTabela.Dock = System.Windows.Forms.DockStyle.Left;
            this.panListaTabela.HorizontalScrollbar = true;
            this.panListaTabela.HorizontalScrollbarBarColor = true;
            this.panListaTabela.HorizontalScrollbarHighlightOnWheel = false;
            this.panListaTabela.HorizontalScrollbarSize = 10;
            this.panListaTabela.Location = new System.Drawing.Point(5, 89);
            this.panListaTabela.Name = "panListaTabela";
            this.panListaTabela.Size = new System.Drawing.Size(144, 398);
            this.panListaTabela.TabIndex = 3;
            this.panListaTabela.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panListaTabela.VerticalScrollbar = true;
            this.panListaTabela.VerticalScrollbarBarColor = true;
            this.panListaTabela.VerticalScrollbarHighlightOnWheel = false;
            this.panListaTabela.VerticalScrollbarSize = 10;
            // 
            // grPrikazPodataka
            // 
            this.grPrikazPodataka.AllowUserToResizeRows = false;
            this.grPrikazPodataka.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.grPrikazPodataka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grPrikazPodataka.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grPrikazPodataka.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grPrikazPodataka.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grPrikazPodataka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grPrikazPodataka.DefaultCellStyle = dataGridViewCellStyle2;
            this.grPrikazPodataka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grPrikazPodataka.EnableHeadersVisualStyles = false;
            this.grPrikazPodataka.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grPrikazPodataka.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.grPrikazPodataka.Location = new System.Drawing.Point(149, 89);
            this.grPrikazPodataka.Name = "grPrikazPodataka";
            this.grPrikazPodataka.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grPrikazPodataka.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grPrikazPodataka.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grPrikazPodataka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grPrikazPodataka.Size = new System.Drawing.Size(782, 398);
            this.grPrikazPodataka.TabIndex = 4;
            this.grPrikazPodataka.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIzmeni.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIzmeni.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnIzmeni.Location = new System.Drawing.Point(630, 0);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(148, 29);
            this.btnIzmeni.TabIndex = 6;
            this.btnIzmeni.TabStop = false;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnIzmeni.UseSelectable = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDodaj.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDodaj.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDodaj.Location = new System.Drawing.Point(482, 0);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(148, 29);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.TabStop = false;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDodaj.UseSelectable = true;
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(936, 492);
            this.Controls.Add(this.grPrikazPodataka);
            this.Controls.Add(this.panListaTabela);
            this.Controls.Add(this.panGlavniMeni);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "GlavnaForma";
            this.Padding = new System.Windows.Forms.Padding(5, 60, 5, 5);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StyleManager = this.uiStyleManager;
            this.Text = "Ispitni projekat";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.uiStyleManager)).EndInit();
            this.panGlavniMeni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grPrikazPodataka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager uiStyleManager;
        private MetroFramework.Controls.MetroPanel panGlavniMeni;
        private MetroFramework.Controls.MetroButton btnObrisi;
        private MetroFramework.Controls.MetroGrid grPrikazPodataka;
        private MetroFramework.Controls.MetroPanel panListaTabela;
        private MetroFramework.Controls.MetroButton btnDodaj;
        private MetroFramework.Controls.MetroButton btnIzmeni;
    }
}

