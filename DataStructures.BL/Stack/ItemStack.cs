namespace DataStructures.BL.Stack
{
    /// <summary>
    /// Элемент Stack.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class ItemStack<T>
    {
        /// <summary>
        /// Данные.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Предыдущий элемент.
        /// </summary>
        public ItemStack<T> Previous { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="data">Обобщение.</param>
        public ItemStack(T data)
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
