namespace ReadWriteTXT
{
    partial class FormReadWrite
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
            this.btnWriteTXT = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnReadTXT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWriteTXT
            // 
            this.btnWriteTXT.Location = new System.Drawing.Point(12, 371);
            this.btnWriteTXT.Name = "btnWriteTXT";
            this.btnWriteTXT.Size = new System.Drawing.Size(227, 72);
            this.btnWriteTXT.TabIndex = 6;
            this.btnWriteTXT.Text = "Write TXT";
            this.btnWriteTXT.UseVisualStyleBackColor = true;
            this.btnWriteTXT.Click += new System.EventHandler(this.btnWriteTXT_Click);
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(12, 12);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(776, 353);
            this.txtContent.TabIndex = 7;
            // 
            // btnReadTXT
            // 
            this.btnReadTXT.Location = new System.Drawing.Point(245, 371);
            this.btnReadTXT.Name = "btnReadTXT";
            this.btnReadTXT.Size = new System.Drawing.Size(227, 72);
            this.btnReadTXT.TabIndex = 8;
            this.btnReadTXT.Text = "Read TXT";
            this.btnReadTXT.UseVisualStyleBackColor = true;
            this.btnReadTXT.Click += new System.EventHandler(this.btnReadTXT_Click);
            // 
            // FormReadWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReadTXT);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnWriteTXT);
            this.Name = "FormReadWrite";
            this.Text = "TXT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnWriteTXT;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnReadTXT;
    }
}

