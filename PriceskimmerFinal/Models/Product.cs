using System;
using System.Collections.Generic;
using System.Text;

namespace PriceskimmerFinal.Models
{
    internal class Product
    {
        Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public string Image { get; set; } // put a link that will show the image.

        public double price { get; set; }
        public List<Retailer> retailers { get; set; }
    }
}
