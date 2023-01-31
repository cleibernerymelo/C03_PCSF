using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E03_AumentoDeVencimento
    {
        internal static void E03_AumentoDeVencimento_Processar()
        {
            const double taxaAumento = .2;
            double vencimentoAtual, vencimentoNovo;
            Console.WriteLine("Vencimento atual: ");
            vencimentoAtual = Convert.ToDouble(Console.ReadLine());
            vencimentoNovo = vencimentoAtual + (vencimentoAtual * taxaAumento);
            Console.Write("O novo vencimento é: " + Convert.ToString(vencimentoNovo));
        }
    }
}
