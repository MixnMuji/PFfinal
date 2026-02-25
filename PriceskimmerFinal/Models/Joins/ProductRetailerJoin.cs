using System;
using System.Collections.Generic;
using System.Text;

namespace PriceskimmerFinal.Models.Joins
{
    internal class ProductRetailerJoin
    {
        public Guid productID { get; set;}
        public Guid retailer { get; set; }
    }
}
