namespace DataStructures.BL.HashTable
{
    /// <summary>
    /// "Плохая" HashTable.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class BadHashTable<T>
    {
        private T[] items;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="size">Размер.</param>
        public BadHashTable(int size)
        {
            items = new T[size];
        }

        /// <summary>
        /// Добавить.
        /// </summary>
        /// <param name="item">Элемент.</param>
        public void Add(T item)
        {
            var key = GetHash(item);
            items[key] = item;
        }

        /// <summary>
        /// Поиск.
        /// </summary>
        /// <param name="item">Элемент.</param>
        /// <returns>Найденый элемент.</returns>
        public bool Search(T item)
        {
            var key = GetHash(item);
            return items[key].Equals(item);
        }

        /// <summary>
        /// Получить Hash.
        /// </summary>
        /// <param name="item">Ключ.</param>
        /// <returns>Hash.</returns>
        private int GetHash(T item)
        {
            return item.ToString().Length % items.Length;
        }
    }
}
