

using System.Collections.Generic;

namespace BalanceApp.BL.Model
{

    public class GeneralCategoryList
    {
        private readonly Category[] generalCategories = new[] {new Category(null,"Salary", "Incomes", null),
                                                                                 new Category(null,"Gifts","Expenses",null),
                                                                               new Category(null,"Codasd", "Incomes", "Salary"),
                                                                              new Category(null,"sdwww","Expenses","Gifts")};


        public Category[] GetGeneralList()
        {
            return generalCategories;
        }

    }
}
