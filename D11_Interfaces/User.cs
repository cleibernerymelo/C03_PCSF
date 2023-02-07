using System;
using System.Runtime.InteropServices;
using System.Security;
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

        public User(string name, string username, string password)
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
            User[] userdata = StorageUser();
            do
            {
                Console.Write("UserName: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();

                //User dbUser = Array.Find(userdata, e => e.UserName.Equals(username));
                User dbUser = Array.Find(userdata, e => e.UserName.Equals(username) && e.Password.Equals(password));
                if (dbUser != null && dbUser.Password.Equals(password))
                {
                    // Login success
                    Console.WriteLine($"\nLogin success for! {dbUser.Name}.\n");
                    Utility.TerminateConsole();
                } else
                {
                    // Login failed
                    Console.Write("\nUser not exist. create an account (true/false) ? ");
                    bool resposta = Boolean.Parse(Console.ReadLine());
                    if (resposta)
                    {
                        CreateUser();
                        Utility.TerminateConsole();
                    }
                    else
                    {
                        Utility.EnvironmentExit();
                    }
                    
                    Utility.TerminateConsole();
                }
            } while (UserName == null || Password == null);
        }

        public User[] StorageUser()
        {
            User[] credentionsData = new User[] 
            {
                new User{ Name = "Dora Nery", UserName = "dora", Password = "dora123" },
                new User{ Name = "Antonio Melo", UserName = "antonio", Password = "antonio123" }
            };

            return credentionsData;
            //string[] credentionsData = new string[] { "Dora", "dora123", "Antonio", "antonio123" };
            //return credentionsData;
        }

        public User[] CreateUser()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("User Name: ");
            string userName = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            User[] credentionsData = new User[]
            {
                new User{Name = name, UserName = userName, Password = password}
            };
            Console.WriteLine($"Welcome {credentionsData[0].Name}. Login success!");
            return credentionsData;
        }
        #endregion
    }
}
