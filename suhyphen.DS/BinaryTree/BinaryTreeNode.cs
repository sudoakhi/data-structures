namespace Suhyphen.DS.BinaryTree
{
    internal class BinaryTreeNode
    {
        internal int Data;
        internal BinaryTreeNode Left;
        internal BinaryTreeNode Right;

        public BinaryTreeNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
