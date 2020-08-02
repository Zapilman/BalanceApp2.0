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
            ExpAddButton.Click += (s, e) => { var balance = new Balance("kek", 103.3); AddButton(ExpAddButton, balance); };
            IncAddButton.Click += (s, e) => { var balance = new Balance("kek", 103.3); AddButton(IncAddButton, balance); };
            IncRemButton.Click += (s, e) => { RemoveButton(IncRemButton, IncomesView, currentUser.Incomes, ShowIncomes,"Incomes"); };
            ExpRemButton.Click += (s, e) => { RemoveButton(ExpRemButton, ExpensesView, currentUser.Expenses, ShowExpenses, "Expenses"); };
            currentUser = user;
        }

        /// <summary>
        /// App loading.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void App_Load(object sender, EventArgs e)
        {
            RefreshData(GetBalanceList(currentUser.Expenses), ExpensesView);
            RefreshData(GetBalanceList(currentUser.Incomes), IncomesView);
            ShowIncomes.Text += GetCountOf(currentUser.Incomes);
            ShowExpenses.Text += GetCountOf(currentUser.Expenses);
            ShowResult.Text += GetCountOf(currentUser.Incomes) - GetCountOf(currentUser.Expenses);
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
        /// Refresh View data of interface.
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="listView"></param>
        private void RefreshData(List<Balance> balance,ListView listView)
        {
            listView.Items.Clear();
            
            var items = GetBalanceList(balance);
            foreach (var item in items)
            {
                var row = new string[] { item.Name, item.ToString()+"$" };//Подогнать валюту под локализацию. 
                var lvi = new ListViewItem(row);
                lvi.Tag = item;
                listView.Items.Add(lvi);
                // TODO: Подумать как без перезалива данный обновлять таблицы(найти способ добавлять и удалять балансы)
            }

        }

        
        /// <summary>
        /// General method of AddButtons.
        /// </summary>
        /// <param name="button"></param>
        /// <param name="stuff"></param>
        private void AddButton(Button button,Balance stuff)
        {
            if(button.Name == "ExpAddButton")
            {
                currentUser.Expenses.Insert(0, stuff);
                RefreshData(GetBalanceList(currentUser.Expenses), ExpensesView);
                ShowExpenses.Text = "Expenses: " + Convert.ToString(GetCountOf(currentUser.Expenses));
            }
            else
            {
                currentUser.Incomes.Insert(0, stuff);
                RefreshData(GetBalanceList(currentUser.Incomes), IncomesView);
                ShowIncomes.Text = "Incomes: " + Convert.ToString(GetCountOf(currentUser.Incomes));
            }

            ShowResult.Text = "Result: " + Convert.ToString(GetCountOf(currentUser.Incomes) - GetCountOf(currentUser.Expenses));
        }
        
        /// <summary>
        /// General method of RemoveButtons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton(Button button, 
                                  ListView listView,
                                  List<Balance> balances,
                                  Label label,
                                  string balance)
        {
            try
            {
                var stuff = listView.SelectedItems[0];
                balances.RemoveAt(stuff.Index);
                listView.Items.Remove(stuff);
            }
            catch 
            {
                return;
            }
            
            RefreshData(GetBalanceList(balances), listView);
            ChangeText(label, balances, balance);
        }

        private void ChangeText(Label label,List<Balance> balances, string balance)
        {
            label.Text = $"{balance}: " + Convert.ToString(GetCountOf(balances));
            ShowResult.Text = "Result: " + Convert.ToString(GetCountOf(currentUser.Incomes) - GetCountOf(currentUser.Expenses));
        }

        

        /// <summary>
        /// Getting full count of things.
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        private double GetCountOf(List<Balance> balance)
        {
            double sumOf = 0.0;
            foreach (var item in balance)
            {
                sumOf += item.Cost;
            }

            return sumOf;


        }
    }
}
