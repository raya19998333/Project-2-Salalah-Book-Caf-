using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2____Salalah_Book_Café_.Moduls
{
    class MenuItem
    {
        public string Name { get; set; }
        public DrinkType Type { get; set; }
        public decimal Price { get; set; }

        public MenuItem(string name, DrinkType type, decimal price)
        {
            Name = name;
            Type = type;
            Price = price;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} ({Type}) - ${Price}");
        }
    }
}