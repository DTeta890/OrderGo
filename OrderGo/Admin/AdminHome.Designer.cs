namespace OrderGo.Admin
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rolesButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.foodCategoryButton = new System.Windows.Forms.Button();
            this.foodMenuButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.taxManagementButton = new System.Windows.Forms.Button();
            this.financeButton = new System.Windows.Forms.Button();
            this.billGeneratorButton = new System.Windows.Forms.Button();
            this.rightPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(250, 561);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Size = new System.Drawing.Size(734, 561);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.rolesButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usersButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.foodCategoryButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.foodMenuButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ordersButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.taxManagementButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.financeButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.billGeneratorButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 516);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // rolesButton
            // 
            this.rolesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rolesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rolesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesButton.FlatAppearance.BorderSize = 2;
            this.rolesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rolesButton.Image = ((System.Drawing.Image)(resources.GetObject("rolesButton.Image")));
            this.rolesButton.Location = new System.Drawing.Point(3, 3);
            this.rolesButton.Name = "rolesButton";
            this.rolesButton.Size = new System.Drawing.Size(177, 123);
            this.rolesButton.TabIndex = 0;
            this.rolesButton.Text = "Roles";
            this.rolesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.rolesButton.UseVisualStyleBackColor = true;
            this.rolesButton.Click += new System.EventHandler(this.rolesButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersButton.FlatAppearance.BorderSize = 2;
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Image = ((System.Drawing.Image)(resources.GetObject("usersButton.Image")));
            this.usersButton.Location = new System.Drawing.Point(186, 3);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(177, 123);
            this.usersButton.TabIndex = 1;
            this.usersButton.Text = "Users";
            this.usersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // foodCategoryButton
            // 
            this.foodCategoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodCategoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodCategoryButton.FlatAppearance.BorderSize = 2;
            this.foodCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodCategoryButton.Image = ((System.Drawing.Image)(resources.GetObject("foodCategoryButton.Image")));
            this.foodCategoryButton.Location = new System.Drawing.Point(369, 3);
            this.foodCategoryButton.Name = "foodCategoryButton";
            this.foodCategoryButton.Size = new System.Drawing.Size(177, 123);
            this.foodCategoryButton.TabIndex = 2;
            this.foodCategoryButton.Text = "Food Categories";
            this.foodCategoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.foodCategoryButton.UseVisualStyleBackColor = true;
            this.foodCategoryButton.Click += new System.EventHandler(this.foodCategoryButton_Click);
            // 
            // foodMenuButton
            // 
            this.foodMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodMenuButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodMenuButton.FlatAppearance.BorderSize = 2;
            this.foodMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("foodMenuButton.Image")));
            this.foodMenuButton.Location = new System.Drawing.Point(552, 3);
            this.foodMenuButton.Name = "foodMenuButton";
            this.foodMenuButton.Size = new System.Drawing.Size(179, 123);
            this.foodMenuButton.TabIndex = 3;
            this.foodMenuButton.Text = "Food Menu";
            this.foodMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.foodMenuButton.UseVisualStyleBackColor = true;
            this.foodMenuButton.Click += new System.EventHandler(this.foodMenuButton_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersButton.FlatAppearance.BorderSize = 2;
            this.ordersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersButton.Image = ((System.Drawing.Image)(resources.GetObject("ordersButton.Image")));
            this.ordersButton.Location = new System.Drawing.Point(3, 132);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(177, 123);
            this.ordersButton.TabIndex = 4;
            this.ordersButton.Text = "Orders";
            this.ordersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // taxManagementButton
            // 
            this.taxManagementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taxManagementButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taxManagementButton.FlatAppearance.BorderSize = 2;
            this.taxManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taxManagementButton.Image = ((System.Drawing.Image)(resources.GetObject("taxManagementButton.Image")));
            this.taxManagementButton.Location = new System.Drawing.Point(369, 132);
            this.taxManagementButton.Name = "taxManagementButton";
            this.taxManagementButton.Size = new System.Drawing.Size(177, 123);
            this.taxManagementButton.TabIndex = 6;
            this.taxManagementButton.Text = "Tax Management";
            this.taxManagementButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.taxManagementButton.UseVisualStyleBackColor = true;
            this.taxManagementButton.Click += new System.EventHandler(this.taxManagementButton_Click);
            // 
            // financeButton
            // 
            this.financeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.financeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financeButton.FlatAppearance.BorderSize = 2;
            this.financeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financeButton.Image = ((System.Drawing.Image)(resources.GetObject("financeButton.Image")));
            this.financeButton.Location = new System.Drawing.Point(552, 132);
            this.financeButton.Name = "financeButton";
            this.financeButton.Size = new System.Drawing.Size(179, 123);
            this.financeButton.TabIndex = 7;
            this.financeButton.Text = "Finance";
            this.financeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.financeButton.UseVisualStyleBackColor = true;
            this.financeButton.Click += new System.EventHandler(this.financeButton_Click);
            // 
            // billGeneratorButton
            // 
            this.billGeneratorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billGeneratorButton.FlatAppearance.BorderSize = 2;
            this.billGeneratorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billGeneratorButton.Image = ((System.Drawing.Image)(resources.GetObject("billGeneratorButton.Image")));
            this.billGeneratorButton.Location = new System.Drawing.Point(186, 132);
            this.billGeneratorButton.Name = "billGeneratorButton";
            this.billGeneratorButton.Size = new System.Drawing.Size(177, 123);
            this.billGeneratorButton.TabIndex = 9;
            this.billGeneratorButton.Text = "Bill Generator";
            this.billGeneratorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.billGeneratorButton.UseVisualStyleBackColor = true;
            this.billGeneratorButton.Click += new System.EventHandler(this.billGeneratorButton_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Name = "AdminHome";
            this.Text = "Admin Home";
            this.rightPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button rolesButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button foodCategoryButton;
        private System.Windows.Forms.Button foodMenuButton;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button financeButton;
        private System.Windows.Forms.Button taxManagementButton;
        private System.Windows.Forms.Button billGeneratorButton;
    }
}