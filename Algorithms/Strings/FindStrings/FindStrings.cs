using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindStrings
{
    /** Note: Incomplete */
    class FindStrings
    {
        public class SuffixTree
        {
            public class Node
            {
                public int total = 1; 
                public int Index = -1;
                public Node[] Children = new Node[26];
                public Node parent = null;
            }

            public Node Root = new Node();
            public String[] Texts;

            public void InsertSuffix(string s, int from)
            {
                var cur = Root;
                for (int i = from; i < s.Length; i++)
                {
                    var c = s[i];
                    if (cur.Children[c - 97] == null)
                    {
                        var n = new Node() { Index = from, parent = cur };
                        cur.Children[c - 97] = n;
                        cur.total++;
                        Node p = cur.parent;
                        while (p != null)
                        {
                            p.total++;
                            p = p.parent;
                        }
                    }
                    cur = cur.Children[c - 97];
                }
            }

            public SuffixTree(string[] s)
            {
                Texts = s;
                for (int j = 0; j < s.Length; j++)
                {
                    for (var i = s[j].Length - 1; i >= 0; i--)
                    {
                        InsertSuffix(s[j], i);
                    }
                }
            }
        }

        static void findStrings(String[] array, int[] query)
        {
            SuffixTree tree = new SuffixTree(array);
            for (int i = 0; i < query.Length; i++)
            {
                bool skip = false;
                int q = query[i];
                if (q + 1 > tree.Root.total)
                {
                    Console.WriteLine("INVALID");
                    skip = true;
                }
                if (!skip)
                {
                    string output = "";
                    int pointer = 0;
                    SuffixTree.Node current = tree.Root;
                    while (pointer < 26)
                    {
                        char c = (char) (pointer + 97);
                        if (current.Children[pointer] != null)
                        {
                            int t = current.Children[pointer].total;
                            if (t < q)
                            {
                                q -= t;
                                pointer++;
                            }
                            else
                            {
                                output += c;
                                q--;
                                if (q == 0)
                                {
                                    break;
                                }
                                current = current.Children[pointer];
                                pointer = 0;
                            }
                        }
                        else
                        {
                            pointer++;
                        }
                    }
                    Console.WriteLine(output);
                }
            }
        }

        /* Tail starts here */
        static void Main(String[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(2000)));
            int _cases = Convert.ToInt32(Console.ReadLine());
            String[] _a = new String[_cases];
            for (int _a_i = 0; _a_i < _cases; _a_i++)
            {
                _a[_a_i] = Console.ReadLine();
            }

            int _query = Convert.ToInt32(Console.ReadLine());
            int[] query = new int[_query];

            for (int _a_i = 0; _a_i < _query; _a_i++)
            {
                query[_a_i] = Convert.ToInt32(Console.ReadLine());
            }

            findStrings(_a, query);
        }
    }
}
