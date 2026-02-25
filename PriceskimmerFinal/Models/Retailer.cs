using System;
using System.Collections.Generic;
using System.Text;

namespace PriceskimmerFinal.Models
{
    internal class Retailer
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public double lattitude { get; set; } 
        public double longittude { get; set; }
        public List<Product> products { get; set; }
    }
}
