using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.DS.BinarySearchTree
{
    internal class Runner
    {
        public static void Run()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            BinarySearchTreeHelper binarySearchTreeHelper = new BinarySearchTreeHelper();
            binarySearchTreeHelper.Insert(binarySearchTree, 20);
            binarySearchTreeHelper.Insert(binarySearchTree, 15);
            binarySearchTreeHelper.Insert(binarySearchTree, 25);
            binarySearchTreeHelper.Insert(binarySearchTree, 13);
            binarySearchTreeHelper.Insert(binarySearchTree, 18);
            binarySearchTreeHelper.Insert(binarySearchTree, 22);
            binarySearchTreeHelper.Insert(binarySearchTree, 45);
            binarySearchTreeHelper.Insert(binarySearchTree, 14);
            binarySearchTreeHelper.Insert(binarySearchTree, 17);
            binarySearchTreeHelper.Insert(binarySearchTree, 40);

            // This should output: 13 14 15 17 18 20 22 25 40 45
            binarySearchTreeHelper.RecursiveInorderTraversal(binarySearchTree.Root);
            Console.WriteLine();
        }
    }
}
