using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Algoritmia
{
    internal class E14_FuncaoSomar10e20
    {
        internal static void E14_FuncaoSomar10e20_Processar()
        {
            int resultado = Somar();
            //Console.WriteLine("Resultado = " + Convert.ToString(resultado));
            mostrarResultado(resultado);
        }
        internal static int Somar()
        {
            int resultado = 10 + 20;
            return resultado;
        }

        internal static void mostrarResultado(int resultado) {
            Console.WriteLine("Resultado = " + Convert.ToString(resultado));
        }
    }
}
