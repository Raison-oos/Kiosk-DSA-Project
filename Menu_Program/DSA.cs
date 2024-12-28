using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Program
{
    internal class DSA
    {
        //Client Side
        public static Menu[] menus = new Menu[25];
        public static List<Order> currentOrder = new List<Order>();
        //public static LinkedList<List<Order>> customerOrder = new LinkedList<List<Order>>();

        //Server Side
        public static HashSet<CustomerOrder> overallLogs= new HashSet<CustomerOrder>();
        public static Stack<CustomerOrder> todayLogs = new Stack<CustomerOrder>();
        public static Queue<CustomerOrder> orders = new Queue<CustomerOrder>();
    }
}
