namespace Bookshop
{
    partial class UserStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserStatus));
            this.userStatusGridView = new System.Windows.Forms.DataGridView();
            this.activeButton = new System.Windows.Forms.Button();
            this.deactiveButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userStatusGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // userStatusGridView
            // 
            this.userStatusGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userStatusGridView.Location = new System.Drawing.Point(201, 215);
            this.userStatusGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userStatusGridView.Name = "userStatusGridView";
            this.userStatusGridView.RowHeadersWidth = 62;
            this.userStatusGridView.Size = new System.Drawing.Size(664, 313);
            this.userStatusGridView.TabIndex = 1;
            // 
            // activeButton
            // 
            this.activeButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.activeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeButton.ForeColor = System.Drawing.Color.Ivory;
            this.activeButton.Location = new System.Drawing.Point(386, 536);
            this.activeButton.Name = "activeButton";
            this.activeButton.Size = new System.Drawing.Size(144, 50);
            this.activeButton.TabIndex = 37;
            this.activeButton.Text = "Activate";
            this.activeButton.UseVisualStyleBackColor = false;
            this.activeButton.Click += new System.EventHandler(this.activeButton_Click);
            // 
            // deactiveButton
            // 
            this.deactiveButton.BackColor = System.Drawing.Color.OrangeRed;
            this.deactiveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactiveButton.ForeColor = System.Drawing.Color.Ivory;
            this.deactiveButton.Location = new System.Drawing.Point(536, 536);
            this.deactiveButton.Name = "deactiveButton";
            this.deactiveButton.Size = new System.Drawing.Size(144, 50);
            this.deactiveButton.TabIndex = 38;
            this.deactiveButton.Text = "Deactivate";
            this.deactiveButton.UseVisualStyleBackColor = false;
            this.deactiveButton.Click += new System.EventHandler(this.deactiveButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1045, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(370, 158);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(244, 45);
            this.textBoxSearch.TabIndex = 65;
            this.textBoxSearch.Text = "Search By Name";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxSearch_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(635, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 49);
            this.button1.TabIndex = 67;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1092, 725);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.deactiveButton);
            this.Controls.Add(this.activeButton);
            this.Controls.Add(this.userStatusGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserStatus";
            ((System.ComponentModel.ISupportInitialize)(this.userStatusGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userStatusGridView;
        private System.Windows.Forms.Button activeButton;
        private System.Windows.Forms.Button deactiveButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button1;
    }
}