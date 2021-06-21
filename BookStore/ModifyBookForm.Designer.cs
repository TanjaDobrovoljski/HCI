
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(16, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 472);
            this.panel1.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTextBox.Location = new System.Drawing.Point(128, 360);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(208, 104);
            this.descriptionTextBox.TabIndex = 13;
            // 
            // imageTextBox
            // 
            this.imageTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageTextBox.Location = new System.Drawing.Point(128, 288);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(100, 22);
            this.imageTextBox.TabIndex = 12;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(8, 360);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 11;
            this.descriptionLabel.Text = "Description";
            // 
            // imageLabel
            // 
            this.imageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(8, 296);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(85, 17);
            this.imageLabel.TabIndex = 10;
            this.imageLabel.Text = "Image name";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authorTextBox.Location = new System.Drawing.Point(128, 224);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(168, 22);
            this.authorTextBox.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(352, 432);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 32);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(128, 160);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(144, 22);
            this.publisherTextBox.TabIndex = 6;
            // 
            // publishingYearTextBox
            // 
            this.publishingYearTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.publishingYearTextBox.Location = new System.Drawing.Point(128, 88);
            this.publishingYearTextBox.Name = "publishingYearTextBox";
            this.publishingYearTextBox.Size = new System.Drawing.Size(128, 22);
            this.publishingYearTextBox.TabIndex = 5;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleTextBox.Location = new System.Drawing.Point(128, 24);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(176, 22);
            this.titleTextBox.TabIndex = 4;
            // 
            // authorLabel
            // 
            this.authorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(8, 224);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(50, 17);
            this.authorLabel.TabIndex = 3;
            this.authorLabel.Text = "Author";
            // 
            // publisherLabel
            // 
            this.publisherLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(8, 160);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(67, 17);
            this.publisherLabel.TabIndex = 2;
            this.publisherLabel.Text = "Publisher";
            // 
            // publishingYearLabel
            // 
            this.publishingYearLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.publishingYearLabel.AutoSize = true;
            this.publishingYearLabel.Location = new System.Drawing.Point(8, 88);
            this.publishingYearLabel.Name = "publishingYearLabel";
            this.publishingYearLabel.Size = new System.Drawing.Size(105, 17);
            this.publishingYearLabel.TabIndex = 1;
            this.publishingYearLabel.Text = "Publishing year";
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(8, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // modifyBookLabel
            // 
            this.modifyBookLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.modifyBookLabel.AutoSize = true;
            this.modifyBookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.modifyBookLabel.Location = new System.Drawing.Point(152, 40);
            this.modifyBookLabel.Name = "modifyBookLabel";
            this.modifyBookLabel.Size = new System.Drawing.Size(131, 25);
            this.modifyBookLabel.TabIndex = 8;
            this.modifyBookLabel.Text = "Modify Book";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 600);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // ModifyBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(475, 594);
            this.Controls.Add(this.modifyBookLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyBookForm";
            this.Text = "ModifyForm - Book";
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}