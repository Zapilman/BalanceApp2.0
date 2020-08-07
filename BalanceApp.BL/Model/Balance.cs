using System;

namespace BalanceApp.BL.Model
{
    /// <summary>
    /// Balance.
    /// </summary>
    [Serializable]
    public class Balance
    {
        /// <summary>
        /// DateTime of the stuff registration.
        /// </summary>
        public DateTime dateTime { get; }
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Cost.
        /// </summary>
        public double Cost { get; }
        /// <summary>
        /// Category.
        /// </summary>
        public Category category { get; }
        /// <summary>
        /// To Create a new balance.
        /// </summary>
        /// <param name="name"> Name of something. </param>
        /// <param name="cost"> Cost of something. </param>

        public Balance(string name, double cost, DateTime dateTime, Category category)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name can not be a null or white space", nameof(name));
            }

            

            Name = name;
            this.dateTime = dateTime;
            this.category = category ?? throw new ArgumentNullException(nameof(category));
            Cost = Convert.ToDouble(cost);
        }

        public override string ToString()
        {
            return $"{Name}: {Cost} $ : {dateTime}";
        }


    }
}