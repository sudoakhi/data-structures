using System;
using System.Collections.Generic;

namespace suhyphen.DS.BinaryTree
{
    internal class BinaryTreeHelper
    {
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
    }
}
