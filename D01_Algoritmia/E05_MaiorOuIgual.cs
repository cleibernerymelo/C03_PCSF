using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E05_MaiorOuIgual
    {
        internal static void E05_MaiorOuIgual_Processar()
        {
            int numero1, numero2;
            string mensagem;
            Console.Write("Escreva primeiro número: ");
            numero1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Escreva primeiro número: ");
            numero2 = Convert.ToInt16(Console.ReadLine());

            if (numero1 > numero2)
            {
                mensagem = "O primeiro número é maior.";
            }
            else if (numero1 == numero2)
            {
                mensagem = "Os números são iguais ";
            }
            else
            {
                   mensagem = "O segundo número é maior";
            }

            Console.WriteLine(Convert.ToString(mensagem));
        }
    }
}
