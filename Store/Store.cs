using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExercise
{
    class Store : IProducts, ICustomers
    {
        private string name;
        private double sales;
        private List<Product> allProducts = new List<Product>();
        private List<Customer> allCustomers = new List<Customer>();
        public Store(string name)
        {
            this.name = name;
        }

        public void AddCustomer(Customer customer)
        {
            this.allCustomers.Add(customer);
        }

        public void AddProduct(Product product)
        {
            this.allProducts.Add(product);
        }

        public void PrintCustomers()
        {
            Console.WriteLine($"Asiakkaiden lkm: {this.allCustomers.Count}");
            foreach (Customer c in allCustomers)
            {
                Console.WriteLine($"{c.ToString()}, bonus: {c.GetBonus()} euroa");
                
            }
        }

        public void PrintProducts()
        {
            foreach (Product p in allProducts)
            {
                Console.WriteLine(p.ToString());
            }
        }

        public override string ToString()
        {
            return $"{this.name}, {this.sales}, {this.allCustomers.Count}, {this.allProducts.Count}"; 
        }
    }
}

