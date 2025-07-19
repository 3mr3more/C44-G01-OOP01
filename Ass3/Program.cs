using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace SD
{

    public struct Point
    {
        double x;
        double y;

        public Point(double x,double y)
        {
            this.x = x;
            this.y = y;

        }
    }
    public struct Person
    {
         string Name { get; set; }
        int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    enum Gender { M, F }
    enum SecurityLevel { Guest, Developer, Secretary, DBA, SecurityOfficer }

    class HireDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }

    //1. Design and implement a Class for the employees in a company:


    //    0. Develop a Class to represent the Hiring Date Data:
    //● Consisting of fields to hold the day, month and Years.
    class Employee
    {
        int ID { get; set; }
        string Name { get; set; }
        private Gender gender;
        public double Salary { get; set; }
        public HireDate HireDate { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public Gender Gender
        {
            get { return gender; }
            set
            {
                gender = value;
            }
        }

        public Employee(int id, string name, Gender gender, double salary, HireDate hireDate, SecurityLevel securityLevel)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
            HireDate = hireDate;
            SecurityLevel = securityLevel;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary}, Hire Date: {HireDate}, Role: {SecurityLevel}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //            1.Create a struct called "Point" to represent a 2D point with properties "X" and
            //"Y". Write a C# program that takes two points as input from the user and
            //calculates the distance between them.

            //    public double x{
            //        set{ x = value; }
            //        get{ return x; }
            //    }
            //public double y
            //{
            //    set { y = value; }
            //    get { return y; }
            //}

            //Console.WriteLine(" X = ");
            //double x1 = Convert.ToDouble( Console.ReadLine());

            //Console.WriteLine(" Y1 = ");
            //double y1 = Convert.ToDouble(Console.ReadLine());



            //Console.WriteLine(" X2 = ");
            //double x2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(" Y2 = ");
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //Point p1 = Point(x1,y1);
            //Point p2 = Point(x2,y2);



            //double distance = Convert.ToDouble(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));

            //Console.WriteLine($"distance = {distance}");



            //2.Create a struct called "Person" with properties "Name" and "Age". Write a C#
            //program that takes details of 3 persons as input from the user and displays the
            //name and age of the oldest person.

            Person[] persons = new Person[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($" name of person : ");
                string name = Console.ReadLine();
                Console.WriteLine($"age of person: ");
                int age = int.Parse(Console.ReadLine());
                persons[i] = new Person(name, age);
            }

            Person old = persons[0];
            foreach (var p in persons)
            {
                if (p.Age > old.Age)
                    old = p;
            }

            Console.WriteLine($"The oldest person is {old.Name} with age {old.Age}");


            //0. Create an array of Employees with size three a DBA, Guest and
            //the third one is security officer who have full permissions. (Employee
            //[] EmpArr;)
            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(1, "Amr", Gender.M, 5600, new HireDate(1, 1, 2017), SecurityLevel.DBA);
            EmpArr[1] = new Employee(2, "Sara", Gender.F, 3050, new HireDate(10, 5, 2015), SecurityLevel.Guest);
            EmpArr[2] = new Employee(3, "Mohamed", Gender.M, 7900, new HireDate(15, 3, 2011), SecurityLevel.SecurityOfficer);

            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }

        }
}
}

