using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    class BasicItem : Item
    {
        public BasicItem(int id, string desc, double price, int count) : base(id, desc, price, count)
        {
        }

        public override double CalculatePrice()
        {
            return this.Price;
        }
    }
}
