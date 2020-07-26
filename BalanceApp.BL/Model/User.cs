using System;
using System.Collections.Generic;
using System.Text;

namespace BalanceApp.BL.Model
{
    /// <summary>
    /// User.
    /// </summary>
    [Serializable]
    public class User
    {
        #region Properties
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Birthday.
        /// </summary>
        public DateTime Birthday { get; }
        /// <summary>
        /// Balance.
        /// </summary>
        public Balance Balance { get; }
        /// <summary>
        /// Password.
        /// </summary>
        public string Password { get; }
        /// <summary>
        /// Login.
        /// </summary>
        public string Login { get; }

        /// <summary>
        /// To create a new user.
        /// </summary>
        /// <param name="name"> Name of user. </param>
        /// <param name="balance"> Balance of user. </param>
        /// <param name="birthday"> Birthday of user. </param>
        /// <param name="password"> Password of user. </param>
        /// <param name="login"> Login of user. </param>
        #endregion
        public User(string name,
                    Balance balance,
                    DateTime birthday,
                    string password,
                    string login)
        {
            #region Checking Arguments
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name can not be a null or white space", nameof(name));
            }

            if (balance is null)
            {
                throw new ArgumentNullException("Balance can not be a null", nameof(balance));
            }

            if (birthday < DateTime.Parse("01.01.1900") || birthday > DateTime.Now)
            {
                throw new ArgumentException("invalid day of birth", nameof(birthday));
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password can not be a null or white space", nameof(password));
            }

            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentException("Login can not be a null or white space", nameof(login));
            }
            #endregion

            Name = name;
            Balance = balance;
            Birthday = birthday;
            Password = password;
            Login = login;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
