using System;
using System.Collections.Generic;

namespace Suhyphen.DS.BinaryTree
{
    internal class BinaryTreeHelper
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
                if (currentNode.Left == null)
                {
                    currentNode.Left = newNode;
                    return;
                }
                else if (currentNode.Right == null)
                {
                    currentNode.Right = newNode;
                    return;
                }
                else
                {
                    nodeQueue.Enqueue(currentNode.Left);
                    nodeQueue.Enqueue(currentNode.Right);
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
                if (currentNode.Data == value)
                {
                    currentNode.Data = GetDeepestNode ( binaryTree._root).Data;
					DeleteDeepestNode ( binaryTree._root);
                    return;
                }
                else
                {
                    if (currentNode.Left != null)
                    {
                        nodeQueue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right != null)
                    {
                        nodeQueue.Enqueue(currentNode.Right);
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

			RecursiveInorderTraversal ( node.Left);
            Console.Write(node.Data + " ");
			RecursiveInorderTraversal ( node.Right);
        }

        internal static void RecursivePreorderTraversal(BinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write(node.Data + " ");
			RecursivePreorderTraversal ( node.Left);
			RecursivePreorderTraversal ( node.Right);
        }

        internal static void RecursivePostorderTraversal(BinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }

			RecursivePostorderTraversal ( node.Left);
			RecursivePostorderTraversal ( node.Right);
            Console.Write(node.Data + " ");
        }

        internal static void LevelOrderTraversal(BinaryTreeNode rootNode)
        {
            var nodeQueue = new Queue<BinaryTreeNode>();
            nodeQueue.Enqueue(rootNode);
            while (nodeQueue.Count > 0)
            {
                var currentNode = nodeQueue.Dequeue();
                Console.Write(currentNode.Data + " ");

                if (currentNode.Left != null)
                {
                    nodeQueue.Enqueue(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    nodeQueue.Enqueue(currentNode.Right);
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
                if (currentNode.Data == value)
                {
                    return true;
                }

                if (currentNode.Left != null)
                {
                    nodeQueue.Enqueue(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    nodeQueue.Enqueue(currentNode.Right);
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

                if (currentNode.Left == null)
                {
                    previousNode.Right = null;
                    return;
                }

                if (currentNode.Right == null)
                {
                    currentNode.Left = null;
                    return;
                }

                nodeQueue.Enqueue(currentNode.Left);
                nodeQueue.Enqueue(currentNode.Right);
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

                if (currentNode.Left != null)
                {
                    nodeQueue.Enqueue(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    nodeQueue.Enqueue(currentNode.Right);
                }
            }

            return currentNode;
        }
        #endregion
    }
}
