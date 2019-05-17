using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DataStructures.BL.Heap
{
    /// <summary>
    /// Класс с вариантами Heap.
    /// </summary>
    public class HeapRun
    {
        Random rnd = new Random();
        private readonly int _count = 100;

        /// <summary>
        /// Демонстрация работы ImplementedHeap.
        /// </summary>
        public void ImplementedHeap()
        {
            var timer = new Stopwatch();
            var startItems = new List<int>();

            for (int i = 0; i < _count; i++)
            {
                startItems.Add(rnd.Next(0, 100));
            }

            timer.Start();
            var heap = new ImplementedHeap(startItems);
            timer.Stop();

            Console.WriteLine($"Initial initialization of {_count} elements - {timer.Elapsed}");

            timer.Restart();
            for (int i = 0; i < _count; i++)
            {
                heap.Add(rnd.Next(0, 100));
            }
            timer.Stop();

            Console.WriteLine($"Adding a second {_count} items - {timer.Elapsed}");
            Console.WriteLine();

            timer.Restart();

            foreach (var item in heap)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Output {_count * 2} items - {timer.Elapsed}");
        }
    }
}
