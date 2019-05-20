using System;
using DataStructures.BL.HashTable;
using DataStructures.BL.List;
using DataStructures.BL.Map;
using DataStructures.BL.Queue;
using DataStructures.BL.Set;
using DataStructures.BL.Stack;
using DataStructures.BL.Tree;
using DataStructures.BL.Heap;
using DataStructures.BL.BinarySearchTree;
using DataStructures.BL.Graph;

namespace DataStructures.UI
{
    class Program
    {
        static void PressAnyKey()
        {
            Console.WriteLine("\nPress any key to continue..");
            Console.ReadLine();
        }

        #region GetInfo

        static void GetBasicInfo()
        {
            Console.WriteLine("Navigation menu");
            Console.WriteLine("==================================================");
            Console.WriteLine("Press the button 'S' to start example - Stack.");
            Console.WriteLine("Press the button 'Q' to start example - Queue.");
            Console.WriteLine("Press the button 'E' to start example - Set.");
            Console.WriteLine("Press the button 'B' to start example - HashTable.");
            Console.WriteLine("Press the button 'M' to start example - Map.");
            Console.WriteLine("Press the button 'L' to start example - List.");
            Console.WriteLine("Press the button 'T' to start example - Tree.");
            Console.WriteLine("Press the button 'H' to start example - Heap.");
            Console.WriteLine("Press the button 'N' to start example - BinarySearchTree.");
            Console.WriteLine("Press the button 'G' to start example - Graph.");
            Console.WriteLine("Press the button 'X' to start example - Exit.");
            Console.WriteLine("==================================================");
        }
        static void GetStackInfo()
        {
            Console.WriteLine("Navigation menu of Stack");
            Console.WriteLine("=========================");
            Console.WriteLine("B - BasicStack");
            Console.WriteLine("E - EasyStack");
            Console.WriteLine("L - LinkedStack");
            Console.WriteLine("A - ArrayStack");
            Console.WriteLine("X - Exit to main menu");
            Console.WriteLine("=========================");
        }
        static void GetQueueInfo()
        {
            Console.WriteLine("Navigation menu of Queue");
            Console.WriteLine("=========================");
            Console.WriteLine("B - BasicQueue");
            Console.WriteLine("E - EasyQueue");
            Console.WriteLine("A - ArrayQueue");
            Console.WriteLine("L - LinkedQueue");
            Console.WriteLine("S - EasyDeque");
            Console.WriteLine("D - DuplexLinkedDeque");
            Console.WriteLine("X - Exit to main menu");
            Console.WriteLine("=========================");
        }
        static void GetHashTableInfo()
        {
            Console.WriteLine("Navigation menu of HashTable");
            Console.WriteLine("=========================");
            Console.WriteLine("B - BasicHashTable");
            Console.WriteLine("T - BadHashTable");
            Console.WriteLine("R - ReleaseHashTabel");
            Console.WriteLine("S - SuperHashTable");
            Console.WriteLine("X - Exit to main menu");
            Console.WriteLine("=========================");
        }
        static void GetMapInfo()
        {
            Console.WriteLine("Navigation menu of Map");
            Console.WriteLine("=========================");
            Console.WriteLine("B - BasicDictionary");
            Console.WriteLine("E - EasyMap");
            Console.WriteLine("D - ImplementedDictionary");
            Console.WriteLine("X - Exit to main menu");
            Console.WriteLine("=========================");
        }
        static void GetListInfo()
        {
            Console.WriteLine("Navigation menu of List");
            Console.WriteLine("=========================");
            Console.WriteLine("B - BasicList");
            Console.WriteLine("L - BasicLinkedList");
            Console.WriteLine("I - ImplementedLinkedList");
            Console.WriteLine("D - DuplexLinkedList");
            Console.WriteLine("C - CircularLinkedList");
            Console.WriteLine("X - Exit to main menu");
            Console.WriteLine("=========================");
        }

        #endregion

        #region BeginMethod

