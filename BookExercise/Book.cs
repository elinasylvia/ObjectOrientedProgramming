using System;
using System.Collections.Generic;
using System.Text;

namespace BookExercise
{
    
    //testikommentti
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
            //this.id = id;
            SetId(id);
            this.price = price;
        }
        public string getBookInformation()
        {
            //return this.author + ", " + this.title + ", " + this.id + ", " + this.price;
            return $"{this.author}, {this.title}, {this.id}, {this.price:F2}";
        }

        public void SetId(string idValue)
        {
            //tarkista tässä onko id:n pituus viisi merkkiä, if...

            // while, jos haluaa, että kysyy niin monta kertaa, että antaa oikean pituisen id:n
            if (idValue.Length != 5)
            {
                Console.WriteLine("Id not valid");
                return;
            }
            this.id = idValue;

        }
        public void CompareBook(Book book)
        {
            //vertaa parametrinä olevan olion kappalehintaa kutsuttavan olion kappalehintaan ja
            //palauta tieto siitä, kumpi kirja on kalliimpi.

            //Console.WriteLine($"kutsuva olio {this.title}");
            //Console.WriteLine($"(parametrinä oleva olio {book.title}");

            if (this.price > book.price)
            {
                Console.WriteLine($"{this.title} on kalliimpi kuin {book.title}");
            }

            else if (this.price < book.price)
            {
                Console.WriteLine($"{book.title} on kalliimpi kuin {this.title}");
            }
            else
            {
                Console.WriteLine($"{book.title} on samanhintainen kuin {this.title}");
            }


        }
    }
}
