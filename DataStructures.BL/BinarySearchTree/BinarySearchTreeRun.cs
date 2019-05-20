using System;

namespace DataStructures.BL.BinarySearchTree
{
    /// <summary>
    /// Класс с вариантами BinarySearchTree.
    /// </summary>
    public class BinarySearchTreeRun
    {
        Random rnd = new Random();

        /// <summary>
        /// Демонстрация работы BinarySearchTree.
        /// </summary>
        public void Tree()
        {
            var binarySearchTree = new Tree<int>();

            Console.WriteLine($"BinarySearchTree - count: {binarySearchTree.Count}");

            binarySearchTree.Add(rnd.Next(0, 100));
            binarySearchTree.Add(rnd.Next(0, 100));
            binarySearchTree.Add(rnd.Next(0, 100));
            binarySearchTree.Add(rnd.Next(0, 100));
            binarySearchTree.Add(rnd.Next(0, 100));
            binarySearchTree.Add(rnd.Next(0, 100));
            binarySearchTree.Add(rnd.Next(0, 100));
            binarySearchTree.Add(rnd.Next(0, 100));
            binarySearchTree.Add(rnd.Next(0, 100));

            Console.WriteLine($"BinarySearchTree - count: {binarySearchTree.Count}");
            Console.WriteLine();

            Console.WriteLine($"BinarySearchTree - Preorder:");
            foreach (var item in binarySearchTree.Preorder())
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n");

            Console.WriteLine($"BinarySearchTree - Postorder:");
            foreach (var item in binarySearchTree.Postorder())
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n");

            Console.WriteLine($"BinarySearchTree - Inorder:");
            foreach (var item in binarySearchTree.Inorder())
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}
