using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Menu_Program
{
    internal class Order
    {
        public string name { get; set; }
        public int price { get; set; }
        public int count { get; set; }
        public string category{ get; set; }
        public Image image{ get; set; }


        public Order(string name, int price, string category, int count, Image image)
        {
            this.name = name;
            this.price = price;
            this.count = count;
            this.category = category;
            this.image = image;
        }
    }
}
