namespace DataStructures.GraphAdjacencyList
{
    internal sealed class AdjacencyListNode
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
