
namespace BookStore
{
    partial class AddingFormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingFormUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.bookStoreLabel = new System.Windows.Forms.Label();
            this.bookstoreBox = new System.Windows.Forms.ComboBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.addLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.bookStoreLabel);
            this.panel1.Controls.Add(this.bookstoreBox);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Name = "panel1";
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // bookStoreLabel
            // 
            resources.ApplyResources(this.bookStoreLabel, "bookStoreLabel");
            this.bookStoreLabel.Name = "bookStoreLabel";
            // 
            // bookstoreBox
            // 
            resources.ApplyResources(this.bookstoreBox, "bookstoreBox");
            this.bookstoreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookstoreBox.FormattingEnabled = true;
            this.bookstoreBox.Name = "bookstoreBox";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.Name = "passwordTextBox";
            // 
            // usernameTextBox
            // 
            resources.ApplyResources(this.usernameTextBox, "usernameTextBox");
            this.usernameTextBox.Name = "usernameTextBox";
            // 
            // addLabel
            // 
            resources.ApplyResources(this.addLabel, "addLabel");
            this.addLabel.Name = "addLabel";
            // 
            // AddingFormUser
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.panel1);
            this.Name = "AddingFormUser";
            this.Load += new System.EventHandler(this.AddingFormUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label bookStoreLabel;
        private System.Windows.Forms.ComboBox bookstoreBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
    }
}