using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

// Error handling = tratamento de erros
namespace D10_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            try
            {
                int numero;

                Console.Write("Introdux um número: ");

                numero = Convert.ToInt16(Console.ReadLine());

                Console.Write($"\n\nO número foi {numero}.");

                Console.WriteLine($"\n\n 10 / numero = {10 / numero}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\n\nErro ao dividir por zero.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("\n\nArgumento em falta.");
            }
            catch (FormatException)
            {
                Console.WriteLine("\n\nFormato incorreto.");
            }
            catch (Exception)
            {
                Console.WriteLine("\n\nAconteceu um erro");
                //throw;
            }
            finally
            {
                Console.WriteLine("\n\nA terminar.");
            }

            Utility.TerminateConsole();
            
        }
    }
}
