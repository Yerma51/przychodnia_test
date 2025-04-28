partial class Form_lista_zapomnianych
{
    private System.ComponentModel.IContainer components = null;

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_lista_zapomnianych));
            this.btn_strona_glowna = new System.Windows.Forms.Button();
            this.anuluj_wyszukiwarka = new System.Windows.Forms.Button();
            this.dtGrdVw_lista_uż = new System.Windows.Forms.DataGridView();
            this.btn_wyszukiwarka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_lista_uż)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_strona_glowna
            // 
            this.btn_strona_glowna.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_strona_glowna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_strona_glowna.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_strona_glowna.Location = new System.Drawing.Point(42, 11);
            this.btn_strona_glowna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_strona_glowna.Name = "btn_strona_glowna";
            this.btn_strona_glowna.Size = new System.Drawing.Size(147, 44);
            this.btn_strona_glowna.TabIndex = 19;
            this.btn_strona_glowna.Text = "Strona główna";
            this.btn_strona_glowna.UseVisualStyleBackColor = false;
            this.btn_strona_glowna.Click += new System.EventHandler(this.btn_strona_glowna_Click_1);
            // 
            // anuluj_wyszukiwarka
            // 
            this.anuluj_wyszukiwarka.Location = new System.Drawing.Point(706, 241);
            this.anuluj_wyszukiwarka.Name = "anuluj_wyszukiwarka";
            this.anuluj_wyszukiwarka.Size = new System.Drawing.Size(79, 25);
            this.anuluj_wyszukiwarka.TabIndex = 18;
            this.anuluj_wyszukiwarka.Text = "Wyczyść";
            this.anuluj_wyszukiwarka.UseVisualStyleBackColor = true;
            this.anuluj_wyszukiwarka.Click += new System.EventHandler(this.anuluj_wyszukiwarka_Click);
            // 
            // dtGrdVw_lista_uż
            // 
            this.dtGrdVw_lista_uż.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(202)))), ((int)(((byte)(224)))));
            this.dtGrdVw_lista_uż.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw_lista_uż.Location = new System.Drawing.Point(42, 409);
            this.dtGrdVw_lista_uż.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGrdVw_lista_uż.Name = "dtGrdVw_lista_uż";
            this.dtGrdVw_lista_uż.ReadOnly = true;
            this.dtGrdVw_lista_uż.RowHeadersWidth = 51;
            this.dtGrdVw_lista_uż.RowTemplate.Height = 24;
            this.dtGrdVw_lista_uż.Size = new System.Drawing.Size(1086, 355);
            this.dtGrdVw_lista_uż.TabIndex = 17;
            // 
            // btn_wyszukiwarka
            // 
            this.btn_wyszukiwarka.Location = new System.Drawing.Point(706, 211);
            this.btn_wyszukiwarka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_wyszukiwarka.Name = "btn_wyszukiwarka";
            this.btn_wyszukiwarka.Size = new System.Drawing.Size(79, 25);
            this.btn_wyszukiwarka.TabIndex = 16;
            this.btn_wyszukiwarka.Text = "Szukaj";
            this.btn_wyszukiwarka.UseVisualStyleBackColor = true;
            this.btn_wyszukiwarka.Click += new System.EventHandler(this.btn_wyszukiwarka_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lista zapomnianych użytkowników ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txb_search
            // 
            this.txb_search.Location = new System.Drawing.Point(403, 214);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(297, 22);
            this.txb_search.TabIndex = 20;
            this.txb_search.Enter += new System.EventHandler(this.txb_search_Enter);
            this.txb_search.Leave += new System.EventHandler(this.txb_search_Leave);
            // 
            // Form_lista_zapomnianych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 791);
            this.Controls.Add(this.txb_search);
            this.Controls.Add(this.btn_strona_glowna);
            this.Controls.Add(this.anuluj_wyszukiwarka);
            this.Controls.Add(this.dtGrdVw_lista_uż);
            this.Controls.Add(this.btn_wyszukiwarka);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_lista_zapomnianych";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista zapomnianych użytkowników";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_lista_uż)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    private System.Windows.Forms.Button btn_strona_glowna;
    private System.Windows.Forms.Button anuluj_wyszukiwarka;
    private System.Windows.Forms.DataGridView dtGrdVw_lista_uż;
    private System.Windows.Forms.Button btn_wyszukiwarka;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txb_search;

}