        static void BeginStack(StackRun stackRun)
        {
            Console.Clear();
            GetStackInfo();
            Console.Write("\nClick on a specific button: ");
            var key = Console.ReadKey();
            Console.WriteLine();

            switch (key.Key)
            {
                case ConsoleKey.B:
                    {
                        Console.Clear();
                        stackRun.BasicStack();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.E:
                    {
                        Console.Clear();
                        stackRun.EasyStack();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.L:
                    {
                        Console.Clear();
                        stackRun.LinkedStack();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.A:
                    {
                        Console.Clear();
                        stackRun.ArrayStack();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.X:
                    {
                    }
                    break;
            }
        }
        static void BeginQueue(QueueRun queueRun)
        {
            Console.Clear();
            GetQueueInfo();
            Console.Write("\nClick on a specific button: ");
            var key = Console.ReadKey();
            Console.WriteLine();

            switch (key.Key)
            {
                case ConsoleKey.B:
                    {
                        Console.Clear();
                        queueRun.BasicQueue();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.E:
                    {
                        Console.Clear();
                        queueRun.EasyQueue();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.A:
                    {
                        Console.Clear();
                        queueRun.ArrayQueue();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.L:
                    {
                        Console.Clear();
                        queueRun.LinkedQueue();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.S:
                    {
                        Console.Clear();
                        queueRun.EasyDeque();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.D:
                    {
                        Console.Clear();
                        queueRun.DuplexLinkedDeque();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.X:
                    {
                    }
                    break;
            }
        }
        static void BeginSet(SetRun setRun)
        {
            Console.Clear();
            setRun.EasySet();
            PressAnyKey();
        }
        static void BeginHashTable(HashTableRun hashTableRun)
        {
            Console.Clear();
            GetHashTableInfo();
            Console.Write("\nClick on a specific button: ");
            var keyMap = Console.ReadKey();
            Console.WriteLine();

            switch (keyMap.Key)
            {
                case ConsoleKey.B:
                    {
                        Console.Clear();
                        hashTableRun.BasicHashTable();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.T:
                    {
                        Console.Clear();
                        hashTableRun.BadHashTable();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.R:
                    {
                        Console.Clear();
                        hashTableRun.ReleaseHashTabel();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.S:
                    {
                        Console.Clear();
                        hashTableRun.SuperHashTable();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.X:
                    {
                    }
                    break;
            }
        }
        static void BeginMap(MapRun mapRun)
        {
            Console.Clear();
            GetMapInfo();
            Console.Write("\nClick on a specific button: ");
            var keyMap = Console.ReadKey();
            Console.WriteLine();

            switch (keyMap.Key)
            {
                case ConsoleKey.B:
                    {
                        Console.Clear();
                        mapRun.BasicDictionary();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.E:
                    {
                        Console.Clear();
                        mapRun.EasyMap();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.D:
                    {
                        Console.Clear();
                        mapRun.ImplementedDictionary();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.X:
                    {
                    }
                    break;
            }
        }
        static void BeginList(ListRun listRun)
        {
            Console.Clear();
            GetListInfo();
            Console.Write("\nClick on a specific button: ");
            var key = Console.ReadKey();
            Console.WriteLine();

            switch (key.Key)
            {
                case ConsoleKey.B:
                    {
                        Console.Clear();
                        listRun.BasicList();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.L:
                    {
                        Console.Clear();
                        listRun.BasicLinkedList();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.I:
                    {
                        Console.Clear();
                        listRun.ImplementedLinkedList();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.D:
                    {
                        Console.Clear();
                        listRun.DuplexLinkedList();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.C:
                    {
                        Console.Clear();
                        listRun.CircularLinkedList();
                        PressAnyKey();
                    }
                    break;

                case ConsoleKey.X:
                    {
                    }
                    break;
            }
        }
        static void BeginTree(TreeRun treeRun)
        {
            Console.Clear();
            treeRun.ImplementedTree();
            PressAnyKey();
        }
        static void BeginHeap(HeapRun heapRun)
        {
            Console.Clear();
            heapRun.ImplementedHeap();
            PressAnyKey();
        }
        static void BeginBinarySearchTree(BinarySearchTreeRun binarySearchTreeRun)
        {
            Console.Clear();
            binarySearchTreeRun.Tree();
            PressAnyKey();
        }
        static void BeginGraph(GraphRun graphRun)
        {
            Console.Clear();
            graphRun.Graph();
            PressAnyKey();
        }

        #endregion

        static void Main(string[] args)
        {
            var stackRun = new StackRun();
            var queueRun = new QueueRun();
            var setRun = new SetRun();
            var hashTableRun = new HashTableRun();
            var mapRun = new MapRun();
            var listRun = new ListRun();
            var treeRun = new TreeRun();
            var heapRun = new HeapRun();
            var binarySearchTreeRun = new BinarySearchTreeRun();
            var graphRun = new GraphRun();
            
            while (true)
            {
                Console.Clear();
                GetBasicInfo();

                Console.Write("\nClick on a specific button: ");
                var key = Console.ReadKey();
                Console.WriteLine();

                switch (key.Key)
                {
                    case ConsoleKey.S:
                        {
                            BeginStack(stackRun);
                        }
                        break;

                    case ConsoleKey.Q:
                        {
                            BeginQueue(queueRun);
                        }
                        break;

                    case ConsoleKey.E:
                        {
                            BeginSet(setRun);
                        }
                        break;

                    case ConsoleKey.B:
                        {
                            BeginHashTable(hashTableRun);
                        }
                        break;

                    case ConsoleKey.M:
                        {
                            BeginMap(mapRun);
                        }
                        break;

                    case ConsoleKey.L:
                        {
                            BeginList(listRun);
                        }
                        break;

                    case ConsoleKey.T:
                        {
                            BeginTree(treeRun);
                        }
                        break;

                    case ConsoleKey.H:
                        {
                            BeginHeap(heapRun);
                        }
                        break;

                    case ConsoleKey.N:
                        {
                            BeginBinarySearchTree(binarySearchTreeRun);
                        }
                        break;

                    case ConsoleKey.G:
                        {
                            BeginGraph(graphRun);
                        }
                        break;

                    case ConsoleKey.X:
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
            }
        }
    }
}
