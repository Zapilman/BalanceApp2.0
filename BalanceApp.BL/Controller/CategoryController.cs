using BalanceApp.BL.Model;
using System.Collections.Generic;

namespace BalanceApp.BL.Controller
{
     public class CategoryController : ControllerBase
     {
        private readonly User currentUser;

        public List<Category> categories { get; }

        private readonly List<Category> generalCategories = new List<Category>() { new Category("Salary", "Incomes", null),
                                                                                 new Category("Gifts","Expenses",null)};
        public CategoryController(User user)
        {
            currentUser = user ?? throw new System.ArgumentNullException(nameof(user));
            categories = GetAllCategories();
            
            Save();
            foreach (var item in generalCategories)
            {
                categories.Insert(0, item);
            }
        }


        

        private List<Category> GetAllCategories()
        {
            return Load<Category>() ?? new List<Category>();
        }

        private void Save()
        {
            Save(categories);
        }

        

     }
}
