using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokenOOPConcepts
{
    /// <summary>
    /// An example of incorrect encapsulation usage.
    /// In the current exmaple Encapsulation may be performed as hidding fields
    /// by making them private and adding properties.
    /// But the all of the fields are public.
    /// </summary>
    public class User
    {
        // Name of a user
        public int _id;
        // Login of a user
        public string _login;
        // Password of a user
        public string _password;
        // First name of a user
        public string _firstname;
        // Last name of a user
        public string _lastname;

        // Encapsulated fields
        public int Id { get => _id; set => _id = value; }
        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; set => _password = value; }
        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }

        // Class constructor
        public User (int id, string login, string password, string fn, string ln)
        {
            Id = id;
            Login = login;
            Password = password;
            Firstname = fn;
            Lastname = ln;
        }

        /// <summary>
        /// Another example of encapsulation concept violation can be considered in this method.
        /// When properties are used in methods that are not the class constructor, they are no
        /// longer immutable. Which allows us to change the password anytime, via third-party access, etc.
        /// </summary>
        /// <param name="password">User's password</param>
        public void SetPassword(string password)
        {
            Password = password;
        }
    }
}
