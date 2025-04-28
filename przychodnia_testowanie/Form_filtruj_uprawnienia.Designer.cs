namespace przychodnia_testowanie
{
    partial class Form_filtruj_uprawnienia
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
            this.lbl_wybor_uprawnien = new System.Windows.Forms.Label();
            this.cmb_uprawnienia = new System.Windows.Forms.ComboBox();
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.btn_filtruj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_wybor_uprawnien
            // 
            this.lbl_wybor_uprawnien.AutoSize = true;
            this.lbl_wybor_uprawnien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.lbl_wybor_uprawnien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_wybor_uprawnien.Location = new System.Drawing.Point(28, 38);
            this.lbl_wybor_uprawnien.Name = "lbl_wybor_uprawnien";
            this.lbl_wybor_uprawnien.Size = new System.Drawing.Size(200, 25);
            this.lbl_wybor_uprawnien.TabIndex = 94;
            this.lbl_wybor_uprawnien.Text = "Wybierz uprawnienia:";
            // 
            // cmb_uprawnienia
            // 
            this.cmb_uprawnienia.FormattingEnabled = true;
            this.cmb_uprawnienia.Location = new System.Drawing.Point(240, 38);
            this.cmb_uprawnienia.Name = "cmb_uprawnienia";
            this.cmb_uprawnienia.Size = new System.Drawing.Size(177, 24);
            this.cmb_uprawnienia.TabIndex = 95;
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(204)))), ((int)(((byte)(109)))));
            this.btn_anuluj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_anuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_anuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_anuluj.ForeColor = System.Drawing.Color.Black;
            this.btn_anuluj.Location = new System.Drawing.Point(100, 93);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.Size = new System.Drawing.Size(128, 37);
            this.btn_anuluj.TabIndex = 98;
            this.btn_anuluj.Text = "Anuluj";
            this.btn_anuluj.UseVisualStyleBackColor = false;
            // 
            // btn_filtruj
            // 
            this.btn_filtruj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(204)))), ((int)(((byte)(109)))));
            this.btn_filtruj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filtruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_filtruj.ForeColor = System.Drawing.Color.Black;
            this.btn_filtruj.Location = new System.Drawing.Point(240, 93);
            this.btn_filtruj.Name = "btn_filtruj";
            this.btn_filtruj.Size = new System.Drawing.Size(117, 37);
            this.btn_filtruj.TabIndex = 97;
            this.btn_filtruj.Text = "Filtruj";
            this.btn_filtruj.UseVisualStyleBackColor = false;
            this.btn_filtruj.Click += new System.EventHandler(this.btn_filtruj_Click_1);
            // 
            // Form_filtruj_uprawnienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(438, 183);
            this.Controls.Add(this.btn_anuluj);
            this.Controls.Add(this.btn_filtruj);
            this.Controls.Add(this.cmb_uprawnienia);
            this.Controls.Add(this.lbl_wybor_uprawnien);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_filtruj_uprawnienia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtruj uprawnienia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_wybor_uprawnien;
        private System.Windows.Forms.ComboBox cmb_uprawnienia;
        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.Button btn_filtruj;
    }
}