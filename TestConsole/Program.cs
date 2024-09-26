using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Testing Console");

            Console.WriteLine("================================");

            Console.WriteLine("  ");


            List<Employee> list = new List<Employee>
            { 

                new Employee{Id = 10, Name = "Fahad Iqbal", Address="Nazimabad"},
                new Employee{Id = 12, Name = "Yaseen", Address="D.H.A"},
                new Employee{Id = 14, Name = "Waqar Alam", Address="Saddar"},
                new Employee{Id = 16, Name = "Jamal Ahmed", Address="Korangi"}

            };


            foreach (Employee emp in list)
            {

                Console.WriteLine(emp.Id + " " + emp.Name + " " + emp.Address);

            }

            Console.ReadLine();
        }
    }
}
