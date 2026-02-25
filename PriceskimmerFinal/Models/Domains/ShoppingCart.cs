using System;
using System.Collections.Generic;
using System.Text;
using AndroidX.AppCompat.View.Menu;

namespace PriceskimmerFinal.Models.Domains
{
    internal class ShoppingCart
    {
        private readonly List<Cartitem> _products = new(); // fix in a bit
        public IReadOnlyList<Product> Proudcts = _products;
            public void add(Product product,int quantity)
        {
            _products.Add(new Cartiem
        }

    }
}
