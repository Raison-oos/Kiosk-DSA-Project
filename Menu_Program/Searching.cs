using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Program
{
    internal class Searching
    {
        //Search Algorithm
        private static List<CustomerOrder> Search(List<CustomerOrder> arr, string search)
        {
            List<CustomerOrder> temp1 = new List<CustomerOrder>();
            foreach(CustomerOrder c in arr) {
                foreach(Order o in c.orders)
                {
                    if (o.name.ToLower().Contains(search.ToLower()))
                    {
                        temp1.Add(c);
                        break;
                    }
                    
                }
            }
            return temp1;
        }
        public static Stack<CustomerOrder> Search(Stack<CustomerOrder> arr, string search)
        {
            Stack<CustomerOrder> temp = new Stack<CustomerOrder>(Search(arr.ToList<CustomerOrder>(), search));
            return temp;
        }
        public static HashSet<CustomerOrder> Search(HashSet<CustomerOrder> arr, string search)
        {
            HashSet<CustomerOrder> temp = new HashSet<CustomerOrder>(Search(arr.ToList<CustomerOrder>(),search));
            return temp;
        }
    }
}
