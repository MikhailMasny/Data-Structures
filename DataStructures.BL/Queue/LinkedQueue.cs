namespace DataStructures.BL.Queue
{
    /// <summary>
    /// Двусвязная Queue.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedQueue<T>
    {
        private ItemQueue<T> head;
        private ItemQueue<T> tail;

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Пустой конструктор.
        /// </summary>
        public LinkedQueue() { }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="data">Данные.</param>
        public LinkedQueue(T data)
        {
            SetHeadItem(data);
        }

        /// <summary>
        /// Установка головного элемента.
        /// </summary>
        /// <param name="data">Элемент.</param>
        private void SetHeadItem(T data)
        {
            var item = new ItemQueue<T>(data);
            head = item;
            tail = item;
            Count = 1;
        }

        /// <summary>
        /// Добавить элемент в конец.
        /// </summary>
        /// <param name="data">Элемент.</param>
        public void Enqueue(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new ItemQueue<T>(data)
            {
                Next = tail
            };
            tail = item;
            Count++;
        }

        /// <summary>
        /// Убрать первый элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public T Dequeue()
        {
            var data = head.Data;

            var current = tail.Next;
            var previous = tail;
            while (current != null && current.Next != null)
            {
                previous = current;
                current = current.Next;
            }
            head = previous;
            head.Next = null;
            Count--;
            return data;
        }

        /// <summary>
        /// Получить первый элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public T Peek()
        {
            return head.Data;
        }
    }
}
