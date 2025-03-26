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
            this.btn_wyszukiwarka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nowy_użytkow = new System.Windows.Forms.Button();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.dtGrdVw_lista_uż = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_lista_uż)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_wyszukiwarka
            // 
            this.btn_wyszukiwarka.Location = new System.Drawing.Point(590, 188);
            this.btn_wyszukiwarka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_wyszukiwarka.Name = "btn_wyszukiwarka";
            this.btn_wyszukiwarka.Size = new System.Drawing.Size(49, 18);
            this.btn_wyszukiwarka.TabIndex = 8;
            this.btn_wyszukiwarka.Text = "Szukaj";
            this.btn_wyszukiwarka.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista użytkowników ";
            // 
            // btn_nowy_użytkow
            // 
            this.btn_nowy_użytkow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(167)))), ((int)(((byte)(204)))));
            this.btn_nowy_użytkow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_nowy_użytkow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_nowy_użytkow.Location = new System.Drawing.Point(705, 10);
            this.btn_nowy_użytkow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_nowy_użytkow.Name = "btn_nowy_użytkow";
            this.btn_nowy_użytkow.Size = new System.Drawing.Size(110, 36);
            this.btn_nowy_użytkow.TabIndex = 6;
            this.btn_nowy_użytkow.Text = "Dodaj użytkownika";
            this.btn_nowy_użytkow.UseVisualStyleBackColor = false;
            this.btn_nowy_użytkow.Click += new System.EventHandler(this.btn_nowy_użytkow_Click);
            // 
            // txb_search
            // 
            this.txb_search.Cursor = System.Windows.Forms.Cursors.Help;
            this.txb_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(202)))), ((int)(((byte)(224)))));
            this.txb_search.Location = new System.Drawing.Point(316, 188);
            this.txb_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(254, 20);
            this.txb_search.TabIndex = 5;
            this.txb_search.Text = "Wyszukaj użytkownika...";
            // 
            // dtGrdVw_lista_uż
            // 
            this.dtGrdVw_lista_uż.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(202)))), ((int)(((byte)(224)))));
            this.dtGrdVw_lista_uż.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw_lista_uż.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtGrdVw_lista_uż.Location = new System.Drawing.Point(29, 318);
            this.dtGrdVw_lista_uż.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtGrdVw_lista_uż.Name = "dtGrdVw_lista_uż";
            this.dtGrdVw_lista_uż.RowHeadersVisible = false;
            this.dtGrdVw_lista_uż.RowHeadersWidth = 51;
            this.dtGrdVw_lista_uż.RowTemplate.Height = 24;
            this.dtGrdVw_lista_uż.Size = new System.Drawing.Size(820, 306);
            this.dtGrdVw_lista_uż.TabIndex = 9;
            this.dtGrdVw_lista_uż.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVw_lista_uż_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Login";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Imię";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nazwisko";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adres e-mail";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Form_lista_uzytkownikow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.BackgroundImage = global::przychodnia_testowanie.Properties.Resources.Lista_uzytkowników__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 643);
            this.Controls.Add(this.dtGrdVw_lista_uż);
            this.Controls.Add(this.btn_wyszukiwarka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_nowy_użytkow);
            this.Controls.Add(this.txb_search);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}