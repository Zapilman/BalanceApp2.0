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
        /// <summary>
        /// Current User.
        /// </summary>
        private readonly User currentUser;
        /// <summary>
        /// Own user profile
        /// </summary>
        /// <param name="user"> current user. </param>
        public App(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void App_Load(object sender, EventArgs e)
        {
            RestartData(GetBalanceList(currentUser.Expenses), ExpensesView);
            RestartData(GetBalanceList(currentUser.Incomes), IncomesView);
        }
        /// <summary>
        /// Getting list of incomes or expenses.
        /// </summary>
        /// <param name="balance"> balance list. </param>
        /// <returns></returns>
        private List<Balance> GetBalanceList(List<Balance> balance)
        {
            if (balance != null)
            {
                return balance;
            }
            else
            {
                return new List<Balance>();
            }
        }

       
        /// <summary>
        ///  Add new expenses to ExpensesView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpAddButton_Click(object sender, EventArgs e)
        {
            var stuff = new Balance("kek", 100);
            currentUser.Expenses.Insert(0, stuff);
            RestartData(GetBalanceList(currentUser.Expenses),ExpensesView);
            
        }


        /// <summary>
        /// Refresh View data of interface.
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="listView"></param>
        private void RestartData(List<Balance> balance,ListView listView)
        {
            listView.Items.Clear();
            
            var items = GetBalanceList(balance);
            foreach (var item in items)
            {
                var row = new string[] { item.Name, item.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = item;
                listView.Items.Add(lvi);
                
            }
        }
        /// <summary>
        /// Add new incomes to IncomesView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IncAddButton_Click(object sender, EventArgs e)
        {
            var stuff = new Balance("kek", 100);
            currentUser.Incomes.Insert(0, stuff);
            RestartData(GetBalanceList(currentUser.Incomes), IncomesView);
        }
    }
}
