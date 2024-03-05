using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase_of_books
{
    public class Book:Buys
    {
        string Author;
        public Book(string title, string author, double numcopies, double totalcost)
        :base(title, numcopies, totalcost)
        {
          this.Author = author;
        }
        public double buy()
        {
            double costbook;
            costbook = base.totalcost();
            return costbook;
        }
    }
}
