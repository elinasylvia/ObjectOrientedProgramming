using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndAuthor
{
    class Author
    {
        public string _name;
        public string _birthday;
        private Book book;

        public Author()
        {
            this._name = string.Empty;
            this._birthday = string.Empty;
            this.Book = null;
        }

        public Author(string name, string birthday, Book book)
        {
            this._name = name;
            this._birthday = birthday;
            this.Book = book;
        }

        public Book Book
        {
            get
            {
                return book;
            }

            set


            {
                //Console.WriteLine("value-muuttujan author: " + value.Author);   
                //Console.WriteLine("this.author: " + this._name);

                //if( value.Author == this._name)

                if(this._name.Equals(value.Author))
                {
                    this.book = value;
                }
                
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Kirjailijan nimi: {this._name}");
            Console.WriteLine($"Kirjailijan syntymäaika: {this._birthday}");
            Console.WriteLine($"Kirjailijan kirjoittama kirja: {this.Book.ToString()}");

        }
    }
}
