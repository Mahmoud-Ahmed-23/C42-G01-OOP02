using System.Runtime.InteropServices;

namespace Assignment
{

    internal class Program
    {
        static void SortEmployeeByDate(ref Employees[] employees)
        {

            HiringDate check = new HiringDate(0, 0, 0);

            Employees employees2 = new Employees();

            for (int i = 0; i < employees.Length; i++)
            {
                for (int j = 0; j < employees.Length - 1; j++)
                {

                    if (employees[j].Date.Year > employees[j + 1].Date.Year)
                    {
                        employees2 = employees[j];
                        employees[j] = employees[j + 1];
                        employees[j + 1] = employees2;
                    }

                    else if (employees[j].Date.Month > employees[j + 1].Date.Month)
                    {
                        employees2 = employees[j];
                        employees[j] = employees[j + 1];
                        employees[j + 1] = employees2;
                    }
                    else if (employees[j].Date.Day > employees[j + 1].Date.Day)
                    {
                        employees2 = employees[j];
                        employees[j] = employees[j + 1];
                        employees[j + 1] = employees2;
                    }


                }

            }


        }


        static void Main(string[] args)
        {

            HiringDate dbaHireDate = new HiringDate(10, 5, 2022);
            HiringDate guestHireDate = new HiringDate(15, 8, 2023);
            HiringDate securityOfficerHireDate = new HiringDate(1, 1, 2020);


            Employees[] employees = new Employees[3];


            employees[0] = new Employees(1, "Mahmoud1Ahmed", "DBAB", 10000m, dbaHireDate, "Male");
            employees[1] = new Employees(2, "Yara Ahmed", "Guest", 15000m, guestHireDate, "F");
            employees[2] = new Employees(3, "Ahmed Abdeltwab", "Secretary", 20000m, securityOfficerHireDate, "M");

            // employees[0].Gender = Gender.M;

            //employees[0].Gender = Enum.Parse<Gender>("Male");


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(employees[i]);
                if (i != 2)
                    Console.WriteLine("\n\n--------------------------------------------------------------------\n\n");
            }


            Console.WriteLine("\n\n************************************************\n\n");

            Console.WriteLine("After Sorting\n\n");

            SortEmployeeByDate(ref employees);

            Console.WriteLine("************************************************\n\n");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(employees[i]);
                if (i != 2)
                    Console.WriteLine("\n\n--------------------------------------------------------------------\n\n");
            }
        }
    }
}
