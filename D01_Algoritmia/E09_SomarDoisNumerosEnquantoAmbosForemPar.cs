using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E09_SomarDoisNumerosEnquantoAmbosForemPar
    {
        internal static void E09_SomarDoisNumerosEnquantoAmbosForemPar_Processar()
        {
            int numero1, numero2, resultado;
            string mensagemResultado;
            Console.Write("Escreva o primeiro número: ");
            numero1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Escreva o primeiro número: ");
            numero2 = Convert.ToInt16(Console.ReadLine());

            while ((numero1 % 2 == 0) && (numero2 % 2 == 0))
            {
                resultado = numero1 + numero2;
                mensagemResultado = Convert.ToString(numero1) + " + " + Convert.ToString(numero2) + " = " + Convert.ToString(resultado);
                Console.WriteLine(mensagemResultado);
                Console.Write("Escreva o primeiro número: ");
                numero1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("Escreva o primeiro número: ");
                numero2 = Convert.ToInt16(Console.ReadLine());
            };
            Console.WriteLine("\n\n Um dos números informado, não é par. ");
        }
    }
}
