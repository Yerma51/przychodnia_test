namespace przychodnia_testowanie
{
    partial class Form_lista_uprawnien
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
            this.btn_strona_glowna = new System.Windows.Forms.Button();
            this.dtGrdVw_lista_uprawnien = new System.Windows.Forms.DataGridView();
            this.lblTytul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_lista_uprawnien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_strona_glowna
            // 
            this.btn_strona_glowna.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_strona_glowna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_strona_glowna.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_strona_glowna.Location = new System.Drawing.Point(41, 19);
            this.btn_strona_glowna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_strona_glowna.Name = "btn_strona_glowna";
            this.btn_strona_glowna.Size = new System.Drawing.Size(147, 44);
            this.btn_strona_glowna.TabIndex = 25;
            this.btn_strona_glowna.Text = "Strona główna";
            this.btn_strona_glowna.UseVisualStyleBackColor = false;
            this.btn_strona_glowna.Click += new System.EventHandler(this.btn_strona_glowna_Click);
            // 
            // dtGrdVw_lista_uprawnien
            // 
            this.dtGrdVw_lista_uprawnien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(202)))), ((int)(((byte)(224)))));
            this.dtGrdVw_lista_uprawnien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw_lista_uprawnien.Location = new System.Drawing.Point(41, 178);
            this.dtGrdVw_lista_uprawnien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGrdVw_lista_uprawnien.Name = "dtGrdVw_lista_uprawnien";
            this.dtGrdVw_lista_uprawnien.ReadOnly = true;
            this.dtGrdVw_lista_uprawnien.RowHeadersWidth = 51;
            this.dtGrdVw_lista_uprawnien.RowTemplate.Height = 24;
            this.dtGrdVw_lista_uprawnien.Size = new System.Drawing.Size(1086, 594);
            this.dtGrdVw_lista_uprawnien.TabIndex = 23;
            this.dtGrdVw_lista_uprawnien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaUprawnien_CellContentClick);
            // 
            // lblTytul
            // 
            this.lblTytul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.lblTytul.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTytul.Location = new System.Drawing.Point(261, 110);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(665, 46);
            this.lblTytul.TabIndex = 21;
            this.lblTytul.Text = "Lista uprawnień dostępnych w systemie";
            this.lblTytul.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_lista_uprawnien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 791);
            this.Controls.Add(this.btn_strona_glowna);
            this.Controls.Add(this.dtGrdVw_lista_uprawnien);
            this.Controls.Add(this.lblTytul);
            this.Name = "Form_lista_uprawnien";
            this.Text = "Lista uprawnień";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_lista_uprawnien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_strona_glowna;
        private System.Windows.Forms.DataGridView dtGrdVw_lista_uprawnien;
        private System.Windows.Forms.Label lblTytul;
    }
}