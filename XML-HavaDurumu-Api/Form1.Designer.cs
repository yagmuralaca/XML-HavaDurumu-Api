namespace XML_HavaDurumu_Api
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_goster = new System.Windows.Forms.Button();
            this.dg_havaDurumu = new System.Windows.Forms.DataGridView();
            this.sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mak_sicaklik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_havaDurumu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_goster
            // 
            this.btn_goster.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_goster.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_goster.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_goster.Location = new System.Drawing.Point(21, 22);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(442, 34);
            this.btn_goster.TabIndex = 0;
            this.btn_goster.Text = "HAVA DURUMUNU GÖSTER";
            this.btn_goster.UseVisualStyleBackColor = false;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // dg_havaDurumu
            // 
            this.dg_havaDurumu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_havaDurumu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dg_havaDurumu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg_havaDurumu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_havaDurumu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_havaDurumu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sehir,
            this.durum,
            this.mak_sicaklik});
            this.dg_havaDurumu.Location = new System.Drawing.Point(21, 76);
            this.dg_havaDurumu.Name = "dg_havaDurumu";
            this.dg_havaDurumu.RowTemplate.Height = 25;
            this.dg_havaDurumu.Size = new System.Drawing.Size(442, 242);
            this.dg_havaDurumu.TabIndex = 1;
            // 
            // sehir
            // 
            this.sehir.HeaderText = "Şehir";
            this.sehir.Name = "sehir";
            // 
            // durum
            // 
            this.durum.HeaderText = "Durum";
            this.durum.Name = "durum";
            // 
            // mak_sicaklik
            // 
            this.mak_sicaklik.HeaderText = "Sıcaklık";
            this.mak_sicaklik.Name = "mak_sicaklik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 334);
            this.Controls.Add(this.dg_havaDurumu);
            this.Controls.Add(this.btn_goster);
            this.Name = "Form1";
            this.Text = "Hava Durumu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_havaDurumu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_goster;
        private DataGridView dg_havaDurumu;
        private DataGridViewTextBoxColumn sehir;
        private DataGridViewTextBoxColumn durum;
        private DataGridViewTextBoxColumn mak_sicaklik;
    }
}