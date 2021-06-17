
namespace BookStore
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showListLabel = new System.Windows.Forms.Label();
            this.modifyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.listPanel = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
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
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStripContainer1.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.logoutButton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.listPanel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.addBookStore);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.addPublisher);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.addUser);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.addBook);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.addAuthor);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1664, 839);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            this.toolStripContainer1.RightToolStripPanel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.toolStripContainer1.Size = new System.Drawing.Size(1664, 864);
            this.toolStripContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(304, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 1500);
            this.panel1.TabIndex = 1;
            // 
            // showListLabel
            // 
            this.showListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showListLabel.Location = new System.Drawing.Point(368, 8);
            this.showListLabel.Name = "showListLabel";
            this.showListLabel.Size = new System.Drawing.Size(112, 23);
            this.showListLabel.TabIndex = 3;
            this.showListLabel.Text = "Show list:";
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(440, 360);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 24);
            this.modifyButton.TabIndex = 2;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(544, 360);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 25);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutButton.Location = new System.Drawing.Point(8, 504);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(88, 32);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logout_Click);
            // 
            // listPanel
            // 
            this.listPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.listPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPanel.Controls.Add(this.searchBox);
            this.listPanel.Controls.Add(this.deleteButton);
            this.listPanel.Controls.Add(this.modifyButton);
            this.listPanel.Controls.Add(this.showListLabel);
            this.listPanel.Controls.Add(this.dataGridView);
            this.listPanel.Location = new System.Drawing.Point(384, 48);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(632, 392);
            this.listPanel.TabIndex = 2;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Items.AddRange(new object[] {
            "Users",
            "Authors",
            "Books",
            "Publishers",
            "Book Stores"});
            this.searchBox.Location = new System.Drawing.Point(496, 8);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(121, 24);
            this.searchBox.TabIndex = 4;
            this.searchBox.SelectedIndexChanged += new System.EventHandler(this.searchBox_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 72);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(600, 248);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // addBookStore
            // 
            this.addBookStore.BackColor = System.Drawing.Color.Transparent;
            this.addBookStore.Controls.Add(this.bookstoreLabel);
            this.addBookStore.Controls.Add(this.addBookStoreButton);
            this.addBookStore.Location = new System.Drawing.Point(8, 400);
            this.addBookStore.Name = "addBookStore";
            this.addBookStore.Size = new System.Drawing.Size(256, 56);
            this.addBookStore.TabIndex = 3;
            // 
            // addBookStoreButton
            // 
            this.addBookStoreButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBookStoreButton.BackgroundImage")));
            this.addBookStoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBookStoreButton.Location = new System.Drawing.Point(0, 0);
            this.addBookStoreButton.Name = "addBookStoreButton";
            this.addBookStoreButton.Size = new System.Drawing.Size(64, 56);
            this.addBookStoreButton.TabIndex = 0;
            this.addBookStoreButton.UseVisualStyleBackColor = true;
            this.addBookStoreButton.Click += new System.EventHandler(this.addBookStoreButton_Click);
            // 
            // bookstoreLabel
            // 
            this.bookstoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookstoreLabel.Location = new System.Drawing.Point(72, 16);
            this.bookstoreLabel.Name = "bookstoreLabel";
            this.bookstoreLabel.Size = new System.Drawing.Size(168, 23);
            this.bookstoreLabel.TabIndex = 1;
            this.bookstoreLabel.Text = "+ Add Book Store";
            // 
            // addPublisher
            // 
            this.addPublisher.BackColor = System.Drawing.Color.Transparent;
            this.addPublisher.Controls.Add(this.addPublisherButton);
            this.addPublisher.Controls.Add(this.publisherLabel);
            this.addPublisher.Location = new System.Drawing.Point(8, 312);
            this.addPublisher.Name = "addPublisher";
            this.addPublisher.Size = new System.Drawing.Size(248, 56);
            this.addPublisher.TabIndex = 4;
            // 
            // publisherLabel
            // 
            this.publisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLabel.Location = new System.Drawing.Point(72, 16);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(160, 23);
            this.publisherLabel.TabIndex = 0;
            this.publisherLabel.Text = "+ Add Publisher";
            // 
            // addPublisherButton
            // 
            this.addPublisherButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addPublisherButton.BackgroundImage")));
            this.addPublisherButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addPublisherButton.Location = new System.Drawing.Point(0, 0);
            this.addPublisherButton.Name = "addPublisherButton";
            this.addPublisherButton.Size = new System.Drawing.Size(64, 56);
            this.addPublisherButton.TabIndex = 1;
            this.addPublisherButton.UseVisualStyleBackColor = true;
            this.addPublisherButton.Click += new System.EventHandler(this.addPublisherButton_Click);
            // 
            // addBook
            // 
            this.addBook.BackColor = System.Drawing.Color.Transparent;
            this.addBook.Controls.Add(this.addBookButton);
            this.addBook.Controls.Add(this.bookLabel);
            this.addBook.Location = new System.Drawing.Point(8, 224);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(224, 56);
            this.addBook.TabIndex = 5;
            // 
            // bookLabel
            // 
            this.bookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLabel.Location = new System.Drawing.Point(72, 16);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(136, 23);
            this.bookLabel.TabIndex = 0;
            this.bookLabel.Text = "+ Add Book";
            // 
            // addBookButton
            // 
            this.addBookButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBookButton.BackgroundImage")));
            this.addBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBookButton.Location = new System.Drawing.Point(0, 0);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(64, 56);
            this.addBookButton.TabIndex = 1;
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // addAuthor
            // 
            this.addAuthor.BackColor = System.Drawing.Color.Transparent;
            this.addAuthor.Controls.Add(this.authorLabel);
            this.addAuthor.Controls.Add(this.addAuthorButton);
            this.addAuthor.Location = new System.Drawing.Point(8, 136);
            this.addAuthor.Name = "addAuthor";
            this.addAuthor.Size = new System.Drawing.Size(224, 56);
            this.addAuthor.TabIndex = 6;
            // 
            // authorLabel
            // 
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(72, 16);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(144, 23);
            this.authorLabel.TabIndex = 0;
            this.authorLabel.Text = "+ Add Author";
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addAuthorButton.BackgroundImage")));
            this.addAuthorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addAuthorButton.Location = new System.Drawing.Point(0, 0);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(64, 56);
            this.addAuthorButton.TabIndex = 1;
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.Transparent;
            this.addUser.Controls.Add(this.addUserButton);
            this.addUser.Controls.Add(this.userLabel);
            this.addUser.Location = new System.Drawing.Point(8, 48);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(224, 56);
            this.addUser.TabIndex = 7;
            // 
            // addUserButton
            // 
            this.addUserButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addUserButton.BackgroundImage")));
            this.addUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addUserButton.Location = new System.Drawing.Point(0, 0);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(64, 56);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(72, 16);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(136, 23);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "+ Add User";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 568);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "Book Catalogue - Admin";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.listPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.addBookStore.ResumeLayout(false);
            this.addPublisher.ResumeLayout(false);
            this.addBook.ResumeLayout(false);
            this.addAuthor.ResumeLayout(false);
            this.addUser.ResumeLayout(false);
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

        
    
