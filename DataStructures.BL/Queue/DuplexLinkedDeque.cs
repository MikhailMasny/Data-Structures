namespace DataStructures.BL.Queue
{
    /// <summary>
    /// Двойная двусвязная двухсторонняя Deque.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class DuplexLinkedDeque<T>
    {
        private DuplexItem<T> Head;
        private DuplexItem<T> Tail;

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Пустой конструктор.
        /// </summary>
        public DuplexLinkedDeque() { }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="data">Элемент.</param>
        public DuplexLinkedDeque(T data)
        {
            SetHeadItem(data);
        }

        /// <summary>
        /// Установка головного элемента.
        /// </summary>
        /// <param name="data">Элемент.</param>
        private void SetHeadItem(T data)
        {
            var item = new DuplexItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        /// <summary>
        /// Добавить элемент в конец.
        /// </summary>
        /// <param name="data">Элемент.</param>
        public void EnqueueBack(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new DuplexItem<T>(data);
            item.Next = Tail;
            Tail.Previous = item;
            Tail = item;
            Count++;
        }

        /// <summary>
        /// Добавить элемент в начало.
        /// </summary>
        /// <param name="data">Элемент.</param>
        public void EnqueueFront(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new DuplexItem<T>(data);
            item.Previous = Head;
            Head.Next = item;
            Head = item;
            Count++;
        }

        /// <summary>
        /// Убрать последний элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public T DequeueBack()
        {
            if (Count > 0)
            {
                var result = Tail.Data;
                var current = Tail.Next;
                current.Previous = null;
                Tail = current;
                Count--;
                return result;
            }
            else
            {
                return default(T);
            }
        }

        /// <summary>
        /// Убрать первый элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public T DequeueFront()
        {
            if (Count > 0)
            {
                var result = Head.Data;
                var current = Head.Previous;
                current.Next = null;
                Head = current;
                Count--;
                return result;
            }
            else
            {
                return default(T);
            }
        }

        /// <summary>
        /// Получить последний элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public T PeekBack()
        {
            return Tail.Data;
        }

        /// <summary>
        /// Получить первый элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public T PeekFront()
        {
            return Head.Data;
        }
    }
}
