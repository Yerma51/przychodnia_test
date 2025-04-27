namespace przychodnia_testowanie
{
    partial class Form_strona_glowna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_strona_glowna));
            this.btn_zapom = new System.Windows.Forms.Button();
            this.btn_zarzad = new System.Windows.Forms.Button();
            this.btn_uprawn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_zapom
            // 
            this.btn_zapom.BackColor = System.Drawing.Color.White;
            this.btn_zapom.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.btn_zapom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_zapom.Location = new System.Drawing.Point(480, 443);
            this.btn_zapom.Name = "btn_zapom";
            this.btn_zapom.Size = new System.Drawing.Size(216, 47);
            this.btn_zapom.TabIndex = 3;
            this.btn_zapom.Text = "Kliknij";
            this.btn_zapom.UseVisualStyleBackColor = false;
            this.btn_zapom.Click += new System.EventHandler(this.btn_zapom_Click);
            // 
            // btn_zarzad
            // 
            this.btn_zarzad.BackColor = System.Drawing.Color.White;
            this.btn_zarzad.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_zarzad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_zarzad.Location = new System.Drawing.Point(128, 443);
            this.btn_zarzad.Name = "btn_zarzad";
            this.btn_zarzad.Size = new System.Drawing.Size(216, 47);
            this.btn_zarzad.TabIndex = 2;
            this.btn_zarzad.Text = "Kliknij";
            this.btn_zarzad.UseVisualStyleBackColor = false;
            this.btn_zarzad.Click += new System.EventHandler(this.btn_zarzad_Click);
            // 
            // btn_uprawn
            // 
            this.btn_uprawn.BackColor = System.Drawing.Color.White;
            this.btn_uprawn.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.btn_uprawn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_uprawn.Location = new System.Drawing.Point(823, 443);
            this.btn_uprawn.Name = "btn_uprawn";
            this.btn_uprawn.Size = new System.Drawing.Size(216, 47);
            this.btn_uprawn.TabIndex = 4;
            this.btn_uprawn.Text = "Kliknij";
            this.btn_uprawn.UseVisualStyleBackColor = false;
            this.btn_uprawn.Click += new System.EventHandler(this.btn_uprawn_Click_Click);
            // 
            // Form_strona_glowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 791);
            this.Controls.Add(this.btn_uprawn);
            this.Controls.Add(this.btn_zapom);
            this.Controls.Add(this.btn_zarzad);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_strona_glowna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przychodnia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_zapom;
        private System.Windows.Forms.Button btn_zarzad;
        private System.Windows.Forms.Button btn_uprawn;
    }
}