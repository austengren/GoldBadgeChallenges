using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class CafeMenu
    {
        //Constructor
        public CafeMenu(string name, int number, string description, string ingredients, decimal price)
        {
            Name = name;
            Number = number;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }

        //Properties
        public string Name { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set; }
    }
}
