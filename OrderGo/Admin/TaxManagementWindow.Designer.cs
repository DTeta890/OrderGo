namespace OrderGo.Admin
{
    partial class TaxManagementWindow
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
            this.taxNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.taxNameErrorLabel = new System.Windows.Forms.Label();
            this.taxAmountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.taxAmountErrorLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.taxesDataGridView = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Enabled = false;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.taxAmountTextBox);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.taxAmountErrorLabel);
            this.leftPanel.Controls.Add(this.taxNameTextBox);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.taxNameErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(250, 561);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.taxNameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.taxNameTextBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.taxAmountErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.taxAmountTextBox, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.groupBox2);
            this.rightPanel.Size = new System.Drawing.Size(734, 561);
            this.rightPanel.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // taxNameTextBox
            // 
            this.taxNameTextBox.Enabled = false;
            this.taxNameTextBox.Location = new System.Drawing.Point(36, 125);
            this.taxNameTextBox.MaxLength = 30;
            this.taxNameTextBox.Name = "taxNameTextBox";
            this.taxNameTextBox.Size = new System.Drawing.Size(179, 25);
            this.taxNameTextBox.TabIndex = 18;
            this.taxNameTextBox.TextChanged += new System.EventHandler(this.taxNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tax Name";
            // 
            // taxNameErrorLabel
            // 
            this.taxNameErrorLabel.AutoSize = true;
            this.taxNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxNameErrorLabel.Location = new System.Drawing.Point(195, 103);
            this.taxNameErrorLabel.Name = "taxNameErrorLabel";
            this.taxNameErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.taxNameErrorLabel.TabIndex = 20;
            this.taxNameErrorLabel.Text = "*";
            // 
            // taxAmountTextBox
            // 
            this.taxAmountTextBox.Enabled = false;
            this.taxAmountTextBox.Location = new System.Drawing.Point(36, 175);
            this.taxAmountTextBox.MaxLength = 10;
            this.taxAmountTextBox.Name = "taxAmountTextBox";
            this.taxAmountTextBox.Size = new System.Drawing.Size(179, 25);
            this.taxAmountTextBox.TabIndex = 21;
            this.taxAmountTextBox.TextChanged += new System.EventHandler(this.taxAmountTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tax Amount";
            // 
            // taxAmountErrorLabel
            // 
            this.taxAmountErrorLabel.AutoSize = true;
            this.taxAmountErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxAmountErrorLabel.Location = new System.Drawing.Point(195, 153);
            this.taxAmountErrorLabel.Name = "taxAmountErrorLabel";
            this.taxAmountErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.taxAmountErrorLabel.TabIndex = 23;
            this.taxAmountErrorLabel.Text = "*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.taxesDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(0, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 459);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // taxesDataGridView
            // 
            this.taxesDataGridView.AllowUserToAddRows = false;
            this.taxesDataGridView.AllowUserToDeleteRows = false;
            this.taxesDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taxesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.taxesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taxesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.taxIDGV,
            this.taxNameGV,
            this.taxAmountGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.taxesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.taxesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taxesDataGridView.Location = new System.Drawing.Point(3, 19);
            this.taxesDataGridView.Name = "taxesDataGridView";
            this.taxesDataGridView.ReadOnly = true;
            this.taxesDataGridView.RowHeadersVisible = false;
            this.taxesDataGridView.Size = new System.Drawing.Size(728, 437);
            this.taxesDataGridView.TabIndex = 0;
            this.taxesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taxesDataGridView_CellClick);
            // 
            // snoGV
            // 
            this.snoGV.FillWeight = 30F;
            this.snoGV.HeaderText = "";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 30;
            // 
            // taxIDGV
            // 
            this.taxIDGV.HeaderText = "Tax ID";
            this.taxIDGV.Name = "taxIDGV";
            this.taxIDGV.ReadOnly = true;
            this.taxIDGV.Visible = false;
            // 
            // taxNameGV
            // 
            this.taxNameGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taxNameGV.HeaderText = "Name";
            this.taxNameGV.Name = "taxNameGV";
            this.taxNameGV.ReadOnly = true;
            // 
            // taxAmountGV
            // 
            this.taxAmountGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taxAmountGV.HeaderText = "Amount";
            this.taxAmountGV.Name = "taxAmountGV";
            this.taxAmountGV.ReadOnly = true;
            // 
            // TaxManagementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Name = "TaxManagementWindow";
            this.Text = "Tax Management";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taxesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox taxAmountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label taxAmountErrorLabel;
        private System.Windows.Forms.TextBox taxNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label taxNameErrorLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView taxesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxAmountGV;
    }
}