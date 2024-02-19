using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.DS.GraphAdjacencyList
{
    internal class Graph
    {
        internal Dictionary<string, List<AdjacencyListNode>> _vertexAdjacencyListNodesMap = [];
        
        public Graph(List<Edge> edges)
        {
            foreach(var edge in edges)
            {
                if(_vertexAdjacencyListNodesMap.TryGetValue(edge._sourceVertex, out var value))
                {
                    var adjacencyListNodes = value;
                    var adjacencyListNode = new AdjacencyListNode(edge._destinationVertex, edge._weight);
                    adjacencyListNodes.Add(adjacencyListNode);
                    _vertexAdjacencyListNodesMap[edge._sourceVertex] = adjacencyListNodes;
                }
                else
                {
                    var adjacencyListNode = new AdjacencyListNode(edge._destinationVertex, edge._weight);
                    var adjacencyListNodes = new List<AdjacencyListNode>
                    {
                        adjacencyListNode
                    };
                    _vertexAdjacencyListNodesMap.Add(edge._sourceVertex, adjacencyListNodes);
                }   
            }
        }
    }
}
