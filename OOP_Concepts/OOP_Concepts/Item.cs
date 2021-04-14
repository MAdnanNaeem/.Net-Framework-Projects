using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    public abstract class Item
    {
        private int _id;
        private string _desc;
        private double _price;
        private int _count;

        public Item()
        {
        }

        public Item(int id, string desc, double price, int count)
        {
            Id = id;
            Desc = desc;
            Price = price;
            Count = count;
        }

        public int Id { get => _id; set => _id = value; }
        public string Desc { get => _desc; set => _desc = value; }
        public double Price { get => _price; set => _price = value; } 
        public int Count { get => _count; set => _count = value; }



        public virtual string Display() 
        {
            return Id +" "+ Desc +" "+ Price;
        }

        public abstract double CalculatePrice();
        
    }
}
