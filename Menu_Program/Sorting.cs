using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Program
{
    internal class Sorting
    {
        public static List<CustomerOrder> BubbleSort(List<CustomerOrder> arr)
        {
            CustomerOrder temp;
            int n = arr.Count;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].totalPrice > arr[j + 1].totalPrice)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }
            return arr;
        }
        public static Stack<CustomerOrder> BubbleSort(Stack<CustomerOrder> arr)
        {
            Stack<CustomerOrder> temp = new Stack<CustomerOrder>(BubbleSort(arr.ToList<CustomerOrder>()));
            return temp;
        }
        public static List<CustomerOrder> InsertionSort(List<CustomerOrder> arr)
        {
            int n = arr.Count;
            CustomerOrder temp;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i].totalPrice;
                temp = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j].totalPrice> key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
            return arr;
        }
        public static HashSet<CustomerOrder> InsertionSort(HashSet<CustomerOrder> arr)
        {
            HashSet<CustomerOrder> students = new HashSet<CustomerOrder>(InsertionSort(arr.ToList<CustomerOrder>()));
            return students;
        }
        //public static List<CustomerOrder> SelectionSort(List<CustomerOrder> arr)
        //{
        //    int n = arr.Count;
        //    for (int i = 0; i < n - 1; i++)
        //    {

        //        int min_idx = i;

        //        for (int j = i + 1; j < n; j++)
        //        {
        //            if (DateTime.Parse(arr[j].timer) < DateTime.Parse(arr[min_idx].timer))
        //            {
        //                min_idx = j;
        //            }
        //        }

        //        CustomerOrder temp = arr[i];
        //        arr[i] = arr[min_idx];
        //        arr[min_idx] = temp;
        //    }
        //    return arr;
        //}
        //public static HashSet<CustomerOrder> SelectionSort(HashSet<CustomerOrder> arr)
        //{
        //    HashSet<CustomerOrder> temp = new HashSet<CustomerOrder>(SelectionSort(arr.ToList<CustomerOrder>()));
        //    return temp;
        //}

    }


}

