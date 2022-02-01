using System;

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
            Console.WriteLine($"Kirjan 'Ympäristöoppi' alennettu hinta on {book4.Price} euroa.");
            Console.WriteLine();

            Book book5 = new Book("Musiikki 3", "Suvi Sävel", "Gummerus", 29.90, "978-951-52313-2-6");
            Console.WriteLine($"Kirjan Musiikki 3, on kirjoittanut {book5.Author}.");
            
            


            //Console.WriteLine($"1. kirjan nimi on: {book1.Name}");
            ////Console.WriteLine($"2. kirjan nimi on: {book2.Name} ja sen on kirjoittanut: {book2.Author}");

            //Author author1 = new Author();
            //Author author2 = new Author("Mikko Manninen", "1.6.1984", book1);

            //author2.PrintInfo();
        }
    }
}
