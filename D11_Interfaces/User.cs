using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11_Interfaces
{
    internal class User : IUser
    {

        #region Properties

        #endregion

        #region Constructor
        public User() 
        {
            Name = "";
            UserName = "";
            Password = "";
        }

        public User(string name, string username, string password)
        {
            Name = name;
            UserName = username;
            Password = password;
        }
        #endregion

        #region Methods

        #endregion
        public string Name { get; set; }    
        public string UserName { get; set; }
        public string Password { get; set; }

        public void Login()
        {
            
        }

        public void Logout()
        {
            
        }

        public void Message(string message)
        {
            
        }
    }
}
