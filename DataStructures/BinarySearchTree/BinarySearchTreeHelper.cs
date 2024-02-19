using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BinarySearchTree
{
    internal static class BinarySearchTreeHelper
    {
        internal static void Insert(BinarySearchTree binarySearchTree, int value)
        {
            var rootNode = binarySearchTree._root;
            var newNode = new BinarySearchTreeNode(value);

            if (rootNode == null)
            {
                binarySearchTree._root = newNode;
            }
            else
            {
                var currentNode = rootNode;

                while (true)
                {
                    var parentNode = currentNode;
                    if (newNode._data < currentNode._data)
                    {
                        currentNode = currentNode._left;
                        if (currentNode == null)
                        {
                            parentNode._left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        currentNode = currentNode._right;
                        if (currentNode == null)
                        {
                            parentNode._right = newNode;
                            return;
                        }
                    }
                }
            }
        }

        internal static void RecursiveInorderTraversal(BinarySearchTreeNode node)
        {
            if (node == null)
            {
                return;
            }

			RecursiveInorderTraversal ( node._left);
            Console.Write(node._data + " ");
			RecursiveInorderTraversal ( node._right);
        }
    }
}
