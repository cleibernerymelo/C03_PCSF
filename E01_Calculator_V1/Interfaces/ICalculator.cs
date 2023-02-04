using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Calculator_V1.Interfaces
{
    public interface ICalculator
    {
        #region Properties
        decimal Numero1 { get; }
        decimal Numero2 { get; }
        string Operacao { get; }
        #endregion

        #region Methods
        void MotorCalculator();
        void ReadValues();
        void ShowResult();
        decimal Somar(decimal Numero1, decimal Numero2);
        decimal Subtrair(decimal Numero1, decimal Numero2);
        decimal Multiplicar(decimal Numero1, decimal Numero2);
        decimal Dividir(decimal Numero1, decimal Numero2);
        #endregion
    }
}
