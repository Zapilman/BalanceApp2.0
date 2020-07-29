using BalanceApp.BL.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalanceApp.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        /// <summary>
        /// Reason of incorrect data.
        /// </summary>
        /// <param name="reason"> Name of reason. </param>
        private void Reason(string reason, UserController userController)
        {
            

            if (reason != "Nothing")
            {
                warning_alarm.Text = $"You entered an incorrect {reason}";
                goToRegistration.Visible = true;
            }
            else
            {

                App application = new App(userController.CurrentUser);
                this.Hide();
                application.ShowDialog();
                this.Close();
            }
            
        }
        /// <summary>
        /// Intializing of user, saving new data of user after closing an app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            var userController = new UserController(PasswordBox.Text,LoginBox.Text);
            Reason(userController.WhatIsWrong,userController);
            userController.Save();  //Saving again after closing an app to recorder new userdata,
                                    //which has been created in this app.

        }
        /// <summary>
        /// Move to registration form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToRegistration_Click(object sender, EventArgs e)
        {
            using (Registration registration = new Registration())
            {
                this.Hide();

                registration.ShowDialog();
                PasswordBox.Text = "";
                LoginBox.Text = "";
                this.Show();
            }
        }
    }
}
