using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.DS.GraphAdjacencyList
{
    internal class AdjacencyListNode
    {
        internal string Value;
        internal float Weight;

        public AdjacencyListNode(string value, float weight)
        {
            Value = value;
            Weight = weight;
        }
    }
}
