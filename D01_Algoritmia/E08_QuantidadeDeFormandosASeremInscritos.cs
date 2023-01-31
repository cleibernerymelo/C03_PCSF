using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E08_QuantidadeDeFormandosASeremInscritos
    {
        internal static void E08_QuantidadeDeFormandosASeremInscritos_Processar()
        {
            int quantidadeFormandos;
            string resposta, curso;


            Console.Write("Quantos formandos serão inscritos? ");
            quantidadeFormandos = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < quantidadeFormandos; i++)
            {
                Console.Write("Sabe programar (S/N)? ");
                resposta = Convert.ToString(Console.ReadLine());

                if (resposta == "N")
                {
                    curso = "Programming Fundamentals.";
                } 
                else 
                {
                    curso = "C# Foundations.";
                } 
                Console.Write("Você será inscrito no curso " + curso + "\n");
            }
        }
    }
}
