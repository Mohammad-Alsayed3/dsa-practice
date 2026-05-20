using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Operations.DS
{
    public class MyStack
    {
        int counter;
        int[] arr;
        int minValue;
        int[] minVals;
        public MyStack(int size)
        {
            counter = 0;
            arr = new int[size];
            minValue = arr[0];
            minVals = new int[arr.Length];
        }
        public void Push(int val)
        {
            if (counter == arr.Length)
                Console.WriteLine("No More Space!");

            arr[counter++] = val;
            if (minValue > arr[counter - 1])
                minVals[counter - 1]= arr[counter - 1];
        }
        public void Pop()
        {
            if (counter == 0)
                Console.WriteLine("No enough items!");
            counter--;
            arr[counter] = default;
            
        }
        public int Top()
        {
            return arr[counter - 1];
        }
        public int GetMin()
        {
            return minValue;
        }
        public void Display()
        {
            for (int i = 0; i < counter; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
