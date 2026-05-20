using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Operations.DS
{
    public class MyArray
    {
        int[] arr;
        int counter;
        public MyArray()
        {
            this.arr = new int[7];
            counter = 0;
        }
        public void Append(int value)
        {
            if(counter == arr.Length)
            {
                Console.WriteLine("The Array is full!");
                return;
            }
            arr[counter++] = value;
        }
        public void Display()
        {
            for (int i = 0; i < counter; i++)
            {
                Console.Write(arr.Length);
            }
        }
        public bool Search(int value)
        {
            for (int i = 0; i < counter; i++)
            {
                if(arr[i] == value)
                    return true;
            }
            return false;
        }
        public void InsertAt(int index, int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Already Full");
                return;
            }
            for (int i = counter; i > index; i--)
            {
                    arr[i] = arr[i - 1];
            }
            arr[index] = value;
            counter++;
        }
        public bool IsFull()
        {
            return counter == arr.Length;
        }
        public void Delete(int index)
        {
            for (int i = index; i < counter - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            counter--;
            arr[counter] = default;
        }
        public void Enlarge(int newSize)
        {
            if(newSize > arr.Length)
            {
                int[] newArr = new int[newSize];
                for (int i = 0; i < counter; i++)
                {
                    newArr[i] = arr[i];
                }
                arr = newArr;
            }
        }
    }
}
