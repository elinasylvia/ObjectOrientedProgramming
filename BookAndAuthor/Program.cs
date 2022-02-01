using System;
using Literature;

namespace BookAndAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book-tehtävä");

            //Book-oliot
            Book.ChangeTheme("koulukirjat");
            Book book1 = new Book("Aapinen", "Matti Manninen", "Otava", 29.70, "978-951-65432-4-5");
            Console.WriteLine(book1.ToString());
            Console.WriteLine();

            Book book2 = new Book("Matematiikka", "Sami Salminen", "Otava", 24.90, "876-951-98548-9-2");
            Console.WriteLine(book2.ToString());
            Console.WriteLine();

            Book book3 = new Book("Kotitalous", "Kirsi Kauha", "Gummerus", 31.40, "978-951-75623-8-6");
            Console.WriteLine(book3.ToString());
            Console.WriteLine();

            Book book4 = new Book();
            book4.Name = "Ympäristöoppi";
            book4.Price = 45.60;
            Console.WriteLine($"Kirjan '{book4.Name}' alennettu hinta on {book4.Price} euroa.");
            Console.WriteLine();

            Book book5 = new Book("Musiikki 3", "Suvi Sävel", "Gummerus", 29.90, "978-951-52313-2-6");
            Console.WriteLine($"Kirjan '{book5.Name}', on kirjoittanut {book5.Author}.");

            Author author1 = new Author();
            Author author2 = new Author("Mikko Manninen", "1.6.1984", book1);
            Author author3 = new Author("Kirsi Kauha", "5.9.1968", book3);
            author1.PrintInfo();
            author2.PrintInfo();
            author3.PrintInfo();
        }
    }
}
