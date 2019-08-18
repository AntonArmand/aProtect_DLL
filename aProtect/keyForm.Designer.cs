namespace aProtect
{
    partial class keyForm
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
            this.mainTextBoxEmail = new System.Windows.Forms.TextBox();
            this.mainTextBoxKey = new System.Windows.Forms.MaskedTextBox();
            this.mainButtonClose = new System.Windows.Forms.Button();
            this.mainButtonWebsite = new System.Windows.Forms.Button();
            this.mainButtonActivate = new System.Windows.Forms.Button();
            this.mainTitle = new System.Windows.Forms.Label();
            this.mainLabelProductKey = new System.Windows.Forms.Label();
            this.mainLabelMail = new System.Windows.Forms.Label();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTextBoxEmail
            // 
            this.mainTextBoxEmail.Location = new System.Drawing.Point(189, 290);
            this.mainTextBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.mainTextBoxEmail.Name = "mainTextBoxEmail";
            this.mainTextBoxEmail.Size = new System.Drawing.Size(332, 20);
            this.mainTextBoxEmail.TabIndex = 26;
            this.mainTextBoxEmail.TextChanged += new System.EventHandler(this.MainTextBoxEmail_TextChanged);
            // 
            // mainTextBoxKey
            // 
            this.mainTextBoxKey.Location = new System.Drawing.Point(189, 352);
            this.mainTextBoxKey.Margin = new System.Windows.Forms.Padding(2);
            this.mainTextBoxKey.Mask = "AAAA-AAAA-AAAA-AAAA";
            this.mainTextBoxKey.Name = "mainTextBoxKey";
            this.mainTextBoxKey.Size = new System.Drawing.Size(332, 20);
            this.mainTextBoxKey.TabIndex = 25;
            this.mainTextBoxKey.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MainTextBoxKey_MaskInputRejected);
            // 
            // mainButtonClose
            // 
            this.mainButtonClose.Location = new System.Drawing.Point(427, 396);
            this.mainButtonClose.Margin = new System.Windows.Forms.Padding(2);
            this.mainButtonClose.Name = "mainButtonClose";
            this.mainButtonClose.Size = new System.Drawing.Size(152, 27);
            this.mainButtonClose.TabIndex = 24;
            this.mainButtonClose.Text = "Close";
            this.mainButtonClose.UseVisualStyleBackColor = true;
            this.mainButtonClose.Click += new System.EventHandler(this.MainButtonClose_Click);
            // 
            // mainButtonWebsite
            // 
            this.mainButtonWebsite.Location = new System.Drawing.Point(35, 396);
            this.mainButtonWebsite.Margin = new System.Windows.Forms.Padding(2);
            this.mainButtonWebsite.Name = "mainButtonWebsite";
            this.mainButtonWebsite.Size = new System.Drawing.Size(152, 27);
            this.mainButtonWebsite.TabIndex = 23;
            this.mainButtonWebsite.Text = "Let\'s visit our website !!";
            this.mainButtonWebsite.UseVisualStyleBackColor = true;
            this.mainButtonWebsite.Click += new System.EventHandler(this.MainButtonWebsite_Click);
            // 
            // mainButtonActivate
            // 
            this.mainButtonActivate.Location = new System.Drawing.Point(228, 396);
            this.mainButtonActivate.Margin = new System.Windows.Forms.Padding(2);
            this.mainButtonActivate.Name = "mainButtonActivate";
            this.mainButtonActivate.Size = new System.Drawing.Size(152, 27);
            this.mainButtonActivate.TabIndex = 22;
            this.mainButtonActivate.Text = "Activate";
            this.mainButtonActivate.UseVisualStyleBackColor = true;
            this.mainButtonActivate.Click += new System.EventHandler(this.MainButtonActivate_Click);
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(172, 237);
            this.mainTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(282, 22);
            this.mainTitle.TabIndex = 21;
            this.mainTitle.Text = "AtoutProtect - RPI - 2018/2019";
            this.mainTitle.Click += new System.EventHandler(this.MainTitle_Click);
            // 
            // mainLabelProductKey
            // 
            this.mainLabelProductKey.AutoSize = true;
            this.mainLabelProductKey.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabelProductKey.Location = new System.Drawing.Point(75, 352);
            this.mainLabelProductKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainLabelProductKey.Name = "mainLabelProductKey";
            this.mainLabelProductKey.Size = new System.Drawing.Size(75, 17);
            this.mainLabelProductKey.TabIndex = 20;
            this.mainLabelProductKey.Text = "Product Key :";
            this.mainLabelProductKey.Click += new System.EventHandler(this.MainLabelProductKey_Click);
            // 
            // mainLabelMail
            // 
            this.mainLabelMail.AutoSize = true;
            this.mainLabelMail.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabelMail.Location = new System.Drawing.Point(71, 291);
            this.mainLabelMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainLabelMail.Name = "mainLabelMail";
            this.mainLabelMail.Size = new System.Drawing.Size(78, 17);
            this.mainLabelMail.TabIndex = 19;
            this.mainLabelMail.Text = "Mail address :";
            this.mainLabelMail.Click += new System.EventHandler(this.MainLabelMail_Click);
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Image = global::aProtect.Properties.Resources.AtoutProtect;
            this.mainPictureBox.Location = new System.Drawing.Point(-2, -1);
            this.mainPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(641, 236);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPictureBox.TabIndex = 18;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.Click += new System.EventHandler(this.MainPictureBox_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(85, 323);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(64, 17);
            this.passwordLabel.TabIndex = 27;
            this.passwordLabel.Text = "Password :";
            this.passwordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(189, 323);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(332, 20);
            this.textBoxPassword.TabIndex = 28;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // keyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 444);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.mainTextBoxEmail);
            this.Controls.Add(this.mainTextBoxKey);
            this.Controls.Add(this.mainButtonClose);
            this.Controls.Add(this.mainButtonWebsite);
            this.Controls.Add(this.mainButtonActivate);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.mainLabelProductKey);
            this.Controls.Add(this.mainLabelMail);
            this.Controls.Add(this.mainPictureBox);
            this.Name = "keyForm";
            this.Text = "aProtect";
            this.Load += new System.EventHandler(this.KeyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainTextBoxEmail;
        private System.Windows.Forms.MaskedTextBox mainTextBoxKey;
        private System.Windows.Forms.Button mainButtonClose;
        private System.Windows.Forms.Button mainButtonWebsite;
        private System.Windows.Forms.Button mainButtonActivate;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Label mainLabelProductKey;
        private System.Windows.Forms.Label mainLabelMail;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}