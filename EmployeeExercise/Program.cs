using System;

namespace EmployeeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alustetaan taulukkoon työntekijöiden tiedot
            Employee[] employees = new Employee[4];
            employees[0] = new Employee("Aku Ankka" , 8182, "asentaja", 2812.40 );
            employees[1] = new Employee("Iines Ankka", 8183, "kahvilatyöntekijä", 1716.90);
            employees[2] = new Employee("Mikki Hiiri", 8184, "koneenkäyttäjä", 2913.70);
            employees[3] = new Employee("Hessu Hopo", 8185, "osaston päällikkö", 3515.60);

            //tulostetaan kaikkien työntekijöiden tiedot
            foreach (Employee currentEmployee in employees)
            {
                currentEmployee.PrintEmployeeInfo();
            }

            Console.WriteLine();

            //verrataan työntekijöiden palkkoja keskenään
            for (int i = 0; i <employees.Length; i++)
            {
                int comparableI = i + 1;
                if (comparableI == employees.Length)
                {
                    comparableI = 0;
                }
                employees[i].CompareSalary(employees[comparableI]);
            }
        }
    }
}
