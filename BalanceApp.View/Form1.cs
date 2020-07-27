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
        private void Reason(string reason)
        {
            

            if (reason != "Nothing")
            {
                warning_alarm.Text = $"You entered an incorrect {reason}";
                goToRegistration.Visible = true;
            }
            else
            {
                using(App application = new App())
                {
                    application.ShowDialog();
                }
                
            }
            
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            var userController = new UserController(PasswordBox.Text,LoginBox.Text);
            Reason(userController.WhatIsWrong);
        }

        private void GoToRegistration_Click(object sender, EventArgs e)
        {
            using (Registration registration = new Registration())
            {


                registration.ShowDialog();
            }
        }
    }
}
