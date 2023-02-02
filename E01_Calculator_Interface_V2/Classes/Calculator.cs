using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E01_Calculator_Interface_V2.Interfaces;

namespace E01_Calculator_Interface_V2.Classes
{
    internal class Calculator : ICalculator
    {
        #region Properties
        public double Value1 { get; }
        public double Value2 { get; }
        public double Result { get; }
        public string Operation { get; }
        #endregion

        #region Constructor
        public Calculator() 
        { 
            Value1 = 0;
            Value2 = 0;
            Result = 0;
            Operation = "";
        }
        #endregion

        #region Methods
        public void Add() { }
        public void Subtract() { }
        public void Multiply() { }
        public void Divide() { }
        public void ReadValues() { }
        public void ShowResult()
        {
            
        }
        #endregion
    }
}
