using BalanceApp.BL.Controller;
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
    public partial class App : Form
    {
        private readonly User currentUser;
        public App(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void App_Load(object sender, EventArgs e)
        {
            RestartData();
        }

        private List<Balance> GetExpensesList()
        {
            if (currentUser.Expenses != null)
            {
                return currentUser.Expenses;
            }
            else
            {
                return new List<Balance>();
            }
        }

        private void ExpAddButton_Click(object sender, EventArgs e)
        {
            var stuff = new Balance("kek", 100);
            currentUser.Expenses.Insert(0, stuff);
            RestartData();
            
        }

        private void RestartData()
        {
            Expenses.Items.Clear();
            var items = GetExpensesList();
            foreach (var item in items)
            {
                var row = new string[] { item.Name, item.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = item;
                Expenses.Items.Add(lvi);
                
            }
        }

        private void App_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: Дописать сохранение списков для пользователя.
            //var controller = new UserController("e");
        }
    }
}
