
namespace BookStore
{
    partial class AddingFormPublisher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingFormPublisher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNUmberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.newPublisherLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.phoneNUmberLabel);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.addressLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Name = "panel1";
            // 
            // clearButton
            // 
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.Name = "clearButton";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // phoneTextBox
            // 
            resources.ApplyResources(this.phoneTextBox, "phoneTextBox");
            this.phoneTextBox.Name = "phoneTextBox";
            // 
            // emailTextBox
            // 
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            this.emailTextBox.Name = "emailTextBox";
            // 
            // addressTextBox
            // 
            resources.ApplyResources(this.addressTextBox, "addressTextBox");
            this.addressTextBox.Name = "addressTextBox";
            // 
            // nameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.Name = "nameTextBox";
            // 
            // phoneNUmberLabel
            // 
            resources.ApplyResources(this.phoneNUmberLabel, "phoneNUmberLabel");
            this.phoneNUmberLabel.Name = "phoneNUmberLabel";
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.Name = "emailLabel";
            // 
            // addressLabel
            // 
            resources.ApplyResources(this.addressLabel, "addressLabel");
            this.addressLabel.Name = "addressLabel";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // newPublisherLabel
            // 
            resources.ApplyResources(this.newPublisherLabel, "newPublisherLabel");
            this.newPublisherLabel.Name = "newPublisherLabel";
            // 
            // AddingFormPublisher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.newPublisherLabel);
            this.Controls.Add(this.panel1);
            this.Name = "AddingFormPublisher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label newPublisherLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label phoneNUmberLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}