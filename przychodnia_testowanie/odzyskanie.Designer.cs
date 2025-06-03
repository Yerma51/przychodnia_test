namespace przychodnia_testowanie
{
    partial class odzyskanie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(odzyskanie));
            this.button_anuluj = new System.Windows.Forms.Button();
            this.label_login = new System.Windows.Forms.Label();
            this.button_odzyskaj = new System.Windows.Forms.Button();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_anuluj
            // 
            this.button_anuluj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.button_anuluj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_anuluj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_anuluj.Location = new System.Drawing.Point(75, 565);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(288, 45);
            this.button_anuluj.TabIndex = 11;
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.UseVisualStyleBackColor = false;
            this.button_anuluj.Click += new System.EventHandler(this.button_anuluj_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.label_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.ForeColor = System.Drawing.Color.White;
            this.label_login.Location = new System.Drawing.Point(70, 352);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(305, 28);
            this.label_login.TabIndex = 10;
            this.label_login.Text = "Proszę podaj swój adres e-mail";
            // 
            // button_odzyskaj
            // 
            this.button_odzyskaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.button_odzyskaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_odzyskaj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_odzyskaj.Location = new System.Drawing.Point(75, 501);
            this.button_odzyskaj.Name = "button_odzyskaj";
            this.button_odzyskaj.Size = new System.Drawing.Size(288, 45);
            this.button_odzyskaj.TabIndex = 9;
            this.button_odzyskaj.Text = "Odzyskaj hasło";
            this.button_odzyskaj.UseVisualStyleBackColor = false;
            this.button_odzyskaj.Click += new System.EventHandler(this.button_odzyskaj_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(98, 405);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(254, 22);
            this.textBox_email.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Proszę podaj swój login";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(98, 299);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(254, 22);
            this.textBox_login.TabIndex = 13;
            // 
            // odzyskanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 791);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_anuluj);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.button_odzyskaj);
            this.Controls.Add(this.textBox_email);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "odzyskanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odzyskanie hasła";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_anuluj;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Button button_odzyskaj;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_login;
    }
}