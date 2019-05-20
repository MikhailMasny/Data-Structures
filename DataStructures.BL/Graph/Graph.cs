using System.Collections.Generic;

namespace DataStructures.BL.Graph
{
    /// <summary>
    /// Граф (Graph).
    /// </summary>
    public class Graph
    {
        List<Vertex> Vertexes = new List<Vertex>();
        List<Edge> Edges = new List<Edge>();

        /// <summary>
        /// Количество вершин.
        /// </summary>
        public int VertexCount => Vertexes.Count;

        /// <summary>
        /// Количество ребер.
        /// </summary>
        public int EdgeCount => Edges.Count;

        /// <summary>
        /// Добавить вершину.
        /// </summary>
        /// <param name="vertex">Вершина.</param>
        public void AddVertex(Vertex vertex)
        {
            Vertexes.Add(vertex);
        }

        /// <summary>
        /// Добавить ребро.
        /// </summary>
        /// <param name="from">Откуда.</param>
        /// <param name="to">Куда.</param>
        public void AddEdge(Vertex from, Vertex to)
        {
            var edge = new Edge(from, to);
            Edges.Add(edge);
        }

        /// <summary>
        /// Получить матрицу смежности.
        /// </summary>
        /// <returns>Матрица.</returns>
        public int[,] GetMatrix()
        {
            var matrix = new int[Vertexes.Count, Vertexes.Count];

            foreach (var edge in Edges)
            {
                var row = edge.From.Number - 1;
                var column = edge.To.Number - 1;

                matrix[row, column] = edge.Weight;
            }

            return matrix;
        }

        /// <summary>
        /// Получить список вершин.
        /// </summary>
        /// <param name="vertex">Вершина.</param>
        /// <returns>Список.</returns>
        public List<Vertex> GetVetexLists(Vertex vertex)
        {
            var result = new List<Vertex>();

            foreach (var edge in Edges)
            {
                if (edge.From == vertex)
                {
                    result.Add(edge.To);
                }
            }

            return result;
        }

        /// <summary>
        /// Получить волновой элемент.
        /// </summary>
        /// <param name="start">Начальная вершина.</param>
        /// <param name="finish">Конечная вершина.</param>
        /// <returns>Головной элемент.</returns>
        public bool Wave(Vertex start, Vertex finish)
        {
            var list = new List<Vertex>
            {
                start
            };

            for (int i = 0; i < list.Count; i++)
            {
                var vertex = list[i];
                foreach (var v in GetVetexLists(vertex))
                {
                    if (!list.Contains(v))
                    {
                        list.Add(v);
                    }
                }
            }

            return list.Contains(finish);
        }
    }
}
