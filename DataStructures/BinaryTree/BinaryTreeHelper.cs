using System;
using System.Collections.Generic;

namespace DataStructures.BinaryTree
{
    internal static class BinaryTreeHelper
    {
        // Insert a Node at the first empty location
        internal static void Insert(BinaryTree binaryTree, int value)
        {
            var newNode = new BinaryTreeNode(value);
            var rootNode = binaryTree._root;

            if (rootNode == null)
            {
                binaryTree._root = newNode;
                return;
            }

            var nodeQueue = new Queue<BinaryTreeNode>();
            nodeQueue.Enqueue(rootNode);
            while (nodeQueue.Count > 0)
            {
                var currentNode = nodeQueue.Dequeue();
                if (currentNode._left == null)
                {
                    currentNode._left = newNode;
                    return;
                }
                else if (currentNode._right == null)
                {
                    currentNode._right = newNode;
                    return;
                }
                else
                {
                    nodeQueue.Enqueue(currentNode._left);
                    nodeQueue.Enqueue(currentNode._right);
                }
            }
        }

        // Find the deepest Node in the Binary Tree
        // Replace the value to be deleted with the value of the deepest Node
        // Delete the deepest Node
        internal static void Delete(BinaryTree binaryTree, int value)
        {
            var rootNode = binaryTree._root;
            var nodeQueue = new Queue<BinaryTreeNode>();
            nodeQueue.Enqueue(rootNode);
            while (nodeQueue.Count > 0)
            {
                var currentNode = nodeQueue.Dequeue();
                if (currentNode._data == value)
                {
                    currentNode._data = GetDeepestNode(binaryTree._root)._data;
					DeleteDeepestNode(binaryTree._root);
                    return;
                }
                else
                {
                    if (currentNode._left != null)
                    {
                        nodeQueue.Enqueue(currentNode._left);
                    }

                    if (currentNode._right != null)
                    {
                        nodeQueue.Enqueue(currentNode._right);
                    }
                }
            }
        }

        internal static void RecursiveInorderTraversal(BinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }

			RecursiveInorderTraversal ( node._left);
            Console.Write(node._data + " ");
			RecursiveInorderTraversal ( node._right);
        }

        internal static void RecursivePreorderTraversal(BinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write(node._data + " ");
			RecursivePreorderTraversal ( node._left);
			RecursivePreorderTraversal ( node._right);
        }

        internal static void RecursivePostorderTraversal(BinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }

			RecursivePostorderTraversal ( node._left);
			RecursivePostorderTraversal ( node._right);
            Console.Write(node._data + " ");
        }

        internal static void LevelOrderTraversal(BinaryTreeNode rootNode)
        {
            var nodeQueue = new Queue<BinaryTreeNode>();
            nodeQueue.Enqueue(rootNode);
            while (nodeQueue.Count > 0)
            {
                var currentNode = nodeQueue.Dequeue();
                Console.Write(currentNode._data + " ");

                if (currentNode._left != null)
                {
                    nodeQueue.Enqueue(currentNode._left);
                }

                if (currentNode._right != null)
                {
                    nodeQueue.Enqueue(currentNode._right);
                }
            }
        }

        internal static bool IsValuePresent(BinaryTreeNode rootNode, int value)
        {
            var nodeQueue = new Queue<BinaryTreeNode>();
            nodeQueue.Enqueue(rootNode);
            while (nodeQueue.Count > 0)
            {
                var currentNode = nodeQueue.Dequeue();
                if (currentNode._data == value)
                {
                    return true;
                }

                if (currentNode._left != null)
                {
                    nodeQueue.Enqueue(currentNode._left);
                }

                if (currentNode._right != null)
                {
                    nodeQueue.Enqueue(currentNode._right);
                }
            }

            return false;
        }

        #region Private Functions
        private static void DeleteDeepestNode(BinaryTreeNode rootNode)
        {
            var nodeQueue = new Queue<BinaryTreeNode>();
            nodeQueue.Enqueue(rootNode);
            BinaryTreeNode currentNode = null;
            while (nodeQueue.Count > 0)
            {
                var previousNode = currentNode;
                currentNode = nodeQueue.Dequeue();

                if (currentNode._left == null)
                {
                    previousNode._right = null;
                    return;
                }

                if (currentNode._right == null)
                {
                    currentNode._left = null;
                    return;
                }

                nodeQueue.Enqueue(currentNode._left);
                nodeQueue.Enqueue(currentNode._right);
            }
        }

        private static BinaryTreeNode GetDeepestNode(BinaryTreeNode rootNode)
        {
            var nodeQueue = new Queue<BinaryTreeNode>();
            nodeQueue.Enqueue(rootNode);
            BinaryTreeNode currentNode = null;
            while (nodeQueue.Count > 0)
            {
                currentNode = nodeQueue.Dequeue();

                if (currentNode._left != null)
                {
                    nodeQueue.Enqueue(currentNode._left);
                }

                if (currentNode._right != null)
                {
                    nodeQueue.Enqueue(currentNode._right);
                }
            }

            return currentNode;
        }
        #endregion
    }
}
