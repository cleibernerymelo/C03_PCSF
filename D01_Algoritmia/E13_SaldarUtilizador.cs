using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E13_SaldarUtilizador
    {
        internal static void E13_SaldarUtilizador_Processar()
        {
            // SaldarUtilizador();
            // EscreverMensagem("Write Your Name: ");
            //string nome = LerNome("Cleiber Nery Melo");
            //string nome = LerNome();
            //EscreverMensagem("Good Morning " + nome);
            EscreverMensagem("Melo");
            EscreverMensagem("Melo", "Cleiber");
        }

 

        //internal static void EscreverMensagem(string mensagem)
        //{

        //    Console.Write(mensagem);

        //}
        // passagem de parametro opcional e um parametro obrigatorio.
        // quando for assim o parametro obrigatorio deve vir primeiro.
        internal static void EscreverMensagem(string apelido, string nome = "Pessoa")
        {

            Console.Write("Olá " + nome + " " + apelido);

        }

        //internal static string LerNome(string nome)
        //{

        //    string retorno = nome;
        //    return retorno;
        //}

        internal static string LerNome()                                                                                                       
        {
            string nome;
            nome = Console.ReadLine();
            return nome;
        }
    }
}
