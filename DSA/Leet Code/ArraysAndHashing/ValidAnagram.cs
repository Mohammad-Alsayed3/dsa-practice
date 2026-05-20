using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Operations.Leet_Code.ArraysAndHashing
{
    // 242. Valid Anagram
    // https://leetcode.com/problems/valid-anagram/
    // Difficulty: Easy | Topic: Arrays & Hashing
    // Time: O(n) | Space: O(1)
    // (Space is O(1) because the dictionary holds at most 26 characters)

    // Approach:
    // Count the frequency of each character in the first string using a dictionary.
    // Then for each character in the second string, decrement its count.
    // If a character doesn't exist or its count is already 0, return false.
    // If both strings have different lengths, return false immediately.

    internal class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            string firstWord = s.Trim().ToLower();
            string secondWord = t.Trim().ToLower();
            if (firstWord.Length == secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    if (dic.ContainsKey(firstWord[i]))
                        dic[firstWord[i]]++;
                    else
                        dic.Add(firstWord[i], 1);
                }
                for (int i = 0; i < secondWord.Length; i++)
                {
                    if (dic.ContainsKey(secondWord[i]))
                    {
                        if (dic[secondWord[i]] == 0)
                            return false;
                        else
                            dic[secondWord[i]]--;
                    }
                    else
                        return false;
                }
                return true;
            }
            return false;
        }
    }
}
