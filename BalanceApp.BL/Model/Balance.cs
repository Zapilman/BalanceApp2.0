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
        public int Cost { get; }
        /// <summary>
        /// To Create a new balance.
        /// </summary>
        /// <param name="name"> Name of something. </param>
        /// <param name="cost"> Cost of something. </param>

        public Balance(string name, int cost)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name can not be a null or white space", nameof(name));
            }

            Name = name;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"{Name}:\t{Cost}";
        }


    }
}