using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partOne
{
    internal class SelectSort
    {
        private List<int> list { get; set; }

        public SelectSort(List<int> list)
        {
            this.list = list;
        }

        public List<int> Sort()
        {
            int n = list.Count;

            for (int i = 0; i < n - 1; i++)
            {
                // Находим минимальный элемент в неотсортированной части массива
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (list[j] < list[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Меняем найденный минимальный элемент с первым элементом неотсортированной части
                if (minIndex != i)
                {
                    int temp = list[i];
                    list[i] = list[minIndex];
                    list[minIndex] = temp;
                }
            }
            return list;
        }

        public List<int> Sort(int n)
        {

            for (int i = 0; i < n - 1; i++)
            {
                // Находим минимальный элемент в неотсортированной части массива
                int minIndex = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Меняем найденный минимальный элемент с первым элементом неотсортированной части
                if (minIndex != i)
                {
                    int temp = list[i];
                    list[i] = list[minIndex];
                    list[minIndex] = temp;
                }
            }
            return list;
        }
    }
}
