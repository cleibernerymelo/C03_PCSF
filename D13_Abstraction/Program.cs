using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D13_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Não poder instanciar a base classe. Tornando abstrata
            //Curso curso= new Curso();

            Utility.SetUnicodeConsole();

            CursoSoftskill cursoSoftskill = new CursoSoftskill(1, "Gestão", "Gestão do Tempo", "Meddium");
            CursoSoftskill cursoSoftskill3 = new CursoSoftskill(3, "BD", "SQL");

            cursoSoftskill.ListCurso();
            cursoSoftskill3.ListCurso();

            Utility.TerminateConsole();
        }
    }
}
