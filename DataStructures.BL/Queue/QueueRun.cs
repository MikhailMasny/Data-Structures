using System;
using System.Collections.Generic;

namespace DataStructures.BL.Queue
{
    /// <summary>
    /// Класс с вариантами Queue.
    /// </summary>
    public class QueueRun
    {
        public void BasicQueue()
        {
            var queue = new Queue<int>();

            Console.WriteLine($"BasicQueue - count: {queue.Count}");

            queue.Enqueue(111);
            queue.Enqueue(222);
            queue.Enqueue(333);

            Console.WriteLine($"BasicQueue - count: {queue.Count}");

            Console.WriteLine($"BasicQueue - dequeue item: {queue.Dequeue()}");
            Console.WriteLine($"BasicQueue - peek item: {queue.Peek()}");
            Console.WriteLine($"BasicQueue - dequeue item: {queue.Dequeue()}");

            Console.WriteLine($"BasicQueue - count: {queue.Count}");
        }


        /// <summary>
        /// Демонстрация работы EasyQueue.
        /// </summary>
        public void EasyQueue()
        {
            var easyQueue = new EasyQueue<int>();

            Console.WriteLine($"EasyQueue - count: {easyQueue.Count}");

            easyQueue.Enqueue(1);
            easyQueue.Enqueue(2);
            easyQueue.Enqueue(3);

            Console.WriteLine($"EasyQueue - count: {easyQueue.Count}");

            Console.WriteLine($"EasyQueue - dequeue item: {easyQueue.Dequeue()}");
            Console.WriteLine($"EasyQueue - peek item: {easyQueue.Peek()}");
            Console.WriteLine($"EasyQueue - dequeue item: {easyQueue.Dequeue()}");

            Console.WriteLine($"EasyQueue - count: {easyQueue.Count}");
        }

        /// <summary>
        /// Демонстрация работы ArrayQueue.
        /// </summary>
        public void ArrayQueue()
        {
            var arrayQueue = new ArrayQueue<int>(3);

            Console.WriteLine($"ArrayQueue - count: {arrayQueue.Count}");

            arrayQueue.Enqueue(4);
            arrayQueue.Enqueue(5);
            arrayQueue.Enqueue(6);

            Console.WriteLine($"ArrayQueue - count: {arrayQueue.Count}");

            Console.WriteLine($"ArrayQueue - dequeue item: {arrayQueue.Dequeue()}");
            Console.WriteLine($"ArrayQueue - peek item: {arrayQueue.Peek()}");
            Console.WriteLine($"ArrayQueue - dequeue item: {arrayQueue.Dequeue()}");

            Console.WriteLine($"ArrayQueue - count: {arrayQueue.Count}");
        }

        /// <summary>
        /// Демонстрация работы LinkedQueue.
        /// </summary>
        public void LinkedQueue()
        {
            var linkedQueue = new LinkedQueue<int>();

            Console.WriteLine($"LinkedQueue - count: {linkedQueue.Count}");

            linkedQueue.Enqueue(7);
            linkedQueue.Enqueue(8);
            linkedQueue.Enqueue(9);

            Console.WriteLine($"LinkedQueue - count: {linkedQueue.Count}");

            Console.WriteLine($"LinkedQueue - dequeue item: {linkedQueue.Dequeue()}");
            Console.WriteLine($"LinkedQueue - peek item: {linkedQueue.Peek()}");
            Console.WriteLine($"LinkedQueue - dequeue item: {linkedQueue.Dequeue()}");

            Console.WriteLine($"LinkedQueue - count: {linkedQueue.Count}");
        }

        /// <summary>
        /// Демонстрация работы EasyDeque.
        /// </summary>
        public void EasyDeque()
        {
            var easyDeque = new EasyDeque<int>();

            Console.WriteLine($"EasyDeque - count: {easyDeque.Count}");

            easyDeque.EnqueueFront(1);
            easyDeque.EnqueueFront(2);
            easyDeque.EnqueueFront(3);
            easyDeque.EnqueueBack(4);
            easyDeque.EnqueueBack(5);
            easyDeque.EnqueueFront(6);
            easyDeque.EnqueueBack(7);

            Console.WriteLine($"EasyDeque - count: {easyDeque.Count}");

            Console.WriteLine($"EasyDeque - dequeue front item: {easyDeque.DequeueFront()}");
            Console.WriteLine($"EasyDeque - dequeue back item: {easyDeque.DequeueBack()}");
            Console.WriteLine($"EasyDeque - dequeue front item: {easyDeque.DequeueFront()}");
            Console.WriteLine($"EasyDeque - dequeue back item: {easyDeque.DequeueBack()}");
            Console.WriteLine($"EasyDeque - dequeue front item: {easyDeque.DequeueFront()}");

            Console.WriteLine($"EasyDeque - count: {easyDeque.Count}");
        }

        /// <summary>
        /// Демонстрация работы DuplexLinkedDeque.
        /// </summary>
        public void DuplexLinkedDeque()
        {
            var duplexLinkedDeque = new DuplexLinkedDeque<int>();

            Console.WriteLine($"DuplexLinkedDeque - count: {duplexLinkedDeque.Count}");

            duplexLinkedDeque.EnqueueFront(111);
            duplexLinkedDeque.EnqueueFront(222);
            duplexLinkedDeque.EnqueueFront(333);
            duplexLinkedDeque.EnqueueBack(444);
            duplexLinkedDeque.EnqueueBack(555);

            Console.WriteLine($"DuplexLinkedDeque - count: {duplexLinkedDeque.Count}");

            Console.WriteLine($"DuplexLinkedDeque - dequeue front item: {duplexLinkedDeque.DequeueFront()}");
            Console.WriteLine($"DuplexLinkedDeque - dequeue back item: {duplexLinkedDeque.DequeueBack()}");
            Console.WriteLine($"DuplexLinkedDeque - dequeue front item: {duplexLinkedDeque.DequeueFront()}");
            Console.WriteLine($"DuplexLinkedDeque - dequeue back item: {duplexLinkedDeque.DequeueBack()}");

            Console.WriteLine($"DuplexLinkedDeque - count: {duplexLinkedDeque.Count}");
        }
    }
}
