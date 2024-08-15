namespace DataStructures.SingleLinkedList
{
    internal sealed class SingleLinkedListNode
    {
        internal int _value;
        internal SingleLinkedListNode _next;
        public SingleLinkedListNode(int value)
        {
            _value = value;
            _next = null;
        }
    }
}
