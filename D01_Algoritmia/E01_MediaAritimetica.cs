//E01. Média aritimetica de dois valores reais.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E01_MediaAritimetica
    {
        internal static void E01_MediaAritimetica_Processar()
        {
            Console.Write("Escreva o primeiro número: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Escreva o segundo número: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            double resultado = (valor1 + valor2) / 2;

            //Console.WriteLine("Média {0}: ", resultado);
            Console.WriteLine("Média: " + Convert.ToString(resultado));
        }
    }
}
