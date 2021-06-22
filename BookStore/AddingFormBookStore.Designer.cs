
namespace BookStore
{
    partial class AddingFormBookStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingFormBookStore));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openningDateTextBox = new System.Windows.Forms.TextBox();
            this.workTimeTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.openingLabel = new System.Windows.Forms.Label();
            this.workTimeLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.newBookStoreLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.panel1.Controls.Add(this.openningDateTextBox);
            this.panel1.Controls.Add(this.workTimeTextBox);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.openingLabel);
            this.panel1.Controls.Add(this.workTimeLabel);
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
            // openningDateTextBox
            // 
            resources.ApplyResources(this.openningDateTextBox, "openningDateTextBox");
            this.openningDateTextBox.Name = "openningDateTextBox";
            this.openningDateTextBox.Enter += new System.EventHandler(this.openningDateTextBox_Enter);
            this.openningDateTextBox.Leave += new System.EventHandler(this.openningDateTextBox_Leave);
            // 
            // workTimeTextBox
            // 
            resources.ApplyResources(this.workTimeTextBox, "workTimeTextBox");
            this.workTimeTextBox.Name = "workTimeTextBox";
            this.workTimeTextBox.Enter += new System.EventHandler(this.workTimeTextBox_Enter);
            this.workTimeTextBox.Leave += new System.EventHandler(this.workTimeTextBox_Leave);
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
            // openingLabel
            // 
            resources.ApplyResources(this.openingLabel, "openingLabel");
            this.openingLabel.Name = "openingLabel";
            // 
            // workTimeLabel
            // 
            resources.ApplyResources(this.workTimeLabel, "workTimeLabel");
            this.workTimeLabel.Name = "workTimeLabel";
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
            // newBookStoreLabel
            // 
            resources.ApplyResources(this.newBookStoreLabel, "newBookStoreLabel");
            this.newBookStoreLabel.Name = "newBookStoreLabel";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // AddingFormBookStore
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.newBookStoreLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddingFormBookStore";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label newBookStoreLabel;
        private System.Windows.Forms.TextBox openningDateTextBox;
        private System.Windows.Forms.TextBox workTimeTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label openingLabel;
        private System.Windows.Forms.Label workTimeLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}