namespace przychodnia_testowanie
{
    partial class Form_nadawanie_uprawnien
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
            this.clb_uprawnienia = new System.Windows.Forms.CheckedListBox();
            this.lbl_wybor_uprawnien = new System.Windows.Forms.Label();
            this.btn_zapisz_uprawnienia = new System.Windows.Forms.Button();
            this.btn_anuluj_uprawnienia = new System.Windows.Forms.Button();
            this.lbl_info_uprawnienia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_uprawnienia
            // 
            this.clb_uprawnienia.FormattingEnabled = true;
            this.clb_uprawnienia.Location = new System.Drawing.Point(70, 69);
            this.clb_uprawnienia.Name = "clb_uprawnienia";
            this.clb_uprawnienia.Size = new System.Drawing.Size(295, 259);
            this.clb_uprawnienia.TabIndex = 1;
            this.clb_uprawnienia.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_uprawnienia_ItemCheck_1);
            // 
            // lbl_wybor_uprawnien
            // 
            this.lbl_wybor_uprawnien.AutoSize = true;
            this.lbl_wybor_uprawnien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.lbl_wybor_uprawnien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_wybor_uprawnien.Location = new System.Drawing.Point(65, 32);
            this.lbl_wybor_uprawnien.Name = "lbl_wybor_uprawnien";
            this.lbl_wybor_uprawnien.Size = new System.Drawing.Size(200, 25);
            this.lbl_wybor_uprawnien.TabIndex = 93;
            this.lbl_wybor_uprawnien.Text = "Wybierz uprawnienia:";
            // 
            // btn_zapisz_uprawnienia
            // 
            this.btn_zapisz_uprawnienia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(204)))), ((int)(((byte)(109)))));
            this.btn_zapisz_uprawnienia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_zapisz_uprawnienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_zapisz_uprawnienia.ForeColor = System.Drawing.Color.Black;
            this.btn_zapisz_uprawnienia.Location = new System.Drawing.Point(226, 539);
            this.btn_zapisz_uprawnienia.Name = "btn_zapisz_uprawnienia";
            this.btn_zapisz_uprawnienia.Size = new System.Drawing.Size(139, 50);
            this.btn_zapisz_uprawnienia.TabIndex = 95;
            this.btn_zapisz_uprawnienia.Text = "Zapisz";
            this.btn_zapisz_uprawnienia.UseVisualStyleBackColor = false;
            this.btn_zapisz_uprawnienia.Click += new System.EventHandler(this.btn_zapisz_uprawnienia_Click_1);
            // 
            // btn_anuluj_uprawnienia
            // 
            this.btn_anuluj_uprawnienia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(204)))), ((int)(((byte)(109)))));
            this.btn_anuluj_uprawnienia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_anuluj_uprawnienia.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_anuluj_uprawnienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_anuluj_uprawnienia.ForeColor = System.Drawing.Color.Black;
            this.btn_anuluj_uprawnienia.Location = new System.Drawing.Point(70, 539);
            this.btn_anuluj_uprawnienia.Name = "btn_anuluj_uprawnienia";
            this.btn_anuluj_uprawnienia.Size = new System.Drawing.Size(139, 50);
            this.btn_anuluj_uprawnienia.TabIndex = 96;
            this.btn_anuluj_uprawnienia.Text = "Anuluj";
            this.btn_anuluj_uprawnienia.UseVisualStyleBackColor = false;
            // 
            // lbl_info_uprawnienia
            // 
            this.lbl_info_uprawnienia.AutoSize = true;
            this.lbl_info_uprawnienia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.lbl_info_uprawnienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_info_uprawnienia.Location = new System.Drawing.Point(65, 340);
            this.lbl_info_uprawnienia.Name = "lbl_info_uprawnienia";
            this.lbl_info_uprawnienia.Size = new System.Drawing.Size(246, 25);
            this.lbl_info_uprawnienia.TabIndex = 97;
            this.lbl_info_uprawnienia.Text = "Brak wybranych uprawnień";
            // 
            // Form_nadawanie_uprawnien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(432, 653);
            this.Controls.Add(this.lbl_info_uprawnienia);
            this.Controls.Add(this.btn_anuluj_uprawnienia);
            this.Controls.Add(this.btn_zapisz_uprawnienia);
            this.Controls.Add(this.lbl_wybor_uprawnien);
            this.Controls.Add(this.clb_uprawnienia);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_nadawanie_uprawnien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarządzanie uprawnieniami";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox clb_uprawnienia;
        private System.Windows.Forms.Label lbl_wybor_uprawnien;
        private System.Windows.Forms.Button btn_zapisz_uprawnienia;
        private System.Windows.Forms.Button btn_anuluj_uprawnienia;
        private System.Windows.Forms.Label lbl_info_uprawnienia;
    }
}