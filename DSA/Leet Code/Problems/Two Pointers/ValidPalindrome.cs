using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Operations.Leet_Code.Two_Pointers
{
    // 125. Valid Palindrome
    // https://leetcode.com/problems/valid-palindrome/
    // Difficulty: Easy | Topic: Two Pointers
    // Time: O(n) | Space: O(n)

    // Approach:
    // Clean the string by keeping only alphanumeric characters using
    // StringBuilder (for efficiency) and convert to lowercase.
    // Set two pointers at the start and end, moving inward.
    // If both elements match, move pointers inward. If they don't, return false.
    // If pointers meet, return true.

    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                    sb.Append(c);
            }
            string cleanText = sb.ToString().ToLower();

            int left = 0;
            int right = cleanText.Length - 1;

            while (left < right)
            {
                if (cleanText[left] != cleanText[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
