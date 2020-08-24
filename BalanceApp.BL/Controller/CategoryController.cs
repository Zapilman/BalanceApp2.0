using BalanceApp.BL.Model;
using System.Collections.Generic;
using System.Linq;

namespace BalanceApp.BL.Controller
{
     public class CategoryController : ControllerBase
     {
        List<Category> correctCategories = new List<Category>() { };
        public List<Category> categories { get; }

        public Category currentCategory { get; }

        public CategoryController(User user)
        {
            foreach(var category in GetCategories())
            {
                if (category.Owner.Name == user.Name)
                {
                    correctCategories.Add(category);
                }
            }

            categories = correctCategories;


            var generalCategories = new GeneralCategoryList();
            foreach (var category in generalCategories.GetGeneralList())
            {
                categories.Add(category);
            }
        }

        public CategoryController(User user, string name, string type, string parent)
        {
            categories = GetCategories();
            
            currentCategory = categories.SingleOrDefault(c => c.Name == name);
            if(currentCategory != null)
            {
                return;
            }
            else
            {
                var category = new Category(user, name, type, parent);
                categories.Add(category);
                Save();
            }
        }

        public CategoryController(User user,string name)
        {
            categories = GetCategories();
            currentCategory = categories.SingleOrDefault(c => c.Owner.Name == user.Name && c.Name == name );
            if(currentCategory != null)
            {

                RemoveCategory(categories, currentCategory);
                Save();
            }
        }
        

        private void RemoveCategory(List<Category> categories, Category category)
        {
            Category _category;
            int length = categories.Count;
            for(int i = 0; i < length; i++)
            {
                _category = categories.SingleOrDefault(c => c.Parent == category.Name);
                if(_category != null)
                {
                    RemoveCategory(categories, _category);

                }
            }

            

            categories.Remove(category);
        }


        private void Save()
        {
            Save(categories);
        }

        private List<Category> GetCategories()
        {
           return Load<Category>() ?? new List<Category>();
        }
        
     }
}
