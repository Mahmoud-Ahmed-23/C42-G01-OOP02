﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assosiation.Composition
{
    internal class OrderItem
    {

        public int Id { get; set; }

        public Product Product { get; set; }
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public OrderItem(Product product)
        {
            Product = product;
        }
    }
}
