using System;
using System.Collections.Generic;
using System.Text;

namespace _18MartTask
{
    internal class Department
    {
        private string _name;
        private int _employeeLimit;
        public double _salaryLimit;
        private string _employees;
        public Employee[] employes= new Employee[0];
        public Department(int limit)
        {
            this._employeeLimit = limit;

        }
        public int EmployeesLimit { get => this._employeeLimit;


            set {
                if (value >5 && value<18 )
                {
                    this._employeeLimit = value;
                }

            } 
        }

        public string Employees {
            get => this._employees;
            set
            {
                if (CheckInputs(value))
                {
                    this.Employees = value;
                }
            }
        }

        public string Name
        {
            get => this._name;
            set
            {
                if (CheckInputs(value)&& value.Length>2 && value.Length<25)
                {
                    this._name = value;
                }
            }
        }
        public int EmployeeLimit
        {
            get => this._employeeLimit;
            set
            {
                if (EmployeeLimit > 0)
                {
                    this._employeeLimit = value;
                }
            }
        }


        
        public bool CheckInputs(string name)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(name) && char.IsUpper(name[0]))
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsLetter(name[i]) == true)
                    {
                        count++;
                    }
                }
            }
            if (count == name.Length)
            {
                return true;
            }
            return false;
        }
        public Employee[] AddEmploye(Employee employee)
        {
            if (employes.Length == EmployeeLimit)
            {
                throw new Exception("Limit Doldu");
            }
            
            Array.Resize(ref employes, employes.Length + 1);
            employes[employes.Length - 1] = employee;

            return employes;
        }

    }
}
