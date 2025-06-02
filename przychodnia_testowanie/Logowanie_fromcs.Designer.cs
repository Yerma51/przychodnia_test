namespace przychodnia_testowanie
{
    partial class Logowanie_fromcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logowanie_fromcs));
            this.label_login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_haslo = new System.Windows.Forms.TextBox();
            this.button_zaloguj = new System.Windows.Forms.Button();
            this.button_nie_pamietam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.label_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.ForeColor = System.Drawing.Color.White;
            this.label_login.Location = new System.Drawing.Point(68, 313);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(64, 28);
            this.label_login.TabIndex = 0;
            this.label_login.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(150, 319);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(211, 22);
            this.textBox_login.TabIndex = 2;
            // 
            // textBox_haslo
            // 
            this.textBox_haslo.Location = new System.Drawing.Point(150, 362);
            this.textBox_haslo.Name = "textBox_haslo";
            this.textBox_haslo.Size = new System.Drawing.Size(211, 22);
            this.textBox_haslo.TabIndex = 3;
            // 
            // button_zaloguj
            // 
            this.button_zaloguj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.button_zaloguj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_zaloguj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_zaloguj.Location = new System.Drawing.Point(73, 407);
            this.button_zaloguj.Name = "button_zaloguj";
            this.button_zaloguj.Size = new System.Drawing.Size(288, 45);
            this.button_zaloguj.TabIndex = 4;
            this.button_zaloguj.Text = "Zaloguj się";
            this.button_zaloguj.UseVisualStyleBackColor = false;
            this.button_zaloguj.Click += new System.EventHandler(this.button_zaloguj_Click);
            // 
            // button_nie_pamietam
            // 
            this.button_nie_pamietam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.button_nie_pamietam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_nie_pamietam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_nie_pamietam.Location = new System.Drawing.Point(73, 475);
            this.button_nie_pamietam.Name = "button_nie_pamietam";
            this.button_nie_pamietam.Size = new System.Drawing.Size(288, 45);
            this.button_nie_pamietam.TabIndex = 5;
            this.button_nie_pamietam.Text = "Nie pamiętam hasła\r\n";
            this.button_nie_pamietam.UseVisualStyleBackColor = false;
            this.button_nie_pamietam.Click += new System.EventHandler(this.button_nie_pamietam_Click_1);
            // 
            // Logowanie_fromcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 791);
            this.Controls.Add(this.button_nie_pamietam);
            this.Controls.Add(this.button_zaloguj);
            this.Controls.Add(this.textBox_haslo);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_login);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Logowanie_fromcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_haslo;
        private System.Windows.Forms.Button button_zaloguj;
        private System.Windows.Forms.Button button_nie_pamietam;
    }
}