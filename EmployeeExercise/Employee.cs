using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeExercise
{
    class Employee
    {
       public string name;
       public int id;
       public string position;
       public double salary;

        public Employee(string name, int id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }

        public void CompareSalary(Employee employee)
        {
            if (this.salary > employee.salary)
            {
                Console.WriteLine($"Työntekijän {this.name} palkka on suurempi kuin työntekijän {employee.name} palkka.");
            }
            else Console.WriteLine($"Työntekijän {employee.name} palkka on suurempi kuin työntekijän {this.name} palkka.");
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            return $"Työntekijän nimi: { this.name}, id: { this.id}, tehtävä: { this.position}, palkka {this.salary} euroa.";
        }
    }
}