using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.BL.Map
{
    /// <summary>
    /// Словарь на основе Map.
    /// </summary>
    /// <typeparam name="TKey">Ключ.</typeparam>
    /// <typeparam name="TValue">Значение.</typeparam>
    class Dictionary<TKey, TValue> : IEnumerable
    {
        private int size = 100;
        private ItemMap<TKey, TValue>[] Items;
        private List<TKey> Keys = new List<TKey>();

        /// <summary>
        /// Пустой конструктор.
        /// </summary>
        public Dictionary()
        {
            Items = new ItemMap<TKey, TValue>[size];
        }

        /// <summary>
        /// Добавить новый элемент.
        /// </summary>
        /// <param name="item">Элемент.</param>
        public void Add(ItemMap<TKey, TValue> item)
        {
            var hash = GetHash(item.Key);

            if (Keys.Contains(item.Key))
            {
                return;
            }

            if (Items[hash] == null)
            {
                Keys.Add(item.Key);
                Items[hash] = item;
            }
            else
            {
                var placed = false;
                for (var i = hash; i < size; i++)
                {
                    if (Items[i] == null)
                    {
                        Keys.Add(item.Key);
                        Items[i] = item;
                        placed = true;
                        break;
                    }

                    if (Items[i].Key.Equals(item.Key))
                    {
                        return;
                    }
                }

                if (!placed)
                {
                    for (var i = 0; i < hash; i++)
                    {
                        if (Items[i] == null)
                        {
                            Keys.Add(item.Key);
                            Items[i] = item;
                            placed = true;
                            break;
                        }

                        if (Items[i].Key.Equals(item.Key))
                        {
                            return;
                        }
                    }
                }

                if (!placed)
                {
                    throw new Exception("Dictionary is full.");
                }
            }
        }

        /// <summary>
        /// Удалить элемент.
        /// </summary>
        /// <param name="key">Ключ.</param>
        public void Remove(TKey key)
        {
            var hash = GetHash(key);

            if (!Keys.Contains(key))
            {
                return;
            }

            if (Items[hash] == null)
            {
                for (var i = 0; i < size; i++)
                {
                    if (Items[i] != null && Items[i].Key.Equals(key))
                    {
                        Items[i] = null;
                        Keys.Remove(key);
                        return;
                    }
                }

                return;
            }

            if (Items[hash].Key.Equals(key))
            {
                Items[hash] = null;
                Keys.Remove(key);
            }
            else
            {
                var placed = false;
                for (var i = hash; i < size; i++)
                {
                    if (Items[i] == null)
                    {
                        return;
                    }

                    if (Items[i].Key.Equals(key))
                    {
                        Items[i] = null;
                        Keys.Remove(key);
                        return;
                    }
                }

                if (!placed)
                {
                    for (var i = 0; i < hash; i++)
                    {
                        if (Items[i] == null)
                        {
                            return;
                        }

                        if (Items[i].Key.Equals(key))
                        {
                            Items[i] = null;
                            Keys.Remove(key);
                            return;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Поиск элемента.
        /// </summary>
        /// <param name="key">Ключ.</param>
        /// <returns>Результат поиска.</returns>
        public TValue Search(TKey key)
        {
            var hash = GetHash(key);

            if (!Keys.Contains(key))
            {
                return default(TValue);
            }

            if (Items[hash] == null)
            {
                foreach (var item in Items)
                {
                    if (item.Key.Equals(key))
                    {
                        return item.Value;
                    }
                }

                return default(TValue);
            }

            if (Items[hash].Key.Equals(key))
            {
                return Items[hash].Value;
            }
            else
            {
                var placed = false;
                for (var i = hash; i < size; i++)
                {
                    if (Items[i] == null)
                    {
                        return default(TValue);
                    }

                    if (Items[i].Key.Equals(key))
                    {
                        return Items[i].Value;
                    }
                }

                if (!placed)
                {
                    for (var i = 0; i < hash; i++)
                    {
                        if (Items[i] == null)
                        {
                            return default(TValue);
                        }

                        if (Items[i].Key.Equals(key))
                        {
                            return Items[i].Value;
                        }
                    }
                }
            }

            return default(TValue);
        }

        private int GetHash(TKey key)
        {
            return key.GetHashCode() % size;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in Items)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }
    }
}
