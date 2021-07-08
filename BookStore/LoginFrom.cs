using BookStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
            
           // ChangeLanguage("sr");
            
            
        }
        int lan = 0;
     

        private void usernameText_Leave(object sender, EventArgs e)
        {
            if (usernameText.Text == "" && lan!=1)
            {
                usernameText.Text = "Korisnicko ime";
                
                usernameText.ForeColor = Color.Gray;
            }
            else
            {
                if (usernameText.Text=="")
                {
                    lan = 0;
                    usernameText.Text = "Username";

                    usernameText.ForeColor = Color.Gray;
                }
            }
        }
      
        private void passwordText_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("vsav");
            if (passwordText.Text == "Password") lan = 1;

            if(passwordText.Text =="Lozinka"|| passwordText.Text=="Password")
            {
                passwordText.Text = "";
                passwordText.ForeColor = Color.Black;
            }
        }

        private void passwordText_Leave(object sender, EventArgs e)
        {
            if (passwordText.Text == "" && lan!=1)
            {
                passwordText.Text = "Lozinka";
                passwordText.ForeColor = Color.Gray;
            }
            else
            {
                if (passwordText.Text == "")
                {
                    lan = 0;
                    passwordText.Text = "Password";

                    passwordText.ForeColor = Color.Gray;
                }
            }

        }


        private void serbianButton_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
            { MessageBox.Show("Aplikacija je vec na srpskom jeziku!"); }
            else
            {
                var changeLanguage = new ChangeLanguage();
                changeLanguage.UpdateConfig("language", "sr-Latn");
                Application.Restart();
            }


        }

        /*private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }*/

       /* private void englishButton_Click(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            changeLanguage.UpdateConfig("language", "en");
            LoginFrom_Load(sender, e);
        }*/

        public string GetMD5(string text) //hesiranje lozinke
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("x2"));
            }
            return str.ToString();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (usernameText.Text == "" || passwordText.Text == "" || passwordText.ForeColor == Color.Gray || usernameText.ForeColor == Color.Gray)
 
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                {
                    MessageBox.Show("Trebate popuniti korisničko ime ili lozinku!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ActiveControl = this.passwordText;
                    ActiveControl = this.usernameText;
                }
                else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                {
                    MessageBox.Show("You should enter password and username!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ActiveControl = this.passwordText;
                    ActiveControl = this.usernameText;
                }
            } 
            else
            {
                string userName = usernameText.Text;
                string hashPassw = passwordText.Text;



                if (UserDAO.Check_Username(userName) == true)
                {
                    if (UserDAO.Check_user(userName, hashPassw) == true)
                    {
                        MessageBox.Show(userName);
                        Int32 admin = UserDAO.Check_Role(userName, hashPassw);
                        Console.WriteLine(admin);
                        if (admin == 1)
                        {

                            // Form3 f3 = new Form3(1, userName);
                            this.Hide();
                            AdminForm f3 = new AdminForm(1, userName);
                            f3.ShowDialog();
                            Application.Exit();
                        //    this.Close();
                        //    this.usernameText.Text = "";
                        //    this.passwordText.Text = "";
                            // ActiveControl = this.usernameText;

                            //this.Show();


                        }
                        else if (admin == 2)
                        {

                            int i = BookStoreHasUserDAO.getBookStoreID(UserDAO.getByID(UserDAO.getID(userName)));
                            this.Hide();
                            UserForm f2 = new UserForm(i);

                            f2.ShowDialog();
                            Application.Exit();
                            /*this.passwordText.Text = "";
                            this.usernameText.Text = "";
                            ActiveControl = this.usernameText;
                            this.Show();*/

                        }

                    }
                    else
                    {
                        if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                        { MessageBox.Show("Neispravna lozinka"); }
                        else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                            MessageBox.Show("Incorrect password");
                        this.passwordText.Text = "";
                        this.usernameText.Text = "";
                        ActiveControl = this.passwordText;
                        ActiveControl = this.usernameText;
                        this.Show();
                    }



                }


                else
                {
                    if (Thread.CurrentThread.CurrentCulture.Name == "sr-Latn")
                    { MessageBox.Show("Niste registrovani.\r\n Upravo sada imate profil i možete pristupiti"); }
                    else if (Thread.CurrentThread.CurrentCulture.Name == "en")
                        MessageBox.Show("You are not registered.\r\n Now, you will have your account");
                    User korisnik = new User(userName, hashPassw, 2);
                    UserDAO.Insert(korisnik);

                    int rand = BookStoreDAO.RandomNumber(1, 3);
                    BookStoreHasUserDAO.Insert(BookStoreDAO.getByID(rand), korisnik);

                    int i = BookStoreHasUserDAO.getBookStoreID(UserDAO.getByID(UserDAO.getID(userName)));
                    this.Hide();
                    UserForm f = new UserForm(i);

                    f.ShowDialog();
                    Application.Exit();
                    /*this.passwordText.Text = "";
                    this.usernameText.Text = "";
                    ActiveControl = this.usernameText;
                    this.Show();*/
                }
            }
            
        }


        private void englishButton_Click_1(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == "en")
            { MessageBox.Show("You application is already in english!"); }
            else
            {
                var changeLanguage = new ChangeLanguage();
                changeLanguage.UpdateConfig("language", "en");
                Application.Restart();
            }
        }

        private void LoginFrom_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void usernameText_Click(object sender, EventArgs e)
        {
           
            if (usernameText.Text == "Username") lan = 1;

            if (usernameText.Text == "Korisnicko ime" || usernameText.Text == "Username")
            {
                usernameText.Text = "";
                usernameText.ForeColor = Color.Black;
            }
        }
    }
}
