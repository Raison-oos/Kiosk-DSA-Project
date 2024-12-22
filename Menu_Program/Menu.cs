using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Menu_Program
{
    internal class Menu
    {
        public string name { get; set; }
        public int price { get; set; }
        public string category { get; set; }
        public Image image { get; set; }
        //public string description { get; set; }

        public Menu(string name, int price, string category, Image image)
        {
            this.name = name;
            this.price = price;
            this.category = category;
            this.image = image;
        }
    }
}
