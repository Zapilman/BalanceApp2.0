using BalanceApp.BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace BalanceApp.BL.Controller
{
    /// <summary>
    /// UserController.
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// User List.
        /// </summary>
        public List<User> Users { get; }

        /// <summary>
        /// Which input is incorrect.
        /// </summary>
        public string WhatIsWrong { get; set; }

        /// <summary>
        /// CurrentUser.
        /// </summary>
        public User CurrentUser { get; }
        /// <summary>
        /// To create a new user.
        /// </summary>
        /// <param name="password"> User password. </param>
        /// <param name="login"> User login. </param>
        public UserController(string password, string login)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password can not be a null", nameof(password));
            }

            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentException("Login can not be a null", nameof(login));
            }
            Users = GetUsersData();

            CurrentUser = Users.SingleOrDefault(u => u.Login == login);
            if (CurrentUser == null)
            {
                WhatIsWrong = "login";
                return;
            }
            else
            {
                if (CurrentUser.Password != password)
                {
                    WhatIsWrong = "password";
                    return;
                }
                else
                {
                    WhatIsWrong = "Nothing"; 
                }
            }
            
        }
        /// <summary>
        /// To create a new user.
        /// </summary>
        /// <param name="userName"></param>
        public UserController(string userName)
        {
            var newUser = new User(userName);
            CurrentUser = newUser;
            Users = GetUsersData();
            Users.Add(CurrentUser);
            Save();
        }
        
        public UserController(string userName,
                              DateTime dateTime,
                              string password,
                              string login)
        {
            Users = GetUsersData();
            CurrentUser = Users.SingleOrDefault(u => u.Login == login);
            if (CurrentUser != null)
            {
                WhatIsWrong = "This login is already teken";
            }
            else
            {
                CurrentUser = new User(userName, dateTime, password, login);
                Users.Add(CurrentUser);
                Save();
            }
        }

        /// <summary>
        /// Saving user's data.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using (var file = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(file, Users);
            }
        }
        /// <summary>
        /// Geting user data.
        /// </summary>
        /// <returns></returns>
        private List<User> GetUsersData()
        {
            var formatter = new BinaryFormatter();
            using (var file = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (file.Length>0 && formatter.Deserialize(file) is List<User> user)
                {
                    return user;
                }
                else
                {
                    return new List<User>();
                }
            }
        }

    }
}
