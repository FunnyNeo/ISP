﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaaa3
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
        public override void Display()
        {
            Console.WriteLine(Name + " работает в " + Company);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Дмитрий");
            p1.Display();

            Employee p2 = new Employee("Георгий", "Apple");
            p2.Display();

            Console.ReadKey();
        }
    }
}
