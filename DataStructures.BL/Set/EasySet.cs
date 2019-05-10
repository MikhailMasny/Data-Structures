using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.BL.Set
{
    /// <summary>
    /// Простой Set.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class EasySet<T> : IEnumerable
    {
        private List<T> items = new List<T>();

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count => items.Count;

        /// <summary>
        /// Пустой конструтор.
        /// </summary>
        public EasySet() { }

        /// <summary>
        /// Конструктор с добавлением элемента.
        /// </summary>
        /// <param name="item">Элемент.</param>
        public EasySet(T item)
        {
            items.Add(item);
        }

        /// <summary>
        /// Конструктор с добавлением элементов.
        /// </summary>
        /// <param name="items">Элементы.</param>
        public EasySet(IEnumerable<T> items)
        {
            this.items = items.ToList();
        }

        /// <summary>
        /// Добавить элемент.
        /// </summary>
        /// <param name="item">Элемент.</param>
        public void Add(T item)
        {
            if (items.Contains(item))
            {
                return;
            }

            items.Add(item);
        }

        /// <summary>
        /// Удалить элемент.
        /// </summary>
        /// <param name="item">Элемент.</param>
        public void Remove(T item)
        {
            items.Remove(item);
        }

        /// <summary>
        /// Объединить.
        /// </summary>
        /// <param name="set">Данные.</param>
        /// <returns>Результат объединения.</returns>
        public EasySet<T> Union(EasySet<T> set)
        {
            EasySet<T> result = new EasySet<T>();

            foreach (var item in items)
            {
                result.Add(item);
            }

            foreach (var item in set.items)
            {
                result.Add(item);
            }

            return result;
        }

        /// <summary>
        /// Пересечение.
        /// </summary>
        /// <param name="set">Данныех.</param>
        /// <returns>Результат пересечения.</returns>
        public EasySet<T> Intersection(EasySet<T> set)
        {
            var result = new EasySet<T>();
            EasySet<T> big;
            EasySet<T> small;

            if (Count >= set.Count)
            {
                big = this;
                small = set;
            }
            else
            {
                big = set;
                small = this;
            }

            foreach (var item1 in small.items)
            {
                foreach (var item2 in big.items)
                {
                    if (item1.Equals(item2))
                    {
                        result.Add(item1);
                        break;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Разность.
        /// </summary>
        /// <param name="set">Данные.</param>
        /// <returns>Результат разности.</returns>
        public EasySet<T> Difference(EasySet<T> set)
        {
            var result = new EasySet<T>(items);

            foreach (var item in set.items)
            {
                result.Remove(item);
            }

            return result;
        }

        /// <summary>
        /// Подмножество.
        /// </summary>
        /// <param name="set">Данные.</param>
        /// <returns>Результат подмножества.</returns>
        public bool Subset(EasySet<T> set)
        {
            foreach (var item1 in items)
            {
                var equals = false;

                foreach (var item2 in set.items)
                {
                    if (item1.Equals(item2))
                    {
                        equals = true;
                        break;
                    }
                }

                if (!equals)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Симметричная разность.
        /// </summary>
        /// <param name="set">Данные.</param>
        /// <returns>Результат симметричной разности.</returns>
        public EasySet<T> SymmetricDifference(EasySet<T> set)
        {
            var result = new EasySet<T>();

            foreach (var item1 in items)
            {
                var equals = false;

                foreach (var item2 in set.items)
                {
                    if (item1.Equals(item2))
                    {
                        equals = true;

                        break;
                    }
                }

                if (equals == false)
                {
                    result.Add(item1);
                }
            }

            foreach (var item1 in set.items)
            {
                var equals = false;

                foreach (var item2 in items)
                {
                    if (item1.Equals(item2))
                    {
                        equals = true;

                        break;
                    }
                }

                if (equals == false)
                {
                    result.Add(item1);
                }
            }

            return result;
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
