using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

namespace PlayGround
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {EmployeeNo = "001", ExperienceInYears = 5, Name ="Radhe", Salary = 10000 },
                new Employee {EmployeeNo = "002", ExperienceInYears = 5, Name ="Ronny", Salary = 15000 },
                new Employee {EmployeeNo = "003", ExperienceInYears = 5, Name ="Tony", Salary = 8000 },
                new Employee {EmployeeNo = "004", ExperienceInYears = 5, Name ="Ali", Salary = 20000 }
            };

            foreach (var item in employees.Where(e => e.Salary >= employees.Average(x => x.Salary)))
            {
                Console.WriteLine(item.Name);
            }
        }


        public static void PrintCapacity(List<int> inputlist)
        {
            Console.WriteLine(inputlist.Capacity);
        }

        //public static void CalcualteAge()
        //{
        //    Console.WriteLine("Please Provid Your Date of Birth (DD/MM/YYYY) :");
        //    var dateofBirthInStr = Console.ReadLine();
        //    if (DateTime.TryParse(dateofBirthInStr, out DateTime dob))
        //    {
        //        DateTime PresentYear = DateTime.Now;
        //        TimeSpan ts = PresentYear - dob;
        //        DateTime Age = DateTime.MinValue.AddTicks(ts.Ticks);
        //        Console.WriteLine($"You are { Age.Year - 1} Years, {Age.Month - 1} Months, {Age.Day - 1} Days");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please enter a valid date");
        //    }
        //}
    }

    public class Student
    {
        public string RollNo { get; set; }
        public string Name { get; set; }
    }

    public class Employee
    {
        public string EmployeeNo { get; set; }
        public string Name { get; set; }
        public int ExperienceInYears { get; set; }
        public decimal Salary { get; set; }
    }

    //interface IFlyable
    //{
    //    void Fly();
    //}

    //interface ISwimmable
    //{
    //    void Swim();
    //}

    //interface IClimbable
    //{
    //    void Climb();
    //}

    //class Swan : IFlyable, ISwimmable
    //{
    //    public void Fly()
    //    {
    //        // implementation of flying
    //    }

    //    public void Swim()
    //    {
    //        // implementation of Swimming
    //    }
    //}

    //class ButterFly : IFlyable
    //{
    //    public void Fly()
    //    {
    //        // implementation of flying
    //    }
    //}

    //class Jaguar : IClimbable, ISwimmable
    //{
    //    public void Climb()
    //    {
    //        // implementation of climbing
    //    }

    //    public void Swim()
    //    {
    //        // implementation of Swimming
    //    }
    //}
}