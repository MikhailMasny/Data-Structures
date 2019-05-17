using System;

namespace DataStructures.BL.Tree
{
    /// <summary>
    /// Класс с вариантами Tree.
    /// </summary>
    public class TreeRun
    {
        Random rnd = new Random();

        private static void Search(ImplementedTree<int> trie, string word)
        {
            if (trie.TrySearch(word, out int value))
            {
                Console.WriteLine($"{word} {value}");
            }
            else
            {
                Console.WriteLine($"No found - {word}!");
            }
        }

        /// <summary>
        /// Демонстрация работы Tree.
        /// </summary>
        public void ImplementedTree()
        {
            var tree = new ImplementedTree<int>();

            Console.WriteLine($"Tree - count: {tree.Count}");

            var guid1 = Guid.NewGuid().ToString();
            var guid2 = Guid.NewGuid().ToString();

            tree.Add(Guid.NewGuid().ToString(), rnd.Next(0, 100));
            tree.Add(guid1, rnd.Next(0, 100));
            tree.Add(Guid.NewGuid().ToString(), rnd.Next(0, 100));
            tree.Add(guid2, rnd.Next(0, 100));
            tree.Add(Guid.NewGuid().ToString(), rnd.Next(0, 100));

            Console.WriteLine($"Tree - count: {tree.Count}");

            tree.Remove(guid1);
            tree.Remove(guid2);

            Console.WriteLine($"Tree - count after delete: {tree.Count}");

            Search(tree, guid1);
            Search(tree, guid2);
            Search(tree, Guid.NewGuid().ToString());
        }
    }
}
