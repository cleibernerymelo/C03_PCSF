using System;

namespace D03_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--> metodo construtor da classe, leva o mesmo nome da classe. Nos exemplos abaixo estou usando
            // construtor padrão.

           // Course course1 = new Course();
            Course course2 = new Course(1, "Java", new DateTime(2023, 1, 23), new DateTime(2023, 1, 23), 40);

            //Formando formando1 = new Formando();
            Formando formando2 = new Formando(2, "cleiber", new DateTime(2023, 1, 23), "c@gmail.com");

            //Formador formador1 = new Formador();
            Formador formador2 = new Formador(2, "cleiber", "c@gmail.com", true);


            // usando um construtor vazio
            //Console.WriteLine("--------Pegar Dados Course-----------------\n");
            //course1.Create();
            //Console.ReadKey();

            //Console.WriteLine("\n--------Pegar Dados Formador-----------------\n");
            //formador1.Create();
            //Console.ReadKey();

            //Console.WriteLine("\n--------Pegar Dados Formando-----------------\n");
            //formando1.Create();
            //Console.ReadKey();

            //Console.WriteLine("\n------Mostrar Dados Course---------------\n");
            //course1.List();
            //Console.WriteLine("\n------Mostrar Dados Formador---------------\n");
            //formador1.List();
            //Console.WriteLine("\n------Mostrar Dados Formando---------------\n");
            //formando1.List();
            //Console.ReadKey();
            //Console.Clear();



            // usando um construtor passando parameter
            Console.WriteLine("--------Pegar Dados Course-----------------\n");
            course2.Create();
            Console.ReadKey();

            Console.WriteLine("\n--------Pegar Dados Formador-----------------\n");
            formador2.Create();
            Console.ReadKey();

            Console.WriteLine("\n--------Pegar Dados Formando-----------------\n");
            formando2.Create();
            Console.ReadKey();

            Console.WriteLine("\n------Mostrar Dados Course---------------\n");
            course2.List();
            Console.WriteLine("\n------Mostrar Dados Formador---------------\n");
            formador2.List();
            Console.WriteLine("\n------Mostrar Dados Formando---------------\n");
            formando2.List();
            Console.ReadKey();
            Console.Clear();

        }
    }
}
