using System;
using System.Collections.Generic;
using System.Text;
using Literature;

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
                if (value == null)
                {
                    return;
                }
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
                if (this.Book != null)
            {
                Console.WriteLine($"Kirjailijan kirjoittama kirja: {this.Book.Name}");
            }

            

        }
    }
}
