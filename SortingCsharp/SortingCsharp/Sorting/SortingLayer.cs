using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCsharp.Sorting
{
    public class SortingLayer
    {

        //Selection Sorting 
        public int[] SelectionSort(int[] data)
        {
            for (int i = 0; i < data.Length-1; i++)
            {
                for (int j = i + 1; j < data.Length-1; j++)
                {
                    if (data[i] > data[j])
                    {
                        Swap(data, i, j);
                    }
                }
            }

            return data;
        }

        //bubble sort 
        public int[] BubbleSort(int[] data)
        {

            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = 0; j < data.Length - i - 1; j++)
                    if (data[j] > data[j + 1])
                    {
                        // swap temp and arr[i] 
                        Swap(data, j, j + 1);
                    }
            }

            return data;
        }

        public int[] BubbleSortTwo(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                bool swapped = false;
                for (int j = data.Length - 1; j > i; j--)
                {
                    if (data[j] < data[j - 1])
                    {
                        Swap(data, j, j - 1);
                        swapped = true;
                    }
                }
               
                if (!swapped)
                {
                    break;
                }
            }


            return data;
        }

        //insertion sort 
        public int[] InsertionSort(int[] data)
        {
            int n = data.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = data[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key,  
                // to one position ahead of 
                // their current position 
                while (j >= 0 && data[j] > key)
                {
                    data[j + 1] = data[j];
                    j = j - 1;
                }
                data[j + 1] = key;
            }

            return data;
        }

        public int[] InsertionSortTwo(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (data[j] < data[j - 1])
                    {
                        Swap(data, j, j - 1);
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }

            return data;
        }

        public static void insertionShellSort(int[] data, int startIndex, int increment)
        {
            for (int i = startIndex; i < data.Length; i = i + increment)
            {
                for (int j = Math.Min(i + increment, data.Length - 1);
                    j - increment >= 0;
                    j = j - increment)
                {
                    if (data[j] < data[j - increment])
                    {
                        Swap(data, j, j - increment);
                    }
                    else
                    {
                        break;
                    }
                   
                }
            }
        }

        public int[]  ShellSort(int[] data)
        {
            int increment = data.Length / 2;
            while (increment >= 1)
            {
                for (int startIndex = 0; startIndex < increment; startIndex++)
                {
                    insertionShellSort(data, startIndex, increment);
                }

                increment = increment / 2;
            }

            return data;
        }

        public int[] ShellSortTwo(int[] data)
        {
            int n = data.Length;
            int gap = n / 2;
            int temp;

            while (gap > 0)
            {
                for (int i = 0; i + gap < n; i++)
                {
                    int j = i + gap;
                    temp = data[j];

                    while (j - gap >= 0 && temp < data[j - gap])
                    {
                        data[j] = data[j - gap];
                        j = j - gap;
                    }

                    data[j] = temp;
                }

                gap = gap / 2;
            }

            return data;
        }

        public static void Swap(int[] data,int first, int second)
        {
            int temporary = data[first];
            data[first] = data[second];
            data[second] = temporary;
        }

    }

   


    
}
