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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void ButtonReg_Click(object sender, EventArgs e)
        {
            var userController = new UserController(NameBox.Text,
                                                dateTimePicker.Value,
                                                PassBox.Text,
                                                LogBox.Text);

            this.Close();
        }
    }
}
