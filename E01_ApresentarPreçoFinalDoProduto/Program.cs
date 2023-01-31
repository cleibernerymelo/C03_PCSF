using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_ApresentarPreçoFinalDoProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o nome do produto: ");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine("Escreva o preço do produto: ");
            double precoProduto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva a percentagem de desconto: ");
            double percentagemDesconto = Convert.ToDouble(Console.ReadLine());

            double valorDesconto = precoProduto * (percentagemDesconto/100);
            double precoFinal = precoProduto - valorDesconto;

            Console.WriteLine("O preço do produto {0} é de {1} EUR. Foi aplicado {2} EUR de desconto. " +
                              "O preço final é de {3} EUR.", nomeProduto, precoProduto, valorDesconto, precoFinal);
            Console.ReadLine();
        }
    }
}
