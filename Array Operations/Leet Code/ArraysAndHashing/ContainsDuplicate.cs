using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Operations.Leet_Code.HashSet
{
    // 217. Contains Duplicate
    // https://leetcode.com/problems/contains-duplicate/
    // Difficulty: Easy | Topic: Arrays & Hashing & Sorting
    // Time: O(n) | Space: O(n)

    // Approach:
    // Check if the element already exists in the set.
    // If yes, return true. If no, add it to the set
    // so future elements can be checked against it.

    // Imrpovments:
    // 1. if [(!set.Add(nums[i])) -> return true;] For cleaner code

    internal class ContainsDuplicate
    {
        public static bool IsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.Contains(nums[i]))
                    set.Add(nums[i]);
                else
                    return true;
            }
            return false;
        }
    }
}
