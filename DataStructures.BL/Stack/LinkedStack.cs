using System;

namespace DataStructures.BL.Stack
{
    /// <summary>
    /// Двусвязный Stack.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class LinkedStack<T>
    {
        /// <summary>
        /// Головной элемент.
        /// </summary>
        public ItemStack<T> Head { get; set; }

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Пустой конструктор.
        /// </summary>
        public LinkedStack()
        {
            Head = null;
            Count = 0;
        }

        /// <summary>
        /// Конструтор.
        /// </summary>
        /// <param name="data">Данные.</param>
        public LinkedStack(T data)
        {
            Head = new ItemStack<T>(data);
            Count = 1;
        }

        /// <summary>
        /// Добавить новый элемент.
        /// </summary>
        /// <param name="data">Элемент.</param>
        public void Push(T data)
        {
            var item = new ItemStack<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;
        }

        /// <summary>
        /// Достать элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public T Pop()
        {
            if (Count > 0)
            {
                var item = Head;
                Head = Head.Previous;
                Count--;
                return item.Data;
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
            if (Count > 0)
            {
                return Head.Data;
            }
            else
            {
                throw new NullReferenceException("Stack is empty.");
            }
        }
    }
}
