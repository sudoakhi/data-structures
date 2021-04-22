using System;

namespace suhyphen.DS.BinaryTree
{
    internal class Runner
    {
        public static void Run()
        {
            BinaryTree binaryTree = new BinaryTree();
            BinaryTreeHelper binaryTreeHelper = new BinaryTreeHelper();
            binaryTreeHelper.Insert(binaryTree, 20);
            binaryTreeHelper.Insert(binaryTree, 100);
            binaryTreeHelper.Insert(binaryTree, 3);
            binaryTreeHelper.Insert(binaryTree, 50);
            binaryTreeHelper.Insert(binaryTree, 15);
            binaryTreeHelper.Insert(binaryTree, 250);
            binaryTreeHelper.Insert(binaryTree, 35);
            binaryTreeHelper.Insert(binaryTree, 222);

            //This should output: 222 50 100 15 20 250 3 35
            binaryTreeHelper.RecursiveInorderTraversal(binaryTree.Root);
            Console.WriteLine();

            //This should output: 20 100 50 222 15 3 250 35
            binaryTreeHelper.RecursivePreorderTraversal(binaryTree.Root);
            Console.WriteLine();

            //This should output: 222 50 15 100 250 35 3 20
            binaryTreeHelper.RecursivePostorderTraversal(binaryTree.Root);
            Console.WriteLine();
        }
    }
}
