using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static assignment_OOP_2.Employee;

namespace assignment_OOP_2
{
    public class Program
    {
        static void Main ()
        {
            // Create an array of three Persons 
            Person[] persons = new Person[3];

            // fill the array with persons :
            persons[0] = new Person("hesham", 26);
            persons[1] = new Person("ahmed", 27);
            persons[2] = new Person("mohamed", 35);

            // Display the details of all the persons in the array
            foreach (var personss in persons)
            {
                Console.WriteLine(personss);
                
            }

            // part 3
            Employee emp1 = new Employee(1, "salma ahmed", "Female", 60000m, new DateTime(2020, 5, 1), 3);
            Employee emp2 = new Employee(2, "ahmed hamada", "Male", 55000m, new DateTime(2019, 8, 15), 2);
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
        }

        // Create instances of Employee
        Employee[] EmpArr = new Employee[3];
        EmpArr[0] = new Employee(1, "hesham fathy", SecurityLevel.DBA, 80000m, new HireDate(1, 5, 2020), Gender.Male);
        EmpArr[1] = new Employee(2, "ahmed ali", SecurityLevel.Guest, 50000m, new HireDate(15, 8, 2019), Gender.Male);
        EmpArr[2] = new Employee(3, "salama amr", SecurityLevel.Secretary, 45000m, new HireDate(20, 3, 2021), Gender.Female);

        // Display unsorted employee details
        Console.WriteLine("Unsorted Employees:");
        foreach (var emp in EmpArr)
        {
            Console.WriteLine(emp);
        }

    // Sort employees based on their hire date
    Array.Sort(EmpArr);

        // Display sorted employee details
        Console.WriteLine("\nSorted Employees:");
        foreach (var emp in EmpArr)
        {
            Console.WriteLine(emp);
        }
        
    }
}
