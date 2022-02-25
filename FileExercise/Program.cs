using System;
using System.Collections.Generic;
using System.IO;

namespace FileExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string filePath = "linkki tekstitiedostoon tähän";

            FileManager fm = new FileManager(filePath); //selvitä virhe
            try
            {
                string text = fm.ReadWords();
                Console.WriteLine(text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            WriteFile();
            ReadFile();
            WriteJsonFile();
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

            const string jsonFile =@"C:\Users\Elina\source\repos\ObjectOrientedProgramming\FileExercise\books.txt";

            List<Book> bookList = new List<Book>();
            bookList.Add(new Book("Harry Potter"));

            // File.WriteAllText(string path, string contents);
            //JsonConvert.SerializeObject(Object value);

            // Serialize JSON to a file
            // https://www.newtonsoft.com/json/help/html/SerializeWithJsonSerializerToFile.htm

        }

        static void ReadJsonFile()
        {
            Console.WriteLine("\nReading Json data from books.txt file");

            // File.ReadAllText(string path, E
        }
    }
}
