using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Formando f1= new Formando();
            Console.WriteLine("--------Coletar Dados---------------\n");
            f1.Create();
            Console.WriteLine("\n--------Mostrar Dados---------------\n");
            f1.List();
            Console.ReadKey();

            #region 1. Declare variables and instanciar objects
            #region Value types

            // Ficam na stack e morrem, mal termina o método.
            //byte idade; // 0 - 255
            //float altura;
            //double peso;
            //bool inscrito; // true|false
            //bool pago = true; // declarar e atribuir
            //DateTime data;
            //DateTime hora;
            //DateTime agora;
            //DateTime dataAtual;
            //DateTime dataVazia;
            //DateTime dataMaxima;
            //#endregion

            //#region Reference types
            //// Ficam na heap e são geridos pela GC (garbage collector) = coletor de lixo.
            ////o .net identifica stack e haep pelo tipo da viavel.
            ////se for byte é stack, se for objeto é heap.

            ////Sintaxe de instanciação de objetos: NomeClasse + nomeObjeto = new NomeClasse() o certo seria Construtor.
            //Course course01 = new Course();
            //Course course02 = new Course();

            //#endregion

            //#endregion

            //#region 2. Assign values
            //#region Values types
            //idade = 10;
            //altura = 1.5F;
            //peso = 10.5;
            //inscrito = false;

            ////overloads são as diferentes formas de escrever um metodo
            //data = new DateTime(2023, 1, 20);
            //hora = new DateTime(2023, 1, 19, 21, 14, 00);
            //agora = DateTime.Now;
            //dataAtual = DateTime.Today;
            //dataVazia = DateTime.MinValue;  // 1/1/0001  12:00:00 AM
            //dataMaxima = DateTime.MaxValue; // 31/12/9999 11:59:59 PM

            //#endregion
            //#region Reference types

            //course01.CourseId = 1;
            ////course01.NewName = "SQL - Foundations to Advanced"; //property private
            //course01.Name = "SQL - Foundations to Advanced"; //property public
            //course01.StartDate = new DateTime(2022, 11, 11);
            //course01.EndDate = new DateTime(2022, 12, 5);
            //course01.DurationInHours = 33;

            //course02.CourseId = 2;
            ////course02.NewName = "C# Foundation"; //property private
            //course02.Name = "C# Foundation"; //property public
            //course02.StartDate = new DateTime(2023, 1, 11);
            //course02.EndDate = new DateTime(2023, 1, 26);
            //course02.DurationInHours = 30;

            //#endregion
            //#endregion

            //#region 3. Work in console
            //#region Values types

            //Console.WriteLine("-----------------\nValues types\n---------------\n");

            ////Não convertemos
            //Console.WriteLine("Byte " + idade);

            ////Class convert
            //Console.WriteLine("Byte " + Convert.ToString(idade));

            //// Método ToString() da variável
            //Console.WriteLine("Byte " + idade.ToString());
            //Console.WriteLine("Float " + altura.ToString());
            //Console.WriteLine("Double" + peso.ToString());
            //Console.WriteLine("Boolean " + inscrito.ToString());
            //Console.WriteLine("Boolean " + pago.ToString());

            //// String interpolation: type safe
            //Console.WriteLine($"Date Time - data: {data.ToShortDateString()}");
            //Console.WriteLine($"Date Time - hora: {hora}");
            //Console.WriteLine($"Date Time - hora short: {hora.ToShortTimeString()}");
            //Console.WriteLine($"Date Time - hora long: {hora.ToLongTimeString()}");
            //Console.WriteLine($"Date Time - agora: {agora}");
            //Console.WriteLine($"Date Time - data atual: {dataAtual.ToLongDateString()}");
            //Console.WriteLine($"Date Time - data vazia: {dataVazia}");
            //Console.WriteLine($"Date Time - data maxima: {dataMaxima}");

            //Console.WriteLine("-----------------\nDesafio\n-------------------------\n");

            ////V1 USEI A VARIAVEL hora QUE CRIAMOS

            //Console.WriteLine($"Year - ano atual: {agora.Year}");
            //Console.WriteLine($"Month - mês atual: {agora.Month}");
            //Console.WriteLine($"Day - dia atual: {agora.Day}");
            //Console.WriteLine($"Hour - hora atual: {agora.Hour}");
            //Console.WriteLine($"Minute - minuto atual: {agora.Minute}");
            //Console.WriteLine($"Secoud - segundo atual: {agora.Second}");

            ////V2 NÃO USEI A VARIAVEL

            //Console.WriteLine($"Year - ano atual: {DateTime.Today.Year}");
            //Console.WriteLine($"Month - mês atual: {DateTime.Today.Month}");
            //Console.WriteLine($"Day - dia atual: {DateTime.Today.Day}");
            //Console.WriteLine($"Hour - hora atual: {DateTime.Now.Hour}");
            //Console.WriteLine($"Minute - minuto atual: {DateTime.Now.Minute}");
            //Console.WriteLine($"Secoud - segundo atual: {DateTime.Now.Second}");

            //#endregion
            //#region Reference types
            //Console.WriteLine("-----------------\nReference types\n---------------\n");

            //Console.WriteLine("Course id: " + course01.CourseId);
            ////Console.WriteLine("Course Name: " + course01.NewName); //property private
            //Console.WriteLine("Course Name: " + course01.Name); // property public
            //Console.WriteLine("Couse start date: " + course01.StartDate);
            //Console.WriteLine("Course end date: " + course01.EndDate);
            //Console.WriteLine("Course duration: " + course01.DurationInHours);
            //Console.ReadLine();
            #endregion
            #endregion
        }
    }
}
