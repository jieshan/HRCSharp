using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BreadthFirstSearchShortestReach
{
    class BreadthFirstSearchShortestReach
    {
        static void Main(String[] args)
        {
            int numCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCases; i++)
            {
                string[] numNodesEdges = Console.ReadLine().Split(' ');
                int numNodes = int.Parse(numNodesEdges[0]);
                int numEdges = int.Parse(numNodesEdges[1]);
                Dictionary<int, List<int>> edges = new Dictionary<int, List<int>>();
                for (int j = 0; j < numEdges; j++)
                {
                    string[] edge = Console.ReadLine().Split(' ');
                    int nodeA = int.Parse(edge[0]);
                    int nodeB = int.Parse(edge[1]);
                    edges = AddDirectionalEdge(edges, nodeA, nodeB);
                    edges = AddDirectionalEdge(edges, nodeB, nodeA);
                }
                int start = int.Parse(Console.ReadLine());
                ProcessGraph(edges, start, numNodes);
            }
        }

        static void ProcessGraph(Dictionary<int, List<int>> dict, int start, int numNodes) 
        {
            int[] results = new int[numNodes];
            results = results.Select(i => -1).ToArray();
            List<int> outputList = null;
            Queue<int> toProcess = new Queue<int>();
            Queue<int> distances = new Queue<int>();
            List<int> traversed = new List<int>();
            traversed.Add(start);
            if (!dict.ContainsKey(start)) 
            {
                outputList = results.ToList();
                outputList.RemoveAt(start - 1);
                results = outputList.ToArray();
                Console.WriteLine(String.Join(" ", results));
                return;
            }
            int found = 0;
            for (int i = 0; i < dict[start].Count; i++)
            {
                var nextNode = dict[start][i];
                if (!traversed.Contains(nextNode) && !toProcess.Contains(nextNode))
                {
                    toProcess.Enqueue(nextNode);
                    distances.Enqueue(6);
                    results[dict[start][i] - 1] = 6;
                    found ++;
                }
            }
            while (found < numNodes - 1 && traversed.Count < numNodes && toProcess.Count > 0)
            {
                int currentNode = toProcess.Dequeue();
                int currentDistance = distances.Dequeue();
                if (dict.ContainsKey(currentNode)) 
                {
                    for (int i = 0; i < dict[currentNode].Count; i++)
                    {
                        var nextNode = dict[currentNode][i];
                        if (!traversed.Contains(nextNode) && !toProcess.Contains(nextNode))
                        {
                            toProcess.Enqueue(nextNode);
                            distances.Enqueue(currentDistance + 6);
                            results[nextNode - 1] = currentDistance + 6;
                            found++;
                        }
                    }
                }
                traversed.Add(currentNode);
            }
            outputList = results.ToList();
            outputList.RemoveAt(start - 1);
            results = outputList.ToArray();
            Console.WriteLine(String.Join(" ", results));
        }

        static Dictionary<int, List<int>> AddDirectionalEdge(Dictionary<int, List<int>> dict, int nodeA, int nodeB) 
        {
            if (dict.ContainsKey(nodeA))
            {
                if (!dict[nodeA].Contains(nodeB))
                {
                    dict[nodeA].Add(nodeB);
                }
            }
            else 
            {
                List<int> connections = new List<int>();
                connections.Add(nodeB);
                dict.Add(nodeA, connections);
            }
            return dict;
        }
    }
}
