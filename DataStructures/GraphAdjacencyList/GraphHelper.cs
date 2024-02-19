using System;
using System.Collections.Generic;

namespace DataStructures.GraphAdjacencyList
{
    internal static class GraphHelper
    {
        public static void DisplayGraph(Graph graph)
        {
            foreach (var entry in graph._vertexAdjacencyListNodesMap)
            {
                var adjacencyListNodes = entry.Value;
                foreach(var adjacencyListNode in adjacencyListNodes)
                {
                    Console.Write("Vertex: " + entry.Key + " ==> " + adjacencyListNode._vertex + "|" + adjacencyListNode._weight + "\t");
                }

                Console.WriteLine();
            }
        }

        // Works for Connected and Undirected Graph
        public static void DepthFirstTraversal(Graph graph, string rootVertex)
        {
            var depthFirstOrder = new List<string>();
            var vertexStack = new Stack<string>();
            vertexStack.Push(rootVertex);
            while(vertexStack.Count > 0)
            {
                var currentVertex = vertexStack.Pop();
                depthFirstOrder.Add(currentVertex);
                var adjacencyListNodes = graph._vertexAdjacencyListNodesMap[currentVertex];
                foreach(var adjacencyListNode in adjacencyListNodes)
                {
                    if(!depthFirstOrder.Contains(adjacencyListNode._vertex) && !vertexStack.Contains(adjacencyListNode._vertex))
                    {
                        vertexStack.Push(adjacencyListNode._vertex);
                    }
                }
            }

            foreach(var vertex in depthFirstOrder)
            {
                Console.Write(vertex + " ");
            }

            Console.WriteLine();
        }

        // Works for Connected and Undirected Graph
        public static void BreadthFirstTraversal(Graph graph, string rootVertex)
        {
            var breadthFirstOrder = new List<string>();
            var vertexQueue = new Queue<string>();
            vertexQueue.Enqueue(rootVertex);
            while(vertexQueue.Count > 0)
            {
                var currentVertex = vertexQueue.Dequeue();
                breadthFirstOrder.Add(currentVertex);
                var adjacencyListNodes = graph._vertexAdjacencyListNodesMap[currentVertex];
                foreach (var adjacencyListNode in adjacencyListNodes)
                {
                    if (!breadthFirstOrder.Contains(adjacencyListNode._vertex) && !vertexQueue.Contains(adjacencyListNode._vertex))
                    {
                        vertexQueue.Enqueue(adjacencyListNode._vertex);
                    }
                }
            }

            foreach (var vertex in breadthFirstOrder)
            {
                Console.Write(vertex + " ");
            }

            Console.WriteLine();
        }
    }
}
