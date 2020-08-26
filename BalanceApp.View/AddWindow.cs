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
        private List<Amount> balances;
        private readonly List<Category> categories;
        private readonly string nameOfBalance;
        private readonly string countOfBalance;
        public AddWindow(List<Amount> balances, List<Category> categories )
        {
            this.balances = balances;
            this.categories = categories;
            
            InitializeComponent();

            foreach(var category in categories)
            {
                categoryBox.Items.Add(category.Name);
            }
            stuffBox.Text = nameOfBalance = "Name of " + categories[0].Type.Substring(0, categories[0].Type.Length - 1);
            countBox.Text = countOfBalance = "Count of " + categories[0].Type.Substring(0, categories[0].Type.Length - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(stuffBox.Text != null)
            {
                var category = categories.SingleOrDefault(c => c.Name == categoryBox.Text);
                try
                {
                    var balance = new Amount(stuffBox.Text, Convert.ToDouble(countBox.Text), DateTime.Today,category);
                    balances.Insert(0, balance);
                }
                catch
                {
                    var balance = new Amount(stuffBox.Text, Convert.ToDouble(countBox.Text.Replace('.', ',')),DateTime.Today,category);
                    balances.Insert(0, balance);
                }
                this.Close();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        

        

        private void stuffBox_Leave(object sender, EventArgs e)
        {
            if (stuffBox.Text == "")
            {
                stuffBox.Text = nameOfBalance;
                stuffBox.ForeColor = Color.Gray;
            }
        }

        private void stuffBox_Enter(object sender, EventArgs e)
        {
            if (stuffBox.Text == nameOfBalance)
            {
                stuffBox.Text = "";
                stuffBox.ForeColor = Color.Black;
            }
        }

        

        private void countBox_Leave(object sender, EventArgs e)
        {
            if (countBox.Text == "")
            {
                countBox.Text = countOfBalance;
                countBox.ForeColor = Color.Gray;
            }
        }

        private bool nonNumberEntered = false;

        private void countBox_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    
                    if (e.KeyCode != Keys.Back)
                    {
                        
                        nonNumberEntered = true;
                    }
                }
            }
            
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void countBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void countBox_Enter(object sender, EventArgs e)
        {
            if (countBox.Text == countOfBalance)
            {
                countBox.Text = "";
                countBox.ForeColor = Color.Black;
            }
        }
    }
}
