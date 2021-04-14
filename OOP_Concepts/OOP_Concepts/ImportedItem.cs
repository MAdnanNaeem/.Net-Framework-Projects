using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    public class ImportedItem:Item
    {
        private double _taxRate;


        public ImportedItem(int id, string desc, double price, int count, double taxRate) : base(id, desc, price, count)
        {
            this.TaxRate = taxRate;
        }

        public override string Display()
        {
            return base.Display()+" "+ this._taxRate;
        }

        public override double CalculatePrice()
        {
            return this.Price + (this.Price * this.TaxRate) / 100;
        }

        public double TaxRate { get => _taxRate; set => _taxRate = value; }
    }
}
