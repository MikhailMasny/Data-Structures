using System.Collections.Generic;
using System.Linq;

namespace DataStructures.BL.Queue
{
    /// <summary>
    /// Простая Queue.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class EasyQueue<T>
    {
        private List<T> items = new List<T>();
        private T Head => items.Last();
        private T Tail => items.First();

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count => items.Count;

        /// <summary>
        /// Пустой конструктор.
        /// </summary>
        public EasyQueue() { }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="data">Элемент.</param>
        public EasyQueue(T data)
        {
            items.Add(data);
        }

        /// <summary>
        /// Добавить элемент в конец.
        /// </summary>
        /// <param name="data">Элемент.</param>
        public void Enqueue(T data)
        {
            items.Insert(0, data);
        }

        /// <summary>
        /// Убрать первый элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public T Dequeue()
        {
            var item = Head;
            items.Remove(item);
            return item;
        }

        /// <summary>
        /// Получить первый элемент.
        /// </summary>
        /// <returns>Вернуть элемент.</returns>
        public T Peek()
        {
            return Head;
        }
    }
}
