using System;
using System.Collections.Generic;

namespace DataStructures.BL.BinarySearchTree
{
    /// <summary>
    /// Дерево (BinarySearchTree).
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class Tree<T> where T : IComparable, IComparable<T>
    {
        /// <summary>
        /// Корень.
        /// </summary>
        public Node<T> Root { get; private set; }

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Добавить элемент.
        /// </summary>
        /// <param name="data">Данные.</param>
        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }

            Root.Add(data);
            Count++;
        }

        /// <summary>
        /// Префиксный обход.
        /// </summary>
        /// <returns>Список.</returns>
        public List<T> Preorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Preorder(Root);
        }

        /// <summary>
        /// Постфиксный обход.
        /// </summary>
        /// <returns></returns>
        public List<T> Postorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Postorder(Root);
        }

        /// <summary>
        /// Инфиксный обход.
        /// </summary>
        /// <returns>Список.</returns>
        public List<T> Inorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Inorder(Root);
        }

        private List<T> Preorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                list.Add(node.Data);

                if (node.Left != null)
                {
                    list.AddRange(Preorder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(Preorder(node.Right));
                }
            }

            return list;
        }

        private List<T> Postorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Postorder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(Postorder(node.Right));
                }

                list.Add(node.Data);
            }

            return list;
        }

        private List<T> Inorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inorder(node.Left));
                }

                list.Add(node.Data);

                if (node.Right != null)
                {
                    list.AddRange(Inorder(node.Right));
                }
            }

            return list;
        }
    }
}
