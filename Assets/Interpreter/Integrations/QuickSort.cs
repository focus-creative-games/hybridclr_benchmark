using BenchmarkTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Benchmarks
{
    class QuickSort
    {
        static public int Partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        static public void quickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
        }

        public QuickSort()
        {
            int n = 20_0000;
            _arr = new int[n];

            var r = new Random(0);
            for(int i = 0; i < n; i++)
            {
                _arr[i] = r.Next();
            }
        }

        int[] _arr;

        [Benchmark]
        public void Run()
        {
            quickSort(_arr, 0, _arr.Length - 1);
        }
    }

}
