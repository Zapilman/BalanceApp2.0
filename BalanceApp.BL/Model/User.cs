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

        #region Properties
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Birthday.
        /// </summary>
        public DateTime Birthday { get; }
        /// <summary>
        /// List of expenses.
        /// </summary>
        public List<Amount> Expenses { get; set; }
        /// <summary>
        /// List of incomes.
        /// </summary>
        public List<Amount> Incomes { get; set; }
        /// <summary>
        /// Password.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Login.
        /// </summary>
        public string Login { get; }

        

        /// <summary>
        /// To create new user.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthday"></param>
        /// <param name="password"></param>
        /// <param name="login"></param>
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
            Expenses = new List<Amount>();
            Incomes = new List<Amount>();
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
