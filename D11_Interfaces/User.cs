using System;
using System.Runtime.InteropServices;
using D00_Utility;

namespace D11_Interfaces
{
    internal class User : IUser
    {

        #region Properties
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        #endregion

        #region Constructor
        public User() 
        {
            Name = "Dora Nery";
            UserName = "";
            Password = "";
        }

        public User(string name, [Optional] string username, [Optional] string password)
        {
            Name = name;
            UserName = username;
            Password = password;
        }
        #endregion

        #region Methods

        public void Login()
        {
            ReadCredentions();
        }

        public void Logout()
        {

        }

        public void Message(string message)
        {

        }


        public void ReadCredentions()
        {
            string[] Userdata = StorageUser();

            do
            {
                Console.WriteLine($"Name: {Name}");
                Console.Write("UserName: ");
                UserName = Console.ReadLine();
                UserName = Array.Find(Userdata, e => e.Equals(UserName));
                Console.Write("Password: ");
                Password = Console.ReadLine();
                Password = Array.Find(Userdata, e => e.Equals(Password));
                if (UserName == null || Password == null)
                {
                    Console.WriteLine("\nlogin error!\n");
                    Utility.TerminateConsole();
                }
                else
                {
                    Console.WriteLine("\nLogin success!\n");
                    Utility.TerminateConsole();
                }
            } while (UserName == null || Password == null);
        }

        public static string[] StorageUser()
        {
            string[] credentionsData = new string[] { "Dora", "dora123", "Antonio", "antonio123" };
            return credentionsData;
        }
        #endregion

    }
}
