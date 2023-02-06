using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D11_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            User user2 = new User();    
            user1.Login();
            user2.Login();


            //UserService userService = new UserService();

            //User user = userService.Login(username, password);


            Console.ReadKey();
        }
    }
}
