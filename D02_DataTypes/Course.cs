using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_DataTypes
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
        internal void Create()
        { 

        }

        internal void List()
        {

        }

        public string NewName
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value.ToUpper();
            }
        }
        #endregion
    }
}
