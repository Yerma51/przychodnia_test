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
            this.label1 = new System.Windows.Forms.Label();
            this.imie_textBox = new System.Windows.Forms.TextBox();
            this.nazwisko_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.miejcowosc_textBox = new System.Windows.Forms.TextBox();
            this.kodPocztowy_textBox = new System.Windows.Forms.TextBox();
            this.ulica_textBox = new System.Windows.Forms.TextBox();
            this.NumerPosesji_textBox = new System.Windows.Forms.TextBox();
            this.NumerLokalu_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(84, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // imie_textBox
            // 
            this.imie_textBox.Location = new System.Drawing.Point(86, 113);
            this.imie_textBox.Name = "imie_textBox";
            this.imie_textBox.Size = new System.Drawing.Size(200, 22);
            this.imie_textBox.TabIndex = 1;
            // 
            // nazwisko_textBox
            // 
            this.nazwisko_textBox.Location = new System.Drawing.Point(86, 183);
            this.nazwisko_textBox.Name = "nazwisko_textBox";
            this.nazwisko_textBox.Size = new System.Drawing.Size(200, 22);
            this.nazwisko_textBox.TabIndex = 2;
            this.nazwisko_textBox.TextChanged += new System.EventHandler(this.nazwisko_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(84, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(80, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dane personalne";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(527, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Miejscowość";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(527, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Kod pocztowy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(525, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Numer posesji";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(525, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 25);
            this.label12.TabIndex = 18;
            this.label12.Text = "Numer lokalu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(525, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 25);
            this.label13.TabIndex = 19;
            this.label13.Text = "Ulica";
            // 
            // miejcowosc_textBox
            // 
            this.miejcowosc_textBox.Location = new System.Drawing.Point(530, 113);
            this.miejcowosc_textBox.Name = "miejcowosc_textBox";
            this.miejcowosc_textBox.Size = new System.Drawing.Size(200, 22);
            this.miejcowosc_textBox.TabIndex = 21;
            // 
            // kodPocztowy_textBox
            // 
            this.kodPocztowy_textBox.Location = new System.Drawing.Point(532, 401);
            this.kodPocztowy_textBox.Name = "kodPocztowy_textBox";
            this.kodPocztowy_textBox.Size = new System.Drawing.Size(200, 22);
            this.kodPocztowy_textBox.TabIndex = 22;
            // 
            // ulica_textBox
            // 
            this.ulica_textBox.Location = new System.Drawing.Point(530, 183);
            this.ulica_textBox.Name = "ulica_textBox";
            this.ulica_textBox.Size = new System.Drawing.Size(200, 22);
            this.ulica_textBox.TabIndex = 23;
            // 
            // NumerPosesji_textBox
            // 
            this.NumerPosesji_textBox.Location = new System.Drawing.Point(530, 256);
            this.NumerPosesji_textBox.Name = "NumerPosesji_textBox";
            this.NumerPosesji_textBox.Size = new System.Drawing.Size(200, 22);
            this.NumerPosesji_textBox.TabIndex = 24;
            // 
            // NumerLokalu_textBox
            // 
            this.NumerLokalu_textBox.Location = new System.Drawing.Point(530, 328);
            this.NumerLokalu_textBox.Name = "NumerLokalu_textBox";
            this.NumerLokalu_textBox.Size = new System.Drawing.Size(200, 22);
            this.NumerLokalu_textBox.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1089, 688);
            this.Controls.Add(this.NumerLokalu_textBox);
            this.Controls.Add(this.NumerPosesji_textBox);
            this.Controls.Add(this.ulica_textBox);
            this.Controls.Add(this.kodPocztowy_textBox);
            this.Controls.Add(this.miejcowosc_textBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazwisko_textBox);
            this.Controls.Add(this.imie_textBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imie_textBox;
        private System.Windows.Forms.TextBox nazwisko_textBox;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox miejcowosc_textBox;
        private System.Windows.Forms.TextBox kodPocztowy_textBox;
        private System.Windows.Forms.TextBox ulica_textBox;
        private System.Windows.Forms.TextBox NumerPosesji_textBox;
        private System.Windows.Forms.TextBox NumerLokalu_textBox;
    }
}

