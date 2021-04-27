using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.DS.GraphAdjacencyList
{
    internal class Runner
    {
        public static void Run()
        {
            Edge edge1 = new Edge("A", "B", 2);
            Edge edge2 = new Edge("A", "C", 4);
            Edge edge3 = new Edge("B", "C", 4);
            Edge edge4 = new Edge("C", "A", 5);
            Edge edge5 = new Edge("C", "B", 4);
            Edge edge6 = new Edge("D", "C", 3);
            Edge edge7 = new Edge("E", "F", 1);
            Edge edge8 = new Edge("F", "E", 3);

            List<Edge> edgeList = new List<Edge>
            {
                edge1,
                edge2,
                edge3,
                edge4,
                edge5,
                edge6,
                edge7,
                edge8
            };

            Graph graph = new Graph(edgeList);
            GraphHelper.DisplayGraph(graph);
            GraphHelper.DepthFirstTraversal(graph, "A");
            GraphHelper.BreadthFirstTraversal(graph, "A");

            Edge edge11 = new Edge("A", "B", 0);
            Edge edge12 = new Edge("B", "A", 0);
            Edge edge13 = new Edge("A", "C", 0);
            Edge edge14 = new Edge("C", "A", 0);
            Edge edge15 = new Edge("A", "D", 0);
            Edge edge16 = new Edge("D", "A", 0);
            Edge edge17 = new Edge("B", "C", 0);
            Edge edge18 = new Edge("C", "B", 0);
            Edge edge19 = new Edge("C", "E", 0);
            Edge edge20 = new Edge("E", "C", 0);

            edgeList = new List<Edge>
            {
                edge11,
                edge12,
                edge13,
                edge14,
                edge15,
                edge16,
                edge17,
                edge18,
                edge19,
                edge20
            };

            Graph newGraph = new Graph(edgeList);
            GraphHelper.DisplayGraph(newGraph);
            GraphHelper.DepthFirstTraversal(newGraph, "A");
            GraphHelper.BreadthFirstTraversal(newGraph, "A");
        }
    }
}
