namespace OrderGo.Admin
{
    partial class BillGeneratorWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillGeneratorWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backButton = new System.Windows.Forms.Button();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTypeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.snoGV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.loadOrdersButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.generateBillButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.totalBillLabel = new System.Windows.Forms.Label();
            this.amtPaidTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amtPaidErrorLabel = new System.Windows.Forms.Label();
            this.amtReturnedTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.getButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.billCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.taxTextBox);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.getButton);
            this.leftPanel.Controls.Add(this.addressTextBox);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.phoneTextBox);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.amtReturnedTextBox);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.amtPaidTextBox);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.amtPaidErrorLabel);
            this.leftPanel.Controls.Add(this.totalBillLabel);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.panel4);
            this.leftPanel.Controls.Add(this.panel3);
            this.leftPanel.Controls.Add(this.orderDetailsDataGridView);
            this.leftPanel.Controls.Add(this.ordersDataGridView);
            this.leftPanel.Size = new System.Drawing.Size(400, 561);
            this.leftPanel.Controls.SetChildIndex(this.ordersDataGridView, 0);
            this.leftPanel.Controls.SetChildIndex(this.orderDetailsDataGridView, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.totalBillLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.amtPaidErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.amtPaidTextBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.amtReturnedTextBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneTextBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressTextBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.getButton, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.taxTextBox, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.billCrystalReportViewer);
            this.rightPanel.Location = new System.Drawing.Point(400, 0);
            this.rightPanel.Size = new System.Drawing.Size(584, 561);
            this.rightPanel.Controls.SetChildIndex(this.billCrystalReportViewer, 0);
            // 
            // panelBack
            // 
            this.panelBack.Controls.Add(this.backButton);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(45, 45);
            this.backButton.TabIndex = 1;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.orderIDGV,
            this.statusGV,
            this.totalAmountGV,
            this.orderTypeGV,
            this.phoneGV,
            this.addressGV,
            this.taxGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.ordersDataGridView.Location = new System.Drawing.Point(3, 101);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.RowHeadersVisible = false;
            this.ordersDataGridView.Size = new System.Drawing.Size(135, 175);
            this.ordersDataGridView.TabIndex = 1;
            this.ordersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDataGridView_CellClick);
            // 
            // snoGV
            // 
            this.snoGV.FillWeight = 30F;
            this.snoGV.HeaderText = "";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 30;
            // 
            // orderIDGV
            // 
            this.orderIDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderIDGV.HeaderText = "Order ID";
            this.orderIDGV.Name = "orderIDGV";
            this.orderIDGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            this.statusGV.Visible = false;
            // 
            // totalAmountGV
            // 
            this.totalAmountGV.HeaderText = "Total";
            this.totalAmountGV.Name = "totalAmountGV";
            this.totalAmountGV.ReadOnly = true;
            this.totalAmountGV.Visible = false;
            // 
            // orderTypeGV
            // 
            this.orderTypeGV.HeaderText = "Order Type";
            this.orderTypeGV.Name = "orderTypeGV";
            this.orderTypeGV.ReadOnly = true;
            this.orderTypeGV.Visible = false;
            // 
            // phoneGV
            // 
            this.phoneGV.HeaderText = "Phone";
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
            this.phoneGV.Visible = false;
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "Address";
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            this.addressGV.Visible = false;
            // 
            // taxGV
            // 
            this.taxGV.HeaderText = "Tax";
            this.taxGV.Name = "taxGV";
            this.taxGV.ReadOnly = true;
            this.taxGV.Visible = false;
            // 
            // orderDetailsDataGridView
            // 
            this.orderDetailsDataGridView.AllowUserToAddRows = false;
            this.orderDetailsDataGridView.AllowUserToDeleteRows = false;
            this.orderDetailsDataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDetailsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orderDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV1,
            this.itemNameGV,
            this.quantityGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderDetailsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderDetailsDataGridView.Location = new System.Drawing.Point(144, 101);
            this.orderDetailsDataGridView.Name = "orderDetailsDataGridView";
            this.orderDetailsDataGridView.ReadOnly = true;
            this.orderDetailsDataGridView.RowHeadersVisible = false;
            this.orderDetailsDataGridView.Size = new System.Drawing.Size(250, 175);
            this.orderDetailsDataGridView.TabIndex = 2;
            this.orderDetailsDataGridView.AutoGenerateColumns = false;
            // 
            // snoGV1
            // 
            this.snoGV1.FillWeight = 30F;
            this.snoGV1.HeaderText = "";
            this.snoGV1.Name = "snoGV1";
            this.snoGV1.ReadOnly = true;
            this.snoGV1.Width = 30;
            // 
            // itemNameGV
            // 
            this.itemNameGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemNameGV.HeaderText = "Item";
            this.itemNameGV.Name = "itemNameGV";
            this.itemNameGV.ReadOnly = true;
            // 
            // quantityGV
            // 
            this.quantityGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityGV.HeaderText = "Quantity";
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.loadOrdersButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 50);
            this.panel3.TabIndex = 3;
            // 
            // loadOrdersButton
            // 
            this.loadOrdersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadOrdersButton.FlatAppearance.BorderSize = 2;
            this.loadOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadOrdersButton.Location = new System.Drawing.Point(0, 0);
            this.loadOrdersButton.Name = "loadOrdersButton";
            this.loadOrdersButton.Size = new System.Drawing.Size(400, 50);
            this.loadOrdersButton.TabIndex = 2;
            this.loadOrdersButton.Text = "LOAD ORDERS";
            this.loadOrdersButton.UseVisualStyleBackColor = true;
            this.loadOrdersButton.Click += new System.EventHandler(this.loadOrdersButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.generateBillButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 511);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 50);
            this.panel4.TabIndex = 4;
            // 
            // generateBillButton
            // 
            this.generateBillButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateBillButton.FlatAppearance.BorderSize = 2;
            this.generateBillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBillButton.Location = new System.Drawing.Point(0, 0);
            this.generateBillButton.Name = "generateBillButton";
            this.generateBillButton.Size = new System.Drawing.Size(400, 50);
            this.generateBillButton.TabIndex = 2;
            this.generateBillButton.Text = "GENERATE BILL";
            this.generateBillButton.UseVisualStyleBackColor = true;
            this.generateBillButton.Click += new System.EventHandler(this.generateBillButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Bill:";
            // 
            // totalBillLabel
            // 
            this.totalBillLabel.AutoSize = true;
            this.totalBillLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBillLabel.Location = new System.Drawing.Point(134, 279);
            this.totalBillLabel.Name = "totalBillLabel";
            this.totalBillLabel.Size = new System.Drawing.Size(56, 37);
            this.totalBillLabel.TabIndex = 6;
            this.totalBillLabel.Text = "0.0";
            // 
            // amtPaidTextBox
            // 
            this.amtPaidTextBox.Enabled = false;
            this.amtPaidTextBox.Location = new System.Drawing.Point(12, 350);
            this.amtPaidTextBox.MaxLength = 30;
            this.amtPaidTextBox.Name = "amtPaidTextBox";
            this.amtPaidTextBox.Size = new System.Drawing.Size(179, 25);
            this.amtPaidTextBox.TabIndex = 18;
            this.amtPaidTextBox.Text = "0.0";
            this.amtPaidTextBox.TextChanged += new System.EventHandler(this.amtPaidTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Amount Paid";
            // 
            // amtPaidErrorLabel
            // 
            this.amtPaidErrorLabel.AutoSize = true;
            this.amtPaidErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtPaidErrorLabel.Location = new System.Drawing.Point(171, 328);
            this.amtPaidErrorLabel.Name = "amtPaidErrorLabel";
            this.amtPaidErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.amtPaidErrorLabel.TabIndex = 20;
            this.amtPaidErrorLabel.Text = "*";
            // 
            // amtReturnedTextBox
            // 
            this.amtReturnedTextBox.Enabled = false;
            this.amtReturnedTextBox.Location = new System.Drawing.Point(12, 400);
            this.amtReturnedTextBox.MaxLength = 30;
            this.amtReturnedTextBox.Name = "amtReturnedTextBox";
            this.amtReturnedTextBox.Size = new System.Drawing.Size(179, 25);
            this.amtReturnedTextBox.TabIndex = 21;
            this.amtReturnedTextBox.Text = "0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Amount Returned";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Enabled = false;
            this.addressTextBox.Location = new System.Drawing.Point(215, 400);
            this.addressTextBox.MaxLength = 30;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(179, 25);
            this.addressTextBox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Address";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Enabled = false;
            this.phoneTextBox.Location = new System.Drawing.Point(215, 350);
            this.phoneTextBox.MaxLength = 30;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(179, 25);
            this.phoneTextBox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Phone";
            // 
            // getButton
            // 
            this.getButton.Enabled = false;
            this.getButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getButton.Location = new System.Drawing.Point(12, 431);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(75, 32);
            this.getButton.TabIndex = 28;
            this.getButton.Text = "GET";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tax";
            // 
            // taxTextBox
            // 
            this.taxTextBox.Enabled = false;
            this.taxTextBox.Location = new System.Drawing.Point(215, 450);
            this.taxTextBox.MaxLength = 30;
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(179, 25);
            this.taxTextBox.TabIndex = 31;
            // 
            // billCrystalReportViewer
            // 
            this.billCrystalReportViewer.ActiveViewIndex = -1;
            this.billCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.billCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.billCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billCrystalReportViewer.Location = new System.Drawing.Point(0, 45);
            this.billCrystalReportViewer.Name = "billCrystalReportViewer";
            this.billCrystalReportViewer.ShowCloseButton = false;
            this.billCrystalReportViewer.ShowCopyButton = false;
            this.billCrystalReportViewer.ShowGotoPageButton = false;
            this.billCrystalReportViewer.ShowGroupTreeButton = false;
            this.billCrystalReportViewer.ShowLogo = false;
            this.billCrystalReportViewer.ShowParameterPanelButton = false;
            this.billCrystalReportViewer.ShowRefreshButton = false;
            this.billCrystalReportViewer.ShowTextSearchButton = false;
            this.billCrystalReportViewer.Size = new System.Drawing.Size(584, 516);
            this.billCrystalReportViewer.TabIndex = 1;
            this.billCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // BillGeneratorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Name = "BillGeneratorWindow";
            this.Text = "BillGeneratorWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BillGeneratorWindow_FormClosing);
            this.Load += new System.EventHandler(this.BillGeneratorWindow_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridView orderDetailsDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button loadOrdersButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button generateBillButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalBillLabel;
        private System.Windows.Forms.TextBox amtReturnedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amtPaidTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label amtPaidErrorLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTypeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxGV;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer billCrystalReportViewer;
    }
}