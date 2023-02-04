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
            User user2 = new User("Antonio Melo");    
            user1.Login();
            user2.Login();
            Console.ReadKey();
        }
    }
}
