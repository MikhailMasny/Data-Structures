using System.Collections.Generic;
using System.Linq;

namespace DataStructures.BL.Queue
{
    /// <summary>
    /// Простая Deque.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EasyDeque<T>
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
        public EasyDeque() { }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="data">Элемент.</param>
        public EasyDeque(T data)
        {
            items.Add(data);
        }

        /// <summary>
        /// Добавить элемент в конец.
        /// </summary>
        /// <param name="data">"Элемент.</param>
        public void EnqueueBack(T data)
        {
            items.Insert(0, data);
        }

        /// <summary>
        /// Добавить элемент в начало.
        /// </summary>
        /// <param name="data">Элемент.</param>
        public void EnqueueFront(T data)
        {
            items.Add(data);
        }

        /// <summary>
        /// Убрать последний элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public T DequeueBack()
        {
            var item = Tail;
            items.Remove(item);
            return item;
        }

        /// <summary>
        /// Убрать первый элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public T DequeueFront()
        {
            var item = Head;
            items.Remove(item);
            return item;
        }

        /// <summary>
        /// Получить последний элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public T PeekBack()
        {
            return Tail;
        }

        /// <summary>
        /// Получить первый элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public T PeekFront()
        {
            return Head;
        }
    }
}
