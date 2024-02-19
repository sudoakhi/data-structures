using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.GraphAdjacencyList
{
    internal static class Runner
    {
        public static void Run()
        {
            var edge1 = new Edge("A", "B", 2);
			var edge2 = new Edge("A", "C", 4);
			var edge3 = new Edge("B", "C", 4);
			var edge4 = new Edge("C", "A", 5);
			var edge5 = new Edge("C", "B", 4);
			var edge6 = new Edge("D", "C", 3);
			var edge7 = new Edge("E", "F", 1);
			var edge8 = new Edge("F", "E", 3);

            var edgeList = new List<Edge>
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

			var graph = new Graph(edgeList);
            GraphHelper.DisplayGraph(graph);
            GraphHelper.DepthFirstTraversal(graph, "A");
            GraphHelper.BreadthFirstTraversal(graph, "A");

			var edge11 = new Edge("A", "B", 0);
			var edge12 = new Edge("B", "A", 0);
			var edge13 = new Edge("A", "C", 0);
			var edge14 = new Edge("C", "A", 0);
			var edge15 = new Edge("A", "D", 0);
			var edge16 = new Edge("D", "A", 0);
			var edge17 = new Edge("B", "C", 0);
			var edge18 = new Edge("C", "B", 0);
			var edge19 = new Edge("C", "E", 0);
			var edge20 = new Edge("E", "C", 0);

            edgeList =
			[
				edge11 ,
                edge12,
                edge13,
                edge14,
                edge15,
                edge16,
                edge17,
                edge18,
                edge19,
                edge20
            ];

			var newGraph = new Graph(edgeList);
            GraphHelper.DisplayGraph(newGraph);
            GraphHelper.DepthFirstTraversal(newGraph, "A");
            GraphHelper.BreadthFirstTraversal(newGraph, "A");
        }
    }
}
