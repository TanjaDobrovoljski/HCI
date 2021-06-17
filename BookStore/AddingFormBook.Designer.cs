
namespace BookStore
{
    partial class AddingFormBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingFormBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.imageLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorComboBox = new System.Windows.Forms.ComboBox();
            this.publisherComboBox = new System.Windows.Forms.ComboBox();
            this.publishingYearTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.publishingYearLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.newBookLabel = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.imageTextBox);
            this.panel1.Controls.Add(this.imageLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Controls.Add(this.authorLabel);
            this.panel1.Controls.Add(this.authorComboBox);
            this.panel1.Controls.Add(this.publisherComboBox);
            this.panel1.Controls.Add(this.publishingYearTextBox);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(this.publisherLabel);
            this.panel1.Controls.Add(this.publishingYearLabel);
            this.panel1.Controls.Add(this.titleLabel);
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
            // imageTextBox
            // 
            resources.ApplyResources(this.imageTextBox, "imageTextBox");
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Enter += new System.EventHandler(this.imageTextBox_Enter);
            this.imageTextBox.Leave += new System.EventHandler(this.imageTextBox_Leave);
            // 
            // imageLabel
            // 
            resources.ApplyResources(this.imageLabel, "imageLabel");
            this.imageLabel.Name = "imageLabel";
            // 
            // descriptionTextBox
            // 
            resources.ApplyResources(this.descriptionTextBox, "descriptionTextBox");
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Enter += new System.EventHandler(this.descriptionTextBox_Enter);
            this.descriptionTextBox.Leave += new System.EventHandler(this.descriptionTextBox_Leave);
            // 
            // descriptionLabel
            // 
            resources.ApplyResources(this.descriptionLabel, "descriptionLabel");
            this.descriptionLabel.Name = "descriptionLabel";
            // 
            // authorLabel
            // 
            resources.ApplyResources(this.authorLabel, "authorLabel");
            this.authorLabel.Name = "authorLabel";
            // 
            // authorComboBox
            // 
            resources.ApplyResources(this.authorComboBox, "authorComboBox");
            this.authorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorComboBox.FormattingEnabled = true;
            this.authorComboBox.Name = "authorComboBox";
            // 
            // publisherComboBox
            // 
            resources.ApplyResources(this.publisherComboBox, "publisherComboBox");
            this.publisherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publisherComboBox.FormattingEnabled = true;
            this.publisherComboBox.Name = "publisherComboBox";
            // 
            // publishingYearTextBox
            // 
            resources.ApplyResources(this.publishingYearTextBox, "publishingYearTextBox");
            this.publishingYearTextBox.Name = "publishingYearTextBox";
            this.publishingYearTextBox.Enter += new System.EventHandler(this.publishingYearTextBox_Enter);
            this.publishingYearTextBox.Leave += new System.EventHandler(this.publishingYearTextBox_Leave);
            // 
            // titleTextBox
            // 
            resources.ApplyResources(this.titleTextBox, "titleTextBox");
            this.titleTextBox.Name = "titleTextBox";
            // 
            // publisherLabel
            // 
            resources.ApplyResources(this.publisherLabel, "publisherLabel");
            this.publisherLabel.Name = "publisherLabel";
            // 
            // publishingYearLabel
            // 
            resources.ApplyResources(this.publishingYearLabel, "publishingYearLabel");
            this.publishingYearLabel.Name = "publishingYearLabel";
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            // 
            // newBookLabel
            // 
            resources.ApplyResources(this.newBookLabel, "newBookLabel");
            this.newBookLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.newBookLabel.Name = "newBookLabel";
            // 
            // AddingFormBook
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.newBookLabel);
            this.Controls.Add(this.panel1);
            this.Name = "AddingFormBook";
            this.Load += new System.EventHandler(this.AddingFormBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label newBookLabel;
        private System.Windows.Forms.TextBox publishingYearTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label publishingYearLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox publisherComboBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.ComboBox authorComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
    }
}