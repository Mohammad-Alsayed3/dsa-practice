using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Operations.DS
{
    public class DynamicArray<T>
    {
        T[] arr;
        int counter;
        public DynamicArray(int size)
        {
            arr = new T[size];
            counter = 0;
        }
        public void Add(T value)
        {
            if (counter == arr.Length)
                Resize();
            arr[counter] = value;
            counter++;
        }
        public void Resize()
        {
            T[] newArr = new T[arr.Length*2];
            for (int i = 0; i < counter; i++)
                newArr[i] = arr[i];
            arr = newArr;
        }
        public void Remove()
        {
            arr[counter - 1] = default;
            counter--;
        }
        public int Size()
        {
            return counter;
        }
        public void Display()
        {
            for (int i = 0; i < counter; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\n");
        }
        public void InsertAtIndex(int index, T value  )
        {
            if (counter == arr.Length)
                Resize();
            for (int i = counter; i > index; i--)
                arr[i] = arr[i - 1];
            arr[index] = value;
            counter++;
        }
        public void RemoveFromIndex(int index)
        {
            for (int i = index; i < counter; i++)
                arr[i] = arr[i + 1];
            counter--;
            arr[counter] = default;
        }
        public bool IsFull()
        {
            return counter == arr.Length;
        }
        public bool Search(T value)
        {
            for (int i = 0; i < counter; i++)
            {
                if (arr[i].Equals(value))
                    return true; 
            }
            return false;
        }
    }
}
