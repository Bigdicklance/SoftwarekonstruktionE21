using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLearn
{
    // Person class without abstraction
    class Person
    {
        public int BirthYear;
        public string FirstName;

        public void age()
        {
            int CurrentYear = 2021;
            int a = CurrentYear - BirthYear;
            Console.WriteLine(a);
        }


    // Person class with abstraction, inheritance and encapsulation. Can you mention where each OOP pillar exists?
    abstract class AbstractPerson
        {
            public int birthY;
            public string FirstName;
            public abstract int MonthlySalary();
        }

    class ContractWorker : AbstractPerson
        {
            public int HourlySalary;
            public int HoursWorked;
            public override int MonthlySalary()
            {
                int TotalMonthlySalary = HourlySalary * HoursWorked;
                Console.WriteLine(FirstName + "has a monthly salary of " + TotalMonthlySalary);
                return TotalMonthlySalary;
            }
        }

        static void Main(string[] args)
        {
            // Implement the classes
        }
    }

}
