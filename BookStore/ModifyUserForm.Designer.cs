
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.usernameModifyTextBox);
            this.panel1.Controls.Add(this.passwordModifyTextBox);
            this.panel1.Controls.Add(this.employeeTextBox);
            this.panel1.Controls.Add(this.employeeInModifyLabel);
            this.panel1.Controls.Add(this.passwordModifyLabel);
            this.panel1.Controls.Add(this.usernameModifyLabel);
            this.panel1.Name = "panel1";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // usernameModifyTextBox
            // 
            resources.ApplyResources(this.usernameModifyTextBox, "usernameModifyTextBox");
            this.usernameModifyTextBox.Name = "usernameModifyTextBox";
            // 
            // passwordModifyTextBox
            // 
            resources.ApplyResources(this.passwordModifyTextBox, "passwordModifyTextBox");
            this.passwordModifyTextBox.Name = "passwordModifyTextBox";
            // 
            // employeeTextBox
            // 
            resources.ApplyResources(this.employeeTextBox, "employeeTextBox");
            this.employeeTextBox.Name = "employeeTextBox";
            // 
            // employeeInModifyLabel
            // 
            resources.ApplyResources(this.employeeInModifyLabel, "employeeInModifyLabel");
            this.employeeInModifyLabel.Name = "employeeInModifyLabel";
            // 
            // passwordModifyLabel
            // 
            resources.ApplyResources(this.passwordModifyLabel, "passwordModifyLabel");
            this.passwordModifyLabel.Name = "passwordModifyLabel";
            // 
            // usernameModifyLabel
            // 
            resources.ApplyResources(this.usernameModifyLabel, "usernameModifyLabel");
            this.usernameModifyLabel.Name = "usernameModifyLabel";
            // 
            // modifyUserLabel
            // 
            resources.ApplyResources(this.modifyUserLabel, "modifyUserLabel");
            this.modifyUserLabel.Name = "modifyUserLabel";
            // 
            // ModifyUserForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.modifyUserLabel);
            this.Controls.Add(this.panel1);
            this.Name = "ModifyUserForm";
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
    }
}