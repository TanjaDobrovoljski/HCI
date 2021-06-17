
namespace BookStore
{
    partial class ModifyBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyBookForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.publishingYearTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.publishingYearLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.modifyBookLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.imageTextBox);
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Controls.Add(this.imageLabel);
            this.panel1.Controls.Add(this.authorTextBox);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.publisherTextBox);
            this.panel1.Controls.Add(this.publishingYearTextBox);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(this.authorLabel);
            this.panel1.Controls.Add(this.publisherLabel);
            this.panel1.Controls.Add(this.publishingYearLabel);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Name = "panel1";
            // 
            // descriptionTextBox
            // 
            resources.ApplyResources(this.descriptionTextBox, "descriptionTextBox");
            this.descriptionTextBox.Name = "descriptionTextBox";
            // 
            // imageTextBox
            // 
            resources.ApplyResources(this.imageTextBox, "imageTextBox");
            this.imageTextBox.Name = "imageTextBox";
            // 
            // descriptionLabel
            // 
            resources.ApplyResources(this.descriptionLabel, "descriptionLabel");
            this.descriptionLabel.Name = "descriptionLabel";
            // 
            // imageLabel
            // 
            resources.ApplyResources(this.imageLabel, "imageLabel");
            this.imageLabel.Name = "imageLabel";
            // 
            // authorTextBox
            // 
            resources.ApplyResources(this.authorTextBox, "authorTextBox");
            this.authorTextBox.Name = "authorTextBox";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // publisherTextBox
            // 
            resources.ApplyResources(this.publisherTextBox, "publisherTextBox");
            this.publisherTextBox.Name = "publisherTextBox";
            // 
            // publishingYearTextBox
            // 
            resources.ApplyResources(this.publishingYearTextBox, "publishingYearTextBox");
            this.publishingYearTextBox.Name = "publishingYearTextBox";
            // 
            // titleTextBox
            // 
            resources.ApplyResources(this.titleTextBox, "titleTextBox");
            this.titleTextBox.Name = "titleTextBox";
            // 
            // authorLabel
            // 
            resources.ApplyResources(this.authorLabel, "authorLabel");
            this.authorLabel.Name = "authorLabel";
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
            // modifyBookLabel
            // 
            resources.ApplyResources(this.modifyBookLabel, "modifyBookLabel");
            this.modifyBookLabel.Name = "modifyBookLabel";
            // 
            // ModifyBookForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.modifyBookLabel);
            this.Controls.Add(this.panel1);
            this.Name = "ModifyBookForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox publishingYearTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label publishingYearLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label modifyBookLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label imageLabel;
    }
}