using BalanceApp.BL.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BalanceApp.View
{
    public partial class MyAccount : Form
    {
        private User currentUser;
        public MyAccount(User user)
        {
            currentUser = user;
            InitializeComponent();

           
            ChangeNameButton.Click += (s, e) =>
            {
                currentUser.Name = newNameBox.Text;
                MyAccount_Load(s, e);
                newNameBox.Text = "New username...";
            };

            newNameBox.Click += (s, e) => { newNameBox.Text = ""; };
            oldPassBox.Click += (s, e) => { oldPassBox.Text = ""; oldPassBox.UseSystemPasswordChar = true; };
            newPassBox.Click += (s, e) => { newPassBox.Text = ""; newPassBox.UseSystemPasswordChar = true; };


        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = currentUser.Name;
        }

        private void newNameBox_TextChanged(object sender, EventArgs e)
        {
            if(newNameBox.Text.Length > 0)
            {
                ChangeNameButton.Enabled = true;
                ChangeNameButton.BackColor = Color.Green;
            }
            else
            {
                ChangeNameButton.Enabled = false;
                ChangeNameButton.BackColor = Color.Red;
            }
        }

        private void ChangePassButton_Click(object sender, EventArgs e)
        {
            if(oldPassBox.Text != currentUser.Password)
            {
                succsesLabel.Text = "";
                warningLabel.Text = "It's not a currency password.";
            }
            else
            {
                warningLabel.Text = "";
                currentUser.Password = newPassBox.Text;
                oldPassBox.UseSystemPasswordChar = false;
                newPassBox.UseSystemPasswordChar = false;
                oldPassBox.Text = "Old password...";
                newPassBox.Text = "New password...";
                succsesLabel.Text = "Password has been succsessfully changed !";


            }
        }

        private void changeNameLabel_Click(object sender, EventArgs e)
        {
            if(newNameBox.Visible == false)
            {
                newNameBox.Visible = ChangeNameButton.Visible = true; 
            }
            else
            {
                newNameBox.Visible = ChangeNameButton.Visible = false;
            }

        }

        private void ChangePassLabel_Click(object sender, EventArgs e)
        {
            if(oldPassBox.Visible == false)
            {
                oldPassBox.Visible = newPassBox.Visible = ChangePassButton.Visible =  true;
            }
            else
            {
                oldPassBox.Visible = newPassBox.Visible = ChangePassButton.Visible = false;
            }
        }
    }
}
