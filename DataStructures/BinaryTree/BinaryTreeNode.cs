namespace DataStructures.BinaryTree
{
    internal sealed class BinaryTreeNode
    {
        internal int _data;
        internal BinaryTreeNode _left;
        internal BinaryTreeNode _right;

        public BinaryTreeNode(int data)
        {
            _data = data;
            _left = null;
            _right = null;
        }
    }
}
