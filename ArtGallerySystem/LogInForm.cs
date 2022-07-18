using System;
using System.Windows.Forms;


namespace ArtGallerySystem
{
    public partial class LogInForm : Form
    {

        public LogInForm()
        {
            InitializeComponent();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            String superUser = "admin", superPass = "helloWorld"; //Info for admin access (superUser should be lowercase for easy comparing of strings)
            String username = userTBox.Text, pass = passTBox.Text; //Get text from textboxes

            String usernameConverted = username.ToLower(); //Convert String to lowercase

            if (String.Equals(usernameConverted, superUser) && String.Equals(pass, superPass))
            {
                //Opens form1
                this.Hide();
                var form1 = new Form1();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }

            else
            {
                MessageBox.Show("Incorrect Username or Password.");
                passTBox.Clear();
                passTBox.Focus();
            }
        }

        private void passTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true; //Remove sound when pressing enter
                String superUser = "admin", superPass = "helloWorld"; //Info for admin access (superUser should be lowercase for easy comparing of strings)
                String username = userTBox.Text, pass = passTBox.Text; //Get text from textboxes

                String usernameConverted = username.ToLower(); //Convert String to lowercase

                if (String.Equals(usernameConverted, superUser) && String.Equals(pass, superPass))
                {
                    //Opens form1
                    this.Hide();
                    var form1 = new Form1();
                    form1.Closed += (s, args) => this.Close();
                    form1.Show();
                }

                else
                {
                    MessageBox.Show("Incorrect Username or Password.");
                    passTBox.Clear();
                }
            }
        }

        private void LogInForm_Activated(object sender, EventArgs e)
        {
            userTBox.Focus();
            passTBox.UseSystemPasswordChar = true;
        }
    }
}

