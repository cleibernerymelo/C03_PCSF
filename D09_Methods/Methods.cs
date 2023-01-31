using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace D09_Methods
{
    internal class Methods
    {
        #region Void (procedure/procedimento): Não devolve valor
        internal void Procedure()
        {
            Console.WriteLine("Void (procedure/procedimento): Não devolve valor");
        }
        #endregion

        #region No void (function ou função): devolve valor com return
        internal string Function() 
        {
            string text = "No void (function ou função): devolve valor com return";
            return text; 
        }
        #endregion

        #region Method void with mandatory parameters
        internal void MethodWithMandatoryParameter(string text1, string text2)
        {
            Console.WriteLine($"Resultado: {text1}, {text2}");
            Console.WriteLine($"Resultado:{0}, {1}" + text1, text2);
        }
        #endregion

        #region Method void with optional parameters
        internal void MethodWithMandatoryParameterOptional(string text1, string text2, [Optional] string text3, string text4 = "olá")
        {
            Console.WriteLine($"Resultado: {text1}, {text2}, {text3}, {text4}");
            Console.WriteLine($"Resultado:{0}, {1}, {2}, {3}" + text1, text2, text3, text4);
        }

        #endregion

        #region Method with parameters by value (default para dados nativos)
        internal void PassingValueToMethod(string text)
        {
            text = "Text alterado - por valor";
            Console.WriteLine($"2: Dentro valor dentro do método {text}");
        }
        #endregion

        #region Method with parameters by reference (default para dados objetos)
        internal void PassingReferenceToMethod(ref string message)
        {
            message = "Text alterado - por referencia";
            Console.WriteLine($"2: Dentro do método {message}");
        }
        #endregion

        #region Instance method
        internal void MessageInstanceEcram() 
        {
            Console.WriteLine("Instance method");
        }
        #endregion

        #region Static method
        internal static void  MessageStaticEcram()
        {
            Console.WriteLine("Static method");
        }
        #endregion
    }
}
