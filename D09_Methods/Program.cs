using Microsoft.SqlServer.Server;
using System;
using D00_Utility;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region procedure
            // tenho que instanciar o method void.
            Methods methods= new Methods();
            methods.Procedure();
            #endregion

            #region Function
            //v1
            string message;
            message = methods.Function();
            Console.WriteLine(message);

            //v2
            Console.WriteLine(methods.Function());
            #endregion

            #region Method void with mandatory parameters
            methods.MethodWithMandatoryParameter("Hellow", "World!");
            #endregion

            #region Method void with mandatory parameters
            methods.MethodWithMandatoryParameterOptional("Cleiber", "Nery");
            #endregion

            #region Method with parameters by value (default para dados nativos)
            string text = "1: texto original";
            Console.WriteLine($"Texto antes de mudar o valor da variavel {text}");
            methods.PassingValueToMethod(text);
            Console.WriteLine($"3: Texto depois de mudar o valor da variavel {text}");
            #endregion
            #region Method with parameters by reference (default para dados objetos)
            string reference = "1: Original";
            Console.WriteLine($"1: {reference}");
            methods.PassingReferenceToMethod(ref reference);
            Console.WriteLine($"3: Texto depois de mudar o valor da variavel {reference}");
            #endregion
            #region Instance Method
            methods.MessageInstanceEcram();
            #endregion

            #region Static Method
            Methods.MessageStaticEcram();
            #endregion

            Utility.TerminateConsole();
        }
    }
}
