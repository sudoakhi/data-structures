using System;
using System.Collections.Generic;

namespace suhyphen.DS.BinaryTree
{
    internal class BinaryTreeHelper
    {
        // Insert a Node at the first empty location
        internal void Insert(BinaryTree binaryTree, int value)
        {
            Node newNode = new Node(value);
            Node rootNode = binaryTree.Root;

            if(rootNode == null)
            {
                binaryTree.Root = newNode;
                return;
            }

            Queue<Node> nodeQueue = new Queue<Node>();
            nodeQueue.Enqueue(rootNode);
            while(nodeQueue.Count > 0)
            {
                Node currentNode = nodeQueue.Dequeue();
                if(currentNode.Left == null)
                {
                    currentNode.Left = newNode;
                    return;
                }
                else if(currentNode.Right == null)
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
        internal void Delete(BinaryTree binaryTree, int value)
        {
            Node rootNode = binaryTree.Root;
            Queue<Node> nodeQueue = new Queue<Node>();
            nodeQueue.Enqueue(rootNode);
            while (nodeQueue.Count > 0)
            {
                Node currentNode = nodeQueue.Dequeue();
                if(currentNode.Data == value)
                {
                    currentNode.Data = GetDeepestNode(binaryTree.Root).Data;
                    DeleteDeepestNode(binaryTree.Root);
                    return;
                }
                else
                {
                    if(currentNode.Left != null)
                    {
                        nodeQueue.Enqueue(currentNode.Left);
                    }

                    if(currentNode.Right != null)
                    {
                        nodeQueue.Enqueue(currentNode.Right);
                    }
                }
            }

            Console.WriteLine("Value nor present in the Binary Tree");
        }

        internal void RecursiveInorderTraversal(Node node)
        {
            if(node == null)
            {
                return;
            }

            RecursiveInorderTraversal(node.Left);
            Console.Write(node.Data + " ");
            RecursiveInorderTraversal(node.Right);
        }

        internal void RecursivePreorderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write(node.Data + " ");
            RecursivePreorderTraversal(node.Left);
            RecursivePreorderTraversal(node.Right);
        }

        internal void RecursivePostorderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }

            RecursivePostorderTraversal(node.Left);
            RecursivePostorderTraversal(node.Right);
            Console.Write(node.Data + " ");
        }

        internal void LevelOrderTraversal(Node rootNode)
        {
            Queue<Node> nodeQueue = new Queue<Node>();
            nodeQueue.Enqueue(rootNode);
            while(nodeQueue.Count > 0)
            {
                Node currentNode = nodeQueue.Dequeue();
                Console.Write(currentNode.Data + " ");

                if(currentNode.Left != null)
                {
                    nodeQueue.Enqueue(currentNode.Left);
                }

                if(currentNode.Right != null)
                {
                    nodeQueue.Enqueue(currentNode.Right);
                }
            }
        }

        internal bool IsValuePresent(Node rootNode, int value)
        {
            Queue<Node> nodeQueue = new Queue<Node>();
            nodeQueue.Enqueue(rootNode);
            while (nodeQueue.Count > 0)
            {
                Node currentNode = nodeQueue.Dequeue();
                if(currentNode.Data == value)
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
        private void DeleteDeepestNode(Node rootNode)
        {
            Queue<Node> nodeQueue = new Queue<Node>();
            nodeQueue.Enqueue(rootNode);
            Node currentNode = null;
            while (nodeQueue.Count > 0)
            {
                Node previousNode = currentNode;
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

        private Node GetDeepestNode(Node rootNode)
        {
            Queue<Node> nodeQueue = new Queue<Node>();
            nodeQueue.Enqueue(rootNode);
            Node currentNode = null;
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
