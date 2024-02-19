using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.DS.GraphAdjacencyList
{
    internal class Graph
    {
        internal Dictionary<string, List<AdjacencyListNode>> VertexAdjacencyListNodesMap = new Dictionary<string, List<AdjacencyListNode>>();
        
        public Graph(List<Edge> edges)
        {
            foreach(Edge edge in edges)
            {
                if(VertexAdjacencyListNodesMap.ContainsKey(edge.SourceVertex))
                {
                    List<AdjacencyListNode> adjacencyListNodes = VertexAdjacencyListNodesMap[edge.SourceVertex];
                    AdjacencyListNode adjacencyListNode = new AdjacencyListNode(edge.DestinationVertex, edge.Weight);
                    adjacencyListNodes.Add(adjacencyListNode);
                    VertexAdjacencyListNodesMap[edge.SourceVertex] = adjacencyListNodes;
                }
                else
                {
                    AdjacencyListNode adjacencyListNode = new AdjacencyListNode(edge.DestinationVertex, edge.Weight);
                    List<AdjacencyListNode> adjacencyListNodes = new List<AdjacencyListNode>
                    {
                        adjacencyListNode
                    };
                    VertexAdjacencyListNodesMap.Add(edge.SourceVertex, adjacencyListNodes);
                }   
            }
        }
    }
}
