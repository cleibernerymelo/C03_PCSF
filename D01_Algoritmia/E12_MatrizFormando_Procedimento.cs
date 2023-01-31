using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E12_MatrizFormando_Procedimento
    {

        internal static void E12_MatrizFormando_Procedimento_Processar()
        {
            string[,] turma = LerTurma();
            EscreverTurma(turma);
        }

        internal static string[,] LerTurma()
        {
            string[,] turma = new string[13, 4];
            int linha;

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
            return turma;
        }

        internal static void EscreverTurma(string[,] turma)
        {
            int linha, coluna;

            for (linha = 0; linha <= 12; linha++)
            {
                for (coluna = 0; coluna <= 3; coluna++)
                {
                    Console.WriteLine("Matriz: " + linha + "." + coluna + " = " + turma[linha, coluna]);
                }
            }
        }
    }
}
