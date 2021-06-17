
namespace BookStore
{
    partial class ModifyPublisherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyPublisherForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.booksTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.booksLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.booksTextBox);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.addressLabel);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.phoneLabel);
            this.panel1.Controls.Add(this.booksLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Name = "panel1";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // booksTextBox
            // 
            resources.ApplyResources(this.booksTextBox, "booksTextBox");
            this.booksTextBox.Name = "booksTextBox";
            // 
            // phoneTextBox
            // 
            resources.ApplyResources(this.phoneTextBox, "phoneTextBox");
            this.phoneTextBox.Name = "phoneTextBox";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // addressLabel
            // 
            resources.ApplyResources(this.addressLabel, "addressLabel");
            this.addressLabel.Name = "addressLabel";
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.Name = "emailLabel";
            // 
            // phoneLabel
            // 
            resources.ApplyResources(this.phoneLabel, "phoneLabel");
            this.phoneLabel.Name = "phoneLabel";
            // 
            // booksLabel
            // 
            resources.ApplyResources(this.booksLabel, "booksLabel");
            this.booksLabel.Name = "booksLabel";
            // 
            // nameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.Name = "nameTextBox";
            // 
            // addressTextBox
            // 
            resources.ApplyResources(this.addressTextBox, "addressTextBox");
            this.addressTextBox.Name = "addressTextBox";
            // 
            // emailTextBox
            // 
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            this.emailTextBox.Name = "emailTextBox";
            // 
            // publisherLabel
            // 
            resources.ApplyResources(this.publisherLabel, "publisherLabel");
            this.publisherLabel.Name = "publisherLabel";
            // 
            // ModifyPublisherForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.panel1);
            this.Name = "ModifyPublisherForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox booksTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label booksLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Button saveButton;
    }
}