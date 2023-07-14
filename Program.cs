using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_exersice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numEmployees = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of working days for each employee: ");
            int numDays = Convert.ToInt32(Console.ReadLine());

            // Create a jagged array to store salaries
            int[][] salaries = new int[numEmployees][];

            // Input salaries for each employee
            for (int i = 0; i < numEmployees; i++)
            {
                salaries[i] = new int[numDays];

                for (int j = 0; j < numDays; j++)
                {
                    Console.Write($"Enter salary for Employee {i + 1}, Day {j + 1}: ");
                    salaries[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Display the salary for each day and calculate the total salary for each employee
            Console.WriteLine("\nDay1\tDay2\tDay3\tDay4\tDay5\tTotalSalary");

            for (int i = 0; i < numEmployees; i++)
            {
                int totalSalary = 0;

                for (int j = 0; j < numDays; j++)
                {
                    Console.Write($"{salaries[i][j]}\t");
                    totalSalary += salaries[i][j];
                }

                Console.WriteLine(totalSalary);
            }

            Console.ReadKey();
        }
    }
}
