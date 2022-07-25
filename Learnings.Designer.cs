namespace CitsDemo
{
    partial class Learnings
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
            this.lblFName = new System.Windows.Forms.Label();
            this.tbxFName = new System.Windows.Forms.TextBox();
            this.tbxSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.tbxContent = new System.Windows.Forms.TextBox();
            this.btnAddTxt = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFName.Location = new System.Drawing.Point(28, 54);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(114, 26);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "File Name :";
            // 
            // tbxFName
            // 
            this.tbxFName.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxFName.Location = new System.Drawing.Point(148, 51);
            this.tbxFName.Name = "tbxFName";
            this.tbxFName.Size = new System.Drawing.Size(803, 34);
            this.tbxFName.TabIndex = 1;
            // 
            // tbxSubject
            // 
            this.tbxSubject.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSubject.Location = new System.Drawing.Point(148, 127);
            this.tbxSubject.Name = "tbxSubject";
            this.tbxSubject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxSubject.Size = new System.Drawing.Size(803, 34);
            this.tbxSubject.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 127);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 2;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubject.Location = new System.Drawing.Point(28, 132);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(78, 26);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Subject";
            // 
            // tbxContent
            // 
            this.tbxContent.Location = new System.Drawing.Point(148, 221);
            this.tbxContent.Multiline = true;
            this.tbxContent.Name = "tbxContent";
            this.tbxContent.Size = new System.Drawing.Size(985, 345);
            this.tbxContent.TabIndex = 5;
            // 
            // btnAddTxt
            // 
            this.btnAddTxt.BackColor = System.Drawing.Color.DimGray;
            this.btnAddTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTxt.Location = new System.Drawing.Point(1002, 51);
            this.btnAddTxt.Name = "btnAddTxt";
            this.btnAddTxt.Size = new System.Drawing.Size(131, 110);
            this.btnAddTxt.TabIndex = 6;
            this.btnAddTxt.Text = "Add";
            this.btnAddTxt.UseVisualStyleBackColor = false;
            this.btnAddTxt.Click += new System.EventHandler(this.btnAddTxt_Click);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblContent.Location = new System.Drawing.Point(33, 246);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(94, 26);
            this.lblContent.TabIndex = 7;
            this.lblContent.Text = "Content :";
            // 
            // Learnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1181, 599);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.btnAddTxt);
            this.Controls.Add(this.tbxContent);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.tbxSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxFName);
            this.Controls.Add(this.lblFName);
            this.MaximizeBox = false;
            this.Name = "Learnings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learnings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox tbxFName;
        private System.Windows.Forms.TextBox tbxSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox tbxContent;
        private System.Windows.Forms.Button btnAddTxt;
        private System.Windows.Forms.Label lblContent;
    }
}