﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PASTRY.Models
{
    public class Drink
    {
        public int Id { get; set; }
        public int IdImage { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string ImageDrink { get; set; }
    }
}
