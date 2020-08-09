using BalanceApp.BL.Model;
using System.Collections.Generic;
using System.Linq;

namespace BalanceApp.BL.Controller
{
     public class CategoryController : ControllerBase
     {
        private readonly User currentUser;

        public List<Category> categories { get; }

        
        public CategoryController(User user)
        {
            currentUser = user ?? throw new System.ArgumentNullException(nameof(user));
            categories = GetAllCategories();
            Save();
            var generalcategories = new GeneralCategoryList();
            foreach (var item in generalcategories.GetGeneralList())
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
