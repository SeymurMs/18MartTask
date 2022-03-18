using System;
using System.Collections.Generic;
using System.Text;

namespace _18MartTask
{
    internal class Employee
    {
        private string _name;
        private string _surname;
        private double _salary;

        public string Name {
            get => this._name;
            set
            {
                if (CheckInputs(value) == true)
                {
                    this._name = value;
                }
            }
        }
        public string Surname { 
            get => this._surname;
            set
            {
                if (CheckInputs(value)==true)
                {
                    this._surname = value;
                }
            }
        } 

        public double Salary
        {
            get=> this._salary;
            set
            {
                if (value > 250)
                {
                    this._salary = value;
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
                    if (char.IsLetter(name[i])== true)
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
    }
}
