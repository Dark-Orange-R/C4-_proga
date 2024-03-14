using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgaC4__1
{
    

    internal class Program
    {
        

        class Student : IComparable<Student>
        {
            public double GPA;
            public Student(double g = 0)
            {
                GPA = g;
            }
            public int CompareTo(Student other)
            {
                return this.GPA.CompareTo(other.GPA);
            }
        }

        interface IVehicle
        {
            void Drive(string message);
        }
        
        class Car : IVehicle
        {
            private string name;
            private int year;
            public Car(string name = "", int year = 0)
            {
                this.name = name;
                this.year = year;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Year
            {
                get { return year; }
                set { year = value; }
            }
            public void Drive(string message = "Be careful on the road")
            {
                Console.WriteLine(message);
            }
        }
        class Motorcycle : IVehicle
        {
            private string name;
            private int year;
            private double speed;
            public Motorcycle(string name = "", int year = 0, double speed = 0.0)
            {
                this.name = name;
                this.year = year;
                this.speed = speed;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Year
            {
                get { return year; }
                set { year = value; }
            }
            public double Speed
            {
                get { return speed; }
                set { speed = value; }
            }
            public void Drive(string message = "Be careful on the road, cuz eventually some car will hit you")
            {
                Console.WriteLine(message);
            }
        }

        abstract class Shape
        {
            public abstract double CalculateArea();
        }
        class Rectangle:Shape
        {
            private double x;
            private double y;
            public Rectangle(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public double X
            {
                get { return x; }
                set { x = value; }
            }
            public double Y
            {
                get { return y; }
                set { y = value; }
            }
            public override double CalculateArea()
            {
                return x * y;
            }
        }

        class Person 
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Person(string name = "",int age = 0)
            {
                Name= name;
                Age = age;
            }
        }
        class Employee : Person, IComparable<Employee>, ICloneable
        {
            public double Salary { get; set; }
            public Employee(string name = "", int age = 0, double salary = 0.0)
            {
                Name = name;
                Age = age;
                Salary = salary;
            }
            public int CompareTo(Employee other)
            {
                return Salary.CompareTo(other.Salary);
            }
            public object Clone()
            {
                return new Employee(Name, Age, Salary);
            }
        }

        class Vector
        {
            public List<int> values;
            public Vector(List<int> v = null)
            {
                if (v == null)
                {
                    values = new List<int>();
                }
                else
                {
                    values = v;
                }
            }
            public static Vector operator +(Vector a, Vector b)
            {
                List<int> result = new List<int>();
                if (a.values.Count() > b.values.Count())
                {
                    for (int i = 0; i < b.values.Count();i++)
                    {
                        result.Add(a.values[i] + b.values[i]);
                    }
                    for (int i = b.values.Count(); i < a.values.Count(); i++)
                    {
                        result.Add(a.values[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < a.values.Count(); i++)
                    {
                        result.Add(a.values[i] + b.values[i]);
                    }
                    for (int i = a.values.Count(); i < b.values.Count(); i++)
                    {
                        result.Add(b.values[i]);
                    }
                }
                return new Vector(result);
            }
        }




        static void Main(string[] args)
        {
            Car car = new Car();
            Motorcycle motorcycle = new Motorcycle();
            car.Drive();
            motorcycle.Drive();


            Rectangle r = new Rectangle(2, 6);
            Console.WriteLine(r.CalculateArea());


            Employee e1 = new Employee("Max", 24, 300.5);
            Employee e2 = new Employee("notMax", 42, 500.3);
            Console.WriteLine(e2.CompareTo(e1));
            Console.WriteLine(e1.CompareTo(e1));
            Console.WriteLine(e1.CompareTo(e2));


            int[] l1 = { 1, 2, 3, 4, 5, 6, };
            int[] l2 = { 6, 2, 8 };
            Vector v1 = new Vector(l1.ToList());
            Vector v2 = new Vector(l2.ToList());
            Vector v3 = v1 + v2;
            foreach (int i in v3.values)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();





            Console.ReadLine();

        }
    }
}
