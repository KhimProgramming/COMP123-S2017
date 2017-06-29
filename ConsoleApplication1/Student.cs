using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// This is the Student class
    /// </summary>
   public class Student : Person
    {
        //PRIVAT INSTANCE VARIABLES (FIELDS)

        private string _studentID;

        //PUBLIC PROPERTIES
        public string StudentID
        {
            get
            {
                return this._studentID;
            }

            set
            {
                this._studentID = value;
            }
        }
        //CONSTRUCTOR---------------------------

            /// <summary>
            /// 
            /// </summary>
            /// <param name="name"></param>
            /// <param name="age"></param>
            /// <param name="studentID"></param>
        public Student(string name, int age, string studentID) : base(name,age)
        {
            this.StudentID = studentID;
        }

        //PUBLIC METHODS----------------------------

            /// <summary>
            /// This is the Studies Method.  Take no arguments
            /// </summary>

        public void Studies()
        {
            Console.WriteLine(this.Name+ "is studying!");
        }
    }
}
