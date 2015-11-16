using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenTree
{
    class EvenTree
    {
        static void Main(String[] args)
        {
            string[] setup = Console.ReadLine().Split(' ');
            int numVertices = int.Parse(setup[0]);
            int numEdges = int.Parse(setup[1]);
            int[] tree = new int[numVertices];
            Dictionary<int, int> parents = new Dictionary<int, int>();
            for (int i = 0; i < numEdges; i++)
            {
                string[] edge = Console.ReadLine().Split(' ');
                int parentNode = Math.Min(int.Parse(edge[0]), int.Parse(edge[1]));
                int childNode = Math.Max(int.Parse(edge[0]), int.Parse(edge[1]));
                tree[parentNode]++;
                parents.Add(childNode, parentNode);
                int current = parentNode;
                while(parents.ContainsKey(current))
                {
                    current = parents[current];
                    tree[current]++;
                }

            }
            int count = 0;
            for (int i = 0; i < tree.Length; i++ )
            {
                if ((tree[i] + 1) % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(Math.Max(count -= 1, 0));
        }
    }
}
