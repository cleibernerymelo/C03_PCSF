using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_DataTypes
{
    internal class Formando
    {
        #region Properties
        public int FormandoId { get; set; }

        //public int formandoId
        //{
        //    get
        //    {
        //        return this.formandoId;
        //    }
        //    set
        //    {
        //        this.formandoId = value;
        //    }
        //}
        public string Name { get; set; }
        //public string Name
        //{
        //    get
        //    {
        //        return this.name;
        //    }
        //    set
        //    {
        //        this.name = value;
        //    }
        //}
        public DateTime BirthDate { get; set; }
        //public DateTime BirthDate
        //{
        //    get
        //    {
        //        return this.birthDate;
        //    }
        //    set
        //    {
        //        this.birthDate = value;
        //    }
        //}
        public string Email { get; set; }
        //public string Email
        //{
        //    get
        //    {
        //        return this.email;
        //    }
        //    set
        //    {
        //        this.email = value;
        //    }
        //}
        #endregion

        #region Methods
        internal void Create()
        {
            //int Id = Convert.ToInt16(((uint)FormandoId)+1);
            //Random randNum = new Random();
           // FormandoId = randNum.Next();
            Console.Write("ID: ");
            FormandoId= Convert.ToInt16(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Birth Date: ");
            BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Email: ");
            Email = Console.ReadLine();
        }
        internal void List()
        {
            Console.WriteLine($"ID: {FormandoId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Birth Date: {BirthDate.ToShortDateString()}");
            Console.WriteLine($"Email: {Email}");
        }
        #endregion
    }
}
