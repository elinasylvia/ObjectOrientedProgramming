﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileExercise
{
    // Custom exception
    public class WordListNotFoundException : Exception
    {
        public WordListNotFoundException(string message) : base(message)
        {

        }
    }

    class FileManager
    {
        private string filePath;

        // Constructor
        public FileManager()
        {
            this.filePath = String.Empty;
        }

        // Constructor
        public FileManager(string filePath)
        {
            this.filePath = filePath;
        }

        public string ReadWords()
        {
            string content = String.Empty;
            try
            {
                content = ReadFile();
            }
            catch(WordListNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return content;
        }

        /* Method reads file from a local 
         * directory path.
         */
        private string ReadFile()
        {
            if (!File.Exists(filePath))
            {
                // Throw exception if file does not exists
                throw new FileNotFoundException("File not available");
            }

            string directoryName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);

            Console.WriteLine("directoryName: " + directoryName);
            Console.WriteLine("fileName: " + fileName);
            Console.WriteLine("fileExtension: " + fileExtension);

            string fileContent = File.ReadAllText(filePath, Encoding.UTF8);
            return fileContent;
        }
    }
}
