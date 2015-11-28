using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimAndTheOrders
{
    class JimAndTheOrders
    {
        public class Order
        {
            public int ind;
            public int outTime;
        }

        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            SortedList<Order, string> orders = new SortedList<Order, string>(new OrderComparer());
            for (int i = 0; i < numCases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Order order = new Order() { ind = i + 1, outTime = int.Parse(input[0]) + int.Parse(input[1]) };
                orders.Add(order, "");
            }
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < orders.Count; i++)
            {
                builder.Append(orders.ElementAt(i).Key.ind + " ");
            }
            Console.WriteLine(builder.ToString().Substring(0, builder.Length - 1));
        }

        private class OrderComparer : IComparer<Order>
        {
            public int Compare(Order x, Order y)
            {
                int result = x.outTime.CompareTo(y.outTime);
                if (result == 0)
                    result = x.ind.CompareTo(y.ind);
                return result;
            }
        }
    }
}
