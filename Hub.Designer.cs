namespace CitsDemo
{
    partial class Hub
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxSicil = new System.Windows.Forms.TextBox();
            this.lblSicil = new System.Windows.Forms.Label();
            this.tbxRol = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.tbxTarih = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(29, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 127);
            this.button1.TabIndex = 0;
            this.button1.Text = "Giriş - Çıkış Kaydı";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(478, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 127);
            this.button2.TabIndex = 1;
            this.button2.Text = "Öğrendiklerim";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(241, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(154, 32);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Username :";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold);
            this.tbxName.Location = new System.Drawing.Point(402, 69);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(240, 35);
            this.tbxName.TabIndex = 4;
            // 
            // tbxSicil
            // 
            this.tbxSicil.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold);
            this.tbxSicil.Location = new System.Drawing.Point(402, 153);
            this.tbxSicil.Name = "tbxSicil";
            this.tbxSicil.ReadOnly = true;
            this.tbxSicil.Size = new System.Drawing.Size(240, 35);
            this.tbxSicil.TabIndex = 8;
            // 
            // lblSicil
            // 
            this.lblSicil.AutoSize = true;
            this.lblSicil.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold);
            this.lblSicil.ForeColor = System.Drawing.Color.White;
            this.lblSicil.Location = new System.Drawing.Point(242, 153);
            this.lblSicil.Name = "lblSicil";
            this.lblSicil.Size = new System.Drawing.Size(154, 32);
            this.lblSicil.TabIndex = 7;
            this.lblSicil.Text = "Sicil No :";
            // 
            // tbxRol
            // 
            this.tbxRol.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold);
            this.tbxRol.Location = new System.Drawing.Point(872, 69);
            this.tbxRol.Name = "tbxRol";
            this.tbxRol.ReadOnly = true;
            this.tbxRol.Size = new System.Drawing.Size(240, 35);
            this.tbxRol.TabIndex = 10;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(712, 71);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(98, 32);
            this.lblRol.TabIndex = 9;
            this.lblRol.Text = "Rolü :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(247, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 127);
            this.button3.TabIndex = 11;
            this.button3.Text = "Giriş - Çıkış Tablosu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PowderBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(977, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 127);
            this.button4.TabIndex = 12;
            this.button4.Text = "Ticket Bakiye Sorgulama";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PowderBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(729, 412);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(208, 127);
            this.button5.TabIndex = 13;
            this.button5.Text = "Öğrendiklerim Tablosu";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold);
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Location = new System.Drawing.Point(712, 156);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(112, 32);
            this.lblTarih.TabIndex = 14;
            this.lblTarih.Text = "Tarih :";
            // 
            // tbxTarih
            // 
            this.tbxTarih.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold);
            this.tbxTarih.Location = new System.Drawing.Point(872, 156);
            this.tbxTarih.Name = "tbxTarih";
            this.tbxTarih.ReadOnly = true;
            this.tbxTarih.Size = new System.Drawing.Size(240, 35);
            this.tbxTarih.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CitsDemo.Properties.Resources._1200px_User_icon_cp_svg;
            this.pictureBox1.Location = new System.Drawing.Point(29, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1183, 575);
            this.Controls.Add(this.tbxTarih);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbxRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.tbxSicil);
            this.Controls.Add(this.lblSicil);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Hub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hub";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSicil;
        private System.Windows.Forms.TextBox tbxRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox tbxTarih;
        public System.Windows.Forms.TextBox tbxName;
        public System.Windows.Forms.TextBox tbxSicil;
    }
}