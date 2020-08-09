using BalanceApp.BL.Controller;
using BalanceApp.BL.Model;
using System.Windows.Forms;

namespace BalanceApp.View
{
    public partial class Categories : Form
    {
        private readonly User currentuser;
        public Categories(User user)
        {
            currentuser = user;
            InitializeComponent();
            FillCategoryNodes();
        }

        private void FillCategoryNodes()
        {
            var categoryController = new CategoryController(currentuser);
            foreach(var category in categoryController.categories)
            {
                TreeNode categoryNode = new TreeNode(Text = category.Name);
                if (category.Parent != null)
                {
                    continue;
                }
                FillTreeNode(categoryNode);
                treeView1.Nodes.Add(categoryNode);
            }
        }

        private void FillTreeNode(TreeNode treeNode)
        {
            var categoryController = new CategoryController(currentuser);
            foreach(var category in categoryController.categories)
            {
                if(category.Parent == treeNode.Text)
                {
                    TreeNode node = new TreeNode(Text = category.Name);
                    treeNode.Nodes.Add(node);
                }
            }
        }
    }
}
