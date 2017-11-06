namespace WindowsFormsMailClient
{
    partial class Form1
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
            this.lblRecipient = new System.Windows.Forms.Label();
            this.lblMessageTitle = new System.Windows.Forms.Label();
            this.lblMessageBody = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.inptRecipient = new System.Windows.Forms.TextBox();
            this.inptMessageTitle = new System.Windows.Forms.TextBox();
            this.inptMessageBody = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRecipient
            // 
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.Location = new System.Drawing.Point(28, 30);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(46, 13);
            this.lblRecipient.TabIndex = 0;
            this.lblRecipient.Text = "Primatelj";
            // 
            // lblMessageTitle
            // 
            this.lblMessageTitle.AutoSize = true;
            this.lblMessageTitle.Location = new System.Drawing.Point(28, 68);
            this.lblMessageTitle.Name = "lblMessageTitle";
            this.lblMessageTitle.Size = new System.Drawing.Size(76, 13);
            this.lblMessageTitle.TabIndex = 1;
            this.lblMessageTitle.Text = "Naslov poruke";
            // 
            // lblMessageBody
            // 
            this.lblMessageBody.AutoSize = true;
            this.lblMessageBody.Location = new System.Drawing.Point(28, 109);
            this.lblMessageBody.Name = "lblMessageBody";
            this.lblMessageBody.Size = new System.Drawing.Size(68, 13);
            this.lblMessageBody.TabIndex = 2;
            this.lblMessageBody.Text = "Tijelo poruke";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(28, 151);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Pošalji";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // inptRecipient
            // 
            this.inptRecipient.Location = new System.Drawing.Point(136, 30);
            this.inptRecipient.Name = "inptRecipient";
            this.inptRecipient.Size = new System.Drawing.Size(100, 20);
            this.inptRecipient.TabIndex = 4;
            this.inptRecipient.TextChanged += new System.EventHandler(this.inptRecipient_TextChanged);
            // 
            // inptMessageTitle
            // 
            this.inptMessageTitle.Location = new System.Drawing.Point(136, 68);
            this.inptMessageTitle.Name = "inptMessageTitle";
            this.inptMessageTitle.Size = new System.Drawing.Size(100, 20);
            this.inptMessageTitle.TabIndex = 5;
            this.inptMessageTitle.TextChanged += new System.EventHandler(this.inptMessageTitle_TextChanged);
            // 
            // inptMessageBody
            // 
            this.inptMessageBody.Location = new System.Drawing.Point(136, 109);
            this.inptMessageBody.Name = "inptMessageBody";
            this.inptMessageBody.Size = new System.Drawing.Size(100, 20);
            this.inptMessageBody.TabIndex = 6;
            this.inptMessageBody.TextChanged += new System.EventHandler(this.inptMessageBody_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.inptMessageBody);
            this.Controls.Add(this.inptMessageTitle);
            this.Controls.Add(this.inptRecipient);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblMessageBody);
            this.Controls.Add(this.lblMessageTitle);
            this.Controls.Add(this.lblRecipient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.Label lblMessageTitle;
        private System.Windows.Forms.Label lblMessageBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox inptRecipient;
        private System.Windows.Forms.TextBox inptMessageTitle;
        private System.Windows.Forms.TextBox inptMessageBody;
    }
}

