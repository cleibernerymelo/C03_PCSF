//E02 - Calcular o preço final de um produto mediante ao preço inicial e o percentual de desconto
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E02_ProdutoPrecoFinal
    {
        internal static void E02_ProdutoPrecoFinal_Processar()
        {
            double precoInicial, taxaDesconto, valorDesconto, precoFinal;
            //Console.WriteLine("Escreva o nome do produto: ");
            //string nomeProduto = Console.ReadLine();
            Console.WriteLine("Escreva o preço do produto: ");
            precoInicial = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva a percentagem de desconto: ");
            taxaDesconto = Convert.ToDouble(Console.ReadLine());

            valorDesconto = precoInicial * taxaDesconto;
            precoFinal = precoInicial - valorDesconto;

            Console.WriteLine("Preço inicial    : " + Convert.ToString(precoInicial));
            Console.WriteLine("Taxa de desconto : " + Convert.ToString(taxaDesconto));
            Console.WriteLine("Valor desconto   : " + Convert.ToString(valorDesconto));
            Console.WriteLine("Preco final      : " + Convert.ToString(precoFinal));
 
  
        }
    }
}
