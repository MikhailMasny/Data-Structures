using System.Collections.Generic;

namespace DataStructures.BL.Tree
{
    /// <summary>
    /// Элемент Tree (Узел).
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class Node<T>
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
        public Dictionary<char, Node<T>> SubNodes { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="symbol">Символ.</param>
        /// <param name="data">Данные.</param>
        /// <param name="prefix">Префикс.</param>
        public Node(char symbol, T data, string prefix)
        {
            Symbol = symbol;
            Data = data;
            SubNodes = new Dictionary<char, Node<T>>();
            Prefix = prefix;
        }

        public override string ToString()
        {
            return $"{Data} [{SubNodes.Count}] ({Prefix})";
        }

        /// <summary>
        /// Найти элемент.
        /// </summary>
        /// <param name="symbol">Символ.</param>
        /// <returns></returns>
        public Node<T> TryFind(char symbol)
        {
            if (SubNodes.TryGetValue(symbol, out Node<T> value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Node<T> item)
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
