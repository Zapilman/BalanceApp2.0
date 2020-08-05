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
        private readonly string name;
        public AddWindow(List<Balance> balances)
        {
            this.balances = balances;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(stuffBox.Text != null)
            {
                try
                {
                    var balance = new Balance(stuffBox.Text, Convert.ToDouble(countBox.Text));
                    balances.Insert(0, balance);
                }
                catch
                {
                    var balance = new Balance(stuffBox.Text, Convert.ToDouble(countBox.Text.Replace('.', ',')));
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
