using System.Collections;

namespace DataStructures.BL.List
{
    /// <summary>
    /// Односвязный список.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class ImplementedLinkedList<T> : IEnumerable
    {
        /// <summary>
        /// Головной элемент.
        /// </summary>
        public ItemList<T> Head { get; private set; }

        /// <summary>
        /// Последний элемент.
        /// </summary>
        public ItemList<T> Tail { get; private set; }

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        public ImplementedLinkedList()
        {
            Clear();
        }

        /// <summary>
        /// Конструктор с данными.
        /// </summary>
        /// <param name="data">Данные.</param>
        public ImplementedLinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        /// <summary>
        /// Добавить новый элемент.
        /// </summary>
        /// <param name="data">Данные.</param>
        public void Add(T data)
        {
            if (Tail != null)
            {
                var item = new ItemList<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        /// <summary>
        /// Удалить элемент.
        /// </summary>
        /// <param name="data">Данные.</param>
        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        /// <summary>
        /// Добавить элемент в начало.
        /// </summary>
        /// <param name="data">Данные.</param>
        public void AppendHead(T data)
        {
            var item = new ItemList<T>(data)
            {
                Next = Head
            };

            Head = item;
            Count++;
        }

        /// <summary>
        /// Добавить элемент в конец.
        /// </summary>
        /// <param name="target">Цель.</param>
        /// <param name="data">Данные.</param>
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new ItemList<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else
            {
                // Нужно для себя решить, если список пустой, 
                // то либо не добавлять ничего, либо вставить данные
            }
        }

        /// <summary>
        /// Очистить список.
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        private void SetHeadAndTail(T data)
        {
            var item = new ItemList<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        /// <summary>
        /// Получить перечисление всех элементов списка
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        /// <summary>
        /// Переопределение ToString.
        /// </summary>
        /// <returns>Возвращение нового ToString.</returns>
        public override string ToString()
        {
            return "Linked List " + Count + " elements.";
        }
    }
}
