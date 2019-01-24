using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingCsharp.Sorting;

namespace SortingCsharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] data = {2, 4, 3, 6, 1, 7};
            SortingLayer objLayer = new SortingLayer();
            // var newObj= objLayer.SelectionSort(data);

            // var newObj = objLayer.BubbleSortTwo(data);
            // var newObj = objLayer.InsertionSort(data);
            // var newObj = objLayer.InsertionSortTwo(data);

            var newObj = objLayer.ShellSortTwo(data);
            for (int i = 0; i < newObj.Length; i++)
            {
                Console.WriteLine(newObj[i]);
            }

            Console.ReadLine();
        }
    }
}
