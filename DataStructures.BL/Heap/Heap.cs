using System.Collections;
using System.Collections.Generic;

namespace DataStructures.BL.Heap
{
    /// <summary>
    /// Куча (Heap).
    /// </summary>
    public class ImplementedHeap : IEnumerable
    {
        private List<int> items = new List<int>();

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count => items.Count;

        /// <summary>
        /// Пустой конструктор.
        /// </summary>
        public ImplementedHeap() { }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="items">Элементы.</param>
        public ImplementedHeap(List<int> items)
        {
            this.items.AddRange(items);
            for (int i = Count; i >= 0; i--)
            {
                Sort(i);
            }
        }

        /// <summary>
        /// Получить элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public int? Peek()
        {
            if (Count > 0)
            {
                return items[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Добавить элемент.
        /// </summary>
        /// <param name="item">Элемент.</param>
        public void Add(int item)
        {
            items.Add(item);

            var currentIndex = Count - 1;
            var parentIndex = GetParentIndex(currentIndex);

            while (currentIndex > 0 && items[parentIndex] < items[currentIndex])
            {
                Swap(currentIndex, parentIndex);

                currentIndex = parentIndex;
                parentIndex = GetParentIndex(currentIndex);
            }
        }

        /// <summary>
        /// Получить максимальный элемент.
        /// </summary>
        /// <returns></returns>
        public int GetMax()
        {
            var result = items[0];
            items[0] = items[Count - 1];
            items.RemoveAt(Count - 1);
            Sort(0);
            return result;
        }

        private void Sort(int curentIndex)
        {
            int maxIndex = curentIndex;
            int leftIndex;
            int rightIndex;

            while (curentIndex < Count)
            {
                leftIndex = 2 * curentIndex + 1;
                rightIndex = 2 * curentIndex + 2;

                if (leftIndex < Count && items[leftIndex] > items[maxIndex])
                {
                    maxIndex = leftIndex;
                }

                if (rightIndex < Count && items[rightIndex] > items[maxIndex])
                {
                    maxIndex = rightIndex;
                }

                if (maxIndex == curentIndex)
                {
                    break;
                }

                Swap(curentIndex, maxIndex);
                curentIndex = maxIndex;
            }
        }

        private void Swap(int currentIndex, int parentIndex)
        {
            int temp = items[currentIndex];
            items[currentIndex] = items[parentIndex];
            items[parentIndex] = temp;
        }

        private int GetParentIndex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        public IEnumerator GetEnumerator()
        {
            while (Count > 0)
            {
                yield return GetMax();
            }
        }
    }
}
