namespace Bookshop
{
    partial class BookStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookStatus));
            this.BookStatusGridView = new System.Windows.Forms.DataGridView();
            this.activeButton = new System.Windows.Forms.Button();
            this.deactiveButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookStatusGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // BookStatusGridView
            // 
            this.BookStatusGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookStatusGridView.Location = new System.Drawing.Point(222, 245);
            this.BookStatusGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BookStatusGridView.Name = "BookStatusGridView";
            this.BookStatusGridView.RowHeadersWidth = 62;
            this.BookStatusGridView.Size = new System.Drawing.Size(1177, 475);
            this.BookStatusGridView.TabIndex = 2;
            this.BookStatusGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BookStatusGridView_RowHeaderMouseClick);
            // 
            // activeButton
            // 
            this.activeButton.BackColor = System.Drawing.Color.DarkBlue;
            this.activeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeButton.ForeColor = System.Drawing.Color.Ivory;
            this.activeButton.Location = new System.Drawing.Point(632, 187);
            this.activeButton.Name = "activeButton";
            this.activeButton.Size = new System.Drawing.Size(144, 50);
            this.activeButton.TabIndex = 38;
            this.activeButton.Text = "Activate";
            this.activeButton.UseVisualStyleBackColor = false;
            this.activeButton.Click += new System.EventHandler(this.activeButton_Click);
            // 
            // deactiveButton
            // 
            this.deactiveButton.BackColor = System.Drawing.Color.OrangeRed;
            this.deactiveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactiveButton.ForeColor = System.Drawing.Color.Ivory;
            this.deactiveButton.Location = new System.Drawing.Point(803, 187);
            this.deactiveButton.Name = "deactiveButton";
            this.deactiveButton.Size = new System.Drawing.Size(144, 50);
            this.deactiveButton.TabIndex = 39;
            this.deactiveButton.Text = "Deactivate";
            this.deactiveButton.UseVisualStyleBackColor = false;
            this.deactiveButton.Click += new System.EventHandler(this.deactiveButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1514, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(582, 125);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(400, 45);
            this.textBoxSearch.TabIndex = 64;
            this.textBoxSearch.Text = "             Search By Name";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxSearch_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(1009, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 49);
            this.button1.TabIndex = 66;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1559, 765);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.deactiveButton);
            this.Controls.Add(this.activeButton);
            this.Controls.Add(this.BookStatusGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookStatus";
            ((System.ComponentModel.ISupportInitialize)(this.BookStatusGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BookStatusGridView;
        private System.Windows.Forms.Button activeButton;
        private System.Windows.Forms.Button deactiveButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button1;
    }
}