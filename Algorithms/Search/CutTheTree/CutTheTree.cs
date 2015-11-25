using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutTheTree
{
    class CutTheTree
    {
        public class Node
        {
            public int val;
            public int total;
            public int index;
            public List<Node> connected;
        }
        static void Main(String[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double sum = 0;
            Node[] tree = new Node[num + 1];
            string[] nodes = Console.ReadLine().Split(' ');
            for (int i = 0; i < num; i++)
            {
                int v =  int.Parse(nodes[i]);
                tree[i + 1] = new Node() { val = v, total = v, index = i + 1, connected = new List<Node>() };
                sum += v;
            }
            for (int i = 0; i < num - 1; i++)
            {
                string[] edge = Console.ReadLine().Split(' ');
                int first = int.Parse(edge[0]);
                int second = int.Parse(edge[1]);
                tree[first].connected.Add(tree[second]);
                tree[second].connected.Add(tree[first]);
            }
            bool[] visited = new bool[num + 1];
            Dfs(tree[1], visited);
            double diff = (double)sum;
            for (int i = 1; i < num + 1; i++)
            {
                double tempDiff = Math.Abs(sum - 2 * tree[i].total);
                if (tempDiff < diff)
                {
                    diff = tempDiff;
                }
            }
            Console.WriteLine((int)diff);
        }

        private static int Dfs(Node node, bool[] visited)
        {
            visited[node.index] = true;
            for (int i = 0; i < node.connected.Count; i++)
            {
                if (!visited[node.connected.ElementAt(i).index])
                {
                    node.total += Dfs(node.connected.ElementAt(i), visited);
                }
            }
            return node.total;
        }
    }
}
