using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Game
    {

    
        public void Run()
        {
            int[] arr = {20, 40, 12, 100, 15};
            PrintArray(arr);
            PrintSmallestAndLargest(arr);

        }

        void PrintArray(int[] arr)
        {

            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }

        void PrintSmallestAndLargest(int[] arr)
        {
            int largest = arr[0];
            int smallest = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }

                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }

            Console.WriteLine("Largest: " + largest);
            Console.WriteLine("Smallest: " + smallest);

        }






    }
}
