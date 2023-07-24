using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithFabric
{
    public interface SortingAlgorithm
    {
        void Sort(int[] arr);
    }

    public class SelectionSort : SortingAlgorithm
    {
        public void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }

    }

    public class InsertionSort : SortingAlgorithm
    {
        public void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }
        }

    }

    public class MergeSort : SortingAlgorithm
    {
        public void Sort(int[] arr)
        {
            MergeSortMethod(arr, 0, arr.Length - 1);
        }

        private void MergeSortMethod(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSortMethod(arr, left, mid);
                MergeSortMethod(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        private void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = arr[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = arr[mid + 1 + j];

            int k = left;
            int leftIdx = 0;
            int rightIdx = 0;

            while (leftIdx < n1 && rightIdx < n2)
            {
                if (leftArray[leftIdx] <= rightArray[rightIdx])
                {
                    arr[k] = leftArray[leftIdx];
                    leftIdx++;
                }
                else
                {
                    arr[k] = rightArray[rightIdx];
                    rightIdx++;
                }
                k++;
            }

            while (leftIdx < n1)
            {
                arr[k] = leftArray[leftIdx];
                leftIdx++;
                k++;
            }

            while (rightIdx < n2)
            {
                arr[k] = rightArray[rightIdx];
                rightIdx++;
                k++;
            }
        }

    }

}
