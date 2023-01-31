using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace D03_Classes
{
    internal class Formador
    {
        #region Fildes ou (Attributes):
        /*
         Devem ser privados; variaveis internas de classe e que suportam as propriedades classicas.
         */
        private int _trainerId;
        private string _name;
        private bool _ccp;
        #endregion
        #region Properties (devem ser pública; caracteristicas do objetos)

        // Propriedade classica usa um field - sniped propfull
        public int TrainerId
        {
            get { return _trainerId; }
            set { _trainerId = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //propriedade automatica: auto-implementada Criada com o sniped prop tab tab
        public string Email { get; set; }

        //propriedade bodie expression (apto para expressão): usa o field operador lambda (=>)
        public bool Ccp 
        {
            get => _ccp;
            set { _ccp = value; }
        }
        #endregion
        #region Constructors
        public Formador() //--> Esse construtor é o mesmo default new Formador()
        {
            TrainerId = 0;
            Name = ""; 
            Email = "";
            Ccp = true;
        }

        public Formador(int trainerId, string name, string email, Boolean ccp)
        {
            TrainerId = trainerId;
            Name = name; 
            Email = email;
            Ccp = ccp;
        }
        #endregion
        #region Methods
        public void Create()
        {
            Console.Write("Id Formador: ");
            TrainerId = Convert.ToInt16(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Email: ");
            Email = Console.ReadLine();
            Console.Write("Ccp: ");
            Ccp = Convert.ToBoolean(Console.ReadLine());

        }

        public void List()
        {
            Console.WriteLine($"Id Formador: {TrainerId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Ccp: {Ccp}");
        }
        #endregion
    }
}
