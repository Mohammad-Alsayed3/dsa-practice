using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Operations.Leet_Code.Stack
{
    // 20. Valid Parentheses
    // https://leetcode.com/problems/valid-parentheses/
    // Difficulty: Easy | Topic: Stack
    // Time: O(n) | Space: O(n)

    // Approach:
    // Use a stack to track opening brackets.
    // For each closing bracket, check if it matches the top of the stack.
    // At the end, stack must be empty for the string to be valid.

    internal class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Dictionary<char, char> mappings = new Dictionary<char, char>
            {
            { '}', '{' },
            { ')', '(' },
            { ']', '[' },
            };
            Stack<char> stack = new Stack<char>();
            char[] letters = s.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == '{' || letters[i] == '[' || letters[i] == '(')
                {
                    stack.Push(letters[i]);
                }
                else if (letters[i] == '}' || letters[i] == ']' || letters[i] == ')')
                {
                    if (stack.Count == 0 || stack.Peek() != mappings[letters[i]])
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }
            return stack.Count == 0;
        }
    }
}
