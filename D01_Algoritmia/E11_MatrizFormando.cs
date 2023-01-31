using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E11_MatrizFormando
    {
        internal static void E11_MatrizFormando_Processar()
        {
            string[,] turma = new string[13, 4];
            int linha, coluna;

            for (linha = 0; linha <= 12; linha++)
            {
                Console.Write("Nº: ");
                turma[linha, 0] = Convert.ToString(Console.ReadLine());
                Console.Write("Nome: ");
                turma[linha, 1] = Convert.ToString(Console.ReadLine());
                Console.Write("Localidade: ");
                turma[linha, 2] = Convert.ToString(Console.ReadLine());
                Console.Write("Email: ");
                turma[linha, 3] = Convert.ToString(Console.ReadLine());
            }

            for (linha = 0; linha <= 12; linha++)
            {
                for(coluna = 0; coluna <= 3; coluna++)
                {
                    Console.WriteLine("Matriz: " + linha +"." + coluna + " = " + turma[linha, coluna]);
                }
            }
        }
    }
}
