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
        /// Name.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Cost.
        /// </summary>
        public double Cost { get; }
        /// <summary>
        /// To Create a new balance.
        /// </summary>
        /// <param name="name"> Name of something. </param>
        /// <param name="cost"> Cost of something. </param>

        public Balance(string name, double cost)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name can not be a null or white space", nameof(name));
            }

            

            Name = name;
            Cost = Convert.ToDouble(cost);
        }

        public override string ToString()
        {
            return $"{Cost}";
        }


    }
}