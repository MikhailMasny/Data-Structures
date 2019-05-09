using System.Linq;

namespace DataStructures.BL.Queue
{
    /// <summary>
    /// Queue на основе массива.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class ArrayQueue<T>
    {
        private T[] items;
        private T Head => items[Count > 0 ? Count - 1 : 0];
        private T Tail => items[0];
        private int MaxCount => items.Length;

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Базовый конструктор.
        /// </summary>
        /// <param name="size">Размер.</param>
        public ArrayQueue(int size)
        {
            items = new T[size];
            Count = 0;
        }

        /// <summary>
        /// Конструтор с доп. параметрами.
        /// </summary>
        /// <param name="size">Размер.</param>
        /// <param name="data">Элемент.</param>
        public ArrayQueue(int size, T data)
        {
            items = new T[size];
            items[0] = data;
            Count = 1;
        }

        /// <summary>
        /// Добавить элемент в конец.
        /// </summary>
        /// <param name="data">Элемент.</param>
        public void Enqueue(T data)
        {
            if (Count < MaxCount)
            {
                var result = (new T[] { data }).Concat(items);
                items = result.ToArray();
                Count++;
            }
        }

        /// <summary>
        /// Убрать первый элемент.
        /// </summary>
        /// <returns>"Элемент.</returns>
        public T Dequeue()
        {
            var item = Head;
            Count--;
            return item;
        }

        /// <summary>
        /// Получить первый элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public T Peek()
        {
            return Head;
        }
    }
}
