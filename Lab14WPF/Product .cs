﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14WPF
{
    public enum ProductTypes
    {
        Eat,
        Device
    }

    public class Product
    {            
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public object ProductImage { get; set; }
        public ProductTypes ProductType { get; set; }
    }
}
