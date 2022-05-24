using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms4
{
    public class Product
    {
        public Product(string name, string country, int cost)
        {
            Name = name;
            Country = country;
            Cost = cost;
        }

        public Product()
        {

        }
        public string Name { get; set; }

        public string Country { get; set; }

        public int Cost { get; set; }

        public override string ToString() => Name;
    }
}
