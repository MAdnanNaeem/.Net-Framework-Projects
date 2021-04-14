using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Concepts
{
    public partial class Form1 : Form
    {
        private Inventory inventory;

        public Form1()
        {
            InitializeComponent();

            inventory = new Inventory();
             
        }

        private void rtb_item_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inventory.addItem();
             foreach (Item I in inventory.MyItem)
            {
                rtb_item.Text += I.Display();
                rtb_item.Text += "  "+I.CalculatePrice();
                rtb_item.Text += "\n";
            }
        }
    }
}
