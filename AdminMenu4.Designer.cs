namespace Bookshop
{
    partial class AdminMenu4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.pictureBoxDashboard = new System.Windows.Forms.PictureBox();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.labelLogout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridViewBillHistory = new System.Windows.Forms.DataGridView();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownCID = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownTotalAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownBill_ID = new System.Windows.Forms.NumericUpDown();
            this.textBoxCN = new System.Windows.Forms.TextBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelQnt = new System.Windows.Forms.Label();
            this.labelBN = new System.Windows.Forms.Label();
            this.numericUpDownQnt = new System.Windows.Forms.NumericUpDown();
            this.textBoxBN = new System.Windows.Forms.TextBox();
            this.labelBookList = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboard)).BeginInit();
            this.panelLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBill_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQnt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panelDashboard);
            this.panel1.Controls.Add(this.panelLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 740);
            this.panel1.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(60, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 38);
            this.label7.TabIndex = 25;
            this.label7.Text = "History View";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(40, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 38);
            this.label6.TabIndex = 6;
            this.label6.Text = "Welcome to Bill";
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.Transparent;
            this.panelDashboard.Controls.Add(this.pictureBoxDashboard);
            this.panelDashboard.Controls.Add(this.labelDashboard);
            this.panelDashboard.Location = new System.Drawing.Point(17, 380);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(242, 61);
            this.panelDashboard.TabIndex = 24;
            this.panelDashboard.Click += new System.EventHandler(this.panelDashboard_Click);
            // 
            // pictureBoxDashboard
            // 
            this.pictureBoxDashboard.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboard.Image")));
            this.pictureBoxDashboard.Location = new System.Drawing.Point(6, 3);
            this.pictureBoxDashboard.Name = "pictureBoxDashboard";
            this.pictureBoxDashboard.Size = new System.Drawing.Size(76, 58);
            this.pictureBoxDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDashboard.TabIndex = 4;
            this.pictureBoxDashboard.TabStop = false;
            this.pictureBoxDashboard.Click += new System.EventHandler(this.pictureBoxDashboard_Click);
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.BackColor = System.Drawing.Color.Transparent;
            this.labelDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDashboard.Location = new System.Drawing.Point(83, 12);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(156, 38);
            this.labelDashboard.TabIndex = 5;
            this.labelDashboard.Text = "Dashboard";
            this.labelDashboard.Click += new System.EventHandler(this.labelDashboard_Click);
            // 
            // panelLogout
            // 
            this.panelLogout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLogout.Controls.Add(this.pictureBoxLogout);
            this.panelLogout.Controls.Add(this.labelLogout);
            this.panelLogout.Location = new System.Drawing.Point(14, 506);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(242, 56);
            this.panelLogout.TabIndex = 24;
            this.panelLogout.Click += new System.EventHandler(this.panelLogout_Click);
            // 
            // pictureBoxLogout
            // 
            this.pictureBoxLogout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogout.Image")));
            this.pictureBoxLogout.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogout.Name = "pictureBoxLogout";
            this.pictureBoxLogout.Size = new System.Drawing.Size(73, 58);
            this.pictureBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogout.TabIndex = 3;
            this.pictureBoxLogout.TabStop = false;
            this.pictureBoxLogout.Click += new System.EventHandler(this.pictureBoxLogout_Click);
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.BackColor = System.Drawing.Color.Black;
            this.labelLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLogout.Location = new System.Drawing.Point(100, 7);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(108, 38);
            this.labelLogout.TabIndex = 2;
            this.labelLogout.Text = "Logout";
            this.labelLogout.Click += new System.EventHandler(this.labelLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(85, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Store";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Ivory;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(564, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book Store";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(600, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridViewBillHistory
            // 
            this.dataGridViewBillHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBillHistory.Location = new System.Drawing.Point(53, 446);
            this.dataGridViewBillHistory.Name = "dataGridViewBillHistory";
            this.dataGridViewBillHistory.RowHeadersWidth = 62;
            this.dataGridViewBillHistory.RowTemplate.Height = 28;
            this.dataGridViewBillHistory.Size = new System.Drawing.Size(1129, 281);
            this.dataGridViewBillHistory.TabIndex = 18;
            this.dataGridViewBillHistory.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBillHistory_RowHeaderMouseClick);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1180, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(33, 38);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 41;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.labelBookList);
            this.panel2.Controls.Add(this.buttonReset);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.numericUpDownCID);
            this.panel2.Controls.Add(this.numericUpDownPrice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.numericUpDownTotalAmount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numericUpDownBill_ID);
            this.panel2.Controls.Add(this.textBoxCN);
            this.panel2.Controls.Add(this.labelClientName);
            this.panel2.Controls.Add(this.labelPrice);
            this.panel2.Controls.Add(this.labelQnt);
            this.panel2.Controls.Add(this.labelBN);
            this.panel2.Controls.Add(this.numericUpDownQnt);
            this.panel2.Controls.Add(this.textBoxBN);
            this.panel2.Controls.Add(this.pictureBoxClose);
            this.panel2.Controls.Add(this.dataGridViewBillHistory);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(304, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1216, 740);
            this.panel2.TabIndex = 3;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.Ivory;
            this.buttonReset.Location = new System.Drawing.Point(640, 275);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(130, 49);
            this.buttonReset.TabIndex = 60;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Ivory;
            this.buttonDelete.Location = new System.Drawing.Point(472, 275);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(130, 49);
            this.buttonDelete.TabIndex = 59;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Ivory;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(987, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 38);
            this.label5.TabIndex = 56;
            this.label5.Text = "Customer ID";
            // 
            // numericUpDownCID
            // 
            this.numericUpDownCID.Enabled = false;
            this.numericUpDownCID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCID.Location = new System.Drawing.Point(994, 208);
            this.numericUpDownCID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCID.Name = "numericUpDownCID";
            this.numericUpDownCID.Size = new System.Drawing.Size(150, 39);
            this.numericUpDownCID.TabIndex = 55;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Enabled = false;
            this.numericUpDownPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPrice.Location = new System.Drawing.Point(589, 208);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(132, 39);
            this.numericUpDownPrice.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Ivory;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(753, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 38);
            this.label4.TabIndex = 53;
            this.label4.Text = "Total Amount";
            // 
            // numericUpDownTotalAmount
            // 
            this.numericUpDownTotalAmount.Enabled = false;
            this.numericUpDownTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTotalAmount.Location = new System.Drawing.Point(760, 208);
            this.numericUpDownTotalAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownTotalAmount.Name = "numericUpDownTotalAmount";
            this.numericUpDownTotalAmount.Size = new System.Drawing.Size(182, 39);
            this.numericUpDownTotalAmount.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Ivory;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(46, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 38);
            this.label2.TabIndex = 51;
            this.label2.Text = "Bill ID";
            // 
            // numericUpDownBill_ID
            // 
            this.numericUpDownBill_ID.Enabled = false;
            this.numericUpDownBill_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownBill_ID.Location = new System.Drawing.Point(53, 208);
            this.numericUpDownBill_ID.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownBill_ID.Name = "numericUpDownBill_ID";
            this.numericUpDownBill_ID.Size = new System.Drawing.Size(145, 39);
            this.numericUpDownBill_ID.TabIndex = 50;
            // 
            // textBoxCN
            // 
            this.textBoxCN.Enabled = false;
            this.textBoxCN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCN.Location = new System.Drawing.Point(255, 210);
            this.textBoxCN.Name = "textBoxCN";
            this.textBoxCN.Size = new System.Drawing.Size(287, 39);
            this.textBoxCN.TabIndex = 49;
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.BackColor = System.Drawing.Color.Ivory;
            this.labelClientName.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientName.ForeColor = System.Drawing.Color.DimGray;
            this.labelClientName.Location = new System.Drawing.Point(248, 167);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(173, 38);
            this.labelClientName.TabIndex = 48;
            this.labelClientName.Text = "Client Name";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Ivory;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.DimGray;
            this.labelPrice.Location = new System.Drawing.Point(582, 167);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(78, 38);
            this.labelPrice.TabIndex = 47;
            this.labelPrice.Text = "Price";
            // 
            // labelQnt
            // 
            this.labelQnt.AutoSize = true;
            this.labelQnt.BackColor = System.Drawing.Color.Ivory;
            this.labelQnt.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQnt.ForeColor = System.Drawing.Color.DimGray;
            this.labelQnt.Location = new System.Drawing.Point(440, 78);
            this.labelQnt.Name = "labelQnt";
            this.labelQnt.Size = new System.Drawing.Size(126, 38);
            this.labelQnt.TabIndex = 45;
            this.labelQnt.Text = "Quantity";
            // 
            // labelBN
            // 
            this.labelBN.AutoSize = true;
            this.labelBN.BackColor = System.Drawing.Color.Ivory;
            this.labelBN.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBN.ForeColor = System.Drawing.Color.DimGray;
            this.labelBN.Location = new System.Drawing.Point(46, 77);
            this.labelBN.Name = "labelBN";
            this.labelBN.Size = new System.Drawing.Size(167, 38);
            this.labelBN.TabIndex = 44;
            this.labelBN.Text = "Book Name";
            // 
            // numericUpDownQnt
            // 
            this.numericUpDownQnt.Enabled = false;
            this.numericUpDownQnt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQnt.Location = new System.Drawing.Point(447, 119);
            this.numericUpDownQnt.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numericUpDownQnt.Name = "numericUpDownQnt";
            this.numericUpDownQnt.Size = new System.Drawing.Size(84, 39);
            this.numericUpDownQnt.TabIndex = 43;
            // 
            // textBoxBN
            // 
            this.textBoxBN.Enabled = false;
            this.textBoxBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBN.Location = new System.Drawing.Point(53, 118);
            this.textBoxBN.Name = "textBoxBN";
            this.textBoxBN.Size = new System.Drawing.Size(350, 39);
            this.textBoxBN.TabIndex = 42;
            // 
            // labelBookList
            // 
            this.labelBookList.AutoSize = true;
            this.labelBookList.BackColor = System.Drawing.Color.Ivory;
            this.labelBookList.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookList.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelBookList.Location = new System.Drawing.Point(523, 395);
            this.labelBookList.Name = "labelBookList";
            this.labelBookList.Size = new System.Drawing.Size(216, 38);
            this.labelBookList.TabIndex = 61;
            this.labelBookList.Text = "Bill History List";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Ivory;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(820, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 38);
            this.label8.TabIndex = 67;
            this.label8.Text = "Client Name";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(827, 397);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(203, 39);
            this.textBoxSearch.TabIndex = 68;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(1052, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 49);
            this.button1.TabIndex = 69;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminMenu4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1559, 775);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboard)).EndInit();
            this.panelLogout.ResumeLayout(false);
            this.panelLogout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBill_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQnt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.PictureBox pictureBoxLogout;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridViewBillHistory;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.PictureBox pictureBoxDashboard;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.TextBox textBoxBN;
        private System.Windows.Forms.NumericUpDown numericUpDownQnt;
        private System.Windows.Forms.Label labelBN;
        private System.Windows.Forms.Label labelQnt;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.TextBox textBoxCN;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownBill_ID;
        private System.Windows.Forms.NumericUpDown numericUpDownCID;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelBookList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button1;
    }
}