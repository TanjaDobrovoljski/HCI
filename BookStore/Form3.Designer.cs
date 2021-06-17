
namespace BookStore
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.logoutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listPanel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.showListLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.ComboBox();
            this.addBookStore = new System.Windows.Forms.Panel();
            this.addBookStoreButton = new System.Windows.Forms.Button();
            this.bookstoreLabel = new System.Windows.Forms.Label();
            this.addPublisher = new System.Windows.Forms.Panel();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.addPublisherButton = new System.Windows.Forms.Button();
            this.addBook = new System.Windows.Forms.Panel();
            this.bookLabel = new System.Windows.Forms.Label();
            this.addBookButton = new System.Windows.Forms.Button();
            this.addAuthor = new System.Windows.Forms.Panel();
            this.authorLabel = new System.Windows.Forms.Label();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Panel();
            this.addUserButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.listPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.addBookStore.SuspendLayout();
            this.addPublisher.SuspendLayout();
            this.addBook.SuspendLayout();
            this.addAuthor.SuspendLayout();
            this.addUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.BottomToolStripPanel, "toolStripContainer1.BottomToolStripPanel");
            // 
            // toolStripContainer1.ContentPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStripContainer1.ContentPanel.Controls.Add(this.logoutButton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.listPanel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.addBookStore);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.addPublisher);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.addBook);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.addAuthor);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.addUser);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.LeftToolStripPanel, "toolStripContainer1.LeftToolStripPanel");
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.RightToolStripPanel, "toolStripContainer1.RightToolStripPanel");
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.TopToolStripPanel, "toolStripContainer1.TopToolStripPanel");
            // 
            // logoutButton
            // 
            resources.ApplyResources(this.logoutButton, "logoutButton");
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logout_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Name = "panel1";
            // 
            // listPanel
            // 
            resources.ApplyResources(this.listPanel, "listPanel");
            this.listPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPanel.Controls.Add(this.dataGridView);
            this.listPanel.Controls.Add(this.deleteButton);
            this.listPanel.Controls.Add(this.modifyButton);
            this.listPanel.Controls.Add(this.showListLabel);
            this.listPanel.Controls.Add(this.searchBox);
            this.listPanel.Name = "listPanel";
            // 
            // dataGridView
            // 
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // modifyButton
            // 
            resources.ApplyResources(this.modifyButton, "modifyButton");
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // showListLabel
            // 
            resources.ApplyResources(this.showListLabel, "showListLabel");
            this.showListLabel.Name = "showListLabel";
            // 
            // searchBox
            // 
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Items.AddRange(new object[] {
            resources.GetString("searchBox.Items"),
            resources.GetString("searchBox.Items1"),
            resources.GetString("searchBox.Items2"),
            resources.GetString("searchBox.Items3"),
            resources.GetString("searchBox.Items4")});
            this.searchBox.Name = "searchBox";
            this.searchBox.SelectedIndexChanged += new System.EventHandler(this.searchBox_SelectedIndexChanged);
            // 
            // addBookStore
            // 
            resources.ApplyResources(this.addBookStore, "addBookStore");
            this.addBookStore.BackColor = System.Drawing.Color.Transparent;
            this.addBookStore.Controls.Add(this.addBookStoreButton);
            this.addBookStore.Controls.Add(this.bookstoreLabel);
            this.addBookStore.Name = "addBookStore";
            // 
            // addBookStoreButton
            // 
            resources.ApplyResources(this.addBookStoreButton, "addBookStoreButton");
            this.addBookStoreButton.Name = "addBookStoreButton";
            this.addBookStoreButton.UseVisualStyleBackColor = true;
            this.addBookStoreButton.Click += new System.EventHandler(this.addBookStoreButton_Click);
            // 
            // bookstoreLabel
            // 
            resources.ApplyResources(this.bookstoreLabel, "bookstoreLabel");
            this.bookstoreLabel.Name = "bookstoreLabel";
            // 
            // addPublisher
            // 
            resources.ApplyResources(this.addPublisher, "addPublisher");
            this.addPublisher.BackColor = System.Drawing.Color.Transparent;
            this.addPublisher.Controls.Add(this.publisherLabel);
            this.addPublisher.Controls.Add(this.addPublisherButton);
            this.addPublisher.Name = "addPublisher";
            // 
            // publisherLabel
            // 
            resources.ApplyResources(this.publisherLabel, "publisherLabel");
            this.publisherLabel.Name = "publisherLabel";
            // 
            // addPublisherButton
            // 
            resources.ApplyResources(this.addPublisherButton, "addPublisherButton");
            this.addPublisherButton.Name = "addPublisherButton";
            this.addPublisherButton.UseVisualStyleBackColor = true;
            this.addPublisherButton.Click += new System.EventHandler(this.addPublisherButton_Click);
            // 
            // addBook
            // 
            resources.ApplyResources(this.addBook, "addBook");
            this.addBook.BackColor = System.Drawing.Color.Transparent;
            this.addBook.Controls.Add(this.bookLabel);
            this.addBook.Controls.Add(this.addBookButton);
            this.addBook.Name = "addBook";
            // 
            // bookLabel
            // 
            resources.ApplyResources(this.bookLabel, "bookLabel");
            this.bookLabel.Name = "bookLabel";
            // 
            // addBookButton
            // 
            resources.ApplyResources(this.addBookButton, "addBookButton");
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // addAuthor
            // 
            resources.ApplyResources(this.addAuthor, "addAuthor");
            this.addAuthor.BackColor = System.Drawing.Color.Transparent;
            this.addAuthor.Controls.Add(this.authorLabel);
            this.addAuthor.Controls.Add(this.addAuthorButton);
            this.addAuthor.Name = "addAuthor";
            // 
            // authorLabel
            // 
            resources.ApplyResources(this.authorLabel, "authorLabel");
            this.authorLabel.Name = "authorLabel";
            // 
            // addAuthorButton
            // 
            resources.ApplyResources(this.addAuthorButton, "addAuthorButton");
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // addUser
            // 
            resources.ApplyResources(this.addUser, "addUser");
            this.addUser.BackColor = System.Drawing.Color.Transparent;
            this.addUser.Controls.Add(this.addUserButton);
            this.addUser.Controls.Add(this.userLabel);
            this.addUser.Name = "addUser";
            // 
            // addUserButton
            // 
            resources.ApplyResources(this.addUserButton, "addUserButton");
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // userLabel
            // 
            resources.ApplyResources(this.userLabel, "userLabel");
            this.userLabel.Name = "userLabel";
            // 
            // Form3
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.addBookStore.ResumeLayout(false);
            this.addBookStore.PerformLayout();
            this.addPublisher.ResumeLayout(false);
            this.addPublisher.PerformLayout();
            this.addBook.ResumeLayout(false);
            this.addBook.PerformLayout();
            this.addAuthor.ResumeLayout(false);
            this.addAuthor.PerformLayout();
            this.addUser.ResumeLayout(false);
            this.addUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel addUser;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Panel addAuthor;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Panel addBookStore;
        private System.Windows.Forms.Label bookstoreLabel;
        private System.Windows.Forms.Panel addPublisher;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Panel addBook;
        private System.Windows.Forms.Label bookLabel;
        private System.Windows.Forms.Button addBookStoreButton;
        private System.Windows.Forms.Button addPublisherButton;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Label showListLabel;
        private System.Windows.Forms.ComboBox searchBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button logoutButton;
    }
}