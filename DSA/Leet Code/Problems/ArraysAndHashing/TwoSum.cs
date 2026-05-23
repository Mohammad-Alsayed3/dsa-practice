using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Array_Operations.Leet_Code.Problems.ArraysAndHashing
{
    // 1. Two Sum
    // https://leetcode.com/problems/two-sum/
    // Difficulty: Easy | Topic: Arrays & Hashing
    // Time: O(n) | Space: O(n)

    // Approach:
    // Use a dictionary to make use of instant lookup.
    // Iterate over the array and if the current complement exists
    // in the dictionary, return its index and the current index.
    // Otherwise add the current element and its index to the dictionary.

    public class TwoSum
    {
        public int[] TwoSums(int[] nums, int target)
        {
            Dictionary<int,int> dic = new Dictionary<int,int>();
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dic.ContainsKey(complement))
                {
                    result = [dic[complement], i];
                }
                else
                    dic.TryAdd(nums[i], i);
            }
            return result;
        }
    }
}
