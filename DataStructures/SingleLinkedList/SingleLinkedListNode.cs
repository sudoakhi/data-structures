namespace DataStructures.SingleLinkedList
{
    internal sealed class SingleLinkedListNode
    {
        internal int _data;
        internal SingleLinkedListNode _next;
        public SingleLinkedListNode(int data)
        {
            _data = data;
            _next = null;
        }
    }
}
