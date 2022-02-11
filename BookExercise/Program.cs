using System;
using System.Collections.Generic;

namespace BookExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("This is Book exercise");
            Book book1 = new Book();
            book1.title = "Matematiikka 1";
            Console.WriteLine("Ensimmäinen kirja: " + book1.title);

            Book book2 = new Book("Aapinen");
            book2.price = 10.00;
            book2.SetId("54321");
            Console.WriteLine("Toinen kirja: " + book2.title);

            Book book3 = new Book("Historia 4", "Salonen Matti", "12345", 22.50);
            Console.WriteLine(book3.getBookInformation());
            book3.SetId("4322");
            Console.WriteLine(book3.id);

            book3.CompareBook(book2);

            //IComparable-rajapinnan toteutus
            List<Book> books = new List<Book>();
            books.Add(new Book("Historia 4", "Salonen Matti", "12345", 42.50));
            books.Add(new Book("Matematiikka 2", "Linja Lauri", "12563", 23.80));
            books.Add(new Book("Kotitalous 1", "Kauha Kirsi", "64923", 32.50));
            books.Add(new Book("Ympäristöoppi", "Karhu Otso", "39183", 29.50));

            books.Sort();

            foreach (Book b in books)
            {
                Console.WriteLine(b.getBookInformation());
            }

        }
    }
}
