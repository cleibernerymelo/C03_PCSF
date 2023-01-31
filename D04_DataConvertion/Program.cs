using System;
using D00_Utility;

namespace D04_DataConvertion
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Utility.SetUnicodeConsole();

            #region Variaveis
            string string01 = "1";
            string string02 = "a";
            int int01 = 10;
            int int02 = 20;
            long long01 = 2000000;
            float float01 = 3.8F;
            double double01 = 10.5;

            bool successInt = false;
            int resultInt;
            bool successLong = false;
            long resultLong;
            bool successFloat = false;
            float resultFloat;
            bool successDouble = false ;
            double resultDouble ;
            #endregion

            #region Sem conversão
            Utility.WriteTitle("Sem conversão");
            Console.WriteLine(string01 + int01);
            Utility.BlockSeparator("\n");
            #endregion

            #region Conversão implicita
            Utility.WriteTitle("Conversão Implicita");
            Console.WriteLine(int02+long01);
            Console.WriteLine(float01 + double01);
            Utility.BlockSeparator("\n");
            #endregion

            #region Conversão explicita
            Utility.WriteTitle("Conversão Explicita");
            // Classe convert: converter diferentes tipos de dados
            Console.WriteLine(Convert.ToInt16(string01) + int01);
            Utility.BlockSeparator("\n");

            // Método ToString(): data type extension method --> converter para string
            Utility.WriteTitle("Método ToString");
            Console.WriteLine(string01 + int01.ToString());
            Console.WriteLine(string01 + long01.ToString());
            Console.WriteLine(string01 + float01.ToString());
            Console.WriteLine(string01 + double01.ToString());
            Console.WriteLine();

            // Método Parse(): data type extension method --> converter string em número
            Utility.WriteTitle("Método Parse");
            Console.WriteLine(int01 + int.Parse(string01));
            Console.WriteLine(long01 + long.Parse(string01));
            Console.WriteLine(float01 + float.Parse(string01));
            Console.WriteLine(double.Parse(string01) + double01);
            Console.WriteLine();

            // Método TryParse(): converter string em número
            Utility.WriteTitle("Método TryParse");
            successInt = int.TryParse(string01, out resultInt);
            Console.WriteLine(successInt);
            Console.WriteLine(resultInt);

            // Operator Cast: converter números em outros números (editado) 
            Utility.WriteTitle("Cast");
            Console.WriteLine((long)int01 + long01);
            Console.WriteLine((double)float01 + double01);
           // Console.WriteLine((int)string01 + int01); não é para manipular string
           //consola numeros calculas try parse
           // tipos de dados diferentes cast
           // string toString
           // convert o ultimo recurso
            Console.WriteLine();
            #endregion

            Utility.TerminateConsole();
            //Console.ReadKey();
        }
    }
}
