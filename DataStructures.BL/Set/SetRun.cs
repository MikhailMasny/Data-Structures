using System;

namespace DataStructures.BL.Set
{
    /// <summary>
    /// Класс с вариантами Set.
    /// </summary>
    public class SetRun
    {
        private void DisplayResult(EasySet<int> easySet)
        {
            foreach (var set in easySet)
            {
                Console.Write($"{set} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Демонстрация работы EasySet.
        /// </summary>
        public void EasySet()
        {
            var easyset1 = new EasySet<int>(new int[] { 1, 2, 3, 4, 5 });
            var easyset2 = new EasySet<int>(new int[] { 4, 5, 6, 7, 8 });
            var easyset3 = new EasySet<int>(new int[] { 3, 4, 5 });

            Console.WriteLine("Basic strings:");
            DisplayResult(easyset1);
            DisplayResult(easyset2);
            DisplayResult(easyset3);

            Console.Write("Union: ");
            DisplayResult(easyset1.Union(easyset2));

            Console.Write("Intersection: ");
            DisplayResult(easyset1.Intersection(easyset2));

            Console.Write("Difference A \\ B: ");
            DisplayResult(easyset1.Difference(easyset2));

            Console.Write("Difference B \\ A: ");
            DisplayResult(easyset2.Difference(easyset1));

            Console.Write("A Subset C: ");
            Console.Write($"{easyset1.Subset(easyset3)} \n");

            Console.Write("C Subset A: ");
            Console.Write($"{easyset3.Subset(easyset1)} \n");

            Console.Write("C Subset B: ");
            Console.Write($"{easyset1.Subset(easyset3)} \n");

            Console.Write("Symmetric Difference: ");
            DisplayResult(easyset1.SymmetricDifference(easyset2));
        }
    }
}
