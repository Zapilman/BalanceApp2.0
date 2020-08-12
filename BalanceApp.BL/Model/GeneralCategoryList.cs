

using System.Collections.Generic;

namespace BalanceApp.BL.Model
{

    public class GeneralCategoryList
    {
        private readonly List<Category> generalCategories = new List<Category>() { new Category(null,"Salary", "Incomes", null),
                                                                                 new Category(null,"Gifts","Expenses",null),
                                                                               new Category(null,"Codasd", "Incomes", "Salary"),
                                                                              new Category(null,"Suka","Expenses","Gifts")};


        public List<Category> GetGeneralList()
        {
            return generalCategories;
        }

    }
}
