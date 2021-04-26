using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.DS.BinarySearchTree
{
    internal class BinarySearchTreeHelper
    {
        internal void Insert(BinarySearchTree binarySearchTree, int value)
        {
            Node rootNode = binarySearchTree.Root;
            Node newNode = new Node(value);

            if(rootNode == null)
            {
                binarySearchTree.Root = newNode;
            }
            else
            {
                Node currentNode = rootNode;

                while(true)
                {
                    Node parentNode = currentNode;
                    if(newNode.Data < currentNode.Data)
                    {
                        currentNode = currentNode.Left;
                        if(currentNode == null)
                        {
                            parentNode.Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.Right;
                        if(currentNode == null)
                        {
                            parentNode.Right = newNode;
                            return;
                        }
                    }
                }
            }
        }

        internal void Delete(BinarySearchTree binarySearchTree, int value)
        {
            //TODO
        }

        internal void RecursiveInorderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }

            RecursiveInorderTraversal(node.Left);
            Console.Write(node.Data + " ");
            RecursiveInorderTraversal(node.Right);
        }
    }
}
