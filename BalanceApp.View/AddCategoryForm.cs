﻿using BalanceApp.BL.Controller;
using BalanceApp.BL.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BalanceApp.View
{
    public partial class AddCategoryForm : Form
    {
        public  List<Category> categories { get; set; }
        private  User currentUser { get; }

        private string type { get; set; }
        public AddCategoryForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            ParentList.Click += (s, e) => { if(ParentList.Text == "Parent Category") { ParentList.Text = ""; } };
            ParentList.Leave += (s, e) => { if (ParentList.Text.Length < 1) { ParentList.Text = "Parent Category"; } };
            CategoryNameBox.Click += (s, e) => { if (CategoryNameBox.Text == "Category Name") { CategoryNameBox.Text = ""; } };
            CategoryNameBox.Leave += (s, e) => { if (CategoryNameBox.Text.Length < 1) { CategoryNameBox.Text = "Category Name"; } };
            var categoryController = new CategoryController(user);
            categories = categoryController.categories;
        }

        #region Events
        private void IncomeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(IncomeCheck.Checked == true)
            {
                ExpenseCheck.Checked = false;
            }
            if(IncomeCheck.Checked == false && ExpenseCheck.Checked == false)
            {
                IncomeCheck.Checked = true;
            }
            
        }

        private void ExpenseCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ExpenseCheck.Checked == true)
            {
                IncomeCheck.Checked = false;
            }
            if (ExpenseCheck.Checked == false && IncomeCheck.Checked == false)
            {
                ExpenseCheck.Checked = true;
            }
        }

        private void ParentList_Click(object sender, EventArgs e)
        {
            ParentList.Items.Clear();
            if(ExpenseCheck.Checked == true)
            {
                type = "Expenses";
                foreach (var category in categories)
                {
                    if (category.Parent == null && category.Type=="Expenses")
                    {
                        ParentList.Items.Add(category.Name);
                    }
                }
            }
            else
            {
                type = "Incomes";
                foreach (var category in categories)
                {
                    if (category.Parent == null && category.Type == "Incomes")
                    {
                        ParentList.Items.Add(category.Name);
                    }
                }
            }
        }
        #endregion

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(CategoryNameBox.Text))
            {
                throw new ArgumentNullException("category can not bea null", nameof(CategoryNameBox.Text));
            }
           
            if (ParentList.Text == "" || ParentList.Text == "Parent Category")
            {
                MessageBox.Show("You have to choose parent category");
                return;
            }
            var newCategory = new CategoryController(currentUser, CategoryNameBox.Text, type, ParentList.Text);
            this.Close();
        }
    }
}
