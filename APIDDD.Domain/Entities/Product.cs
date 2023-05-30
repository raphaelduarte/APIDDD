﻿namespace APIDDD.Domain.Entities
{
    public class Product : Base
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}