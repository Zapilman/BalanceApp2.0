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
            var categoryController = new CategoryController(currentUser);
            currentUser = user;
            InitializeComponent();
            FillCategoryNodes();
        }

        private void FillCategoryNodes()
        {
            treeView1.Nodes.Clear();
            
            foreach(var category in categories)
            {
                TreeNode categoryNode = new TreeNode(Text = category.Name);
                if (category.Parent != null)
                {
                    continue;
                }
                FillTreeNode(categoryNode,categories);
                treeView1.Nodes.Add(categoryNode);
            }
        }

        private void FillTreeNode(TreeNode treeNode, List<Category> categories)
        {
            foreach(var category in categories)
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
                FillCategoryNodes(addCategory.categories);
            }
        }
    }
}
