using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E19_Extra_MatrizCurso
    {



        internal static void E19_Extra_MatrizCurso_Processar()
        {
            // declarei a matriz
            string[,] tabela = new string[5, 3];
            // atribuir valores a matriz

            #region Atrobuir valores a matriz manualmente
            //tabela[0, 0] = "1";
            //tabela[0, 1] = "CSF";
            //tabela[0, 2] = "DEV";
            #endregion

            #region Ler da consola e escrever valores na matriz usando for
            //Atribuir os valores a primeira coluna da matriz usando a estrutura for
            //for (int i = 0; i < 5; i++)
            //{
            //    tabela[i, 0] = Convert.ToString(i + 1);
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    //2 coluna
            //    Console.Write("Curso: ");
            //    tabela[i, 1] = Console.ReadLine();
            //    //3 coluna
            //    Console.Write("\nArea: ");
            //    tabela[i, 2] = Console.ReadLine();

            //    Console.WriteLine();
            //}
            #endregion

            #region Listar a matriz
            //for (int linha = 0; linha < 5; linha++)
            //{
            //    for (int coluna = 0; coluna < 3; coluna++)
            //    {
            //        Console.Write(tabela[linha, coluna] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Refatoring Ler e Listar Matriz
            LerValores(tabela);
            ListarMatriz(tabela);
            #endregion

        }
        #region Metodo para listar matriz
        internal static void ListarMatriz(string[,] tabela)
        {
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write(tabela[linha, coluna] + " ");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Ler valores a serem inseridos à matriz
        internal static void LerValores(string[,] tabela) {
            for (int i = 0; i < 5; i++)
            {
                tabela[i, 0] = Convert.ToString(i + 1);
            }

            for (int i = 0; i < 5; i++)
            {
                //2 coluna
                //Console.Write("Curso: ");
                Escrever("Curso: ");
                tabela[i, 1] = Console.ReadLine();
                //3 coluna
                //Console.Write("\nArea: ");
                Escrever("Area: ");
                tabela[i, 2] = Console.ReadLine();

                Console.WriteLine();
            }
        }
        #endregion

        #region pedir para o utilizador escrever na consola
        internal static void Escrever(string mensagem)
        {
            Console.Write(mensagem);
        }
        #endregion
    }
}
