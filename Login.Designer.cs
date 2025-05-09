namespace Bookshop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_UserID = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.label_Password = new System.Windows.Forms.Label();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_ClearPW = new System.Windows.Forms.Button();
            this.button_ClearID = new System.Windows.Forms.Button();
            this.textBox_PW = new System.Windows.Forms.TextBox();
            this.showPasspictureBox = new System.Windows.Forms.PictureBox();
            this.hidePasspictureBox = new System.Windows.Forms.PictureBox();
            this.forgotPassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPasspictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePasspictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(302, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.BackColor = System.Drawing.Color.Transparent;
            this.label_UserID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserID.Location = new System.Drawing.Point(161, 252);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(94, 32);
            this.label_UserID.TabIndex = 1;
            this.label_UserID.Text = "User ID";
            this.label_UserID.Click += new System.EventHandler(this.label_UserID_Click);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(302, 249);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(226, 45);
            this.textBox_ID.TabIndex = 2;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.Transparent;
            this.button_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Login.Location = new System.Drawing.Point(278, 434);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(122, 47);
            this.button_Login.TabIndex = 3;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.Color.Transparent;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(161, 327);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(115, 32);
            this.label_Password.TabIndex = 4;
            this.label_Password.Text = "Password";
            // 
            // button_SignUp
            // 
            this.button_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.button_SignUp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SignUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_SignUp.Location = new System.Drawing.Point(426, 434);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(120, 47);
            this.button_SignUp.TabIndex = 6;
            this.button_SignUp.Text = "Sign Up";
            this.button_SignUp.UseVisualStyleBackColor = false;
            this.button_SignUp.Click += new System.EventHandler(this.button_SignUp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(768, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button_ClearPW
            // 
            this.button_ClearPW.BackColor = System.Drawing.Color.Transparent;
            this.button_ClearPW.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ClearPW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_ClearPW.Location = new System.Drawing.Point(571, 320);
            this.button_ClearPW.Name = "button_ClearPW";
            this.button_ClearPW.Size = new System.Drawing.Size(75, 39);
            this.button_ClearPW.TabIndex = 8;
            this.button_ClearPW.Text = "Clear";
            this.button_ClearPW.UseVisualStyleBackColor = false;
            this.button_ClearPW.Click += new System.EventHandler(this.button_ClearPW_Click);
            // 
            // button_ClearID
            // 
            this.button_ClearID.BackColor = System.Drawing.Color.Transparent;
            this.button_ClearID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ClearID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_ClearID.Location = new System.Drawing.Point(571, 251);
            this.button_ClearID.Name = "button_ClearID";
            this.button_ClearID.Size = new System.Drawing.Size(75, 39);
            this.button_ClearID.TabIndex = 9;
            this.button_ClearID.Text = "Clear";
            this.button_ClearID.UseVisualStyleBackColor = false;
            this.button_ClearID.Click += new System.EventHandler(this.button_ClearID_Click_1);
            // 
            // textBox_PW
            // 
            this.textBox_PW.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PW.Location = new System.Drawing.Point(302, 320);
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.Size = new System.Drawing.Size(226, 45);
            this.textBox_PW.TabIndex = 10;
            this.textBox_PW.TextChanged += new System.EventHandler(this.textBox_PW_TextChanged);
            // 
            // showPasspictureBox
            // 
            this.showPasspictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasspictureBox.Image = ((System.Drawing.Image)(resources.GetObject("showPasspictureBox.Image")));
            this.showPasspictureBox.Location = new System.Drawing.Point(498, 330);
            this.showPasspictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showPasspictureBox.Name = "showPasspictureBox";
            this.showPasspictureBox.Size = new System.Drawing.Size(30, 29);
            this.showPasspictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPasspictureBox.TabIndex = 14;
            this.showPasspictureBox.TabStop = false;
            this.showPasspictureBox.Visible = false;
            this.showPasspictureBox.Click += new System.EventHandler(this.showPasspictureBox_Click_1);
            // 
            // hidePasspictureBox
            // 
            this.hidePasspictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidePasspictureBox.Image = ((System.Drawing.Image)(resources.GetObject("hidePasspictureBox.Image")));
            this.hidePasspictureBox.Location = new System.Drawing.Point(498, 330);
            this.hidePasspictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hidePasspictureBox.Name = "hidePasspictureBox";
            this.hidePasspictureBox.Size = new System.Drawing.Size(30, 29);
            this.hidePasspictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidePasspictureBox.TabIndex = 15;
            this.hidePasspictureBox.TabStop = false;
            this.hidePasspictureBox.Click += new System.EventHandler(this.hidePasspictureBox_Click_1);
            // 
            // forgotPassLabel
            // 
            this.forgotPassLabel.AutoSize = true;
            this.forgotPassLabel.BackColor = System.Drawing.Color.Transparent;
            this.forgotPassLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.forgotPassLabel.Location = new System.Drawing.Point(343, 538);
            this.forgotPassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgotPassLabel.Name = "forgotPassLabel";
            this.forgotPassLabel.Size = new System.Drawing.Size(145, 20);
            this.forgotPassLabel.TabIndex = 16;
            this.forgotPassLabel.Text = "Forgot Password?";
            this.forgotPassLabel.Click += new System.EventHandler(this.forgotPassLabel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 594);
            this.Controls.Add(this.forgotPassLabel);
            this.Controls.Add(this.hidePasspictureBox);
            this.Controls.Add(this.showPasspictureBox);
            this.Controls.Add(this.textBox_PW);
            this.Controls.Add(this.button_ClearID);
            this.Controls.Add(this.button_ClearPW);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_SignUp);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_UserID);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPasspictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePasspictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_UserID;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_ClearPW;
        private System.Windows.Forms.Button button_ClearID;
        private System.Windows.Forms.TextBox textBox_PW;
        private System.Windows.Forms.PictureBox showPasspictureBox;
        private System.Windows.Forms.PictureBox hidePasspictureBox;
        private System.Windows.Forms.Label forgotPassLabel;
    }
}