using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int DepartmentNo { get; set; }

        public decimal Salary { get; set; }

        public Employee(string name, string surname, int age, int departmentNo, int salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentNo = departmentNo;
            Salary = salary;
        }
    }
}
