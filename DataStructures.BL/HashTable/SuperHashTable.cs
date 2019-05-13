namespace DataStructures.BL.HashTable
{
    /// <summary>
    /// "Супер" HashTable.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SuperHashTable<T>
    {
        private ItemHashTable<T>[] items;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="size">Размер.</param>
        public SuperHashTable(int size)
        {
            items = new ItemHashTable<T>[size];

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ItemHashTable<T>(i);
            }
        }

        /// <summary>
        /// Добавить.
        /// </summary>
        /// <param name="item">Элемент.</param>
        public void Add(T item)
        {
            var key = GetHash(item);
            items[key].Nodes.Add(item);
        }

        /// <summary>
        /// Поиск.
        /// </summary>
        /// <param name="item">Элемент.</param>
        /// <returns>Найденый элемент.</returns>
        public bool Search(T item)
        {
            var key = GetHash(item);
            return items[key].Nodes.Contains(item);
        }

        /// <summary>
        /// Получить Hash.
        /// </summary>
        /// <param name="item">Элемент.</param>
        /// <returns>Hash.</returns>
        private int GetHash(T item)
        {
            return item.GetHashCode() % items.Length;
        }
    }
}
