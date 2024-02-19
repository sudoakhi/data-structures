using System;
using System.Collections.Generic;

namespace suhyphen.DS.GraphAdjacencyList
{
    internal class GraphHelper
    {
        public static void DisplayGraph(Graph graph)
        {
            Console.WriteLine("Displaying Contents of the Graph ...");
            foreach (var entry in graph.VertexAdjacencyListNodesMap)
            {
                List<AdjacencyListNode> adjacencyListNodes = entry.Value;
                foreach(AdjacencyListNode adjacencyListNode in adjacencyListNodes)
                {
                    Console.Write("Vertex: " + entry.Key + " ==> " + adjacencyListNode.Vertex + "|" + adjacencyListNode.Weight + "\t");
                }

                Console.WriteLine();
            }
        }

        // Works for Connected and Undirected Graph
        public static void DepthFirstTraversal(Graph graph, string rootVertex)
        {
            List<string> depthFirstOrder = new List<string>();
            Stack<string> vertexStack = new Stack<string>();
            vertexStack.Push(rootVertex);
            while(vertexStack.Count > 0)
            {
                string currentVertex = vertexStack.Pop();
                depthFirstOrder.Add(currentVertex);
                List<AdjacencyListNode> adjacencyListNodes = graph.VertexAdjacencyListNodesMap[currentVertex];
                foreach(AdjacencyListNode adjacencyListNode in adjacencyListNodes)
                {
                    if(!depthFirstOrder.Contains(adjacencyListNode.Vertex) && !vertexStack.Contains(adjacencyListNode.Vertex))
                    {
                        vertexStack.Push(adjacencyListNode.Vertex);
                    }
                }
            }

            foreach(string vertex in depthFirstOrder)
            {
                Console.Write(vertex + " ");
            }

            Console.WriteLine();
        }

        // Works for Connected and Undirected Graph
        public static void BreadthFirstTraversal(Graph graph, string rootVertex)
        {
            List<string> breadthFirstOrder = new List<string>();
            Queue<string> vertexQueue = new Queue<string>();
            vertexQueue.Enqueue(rootVertex);
            while(vertexQueue.Count > 0)
            {
                string currentVertex = vertexQueue.Dequeue();
                breadthFirstOrder.Add(currentVertex);
                List<AdjacencyListNode> adjacencyListNodes = graph.VertexAdjacencyListNodesMap[currentVertex];
                foreach (AdjacencyListNode adjacencyListNode in adjacencyListNodes)
                {
                    if (!breadthFirstOrder.Contains(adjacencyListNode.Vertex) && !vertexQueue.Contains(adjacencyListNode.Vertex))
                    {
                        vertexQueue.Enqueue(adjacencyListNode.Vertex);
                    }
                }
            }

            foreach (string vertex in breadthFirstOrder)
            {
                Console.Write(vertex + " ");
            }

            Console.WriteLine();
        }
    }
}
