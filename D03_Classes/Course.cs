using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_Classes
{
    internal class Course
    {
        #region Properties

        // Sintaxe: public datatype NomePropriedade {get; set}, PascalCase.

        public int CourseId { get; set; } //read and write
        //public int CourseId { get; } // read only
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double DurationInHours { get; set; }
        #endregion

        #region Methods (método)
        public void Create()
        {
            Console.Write("Id Curso: ");
            CourseId = Convert.ToInt16(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Start Date: ");
            StartDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("End Date: ");
            EndDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Duration In Hours : ");
            DurationInHours = Convert.ToDouble(Console.ReadLine());
        }

        public void List()
        {
            Console.WriteLine($"Id Curso: {CourseId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Start Date: {StartDate.ToShortDateString()}");
            Console.WriteLine($"End Date: {EndDate.ToShortDateString()}");
            Console.WriteLine($"Duration In Hours: {DurationInHours}");
        }

        #endregion
        #region Constructors
        public Course()
        {
            CourseId = 0;
            Name = ""; //--> vazio
            StartDate = DateTime.MinValue;
            EndDate = DateTime.MinValue;
            DurationInHours = 30;
        }

        // passando parameters para o construtor
        public Course(int courseId, string name, DateTime startDate, DateTime endDate, int durationInHours)
        {
            CourseId = courseId;
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            DurationInHours = durationInHours;
            #endregion
        }
    }
}
