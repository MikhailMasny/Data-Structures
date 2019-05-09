namespace DataStructures.BL.Queue
{
    /// <summary>
    /// Элемент Queue.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class ItemQueue<T>
    {
        /// <summary>
        /// Данные.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Следующий элемент.
        /// </summary>
        public ItemQueue<T> Next { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="data">Обобщение.</param>
        public ItemQueue(T data)
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
