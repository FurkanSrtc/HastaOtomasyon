namespace KlinikApp
{
    partial class Login
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
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.sifreLink = new System.Windows.Forms.LinkLabel();
            this.mailRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(12, 12);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(122, 20);
            this.mailTxt.TabIndex = 0;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(12, 38);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(122, 20);
            this.sifreTxt.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(12, 64);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(122, 20);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "button1";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // sifreLink
            // 
            this.sifreLink.AutoSize = true;
            this.sifreLink.Location = new System.Drawing.Point(12, 110);
            this.sifreLink.Name = "sifreLink";
            this.sifreLink.Size = new System.Drawing.Size(81, 13);
            this.sifreLink.TabIndex = 3;
            this.sifreLink.TabStop = true;
            this.sifreLink.Text = "Şifremi Unuttum";
            // 
            // mailRadio
            // 
            this.mailRadio.AutoSize = true;
            this.mailRadio.Location = new System.Drawing.Point(12, 90);
            this.mailRadio.Name = "mailRadio";
            this.mailRadio.Size = new System.Drawing.Size(87, 17);
            this.mailRadio.TabIndex = 4;
            this.mailRadio.TabStop = true;
            this.mailRadio.Text = "E-Mail Hatırla";
            this.mailRadio.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 137);
            this.Controls.Add(this.mailRadio);
            this.Controls.Add(this.sifreLink);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.mailTxt);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.LinkLabel sifreLink;
        private System.Windows.Forms.RadioButton mailRadio;
    }
}