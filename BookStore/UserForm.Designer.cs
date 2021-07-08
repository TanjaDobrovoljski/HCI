
namespace BookStore
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.logo = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.searchTitleBox = new System.Windows.Forms.ComboBox();
            this.searchTitleText = new System.Windows.Forms.Label();
            this.searchAuthorBox = new System.Windows.Forms.ComboBox();
            this.searchAuthorText = new System.Windows.Forms.Label();
            this.bookstoreLetter = new System.Windows.Forms.Label();
            this.searchPublisherBox = new System.Windows.Forms.ComboBox();
            this.searchPublisherText = new System.Windows.Forms.Label();
            this.storeLetter = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.bookStoreInfromation = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            resources.ApplyResources(this.logo, "logo");
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // searchTitleBox
            // 
            resources.ApplyResources(this.searchTitleBox, "searchTitleBox");
            this.searchTitleBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchTitleBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchTitleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchTitleBox.FormattingEnabled = true;
            this.searchTitleBox.Name = "searchTitleBox";
            this.searchTitleBox.SelectedIndexChanged += new System.EventHandler(this.searchTitleBox_SelectedIndexChanged);
            // 
            // searchTitleText
            // 
            resources.ApplyResources(this.searchTitleText, "searchTitleText");
            this.searchTitleText.BackColor = System.Drawing.Color.Transparent;
            this.searchTitleText.ForeColor = System.Drawing.Color.Cyan;
            this.searchTitleText.Name = "searchTitleText";
            // 
            // searchAuthorBox
            // 
            resources.ApplyResources(this.searchAuthorBox, "searchAuthorBox");
            this.searchAuthorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchAuthorBox.FormattingEnabled = true;
            this.searchAuthorBox.Name = "searchAuthorBox";
            this.searchAuthorBox.SelectedIndexChanged += new System.EventHandler(this.searchAuthorBox_SelectedIndexChanged);
            // 
            // searchAuthorText
            // 
            resources.ApplyResources(this.searchAuthorText, "searchAuthorText");
            this.searchAuthorText.BackColor = System.Drawing.Color.Transparent;
            this.searchAuthorText.ForeColor = System.Drawing.Color.Cyan;
            this.searchAuthorText.Name = "searchAuthorText";
            // 
            // bookstoreLetter
            // 
            resources.ApplyResources(this.bookstoreLetter, "bookstoreLetter");
            this.bookstoreLetter.BackColor = System.Drawing.Color.Transparent;
            this.bookstoreLetter.Name = "bookstoreLetter";
            // 
            // searchPublisherBox
            // 
            resources.ApplyResources(this.searchPublisherBox, "searchPublisherBox");
            this.searchPublisherBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchPublisherBox.FormattingEnabled = true;
            this.searchPublisherBox.Name = "searchPublisherBox";
            this.searchPublisherBox.SelectedIndexChanged += new System.EventHandler(this.searchPublisherBox_SelectedIndexChanged);
            // 
            // searchPublisherText
            // 
            resources.ApplyResources(this.searchPublisherText, "searchPublisherText");
            this.searchPublisherText.BackColor = System.Drawing.Color.Transparent;
            this.searchPublisherText.ForeColor = System.Drawing.Color.Cyan;
            this.searchPublisherText.Name = "searchPublisherText";
            // 
            // storeLetter
            // 
            resources.ApplyResources(this.storeLetter, "storeLetter");
            this.storeLetter.BackColor = System.Drawing.Color.Transparent;
            this.storeLetter.Name = "storeLetter";
            // 
            // searchButton
            // 
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.BackColor = System.Drawing.Color.Cyan;
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showAllButton
            // 
            resources.ApplyResources(this.showAllButton, "showAllButton");
            this.showAllButton.BackColor = System.Drawing.Color.Cyan;
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.UseVisualStyleBackColor = false;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // bookStoreInfromation
            // 
            resources.ApplyResources(this.bookStoreInfromation, "bookStoreInfromation");
            this.bookStoreInfromation.BackColor = System.Drawing.Color.Transparent;
            this.bookStoreInfromation.ForeColor = System.Drawing.Color.Black;
            this.bookStoreInfromation.Name = "bookStoreInfromation";
            // 
            // logoutButton
            // 
            resources.ApplyResources(this.logoutButton, "logoutButton");
            this.logoutButton.BackColor = System.Drawing.Color.Cyan;
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // UserForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchPublisherText);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.bookStoreInfromation);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.storeLetter);
            this.Controls.Add(this.searchPublisherBox);
            this.Controls.Add(this.bookstoreLetter);
            this.Controls.Add(this.searchAuthorText);
            this.Controls.Add(this.searchAuthorBox);
            this.Controls.Add(this.searchTitleText);
            this.Controls.Add(this.searchTitleBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "UserForm";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox searchTitleBox;
        private System.Windows.Forms.Label searchTitleText;
        private System.Windows.Forms.ComboBox searchAuthorBox;
        private System.Windows.Forms.Label searchAuthorText;
        private System.Windows.Forms.Label bookstoreLetter;
        private System.Windows.Forms.ComboBox searchPublisherBox;
        private System.Windows.Forms.Label searchPublisherText;
        private System.Windows.Forms.Label storeLetter;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Label bookStoreInfromation;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}