using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BL.List
{
    /// <summary>
    /// Класс с вариантами List.
    /// </summary>
    public class ListRun
    {
        Random rnd = new Random();

        /// <summary>
        /// Демонстрация работы базового List.
        /// </summary>
        public void BasicList()
        {
            var list = new List<int>();

            Console.WriteLine($"BasicList - count: {list.Count}");
            var rndValue = rnd.Next(0, 100);

            list.Add(rnd.Next(0, 100));
            list.Add(rnd.Next(0, 100));
            list.Add(rnd.Next(0, 100));
            list.Add(rnd.Next(0, 100));
            list.Add(rndValue);

            Console.WriteLine($"BasicList - count: {list.Count}");

            list.Remove(rndValue);

            Console.WriteLine($"BasicList - count after delete: {list.Count}");

            foreach (var item in list)
            {
                Console.WriteLine($"BasicList - Item: {item}");
            }
        }

        /// <summary>
        /// Демонстрация работы базового LinkedList.
        /// </summary>
        public void BasicLinkedList()
        {
            var list = new LinkedList<string>();

            Console.WriteLine($"BasicLinkedList - count: {list.Count}");

            list.AddFirst(Guid.NewGuid().ToString());
            list.AddFirst(Guid.NewGuid().ToString());
            list.AddFirst(Guid.NewGuid().ToString());
            list.AddFirst(Guid.NewGuid().ToString());
            list.AddFirst(Guid.NewGuid().ToString());

            Console.WriteLine($"BasicLinkedList - count: {list.Count}");

            list.RemoveFirst();

            Console.WriteLine($"BasicLinkedList - count after delete: {list.Count}");

            foreach (var item in list)
            {
                Console.WriteLine($"BasicLinkedList - Item: {item}");
            }
        }

        /// <summary>
        /// Демонстрация работы базового ImplementedLinkedList.
        /// </summary>
        public void ImplementedLinkedList()
        {
            var list = new ImplementedLinkedList<int>();

            Console.WriteLine($"ImplementedLinkedList - count: {list.Count}");
            var rndValue = rnd.Next(0, 100);

            list.Add(rnd.Next(0, 100));
            list.Add(rnd.Next(0, 100));
            list.Add(rnd.Next(0, 100));
            list.Add(rndValue);
            list.Add(rnd.Next(0, 100));

            Console.WriteLine($"ImplementedLinkedList - count: {list.Count}");

            list.Delete(rndValue);

            Console.WriteLine($"ImplementedLinkedList - count: {list.Count}");

            list.AppendHead(rnd.Next(0, 100));
            list.InsertAfter(4, rnd.Next(0, 100));

            Console.WriteLine($"ImplementedLinkedList - count after added some elements: {list.Count}");

            foreach (var item in list)
            {
                Console.WriteLine($"ImplementedLinkedList - Item: {item}");
            }
        }

        /// <summary>
        /// Демонстрация работы базового DuplexLinkedList.
        /// </summary>
        public void DuplexLinkedList()
        {
            var duplexList = new DuplexLinkedList<int>();

            Console.WriteLine($"DuplexLinkedList - count: {duplexList.Count}");
            var rndValue = rnd.Next(0, 100);

            duplexList.Add(rnd.Next(0, 100));
            duplexList.Add(rndValue);
            duplexList.Add(rnd.Next(0, 100));
            duplexList.Add(rnd.Next(0, 100));
            duplexList.Add(rnd.Next(0, 100));

            Console.WriteLine($"DuplexLinkedList - count: {duplexList.Count}");

            duplexList.Delete(rndValue);

            Console.WriteLine($"DuplexLinkedList - count after delete: {duplexList.Count}");

            foreach (var item in duplexList)
            {
                Console.WriteLine($"DuplexLinkedList - Item: {item}");
            }

            var reverse = duplexList.Reverse();

            Console.WriteLine("\nAfter Reverse..\n");
            foreach (var item in reverse)
            {
                Console.WriteLine($"DuplexLinkedList - Item: {item}");
            }
        }

        /// <summary>
        /// Демонстрация работы базового CircularLinkedList.
        /// </summary>
        public void CircularLinkedList()
        {
            var circularList = new CircularLinkedList<string>();

            Console.WriteLine($"CircularLinkedList - count: {circularList.Count}");
            var guid = Guid.NewGuid().ToString();

            circularList.Add(Guid.NewGuid().ToString());
            circularList.Add(Guid.NewGuid().ToString());
            circularList.Add(Guid.NewGuid().ToString());
            circularList.Add(guid);
            circularList.Add(Guid.NewGuid().ToString());

            Console.WriteLine($"CircularLinkedList - count: {circularList.Count}");

            circularList.Delete(guid);

            Console.WriteLine($"CircularLinkedList - count after delete: {circularList.Count}");

            foreach (var item in circularList)
            {
                Console.WriteLine($"CircularLinkedList - Item: {item}");
            }
        }
    }
}
