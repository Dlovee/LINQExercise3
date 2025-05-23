using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("Sum of all numbers: ");
            int sum = numbers.Sum();
            Console.WriteLine(sum);
            Console.WriteLine();

            //TODO: Print the Average of numbers
            Console.WriteLine("Average of all the numbers: ");
            Console.WriteLine(numbers.Average());
            Console.WriteLine();

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Numbers in ascending order: ");
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine("Numbers in descending order: ");
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Numbers greater than 6: ");
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Prints only four numbers: ");
            var prints4 = numbers.OrderBy(x => x).Take(4);

            foreach (var item in prints4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order

            numbers.SetValue(21, 4);
            Console.WriteLine("Changing the value of index 4 to 21: ");
            foreach (var item in numbers.OrderByDescending(x => x))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // List of employees ****Do not remove this****
            List<Employee> employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("ALl names that start with C or S: ");
            employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S')).OrderBy(x => x.FirstName)
                .ToList()
                .ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Employees over 26 years old: ");
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList()
                .ForEach(x => Console.WriteLine($"Full name: {x.FullName} Age: {x.Age}"));
            Console.WriteLine();

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Sum of YOE");
            int employeeSum = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine(employeeSum);
            Console.WriteLine();

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Average of YOE");
            double employeeAvg = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine(employeeAvg);
            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()
            Employee newEmployee = new Employee();
            newEmployee.FirstName = "Alen";
            newEmployee.LastName = "V";
            newEmployee.YearsOfExperience = 5;

            employees.Add(newEmployee); //.ToList().ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();
            Console.WriteLine("Original List");

            foreach (var item in employees)
            {
                Console.WriteLine(item.FullName);
            }


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("Cruz", "Sanchez", 25, 10),
                new Employee("Steven", "Bustamento", 56, 5),
                new Employee("Micheal", "Doyle", 36, 8),
                new Employee("Daniel", "Walsh", 72, 22),
                new Employee("Jill", "Valentine", 32, 43),
                new Employee("Yusuke", "Urameshi", 14, 1),
                new Employee("Big", "Boss", 23, 14),
                new Employee("Solid", "Snake", 18, 3),
                new Employee("Chris", "Redfield", 44, 7),
                new Employee("Faye", "Valentine", 32, 10)
            };

            return employees;
        }

        #endregion
    }
}
