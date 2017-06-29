using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Hello, World!");
                Console.WriteLine("-------------");
                Console.WriteLine();

                Person person = new Person("Tom", 25);
                person.Talks();

                Student student = new Student("John", 19, "123456789A");
                student.Studies();
                student.Talks();

                DomesticStudents domestic = new DomesticStudents("Mary", 21, "123456788B");
                domestic.Talks();
            }
        }
    }

