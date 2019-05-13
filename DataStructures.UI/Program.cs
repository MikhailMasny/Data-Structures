using DataStructures.BL.HashTable;
using DataStructures.BL.Queue;
using DataStructures.BL.Set;
using DataStructures.BL.Stack;
using System;

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

            Console.ReadLine();
        }
    }
}
