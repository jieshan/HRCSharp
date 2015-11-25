using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLuck
{
    class CountLuck
    {
        public class Node 
        {
            public Node parent;
            public int row;
            public int col;
            public List<Node> adjacent;
        }
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++)
            {
                string[] dim = Console.ReadLine().Split(' ');
                int row = int.Parse(dim[0]);
                int col = int.Parse(dim[1]);
                string[] matrix = new string[row];
                Node start = null;
                for (int j = 0; j < row; j++)
                {
                    matrix[j] = Console.ReadLine();
                    if (matrix[j].Contains("M"))
                    {
                        start = new Node(){ parent = null, row = j, col = matrix[j].IndexOf("M"), adjacent = new List<Node>() };
                    }
                }
                int ron = int.Parse(Console.ReadLine());
                Queue<Node> toCheck = new Queue<Node>();
                toCheck.Enqueue(start);
                Node dest = null;
                string visited = " (" + start.row + "," + start.col +") ";
                while (toCheck.Count > 0)
                {
                    bool found = false;
                    Node curr = toCheck.Dequeue();
                    if (curr.col + 1 < col && matrix[curr.row][curr.col + 1] != 'X')
                    {
                        Node next = new Node() { parent = curr, row = curr.row, col = curr.col + 1, adjacent = new List<Node>() };
                        curr.adjacent.Add(next);
                        if (matrix[curr.row][curr.col + 1] == '*')
                        {
                            dest = next;
                            found = true;
                        }
                        else if (!visited.Contains(" (" + next.row + "," + next.col + ") "))
                        {
                            toCheck.Enqueue(next);
                            visited += " (" + next.row + "," + next.col + ") ";
                        }                           
                    }
                    if (curr.col - 1 >= 0 && matrix[curr.row][curr.col - 1] != 'X')
                    {
                        Node next = new Node() { parent = curr, row = curr.row, col = curr.col - 1, adjacent = new List<Node>() };
                        curr.adjacent.Add(next);
                        if (matrix[curr.row][curr.col - 1] == '*')
                        {
                            dest = next;
                            found = true;
                        }
                        else if (!visited.Contains(" (" + next.row + "," + next.col + ") "))
                        {
                            toCheck.Enqueue(next);
                            visited += " (" + next.row + "," + next.col + ") ";
                        }
                    }
                    if (curr.row + 1 < row && matrix[curr.row + 1][curr.col] != 'X')
                    {
                        Node next = new Node() { parent = curr, row = curr.row + 1, col = curr.col, adjacent = new List<Node>() };
                        curr.adjacent.Add(next);
                        if (matrix[curr.row + 1][curr.col] == '*')
                        {
                            dest = next;
                            found = true;
                        }
                        else if (!visited.Contains(" (" + next.row + "," + next.col + ") "))
                        {
                            toCheck.Enqueue(next);
                            visited += " (" + next.row + "," + next.col + ") ";
                        }
                    }
                    if (curr.row - 1 >= 0 && matrix[curr.row - 1][curr.col] != 'X')
                    {
                        Node next = new Node() { parent = curr, row = curr.row - 1, col = curr.col, adjacent = new List<Node>() };
                        curr.adjacent.Add(next);
                        if (matrix[curr.row - 1][curr.col] == '*')
                        {
                            dest = next;
                            found = true;
                        }
                        else if (!visited.Contains(" (" + next.row + "," + next.col + ") "))
                        {
                            toCheck.Enqueue(next);
                            visited += " (" + next.row + "," + next.col + ") ";
                        }
                    }
                    if (found)
                    {
                        break;
                    }
                }
                
                int count = start.adjacent.Count > 1 ? 1 : 0;
                Node previous = dest.parent;
                while (previous != null && previous.parent != null)
                {
                    if (previous.adjacent.Count > 2)
                    {
                        count++;
                    }
                    previous = previous.parent;
                }
                Console.WriteLine(count == ron ? "Impressed" : "Oops!");
            }
        }
    }
}
