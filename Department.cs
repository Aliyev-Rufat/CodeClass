using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Department
    {
        public Employee[] Employees { get; set; }

        public Department(int baza)
        {
            Employees = new Employee[baza];
        }

        public void AddEmployee(Employee employee)
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i] == null)
                {
                    Employees[i] = employee;
                    break;
                }
                else
                {

                }
            }
        }

        public void ShowEmployeeInfo()
        {
            foreach (var employee in Employees)
            {
                if (employee != null)
                {
                    Console.WriteLine($"Name: {employee.Name}, Surname: {employee.Surname}, Age: {employee.Age}, DepartmentNo: {employee.DepartmentNo}, Salary: {employee.Salary}");
                }
            }
        }
        public Employee[] GetAllEmployees()
        {
            return Employees;
        }


    }
}
