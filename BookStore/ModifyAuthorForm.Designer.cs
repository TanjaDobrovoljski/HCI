
namespace BookStore
{
    partial class ModifyAuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyAuthorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.dateBirthLabel = new System.Windows.Forms.Label();
            this.birthPlaceLabel = new System.Windows.Forms.Label();
            this.booksLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dateBirthTextBox = new System.Windows.Forms.TextBox();
            this.birthPlaceTextBox = new System.Windows.Forms.TextBox();
            this.booksTextBox = new System.Windows.Forms.TextBox();
            this.modifyAuthorLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.lastNameLabel);
            this.panel1.Controls.Add(this.dateBirthLabel);
            this.panel1.Controls.Add(this.birthPlaceLabel);
            this.panel1.Controls.Add(this.booksLabel);
            this.panel1.Controls.Add(this.firstNameLabel);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.dateBirthTextBox);
            this.panel1.Controls.Add(this.birthPlaceTextBox);
            this.panel1.Controls.Add(this.booksTextBox);
            this.panel1.Name = "panel1";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // lastNameLabel
            // 
            resources.ApplyResources(this.lastNameLabel, "lastNameLabel");
            this.lastNameLabel.Name = "lastNameLabel";
            // 
            // dateBirthLabel
            // 
            resources.ApplyResources(this.dateBirthLabel, "dateBirthLabel");
            this.dateBirthLabel.Name = "dateBirthLabel";
            // 
            // birthPlaceLabel
            // 
            resources.ApplyResources(this.birthPlaceLabel, "birthPlaceLabel");
            this.birthPlaceLabel.Name = "birthPlaceLabel";
            // 
            // booksLabel
            // 
            resources.ApplyResources(this.booksLabel, "booksLabel");
            this.booksLabel.Name = "booksLabel";
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
            // dateBirthTextBox
            // 
            resources.ApplyResources(this.dateBirthTextBox, "dateBirthTextBox");
            this.dateBirthTextBox.Name = "dateBirthTextBox";
            // 
            // birthPlaceTextBox
            // 
            resources.ApplyResources(this.birthPlaceTextBox, "birthPlaceTextBox");
            this.birthPlaceTextBox.Name = "birthPlaceTextBox";
            // 
            // booksTextBox
            // 
            resources.ApplyResources(this.booksTextBox, "booksTextBox");
            this.booksTextBox.Name = "booksTextBox";
            // 
            // modifyAuthorLabel
            // 
            resources.ApplyResources(this.modifyAuthorLabel, "modifyAuthorLabel");
            this.modifyAuthorLabel.Name = "modifyAuthorLabel";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // ModifyAuthorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.modifyAuthorLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ModifyAuthorForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label dateBirthLabel;
        private System.Windows.Forms.Label birthPlaceLabel;
        private System.Windows.Forms.Label booksLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox dateBirthTextBox;
        private System.Windows.Forms.TextBox birthPlaceTextBox;
        private System.Windows.Forms.TextBox booksTextBox;
        private System.Windows.Forms.Label modifyAuthorLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}