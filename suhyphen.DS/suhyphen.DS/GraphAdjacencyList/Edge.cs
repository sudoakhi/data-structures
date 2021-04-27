using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.DS.GraphAdjacencyList
{
    internal class Edge
    {
        internal string Source;
        internal string Destination;
        internal int Weight;

        public Edge(string source, string destination, int weight)
        {
            Source = source;
            Destination = destination;
            Weight = weight;
        }
    }
}
