using BalanceApp.BL.Model;
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
    public partial class Profile : Form
    {
        private readonly User currentuser;

        public Profile(User user)
        {
            currentuser = user;
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = currentuser.Name;
        }

        

        private void userNameLabel_Click(object sender, EventArgs e)
        {
            using(var myAccount = new MyAccount(currentuser))
            {
                this.Hide();
                myAccount.ShowDialog();
                Profile_Load(sender, e);
                this.Show();
            }
        }

        private void categoriesLabel_Click(object sender, EventArgs e)
        {
            var categories = new Categories(currentuser);
            categories.Show();
        }
    }
}
