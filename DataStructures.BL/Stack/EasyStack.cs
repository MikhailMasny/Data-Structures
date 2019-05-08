using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.BL.Stack
{
    /// <summary>
    /// Простой Stack.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class EasyStack<T> : ICloneable
    {
        /// <summary>
        /// Лист элементов.
        /// </summary>
        private List<T> items = new List<T>();

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count => items.Count;

        /// <summary>
        /// Проверка на пустоту Stack.
        /// </summary>
        public bool IsEmpty => items.Count == 0;

        /// <summary>
        /// Добавить новый элемент.
        /// </summary>
        /// <param name="item">Элемент.</param>
        public void Push(T item)
        {
            items.Add(item);
        }

        /// <summary>
        /// Очистить список.
        /// </summary>
        public void Clear()
        {
            items.Clear();
        }

        /// <summary>
        /// Достать элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public T Pop()
        {
            if (!IsEmpty)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
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
            if (!IsEmpty)
            {
                return items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Stack is empty.");
            }
        }

        /// <summary>
        /// Переопределение ToString.
        /// </summary>
        /// <returns>Определенного вида строка.</returns>
        public override string ToString()
        {
            return $"Stack with {Count} items.";
        }

        /// <summary>
        /// Клонирование объектов.
        /// </summary>
        /// <returns>Список EasyStack.</returns>
        public object Clone()
        {
            var newStack = new EasyStack<T>();
            newStack.items = new List<T>(items);
            return newStack;
        }
    }
}
