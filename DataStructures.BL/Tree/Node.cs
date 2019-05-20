using System.Collections.Generic;

namespace DataStructures.BL.Tree
{
    /// <summary>
    /// Элемент Tree (Узел).
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class ImplementedNode<T>
    {
        /// <summary>
        /// Символ.
        /// </summary>
        public char Symbol { get; set; }

        /// <summary>
        /// Данные.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Слово.
        /// </summary>
        public bool IsWord { get; set; }

        /// <summary>
        /// Префикс.
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Под узел.
        /// </summary>
        public Dictionary<char, ImplementedNode<T>> SubNodes { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="symbol">Символ.</param>
        /// <param name="data">Данные.</param>
        /// <param name="prefix">Префикс.</param>
        public ImplementedNode(char symbol, T data, string prefix)
        {
            Symbol = symbol;
            Data = data;
            SubNodes = new Dictionary<char, ImplementedNode<T>>();
            Prefix = prefix;
        }

        /// <summary>
        /// Переопределение ToString.
        /// </summary>
        /// <returns>Определенного вида строка.</returns>
        public override string ToString()
        {
            return $"{Data} [{SubNodes.Count}] ({Prefix})";
        }

        /// <summary>
        /// Найти элемент.
        /// </summary>
        /// <param name="symbol">Символ.</param>
        /// <returns></returns>
        public ImplementedNode<T> TryFind(char symbol)
        {
            if (SubNodes.TryGetValue(symbol, out ImplementedNode<T> value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Сравнение элементов.
        /// </summary>
        /// <param name="obj">Объект.</param>
        /// <returns>Результат сравнения.</returns>
        public override bool Equals(object obj)
        {
            if (obj is ImplementedNode<T> item)
            {
                return Data.Equals(item);
            }
            else
            {
                return false;
            }
        }
    }
}
