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
            Name = "";
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
            User[] Userdata = StorageUser();
            do
            {
                Console.Write("UserName: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();


                User dbUser = Array.Find(Userdata, e => e.UserName.Equals(username));
                if (dbUser != null && dbUser.Password.Equals(password))
                {
                    // Login success
                    Console.WriteLine($"\nLogin success for! {dbUser.Name}.\n");
                    Utility.TerminateConsole();
                } else
                {
                    // Login failed
                    Console.WriteLine("\nlogin error!\n");
                    Utility.TerminateConsole();
                }
            } while (UserName == null || Password == null);
        }

        public static User[] StorageUser()
        {
            User[] credentionsData = new User[] {
                new User{ Name = "Dora", UserName = "dora", Password = "dora123" },
                new User{ Name = "Antonio", UserName = "antonio", Password = "antonio123" }
            };

            return credentionsData;
            //string[] credentionsData = new string[] { "Dora", "dora123", "Antonio", "antonio123" };
            //return credentionsData;
        }
        #endregion

    }
}
