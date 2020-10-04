using System;

namespace Employee_Wage_Problem
{
    class Employee_Wage_Problem
    {
        static void Main(string[] args)
        {
            //Constants
            int wage_per_hour = 20;
            int full_time_hours = 8;
            int part_time_hours = 4;
            int max_woking_hours = 100;
            int max_working_days = 20;

            //Variables
            int empHours = 0;
            int total_empHours = 0;
            int total_empWorkDays = 0;
            int total_empSalary = 0;


            Random randomNum = new Random();
            // Welcome Message
            Console.WriteLine("Welcome to the Employee Wage Calculation Program \n");

            //Monthly Wage Calculation
            for (int i = 1; ; i++)
            {

                //Condition for max working days
                if (total_empWorkDays >= max_working_days)
                {
                    Console.WriteLine("\nMax. Work days limit reached");
                    Console.WriteLine("Total Working hours = " + total_empHours);
                    Console.WriteLine("Total Working days = " + total_empWorkDays);
                    Console.WriteLine("\nTotal salary of the employee is : Rs. " + total_empSalary);
                    break;
                }
                //Condition for max working hours
                if (total_empHours >= max_woking_hours)
                {
                    Console.WriteLine("\nMax. Working Hours limit reached");
                    Console.WriteLine("Total Working hours = " + total_empHours);
                    Console.WriteLine("Total Working days = " + total_empWorkDays);
                    Console.WriteLine("\nTotal salary of the employee is : Rs. " + total_empSalary);
                    break;
                }
                else
                {
                    //Attendance Assignment and Hours Allotment
                    int empAttendance = randomNum.Next(0, 3);
                    switch (empAttendance)
                    {
                        case 0:
                            Console.WriteLine("Employee is absent");
                            empHours = 0;
                            total_empHours = total_empHours + 0;
                            total_empWorkDays = total_empWorkDays + 1;
                            break;
                        case 1:
                            Console.WriteLine("Employee is Present");
                            empHours = full_time_hours;
                            total_empHours = total_empHours + 8;
                            total_empWorkDays = total_empWorkDays + 1;
                            break;
                        case 2:
                            Console.WriteLine("Employee is present and is working part time");
                            empHours = part_time_hours;
                            total_empHours = total_empHours + 4;
                            total_empWorkDays = total_empWorkDays + 1;
                            break;
                    }
                    //Employee Wage Calculation
                    int empWage = wage_per_hour * empHours;
                    Console.WriteLine("The wage of the employee for the day is : Rs." + empWage);
                    total_empSalary = total_empSalary + empWage;

                }
            }


        }
    }
}
