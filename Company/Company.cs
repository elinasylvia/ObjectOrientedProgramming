using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyExercise
{
    class Company
    {

        public string title;
        public string address;
        public int phone;
        public double outcome;
        public double expense;

        public Company()
        {
            this.title = string.Empty;
            this.address = string.Empty;
            this.phone = 0;
            this.outcome = 0;
            this.expense = 0;

        }
        public Company(string title, string address, int phone, double outcome, double expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expense = expense;
        }
        public Company(Company company)
        {
            this.title = company.title;
            this.address = company.address;
            this.phone = company.phone;
            this.outcome = company.outcome;
            this.expense = company.expense;
        }
        public void CompanySummary()
        {
            Console.WriteLine($"Yrityksen nimi ja yhteystiedot: {this.title}, {this.address}, {this.phone}. Yrityksen tulot: {this.outcome}. Yrityksen menot: {this.expense}");
        }
        public void FinancialSituation()
        {
            double profits;
            profits = (this.outcome - this.expense) / this.expense * 100;
            Console.WriteLine("Yrityksen voitto: " + profits + " %");
            if (profits < 100)
            {
                Console.WriteLine("Yrityksellä menee kehnosti");
            }
            else if (profits <= 200)
            {
                Console.WriteLine("Yrityksellä menee välttävästi");
            }
            else if (profits >= 200 && profits <300)
            {
                Console.WriteLine("Yrityksellä menee tyydyttävästi");
            }
            else if (profits >= 300)
            {
                Console.WriteLine("Yrityksellä menee hyvin");
            }
        }
    }
}
