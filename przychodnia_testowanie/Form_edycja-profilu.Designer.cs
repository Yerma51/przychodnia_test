namespace przychodnia_testowanie
{
    partial class Form_Edycja_profilu
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
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.txb_login = new System.Windows.Forms.TextBox();
            this.label16_login = new System.Windows.Forms.Label();
            this.btn_lista = new System.Windows.Forms.Button();
            this.button1_zapisz = new System.Windows.Forms.Button();
            this.numerLokalu_textBox = new System.Windows.Forms.TextBox();
            this.numerPosesji_textBox = new System.Windows.Forms.TextBox();
            this.ulica_textBox = new System.Windows.Forms.TextBox();
            this.kodPocztowy_textBox = new System.Windows.Forms.TextBox();
            this.miejcowosc_textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numerTelefonu_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mail_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.plec_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataUrodzenia_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pesel_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nazwisko_textBox = new System.Windows.Forms.TextBox();
            this.imie_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(204)))), ((int)(((byte)(109)))));
            this.btn_anuluj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_anuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_anuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_anuluj.ForeColor = System.Drawing.Color.Black;
            this.btn_anuluj.Location = new System.Drawing.Point(863, 673);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.Size = new System.Drawing.Size(172, 55);
            this.btn_anuluj.TabIndex = 92;
            this.btn_anuluj.Text = "Anuluj";
            this.btn_anuluj.UseVisualStyleBackColor = false;
            this.btn_anuluj.Click += new System.EventHandler(this.btn_anuluj_Click);
            // 
            // txb_login
            // 
            this.txb_login.Location = new System.Drawing.Point(107, 264);
            this.txb_login.Name = "txb_login";
            this.txb_login.Size = new System.Drawing.Size(201, 22);
            this.txb_login.TabIndex = 91;
            // 
            // label16_login
            // 
            this.label16_login.AutoSize = true;
            this.label16_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label16_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16_login.Location = new System.Drawing.Point(108, 236);
            this.label16_login.Name = "label16_login";
            this.label16_login.Size = new System.Drawing.Size(65, 25);
            this.label16_login.TabIndex = 90;
            this.label16_login.Text = "Login ";
            // 
            // btn_lista
            // 
            this.btn_lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(167)))), ((int)(((byte)(204)))));
            this.btn_lista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_lista.Location = new System.Drawing.Point(930, 12);
            this.btn_lista.Name = "btn_lista";
            this.btn_lista.Size = new System.Drawing.Size(147, 44);
            this.btn_lista.TabIndex = 89;
            this.btn_lista.Text = "Lista użytkowników";
            this.btn_lista.UseVisualStyleBackColor = false;
            this.btn_lista.Click += new System.EventHandler(this.btn_lista_Click);
            // 
            // button1_zapisz
            // 
            this.button1_zapisz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(204)))), ((int)(((byte)(109)))));
            this.button1_zapisz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_zapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_zapisz.ForeColor = System.Drawing.Color.Black;
            this.button1_zapisz.Location = new System.Drawing.Point(644, 673);
            this.button1_zapisz.Name = "button1_zapisz";
            this.button1_zapisz.Size = new System.Drawing.Size(172, 55);
            this.button1_zapisz.TabIndex = 88;
            this.button1_zapisz.Text = "Zapisz";
            this.button1_zapisz.UseVisualStyleBackColor = false;
            this.button1_zapisz.Click += new System.EventHandler(this.button1_zapisz_Click);
            // 
            // numerLokalu_textBox
            // 
            this.numerLokalu_textBox.Location = new System.Drawing.Point(644, 479);
            this.numerLokalu_textBox.Name = "numerLokalu_textBox";
            this.numerLokalu_textBox.Size = new System.Drawing.Size(200, 22);
            this.numerLokalu_textBox.TabIndex = 87;
            // 
            // numerPosesji_textBox
            // 
            this.numerPosesji_textBox.Location = new System.Drawing.Point(644, 407);
            this.numerPosesji_textBox.Name = "numerPosesji_textBox";
            this.numerPosesji_textBox.Size = new System.Drawing.Size(200, 22);
            this.numerPosesji_textBox.TabIndex = 86;
            // 
            // ulica_textBox
            // 
            this.ulica_textBox.Location = new System.Drawing.Point(644, 334);
            this.ulica_textBox.Name = "ulica_textBox";
            this.ulica_textBox.Size = new System.Drawing.Size(200, 22);
            this.ulica_textBox.TabIndex = 85;
            // 
            // kodPocztowy_textBox
            // 
            this.kodPocztowy_textBox.Location = new System.Drawing.Point(646, 552);
            this.kodPocztowy_textBox.Name = "kodPocztowy_textBox";
            this.kodPocztowy_textBox.Size = new System.Drawing.Size(200, 22);
            this.kodPocztowy_textBox.TabIndex = 84;
            // 
            // miejcowosc_textBox
            // 
            this.miejcowosc_textBox.Location = new System.Drawing.Point(644, 264);
            this.miejcowosc_textBox.Name = "miejcowosc_textBox";
            this.miejcowosc_textBox.Size = new System.Drawing.Size(200, 22);
            this.miejcowosc_textBox.TabIndex = 83;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(661, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(353, 42);
            this.label14.TabIndex = 82;
            this.label14.Text = "Adres zamieszkania";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(639, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 25);
            this.label13.TabIndex = 81;
            this.label13.Text = "Ulica";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(639, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 25);
            this.label12.TabIndex = 80;
            this.label12.Text = "Numer lokalu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(639, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 25);
            this.label11.TabIndex = 79;
            this.label11.Text = "Numer posesji";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(641, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 25);
            this.label10.TabIndex = 78;
            this.label10.Text = "Kod pocztowy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(641, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 25);
            this.label9.TabIndex = 77;
            this.label9.Text = "Miejscowość";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(148, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(304, 42);
            this.label8.TabIndex = 76;
            this.label8.Text = "Dane personalne";
            // 
            // numerTelefonu_textBox
            // 
            this.numerTelefonu_textBox.Location = new System.Drawing.Point(649, 625);
            this.numerTelefonu_textBox.Name = "numerTelefonu_textBox";
            this.numerTelefonu_textBox.Size = new System.Drawing.Size(197, 22);
            this.numerTelefonu_textBox.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(646, 597);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 25);
            this.label7.TabIndex = 74;
            this.label7.Text = "Numer telefonu";
            // 
            // mail_textBox
            // 
            this.mail_textBox.Location = new System.Drawing.Point(108, 695);
            this.mail_textBox.Name = "mail_textBox";
            this.mail_textBox.Size = new System.Drawing.Size(201, 22);
            this.mail_textBox.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(107, 667);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 72;
            this.label6.Text = "Adres e-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(106, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 71;
            this.label5.Text = "Płeć";
            // 
            // plec_comboBox
            // 
            this.plec_comboBox.FormattingEnabled = true;
            this.plec_comboBox.Items.AddRange(new object[] {
            "Kobieta",
            "Mężczyzna"});
            this.plec_comboBox.Location = new System.Drawing.Point(108, 477);
            this.plec_comboBox.Name = "plec_comboBox";
            this.plec_comboBox.Size = new System.Drawing.Size(200, 24);
            this.plec_comboBox.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(107, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 69;
            this.label4.Text = "Data urodzenia";
            // 
            // dataUrodzenia_dateTimePicker
            // 
            this.dataUrodzenia_dateTimePicker.Location = new System.Drawing.Point(108, 548);
            this.dataUrodzenia_dateTimePicker.Name = "dataUrodzenia_dateTimePicker";
            this.dataUrodzenia_dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dataUrodzenia_dateTimePicker.TabIndex = 68;
            // 
            // pesel_textBox
            // 
            this.pesel_textBox.Location = new System.Drawing.Point(109, 620);
            this.pesel_textBox.Name = "pesel_textBox";
            this.pesel_textBox.Size = new System.Drawing.Size(200, 22);
            this.pesel_textBox.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(108, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 66;
            this.label3.Text = "Pesel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(106, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 65;
            this.label2.Text = "Nazwisko";
            // 
            // nazwisko_textBox
            // 
            this.nazwisko_textBox.Location = new System.Drawing.Point(108, 404);
            this.nazwisko_textBox.Name = "nazwisko_textBox";
            this.nazwisko_textBox.Size = new System.Drawing.Size(200, 22);
            this.nazwisko_textBox.TabIndex = 64;
            // 
            // imie_textBox
            // 
            this.imie_textBox.Location = new System.Drawing.Point(108, 334);
            this.imie_textBox.Name = "imie_textBox";
            this.imie_textBox.Size = new System.Drawing.Size(200, 22);
            this.imie_textBox.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Imię";
            // 
            // Form_Edycja_profilu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.BackgroundImage = global::przychodnia_testowanie.Properties.Resources.Profil;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 791);
            this.Controls.Add(this.btn_anuluj);
            this.Controls.Add(this.txb_login);
            this.Controls.Add(this.label16_login);
            this.Controls.Add(this.btn_lista);
            this.Controls.Add(this.button1_zapisz);
            this.Controls.Add(this.numerLokalu_textBox);
            this.Controls.Add(this.numerPosesji_textBox);
            this.Controls.Add(this.ulica_textBox);
            this.Controls.Add(this.kodPocztowy_textBox);
            this.Controls.Add(this.miejcowosc_textBox);
            this.Controls.Add(this.label14);
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
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Edycja_profilu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edycja użytkownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.TextBox txb_login;
        private System.Windows.Forms.Label label16_login;
        private System.Windows.Forms.Button btn_lista;
        private System.Windows.Forms.Button button1_zapisz;
        private System.Windows.Forms.TextBox numerLokalu_textBox;
        private System.Windows.Forms.TextBox numerPosesji_textBox;
        private System.Windows.Forms.TextBox ulica_textBox;
        private System.Windows.Forms.TextBox kodPocztowy_textBox;
        private System.Windows.Forms.TextBox miejcowosc_textBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox numerTelefonu_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mail_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox plec_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dataUrodzenia_dateTimePicker;
        private System.Windows.Forms.TextBox pesel_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nazwisko_textBox;
        private System.Windows.Forms.TextBox imie_textBox;
        private System.Windows.Forms.Label label1;
    }
}

