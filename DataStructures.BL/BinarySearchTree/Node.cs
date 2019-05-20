using System;

namespace DataStructures.BL.BinarySearchTree
{
    /// <summary>
    /// Элемент BinarySearchTree.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class Node<T> : IComparable<T>, IComparable where T : IComparable, IComparable<T>
    {
        /// <summary>
        /// Данные (дерево).
        /// </summary>
        public T Data { get; private set; }

        /// <summary>
        /// Левый узел.
        /// </summary>
        public Node<T> Left { get; private set; }

        /// <summary>
        /// Правый узел.
        /// </summary>
        public Node<T> Right { get; private set; }

        /// <summary>
        /// Конструктор c данными.
        /// </summary>
        /// <param name="data">Данные.</param>
        public Node(T data)
        {
            Data = data;
        }

        /// <summary>
        /// Конструктор с данными и навигацией.
        /// </summary>
        /// <param name="data">Данные.</param>
        /// <param name="left">Влево.</param>
        /// <param name="right">Вправо.</param>
        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        /// <summary>
        /// Добавить элемент.
        /// </summary>
        /// <param name="data">Данные.</param>
        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (node.Data.CompareTo(Data) == -1)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(data);
                }
            }
        }

        /// <summary>
        /// Сравнить объект.
        /// </summary>
        /// <param name="obj">Объект.</param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is Node<T> item)
            {
                return Data.CompareTo(item);
            }
            else
            {
                throw new ArgumentException("No type match.");
            }
        }

        /// <summary>
        /// Сравнить объект.
        /// </summary>
        /// <param name="other">Другой элемент.</param>
        /// <returns></returns>
        public int CompareTo(T other)
        {
            return Data.CompareTo(other);
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
