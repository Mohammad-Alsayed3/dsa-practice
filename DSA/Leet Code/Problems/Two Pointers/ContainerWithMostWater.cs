using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Operations.Leet_Code.Problems.Two_Pointers
{
    // 11. Container With Most Water
    // https://leetcode.com/problems/container-with-most-water/
    // Difficulty: Medium | Topic: Two Pointers
    // Time: O(n) | Space: O(1)

    // Approach:
    // Set 2 pointers at the two ends of the array.
    // Calculate the area at each position.
    // If the height of the right pointer is less than the left, move right inward.
    // Otherwise move left inward. Track the maximum area seen.

    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int area = 0;

            while (left < right)
            {
                area = Math.Max((right - left) * Math.Min(height[right], height[left]), area);

                if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return area;
        }


        // Initial Solution (Forgot about Math.Max)

        //public int MaxArea(int[] height)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    int left = 0;
        //    int right = height.Length - 1;
        //    int area = 0;

        //    while (left < right)
        //    {
        //        area = (right - left) * Math.Min(height[right], height[left]);
        //        if (stack.Count == 0 || area > stack.Peek())
        //        {
        //            stack.Push(area);

        //        }
        //        if (height[left] > height[right])
        //        {
        //            right--;
        //        }
        //        else
        //        {
        //            left++;
        //        }
        //    }
        //    return stack.Pop();
        //}
    }
}
