using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
       int[] arr = { 5, 10, 9, 3, 6, 11, 2 , 11, 8, 15 };
            int arr_size = arr.Length;

            printRepeating(arr, arr_size);
        }
        static void printRepeating(int[] arr, int size)
        {
            int i, j;

            Console.WriteLine("Repeated Elements are :");
            for (i = 0; i < size; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                      Console.WriteLine(arr[i] + " ");
              }
          }
       }
    }
}