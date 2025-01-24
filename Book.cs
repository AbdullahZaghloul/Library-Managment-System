using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System
{
    internal class Book
    {
        string title;
        string author;
        string ISBN;
        bool availability;

        public Book(string title,string author,string ISBN)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            availability = true;
        }

        public string GetTitle()
        {
            return title;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public string GetAuthor()
        {
            return author;
        }
        public void SetAuthor(string author)
        {
            this.author = author;
        }
        public string GetISBN()
        {
            return ISBN;
        }
        public void SetISBN(string ISBN)
        {
            this.ISBN = ISBN;
        }

        public bool GetAvailability()
        {
            return availability;
        }
        public void SetAvailability(bool availability)
        { 
            this.availability = availability;
        }


    }
}
