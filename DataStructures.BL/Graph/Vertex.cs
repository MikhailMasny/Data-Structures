namespace DataStructures.BL.Graph
{
    /// <summary>
    /// Вершина.
    /// </summary>
    public class Vertex
    {
        /// <summary>
        /// Идентификатор вершины.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="number">Значение.</param>
        public Vertex(int number)
        {
            Number = number;
        }

        /// <summary>
        /// Переопределение ToString.
        /// </summary>
        /// <returns>Определенного вида строка.</returns>
        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
