using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        private DateTime dateAdded;
        public DateTime DateAdded
        {
            get { return dateAdded; }
            set { dateAdded = value; }
        }

        public MenuItem(string name, double price, string category, DateTime dateAdded)
        {
            Name = name;
            Price = price;
            Category = category;
            DateAdded = dateAdded;
        }
    }
}
