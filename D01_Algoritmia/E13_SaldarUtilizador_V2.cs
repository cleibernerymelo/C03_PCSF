using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E13_SaldarUtilizador_V2
    {
        internal static void E13_SaldarUtilizador_V2_Processar()
        {
            SaldarUtilizador();
            //DizerOla("Cleiber");
            //DizerOla("Melo");
        }

        // SEM PASSAGEM DE PARÂMETRO
        internal static void SaldarUtilizador()
        {
            string firstName, lastName;
            Console.Write("Escreva seu nome: ");
            firstName = Convert.ToString(Console.ReadLine());
            Console.Write("Escreva seu apelido: ");
            lastName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Olá " + firstName + " " + lastName + ". " + "Tenha um otimo dia!!!");
        }

        //internal static void DizerOla(string nome)
        //{

        //    Console.WriteLine("Olá " + nome);

        //}

        // COM PASSAGEM DE PARÂMETRO
        //internal static void SaldarUtilizador(string nome)
        //{

        //    Console.WriteLine("Olá " + nome);

        //}
    }
}
