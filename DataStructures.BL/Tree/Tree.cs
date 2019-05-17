namespace DataStructures.BL.Tree
{
    /// <summary>
    /// Дерево (Tree).
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class Tree<T>
    {
        private Node<T> root;

        /// <summary>
        /// Количество.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        public Tree()
        {
            root = new Node<T>('\0', default(T), "");
            Count = 1;
        }

        /// <summary>
        /// Добавить элемент.
        /// </summary>
        /// <param name="key">Ключ.</param>
        /// <param name="data">Данные.</param>
        public void Add(string key, T data)
        {
            AddNode(key, data, root);
        }

        private void AddNode(string key, T data, Node<T> node)
        {
            if (string.IsNullOrEmpty(key))
            {
                if (!node.IsWord)
                {
                    node.Data = data;
                    node.IsWord = true;
                }
            }
            else
            {
                var symbol = key[0];
                var subnode = node.TryFind(symbol);
                if (subnode != null)
                {
                    AddNode(key.Substring(1), data, subnode);
                }
                else
                {
                    var newNode = new Node<T>(key[0], data, node.Prefix + key[0]);
                    node.SubNodes.Add(key[0], newNode);
                    AddNode(key.Substring(1), data, newNode);
                }
            }

        }

        /// <summary>
        /// Удалить элемент.
        /// </summary>
        /// <param name="key">Ключ.</param>
        public void Remove(string key)
        {
            RemoveNode(key, root);
        }

        /// <summary>
        /// Удалить узел.
        /// </summary>
        /// <param name="key">Ключ.</param>
        /// <param name="node">Узел.</param>
        private void RemoveNode(string key, Node<T> node)
        {
            if (string.IsNullOrEmpty(key))
            {
                if (node.IsWord)
                {
                    node.IsWord = false;
                }
            }
            else
            {
                var subnode = node.TryFind(key[0]);
                if (subnode != null)
                {
                    RemoveNode(key.Substring(1), subnode);
                }
            }
        }

        /// <summary>
        /// Попытка поиска элемента.
        /// </summary>
        /// <param name="key">Ключ.</param>
        /// <param name="value">Значение.</param>
        /// <returns></returns>
        public bool TrySearch(string key, out T value)
        {
            return SearchNode(key, root, out value);
        }

        /// <summary>
        /// Поиск узла.
        /// </summary>
        /// <param name="key">Ключ.</param>
        /// <param name="node">Ухел.</param>
        /// <param name="value">Значение.</param>
        /// <returns></returns>
        private bool SearchNode(string key, Node<T> node, out T value)
        {
            value = default(T);
            var result = false;
            if (string.IsNullOrEmpty(key))
            {
                if (node.IsWord)
                {
                    value = node.Data;
                    result = true;
                }
            }
            else
            {
                var subnode = node.TryFind(key[0]);
                if (subnode != null)
                {
                    result = SearchNode(key.Substring(1), subnode, out value);
                }
            }

            return result;
        }
    }
}
