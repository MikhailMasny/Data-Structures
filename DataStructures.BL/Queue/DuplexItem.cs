namespace DataStructures.BL.Queue
{
    /// <summary>
    /// Двойной элемент Queue.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class DuplexItem<T>
    {
        /// <summary>
        /// Данные.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Следующий элемент.
        /// </summary>
        public DuplexItem<T> Next { get; set; }

        /// <summary>
        /// Предыдущий элемент.
        /// </summary>
        public DuplexItem<T> Previous { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="data">Элемент.</param>
        public DuplexItem(T data)
        {
            Data = data;
        }

        /// <summary>
        /// Переопределение ToString.
        /// </summary>
        /// <returns>Определенного вида строка.</returns>
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
