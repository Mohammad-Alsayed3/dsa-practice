using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Operations.Leet_Code.Stack
{
    // 739. Daily Temperatures
    // https://leetcode.com/problems/daily-temperatures/
    // Difficulty: Medium | Topic: Stack (Monotonic Stack)
    // Time: O(n) | Space: O(n)

    // Approach:
    // We use a stack to store previous days(as indices).
    // When we find a warmer temperature, we pop the index and use it
    // to calculate and set the answer for that day.
    // Any index left in the stack at the end stays 0 (no warmer day found).


    public class DailyTemperatures
    {
        public int[] DailyTemperature(int[] temperatures)
        {
            Stack<int> stack = new Stack<int>();
            int[] answers = new int[temperatures.Length];

            for (int i = 0; i < temperatures.Length; i++)
            {
                while (stack.Count != 0 && temperatures[i] > temperatures[stack.Peek()])
                {
                    int prevIndex = stack.Pop();
                    answers[prevIndex] = i - prevIndex;
                }

                stack.Push(i);
            }
            return answers;
        }


        // O(n^2) Solution 

        //public int[] DailyTemperature(int[] temperatures)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    int[] answers = new int[temperatures.Length];

        //    for (int i = 0; i < temperatures.Length; i++)
        //    {
        //        stack.Push(i);
        //        for (int k = i + 1; k < temperatures.Length; k++)
        //        {
        //            if (temperatures[k] > temperatures[stack.Peek()])
        //            {
        //                answers[stack.Peek()] = k - stack.Peek();
        //                break;
        //            }
        //            answers[stack.Peek()] = 0;
        //        }
        //        stack.Pop();
        //    }
        //    return answers;
        //}
    }
}
