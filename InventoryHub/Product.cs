﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryHub
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }

}
