
namespace BookStore
{
    partial class ModifyUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyUserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.usernameModifyTextBox = new System.Windows.Forms.TextBox();
            this.passwordModifyTextBox = new System.Windows.Forms.TextBox();
            this.employeeTextBox = new System.Windows.Forms.TextBox();
            this.employeeInModifyLabel = new System.Windows.Forms.Label();
            this.passwordModifyLabel = new System.Windows.Forms.Label();
            this.usernameModifyLabel = new System.Windows.Forms.Label();
            this.modifyUserLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.usernameModifyTextBox);
            this.panel1.Controls.Add(this.passwordModifyTextBox);
            this.panel1.Controls.Add(this.employeeTextBox);
            this.panel1.Controls.Add(this.employeeInModifyLabel);
            this.panel1.Controls.Add(this.passwordModifyLabel);
            this.panel1.Controls.Add(this.usernameModifyLabel);
            this.panel1.Location = new System.Drawing.Point(16, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 288);
            this.panel1.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(304, 248);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(87, 31);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // usernameModifyTextBox
            // 
            this.usernameModifyTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameModifyTextBox.Location = new System.Drawing.Point(144, 32);
            this.usernameModifyTextBox.Name = "usernameModifyTextBox";
            this.usernameModifyTextBox.Size = new System.Drawing.Size(176, 22);
            this.usernameModifyTextBox.TabIndex = 2;
            // 
            // passwordModifyTextBox
            // 
            this.passwordModifyTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordModifyTextBox.Location = new System.Drawing.Point(144, 88);
            this.passwordModifyTextBox.Name = "passwordModifyTextBox";
            this.passwordModifyTextBox.Size = new System.Drawing.Size(176, 22);
            this.passwordModifyTextBox.TabIndex = 3;
            // 
            // employeeTextBox
            // 
            this.employeeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeTextBox.Location = new System.Drawing.Point(8, 184);
            this.employeeTextBox.Name = "employeeTextBox";
            this.employeeTextBox.Size = new System.Drawing.Size(384, 22);
            this.employeeTextBox.TabIndex = 4;
            // 
            // employeeInModifyLabel
            // 
            this.employeeInModifyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeInModifyLabel.AutoSize = true;
            this.employeeInModifyLabel.Location = new System.Drawing.Point(8, 144);
            this.employeeInModifyLabel.Name = "employeeInModifyLabel";
            this.employeeInModifyLabel.Size = new System.Drawing.Size(180, 17);
            this.employeeInModifyLabel.TabIndex = 5;
            this.employeeInModifyLabel.Text = "Employee in Book Store(s):";
            // 
            // passwordModifyLabel
            // 
            this.passwordModifyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordModifyLabel.AutoSize = true;
            this.passwordModifyLabel.Location = new System.Drawing.Point(8, 88);
            this.passwordModifyLabel.Name = "passwordModifyLabel";
            this.passwordModifyLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordModifyLabel.TabIndex = 6;
            this.passwordModifyLabel.Text = "Password";
            // 
            // usernameModifyLabel
            // 
            this.usernameModifyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameModifyLabel.AutoSize = true;
            this.usernameModifyLabel.Location = new System.Drawing.Point(8, 32);
            this.usernameModifyLabel.Name = "usernameModifyLabel";
            this.usernameModifyLabel.Size = new System.Drawing.Size(73, 17);
            this.usernameModifyLabel.TabIndex = 7;
            this.usernameModifyLabel.Text = "Username";
            // 
            // modifyUserLabel
            // 
            this.modifyUserLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.modifyUserLabel.AutoSize = true;
            this.modifyUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.modifyUserLabel.Location = new System.Drawing.Point(160, 32);
            this.modifyUserLabel.Name = "modifyUserLabel";
            this.modifyUserLabel.Size = new System.Drawing.Size(127, 25);
            this.modifyUserLabel.TabIndex = 1;
            this.modifyUserLabel.Text = "Modify User";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 432);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ModifyUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(427, 427);
            this.Controls.Add(this.modifyUserLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyUserForm";
            this.Text = "ModifyForm - User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label modifyUserLabel;
        private System.Windows.Forms.TextBox usernameModifyTextBox;
        private System.Windows.Forms.TextBox passwordModifyTextBox;
        private System.Windows.Forms.TextBox employeeTextBox;
        private System.Windows.Forms.Label employeeInModifyLabel;
        private System.Windows.Forms.Label passwordModifyLabel;
        private System.Windows.Forms.Label usernameModifyLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}