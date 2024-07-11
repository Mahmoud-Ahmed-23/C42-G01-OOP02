using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{


    class EmployeesGenderandSecurity
    {
        internal protected enum Gender : byte
        {
            M = 1,
            F
        }
        internal protected enum SecurityPrivileges : byte
        {
            Guest = 1,
            Developer,
            Secretary,
            DBA
        }

    }


    internal class Employees : EmployeesGenderandSecurity
    {

        #region Attribute

        private string name;

        private int id;

        private decimal salary;

        private string gender;

        private HiringDate date;

        private string securityLevel;

        #endregion


        #region Properties

        public string Name
        {
            get { return name; }
            set
            {
                bool flag = true;

                do
                {
                    char[] check = value.ToCharArray();

                    flag = true;

                    for (int i = 0; i < check.Length; i++)
                    {
                        if (char.IsDigit(check[i]))
                        {
                            flag = false;

                            break;
                        }
                    }

                    if (flag)
                        name = value;
                    else
                    {
                        Console.Write("Please Enter an Acceptable Name: ");
                        value = Console.ReadLine() ?? "0";
                    }
                } while (!flag);
            }
        }

        public int Id
        {
            get { return id; }
            set
            {

                bool flag = true;

                do
                {
                    string res = value.ToString();

                    flag = true;

                    if (int.TryParse(res, out value))
                    {
                        id = value;
                        flag = true;
                    }
                    else
                    {
                        Console.Write("Please Enter an Acceptable Id: ");
                        Console.WriteLine($"\nValue = {value}\n");
                        value = int.Parse(Console.ReadLine() ?? "nn");
                        flag = false;
                    }
                } while (!flag);

            }
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {

                bool flag = true;

                do
                {
                    string res = value.ToString();

                    flag = true;

                    if (decimal.TryParse(res, out value))
                    {
                        salary = value;
                        flag = true;
                    }
                    else
                    {
                        Console.Write("Please Enter an Acceptable Salary: ");
                        value = decimal.Parse(Console.ReadLine() ?? "nn");
                        flag = false;
                    }
                } while (!flag);

            }
        }

        internal protected new string Gender
        {
            get { return gender; }
            set
            {

                bool flag = true;


                do
                {

                    Gender gender1;

                    flag = Enum.TryParse(value, true, out gender1);
                    if (flag)
                    {
                        gender = value.ToUpper();
                    }
                    else
                    {
                        Console.Write("Please Enter an Acceptable Gender: ");
                        value = Console.ReadLine() ?? "k";
                    }

                }
                while (!flag);
            }
        }

        public HiringDate Date
        {
            get { return date; }
            set
            {
                date = value;
            }
        }

        internal protected string SecurityLevel
        {
            get { return securityLevel; }
            set
            {
                bool flag = true;


                do
                {
                    string res = value;

                    SecurityPrivileges security;

                    flag = Enum.TryParse(res, true, out security);
                    if (flag)
                    {
                        securityLevel = value.ToUpper();
                    }
                    else
                    {
                        Console.Write("Please Enter an Acceptable SecurityLevel: ");
                        value = Console.ReadLine() ?? "k";
                    }
                } while (!flag);
            }
        }


        #endregion


        #region Constructors
        public Employees()
        {

        }

        internal protected Employees(int id, string name, string security, decimal salary, HiringDate date, string gender)
        {

            Id = id;
            Name = name;
            SecurityLevel = security;
            Salary = salary;
            Date = date;
            Gender = gender;
        }

        #endregion


        #region Methods
        public override string ToString()
        {
            return String.Format("Id: {0}\nName: {1}\nSecurity: {2}\nSalary: {3:c}\nDate: {4}\nGender: {5}", Id, Name, SecurityLevel, Salary, Date, Gender);
        }

        #endregion

    }

    class HiringDate
    {

        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int day, int month, int year)
        {
            string check = day.ToString();
            bool flag;

            do
            {
                flag = int.TryParse(check, out day);
                if (flag)
                    Day = day;
                else
                    check = Console.ReadLine() ?? "0";

            } while (!flag);



            check = month.ToString();


            do
            {
                flag = int.TryParse(check, out month);
                if (flag)
                    Month = month;
                else
                    check = Console.ReadLine() ?? "0";

            } while (!flag);




            check = year.ToString();


            do
            {
                flag = int.TryParse(check, out year);
                if (flag)
                    Year = year;
                else
                    check = Console.ReadLine() ?? "0";

            } while (!flag);


        }


        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

    }


}
