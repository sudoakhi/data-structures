namespace Suhyphen.DS.GraphAdjacencyList
{
    internal class AdjacencyListNode
    {
        internal string _vertex;
        internal float _weight;

        public AdjacencyListNode(string vertex, float weight)
        {
            _vertex = vertex;
            _weight = weight;
        }
    }
}
