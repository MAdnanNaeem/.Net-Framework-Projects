using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    class Inventory
    {
        private List<Item> myItem;
     
        
        public Inventory()
        {
            myItem = new List<Item>();
            
        }

        public List<Item> MyItem { get => myItem; set => myItem = value; }
      
        public void addItem()
        {
            Item I1 = new BasicItem(1, "Chocolate", 250,5);
            Item I2 = new BasicItem(2, "Face Wash", 150,1);
            Item I3 = new BasicItem(3, "Hair Brush", 500,3);
            Item I4 = new ImportedItem(4, "Jam", 1000, 6, 30.00);
            Item I5 = new FoodItem(5, "Bread", 120, 1, new DateTime(2021,04,14));
            Item I6 = new DecorationItem(6, "Flowers", 1200, 2, 10);


            myItem.Add(I1);
            myItem.Add(I2);
            myItem.Add(I3);
            myItem.Add(I4);
            myItem.Add(I5);
            myItem.Add(I6);

           

        }


    }
}
