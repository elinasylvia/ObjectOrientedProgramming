using System;
using System.Collections.Generic;

namespace StoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Interface/Product Example");
            List<Product> productsList = new List<Product>();
            productsList.Add(new Product("Teltta", 159.99, 300));
            productsList.Add(new Product("Makuupussi", 109.99, 470));
            productsList.Add(new Product("Makuualusta", 39.99, 450));

            foreach (Product currentProduct in productsList)
            {
                if (currentProduct.GetProduct("Makuupussi") != null)
                {
                    Console.WriteLine("Makuupussi löytyi");
                    Console.WriteLine($"Varaston arvo: {currentProduct.CalculateTotal()}");
                    Console.WriteLine();
                }
                Console.WriteLine(currentProduct.ToString());
            }

            Console.WriteLine("-------------");
            Console.WriteLine("----STORE----");
            Console.WriteLine("-------------");

            Store myStore = new Store("Retkenpaikka");
            myStore.AddProduct(new Product ("Uimapatja", 19.99, 800));
          
            myStore.PrintProducts();

            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer("Maija Mehiläinen", 250));
            customerList.Add(new Customer("Ville Mehiläinen", 2000));
            customerList.Add(new Customer("Kurt", 300));

            foreach (Customer currentCustomer in customerList)
            {
                Console.WriteLine($"Asiakkaan {currentCustomer.ToString()}, bonus on: {currentCustomer.GetBonus()} euroa");
            }

            myStore.AddCustomer(new Customer("Flip", 3000));
            myStore.AddCustomer(new Customer("Kassandra", 2000));
            myStore.AddCustomer(new Customer("Tekla", 24000));

            myStore.PrintCustomers();

        }
    }
}
