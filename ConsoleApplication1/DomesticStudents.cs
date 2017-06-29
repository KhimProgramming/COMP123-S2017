using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class DomesticStudents : Student
    {
        //PUBLIC PROPERTIES
        public string DomesticAddress { get; set; }

        //CONSTRUCTORS------------------------------

        public DomesticStudents(string name, int age, string studentID) : base(name,age,studentID)
        {
            this.DomesticAddress = "Unknown";
        }
        
    }
}
