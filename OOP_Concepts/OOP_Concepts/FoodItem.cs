using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    public class FoodItem:Item
    {
        private DateTime _expDate;


        public FoodItem(int id, string desc, double price, int count, DateTime expDate) : base(id, desc, price, count)
        {
            this.ExpDate = expDate;
        }

        public DateTime ExpDate { get => _expDate; set => _expDate = value; }

        public override double CalculatePrice()
        {
            return this.Price;
        }

        public override string Display()
        {
            return base.Display() + "   " + this._expDate;
        }
    }
}
