using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D13_Abstraction
{
    internal class CursoSoftskill : Curso
    {
        #region Propriedades
        internal string Area { get; set; } //propriedade nova
        internal override string Level { get; set; }
        #endregion
        //construtores só são implementados se houver propriedades.
        #region Construtor
        public CursoSoftskill() : base()
        {
            Area = "";
            Level = "";
        }

        public CursoSoftskill(int cursoId, string name, string area, string level = "Advanced") : base (cursoId, name)
        {
            Area = area;
            Level = level;
        }
        #endregion

        #region Metodos

        //Marcar o metodo como override na classe derivda para poder substituir o metodo da classe base virtual
        internal override void ListCurso()
        {
            Console.WriteLine($"ID: {CursoId}, Area: {Area}, Name: {Name}, Level: {Level} ");
        }

        internal override void Billing()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
