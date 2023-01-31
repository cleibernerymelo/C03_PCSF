using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E10_VetorDezInteirosMultiplicadoPorDois
    {
        internal static void E10_VetorDezInteirosMultiplicadoPorDois_Processar()
        {
            int[] vetor = new int[10];
            int linha, resultado;
            const int numeroBase = 2;

            for(linha = 0; linha <= 9; linha++) 
            {
                vetor[linha] = linha + 1;
                resultado = vetor[linha] * numeroBase;
                Console.WriteLine("\n Resuldado = " + Convert.ToString(resultado));
            }
        }
    }
}
