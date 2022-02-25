using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Manager-exercise");
          

            //WriteFile();
            //ReadFile();
            //WriteJsonFile();
            ReadJsonFile();

        }
        static void WriteFile()
        {
            Console.WriteLine("\nWriting to file data.txt");

            const string path = @"C:\Users\Elina\source\repos\ObjectOrientedProgramming\FileExercise\data.txt";

            if (File.Exists(path))
            { // File.WriteAllLines(string path, string[] contents, System.Text.Encoding encoding);
              // File.AppendAllText(string path, string contents);
            }

                // File.Exists(string path);

            }

            static void ReadFile()
        {
            Console.WriteLine("\nReading file data.txt");

            const string path = @"C:\Users\Elina\source\repos\ObjectOrientedProgramming\FileExercise\data.txt";
            if (File.Exists(path))
            {
                // File.ReadAllLines(string path);
            }


            }

        static void WriteJsonFile()
        {
            Console.WriteLine("\nWriting Json data to books.txt file");

            const string jsonFile =@"C:\Users\Elina\source\repos\ObjectOrientedProgramming\FileExercise\books.json";

            List<Book> bookList = new List<Book>();
            bookList.Add(new Book("Harry Potter"));

            var content = JsonConvert.SerializeObject(bookList);
            File.WriteAllText(jsonFile, content);
            

            // Serialize JSON to a file
            // https://www.newtonsoft.com/json/help/html/SerializeWithJsonSerializerToFile.htm

        }

        static void ReadJsonFile()
        {
            Console.WriteLine("\nReading Json data from books.txt file");
     

            const string jsonFile = @"C:\Users\Elina\source\repos\ObjectOrientedProgramming\FileExercise\books.json";
            FileManager fileManager = new FileManager(jsonFile);
            string content = fileManager.ReadWords();
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(content);
            foreach(Book book in books)
            {
                Console.WriteLine(book.getBookInformation());
            }
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book("Harry Potter"));
            // File.ReadAllText(string path, E
        }
    }
}
