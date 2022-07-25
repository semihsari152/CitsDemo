namespace CitsDemo
{
    partial class GirisCikisTable
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
            this.dtGirisCikis = new System.Windows.Forms.DataGridView();
            this.gbxAdminPanel = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblGirisSaati = new System.Windows.Forms.Label();
            this.tbxCikis = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCikisSaati = new System.Windows.Forms.Label();
            this.tbxGiris = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGirisCikis)).BeginInit();
            this.gbxAdminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGirisCikis
            // 
            this.dtGirisCikis.ColumnHeadersHeight = 34;
            this.dtGirisCikis.Location = new System.Drawing.Point(33, 36);
            this.dtGirisCikis.Name = "dtGirisCikis";
            this.dtGirisCikis.ReadOnly = true;
            this.dtGirisCikis.RowHeadersWidth = 62;
            this.dtGirisCikis.Size = new System.Drawing.Size(870, 559);
            this.dtGirisCikis.TabIndex = 4;
            this.dtGirisCikis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGirisCikis_CellClick);
            // 
            // gbxAdminPanel
            // 
            this.gbxAdminPanel.Controls.Add(this.btnUpdate);
            this.gbxAdminPanel.Controls.Add(this.lblGirisSaati);
            this.gbxAdminPanel.Controls.Add(this.tbxCikis);
            this.gbxAdminPanel.Controls.Add(this.btnDelete);
            this.gbxAdminPanel.Controls.Add(this.lblCikisSaati);
            this.gbxAdminPanel.Controls.Add(this.tbxGiris);
            this.gbxAdminPanel.Location = new System.Drawing.Point(34, 601);
            this.gbxAdminPanel.Name = "gbxAdminPanel";
            this.gbxAdminPanel.Size = new System.Drawing.Size(869, 96);
            this.gbxAdminPanel.TabIndex = 11;
            this.gbxAdminPanel.TabStop = false;
            this.gbxAdminPanel.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(-1, 25);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(246, 47);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // lblGirisSaati
            // 
            this.lblGirisSaati.AutoSize = true;
            this.lblGirisSaati.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisSaati.Location = new System.Drawing.Point(292, 25);
            this.lblGirisSaati.Name = "lblGirisSaati";
            this.lblGirisSaati.Size = new System.Drawing.Size(45, 21);
            this.lblGirisSaati.TabIndex = 13;
            this.lblGirisSaati.Text = "Giris:";
            // 
            // tbxCikis
            // 
            this.tbxCikis.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCikis.Location = new System.Drawing.Point(375, 62);
            this.tbxCikis.Name = "tbxCikis";
            this.tbxCikis.Size = new System.Drawing.Size(188, 29);
            this.tbxCikis.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(628, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(241, 47);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // lblCikisSaati
            // 
            this.lblCikisSaati.AutoSize = true;
            this.lblCikisSaati.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikisSaati.Location = new System.Drawing.Point(292, 65);
            this.lblCikisSaati.Name = "lblCikisSaati";
            this.lblCikisSaati.Size = new System.Drawing.Size(52, 21);
            this.lblCikisSaati.TabIndex = 15;
            this.lblCikisSaati.Text = "Çıkış :";
            // 
            // tbxGiris
            // 
            this.tbxGiris.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGiris.Location = new System.Drawing.Point(375, 15);
            this.tbxGiris.Name = "tbxGiris";
            this.tbxGiris.Size = new System.Drawing.Size(188, 29);
            this.tbxGiris.TabIndex = 14;
            // 
            // GirisCikisTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 709);
            this.Controls.Add(this.gbxAdminPanel);
            this.Controls.Add(this.dtGirisCikis);
            this.MaximizeBox = false;
            this.Name = "GirisCikisTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisCikisTable";
            ((System.ComponentModel.ISupportInitialize)(this.dtGirisCikis)).EndInit();
            this.gbxAdminPanel.ResumeLayout(false);
            this.gbxAdminPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGirisCikis;
        private System.Windows.Forms.GroupBox gbxAdminPanel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblGirisSaati;
        private System.Windows.Forms.TextBox tbxCikis;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCikisSaati;
        private System.Windows.Forms.TextBox tbxGiris;
    }
}