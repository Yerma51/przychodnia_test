namespace przychodnia_testowanie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.pesel_textBox = new System.Windows.Forms.TextBox();
            this.dataUrodzenia_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.plec_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mail_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numerTelefonu_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(86, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pesel";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pesel_textBox
            // 
            this.pesel_textBox.Location = new System.Drawing.Point(87, 399);
            this.pesel_textBox.Name = "pesel_textBox";
            this.pesel_textBox.Size = new System.Drawing.Size(200, 22);
            this.pesel_textBox.TabIndex = 5;
            // 
            // dataUrodzenia_dateTimePicker
            // 
            this.dataUrodzenia_dateTimePicker.Location = new System.Drawing.Point(86, 327);
            this.dataUrodzenia_dateTimePicker.Name = "dataUrodzenia_dateTimePicker";
            this.dataUrodzenia_dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dataUrodzenia_dateTimePicker.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(85, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data urodzenia";
            // 
            // plec_comboBox
            // 
            this.plec_comboBox.FormattingEnabled = true;
            this.plec_comboBox.Location = new System.Drawing.Point(86, 256);
            this.plec_comboBox.Name = "plec_comboBox";
            this.plec_comboBox.Size = new System.Drawing.Size(200, 24);
            this.plec_comboBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(84, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Płeć";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(85, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Adres e-mail";
            // 
            // mail_textBox
            // 
            this.mail_textBox.Location = new System.Drawing.Point(86, 474);
            this.mail_textBox.Name = "mail_textBox";
            this.mail_textBox.Size = new System.Drawing.Size(200, 22);
            this.mail_textBox.TabIndex = 11;
            this.mail_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(86, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Numer telefonu";
            // 
            // numerTelefonu_textBox
            // 
            this.numerTelefonu_textBox.Location = new System.Drawing.Point(89, 553);
            this.numerTelefonu_textBox.Name = "numerTelefonu_textBox";
            this.numerTelefonu_textBox.Size = new System.Drawing.Size(197, 22);
            this.numerTelefonu_textBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1089, 688);
            this.Controls.Add(this.numerTelefonu_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mail_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.plec_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataUrodzenia_dateTimePicker);
            this.Controls.Add(this.pesel_textBox);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pesel_textBox;
        private System.Windows.Forms.DateTimePicker dataUrodzenia_dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox plec_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mail_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numerTelefonu_textBox;
    }
}

