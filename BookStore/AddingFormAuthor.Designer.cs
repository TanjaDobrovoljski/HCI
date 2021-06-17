
namespace BookStore
{
    partial class AddingFormAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingFormAuthor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.birthPlaceLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.birthPlaceTextBox = new System.Windows.Forms.TextBox();
            this.newAuthorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateOfBirthTextBox);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.birthPlaceLabel);
            this.panel1.Controls.Add(this.dateOfBirthLabel);
            this.panel1.Controls.Add(this.lastNameLabel);
            this.panel1.Controls.Add(this.firstNameLabel);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.birthPlaceTextBox);
            this.panel1.Name = "panel1";
            // 
            // dateOfBirthTextBox
            // 
            resources.ApplyResources(this.dateOfBirthTextBox, "dateOfBirthTextBox");
            this.dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            this.dateOfBirthTextBox.Enter += new System.EventHandler(this.dateOfBirthTextBox_Enter);
            this.dateOfBirthTextBox.Leave += new System.EventHandler(this.dateOfBirthTextBox_Leave);
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
            // birthPlaceLabel
            // 
            resources.ApplyResources(this.birthPlaceLabel, "birthPlaceLabel");
            this.birthPlaceLabel.Name = "birthPlaceLabel";
            // 
            // dateOfBirthLabel
            // 
            resources.ApplyResources(this.dateOfBirthLabel, "dateOfBirthLabel");
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            // 
            // lastNameLabel
            // 
            resources.ApplyResources(this.lastNameLabel, "lastNameLabel");
            this.lastNameLabel.Name = "lastNameLabel";
            // 
            // firstNameLabel
            // 
            resources.ApplyResources(this.firstNameLabel, "firstNameLabel");
            this.firstNameLabel.Name = "firstNameLabel";
            // 
            // firstNameTextBox
            // 
            resources.ApplyResources(this.firstNameTextBox, "firstNameTextBox");
            this.firstNameTextBox.Name = "firstNameTextBox";
            // 
            // lastNameTextBox
            // 
            resources.ApplyResources(this.lastNameTextBox, "lastNameTextBox");
            this.lastNameTextBox.Name = "lastNameTextBox";
            // 
            // birthPlaceTextBox
            // 
            resources.ApplyResources(this.birthPlaceTextBox, "birthPlaceTextBox");
            this.birthPlaceTextBox.Name = "birthPlaceTextBox";
            // 
            // newAuthorLabel
            // 
            resources.ApplyResources(this.newAuthorLabel, "newAuthorLabel");
            this.newAuthorLabel.Name = "newAuthorLabel";
            // 
            // AddingFormAuthor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.newAuthorLabel);
            this.Controls.Add(this.panel1);
            this.Name = "AddingFormAuthor";
            this.Load += new System.EventHandler(this.AddingFormAuthor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label newAuthorLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox birthPlaceTextBox;
        private System.Windows.Forms.Label birthPlaceLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox dateOfBirthTextBox;
    }
}