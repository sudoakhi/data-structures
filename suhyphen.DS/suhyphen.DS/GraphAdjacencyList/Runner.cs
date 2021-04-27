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
        }
    }
}
