﻿using System;
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
        public int Id { get; set; }

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
        /// List of expenses.
        /// </summary>
        public List<Balance> Expenses { get; set; }
        /// <summary>
        /// List of incomes.
        /// </summary>
        public List<Balance> Incomes { get; set; }
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
                    DateTime birthday,
                    string password,
                    string login)
        {
            #region Checking Arguments
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name can not be a null or white space", nameof(name));
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
            Birthday = birthday;
            Password = password;
            Login = login;
            Expenses = new List<Balance>();
            Incomes = new List<Balance>();
        }
        /// <summary>
        /// to Create new User with one name.
        /// </summary>
        /// <param name="name"> username. </param>
        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("message", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
