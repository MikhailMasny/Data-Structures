namespace DataStructures.BL.List
{
    /// <summary>
    /// Элемент List.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class DuplexItemList<T>
    {
        /// <summary>
        /// Данные.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Предыдущий элемент.
        /// </summary>
        public DuplexItemList<T> Previous { get; set; }

        /// <summary>
        /// Следующий элемент.
        /// </summary>
        public DuplexItemList<T> Next { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="data">Данные.</param>
        public DuplexItemList(T data)
        {
            Data = data;
        }

        /// <summary>
        /// Переопределение ToString.
        /// </summary>
        /// <returns>Новое значение ToString.</returns>
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
