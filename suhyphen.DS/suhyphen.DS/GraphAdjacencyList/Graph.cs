using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.DS.GraphAdjacencyList
{
    internal class Graph
    {
        internal Dictionary<string, List<AdjacencyListNode>> AdjacencyList = new Dictionary<string, List<AdjacencyListNode>>();
        
        public Graph(List<Edge> edges)
        {
            foreach(Edge edge in edges)
            {
                if(AdjacencyList.ContainsKey(edge.Source))
                {
                    List<AdjacencyListNode> adjacencyListNodes = AdjacencyList[edge.Source];
                    AdjacencyListNode adjacencyListNode = new AdjacencyListNode(edge.Destination, edge.Weight);
                    adjacencyListNodes.Add(adjacencyListNode);
                    AdjacencyList[edge.Source] = adjacencyListNodes;
                }
                else
                {
                    AdjacencyListNode adjacencyListNode = new AdjacencyListNode(edge.Destination, edge.Weight);
                    List<AdjacencyListNode> adjacencyListNodes = new List<AdjacencyListNode>();
                    adjacencyListNodes.Add(adjacencyListNode);
                    AdjacencyList.Add(edge.Source, adjacencyListNodes);
                }   
            }
        }
    }
}
