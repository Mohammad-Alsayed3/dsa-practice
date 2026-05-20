using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Operations.DS
{
    public class MyHashSet
    {
        List<int>[] buckets; // array of lists: {list1, list2}
        public MyHashSet()
        {
            buckets = new List<int>[10]; // 10 lists are all null

            for (int i = 0; i < buckets.Length; i++) // Initializing the Lists
            {
                buckets[i] = new List<int>();
            }
        }
        public int Hash(int key)
        {
            return Math.Abs(key) % buckets.Length;
        }
        public void Add(int key)
        {
            int Index = Hash(key);
            if(!buckets[Index].Contains(key))
                buckets[Index].Add(key);
        }
        public bool Contains(int key)
        {
            //int Index = Hash(key);
            //if (buckets[Index].Contains(key))
            //    return true;
            //return false;

            // Or
            return buckets[Hash(key)].Contains(key);
        }
        public void Remove(int key)
        {
            buckets[Hash(key)].Remove(key); // List.Remove returns bool, if the key isn't there, it won't do anything
        }
    }
}
