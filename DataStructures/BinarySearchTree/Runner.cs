using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BinarySearchTree
{
    internal static class Runner
    {
        public static void Run()
        {
            var binarySearchTree = new BinarySearchTree();
			BinarySearchTreeHelper.Insert ( binarySearchTree, 20);
			BinarySearchTreeHelper.Insert ( binarySearchTree, 15);
			BinarySearchTreeHelper.Insert ( binarySearchTree, 25);
			BinarySearchTreeHelper.Insert ( binarySearchTree, 13);
			BinarySearchTreeHelper.Insert ( binarySearchTree, 18);
			BinarySearchTreeHelper.Insert ( binarySearchTree, 22);
			BinarySearchTreeHelper.Insert ( binarySearchTree, 45);
			BinarySearchTreeHelper.Insert ( binarySearchTree, 14);
			BinarySearchTreeHelper.Insert ( binarySearchTree, 17);
			BinarySearchTreeHelper.Insert ( binarySearchTree, 40);

			// This should output: 13 14 15 17 18 20 22 25 40 45
			BinarySearchTreeHelper.RecursiveInorderTraversal ( binarySearchTree._root);
            Console.WriteLine();
        }
    }
}
