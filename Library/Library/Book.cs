using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string title { private set; get; }
        public string author { private set; get; }
        public string publisher { private set; get; }
        public int date { private set; get; }
        public string genre { private set; get; }
        public string isbn { private set; get; }
        public string status { set; get; }

        public Book (string title="", string author="", string publisher = "", int date = 0, string genre = "", string isbn = "")
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.date = date;
            this.genre = genre;
            this.isbn = isbn;
            status = "free";
        }
        public override string ToString()
        {
            string line = string.Format("|{0, -15}|{1, -15}|{2, -10}|{3, 5}|{4,-7}|{5,-8}|{6, -7}|", title, author, publisher, date, genre, isbn, status);
            return line;
        }
    }
}
