using ConsoleApp8;

public class Program
{
    public static void Main()
    {
        Department department = new Department(10);

        while (true)
        {
            Console.WriteLine("Employee əlavə et");
            Console.WriteLine("Bütün işçilərə bax");
            Console.WriteLine("Proqramı bitir");

            int secme;
            if (int.TryParse(Console.ReadLine(), out secme))
            {
                Console.WriteLine("Error");
                continue;
            }

            if (secme == 1)
            {
                Console.Write("Adini gir: ");
                string name = Console.ReadLine();

                Console.Write("Soyadini gir: ");
                string surname = Console.ReadLine();

                Console.Write("Enter Ag: ");
                int age;
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Duzgun yasinizi girin.");
                    continue;
                }

                Console.Write(" Department nomresini gir: ");
                int departmentNo;
                if (int.TryParse(Console.ReadLine(), out departmentNo))
                {
                    Console.WriteLine("duzgun department nomresini gir.");
                    continue;
                }

                Console.Write("Enter Salary: ");
                decimal salary;
                if (decimal.TryParse(Console.ReadLine(), out salary))
                {
                    Console.WriteLine("duzgun yaz.");
                    continue;
                }

                Employee newEmployee = new Employee(name, surname, age, departmentNo, salary);
                department.AddEmployee(newEmployee);
            }
            else if (secme == 2)
            {
                department.ShowEmployeeInfo();
            }
            else if (secme == 0)
            {
                Console.WriteLine("Proqramdan cix.");
                break;
            }

        }
    }
}
