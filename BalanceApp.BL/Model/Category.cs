using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BalanceApp.BL.Model
{
    [Serializable]
     public class Category
     {
        /// <summary>
        /// Name of category.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Type of category: Expense or Income.
        /// </summary>
        public string Type { get; set;}
        /// <summary>
        /// Parent of category.
        /// </summary>
        public string Parent { get; set; }

        public User Owner { get; }
        
        /// <summary>
        /// To create a new category.
        /// </summary>
        /// <param name="name"> category name. </param>
        /// <param name="type"> category type. </param>
        /// <param name="parent"> category parent. </param>
        public Category(User user, string name, string type, string parent)
        {
            
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("message", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(type))
            {
                throw new ArgumentException("message", nameof(type));
            }
            
            Name = name;
            Type = type;
            Parent = parent;
            Owner = user;
        }

        

     }
}
