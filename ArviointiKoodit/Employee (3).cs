using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioEmployee
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Id;
        public string Position;
        public double Salary;
        public string UserFirstName;
        public string UserLastName;
        public string UserId;
        public string UserPosition;
        public double UserSalary;

        public Employee()
        {
            this.FirstName = String.Empty;
            this.LastName = String.Empty;
            this.Id = String.Empty;
            this.Position = String.Empty;
            this.Salary = 0;

        }
        public Employee(Employee useremployees)
        {
            this.UserFirstName = String.Empty;
            this.UserLastName = String.Empty;
            this.UserId = String.Empty;
            this.UserPosition = String.Empty;
            this.UserSalary = 0;

        }
        

        public Employee(string firstName, string lastName, string id, string position, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Position = position;
            Salary = salary;
        }

        public void AskData()
        {
            Console.WriteLine("Syötä työntekijän etunimi: ");
            this.UserFirstName = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Syötä työntekijän sukunimi: ");
            this.UserLastName = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Syötä työntekijän ID: ");
            this.UserId = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Syötä työtehtävä: ");
            this.UserPosition = Console.ReadLine();

            Console.WriteLine("");

            do
            {
                Console.WriteLine("Syötä palkka: ");
            } while (!double.TryParse(Console.ReadLine(), out this.UserSalary) || this.UserSalary < 0);

        }
        
        public void CompareSalaries()
        {
            //Ei ihan taittunu mun logiikka tähän.. Sori! 

        }
        public void PrintEmployeeInfo()
        {
            
            Console.WriteLine($"Nimi: {this.UserFirstName} {this.UserLastName}, ID: {this.UserId}, työtehtävä: {this.UserPosition}, palkka: {this.UserSalary}");

        }
        public override string ToString()
        {
            return $"Nimi: {this.FirstName} {this.LastName}, ID: {this.Id} , työtehtävä: {this.Position} palkka: {this.Salary}";
        }
    }
}
