using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Calculator_V2
{
    internal class Calculator
    {
        #region Properties
        public double Value01 { get; set; }
        public double Value02 { get; set; }
        public double Result { get; set; }
        public string Operation { get; set; }
        #endregion

        #region Constructor
        internal Calculator()
        {
            Value01 = 0;
            Value02 = 0;
            Result = 0;
            Operation = "";
        }
        #endregion

        #region Methods
        public void Somar (double value)
        {

        }
        #endregion


    }
}
