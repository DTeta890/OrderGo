namespace OrderGo.Login
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.saveButton = new System.Windows.Forms.Button();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dbTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.serverErrorLabel = new System.Windows.Forms.Label();
            this.dbErrorLabel = new System.Windows.Forms.Label();
            this.userIdErrorLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.testButton);
            this.leftPanel.Controls.Add(this.dbTextBox);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.serverTextBox);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.saveButton);
            this.leftPanel.Controls.Add(this.passTextBox);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.userIdTextBox);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.serverErrorLabel);
            this.leftPanel.Controls.Add(this.dbErrorLabel);
            this.leftPanel.Controls.Add(this.userIdErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(250, 561);
            this.leftPanel.Controls.SetChildIndex(this.userIdErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.dbErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.userIdTextBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.passTextBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.saveButton, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverTextBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.dbTextBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.testButton, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.pictureBox1);
            this.rightPanel.Size = new System.Drawing.Size(734, 561);
            this.rightPanel.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Enabled = false;
            this.saveButton.FlatAppearance.BorderSize = 2;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(49, 399);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(148, 33);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(49, 323);
            this.passTextBox.MaxLength = 50;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(148, 25);
            this.passTextBox.TabIndex = 3;
            this.passTextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(49, 273);
            this.userIdTextBox.MaxLength = 50;
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(148, 25);
            this.userIdTextBox.TabIndex = 2;
            this.userIdTextBox.TextChanged += new System.EventHandler(this.userIdTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "User ID";
            // 
            // dbTextBox
            // 
            this.dbTextBox.Location = new System.Drawing.Point(49, 223);
            this.dbTextBox.MaxLength = 50;
            this.dbTextBox.Name = "dbTextBox";
            this.dbTextBox.Size = new System.Drawing.Size(148, 25);
            this.dbTextBox.TabIndex = 1;
            this.dbTextBox.TextChanged += new System.EventHandler(this.dbTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Database";
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(49, 173);
            this.serverTextBox.MaxLength = 50;
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(148, 25);
            this.serverTextBox.TabIndex = 0;
            this.serverTextBox.TextChanged += new System.EventHandler(this.serverTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Server";
            // 
            // serverErrorLabel
            // 
            this.serverErrorLabel.AutoSize = true;
            this.serverErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverErrorLabel.Location = new System.Drawing.Point(177, 151);
            this.serverErrorLabel.Name = "serverErrorLabel";
            this.serverErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.serverErrorLabel.TabIndex = 13;
            this.serverErrorLabel.Text = "*";
            // 
            // dbErrorLabel
            // 
            this.dbErrorLabel.AutoSize = true;
            this.dbErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbErrorLabel.Location = new System.Drawing.Point(177, 201);
            this.dbErrorLabel.Name = "dbErrorLabel";
            this.dbErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.dbErrorLabel.TabIndex = 14;
            this.dbErrorLabel.Text = "*";
            // 
            // userIdErrorLabel
            // 
            this.userIdErrorLabel.AutoSize = true;
            this.userIdErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdErrorLabel.Location = new System.Drawing.Point(177, 251);
            this.userIdErrorLabel.Name = "userIdErrorLabel";
            this.userIdErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.userIdErrorLabel.TabIndex = 15;
            this.userIdErrorLabel.Text = "*";
            // 
            // testButton
            // 
            this.testButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testButton.FlatAppearance.BorderSize = 2;
            this.testButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testButton.Location = new System.Drawing.Point(49, 360);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(148, 33);
            this.testButton.TabIndex = 4;
            this.testButton.Text = "TEST CONNECTION";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Name = "Settings";
            this.Text = "Settings";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox dbTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label serverErrorLabel;
        private System.Windows.Forms.Label dbErrorLabel;
        private System.Windows.Forms.Label userIdErrorLabel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}