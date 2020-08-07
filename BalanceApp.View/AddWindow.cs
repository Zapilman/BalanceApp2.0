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
    public partial class AddWindow : Form
    {
        private List<Balance> balances;
        private readonly List<Category> categories;
        public AddWindow(List<Balance> balances, List<Category> categories )
        {
            this.balances = balances;
            this.categories = categories;
            //foreach(var item in categories)
            //{
            //    categoryBox.Items.Insert(0, item);
            //}
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(stuffBox.Text != null)
            {
                var category = categories.SingleOrDefault(c => c.Name == categoryBox.Text);
                try
                {
                    var balance = new Balance(stuffBox.Text, Convert.ToDouble(countBox.Text), DateTime.Today,category);
                    balances.Insert(0, balance);
                }
                catch
                {
                    var balance = new Balance(stuffBox.Text, Convert.ToDouble(countBox.Text.Replace('.', ',')),DateTime.Today,category);
                    balances.Insert(0, balance);
                }
                this.Close();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}
