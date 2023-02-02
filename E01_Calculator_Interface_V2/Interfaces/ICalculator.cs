using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Calculator_Interface_V2.Interfaces
{
    internal interface ICalculator
    {
        #region Properties
        double Value1 { get; }
        double Value2 { get; }
        double Result { get; }
        string Operation { get; }
        #endregion
        #region Methods
        void Add();
        void Subtract();
        void Multiply();
        void Divide();
        void ReadValues();
        void ShowResult();
        #endregion
    }
}
