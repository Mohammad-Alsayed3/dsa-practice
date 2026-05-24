using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Operations.Leet_Code.Problems.Two_Pointers
{
    internal class TwoSum_II
    {
        // 167. Two Sum II
        // https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
        // Difficulty: Medium | Topic: Two Pointers
        // Time: O(n) | Space: O(1)

        // Approach:
        // Set 2 pointers, one at the beginning and one at the end.
        // Check if the sum of both elements is larger, smaller, or equal to target.
        // If larger, move the right pointer inwards.
        // If smaller, move the left pointer inwards.
        // If equal, return the current indices (1-indexed).

        public int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                if (numbers[left] + numbers[right] > target)
                {
                    right -= 1;
                }
                else if (numbers[left] + numbers[right] < target)
                {
                    left += 1;
                }
                else
                {
                    result = [left + 1, right + 1];
                    break;
                }
            }

            return result;
        }
    }
}
