
namespace BookStore
{
    partial class BookStoreSave4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookStoreSave4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantitycomboBox1 = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.bookStoreComboBox = new System.Windows.Forms.ComboBox();
            this.bookStoreLabel = new System.Windows.Forms.Label();
            this.saveInBookStoreLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.quantitycomboBox1);
            this.panel1.Controls.Add(this.quantityLabel);
            this.panel1.Controls.Add(this.bookStoreComboBox);
            this.panel1.Controls.Add(this.bookStoreLabel);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // clearButton
            // 
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.Name = "clearButton";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // priceTextBox
            // 
            resources.ApplyResources(this.priceTextBox, "priceTextBox");
            this.priceTextBox.Name = "priceTextBox";
            // 
            // priceLabel
            // 
            resources.ApplyResources(this.priceLabel, "priceLabel");
            this.priceLabel.Name = "priceLabel";
            // 
            // quantitycomboBox1
            // 
            resources.ApplyResources(this.quantitycomboBox1, "quantitycomboBox1");
            this.quantitycomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantitycomboBox1.FormattingEnabled = true;
            this.quantitycomboBox1.Name = "quantitycomboBox1";
            // 
            // quantityLabel
            // 
            resources.ApplyResources(this.quantityLabel, "quantityLabel");
            this.quantityLabel.Name = "quantityLabel";
            // 
            // bookStoreComboBox
            // 
            resources.ApplyResources(this.bookStoreComboBox, "bookStoreComboBox");
            this.bookStoreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookStoreComboBox.FormattingEnabled = true;
            this.bookStoreComboBox.Name = "bookStoreComboBox";
            // 
            // bookStoreLabel
            // 
            resources.ApplyResources(this.bookStoreLabel, "bookStoreLabel");
            this.bookStoreLabel.Name = "bookStoreLabel";
            // 
            // saveInBookStoreLabel
            // 
            resources.ApplyResources(this.saveInBookStoreLabel, "saveInBookStoreLabel");
            this.saveInBookStoreLabel.Name = "saveInBookStoreLabel";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // BookStoreSave4
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.saveInBookStoreLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BookStoreSave4";
            this.Load += new System.EventHandler(this.BookStoreSave4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label saveInBookStoreLabel;
        private System.Windows.Forms.Label bookStoreLabel;
        private System.Windows.Forms.ComboBox bookStoreComboBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.ComboBox quantitycomboBox1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}