using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E15_SomarDoisNumerosSolicitadoAoUtilizador
    {
        internal static void E15_SomarDoisNumerosSolicitadoAoUtilizador_Processar()
        {
            EscreverMensagem("Primeiro Número: ");
            int numero1 = LerNumero();
            EscreverMensagem("Segundo Número: ");
            int numero2 = LerNumero();
            int resultado = Somar(numero1, numero2);
            string mensagem = Convert.ToString(resultado);
            Console.WriteLine(mensagem);
        }

        internal static void EscreverMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        internal static int LerNumero()
        {
            int numero = Convert.ToInt16(Console.ReadLine());
            return numero;
        }

        internal static int Somar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }
    }
}
