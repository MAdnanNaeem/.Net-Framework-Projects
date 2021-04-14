using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    class BasicItem : Item, ReturnableItem
    {
        public BasicItem(int id, string desc, double price, int count) : base(id, desc, price, count)
        {
        }

        public override string Display()
        {
            return base.Display() +"   "+ ReturnPolicy();
        }

        public override double CalculatePrice()
        {
            return this.Price;
        }

        public string ReturnPolicy()
        {
           return "Basic Items can be return able";
        }
    }
}
