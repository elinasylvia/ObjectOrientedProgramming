using System;
using System.Collections.Generic;
using System.Text;

namespace Literature
{
    class Book
    {
        private const string Prefix = "978";
        private const int MaxLength = 13;
        private string _name;
        private string _author;
        private string _publisher;
        private double _price;
        private string _isbn;
        private static string _theme;
        public Book()
        {
            _name = string.Empty;
            _author = string.Empty;
            _publisher = string.Empty;
            this.Price = 0;
            this.Isbn = string.Empty;
        }

        public Book(string name, string author, string publisher, double price, string isbn)
        {
            _name = name;
            _author = author;
            _publisher = publisher;
            this.Price = price;
            this.Isbn = isbn;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }

        }

        public string Author
        {
            get
            {
                return this._author;
            }
        }

        public string Publisher
        {
            get
            {
                return _publisher;
            }

            set 
            {
                _publisher = value; 
            }
        }
        public double Price
        {

            get
            {
                return _price;
            }
            set
            {
                _price = value;
                if (value > 30)
                {
                    _price = value * 0.9;
                }
            }
        }
        public string Isbn
        {

            get
            {
                return _isbn;
            }

            set
            {
                if (value.Replace("-", string.Empty).Length != MaxLength)
                {
                    Console.WriteLine("Pituuden täytyy olla 13 merkkiä");
                    return;
                }
                if (value.Substring(0, 3) != Prefix)
                {
                    Console.WriteLine($"Kirjan ISBN tunniste on väärä, eikä sitä voitu tulostaa. ISBN - tunnisteen tulee alkaa numeroilla: {Prefix}");
                    return;
                }
                _isbn = value;
            }
        }
        public static string Theme 
        { 
            get 
            { 
                return _theme; 
            } 
            set 
            {
                _theme = value; 
            } 
        }

        public string GetBookDetails(string compareIsbn)
        {
            if (compareIsbn == this._isbn)
            {
                return this.ToString();
            }
            return "Kirjan tietoja ei voida tulostaa";

        }
        public static void ChangeTheme(string theme)
        {
            _theme = theme;
        }

        public override string ToString()
        {
            return $"Kirjan nimi: {this.Name}, kirjailija: {this.Author}, kustantaja: {this.Publisher}, hinta: {this.Price:F2} euroa, ISBN: {this.Isbn}, {_theme}";
        }
    }
}
