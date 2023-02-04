using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D13_Abstraction

    // classe asbtrata permite fazer implementação nos metodos virtuais
    // nos metodos abstrato não é possivel fazer implementaçãp
{
    internal abstract class Curso
    {
        #region Properties
        internal int CursoId { get; set; }
        internal string Name { get; set; }
        internal abstract string Level { get; set; }
        #endregion

        #region Construtor
        public Curso() 
        {
            CursoId = 0;
            Name = "";
        }

        public Curso(int cursoId, string name)
        {
            CursoId = cursoId;
            Name = name;
        }
        #endregion

        #region Metodos
        //Virtual na classe base abstrata, é para permitir que o metodo seja substituido na classe derivada.
        internal virtual void ListCurso()
        {
            Console.WriteLine($"ID: {CursoId}, Name: {Name} ");
        }

        //Metodo vazio sem implementação, que deve ser implementado
        //na classe derivada.
        internal abstract void Billing();
        #endregion
    }
}
