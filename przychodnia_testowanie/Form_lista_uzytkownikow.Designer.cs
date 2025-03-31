namespace przychodnia_testowanie
{
    partial class Form_lista_uzytkownikow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_lista_uzytkownikow));
            this.btn_wyszukiwarka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nowy_użytkow = new System.Windows.Forms.Button();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.dtGrdVw_lista_uż = new System.Windows.Forms.DataGridView();
            this.btn_edycja_użytkownika = new System.Windows.Forms.Button();
            this.btn_zapomnij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_lista_uż)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_wyszukiwarka
            // 
            this.btn_wyszukiwarka.Location = new System.Drawing.Point(787, 231);
            this.btn_wyszukiwarka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_wyszukiwarka.Name = "btn_wyszukiwarka";
            this.btn_wyszukiwarka.Size = new System.Drawing.Size(65, 25);
            this.btn_wyszukiwarka.TabIndex = 8;
            this.btn_wyszukiwarka.Text = "Szukaj";
            this.btn_wyszukiwarka.UseVisualStyleBackColor = true;
            this.btn_wyszukiwarka.Click += new System.EventHandler(this.btn_wyszukiwarka_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista użytkowników ";
            // 
            // btn_nowy_użytkow
            // 
            this.btn_nowy_użytkow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_nowy_użytkow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_nowy_użytkow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_nowy_użytkow.Location = new System.Drawing.Point(940, 12);
            this.btn_nowy_użytkow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nowy_użytkow.Name = "btn_nowy_użytkow";
            this.btn_nowy_użytkow.Size = new System.Drawing.Size(147, 44);
            this.btn_nowy_użytkow.TabIndex = 6;
            this.btn_nowy_użytkow.Text = "Dodaj użytkownika";
            this.btn_nowy_użytkow.UseVisualStyleBackColor = false;
            this.btn_nowy_użytkow.Click += new System.EventHandler(this.btn_nowy_użytkow_Click);
            // 
            // txb_search
            // 
            this.txb_search.Cursor = System.Windows.Forms.Cursors.Help;
            this.txb_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txb_search.Location = new System.Drawing.Point(421, 231);
            this.txb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(337, 22);
            this.txb_search.TabIndex = 5;
            // 
            // dtGrdVw_lista_uż
            // 
            this.dtGrdVw_lista_uż.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(202)))), ((int)(((byte)(224)))));
            this.dtGrdVw_lista_uż.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw_lista_uż.Location = new System.Drawing.Point(39, 391);
            this.dtGrdVw_lista_uż.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGrdVw_lista_uż.Name = "dtGrdVw_lista_uż";
            this.dtGrdVw_lista_uż.RowHeadersWidth = 51;
            this.dtGrdVw_lista_uż.RowTemplate.Height = 24;
            this.dtGrdVw_lista_uż.Size = new System.Drawing.Size(1093, 377);
            this.dtGrdVw_lista_uż.TabIndex = 9;
            // 
            // btn_edycja_użytkownika
            // 
            this.btn_edycja_użytkownika.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_edycja_użytkownika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_edycja_użytkownika.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edycja_użytkownika.Location = new System.Drawing.Point(693, 12);
            this.btn_edycja_użytkownika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edycja_użytkownika.Name = "btn_edycja_użytkownika";
            this.btn_edycja_użytkownika.Size = new System.Drawing.Size(147, 44);
            this.btn_edycja_użytkownika.TabIndex = 10;
            this.btn_edycja_użytkownika.Text = "Edytuj uzytkownika";
            this.btn_edycja_użytkownika.UseVisualStyleBackColor = false;
            this.btn_edycja_użytkownika.Click += new System.EventHandler(this.btn_edycja_użytkownika_Click);
            // 
            // btn_zapomnij
            // 
            this.btn_zapomnij.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_zapomnij.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_zapomnij.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_zapomnij.Location = new System.Drawing.Point(526, 12);
            this.btn_zapomnij.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_zapomnij.Name = "btn_zapomnij";
            this.btn_zapomnij.Size = new System.Drawing.Size(147, 44);
            this.btn_zapomnij.TabIndex = 11;
            this.btn_zapomnij.Text = "Zapomnij użytkownika";
            this.btn_zapomnij.UseVisualStyleBackColor = false;
            this.btn_zapomnij.Click += new System.EventHandler(this.btn_zapomnij_Click);
            // 
            // Form_lista_uzytkownikow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 791);
            this.Controls.Add(this.btn_zapomnij);
            this.Controls.Add(this.btn_edycja_użytkownika);
            this.Controls.Add(this.dtGrdVw_lista_uż);
            this.Controls.Add(this.btn_wyszukiwarka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_nowy_użytkow);
            this.Controls.Add(this.txb_search);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_lista_uzytkownikow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_lista_użytkow";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_lista_uż)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_wyszukiwarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nowy_użytkow;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.DataGridView dtGrdVw_lista_uż;
        private System.Windows.Forms.Button btn_edycja_użytkownika;
        private System.Windows.Forms.Button btn_zapomnij;
    }
}