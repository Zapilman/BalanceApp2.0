using BalanceApp.BL.Controller;
using BalanceApp.BL.Model;
using System.Linq;
using System.Windows.Forms;

namespace BalanceApp.View
{
    public partial class Categories : Form
    {
        private readonly User currentUser;
        CategoryController categoryController;

        public Categories(User user)
        {
            currentUser = user;
            
           
            InitializeComponent();
            FillCategoryNodes();
            Text = "Categories";
        }

        private void FillCategoryNodes()
        {
            categoryController = new CategoryController(currentUser);
            treeView1.Nodes.Clear();
            foreach (var category in categoryController.categories)
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
            using (var addCategory = new AddCategoryForm(currentUser))
            {
                addCategory.ShowDialog();
                FillCategoryNodes();
            }
        }

        private void removeLabel_Click(object sender, System.EventArgs e)
        {
            
            try
            {
                var generalCategoies = new GeneralCategoryList();
                var currentCategory = generalCategoies.GetGeneralList().SingleOrDefault(c => c.Name == treeView1.SelectedNode.Text);
                if(currentCategory != null)
                {
                    return;
                }
                else
                {
                    CategoryController removeCategoryController = new CategoryController(currentUser, treeView1.SelectedNode.Text);
                    treeView1.Nodes.Remove(treeView1.SelectedNode);
                }

                

            }
            catch
            {
                return;
            }
        }
    }
}
