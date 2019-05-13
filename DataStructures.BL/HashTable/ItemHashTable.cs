using System.Collections.Generic;

namespace DataStructures.BL.HashTable
{
    /// <summary>
    /// Элемент HashTable.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class ItemHashTable<T>
    {
        /// <summary>
        /// Ключ.
        /// </summary>
        public int Key { get; set; }

        /// <summary>
        /// Список узлов.
        /// </summary>
        public List<T> Nodes { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="key">Ключ.</param>
        public ItemHashTable(int key)
        {
            Key = key;
            Nodes = new List<T>();
        }
    }
}
