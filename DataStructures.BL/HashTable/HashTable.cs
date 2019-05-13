using System;
using System.Collections.Generic;

namespace DataStructures.BL.HashTable
{
    /// <summary>
    /// HashTable.
    /// </summary>
    /// <typeparam name="TKey">Ключ.</typeparam>
    /// <typeparam name="TValue">Значение.</typeparam>
    public class HashTable<TKey, TValue>
    {
        private List<TValue>[] items;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="size">Размер.</param>
        public HashTable(int size)
        {
            items = new List<TValue>[size];
        }

        /// <summary>
        /// Добавить.
        /// </summary>
        /// <param name="key">Ключ.</param>
        /// <param name="value">Значение.</param>
        public void Add(TKey key, TValue value)
        {
            var k = GetHash(key);
            if (items[k] == null)
            {
                items[k] = new List<TValue>() { value };
            }
            else
            {
                items[k].Add(value);
            }
        }

        /// <summary>
        /// Поиск.
        /// </summary>
        /// <param name="key">Ключ.</param>
        /// <param name="item">Значение.</param>
        /// <returns>Найденый элемент.</returns>
        public bool Search(TKey key, TValue item)
        {
            var k = GetHash(key);
            return items[k]?.Contains(item) ?? false;
        }

        /// <summary>
        /// Получить Hash.
        /// </summary>
        /// <param name="key">Ключ.</param>
        /// <returns>Hash.</returns>
        private int GetHash(TKey key)
        {
            return Convert.ToInt32(key.ToString().Substring(0, 1));
        }
    }
}

