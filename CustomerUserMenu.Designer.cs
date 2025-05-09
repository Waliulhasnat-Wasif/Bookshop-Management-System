namespace Bookshop
{
    partial class CustomerUserMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerUserMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_ID = new System.Windows.Forms.Label();
            this.labelTextID = new System.Windows.Forms.Label();
            this.pictureBoxUsers = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.buttonBillHistory = new System.Windows.Forms.Button();
            this.numericUpDownQnt = new System.Windows.Forms.NumericUpDown();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBoxCN = new System.Windows.Forms.TextBox();
            this.textBoxBN = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.comboBoxFilterCtg = new System.Windows.Forms.ComboBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.dataGridViewBookList = new System.Windows.Forms.DataGridView();
            this.labelBookList = new System.Windows.Forms.Label();
            this.dataGridViewBookBill = new System.Windows.Forms.DataGridView();
            this.Client_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAddBill = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelQnt = new System.Windows.Forms.Label();
            this.labelBN = new System.Windows.Forms.Label();
            this.labelBill = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panelUserInfo);
            this.panel1.Controls.Add(this.label_ID);
            this.panel1.Controls.Add(this.labelTextID);
            this.panel1.Controls.Add(this.pictureBoxUsers);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 768);
            this.panel1.TabIndex = 0;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.BackColor = System.Drawing.Color.Black;
            this.label_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.SystemColors.Control;
            this.label_ID.Location = new System.Drawing.Point(165, 144);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(38, 32);
            this.label_ID.TabIndex = 8;
            this.label_ID.Text = "ID";
            this.label_ID.Click += new System.EventHandler(this.label_ID_Click);
            // 
            // labelTextID
            // 
            this.labelTextID.AutoSize = true;
            this.labelTextID.BackColor = System.Drawing.Color.Black;
            this.labelTextID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextID.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTextID.Location = new System.Drawing.Point(9, 144);
            this.labelTextID.Name = "labelTextID";
            this.labelTextID.Size = new System.Drawing.Size(156, 32);
            this.labelTextID.TabIndex = 7;
            this.labelTextID.Text = "Customer ID:";
            this.labelTextID.Click += new System.EventHandler(this.labelCustomerID_Click);
            // 
            // pictureBoxUsers
            // 
            this.pictureBoxUsers.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsers.Image")));
            this.pictureBoxUsers.Location = new System.Drawing.Point(61, 6);
            this.pictureBoxUsers.Name = "pictureBoxUsers";
            this.pictureBoxUsers.Size = new System.Drawing.Size(142, 125);
            this.pictureBoxUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsers.TabIndex = 5;
            this.pictureBoxUsers.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 643);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(114, 643);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logout";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Book Store";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 411);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.numericUpDownPrice);
            this.panel2.Controls.Add(this.buttonBillHistory);
            this.panel2.Controls.Add(this.numericUpDownQnt);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.textBoxCN);
            this.panel2.Controls.Add(this.textBoxBN);
            this.panel2.Controls.Add(this.buttonRefresh);
            this.panel2.Controls.Add(this.comboBoxFilterCtg);
            this.panel2.Controls.Add(this.buttonPrint);
            this.panel2.Controls.Add(this.labelTotalAmount);
            this.panel2.Controls.Add(this.dataGridViewBookList);
            this.panel2.Controls.Add(this.labelBookList);
            this.panel2.Controls.Add(this.dataGridViewBookBill);
            this.panel2.Controls.Add(this.buttonReset);
            this.panel2.Controls.Add(this.buttonAddBill);
            this.panel2.Controls.Add(this.labelPrice);
            this.panel2.Controls.Add(this.labelClientName);
            this.panel2.Controls.Add(this.labelQnt);
            this.panel2.Controls.Add(this.labelBN);
            this.panel2.Controls.Add(this.labelBill);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(304, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 765);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPrice.Location = new System.Drawing.Point(401, 197);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(113, 39);
            this.numericUpDownPrice.TabIndex = 55;
            // 
            // buttonBillHistory
            // 
            this.buttonBillHistory.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonBillHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBillHistory.ForeColor = System.Drawing.Color.Ivory;
            this.buttonBillHistory.Location = new System.Drawing.Point(77, 327);
            this.buttonBillHistory.Name = "buttonBillHistory";
            this.buttonBillHistory.Size = new System.Drawing.Size(165, 53);
            this.buttonBillHistory.TabIndex = 43;
            this.buttonBillHistory.Text = "Bill History";
            this.buttonBillHistory.UseVisualStyleBackColor = false;
            this.buttonBillHistory.Click += new System.EventHandler(this.buttonBillHistory_Click);
            // 
            // numericUpDownQnt
            // 
            this.numericUpDownQnt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQnt.Location = new System.Drawing.Point(401, 108);
            this.numericUpDownQnt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownQnt.Name = "numericUpDownQnt";
            this.numericUpDownQnt.Size = new System.Drawing.Size(84, 39);
            this.numericUpDownQnt.TabIndex = 42;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1171, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // textBoxCN
            // 
            this.textBoxCN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCN.Location = new System.Drawing.Point(25, 197);
            this.textBoxCN.Name = "textBoxCN";
            this.textBoxCN.Size = new System.Drawing.Size(287, 39);
            this.textBoxCN.TabIndex = 39;
            // 
            // textBoxBN
            // 
            this.textBoxBN.Enabled = false;
            this.textBoxBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBN.Location = new System.Drawing.Point(25, 108);
            this.textBoxBN.Name = "textBoxBN";
            this.textBoxBN.Size = new System.Drawing.Size(359, 39);
            this.textBoxBN.TabIndex = 38;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.Ivory;
            this.buttonRefresh.Location = new System.Drawing.Point(862, 385);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(131, 50);
            this.buttonRefresh.TabIndex = 36;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // comboBoxFilterCtg
            // 
            this.comboBoxFilterCtg.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilterCtg.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxFilterCtg.FormattingEnabled = true;
            this.comboBoxFilterCtg.Items.AddRange(new object[] {
            "Programming",
            "Networking",
            "Mathematics",
            "Story"});
            this.comboBoxFilterCtg.Location = new System.Drawing.Point(303, 388);
            this.comboBoxFilterCtg.Name = "comboBoxFilterCtg";
            this.comboBoxFilterCtg.Size = new System.Drawing.Size(264, 46);
            this.comboBoxFilterCtg.TabIndex = 35;
            this.comboBoxFilterCtg.Text = "Filter By Category";
            this.comboBoxFilterCtg.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFilterCtg_SelectionChangeCommitted);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.Color.Ivory;
            this.buttonPrint.Location = new System.Drawing.Point(1022, 521);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(170, 60);
            this.buttonPrint.TabIndex = 20;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.BackColor = System.Drawing.Color.Ivory;
            this.labelTotalAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelTotalAmount.Location = new System.Drawing.Point(1050, 470);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(75, 38);
            this.labelTotalAmount.TabIndex = 19;
            this.labelTotalAmount.Text = "Total";
            // 
            // dataGridViewBookList
            // 
            this.dataGridViewBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookList.Location = new System.Drawing.Point(12, 441);
            this.dataGridViewBookList.Name = "dataGridViewBookList";
            this.dataGridViewBookList.RowHeadersWidth = 62;
            this.dataGridViewBookList.RowTemplate.Height = 28;
            this.dataGridViewBookList.Size = new System.Drawing.Size(981, 308);
            this.dataGridViewBookList.TabIndex = 18;
            this.dataGridViewBookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookList_CellContentClick);
            this.dataGridViewBookList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBookList_RowHeaderMouseClick);
            // 
            // labelBookList
            // 
            this.labelBookList.AutoSize = true;
            this.labelBookList.BackColor = System.Drawing.Color.Ivory;
            this.labelBookList.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookList.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelBookList.Location = new System.Drawing.Point(347, 340);
            this.labelBookList.Name = "labelBookList";
            this.labelBookList.Size = new System.Drawing.Size(167, 45);
            this.labelBookList.TabIndex = 17;
            this.labelBookList.Text = "Books List";
            // 
            // dataGridViewBookBill
            // 
            this.dataGridViewBookBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client_Name,
            this.Book_Name,
            this.Book_Price,
            this.Book_Quantity,
            this.Total_Amount});
            this.dataGridViewBookBill.Location = new System.Drawing.Point(526, 152);
            this.dataGridViewBookBill.Name = "dataGridViewBookBill";
            this.dataGridViewBookBill.RowHeadersWidth = 62;
            this.dataGridViewBookBill.RowTemplate.Height = 28;
            this.dataGridViewBookBill.Size = new System.Drawing.Size(687, 169);
            this.dataGridViewBookBill.TabIndex = 16;
            this.dataGridViewBookBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookBill_CellContentClick);
            // 
            // Client_Name
            // 
            this.Client_Name.HeaderText = "Client Name";
            this.Client_Name.MinimumWidth = 8;
            this.Client_Name.Name = "Client_Name";
            this.Client_Name.Width = 150;
            // 
            // Book_Name
            // 
            this.Book_Name.HeaderText = "Books";
            this.Book_Name.MinimumWidth = 8;
            this.Book_Name.Name = "Book_Name";
            this.Book_Name.Width = 150;
            // 
            // Book_Price
            // 
            this.Book_Price.HeaderText = "Price";
            this.Book_Price.MinimumWidth = 8;
            this.Book_Price.Name = "Book_Price";
            this.Book_Price.Width = 150;
            // 
            // Book_Quantity
            // 
            this.Book_Quantity.HeaderText = "Quantity";
            this.Book_Quantity.MinimumWidth = 8;
            this.Book_Quantity.Name = "Book_Quantity";
            this.Book_Quantity.Width = 150;
            // 
            // Total_Amount
            // 
            this.Total_Amount.HeaderText = "Total Amount";
            this.Total_Amount.MinimumWidth = 8;
            this.Total_Amount.Name = "Total_Amount";
            this.Total_Amount.Width = 150;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.Ivory;
            this.buttonReset.Location = new System.Drawing.Point(260, 259);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(152, 53);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonAddBill
            // 
            this.buttonAddBill.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAddBill.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBill.ForeColor = System.Drawing.Color.Ivory;
            this.buttonAddBill.Location = new System.Drawing.Point(77, 259);
            this.buttonAddBill.Name = "buttonAddBill";
            this.buttonAddBill.Size = new System.Drawing.Size(165, 53);
            this.buttonAddBill.TabIndex = 14;
            this.buttonAddBill.Text = "Add To Bill";
            this.buttonAddBill.UseVisualStyleBackColor = false;
            this.buttonAddBill.Click += new System.EventHandler(this.buttonAddBill_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Ivory;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.DimGray;
            this.labelPrice.Location = new System.Drawing.Point(394, 156);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(78, 38);
            this.labelPrice.TabIndex = 13;
            this.labelPrice.Text = "Price";
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.BackColor = System.Drawing.Color.Ivory;
            this.labelClientName.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientName.ForeColor = System.Drawing.Color.DimGray;
            this.labelClientName.Location = new System.Drawing.Point(27, 156);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(173, 38);
            this.labelClientName.TabIndex = 10;
            this.labelClientName.Text = "Client Name";
            // 
            // labelQnt
            // 
            this.labelQnt.AutoSize = true;
            this.labelQnt.BackColor = System.Drawing.Color.Ivory;
            this.labelQnt.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQnt.ForeColor = System.Drawing.Color.DimGray;
            this.labelQnt.Location = new System.Drawing.Point(394, 67);
            this.labelQnt.Name = "labelQnt";
            this.labelQnt.Size = new System.Drawing.Size(126, 38);
            this.labelQnt.TabIndex = 7;
            this.labelQnt.Text = "Quantity";
            // 
            // labelBN
            // 
            this.labelBN.AutoSize = true;
            this.labelBN.BackColor = System.Drawing.Color.Ivory;
            this.labelBN.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBN.ForeColor = System.Drawing.Color.DimGray;
            this.labelBN.Location = new System.Drawing.Point(27, 67);
            this.labelBN.Name = "labelBN";
            this.labelBN.Size = new System.Drawing.Size(167, 38);
            this.labelBN.TabIndex = 6;
            this.labelBN.Text = "Book Name";
            // 
            // labelBill
            // 
            this.labelBill.AutoSize = true;
            this.labelBill.BackColor = System.Drawing.Color.Ivory;
            this.labelBill.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBill.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelBill.Location = new System.Drawing.Point(785, 111);
            this.labelBill.Name = "labelBill";
            this.labelBill.Size = new System.Drawing.Size(141, 38);
            this.labelBill.TabIndex = 5;
            this.labelBill.Text = "Books Bill";
            this.labelBill.Click += new System.EventHandler(this.labelBill_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(526, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Ivory;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(510, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book Store";
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelUserInfo.Controls.Add(this.pictureBoxInfo);
            this.panelUserInfo.Controls.Add(this.labelUserInfo);
            this.panelUserInfo.Location = new System.Drawing.Point(15, 240);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(242, 61);
            this.panelUserInfo.TabIndex = 24;
            this.panelUserInfo.Click += new System.EventHandler(this.panelUserInfo_Click);
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo.Image")));
            this.pictureBoxInfo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(79, 58);
            this.pictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInfo.TabIndex = 4;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.Click += new System.EventHandler(this.pictureBoxInfo_Click);
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.AutoSize = true;
            this.labelUserInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUserInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUserInfo.Location = new System.Drawing.Point(102, 9);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(135, 38);
            this.labelUserInfo.TabIndex = 5;
            this.labelUserInfo.Text = "Acc. Info.";
            this.labelUserInfo.Click += new System.EventHandler(this.labelUserInfo_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxSearch.Location = new System.Drawing.Point(589, 388);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(254, 45);
            this.textBoxSearch.TabIndex = 57;
            this.textBoxSearch.Text = "Search Book Name";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxSearch_MouseDown);
            // 
            // CustomerUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1558, 798);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerUserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerUserMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelBill;
        private System.Windows.Forms.Label labelQnt;
        private System.Windows.Forms.Label labelBN;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonAddBill;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelBookList;
        private System.Windows.Forms.DataGridView dataGridViewBookBill;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.DataGridView dataGridViewBookList;
        private System.Windows.Forms.ComboBox comboBoxFilterCtg;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxCN;
        private System.Windows.Forms.TextBox textBoxBN;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBoxUsers;
        private System.Windows.Forms.NumericUpDown numericUpDownQnt;
        private System.Windows.Forms.Button buttonBillHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Amount;
        private System.Windows.Forms.Label labelTextID;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.Label labelUserInfo;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}