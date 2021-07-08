
namespace BookStore
{
    partial class LoginFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrom));
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.serbianButton = new System.Windows.Forms.Button();
            this.englishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameText
            // 
            resources.ApplyResources(this.usernameText, "usernameText");
            this.usernameText.ForeColor = System.Drawing.Color.Gray;
            this.usernameText.Name = "usernameText";
            this.usernameText.Click += new System.EventHandler(this.usernameText_Click);
            this.usernameText.Leave += new System.EventHandler(this.usernameText_Leave);
            // 
            // passwordText
            // 
            resources.ApplyResources(this.passwordText, "passwordText");
            this.passwordText.ForeColor = System.Drawing.Color.Gray;
            this.passwordText.Name = "passwordText";
            this.passwordText.Enter += new System.EventHandler(this.passwordText_Enter);
            this.passwordText.Leave += new System.EventHandler(this.passwordText_Leave);
            // 
            // LogInButton
            // 
            resources.ApplyResources(this.LogInButton, "LogInButton");
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // serbianButton
            // 
            resources.ApplyResources(this.serbianButton, "serbianButton");
            this.serbianButton.Name = "serbianButton";
            this.serbianButton.UseVisualStyleBackColor = true;
            this.serbianButton.Click += new System.EventHandler(this.serbianButton_Click);
            // 
            // englishButton
            // 
            resources.ApplyResources(this.englishButton, "englishButton");
            this.englishButton.Name = "englishButton";
            this.englishButton.UseVisualStyleBackColor = true;
            this.englishButton.Click += new System.EventHandler(this.englishButton_Click_1);
            // 
            // LoginFrom
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.englishButton);
            this.Controls.Add(this.serbianButton);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Name = "LoginFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button serbianButton;
        public System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button englishButton;
    }
}

