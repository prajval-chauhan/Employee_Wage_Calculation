using System;

namespace Emp_Wage_Prob_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Program");
            Random randomNum = new Random();
            int attendance = randomNum.Next(0, 3);
            if (attendance == 0)
                Console.WriteLine("Employee is absent");
            if (attendance == 1)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is part time");

        }
    }
}
