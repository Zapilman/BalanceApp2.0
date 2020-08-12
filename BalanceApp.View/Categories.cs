﻿using BalanceApp.BL.Controller;
using BalanceApp.BL.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BalanceApp.View
{
    public partial class Categories : Form
    {
        private readonly User currentUser;
        public Categories(User user)
        {
            
            currentUser = user;
            InitializeComponent();
            FillCategoryNodes();
        }

        private void FillCategoryNodes()
        {
            treeView1.Nodes.Clear();
            var categoryController = new CategoryController(currentUser);
            foreach (var category in categoryController.categories)
            {
                TreeNode categoryNode = new TreeNode(Text = category.Name);
                if (category.Parent != null)
                {
                    continue;
                }
                FillTreeNode(categoryNode, categoryController);
                treeView1.Nodes.Add(categoryNode);
            }
        }

        private void FillTreeNode(TreeNode treeNode, CategoryController categoryController)
        {
            foreach(var category in categoryController.categories)
            {
                if(category.Parent == treeNode.Text)
                {
                    TreeNode node = new TreeNode(Text = category.Name);
                    treeNode.Nodes.Add(node);
                }
            }
        }

        private void AddCategoryLabel_Click(object sender, System.EventArgs e)
        {
            
            using(var addCategory = new AddCategoryForm(currentUser))
            {
                addCategory.ShowDialog();
                FillCategoryNodes();
            }
            
        }
    }
}
