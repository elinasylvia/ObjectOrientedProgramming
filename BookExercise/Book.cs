using System;
using System.Collections.Generic;
using System.Text;

namespace BookExercise
{
    class Book
    {
        public string title;
        public string author;
        public string id;
        public double price;

        //empty constructor
        public Book()
        {
            this.title = string.Empty;
            this.author = string.Empty;
            this.id = string.Empty;
            this.price = 0;
        }
        //constructor
        public Book(string title)
        {
            this.title = title;
        }

        public Book(string title, string author, string id, double price) 
        {
            this.title = title;
            this.author = author;
            this.id = id;
            this.price = price;
        }
    }
}
