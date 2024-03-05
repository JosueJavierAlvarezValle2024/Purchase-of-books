using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase_of_books
{
    public class Buys
    {
        string Title;
        double Numcopies;
        double Onetimecost;

        public Buys (string title, double numcopies, double onetimecost) 
        {
            this.Title = title;
            this.Numcopies = numcopies;
            this.Onetimecost = onetimecost;
        }
        public double totalcost()
        {
            double ct = Onetimecost * Numcopies;
            return ct;
        }
    }
}
