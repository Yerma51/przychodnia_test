namespace przychodnia_testowanie
{
    partial class Nowe_haslo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nowe_haslo));
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_powtorz_haslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.button_zmien_haslo = new System.Windows.Forms.Button();
            this.textBox_haslo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Powtórz go";
            // 
            // textBox_powtorz_haslo
            // 
            this.textBox_powtorz_haslo.Location = new System.Drawing.Point(67, 385);
            this.textBox_powtorz_haslo.Name = "textBox_powtorz_haslo";
            this.textBox_powtorz_haslo.Size = new System.Drawing.Size(254, 22);
            this.textBox_powtorz_haslo.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Podaj haslo";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(62, 164);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(366, 41);
            this.label.TabIndex = 15;
            this.label.Text = "Proszę ustaw nowe haslo\r\n";
            // 
            // button_zmien_haslo
            // 
            this.button_zmien_haslo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.button_zmien_haslo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_zmien_haslo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_zmien_haslo.Location = new System.Drawing.Point(69, 446);
            this.button_zmien_haslo.Name = "button_zmien_haslo";
            this.button_zmien_haslo.Size = new System.Drawing.Size(288, 45);
            this.button_zmien_haslo.TabIndex = 14;
            this.button_zmien_haslo.Text = "Zapisz haslo";
            this.button_zmien_haslo.UseVisualStyleBackColor = false;
            this.button_zmien_haslo.Click += new System.EventHandler(this.button_zmien_haslo_Click);
            // 
            // textBox_haslo
            // 
            this.textBox_haslo.Location = new System.Drawing.Point(67, 312);
            this.textBox_haslo.Name = "textBox_haslo";
            this.textBox_haslo.Size = new System.Drawing.Size(254, 22);
            this.textBox_haslo.TabIndex = 13;
            // 
            // Nowe_haslo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 791);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_powtorz_haslo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button_zmien_haslo);
            this.Controls.Add(this.textBox_haslo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Nowe_haslo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utwórz nowe hasło";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_powtorz_haslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button_zmien_haslo;
        private System.Windows.Forms.TextBox textBox_haslo;
    }
}