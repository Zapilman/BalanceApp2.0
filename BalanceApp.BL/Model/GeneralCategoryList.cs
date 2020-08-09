

using System.Collections.Generic;

namespace BalanceApp.BL.Model
{

    public class GeneralCategoryList
    {
        private readonly List<Category> generalCategories = new List<Category>() { new Category("Salary", "Incomes", null),
                                                                                 new Category("Gifts","Expenses",null),
                                                                               new Category("Codasd", "Incomes", "Salary")};


        public List<Category> GetGeneralList()
        {
            return generalCategories;
        }

    }
}
