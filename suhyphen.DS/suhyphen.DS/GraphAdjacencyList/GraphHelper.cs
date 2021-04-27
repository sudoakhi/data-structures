using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.DS.GraphAdjacencyList
{
    internal class GraphHelper
    {
        public static void DisplayGraph(Graph graph)
        {
            Console.WriteLine("Displaying Contents of the Graph ...");
            foreach (var entry in graph.AdjacencyList)
            {
                List<AdjacencyListNode> adjacencyListNodes = entry.Value;
                foreach(AdjacencyListNode adjacencyListNode in adjacencyListNodes)
                {
                    Console.Write("Vertex: " + entry.Key + " ==> " + adjacencyListNode.Value + "|" + adjacencyListNode.Weight + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
