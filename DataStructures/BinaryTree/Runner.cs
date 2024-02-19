using System;

namespace DataStructures.BinaryTree
{
    internal static class Runner
    {
        public static void Run()
        {
            var binaryTree = new BinaryTree();
			BinaryTreeHelper.Insert ( binaryTree, 20);
			BinaryTreeHelper.Insert ( binaryTree, 100);
			BinaryTreeHelper.Insert ( binaryTree, 3);
			BinaryTreeHelper.Insert ( binaryTree, 50);
			BinaryTreeHelper.Insert ( binaryTree, 15);
			BinaryTreeHelper.Insert ( binaryTree, 250);
			BinaryTreeHelper.Insert ( binaryTree, 35);
			BinaryTreeHelper.Insert ( binaryTree, 222);

			//This should output: 222 50 100 15 20 250 3 35
			BinaryTreeHelper.RecursiveInorderTraversal ( binaryTree._root);
            Console.WriteLine();

			//This should output: 20 100 50 222 15 3 250 35
			BinaryTreeHelper.RecursivePreorderTraversal ( binaryTree._root);
            Console.WriteLine();

			//This should output: 222 50 15 100 250 35 3 20
			BinaryTreeHelper.RecursivePostorderTraversal ( binaryTree._root);
            Console.WriteLine();

			//This should output: 20 100 3 50 15 250 35 222
			BinaryTreeHelper.LevelOrderTraversal ( binaryTree._root);
            Console.WriteLine();

            // This should output: True
            var isValuePresent = BinaryTreeHelper.IsValuePresent(binaryTree._root, 100);
            Console.WriteLine(isValuePresent);

            // This should output: False
            isValuePresent = BinaryTreeHelper.IsValuePresent ( binaryTree._root, 99);
            Console.WriteLine(isValuePresent);

			BinaryTreeHelper.Delete ( binaryTree, 20);

			//This should output: 222 100 3 50 15 250 35
			BinaryTreeHelper.LevelOrderTraversal ( binaryTree._root);
            Console.WriteLine();

			BinaryTreeHelper.Delete ( binaryTree, 3);

			//This should output: 222 100 35 50 15 250
			BinaryTreeHelper.LevelOrderTraversal ( binaryTree._root);
            Console.WriteLine();
        }
    }
}
