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
            this.anuluj_wyszukiwarka = new System.Windows.Forms.Button();
            this.btn_strona_główna = new System.Windows.Forms.Button();
            this.btn_podglad_danych = new System.Windows.Forms.Button();
            this.btn_nadaj_uprawnienia = new System.Windows.Forms.Button();
            this.btn_filtruj_uprawnienia = new System.Windows.Forms.Button();
            this.btn_wyczysc_filtr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_lista_uż)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_wyszukiwarka
            // 
            this.btn_wyszukiwarka.Location = new System.Drawing.Point(780, 231);
            this.btn_wyszukiwarka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_wyszukiwarka.Name = "btn_wyszukiwarka";
            this.btn_wyszukiwarka.Size = new System.Drawing.Size(79, 25);
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
            this.txb_search.ForeColor = System.Drawing.Color.Black;
            this.txb_search.Location = new System.Drawing.Point(421, 231);
            this.txb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(337, 22);
            this.txb_search.TabIndex = 5;
            this.txb_search.Text = "Podaj imię, nazwisko lub login";
            this.txb_search.Enter += new System.EventHandler(this.txb_search_Enter);
            this.txb_search.Leave += new System.EventHandler(this.txb_search_Leave);
            // 
            // dtGrdVw_lista_uż
            // 
            this.dtGrdVw_lista_uż.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(202)))), ((int)(((byte)(224)))));
            this.dtGrdVw_lista_uż.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw_lista_uż.Location = new System.Drawing.Point(39, 391);
            this.dtGrdVw_lista_uż.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGrdVw_lista_uż.Name = "dtGrdVw_lista_uż";
            this.dtGrdVw_lista_uż.ReadOnly = true;
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
            this.btn_edycja_użytkownika.Location = new System.Drawing.Point(744, 12);
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
            this.btn_zapomnij.Location = new System.Drawing.Point(591, 12);
            this.btn_zapomnij.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_zapomnij.Name = "btn_zapomnij";
            this.btn_zapomnij.Size = new System.Drawing.Size(147, 44);
            this.btn_zapomnij.TabIndex = 11;
            this.btn_zapomnij.Text = "Zapomnij użytkownika";
            this.btn_zapomnij.UseVisualStyleBackColor = false;
            this.btn_zapomnij.Click += new System.EventHandler(this.btn_zapomnij_Click);
            // 
            // anuluj_wyszukiwarka
            // 
            this.anuluj_wyszukiwarka.Location = new System.Drawing.Point(780, 265);
            this.anuluj_wyszukiwarka.Name = "anuluj_wyszukiwarka";
            this.anuluj_wyszukiwarka.Size = new System.Drawing.Size(79, 25);
            this.anuluj_wyszukiwarka.TabIndex = 12;
            this.anuluj_wyszukiwarka.Text = "Wyczyść";
            this.anuluj_wyszukiwarka.UseVisualStyleBackColor = true;
            this.anuluj_wyszukiwarka.Click += new System.EventHandler(this.anuluj_wyszukiwarka_Click);
            // 
            // btn_strona_główna
            // 
            this.btn_strona_główna.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_strona_główna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_strona_główna.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_strona_główna.Location = new System.Drawing.Point(39, 11);
            this.btn_strona_główna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_strona_główna.Name = "btn_strona_główna";
            this.btn_strona_główna.Size = new System.Drawing.Size(147, 44);
            this.btn_strona_główna.TabIndex = 13;
            this.btn_strona_główna.Text = "Strona główna";
            this.btn_strona_główna.UseVisualStyleBackColor = false;
            this.btn_strona_główna.Click += new System.EventHandler(this.btn_strona_główna_Click);
            // 
            // btn_podglad_danych
            // 
            this.btn_podglad_danych.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_podglad_danych.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_podglad_danych.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_podglad_danych.Location = new System.Drawing.Point(438, 12);
            this.btn_podglad_danych.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_podglad_danych.Name = "btn_podglad_danych";
            this.btn_podglad_danych.Size = new System.Drawing.Size(147, 44);
            this.btn_podglad_danych.TabIndex = 14;
            this.btn_podglad_danych.Text = "Podgląd danych";
            this.btn_podglad_danych.UseVisualStyleBackColor = false;
            this.btn_podglad_danych.Click += new System.EventHandler(this.btn_podglad_danych_Click);
            // 
            // btn_nadaj_uprawnienia
            // 
            this.btn_nadaj_uprawnienia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_nadaj_uprawnienia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_nadaj_uprawnienia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_nadaj_uprawnienia.Location = new System.Drawing.Point(285, 12);
            this.btn_nadaj_uprawnienia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nadaj_uprawnienia.Name = "btn_nadaj_uprawnienia";
            this.btn_nadaj_uprawnienia.Size = new System.Drawing.Size(147, 44);
            this.btn_nadaj_uprawnienia.TabIndex = 15;
            this.btn_nadaj_uprawnienia.Text = "Nadaj uprawnienia";
            this.btn_nadaj_uprawnienia.UseVisualStyleBackColor = false;
            this.btn_nadaj_uprawnienia.Click += new System.EventHandler(this.btn_nadaj_uprawnienia_Click);
            // 
            // btn_filtruj_uprawnienia
            // 
            this.btn_filtruj_uprawnienia.Location = new System.Drawing.Point(421, 265);
            this.btn_filtruj_uprawnienia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_filtruj_uprawnienia.Name = "btn_filtruj_uprawnienia";
            this.btn_filtruj_uprawnienia.Size = new System.Drawing.Size(180, 25);
            this.btn_filtruj_uprawnienia.TabIndex = 16;
            this.btn_filtruj_uprawnienia.Text = "Filtruj według uprawnień";
            this.btn_filtruj_uprawnienia.UseVisualStyleBackColor = true;
            this.btn_filtruj_uprawnienia.Click += new System.EventHandler(this.btn_filtruj_uprawnienia_Click);
            // 
            // btn_wyczysc_filtr
            // 
            this.btn_wyczysc_filtr.Location = new System.Drawing.Point(607, 265);
            this.btn_wyczysc_filtr.Name = "btn_wyczysc_filtr";
            this.btn_wyczysc_filtr.Size = new System.Drawing.Size(98, 25);
            this.btn_wyczysc_filtr.TabIndex = 17;
            this.btn_wyczysc_filtr.Text = "Wyczyść filtr";
            this.btn_wyczysc_filtr.UseVisualStyleBackColor = true;
            this.btn_wyczysc_filtr.Click += new System.EventHandler(this.btn_wyczysc_filtr_Click);
            // 
            // Form_lista_uzytkownikow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 791);
            this.Controls.Add(this.btn_wyczysc_filtr);
            this.Controls.Add(this.btn_filtruj_uprawnienia);
            this.Controls.Add(this.btn_nadaj_uprawnienia);
            this.Controls.Add(this.btn_podglad_danych);
            this.Controls.Add(this.btn_strona_główna);
            this.Controls.Add(this.anuluj_wyszukiwarka);
            this.Controls.Add(this.btn_zapomnij);
            this.Controls.Add(this.btn_edycja_użytkownika);
            this.Controls.Add(this.dtGrdVw_lista_uż);
            this.Controls.Add(this.btn_wyszukiwarka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_nowy_użytkow);
            this.Controls.Add(this.txb_search);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_lista_uzytkownikow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista użytkowników";
            this.Shown += new System.EventHandler(this.Form_lista_uzytkownikow_Shown);
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
        private System.Windows.Forms.Button anuluj_wyszukiwarka;
        private System.Windows.Forms.Button btn_strona_główna;
        private System.Windows.Forms.Button btn_podglad_danych;
        private System.Windows.Forms.Button btn_nadaj_uprawnienia;
        private System.Windows.Forms.Button btn_filtruj_uprawnienia;
        private System.Windows.Forms.Button btn_wyczysc_filtr;
    }
}