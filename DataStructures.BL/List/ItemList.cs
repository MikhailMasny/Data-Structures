using System;

namespace DataStructures.BL.List
{
    /// <summary>
    /// Элемент List.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class ItemList<T>
    {
        private T data = default(T);

        /// <summary>
        /// Данные.
        /// </summary>
        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }

        /// <summary>
        /// Следующий элемент.
        /// </summary>
        public ItemList<T> Next { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="data">Данные.</param>
        public ItemList(T data)
        {
            Data = data;
        }

        /// <summary>
        /// Переопределение ToString.
        /// </summary>
        /// <returns>Новое значение.</returns>
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
