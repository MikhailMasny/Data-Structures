namespace DataStructures.BL.Graph
{
    /// <summary>
    /// Ребро.
    /// </summary>
    public class Edge
    {
        /// <summary>
        /// Откуда.
        /// </summary>
        public Vertex From { get; set; }

        /// <summary>
        /// Куда.
        /// </summary>
        public Vertex To { get; set; }
        
        /// <summary>
        /// Вес.
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="from">Откуда.</param>
        /// <param name="to">Куда.</param>
        /// <param name="weight">Вес.</param>
        public Edge(Vertex from, Vertex to, int weight = 1)
        {
            From = from;
            To = to;
            Weight = weight;
        }

        /// <summary>
        /// Переопределение ToString.
        /// </summary>
        /// <returns>Определенного вида строка.</returns>
        public override string ToString()
        {
            return $"({From}; {To})";
        }
    }
}
