using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    class DecorationItem:Item
    {
        private double disccount;

        public DecorationItem(int id, string desc, double price, int count, double dicount) : base(id, desc, price, count)
        {
            this.Disccount = dicount;
        }

        public double Disccount { get => disccount; set => disccount = value; }

        public override double CalculatePrice()
        {
            return this.Price - (this.Price*this.Disccount) / 100;
        }

        public override string Display()
        {
            return base.Display()+" "+this.Disccount ;
        }
    }
}
