using System;

namespace _18MartTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Name = "Seymur",
                Surname = "Mustafayev",
                Salary = 800,
            };
            Employee employee2 = new Employee()
            {
                Name = "Seymur",
                Surname = "Mustafayev",
                Salary = 800,

            };
            Employee employee3 = new Employee()
            {
                Name = "Seymur",
                Surname = "Mustafayev",
                Salary = 800,
            };
            Employee employee4 = new Employee()
            {
                Name = "Seymur",
                Surname = "Mustafayev",
                Salary = 800,
            };
            Employee employee5 = new Employee()
            {
                Name = "Seymur",
                Surname = "Mustafayev",
                Salary = 800,
            };
            Employee employee6 = new Employee()
            {
                Name = "Seymur",
                Surname = "Mustafayev",
                Salary = 800,
            };

            Department department = new Department(3);
            try
            {
                department.AddEmploye(employee);
                department.AddEmploye(employee2);
                department.AddEmploye(employee3);
                department.AddEmploye(employee4);
                department.AddEmploye(employee5);
                department.AddEmploye(employee6);
            }
            catch (Exception)
            {

                Console.WriteLine("Limit Doldu!!!!");
            }
            




            foreach (var item in department.employes)
            {
                Console.WriteLine($"Name:{item.Name}");
            }

        }
    }
}
