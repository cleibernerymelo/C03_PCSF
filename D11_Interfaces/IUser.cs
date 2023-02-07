using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11_Interfaces
{
    interface IUser
    {

        #region Properties

        string Name { get; }
        string UserName { get; }
        string Password { get; }

        #endregion

        #region Methods
        void Message(string message);
        void Login();
        void Logout();
        void ReadCredentions();
        User[] StorageUser();
        User[] CreateUser();
        #endregion
    }
}
