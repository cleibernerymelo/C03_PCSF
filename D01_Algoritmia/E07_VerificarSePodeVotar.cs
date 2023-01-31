using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E07_VerificarSePodeVotar
    {
        internal static void E07_VerificarSePodeVotar_Processar()
        {
            int idade;
            const int menorIdadePermitida = 18;
            string mensagem;
            Console.Write("Escreva sua idade: ");

            idade = Convert.ToInt16(Console.ReadLine());

            if (idade >= menorIdadePermitida)
            {
                mensagem = "Você pode votar!";
            }
            else
            {
                mensagem = "Atenção, você não pode votar!";
            }
            Console.WriteLine(mensagem);
        }
    }
}
