using System;
using D00_Utility;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Calculator_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Calculator calculator = new Calculator(); 
            calculator.MotorCalculator();

           Console.WriteLine(Utility.ValidateNumber(10));
           Console.WriteLine(Utility.ValidateNumber(0));
            Console.WriteLine("Teste");
        }
    }
}
