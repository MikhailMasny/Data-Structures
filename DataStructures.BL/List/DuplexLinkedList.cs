using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.BL.List
{
    /// <summary>
    /// Элемент двусвязного списка.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class DuplexLinkedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Головной элемент.
        /// </summary>
        public DuplexItemList<T> Head { get; set; }

        /// <summary>
        /// Последний элемент.
        /// </summary>
        public DuplexItemList<T> Tail { get; set; }

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Пустой конструктор.
        /// </summary>
        public DuplexLinkedList() { }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="data">Данные.</param>
        public DuplexLinkedList(T data)
        {
            var item = new DuplexItemList<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        /// <summary>
        /// Добавить новый элемент.
        /// </summary>
        /// <param name="data">Данные.</param>
        public void Add(T data)
        {

            var item = new DuplexItemList<T>(data);

            if (Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }


            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;
            Count++;
        }

        /// <summary>
        /// Удалить новый элемент.
        /// </summary>
        /// <param name="data">Данные.</param>
        public void Delete(T data)
        {
            var current = Head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                    return;
                }

                current = current.Next;
            }
        }

        /// <summary>
        /// Реверс элементов.
        /// </summary>
        /// <returns>Результат реверса.</returns>
        public DuplexLinkedList<T> Reverse()
        {
            var result = new DuplexLinkedList<T>();

            var current = Tail;
            while (current != null)
            {
                result.Add(current.Data);
                current = current.Previous;
            }

            return result;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
