using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E16_CalculadoraModular
    {
        internal static void E16_Calculadora_Modular_v3_Processar()
        {
            string[,] resultado = new string[4, 2];
            double numero1, numero2;
            Escrever("Número 1: ");
            numero1 = Convert.ToDouble(Ler());
            Escrever("Número 2: ");
            numero2 = Convert.ToDouble(Ler());
            resultado[0, 0] = "Soma: ";
            resultado[0, 1] = Convert.ToString(Soma(numero1, numero2));
            resultado[1, 0] = "Subtração: ";
            resultado[1, 1] = Convert.ToString(Subtracao(numero1, numero2));
            resultado[2, 0] = "Divião: ";
            resultado[2, 1] = Convert.ToString(Divisao(numero1, numero2));
            resultado[3, 0] = "Multiplicação: ";
            resultado[3, 1] = Convert.ToString(Multiplicacao(numero1, numero2));
            Escrever("\n\n-------------\nRESULTADOS:\n-------------\n\n");
            MostrarResultado(resultado);
            //for (int linha = 0; linha < 4; linha++)
            //{
            //    for (int coluna = 0; coluna < 2; coluna++)
            //    {
            //        Escrever(resultado[linha, coluna]);
            //    }
            //    Escrever("\n");
            //}
        }
        internal static void Escrever(string mensagem)
        {
            Console.Write(mensagem);
        }
        internal static string Ler()
        {
            string numero;
            numero = Console.ReadLine();
            return numero;
        }
        internal static double Soma(double numero1, double numero2)
        {
            double soma;
            soma = numero1 + numero2;
            return soma;
        }
        internal static double Subtracao(double numero1, double numero2)
        {
            double subtracao;
            subtracao = numero1 - numero2;
            return subtracao;
        }
        internal static double Divisao(double numero1, double numero2)
        {
            double divisao;
            divisao = numero1 / numero2;
            return divisao;
        }
        internal static double Multiplicacao(double numero1, double numero2)
        {
            double multiplicacao;
            multiplicacao = numero1 * numero2;
            return multiplicacao;
        }

        internal static void MostrarResultado(string[,] resultado)
        {
            //string[,] resultado = new string[4, 2];

            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Escrever(resultado[linha, coluna]);
                }
                Escrever("\n");
            }

        }
    }
}
