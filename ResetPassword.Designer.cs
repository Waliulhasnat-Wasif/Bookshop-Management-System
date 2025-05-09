namespace Bookshop
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.dynamicLabel = new System.Windows.Forms.Label();
            this.resetPassSecurKeyLabel = new System.Windows.Forms.Label();
            this.resetPassSecureKeyTextbox = new System.Windows.Forms.TextBox();
            this.resetPass = new System.Windows.Forms.Button();
            this.cancelReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newPassLabel = new System.Windows.Forms.Label();
            this.resetPassConfirmPass = new System.Windows.Forms.TextBox();
            this.resetPassNewPass = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dynamicLabel
            // 
            this.dynamicLabel.AutoSize = true;
            this.dynamicLabel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynamicLabel.ForeColor = System.Drawing.Color.Red;
            this.dynamicLabel.Location = new System.Drawing.Point(374, 116);
            this.dynamicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dynamicLabel.Name = "dynamicLabel";
            this.dynamicLabel.Size = new System.Drawing.Size(0, 22);
            this.dynamicLabel.TabIndex = 26;
            // 
            // resetPassSecurKeyLabel
            // 
            this.resetPassSecurKeyLabel.AutoSize = true;
            this.resetPassSecurKeyLabel.BackColor = System.Drawing.Color.Transparent;
            this.resetPassSecurKeyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPassSecurKeyLabel.Location = new System.Drawing.Point(124, 143);
            this.resetPassSecurKeyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resetPassSecurKeyLabel.Name = "resetPassSecurKeyLabel";
            this.resetPassSecurKeyLabel.Size = new System.Drawing.Size(148, 32);
            this.resetPassSecurKeyLabel.TabIndex = 25;
            this.resetPassSecurKeyLabel.Text = "Security Key";
            // 
            // resetPassSecureKeyTextbox
            // 
            this.resetPassSecureKeyTextbox.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPassSecureKeyTextbox.Location = new System.Drawing.Point(360, 143);
            this.resetPassSecureKeyTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetPassSecureKeyTextbox.Name = "resetPassSecureKeyTextbox";
            this.resetPassSecureKeyTextbox.Size = new System.Drawing.Size(224, 45);
            this.resetPassSecureKeyTextbox.TabIndex = 24;
            this.resetPassSecureKeyTextbox.TextChanged += new System.EventHandler(this.resetPassSecureKeyTextbox_TextChanged);
            // 
            // resetPass
            // 
            this.resetPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPass.Location = new System.Drawing.Point(207, 411);
            this.resetPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetPass.Name = "resetPass";
            this.resetPass.Size = new System.Drawing.Size(198, 55);
            this.resetPass.TabIndex = 23;
            this.resetPass.Text = "Reset Password";
            this.resetPass.UseVisualStyleBackColor = true;
            this.resetPass.Click += new System.EventHandler(this.resetPass_Click);
            // 
            // cancelReset
            // 
            this.cancelReset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelReset.Location = new System.Drawing.Point(512, 411);
            this.cancelReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelReset.Name = "cancelReset";
            this.cancelReset.Size = new System.Drawing.Size(112, 55);
            this.cancelReset.TabIndex = 22;
            this.cancelReset.Text = "Cancel";
            this.cancelReset.UseVisualStyleBackColor = true;
            this.cancelReset.Click += new System.EventHandler(this.cancelReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 328);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Confirm Password";
            // 
            // newPassLabel
            // 
            this.newPassLabel.AutoSize = true;
            this.newPassLabel.BackColor = System.Drawing.Color.Transparent;
            this.newPassLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassLabel.Location = new System.Drawing.Point(124, 247);
            this.newPassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(171, 32);
            this.newPassLabel.TabIndex = 20;
            this.newPassLabel.Text = "New Password";
            // 
            // resetPassConfirmPass
            // 
            this.resetPassConfirmPass.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPassConfirmPass.Location = new System.Drawing.Point(360, 328);
            this.resetPassConfirmPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetPassConfirmPass.Name = "resetPassConfirmPass";
            this.resetPassConfirmPass.Size = new System.Drawing.Size(224, 45);
            this.resetPassConfirmPass.TabIndex = 19;
            this.resetPassConfirmPass.TextChanged += new System.EventHandler(this.resetPassConfirmPass_TextChanged);
            // 
            // resetPassNewPass
            // 
            this.resetPassNewPass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPassNewPass.Location = new System.Drawing.Point(360, 234);
            this.resetPassNewPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetPassNewPass.Name = "resetPassNewPass";
            this.resetPassNewPass.Size = new System.Drawing.Size(224, 45);
            this.resetPassNewPass.TabIndex = 18;
            this.resetPassNewPass.TextChanged += new System.EventHandler(this.resetPassNewPass_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(837, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Location = new System.Drawing.Point(373, 193);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 28);
            this.labelMessage.TabIndex = 43;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(882, 529);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dynamicLabel);
            this.Controls.Add(this.resetPassSecurKeyLabel);
            this.Controls.Add(this.resetPassSecureKeyTextbox);
            this.Controls.Add(this.resetPass);
            this.Controls.Add(this.cancelReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPassLabel);
            this.Controls.Add(this.resetPassConfirmPass);
            this.Controls.Add(this.resetPassNewPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dynamicLabel;
        private System.Windows.Forms.Label resetPassSecurKeyLabel;
        private System.Windows.Forms.TextBox resetPassSecureKeyTextbox;
        private System.Windows.Forms.Button resetPass;
        private System.Windows.Forms.Button cancelReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label newPassLabel;
        private System.Windows.Forms.TextBox resetPassConfirmPass;
        private System.Windows.Forms.TextBox resetPassNewPass;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelMessage;
    }
}