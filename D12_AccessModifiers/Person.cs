using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D12_AccessModifiers;

namespace D12_AccessModifiers
{
    internal class Person
    {
        #region Attributes
        internal string message1; // usado dentro do namespace
        private string message2; // usado somente na classe
        public string message3;
        #endregion

        #region Properties
        internal string Name { get; set; }
        internal string Address { get; set; }
        #endregion

        #region Methods
        internal void WriteResult1()
        {
            message1 = "hellow world";
            message2 = "boa noite";

            //variavel dentro do metodo não tem modifiers
            // quando o metodo terminar a variavel finaliza

            string m01;
        }

        internal void WriteResult2()
        {
            message1 = "hellow world";
            message2 = "Bom dia";
        }

        internal void Create()
        {

        }
        #endregion
    }

    internal class Test
    {
        internal void CheckStatus()
        {
            Person person = new Person();
            person.message1 = "teste1";
            person.message3 = "teste2";
        }
    }
}

namespace D12_AccessModifiers_v2
{
    using D12_AccessModifiers;
    internal class Customer
    {
        internal void ReadDate()
        {
            Person person1 = new Person();
            person1.Name= "Test";
        }
    }
}
