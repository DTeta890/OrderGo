namespace OrderGo.Admin
{
    partial class FoodMenuWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceErrorLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuItemTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuItemErrorLabel = new System.Windows.Forms.Label();
            this.categoryErrorLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuDataGridView = new System.Windows.Forms.DataGridView();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.photoErrorLabel = new System.Windows.Forms.Label();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuItemGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Enabled = false;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.photoTextBox);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.photoErrorLabel);
            this.leftPanel.Controls.Add(this.priceTextBox);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.priceErrorLabel);
            this.leftPanel.Controls.Add(this.categoryComboBox);
            this.leftPanel.Controls.Add(this.label9);
            this.leftPanel.Controls.Add(this.menuItemTextBox);
            this.leftPanel.Controls.Add(this.label8);
            this.leftPanel.Controls.Add(this.menuItemErrorLabel);
            this.leftPanel.Controls.Add(this.categoryErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(250, 561);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.menuItemErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label8, 0);
            this.leftPanel.Controls.SetChildIndex(this.menuItemTextBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.label9, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryComboBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceTextBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.photoErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.photoTextBox, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.groupBox2);
            this.rightPanel.Size = new System.Drawing.Size(734, 561);
            this.rightPanel.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(35, 236);
            this.priceTextBox.MaxLength = 10;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(179, 25);
            this.priceTextBox.TabIndex = 2;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Price";
            // 
            // priceErrorLabel
            // 
            this.priceErrorLabel.AutoSize = true;
            this.priceErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceErrorLabel.Location = new System.Drawing.Point(194, 214);
            this.priceErrorLabel.Name = "priceErrorLabel";
            this.priceErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.priceErrorLabel.TabIndex = 41;
            this.priceErrorLabel.Text = "*";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Enabled = false;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(35, 178);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(179, 25);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "Category";
            // 
            // menuItemTextBox
            // 
            this.menuItemTextBox.Enabled = false;
            this.menuItemTextBox.Location = new System.Drawing.Point(35, 123);
            this.menuItemTextBox.MaxLength = 100;
            this.menuItemTextBox.Name = "menuItemTextBox";
            this.menuItemTextBox.Size = new System.Drawing.Size(179, 25);
            this.menuItemTextBox.TabIndex = 0;
            this.menuItemTextBox.TextChanged += new System.EventHandler(this.menuItemTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "Menu Item";
            // 
            // menuItemErrorLabel
            // 
            this.menuItemErrorLabel.AutoSize = true;
            this.menuItemErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemErrorLabel.Location = new System.Drawing.Point(194, 101);
            this.menuItemErrorLabel.Name = "menuItemErrorLabel";
            this.menuItemErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.menuItemErrorLabel.TabIndex = 35;
            this.menuItemErrorLabel.Text = "*";
            // 
            // categoryErrorLabel
            // 
            this.categoryErrorLabel.AutoSize = true;
            this.categoryErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryErrorLabel.Location = new System.Drawing.Point(194, 156);
            this.categoryErrorLabel.Name = "categoryErrorLabel";
            this.categoryErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.categoryErrorLabel.TabIndex = 38;
            this.categoryErrorLabel.Text = "*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.menuDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(0, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 459);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // menuDataGridView
            // 
            this.menuDataGridView.AllowUserToAddRows = false;
            this.menuDataGridView.AllowUserToDeleteRows = false;
            this.menuDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.menuIDGV,
            this.menuItemGV,
            this.priceGV,
            this.photoGV,
            this.categoryGV,
            this.catIDGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menuDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.menuDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuDataGridView.Location = new System.Drawing.Point(3, 19);
            this.menuDataGridView.Name = "menuDataGridView";
            this.menuDataGridView.ReadOnly = true;
            this.menuDataGridView.RowHeadersVisible = false;
            this.menuDataGridView.Size = new System.Drawing.Size(728, 437);
            this.menuDataGridView.TabIndex = 0;
            this.menuDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuDataGridView_CellClick);
            // 
            // photoTextBox
            // 
            this.photoTextBox.Enabled = false;
            this.photoTextBox.Location = new System.Drawing.Point(35, 294);
            this.photoTextBox.MaxLength = 254;
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(179, 25);
            this.photoTextBox.TabIndex = 42;
            this.photoTextBox.TextChanged += new System.EventHandler(this.photoTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Photo URL";
            // 
            // photoErrorLabel
            // 
            this.photoErrorLabel.AutoSize = true;
            this.photoErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoErrorLabel.Location = new System.Drawing.Point(194, 272);
            this.photoErrorLabel.Name = "photoErrorLabel";
            this.photoErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.photoErrorLabel.TabIndex = 44;
            this.photoErrorLabel.Text = "*";
            // 
            // snoGV
            // 
            this.snoGV.FillWeight = 30F;
            this.snoGV.HeaderText = "";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 30;
            // 
            // menuIDGV
            // 
            this.menuIDGV.HeaderText = "Menu ID";
            this.menuIDGV.Name = "menuIDGV";
            this.menuIDGV.ReadOnly = true;
            this.menuIDGV.Visible = false;
            // 
            // menuItemGV
            // 
            this.menuItemGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menuItemGV.HeaderText = "Menu Item";
            this.menuItemGV.Name = "menuItemGV";
            this.menuItemGV.ReadOnly = true;
            // 
            // priceGV
            // 
            this.priceGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceGV.HeaderText = "Price";
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // photoGV
            // 
            this.photoGV.HeaderText = "Photo";
            this.photoGV.Name = "photoGV";
            this.photoGV.ReadOnly = true;
            this.photoGV.Visible = false;
            // 
            // categoryGV
            // 
            this.categoryGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryGV.HeaderText = "Category";
            this.categoryGV.Name = "categoryGV";
            this.categoryGV.ReadOnly = true;
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "CatID";
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // FoodMenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Name = "FoodMenuWindow";
            this.Text = "Food Menu";
            this.Load += new System.EventHandler(this.FoodMenuWindow_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label priceErrorLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox menuItemTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label menuItemErrorLabel;
        private System.Windows.Forms.Label categoryErrorLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView menuDataGridView;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label photoErrorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuItemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
    }
}