using DataStructures.BL.HashTable;
using DataStructures.BL.List;
using DataStructures.BL.Map;
using DataStructures.BL.Queue;
using DataStructures.BL.Set;
using DataStructures.BL.Stack;
using DataStructures.BL.Tree;
using DataStructures.BL.Heap;
using System;
using DataStructures.BL.BinarySearchTree;

// TODO: Реализовать через while вызов всех возможных структур.

namespace DataStructures.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackRun = new StackRun();
            var queueRun = new QueueRun();
            var setRun = new SetRun();
            var hashtableRun = new HashTableRun();
            var mapRun = new MapRun();
            var listRun = new ListRun();
            var treeRun = new TreeRun();
            var heapRun = new HeapRun();
            var binarySearchTree = new BinarySearchTreeRun();

            Console.ReadLine();
        }
    }
}
