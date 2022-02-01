using System;

namespace OlioEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Kirjoita mitä vain aloittaaksesi työntekijän tietojen syötön. Kun haluat lopettaa, kirjoita 'stop'");
                string stopper = Console.ReadLine();
                if (stopper == "stop")
                {
                    break;
                }
                Employee useremployee = new Employee();
                useremployee.AskData();

                Employee[] employee = new Employee[3];
                employee[0] = new Employee("Mikko", "Mallikas", "310X330", "CEO", 10700);
                employee[1] = new Employee("Maija", "Mallikas", "27BC133", "Technical Advisor", 7200);
                employee[2] = new Employee("Helena", "Jokinen", "1Z33M12", "Human Resources", 7820); ;
                
                foreach (Employee employees in employee)
                {
                    
                    Console.WriteLine(employees.ToString());

                }
                useremployee.PrintEmployeeInfo();
                
            }

        }
    }
}
