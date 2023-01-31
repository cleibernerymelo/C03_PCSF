using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E04_MaiorDeDoisNumeros
    {
        internal static void E04_MaiorDeDoisNumeros_Processar()
        {
            int numero1, numero2, numeroMaior;
            Console.Write("Escreva primeiro número: ");
            numero1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Escreva primeiro número: ");
            numero2 = Convert.ToInt16(Console.ReadLine());

            if (numero1 > numero2)
            {
                numeroMaior = numero1;               
            }
            else
            {
                numeroMaior = numero2;
            }

            Console.WriteLine("O número maior é " + Convert.ToString(numeroMaior));
        }
    }
}
