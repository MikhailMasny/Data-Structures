using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BL.Stack
{
    /// <summary>
    /// Stack на основе массива.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class ArrayStack<T>
    {
        /// <summary>
        /// Массив элементов определенного типа.
        /// </summary>
        T[] items;

        private int current = -1;
        private readonly int size = 10;

        /// <summary>
        /// Получение макс. кол-ва элем.
        /// </summary>
        public int MaxCount => items.Length;

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count => current + 1;

        /// <summary>
        /// Базовый конструктор.
        /// </summary>
        /// <param name="size">Размер.</param>
        public ArrayStack(int size = 10)
        {
            items = new T[size];
            this.size = size;
        }

        /// <summary>
        /// Конструтор с доп. параметрами.
        /// </summary>
        /// <param name="data">Данные.</param>
        /// <param name="size">Размер.</param>
        public ArrayStack(T data, int size = 10) : this(size)
        {
            items[0] = data;
            current = 1;
        }

        /// <summary>
        /// Добавить новый элемент.
        /// </summary>
        /// <param name="data">Данные.</param>
        public void Push(T data)
        {
            if (current < size - 1)
            {
                current++;
                items[current] = data;
            }
            else
            {
                throw new StackOverflowException("Stack is full.");
            }
        }

        /// <summary>
        /// Достать элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public T Pop()
        {
            if (current >= 0)
            {
                var item = items[current];
                current--;
                return item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty.");
            }
        }

        /// <summary>
        /// Получить верхний элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public T Peek()
        {
            if (current >= 0)
            {
                return items[current];
            }
            else
            {
                throw new NullReferenceException("Stack is empty.");
            }
        }
    }
}
