using System;
using System.Collections.Generic;

namespace DataStructures.BL.Stack
{
    /// <summary>
    /// Класс с вариантами Stack.
    /// </summary>
    public class StackRun
    {
        /// <summary>
        /// Демонстрация работы базового Stack.
        /// </summary>
        public void BasicStack()
        {
            var stack = new Stack<int>();

            Console.WriteLine($"BasicStack - count: {stack.Count}");

            stack.Push(11);
            stack.Push(22);
            stack.Push(33);

            Console.WriteLine($"BasicStack - count: {stack.Count}");

            Console.WriteLine($"BasicStack - pop item: {stack.Pop()}");
            Console.WriteLine($"BasicStack - peek item: {stack.Peek()}");

            Console.WriteLine($"BasicStack - count: {stack.Count}");
        }

        /// <summary>
        /// Демонстрация работы EasyStack.
        /// </summary>
        public void EasyStack()
        {
            var easyStack = new EasyStack<int>();

            Console.WriteLine($"EasyStack - count: {easyStack.Count}");

            easyStack.Push(1);
            easyStack.Push(2);
            easyStack.Push(3);

            Console.WriteLine($"EasyStack - count: {easyStack.Count}");

            Console.WriteLine($"EasyStack - pop item: {easyStack.Pop()}");
            Console.WriteLine($"EasyStack - peek item: {easyStack.Peek()}");

            Console.WriteLine($"EasyStack - count: {easyStack.Count}");
        }

        /// <summary>
        /// Демонстрация работы LinkedStack.
        /// </summary>
        public void LinkedStack()
        {
            var linkedStack = new LinkedStack<int>();

            Console.WriteLine($"LinkedStack - count: {linkedStack.Count}");

            linkedStack.Push(4);
            linkedStack.Push(5);
            linkedStack.Push(6);

            Console.WriteLine($"LinkedStack - count: {linkedStack.Count}");

            Console.WriteLine($"LinkedStack - peek item: {linkedStack.Peek()}");
            Console.WriteLine($"LinkedStack - pop item: {linkedStack.Pop()}");
            Console.WriteLine($"LinkedStack - pop item: {linkedStack.Pop()}");
            Console.WriteLine($"LinkedStack - peek item: {linkedStack.Peek()}");

            Console.WriteLine($"LinkedStack - count: {linkedStack.Count}");
        }

        /// <summary>
        /// Демонстрация работы ArrayStack.
        /// </summary>
        public void ArrayStack()
        {
            var arrayStack = new ArrayStack<int>(4);

            Console.WriteLine($"ArrayStack - count: {arrayStack.Count}");

            arrayStack.Push(7);           
            arrayStack.Push(8);
            arrayStack.Push(9);
            arrayStack.Push(0);

            Console.WriteLine($"ArrayStack - count: {arrayStack.Count}");

            Console.WriteLine($"ArrayStack - peek item: {arrayStack.Peek()}");
            Console.WriteLine($"ArrayStack - pop item: {arrayStack.Pop()}");
            Console.WriteLine($"ArrayStack - pop item: {arrayStack.Pop()}");
            Console.WriteLine($"ArrayStack - peek item: {arrayStack.Peek()}");

            Console.WriteLine($"ArrayStack - count: {arrayStack.Count}");
        }
    }
}
