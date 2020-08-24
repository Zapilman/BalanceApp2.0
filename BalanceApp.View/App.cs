using BalanceApp.BL.Controller;
using BalanceApp.BL.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BalanceApp.View
{
    public partial class App : Form
    {
        /// <summary>
        /// Current User.
        /// </summary>
        private readonly User currentUser;

        private double result = 0.0;

        private Balance oldBalance;
        /// <summary>
        /// Own user profile
        /// </summary>
        /// <param name="user"> current user. </param>
        public App(User user)
        {
            InitializeComponent();
            ExpAddButton.Click += (s, e) => { AddButton(ExpAddButton); };
            IncAddButton.Click += (s, e) => { AddButton(IncAddButton); };
            IncClearButton.Click += (s, e) => { ClearButton(IncomesView, currentUser.Incomes, ShowIncomes, "Incomes"); };
            ExpClearButton.Click += (s, e) => { ClearButton(ExpensesView, currentUser.Expenses, ShowExpenses, "Expenses"); };
            currentUser = user;
            IncomesView.ContextMenuStrip = contextMenuStrip1;
            ExpensesView.ContextMenuStrip = contextMenuStrip2;
            
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
            ShowExpenses.Text = "Expenses: " + Convert.ToString(GetCountOf(currentUser.Expenses));
            ChangeText(ShowIncomes, currentUser.Incomes, "Incomes");
            
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

       
        // TODO: Сделать разделение на доходы и расходы в зависимости от выбранной таблицы при создании AddWindow.


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
                var row = new string[] { item.Name, Convert.ToString(item.Cost) +"$",item.dateTime.ToShortDateString(), item.category.Name };//Подогнать валюту под локализацию. 
                var lvi = new ListViewItem(row)
                {
                    Tag = item
                };
                lvi.ToolTipText = lvi.Text.ToString();
                listView.Items.Add(lvi);
            }

        }

        
        /// <summary>
        /// General method of AddButtons.
        /// </summary>
        /// <param name="button"></param>
        /// <param name="stuff"></param>
        private void AddButton(Button button)
        {
            if(button.Name == "ExpAddButton")
            {

                AddWindow(currentUser.Expenses,"Expenses");
                RefreshData(GetBalanceList(currentUser.Expenses), ExpensesView);
                ChangeText(ShowExpenses, currentUser.Expenses, "Expenses");
            }
            else
            {
                AddWindow(currentUser.Incomes,"Incomes");
                RefreshData(GetBalanceList(currentUser.Incomes), IncomesView);
                ChangeText(ShowIncomes, currentUser.Incomes, "Incomes");
            }

            
        }
        
        /// <summary>
        /// General method of RemoveButtons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       

        private void AddWindow(List<Balance> balances,string type)
        {
            var categoryController = new CategoryController(currentUser);
            var newcontroller = new List<Category>();
            foreach (var category in categoryController.categories)
            {
                if (category.Type == type)
                {
                    newcontroller.Add(category);
                }
            }
            using (AddWindow addWindow = new AddWindow(balances, newcontroller))
            {
                addWindow.ShowDialog();
            }
        }


        private void ClearButton(ListView listView,
                                List<Balance> balances,
                                Label label,
                                string balance )
        {
            listView.Items.Clear(); 
            balances.Clear();
            RefreshData(balances, listView);
            ChangeText(label, balances, balance);
        }

        private void ChangeText(Label label,List<Balance> balances, string balance)
        {
            label.Text = $"{balance}: " + Convert.ToString(GetCountOf(balances));
            result = GetCountOf(currentUser.Incomes) - GetCountOf(currentUser.Expenses);
            ShowResult.Text = "Result: " + Convert.ToString(result);
            if (result < 0.0)
            {
                ShowResult.ForeColor = Color.Red;
            }
            else if (result > 0.0)
            {
                ShowResult.ForeColor = Color.Green;
            }
            else
            {
                ShowResult.ForeColor = Color.Black;

            }
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

        private void Profile_Click(object sender, EventArgs e)
        {
            using (var profile = new Profile(currentUser))
            {
                profile.ShowDialog();
                App_Load(sender, e);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Balance currentIncome = currentUser.Incomes.SingleOrDefault(b => b.Name == IncomesView.SelectedItems[0].Text);
                IncomesView.Items.Remove(IncomesView.SelectedItems[0]);
                currentUser.Incomes.Remove(currentIncome);
            }
            catch
            {
                return;
            }
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                Balance currentExpense = currentUser.Expenses.SingleOrDefault(b => b.Name == ExpensesView.SelectedItems[0].Text);
                ExpensesView.Items.Remove(ExpensesView.SelectedItems[0]);
                currentUser.Expenses.Remove(currentExpense);
            }
            catch
            {
                return;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            oldBalance = currentUser.Incomes.SingleOrDefault(b => b.Name == IncomesView.SelectedItems[0].Text);
            if (IncomesView.SelectedItems[0] != null)
            {
                IncomesView.LabelEdit = true;
                IncomesView.SelectedItems[0].BeginEdit();
            }

        }

        private void IncomesView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(e.Label))
            {
                MessageBox.Show("Please enter a valid value.");
                return;
            }
            e.CancelEdit = true;
            IncomesView.LabelEdit = false;
            oldBalance.Name = e.Label;
            RefreshData(currentUser.Incomes, IncomesView);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                oldBalance = currentUser.Expenses.SingleOrDefault(b => b.Name == ExpensesView.SelectedItems[0].Text);
                if (ExpensesView.SelectedItems[0] != null)
                {
                    ExpensesView.LabelEdit = true;
                    ExpensesView.SelectedItems[0].BeginEdit();
                }
            }
            catch
            {
                return;
            }
            
        }

        private void ExpensesView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.Label))
            {
                MessageBox.Show("Please enter a valid value.");
                return;
            }
            e.CancelEdit = true;
            ExpensesView.LabelEdit = false;
            oldBalance.Name = e.Label;
            RefreshData(currentUser.Expenses, ExpensesView);
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(IncomesView.SelectedItems[0].Text);
            }
            catch
            {
                return;
            }
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(IncomesView.SelectedItems[0].Tag.ToString());
            }
            catch
            {
                return;
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var text = Clipboard.GetText();
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Please enter a valid value.");
                return;
            }
            try
            {
                oldBalance = currentUser.Incomes.SingleOrDefault(b => b.Name == IncomesView.SelectedItems[0].Text);
                oldBalance.Name = text;
                RefreshData(currentUser.Incomes, IncomesView);
            }
            catch
            {
                return;
            }
        }

        private void nameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(ExpensesView.SelectedItems[0].Text);
            }
            catch
            {
                return;
            }
        }

        private void allToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(ExpensesView.SelectedItems[0].Tag.ToString());
            }
            catch
            {
                return;
            }
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var text = Clipboard.GetText();
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Please enter a valid value.");
                return;
            }
            try
            {
                oldBalance = currentUser.Expenses.SingleOrDefault(b => b.Name == ExpensesView.SelectedItems[0].Text);
                oldBalance.Name = text;
                RefreshData(currentUser.Expenses, ExpensesView);
            }
            catch
            {
                return;
            }
        }

        int quantityInc = 0;
        int quantityExp = 0;
        private void IncomesView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            quantityInc++;
            if(quantityInc % 2 == 0)
            {
                if (e.Column == 1)
                {
                    IncomesView.ListViewItemSorter = new ListViewColumnComparer(e.Column);

                }
            }
            else
            {
                if (e.Column == 1)
                {
                    IncomesView.ListViewItemSorter = new ReverseColumnComparer(e.Column);

                }
            }
            
        }

        private void ExpensesView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            quantityExp++;
            if (quantityExp % 2 == 0)
            {
                if (e.Column == 1)
                {
                    ExpensesView.ListViewItemSorter = new ListViewColumnComparer(e.Column);

                }
            }
            else
            {
                if (e.Column == 1)
                {
                    ExpensesView.ListViewItemSorter = new ReverseColumnComparer(e.Column);

                }
            }
        }
    }
}
