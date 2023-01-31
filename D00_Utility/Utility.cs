using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D00_Utility
{
    public static class Utility
    {
        //Encoding da consola, i.e, preparar a consola para receber caracteres especiais.
        public static void SetUnicodeConsole()
        {
            Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");

            Console.OutputEncoding = Encoding.UTF8; // memas coisa se usasse System.Text.Encoding.UTF8

            Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");
        }

        public static void WriteTitle(string title) 
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(title.ToUpper());
            Console.WriteLine(new string('-', 50));
        }
        public static void TerminateConsole()
        {
            //Console.Write("\n\nPrima qualquer tecla para saíres");
            Console.ReadKey();
            Console.Clear();
        }

        public static void OptionInvalid()
        {
            Console.WriteLine("Opção Inválida");
        }

        public static void EnvironmentExit()
        {
            Environment.Exit(0);
        }

        public static void BlockSeparator(string separator)
        {
            Console.WriteLine(separator);
        }

        public static void MenuOptionsCalculator()
        {
            DateTime data = DateTime.Now;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Bem vindo ao MyCalculator - {data}");
            WriteTitle("Qual operação deseja realizar?\n");
            Console.WriteLine("| + | Somar");
            Console.WriteLine("| - | Subtrair");
            Console.WriteLine("| * | Multiplicar");
            Console.WriteLine("| / | Dividir");
            Console.WriteLine("| S | Sair");
            Console.Write("\nSelecione Opção: ");
        }

        public static void MenuInical()
        {
            string[] menu = new string[] { "0. Exit", "1. Add", "2. Subtract", "3. Multiply", "4. Divide" };
            DateTime data = DateTime.Now;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Bem vindo ao MyCalculator - {data}");
            WriteTitle("Qual operação deseja realizar?\n");
            foreach (var item in menu)
            {
                Console.WriteLine(item);           
            }
        }

        public static void MenuInical1()
        {
            string[,] tabela = new string[5, 2];
            DateTime data = DateTime.Now;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Bem vindo ao MyCalculator - {data}");
            WriteTitle("Qual operação deseja realizar?\n");
            
            tabela[0, 0] = "0. ";
            tabela[0, 1] = "Exit";
            tabela[1, 0] = "1. ";
            tabela[1, 1] = "Add";
            tabela[2, 0] = "2. ";
            tabela[2, 1] = "Subtract";
            tabela[3, 0] = "3. ";
            tabela[3, 1] = "Multiply";
            tabela[4, 0] = "4. ";
            tabela[4, 1] = "Divide";

            foreach (var item in tabela)
            {
                Console.WriteLine(item);
            }
        }
    }
}
