using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Game
    {

    
        public void Run()
        {

            int[] numbers = new int[] { 1, 2, 3, 4 };

            numbers = AppendToArray(numbers, 5);



        }
        
        int[] AppendToArray(int[] arr, int value)
        {
            //Create a new array with one more slot than the older one
            int[] tempArray = new int[arr.Length + 1];

            //Copy the values from the old array into the new array
            for (int i = 0; i < arr.Length; i++)
            {
                tempArray[i] = arr[i];
            }

            tempArray[tempArray.Length - 1] = value;

            return tempArray;
        }






    }
}
