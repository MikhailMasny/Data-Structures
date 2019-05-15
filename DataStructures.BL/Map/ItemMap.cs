namespace DataStructures.BL.Map
{
    /// <summary>
    /// Элемент Map или Dictionary.
    /// </summary>
    /// <typeparam name="TKey">Ключ.</typeparam>
    /// <typeparam name="TValue">Значение.</typeparam>
    class ItemMap<TKey, TValue>
    {
        /// <summary>
        /// Ключ.
        /// </summary>
        public TKey Key { get; set; }

        /// <summary>
        /// Значение.
        /// </summary>
        public TValue Value { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="key">Ключ.</param>
        /// <param name="value">Значение.</param>
        public ItemMap(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        /// <summary>
        /// Переопределение GetHashCode.
        /// </summary>
        /// <returns>Новый GetHashCode.</returns>
        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }

        /// <summary>
        /// Переопределение ToString.
        /// </summary>
        /// <returns>Новый вариант ToString.</returns>
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
