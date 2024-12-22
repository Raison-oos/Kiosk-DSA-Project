using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Program
{
    internal class CustomerOrder
    {
        public List<Order> orders { get; set; }
        public string timer { get;}
        public int totalPrice { get;}
        
        public CustomerOrder(List<Order> orders)
        {
            this.orders = new List<Order>(orders);
            this.timer = DateTime.Now.ToString("M-dd-yyyy");
            foreach(Order order in orders)
            {
                totalPrice += (order.price * order.count);
            }           

        }
    }
}
