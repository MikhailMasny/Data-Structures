using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.BL.Map
{
    /// <summary>
    /// Простой Map.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    class EasyMap<TKey, TValue> : IEnumerable
    {
        private List<ItemMap<TKey, TValue>> Items = new List<ItemMap<TKey, TValue>>();
        private List<TKey> Keys = new List<TKey>();

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count => Items.Count;

        /// <summary>
        /// Пустой конструктор.
        /// </summary>
        public EasyMap()
        {

        }

        /// <summary>
        /// Добавление нового элемента.
        /// </summary>
        /// <param name="item">Элемент.</param>
        public void Add(ItemMap<TKey, TValue> item)
        {
            if (!Keys.Contains(item.Key))
            {
                Keys.Add(item.Key);
                Items.Add(item);
            }
        }

        /// <summary>
        /// Поиск элемента.
        /// </summary>
        /// <param name="key">Ключ.</param>
        /// <returns>Результат поиска.</returns>
        public TValue Search(TKey key)
        {
            if (Keys.Contains(key))
            {
                return Items.Single(i => i.Key.Equals(key)).Value;
            }

            return default(TValue);
        }

        /// <summary>
        /// Удалить элемент.
        /// </summary>
        /// <param name="key">Ключ.</param>
        public void Remove(TKey key)
        {
            if (Keys.Contains(key))
            {
                Keys.Remove(key);
                Items.Remove(Items.Single(i => i.Key.Equals(key)));
            }
        }

        public IEnumerator GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
}
