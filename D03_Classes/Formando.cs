using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_Classes
{
    internal class Formando
    {
        #region Properties
        public int FormandoId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        #endregion

        #region Methods
        public void Create()
        {
            Console.Write("Id Formando: ");
            FormandoId = Convert.ToInt16(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Birth Date: ");
            BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Email: ");
            Email = Console.ReadLine();
        }
        public void List()
        {
            Console.WriteLine($"Id Formando: {FormandoId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Birth Date: {BirthDate.ToShortDateString()}");
            Console.WriteLine($"Email: {Email}");
        }
        #endregion
        #region Constructors
        // tem que ser publico e levar o nome da propria classse.
        // construtor vazio indica que a propriedade recebe valor vazio ex: Name = "";
        public Formando()
        {
            FormandoId = 0;
            Name = ""; //--> vazio
            BirthDate = DateTime.MinValue;
            Email = string.Empty; // -->> vazio
        }

        // passando parameters para o construtor
        public Formando(int formandoId, string name, DateTime birthDate, string email)
        {
            FormandoId = formandoId;
            Name = name; //--> vazio
            BirthDate = birthDate;
            Email = email; // -->> vazio
        }
        #endregion
    }
}
