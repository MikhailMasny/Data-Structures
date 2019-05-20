using System;

namespace DataStructures.BL.Graph
{
    /// <summary>
    /// Класс с вариантами Graph.
    /// </summary>
    public class GraphRun
    {
        /// <summary>
        /// Демонстрация работы Graph.
        /// </summary>
        public void Graph()
        {
            var graph = new Graph();

            Console.WriteLine($"Graph - VertexCount: {graph.VertexCount}");
            Console.WriteLine($"Graph - EdgeCount: {graph.EdgeCount}");

            var v1 = new Vertex(1);
            var v2 = new Vertex(2);
            var v3 = new Vertex(3);
            var v4 = new Vertex(4);
            var v5 = new Vertex(5);
            var v6 = new Vertex(6);
            var v7 = new Vertex(7);

            graph.AddVertex(v1);
            graph.AddVertex(v2);
            graph.AddVertex(v3);
            graph.AddVertex(v4);
            graph.AddVertex(v5);
            graph.AddVertex(v6);
            graph.AddVertex(v7);

            graph.AddEdge(v1, v2);
            graph.AddEdge(v1, v3);
            graph.AddEdge(v3, v4);
            graph.AddEdge(v2, v5);
            graph.AddEdge(v2, v6);
            graph.AddEdge(v6, v5);
            graph.AddEdge(v5, v6);

            Console.WriteLine($"Graph - VertexCount: {graph.VertexCount}");
            Console.WriteLine($"Graph - EdgeCount: {graph.EdgeCount}");

            Console.WriteLine();

            GetMatrix(graph);

            Console.WriteLine("\n");

            Console.WriteLine("Graph paths:");
            GetVertex(graph, v1);
            GetVertex(graph, v2);
            GetVertex(graph, v3);
            GetVertex(graph, v4);
            GetVertex(graph, v5);
            GetVertex(graph, v6);
            GetVertex(graph, v7);

            Console.WriteLine();

            Console.WriteLine("Graph waves:");
            Console.WriteLine(graph.Wave(v1, v5));
            Console.WriteLine(graph.Wave(v2, v4));
        }

        private static void GetVertex(Graph graph, Vertex vertex)
        {
            Console.Write($"{vertex.Number}: ");
            foreach (var v in graph.GetVetexLists(vertex))
            {
                Console.Write($"{v.Number} ");
            }
            Console.WriteLine();
        }

        private static void GetMatrix(Graph graph)
        {
            Console.WriteLine("Matrix:");

            int[,] matrix = graph.GetMatrix();
            for (int i = 0; i < graph.VertexCount; i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < graph.VertexCount; j++)
                {
                    Console.Write($" | {matrix[i, j]} | ");
                }
                Console.WriteLine();
            }

            Console.Write("\nVertices:");
            for (int i = 0; i < graph.VertexCount; i++)
            {
                Console.Write($" | {i + 1} | ");
            }
        }
    }
}
